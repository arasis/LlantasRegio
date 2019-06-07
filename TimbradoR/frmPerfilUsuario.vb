Imports System.Data.SqlClient

Public Class frmPerfilUsuario
    Private Sub FrmPerfilUsuario_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        carga_usuario()
        validaCampos()
    End Sub
    'Private Function validaCampos() As Boolean
    '    If tbUsuario.Text.Trim() = String.Empty Then Return False
    '    If tbEmpresa.Text.Trim() = String.Empty Then Return False
    '    If tbNivel.Text.Trim() = String.Empty Then Return False
    '    If tbEmail.Text.Trim() = String.Empty Then Return False
    '    If tbPassword.Text.Trim() = String.Empty Then Return False


    '    Return True
    'End Function
    Sub carga_usuario()


        SQL = "SELECT [us_id] " &
                    ",[us_nombre] " &
                    ",CONVERT(varchar,DECRYPTBYPASSPHRASE('Desk',us_pass,1,CONVERT(varbinary,'ARASIS'))) AS PASS " &
                    ",[us_nivel] " &
                    ",[us_empresa] " &
                    ",[us_mail] " &
                    "FROM [dbo].[arasis_usuarios] " &
               "WHERE [us_nombre] = '" & Variables.USUARIO_SISTEMA.Trim & "' " &
                 "AND [us_status] = '1' "

        Dim da As New SqlDataAdapter(SQL, DB.obtenerConexionDB)
        Dim ds As New DataSet

        Try
            da.Fill(ds)

            If ds.Tables(0).Rows.Count = 0 Then
                Exit Sub
            Else

                Dim I As Integer
                For I = 0 To ds.Tables(0).Rows.Count - 1

                    tbUsuario.Text = ds.Tables(0).Rows(I)(1).ToString()
                    tbEmpresa.Text = ds.Tables(0).Rows(I)(4).ToString()
                    tbNivel.Text = ds.Tables(0).Rows(I)(3).ToString()
                    tbEmail.Text = ds.Tables(0).Rows(I)(5).ToString()
                    tbPassword.Text = ds.Tables(0).Rows(I)(2).ToString()
                Next
            End If
        Catch ex As Exception
            MsgBox("ERROR: " & ex.Message, MsgBoxStyle.Critical)
            Exit Sub
        End Try

    End Sub

    Private Sub FrmPerfilUsuario_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub ChkPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkPassword.CheckedChanged
        If chkPassword.Checked = True Then
            tbPassword.PasswordChar = ""
        End If
        If chkPassword.Checked = False Then
            tbPassword.PasswordChar = "*"
        End If

    End Sub

    Private Sub BtnPerfilUsuario_Click(sender As Object, e As EventArgs) Handles btnPerfilUsuario.Click
        If MsgBox("¿ Desea guardar los cambios ?", MsgBoxStyle.YesNo, "efactura33") = MsgBoxResult.Yes Then
            If validaCampos() Then Return
            DB.guardarUsuario(tbUsuario.Text, tbEmpresa.Text, tbNivel.Text, tbEmail.Text, tbPassword.Text)
            MsgBox("Información Actualizada correctamente", MsgBoxStyle.OkOnly)
            Me.Close()
        End If
    End Sub

    Private Function validaCampos() As Boolean
        Dim hayError As Boolean = False

        '****+***********modificacion alex ramos 31/03/2019
        If tbUsuario.Text = "" Then
            lError.Text = "El campo Usuario es obligatorio"
            hayError = True
        ElseIf tbEmpresa.Text = "" Then
            lError.Text = "El campo Empresa es obligatorio"
            hayError = True
        ElseIf tbNivel.Text.Trim() = String.Empty Then
            lError.Text = "El campo Nivel es obligatorio"
            hayError = True
        ElseIf tbEmail.Text.Trim() = String.Empty Then
            lError.Text = "El campo Email es obligatorio"
            hayError = True
        ElseIf tbPassword.Text.Trim() = String.Empty Then
            lError.Text = "El campo Password es obligatorio"
            hayError = True
        End If


        If hayError Then
            tlpError.Visible = True
            timer1.Enabled = True
        End If

        Return hayError
    End Function

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles timer1.Tick
        tlpError.Visible = False
        lError.Text = String.Empty
        timer1.Enabled = False
    End Sub
End Class