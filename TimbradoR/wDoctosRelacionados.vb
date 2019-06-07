Imports System.Data.SqlClient

Public Class wDoctosRelacionados

    Public _documentosRelacionados As List(Of DoctoRelacionado)
    Private bs As BindingSource = New BindingSource()

    Public Sub New(documentos As List(Of DoctoRelacionado))
        _documentosRelacionados = documentos
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        dgvDocumentos.DataSource = _documentosRelacionados
        cbMetodoPago.ValueMember = "MetodoPago"
        cbMoneda.ValueMember = "Moneda"
        cbMetodoPago.DataSource = DB.obtenerMetodosPago()
        cbMoneda.DataSource = DB.obtenerMonedas()
        bs.DataSource = _documentosRelacionados
        dgvDocumentos.DataSource = bs
        dgvDocumentos.Columns("MonedaDR").Visible = False
        dgvDocumentos.Columns("TipoCambioDR").Visible = False
        dgvDocumentos.Columns("MetodoDePagoDR").Visible = False
        dgvDocumentos.Columns("NumParcialidad").Visible = False
        dgvDocumentos.Columns("ImpSaldoAnt").Visible = False
        dgvDocumentos.Columns("ImpPagado").Visible = False
        dgvDocumentos.Columns("ImpSaldoInsoluto").Visible = False
        dgvDocumentos.Columns("cEliminar").DisplayIndex = 6
    End Sub
    Private Function validaCampos() As Boolean
        If (tbIdDocumento.Text.Trim() = String.Empty) Then
            Return False
        ElseIf (cbMoneda.SelectedValue = Nothing) Then
            Return False
        ElseIf (cbMetodoPago.SelectedValue = Nothing) Then
            Return False
        End If
        Return True
    End Function

    Private Function limpiarCampos()
        tbIdDocumento.Text = String.Empty
        tbFolio.Text = String.Empty
        tbSerie.Text = String.Empty
        tbNumeroParcialidad.Text = String.Empty
        tbTipoCambio.Text = String.Empty
        cbMetodoPago.SelectedIndex = 0
        cbMoneda.SelectedIndex = 0
        nudImporteInsoluto.Value = 0
        nudImportePagado.Value = 0
        nudImporteSaldoAnterior.Value = 0
    End Function

    Private Sub btnAgregaConcepto_Click(sender As Object, e As EventArgs) Handles btnAgregaConcepto.Click
        If (validaCampos() = False) Then
            Return
        End If
        Dim dr As DoctoRelacionado = New DoctoRelacionado()
        dr.Folio = tbFolio.Text.Trim()
        dr.IdDocumento = tbIdDocumento.Text.Trim()
        dr.ImpPagado = nudImportePagado.Value
        dr.ImpSaldoAnt = nudImporteSaldoAnterior.Value
        dr.ImpSaldoInsoluto = nudImporteInsoluto.Value
        dr.MetodoDePagoDR = cbMetodoPago.SelectedValue
        dr.MonedaDR = cbMoneda.SelectedValue
        dr.NumParcialidad = tbNumeroParcialidad.Text.Trim()
        dr.Serie = tbSerie.Text.Trim()
        dr.TipoCambioDR = tbTipoCambio.Text.Trim()
        _documentosRelacionados.Add(dr)
        bs.ResetBindings(False)
        limpiarCampos()
    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles nudImporteSaldoAnterior.ValueChanged

    End Sub

    Private Sub dgvDocumentos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDocumentos.CellClick
        If (e.RowIndex = dgvDocumentos.NewRowIndex Or e.RowIndex < 0) Then
            Return
        End If

        If (e.ColumnIndex = dgvDocumentos.Columns("cEliminar").Index) Then
            _documentosRelacionados.RemoveAt(e.RowIndex)
            bs.ResetBindings(False)
        End If
    End Sub

    Private Sub cbMetodoPago_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbMetodoPago.SelectedIndexChanged
        If (cbMetodoPago.SelectedValue = Nothing) Then
            Return
        End If

        If (cbMetodoPago.SelectedValue = "PUE") Then
            tbNumeroParcialidad.Enabled = False
            nudImporteInsoluto.Enabled = False
            nudImportePagado.Enabled = False
            nudImporteSaldoAnterior.Enabled = False
        Else
            tbNumeroParcialidad.Enabled = True
            nudImporteInsoluto.Enabled = True
            nudImportePagado.Enabled = True
            nudImporteSaldoAnterior.Enabled = True
        End If
    End Sub

    Private Sub cbMoneda_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbMoneda.SelectedIndexChanged
        If (cbMoneda.SelectedValue = Nothing) Then
            Return
        End If

        If (cbMoneda.SelectedValue = "MXN") Then
            tbTipoCambio.Enabled = False
        Else
            tbTipoCambio.Enabled = True

        End If
    End Sub

    Private Sub btnConceptoLimpiar_Click(sender As Object, e As EventArgs) Handles btnConceptoLimpiar.Click
        limpiarCampos()
    End Sub

    Private Sub TbIdDocumento_TextChanged(sender As Object, e As EventArgs) Handles tbIdDocumento.TextChanged

    End Sub

    Private Sub TableLayoutPanel8_Paint(sender As Object, e As PaintEventArgs) Handles tableLayoutPanel8.Paint

    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

        SQL = "SELECT [id] " &
                    ",[folio] " &
                    ",[version] " &
                    ",[serie] " &
                    ",[fecha] " &
                    ",[LugarExpedicion] " &
                    ",[NumCtaPago] " &
                    ",[TipodeComprobante] " &
                    ",[condicionesDePago] " &
                    ",[metodoDePago] " &
                    ",[formaDePago] " &
                    ",[TipoCambio] " &
                    ",[Moneda] " &
                    ",[subTotal] " &
                    ",[total]          " &
                "FROM [ARASIS_XML_ENCABEZADO] " &
               "WHERE [id] = '" & tbIdDocumento.Text.Trim & "' "

        Dim da As New SqlDataAdapter(SQL, DB.obtenerConexionDB)
        Dim ds As New DataSet

        Try
            da.Fill(ds)

            If ds.Tables(0).Rows.Count = 0 Then
                Exit Sub
            Else

                Dim i As Integer

                tbSerie.Text = ""
                tbFolio.Text = ""
                cbMoneda.Text = ""
                cbMetodoPago.Text = ""
                nudImportePagado.Value = 0
                For i = 0 To ds.Tables(0).Rows.Count - 1


                    tbSerie.Text = ds.Tables(0).Rows(i)(3).ToString()
                    tbFolio.Text = ds.Tables(0).Rows(i)(1).ToString()
                    cbMoneda.SelectedItem = ds.Tables(0).Rows(i)(1).ToString() + "- MXN Peso Mexicano"
                    cbMetodoPago.SelectedItem = ds.Tables(0).Rows(i)(1).ToString()
                    nudImportePagado.Value = ds.Tables(0).Rows(i)(14).ToString()


                    '                    moneda  descripcion
                    'MXN Peso Mexicano
                    'USD Dolar americano

                Next

            End If

        Catch ex As Exception
            MsgBox("ERROR: " & ex.Message, MsgBoxStyle.Critical)
            Exit Sub
        End Try


    End Sub
End Class