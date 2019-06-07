<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class wDoctosRelacionados
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.tableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
        Me.tableLayoutPanel25 = New System.Windows.Forms.TableLayoutPanel()
        Me.label21 = New System.Windows.Forms.Label()
        Me.tableLayoutPanel8 = New System.Windows.Forms.TableLayoutPanel()
        Me.tbIdDocumento = New System.Windows.Forms.TextBox()
        Me.label22 = New System.Windows.Forms.Label()
        Me.tableLayoutPanel12 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnAgregaConcepto = New System.Windows.Forms.Button()
        Me.btnConceptoLimpiar = New System.Windows.Forms.Button()
        Me.dgvDocumentos = New System.Windows.Forms.DataGridView()
        Me.cEliminar = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.tlpError = New System.Windows.Forms.TableLayoutPanel()
        Me.lError = New System.Windows.Forms.Label()
        Me.label18 = New System.Windows.Forms.Label()
        Me.tbFolio = New System.Windows.Forms.TextBox()
        Me.tbTipoCambio = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.tbNumeroParcialidad = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.label26 = New System.Windows.Forms.Label()
        Me.label17 = New System.Windows.Forms.Label()
        Me.label16 = New System.Windows.Forms.Label()
        Me.cbMoneda = New System.Windows.Forms.ComboBox()
        Me.label30 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbSerie = New System.Windows.Forms.TextBox()
        Me.nudImporteSaldoAnterior = New System.Windows.Forms.NumericUpDown()
        Me.nudImportePagado = New System.Windows.Forms.NumericUpDown()
        Me.nudImporteInsoluto = New System.Windows.Forms.NumericUpDown()
        Me.cbMetodoPago = New System.Windows.Forms.ComboBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.tableLayoutPanel7.SuspendLayout()
        Me.tableLayoutPanel25.SuspendLayout()
        Me.tableLayoutPanel8.SuspendLayout()
        Me.tableLayoutPanel12.SuspendLayout()
        CType(Me.dgvDocumentos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpError.SuspendLayout()
        CType(Me.nudImporteSaldoAnterior, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudImportePagado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudImporteInsoluto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tableLayoutPanel7
        '
        Me.tableLayoutPanel7.ColumnCount = 1
        Me.tableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableLayoutPanel7.Controls.Add(Me.tableLayoutPanel25, 0, 0)
        Me.tableLayoutPanel7.Controls.Add(Me.tableLayoutPanel8, 0, 1)
        Me.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tableLayoutPanel7.Location = New System.Drawing.Point(0, 0)
        Me.tableLayoutPanel7.Margin = New System.Windows.Forms.Padding(10)
        Me.tableLayoutPanel7.Name = "tableLayoutPanel7"
        Me.tableLayoutPanel7.RowCount = 2
        Me.tableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableLayoutPanel7.Size = New System.Drawing.Size(1018, 382)
        Me.tableLayoutPanel7.TabIndex = 24
        '
        'tableLayoutPanel25
        '
        Me.tableLayoutPanel25.AutoSize = True
        Me.tableLayoutPanel25.BackColor = System.Drawing.Color.White
        Me.tableLayoutPanel25.BackgroundImage = Global.ef33LlantasRegio.My.Resources.Resources.Untitled_2
        Me.tableLayoutPanel25.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.tableLayoutPanel25.ColumnCount = 1
        Me.tableLayoutPanel25.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tableLayoutPanel25.Controls.Add(Me.label21, 0, 0)
        Me.tableLayoutPanel25.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tableLayoutPanel25.Location = New System.Drawing.Point(0, 0)
        Me.tableLayoutPanel25.Margin = New System.Windows.Forms.Padding(0)
        Me.tableLayoutPanel25.Name = "tableLayoutPanel25"
        Me.tableLayoutPanel25.RowCount = 1
        Me.tableLayoutPanel25.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tableLayoutPanel25.Size = New System.Drawing.Size(1018, 30)
        Me.tableLayoutPanel25.TabIndex = 1
        '
        'label21
        '
        Me.label21.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.label21.AutoSize = True
        Me.label21.BackColor = System.Drawing.Color.Transparent
        Me.label21.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label21.ForeColor = System.Drawing.Color.White
        Me.label21.Location = New System.Drawing.Point(9, 4)
        Me.label21.Margin = New System.Windows.Forms.Padding(9, 0, 3, 0)
        Me.label21.Name = "label21"
        Me.label21.Size = New System.Drawing.Size(200, 21)
        Me.label21.TabIndex = 0
        Me.label21.Text = "Documentos relacionados"
        '
        'tableLayoutPanel8
        '
        Me.tableLayoutPanel8.BackColor = System.Drawing.SystemColors.Control
        Me.tableLayoutPanel8.ColumnCount = 6
        Me.tableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125.0!))
        Me.tableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125.0!))
        Me.tableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 127.0!))
        Me.tableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tableLayoutPanel8.Controls.Add(Me.tbIdDocumento, 1, 0)
        Me.tableLayoutPanel8.Controls.Add(Me.label22, 0, 0)
        Me.tableLayoutPanel8.Controls.Add(Me.tableLayoutPanel12, 4, 4)
        Me.tableLayoutPanel8.Controls.Add(Me.dgvDocumentos, 0, 5)
        Me.tableLayoutPanel8.Controls.Add(Me.tlpError, 2, 4)
        Me.tableLayoutPanel8.Controls.Add(Me.label18, 2, 1)
        Me.tableLayoutPanel8.Controls.Add(Me.tbFolio, 3, 1)
        Me.tableLayoutPanel8.Controls.Add(Me.tbTipoCambio, 1, 2)
        Me.tableLayoutPanel8.Controls.Add(Me.Label20, 4, 2)
        Me.tableLayoutPanel8.Controls.Add(Me.tbNumeroParcialidad, 5, 2)
        Me.tableLayoutPanel8.Controls.Add(Me.Label25, 2, 3)
        Me.tableLayoutPanel8.Controls.Add(Me.Label27, 4, 3)
        Me.tableLayoutPanel8.Controls.Add(Me.label26, 0, 3)
        Me.tableLayoutPanel8.Controls.Add(Me.label17, 0, 1)
        Me.tableLayoutPanel8.Controls.Add(Me.label16, 4, 1)
        Me.tableLayoutPanel8.Controls.Add(Me.cbMoneda, 5, 1)
        Me.tableLayoutPanel8.Controls.Add(Me.label30, 0, 2)
        Me.tableLayoutPanel8.Controls.Add(Me.Label1, 2, 2)
        Me.tableLayoutPanel8.Controls.Add(Me.tbSerie, 1, 1)
        Me.tableLayoutPanel8.Controls.Add(Me.nudImporteSaldoAnterior, 1, 3)
        Me.tableLayoutPanel8.Controls.Add(Me.nudImportePagado, 3, 3)
        Me.tableLayoutPanel8.Controls.Add(Me.nudImporteInsoluto, 5, 3)
        Me.tableLayoutPanel8.Controls.Add(Me.cbMetodoPago, 3, 2)
        Me.tableLayoutPanel8.Controls.Add(Me.btnBuscar, 4, 0)
        Me.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tableLayoutPanel8.Location = New System.Drawing.Point(5, 30)
        Me.tableLayoutPanel8.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.tableLayoutPanel8.Name = "tableLayoutPanel8"
        Me.tableLayoutPanel8.RowCount = 6
        Me.tableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tableLayoutPanel8.Size = New System.Drawing.Size(1008, 352)
        Me.tableLayoutPanel8.TabIndex = 2
        '
        'tbIdDocumento
        '
        Me.tbIdDocumento.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tableLayoutPanel8.SetColumnSpan(Me.tbIdDocumento, 3)
        Me.tbIdDocumento.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbIdDocumento.Location = New System.Drawing.Point(128, 7)
        Me.tbIdDocumento.Name = "tbIdDocumento"
        Me.tbIdDocumento.Size = New System.Drawing.Size(539, 25)
        Me.tbIdDocumento.TabIndex = 35
        '
        'label22
        '
        Me.label22.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.label22.AutoSize = True
        Me.label22.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label22.Location = New System.Drawing.Point(44, 3)
        Me.label22.Margin = New System.Windows.Forms.Padding(3)
        Me.label22.Name = "label22"
        Me.label22.Size = New System.Drawing.Size(78, 34)
        Me.label22.TabIndex = 0
        Me.label22.Text = "*Id del documento"
        '
        'tableLayoutPanel12
        '
        Me.tableLayoutPanel12.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.tableLayoutPanel12.ColumnCount = 3
        Me.tableLayoutPanel8.SetColumnSpan(Me.tableLayoutPanel12, 2)
        Me.tableLayoutPanel12.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableLayoutPanel12.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 124.0!))
        Me.tableLayoutPanel12.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130.0!))
        Me.tableLayoutPanel12.Controls.Add(Me.btnAgregaConcepto, 2, 0)
        Me.tableLayoutPanel12.Controls.Add(Me.btnConceptoLimpiar, 1, 0)
        Me.tableLayoutPanel12.Location = New System.Drawing.Point(673, 163)
        Me.tableLayoutPanel12.Name = "tableLayoutPanel12"
        Me.tableLayoutPanel12.RowCount = 1
        Me.tableLayoutPanel12.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableLayoutPanel12.Size = New System.Drawing.Size(332, 34)
        Me.tableLayoutPanel12.TabIndex = 19
        '
        'btnAgregaConcepto
        '
        Me.btnAgregaConcepto.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnAgregaConcepto.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.btnAgregaConcepto.FlatAppearance.BorderSize = 0
        Me.btnAgregaConcepto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregaConcepto.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregaConcepto.ForeColor = System.Drawing.Color.White
        Me.btnAgregaConcepto.Location = New System.Drawing.Point(221, 3)
        Me.btnAgregaConcepto.Name = "btnAgregaConcepto"
        Me.btnAgregaConcepto.Size = New System.Drawing.Size(108, 28)
        Me.btnAgregaConcepto.TabIndex = 17
        Me.btnAgregaConcepto.Text = "Agregar"
        Me.btnAgregaConcepto.UseVisualStyleBackColor = False
        '
        'btnConceptoLimpiar
        '
        Me.btnConceptoLimpiar.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnConceptoLimpiar.BackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.btnConceptoLimpiar.FlatAppearance.BorderSize = 0
        Me.btnConceptoLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConceptoLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConceptoLimpiar.ForeColor = System.Drawing.Color.White
        Me.btnConceptoLimpiar.Location = New System.Drawing.Point(91, 3)
        Me.btnConceptoLimpiar.Name = "btnConceptoLimpiar"
        Me.btnConceptoLimpiar.Size = New System.Drawing.Size(108, 28)
        Me.btnConceptoLimpiar.TabIndex = 18
        Me.btnConceptoLimpiar.Text = "Limpiar"
        Me.btnConceptoLimpiar.UseVisualStyleBackColor = False
        '
        'dgvDocumentos
        '
        Me.dgvDocumentos.AllowUserToAddRows = False
        Me.dgvDocumentos.AllowUserToDeleteRows = False
        Me.dgvDocumentos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDocumentos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.dgvDocumentos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvDocumentos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(134, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(134, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDocumentos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvDocumentos.ColumnHeadersHeight = 30
        Me.dgvDocumentos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cEliminar})
        Me.tableLayoutPanel8.SetColumnSpan(Me.dgvDocumentos, 6)
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDocumentos.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgvDocumentos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvDocumentos.EnableHeadersVisualStyles = False
        Me.dgvDocumentos.GridColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.dgvDocumentos.Location = New System.Drawing.Point(3, 203)
        Me.dgvDocumentos.Name = "dgvDocumentos"
        Me.dgvDocumentos.ReadOnly = True
        Me.dgvDocumentos.RowHeadersVisible = False
        Me.dgvDocumentos.Size = New System.Drawing.Size(1002, 146)
        Me.dgvDocumentos.TabIndex = 20
        '
        'cEliminar
        '
        Me.cEliminar.HeaderText = "Eliminar"
        Me.cEliminar.Name = "cEliminar"
        Me.cEliminar.ReadOnly = True
        Me.cEliminar.Text = "Eliminar"
        Me.cEliminar.UseColumnTextForLinkValue = True
        '
        'tlpError
        '
        Me.tlpError.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tlpError.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tlpError.ColumnCount = 1
        Me.tableLayoutPanel8.SetColumnSpan(Me.tlpError, 2)
        Me.tlpError.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpError.Controls.Add(Me.lError, 0, 0)
        Me.tlpError.Location = New System.Drawing.Point(338, 165)
        Me.tlpError.Name = "tlpError"
        Me.tlpError.RowCount = 1
        Me.tlpError.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpError.Size = New System.Drawing.Size(329, 30)
        Me.tlpError.TabIndex = 21
        Me.tlpError.Visible = False
        '
        'lError
        '
        Me.lError.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lError.AutoSize = True
        Me.lError.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lError.ForeColor = System.Drawing.Color.White
        Me.lError.Location = New System.Drawing.Point(276, 6)
        Me.lError.Name = "lError"
        Me.lError.Size = New System.Drawing.Size(50, 17)
        Me.lError.TabIndex = 0
        Me.lError.Text = "label36"
        '
        'label18
        '
        Me.label18.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.label18.AutoSize = True
        Me.label18.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label18.Location = New System.Drawing.Point(421, 51)
        Me.label18.Margin = New System.Windows.Forms.Padding(3)
        Me.label18.Name = "label18"
        Me.label18.Size = New System.Drawing.Size(36, 17)
        Me.label18.TabIndex = 0
        Me.label18.Text = "Folio"
        '
        'tbFolio
        '
        Me.tbFolio.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbFolio.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbFolio.Location = New System.Drawing.Point(463, 47)
        Me.tbFolio.Name = "tbFolio"
        Me.tbFolio.Size = New System.Drawing.Size(204, 25)
        Me.tbFolio.TabIndex = 2
        '
        'tbTipoCambio
        '
        Me.tbTipoCambio.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbTipoCambio.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTipoCambio.Location = New System.Drawing.Point(128, 87)
        Me.tbTipoCambio.Name = "tbTipoCambio"
        Me.tbTipoCambio.Size = New System.Drawing.Size(204, 25)
        Me.tbTipoCambio.TabIndex = 2
        '
        'Label20
        '
        Me.Label20.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(689, 91)
        Me.Label20.Margin = New System.Windows.Forms.Padding(3)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(105, 17)
        Me.Label20.TabIndex = 27
        Me.Label20.Text = "Núm parcialidad"
        '
        'tbNumeroParcialidad
        '
        Me.tbNumeroParcialidad.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbNumeroParcialidad.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNumeroParcialidad.Location = New System.Drawing.Point(800, 87)
        Me.tbNumeroParcialidad.Name = "tbNumeroParcialidad"
        Me.tbNumeroParcialidad.Size = New System.Drawing.Size(205, 25)
        Me.tbNumeroParcialidad.TabIndex = 26
        '
        'Label25
        '
        Me.Label25.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(353, 131)
        Me.Label25.Margin = New System.Windows.Forms.Padding(3)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(104, 17)
        Me.Label25.TabIndex = 29
        Me.Label25.Text = "Importe pagado"
        '
        'Label27
        '
        Me.Label27.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(704, 123)
        Me.Label27.Margin = New System.Windows.Forms.Padding(3)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(90, 34)
        Me.Label27.TabIndex = 30
        Me.Label27.Text = "Importe saldo insoluto"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'label26
        '
        Me.label26.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.label26.AutoSize = True
        Me.label26.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label26.Location = New System.Drawing.Point(13, 123)
        Me.label26.Margin = New System.Windows.Forms.Padding(3)
        Me.label26.Name = "label26"
        Me.label26.Size = New System.Drawing.Size(109, 34)
        Me.label26.TabIndex = 0
        Me.label26.Text = "Importe de saldo anterior"
        Me.label26.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'label17
        '
        Me.label17.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.label17.AutoSize = True
        Me.label17.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label17.Location = New System.Drawing.Point(85, 51)
        Me.label17.Margin = New System.Windows.Forms.Padding(3)
        Me.label17.Name = "label17"
        Me.label17.Size = New System.Drawing.Size(37, 17)
        Me.label17.TabIndex = 0
        Me.label17.Text = "Serie"
        '
        'label16
        '
        Me.label16.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.label16.AutoSize = True
        Me.label16.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label16.Location = New System.Drawing.Point(730, 51)
        Me.label16.Margin = New System.Windows.Forms.Padding(3)
        Me.label16.Name = "label16"
        Me.label16.Size = New System.Drawing.Size(64, 17)
        Me.label16.TabIndex = 0
        Me.label16.Text = "*Moneda"
        '
        'cbMoneda
        '
        Me.cbMoneda.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbMoneda.DisplayMember = "ClaveYDescripcion"
        Me.cbMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMoneda.DropDownWidth = 200
        Me.cbMoneda.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMoneda.FormattingEnabled = True
        Me.cbMoneda.Location = New System.Drawing.Point(800, 47)
        Me.cbMoneda.Name = "cbMoneda"
        Me.cbMoneda.Size = New System.Drawing.Size(205, 25)
        Me.cbMoneda.TabIndex = 3
        Me.cbMoneda.ValueMember = "Id"
        '
        'label30
        '
        Me.label30.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.label30.AutoSize = True
        Me.label30.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label30.Location = New System.Drawing.Point(22, 83)
        Me.label30.Margin = New System.Windows.Forms.Padding(3)
        Me.label30.Name = "label30"
        Me.label30.Size = New System.Drawing.Size(100, 34)
        Me.label30.TabIndex = 0
        Me.label30.Text = "Tipo de cambio del documento"
        Me.label30.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(341, 91)
        Me.Label1.Margin = New System.Windows.Forms.Padding(3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 17)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "*Metodo de pago"
        '
        'tbSerie
        '
        Me.tbSerie.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbSerie.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbSerie.Location = New System.Drawing.Point(128, 47)
        Me.tbSerie.Name = "tbSerie"
        Me.tbSerie.Size = New System.Drawing.Size(204, 25)
        Me.tbSerie.TabIndex = 37
        '
        'nudImporteSaldoAnterior
        '
        Me.nudImporteSaldoAnterior.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nudImporteSaldoAnterior.DecimalPlaces = 2
        Me.nudImporteSaldoAnterior.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudImporteSaldoAnterior.Location = New System.Drawing.Point(128, 127)
        Me.nudImporteSaldoAnterior.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.nudImporteSaldoAnterior.Name = "nudImporteSaldoAnterior"
        Me.nudImporteSaldoAnterior.Size = New System.Drawing.Size(204, 25)
        Me.nudImporteSaldoAnterior.TabIndex = 38
        '
        'nudImportePagado
        '
        Me.nudImportePagado.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nudImportePagado.DecimalPlaces = 2
        Me.nudImportePagado.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudImportePagado.Location = New System.Drawing.Point(463, 127)
        Me.nudImportePagado.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.nudImportePagado.Name = "nudImportePagado"
        Me.nudImportePagado.Size = New System.Drawing.Size(204, 25)
        Me.nudImportePagado.TabIndex = 39
        '
        'nudImporteInsoluto
        '
        Me.nudImporteInsoluto.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nudImporteInsoluto.DecimalPlaces = 2
        Me.nudImporteInsoluto.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudImporteInsoluto.Location = New System.Drawing.Point(800, 127)
        Me.nudImporteInsoluto.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.nudImporteInsoluto.Name = "nudImporteInsoluto"
        Me.nudImporteInsoluto.Size = New System.Drawing.Size(205, 25)
        Me.nudImporteInsoluto.TabIndex = 40
        '
        'cbMetodoPago
        '
        Me.cbMetodoPago.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbMetodoPago.DisplayMember = "ClaveYDescripcion"
        Me.cbMetodoPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMetodoPago.DropDownWidth = 250
        Me.cbMetodoPago.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMetodoPago.FormattingEnabled = True
        Me.cbMetodoPago.Location = New System.Drawing.Point(463, 87)
        Me.cbMetodoPago.Name = "cbMetodoPago"
        Me.cbMetodoPago.Size = New System.Drawing.Size(204, 25)
        Me.cbMetodoPago.TabIndex = 41
        Me.cbMetodoPago.ValueMember = "Id"
        '
        'btnBuscar
        '
        Me.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.btnBuscar.FlatAppearance.BorderSize = 0
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.ForeColor = System.Drawing.Color.White
        Me.btnBuscar.Location = New System.Drawing.Point(686, 6)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(108, 28)
        Me.btnBuscar.TabIndex = 42
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'wDoctosRelacionados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1018, 382)
        Me.Controls.Add(Me.tableLayoutPanel7)
        Me.Name = "wDoctosRelacionados"
        Me.Text = "wDoctosRelacionados"
        Me.tableLayoutPanel7.ResumeLayout(False)
        Me.tableLayoutPanel7.PerformLayout()
        Me.tableLayoutPanel25.ResumeLayout(False)
        Me.tableLayoutPanel25.PerformLayout()
        Me.tableLayoutPanel8.ResumeLayout(False)
        Me.tableLayoutPanel8.PerformLayout()
        Me.tableLayoutPanel12.ResumeLayout(False)
        CType(Me.dgvDocumentos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpError.ResumeLayout(False)
        Me.tlpError.PerformLayout()
        CType(Me.nudImporteSaldoAnterior, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudImportePagado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudImporteInsoluto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents tableLayoutPanel7 As System.Windows.Forms.TableLayoutPanel
    Private WithEvents tableLayoutPanel25 As System.Windows.Forms.TableLayoutPanel
    Private WithEvents label21 As System.Windows.Forms.Label
    Private WithEvents tableLayoutPanel8 As System.Windows.Forms.TableLayoutPanel
    Private WithEvents label16 As System.Windows.Forms.Label
    Private WithEvents cbMoneda As System.Windows.Forms.ComboBox
    Private WithEvents label17 As System.Windows.Forms.Label
    Private WithEvents label22 As System.Windows.Forms.Label
    Private WithEvents tableLayoutPanel12 As System.Windows.Forms.TableLayoutPanel
    Private WithEvents btnAgregaConcepto As System.Windows.Forms.Button
    Private WithEvents btnConceptoLimpiar As System.Windows.Forms.Button
    Private WithEvents dgvDocumentos As System.Windows.Forms.DataGridView
    Private WithEvents tlpError As System.Windows.Forms.TableLayoutPanel
    Private WithEvents lError As System.Windows.Forms.Label
    Private WithEvents label18 As System.Windows.Forms.Label
    Private WithEvents tbFolio As System.Windows.Forms.TextBox
    Private WithEvents label26 As System.Windows.Forms.Label
    Private WithEvents tbTipoCambio As System.Windows.Forms.TextBox
    Private WithEvents label30 As System.Windows.Forms.Label
    Private WithEvents Label20 As System.Windows.Forms.Label
    Private WithEvents tbNumeroParcialidad As System.Windows.Forms.TextBox
    Private WithEvents Label25 As System.Windows.Forms.Label
    Private WithEvents Label27 As System.Windows.Forms.Label
    Private WithEvents tbIdDocumento As System.Windows.Forms.TextBox
    Private WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cEliminar As System.Windows.Forms.DataGridViewLinkColumn
    Private WithEvents tbSerie As System.Windows.Forms.TextBox
    Private WithEvents nudImporteSaldoAnterior As System.Windows.Forms.NumericUpDown
    Private WithEvents nudImportePagado As System.Windows.Forms.NumericUpDown
    Private WithEvents nudImporteInsoluto As System.Windows.Forms.NumericUpDown
    Private WithEvents cbMetodoPago As System.Windows.Forms.ComboBox
    Private WithEvents btnBuscar As Button
End Class
