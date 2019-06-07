<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmContadorTimbres
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmContadorTimbres))
        Me.flowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.tableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.tbActivacion = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.tableLayoutPanel14 = New System.Windows.Forms.TableLayoutPanel()
        Me.tbVencimiento = New System.Windows.Forms.TextBox()
        Me.label14 = New System.Windows.Forms.Label()
        Me.tableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.tbPaquete = New System.Windows.Forms.TextBox()
        Me.label5 = New System.Windows.Forms.Label()
        Me.tableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
        Me.tbTimbres = New System.Windows.Forms.TextBox()
        Me.label7 = New System.Windows.Forms.Label()
        Me.tableLayoutPanel9 = New System.Windows.Forms.TableLayoutPanel()
        Me.tbRestantes = New System.Windows.Forms.TextBox()
        Me.label9 = New System.Windows.Forms.Label()
        Me.tableLayoutPanel11 = New System.Windows.Forms.TableLayoutPanel()
        Me.tbUsados = New System.Windows.Forms.TextBox()
        Me.label11 = New System.Windows.Forms.Label()
        Me.btnGuardarCliente = New System.Windows.Forms.Button()
        Me.label1 = New System.Windows.Forms.Label()
        Me.tableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.flowLayoutPanel1.SuspendLayout()
        Me.tableLayoutPanel2.SuspendLayout()
        Me.tableLayoutPanel14.SuspendLayout()
        Me.tableLayoutPanel5.SuspendLayout()
        Me.tableLayoutPanel7.SuspendLayout()
        Me.tableLayoutPanel9.SuspendLayout()
        Me.tableLayoutPanel11.SuspendLayout()
        Me.tableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'flowLayoutPanel1
        '
        Me.flowLayoutPanel1.AutoScroll = True
        Me.flowLayoutPanel1.Controls.Add(Me.tableLayoutPanel2)
        Me.flowLayoutPanel1.Controls.Add(Me.tableLayoutPanel14)
        Me.flowLayoutPanel1.Controls.Add(Me.tableLayoutPanel5)
        Me.flowLayoutPanel1.Controls.Add(Me.tableLayoutPanel7)
        Me.flowLayoutPanel1.Controls.Add(Me.tableLayoutPanel9)
        Me.flowLayoutPanel1.Controls.Add(Me.tableLayoutPanel11)
        Me.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flowLayoutPanel1.Location = New System.Drawing.Point(3, 59)
        Me.flowLayoutPanel1.Name = "flowLayoutPanel1"
        Me.flowLayoutPanel1.Size = New System.Drawing.Size(712, 133)
        Me.flowLayoutPanel1.TabIndex = 0
        '
        'tableLayoutPanel2
        '
        Me.tableLayoutPanel2.ColumnCount = 2
        Me.tableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105.0!))
        Me.tableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableLayoutPanel2.Controls.Add(Me.tbActivacion, 1, 0)
        Me.tableLayoutPanel2.Controls.Add(Me.label2, 0, 0)
        Me.tableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.tableLayoutPanel2.Name = "tableLayoutPanel2"
        Me.tableLayoutPanel2.RowCount = 1
        Me.tableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableLayoutPanel2.Size = New System.Drawing.Size(316, 37)
        Me.tableLayoutPanel2.TabIndex = 5
        '
        'tbActivacion
        '
        Me.tbActivacion.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.tbActivacion.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbActivacion.Location = New System.Drawing.Point(108, 4)
        Me.tbActivacion.Name = "tbActivacion"
        Me.tbActivacion.ReadOnly = True
        Me.tbActivacion.Size = New System.Drawing.Size(200, 29)
        Me.tbActivacion.TabIndex = 2
        '
        'label2
        '
        Me.label2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(32, 10)
        Me.label2.Margin = New System.Windows.Forms.Padding(3)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(70, 17)
        Me.label2.TabIndex = 0
        Me.label2.Text = "Activación"
        '
        'tableLayoutPanel14
        '
        Me.tableLayoutPanel14.ColumnCount = 2
        Me.tableLayoutPanel14.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105.0!))
        Me.tableLayoutPanel14.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableLayoutPanel14.Controls.Add(Me.tbVencimiento, 0, 0)
        Me.tableLayoutPanel14.Controls.Add(Me.label14, 0, 0)
        Me.tableLayoutPanel14.Location = New System.Drawing.Point(325, 3)
        Me.tableLayoutPanel14.Name = "tableLayoutPanel14"
        Me.tableLayoutPanel14.RowCount = 1
        Me.tableLayoutPanel14.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableLayoutPanel14.Size = New System.Drawing.Size(316, 37)
        Me.tableLayoutPanel14.TabIndex = 17
        '
        'tbVencimiento
        '
        Me.tbVencimiento.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.tbVencimiento.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbVencimiento.Location = New System.Drawing.Point(108, 4)
        Me.tbVencimiento.Name = "tbVencimiento"
        Me.tbVencimiento.ReadOnly = True
        Me.tbVencimiento.Size = New System.Drawing.Size(200, 29)
        Me.tbVencimiento.TabIndex = 4
        '
        'label14
        '
        Me.label14.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.label14.AutoSize = True
        Me.label14.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label14.Location = New System.Drawing.Point(20, 10)
        Me.label14.Margin = New System.Windows.Forms.Padding(3)
        Me.label14.Name = "label14"
        Me.label14.Size = New System.Drawing.Size(82, 17)
        Me.label14.TabIndex = 0
        Me.label14.Text = "Vencimiento"
        '
        'tableLayoutPanel5
        '
        Me.tableLayoutPanel5.ColumnCount = 2
        Me.tableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105.0!))
        Me.tableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableLayoutPanel5.Controls.Add(Me.tbPaquete, 0, 0)
        Me.tableLayoutPanel5.Controls.Add(Me.label5, 0, 0)
        Me.tableLayoutPanel5.Location = New System.Drawing.Point(3, 46)
        Me.tableLayoutPanel5.Name = "tableLayoutPanel5"
        Me.tableLayoutPanel5.RowCount = 1
        Me.tableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableLayoutPanel5.Size = New System.Drawing.Size(316, 37)
        Me.tableLayoutPanel5.TabIndex = 8
        '
        'tbPaquete
        '
        Me.tbPaquete.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.tbPaquete.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPaquete.Location = New System.Drawing.Point(108, 4)
        Me.tbPaquete.Name = "tbPaquete"
        Me.tbPaquete.ReadOnly = True
        Me.tbPaquete.Size = New System.Drawing.Size(200, 29)
        Me.tbPaquete.TabIndex = 3
        '
        'label5
        '
        Me.label5.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.label5.AutoSize = True
        Me.label5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label5.Location = New System.Drawing.Point(47, 10)
        Me.label5.Margin = New System.Windows.Forms.Padding(3)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(55, 17)
        Me.label5.TabIndex = 0
        Me.label5.Text = "Paquete"
        '
        'tableLayoutPanel7
        '
        Me.tableLayoutPanel7.ColumnCount = 2
        Me.tableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105.0!))
        Me.tableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableLayoutPanel7.Controls.Add(Me.tbTimbres, 0, 0)
        Me.tableLayoutPanel7.Controls.Add(Me.label7, 0, 0)
        Me.tableLayoutPanel7.Location = New System.Drawing.Point(325, 46)
        Me.tableLayoutPanel7.Name = "tableLayoutPanel7"
        Me.tableLayoutPanel7.RowCount = 1
        Me.tableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableLayoutPanel7.Size = New System.Drawing.Size(316, 37)
        Me.tableLayoutPanel7.TabIndex = 10
        '
        'tbTimbres
        '
        Me.tbTimbres.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.tbTimbres.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTimbres.Location = New System.Drawing.Point(108, 4)
        Me.tbTimbres.Name = "tbTimbres"
        Me.tbTimbres.ReadOnly = True
        Me.tbTimbres.Size = New System.Drawing.Size(200, 29)
        Me.tbTimbres.TabIndex = 3
        '
        'label7
        '
        Me.label7.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.label7.AutoSize = True
        Me.label7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label7.Location = New System.Drawing.Point(47, 10)
        Me.label7.Margin = New System.Windows.Forms.Padding(3)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(55, 17)
        Me.label7.TabIndex = 0
        Me.label7.Text = "Timbres"
        '
        'tableLayoutPanel9
        '
        Me.tableLayoutPanel9.ColumnCount = 2
        Me.tableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105.0!))
        Me.tableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableLayoutPanel9.Controls.Add(Me.tbRestantes, 0, 0)
        Me.tableLayoutPanel9.Controls.Add(Me.label9, 0, 0)
        Me.tableLayoutPanel9.Location = New System.Drawing.Point(3, 89)
        Me.tableLayoutPanel9.Name = "tableLayoutPanel9"
        Me.tableLayoutPanel9.RowCount = 1
        Me.tableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableLayoutPanel9.Size = New System.Drawing.Size(316, 37)
        Me.tableLayoutPanel9.TabIndex = 12
        '
        'tbRestantes
        '
        Me.tbRestantes.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.tbRestantes.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbRestantes.Location = New System.Drawing.Point(108, 4)
        Me.tbRestantes.Name = "tbRestantes"
        Me.tbRestantes.ReadOnly = True
        Me.tbRestantes.Size = New System.Drawing.Size(200, 29)
        Me.tbRestantes.TabIndex = 3
        '
        'label9
        '
        Me.label9.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.label9.AutoSize = True
        Me.label9.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label9.Location = New System.Drawing.Point(38, 10)
        Me.label9.Margin = New System.Windows.Forms.Padding(3)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(64, 17)
        Me.label9.TabIndex = 2
        Me.label9.Text = "Restantes"
        '
        'tableLayoutPanel11
        '
        Me.tableLayoutPanel11.ColumnCount = 2
        Me.tableLayoutPanel11.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105.0!))
        Me.tableLayoutPanel11.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableLayoutPanel11.Controls.Add(Me.tbUsados, 0, 0)
        Me.tableLayoutPanel11.Controls.Add(Me.label11, 0, 0)
        Me.tableLayoutPanel11.Location = New System.Drawing.Point(325, 89)
        Me.tableLayoutPanel11.Name = "tableLayoutPanel11"
        Me.tableLayoutPanel11.RowCount = 1
        Me.tableLayoutPanel11.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableLayoutPanel11.Size = New System.Drawing.Size(316, 37)
        Me.tableLayoutPanel11.TabIndex = 14
        '
        'tbUsados
        '
        Me.tbUsados.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.tbUsados.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbUsados.Location = New System.Drawing.Point(108, 4)
        Me.tbUsados.Name = "tbUsados"
        Me.tbUsados.ReadOnly = True
        Me.tbUsados.Size = New System.Drawing.Size(200, 29)
        Me.tbUsados.TabIndex = 3
        '
        'label11
        '
        Me.label11.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.label11.AutoSize = True
        Me.label11.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label11.Location = New System.Drawing.Point(50, 10)
        Me.label11.Margin = New System.Windows.Forms.Padding(3)
        Me.label11.Name = "label11"
        Me.label11.Size = New System.Drawing.Size(52, 17)
        Me.label11.TabIndex = 0
        Me.label11.Text = "Usados"
        '
        'btnGuardarCliente
        '
        Me.btnGuardarCliente.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnGuardarCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(164, Byte), Integer))
        Me.btnGuardarCliente.FlatAppearance.BorderSize = 0
        Me.btnGuardarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardarCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardarCliente.ForeColor = System.Drawing.Color.White
        Me.btnGuardarCliente.Location = New System.Drawing.Point(233, 228)
        Me.btnGuardarCliente.Name = "btnGuardarCliente"
        Me.btnGuardarCliente.Size = New System.Drawing.Size(252, 34)
        Me.btnGuardarCliente.TabIndex = 6
        Me.btnGuardarCliente.Text = "ACEPTAR"
        Me.btnGuardarCliente.UseVisualStyleBackColor = False
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
        Me.label1.Size = New System.Drawing.Size(88, 25)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Timbres "
        '
        'tableLayoutPanel1
        '
        Me.tableLayoutPanel1.ColumnCount = 1
        Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableLayoutPanel1.Controls.Add(Me.label1, 0, 0)
        Me.tableLayoutPanel1.Controls.Add(Me.flowLayoutPanel1, 0, 1)
        Me.tableLayoutPanel1.Controls.Add(Me.btnGuardarCliente, 0, 2)
        Me.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.tableLayoutPanel1.Name = "tableLayoutPanel1"
        Me.tableLayoutPanel1.RowCount = 3
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56.0!))
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 101.0!))
        Me.tableLayoutPanel1.Size = New System.Drawing.Size(718, 296)
        Me.tableLayoutPanel1.TabIndex = 3
        '
        'frmContadorTimbres
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(718, 296)
        Me.Controls.Add(Me.tableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmContadorTimbres"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Timbres"
        Me.flowLayoutPanel1.ResumeLayout(False)
        Me.tableLayoutPanel2.ResumeLayout(False)
        Me.tableLayoutPanel2.PerformLayout()
        Me.tableLayoutPanel14.ResumeLayout(False)
        Me.tableLayoutPanel14.PerformLayout()
        Me.tableLayoutPanel5.ResumeLayout(False)
        Me.tableLayoutPanel5.PerformLayout()
        Me.tableLayoutPanel7.ResumeLayout(False)
        Me.tableLayoutPanel7.PerformLayout()
        Me.tableLayoutPanel9.ResumeLayout(False)
        Me.tableLayoutPanel9.PerformLayout()
        Me.tableLayoutPanel11.ResumeLayout(False)
        Me.tableLayoutPanel11.PerformLayout()
        Me.tableLayoutPanel1.ResumeLayout(False)
        Me.tableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents flowLayoutPanel1 As FlowLayoutPanel
    Private WithEvents tableLayoutPanel2 As TableLayoutPanel
    Private WithEvents tbActivacion As TextBox
    Private WithEvents label2 As Label
    Private WithEvents tableLayoutPanel14 As TableLayoutPanel
    Private WithEvents tbVencimiento As TextBox
    Private WithEvents label14 As Label
    Private WithEvents tableLayoutPanel5 As TableLayoutPanel
    Private WithEvents tbPaquete As TextBox
    Private WithEvents label5 As Label
    Private WithEvents tableLayoutPanel7 As TableLayoutPanel
    Private WithEvents tbTimbres As TextBox
    Private WithEvents label7 As Label
    Private WithEvents tableLayoutPanel9 As TableLayoutPanel
    Private WithEvents tbRestantes As TextBox
    Private WithEvents label9 As Label
    Private WithEvents tableLayoutPanel11 As TableLayoutPanel
    Private WithEvents tbUsados As TextBox
    Private WithEvents label11 As Label
    Private WithEvents btnGuardarCliente As Button
    Private WithEvents label1 As Label
    Private WithEvents tableLayoutPanel1 As TableLayoutPanel
End Class
