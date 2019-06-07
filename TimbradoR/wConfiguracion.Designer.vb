<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class wConfiguracion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(wConfiguracion))
        Me.tabControl1 = New System.Windows.Forms.TabControl()
        Me.tabPage1 = New System.Windows.Forms.TabPage()
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
        Me.tableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.tbPasswordFoliosDigitales = New System.Windows.Forms.TextBox()
        Me.tbUsuarioFoliosDigitales = New System.Windows.Forms.TextBox()
        Me.label17 = New System.Windows.Forms.Label()
        Me.label18 = New System.Windows.Forms.Label()
        Me.label6 = New System.Windows.Forms.Label()
        Me.tabPage2 = New System.Windows.Forms.TabPage()
        Me.tableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.label9 = New System.Windows.Forms.Label()
        Me.label8 = New System.Windows.Forms.Label()
        Me.cbRegimenesFiscales = New System.Windows.Forms.ComboBox()
        Me.label14 = New System.Windows.Forms.Label()
        Me.tbEmisorRazonSocial = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.tbEmisorRFC = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.tbLugarExpedicion = New System.Windows.Forms.TextBox()
        Me.tabPage3 = New System.Windows.Forms.TabPage()
        Me.tableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.label7 = New System.Windows.Forms.Label()
        Me.tbConexionRutaCertificado = New System.Windows.Forms.TextBox()
        Me.label5 = New System.Windows.Forms.Label()
        Me.tbConexionRutaPfx = New System.Windows.Forms.TextBox()
        Me.tbConexionContrasenaPfx = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.btnExaminarCertificadosRutaPFX = New System.Windows.Forms.Button()
        Me.btnExaminarCertificadosRutaCertificado = New System.Windows.Forms.Button()
        Me.tableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.label19 = New System.Windows.Forms.Label()
        Me.label20 = New System.Windows.Forms.Label()
        Me.label21 = New System.Windows.Forms.Label()
        Me.tbFacturacionRutaXMLST = New System.Windows.Forms.TextBox()
        Me.tbFacturacionRutaXMLT = New System.Windows.Forms.TextBox()
        Me.btnExaminarRutaXMLST = New System.Windows.Forms.Button()
        Me.btnExaminarRutaXMLT = New System.Windows.Forms.Button()
        Me.tableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.tableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnLimpiarCampos = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.tabControl1.SuspendLayout()
        Me.tabPage1.SuspendLayout()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tableLayoutPanel5.SuspendLayout()
        Me.tabPage2.SuspendLayout()
        Me.tableLayoutPanel1.SuspendLayout()
        Me.tabPage3.SuspendLayout()
        Me.tableLayoutPanel2.SuspendLayout()
        Me.tableLayoutPanel4.SuspendLayout()
        Me.tableLayoutPanel3.SuspendLayout()
        Me.tableLayoutPanel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabControl1
        '
        Me.tabControl1.Controls.Add(Me.tabPage1)
        Me.tabControl1.Controls.Add(Me.tabPage2)
        Me.tabControl1.Controls.Add(Me.tabPage3)
        Me.tabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabControl1.ItemSize = New System.Drawing.Size(56, 30)
        Me.tabControl1.Location = New System.Drawing.Point(3, 3)
        Me.tabControl1.Name = "tabControl1"
        Me.tabControl1.SelectedIndex = 0
        Me.tabControl1.Size = New System.Drawing.Size(863, 362)
        Me.tabControl1.TabIndex = 0
        '
        'tabPage1
        '
        Me.tabPage1.Controls.Add(Me.LogoPictureBox)
        Me.tabPage1.Controls.Add(Me.tableLayoutPanel5)
        Me.tabPage1.Location = New System.Drawing.Point(4, 34)
        Me.tabPage1.Name = "tabPage1"
        Me.tabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage1.Size = New System.Drawing.Size(855, 324)
        Me.tabPage1.TabIndex = 0
        Me.tabPage1.Text = "Conexión"
        Me.tabPage1.UseVisualStyleBackColor = True
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.Image = Global.ef33LlantasRegio.My.Resources.Resources.LogoFacrura33
        Me.LogoPictureBox.Location = New System.Drawing.Point(460, 11)
        Me.LogoPictureBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(377, 290)
        Me.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.LogoPictureBox.TabIndex = 24
        Me.LogoPictureBox.TabStop = False
        '
        'tableLayoutPanel5
        '
        Me.tableLayoutPanel5.ColumnCount = 2
        Me.tableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.98795!))
        Me.tableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.01205!))
        Me.tableLayoutPanel5.Controls.Add(Me.tbPasswordFoliosDigitales, 1, 2)
        Me.tableLayoutPanel5.Controls.Add(Me.tbUsuarioFoliosDigitales, 1, 1)
        Me.tableLayoutPanel5.Controls.Add(Me.label17, 0, 0)
        Me.tableLayoutPanel5.Controls.Add(Me.label18, 0, 1)
        Me.tableLayoutPanel5.Controls.Add(Me.label6, 0, 2)
        Me.tableLayoutPanel5.Location = New System.Drawing.Point(6, 6)
        Me.tableLayoutPanel5.Name = "tableLayoutPanel5"
        Me.tableLayoutPanel5.RowCount = 3
        Me.tableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42.0!))
        Me.tableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tableLayoutPanel5.Size = New System.Drawing.Size(415, 127)
        Me.tableLayoutPanel5.TabIndex = 23
        '
        'tbPasswordFoliosDigitales
        '
        Me.tbPasswordFoliosDigitales.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbPasswordFoliosDigitales.Enabled = False
        Me.tbPasswordFoliosDigitales.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPasswordFoliosDigitales.Location = New System.Drawing.Point(197, 90)
        Me.tbPasswordFoliosDigitales.MinimumSize = New System.Drawing.Size(4, 30)
        Me.tbPasswordFoliosDigitales.Name = "tbPasswordFoliosDigitales"
        Me.tbPasswordFoliosDigitales.Size = New System.Drawing.Size(215, 30)
        Me.tbPasswordFoliosDigitales.TabIndex = 1
        Me.tbPasswordFoliosDigitales.UseSystemPasswordChar = True
        '
        'tbUsuarioFoliosDigitales
        '
        Me.tbUsuarioFoliosDigitales.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbUsuarioFoliosDigitales.Enabled = False
        Me.tbUsuarioFoliosDigitales.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbUsuarioFoliosDigitales.Location = New System.Drawing.Point(197, 48)
        Me.tbUsuarioFoliosDigitales.MinimumSize = New System.Drawing.Size(4, 30)
        Me.tbUsuarioFoliosDigitales.Name = "tbUsuarioFoliosDigitales"
        Me.tbUsuarioFoliosDigitales.Size = New System.Drawing.Size(215, 30)
        Me.tbUsuarioFoliosDigitales.TabIndex = 0
        '
        'label17
        '
        Me.label17.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.label17.AutoSize = True
        Me.tableLayoutPanel5.SetColumnSpan(Me.label17, 2)
        Me.label17.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.label17.Location = New System.Drawing.Point(3, 5)
        Me.label17.Name = "label17"
        Me.label17.Size = New System.Drawing.Size(221, 32)
        Me.label17.TabIndex = 55
        Me.label17.Text = "Usuario Timbrado"
        '
        'label18
        '
        Me.label18.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.label18.AutoSize = True
        Me.label18.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label18.Location = New System.Drawing.Point(30, 54)
        Me.label18.Margin = New System.Windows.Forms.Padding(3)
        Me.label18.Name = "label18"
        Me.label18.Size = New System.Drawing.Size(161, 17)
        Me.label18.TabIndex = 57
        Me.label18.Text = "Usuario de folios digitales"
        '
        'label6
        '
        Me.label6.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.label6.AutoSize = True
        Me.label6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label6.Location = New System.Drawing.Point(9, 97)
        Me.label6.Margin = New System.Windows.Forms.Padding(3)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(182, 17)
        Me.label6.TabIndex = 56
        Me.label6.Text = "Contraseña de folios digitales"
        '
        'tabPage2
        '
        Me.tabPage2.Controls.Add(Me.tableLayoutPanel1)
        Me.tabPage2.Location = New System.Drawing.Point(4, 34)
        Me.tabPage2.Name = "tabPage2"
        Me.tabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage2.Size = New System.Drawing.Size(855, 324)
        Me.tabPage2.TabIndex = 1
        Me.tabPage2.Text = "Información fiscal"
        Me.tabPage2.UseVisualStyleBackColor = True
        '
        'tableLayoutPanel1
        '
        Me.tableLayoutPanel1.ColumnCount = 3
        Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 12.0!))
        Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 146.0!))
        Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableLayoutPanel1.Controls.Add(Me.label9, 1, 4)
        Me.tableLayoutPanel1.Controls.Add(Me.label8, 0, 0)
        Me.tableLayoutPanel1.Controls.Add(Me.cbRegimenesFiscales, 2, 3)
        Me.tableLayoutPanel1.Controls.Add(Me.label14, 1, 3)
        Me.tableLayoutPanel1.Controls.Add(Me.tbEmisorRazonSocial, 2, 2)
        Me.tableLayoutPanel1.Controls.Add(Me.label1, 1, 2)
        Me.tableLayoutPanel1.Controls.Add(Me.tbEmisorRFC, 2, 1)
        Me.tableLayoutPanel1.Controls.Add(Me.label3, 1, 1)
        Me.tableLayoutPanel1.Controls.Add(Me.tbLugarExpedicion, 2, 4)
        Me.tableLayoutPanel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tableLayoutPanel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tableLayoutPanel1.Location = New System.Drawing.Point(6, 6)
        Me.tableLayoutPanel1.Name = "tableLayoutPanel1"
        Me.tableLayoutPanel1.RowCount = 5
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tableLayoutPanel1.Size = New System.Drawing.Size(621, 187)
        Me.tableLayoutPanel1.TabIndex = 1
        '
        'label9
        '
        Me.label9.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.label9.AutoSize = True
        Me.label9.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label9.Location = New System.Drawing.Point(19, 159)
        Me.label9.Margin = New System.Windows.Forms.Padding(3)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(136, 17)
        Me.label9.TabIndex = 53
        Me.label9.Text = "*Lugar de expedición"
        '
        'label8
        '
        Me.label8.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.label8.AutoSize = True
        Me.tableLayoutPanel1.SetColumnSpan(Me.label8, 3)
        Me.label8.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.label8.Location = New System.Drawing.Point(3, 2)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(222, 32)
        Me.label8.TabIndex = 54
        Me.label8.Text = "Información fiscal"
        '
        'cbRegimenesFiscales
        '
        Me.cbRegimenesFiscales.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbRegimenesFiscales.DisplayMember = "ClaveYDescripcion"
        Me.cbRegimenesFiscales.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbRegimenesFiscales.DropDownWidth = 500
        Me.cbRegimenesFiscales.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbRegimenesFiscales.FormattingEnabled = True
        Me.cbRegimenesFiscales.Location = New System.Drawing.Point(161, 117)
        Me.cbRegimenesFiscales.Name = "cbRegimenesFiscales"
        Me.cbRegimenesFiscales.Size = New System.Drawing.Size(457, 25)
        Me.cbRegimenesFiscales.TabIndex = 53
        Me.cbRegimenesFiscales.ValueMember = "Id"
        '
        'label14
        '
        Me.label14.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.label14.AutoSize = True
        Me.label14.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label14.Location = New System.Drawing.Point(55, 121)
        Me.label14.Margin = New System.Windows.Forms.Padding(3)
        Me.label14.Name = "label14"
        Me.label14.Size = New System.Drawing.Size(100, 17)
        Me.label14.TabIndex = 52
        Me.label14.Text = "*Regimen fiscal"
        '
        'tbEmisorRazonSocial
        '
        Me.tbEmisorRazonSocial.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbEmisorRazonSocial.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbEmisorRazonSocial.Location = New System.Drawing.Point(161, 80)
        Me.tbEmisorRazonSocial.Name = "tbEmisorRazonSocial"
        Me.tbEmisorRazonSocial.Size = New System.Drawing.Size(457, 25)
        Me.tbEmisorRazonSocial.TabIndex = 51
        '
        'label1
        '
        Me.label1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(74, 84)
        Me.label1.Margin = New System.Windows.Forms.Padding(3)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(81, 17)
        Me.label1.TabIndex = 50
        Me.label1.Text = "Razón social"
        '
        'tbEmisorRFC
        '
        Me.tbEmisorRFC.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbEmisorRFC.Enabled = False
        Me.tbEmisorRFC.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbEmisorRFC.Location = New System.Drawing.Point(161, 43)
        Me.tbEmisorRFC.Name = "tbEmisorRFC"
        Me.tbEmisorRFC.Size = New System.Drawing.Size(457, 25)
        Me.tbEmisorRFC.TabIndex = 49
        '
        'label3
        '
        Me.label3.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.Location = New System.Drawing.Point(118, 47)
        Me.label3.Margin = New System.Windows.Forms.Padding(3)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(37, 17)
        Me.label3.TabIndex = 48
        Me.label3.Text = "*RFC"
        '
        'tbLugarExpedicion
        '
        Me.tbLugarExpedicion.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbLugarExpedicion.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbLugarExpedicion.Location = New System.Drawing.Point(161, 155)
        Me.tbLugarExpedicion.Name = "tbLugarExpedicion"
        Me.tbLugarExpedicion.Size = New System.Drawing.Size(457, 25)
        Me.tbLugarExpedicion.TabIndex = 55
        '
        'tabPage3
        '
        Me.tabPage3.Controls.Add(Me.tableLayoutPanel2)
        Me.tabPage3.Controls.Add(Me.tableLayoutPanel4)
        Me.tabPage3.Location = New System.Drawing.Point(4, 34)
        Me.tabPage3.Name = "tabPage3"
        Me.tabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage3.Size = New System.Drawing.Size(855, 324)
        Me.tabPage3.TabIndex = 2
        Me.tabPage3.Text = "Facturación"
        Me.tabPage3.UseVisualStyleBackColor = True
        '
        'tableLayoutPanel2
        '
        Me.tableLayoutPanel2.ColumnCount = 3
        Me.tableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 178.0!))
        Me.tableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 121.0!))
        Me.tableLayoutPanel2.Controls.Add(Me.label7, 0, 0)
        Me.tableLayoutPanel2.Controls.Add(Me.tbConexionRutaCertificado, 1, 3)
        Me.tableLayoutPanel2.Controls.Add(Me.label5, 0, 3)
        Me.tableLayoutPanel2.Controls.Add(Me.tbConexionRutaPfx, 1, 1)
        Me.tableLayoutPanel2.Controls.Add(Me.tbConexionContrasenaPfx, 1, 2)
        Me.tableLayoutPanel2.Controls.Add(Me.label2, 0, 2)
        Me.tableLayoutPanel2.Controls.Add(Me.label4, 0, 1)
        Me.tableLayoutPanel2.Controls.Add(Me.btnExaminarCertificadosRutaPFX, 2, 1)
        Me.tableLayoutPanel2.Controls.Add(Me.btnExaminarCertificadosRutaCertificado, 2, 3)
        Me.tableLayoutPanel2.Location = New System.Drawing.Point(8, 141)
        Me.tableLayoutPanel2.Name = "tableLayoutPanel2"
        Me.tableLayoutPanel2.RowCount = 4
        Me.tableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44.0!))
        Me.tableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tableLayoutPanel2.Size = New System.Drawing.Size(776, 156)
        Me.tableLayoutPanel2.TabIndex = 23
        '
        'label7
        '
        Me.label7.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.label7.AutoSize = True
        Me.label7.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.label7.Location = New System.Drawing.Point(3, 6)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(152, 32)
        Me.label7.TabIndex = 56
        Me.label7.Text = "Certificados"
        '
        'tbConexionRutaCertificado
        '
        Me.tbConexionRutaCertificado.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.tbConexionRutaCertificado.Enabled = False
        Me.tbConexionRutaCertificado.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbConexionRutaCertificado.Location = New System.Drawing.Point(181, 124)
        Me.tbConexionRutaCertificado.MinimumSize = New System.Drawing.Size(4, 30)
        Me.tbConexionRutaCertificado.Name = "tbConexionRutaCertificado"
        Me.tbConexionRutaCertificado.Size = New System.Drawing.Size(471, 30)
        Me.tbConexionRutaCertificado.TabIndex = 13
        '
        'label5
        '
        Me.label5.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.label5.AutoSize = True
        Me.label5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label5.ForeColor = System.Drawing.Color.Black
        Me.label5.Location = New System.Drawing.Point(38, 128)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(137, 17)
        Me.label5.TabIndex = 34
        Me.label5.Text = "Rutar certificado (.cer)"
        Me.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tbConexionRutaPfx
        '
        Me.tbConexionRutaPfx.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.tbConexionRutaPfx.Enabled = False
        Me.tbConexionRutaPfx.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbConexionRutaPfx.Location = New System.Drawing.Point(181, 50)
        Me.tbConexionRutaPfx.MinimumSize = New System.Drawing.Size(4, 30)
        Me.tbConexionRutaPfx.Name = "tbConexionRutaPfx"
        Me.tbConexionRutaPfx.Size = New System.Drawing.Size(471, 30)
        Me.tbConexionRutaPfx.TabIndex = 12
        '
        'tbConexionContrasenaPfx
        '
        Me.tbConexionContrasenaPfx.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.tbConexionContrasenaPfx.Enabled = False
        Me.tbConexionContrasenaPfx.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbConexionContrasenaPfx.Location = New System.Drawing.Point(181, 87)
        Me.tbConexionContrasenaPfx.MinimumSize = New System.Drawing.Size(4, 30)
        Me.tbConexionContrasenaPfx.Name = "tbConexionContrasenaPfx"
        Me.tbConexionContrasenaPfx.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbConexionContrasenaPfx.Size = New System.Drawing.Size(471, 30)
        Me.tbConexionContrasenaPfx.TabIndex = 14
        '
        'label2
        '
        Me.label2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.ForeColor = System.Drawing.Color.Black
        Me.label2.Location = New System.Drawing.Point(22, 91)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(153, 17)
        Me.label2.TabIndex = 33
        Me.label2.Text = "Contraseña archivo (.pfx)"
        Me.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'label4
        '
        Me.label4.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.label4.AutoSize = True
        Me.label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.ForeColor = System.Drawing.Color.Black
        Me.label4.Location = New System.Drawing.Point(57, 54)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(118, 17)
        Me.label4.TabIndex = 32
        Me.label4.Text = "Ruta archivo (*.pfx)"
        Me.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnExaminarCertificadosRutaPFX
        '
        Me.btnExaminarCertificadosRutaPFX.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnExaminarCertificadosRutaPFX.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnExaminarCertificadosRutaPFX.Enabled = False
        Me.btnExaminarCertificadosRutaPFX.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExaminarCertificadosRutaPFX.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExaminarCertificadosRutaPFX.ForeColor = System.Drawing.Color.White
        Me.btnExaminarCertificadosRutaPFX.Location = New System.Drawing.Point(657, 48)
        Me.btnExaminarCertificadosRutaPFX.Margin = New System.Windows.Forms.Padding(2)
        Me.btnExaminarCertificadosRutaPFX.Name = "btnExaminarCertificadosRutaPFX"
        Me.btnExaminarCertificadosRutaPFX.Size = New System.Drawing.Size(90, 29)
        Me.btnExaminarCertificadosRutaPFX.TabIndex = 63
        Me.btnExaminarCertificadosRutaPFX.Text = "Examinar ..."
        Me.btnExaminarCertificadosRutaPFX.UseVisualStyleBackColor = False
        '
        'btnExaminarCertificadosRutaCertificado
        '
        Me.btnExaminarCertificadosRutaCertificado.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnExaminarCertificadosRutaCertificado.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnExaminarCertificadosRutaCertificado.Enabled = False
        Me.btnExaminarCertificadosRutaCertificado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExaminarCertificadosRutaCertificado.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExaminarCertificadosRutaCertificado.ForeColor = System.Drawing.Color.White
        Me.btnExaminarCertificadosRutaCertificado.Location = New System.Drawing.Point(657, 122)
        Me.btnExaminarCertificadosRutaCertificado.Margin = New System.Windows.Forms.Padding(2)
        Me.btnExaminarCertificadosRutaCertificado.Name = "btnExaminarCertificadosRutaCertificado"
        Me.btnExaminarCertificadosRutaCertificado.Size = New System.Drawing.Size(90, 29)
        Me.btnExaminarCertificadosRutaCertificado.TabIndex = 64
        Me.btnExaminarCertificadosRutaCertificado.Text = "Examinar ..."
        Me.btnExaminarCertificadosRutaCertificado.UseVisualStyleBackColor = False
        '
        'tableLayoutPanel4
        '
        Me.tableLayoutPanel4.ColumnCount = 3
        Me.tableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.25881!))
        Me.tableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.7412!))
        Me.tableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 134.0!))
        Me.tableLayoutPanel4.Controls.Add(Me.label19, 0, 0)
        Me.tableLayoutPanel4.Controls.Add(Me.label20, 0, 1)
        Me.tableLayoutPanel4.Controls.Add(Me.label21, 0, 2)
        Me.tableLayoutPanel4.Controls.Add(Me.tbFacturacionRutaXMLST, 1, 1)
        Me.tableLayoutPanel4.Controls.Add(Me.tbFacturacionRutaXMLT, 1, 2)
        Me.tableLayoutPanel4.Controls.Add(Me.btnExaminarRutaXMLST, 2, 1)
        Me.tableLayoutPanel4.Controls.Add(Me.btnExaminarRutaXMLT, 2, 2)
        Me.tableLayoutPanel4.Location = New System.Drawing.Point(8, 6)
        Me.tableLayoutPanel4.Name = "tableLayoutPanel4"
        Me.tableLayoutPanel4.RowCount = 3
        Me.tableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tableLayoutPanel4.Size = New System.Drawing.Size(776, 129)
        Me.tableLayoutPanel4.TabIndex = 0
        '
        'label19
        '
        Me.label19.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.label19.AutoSize = True
        Me.label19.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.label19.Location = New System.Drawing.Point(3, 5)
        Me.label19.Name = "label19"
        Me.label19.Size = New System.Drawing.Size(142, 32)
        Me.label19.TabIndex = 57
        Me.label19.Text = "Directorios"
        '
        'label20
        '
        Me.label20.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.label20.AutoSize = True
        Me.label20.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label20.ForeColor = System.Drawing.Color.Black
        Me.label20.Location = New System.Drawing.Point(15, 47)
        Me.label20.Name = "label20"
        Me.label20.Size = New System.Drawing.Size(157, 34)
        Me.label20.TabIndex = 58
        Me.label20.Text = "Guardar XML sin timbrar en "
        Me.label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'label21
        '
        Me.label21.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.label21.AutoSize = True
        Me.label21.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label21.ForeColor = System.Drawing.Color.Black
        Me.label21.Location = New System.Drawing.Point(6, 99)
        Me.label21.Name = "label21"
        Me.label21.Size = New System.Drawing.Size(166, 17)
        Me.label21.TabIndex = 59
        Me.label21.Text = "Guardar xml timbrados en "
        Me.label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tbFacturacionRutaXMLST
        '
        Me.tbFacturacionRutaXMLST.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.tbFacturacionRutaXMLST.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbFacturacionRutaXMLST.Location = New System.Drawing.Point(178, 52)
        Me.tbFacturacionRutaXMLST.MinimumSize = New System.Drawing.Size(4, 30)
        Me.tbFacturacionRutaXMLST.Name = "tbFacturacionRutaXMLST"
        Me.tbFacturacionRutaXMLST.Size = New System.Drawing.Size(460, 30)
        Me.tbFacturacionRutaXMLST.TabIndex = 60
        '
        'tbFacturacionRutaXMLT
        '
        Me.tbFacturacionRutaXMLT.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.tbFacturacionRutaXMLT.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbFacturacionRutaXMLT.Location = New System.Drawing.Point(178, 95)
        Me.tbFacturacionRutaXMLT.MinimumSize = New System.Drawing.Size(4, 30)
        Me.tbFacturacionRutaXMLT.Name = "tbFacturacionRutaXMLT"
        Me.tbFacturacionRutaXMLT.Size = New System.Drawing.Size(460, 30)
        Me.tbFacturacionRutaXMLT.TabIndex = 61
        '
        'btnExaminarRutaXMLST
        '
        Me.btnExaminarRutaXMLST.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnExaminarRutaXMLST.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnExaminarRutaXMLST.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExaminarRutaXMLST.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExaminarRutaXMLST.ForeColor = System.Drawing.Color.White
        Me.btnExaminarRutaXMLST.Location = New System.Drawing.Point(643, 50)
        Me.btnExaminarRutaXMLST.Margin = New System.Windows.Forms.Padding(2)
        Me.btnExaminarRutaXMLST.Name = "btnExaminarRutaXMLST"
        Me.btnExaminarRutaXMLST.Size = New System.Drawing.Size(90, 29)
        Me.btnExaminarRutaXMLST.TabIndex = 62
        Me.btnExaminarRutaXMLST.Text = "Examinar ..."
        Me.btnExaminarRutaXMLST.UseVisualStyleBackColor = False
        '
        'btnExaminarRutaXMLT
        '
        Me.btnExaminarRutaXMLT.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnExaminarRutaXMLT.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnExaminarRutaXMLT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExaminarRutaXMLT.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExaminarRutaXMLT.ForeColor = System.Drawing.Color.White
        Me.btnExaminarRutaXMLT.Location = New System.Drawing.Point(643, 93)
        Me.btnExaminarRutaXMLT.Margin = New System.Windows.Forms.Padding(2)
        Me.btnExaminarRutaXMLT.Name = "btnExaminarRutaXMLT"
        Me.btnExaminarRutaXMLT.Size = New System.Drawing.Size(90, 29)
        Me.btnExaminarRutaXMLT.TabIndex = 63
        Me.btnExaminarRutaXMLT.Text = "Examinar ..."
        Me.btnExaminarRutaXMLT.UseVisualStyleBackColor = False
        '
        'tableLayoutPanel3
        '
        Me.tableLayoutPanel3.ColumnCount = 1
        Me.tableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableLayoutPanel3.Controls.Add(Me.tableLayoutPanel6, 0, 1)
        Me.tableLayoutPanel3.Controls.Add(Me.tabControl1, 0, 0)
        Me.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tableLayoutPanel3.Location = New System.Drawing.Point(0, 0)
        Me.tableLayoutPanel3.Name = "tableLayoutPanel3"
        Me.tableLayoutPanel3.RowCount = 2
        Me.tableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51.0!))
        Me.tableLayoutPanel3.Size = New System.Drawing.Size(869, 419)
        Me.tableLayoutPanel3.TabIndex = 1
        '
        'tableLayoutPanel6
        '
        Me.tableLayoutPanel6.ColumnCount = 3
        Me.tableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tableLayoutPanel6.Controls.Add(Me.btnLimpiarCampos, 0, 0)
        Me.tableLayoutPanel6.Controls.Add(Me.btnGuardar, 2, 0)
        Me.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tableLayoutPanel6.Location = New System.Drawing.Point(3, 371)
        Me.tableLayoutPanel6.Name = "tableLayoutPanel6"
        Me.tableLayoutPanel6.RowCount = 1
        Me.tableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableLayoutPanel6.Size = New System.Drawing.Size(863, 45)
        Me.tableLayoutPanel6.TabIndex = 19
        '
        'btnLimpiarCampos
        '
        Me.btnLimpiarCampos.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnLimpiarCampos.BackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.btnLimpiarCampos.FlatAppearance.BorderSize = 0
        Me.btnLimpiarCampos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpiarCampos.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiarCampos.ForeColor = System.Drawing.Color.White
        Me.btnLimpiarCampos.Location = New System.Drawing.Point(113, 3)
        Me.btnLimpiarCampos.Name = "btnLimpiarCampos"
        Me.btnLimpiarCampos.Size = New System.Drawing.Size(305, 39)
        Me.btnLimpiarCampos.TabIndex = 18
        Me.btnLimpiarCampos.Text = "Cancelar"
        Me.btnLimpiarCampos.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.btnGuardar.FlatAppearance.BorderSize = 0
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ForeColor = System.Drawing.Color.White
        Me.btnGuardar.Location = New System.Drawing.Point(444, 3)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(305, 39)
        Me.btnGuardar.TabIndex = 17
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'wConfiguracion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(869, 419)
        Me.Controls.Add(Me.tableLayoutPanel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "wConfiguracion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configuración"
        Me.tabControl1.ResumeLayout(False)
        Me.tabPage1.ResumeLayout(False)
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tableLayoutPanel5.ResumeLayout(False)
        Me.tableLayoutPanel5.PerformLayout()
        Me.tabPage2.ResumeLayout(False)
        Me.tableLayoutPanel1.ResumeLayout(False)
        Me.tableLayoutPanel1.PerformLayout()
        Me.tabPage3.ResumeLayout(False)
        Me.tableLayoutPanel2.ResumeLayout(False)
        Me.tableLayoutPanel2.PerformLayout()
        Me.tableLayoutPanel4.ResumeLayout(False)
        Me.tableLayoutPanel4.PerformLayout()
        Me.tableLayoutPanel3.ResumeLayout(False)
        Me.tableLayoutPanel6.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub


    Private tabControl1 As System.Windows.Forms.TabControl

    Private tabPage1 As System.Windows.Forms.TabPage

    Private tabPage2 As System.Windows.Forms.TabPage

    Private tbUsuarioFoliosDigitales As System.Windows.Forms.TextBox

    Private tbPasswordFoliosDigitales As System.Windows.Forms.TextBox

    Private tableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel

    Private tbEmisorRFC As System.Windows.Forms.TextBox

    Private label3 As System.Windows.Forms.Label

    Private tbEmisorRazonSocial As System.Windows.Forms.TextBox

    Private label1 As System.Windows.Forms.Label

    Private label14 As System.Windows.Forms.Label

    Private cbRegimenesFiscales As System.Windows.Forms.ComboBox

    Private label8 As System.Windows.Forms.Label

    Private label17 As System.Windows.Forms.Label

    Private label6 As System.Windows.Forms.Label

    Private label18 As System.Windows.Forms.Label

    Private tabPage3 As System.Windows.Forms.TabPage

    Private tableLayoutPanel4 As System.Windows.Forms.TableLayoutPanel

    Private label19 As System.Windows.Forms.Label

    Private label20 As System.Windows.Forms.Label

    Private label21 As System.Windows.Forms.Label

    Private tbFacturacionRutaXMLST As System.Windows.Forms.TextBox

    Private tbFacturacionRutaXMLT As System.Windows.Forms.TextBox

    Private WithEvents btnExaminarRutaXMLST As System.Windows.Forms.Button

    Private WithEvents btnExaminarRutaXMLT As System.Windows.Forms.Button

    Private tableLayoutPanel5 As System.Windows.Forms.TableLayoutPanel

    Private tableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel

    Private label7 As System.Windows.Forms.Label

    Private tbConexionRutaCertificado As System.Windows.Forms.TextBox

    Private label5 As System.Windows.Forms.Label

    Private tbConexionRutaPfx As System.Windows.Forms.TextBox

    Private tbConexionContrasenaPfx As System.Windows.Forms.TextBox

    Private label2 As System.Windows.Forms.Label

    Private label4 As System.Windows.Forms.Label

    Private WithEvents btnExaminarCertificadosRutaPFX As System.Windows.Forms.Button

    Private WithEvents btnExaminarCertificadosRutaCertificado As System.Windows.Forms.Button

    Private tableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel

    Private tableLayoutPanel6 As System.Windows.Forms.TableLayoutPanel

    Private WithEvents btnLimpiarCampos As System.Windows.Forms.Button

    Private WithEvents btnGuardar As System.Windows.Forms.Button

    Private label9 As System.Windows.Forms.Label

    Private tbLugarExpedicion As System.Windows.Forms.TextBox
    Friend WithEvents LogoPictureBox As PictureBox
End Class
