Public Class frmComplementoVentaVehiculos
    Private _ventaVehiculos As VentaVehiculos
    Private _bs As BindingSource
    Private _bsInformacionAduanera As BindingSource
    Private _bsPartes As BindingSource
    Public Sub New(ByVal ventaVehiculos As VentaVehiculos)
        _ventaVehiculos = ventaVehiculos
        InitializeComponent()
        RefreshDataBindings()
    End Sub

    Public Sub RefreshDataBindings()
        If (_ventaVehiculos Is Nothing) Then
            _ventaVehiculos = New VentaVehiculos()
        End If
        _bs = New BindingSource()
        _bsInformacionAduanera = New BindingSource()
        _bsPartes = New BindingSource()

        _bs.DataSource = _ventaVehiculos
        _bsInformacionAduanera.DataSource = _ventaVehiculos.InformacionAduanera
        _bsPartes.DataSource = _ventaVehiculos.Parte

        tbClaveVehicular.DataBindings.Add("Text", _bs, "ClaveVehicular", False, DataSourceUpdateMode.OnPropertyChanged)
        tbNiv.DataBindings.Add("Text", _bs, "NIV", False, DataSourceUpdateMode.OnPropertyChanged)
        dgvInformacionAduanera.DataSource = _bsInformacionAduanera
        dgvPartes.DataSource = _bsPartes
        ''dgvInformacionAduanera.Columns("Fecha").DefaultCellStyle.Format = "dd/MM/yyyy"

        
    End Sub
    Public Property VentaVehiculos As VentaVehiculos
        Get
            Return _ventaVehiculos
        End Get
        Set(value As VentaVehiculos)
            _ventaVehiculos = value
        End Set
    End Property
    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel1.Paint

    End Sub

    Private Sub btnAgregarInfoAduanera_Click(sender As Object, e As EventArgs) Handles btnAgregarInfoAduanera.Click
        Dim ia As frmVVInformacionAduanera = New frmVVInformacionAduanera()
        Dim result As DialogResult
        result = ia.ShowDialog()
        If (result = Windows.Forms.DialogResult.Yes) Then
            _ventaVehiculos.InformacionAduanera.Add(ia.InformacionAduanera)
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

    Private Sub btnEliminarInformacionAduanera_Click(sender As Object, e As EventArgs) Handles btnEliminarInformacionAduanera.Click
        If (Not dgvInformacionAduanera.SelectedCells Is Nothing) Then
            _ventaVehiculos.InformacionAduanera.RemoveAt(dgvInformacionAduanera.SelectedCells.Item(0).RowIndex)
            _bsInformacionAduanera.ResetBindings(False)
        End If
    End Sub

    Private Sub btnEliminarParte_Click(sender As Object, e As EventArgs) Handles btnEliminarParte.Click
        If (Not dgvPartes.SelectedCells Is Nothing) Then
            _ventaVehiculos.Parte.RemoveAt(dgvPartes.SelectedCells.Item(0).RowIndex)
            _bsPartes.ResetBindings(False)
        End If
    End Sub

    Private Sub btnAgregarParte_Click(sender As Object, e As EventArgs) Handles btnAgregarParte.Click
        Dim parte As frmVVPartes = New frmVVPartes()
        Dim result As DialogResult
        result = parte.ShowDialog()
        If (result = Windows.Forms.DialogResult.Yes) Then
            _ventaVehiculos.Parte.Add(parte.Parte)
            _bsPartes.ResetBindings(False)
        End If
    End Sub

    Private Sub btnEditarParte_Click(sender As Object, e As EventArgs) Handles btnEditarParte.Click
        If (Not dgvPartes.SelectedCells Is Nothing) Then
            Dim index As Integer
            index = dgvPartes.SelectedCells.Item(0).RowIndex
            Dim info As VVParte = dgvPartes.Rows(dgvPartes.SelectedCells.Item(0).RowIndex).DataBoundItem
            Dim ia As frmVVPartes = New frmVVPartes(info)
            Dim result As DialogResult
            result = ia.ShowDialog()
        End If
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If (tbClaveVehicular.Text = String.Empty) Then
            IError("La clave vehicular es requerida")
            Return
        ElseIf (tbNiv.Text = String.Empty) Then
            IError("El Campo NIV es un campo obligatorio")
            Return
        End If
        DialogResult = Windows.Forms.DialogResult.Yes
        Close()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Close()
    End Sub
    Private Sub IError(mensaje As String)
        lError.Text = mensaje
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lError.Text = "Listo"
        Timer1.Stop()
    End Sub
End Class