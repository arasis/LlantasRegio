Public Class frmImpuestos
    Private _impuestos As ImpuestosC = New ImpuestosC()
    Private _bs As BindingSource
    Private _bsTraslados As BindingSource
    Private _bsRetenciones As BindingSource

    Public Sub New(ByVal impuestos As ImpuestosC)
        _impuestos = impuestos
        InitializeComponent()
        RefreshDataBindings()
    End Sub
    Private Sub btnAgregarTraslado_Click(sender As Object, e As EventArgs) Handles btnAgregarTraslado.Click
        Dim trasladoC As TrasladoC
        Dim traslado As frmTraslado = New frmTraslado(trasladoC)
        If (traslado.ShowDialog() = Windows.Forms.DialogResult.Yes) Then
            _impuestos.Traslados.Add(traslado.Traslado)
            _bsTraslados.ResetBindings(False)
        End If

    End Sub

    Public Sub RefreshDataBindings()
        _bs = New BindingSource()
        _bs.DataSource = _impuestos

        _bsTraslados = New BindingSource()
        _bsRetenciones = New BindingSource()

        _bsTraslados.DataSource = _impuestos.Traslados
        _bsRetenciones.DataSource = _impuestos.Retenciones

        dgvTraslados.DataSource = _bsTraslados
        dgvRetenciones.DataSource = _bsRetenciones

        dgvTraslados.Columns("Importe").DefaultCellStyle.Format = "F2"
        dgvTraslados.Columns("Base").DefaultCellStyle.Format = "F2"
        dgvTraslados.Columns("TasaOCuota").DefaultCellStyle.Format = "F6"
        dgvTraslados.Columns("Importe").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvTraslados.Columns("Base").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvTraslados.Columns("TasaOCuota").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        dgvRetenciones.Columns("Importe").DefaultCellStyle.Format = "F2"
        dgvRetenciones.Columns("Base").DefaultCellStyle.Format = "F2"
        dgvRetenciones.Columns("TasaOCuota").DefaultCellStyle.Format = "F6"
        dgvRetenciones.Columns("Importe").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvRetenciones.Columns("Base").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvRetenciones.Columns("TasaOCuota").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        
    End Sub

    Private Sub btnEliminarTraslados_Click(sender As Object, e As EventArgs) Handles btnEliminarTraslados.Click
        If (Not dgvTraslados.SelectedCells Is Nothing) Then
            _impuestos.Traslados.RemoveAt(dgvTraslados.SelectedCells.Item(0).RowIndex)
            _bsTraslados.ResetBindings(False)
        End If
    End Sub

    Private Sub btnEditarTraslados_Click(sender As Object, e As EventArgs) Handles btnEditarTraslados.Click

    End Sub
End Class