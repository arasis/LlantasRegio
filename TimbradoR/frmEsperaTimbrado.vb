Public Class frmEsperaTimbrado
    Dim contador As Byte = 4
    Private Sub FrmEsperaTimbrado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblMnesaje.Text = "¿ Desea generar su factura ?"


        'If Timbrar.timbrar(Variables.rutaXMLST, Variables.rutaXMLT, DB.obtenerUsuarioFD(), DB.contrasenaFD()) Then





        'End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        barra.Visible = True

        If barra.Value = 100 Then
            Me.Opacity -= 0.07
            If Me.Opacity = 0.0 Then

                Me.Close()
                Me.Timer1.Stop()
                Me.DialogResult = Windows.Forms.DialogResult.OK

            End If
            ' MsgBox("Factura Generada Correctamente")
        Else
            barra.Value += 4
            If barra.Value = contador Then
                lblMnesaje.Text = "GENERANDO ..........."
            End If
            If barra.Value = 99 Then
                lblMnesaje.Text = "FACTURA GENERADA CORRECTAMENTE"
            End If
        End If

    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Timer1.Start()

    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click

    End Sub
End Class