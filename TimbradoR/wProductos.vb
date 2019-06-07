Imports System.Data.SqlClient

Public Class wProductos
    Private table As System.Data.DataTable
    Private row As System.Data.DataRow

    Private Sub actualizarGrid()
        dgvConceptos.DataSource = DB.obtenerProductos()
        dgvConceptos.Columns("IdProducto").Visible = False
        dgvConceptos.Columns("IdUnidad").Visible = False
        dgvConceptos.Columns("IdClaveProdServ").Visible = False
    End Sub

    Private Sub btnComprobante_Click(sender As Object, e As EventArgs) Handles btnAgregarProducto.Click
        Dim ap As wProducto = New wProducto()
        ap.ShowDialog()

        'actualizarGrid()
        carga_productos()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        'If dgvConceptos.CurrentCell Is Nothing Then
        '    MessageBox.Show("Selecciona un producto", "Eliminar producto...", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    Return
        'End If

        'Dim result As DialogResult = MessageBox.Show("Confirma que deseas eliminar el producto", "Eliminar producto...", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        'If result = System.Windows.Forms.DialogResult.Yes Then
        '    Dim r As Integer = dgvConceptos.CurrentCell.RowIndex
        '    DB.eliminarProducto(dgvConceptos.Rows(r).Cells("idProducto").Value)
        '    carga_productos()
        'End If
    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        ' actualizarGrid()
        carga_productos()
        ' Add any initialization after the InitializeComponent() call.

    End Sub


    Sub carga_productos()

        SQL = "SELECT [idProducto] " &
                      ",[codigo] " &
                      ",[descripcion] " &
                      ",[precio] " &
                      ",[unidad] " &
                      ",[idClaveProdServ] " &
                      ",[idClaveUnidad] " &
                  "FROM [dbo].[tblproductos] ORDER BY idProducto ASC"


        Dim da As New SqlDataAdapter(SQL, DB.obtenerConexionDB)
        Dim ds As New DataSet
        Try
            da.Fill(ds)

            If ds.Tables(0).Rows.Count = 0 Then
                ' MsgBox("Registro No Encontrado, Verifique", MsgBoxStyle.Information)
                Me.dgvConceptos.DataSource = Nothing
                'lblRegistroArchivosEquipo.Text = "0"

            Else

                'lblRegistroArchivosEquipo.Text = ds.Tables(0).Rows.Count

                table = New System.Data.DataTable()
                table.Columns.Add("IdProducto", GetType(System.String))
                table.Columns.Add("Código", GetType(System.String))
                table.Columns.Add("Descripción", GetType(System.String))
                table.Columns.Add("Precio", GetType(System.String))
                table.Columns.Add("Unidad", GetType(System.String))
                table.Columns.Add("idClaveProdServ", GetType(System.String))
                table.Columns.Add("idClaveUnidad", GetType(System.String))


                For i As Integer = 0 To ds.Tables(0).Rows.Count - 1

                    Row = table.NewRow()

                    row("IdProducto") = ds.Tables(0).Rows(i)(0).ToString
                    row("Código") = ds.Tables(0).Rows(i)(1).ToString
                    row("Descripción") = ds.Tables(0).Rows(i)(2).ToString
                    row("Precio") = ds.Tables(0).Rows(i)(3).ToString
                    row("Unidad") = ds.Tables(0).Rows(i)(4).ToString
                    row("idClaveProdServ") = ds.Tables(0).Rows(i)(5).ToString
                    row("idClaveUnidad") = ds.Tables(0).Rows(i)(6).ToString


                    table.Rows.Add(Row)

                    Me.dgvConceptos.DataSource = table

                Next

                dgvConceptos.Columns(0).Width = 60  'IdProducto
                dgvConceptos.Columns(1).Width = 100  'Código
                dgvConceptos.Columns(2).Width = 350  'Descripción
                dgvConceptos.Columns(3).Width = 100  'Precio
                dgvConceptos.Columns(4).Width = 100  'Unidad
                dgvConceptos.Columns(5).Width = 150  'idClaveProdServ
                dgvConceptos.Columns(6).Width = 150  'idClaveUnidad


                dgvConceptos.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter   'IdProducto
                dgvConceptos.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter   'Código
                dgvConceptos.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft     'Descripción
                dgvConceptos.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight   'Precio
                dgvConceptos.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter   'Unidad
                dgvConceptos.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter   'idClaveProdServ
                dgvConceptos.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter   'idClaveUnidad


            End If

        Catch ex As Exception
            Beep()
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical)
            Exit Sub
        End Try

    End Sub

    Private Sub dgvConceptos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvConceptos.CellContentClick

    End Sub

    Private Sub dgvConceptos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvConceptos.CellDoubleClick

        If dgvConceptos.CurrentCell Is Nothing Then
            MessageBox.Show("Selecciona un producto", "Eliminar producto...", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim result As DialogResult = MessageBox.Show("Confirma que deseas eliminar el producto", "Eliminar producto...", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = System.Windows.Forms.DialogResult.Yes Then
            Dim r As Integer = dgvConceptos.CurrentCell.RowIndex
            DB.eliminarProducto(dgvConceptos.Rows(r).Cells("idProducto").Value)
            carga_productos()
        End If


    End Sub
End Class