<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDocumentoRelacionado
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lError = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.nudMontoTotalErogaciones = New System.Windows.Forms.NumericUpDown()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cbClavePagoPedimentoVinculado = New System.Windows.Forms.ComboBox()
        Me.cbClavePedimentoVinculado = New System.Windows.Forms.ComboBox()
        Me.tbFolioFiscalVinculado = New System.Windows.Forms.TextBox()
        Me.cbMeses = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.nudOtroImpuestosPagadosPedimento = New System.Windows.Forms.NumericUpDown()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.nudMontoIVAPedimento = New System.Windows.Forms.NumericUpDown()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.nudMontoRetencionOtroImpuestos = New System.Windows.Forms.NumericUpDown()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.nudMontoRetencionIVA = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.nudMontoRetencionISR = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.nudMontoTotalIVA = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbRFCProveedor = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbNumeroPedimentoVinculado = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.cbOrigenErogacion = New System.Windows.Forms.ComboBox()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ToolStripContainer1.BottomToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.nudMontoTotalErogaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudOtroImpuestosPagadosPedimento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudMontoIVAPedimento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudMontoRetencionOtroImpuestos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudMontoRetencionIVA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudMontoRetencionISR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudMontoTotalIVA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStripContainer1
        '
        '
        'ToolStripContainer1.BottomToolStripPanel
        '
        Me.ToolStripContainer1.BottomToolStripPanel.Controls.Add(Me.StatusStrip1)
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.TableLayoutPanel1)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(765, 413)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.Size = New System.Drawing.Size(765, 460)
        Me.ToolStripContainer1.TabIndex = 2
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.StatusStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lError})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 0)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(765, 22)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 0
        '
        'lError
        '
        Me.lError.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lError.ForeColor = System.Drawing.Color.White
        Me.lError.Name = "lError"
        Me.lError.Size = New System.Drawing.Size(35, 17)
        Me.lError.Text = "Listo"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.FlowLayoutPanel1, 0, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(765, 413)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(283, 5)
        Me.Label5.Margin = New System.Windows.Forms.Padding(5)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(199, 20)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Documento relacionado"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 4
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 194.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 175.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label16, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.nudMontoTotalErogaciones, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label10, 0, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.Label9, 0, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.Label15, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.cbClavePagoPedimentoVinculado, 1, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.cbClavePedimentoVinculado, 1, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.tbFolioFiscalVinculado, 1, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.cbMeses, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Label12, 0, 11)
        Me.TableLayoutPanel2.Controls.Add(Me.nudOtroImpuestosPagadosPedimento, 1, 11)
        Me.TableLayoutPanel2.Controls.Add(Me.Label11, 0, 10)
        Me.TableLayoutPanel2.Controls.Add(Me.nudMontoIVAPedimento, 1, 10)
        Me.TableLayoutPanel2.Controls.Add(Me.Label13, 0, 9)
        Me.TableLayoutPanel2.Controls.Add(Me.nudMontoRetencionOtroImpuestos, 1, 9)
        Me.TableLayoutPanel2.Controls.Add(Me.Label8, 0, 8)
        Me.TableLayoutPanel2.Controls.Add(Me.nudMontoRetencionIVA, 1, 8)
        Me.TableLayoutPanel2.Controls.Add(Me.Label7, 0, 7)
        Me.TableLayoutPanel2.Controls.Add(Me.nudMontoRetencionISR, 1, 7)
        Me.TableLayoutPanel2.Controls.Add(Me.Label6, 0, 6)
        Me.TableLayoutPanel2.Controls.Add(Me.nudMontoTotalIVA, 1, 6)
        Me.TableLayoutPanel2.Controls.Add(Me.Label3, 2, 6)
        Me.TableLayoutPanel2.Controls.Add(Me.tbRFCProveedor, 3, 6)
        Me.TableLayoutPanel2.Controls.Add(Me.Label4, 2, 7)
        Me.TableLayoutPanel2.Controls.Add(Me.tbNumeroPedimentoVinculado, 3, 7)
        Me.TableLayoutPanel2.Controls.Add(Me.Label14, 2, 8)
        Me.TableLayoutPanel2.Controls.Add(Me.dtpFecha, 3, 8)
        Me.TableLayoutPanel2.Controls.Add(Me.cbOrigenErogacion, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(10, 40)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(10)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 12
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333335!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333335!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333335!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333335!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333335!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333335!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333335!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333335!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333335!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333335!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333335!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333335!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(745, 311)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Origen erogación:"
        '
        'Label16
        '
        Me.Label16.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(3, 31)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(139, 13)
        Me.Label16.TabIndex = 18
        Me.Label16.Text = "Monto total erogaciones:"
        '
        'nudMontoTotalErogaciones
        '
        Me.nudMontoTotalErogaciones.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.nudMontoTotalErogaciones.DecimalPlaces = 2
        Me.nudMontoTotalErogaciones.Location = New System.Drawing.Point(197, 28)
        Me.nudMontoTotalErogaciones.Maximum = New Decimal(New Integer() {9000000, 0, 0, 0})
        Me.nudMontoTotalErogaciones.Name = "nudMontoTotalErogaciones"
        Me.nudMontoTotalErogaciones.Size = New System.Drawing.Size(182, 22)
        Me.nudMontoTotalErogaciones.TabIndex = 1
        Me.nudMontoTotalErogaciones.Value = New Decimal(New Integer() {1, 0, 0, 196608})
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(3, 131)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(161, 13)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "Clave de pago del pedimento:"
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(3, 106)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(168, 13)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Clave del pedimento vinculado:"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Folio fiscal vinculado:"
        '
        'Label15
        '
        Me.Label15.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(3, 56)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(32, 13)
        Me.Label15.TabIndex = 17
        Me.Label15.Text = "Mes:"
        '
        'cbClavePagoPedimentoVinculado
        '
        Me.cbClavePagoPedimentoVinculado.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.SetColumnSpan(Me.cbClavePagoPedimentoVinculado, 3)
        Me.cbClavePagoPedimentoVinculado.DropDownHeight = 200
        Me.cbClavePagoPedimentoVinculado.DropDownWidth = 500
        Me.cbClavePagoPedimentoVinculado.FormattingEnabled = True
        Me.cbClavePagoPedimentoVinculado.IntegralHeight = False
        Me.cbClavePagoPedimentoVinculado.Location = New System.Drawing.Point(197, 128)
        Me.cbClavePagoPedimentoVinculado.Name = "cbClavePagoPedimentoVinculado"
        Me.cbClavePagoPedimentoVinculado.Size = New System.Drawing.Size(545, 21)
        Me.cbClavePagoPedimentoVinculado.TabIndex = 7
        '
        'cbClavePedimentoVinculado
        '
        Me.cbClavePedimentoVinculado.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbClavePedimentoVinculado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TableLayoutPanel2.SetColumnSpan(Me.cbClavePedimentoVinculado, 3)
        Me.cbClavePedimentoVinculado.DropDownHeight = 200
        Me.cbClavePedimentoVinculado.DropDownWidth = 700
        Me.cbClavePedimentoVinculado.FormattingEnabled = True
        Me.cbClavePedimentoVinculado.IntegralHeight = False
        Me.cbClavePedimentoVinculado.ItemHeight = 13
        Me.cbClavePedimentoVinculado.Location = New System.Drawing.Point(197, 103)
        Me.cbClavePedimentoVinculado.Name = "cbClavePedimentoVinculado"
        Me.cbClavePedimentoVinculado.Size = New System.Drawing.Size(545, 21)
        Me.cbClavePedimentoVinculado.TabIndex = 5
        '
        'tbFolioFiscalVinculado
        '
        Me.tbFolioFiscalVinculado.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.SetColumnSpan(Me.tbFolioFiscalVinculado, 3)
        Me.tbFolioFiscalVinculado.Location = New System.Drawing.Point(197, 78)
        Me.tbFolioFiscalVinculado.Name = "tbFolioFiscalVinculado"
        Me.tbFolioFiscalVinculado.Size = New System.Drawing.Size(545, 22)
        Me.tbFolioFiscalVinculado.TabIndex = 3
        '
        'cbMeses
        '
        Me.cbMeses.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbMeses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMeses.FormattingEnabled = True
        Me.cbMeses.Location = New System.Drawing.Point(197, 53)
        Me.cbMeses.Name = "cbMeses"
        Me.cbMeses.Size = New System.Drawing.Size(182, 21)
        Me.cbMeses.TabIndex = 2
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(3, 280)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(174, 26)
        Me.Label12.TabIndex = 15
        Me.Label12.Text = "Monto total de otros impuestos pagados en el pedimento:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'nudOtroImpuestosPagadosPedimento
        '
        Me.nudOtroImpuestosPagadosPedimento.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.nudOtroImpuestosPagadosPedimento.DecimalPlaces = 2
        Me.nudOtroImpuestosPagadosPedimento.Location = New System.Drawing.Point(197, 282)
        Me.nudOtroImpuestosPagadosPedimento.Maximum = New Decimal(New Integer() {9000000, 0, 0, 0})
        Me.nudOtroImpuestosPagadosPedimento.Name = "nudOtroImpuestosPagadosPedimento"
        Me.nudOtroImpuestosPagadosPedimento.Size = New System.Drawing.Size(121, 22)
        Me.nudOtroImpuestosPagadosPedimento.TabIndex = 16
        Me.nudOtroImpuestosPagadosPedimento.Value = New Decimal(New Integer() {1, 0, 0, 196608})
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(3, 256)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(161, 13)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "Monto del IVA del pedimento:"
        '
        'nudMontoIVAPedimento
        '
        Me.nudMontoIVAPedimento.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.nudMontoIVAPedimento.DecimalPlaces = 2
        Me.nudMontoIVAPedimento.Location = New System.Drawing.Point(197, 253)
        Me.nudMontoIVAPedimento.Maximum = New Decimal(New Integer() {9000000, 0, 0, 0})
        Me.nudMontoIVAPedimento.Name = "nudMontoIVAPedimento"
        Me.nudMontoIVAPedimento.Size = New System.Drawing.Size(121, 22)
        Me.nudMontoIVAPedimento.TabIndex = 14
        Me.nudMontoIVAPedimento.Value = New Decimal(New Integer() {1, 0, 0, 196608})
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(3, 231)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(180, 13)
        Me.Label13.TabIndex = 11
        Me.Label13.Text = "Monto retencion otros impuestos"
        '
        'nudMontoRetencionOtroImpuestos
        '
        Me.nudMontoRetencionOtroImpuestos.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.nudMontoRetencionOtroImpuestos.DecimalPlaces = 2
        Me.nudMontoRetencionOtroImpuestos.Location = New System.Drawing.Point(197, 228)
        Me.nudMontoRetencionOtroImpuestos.Maximum = New Decimal(New Integer() {9000000, 0, 0, 0})
        Me.nudMontoRetencionOtroImpuestos.Name = "nudMontoRetencionOtroImpuestos"
        Me.nudMontoRetencionOtroImpuestos.Size = New System.Drawing.Size(121, 22)
        Me.nudMontoRetencionOtroImpuestos.TabIndex = 12
        Me.nudMontoRetencionOtroImpuestos.Value = New Decimal(New Integer() {1, 0, 0, 196608})
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(3, 206)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(116, 13)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Monto retencion IVA:"
        '
        'nudMontoRetencionIVA
        '
        Me.nudMontoRetencionIVA.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.nudMontoRetencionIVA.DecimalPlaces = 2
        Me.nudMontoRetencionIVA.Location = New System.Drawing.Point(197, 203)
        Me.nudMontoRetencionIVA.Maximum = New Decimal(New Integer() {9000000, 0, 0, 0})
        Me.nudMontoRetencionIVA.Name = "nudMontoRetencionIVA"
        Me.nudMontoRetencionIVA.Size = New System.Drawing.Size(121, 22)
        Me.nudMontoRetencionIVA.TabIndex = 10
        Me.nudMontoRetencionIVA.Value = New Decimal(New Integer() {1, 0, 0, 196608})
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 181)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(116, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Monto retencion ISR:"
        '
        'nudMontoRetencionISR
        '
        Me.nudMontoRetencionISR.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.nudMontoRetencionISR.DecimalPlaces = 2
        Me.nudMontoRetencionISR.Location = New System.Drawing.Point(197, 178)
        Me.nudMontoRetencionISR.Maximum = New Decimal(New Integer() {9000000, 0, 0, 0})
        Me.nudMontoRetencionISR.Name = "nudMontoRetencionISR"
        Me.nudMontoRetencionISR.Size = New System.Drawing.Size(121, 22)
        Me.nudMontoRetencionISR.TabIndex = 9
        Me.nudMontoRetencionISR.Value = New Decimal(New Integer() {1, 0, 0, 196608})
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 156)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Monto total IVA:"
        '
        'nudMontoTotalIVA
        '
        Me.nudMontoTotalIVA.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.nudMontoTotalIVA.DecimalPlaces = 2
        Me.nudMontoTotalIVA.Location = New System.Drawing.Point(197, 153)
        Me.nudMontoTotalIVA.Maximum = New Decimal(New Integer() {9000000, 0, 0, 0})
        Me.nudMontoTotalIVA.Name = "nudMontoTotalIVA"
        Me.nudMontoTotalIVA.Size = New System.Drawing.Size(121, 22)
        Me.nudMontoTotalIVA.TabIndex = 8
        Me.nudMontoTotalIVA.Value = New Decimal(New Integer() {1, 0, 0, 196608})
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(385, 156)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "RFC del proveedor:"
        '
        'tbRFCProveedor
        '
        Me.tbRFCProveedor.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.tbRFCProveedor.Location = New System.Drawing.Point(560, 153)
        Me.tbRFCProveedor.Name = "tbRFCProveedor"
        Me.tbRFCProveedor.Size = New System.Drawing.Size(157, 22)
        Me.tbRFCProveedor.TabIndex = 18
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(385, 181)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(160, 13)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Numero pedimento vinculado"
        '
        'tbNumeroPedimentoVinculado
        '
        Me.tbNumeroPedimentoVinculado.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.tbNumeroPedimentoVinculado.Location = New System.Drawing.Point(560, 178)
        Me.tbNumeroPedimentoVinculado.Name = "tbNumeroPedimentoVinculado"
        Me.tbNumeroPedimentoVinculado.Size = New System.Drawing.Size(157, 22)
        Me.tbNumeroPedimentoVinculado.TabIndex = 20
        '
        'Label14
        '
        Me.Label14.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(385, 206)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(168, 13)
        Me.Label14.TabIndex = 21
        Me.Label14.Text = "Fecha del folio fiscal vinculado:"
        '
        'dtpFecha
        '
        Me.dtpFecha.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.dtpFecha.CustomFormat = "yyyy-MM-dd"
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFecha.Location = New System.Drawing.Point(560, 203)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.ShowCheckBox = True
        Me.dtpFecha.Size = New System.Drawing.Size(157, 22)
        Me.dtpFecha.TabIndex = 22
        Me.dtpFecha.Value = New Date(2019, 1, 2, 0, 0, 0, 0)
        '
        'cbOrigenErogacion
        '
        Me.cbOrigenErogacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbOrigenErogacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbOrigenErogacion.FormattingEnabled = True
        Me.cbOrigenErogacion.Items.AddRange(New Object() {"Nacional", "Extranjero"})
        Me.cbOrigenErogacion.Location = New System.Drawing.Point(197, 3)
        Me.cbOrigenErogacion.Name = "cbOrigenErogacion"
        Me.cbOrigenErogacion.Size = New System.Drawing.Size(182, 21)
        Me.cbOrigenErogacion.TabIndex = 23
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoSize = True
        Me.FlowLayoutPanel1.Controls.Add(Me.Button2)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnCancelar)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(10, 371)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(10)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(745, 32)
        Me.FlowLayoutPanel1.TabIndex = 12
        '
        'Button2
        '
        Me.Button2.AutoSize = True
        Me.Button2.Location = New System.Drawing.Point(667, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Button2.Size = New System.Drawing.Size(75, 26)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Aceptar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.AutoSize = True
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.Location = New System.Drawing.Point(586, 3)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnCancelar.Size = New System.Drawing.Size(75, 26)
        Me.btnCancelar.TabIndex = 0
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 4000
        '
        'frmDocumentoRelacionado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancelar
        Me.ClientSize = New System.Drawing.Size(765, 460)
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Name = "frmDocumentoRelacionado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Documento relacionado"
        Me.ToolStripContainer1.BottomToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.BottomToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        CType(Me.nudMontoTotalErogaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudOtroImpuestosPagadosPedimento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudMontoIVAPedimento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudMontoRetencionOtroImpuestos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudMontoRetencionIVA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudMontoRetencionISR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudMontoTotalIVA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lError As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tbNumeroPedimentoVinculado As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents nudMontoTotalErogaciones As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tbRFCProveedor As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents nudMontoTotalIVA As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudMontoRetencionISR As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudMontoRetencionIVA As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents nudMontoIVAPedimento As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudOtroImpuestosPagadosPedimento As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudMontoRetencionOtroImpuestos As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents tbFolioFiscalVinculado As System.Windows.Forms.TextBox
    Friend WithEvents cbMeses As System.Windows.Forms.ComboBox
    Friend WithEvents cbClavePagoPedimentoVinculado As System.Windows.Forms.ComboBox
    Friend WithEvents cbClavePedimentoVinculado As System.Windows.Forms.ComboBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents cbOrigenErogacion As System.Windows.Forms.ComboBox
End Class
