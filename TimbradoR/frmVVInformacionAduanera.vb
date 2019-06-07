Public Class frmVVInformacionAduanera
    Private _informacionAduanera As VVInformacionAduanera
    Private _bs As BindingSource
    Public Sub New()
        _informacionAduanera = New VVInformacionAduanera()
        _informacionAduanera.Fecha = Date.Now
        ' This call is required by the designer.
        InitializeComponent()
        RefreshDataBindings()
        ' Add any initialization after the InitializeComponent() call.
    End Sub
    Public Sub New(ByVal informacionAduanera As VVInformacionAduanera)
        _informacionAduanera = informacionAduanera
        InitializeComponent()
        btnCancelar.Visible = False
        RefreshDataBindings()
    End Sub
    Public Sub RefreshDataBindings()
        _bs = New BindingSource()
        _bs.DataSource = _informacionAduanera
        tbNumero.DataBindings.Add("Text", _bs, "Numero", False, DataSourceUpdateMode.OnPropertyChanged)
        tbAduana.DataBindings.Add("Text", _bs, "Aduana", False, DataSourceUpdateMode.OnPropertyChanged)
        dtpFecha.DataBindings.Add(New Binding("Value", _bs, "Fecha", False, DataSourceUpdateMode.OnPropertyChanged, Date.Now, "yyyy-MM-dd"))
    End Sub
    Public Property InformacionAduanera As VVInformacionAduanera
        Get
            Return _informacionAduanera
        End Get
        Set(value As VVInformacionAduanera)
            _informacionAduanera = value
        End Set
    End Property

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If (_informacionAduanera.Numero = String.Empty) Then
            IError("El número del documento aduanero es obligatorio")
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
End Class