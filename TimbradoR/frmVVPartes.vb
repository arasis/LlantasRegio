Public Class frmVVPartes
    Private _parte As VVParte
    Private _bs As BindingSource
    Private _bsInformacionAduanera As BindingSource
    Public Sub New()
        _parte = New VVParte()
        ' This call is required by the designer.
        InitializeComponent()
        RefreshDataBindings()
        ' Add any initialization after the InitializeComponent() call.
    End Sub
    Public Sub New(ByVal parte As VVParte)
        _parte = parte
        InitializeComponent()
        btnCancelar.Visible = False
        RefreshDataBindings()
    End Sub
    Public Property Parte As VVParte
        Get
            Return _parte
        End Get
        Set(value As VVParte)
            _parte = value
        End Set
    End Property
    Public Sub RefreshDataBindings()
        _bs = New BindingSource()
        _bs.DataSource = _parte
        _bsInformacionAduanera = New BindingSource()
        _bsInformacionAduanera.DataSource = _parte.InformacionAduanera

        tbDescripcion.DataBindings.Add("Text", _bs, "Descripcion", False, DataSourceUpdateMode.OnPropertyChanged)
        tbNoIdentificacion.DataBindings.Add("Text", _bs, "NoIdentificacion", False, DataSourceUpdateMode.OnPropertyChanged)
        tbUnidad.DataBindings.Add("Text", _bs, "Unidad", False, DataSourceUpdateMode.OnPropertyChanged)
        nudCantidad.DataBindings.Add("Value", _bs, "Cantidad", False, DataSourceUpdateMode.OnPropertyChanged)
        nudImporte.DataBindings.Add("Value", _bs, "Importe", False, DataSourceUpdateMode.OnPropertyChanged)
        nudValorUnitario.DataBindings.Add("Value", _bs, "ValorUnitario", False, DataSourceUpdateMode.OnPropertyChanged)
        dgvInformacionAduanera.DataSource = _bsInformacionAduanera
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Close()
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If (_parte.Descripcion = String.Empty) Then
            IError("La descripcion es obligatoria")
            Return
        Else
            '_informacionAduanera.Fecha = dtpFecha.Value
            DialogResult = Windows.Forms.DialogResult.Yes
            Close()
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

    Private Sub btnAgregarInfoAduanera_Click(sender As Object, e As EventArgs) Handles btnAgregarInfoAduanera.Click
        Dim ia As frmVVInformacionAduanera = New frmVVInformacionAduanera()
        Dim result As DialogResult
        result = ia.ShowDialog()
        If (result = Windows.Forms.DialogResult.Yes) Then
            _parte.InformacionAduanera.Add(ia.InformacionAduanera)
            _bs.ResetBindings(false)
            _bsInformacionAduanera.ResetBindings(False)
        End If
    End Sub

    Private Sub btnEliminarInformacionAduanera_Click(sender As Object, e As EventArgs) Handles btnEliminarInformacionAduanera.Click
        If (Not dgvInformacionAduanera.SelectedCells Is Nothing) Then
            _parte.InformacionAduanera.RemoveAt(dgvInformacionAduanera.SelectedCells.Item(0).RowIndex)
            _bsInformacionAduanera.ResetBindings(False)
        End If
    End Sub

    Private Sub btnEditarInformacionAduanera_Click(sender As Object, e As EventArgs) Handles btnEditarInformacionAduanera.Click
        If (Not dgvInformacionAduanera.SelectedCells Is Nothing) Then
            Dim index As Integer
            index = dgvInformacionAduanera.SelectedCells.Item(0).RowIndex
            Dim info As VVInformacionAduanera = dgvInformacionAduanera.Rows(dgvInformacionAduanera.SelectedCells.Item(0).RowIndex).DataBoundItem
            Dim ia As frmVVInformacionAduanera = New frmVVInformacionAduanera(info)
            Dim result As DialogResult
            result = ia.ShowDialog()
        End If
    End Sub
End Class