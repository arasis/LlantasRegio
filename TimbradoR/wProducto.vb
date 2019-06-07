Imports System.Data.SqlClient
Imports System.Math

Public Class wProducto
    Private unidad As cClaveUnidad
    Private producto As cClaveProdServ
    Dim AutoComp As New AutoCompleteStringCollection()
    Private Sub WProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CARGA_ARTICULOS()
    End Sub
    Private Sub btnBuscarClaveProd_Click(sender As Object, e As EventArgs) Handles btnBuscarClaveProd.Click
        Dim wb As wBuscar = New wBuscar(TipoBusqueda.ClaveProdServ)
        If wb.ShowDialog() = System.Windows.Forms.DialogResult.Yes Then
            producto = wb.claveProducto
            tbClaveProdServ.Text = producto.ClaveYDescripcion
        End If
    End Sub
    Sub carga_clientes()

    End Sub
    Private Sub btnBuscarUnidad_Click(sender As Object, e As EventArgs) Handles btnBuscarUnidad.Click
        Dim wb As wBuscar = New wBuscar(TipoBusqueda.Unidad)
        If wb.ShowDialog() = System.Windows.Forms.DialogResult.Yes Then
            unidad = wb.unidad
            tbClaveUnidad.Text = unidad.ClaveYDescripcion
        End If
    End Sub

    Private Function camposValidos() As Boolean
        If producto.Id Is Nothing Then Return False
        If unidad.Id Is Nothing Then Return False
        If tbDescripcion.Text.Trim() = String.Empty Then Return False
        If nudPrecio.Value <= 0 Then Return False
        Return True
    End Function

    Private Sub btnGuardarCliente_Click(sender As Object, e As EventArgs) Handles btnGuardarCliente.Click
        If Not camposValidos() Then Return
        DB.guardarProducto(producto.Id.ToString(), unidad.Id.ToString(), tbUnidad.Text, tbNoIdentificacion.Text, tbDescripcion.Text, nudPrecio.Value)
        Me.Close()
    End Sub

    Sub CARGA_ARTICULOS()


        ' cmbArtDescripcion.Items.Clear()

        SQL = "SELECT [Articulo] FROM [American].[dbo].[Art] WHERE [Estatus] = 'ALTA' ORDER BY [Articulo] ASC "


        Dim da As New SqlDataAdapter(SQL, DB.obtenerConexionDB)
        Dim ds As New DataSet

        Try
            da.Fill(ds)

            If ds.Tables(0).Rows.Count = 0 Then
                Exit Sub
            Else

                Dim i As Integer
                ' cmbProveedor.Items.Add("")
                For i = 0 To ds.Tables(0).Rows.Count - 1
                    ' cmbProveedor.Items.Add(ds.Tables(0).Rows(i)(0).ToString())
                    AutoComp.Add(ds.Tables(0).Rows(i)(0).ToString())
                Next



                'Set the some propersties of the text box to allow auto                   search
                'Or you may set this manaully on the textbox property window
                'txtProveedor.AutoCompleteMode = AutoCompleteMode.SuggestAppend
                'txtProveedor.AutoCompleteSource = AutoCompleteSource.ListItems
                'txtProveedor.AutoCompleteCustomSource = AutoComp

                txtArtIntelisis.AutoCompleteSource = AutoCompleteSource.CustomSource
                txtArtIntelisis.AutoCompleteCustomSource = AutoComp
                txtArtIntelisis.AutoCompleteMode = AutoCompleteMode.Suggest


            End If

        Catch ex As Exception
            MsgBox("ERROR: " & ex.Message, MsgBoxStyle.Critical)
            Exit Sub
        End Try


    End Sub

    Private Sub TxtArtIntelisis_TextChanged(sender As Object, e As EventArgs) Handles txtArtIntelisis.TextChanged
        If txtArtIntelisis.Text <> "" Then


            SQL = "SELECT [Descripcion1],[Articulo],[Unidad],[PrecioLista] " &
                    "FROM [American].[dbo].[Art]" &
                  " WHERE [Articulo]  = '" & txtArtIntelisis.Text & "' AND [Estatus] = 'ALTA' "

            Dim da As New SqlDataAdapter(SQL, DB.obtenerConexionDB)
            Dim ds As New DataSet


            Try
                da.Fill(ds)

                If ds.Tables(0).Rows.Count = 0 Then
                    Exit Sub
                Else

                    lblDescripcionArt.Text = ""
                    tbUnidad.Text = ""
                    tbNoIdentificacion.Text = ""
                    tbUnidad.Text = ""
                    Dim precio As Double



                    For i = 0 To ds.Tables(0).Rows.Count - 1

                        lblDescripcionArt.Text = ds.Tables(0).Rows(i)(0).ToString().Trim
                        tbDescripcion.Text = ds.Tables(0).Rows(i)(0).ToString().Trim


                        tbUnidad.Text = ds.Tables(0).Rows(i)(2).ToString().Trim
                        tbNoIdentificacion.Text = ds.Tables(0).Rows(i)(1).ToString().Trim

                        precio = Val(ds.Tables(0).Rows(i)(3).ToString)
                        nudPrecio.Value = Round(precio, 2)




                    Next
                End If

            Catch ex As Exception
                MsgBox("ERROR: " & ex.Message, MsgBoxStyle.Critical)
                Exit Sub
            End Try
        End If
    End Sub
End Class