<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmErogacion
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
        Me.NudPorcentaje = New System.Windows.Forms.NumericUpDown()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblMontoErogacion_sin_iva = New System.Windows.Forms.Label()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dgvDocumentoRelacionado = New System.Windows.Forms.DataGridView()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnAgregarDocumentoRelacionado = New System.Windows.Forms.Button()
        Me.btnEliminarDocumentoRelacionado = New System.Windows.Forms.Button()
        Me.btnEditarDocumentoRelacionado = New System.Windows.Forms.Button()
        Me.btnImportar = New System.Windows.Forms.Button()
        Me.lblNumeroDocumentos = New System.Windows.Forms.Label()
        Me.lblMontoErogacion = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel12 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel13 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dgvCentroCostos = New System.Windows.Forms.DataGridView()
        Me.FlowLayoutPanel6 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnAgregarCentroCosto = New System.Windows.Forms.Button()
        Me.btnEliminarCentroCostos = New System.Windows.Forms.Button()
        Me.btnEditarCentroCostos = New System.Windows.Forms.Button()
        Me.TableLayoutPanel10 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel11 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dgvActividades = New System.Windows.Forms.DataGridView()
        Me.FlowLayoutPanel5 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnAgregarActividad = New System.Windows.Forms.Button()
        Me.btnEliminarActividad = New System.Windows.Forms.Button()
        Me.btnEditarActividades = New System.Windows.Forms.Button()
        Me.cbTipoErogacion = New System.Windows.Forms.ComboBox()
        Me.nudMontocuErogacion = New System.Windows.Forms.NumericUpDown()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TotalMErogacion = New System.Windows.Forms.Label()
        Me.ToolStripContainer1.BottomToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.NudPorcentaje, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        CType(Me.dgvDocumentoRelacionado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel7.SuspendLayout()
        Me.TableLayoutPanel12.SuspendLayout()
        Me.TableLayoutPanel13.SuspendLayout()
        CType(Me.dgvCentroCostos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel6.SuspendLayout()
        Me.TableLayoutPanel10.SuspendLayout()
        Me.TableLayoutPanel11.SuspendLayout()
        CType(Me.dgvActividades, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel5.SuspendLayout()
        CType(Me.nudMontocuErogacion, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(895, 476)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.Size = New System.Drawing.Size(895, 523)
        Me.ToolStripContainer1.TabIndex = 4
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.StatusStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lError})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 0)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(895, 22)
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
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(5)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(895, 476)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(402, 10)
        Me.Label5.Margin = New System.Windows.Forms.Padding(10)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 20)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Erogación"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.NudPorcentaje, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel3, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label2, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Label4, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel7, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.cbTipoErogacion, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.nudMontocuErogacion, 1, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(13, 52)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(13, 12, 13, 12)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 4
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(869, 355)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'NudPorcentaje
        '
        Me.NudPorcentaje.Cursor = System.Windows.Forms.Cursors.Default
        Me.NudPorcentaje.DecimalPlaces = 3
        Me.NudPorcentaje.Location = New System.Drawing.Point(128, 61)
        Me.NudPorcentaje.Maximum = New Decimal(New Integer() {99999, 0, 0, 196608})
        Me.NudPorcentaje.Name = "NudPorcentaje"
        Me.NudPorcentaje.Size = New System.Drawing.Size(175, 23)
        Me.NudPorcentaje.TabIndex = 19
        Me.NudPorcentaje.Value = New Decimal(New Integer() {1, 0, 0, 196608})
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel2.SetColumnSpan(Me.TableLayoutPanel3, 2)
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.TotalMErogacion, 0, 6)
        Me.TableLayoutPanel3.Controls.Add(Me.lblMontoErogacion_sin_iva, 0, 5)
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel5, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.dgvDocumentoRelacionado, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.FlowLayoutPanel2, 0, 4)
        Me.TableLayoutPanel3.Controls.Add(Me.lblNumeroDocumentos, 0, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.lblMontoErogacion, 0, 5)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(10, 97)
        Me.TableLayoutPanel3.Margin = New System.Windows.Forms.Padding(10)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 7
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(402, 248)
        Me.TableLayoutPanel3.TabIndex = 14
        '
        'lblMontoErogacion_sin_iva
        '
        Me.lblMontoErogacion_sin_iva.AutoSize = True
        Me.lblMontoErogacion_sin_iva.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblMontoErogacion_sin_iva.Location = New System.Drawing.Point(3, 171)
        Me.lblMontoErogacion_sin_iva.Name = "lblMontoErogacion_sin_iva"
        Me.lblMontoErogacion_sin_iva.Size = New System.Drawing.Size(98, 15)
        Me.lblMontoErogacion_sin_iva.TabIndex = 15
        Me.lblMontoErogacion_sin_iva.Text = "MontoErogación"
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.AutoSize = True
        Me.TableLayoutPanel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel5.ColumnCount = 4
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel5.Controls.Add(Me.Label9, 0, 0)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 1
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(396, 20)
        Me.TableLayoutPanel5.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(4, 0)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(307, 20)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Documento relacionado  (1, ilimitado)"
        '
        'dgvDocumentoRelacionado
        '
        Me.dgvDocumentoRelacionado.AllowUserToAddRows = False
        Me.dgvDocumentoRelacionado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvDocumentoRelacionado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDocumentoRelacionado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvDocumentoRelacionado.Location = New System.Drawing.Point(3, 29)
        Me.dgvDocumentoRelacionado.Name = "dgvDocumentoRelacionado"
        Me.dgvDocumentoRelacionado.ReadOnly = True
        Me.dgvDocumentoRelacionado.RowHeadersWidth = 5
        Me.dgvDocumentoRelacionado.Size = New System.Drawing.Size(396, 86)
        Me.dgvDocumentoRelacionado.TabIndex = 0
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.AutoSize = True
        Me.FlowLayoutPanel2.Controls.Add(Me.btnAgregarDocumentoRelacionado)
        Me.FlowLayoutPanel2.Controls.Add(Me.btnEliminarDocumentoRelacionado)
        Me.FlowLayoutPanel2.Controls.Add(Me.btnEditarDocumentoRelacionado)
        Me.FlowLayoutPanel2.Controls.Add(Me.btnImportar)
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(3, 136)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(316, 32)
        Me.FlowLayoutPanel2.TabIndex = 12
        '
        'btnAgregarDocumentoRelacionado
        '
        Me.btnAgregarDocumentoRelacionado.AutoSize = True
        Me.btnAgregarDocumentoRelacionado.Location = New System.Drawing.Point(3, 3)
        Me.btnAgregarDocumentoRelacionado.Name = "btnAgregarDocumentoRelacionado"
        Me.btnAgregarDocumentoRelacionado.Size = New System.Drawing.Size(67, 26)
        Me.btnAgregarDocumentoRelacionado.TabIndex = 0
        Me.btnAgregarDocumentoRelacionado.Text = "Agregar"
        Me.btnAgregarDocumentoRelacionado.UseVisualStyleBackColor = True
        '
        'btnEliminarDocumentoRelacionado
        '
        Me.btnEliminarDocumentoRelacionado.AutoSize = True
        Me.btnEliminarDocumentoRelacionado.Enabled = False
        Me.btnEliminarDocumentoRelacionado.Location = New System.Drawing.Point(76, 3)
        Me.btnEliminarDocumentoRelacionado.Name = "btnEliminarDocumentoRelacionado"
        Me.btnEliminarDocumentoRelacionado.Size = New System.Drawing.Size(75, 26)
        Me.btnEliminarDocumentoRelacionado.TabIndex = 1
        Me.btnEliminarDocumentoRelacionado.Text = "Eliminar"
        Me.btnEliminarDocumentoRelacionado.UseVisualStyleBackColor = True
        '
        'btnEditarDocumentoRelacionado
        '
        Me.btnEditarDocumentoRelacionado.AutoSize = True
        Me.btnEditarDocumentoRelacionado.Enabled = False
        Me.btnEditarDocumentoRelacionado.Location = New System.Drawing.Point(157, 3)
        Me.btnEditarDocumentoRelacionado.Name = "btnEditarDocumentoRelacionado"
        Me.btnEditarDocumentoRelacionado.Size = New System.Drawing.Size(75, 26)
        Me.btnEditarDocumentoRelacionado.TabIndex = 2
        Me.btnEditarDocumentoRelacionado.Text = "Editar"
        Me.btnEditarDocumentoRelacionado.UseVisualStyleBackColor = True
        '
        'btnImportar
        '
        Me.btnImportar.AutoSize = True
        Me.btnImportar.Location = New System.Drawing.Point(238, 3)
        Me.btnImportar.Name = "btnImportar"
        Me.btnImportar.Size = New System.Drawing.Size(75, 26)
        Me.btnImportar.TabIndex = 3
        Me.btnImportar.Text = "Importar ..."
        Me.btnImportar.UseVisualStyleBackColor = True
        '
        'lblNumeroDocumentos
        '
        Me.lblNumeroDocumentos.AutoSize = True
        Me.lblNumeroDocumentos.Location = New System.Drawing.Point(3, 118)
        Me.lblNumeroDocumentos.Name = "lblNumeroDocumentos"
        Me.lblNumeroDocumentos.Size = New System.Drawing.Size(153, 15)
        Me.lblNumeroDocumentos.TabIndex = 13
        Me.lblNumeroDocumentos.Text = "0 documentos relacionados"
        '
        'lblMontoErogacion
        '
        Me.lblMontoErogacion.AutoSize = True
        Me.lblMontoErogacion.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblMontoErogacion.Location = New System.Drawing.Point(3, 194)
        Me.lblMontoErogacion.Name = "lblMontoErogacion"
        Me.lblMontoErogacion.Size = New System.Drawing.Size(98, 15)
        Me.lblMontoErogacion.TabIndex = 14
        Me.lblMontoErogacion.Text = "MontoErogación"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 36)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Montocu Erogación:"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(4, 65)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Porcentaje:"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(4, 7)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 15)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Tipo de erogación:"
        '
        'TableLayoutPanel7
        '
        Me.TableLayoutPanel7.ColumnCount = 1
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel7.Controls.Add(Me.TableLayoutPanel12, 0, 1)
        Me.TableLayoutPanel7.Controls.Add(Me.TableLayoutPanel10, 0, 0)
        Me.TableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel7.Location = New System.Drawing.Point(425, 3)
        Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
        Me.TableLayoutPanel7.RowCount = 2
        Me.TableLayoutPanel2.SetRowSpan(Me.TableLayoutPanel7, 4)
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel7.Size = New System.Drawing.Size(441, 349)
        Me.TableLayoutPanel7.TabIndex = 16
        '
        'TableLayoutPanel12
        '
        Me.TableLayoutPanel12.ColumnCount = 1
        Me.TableLayoutPanel7.SetColumnSpan(Me.TableLayoutPanel12, 2)
        Me.TableLayoutPanel12.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel12.Controls.Add(Me.TableLayoutPanel13, 0, 0)
        Me.TableLayoutPanel12.Controls.Add(Me.dgvCentroCostos, 0, 1)
        Me.TableLayoutPanel12.Controls.Add(Me.FlowLayoutPanel6, 0, 2)
        Me.TableLayoutPanel12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel12.Location = New System.Drawing.Point(10, 184)
        Me.TableLayoutPanel12.Margin = New System.Windows.Forms.Padding(10)
        Me.TableLayoutPanel12.Name = "TableLayoutPanel12"
        Me.TableLayoutPanel12.RowCount = 4
        Me.TableLayoutPanel12.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel12.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.85714!))
        Me.TableLayoutPanel12.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel12.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel12.Size = New System.Drawing.Size(421, 155)
        Me.TableLayoutPanel12.TabIndex = 17
        '
        'TableLayoutPanel13
        '
        Me.TableLayoutPanel13.AutoSize = True
        Me.TableLayoutPanel13.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel13.ColumnCount = 4
        Me.TableLayoutPanel13.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel13.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel13.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel13.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel13.Controls.Add(Me.Label8, 0, 0)
        Me.TableLayoutPanel13.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel13.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel13.Name = "TableLayoutPanel13"
        Me.TableLayoutPanel13.RowCount = 1
        Me.TableLayoutPanel13.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel13.Size = New System.Drawing.Size(415, 20)
        Me.TableLayoutPanel13.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(4, 0)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(249, 20)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Centro de costos (0, ilimitado)"
        '
        'dgvCentroCostos
        '
        Me.dgvCentroCostos.AllowUserToAddRows = False
        Me.dgvCentroCostos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvCentroCostos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCentroCostos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvCentroCostos.Location = New System.Drawing.Point(3, 29)
        Me.dgvCentroCostos.Name = "dgvCentroCostos"
        Me.dgvCentroCostos.ReadOnly = True
        Me.dgvCentroCostos.RowHeadersWidth = 5
        Me.dgvCentroCostos.Size = New System.Drawing.Size(415, 85)
        Me.dgvCentroCostos.TabIndex = 0
        '
        'FlowLayoutPanel6
        '
        Me.FlowLayoutPanel6.AutoSize = True
        Me.FlowLayoutPanel6.Controls.Add(Me.btnAgregarCentroCosto)
        Me.FlowLayoutPanel6.Controls.Add(Me.btnEliminarCentroCostos)
        Me.FlowLayoutPanel6.Controls.Add(Me.btnEditarCentroCostos)
        Me.FlowLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel6.Location = New System.Drawing.Point(3, 120)
        Me.FlowLayoutPanel6.Name = "FlowLayoutPanel6"
        Me.FlowLayoutPanel6.Size = New System.Drawing.Size(415, 32)
        Me.FlowLayoutPanel6.TabIndex = 12
        '
        'btnAgregarCentroCosto
        '
        Me.btnAgregarCentroCosto.AutoSize = True
        Me.btnAgregarCentroCosto.Location = New System.Drawing.Point(3, 3)
        Me.btnAgregarCentroCosto.Name = "btnAgregarCentroCosto"
        Me.btnAgregarCentroCosto.Size = New System.Drawing.Size(67, 26)
        Me.btnAgregarCentroCosto.TabIndex = 0
        Me.btnAgregarCentroCosto.Text = "Agregar"
        Me.btnAgregarCentroCosto.UseVisualStyleBackColor = True
        '
        'btnEliminarCentroCostos
        '
        Me.btnEliminarCentroCostos.AutoSize = True
        Me.btnEliminarCentroCostos.Enabled = False
        Me.btnEliminarCentroCostos.Location = New System.Drawing.Point(76, 3)
        Me.btnEliminarCentroCostos.Name = "btnEliminarCentroCostos"
        Me.btnEliminarCentroCostos.Size = New System.Drawing.Size(75, 26)
        Me.btnEliminarCentroCostos.TabIndex = 1
        Me.btnEliminarCentroCostos.Text = "Eliminar"
        Me.btnEliminarCentroCostos.UseVisualStyleBackColor = True
        '
        'btnEditarCentroCostos
        '
        Me.btnEditarCentroCostos.AutoSize = True
        Me.btnEditarCentroCostos.Enabled = False
        Me.btnEditarCentroCostos.Location = New System.Drawing.Point(157, 3)
        Me.btnEditarCentroCostos.Name = "btnEditarCentroCostos"
        Me.btnEditarCentroCostos.Size = New System.Drawing.Size(75, 26)
        Me.btnEditarCentroCostos.TabIndex = 2
        Me.btnEditarCentroCostos.Text = "Editar"
        Me.btnEditarCentroCostos.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel10
        '
        Me.TableLayoutPanel10.ColumnCount = 1
        Me.TableLayoutPanel7.SetColumnSpan(Me.TableLayoutPanel10, 2)
        Me.TableLayoutPanel10.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel10.Controls.Add(Me.TableLayoutPanel11, 0, 0)
        Me.TableLayoutPanel10.Controls.Add(Me.dgvActividades, 0, 1)
        Me.TableLayoutPanel10.Controls.Add(Me.FlowLayoutPanel5, 0, 2)
        Me.TableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel10.Location = New System.Drawing.Point(10, 10)
        Me.TableLayoutPanel10.Margin = New System.Windows.Forms.Padding(10)
        Me.TableLayoutPanel10.Name = "TableLayoutPanel10"
        Me.TableLayoutPanel10.RowCount = 4
        Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.85714!))
        Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel10.Size = New System.Drawing.Size(421, 154)
        Me.TableLayoutPanel10.TabIndex = 16
        '
        'TableLayoutPanel11
        '
        Me.TableLayoutPanel11.AutoSize = True
        Me.TableLayoutPanel11.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel11.ColumnCount = 4
        Me.TableLayoutPanel11.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel11.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel11.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel11.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel11.Controls.Add(Me.Label7, 0, 0)
        Me.TableLayoutPanel11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel11.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel11.Name = "TableLayoutPanel11"
        Me.TableLayoutPanel11.RowCount = 1
        Me.TableLayoutPanel11.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel11.Size = New System.Drawing.Size(415, 20)
        Me.TableLayoutPanel11.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(4, 0)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(204, 20)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Actividades (0, ilimitado)"
        '
        'dgvActividades
        '
        Me.dgvActividades.AllowUserToAddRows = False
        Me.dgvActividades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvActividades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvActividades.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvActividades.Location = New System.Drawing.Point(3, 29)
        Me.dgvActividades.Name = "dgvActividades"
        Me.dgvActividades.ReadOnly = True
        Me.dgvActividades.RowHeadersWidth = 5
        Me.dgvActividades.Size = New System.Drawing.Size(415, 84)
        Me.dgvActividades.TabIndex = 0
        '
        'FlowLayoutPanel5
        '
        Me.FlowLayoutPanel5.AutoSize = True
        Me.FlowLayoutPanel5.Controls.Add(Me.btnAgregarActividad)
        Me.FlowLayoutPanel5.Controls.Add(Me.btnEliminarActividad)
        Me.FlowLayoutPanel5.Controls.Add(Me.btnEditarActividades)
        Me.FlowLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel5.Location = New System.Drawing.Point(3, 119)
        Me.FlowLayoutPanel5.Name = "FlowLayoutPanel5"
        Me.FlowLayoutPanel5.Size = New System.Drawing.Size(415, 32)
        Me.FlowLayoutPanel5.TabIndex = 12
        '
        'btnAgregarActividad
        '
        Me.btnAgregarActividad.AutoSize = True
        Me.btnAgregarActividad.Location = New System.Drawing.Point(3, 3)
        Me.btnAgregarActividad.Name = "btnAgregarActividad"
        Me.btnAgregarActividad.Size = New System.Drawing.Size(67, 26)
        Me.btnAgregarActividad.TabIndex = 0
        Me.btnAgregarActividad.Text = "Agregar"
        Me.btnAgregarActividad.UseVisualStyleBackColor = True
        '
        'btnEliminarActividad
        '
        Me.btnEliminarActividad.AutoSize = True
        Me.btnEliminarActividad.Enabled = False
        Me.btnEliminarActividad.Location = New System.Drawing.Point(76, 3)
        Me.btnEliminarActividad.Name = "btnEliminarActividad"
        Me.btnEliminarActividad.Size = New System.Drawing.Size(75, 26)
        Me.btnEliminarActividad.TabIndex = 1
        Me.btnEliminarActividad.Text = "Eliminar"
        Me.btnEliminarActividad.UseVisualStyleBackColor = True
        '
        'btnEditarActividades
        '
        Me.btnEditarActividades.AutoSize = True
        Me.btnEditarActividades.Enabled = False
        Me.btnEditarActividades.Location = New System.Drawing.Point(157, 3)
        Me.btnEditarActividades.Name = "btnEditarActividades"
        Me.btnEditarActividades.Size = New System.Drawing.Size(75, 26)
        Me.btnEditarActividades.TabIndex = 2
        Me.btnEditarActividades.Text = "Editar"
        Me.btnEditarActividades.UseVisualStyleBackColor = True
        '
        'cbTipoErogacion
        '
        Me.cbTipoErogacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipoErogacion.FormattingEnabled = True
        Me.cbTipoErogacion.Items.AddRange(New Object() {"Costo", "Gasto", "Inversión"})
        Me.cbTipoErogacion.Location = New System.Drawing.Point(128, 3)
        Me.cbTipoErogacion.Name = "cbTipoErogacion"
        Me.cbTipoErogacion.Size = New System.Drawing.Size(175, 23)
        Me.cbTipoErogacion.TabIndex = 17
        '
        'nudMontocuErogacion
        '
        Me.nudMontocuErogacion.DecimalPlaces = 2
        Me.nudMontocuErogacion.Location = New System.Drawing.Point(128, 32)
        Me.nudMontocuErogacion.Maximum = New Decimal(New Integer() {-1943132160, 209, 0, 0})
        Me.nudMontocuErogacion.Name = "nudMontocuErogacion"
        Me.nudMontocuErogacion.Size = New System.Drawing.Size(175, 23)
        Me.nudMontocuErogacion.TabIndex = 18
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoSize = True
        Me.FlowLayoutPanel1.Controls.Add(Me.btnAceptar)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnCancelar)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(13, 431)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(13, 12, 13, 12)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(869, 33)
        Me.FlowLayoutPanel1.TabIndex = 1
        '
        'btnAceptar
        '
        Me.btnAceptar.AutoSize = True
        Me.btnAceptar.Location = New System.Drawing.Point(808, 3)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Padding = New System.Windows.Forms.Padding(2)
        Me.btnAceptar.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnAceptar.Size = New System.Drawing.Size(58, 27)
        Me.btnAceptar.TabIndex = 0
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.AutoSize = True
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.Location = New System.Drawing.Point(739, 3)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Padding = New System.Windows.Forms.Padding(2)
        Me.btnCancelar.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnCancelar.Size = New System.Drawing.Size(63, 27)
        Me.btnCancelar.TabIndex = 1
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 4000
        '
        'TotalMErogacion
        '
        Me.TotalMErogacion.AutoSize = True
        Me.TotalMErogacion.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.TotalMErogacion.Location = New System.Drawing.Point(3, 228)
        Me.TotalMErogacion.Name = "TotalMErogacion"
        Me.TotalMErogacion.Size = New System.Drawing.Size(98, 15)
        Me.TotalMErogacion.TabIndex = 16
        Me.TotalMErogacion.Text = "MontoErogación"
        '
        'frmErogacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(895, 523)
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Name = "frmErogacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Erogación"
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
        CType(Me.NudPorcentaje, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel5.PerformLayout()
        CType(Me.dgvDocumentoRelacionado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.FlowLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel7.ResumeLayout(False)
        Me.TableLayoutPanel12.ResumeLayout(False)
        Me.TableLayoutPanel12.PerformLayout()
        Me.TableLayoutPanel13.ResumeLayout(False)
        Me.TableLayoutPanel13.PerformLayout()
        CType(Me.dgvCentroCostos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel6.ResumeLayout(False)
        Me.FlowLayoutPanel6.PerformLayout()
        Me.TableLayoutPanel10.ResumeLayout(False)
        Me.TableLayoutPanel10.PerformLayout()
        Me.TableLayoutPanel11.ResumeLayout(False)
        Me.TableLayoutPanel11.PerformLayout()
        CType(Me.dgvActividades, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel5.ResumeLayout(False)
        Me.FlowLayoutPanel5.PerformLayout()
        CType(Me.nudMontocuErogacion, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel5 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents dgvDocumentoRelacionado As System.Windows.Forms.DataGridView
    Friend WithEvents FlowLayoutPanel2 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents btnAgregarDocumentoRelacionado As System.Windows.Forms.Button
    Friend WithEvents btnEliminarDocumentoRelacionado As System.Windows.Forms.Button
    Friend WithEvents btnEditarDocumentoRelacionado As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel7 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel12 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel13 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents dgvCentroCostos As System.Windows.Forms.DataGridView
    Friend WithEvents FlowLayoutPanel6 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents btnAgregarCentroCosto As System.Windows.Forms.Button
    Friend WithEvents btnEliminarCentroCostos As System.Windows.Forms.Button
    Friend WithEvents btnEditarCentroCostos As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel10 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel11 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents dgvActividades As System.Windows.Forms.DataGridView
    Friend WithEvents FlowLayoutPanel5 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents btnAgregarActividad As System.Windows.Forms.Button
    Friend WithEvents btnEliminarActividad As System.Windows.Forms.Button
    Friend WithEvents btnEditarActividades As System.Windows.Forms.Button
    Friend WithEvents NudPorcentaje As System.Windows.Forms.NumericUpDown
    Friend WithEvents cbTipoErogacion As System.Windows.Forms.ComboBox
    Friend WithEvents nudMontocuErogacion As System.Windows.Forms.NumericUpDown
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btnImportar As System.Windows.Forms.Button
    Friend WithEvents lblNumeroDocumentos As System.Windows.Forms.Label
    Friend WithEvents lblMontoErogacion As Label
    Friend WithEvents lblMontoErogacion_sin_iva As Label
    Friend WithEvents TotalMErogacion As Label
End Class
