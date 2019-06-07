Imports System.Data.SqlClient

Public Enum TipoBusqueda
    ClaveProdServ
    Unidad
    Producto
End Enum

Public Class wBuscar
    Private table_CD As System.Data.DataTable
    Private row_CD As System.Data.DataRow
    Public claveProducto As cClaveProdServ
    Public unidad As cClaveUnidad
    Public producto As Producto
    Private tipoBusqueda As TipoBusqueda

    Public Sub New(ByVal tipobusqueda As TipoBusqueda)
        If tipobusqueda = TipoBusqueda.Unidad Then Me.Text = "Buscar unidad"
        If tipobusqueda = TipoBusqueda.Producto Then Me.Text = "Buscar producto"
        Me.tipoBusqueda = tipobusqueda
        InitializeComponent()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If tipoBusqueda = TipoBusqueda.ClaveProdServ Then
            dgvDatos.DataSource = DB.buscarClaveProductos(tbBuscar.Text.Trim())
            dgvDatos.Columns("Id").Visible = False
            dgvDatos.Columns("ClaveProdServ").Visible = False
            dgvDatos.Columns("Descripcion").Visible = False
        End If

        If tipoBusqueda = TipoBusqueda.Unidad Then
            dgvDatos.DataSource = DB.buscarUnidades(tbBuscar.Text.Trim())
            dgvDatos.Columns("Id").Visible = False
            dgvDatos.Columns("ClaveUnidad").Visible = False
            dgvDatos.Columns("Nombre").Visible = False
        End If

        If tipoBusqueda = TipoBusqueda.Producto Then
            dgvDatos.DataSource = DB.buscarProductos(tbBuscar.Text.Trim())
            dgvDatos.Columns("IdProducto").Visible = False
            dgvDatos.Columns("IdUnidad").Visible = False
            dgvDatos.Columns("IdClaveProdServ").Visible = False
        End If
    End Sub

    Private Sub btnSeleccionar_Click(sender As Object, e As EventArgs) Handles btnSeleccionar.Click
        If dgvDatos.CurrentCell Is Nothing Then Return
        Me.DialogResult = DialogResult.Yes
        If tipoBusqueda = TipoBusqueda.Unidad Then unidad = CType(dgvDatos.CurrentRow.DataBoundItem, cClaveUnidad)
        If tipoBusqueda = TipoBusqueda.ClaveProdServ Then claveProducto = CType(dgvDatos.CurrentRow.DataBoundItem, cClaveProdServ)
        If tipoBusqueda = TipoBusqueda.Producto Then producto = CType(dgvDatos.CurrentRow.DataBoundItem, Producto)
        Me.Close()
    End Sub

    Sub busca_descripcion()

        SQL = "SELECT [id] " &
                    ",[claveProdServ] " &
                    ",[descripcion] " &
                "FROM [facturacion33].[dbo].[tblcclaveprodserv] WHERE (UPPER(nombre) LIKE '%" & tbBuscar.Text.Trim & "%'"


        Dim da As New SqlDataAdapter(SQL, DB.obtenerConexionDB)
        Dim ds As New DataSet

        Try
            da.Fill(ds)

            If ds.Tables(0).Rows.Count = 0 Then
                ' MsgBox("Registro No Encontrado, Verifique", MsgBoxStyle.Information)
                Me.dgvDatos.DataSource = Nothing

                'lblTotalRegistros_CD.Text = "0"

            Else
                table_CD = New System.Data.DataTable()
                table_CD.Columns.Add("Id", GetType(System.String))
                table_CD.Columns.Add("ClaveProdServ", GetType(System.String))
                table_CD.Columns.Add("Descripción", GetType(System.String))


                'lblTotalRegistros_CD.Text = ds.Tables(0).Rows.Count

                For i As Integer = 0 To ds.Tables(0).Rows.Count - 1

                    row_CD = table_CD.NewRow()
                    row_CD("Id") = ds.Tables(0).Rows(i)(0).ToString
                    row_CD("ClaveProdServ") = ds.Tables(0).Rows(i)(1).ToString
                    row_CD("Descripción") = ds.Tables(0).Rows(i)(2).ToString

                    table_CD.Rows.Add(row_CD)

                    Me.dgvDatos.DataSource = table_CD

                Next

                dgvDatos.Columns(0).Width = 35  'Id
                dgvDatos.Columns(1).Width = 90  'Folio
                dgvDatos.Columns(2).Width = 350  'Versión

            End If

        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical)
            Exit Sub
        End Try

    End Sub
End Class