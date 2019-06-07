Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Public Class frmUsuarios
    '******************************************************
    Private table As System.Data.DataTable
    Private row As System.Data.DataRow
    '******************************************************
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        listado_usuarios()
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub frmUsuarios_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnAgregarUsuario_Click(sender As Object, e As EventArgs) Handles btnAgregarUsuario.Click

        frmAgregaUsuarios.ShowDialog()
    End Sub
    Sub listado_usuarios()

        SQL = "SELECT   us_id   " &
                               ",  us_nombre   " &
                               ",  us_pass   " &
                               ",  us_fecha_alta   " &
                               ",  us_status   " &
                               ",  us_nivel   " &
                               ",  us_empresa   " &
                           "FROM   tblusuarios   WHERE us_status = '1' AND   us_empresa    = '" & Variables.EMPRESA_SISTEMA & "' "

        Dim conectar As New SqlConnection(DB.obtenerConexionDB)

        Dim da As New SqlDataAdapter(SQL, conectar)
        Dim ds As New DataSet
        Try
            da.Fill(ds)

            If ds.Tables(0).Rows.Count = 0 Then
                dgvUsuarios.DataSource = Nothing

                'lblregistros.Text = 0
            Else
                table = New System.Data.DataTable()
                table.Columns.Add("Id", GetType(System.String))
                table.Columns.Add("Nombre Completo", GetType(System.String))
                table.Columns.Add("Nivel", GetType(System.String))
                table.Columns.Add("Empresa", GetType(System.String))
                table.Columns.Add("Fecha Alta", GetType(System.String))
                table.Columns.Add("Status", GetType(System.String))

                ' lblregistros.Text = ds.Tables(0).Rows.Count
                MDIPrincipal.barra.Visible = True
                MDIPrincipal.barra.Value = 0
                MDIPrincipal.barra.Minimum = 0
                MDIPrincipal.barra.Maximum = ds.Tables(0).Rows.Count
                For i As Integer = 0 To ds.Tables(0).Rows.Count - 1

                    row = table.NewRow()
                    row("Id") = ds.Tables(0).Rows(i)(0).ToString
                    row("Nombre Completo") = ds.Tables(0).Rows(i)(1).ToString
                    row("Nivel") = ds.Tables(0).Rows(i)(5).ToString
                    row("Empresa") = ds.Tables(0).Rows(i)(6).ToString
                    row("Fecha Alta") = ds.Tables(0).Rows(i)(3).ToString
                    row("Status") = ds.Tables(0).Rows(i)(4).ToString

                    table.Rows.Add(row)
                    Me.dgvUsuarios.DataSource = table
                    ' Me.GridView1_xls.DataSource = table
                    ' Me.GridView1_xls.DataBind()


                    MDIPrincipal.barra.Value = MDIPrincipal.barra.Value + 1
                Next
                ' MDIPrincipal.barra.Visible = False
                dgvUsuarios.Columns(0).Width = 35 'ID
                dgvUsuarios.Columns(1).Width = 150 'NOMBRE
                dgvUsuarios.Columns(2).Width = 150 'APELLIDOS
                dgvUsuarios.Columns(3).Width = 120 'NIVEL
                dgvUsuarios.Columns(4).Width = 150 'EMPRESA
                dgvUsuarios.Columns(5).Width = 150 'FECHA ALTA

                color_status_usuarios()


            End If

        Catch ex As Exception
            MsgBox("ERROR: " & ex.Message, MsgBoxStyle.Critical)
            Exit Sub
        End Try

    End Sub
    Sub color_status_usuarios()

        If dgvUsuarios.RowCount > 0 Then

            For Each Row As DataGridViewRow In dgvUsuarios.Rows

                If Row.Cells("Nivel").Value = "ADMINISTRADOR" Then
                    Row.DefaultCellStyle.BackColor = Color.Green
                    Row.DefaultCellStyle.ForeColor = Color.White
                End If

                If Row.Cells("Nivel").Value = "SUPERVISOR" Then
                    Row.DefaultCellStyle.BackColor = Color.Yellow
                    Row.DefaultCellStyle.ForeColor = Color.Black
                End If

                If Row.Cells("Nivel").Value = "EMPLEADO" Then
                    Row.DefaultCellStyle.BackColor = Color.Red
                    Row.DefaultCellStyle.ForeColor = Color.Black
                End If

            Next
        End If
    End Sub

End Class