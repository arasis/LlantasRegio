Public Class frmYacimientos
    Private _yacimientos As Yacimientos
    Private _bsPozos As BindingSource
    Public Property Yacimiento As Yacimientos
        Get
            Return _yacimientos
        End Get
        Set(value As Yacimientos)
            _yacimientos = value
        End Set
    End Property
    Public Sub New(ByVal yacimientos As Yacimientos)
        _yacimientos = yacimientos
        ' This call is required by the designer.
        InitializeComponent()
        tbDescripcion.Text = _yacimientos.Yacimiento
        ' Add any initialization after the InitializeComponent() call.
        _bsPozos = New BindingSource()
        _bsPozos.DataSource = _yacimientos.Pozos
        dgvPozos.DataSource = _bsPozos
    End Sub

    Private Sub btnAgregarPozo_Click(sender As Object, e As EventArgs) Handles btnAgregarPozo.Click
        Dim ap As frmPozos = New frmPozos(New Pozos)
        If (ap.ShowDialog() = Windows.Forms.DialogResult.Yes) Then
            _yacimientos.Pozos.Add(ap.Pozo)
            _bsPozos.ResetBindings(False)
        End If
    End Sub

    Private Sub btnEliminarPozos_Click(sender As Object, e As EventArgs) Handles btnEliminarPozos.Click
        If (dgvPozos.SelectedCells.Count > 0) Then
            _yacimientos.Pozos.RemoveAt(dgvPozos.SelectedCells.Item(0).RowIndex)
            _bsPozos.ResetBindings(False)
        Else
            IError("Selecciona un pozo de la tabla")
        End If
    End Sub

    Private Sub btnEditarPozos_Click(sender As Object, e As EventArgs) Handles btnEditarPozos.Click
        If (dgvPozos.SelectedCells.Count > 0) Then
            Dim dr As Pozos = dgvPozos.Rows(dgvPozos.SelectedCells.Item(0).RowIndex).DataBoundItem
            Dim fdr As frmPozos = New frmPozos(dr)
            If (fdr.ShowDialog() = DialogResult.Yes) Then
                _yacimientos.Pozos(dgvPozos.SelectedCells.Item(0).RowIndex) = fdr.Pozo
                _bsPozos.ResetBindings(False)
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

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        _yacimientos.Yacimiento = tbDescripcion.Text.Trim()
        If (_yacimientos.Yacimiento = String.Empty) Then
            lError.Text = "El campo yacimiento es obligatorio"
            Timer1.Stop()
        End If

        DialogResult = Windows.Forms.DialogResult.Yes
        Close()
    End Sub
    Private Sub deshabilitarBotonesPozos()
        If dgvPozos.Rows.Count > 0 Then
            btnEditarPozos.Enabled = True
            btnEliminarPozos.Enabled = True
        Else
            btnEditarPozos.Enabled = False
            btnEliminarPozos.Enabled = False
        End If
    End Sub
    Private Sub dgvPozos_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles dgvPozos.RowsAdded
        deshabilitarBotonesPozos()
    End Sub

    Private Sub dgvPozos_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles dgvPozos.RowsRemoved
        deshabilitarBotonesPozos()
    End Sub
End Class