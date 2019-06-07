
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
Module TimbrarPrueba
    Function timbrar(ByVal rutaXMLTimbrar As String, ByVal rutaXML As String, ByVal usuario As String, ByVal password As String) As Boolean

        'rutaXMLTimbrar = "C:\Users\Faustino\Desktop\SEFACTURA\CFDI_previo.xml"
        Dim DocumentoXML As XmlDocument = New XmlDocument()
        DocumentoXML.Load(rutaXMLTimbrar)

        Dim ServicioTimbrado As New WSCFDI33.WSCFDI33Client

        'Se instancia la Respuesta del WS de Timbrado.
        Dim RespuestaTimbrado As New WSCFDI33.RespuestaTFD33

        Dim stringXML As String = Nothing
        stringXML = DocumentoXML.OuterXml

        RespuestaTimbrado = ServicioTimbrado.TimbrarCFDI(usuario, password, stringXML, "0001")

        'If (resultado.status) Then
        '    DocumentoXML.LoadXml(resultado.timbre)
        '    DocumentoXML.Save(rutaXML)
        'Else
        '    MessageBox.Show(resultado.codigo)
        'End If

        If RespuestaTimbrado.OperacionExitosa = True Then

            'Guardo el XML timbrado.
            DocumentoXML.LoadXml(RespuestaTimbrado.XMLResultado)
            DocumentoXML.Save(rutaXML)
            Return True
        Else

            'Se limpia el TextBox
            Dim mensaje As String


            'Si la petición fue erronea muestro el error.
            mensaje = RespuestaTimbrado.CodigoRespuesta + vbNewLine
            mensaje += RespuestaTimbrado.MensajeError + vbNewLine
            mensaje += RespuestaTimbrado.MensajeErrorDetallado + vbNewLine

            MessageBox.Show(RespuestaTimbrado.MensajeError)
            Variables.ErrorMensajeTimbrado = RespuestaTimbrado.MensajeError
            Return False
        End If






        'Dim ServicioTimbrado_FOLIOS_DIGITALES As WSFD.WSCFDI33Client = New WSFD.WSCFDI33Client
        'Dim RespuestaTimbrado_FOLIOS_DIGITALES As WSFD.RespuestaTFD33 = New WSFD.RespuestaTFD33
        'Dim DocumentoXML As XmlDocument = New XmlDocument()
        'DocumentoXML.Load(rutaXMLTimbrar)
        'Dim stringXML As String = Nothing
        'stringXML = DocumentoXML.OuterXml
        'RespuestaTimbrado_FOLIOS_DIGITALES = ServicioTimbrado_FOLIOS_DIGITALES.TimbrarCFDI(usuario, password, stringXML, "1222")
        'If RespuestaTimbrado_FOLIOS_DIGITALES.OperacionExitosa = True Then
        '    DocumentoXML.LoadXml(RespuestaTimbrado_FOLIOS_DIGITALES.XMLResultado)
        '    DocumentoXML.Save(rutaXML)
        '    Return True
        'Else
        '    Dim [error] As String
        '    [error] = RespuestaTimbrado_FOLIOS_DIGITALES.CodigoRespuesta
        '    [error] += RespuestaTimbrado_FOLIOS_DIGITALES.MensajeError
        '    [error] += RespuestaTimbrado_FOLIOS_DIGITALES.MensajeErrorDetallado
        '    MessageBox.Show([error])
        '    Return False
        'End If
    End Function
End Module
