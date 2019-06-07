<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReporteXML
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReporteXML))
        Me.GroupXML = New System.Windows.Forms.GroupBox()
        Me.barra = New System.Windows.Forms.ProgressBar()
        Me.PictureLogoMenu = New System.Windows.Forms.PictureBox()
        Me.txtFacturaXML = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnExporaExvelXML = New System.Windows.Forms.Button()
        Me.cmbProveedorXML = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblTotalRegistrolXML = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupRangoFechasXML = New System.Windows.Forms.GroupBox()
        Me.dtpFechaFinalXML = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaIncialXML = New System.Windows.Forms.DateTimePicker()
        Me.chkRangoFechasXML = New System.Windows.Forms.CheckBox()
        Me.btrnBuscarXML = New System.Windows.Forms.Button()
        Me.GridXML_ = New System.Windows.Forms.DataGridView()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnImprimirReporteXML = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.GroupXML.SuspendLayout()
        CType(Me.PictureLogoMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupRangoFechasXML.SuspendLayout()
        CType(Me.GridXML_, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupXML
        '
        Me.GroupXML.Controls.Add(Me.barra)
        Me.GroupXML.Controls.Add(Me.PictureLogoMenu)
        Me.GroupXML.Controls.Add(Me.txtFacturaXML)
        Me.GroupXML.Controls.Add(Me.Label1)
        Me.GroupXML.Controls.Add(Me.btnExporaExvelXML)
        Me.GroupXML.Controls.Add(Me.cmbProveedorXML)
        Me.GroupXML.Controls.Add(Me.Label2)
        Me.GroupXML.Controls.Add(Me.lblTotalRegistrolXML)
        Me.GroupXML.Controls.Add(Me.Label4)
        Me.GroupXML.Controls.Add(Me.GroupRangoFechasXML)
        Me.GroupXML.Controls.Add(Me.chkRangoFechasXML)
        Me.GroupXML.Controls.Add(Me.btrnBuscarXML)
        Me.GroupXML.Controls.Add(Me.GridXML_)
        Me.GroupXML.Controls.Add(Me.GroupBox5)
        Me.GroupXML.Controls.Add(Me.btnImprimirReporteXML)
        Me.GroupXML.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupXML.Location = New System.Drawing.Point(3, 46)
        Me.GroupXML.Name = "GroupXML"
        Me.GroupXML.Size = New System.Drawing.Size(1030, 514)
        Me.GroupXML.TabIndex = 116
        Me.GroupXML.TabStop = False
        '
        'barra
        '
        Me.barra.Location = New System.Drawing.Point(9, 488)
        Me.barra.Name = "barra"
        Me.barra.Size = New System.Drawing.Size(849, 20)
        Me.barra.TabIndex = 72
        '
        'PictureLogoMenu
        '
        Me.PictureLogoMenu.Image = Global.ef33LlantasRegio.My.Resources.Resources.LogoFacrura33
        Me.PictureLogoMenu.Location = New System.Drawing.Point(900, 9)
        Me.PictureLogoMenu.Name = "PictureLogoMenu"
        Me.PictureLogoMenu.Size = New System.Drawing.Size(118, 75)
        Me.PictureLogoMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureLogoMenu.TabIndex = 145
        Me.PictureLogoMenu.TabStop = False
        '
        'txtFacturaXML
        '
        Me.txtFacturaXML.Location = New System.Drawing.Point(9, 44)
        Me.txtFacturaXML.Name = "txtFacturaXML"
        Me.txtFacturaXML.Size = New System.Drawing.Size(118, 22)
        Me.txtFacturaXML.TabIndex = 38
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 16)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Factura:"
        '
        'btnExporaExvelXML
        '
        Me.btnExporaExvelXML.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExporaExvelXML.Image = Global.ef33LlantasRegio.My.Resources.Resources.icons8_microsoft_excel_48
        Me.btnExporaExvelXML.Location = New System.Drawing.Point(840, 34)
        Me.btnExporaExvelXML.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btnExporaExvelXML.Name = "btnExporaExvelXML"
        Me.btnExporaExvelXML.Size = New System.Drawing.Size(54, 50)
        Me.btnExporaExvelXML.TabIndex = 70
        Me.btnExporaExvelXML.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnExporaExvelXML.UseVisualStyleBackColor = True
        '
        'cmbProveedorXML
        '
        Me.cmbProveedorXML.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbProveedorXML.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbProveedorXML.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbProveedorXML.FormattingEnabled = True
        Me.cmbProveedorXML.Location = New System.Drawing.Point(144, 42)
        Me.cmbProveedorXML.Name = "cmbProveedorXML"
        Me.cmbProveedorXML.Size = New System.Drawing.Size(289, 24)
        Me.cmbProveedorXML.TabIndex = 32
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(141, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 16)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Proveedor:"
        '
        'lblTotalRegistrolXML
        '
        Me.lblTotalRegistrolXML.AutoSize = True
        Me.lblTotalRegistrolXML.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalRegistrolXML.Location = New System.Drawing.Point(986, 488)
        Me.lblTotalRegistrolXML.Name = "lblTotalRegistrolXML"
        Me.lblTotalRegistrolXML.Size = New System.Drawing.Size(15, 16)
        Me.lblTotalRegistrolXML.TabIndex = 30
        Me.lblTotalRegistrolXML.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(875, 488)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 16)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Total Regsitros:"
        '
        'GroupRangoFechasXML
        '
        Me.GroupRangoFechasXML.Controls.Add(Me.dtpFechaFinalXML)
        Me.GroupRangoFechasXML.Controls.Add(Me.dtpFechaIncialXML)
        Me.GroupRangoFechasXML.Enabled = False
        Me.GroupRangoFechasXML.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupRangoFechasXML.Location = New System.Drawing.Point(445, 29)
        Me.GroupRangoFechasXML.Name = "GroupRangoFechasXML"
        Me.GroupRangoFechasXML.Size = New System.Drawing.Size(327, 49)
        Me.GroupRangoFechasXML.TabIndex = 27
        Me.GroupRangoFechasXML.TabStop = False
        '
        'dtpFechaFinalXML
        '
        Me.dtpFechaFinalXML.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFinalXML.Location = New System.Drawing.Point(172, 21)
        Me.dtpFechaFinalXML.Name = "dtpFechaFinalXML"
        Me.dtpFechaFinalXML.Size = New System.Drawing.Size(138, 22)
        Me.dtpFechaFinalXML.TabIndex = 14
        '
        'dtpFechaIncialXML
        '
        Me.dtpFechaIncialXML.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaIncialXML.Location = New System.Drawing.Point(12, 21)
        Me.dtpFechaIncialXML.Name = "dtpFechaIncialXML"
        Me.dtpFechaIncialXML.Size = New System.Drawing.Size(152, 22)
        Me.dtpFechaIncialXML.TabIndex = 13
        '
        'chkRangoFechasXML
        '
        Me.chkRangoFechasXML.AutoSize = True
        Me.chkRangoFechasXML.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkRangoFechasXML.Location = New System.Drawing.Point(445, 9)
        Me.chkRangoFechasXML.Name = "chkRangoFechasXML"
        Me.chkRangoFechasXML.Size = New System.Drawing.Size(111, 20)
        Me.chkRangoFechasXML.TabIndex = 26
        Me.chkRangoFechasXML.Text = "Rango Fechas"
        Me.chkRangoFechasXML.UseVisualStyleBackColor = True
        '
        'btrnBuscarXML
        '
        Me.btrnBuscarXML.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btrnBuscarXML.Image = Global.ef33LlantasRegio.My.Resources.Resources.icons8_search_24_1_
        Me.btrnBuscarXML.Location = New System.Drawing.Point(779, 34)
        Me.btrnBuscarXML.Margin = New System.Windows.Forms.Padding(4)
        Me.btrnBuscarXML.Name = "btrnBuscarXML"
        Me.btrnBuscarXML.Size = New System.Drawing.Size(54, 50)
        Me.btrnBuscarXML.TabIndex = 25
        Me.btrnBuscarXML.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btrnBuscarXML.UseVisualStyleBackColor = True
        '
        'GridXML_
        '
        Me.GridXML_.AllowUserToAddRows = False
        Me.GridXML_.AllowUserToDeleteRows = False
        Me.GridXML_.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridXML_.Location = New System.Drawing.Point(6, 92)
        Me.GridXML_.Name = "GridXML_"
        Me.GridXML_.ReadOnly = True
        Me.GridXML_.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridXML_.Size = New System.Drawing.Size(1012, 390)
        Me.GridXML_.TabIndex = 0
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.DataGridView2)
        Me.GroupBox5.Controls.Add(Me.Label7)
        Me.GroupBox5.Controls.Add(Me.Label10)
        Me.GroupBox5.Location = New System.Drawing.Point(805, 305)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(104, 31)
        Me.GroupBox5.TabIndex = 36
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Detalle Entrada"
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(18, 28)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView2.Size = New System.Drawing.Size(520, 404)
        Me.DataGridView2.TabIndex = 33
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(496, 438)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(15, 16)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "0"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(396, 438)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(105, 16)
        Me.Label10.TabIndex = 34
        Me.Label10.Text = "Total Regsitros:"
        '
        'btnImprimirReporteXML
        '
        Me.btnImprimirReporteXML.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimirReporteXML.Image = Global.ef33LlantasRegio.My.Resources.Resources.icons8_Print_48
        Me.btnImprimirReporteXML.Location = New System.Drawing.Point(514, 154)
        Me.btnImprimirReporteXML.Name = "btnImprimirReporteXML"
        Me.btnImprimirReporteXML.Size = New System.Drawing.Size(115, 208)
        Me.btnImprimirReporteXML.TabIndex = 71
        Me.btnImprimirReporteXML.Text = "IMPRIMIR"
        Me.btnImprimirReporteXML.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnImprimirReporteXML.UseVisualStyleBackColor = True
        Me.btnImprimirReporteXML.Visible = False
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Arial", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label14.Location = New System.Drawing.Point(6, 9)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(257, 34)
        Me.Label14.TabIndex = 146
        Me.Label14.Text = "REPORTE XML"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmReporteXML
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1057, 572)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.GroupXML)
        Me.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmReporteXML"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte XML"
        Me.GroupXML.ResumeLayout(False)
        Me.GroupXML.PerformLayout()
        CType(Me.PictureLogoMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupRangoFechasXML.ResumeLayout(False)
        CType(Me.GridXML_, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupXML As GroupBox
    Friend WithEvents btnImprimirReporteXML As Button
    Friend WithEvents btnExporaExvelXML As Button
    Friend WithEvents txtFacturaXML As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbProveedorXML As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblTotalRegistrolXML As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupRangoFechasXML As GroupBox
    Friend WithEvents dtpFechaFinalXML As DateTimePicker
    Friend WithEvents dtpFechaIncialXML As DateTimePicker
    Friend WithEvents chkRangoFechasXML As CheckBox
    Friend WithEvents btrnBuscarXML As Button
    Friend WithEvents GridXML_ As DataGridView
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents barra As ProgressBar
    Friend WithEvents PictureLogoMenu As PictureBox
    Friend WithEvents Label14 As Label
End Class
