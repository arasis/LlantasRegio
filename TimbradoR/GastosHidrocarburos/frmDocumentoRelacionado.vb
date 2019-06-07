Public Class frmDocumentoRelacionado
    Private _meses As List(Of Mes) = New List(Of Mes)
    Private _dr As EDocumentoRelacionado

    Public Property DocumentoRelacionado As EDocumentoRelacionado
        Get
            Return _dr
        End Get
        Set(value As EDocumentoRelacionado)
            _dr = value
        End Set
    End Property
    Public Sub New(ByVal dr As EDocumentoRelacionado)
        _dr = dr
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        llenarMeses()
        setDocumentoRelacionado()

    End Sub
    Private Function llenarMeses()
        _meses.Add(New Mes With {.Mes = "01", .Descripcion = "ENERO"})
        _meses.Add(New Mes With {.Mes = "02", .Descripcion = "FEBRERO"})
        _meses.Add(New Mes With {.Mes = "03", .Descripcion = "MARZO"})
        _meses.Add(New Mes With {.Mes = "04", .Descripcion = "ABRIL"})
        _meses.Add(New Mes With {.Mes = "05", .Descripcion = "MAYO"})
        _meses.Add(New Mes With {.Mes = "06", .Descripcion = "JUNIO"})
        _meses.Add(New Mes With {.Mes = "07", .Descripcion = "JULIO"})
        _meses.Add(New Mes With {.Mes = "08", .Descripcion = "AGOSTO"})
        _meses.Add(New Mes With {.Mes = "09", .Descripcion = "SEPTIEMBRE"})
        _meses.Add(New Mes With {.Mes = "10", .Descripcion = "OCTUBRE"})
        _meses.Add(New Mes With {.Mes = "11", .Descripcion = "NOVIEMBRE"})
        _meses.Add(New Mes With {.Mes = "12", .Descripcion = "DICIEMBRE"})
        cbMeses.DataSource = _meses
        cbMeses.DisplayMember = "Descripcion"
        cbMeses.ValueMember = "Mes"

        cbClavePagoPedimentoVinculado.DisplayMember = "Descripcion"
        cbClavePedimentoVinculado.DisplayMember = "Descripcion"
        cbClavePagoPedimentoVinculado.ValueMember = "ClavePagoPedimento"
        cbClavePedimentoVinculado.ValueMember = "ClavePedimento"
        cbClavePedimentoVinculado.DataSource = DB.obtenerPedimentos()
        cbClavePagoPedimentoVinculado.DataSource = DB.obtenerPagoPedimentos()

    End Function
    Private Function hayError() As Boolean
        If (cbOrigenErogacion.Text.Trim() = String.Empty) Then
            IError("El campo origen erogación es obligatorio")
            Return True
        ElseIf (nudMontoTotalErogaciones.Value < 0.001) Then
            IError("El monto total erogaciones debe ser mayor a 0.001")
            Return True
        Else
            Return False
        End If
    End Function
    Private Function getDocumentoRelacionado()

        _dr.ClavePagoPedimentoVinculado = cbClavePagoPedimentoVinculado.SelectedValue
        _dr.ClavePedimentoVinculado = cbClavePedimentoVinculado.SelectedValue
        If (dtpFecha.Checked) Then _dr.FechaFolioFiscalVinculado = dtpFecha.Value.ToString("yyyy-MM-dd")
        _dr.FolioFiscalVinculado = tbFolioFiscalVinculado.Text.Trim()
        _dr.Mes = cbMeses.SelectedValue
        _dr.MontoIVAPedimento = nudMontoIVAPedimento.Value
        _dr.MontoRetencionISR = nudMontoRetencionISR.Value
        _dr.MontoRetencionIVA = nudMontoRetencionIVA.Value
        _dr.MontoRetencionOtrosImpuestos = nudMontoRetencionOtroImpuestos.Value
        _dr.MontoTotalErogaciones = nudMontoTotalErogaciones.Value
        _dr.MontoTotalIVA = nudMontoTotalIVA.Value
        _dr.NumeroPedimentoVinculado = tbNumeroPedimentoVinculado.Text.Trim()
        _dr.OrigenErogacion = cbOrigenErogacion.Text.Trim()
        _dr.OtrosImpuestosPagadosPedimento = nudOtroImpuestosPagadosPedimento.Value
        _dr.RFCProveedor = tbRFCProveedor.Text.Trim()
    End Function
    Private Function setDocumentoRelacionado()
        Dim fecha As DateTime
        If (_dr.ClavePagoPedimentoVinculado <> String.Empty) Then
            cbClavePagoPedimentoVinculado.SelectedValue = _dr.ClavePagoPedimentoVinculado
        Else
            cbClavePagoPedimentoVinculado.SelectedIndex = -1
        End If
        If (_dr.ClavePedimentoVinculado <> String.Empty) Then
            cbClavePedimentoVinculado.SelectedValue = _dr.ClavePedimentoVinculado
        Else
            cbClavePedimentoVinculado.SelectedIndex = -1
        End If

        If (DateTime.TryParse(_dr.FechaFolioFiscalVinculado, fecha)) Then dtpFecha.Value = fecha
        tbFolioFiscalVinculado.Text = _dr.FolioFiscalVinculado
        cbMeses.SelectedValue = _dr.Mes
        nudMontoIVAPedimento.Value = _dr.MontoIVAPedimento
        nudMontoRetencionISR.Value = _dr.MontoRetencionISR
        nudMontoRetencionIVA.Value = _dr.MontoRetencionIVA
        nudMontoRetencionOtroImpuestos.Value = _dr.MontoRetencionOtrosImpuestos
        nudMontoTotalErogaciones.Value = _dr.MontoTotalErogaciones
        nudMontoTotalIVA.Value = _dr.MontoTotalIVA
        tbNumeroPedimentoVinculado.Text = _dr.NumeroPedimentoVinculado
        cbOrigenErogacion.Text = _dr.OrigenErogacion
        nudOtroImpuestosPagadosPedimento.Value = _dr.OtrosImpuestosPagadosPedimento
        tbRFCProveedor.Text = _dr.RFCProveedor
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If hayError() Then Return
        getDocumentoRelacionado()
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
Public Class Mes
    Private _mes As String
    Private _descripcion As String

    Public Property Mes As String
        Get
            Return _mes
        End Get
        Set(value As String)
            _mes = value
        End Set
    End Property
    Public Property Descripcion As String
        Get
            Return _descripcion
        End Get
        Set(value As String)
            _descripcion = value
        End Set
    End Property
End Class