Public Class wMenu
    Private Sub btnComprobante_Click(sender As Object, e As EventArgs) Handles btnComprobante.Click
        Dim p As Principal = New Principal()
        p.Show()
    End Sub

    Private Sub btnConfiguracion_Click(sender As Object, e As EventArgs) Handles btnConfiguracion.Click
        Dim c As wConfiguracion = New wConfiguracion()
        c.Show()
    End Sub

    Private Sub btnProductos_Click(sender As Object, e As EventArgs) Handles btnProductos.Click
        Dim p As wProductos = New wProductos()
        p.Show()
    End Sub

    Private Sub btnGenerarPDF_Click(sender As Object, e As EventArgs) Handles btnGenerarPDF.Click
        Dim wgpdf As wGeneraPDF = New wGeneraPDF()
        wgpdf.ShowDialog()
    End Sub

    Private Sub btnClientes_Click(sender As Object, e As EventArgs) Handles btnClientes.Click
        Dim wc As WClientes = New WClientes()
        wc.ShowDialog()
    End Sub

    Private Sub btnPagos_Click(sender As Object, e As EventArgs) Handles btnPagos.Click
        Dim wp As wPagos = New wPagos()
        wp.ShowDialog()
    End Sub


End Class