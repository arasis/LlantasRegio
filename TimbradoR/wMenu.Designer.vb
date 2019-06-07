<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class wMenu
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
        Me.flowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnComprobante = New System.Windows.Forms.Button()
        Me.btnPagos = New System.Windows.Forms.Button()
        Me.btnGenerarPDF = New System.Windows.Forms.Button()
        Me.btnProductos = New System.Windows.Forms.Button()
        Me.btnClientes = New System.Windows.Forms.Button()
        Me.btnConfiguracion = New System.Windows.Forms.Button()
        Me.toolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.flowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'flowLayoutPanel1
        '
        Me.flowLayoutPanel1.Controls.Add(Me.btnComprobante)
        Me.flowLayoutPanel1.Controls.Add(Me.btnPagos)
        Me.flowLayoutPanel1.Controls.Add(Me.btnGenerarPDF)
        Me.flowLayoutPanel1.Controls.Add(Me.btnProductos)
        Me.flowLayoutPanel1.Controls.Add(Me.btnClientes)
        Me.flowLayoutPanel1.Controls.Add(Me.btnConfiguracion)
        Me.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.flowLayoutPanel1.Name = "flowLayoutPanel1"
        Me.flowLayoutPanel1.Size = New System.Drawing.Size(322, 151)
        Me.flowLayoutPanel1.TabIndex = 2
        '
        'btnComprobante
        '
        Me.btnComprobante.AutoEllipsis = True
        Me.btnComprobante.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnComprobante.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnComprobante.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnComprobante.FlatAppearance.BorderSize = 0
        Me.btnComprobante.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.btnComprobante.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.btnComprobante.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnComprobante.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnComprobante.Image = Global.ef33LlantasRegio.My.Resources.Resources.icons8_document_filled_50
        Me.btnComprobante.Location = New System.Drawing.Point(3, 3)
        Me.btnComprobante.Name = "btnComprobante"
        Me.btnComprobante.Size = New System.Drawing.Size(100, 70)
        Me.btnComprobante.TabIndex = 2
        Me.btnComprobante.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.toolTip1.SetToolTip(Me.btnComprobante, "Generar comprobante")
        Me.btnComprobante.UseVisualStyleBackColor = False
        '
        'btnPagos
        '
        Me.btnPagos.AutoEllipsis = True
        Me.btnPagos.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnPagos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnPagos.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnPagos.FlatAppearance.BorderSize = 0
        Me.btnPagos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.btnPagos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.btnPagos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPagos.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPagos.Image = Global.ef33LlantasRegio.My.Resources.Resources.icons8_bill_filled_50
        Me.btnPagos.Location = New System.Drawing.Point(109, 3)
        Me.btnPagos.Name = "btnPagos"
        Me.btnPagos.Size = New System.Drawing.Size(100, 70)
        Me.btnPagos.TabIndex = 5
        Me.btnPagos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.toolTip1.SetToolTip(Me.btnPagos, "Generar comprobante")
        Me.btnPagos.UseVisualStyleBackColor = False
        '
        'btnGenerarPDF
        '
        Me.btnGenerarPDF.AutoEllipsis = True
        Me.btnGenerarPDF.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnGenerarPDF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnGenerarPDF.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnGenerarPDF.FlatAppearance.BorderSize = 0
        Me.btnGenerarPDF.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.btnGenerarPDF.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.btnGenerarPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGenerarPDF.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerarPDF.Image = Global.ef33LlantasRegio.My.Resources.Resources.icons8_pdf_filled_50
        Me.btnGenerarPDF.Location = New System.Drawing.Point(215, 3)
        Me.btnGenerarPDF.Name = "btnGenerarPDF"
        Me.btnGenerarPDF.Size = New System.Drawing.Size(100, 70)
        Me.btnGenerarPDF.TabIndex = 4
        Me.btnGenerarPDF.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.toolTip1.SetToolTip(Me.btnGenerarPDF, "Generar PDF de XML")
        Me.btnGenerarPDF.UseVisualStyleBackColor = False
        '
        'btnProductos
        '
        Me.btnProductos.AutoEllipsis = True
        Me.btnProductos.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnProductos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnProductos.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnProductos.FlatAppearance.BorderSize = 0
        Me.btnProductos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.btnProductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProductos.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProductos.Image = Global.ef33LlantasRegio.My.Resources.Resources.icons8_product_filled_50
        Me.btnProductos.Location = New System.Drawing.Point(3, 79)
        Me.btnProductos.Name = "btnProductos"
        Me.btnProductos.Size = New System.Drawing.Size(100, 70)
        Me.btnProductos.TabIndex = 3
        Me.btnProductos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.toolTip1.SetToolTip(Me.btnProductos, "Catalogo de productos")
        Me.btnProductos.UseVisualStyleBackColor = False
        '
        'btnClientes
        '
        Me.btnClientes.AutoEllipsis = True
        Me.btnClientes.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnClientes.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnClientes.FlatAppearance.BorderSize = 0
        Me.btnClientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.btnClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClientes.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClientes.Image = Global.ef33LlantasRegio.My.Resources.Resources.icons8_customer_filled_50
        Me.btnClientes.Location = New System.Drawing.Point(109, 79)
        Me.btnClientes.Name = "btnClientes"
        Me.btnClientes.Size = New System.Drawing.Size(100, 70)
        Me.btnClientes.TabIndex = 0
        Me.btnClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.toolTip1.SetToolTip(Me.btnClientes, "Cartera de clientes")
        Me.btnClientes.UseVisualStyleBackColor = False
        '
        'btnConfiguracion
        '
        Me.btnConfiguracion.AutoEllipsis = True
        Me.btnConfiguracion.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnConfiguracion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnConfiguracion.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnConfiguracion.FlatAppearance.BorderSize = 0
        Me.btnConfiguracion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.btnConfiguracion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.btnConfiguracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfiguracion.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfiguracion.Image = Global.ef33LlantasRegio.My.Resources.Resources.icons8_support_filled_50
        Me.btnConfiguracion.Location = New System.Drawing.Point(215, 79)
        Me.btnConfiguracion.Name = "btnConfiguracion"
        Me.btnConfiguracion.Size = New System.Drawing.Size(100, 70)
        Me.btnConfiguracion.TabIndex = 1
        Me.btnConfiguracion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.toolTip1.SetToolTip(Me.btnConfiguracion, "Configuración")
        Me.btnConfiguracion.UseVisualStyleBackColor = False
        '
        'wMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(322, 151)
        Me.Controls.Add(Me.flowLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "wMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Generacion de CFDI´s Versión 3.3"
        Me.flowLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents btnClientes As System.Windows.Forms.Button

    Private WithEvents btnConfiguracion As System.Windows.Forms.Button

    Private flowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel

    Private WithEvents btnComprobante As System.Windows.Forms.Button

    Private WithEvents btnProductos As System.Windows.Forms.Button

    Private toolTip1 As System.Windows.Forms.ToolTip

    Private WithEvents btnGenerarPDF As System.Windows.Forms.Button
    Private WithEvents btnPagos As System.Windows.Forms.Button
End Class
