Public Class frmSubactividad
    Private _subactividad As SubActividades
    Private _bsTareas As BindingSource
    Public Property Subactividad As SubActividades
        Get
            Return _subactividad
        End Get
        Set(value As SubActividades)
            _subactividad = value
        End Set
    End Property
    Public Sub New(ByVal subactividad As SubActividades, claveActividad As String)

        ' This call is required by the designer.
        InitializeComponent()
        _subactividad = subactividad
        _bsTareas = New BindingSource()
        _bsTareas.DataSource = _subactividad.Tareas
        dgvTareas.DataSource = _bsTareas


        cbSubactividad.DataSource = DB.obtenerSubactividades(claveActividad)
        cbSubactividad.DisplayMember = "ClaveYDescripcion"
        cbSubactividad.ValueMember = "Subactividad"
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub btnAgregarTarea_Click(sender As Object, e As EventArgs) Handles btnAgregarTarea.Click

        If (Not _subactividad.Tareas.Find(Function(x) x.TareaRelacionada = cbTareas.SelectedValue.ToString()) Is Nothing) Then
            IError("Ya has elegido esta tarea")
            Return
        ElseIf cbTareas.SelectedValue Is Nothing Then
            IError("Selecciona una tarea")
            Return
        Else

        End If
        _subactividad.Tareas.Add(New Tareas With {.TareaRelacionada = cbTareas.SelectedValue})
        _bsTareas.ResetBindings(False)
    End Sub

    Private Sub cbSubactividad_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbSubactividad.SelectedIndexChanged
        cbTareas.DisplayMember = "ClaveYDescripcion"
        cbTareas.ValueMember = "Tarea"
        cbTareas.DataSource = DB.obtenerTareas(cbSubactividad.SelectedValue.ToString())

        _subactividad.Tareas.Clear()
        _bsTareas.ResetBindings(False)
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        _subactividad.SubActividadRelacionada = cbSubactividad.SelectedValue
        DialogResult = Windows.Forms.DialogResult.Yes
        Close()
    End Sub

    Private Sub btnEliminarTarea_Click(sender As Object, e As EventArgs) Handles btnEliminarTarea.Click
        If (dgvTareas.SelectedCells.Count > 0) Then
            _subactividad.Tareas.RemoveAt(dgvTareas.SelectedCells.Item(0).RowIndex)
            _bsTareas.ResetBindings(False)
        Else
            IError("Selecciona una tarea de la tabla")
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

    Private Sub deshabilitarTareas()
        If (dgvTareas.Rows.Count > 0) Then
            btnEliminarTarea.Enabled = True
        Else
            btnEliminarTarea.Enabled = False
        End If
    End Sub
    Private Sub dgvTareas_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles dgvTareas.RowsAdded
        deshabilitarTareas()
    End Sub

    Private Sub dgvTareas_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles dgvTareas.RowsRemoved
        deshabilitarTareas()
    End Sub
End Class