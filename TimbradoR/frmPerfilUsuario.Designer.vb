<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPerfilUsuario
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
        Me.components = New System.ComponentModel.Container()
        Me.flowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.tableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.tbUsuario = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.tableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.tbEmpresa = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.tableLayoutPanel14 = New System.Windows.Forms.TableLayoutPanel()
        Me.tbEmail = New System.Windows.Forms.TextBox()
        Me.label14 = New System.Windows.Forms.Label()
        Me.tableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.tbNivel = New System.Windows.Forms.TextBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.tableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.tbPassword = New System.Windows.Forms.TextBox()
        Me.label5 = New System.Windows.Forms.Label()
        Me.chkPassword = New System.Windows.Forms.CheckBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.btnPerfilUsuario = New System.Windows.Forms.Button()
        Me.tableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpError = New System.Windows.Forms.TableLayoutPanel()
        Me.lError = New System.Windows.Forms.Label()
        Me.timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.flowLayoutPanel1.SuspendLayout()
        Me.tableLayoutPanel2.SuspendLayout()
        Me.tableLayoutPanel3.SuspendLayout()
        Me.tableLayoutPanel14.SuspendLayout()
        Me.tableLayoutPanel4.SuspendLayout()
        Me.tableLayoutPanel5.SuspendLayout()
        Me.tableLayoutPanel1.SuspendLayout()
        Me.tlpError.SuspendLayout()
        Me.SuspendLayout()
        '
        'flowLayoutPanel1
        '
        Me.flowLayoutPanel1.AutoScroll = True
        Me.flowLayoutPanel1.Controls.Add(Me.tableLayoutPanel2)
        Me.flowLayoutPanel1.Controls.Add(Me.tableLayoutPanel3)
        Me.flowLayoutPanel1.Controls.Add(Me.tableLayoutPanel4)
        Me.flowLayoutPanel1.Controls.Add(Me.tableLayoutPanel14)
        Me.flowLayoutPanel1.Controls.Add(Me.tableLayoutPanel5)
        Me.flowLayoutPanel1.Controls.Add(Me.chkPassword)
        Me.flowLayoutPanel1.Controls.Add(Me.tlpError)
        Me.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flowLayoutPanel1.Location = New System.Drawing.Point(3, 59)
        Me.flowLayoutPanel1.Name = "flowLayoutPanel1"
        Me.flowLayoutPanel1.Size = New System.Drawing.Size(795, 169)
        Me.flowLayoutPanel1.TabIndex = 0
        '
        'tableLayoutPanel2
        '
        Me.tableLayoutPanel2.ColumnCount = 2
        Me.tableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105.0!))
        Me.tableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableLayoutPanel2.Controls.Add(Me.tbUsuario, 1, 0)
        Me.tableLayoutPanel2.Controls.Add(Me.label2, 0, 0)
        Me.tableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.tableLayoutPanel2.Name = "tableLayoutPanel2"
        Me.tableLayoutPanel2.RowCount = 1
        Me.tableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableLayoutPanel2.Size = New System.Drawing.Size(316, 37)
        Me.tableLayoutPanel2.TabIndex = 5
        '
        'tbUsuario
        '
        Me.tbUsuario.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.tbUsuario.Enabled = False
        Me.tbUsuario.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbUsuario.Location = New System.Drawing.Point(108, 4)
        Me.tbUsuario.Name = "tbUsuario"
        Me.tbUsuario.Size = New System.Drawing.Size(200, 29)
        Me.tbUsuario.TabIndex = 2
        '
        'label2
        '
        Me.label2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(42, 10)
        Me.label2.Margin = New System.Windows.Forms.Padding(3)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(60, 17)
        Me.label2.TabIndex = 0
        Me.label2.Text = "*Usuario"
        '
        'tableLayoutPanel3
        '
        Me.tableLayoutPanel3.ColumnCount = 2
        Me.tableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105.0!))
        Me.tableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableLayoutPanel3.Controls.Add(Me.tbEmpresa, 0, 0)
        Me.tableLayoutPanel3.Controls.Add(Me.label3, 0, 0)
        Me.tableLayoutPanel3.Location = New System.Drawing.Point(325, 3)
        Me.tableLayoutPanel3.Name = "tableLayoutPanel3"
        Me.tableLayoutPanel3.RowCount = 1
        Me.tableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableLayoutPanel3.Size = New System.Drawing.Size(430, 37)
        Me.tableLayoutPanel3.TabIndex = 6
        '
        'tbEmpresa
        '
        Me.tbEmpresa.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.tbEmpresa.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbEmpresa.Location = New System.Drawing.Point(108, 4)
        Me.tbEmpresa.Name = "tbEmpresa"
        Me.tbEmpresa.Size = New System.Drawing.Size(319, 29)
        Me.tbEmpresa.TabIndex = 3
        '
        'label3
        '
        Me.label3.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.Location = New System.Drawing.Point(36, 10)
        Me.label3.Margin = New System.Windows.Forms.Padding(3)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(66, 17)
        Me.label3.TabIndex = 0
        Me.label3.Text = "*Empresa"
        '
        'tableLayoutPanel14
        '
        Me.tableLayoutPanel14.ColumnCount = 2
        Me.tableLayoutPanel14.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105.0!))
        Me.tableLayoutPanel14.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableLayoutPanel14.Controls.Add(Me.label14, 0, 0)
        Me.tableLayoutPanel14.Controls.Add(Me.tbEmail, 1, 0)
        Me.tableLayoutPanel14.Location = New System.Drawing.Point(325, 46)
        Me.tableLayoutPanel14.Name = "tableLayoutPanel14"
        Me.tableLayoutPanel14.RowCount = 1
        Me.tableLayoutPanel14.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableLayoutPanel14.Size = New System.Drawing.Size(430, 37)
        Me.tableLayoutPanel14.TabIndex = 17
        '
        'tbEmail
        '
        Me.tbEmail.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.tbEmail.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbEmail.Location = New System.Drawing.Point(108, 4)
        Me.tbEmail.Name = "tbEmail"
        Me.tbEmail.Size = New System.Drawing.Size(319, 29)
        Me.tbEmail.TabIndex = 3
        '
        'label14
        '
        Me.label14.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.label14.AutoSize = True
        Me.label14.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label14.Location = New System.Drawing.Point(56, 10)
        Me.label14.Margin = New System.Windows.Forms.Padding(3)
        Me.label14.Name = "label14"
        Me.label14.Size = New System.Drawing.Size(46, 17)
        Me.label14.TabIndex = 0
        Me.label14.Text = "*Email"
        '
        'tableLayoutPanel4
        '
        Me.tableLayoutPanel4.ColumnCount = 2
        Me.tableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105.0!))
        Me.tableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableLayoutPanel4.Controls.Add(Me.tbNivel, 0, 0)
        Me.tableLayoutPanel4.Controls.Add(Me.label4, 0, 0)
        Me.tableLayoutPanel4.Location = New System.Drawing.Point(3, 46)
        Me.tableLayoutPanel4.Name = "tableLayoutPanel4"
        Me.tableLayoutPanel4.RowCount = 1
        Me.tableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableLayoutPanel4.Size = New System.Drawing.Size(316, 37)
        Me.tableLayoutPanel4.TabIndex = 7
        '
        'tbNivel
        '
        Me.tbNivel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.tbNivel.Enabled = False
        Me.tbNivel.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNivel.Location = New System.Drawing.Point(108, 4)
        Me.tbNivel.Name = "tbNivel"
        Me.tbNivel.Size = New System.Drawing.Size(200, 29)
        Me.tbNivel.TabIndex = 3
        '
        'label4
        '
        Me.label4.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.label4.AutoSize = True
        Me.label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.Location = New System.Drawing.Point(65, 10)
        Me.label4.Margin = New System.Windows.Forms.Padding(3)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(37, 17)
        Me.label4.TabIndex = 0
        Me.label4.Text = "Nivel"
        '
        'tableLayoutPanel5
        '
        Me.tableLayoutPanel5.ColumnCount = 2
        Me.tableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105.0!))
        Me.tableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableLayoutPanel5.Controls.Add(Me.tbPassword, 0, 0)
        Me.tableLayoutPanel5.Controls.Add(Me.label5, 0, 0)
        Me.tableLayoutPanel5.Location = New System.Drawing.Point(3, 89)
        Me.tableLayoutPanel5.Name = "tableLayoutPanel5"
        Me.tableLayoutPanel5.RowCount = 1
        Me.tableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableLayoutPanel5.Size = New System.Drawing.Size(316, 37)
        Me.tableLayoutPanel5.TabIndex = 8
        '
        'tbPassword
        '
        Me.tbPassword.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.tbPassword.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPassword.Location = New System.Drawing.Point(108, 4)
        Me.tbPassword.Name = "tbPassword"
        Me.tbPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbPassword.Size = New System.Drawing.Size(200, 29)
        Me.tbPassword.TabIndex = 3
        '
        'label5
        '
        Me.label5.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.label5.AutoSize = True
        Me.label5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label5.Location = New System.Drawing.Point(38, 10)
        Me.label5.Margin = New System.Windows.Forms.Padding(3)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(64, 17)
        Me.label5.TabIndex = 0
        Me.label5.Text = "Password"
        '
        'chkPassword
        '
        Me.chkPassword.AutoSize = True
        Me.chkPassword.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!)
        Me.chkPassword.Location = New System.Drawing.Point(325, 89)
        Me.chkPassword.Name = "chkPassword"
        Me.chkPassword.Size = New System.Drawing.Size(150, 25)
        Me.chkPassword.TabIndex = 18
        Me.chkPassword.Text = "Mostrar Password"
        Me.chkPassword.UseVisualStyleBackColor = True
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
        Me.label1.Size = New System.Drawing.Size(159, 25)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Perfil de Usuario"
        '
        'btnPerfilUsuario
        '
        Me.btnPerfilUsuario.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnPerfilUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(164, Byte), Integer))
        Me.btnPerfilUsuario.FlatAppearance.BorderSize = 0
        Me.btnPerfilUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPerfilUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPerfilUsuario.ForeColor = System.Drawing.Color.White
        Me.btnPerfilUsuario.Location = New System.Drawing.Point(274, 238)
        Me.btnPerfilUsuario.Name = "btnPerfilUsuario"
        Me.btnPerfilUsuario.Size = New System.Drawing.Size(252, 34)
        Me.btnPerfilUsuario.TabIndex = 6
        Me.btnPerfilUsuario.Text = "Guardar"
        Me.btnPerfilUsuario.UseVisualStyleBackColor = False
        '
        'tableLayoutPanel1
        '
        Me.tableLayoutPanel1.BackColor = System.Drawing.Color.White
        Me.tableLayoutPanel1.ColumnCount = 1
        Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableLayoutPanel1.Controls.Add(Me.btnPerfilUsuario, 0, 2)
        Me.tableLayoutPanel1.Controls.Add(Me.label1, 0, 0)
        Me.tableLayoutPanel1.Controls.Add(Me.flowLayoutPanel1, 0, 1)
        Me.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.tableLayoutPanel1.Name = "tableLayoutPanel1"
        Me.tableLayoutPanel1.RowCount = 3
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56.0!))
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48.0!))
        Me.tableLayoutPanel1.Size = New System.Drawing.Size(801, 279)
        Me.tableLayoutPanel1.TabIndex = 3
        '
        'tlpError
        '
        Me.tlpError.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tlpError.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tlpError.ColumnCount = 1
        Me.tlpError.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpError.Controls.Add(Me.lError, 0, 0)
        Me.tlpError.Location = New System.Drawing.Point(3, 132)
        Me.tlpError.Name = "tlpError"
        Me.tlpError.RowCount = 1
        Me.tlpError.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpError.Size = New System.Drawing.Size(401, 30)
        Me.tlpError.TabIndex = 22
        Me.tlpError.Visible = False
        '
        'lError
        '
        Me.lError.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lError.AutoSize = True
        Me.lError.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lError.ForeColor = System.Drawing.Color.White
        Me.lError.Location = New System.Drawing.Point(348, 6)
        Me.lError.Name = "lError"
        Me.lError.Size = New System.Drawing.Size(50, 17)
        Me.lError.TabIndex = 0
        Me.lError.Text = "label36"
        '
        'timer1
        '
        Me.timer1.Interval = 5000
        '
        'frmPerfilUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(801, 279)
        Me.Controls.Add(Me.tableLayoutPanel1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPerfilUsuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Usuario"
        Me.flowLayoutPanel1.ResumeLayout(False)
        Me.flowLayoutPanel1.PerformLayout()
        Me.tableLayoutPanel2.ResumeLayout(False)
        Me.tableLayoutPanel2.PerformLayout()
        Me.tableLayoutPanel3.ResumeLayout(False)
        Me.tableLayoutPanel3.PerformLayout()
        Me.tableLayoutPanel14.ResumeLayout(False)
        Me.tableLayoutPanel14.PerformLayout()
        Me.tableLayoutPanel4.ResumeLayout(False)
        Me.tableLayoutPanel4.PerformLayout()
        Me.tableLayoutPanel5.ResumeLayout(False)
        Me.tableLayoutPanel5.PerformLayout()
        Me.tableLayoutPanel1.ResumeLayout(False)
        Me.tableLayoutPanel1.PerformLayout()
        Me.tlpError.ResumeLayout(False)
        Me.tlpError.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents flowLayoutPanel1 As FlowLayoutPanel
    Private WithEvents tableLayoutPanel2 As TableLayoutPanel
    Private WithEvents tbUsuario As TextBox
    Private WithEvents label2 As Label
    Private WithEvents tableLayoutPanel3 As TableLayoutPanel
    Private WithEvents tbEmpresa As TextBox
    Private WithEvents label3 As Label
    Private WithEvents tableLayoutPanel14 As TableLayoutPanel
    Private WithEvents tbEmail As TextBox
    Private WithEvents label14 As Label
    Private WithEvents tableLayoutPanel4 As TableLayoutPanel
    Private WithEvents tbNivel As TextBox
    Private WithEvents label4 As Label
    Private WithEvents tableLayoutPanel5 As TableLayoutPanel
    Private WithEvents tbPassword As TextBox
    Private WithEvents label5 As Label
    Friend WithEvents chkPassword As CheckBox
    Private WithEvents label1 As Label
    Private WithEvents btnPerfilUsuario As Button
    Private WithEvents tableLayoutPanel1 As TableLayoutPanel
    Private WithEvents tlpError As TableLayoutPanel
    Private WithEvents lError As Label
    Private WithEvents timer1 As Timer
End Class
