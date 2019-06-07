Public Class wCliente
    Public Sub New()
        InitializeComponent()
        cbUsoCfdi.DisplayMember = "Descripcion"
        cbUsoCfdi.ValueMember = "Id"
        cbUsoCfdi.DataSource = DB.obtenerUsosCfdi()
    End Sub

    Private Function validaCampos() As Boolean
        If tbRfc.Text.Trim() = String.Empty Then Return False
        If tbRazonSocial.Text.Trim() = String.Empty Then Return False
        If cbUsoCfdi.SelectedItem Is Nothing Then Return False
        Return True
    End Function

    Private Sub btnGuardarCliente_Click(sender As Object, e As EventArgs) Handles btnGuardarCliente.Click
        If MsgBox("¿ Desea guardar los cambios ?", MsgBoxStyle.YesNo, "efactura33") = MsgBoxResult.Yes Then
            If Not validaCampos() Then Return
            DB.guardarCliente(tbRfc.Text, tbRazonSocial.Text, cbUsoCfdi.SelectedValue.ToString(), tbCalle.Text, tbNumeroExt.Text, tbNumeroInt.Text, tbColonia.Text, tbLocalidad.Text, tbReferencia.Text, tbMunicipio.Text, tbEstado.Text, tbPais.Text, tbCodigoPostal.Text)
            Me.Close()
        End If
    End Sub
End Class