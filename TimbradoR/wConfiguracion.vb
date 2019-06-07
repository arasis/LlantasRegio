Public Class wConfiguracion
    Private Sub cargarRegimenesFiscales()
        Dim lista As List(Of cRegimenFiscal) = New List(Of cRegimenFiscal)()
        lista.Add(New cRegimenFiscal(1, "601", "General de Ley Personas Morales"))
        lista.Add(New cRegimenFiscal(2, "603", "Personas Morales con Fines no Lucrativos"))
        lista.Add(New cRegimenFiscal(3, "605", "Sueldos y Salarios e Ingresos Asimilados a Salarios"))
        lista.Add(New cRegimenFiscal(4, "606", "Arrendamiento"))
        lista.Add(New cRegimenFiscal(5, "608", "Demás ingresos"))
        lista.Add(New cRegimenFiscal(6, "609", "Consolidación"))
        lista.Add(New cRegimenFiscal(7, "610", "Residentes en el Extranjero sin Establecimiento Permanente en México"))
        lista.Add(New cRegimenFiscal(8, "611", "Ingresos por Dividendos(socios y accionistas)"))
        lista.Add(New cRegimenFiscal(9, "612", "Personas Físicas con Actividades Empresariales y Profesionales"))
        lista.Add(New cRegimenFiscal(10, "614", "Ingresos por intereses"))
        lista.Add(New cRegimenFiscal(11, "616", "Sin obligaciones fiscales"))
        lista.Add(New cRegimenFiscal(12, "620", "Sociedades Cooperativas de Producción que optan por diferir sus ingresos"))
        lista.Add(New cRegimenFiscal(13, "621", "Incorporación Fiscal"))
        lista.Add(New cRegimenFiscal(14, "622", "Actividades Agrícolas, Ganaderas, Silvícolas y Pesqueras"))
        lista.Add(New cRegimenFiscal(15, "623", "Opcional para Grupos de Sociedades"))
        lista.Add(New cRegimenFiscal(16, "624", "Coordinados"))
        lista.Add(New cRegimenFiscal(17, "628", "Hidrocarburos"))
        lista.Add(New cRegimenFiscal(18, "607", "Régimen de Enajenación o Adquisición de Bienes"))
        lista.Add(New cRegimenFiscal(19, "629", "De los Regímenes Fiscales Preferentes y de las Empresas Multinacionales"))
        lista.Add(New cRegimenFiscal(20, "630", "Enajenación de acciones en bolsa de valores"))
        lista.Add(New cRegimenFiscal(21, "615", "Régimen de los ingresos por obtención de premios"))
        cbRegimenesFiscales.ValueMember = "RegimenFiscal"
        cbRegimenesFiscales.DataSource = lista
    End Sub

    Private Sub btnExaminarCertificadosRutaPFX_Click(sender As Object, e As EventArgs) Handles btnExaminarCertificadosRutaPFX.Click
        Dim openFileDialog1 As OpenFileDialog = New OpenFileDialog()
        openFileDialog1.InitialDirectory = "c:\"
        openFileDialog1.Filter = "Archivo PFX (*.pfx)|*.pfx|All files (*.*)|*.*"
        openFileDialog1.FilterIndex = 1
        openFileDialog1.RestoreDirectory = True
        If openFileDialog1.ShowDialog() = DialogResult.OK Then tbConexionRutaPfx.Text = openFileDialog1.FileName
    End Sub

    Private Sub btnExaminarCertificadosRutaCertificado_Click(sender As Object, e As EventArgs) Handles btnExaminarCertificadosRutaCertificado.Click
        Dim openFileDialog1 As OpenFileDialog = New OpenFileDialog()
        openFileDialog1.InitialDirectory = "c:\"
        openFileDialog1.Filter = "Certificado (*.cer)|*.cer|All files (*.*)|*.*"
        openFileDialog1.FilterIndex = 1
        openFileDialog1.RestoreDirectory = True
        If openFileDialog1.ShowDialog() = DialogResult.OK Then tbConexionRutaCertificado.Text = openFileDialog1.FileName
    End Sub

    Private Sub btnExaminarRutaXMLST_Click(sender As Object, e As EventArgs) Handles btnExaminarRutaXMLST.Click
        Dim fbd As FolderBrowserDialog = New FolderBrowserDialog()
        Dim result As DialogResult = fbd.ShowDialog()
        If result = DialogResult.OK Then tbFacturacionRutaXMLST.Text = fbd.SelectedPath
    End Sub

    Private Sub btnExaminarRutaXMLT_Click(sender As Object, e As EventArgs) Handles btnExaminarRutaXMLT.Click
        Dim fbd As FolderBrowserDialog = New FolderBrowserDialog()
        Dim result As DialogResult = fbd.ShowDialog()
        If result = DialogResult.OK Then tbFacturacionRutaXMLT.Text = fbd.SelectedPath
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        DB.guadarConfiguracionConexion(tbUsuarioFoliosDigitales.Text.Trim(), tbPasswordFoliosDigitales.Text.Trim())
        DB.guadarConfiguracionFacturacion(tbFacturacionRutaXMLST.Text.Trim(), tbFacturacionRutaXMLT.Text.Trim(), tbConexionRutaPfx.Text.Trim(), tbConexionContrasenaPfx.Text.Trim(), tbConexionRutaCertificado.Text.Trim())
        DB.guadarConfiguracionInformacionFiscal(tbEmisorRFC.Text.Trim(), tbEmisorRazonSocial.Text.Trim(), cbRegimenesFiscales.SelectedValue.ToString(), tbLugarExpedicion.Text.Trim())
        MsgBox("Información guardada correctamente", MsgBoxStyle.Information)
        'MessageBox.Show("Información guardada correctamente")
        Me.Close()
    End Sub

    Private Sub btnLimpiarCampos_Click(sender As Object, e As EventArgs) Handles btnLimpiarCampos.Click
        Me.Close()
    End Sub
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        tbUsuarioFoliosDigitales.Text = DB.obtenerUsuarioFD()
        tbPasswordFoliosDigitales.Text = DB.contrasenaFD()
        tbEmisorRFC.Text = DB.obtenerEmisorRFC()
        tbEmisorRazonSocial.Text = DB.obtenerEmisorRazonSocial()
        tbFacturacionRutaXMLST.Text = DB.obtenerRutaXMLST()
        tbFacturacionRutaXMLT.Text = DB.obtenerRutaXML()
        tbConexionRutaPfx.Text = DB.obtenerRutaPFX()
        tbConexionContrasenaPfx.Text = DB.obtenerContrasenaPFX()
        tbConexionRutaCertificado.Text = DB.obtenerRutaCertificado()
        tbLugarExpedicion.Text = DB.obtenerEmisorLugarExpedicion()
        cargarRegimenesFiscales()
        If DB.obtenerEmisorRegimenFiscal() IsNot Nothing Then
            cbRegimenesFiscales.SelectedValue = DB.obtenerEmisorRegimenFiscal()
        End If

        ' Add any initialization after the InitializeComponent() call.

    End Sub
End Class