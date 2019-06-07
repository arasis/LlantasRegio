Public Class frmActividades
    Private _actividad As Actividades
    Private _bsSubactividades As BindingSource

    Public Property Actividad As Actividades
        Get
            Return _actividad
        End Get
        Set(value As Actividades)
            _actividad = value
        End Set
    End Property
    Public Sub New(ByVal actividad As Actividades)

        ' This call is required by the designer.
        InitializeComponent()
        _actividad = actividad
        cbActividad.DataSource = DB.obtenerActividades()
        cbActividad.DisplayMember = "Descripcion"
        cbActividad.ValueMember = "ACtividad"
        If (_actividad.ActividadRelacionada <> String.Empty) Then
            cbActividad.SelectedValue = _actividad.ActividadRelacionada
        End If

        _bsSubactividades = New BindingSource()
        _bsSubactividades.DataSource = _actividad.SubActividades
        dgvSubactividades.DataSource = _bsSubactividades
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub btnAgregarSubactividad_Click(sender As Object, e As EventArgs) Handles btnAgregarSubactividad.Click
        Dim faa As frmSubactividad = New frmSubactividad(New SubActividades, cbActividad.SelectedValue)
        If (faa.ShowDialog() = Windows.Forms.DialogResult.Yes) Then
            _actividad.SubActividades.Add(faa.Subactividad)
            _bsSubactividades.ResetBindings(False)
        End If
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        _actividad.ActividadRelacionada = cbActividad.SelectedValue
        DialogResult = Windows.Forms.DialogResult.Yes
        Close()
    End Sub

    Private Sub btnEliminarSubactividades_Click(sender As Object, e As EventArgs) Handles btnEliminarSubactividades.Click
        If (dgvSubactividades.SelectedCells.Count > 0) Then
            _actividad.SubActividades.RemoveAt(dgvSubactividades.SelectedCells.Item(0).RowIndex)
            _bsSubactividades.ResetBindings(False)
        Else
            IError("Selecciona una subactividad de la tabla")
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

    Private Sub btnEditarSubactividad_Click(sender As Object, e As EventArgs) Handles btnEditarSubactividad.Click
        If (dgvSubactividades.SelectedCells.Count > 0) Then
            Dim dr As SubActividades = dgvSubactividades.Rows(dgvSubactividades.SelectedCells.Item(0).RowIndex).DataBoundItem
            Dim fdr As frmSubactividad = New frmSubactividad(dr, cbActividad.SelectedValue)
            If (fdr.ShowDialog() = DialogResult.Yes) Then
                _actividad.SubActividades(dgvSubactividades.SelectedCells.Item(0).RowIndex) = fdr.Subactividad
                _bsSubactividades.ResetBindings(False)
            End If
        End If
    End Sub

    Private Sub deshabilitarBotonesSubactividades()
        If (dgvSubactividades.Rows.Count > 0) Then
            btnEditarSubactividad.Enabled = True
            btnEliminarSubactividades.Enabled = True
        Else
            btnEditarSubactividad.Enabled = False
            btnEliminarSubactividades.Enabled = False
        End If
    End Sub
    Private Sub dgvSubactividades_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles dgvSubactividades.RowsAdded
        deshabilitarBotonesSubactividades()
    End Sub

    Private Sub dgvSubactividades_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles dgvSubactividades.RowsRemoved
        deshabilitarBotonesSubactividades()
    End Sub
End Class