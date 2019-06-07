Public Class frmCentroCostos
    Private _centroCostos As CentroCostos
    Private _bsYacimientos As BindingSource
    Public Property CentroCostos
        Get
            Return _centroCostos
        End Get
        Set(value)
            _centroCostos = value
        End Set
    End Property
    Public Sub New(ByVal centroCostos As CentroCostos)
        _centroCostos = centroCostos

        ' This call is required by the designer.
        InitializeComponent()
        tbDescripcion.Text = centroCostos.Campo
        _bsYacimientos = New BindingSource()
        _bsYacimientos.DataSource = _centroCostos.Yacimientos
        dgvYacimientos.DataSource = _bsYacimientos
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub btnAgregarYacimiento_Click(sender As Object, e As EventArgs) Handles btnAgregarYacimiento.Click
        Dim fy As frmYacimientos = New frmYacimientos(New Yacimientos)
        If (fy.ShowDialog() = Windows.Forms.DialogResult.Yes) Then
            _centroCostos.Yacimientos.Add(fy.Yacimiento)
            _bsYacimientos.ResetBindings(False)
        End If
    End Sub

    Private Sub btnEliminarYacimiento_Click(sender As Object, e As EventArgs) Handles btnEliminarYacimiento.Click
        If (dgvYacimientos.SelectedCells.Count > 0) Then
            _centroCostos.Yacimientos.RemoveAt(dgvYacimientos.SelectedCells.Item(0).RowIndex)
            _bsYacimientos.ResetBindings(False)
        Else
            IError("Selecciona un centro de costo de la tabla")
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

    Private Sub btnEditarYacimiento_Click(sender As Object, e As EventArgs) Handles btnEditarYacimiento.Click
        If (dgvYacimientos.SelectedCells.Count > 0) Then
            Dim dr As Yacimientos = dgvYacimientos.Rows(dgvYacimientos.SelectedCells.Item(0).RowIndex).DataBoundItem
            Dim fdr As frmYacimientos = New frmYacimientos(dr)
            If (fdr.ShowDialog() = DialogResult.Yes) Then
                _centroCostos.Yacimientos(dgvYacimientos.SelectedCells.Item(0).RowIndex) = fdr.Yacimiento
                _bsYacimientos.ResetBindings(False)
            End If
        End If
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        _centroCostos.Campo = tbDescripcion.Text.Trim()
        DialogResult = Windows.Forms.DialogResult.Yes
        Close()
    End Sub
    Private Sub deshabilitarCentroCostos()
        If (dgvYacimientos.Rows.Count > 0) Then
            btnEditarYacimiento.Enabled = True
            btnEliminarYacimiento.Enabled = True
        Else
            btnEditarYacimiento.Enabled = False
            btnEliminarYacimiento.Enabled = False
        End If
    End Sub
    Private Sub dgvYacimientos_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles dgvYacimientos.RowsAdded
        deshabilitarCentroCostos()
    End Sub

    Private Sub dgvYacimientos_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles dgvYacimientos.RowsRemoved
        deshabilitarCentroCostos()
    End Sub
End Class