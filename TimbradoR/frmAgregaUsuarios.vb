Imports System.Data.SqlClient
Imports System.Text
Imports MySql.Data.MySqlClient

Public Class frmAgregaUsuarios
    Dim depto As String
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        carga_departamentos()
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub frmAgregaUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Sub CARGA_NIVELES()

        cmbnivel.Items.Clear()

        SQL = "SELECT   niv_descripcion   FROM   PVD_NIVEL  "

        Dim da As New SqlDataAdapter(SQL, DB.obtenerConexionDB)
        Dim ds As New DataSet

        Try
            da.Fill(ds)
        Catch ex As Exception
            MsgBox("ERROR: " & ex.Message, MsgBoxStyle.Critical)
            Exit Sub
        End Try

        If ds.Tables(0).Rows.Count = 0 Then

        Else
            'barra.Visible = True
            'barra.Value = 0
            'barra.Minimum = 0
            'barra.Maximum = ds.Tables(0).Rows.Count
            cmbnivel.Items.Add("")
            For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
                cmbnivel.Items.Add(ds.Tables(0).Rows(i)(0).ToString)
                ' barra.Value = barra.Value + 1
            Next
            ' barra.Visible = False
        End If

    End Sub
    Sub carga_departamentos()

        cmbdepto.Items.Clear()
        'cmbDeptoListaUsuarios.Items.Clear()

        SQL = "SELECT  [dep_departamento]  from    [ARASIS_DEPARTAMENTOS]  order by [dep_departamento] asc "

        Dim da As New SqlDataAdapter(SQL, DB.obtenerConexionDB)
        Dim ds As New DataSet

        Try
            da.Fill(ds)

            If ds.Tables(0).Rows.Count = 0 Then
                Exit Sub
            Else

                Dim i As Integer
                cmbdepto.Items.Add("")
                'cmbDeptoListaUsuarios.Items.Add("")
                For i = 0 To ds.Tables(0).Rows.Count - 1
                    cmbdepto.Items.Add(ds.Tables(0).Rows(i)(0).ToString())
                    'cmbDeptoListaUsuarios.Items.Add(ds.Tables(0).Rows(i)(0).ToString())
                Next
            End If

        Catch ex As Exception
            MsgBox("ERROR: " & ex.Message, MsgBoxStyle.Critical)
            Exit Sub
        End Try
    End Sub
    Sub carga_puestos()

        cmbPuesto.Items.Clear()
        'cmbPuestoListaUsuarios.Items.Clear()

        SQL = "SELECT  [pue_descripcion]  from    [ARASIS_PUESTOS]  order by [pue_descripcion] asc "

        Dim da As New SqlDataAdapter(SQL, DB.obtenerConexionDB)
        Dim ds As New DataSet

        Try
            da.Fill(ds)

            If ds.Tables(0).Rows.Count = 0 Then
                Exit Sub
            Else

                Dim i As Integer
                cmbPuesto.Items.Add("")
                'cmbPuestoListaUsuarios.Items.Add("")
                For i = 0 To ds.Tables(0).Rows.Count - 1
                    cmbPuesto.Items.Add(ds.Tables(0).Rows(i)(0).ToString())
                    'cmbPuestoListaUsuarios.Items.Add(ds.Tables(0).Rows(i)(0).ToString())
                Next
            End If

        Catch ex As Exception
            MsgBox("ERROR: " & ex.Message, MsgBoxStyle.Critical)
            Exit Sub
        End Try


    End Sub
    Private Sub btnGuardarUsuario_Click(sender As Object, e As EventArgs) Handles btnGuardarUsuario.Click

    End Sub
    'Sub GUARDA_USUARIOS()


    '    SQL = "INSERT INTO   PVD_USUARIOS   " &
    '                      "(  us_nombre   " &
    '                      ",  us_pass   " &
    '                      ",  us_status   " &
    '                      ",  us_nivel   " &
    '                      ",  us_fecha_alta  ,  us_usuario_creacion  ,  us_empresa  ) " &
    '                "VALUES " &
    '                      "('" & txtUsuarioNombre.Text & "'  " &
    '                        ",AES_ENCRYPT('" & txtpass.Text & "', 'ARASIS') " &
    '                        ",'1' " &
    '                        ",'" & cmbnivel.Text & "' " &
    '                        ",NOW() " &
    '                        ",'" & Variables.USUARIO_SISTEMA & "' " &
    '                        ",'" & Variables.EMPRESA_SISTEMA & "')"
    '    ' ",ENCRYPTBYPASSPHRASE('Desk', '" & txtpass.Text & "', 1, CONVERT(varbinary,'PVDESK')) " &
    '    ' AES_ENCRYPT('" & txtpass.Text & "', 'ARASIS')

    '    Dim da As New MySqlDataAdapter(SQL, conexion.cadena)
    '    Dim ds As New DataSet

    '    Try
    '        da.Fill(ds)

    '        limpia()
    '        MsgBox("Usuario Registrado Correctamente al Sistema", MsgBoxStyle.Information)
    '        ' MsgBox("Es Necesario Crear Privilegios al Usuario", MsgBoxStyle.Information)

    '        Me.Close()

    '        Exit Sub
    '    Catch ex As Exception
    '        MsgBox("ERROR: " & ex.Message, MsgBoxStyle.Critical)
    '        Exit Sub
    '    End Try

    'End Sub
    Sub VALIDA_GUARDAR_USUARIO()
        If txtNuevoUsuario.Text = "" Or txtpass.Text = "" Or cmbnivel.Text = "" Then
            MsgBox("Existen Campos Vacios, Verifique", MsgBoxStyle.Critical)
            Exit Sub
        End If

        '***************************
        If chkDepto.Checked = True Then

            If txtOtroDepto.Text = "" Then
                MsgBox("Imposible Guardar Campo Obligatorio, Verifique.")
                txtOtroDepto.Focus()
                Exit Sub
            Else
                depto = txtOtroDepto.Text
            End If


        End If

        If chkDepto.Checked = False Then

            If cmbdepto.Text = "" Then
                MsgBox("Imposible Guardar Campo Obligatorio, Verifique.")
                cmbdepto.Focus()
                Exit Sub
            Else
                depto = cmbdepto.Text
            End If


        End If
        '***************************

        If chkPuesto.Checked = True Then

            If txtOtroPuesto.Text = "" Then
                MsgBox("Imposible Guardar Campo Obligatorio, Verifique.")
                txtOtroPuesto.Focus()
                Exit Sub
            Else
                PUESTO = txtOtroPuesto.Text
            End If


        End If

        If chkPuesto.Checked = False Then

            If cmbPuesto.Text = "" Then
                MsgBox("Imposible Guardar Campo Obligatorio, Verifique.")
                cmbPuesto.Focus()
                Exit Sub
            Else
                PUESTO = cmbPuesto.Text
            End If


        End If

        If chkDepto.Checked = True Then
            guarda_depto()
        End If


        If chkPuesto.Checked = True Then
            guarda_puesto()
        End If

        GUARDA_USUARIOS()

    End Sub
    Sub guarda_depto()




        SQL = "INSERT INTO   ARASIS_departamentos  " &
                           "( dep_departamento  " &
                           ", dep_status  " &
                           ", dep_fecha_registro  " &
                           ", dep_usuario  ) " &
                     "VALUES " &
                           "('" & depto & "' " &
                           ",'1' " &
                           ",GETDATE() " &
                           ",'" & Variables.USUARIO_SISTEMA & "' ) "

        Dim da As New SqlDataAdapter(SQL, DB.obtenerConexionDB)
        Dim ds As New DataSet

        Try

            da.Fill(ds)

        Catch ex As Exception
            MsgBox("Error en guardar registro: " & ex.Message, MsgBoxStyle.Critical)
            Exit Sub
        End Try

    End Sub
    Sub guarda_puesto()


        SQL = "INSERT INTO   ARASIS_PUESTOS  " &
                           "( pue_descripcion  " &
                           ", pue_status  " &
                           ", pue_fecha_registro  " &
                           ", pue_usuario_alta  ) " &
                     "VALUES " &
                           "('" & PUESTO & "' " &
                           ",'1' " &
                           ",GETDATE() " &
                           ",'" & Variables.USUARIO_SISTEMA & "' )   "

        Dim da As New SqlDataAdapter(SQL, DB.obtenerConexionDB)
        Dim ds As New DataSet

        Try

            da.Fill(ds)

        Catch ex As Exception
            MsgBox("Error en guardar registro: " & ex.Message, MsgBoxStyle.Critical)
            Exit Sub
        End Try

    End Sub
    Sub GUARDA_USUARIOS()

        Dim statusOC As String

        SQL = "INSERT INTO   ARASIS_USUARIOS   " &
                          "(  us_nombre   " &
                          ",  us_pass   " &
                          ",  us_status   " &
                          ",  us_nivel   " &
                          ",  us_fecha_alta  ,  us_usuario_creacion  ,  us_empresa,us_departamento,us_puesto,us_autoiza_oc  ) " &
                    "VALUES " &
                          "('" & txtNuevoUsuario.Text & "'  " &
                            ",ENCRYPTBYPASSPHRASE('Desk', '" & txtpass.Text & "', 1, CONVERT(varbinary,'SIEL')) " &
                            ",'1' " &
                            ",'" & cmbnivel.Text & "' " &
                            ",GETDATE
                            () " &
                            ",'" & Variables.USUARIO_SISTEMA & "' " &
                            ",'" & Variables.EMPRESA_SISTEMA & "','" & depto & "','" & PUESTO & "','" & statusOC & "')"
        ' ",ENCRYPTBYPASSPHRASE('Desk', '" & txtpass.Text & "', 1, CONVERT(varbinary,'PVDESK')) " &
        ' AES_ENCRYPT('" & txtpass.Text & "', 'ARASIS')

        Dim da As New SqlDataAdapter(SQL, DB.obtenerConexionDB)
        Dim ds As New DataSet

        Try
            da.Fill(ds)

            'limpia_variables_usuarios()
            MsgBox("Usuario Registrado Correctamente al Sistema", MsgBoxStyle.Information)

            Me.Close()

            Exit Sub
        Catch ex As Exception
            MsgBox("ERROR: " & ex.Message, MsgBoxStyle.Critical)
            Exit Sub
        End Try

    End Sub
    Sub limpia()


    End Sub

    Private Sub chkDepto_CheckedChanged(sender As Object, e As EventArgs) Handles chkDepto.CheckedChanged
        If chkDepto.Checked = True Then
            txtOtroDepto.Text = ""
            txtOtroDepto.Visible = True
            cmbdepto.Text = ""
            cmbdepto.Enabled = False
        End If
        If chkDepto.Checked = False Then
            txtOtroDepto.Text = ""
            txtOtroDepto.Visible = False
            cmbdepto.Text = ""
            cmbdepto.Enabled = True
        End If
    End Sub

    Private Sub chkPuesto_CheckedChanged(sender As Object, e As EventArgs) Handles chkPuesto.CheckedChanged
        If chkPuesto.Checked = True Then
            txtOtroPuesto.Text = ""
            txtOtroPuesto.Visible = True
            cmbPuesto.Text = ""
            cmbPuesto.Enabled = False
        End If
        If chkPuesto.Checked = False Then
            txtOtroPuesto.Text = ""
            txtOtroPuesto.Visible = False
            cmbPuesto.Text = ""
            cmbPuesto.Enabled = True
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            txtpass.PasswordChar = ""
        End If
        If CheckBox1.Checked = False Then
            txtpass.PasswordChar = "*"
        End If
    End Sub

    Private Sub btnCreaPassword_Click(sender As Object, e As EventArgs) Handles btnCreaPassword.Click
        txtpass.Text = CrearPassword(6)
    End Sub
    Private Function CrearPassword(longitud As Integer) As String
        Dim caracteres As String = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890"
        Dim res As New StringBuilder()
        Dim rnd As New Random()
        While 0 < System.Math.Max(System.Threading.Interlocked.Decrement(longitud), longitud + 1)
            res.Append(caracteres(rnd.[Next](caracteres.Length)))
        End While
        Return res.ToString
    End Function
End Class