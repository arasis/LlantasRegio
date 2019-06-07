
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Xml
Imports System.Xml.Schema
Imports System.Xml.XPath
Imports System.Xml.Xsl
Imports System.IO
Imports System.Windows.Forms
Imports System.Security.Cryptography
Imports System.Security.Cryptography.X509Certificates

Public Class CrearXML
    Public Const _Namespaceuri As String = "http://www.sat.gob.mx/cfd/3"
    Public Const _NamespaceCfdi As String = "http://www.sat.gob.mx/nomina12 http://www.sat.gob.mx/sitio_internet/cfd/nomina/nomina12.xsd"
    Public Const _NamespaceCfdiNomina As String = "http://www.sat.gob.mx/nomina12"
    Public Const _NamespaceCfdiPagos As String = "http://www.sat.gob.mx/Pagos"
    Public Const _NamespaceGastosHidrocarburos As String = "http://www.sat.gob.mx/GastosHidrocarburos10"
    Public Const _NamespaceVentaVehiculos As String = "http://www.sat.gob.mx/ventavehiculos"
    Private Const _NamespaceXsi As String = "http://www.sat.gob.mx/cfd/3 http://www.sat.gob.mx/sitio_internet/cfd/3/cfdv3.xsd"
    Private Const _SchemaLocation As String = "http://www.sat.gob.mx/cfd/3 http://www.sat.gob.mx/sitio_internet/cfd/3/cfdv33.xsd"
    Private Const _ShemaLocationNomina As String = "http://www.sat.gob.mx/nomina12 http://www.sat.gob.mx/sitio_internet/cfd/nomina/nomina12.xsd"
    Private Const _ShemaLocationPagos As String = "http://www.sat.gob.mx/Pagos http://www.sat.gob.mx/sitio_internet/cfd/Pagos/Pagos10.xsd"
    Private Const _ShemaLocationGastosHidrocarburos As String = "http://www.sat.gob.mx/GastosHidrocarburos10 http://www.sat.gob.mx/sitio_internet/cfd/GastosHidrocarburos10/GastosHidrocarburos10.xsd"
    Private Const _ShemaLocationVentaVehiculos As String = "http://www.sat.gob.mx/sitio_internet/cfd/ventavehiculos/ventavehiculos11.xsd"
    Private Const _rutaXslt As String = ".\XSLT\cadenaoriginal_3_3.xslt"
    ' Private Const _rutaXslt As String = ".\cadenaoriginal_3_3.xslt"
    Private Shared m_xmlDOM As XmlDocument = New XmlDocument()
    Private _comprobante As Comprobante

    Public Sub Create(ByVal c As Comprobante, ByVal rutaXML As String, ByVal rutaPFX As String, ByVal passwordPFX As String, ByVal rutaCertificado As String)
        _comprobante = c
        Dim certificado, nocertificado As String
        certificado = String.Empty
        nocertificado = String.Empty
        ObtenerCerticicadoYNoCertificado(rutaCertificado, certificado, nocertificado)
        _comprobante.Certificado = certificado
        _comprobante.NoCertificado = nocertificado
        Dim xmlComprobante As XmlElement
        m_xmlDOM = CrearDOM()
        xmlComprobante = CrearNodoComprobante()
        m_xmlDOM.AppendChild(xmlComprobante)
        IndentarNodo(xmlComprobante)
        xmlComprobante.SetAttribute("Sello", ObtenerSello1(rutaPFX, passwordPFX))
        m_xmlDOM.InnerXml = m_xmlDOM.InnerXml.Replace("schemaLocation", "xsi:schemaLocation").ToString()
        m_xmlDOM.Normalize()
        m_xmlDOM.Save(rutaXML)
    End Sub
    Private Shared Function CrearDOM() As XmlDocument
        Dim oDOM As XmlDocument = New XmlDocument()
        Dim Nodo As XmlNode
        Nodo = oDOM.CreateProcessingInstruction("xml", "version='1.0' encoding='utf-8'")
        oDOM.AppendChild(Nodo)
        Return oDOM
    End Function
    Private Function CrearNodoComprobante() As XmlElement
        Dim Comprobante As XmlElement
        Comprobante = m_xmlDOM.CreateElement("cfdi", "Comprobante", _Namespaceuri)
        CrearAtributosComprobante(Comprobante)
        Comprobante.AppendChild(CrearNodoEmisor())
        Comprobante.AppendChild(CrearNodoReceptor())
        If CrearNodoConceptos() IsNot Nothing Then Comprobante.AppendChild(CrearNodoConceptos())
        If CrearNodoImpuestos() IsNot Nothing Then Comprobante.AppendChild(CrearNodoImpuestos())
        If CrearNodoGastosHidrocarburos() IsNot Nothing Then Comprobante.AppendChild(CrearNodoGastosHidrocarburos())
        If _comprobante.TipoDeComprobante = "N" Then Comprobante.AppendChild(CrearNodoNomina())
        If _comprobante.TipoDeComprobante = "P" Then Comprobante.AppendChild(CrearNodoPagos())
        Return Comprobante
    End Function
    Private Function CrearNodoPagos() As XmlElement

        Dim complemento As XmlElement
        complemento = m_xmlDOM.CreateElement("cfdi", "Complemento", _Namespaceuri)
        Dim Pagos As XmlElement = m_xmlDOM.CreateElement("pago10", "Pagos", _NamespaceCfdiPagos)
        'Pagos.SetAttribute("xsi:schemaLocation", _ShemaLocationNomina)
        Pagos.SetAttribute("Version", _comprobante.Complemento.Pagos.Version)
        If _comprobante.Complemento.Pagos.Pagos.Count > 0 Then
            For Each pago As Pago In _comprobante.Complemento.Pagos.Pagos
                Dim xpago As XmlElement = m_xmlDOM.CreateElement("pago10", "Pago", _NamespaceCfdiPagos)
                If pago.FechaPago <> String.Empty Then xpago.SetAttribute("FechaPago", pago.FechaPago)
                If pago.FormaDePagoP <> String.Empty Then xpago.SetAttribute("FormaDePagoP", pago.FormaDePagoP)
                If pago.MonedaP <> String.Empty Then xpago.SetAttribute("MonedaP", pago.MonedaP)
                If pago.TipoCambioP <> 0 Then xpago.SetAttribute("TipoCambioP", pago.TipoCambioP.ToString("F2"))
                xpago.SetAttribute("Monto", pago.Monto.ToString("F2"))
                If pago.NumOperacion <> String.Empty Then xpago.SetAttribute("NumOperacion", pago.NumOperacion)
                If pago.RfcEmisorCtaOrd <> String.Empty Then xpago.SetAttribute("RfcEmisorCtaOrd", pago.RfcEmisorCtaOrd)
                If pago.NomBancoOrdExt <> String.Empty Then xpago.SetAttribute("NomBancoOrdExt", pago.NomBancoOrdExt)
                If pago.CtaOrdenante <> String.Empty Then xpago.SetAttribute("CtaOrdenante", pago.CtaOrdenante)
                If pago.RfcEmisorCtaBen <> String.Empty Then xpago.SetAttribute("RfcEmisorCtaBen", pago.RfcEmisorCtaBen)
                If pago.CtaBeneficiario <> String.Empty Then xpago.SetAttribute("CtaBeneficiario", pago.CtaBeneficiario)
                If pago.TipoCadPago <> String.Empty Then xpago.SetAttribute("TipoCadPago", pago.TipoCadPago)
                If pago.CertPago <> String.Empty Then xpago.SetAttribute("CertPago", pago.CertPago)
                If pago.CadPago <> String.Empty Then xpago.SetAttribute("CadPago", pago.CadPago)
                If pago.SelloPago <> String.Empty Then xpago.SetAttribute("SelloPago", pago.SelloPago)
                For Each dr As DoctoRelacionado In pago.DoctoRelacionado
                    Dim xDR As XmlElement = m_xmlDOM.CreateElement("pago10", "DoctoRelacionado", _NamespaceCfdiPagos)
                    If dr.IdDocumento <> String.Empty Then xDR.SetAttribute("IdDocumento", dr.IdDocumento)
                    If dr.Serie <> String.Empty Then xDR.SetAttribute("Serie", dr.Serie)
                    If dr.Folio <> String.Empty Then xDR.SetAttribute("Folio", dr.Folio)
                    If dr.MonedaDR <> String.Empty Then xDR.SetAttribute("MonedaDR", dr.MonedaDR)
                    If dr.TipoCambioDR <> String.Empty Then xDR.SetAttribute("TipoCambioDR", dr.TipoCambioDR)
                    If dr.MetodoDePagoDR <> String.Empty Then xDR.SetAttribute("MetodoDePagoDR", dr.MetodoDePagoDR)
                    If dr.NumParcialidad <> String.Empty Then xDR.SetAttribute("NumParcialidad", dr.NumParcialidad)
                    If dr.ImpSaldoAnt <> 0 Then xDR.SetAttribute("ImpSaldoAnt", dr.ImpSaldoAnt.ToString("F2"))
                    If dr.ImpPagado <> 0 Then xDR.SetAttribute("ImpPagado", dr.ImpPagado.ToString("F2"))
                    If dr.ImpSaldoInsoluto <> 0 Then xDR.SetAttribute("ImpSaldoInsoluto", dr.ImpSaldoInsoluto.ToString("F2"))
                    xpago.AppendChild(xDR)
                Next

                If pago.Impuestos.Retenciones.Count > 0 OrElse _comprobante.Impuestos.Traslados.Count > 0 Then
                    Dim xImpuestos As XmlElement = m_xmlDOM.CreateElement("pago10", "Impuestos", _NamespaceCfdiPagos)
                    If pago.Impuestos.TotalImpuestosRetenidos > 0 Then xImpuestos.SetAttribute("TotalImpuestosRetenidos", pago.Impuestos.TotalImpuestosRetenidos.ToString("F2"))
                    If pago.Impuestos.TotalImpuestosTrasladados > 0 Then xImpuestos.SetAttribute("TotalImpuestosTrasladados", pago.Impuestos.TotalImpuestosTrasladados.ToString("F2"))
                    If pago.Impuestos.Retenciones.Count > 0 Then
                        Dim Retenciones As XmlElement = m_xmlDOM.CreateElement("cfdi", "Retenciones", _NamespaceCfdiPagos)
                        For Each r As Retencion In pago.Impuestos.Retenciones
                            Dim Retencion As XmlElement = m_xmlDOM.CreateElement("cfdi", "Retencion", _NamespaceCfdiPagos)
                            Retencion.SetAttribute("Impuesto", r.Impuesto.ToString())
                            Retencion.SetAttribute("Importe", r.Importe.ToString("F2"))
                            Retenciones.AppendChild(Retencion)
                        Next

                        xImpuestos.AppendChild(Retenciones)
                    End If

                    If pago.Impuestos.Traslados.Count > 0 Then
                        Dim Traslados As XmlElement = m_xmlDOM.CreateElement("cfdi", "Traslados", _NamespaceCfdiPagos)
                        For Each t As Traslado In pago.Impuestos.Traslados
                            Dim Traslado As XmlElement = m_xmlDOM.CreateElement("cfdi", "Traslado", _NamespaceCfdiPagos)
                            Traslado.SetAttribute("Impuesto", t.Impuesto.ToString())
                            Traslado.SetAttribute("Importe", t.Importe.ToString("F2"))
                            Traslado.SetAttribute("TasaOCuota", t.TasaOCuota.ToString("F6"))
                            Traslado.SetAttribute("TipoFactor", t.TipoFactor.ToString())
                            Traslados.AppendChild(Traslado)
                        Next

                        xImpuestos.AppendChild(Traslados)
                    End If

                    xpago.AppendChild(xImpuestos)
                End If

                Pagos.AppendChild(xpago)
            Next
        End If

        complemento.AppendChild(Pagos)
        Return complemento
    End Function
    Private Function CrearNodoNomina() As XmlElement
        Dim complemento As XmlElement
        complemento = m_xmlDOM.CreateElement("cfdi", "Complemento", _Namespaceuri)
        Dim nomina As XmlElement = m_xmlDOM.CreateElement("nomina12", "Nomina", _NamespaceCfdiNomina)
        nomina.SetAttribute("xsi:schemaLocation", _ShemaLocationNomina)
        nomina.SetAttribute("Version", _comprobante.Complemento.Nomina.Version)
        nomina.SetAttribute("TipoNomina", _comprobante.Complemento.Nomina.TipoNomina)
        nomina.SetAttribute("FechaPago", _comprobante.Complemento.Nomina.FechaPago)
        nomina.SetAttribute("FechaInicialPago", _comprobante.Complemento.Nomina.FechaInicialPago)
        nomina.SetAttribute("FechaFinalPago", _comprobante.Complemento.Nomina.FechaFinalPago)
        nomina.SetAttribute("NumDiasPagados", _comprobante.Complemento.Nomina.NumDiasPagados.ToString("F3"))
        If _comprobante.Complemento.Nomina.TotalPercepciones > 0 Then nomina.SetAttribute("TotalPercepciones", _comprobante.Complemento.Nomina.TotalPercepciones.ToString("F2"))
        If _comprobante.Complemento.Nomina.TotalDeducciones > 0 Then nomina.SetAttribute("TotalDeducciones", _comprobante.Complemento.Nomina.TotalDeducciones.ToString("F2"))
        If _comprobante.Complemento.Nomina.TotalOtrosPagos > 0 Then nomina.SetAttribute("TotalOtrosPagos", _comprobante.Complemento.Nomina.TotalOtrosPagos.ToString("F2"))
        Dim emisor As XmlElement = m_xmlDOM.CreateElement("nomina12", "Emisor", _NamespaceCfdiNomina)
        If _comprobante.Complemento.Nomina.Emisor.Curp <> String.Empty Then emisor.SetAttribute("Curp", _comprobante.Complemento.Nomina.Emisor.Curp)
        If _comprobante.Complemento.Nomina.Emisor.RegistroPatronal <> String.Empty Then emisor.SetAttribute("RegistroPatronal", _comprobante.Complemento.Nomina.Emisor.RegistroPatronal)
        If _comprobante.Complemento.Nomina.Emisor.RfcPatronOrigen <> String.Empty Then emisor.SetAttribute("RfcPatronOrigen", _comprobante.Complemento.Nomina.Emisor.RfcPatronOrigen)
        nomina.AppendChild(emisor)
        If _comprobante.Complemento.Nomina.Emisor.EntidadSNCF.OrigenRecurso <> String.Empty Then
            Dim entidadSNCF As XmlElement = m_xmlDOM.CreateElement("nomina12", "EntidadSNCF", _NamespaceCfdiNomina)
            entidadSNCF.SetAttribute("OrigenRecurso", _comprobante.Complemento.Nomina.Emisor.EntidadSNCF.OrigenRecurso)
            entidadSNCF.SetAttribute("MontoRecursoPropio", _comprobante.Complemento.Nomina.Emisor.EntidadSNCF.MontoRecursoPropio.ToString("F2"))
            emisor.AppendChild(entidadSNCF)
        End If

        Dim receptor As XmlElement = m_xmlDOM.CreateElement("nomina12", "Receptor", _NamespaceCfdiNomina)
        receptor.SetAttribute("Curp", _comprobante.Complemento.Nomina.Receptor.Curp)
        If _comprobante.Complemento.Nomina.Receptor.NumSeguridadSocial <> String.Empty Then receptor.SetAttribute("NumSeguridadSocial", _comprobante.Complemento.Nomina.Receptor.NumSeguridadSocial)
        If _comprobante.Complemento.Nomina.Receptor.FechaInicioRelLaboral <> String.Empty Then receptor.SetAttribute("FechaInicioRelLaboral", _comprobante.Complemento.Nomina.Receptor.FechaInicioRelLaboral)
        If _comprobante.Complemento.Nomina.Receptor.Antiguedad <> String.Empty Then receptor.SetAttribute("Antigüedad", _comprobante.Complemento.Nomina.Receptor.Antiguedad)
        receptor.SetAttribute("TipoContrato", _comprobante.Complemento.Nomina.Receptor.TipoContrato)
        If _comprobante.Complemento.Nomina.Receptor.Sindicalizado <> String.Empty Then receptor.SetAttribute("Sindicalizado", _comprobante.Complemento.Nomina.Receptor.Sindicalizado)
        If _comprobante.Complemento.Nomina.Receptor.TipoJornada <> String.Empty Then receptor.SetAttribute("TipoJornada", _comprobante.Complemento.Nomina.Receptor.TipoJornada)
        receptor.SetAttribute("TipoRegimen", _comprobante.Complemento.Nomina.Receptor.TipoRegimen)
        receptor.SetAttribute("NumEmpleado", _comprobante.Complemento.Nomina.Receptor.NumEmpleado)
        If _comprobante.Complemento.Nomina.Receptor.Departamento <> String.Empty Then receptor.SetAttribute("Departamento", _comprobante.Complemento.Nomina.Receptor.Departamento)
        If _comprobante.Complemento.Nomina.Receptor.Puesto <> String.Empty Then receptor.SetAttribute("Puesto", _comprobante.Complemento.Nomina.Receptor.Puesto)
        If _comprobante.Complemento.Nomina.Receptor.RiesgoPuesto <> String.Empty Then receptor.SetAttribute("RiesgoPuesto", _comprobante.Complemento.Nomina.Receptor.RiesgoPuesto)
        receptor.SetAttribute("PeriodicidadPago", _comprobante.Complemento.Nomina.Receptor.PeriodicidadPago)
        If _comprobante.Complemento.Nomina.Receptor.Banco <> String.Empty Then receptor.SetAttribute("Banco", _comprobante.Complemento.Nomina.Receptor.Banco)
        If _comprobante.Complemento.Nomina.Receptor.CuentaBancaria <> String.Empty Then receptor.SetAttribute("CuentaBancaria", _comprobante.Complemento.Nomina.Receptor.CuentaBancaria)
        If _comprobante.Complemento.Nomina.Receptor.SalarioBaseCotApor > 0 Then receptor.SetAttribute("SalarioBaseCotApor", _comprobante.Complemento.Nomina.Receptor.SalarioBaseCotApor.ToString("F2"))
        If _comprobante.Complemento.Nomina.Receptor.SalarioDiarioIntegrado > 0 Then receptor.SetAttribute("SalarioDiarioIntegrado", _comprobante.Complemento.Nomina.Receptor.SalarioDiarioIntegrado.ToString("F2"))
        receptor.SetAttribute("ClaveEntFed", _comprobante.Complemento.Nomina.Receptor.ClaveEntFed)
        nomina.AppendChild(receptor)
        If _comprobante.Complemento.Nomina.Percepciones.Percepciones.Count > 0 Then
            Dim percepciones As XmlElement = m_xmlDOM.CreateElement("nomina12", "Percepciones", _NamespaceCfdiNomina)
            percepciones.SetAttribute("TotalSueldos", _comprobante.Complemento.Nomina.Percepciones.TotalSueldos.ToString("F2"))
            If _comprobante.Complemento.Nomina.Percepciones.TotalSeparacionIndemnizacion > 0 Then percepciones.SetAttribute("TotalSeparacionIndemnizacion", _comprobante.Complemento.Nomina.Percepciones.TotalSeparacionIndemnizacion.ToString("F2"))
            If _comprobante.Complemento.Nomina.Percepciones.TotalJubilacionPensionRetiro > 0 Then percepciones.SetAttribute("TotalJubilacionPensionRetiro", _comprobante.Complemento.Nomina.Percepciones.TotalJubilacionPensionRetiro.ToString("F2"))
            percepciones.SetAttribute("TotalGravado", _comprobante.Complemento.Nomina.Percepciones.TotalGravado.ToString("F2"))
            percepciones.SetAttribute("TotalExento", _comprobante.Complemento.Nomina.Percepciones.TotalExento.ToString("F2"))
            For Each p As NPercepcion In _comprobante.Complemento.Nomina.Percepciones.Percepciones
                Dim percepcion As XmlElement = m_xmlDOM.CreateElement("nomina12", "Percepcion", _NamespaceCfdiNomina)
                percepcion.SetAttribute("TipoPercepcion", p.TipoPercepcion)
                percepcion.SetAttribute("Clave", p.Clave)
                percepcion.SetAttribute("Concepto", p.Concepto)
                percepcion.SetAttribute("ImporteGravado", p.ImporteGravado.ToString("F2"))
                percepcion.SetAttribute("ImporteExento", p.ImporteExento.ToString("F2"))
                For Each he As HorasExtra In p.HorasExtras
                    Dim HoraExtra As XmlElement = m_xmlDOM.CreateElement("nomina12", "HorasExtra", _NamespaceCfdiNomina)
                    HoraExtra.SetAttribute("Dias", he.Dias)
                    HoraExtra.SetAttribute("TipoHoras", he.TipoHoras)
                    HoraExtra.SetAttribute("HorasExtra", he.HorasExtra)
                    HoraExtra.SetAttribute("ImportePagado", he.ImportePagado.ToString("F2"))
                    percepcion.AppendChild(HoraExtra)
                Next

                percepciones.AppendChild(percepcion)
            Next

            nomina.AppendChild(percepciones)
        End If

        If _comprobante.Complemento.Nomina.Deducciones.Deduccion.Count > 0 Then
            Dim deducciones As XmlElement = m_xmlDOM.CreateElement("nomina12", "Deducciones", _NamespaceCfdiNomina)
            deducciones.SetAttribute("TotalOtrasDeducciones", _comprobante.Complemento.Nomina.Deducciones.TotalOtrasDeducciones.ToString())
            deducciones.SetAttribute("TotalImpuestosRetenidos", _comprobante.Complemento.Nomina.Deducciones.TotalImpuestosRetenidos.ToString())
            For Each d As NDeduccion In _comprobante.Complemento.Nomina.Deducciones.Deduccion
                Dim Deduccion As XmlElement = m_xmlDOM.CreateElement("nomina12", "Deduccion", _NamespaceCfdiNomina)
                Deduccion.SetAttribute("TipoDeduccion", d.TipoDeduccion)
                Deduccion.SetAttribute("Clave", d.Clave)
                Deduccion.SetAttribute("Concepto", d.Concepto)
                Deduccion.SetAttribute("Importe", d.Importe.ToString())
                deducciones.AppendChild(Deduccion)
            Next

            nomina.AppendChild(deducciones)
        End If

        complemento.AppendChild(nomina)
        Return complemento
    End Function
    Private Sub CrearAtributosComprobante(ByRef Comprobante As XmlElement)
        Dim shemaLocation As String = _SchemaLocation
        If _comprobante.TipoDeComprobante = "N" Then
            shemaLocation = shemaLocation & " " & _ShemaLocationNomina
        End If
        If _comprobante.TipoDeComprobante = "P" Then
            shemaLocation = shemaLocation & " " & _ShemaLocationPagos
            Comprobante.SetAttribute("xmlns:Pago10", _NamespaceCfdiPagos)
        End If
        If _comprobante.Complemento.GastosHidrocarburos.NumeroContrato <> String.Empty Then
            shemaLocation = shemaLocation & " " & _ShemaLocationGastosHidrocarburos
            Comprobante.SetAttribute("xmlns:gceh", _NamespaceGastosHidrocarburos)
        End If

        Comprobante.SetAttribute("xmlns:xsi", _NamespaceXsi)
        Comprobante.SetAttribute("xsi:schemaLocation", shemaLocation)
        Comprobante.SetAttribute("Version", _comprobante.Version)
        If _comprobante.Serie <> String.Empty Then Comprobante.SetAttribute("Serie", _comprobante.Serie)
        If _comprobante.Folio <> String.Empty Then Comprobante.SetAttribute("Folio", _comprobante.Folio)
        Comprobante.SetAttribute("Fecha", _comprobante.Fecha.ToString("s"))
        Comprobante.SetAttribute("Sello", "")
        If _comprobante.FormaPago <> String.Empty Then Comprobante.SetAttribute("FormaPago", _comprobante.FormaPago)
        Comprobante.SetAttribute("NoCertificado", _comprobante.NoCertificado)
        Comprobante.SetAttribute("Certificado", _comprobante.Certificado)
        If _comprobante.CondicionesDePago <> String.Empty Then Comprobante.SetAttribute("CondicionesDePAgo", _comprobante.CondicionesDePago)
        If (_comprobante.TipoDeComprobante = "P") Then
            Comprobante.SetAttribute("SubTotal", _comprobante.SubTotal.ToString())
        Else
            Comprobante.SetAttribute("SubTotal", _comprobante.SubTotal.ToString("F2"))
        End If

        If _comprobante.Descuento > 0 Then Comprobante.SetAttribute("Descuento", _comprobante.Descuento.ToString("F2"))
        Comprobante.SetAttribute("Moneda", _comprobante.Moneda)
        If _comprobante.TipoCambio > 0 Then Comprobante.SetAttribute("TipoCambio", _comprobante.TipoCambio.ToString())
        If (_comprobante.TipoDeComprobante = "P") Then
            Comprobante.SetAttribute("Total", _comprobante.Total.ToString())
        Else
            Comprobante.SetAttribute("Total", _comprobante.Total.ToString("F2"))
        End If

        Comprobante.SetAttribute("TipoDeComprobante", _comprobante.TipoDeComprobante)
        If _comprobante.MetodoPago <> String.Empty Then Comprobante.SetAttribute("MetodoPago", _comprobante.MetodoPago)
        Comprobante.SetAttribute("LugarExpedicion", _comprobante.LugarExpedicion)
        If _comprobante.Confirmacion <> String.Empty Then Comprobante.SetAttribute("Confirmacion", _comprobante.Confirmacion)
        Comprobante.SetAttribute("xmlns:xsi", "http://www.w3.org/2001/XMLSchema-instance")
        If _comprobante.TipoDeComprobante = "N" Then Comprobante.SetAttribute("xmlns:nomina12", "http://www.sat.gob.mx/nomina12")
    End Sub
    Private Function CrearNodoEmisor() As XmlElement
        Dim Emisor As XmlElement = m_xmlDOM.CreateElement("cfdi", "Emisor", _Namespaceuri)
        Emisor.SetAttribute("Rfc", _comprobante.Emisor.Rfc)
        If _comprobante.Emisor.Nombre <> String.Empty Then Emisor.SetAttribute("Nombre", _comprobante.Emisor.Nombre)
        Emisor.SetAttribute("RegimenFiscal", _comprobante.Emisor.RegimenFiscal)
        Return Emisor
    End Function
    Private Function CrearNodoReceptor() As XmlElement
        Dim Receptor As XmlElement = m_xmlDOM.CreateElement("cfdi", "Receptor", _Namespaceuri)
        Receptor.SetAttribute("Rfc", _comprobante.Receptor.Rfc)
        If _comprobante.Receptor.Nombre <> String.Empty Then Receptor.SetAttribute("Nombre", _comprobante.Receptor.Nombre)
        If _comprobante.Receptor.ResidenciaFiscal <> String.Empty Then Receptor.SetAttribute("ResidenciaFiscal", _comprobante.Receptor.ResidenciaFiscal)
        If _comprobante.Receptor.NumRegIdTrib <> String.Empty Then Receptor.SetAttribute("NumRegIdTrib", _comprobante.Receptor.NumRegIdTrib)
        Receptor.SetAttribute("UsoCFDI", _comprobante.Receptor.UsoCFDI)
        Return Receptor
    End Function
    Private Function CrearNodoConceptos() As XmlElement
        If _comprobante.Conceptos.Count <= 0 Then Return Nothing
        Dim Conceptos As XmlElement = m_xmlDOM.CreateElement("cfdi", "Conceptos", _Namespaceuri)
        For Each c As Concepto In _comprobante.Conceptos
            Dim Impuestos As XmlElement
            Dim Traslado As XmlElement
            Dim Retencion As XmlElement
            Dim Concepto As XmlElement = m_xmlDOM.CreateElement("cfdi", "Concepto", _Namespaceuri)
            Concepto.SetAttribute("ClaveProdServ", c.ClaveProdServ)
            If c.NoIdentificacion <> String.Empty Then Concepto.SetAttribute("NoIdentificacion", c.NoIdentificacion)
            Concepto.SetAttribute("Cantidad", c.Cantidad.ToString())
            Concepto.SetAttribute("ClaveUnidad", c.ClaveUnidad)
            If c.Unidad <> String.Empty Then Concepto.SetAttribute("Unidad", c.Unidad)
            Concepto.SetAttribute("Descripcion", c.Descripcion)
            If (_comprobante.TipoDeComprobante = "P") Then
                Concepto.SetAttribute("ValorUnitario", c.ValorUnitario.ToString())
                Concepto.SetAttribute("Importe", c.Importe.ToString())
            Else

                Concepto.SetAttribute("ValorUnitario", c.ValorUnitario.ToString("F2"))
                Concepto.SetAttribute("Importe", c.Importe.ToString("F2"))
            End If

            If c.Descuento > 0 Then Concepto.SetAttribute("Descuento", c.Descuento.ToString())
            If c.Impuestos.Traslados.Count > 0 OrElse c.Impuestos.Retenciones.Count > 0 Then
                Impuestos = m_xmlDOM.CreateElement("cfdi", "Impuestos", _Namespaceuri)
                If c.Impuestos.Traslados.Count > 0 Then
                    Dim Traslados As XmlElement = m_xmlDOM.CreateElement("cfdi", "Traslados", _Namespaceuri)
                    For Each t As TrasladoC In c.Impuestos.Traslados
                        Traslado = m_xmlDOM.CreateElement("cfdi", "Traslado", _Namespaceuri)
                        Traslado.SetAttribute("Base", t.Base.ToString("F2"))
                        Traslado.SetAttribute("Impuesto", t.Impuesto)
                        Traslado.SetAttribute("TipoFactor", t.TipoFactor)
                        Traslado.SetAttribute("TasaOCuota", t.TasaOCuota.ToString("F6"))
                        Traslado.SetAttribute("Importe", t.Importe.ToString("F2"))
                        Traslados.AppendChild(Traslado)
                    Next
                    Impuestos.AppendChild(Traslados)
                End If

                If c.Impuestos.Retenciones.Count > 0 Then
                    Dim Retenciones As XmlElement = m_xmlDOM.CreateElement("cfdi", "Retenciones", _Namespaceuri)
                    For Each r As RetencionC In c.Impuestos.Retenciones
                        Retencion = m_xmlDOM.CreateElement("cfdi", "Retencion", _Namespaceuri)
                        Retencion.SetAttribute("Base", r.Base.ToString("F2"))
                        Retencion.SetAttribute("Impuesto", r.Impuesto)
                        Retencion.SetAttribute("TipoFactor", r.TipoFactor)
                        Retencion.SetAttribute("TasaOCuota", r.TasaOCuota.ToString("F6"))
                        Retencion.SetAttribute("Importe", r.Importe.ToString("F6"))
                        Retenciones.AppendChild(Retencion)
                    Next
                    Impuestos.AppendChild(Retenciones)
                End If
                Concepto.AppendChild(Impuestos)
            End If

            If c.InformacionAduanera.Count > 0 Then
                For Each ia As InformacionAduanera In c.InformacionAduanera
                    Dim InformacionAduanera As XmlElement = m_xmlDOM.CreateElement("cfdi", "InformacionAduanera", _Namespaceuri)
                    InformacionAduanera.SetAttribute("NumeroPedimento", ia.NumeroPedimento)
                    InformacionAduanera.AppendChild(InformacionAduanera)
                    Concepto.AppendChild(InformacionAduanera)
                Next
            End If

            If c.CuentaPredial.Numero <> String.Empty Then
                Dim CuentaPredial As XmlElement = m_xmlDOM.CreateElement("cfdi", "CuentaPredial", _Namespaceuri)
                CuentaPredial.SetAttribute("Numero", c.CuentaPredial.Numero)
                Conceptos.AppendChild(CuentaPredial)
            End If

            If c.Parte.Count > 0 Then
                For Each p As Parte In c.Parte
                    Dim Parte As XmlElement = m_xmlDOM.CreateElement("cfdi", "Parte", _Namespaceuri)
                    Parte.SetAttribute("Descripcion", p.Descripcion)
                    If p.ValorUnitario > 0 Then Parte.SetAttribute("ValorUnitario", p.ValorUnitario.ToString())
                    If p.Importe > 0 Then Parte.SetAttribute("Importe", p.Importe.ToString())
                    If p.InformacionAduanera.Count > 0 Then
                        For Each ia As InformacionAduanera In p.InformacionAduanera
                            Dim InformacionAduanera As XmlElement = m_xmlDOM.CreateElement("cfdi", "InformacionAduanera", _Namespaceuri)
                            InformacionAduanera.SetAttribute("NumeroPedimento", ia.NumeroPedimento)
                            Parte.AppendChild(InformacionAduanera)
                        Next
                    End If

                    Concepto.AppendChild(Parte)
                Next
            End If

            If (Not c.Complemento.VentaVehiculos Is Nothing) Then
                Dim complemento As XmlElement
                complemento = m_xmlDOM.CreateElement("cfdi", "ComplementoConcepto", _Namespaceuri)
                Dim ventaVehiculos As XmlElement = m_xmlDOM.CreateElement("ventaVehiculos", "VentaVehiculos", _NamespaceVentaVehiculos)
                'ventaVehiculos.SetAttribute("xsi:schemaLocation", _ShemaLocationVentaVehiculos)
                ventaVehiculos.SetAttribute("version", c.Complemento.VentaVehiculos.Version)
                If (c.Complemento.VentaVehiculos.ClaveVehicular <> String.Empty) Then ventaVehiculos.SetAttribute("ClaveVehicular", c.Complemento.VentaVehiculos.ClaveVehicular)
                If (c.Complemento.VentaVehiculos.ClaveVehicular <> String.Empty) Then ventaVehiculos.SetAttribute("Niv", c.Complemento.VentaVehiculos.NIV)

                For Each ia As VVInformacionAduanera In c.Complemento.VentaVehiculos.InformacionAduanera
                    Dim informacionAduanera As XmlElement = m_xmlDOM.CreateElement("ventaVehiculos", "InformacionAduanera", _NamespaceVentaVehiculos)
                    informacionAduanera.SetAttribute("numero", ia.Numero)
                    informacionAduanera.SetAttribute("fecha", Convert.ToDateTime(ia.Fecha).ToString("yyyy-MM-dd"))
                    If (ia.Aduana <> String.Empty) Then informacionAduanera.SetAttribute("aduana", ia.Aduana)
                    ventaVehiculos.AppendChild(informacionAduanera)
                Next
                For Each p As VVParte In c.Complemento.VentaVehiculos.Parte
                    Dim parte As XmlElement = m_xmlDOM.CreateElement("ventaVehiculos", "Parte", _NamespaceVentaVehiculos)
                    parte.SetAttribute("cantidad", p.Cantidad.ToString("F2"))
                    If p.Unidad <> String.Empty Then parte.SetAttribute("unidad", p.Unidad)
                    If p.Unidad <> String.Empty Then parte.SetAttribute("noIdentificacion", p.NoIdentificacion)
                    parte.SetAttribute("descripcion", p.Descripcion)
                    If p.ValorUnitario > 0D Then parte.SetAttribute("valorUnitario", p.ValorUnitario)
                    If p.Importe > 0D Then parte.SetAttribute("importe", p.Importe.ToString("F2"))
                    For Each ia As VVInformacionAduanera In p.InformacionAduanera
                        Dim informacionAduanera As XmlElement = m_xmlDOM.CreateElement("ventaVehiculos", "InformacionAduanera", _NamespaceVentaVehiculos)
                        informacionAduanera.SetAttribute("numero", ia.Numero)
                        informacionAduanera.SetAttribute("fecha", Convert.ToDateTime(ia.Fecha).ToString("yyyy-MM-dd"))
                        If (ia.Aduana <> String.Empty) Then informacionAduanera.SetAttribute("aduana", ia.Aduana)
                        parte.AppendChild(informacionAduanera)
                    Next
                    ventaVehiculos.AppendChild(parte)
                Next
                complemento.AppendChild(ventaVehiculos)
                Concepto.AppendChild(complemento)
            End If

            Conceptos.AppendChild(Concepto)
            Concepto = Nothing
        Next

        Return Conceptos
    End Function
    Private Function CrearNodoImpuestos() As XmlElement
        If _comprobante.Impuestos.Retenciones.Count > 0 OrElse _comprobante.Impuestos.Traslados.Count > 0 Then
            Dim Impuestos As XmlElement = m_xmlDOM.CreateElement("cfdi", "Impuestos", _Namespaceuri)
            If _comprobante.Impuestos.Retenciones.Count > 0 Then Impuestos.SetAttribute("TotalImpuestosRetenidos", _comprobante.Impuestos.TotalImpuestosRetenidos.ToString("F2"))
            If _comprobante.Impuestos.Traslados.Count > 0 Then Impuestos.SetAttribute("TotalImpuestosTrasladados", _comprobante.Impuestos.TotalImpuestosTrasladados.ToString("F2"))
            If _comprobante.Impuestos.Retenciones.Count > 0 Then
                Dim Retenciones As XmlElement = m_xmlDOM.CreateElement("cfdi", "Retenciones", _Namespaceuri)
                For Each r As Retencion In _comprobante.Impuestos.Retenciones
                    Dim Retencion As XmlElement = m_xmlDOM.CreateElement("cfdi", "Retencion", _Namespaceuri)
                    Retencion.SetAttribute("Impuesto", r.Impuesto.ToString())
                    Retencion.SetAttribute("Importe", r.Importe.ToString("F2"))
                    Retenciones.AppendChild(Retencion)
                Next

                Impuestos.AppendChild(Retenciones)
            End If

            If _comprobante.Impuestos.Traslados.Count > 0 Then
                Dim Traslados As XmlElement = m_xmlDOM.CreateElement("cfdi", "Traslados", _Namespaceuri)
                For Each t As Traslado In _comprobante.Impuestos.Traslados
                    Dim Traslado As XmlElement = m_xmlDOM.CreateElement("cfdi", "Traslado", _Namespaceuri)
                    Traslado.SetAttribute("Impuesto", t.Impuesto.ToString())
                    Traslado.SetAttribute("Importe", t.Importe.ToString("F2"))
                    Traslado.SetAttribute("TasaOCuota", t.TasaOCuota.ToString("F6"))
                    Traslado.SetAttribute("TipoFactor", t.TipoFactor.ToString())
                    Traslados.AppendChild(Traslado)
                Next

                Impuestos.AppendChild(Traslados)
            End If

            Return Impuestos
        Else
            Return Nothing
        End If
    End Function
    Private Function CrearNodoGastosHidrocarburos() As XmlElement
        Try
            Dim complemento As XmlElement
            complemento = m_xmlDOM.CreateElement("cfdi", "Complemento", _Namespaceuri)
            Dim NodoGastos = m_xmlDOM.CreateElement("gceh", "GastosHidrocarburos", _NamespaceGastosHidrocarburos)
            'Dim NodoGastos = x_xmlDOM.CreateElement("gceh", "GastosHidrocarburos", _NamespaceGastosHidrocarburos)
            NodoGastos.SetAttribute("xmlns:gceh", _NamespaceGastosHidrocarburos)
            'NodoGastos.SetAttribute("xsi:schemaLocation", _ShemaLocationGastosHidrocarburos)
            NodoGastos.SetAttribute("Version", _comprobante.Complemento.GastosHidrocarburos.Version)
            NodoGastos.SetAttribute("NumeroContrato", _comprobante.Complemento.GastosHidrocarburos.NumeroContrato)
            If _comprobante.Complemento.GastosHidrocarburos.AreaContractual <> String.Empty Then NodoGastos.SetAttribute("AreaContractual", _comprobante.Complemento.GastosHidrocarburos.AreaContractual)
            If _comprobante.Complemento.GastosHidrocarburos.Erogacion.Count > 0 Then
                For Each e As Erogacion In _comprobante.Complemento.GastosHidrocarburos.Erogacion
                    Dim nodoErogaciones As XmlElement = m_xmlDOM.CreateElement("gceh", "Erogacion", _NamespaceGastosHidrocarburos)
                    nodoErogaciones.SetAttribute("TipoErogacion", e.TipoErogacion)
                    nodoErogaciones.SetAttribute("MontocuErogacion", e.MontocuErogacion.ToString("F2"))
                    nodoErogaciones.SetAttribute("Porcentaje", e.Porcentaje.ToString("F3"))
                    If e.DocumentoRelacionado.Count > 0 Then
                        For Each dr As EDocumentoRelacionado In e.DocumentoRelacionado
                            Dim nodoDocumentoRelacionado As XmlElement = m_xmlDOM.CreateElement("gceh", "DocumentoRelacionado", _NamespaceGastosHidrocarburos)
                            nodoDocumentoRelacionado.SetAttribute("OrigenErogacion", dr.OrigenErogacion)
                            If dr.FolioFiscalVinculado <> String.Empty Then
                                nodoDocumentoRelacionado.SetAttribute("FolioFiscalVinculado", dr.FolioFiscalVinculado)
                                nodoDocumentoRelacionado.SetAttribute("MontoTotalIVA", dr.MontoTotalIVA.ToString("F2"))
                            End If

                            If dr.RFCProveedor <> String.Empty Then nodoDocumentoRelacionado.SetAttribute("RFCProveedor", dr.RFCProveedor)
                            If dr.MontoRetencionISR > 0 Then nodoDocumentoRelacionado.SetAttribute("MontoRetencionISR", dr.MontoRetencionISR.ToString("F2"))
                            If dr.MontoRetencionIVA > 0 Then nodoDocumentoRelacionado.SetAttribute("MontoRetencionIVA", dr.MontoRetencionIVA.ToString("F2"))
                            If dr.MontoRetencionOtrosImpuestos > 0 Then nodoDocumentoRelacionado.SetAttribute("MontoRetencionOtrosImpuestos", dr.MontoRetencionOtrosImpuestos.ToString("F2"))
                            If dr.NumeroPedimentoVinculado <> String.Empty Then nodoDocumentoRelacionado.SetAttribute("NumeroPedimentoVinculado", dr.NumeroPedimentoVinculado)
                            If dr.ClavePedimentoVinculado <> String.Empty Then nodoDocumentoRelacionado.SetAttribute("ClavePedimentoVinculado", dr.ClavePedimentoVinculado)
                            If dr.ClavePagoPedimentoVinculado <> String.Empty Then nodoDocumentoRelacionado.SetAttribute("ClavePagoPedimentoVinculado", dr.ClavePagoPedimentoVinculado)
                            If dr.MontoIVAPedimento > 0 Then nodoDocumentoRelacionado.SetAttribute("MontoIVAPedimento", dr.MontoIVAPedimento.ToString("F2"))
                            If dr.OtrosImpuestosPagadosPedimento > 0 Then nodoDocumentoRelacionado.SetAttribute("OtrosImpuestosPagadosPedimento", dr.OtrosImpuestosPagadosPedimento.ToString("F2"))
                            If dr.FechaFolioFiscalVinculado <> String.Empty Then nodoDocumentoRelacionado.SetAttribute("FechaFolioFiscalVinculado", dr.FechaFolioFiscalVinculado)
                            nodoDocumentoRelacionado.SetAttribute("Mes", dr.Mes)
                            nodoDocumentoRelacionado.SetAttribute("MontoTotalErogaciones", dr.MontoTotalErogaciones)
                            nodoErogaciones.AppendChild(nodoDocumentoRelacionado)
                        Next
                    End If

                    If (e.Actividades.Count) > 0 Then
                        Dim nodoActividades As XmlElement = m_xmlDOM.CreateElement("gceh", "Actividades", _NamespaceGastosHidrocarburos)
                        For Each a As Actividades In e.Actividades
                            If a.ActividadRelacionada <> String.Empty Then nodoActividades.SetAttribute("ActividadRelacionada", a.ActividadRelacionada)
                            For Each s As SubActividades In a.SubActividades
                                Dim nodoSubactividad As XmlElement = m_xmlDOM.CreateElement("gceh", "SubActividades", _NamespaceGastosHidrocarburos)
                                nodoSubactividad.SetAttribute("SubActividadRelacionada", s.SubActividadRelacionada)
                                For Each t As Tareas In s.Tareas
                                    Dim nodoTarea As XmlElement = m_xmlDOM.CreateElement("gceh", "Tareas", _NamespaceGastosHidrocarburos)
                                    If t.TareaRelacionada <> String.Empty Then nodoTarea.SetAttribute("TareaRelacionada", t.TareaRelacionada)
                                    nodoSubactividad.AppendChild(nodoTarea)
                                Next
                                nodoActividades.AppendChild(nodoSubactividad)
                            Next
                            nodoErogaciones.AppendChild(nodoActividades)
                        Next
                    End If

                    If (e.CentroCostos.Count > 0) Then
                        For Each cc As CentroCostos In e.CentroCostos
                            Dim nodoCentroCostos As XmlElement = m_xmlDOM.CreateElement("gceh", "CentroCostos", _NamespaceGastosHidrocarburos)
                            If cc.Campo <> String.Empty Then nodoCentroCostos.SetAttribute("Campo", cc.Campo)
                            For Each y As Yacimientos In cc.Yacimientos
                                Dim nodoYacimientos As XmlElement = m_xmlDOM.CreateElement("gceh", "Yacimientos", _NamespaceGastosHidrocarburos)
                                If y.Yacimiento <> String.Empty Then nodoYacimientos.SetAttribute("Yacimiento", y.Yacimiento)
                                For Each p As Pozos In y.Pozos
                                    Dim nodoPozos As XmlElement = m_xmlDOM.CreateElement("gceh", "Pozos", _NamespaceGastosHidrocarburos)
                                    If p.Pozo <> String.Empty Then nodoPozos.SetAttribute("Pozo", p.Pozo)
                                    nodoYacimientos.AppendChild(nodoPozos)
                                Next
                                nodoCentroCostos.AppendChild(nodoYacimientos)
                            Next
                            nodoErogaciones.AppendChild(nodoCentroCostos)
                        Next
                    End If

                    NodoGastos.AppendChild(nodoErogaciones)
                    complemento.AppendChild(NodoGastos)
                Next
                Return complemento
            Else
                Return Nothing
            End If
        Catch ex As Exception

        End Try

    End Function
    Private Function IndentarNodo(ByVal Nodo As XmlNode) As XmlNode
        Nodo.AppendChild(m_xmlDOM.CreateTextNode(Environment.NewLine))
        Return Nodo
    End Function
    Private Function ObtenerSello1(ByVal rutaPFX As String, ByVal passwordPFX As String) As String
        Dim privateCert As X509Certificate2 = New X509Certificate2(rutaPFX, passwordPFX, X509KeyStorageFlags.Exportable)
        Dim privateKey As RSACryptoServiceProvider = CType(privateCert.PrivateKey, RSACryptoServiceProvider)
        Dim privateKey1 As RSACryptoServiceProvider = New System.Security.Cryptography.RSACryptoServiceProvider()
        privateKey1.ImportParameters(privateKey.ExportParameters(True))
        Dim bytesFirmados As Byte() = privateKey1.SignData(System.Text.Encoding.UTF8.GetBytes(GetCadenaOriginal(m_xmlDOM.InnerXml)), "SHA256")
        Return Convert.ToBase64String(bytesFirmados)
    End Function
    Private Function ObtenerSello(ByVal rutaPFX As String, ByVal passwordPFX As String) As String
        Try
            Dim objCertPfx As X509Certificate2 = New X509Certificate2(rutaPFX, passwordPFX)
            Dim lRSA As RSACryptoServiceProvider = CType(objCertPfx.PrivateKey, RSACryptoServiceProvider)
            Dim lhasher As SHA1CryptoServiceProvider = New SHA1CryptoServiceProvider()
            Dim bytesFirmados As Byte() = lRSA.SignData(System.Text.Encoding.UTF8.GetBytes(GetCadenaOriginal(m_xmlDOM.InnerXml)), lhasher)
            Return Convert.ToBase64String(bytesFirmados)
        Catch
            Return String.Empty
        End Try
    End Function
    Private Sub ObtenerCerticicadoYNoCertificado(ByVal rutaCertificado As String, ByRef Certificado As String, ByRef NoCertificado As String)
        Try
            Dim objCert As X509Certificate2 = New X509Certificate2()
            Dim bRawData As Byte() = ReadFile(rutaCertificado)
            objCert.Import(bRawData)
            Certificado = Convert.ToBase64String(bRawData)
            NoCertificado = FormatearSerieCert(objCert.SerialNumber)
        Catch
            Certificado = String.Empty
            NoCertificado = String.Empty
        End Try
    End Sub
    Public Function ReadFile(ByVal strArchivo As String) As Byte()
        Dim f As FileStream = New FileStream(strArchivo, FileMode.Open, FileAccess.Read)
        Dim size As Integer = Convert.ToInt32(f.Length)
        Dim data As Byte() = New Byte(size - 1) {}
        size = f.Read(data, 0, size)
        f.Close()
        Return data
    End Function
    Private Function FormatearSerieCert(ByVal Serie As String) As String
        Dim Resultado As String = ""
        Dim I As Integer
        For I = 1 To Serie.Length - 1 Step 2
            Resultado = Resultado & Serie.Substring(I, 1)
        Next

        Return Resultado
    End Function
    Public Function GetCadenaOriginal(ByVal xmlCFD As String) As String
        Dim xslt As XslCompiledTransform = New XslCompiledTransform()
        Dim xmldoc As XmlDocument = New XmlDocument()
        Dim navigator As XPathNavigator
        Dim output As StringWriter = New StringWriter()
        xmldoc.LoadXml(xmlCFD)
        navigator = xmldoc.CreateNavigator()
        xslt.Load(_rutaXslt)
        ' xslt.Load(Application.StartupPath & _rutaXslt)
        xslt.Transform(navigator, Nothing, output)
        Return output.ToString()
    End Function
End Class
