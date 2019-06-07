Public Class frmGastosHidrocarburos
    Private _gastos As GastosHidrocarburos

    Private _bsErogaciones As BindingSource
    Public Sub New(ByVal gastos As GastosHidrocarburos)

        _gastos = gastos
        ' This call is required by the designer.
        InitializeComponent()
        _bsErogaciones = New BindingSource
        _bsErogaciones.DataSource = _gastos.Erogacion
        dgvErogaciones.DataSource = _bsErogaciones
        dgvErogaciones.Columns("TipoErogacion").HeaderText = "Tipo de erogación"
        dgvErogaciones.Columns("MontocuErogacion").HeaderText = "Montocu de erogación"
        dgvErogaciones.Columns("MontocuErogacion").DefaultCellStyle.Format = "F2"
        dgvErogaciones.Columns("Porcentaje").DefaultCellStyle.Format = "F3"
        dgvErogaciones.Columns("MontocuErogacion").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvErogaciones.Columns("Porcentaje").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        setGastos()
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub btnAgregarErogacion_Click(sender As Object, e As EventArgs) Handles btnAgregarErogacion.Click
        Dim fErogacion As frmErogacion = New frmErogacion(New Erogacion)
        If (fErogacion.ShowDialog() = Windows.Forms.DialogResult.Yes) Then
            _gastos.Erogacion.Add(fErogacion.Erogacion)
            _bsErogaciones.ResetBindings(False)
        End If
    End Sub

    Private Sub btnEliminarErogacion_Click(sender As Object, e As EventArgs) Handles btnEliminarErogacion.Click
        If (dgvErogaciones.SelectedCells.Count > 0) Then
            _gastos.Erogacion.RemoveAt(dgvErogaciones.SelectedCells.Item(0).RowIndex)
            _bsErogaciones.ResetBindings(False)
        Else
            IError("Selecciona una erogacion de la tabla")
        End If
    End Sub

    Private Sub btnEditarErogacion_Click(sender As Object, e As EventArgs) Handles btnEditarErogacion.Click
        If (dgvErogaciones.SelectedCells.Count > 0) Then
            Dim erogacion As Erogacion = dgvErogaciones.Rows(dgvErogaciones.SelectedCells.Item(0).RowIndex).DataBoundItem
            Dim fdr As frmErogacion = New frmErogacion(erogacion)
            If (fdr.ShowDialog() = DialogResult.Yes) Then
                _gastos.Erogacion(dgvErogaciones.SelectedCells.Item(0).RowIndex) = fdr.Erogacion
                _bsErogaciones.ResetBindings(False)
            End If
        End If
    End Sub

    Private Sub IError(mensaje As String)
        lError.Text = mensaje
        Timer1.Start()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lError.Text = "Listo"
        Timer1.Stop()
    End Sub
    Private Function getGastos()
        _gastos.NumeroContrato = tbNumeroContrato.Text.Trim()
        _gastos.AreaContractual = tbAreaContractual.Text.Trim()
    End Function
    Private Function setGastos()
        tbNumeroContrato.Text = _gastos.NumeroContrato
        tbAreaContractual.Text = _gastos.AreaContractual
    End Function

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        getGastos()
        If (_gastos.NumeroContrato = String.Empty) Then
            IError("Escribe el número de contrato")
            Return
        ElseIf (_gastos.Erogacion.Count = 0) Then
            IError("Se necesita por lo menos un documento relacionado")
            Return
        End If
        Close()
    End Sub
    Private Sub deshabilitarErogaciones()
        If (dgvErogaciones.Rows.Count > 0) Then
            btnEditarErogacion.Enabled = True
            btnEliminarErogacion.Enabled = True
        Else
            btnEditarErogacion.Enabled = False
            btnEliminarErogacion.Enabled = False
        End If
    End Sub
    Private Sub dgvErogaciones_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles dgvErogaciones.RowsAdded
        deshabilitarErogaciones()
    End Sub

    Private Sub dgvErogaciones_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles dgvErogaciones.RowsRemoved
        deshabilitarErogaciones()
    End Sub
End Class