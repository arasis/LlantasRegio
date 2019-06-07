Public Class frmTraslado
    Private _traslado As TrasladoC
    Private _bs As BindingSource
    Public Sub New(ByVal trasladoC As TrasladoC)
        _traslado = trasladoC
        InitializeComponent()
        RefreshDataBindings()
    End Sub
    Public Sub RefreshDataBindings()
        If (_traslado Is Nothing) Then
            _traslado = New TrasladoC()
        End If
        _bs = New BindingSource()

        _bs.DataSource = _traslado
        cbImpuesto.DataBindings.Add("Text", _bs, "Impuesto", False, DataSourceUpdateMode.OnPropertyChanged)
        cbTipoFactor.DataBindings.Add("Text", _bs, "TipoFactor", False, DataSourceUpdateMode.OnPropertyChanged)
        tbTasaOCuota.DataBindings.Add("Text", _bs, "TasaOCuota", True, DataSourceUpdateMode.OnPropertyChanged, 0, "F6")
        tbBase.DataBindings.Add("Text", _bs, "Base", True, DataSourceUpdateMode.OnPropertyChanged, 0, "F2")
        tbImporte.DataBindings.Add("Text", _bs, "Importe", True, DataSourceUpdateMode.OnPropertyChanged, 0, "F2")
    End Sub

    Private Sub tbBase_TextChanged(sender As Object, e As EventArgs) Handles tbBase.TextChanged, tbTasaOCuota.TextChanged
        Dim text As String

        Dim importe As Decimal
        Dim base As Decimal
        Dim tasaOCuota As Decimal
        Text = tbBase.Text.Replace("$", "")
        text = text.Trim()
        Decimal.TryParse(text, base)
        Text = tbTasaOCuota.Text.Replace("$", "")
        text = text.Trim()
        Decimal.TryParse(text, tasaOCuota)
        importe = base * tasaOCuota
        _traslado.Importe = importe
        'tbImporte.Text = Format(importe, "F2")
    End Sub

    Public Property Traslado As TrasladoC
        Get
            Return _traslado
        End Get
        Set(value As TrasladoC)
            _traslado = value
        End Set
    End Property
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If (_traslado.TipoFactor = String.Empty) Then
            IError("Selecciona el tipo de factor del traslado")
            Return
        ElseIf (_traslado.Impuesto = String.Empty) Then
            IError("Selecciona el impuesto del traslado")
            Return
        ElseIf (_traslado.Base < 0) Then
            IError("La base del traslado no permite valores negativos")
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
        LError.Text = "Listo"
        Timer1.Stop()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Close()
    End Sub
End Class