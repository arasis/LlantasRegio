Public Class wPagos

    Dim _comprobante As Comprobante

    Private bs As BindingSource = New BindingSource()
    Private bsComprobante As BindingSource = New BindingSource()
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        cargarDatosDB()
        RefreshDataBindings()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Function getConcepto() As Concepto
        Dim c As Concepto = New Concepto()
        c.ClaveProdServ = "84111506"
        c.ClaveUnidad = "ACT"
        c.ValorUnitario = 0
        c.Importe = 0
        c.Cantidad = 1
        c.Descripcion = "Pago"
        Return c
    End Function
    Private Sub cargarDatosDB()
        _comprobante = New Comprobante()
        _comprobante.Fecha = Date.Now
        _comprobante.Conceptos.Add(getConcepto())

        If Not DB.ProbarConexion() Then Return
        cbPagoMoneda.ValueMember = "Moneda"
        cbPagoMoneda.DataSource = DB.obtenerMonedas()
        cbRegimenesFiscales.ValueMember = "RegimenFiscal"
        cbRegimenesFiscales.DataSource = DB.obtenerRegimenesFiscales()
        cbTipoComprobante.ValueMember = "TipoComprobante"
        cbTipoComprobante.DataSource = DB.obtenerTiposComprobante()
        cbPagoFormaPago.ValueMember = "FormaPago"
        cbPagoFormaPago.DataSource = DB.obtenerFormasPago()
        cbPagoMoneda.DataSource = DB.obtenerMonedas()
        cbClientes.DisplayMember = "RFC"
        cbClientes.DataSource = DB.obtenerClientes()
    End Sub
    Private Sub obtenerCamposConfiguracion()
        _comprobante.Emisor.Nombre = DB.obtenerEmisorRazonSocial()
        _comprobante.Emisor.Rfc = DB.obtenerEmisorRFC()
        _comprobante.LugarExpedicion = DB.obtenerEmisorLugarExpedicion()
        cbRegimenesFiscales.SelectedValue = DB.obtenerEmisorRegimenFiscal()
        bsComprobante.ResetBindings(False)
        cbTipoComprobante.SelectedValue = "P"
    End Sub
    Public Sub RefreshDataBindings()
        obtenerCamposConfiguracion()
        bsComprobante.DataSource = _comprobante
        tbEmisorRFC.DataBindings.Add("Text", bsComprobante, "Emisor.Rfc", False, DataSourceUpdateMode.OnPropertyChanged)
        tbEmisorRazonSocial.DataBindings.Add("Text", bsComprobante, "Emisor.Nombre", False, DataSourceUpdateMode.OnPropertyChanged)
        dtpFecha.DataBindings.Add("Value", bsComprobante, "Fecha", False, DataSourceUpdateMode.OnPropertyChanged)
        tbSerie.DataBindings.Add("Text", bsComprobante, "Serie", False, DataSourceUpdateMode.OnPropertyChanged)
        tbFolio.DataBindings.Add("Text", bsComprobante, "Folio", False, DataSourceUpdateMode.OnPropertyChanged)
        tbConfirmacion.DataBindings.Add("Text", bsComprobante, "Confirmacion", False, DataSourceUpdateMode.OnPropertyChanged)
        tbReceptorResidenciaFiscal.DataBindings.Add("Text", bsComprobante, "Receptor.ResidenciaFiscal", False, DataSourceUpdateMode.OnPropertyChanged)
        tbReceptorNumeroRegistro.DataBindings.Add("Text", bsComprobante, "Receptor.NumRegIdTrib", False, DataSourceUpdateMode.OnPropertyChanged)
        tbSubtotal.DataBindings.Add("Text", bsComprobante, "SubTotal", False, DataSourceUpdateMode.OnPropertyChanged)
        tbTotal.DataBindings.Add("Text", bsComprobante, "Total", False, DataSourceUpdateMode.OnPropertyChanged)
        tbDescuento.DataBindings.Add("Text", bsComprobante, "Descuento", False, DataSourceUpdateMode.OnPropertyChanged)
        tbImporteConLetra.DataBindings.Add("Text", bsComprobante, "TotalLetra", False, DataSourceUpdateMode.OnPropertyChanged)
        tbLugarExpedicion.DataBindings.Add("Text", bsComprobante, "LugarExpedicion", False, DataSourceUpdateMode.OnPropertyChanged)
        bs.DataSource = _comprobante.Complemento.Pagos.pagos
        dgvConceptos.DataSource = bs
        dgvConceptos.Columns("NumOperacion").Visible = False
        dgvConceptos.Columns("RfcEmisorCtaOrd").Visible = False
        dgvConceptos.Columns("NomBancoOrdExt").Visible = False
        dgvConceptos.Columns("CtaOrdenante").Visible = False
        dgvConceptos.Columns("RfcEmisorCtaBen").Visible = False
        dgvConceptos.Columns("CtaBeneficiario").Visible = False
        dgvConceptos.Columns("TipoCadPago").Visible = False
        dgvConceptos.Columns("CertPago").Visible = False
        dgvConceptos.Columns("CadPago").Visible = False
        dgvConceptos.Columns("SelloPago").Visible = False
        dgvConceptos.Columns("Impuestos").Visible = False
        dgvConceptos.Columns("TipoCambioP").Visible = False
        dgvConceptos.Columns("cDocumentosRelacionados").DisplayIndex = 6
        dgvConceptos.Columns("cEliminar").DisplayIndex = 7
        'dgvConceptos.Columns("Impuestos").Visible = False
        'dgvConceptos.Columns("ClaveProdServ").DisplayIndex = 0
        'dgvConceptos.Columns("NoIdentificacion").DisplayIndex = 2
        'dgvConceptos.Columns("ClaveUnidad").DisplayIndex = 3
        'dgvConceptos.Columns("Cantidad").DisplayIndex = 4
        'dgvConceptos.Columns("Unidad").DisplayIndex = 5
        'dgvConceptos.Columns("Descripcion").DisplayIndex = 6
        'dgvConceptos.Columns("ValorUnitario").DisplayIndex = 7
        'dgvConceptos.Columns("Importe").DisplayIndex = 8
        'dgvConceptos.Columns("Descuento").DisplayIndex = 9
        'dgvConceptos.Columns("Cantidad").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        'dgvConceptos.Columns("Importe").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        'dgvConceptos.Columns("ValorUnitario").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        'dgvConceptos.Columns("Descuento").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        'dgvConceptos.Columns("Descuento").DefaultCellStyle.Format = "C2"
        'dgvConceptos.Columns("ValorUnitario").DefaultCellStyle.Format = "C2"
        'dgvConceptos.Columns("Importe").DefaultCellStyle.Format = "C2"
    End Sub

    Private Function validaCamposConcepto() As Boolean

        Dim band As Boolean = True
        If (nudPagoMonto.Value <= 0) Then
            lError.Text = "El campo Monto debe ser mayor a 0"
            band = False
        End If
        If (cbPagoFormaPago.SelectedValue = Nothing) Then
            lError.Text = "El campo Forma de pago es obligatorio"
            band = False
        End If
        If (cbPagoMoneda.SelectedValue = Nothing) Then
            lError.Text = "El campo Moneda es obligatorio"
            band = False
        End If
        If (band = False) Then

            tlpError.Visible = True
            timer1.Enabled = True

        End If
        Return band
    End Function


    Private Sub btnConceptoAgregar_Click(sender As Object, e As EventArgs) Handles btnConceptoAgregar.Click
        If (validaCamposConcepto() = False) Then
            Return
        End If
        Dim pago As Pago = New Pago()
        pago.CadPago = tbPagoCadenaOriginal.Text
        pago.CertPago = tbPagoSello.Text
        pago.CtaBeneficiario = tbPagoCuentaBeneficiario.Text
        pago.CtaOrdenante = tbPagoCtaOte.Text
        pago.FechaPago = dtpFecha.Value.ToString("s")
        pago.FormaDePagoP = cbPagoFormaPago.SelectedValue
        pago.MonedaP = cbPagoMoneda.SelectedValue
        pago.Monto = nudPagoMonto.Value
        pago.NomBancoOrdExt = tbPagoNombreBancoOrdenante.Text
        pago.NumOperacion = tbPagoNoOperacion.Text
        pago.RfcEmisorCtaBen = tbPagoRfcEmisoCtaDestino.Text
        pago.RfcEmisorCtaOrd = tbPagoRfcEmisorCtaOte.Text
        pago.SelloPago = tbPagoSello.Text
        pago.TipoCadPago = tbPagoTipoCadenaPago.Text
        pago.TipoCambioP = nudPagoTipoCambio.Value
        _comprobante.Complemento.Pagos.Pagos.Add(pago)
        bs.ResetBindings(False)
        limpiarCampos()
    End Sub
    Private Sub getCamposCombox()
        _comprobante.Complemento.Pagos.Version = "1.0"
        If (cbRegimenesFiscales.SelectedItem IsNot Nothing) Then
            _comprobante.Emisor.RegimenFiscal = (CType(cbRegimenesFiscales.SelectedItem, cRegimenFiscal)).RegimenFiscal
        End If

        If cbTipoComprobante.SelectedItem IsNot Nothing Then
            _comprobante.TipoDeComprobante = (CType(cbTipoComprobante.SelectedItem, cTipoComprobante)).TipoComprobante
        End If
        _comprobante.Moneda = "XXX"
        If cbClientes.SelectedItem IsNot Nothing Then
            _comprobante.Receptor.Nombre = (CType(cbClientes.SelectedItem, Cliente)).RazonSocial
            _comprobante.Receptor.Rfc = (CType(cbClientes.SelectedItem, Cliente)).RFC
            _comprobante.Receptor.UsoCFDI = "P01"
        End If
    End Sub
    Private Sub btnTimbrar_Click(sender As Object, e As EventArgs) Handles btnTimbrar.Click
        getCamposCombox()
        Dim rutaXMLST As String = ".\XMLST\" & _comprobante.Serie + _comprobante.Folio & ".xml"
        Dim rutaXMLT As String = ".\XMLT\" & _comprobante.Serie + _comprobante.Folio & ".xml"
        Dim rutaPFX As String = DB.obtenerRutaPFX()
        Dim rutaCertificado As String = DB.obtenerRutaCertificado()
        Dim contrasenaPFX As String = DB.obtenerContrasenaPFX()
        Dim rutaPDF As String = DB.obtenerRutaXML() + _comprobante.Serie + _comprobante.Folio & ".pdf"
        Dim crearXML As CrearXML = New CrearXML()
        Dim errorC As CError = _comprobante.EsInfoCorrecta()
        If Not errorC.HayError Then
            crearXML.Create(_comprobante, rutaXMLST, rutaPFX, contrasenaPFX, rutaCertificado)
            If Timbrar.timbrar(rutaXMLST, rutaXMLT, DB.obtenerUsuarioFD(), DB.contrasenaFD()) Then
                Dim CreaPDF As CreaPDF = New CreaPDF(rutaXMLT, rutaPDF, Nothing)
            End If
        Else
            MessageBox.Show(errorC.Error, "Validando información...")
        End If
    End Sub

    Private Sub btnAgregarCliente_Click(sender As Object, e As EventArgs) Handles btnAgregarCliente.Click
        Dim cliente As wCliente = New wCliente()
        cliente.ShowDialog()
        cbClientes.DisplayMember = "RFC"
        cbClientes.DataSource = DB.obtenerClientes()

    End Sub

    Private Sub cbPagoFormaPago_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPagoFormaPago.SelectedIndexChanged

       
    End Sub

    Private Sub cbPagoFormaPago_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbPagoFormaPago.SelectedValueChanged
        If (cbPagoFormaPago.SelectedValue = Nothing) Then
            Return
        End If

        If (cbPagoFormaPago.SelectedValue.ToString() = "02") Then
            tbPagoNoOperacion.Enabled = True
            nudPagoTipoCambio.Enabled = False
            tbPagoRfcEmisorCtaOte.Enabled = True
            tbPagoNombreBancoOrdenante.Enabled = True
            tbPagoCtaOte.Enabled = True
            tbPagoRfcEmisoCtaDestino.Enabled = True
            tbPagoCuentaBeneficiario.Enabled = True
            tbPagoTipoCadenaPago.Enabled = False
            tbPagoCertificadoPago.Enabled = False
            tbPagoCadenaOriginal.Enabled = False
            tbPagoSello.Enabled = False
        ElseIf (cbPagoFormaPago.SelectedValue.ToString() = "03") Then
            tbPagoNoOperacion.Enabled = True
            nudPagoTipoCambio.Enabled = False
            tbPagoRfcEmisorCtaOte.Enabled = True
            tbPagoNombreBancoOrdenante.Enabled = True
            tbPagoCtaOte.Enabled = True
            tbPagoRfcEmisoCtaDestino.Enabled = True
            tbPagoCuentaBeneficiario.Enabled = True
            tbPagoTipoCadenaPago.Enabled = True
            tbPagoCertificadoPago.Enabled = False
            tbPagoCadenaOriginal.Enabled = False
            tbPagoSello.Enabled = False
        ElseIf (cbPagoFormaPago.SelectedValue.ToString() = "04") Then
            tbPagoNoOperacion.Enabled = True
            nudPagoTipoCambio.Enabled = False
            tbPagoRfcEmisorCtaOte.Enabled = True
            tbPagoNombreBancoOrdenante.Enabled = True
            tbPagoCtaOte.Enabled = True
            tbPagoRfcEmisoCtaDestino.Enabled = True
            tbPagoCuentaBeneficiario.Enabled = True
            tbPagoTipoCadenaPago.Enabled = False
            tbPagoCertificadoPago.Enabled = False
            tbPagoCadenaOriginal.Enabled = False
            tbPagoSello.Enabled = False
        ElseIf (cbPagoFormaPago.SelectedValue.ToString() = "05") Then
            tbPagoNoOperacion.Enabled = True
            nudPagoTipoCambio.Enabled = False
            tbPagoRfcEmisorCtaOte.Enabled = True
            tbPagoNombreBancoOrdenante.Enabled = False
            tbPagoCtaOte.Enabled = True
            tbPagoRfcEmisoCtaDestino.Enabled = True
            tbPagoCuentaBeneficiario.Enabled = True
            tbPagoTipoCadenaPago.Enabled = False
            tbPagoCertificadoPago.Enabled = False
            tbPagoCadenaOriginal.Enabled = False
            tbPagoSello.Enabled = False
        ElseIf (cbPagoFormaPago.SelectedValue.ToString() = "06") Then
            tbPagoNoOperacion.Enabled = True
            nudPagoTipoCambio.Enabled = False
            tbPagoRfcEmisorCtaOte.Enabled = True
            tbPagoNombreBancoOrdenante.Enabled = False
            tbPagoCtaOte.Enabled = True
            tbPagoRfcEmisoCtaDestino.Enabled = False
            tbPagoCuentaBeneficiario.Enabled = False
            tbPagoTipoCadenaPago.Enabled = False
            tbPagoCertificadoPago.Enabled = False
            tbPagoCadenaOriginal.Enabled = False
            tbPagoSello.Enabled = False
        ElseIf (cbPagoFormaPago.SelectedValue.ToString() = "28") Then
            tbPagoNoOperacion.Enabled = True
            nudPagoTipoCambio.Enabled = False
            tbPagoRfcEmisorCtaOte.Enabled = True
            tbPagoNombreBancoOrdenante.Enabled = True
            tbPagoCtaOte.Enabled = True
            tbPagoRfcEmisoCtaDestino.Enabled = True
            tbPagoCuentaBeneficiario.Enabled = True
            tbPagoTipoCadenaPago.Enabled = False
            tbPagoCertificadoPago.Enabled = False
            tbPagoCadenaOriginal.Enabled = False
            tbPagoSello.Enabled = False
        ElseIf (cbPagoFormaPago.SelectedValue.ToString() = "29") Then
            tbPagoNoOperacion.Enabled = True
            nudPagoTipoCambio.Enabled = False
            tbPagoRfcEmisorCtaOte.Enabled = True
            tbPagoNombreBancoOrdenante.Enabled = True
            tbPagoCtaOte.Enabled = True
            tbPagoRfcEmisoCtaDestino.Enabled = True
            tbPagoCuentaBeneficiario.Enabled = True
            tbPagoTipoCadenaPago.Enabled = False
            tbPagoCertificadoPago.Enabled = False
            tbPagoCadenaOriginal.Enabled = False
            tbPagoSello.Enabled = False
        ElseIf (cbPagoFormaPago.SelectedValue.ToString() = "99") Then
            tbPagoNoOperacion.Enabled = True
            nudPagoTipoCambio.Enabled = False
            tbPagoRfcEmisorCtaOte.Enabled = True
            tbPagoNombreBancoOrdenante.Enabled = True
            tbPagoCtaOte.Enabled = True
            tbPagoRfcEmisoCtaDestino.Enabled = True
            tbPagoCuentaBeneficiario.Enabled = True
            tbPagoTipoCadenaPago.Enabled = True
            tbPagoCertificadoPago.Enabled = False
            tbPagoCadenaOriginal.Enabled = False
            tbPagoSello.Enabled = False
        Else
            tbPagoNoOperacion.Enabled = False
            nudPagoTipoCambio.Enabled = False
            tbPagoRfcEmisorCtaOte.Enabled = False
            tbPagoNombreBancoOrdenante.Enabled = False
            tbPagoCtaOte.Enabled = False
            tbPagoRfcEmisoCtaDestino.Enabled = False
            tbPagoCuentaBeneficiario.Enabled = False
            tbPagoTipoCadenaPago.Enabled = False
            tbPagoCertificadoPago.Enabled = False
            tbPagoCadenaOriginal.Enabled = False
            tbPagoSello.Enabled = False
        End If




    End Sub

    Private Sub dgvConceptos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvConceptos.CellClick
        If (e.RowIndex = dgvConceptos.NewRowIndex Or e.RowIndex < 0) Then
            Return
        End If

        If (e.ColumnIndex = dgvConceptos.Columns("cDocumentosRelacionados").Index) Then
            Dim pago As Pago = DirectCast(dgvConceptos.Rows(e.RowIndex).DataBoundItem, Pago)
            Dim wdr As wDoctosRelacionados = New wDoctosRelacionados(pago.DoctoRelacionado)
            wdr.ShowDialog()
            DirectCast(bs.Item(e.RowIndex), Pago).DoctoRelacionado = wdr._documentosRelacionados
        End If
        If (e.ColumnIndex = dgvConceptos.Columns("cEliminar").Index) Then
            _comprobante.Complemento.Pagos.Pagos.RemoveAt(e.RowIndex)
            bs.ResetBindings(False)
        End If
    End Sub

    Private Sub timer1_Tick(sender As Object, e As EventArgs) Handles timer1.Tick
        tlpError.Visible = False
        lError.Text = String.Empty
        timer1.Enabled = False
    End Sub

    Private Function limpiarCampos()
        nudPagoMonto.Value = 0
        nudPagoTipoCambio.Value = 0
        tbPagoCadenaOriginal.Text = String.Empty
        tbPagoCertificadoPago.Text = String.Empty
        tbPagoCtaOte.Text = String.Empty
        tbPagoCuentaBeneficiario.Text = String.Empty
        tbPagoNombreBancoOrdenante.Text = String.Empty
        tbPagoNoOperacion.Text = String.Empty
        tbPagoRfcEmisoCtaDestino.Text = String.Empty
        tbPagoRfcEmisorCtaOte.Text = String.Empty
        tbPagoSello.Text = String.Empty
        tbPagoTipoCadenaPago.Text = String.Empty
    End Function

    Private Sub btnConceptoLimpiar_Click(sender As Object, e As EventArgs) Handles btnConceptoLimpiar.Click
        limpiarCampos()
    End Sub
End Class