<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class wProducto
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(wProducto))
        Me.flowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblDescripcionArt = New System.Windows.Forms.Label()
        Me.txtArtIntelisis = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.tbClaveProdServ = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.btnBuscarClaveProd = New System.Windows.Forms.Button()
        Me.tableLayoutPanel15 = New System.Windows.Forms.TableLayoutPanel()
        Me.tbClaveUnidad = New System.Windows.Forms.TextBox()
        Me.label15 = New System.Windows.Forms.Label()
        Me.btnBuscarUnidad = New System.Windows.Forms.Button()
        Me.tableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.tbUnidad = New System.Windows.Forms.TextBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.tableLayoutPanel14 = New System.Windows.Forms.TableLayoutPanel()
        Me.label3 = New System.Windows.Forms.Label()
        Me.tbNoIdentificacion = New System.Windows.Forms.TextBox()
        Me.tableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.nudPrecio = New System.Windows.Forms.NumericUpDown()
        Me.label9 = New System.Windows.Forms.Label()
        Me.tableLayoutPanel9 = New System.Windows.Forms.TableLayoutPanel()
        Me.label14 = New System.Windows.Forms.Label()
        Me.tbDescripcion = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.btnGuardarCliente = New System.Windows.Forms.Button()
        Me.tableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.flowLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.tableLayoutPanel2.SuspendLayout()
        Me.tableLayoutPanel15.SuspendLayout()
        Me.tableLayoutPanel3.SuspendLayout()
        Me.tableLayoutPanel14.SuspendLayout()
        Me.tableLayoutPanel4.SuspendLayout()
        CType(Me.nudPrecio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tableLayoutPanel9.SuspendLayout()
        Me.tableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'flowLayoutPanel1
        '
        Me.flowLayoutPanel1.AutoScroll = True
        Me.flowLayoutPanel1.Controls.Add(Me.TableLayoutPanel5)
        Me.flowLayoutPanel1.Controls.Add(Me.tableLayoutPanel2)
        Me.flowLayoutPanel1.Controls.Add(Me.tableLayoutPanel15)
        Me.flowLayoutPanel1.Controls.Add(Me.tableLayoutPanel3)
        Me.flowLayoutPanel1.Controls.Add(Me.tableLayoutPanel14)
        Me.flowLayoutPanel1.Controls.Add(Me.tableLayoutPanel4)
        Me.flowLayoutPanel1.Controls.Add(Me.tableLayoutPanel9)
        Me.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flowLayoutPanel1.Location = New System.Drawing.Point(3, 59)
        Me.flowLayoutPanel1.Name = "flowLayoutPanel1"
        Me.flowLayoutPanel1.Size = New System.Drawing.Size(595, 341)
        Me.flowLayoutPanel1.TabIndex = 0
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 2
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.lblDescripcionArt, 0, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.txtArtIntelisis, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.Label5, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.Label6, 0, 1)
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 2
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(583, 70)
        Me.TableLayoutPanel5.TabIndex = 20
        '
        'lblDescripcionArt
        '
        Me.lblDescripcionArt.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblDescripcionArt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDescripcionArt.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescripcionArt.Location = New System.Drawing.Point(133, 37)
        Me.lblDescripcionArt.Margin = New System.Windows.Forms.Padding(3)
        Me.lblDescripcionArt.Name = "lblDescripcionArt"
        Me.lblDescripcionArt.Size = New System.Drawing.Size(447, 28)
        Me.lblDescripcionArt.TabIndex = 6
        Me.lblDescripcionArt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtArtIntelisis
        '
        Me.txtArtIntelisis.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtArtIntelisis.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtArtIntelisis.Location = New System.Drawing.Point(133, 3)
        Me.txtArtIntelisis.Name = "txtArtIntelisis"
        Me.txtArtIntelisis.Size = New System.Drawing.Size(218, 29)
        Me.txtArtIntelisis.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(23, 7)
        Me.Label5.Margin = New System.Windows.Forms.Padding(3)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 17)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Articulo Intelisis"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(50, 42)
        Me.Label6.Margin = New System.Windows.Forms.Padding(3)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 17)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Descripción"
        '
        'tableLayoutPanel2
        '
        Me.tableLayoutPanel2.ColumnCount = 3
        Me.tableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 134.0!))
        Me.tableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33.0!))
        Me.tableLayoutPanel2.Controls.Add(Me.tbClaveProdServ, 1, 0)
        Me.tableLayoutPanel2.Controls.Add(Me.label2, 0, 0)
        Me.tableLayoutPanel2.Controls.Add(Me.btnBuscarClaveProd, 2, 0)
        Me.tableLayoutPanel2.Location = New System.Drawing.Point(3, 79)
        Me.tableLayoutPanel2.Name = "tableLayoutPanel2"
        Me.tableLayoutPanel2.RowCount = 1
        Me.tableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableLayoutPanel2.Size = New System.Drawing.Size(583, 37)
        Me.tableLayoutPanel2.TabIndex = 5
        '
        'tbClaveProdServ
        '
        Me.tbClaveProdServ.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.tbClaveProdServ.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbClaveProdServ.Location = New System.Drawing.Point(137, 4)
        Me.tbClaveProdServ.Name = "tbClaveProdServ"
        Me.tbClaveProdServ.ReadOnly = True
        Me.tbClaveProdServ.Size = New System.Drawing.Size(410, 29)
        Me.tbClaveProdServ.TabIndex = 2
        '
        'label2
        '
        Me.label2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(12, 10)
        Me.label2.Margin = New System.Windows.Forms.Padding(3)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(119, 17)
        Me.label2.TabIndex = 0
        Me.label2.Text = "Clave de producto"
        '
        'btnBuscarClaveProd
        '
        Me.btnBuscarClaveProd.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnBuscarClaveProd.BackColor = System.Drawing.Color.Transparent
        Me.btnBuscarClaveProd.BackgroundImage = Global.ef33LlantasRegio.My.Resources.Resources.icons8_search_24_1_
        Me.btnBuscarClaveProd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnBuscarClaveProd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnBuscarClaveProd.FlatAppearance.BorderSize = 0
        Me.btnBuscarClaveProd.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.btnBuscarClaveProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscarClaveProd.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnBuscarClaveProd.Location = New System.Drawing.Point(553, 6)
        Me.btnBuscarClaveProd.Name = "btnBuscarClaveProd"
        Me.btnBuscarClaveProd.Size = New System.Drawing.Size(27, 24)
        Me.btnBuscarClaveProd.TabIndex = 18
        Me.btnBuscarClaveProd.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnBuscarClaveProd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBuscarClaveProd.UseVisualStyleBackColor = False
        '
        'tableLayoutPanel15
        '
        Me.tableLayoutPanel15.ColumnCount = 3
        Me.tableLayoutPanel15.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 134.0!))
        Me.tableLayoutPanel15.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableLayoutPanel15.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33.0!))
        Me.tableLayoutPanel15.Controls.Add(Me.tbClaveUnidad, 1, 0)
        Me.tableLayoutPanel15.Controls.Add(Me.label15, 0, 0)
        Me.tableLayoutPanel15.Controls.Add(Me.btnBuscarUnidad, 2, 0)
        Me.tableLayoutPanel15.Location = New System.Drawing.Point(3, 122)
        Me.tableLayoutPanel15.Name = "tableLayoutPanel15"
        Me.tableLayoutPanel15.RowCount = 1
        Me.tableLayoutPanel15.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableLayoutPanel15.Size = New System.Drawing.Size(583, 37)
        Me.tableLayoutPanel15.TabIndex = 18
        '
        'tbClaveUnidad
        '
        Me.tbClaveUnidad.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.tbClaveUnidad.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbClaveUnidad.Location = New System.Drawing.Point(137, 4)
        Me.tbClaveUnidad.Name = "tbClaveUnidad"
        Me.tbClaveUnidad.ReadOnly = True
        Me.tbClaveUnidad.Size = New System.Drawing.Size(410, 29)
        Me.tbClaveUnidad.TabIndex = 2
        '
        'label15
        '
        Me.label15.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.label15.AutoSize = True
        Me.label15.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label15.Location = New System.Drawing.Point(26, 10)
        Me.label15.Margin = New System.Windows.Forms.Padding(3)
        Me.label15.Name = "label15"
        Me.label15.Size = New System.Drawing.Size(105, 17)
        Me.label15.TabIndex = 0
        Me.label15.Text = "Clave de unidad"
        '
        'btnBuscarUnidad
        '
        Me.btnBuscarUnidad.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnBuscarUnidad.BackColor = System.Drawing.Color.Transparent
        Me.btnBuscarUnidad.BackgroundImage = Global.ef33LlantasRegio.My.Resources.Resources.icons8_search_24_1_
        Me.btnBuscarUnidad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnBuscarUnidad.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnBuscarUnidad.FlatAppearance.BorderSize = 0
        Me.btnBuscarUnidad.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.btnBuscarUnidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscarUnidad.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnBuscarUnidad.Location = New System.Drawing.Point(553, 6)
        Me.btnBuscarUnidad.Name = "btnBuscarUnidad"
        Me.btnBuscarUnidad.Size = New System.Drawing.Size(27, 24)
        Me.btnBuscarUnidad.TabIndex = 18
        Me.btnBuscarUnidad.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnBuscarUnidad.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBuscarUnidad.UseVisualStyleBackColor = False
        '
        'tableLayoutPanel3
        '
        Me.tableLayoutPanel3.ColumnCount = 2
        Me.tableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 133.0!))
        Me.tableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableLayoutPanel3.Controls.Add(Me.tbUnidad, 1, 0)
        Me.tableLayoutPanel3.Controls.Add(Me.label4, 0, 0)
        Me.tableLayoutPanel3.Location = New System.Drawing.Point(3, 165)
        Me.tableLayoutPanel3.Name = "tableLayoutPanel3"
        Me.tableLayoutPanel3.RowCount = 1
        Me.tableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableLayoutPanel3.Size = New System.Drawing.Size(389, 37)
        Me.tableLayoutPanel3.TabIndex = 6
        '
        'tbUnidad
        '
        Me.tbUnidad.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.tbUnidad.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbUnidad.Location = New System.Drawing.Point(136, 4)
        Me.tbUnidad.Name = "tbUnidad"
        Me.tbUnidad.Size = New System.Drawing.Size(218, 29)
        Me.tbUnidad.TabIndex = 3
        '
        'label4
        '
        Me.label4.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.label4.AutoSize = True
        Me.label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.Location = New System.Drawing.Point(80, 10)
        Me.label4.Margin = New System.Windows.Forms.Padding(3)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(50, 17)
        Me.label4.TabIndex = 2
        Me.label4.Text = "Unidad"
        '
        'tableLayoutPanel14
        '
        Me.tableLayoutPanel14.ColumnCount = 2
        Me.tableLayoutPanel14.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 132.0!))
        Me.tableLayoutPanel14.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableLayoutPanel14.Controls.Add(Me.label3, 0, 0)
        Me.tableLayoutPanel14.Controls.Add(Me.tbNoIdentificacion, 1, 0)
        Me.tableLayoutPanel14.Location = New System.Drawing.Point(3, 208)
        Me.tableLayoutPanel14.Name = "tableLayoutPanel14"
        Me.tableLayoutPanel14.RowCount = 1
        Me.tableLayoutPanel14.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableLayoutPanel14.Size = New System.Drawing.Size(389, 37)
        Me.tableLayoutPanel14.TabIndex = 17
        '
        'label3
        '
        Me.label3.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.Location = New System.Drawing.Point(23, 10)
        Me.label3.Margin = New System.Windows.Forms.Padding(3)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(106, 17)
        Me.label3.TabIndex = 0
        Me.label3.Text = "No identificación"
        '
        'tbNoIdentificacion
        '
        Me.tbNoIdentificacion.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.tbNoIdentificacion.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNoIdentificacion.Location = New System.Drawing.Point(135, 4)
        Me.tbNoIdentificacion.Name = "tbNoIdentificacion"
        Me.tbNoIdentificacion.Size = New System.Drawing.Size(217, 29)
        Me.tbNoIdentificacion.TabIndex = 3
        '
        'tableLayoutPanel4
        '
        Me.tableLayoutPanel4.ColumnCount = 2
        Me.tableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130.0!))
        Me.tableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableLayoutPanel4.Controls.Add(Me.nudPrecio, 1, 0)
        Me.tableLayoutPanel4.Controls.Add(Me.label9, 0, 0)
        Me.tableLayoutPanel4.Location = New System.Drawing.Point(3, 251)
        Me.tableLayoutPanel4.Name = "tableLayoutPanel4"
        Me.tableLayoutPanel4.RowCount = 1
        Me.tableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableLayoutPanel4.Size = New System.Drawing.Size(389, 37)
        Me.tableLayoutPanel4.TabIndex = 19
        '
        'nudPrecio
        '
        Me.nudPrecio.DecimalPlaces = 2
        Me.nudPrecio.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudPrecio.Location = New System.Drawing.Point(133, 3)
        Me.nudPrecio.Maximum = New Decimal(New Integer() {100000000, 0, 0, 0})
        Me.nudPrecio.Name = "nudPrecio"
        Me.nudPrecio.Size = New System.Drawing.Size(104, 25)
        Me.nudPrecio.TabIndex = 3
        Me.nudPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'label9
        '
        Me.label9.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.label9.AutoSize = True
        Me.label9.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label9.Location = New System.Drawing.Point(76, 10)
        Me.label9.Margin = New System.Windows.Forms.Padding(3)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(51, 17)
        Me.label9.TabIndex = 2
        Me.label9.Text = "*Precio"
        '
        'tableLayoutPanel9
        '
        Me.tableLayoutPanel9.ColumnCount = 2
        Me.tableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130.0!))
        Me.tableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableLayoutPanel9.Controls.Add(Me.label14, 0, 0)
        Me.tableLayoutPanel9.Controls.Add(Me.tbDescripcion, 1, 0)
        Me.tableLayoutPanel9.Location = New System.Drawing.Point(3, 294)
        Me.tableLayoutPanel9.Name = "tableLayoutPanel9"
        Me.tableLayoutPanel9.RowCount = 1
        Me.tableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableLayoutPanel9.Size = New System.Drawing.Size(583, 37)
        Me.tableLayoutPanel9.TabIndex = 12
        '
        'label14
        '
        Me.label14.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.label14.AutoSize = True
        Me.label14.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label14.Location = New System.Drawing.Point(44, 10)
        Me.label14.Margin = New System.Windows.Forms.Padding(3)
        Me.label14.Name = "label14"
        Me.label14.Size = New System.Drawing.Size(83, 17)
        Me.label14.TabIndex = 0
        Me.label14.Text = "*Descripción"
        '
        'tbDescripcion
        '
        Me.tbDescripcion.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.tbDescripcion.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbDescripcion.Location = New System.Drawing.Point(133, 4)
        Me.tbDescripcion.Name = "tbDescripcion"
        Me.tbDescripcion.Size = New System.Drawing.Size(447, 29)
        Me.tbDescripcion.TabIndex = 3
        '
        'label1
        '
        Me.label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.label1.Location = New System.Drawing.Point(10, 15)
        Me.label1.Margin = New System.Windows.Forms.Padding(10)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(174, 25)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Agregar producto"
        '
        'btnGuardarCliente
        '
        Me.btnGuardarCliente.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnGuardarCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(164, Byte), Integer))
        Me.btnGuardarCliente.FlatAppearance.BorderSize = 0
        Me.btnGuardarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardarCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardarCliente.ForeColor = System.Drawing.Color.White
        Me.btnGuardarCliente.Location = New System.Drawing.Point(174, 412)
        Me.btnGuardarCliente.Name = "btnGuardarCliente"
        Me.btnGuardarCliente.Size = New System.Drawing.Size(252, 34)
        Me.btnGuardarCliente.TabIndex = 6
        Me.btnGuardarCliente.Text = "Guardar producto"
        Me.btnGuardarCliente.UseVisualStyleBackColor = False
        '
        'tableLayoutPanel1
        '
        Me.tableLayoutPanel1.ColumnCount = 1
        Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableLayoutPanel1.Controls.Add(Me.btnGuardarCliente, 0, 2)
        Me.tableLayoutPanel1.Controls.Add(Me.label1, 0, 0)
        Me.tableLayoutPanel1.Controls.Add(Me.flowLayoutPanel1, 0, 1)
        Me.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.tableLayoutPanel1.Name = "tableLayoutPanel1"
        Me.tableLayoutPanel1.RowCount = 3
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56.0!))
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52.0!))
        Me.tableLayoutPanel1.Size = New System.Drawing.Size(601, 455)
        Me.tableLayoutPanel1.TabIndex = 2
        '
        'wProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(601, 455)
        Me.Controls.Add(Me.tableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "wProducto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "wProducto"
        Me.flowLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel5.PerformLayout()
        Me.tableLayoutPanel2.ResumeLayout(False)
        Me.tableLayoutPanel2.PerformLayout()
        Me.tableLayoutPanel15.ResumeLayout(False)
        Me.tableLayoutPanel15.PerformLayout()
        Me.tableLayoutPanel3.ResumeLayout(False)
        Me.tableLayoutPanel3.PerformLayout()
        Me.tableLayoutPanel14.ResumeLayout(False)
        Me.tableLayoutPanel14.PerformLayout()
        Me.tableLayoutPanel4.ResumeLayout(False)
        Me.tableLayoutPanel4.PerformLayout()
        CType(Me.nudPrecio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tableLayoutPanel9.ResumeLayout(False)
        Me.tableLayoutPanel9.PerformLayout()
        Me.tableLayoutPanel1.ResumeLayout(False)
        Me.tableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents flowLayoutPanel1 As FlowLayoutPanel
    Private WithEvents TableLayoutPanel5 As TableLayoutPanel
    Private WithEvents txtArtIntelisis As TextBox
    Private WithEvents Label5 As Label
    Private WithEvents tableLayoutPanel2 As TableLayoutPanel
    Private WithEvents tbClaveProdServ As TextBox
    Private WithEvents label2 As Label
    Private WithEvents btnBuscarClaveProd As Button
    Private WithEvents tableLayoutPanel15 As TableLayoutPanel
    Private WithEvents tbClaveUnidad As TextBox
    Private WithEvents label15 As Label
    Private WithEvents btnBuscarUnidad As Button
    Private WithEvents tableLayoutPanel3 As TableLayoutPanel
    Private WithEvents tbUnidad As TextBox
    Private WithEvents label4 As Label
    Private WithEvents tableLayoutPanel14 As TableLayoutPanel
    Private WithEvents label3 As Label
    Private WithEvents tbNoIdentificacion As TextBox
    Private WithEvents tableLayoutPanel9 As TableLayoutPanel
    Private WithEvents label14 As Label
    Private WithEvents tbDescripcion As TextBox
    Private WithEvents tableLayoutPanel4 As TableLayoutPanel
    Private WithEvents nudPrecio As NumericUpDown
    Private WithEvents label9 As Label
    Private WithEvents label1 As Label
    Private WithEvents btnGuardarCliente As Button
    Private WithEvents tableLayoutPanel1 As TableLayoutPanel
    Private WithEvents lblDescripcionArt As Label
    Private WithEvents Label6 As Label
End Class
