<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAgregaUsuarios
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAgregaUsuarios))
        Me.tableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnGuardarUsuario = New System.Windows.Forms.Button()
        Me.label1 = New System.Windows.Forms.Label()
        Me.flowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.tableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtNuevoUsuario = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.tableLayoutPanel15 = New System.Windows.Forms.TableLayoutPanel()
        Me.cmbdepto = New System.Windows.Forms.ComboBox()
        Me.label15 = New System.Windows.Forms.Label()
        Me.chkDepto = New System.Windows.Forms.CheckBox()
        Me.txtOtroDepto = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.cmbPuesto = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.chkPuesto = New System.Windows.Forms.CheckBox()
        Me.txtOtroPuesto = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtpass = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.btnCreaPassword = New System.Windows.Forms.Button()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbnivel = New System.Windows.Forms.ComboBox()
        Me.tableLayoutPanel1.SuspendLayout()
        Me.flowLayoutPanel1.SuspendLayout()
        Me.tableLayoutPanel2.SuspendLayout()
        Me.tableLayoutPanel15.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'tableLayoutPanel1
        '
        Me.tableLayoutPanel1.ColumnCount = 1
        Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableLayoutPanel1.Controls.Add(Me.btnGuardarUsuario, 0, 2)
        Me.tableLayoutPanel1.Controls.Add(Me.label1, 0, 0)
        Me.tableLayoutPanel1.Controls.Add(Me.flowLayoutPanel1, 0, 1)
        Me.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.tableLayoutPanel1.Name = "tableLayoutPanel1"
        Me.tableLayoutPanel1.RowCount = 3
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56.0!))
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52.0!))
        Me.tableLayoutPanel1.Size = New System.Drawing.Size(800, 333)
        Me.tableLayoutPanel1.TabIndex = 3
        '
        'btnGuardarUsuario
        '
        Me.btnGuardarUsuario.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnGuardarUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(164, Byte), Integer))
        Me.btnGuardarUsuario.FlatAppearance.BorderSize = 0
        Me.btnGuardarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardarUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardarUsuario.ForeColor = System.Drawing.Color.White
        Me.btnGuardarUsuario.Location = New System.Drawing.Point(274, 290)
        Me.btnGuardarUsuario.Name = "btnGuardarUsuario"
        Me.btnGuardarUsuario.Size = New System.Drawing.Size(252, 34)
        Me.btnGuardarUsuario.TabIndex = 6
        Me.btnGuardarUsuario.Text = "Guardar Usuario"
        Me.btnGuardarUsuario.UseVisualStyleBackColor = False
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
        Me.label1.Size = New System.Drawing.Size(157, 25)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Agregar usuario"
        '
        'flowLayoutPanel1
        '
        Me.flowLayoutPanel1.AutoScroll = True
        Me.flowLayoutPanel1.Controls.Add(Me.tableLayoutPanel2)
        Me.flowLayoutPanel1.Controls.Add(Me.tableLayoutPanel15)
        Me.flowLayoutPanel1.Controls.Add(Me.TableLayoutPanel4)
        Me.flowLayoutPanel1.Controls.Add(Me.TableLayoutPanel5)
        Me.flowLayoutPanel1.Controls.Add(Me.TableLayoutPanel6)
        Me.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flowLayoutPanel1.Location = New System.Drawing.Point(3, 59)
        Me.flowLayoutPanel1.Name = "flowLayoutPanel1"
        Me.flowLayoutPanel1.Size = New System.Drawing.Size(794, 219)
        Me.flowLayoutPanel1.TabIndex = 0
        '
        'tableLayoutPanel2
        '
        Me.tableLayoutPanel2.ColumnCount = 2
        Me.tableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 134.0!))
        Me.tableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableLayoutPanel2.Controls.Add(Me.txtNuevoUsuario, 1, 0)
        Me.tableLayoutPanel2.Controls.Add(Me.label2, 0, 0)
        Me.tableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.tableLayoutPanel2.Name = "tableLayoutPanel2"
        Me.tableLayoutPanel2.RowCount = 1
        Me.tableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableLayoutPanel2.Size = New System.Drawing.Size(779, 37)
        Me.tableLayoutPanel2.TabIndex = 5
        '
        'txtNuevoUsuario
        '
        Me.txtNuevoUsuario.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtNuevoUsuario.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNuevoUsuario.Location = New System.Drawing.Point(137, 4)
        Me.txtNuevoUsuario.Name = "txtNuevoUsuario"
        Me.txtNuevoUsuario.Size = New System.Drawing.Size(639, 29)
        Me.txtNuevoUsuario.TabIndex = 2
        '
        'label2
        '
        Me.label2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(73, 10)
        Me.label2.Margin = New System.Windows.Forms.Padding(3)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(58, 17)
        Me.label2.TabIndex = 0
        Me.label2.Text = "Nombre"
        '
        'tableLayoutPanel15
        '
        Me.tableLayoutPanel15.ColumnCount = 4
        Me.tableLayoutPanel15.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 134.0!))
        Me.tableLayoutPanel15.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableLayoutPanel15.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 84.0!))
        Me.tableLayoutPanel15.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 256.0!))
        Me.tableLayoutPanel15.Controls.Add(Me.cmbdepto, 1, 0)
        Me.tableLayoutPanel15.Controls.Add(Me.label15, 0, 0)
        Me.tableLayoutPanel15.Controls.Add(Me.chkDepto, 2, 0)
        Me.tableLayoutPanel15.Controls.Add(Me.txtOtroDepto, 3, 0)
        Me.tableLayoutPanel15.Location = New System.Drawing.Point(3, 46)
        Me.tableLayoutPanel15.Name = "tableLayoutPanel15"
        Me.tableLayoutPanel15.RowCount = 1
        Me.tableLayoutPanel15.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableLayoutPanel15.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37.0!))
        Me.tableLayoutPanel15.Size = New System.Drawing.Size(779, 37)
        Me.tableLayoutPanel15.TabIndex = 18
        '
        'cmbdepto
        '
        Me.cmbdepto.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbdepto.FormattingEnabled = True
        Me.cmbdepto.Location = New System.Drawing.Point(137, 3)
        Me.cmbdepto.Name = "cmbdepto"
        Me.cmbdepto.Size = New System.Drawing.Size(299, 29)
        Me.cmbdepto.TabIndex = 20
        '
        'label15
        '
        Me.label15.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.label15.AutoSize = True
        Me.label15.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label15.Location = New System.Drawing.Point(35, 10)
        Me.label15.Margin = New System.Windows.Forms.Padding(3)
        Me.label15.Name = "label15"
        Me.label15.Size = New System.Drawing.Size(96, 17)
        Me.label15.TabIndex = 0
        Me.label15.Text = "Departamento"
        '
        'chkDepto
        '
        Me.chkDepto.AutoSize = True
        Me.chkDepto.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!)
        Me.chkDepto.Location = New System.Drawing.Point(442, 3)
        Me.chkDepto.Name = "chkDepto"
        Me.chkDepto.Size = New System.Drawing.Size(60, 25)
        Me.chkDepto.TabIndex = 3
        Me.chkDepto.Text = "Otro"
        Me.chkDepto.UseVisualStyleBackColor = True
        '
        'txtOtroDepto
        '
        Me.txtOtroDepto.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!)
        Me.txtOtroDepto.Location = New System.Drawing.Point(526, 3)
        Me.txtOtroDepto.Name = "txtOtroDepto"
        Me.txtOtroDepto.Size = New System.Drawing.Size(250, 29)
        Me.txtOtroDepto.TabIndex = 19
        Me.txtOtroDepto.Visible = False
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 4
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 134.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 84.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 256.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.cmbPuesto, 1, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Label3, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.chkPuesto, 2, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.txtOtroPuesto, 3, 0)
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 89)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(779, 37)
        Me.TableLayoutPanel4.TabIndex = 19
        '
        'cmbPuesto
        '
        Me.cmbPuesto.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPuesto.FormattingEnabled = True
        Me.cmbPuesto.Location = New System.Drawing.Point(137, 3)
        Me.cmbPuesto.Name = "cmbPuesto"
        Me.cmbPuesto.Size = New System.Drawing.Size(299, 29)
        Me.cmbPuesto.TabIndex = 20
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(81, 10)
        Me.Label3.Margin = New System.Windows.Forms.Padding(3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 17)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Puesto"
        '
        'chkPuesto
        '
        Me.chkPuesto.AutoSize = True
        Me.chkPuesto.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!)
        Me.chkPuesto.Location = New System.Drawing.Point(442, 3)
        Me.chkPuesto.Name = "chkPuesto"
        Me.chkPuesto.Size = New System.Drawing.Size(60, 25)
        Me.chkPuesto.TabIndex = 3
        Me.chkPuesto.Text = "Otro"
        Me.chkPuesto.UseVisualStyleBackColor = True
        '
        'txtOtroPuesto
        '
        Me.txtOtroPuesto.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!)
        Me.txtOtroPuesto.Location = New System.Drawing.Point(526, 3)
        Me.txtOtroPuesto.Name = "txtOtroPuesto"
        Me.txtOtroPuesto.Size = New System.Drawing.Size(250, 29)
        Me.txtOtroPuesto.TabIndex = 19
        Me.txtOtroPuesto.Visible = False
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 4
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 134.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 172.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 168.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.txtpass, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.Label5, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.CheckBox1, 2, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.btnCreaPassword, 3, 0)
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(3, 132)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 1
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(779, 37)
        Me.TableLayoutPanel5.TabIndex = 20
        '
        'txtpass
        '
        Me.txtpass.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!)
        Me.txtpass.Location = New System.Drawing.Point(137, 3)
        Me.txtpass.Name = "txtpass"
        Me.txtpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpass.Size = New System.Drawing.Size(299, 29)
        Me.txtpass.TabIndex = 20
        Me.txtpass.Visible = False
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(54, 10)
        Me.Label5.Margin = New System.Windows.Forms.Padding(3)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 17)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Contraseña"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!)
        Me.CheckBox1.Location = New System.Drawing.Point(442, 3)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(164, 25)
        Me.CheckBox1.TabIndex = 3
        Me.CheckBox1.Text = "Mostrar Contraseña"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'btnCreaPassword
        '
        Me.btnCreaPassword.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!)
        Me.btnCreaPassword.Location = New System.Drawing.Point(614, 3)
        Me.btnCreaPassword.Name = "btnCreaPassword"
        Me.btnCreaPassword.Size = New System.Drawing.Size(162, 29)
        Me.btnCreaPassword.TabIndex = 21
        Me.btnCreaPassword.Text = "Crea Contraseña"
        Me.btnCreaPassword.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.ColumnCount = 2
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 134.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel6.Controls.Add(Me.Label6, 0, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.cmbnivel, 1, 0)
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(3, 175)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 1
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(443, 37)
        Me.TableLayoutPanel6.TabIndex = 21
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(93, 10)
        Me.Label6.Margin = New System.Windows.Forms.Padding(3)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 17)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Nivel"
        '
        'cmbnivel
        '
        Me.cmbnivel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbnivel.FormattingEnabled = True
        Me.cmbnivel.Location = New System.Drawing.Point(137, 3)
        Me.cmbnivel.Name = "cmbnivel"
        Me.cmbnivel.Size = New System.Drawing.Size(299, 29)
        Me.cmbnivel.TabIndex = 20
        '
        'frmAgregaUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 333)
        Me.Controls.Add(Me.tableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAgregaUsuarios"
        Me.Text = "Agrega Usuario"
        Me.tableLayoutPanel1.ResumeLayout(False)
        Me.tableLayoutPanel1.PerformLayout()
        Me.flowLayoutPanel1.ResumeLayout(False)
        Me.tableLayoutPanel2.ResumeLayout(False)
        Me.tableLayoutPanel2.PerformLayout()
        Me.tableLayoutPanel15.ResumeLayout(False)
        Me.tableLayoutPanel15.PerformLayout()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel5.PerformLayout()
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.TableLayoutPanel6.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents tableLayoutPanel1 As TableLayoutPanel
    Private WithEvents btnGuardarUsuario As Button
    Private WithEvents label1 As Label
    Private WithEvents flowLayoutPanel1 As FlowLayoutPanel
    Private WithEvents tableLayoutPanel2 As TableLayoutPanel
    Private WithEvents txtNuevoUsuario As TextBox
    Private WithEvents label2 As Label
    Private WithEvents tableLayoutPanel15 As TableLayoutPanel
    Private WithEvents label15 As Label
    Friend WithEvents chkDepto As CheckBox
    Friend WithEvents txtOtroDepto As TextBox
    Friend WithEvents cmbdepto As ComboBox
    Private WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents cmbPuesto As ComboBox
    Private WithEvents Label3 As Label
    Friend WithEvents chkPuesto As CheckBox
    Friend WithEvents txtOtroPuesto As TextBox
    Private WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents cmbnivel As ComboBox
    Private WithEvents Label6 As Label
    Private WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents txtpass As TextBox
    Private WithEvents Label5 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents btnCreaPassword As Button
End Class
