Imports SpreadsheetLight
Imports DocumentFormat.OpenXml

Public Class frmErogacion
    Private _erogacion As Erogacion
    Private _bsDocumentosRelacionados As BindingSource
    Private _bsActividades As BindingSource
    Private _bsCentroCostos As BindingSource
    Public Property Erogacion As Erogacion
        Get
            Return _erogacion
        End Get
        Set(value As Erogacion)
            _erogacion = value
        End Set
    End Property
    Public Sub New(ByVal erogacion As Erogacion)

        _erogacion = erogacion
        ' This call is required by the designer.
        InitializeComponent()
        cbTipoErogacion.Text = _erogacion.TipoErogacion
        _bsDocumentosRelacionados = New BindingSource()
        _bsDocumentosRelacionados.DataSource = _erogacion.DocumentoRelacionado
        dgvDocumentoRelacionado.DataSource = _bsDocumentosRelacionados
        dgvDocumentoRelacionado.Columns("MontoTotalErogaciones").DefaultCellStyle.Format = "C2"
        dgvDocumentoRelacionado.Columns("MontoTotalErogaciones").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvDocumentoRelacionado.Columns("RFCProveedor").Visible = False
        dgvDocumentoRelacionado.Columns("MontoTotalIVA").Visible = True
        dgvDocumentoRelacionado.Columns("MontoRetencionISR").Visible = False
        dgvDocumentoRelacionado.Columns("MontoRetencionIVA").Visible = False
        dgvDocumentoRelacionado.Columns("MontoRetencionOtrosImpuestos").Visible = False
        dgvDocumentoRelacionado.Columns("NumeroPedimentoVinculado").Visible = False
        dgvDocumentoRelacionado.Columns("ClavePedimentoVinculado").Visible = False
        dgvDocumentoRelacionado.Columns("ClavePagoPedimentoVinculado").Visible = False
        dgvDocumentoRelacionado.Columns("MontoIVAPedimento").Visible = False
        dgvDocumentoRelacionado.Columns("OtrosImpuestosPagadosPedimento").Visible = False
        'dgvDocumentoRelacionado.Columns("FechaFolioFiscalVinculado").Visible = False

        _bsActividades = New BindingSource()
        _bsActividades.DataSource = _erogacion.Actividades
        dgvActividades.DataSource = _bsActividades

        _bsCentroCostos = New BindingSource()
        _bsCentroCostos.DataSource = _erogacion.CentroCostos
        dgvCentroCostos.DataSource = _bsCentroCostos
        ' Add any initialization after the InitializeComponent() call.
        setErogacion()
    End Sub

    Private Sub btnAgregarDocumentoRelacionado_Click(sender As Object, e As EventArgs) Handles btnAgregarDocumentoRelacionado.Click
        Dim fdr As frmDocumentoRelacionado = New frmDocumentoRelacionado(New EDocumentoRelacionado)
        If (fdr.ShowDialog() = DialogResult.Yes) Then
            _erogacion.DocumentoRelacionado.Add(fdr.DocumentoRelacionado)
            _bsDocumentosRelacionados.ResetBindings(False)
        End If




    End Sub

    Private Sub btnAgregarActividad_Click(sender As Object, e As EventArgs) Handles btnAgregarActividad.Click
        Dim fa As frmActividades = New frmActividades(New Actividades)
        If (fa.ShowDialog() = DialogResult.Yes) Then
            _erogacion.Actividades.Add(fa.Actividad)
            _bsActividades.ResetBindings(False)
        End If

    End Sub

    Private Sub btnAgregarCentroCosto_Click(sender As Object, e As EventArgs) Handles btnAgregarCentroCosto.Click
        Dim facc As frmCentroCostos = New frmCentroCostos(New CentroCostos)
        If (facc.ShowDialog() = Windows.Forms.DialogResult.Yes) Then
            _erogacion.CentroCostos.Add(facc.CentroCostos)
            _bsCentroCostos.ResetBindings(False)
        End If
    End Sub

    Private Sub btnEliminarDocumentoRelacionado_Click(sender As Object, e As EventArgs) Handles btnEliminarDocumentoRelacionado.Click
        If (dgvDocumentoRelacionado.SelectedCells.Count > 0) Then
            _erogacion.DocumentoRelacionado.RemoveAt(dgvDocumentoRelacionado.SelectedCells.Item(0).RowIndex)
            _bsDocumentosRelacionados.ResetBindings(False)
        End If
    End Sub

    Private Sub btnEditarDocumentoRelacionado_Click(sender As Object, e As EventArgs) Handles btnEditarDocumentoRelacionado.Click
        If (dgvDocumentoRelacionado.SelectedCells.Count > 0) Then
            Dim dr As EDocumentoRelacionado = dgvDocumentoRelacionado.Rows(dgvDocumentoRelacionado.SelectedCells.Item(0).RowIndex).DataBoundItem
            Dim fdr As frmDocumentoRelacionado = New frmDocumentoRelacionado(dr)
            If (fdr.ShowDialog() = DialogResult.Yes) Then
                _erogacion.DocumentoRelacionado(dgvDocumentoRelacionado.SelectedCells.Item(0).RowIndex) = fdr.DocumentoRelacionado
                _bsDocumentosRelacionados.ResetBindings(False)
            End If
        End If


    End Sub

    Private Sub btnEditarActividades_Click(sender As Object, e As EventArgs) Handles btnEditarActividades.Click
        If (dgvActividades.SelectedCells.Count > 0) Then
            Dim a As Actividades = dgvActividades.Rows(dgvActividades.SelectedCells.Item(0).RowIndex).DataBoundItem
            Dim fa As frmActividades = New frmActividades(a)
            If (fa.ShowDialog() = DialogResult.Yes) Then
                _erogacion.Actividades(dgvActividades.SelectedCells.Item(0).RowIndex) = fa.Actividad
                _bsActividades.ResetBindings(False)
            End If
        End If
    End Sub

    Private Sub btnEliminarActividad_Click(sender As Object, e As EventArgs) Handles btnEliminarActividad.Click
        If (dgvActividades.SelectedCells.Count > 0) Then
            _erogacion.Actividades.RemoveAt(dgvActividades.SelectedCells.Item(0).RowIndex)
            _bsActividades.ResetBindings(False)
        End If
    End Sub
    Private Function getErogacion()
        _erogacion.TipoErogacion = cbTipoErogacion.SelectedItem
        _erogacion.MontocuErogacion = nudMontocuErogacion.Value
        _erogacion.Porcentaje = NudPorcentaje.Value
    End Function

    Private Function setErogacion()
        cbTipoErogacion.SelectedValue = _erogacion.TipoErogacion
        nudMontocuErogacion.Value = _erogacion.MontocuErogacion
        NudPorcentaje.Value = _erogacion.Porcentaje
    End Function

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        getErogacion()
        If (cbTipoErogacion.SelectedIndex < 0) Then
            IError("Selecciona un tipo de erogacion")
            Return
        ElseIf (_erogacion.DocumentoRelacionado.Count <= 0) Then
            IError("Al menos debe de haber un documento relacionado")
            Return
        ElseIf (_erogacion.Porcentaje <= 0.001) Then
            IError("El valor minimo del porcentaje es 0.001")
            Return
        End If

        DialogResult = Windows.Forms.DialogResult.Yes
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


    Private Sub btnEliminarCentroCostos_Click(sender As Object, e As EventArgs) Handles btnEliminarCentroCostos.Click
        If (dgvCentroCostos.SelectedCells.Count > 0) Then
            _erogacion.CentroCostos.RemoveAt(dgvCentroCostos.SelectedCells.Item(0).RowIndex)
            _bsCentroCostos.ResetBindings(False)
        End If
    End Sub

    Private Sub btnEditarCentroCostos_Click(sender As Object, e As EventArgs) Handles btnEditarCentroCostos.Click
        If (dgvCentroCostos.SelectedCells.Count > 0) Then
            Dim a As CentroCostos = dgvCentroCostos.Rows(dgvCentroCostos.SelectedCells.Item(0).RowIndex).DataBoundItem
            Dim fa As frmCentroCostos = New frmCentroCostos(a)
            If (fa.ShowDialog() = DialogResult.Yes) Then
                _erogacion.Actividades(dgvCentroCostos.SelectedCells.Item(0).RowIndex) = fa.CentroCostos
                _bsCentroCostos.ResetBindings(False)
            End If
        End If
    End Sub
    Private Sub deshabilitarDocumentosRelacionados()
        If (dgvDocumentoRelacionado.Rows.Count > 0) Then
            btnEliminarDocumentoRelacionado.Enabled = True
            btnEditarDocumentoRelacionado.Enabled = True
        Else
            btnEliminarDocumentoRelacionado.Enabled = False
            btnEditarDocumentoRelacionado.Enabled = False
        End If
    End Sub

    Private Sub dgvDocumentoRelacionado_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles dgvDocumentoRelacionado.RowsAdded
        deshabilitarDocumentosRelacionados()
        lblNumeroDocumentos.Text = dgvDocumentoRelacionado.Rows.Count().ToString() + " documentos relacionados"
    End Sub
    Private Sub dgvDocumentoRelacionado_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles dgvDocumentoRelacionado.RowsRemoved
        deshabilitarDocumentosRelacionados()
        lblNumeroDocumentos.Text = dgvDocumentoRelacionado.Rows.Count().ToString() + " documentos relacionados"
    End Sub
    Private Sub deshabilitarBotonesActividades()
        If (dgvActividades.Rows.Count > 0) Then
            btnEditarActividades.Enabled = True
            btnEliminarActividad.Enabled = True
        Else
            btnEditarActividades.Enabled = False
            btnEliminarActividad.Enabled = False
        End If
    End Sub
    Private Sub dgvActividades_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles dgvActividades.RowsAdded
        deshabilitarBotonesActividades()
    End Sub
    Private Sub dgvActividades_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles dgvActividades.RowsRemoved
        deshabilitarBotonesActividades()
    End Sub
    Private Sub deshabilitarBotonesCentroCostos()
        If (dgvCentroCostos.Rows.Count > 0) Then
            btnEliminarCentroCostos.Enabled = True
            btnEditarCentroCostos.Enabled = True
        Else
            btnEliminarCentroCostos.Enabled = False
            btnEditarCentroCostos.Enabled = False
        End If
    End Sub

    Private Sub dgvCentroCostos_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles dgvCentroCostos.RowsAdded
        deshabilitarBotonesCentroCostos()
    End Sub

    Private Sub dgvCentroCostos_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles dgvCentroCostos.RowsRemoved
        deshabilitarBotonesCentroCostos()
    End Sub

    Private Sub btnImportar_Click(sender As Object, e As EventArgs) Handles btnImportar.Click
        Dim open As OpenFileDialog = New OpenFileDialog()
        open.Title = "Selecionar el archivo Excel"
        open.Filter = "Archivos de Excel| *.xls;*.xlsx"
        Dim result As DialogResult = open.ShowDialog()
        If (result = Windows.Forms.DialogResult.OK) Then
            Dim slDocument As SLDocument = New SLDocument(open.FileName, "Base MXN")
            Dim p As New SpreadsheetLight.SLCellPoint(3, 10)
            Dim r As Integer = 6
            Dim fecha, rfc, folio, origenErogacion, totalErogacion, totalIVAErogacion, mes As String
            Dim valore As String = String.Empty
            Dim count As Integer = 0
            Dim fecha1 As DateTime
            Dim totalErogacion1 As Decimal
            Dim totalIVAErogacion1 As Decimal
            montoTotalExcel = 0
            montoTotalExcel_sin_iva = 0
            While (Not slDocument.GetCellValueAsString(r, 1) Is String.Empty)
                folio = String.Empty
                origenErogacion = String.Empty
                fecha = String.Empty

                'r = y
                rfc = slDocument.GetCellValueAsString(r, 24)
                folio = slDocument.GetCellValueAsString(r, 5)
                totalErogacion = slDocument.GetCellValueAsDouble(r, 35)
                fecha = slDocument.GetCellValueAsDateTime(r, 6)
                origenErogacion = slDocument.GetCellValueAsString(r, 23)
                mes = slDocument.GetCellValueAsString(r, 2)

                Dim status_iva As String

                status_iva = slDocument.GetCellValueAsString(r, 32).ToString

                If status_iva.Trim = "SI" Then
                    montoTotalExcel = montoTotalExcel + slDocument.GetCellValueAsDouble(r, 35)
                End If
                If status_iva = "NO" Then
                    montoTotalExcel_sin_iva = montoTotalExcel_sin_iva + slDocument.GetCellValueAsDouble(r, 35)
                End If

                totalIVAErogacion = slDocument.GetCellValueAsDouble(r, 36)

                DateTime.TryParse(fecha, fecha1)
                Decimal.TryParse(totalErogacion, totalErogacion1)

                If (Not Decimal.TryParse(totalIVAErogacion, totalIVAErogacion1)) Then totalIVAErogacion1 = 0

                Dim dr As EDocumentoRelacionado = New EDocumentoRelacionado()
                dr.FolioFiscalVinculado = folio.ToUpper()
                dr.RFCProveedor = rfc.ToUpper()
                dr.OrigenErogacion = origenErogacion.ToString()

                dr.MontoTotalErogaciones = totalErogacion1.ToString("F3")

                dr.MontoTotalIVA = totalIVAErogacion1.ToString("F3")

                dr.FechaFolioFiscalVinculado = fecha1.ToString("yyyy-MM-dd")
                dr.Mes = fecha1.ToString("MM")

                _erogacion.DocumentoRelacionado.Add(dr)
                r = r + 1
                count = count + 1
            End While

            _bsDocumentosRelacionados.ResetBindings(False)
            MessageBox.Show("Se agregaron " + count.ToString() + " documentos relacionados.")



            nudMontocuErogacion.Value = montoTotalExcel + montoTotalExcel_sin_iva
            Variables.TtMontoErogacion = montoTotalExcel + montoTotalExcel_sin_iva



        End If
        '************************************************
        'If (result = Windows.Forms.DialogResult.OK) Then
        '    Dim slDocument As SLDocument = New SLDocument(open.FileName, "Hoja1")
        '    'Dim p As New SpreadsheetLight.SLCellPoint(3, 8)
        '    Dim r As Integer = 2
        '    Dim fecha, rfc, folio, origenErogacion, totalErogacion As String
        '    Dim valore As String = String.Empty
        '    Dim count As Integer = 0
        '    Dim fecha1 As DateTime
        '    Dim totalErogacion1 As Decimal
        '    While (Not slDocument.GetCellValueAsString(r, 8) Is String.Empty)
        '        folio = String.Empty
        '        origenErogacion = String.Empty
        '        fecha = String.Empty

        '        folio = slDocument.GetCellValueAsString(r, 8)
        '        rfc = slDocument.GetCellValueAsString(r, 1)
        '        totalErogacion = slDocument.GetCellValueAsDouble(r, 23)
        '        fecha = slDocument.GetCellValueAsDateTime(r, 11)
        '        DateTime.TryParse(fecha, fecha1)
        '        Decimal.TryParse(totalErogacion, totalErogacion1)
        '        origenErogacion = slDocument.GetCellValueAsString(r, 7)

        '        Dim dr As EDocumentoRelacionado = New EDocumentoRelacionado()
        '        dr.FolioFiscalVinculado = folio.ToUpper()
        '        dr.RFCProveedor = rfc.ToUpper()
        '        dr.OrigenErogacion = origenErogacion.ToUpper()
        '        dr.MontoTotalErogaciones = totalErogacion1.ToString("F3")
        '        dr.FechaFolioFiscalVinculado = fecha1.ToShortDateString()

        '        _erogacion.DocumentoRelacionado.Add(dr)
        '        r = r + 1
        '        count = count + 1
        '    End While
        '    _bsDocumentosRelacionados.ResetBindings(False)
        '    MessageBox.Show("Se agregaron " + count.ToString() + " documentos relacionados.")
        'End If

        lblMontoErogacion.Text = "MontoErogación con IVA = " & Format(montoTotalExcel, "$ ###,###,###.#0")
        lblMontoErogacion_sin_iva.Text = "MontoErogación sin IVA = " & Format(montoTotalExcel_sin_iva, "$ ###,###,###.#0")

        TotalMErogacion.Text = ""
        TotalMErogacion.Text = "MontoErogación Total = " & Format(montoTotalExcel + montoTotalExcel_sin_iva, "$ ###,###,###.#0")


        ' Format(montoTotalExcel, "$ ###,###,###.#0")

    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel1.Paint

    End Sub
End Class