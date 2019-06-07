Imports System.Data.SqlClient
Imports System.DirectoryServices
Imports System.DirectoryServices.AccountManagement
Imports System.DirectoryServices.ActiveDirectory
Imports System.Drawing.Drawing2D
Imports System.IO
Imports MySql.Data.MySqlClient

Public Class frmLogin
    Dim usuarioda As String
    Dim AutoComp As New AutoCompleteStringCollection()

    ' TODO: inserte el código para realizar autenticación personalizada usando el nombre de usuario y la contraseña proporcionada 
    ' (Consulte https://go.microsoft.com/fwlink/?LinkId=35339).  
    ' El objeto principal personalizado se puede adjuntar al objeto principal del subproceso actual como se indica a continuación: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' donde CustomPrincipal es la implementación de IPrincipal utilizada para realizar la autenticación. 
    ' Posteriormente, My.User devolverá la información de identidad encapsulada en el objeto CustomPrincipal
    ' como el nombre de usuario, nombre para mostrar, etc.

    'Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click

    '    'Dim path As String = "LDAP://totis.com.mx"
    '    ''CAMBIAR POR VUESTRO PATH (URL DEL SERVICIO DE DIRECTORIO LDAP)
    '    ''Por ejemplo: 'LDAP://ejemplo.lan.es'
    '    'Dim dominio As String = "totis.com.mx"
    '    ''CAMBIAR POR VUESTRO DOMINIO
    '    'Dim usu As String = UsernameTextBox.Text
    '    ''USUARIO DEL DOMINIO
    '    'Dim pass As String = PasswordTextBox.Text
    '    ''PASSWORD DEL USUARIO
    '    'Dim domUsu As String = Convert.ToString(dominio & Convert.ToString("\")) & usu

    '    'usuarioda = domUsu
    '    ''CADENA DE DOMINIO + USUARIO A COMPROBAR
    '    'Dim permiso As Boolean = AutenticaUsuario(path, domUsu, pass)




    '    'If permiso Then
    '    '    ' variables.UsuarioLogin = UsernameTextBox.Text
    '    '    permitido.Visible = False
    '    '    'permitido.BackColor = Color.Green
    '    '    'permitido.ForeColor = Color.White
    '    '    'permitido.Text = "Acceso permitido"
    '    'Me.Hide()
    '    'Else
    '    '    PasswordTextBox.Text = ""

    '    '    permitido.Visible = True
    '    '    permitido.BackColor = Color.Red
    '    '    permitido.ForeColor = Color.Black
    '    '    permitido.Text = "Acceso denegado"
    '    '    ' MsgBox("Acceso denegado, Usuario o Contraseña Incorrectos.", MsgBoxStyle.Critical)
    '    '    Exit Sub
    '    'End If

    '    If PasswordTextBox.Text = "" Then
    '        MsgBox("Es Necesario la Contraseña para Accesar al Sistema, Verifique", MsgBoxStyle.Information)
    '        PasswordTextBox.Focus()
    '        PasswordTextBox.Text = ""
    '        Exit Sub
    '    Else
    '        Variables.rfc_login = txtUser.Text.Trim
    '        valida_usuario()
    '    End If
    'End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor)

        'Información de Copyright
        Copyright.Text = My.Application.Info.Copyright
        carga_usuarios_efactura33_hidrocarburos()
        'carga_usuarios()
        cmbUser.Focus()
    End Sub

    Private Sub frmLogin_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            If MsgBox("¿ Desea salir de Sistema ?", MsgBoxStyle.YesNo, "efactura33?") = MsgBoxResult.Yes Then
                Application.Exit()
            Else
                e.Cancel = True
            End If
        End If
    End Sub
    Sub carga_usuarios_efactura33_hidrocarburos()

        cmbUser.Items.Add("")  'DS SERVICIOS PETROLEROS
        'cmbUser.Items.Add("DSP061215SL4")  'DS SERVICIOS PETROLEROS
        'cmbUser.Items.Add("OCD120403JU9") 'OPERADORA DE CAMPOS DWF
        cmbUser.Items.Add("FEHJ730109BC9") 'Julio César Fernández Hernández
        cmbUser.Items.Add("TEST010203001") 'ARASIS




        'AutoComp.Add("DSP061215SL4")  'DS SERVICIOS PETROLEROS
        'AutoComp.Add("OCD120403JU9") 'OPERADORA DE CAMPOS DWF
        'AutoComp.Add("TEST010203001") 'ARASIS

        'txtUser.AutoCompleteSource = AutoCompleteSource.CustomSource
        'txtUser.AutoCompleteCustomSource = AutoComp
        'txtUser.AutoCompleteMode = AutoCompleteMode.Suggest


        'DSP061215SL4.arsis.com.mx
        'OCD120403JU9.arsis.com.mx

        'arasisco_DSP061215SL4
        'arasisco_OCD120403JU9

    End Sub
    Sub carga_usuarios()

        'cmbuser.Items.Clear()
        SQL = "SELECT   us_nombre    FROM   [dbo].[arasis_usuarios]   where  us_status   = '1' "

        Dim da As New SqlDataAdapter(SQL, DB.obtenerConexionDB)
        Dim ds As New DataSet

        Try
            da.Fill(ds)

            If ds.Tables(0).Rows.Count = 0 Then
                Exit Sub
            Else

                Dim I As Integer
                For I = 0 To ds.Tables(0).Rows.Count - 1
                    'cmbuser.Items.Add(ds.Tables(0).Rows(I)(0).ToString())
                    AutoComp.Add(ds.Tables(0).Rows(I)(0).ToString())
                Next

                'txtUser.AutoCompleteSource = AutoCompleteSource.CustomSource
                'txtUser.AutoCompleteCustomSource = AutoComp
                'txtUser.AutoCompleteMode = AutoCompleteMode.Suggest

            End If
        Catch ex As Exception
            MsgBox("ERROR: " & ex.Message, MsgBoxStyle.Critical)
            Exit Sub
        End Try
    End Sub

    Sub usuario()
        If PasswordTextBox.Text = "" Then
            MsgBox("Es Necesario la Contraseña para Accesar al Sistema, Verifique", MsgBoxStyle.Information)
            PasswordTextBox.Focus()
            PasswordTextBox.Text = ""
            Exit Sub
        Else
            Variables.rfc_login = cmbUser.Text.Trim
            valida_usuario()
        End If
    End Sub
    Sub valida_usuario()

        Dim PASS_DESCR As String = ""


        'SQL = "SELECT   us_id   " &
        '            ",  us_nombre     " &
        '            ",  us_pass   " &
        '            ",  us_fecha_alta   " &
        '            ",  us_status   " &
        '            ",  us_nivel   " &
        '            ",  us_empresa   " &
        '            ",  us_mail   " &
        '            ",  us_fecha_eliminacion   " &
        '            ",  us_usuario_eliminacion   " &
        '            ",  us_usuario_creacion   " &
        '            ",  AES_DECRYPT(us_pass, 'ARASIS') AS PASS " &
        '        "FROM   tblusuarios   " &
        '       "WHERE   us_nombre     = '" & cmbuser.Text & "'  "

        SQL = "SELECT   us_id   " &
                    ",  us_nombre     " &
                    ",  us_pass   " &
                    ",  us_fecha_alta   " &
                    ",  us_status   " &
                    ",  us_nivel   " &
                    ",  us_empresa   " &
                    ",  us_mail   " &
                    ",  us_fecha_eliminacion   " &
                    ",  us_usuario_eliminacion   " &
                    ",  us_usuario_creacion   " &
                    ",CONVERT(varchar,DECRYPTBYPASSPHRASE('Desk',us_pass,1,CONVERT(varbinary,'ARASIS'))) AS PASS " &
                    ",  us_departamento   " &
                    ",  us_puesto " &
              "FROM   [dbo].[arasis_usuarios]    " &
               "WHERE   us_nombre     = '" & cmbUser.Text.Trim & "'  "

        '",CONVERT(varchar,DECRYPTBYPASSPHRASE('Desk',us_pass,1,CONVERT(varbinary,'PVDESK'))) AS PASS " &
        'AES_DECRYPT(us_pass, 'ARASIS') AS PASS

        Dim da As New SqlDataAdapter(SQL, DB.obtenerConexionDB)
        Dim ds As New DataSet
        Try


            da.Fill(ds)

            If ds.Tables(0).Rows.Count = 0 Then
                MsgBox("Usuario o Contraseña no válida, Verifique", MsgBoxStyle.Critical)
                PasswordTextBox.Text = ""
                PasswordTextBox.Focus()
                ' Me.Hide()
                Exit Sub
            Else

                'Dim utf As New System.Text.UTF7Encoding()
                'PASS_DESCR = utf.GetString(ds.Tables(0).Rows(0)(11))

                PASS_DESCR = ds.Tables(0).Rows(0)(11).ToString

                If PasswordTextBox.Text.Trim = PASS_DESCR.Trim Then
                    Variables.USUARIO_SISTEMA = ds.Tables(0).Rows(0)(1).ToString()
                    Variables.NIVEL_SISTEMA = ds.Tables(0).Rows(0)(5).ToString()
                    Variables.EMPRESA_SISTEMA = ds.Tables(0).Rows(0)(6).ToString()
                    carga_informacion_fiscal_configuracion()


                    'Variables.DEPARTAMENTO_SISTEMA = ds.Tables(0).Rows(0)(12).ToString()
                    'Variables.PUESTO_SISTEMA = ds.Tables(0).Rows(0)(13).ToString()

                    'If ds.Tables(0).Rows(0)(14).ToString().Trim = "1" Then
                    '    Variables.AUT_OC = "AUTORIZA"
                    'Else
                    '    Variables.AUT_OC = "NO AUTORIZA"
                    'End If



                    ' email_user()
                    ' info_user()

                    MDIPrincipal.ToolStripStatusLabel2.Text = Variables.USUARIO_SISTEMA

                    MDIPrincipal.ToolStripStatusLabel4.Text = Variables.EMPRESA_SISTEMA
                    '' lblnivel.Text = ds.Tables(0).Rows(0)(5).ToString()

                    ''lblempresa.Text = Variables.EMPRESA_SISTEMA
                    MDIPrincipal.StatusStrip1.Visible = True


                    '
                    'If Variables.USUARIO_SISTEMA = "ADMINISTRADOR" And Variables.EMPRESA_SISTEMA = "ARASIS" Then
                    '    LinkLabel1.Visible = True
                    'Else
                    '    LinkLabel1.Visible = False
                    'End If

                    Me.Hide()

                Else
                    MsgBox("Usuario o Contraseña no válida, Verifique", MsgBoxStyle.Critical)
                    PasswordTextBox.Text = ""
                    PasswordTextBox.Focus()
                    PasswordTextBox.Text = ""

                    MDIPrincipal.StatusStrip1.Visible = False
                    Exit Sub
                End If



            End If
        Catch ex As Exception
            MsgBox("ERROR: " & ex.Message, MsgBoxStyle.Critical)
            Exit Sub
        End Try
    End Sub



    'Autenticar usuario en servidor de LDAP 
    'Private Function AutenticaUsuario(path As [String], user As [String], pass As [String]) As Boolean
    '    'Los datos que hemos pasado los 'convertimos' en una entrada de Active Directory para hacer la consulta
    '    Dim de As New DirectoryEntry(path, user, pass, AuthenticationTypes.Secure)



    '    Try
    '        'Inicia el chequeo con las credenciales que le hemos pasado
    '        'Si devuelve algo significa que ha autenticado las credenciales
    '        Dim ds As New DirectorySearcher(de)

    '        ds.FindOne()




    '        Return True
    '    Catch ex As Exception
    '        MsgBox("ERROR: " & ex.Message & "")
    '        'Si no devuelve nada es que no ha podido autenticar las credenciales
    '        'ya sea porque no existe el usuario o por que no son correctas
    '        Return False
    '    End Try
    'End Function

    Sub carga_informacion_fiscal_configuracion()

        SQL = "SELECT [usuarioFD] " &
                    ",[contrasenaFD] " &
                    ",[rutaCertificado] " &
                    ",[rutaPFX] " &
                    ",[contrasenaPFX] " &
                    ",[emisorRFC] " &
                    ",[emisorRazonSocial] " &
                    ",[emisorRegimenFiscal] " &
                    ",[emisorLugarExpedicion] " &
                    ",[Base64PFXCancelacion] " &
                    ",[SerieFactura] " &
                "FROM [dbo].[ARASIS_FISCALES] " &
               "WHERE [emisorRFC] = '" & Variables.USUARIO_SISTEMA & "' "

        Dim da As New SqlDataAdapter(SQL, DB.obtenerConexionDB)
        Dim ds As New DataSet

        Try
            da.Fill(ds)


            If ds.Tables(0).Rows.Count = 0 Then

                My.Settings.usuarioFD = String.Empty
                My.Settings.contrasenaFD = String.Empty
                My.Settings.rutaCertificado = String.Empty
                My.Settings.rutaPFX = String.Empty
                My.Settings.contrasenaPFX = String.Empty
                My.Settings.emisorRFC = String.Empty
                My.Settings.emisorRazonSocial = String.Empty
                My.Settings.emisorRegimenFiscal = String.Empty
                My.Settings.emisorLugarExpedicion = String.Empty
                My.Settings.Base64PFXCancelacion = String.Empty
                My.Settings.SerieFactura = String.Empty
                My.Settings.rutaXMLST = "C:\efactura33"
                My.Settings.rutaXML = "C:\efactura33"
                My.Settings.Save()

            Else

                Dim I As Integer
                For I = 0 To ds.Tables(0).Rows.Count - 1

                    My.Settings.usuarioFD = ds.Tables(0).Rows(I)(0).ToString()
                    My.Settings.contrasenaFD = ds.Tables(0).Rows(I)(1).ToString()
                    My.Settings.rutaCertificado = ds.Tables(0).Rows(I)(2).ToString()
                    My.Settings.rutaPFX = ds.Tables(0).Rows(I)(3).ToString()
                    My.Settings.contrasenaPFX = ds.Tables(0).Rows(I)(4).ToString()
                    My.Settings.emisorRFC = ds.Tables(0).Rows(I)(5).ToString()
                    My.Settings.emisorRazonSocial = ds.Tables(0).Rows(I)(6).ToString()
                    My.Settings.emisorRegimenFiscal = ds.Tables(0).Rows(I)(7).ToString()
                    My.Settings.emisorLugarExpedicion = ds.Tables(0).Rows(I)(8).ToString()
                    My.Settings.Base64PFXCancelacion = ds.Tables(0).Rows(I)(9).ToString()
                    My.Settings.SerieFactura = ds.Tables(0).Rows(I)(10).ToString()
                    My.Settings.rutaXMLST = "C:\efactura33"
                    My.Settings.rutaXML = "C:\efactura33"
                    My.Settings.Save()

                Next
                verifica_carpeta()
            End If


        Catch ex As Exception
            MsgBox("ERROR: " & ex.Message, MsgBoxStyle.Critical)
            Exit Sub
        End Try

    End Sub
    Sub verifica_carpeta()

        Try
            ' My.Computer.FileSystem.DeleteDirectory(ruta, FileIO.DeleteDirectoryOption.DeleteAllContents)

            If Not Directory.Exists("C:\efactura33") Then
                Directory.CreateDirectory("C:\efactura33")
            Else

                'Directory.Delete(ruta)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtUser_KeyPress(sender As Object, e As KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = True
            PasswordTextBox.Focus()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        usuario()
    End Sub

    Private Sub PasswordTextBox_TextChanged(sender As Object, e As EventArgs) Handles PasswordTextBox.TextChanged

    End Sub

    Private Sub PasswordTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles PasswordTextBox.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = True
            ' PasswordTextBox.Text = ""
            usuario()
        End If
    End Sub

    Private Sub CmbUser_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbUser.SelectedIndexChanged
        PasswordTextBox.Text = ""
        PasswordTextBox.Focus()

    End Sub
End Class
