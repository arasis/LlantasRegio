<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultaFacturas
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
        Me.PanelConsultaDocumentos = New System.Windows.Forms.Panel()
        Me.Grid_CD = New System.Windows.Forms.DataGridView()
        Me.btnCrearPDF = New System.Windows.Forms.Button()
        Me.lblTotalRegistros_CD = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtProveedor_CD = New System.Windows.Forms.TextBox()
        Me.txtRFC_CD = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.btnBuscaLista_CD = New System.Windows.Forms.Button()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.lblAcuseSAt = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblcMONEDA = New System.Windows.Forms.Label()
        Me.Label67 = New System.Windows.Forms.Label()
        Me.lblcIMPORTE = New System.Windows.Forms.Label()
        Me.Label65 = New System.Windows.Forms.Label()
        Me.lblcFECHAFACTURA = New System.Windows.Forms.Label()
        Me.Label63 = New System.Windows.Forms.Label()
        Me.lblcFOLIO = New System.Windows.Forms.Label()
        Me.Label61 = New System.Windows.Forms.Label()
        Me.lblcUUID = New System.Windows.Forms.Label()
        Me.Label59 = New System.Windows.Forms.Label()
        Me.lblRfcReceptor_CD = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblId_CD = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.lblRazonSocial_CD = New System.Windows.Forms.Label()
        Me.lblRfcEmisor_CD = New System.Windows.Forms.Label()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.panel2 = New System.Windows.Forms.Panel()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.btnBuscarImagen = New System.Windows.Forms.Button()
        Me.tbDireccionPDF = New System.Windows.Forms.TextBox()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnGuardarEn = New System.Windows.Forms.Button()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.tbRutaXML = New System.Windows.Forms.TextBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.lblFechaPago_Consulta = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.tbRutaCarpetaPDF = New System.Windows.Forms.TextBox()
        Me.btnCarpetaPDF = New System.Windows.Forms.Button()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.tbRutaCarpetaXML = New System.Windows.Forms.TextBox()
        Me.btnCarpetaXML = New System.Windows.Forms.Button()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.btnExaminar = New System.Windows.Forms.Button()
        Me.lblOrdenCompra_CD = New System.Windows.Forms.Label()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.PanelConsultaDocumentos.SuspendLayout()
        CType(Me.Grid_CD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.panel2.SuspendLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelConsultaDocumentos
        '
        Me.PanelConsultaDocumentos.Controls.Add(Me.Grid_CD)
        Me.PanelConsultaDocumentos.Controls.Add(Me.btnCrearPDF)
        Me.PanelConsultaDocumentos.Controls.Add(Me.lblTotalRegistros_CD)
        Me.PanelConsultaDocumentos.Controls.Add(Me.Label21)
        Me.PanelConsultaDocumentos.Controls.Add(Me.txtProveedor_CD)
        Me.PanelConsultaDocumentos.Controls.Add(Me.txtRFC_CD)
        Me.PanelConsultaDocumentos.Controls.Add(Me.Label22)
        Me.PanelConsultaDocumentos.Controls.Add(Me.Label24)
        Me.PanelConsultaDocumentos.Controls.Add(Me.btnBuscaLista_CD)
        Me.PanelConsultaDocumentos.Controls.Add(Me.Label25)
        Me.PanelConsultaDocumentos.Controls.Add(Me.lblAcuseSAt)
        Me.PanelConsultaDocumentos.Controls.Add(Me.GroupBox3)
        Me.PanelConsultaDocumentos.Controls.Add(Me.Label51)
        Me.PanelConsultaDocumentos.Controls.Add(Me.panel2)
        Me.PanelConsultaDocumentos.Controls.Add(Me.lblFechaPago_Consulta)
        Me.PanelConsultaDocumentos.Controls.Add(Me.TabControl1)
        Me.PanelConsultaDocumentos.Controls.Add(Me.Label50)
        Me.PanelConsultaDocumentos.Controls.Add(Me.btnExaminar)
        Me.PanelConsultaDocumentos.Controls.Add(Me.lblOrdenCompra_CD)
        Me.PanelConsultaDocumentos.Controls.Add(Me.Label46)
        Me.PanelConsultaDocumentos.Location = New System.Drawing.Point(12, 12)
        Me.PanelConsultaDocumentos.Name = "PanelConsultaDocumentos"
        Me.PanelConsultaDocumentos.Size = New System.Drawing.Size(1254, 527)
        Me.PanelConsultaDocumentos.TabIndex = 118
        '
        'Grid_CD
        '
        Me.Grid_CD.AllowUserToAddRows = False
        Me.Grid_CD.AllowUserToDeleteRows = False
        Me.Grid_CD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grid_CD.Location = New System.Drawing.Point(16, 116)
        Me.Grid_CD.Name = "Grid_CD"
        Me.Grid_CD.ReadOnly = True
        Me.Grid_CD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Grid_CD.Size = New System.Drawing.Size(735, 380)
        Me.Grid_CD.TabIndex = 1
        '
        'btnCrearPDF
        '
        Me.btnCrearPDF.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.btnCrearPDF.FlatAppearance.BorderSize = 0
        Me.btnCrearPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCrearPDF.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCrearPDF.ForeColor = System.Drawing.Color.White
        Me.btnCrearPDF.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCrearPDF.Location = New System.Drawing.Point(416, 306)
        Me.btnCrearPDF.Name = "btnCrearPDF"
        Me.btnCrearPDF.Size = New System.Drawing.Size(190, 60)
        Me.btnCrearPDF.TabIndex = 154
        Me.btnCrearPDF.Text = "Abrir archivos"
        Me.btnCrearPDF.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCrearPDF.UseVisualStyleBackColor = False
        '
        'lblTotalRegistros_CD
        '
        Me.lblTotalRegistros_CD.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalRegistros_CD.Location = New System.Drawing.Point(680, 499)
        Me.lblTotalRegistros_CD.Name = "lblTotalRegistros_CD"
        Me.lblTotalRegistros_CD.Size = New System.Drawing.Size(71, 15)
        Me.lblTotalRegistros_CD.TabIndex = 151
        Me.lblTotalRegistros_CD.Text = "0"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(562, 499)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(112, 15)
        Me.Label21.TabIndex = 150
        Me.Label21.Text = "Total de Registros:"
        '
        'txtProveedor_CD
        '
        Me.txtProveedor_CD.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtProveedor_CD.Location = New System.Drawing.Point(176, 88)
        Me.txtProveedor_CD.Name = "txtProveedor_CD"
        Me.txtProveedor_CD.Size = New System.Drawing.Size(419, 20)
        Me.txtProveedor_CD.TabIndex = 149
        '
        'txtRFC_CD
        '
        Me.txtRFC_CD.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRFC_CD.Location = New System.Drawing.Point(16, 87)
        Me.txtRFC_CD.Name = "txtRFC_CD"
        Me.txtRFC_CD.Size = New System.Drawing.Size(154, 20)
        Me.txtRFC_CD.TabIndex = 148
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(16, 67)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(29, 15)
        Me.Label22.TabIndex = 147
        Me.Label22.Text = "RFC"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(173, 70)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(79, 15)
        Me.Label24.TabIndex = 145
        Me.Label24.Text = "PROVEEDOR"
        '
        'btnBuscaLista_CD
        '
        Me.btnBuscaLista_CD.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.btnBuscaLista_CD.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscaLista_CD.ForeColor = System.Drawing.Color.White
        Me.btnBuscaLista_CD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscaLista_CD.Location = New System.Drawing.Point(601, 79)
        Me.btnBuscaLista_CD.Name = "btnBuscaLista_CD"
        Me.btnBuscaLista_CD.Size = New System.Drawing.Size(151, 34)
        Me.btnBuscaLista_CD.TabIndex = 144
        Me.btnBuscaLista_CD.Text = "Lista Completa"
        Me.btnBuscaLista_CD.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBuscaLista_CD.UseVisualStyleBackColor = False
        '
        'Label25
        '
        Me.Label25.Font = New System.Drawing.Font("Arial", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label25.Location = New System.Drawing.Point(16, 20)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(1310, 34)
        Me.Label25.TabIndex = 133
        Me.Label25.Text = "CONSULTA DE DOCUMENTOS"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAcuseSAt
        '
        Me.lblAcuseSAt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAcuseSAt.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAcuseSAt.Location = New System.Drawing.Point(397, 402)
        Me.lblAcuseSAt.Name = "lblAcuseSAt"
        Me.lblAcuseSAt.Size = New System.Drawing.Size(292, 45)
        Me.lblAcuseSAt.TabIndex = 169
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblcMONEDA)
        Me.GroupBox3.Controls.Add(Me.Label67)
        Me.GroupBox3.Controls.Add(Me.lblcIMPORTE)
        Me.GroupBox3.Controls.Add(Me.Label65)
        Me.GroupBox3.Controls.Add(Me.lblcFECHAFACTURA)
        Me.GroupBox3.Controls.Add(Me.Label63)
        Me.GroupBox3.Controls.Add(Me.lblcFOLIO)
        Me.GroupBox3.Controls.Add(Me.Label61)
        Me.GroupBox3.Controls.Add(Me.lblcUUID)
        Me.GroupBox3.Controls.Add(Me.Label59)
        Me.GroupBox3.Controls.Add(Me.lblRfcReceptor_CD)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.lblId_CD)
        Me.GroupBox3.Controls.Add(Me.Label32)
        Me.GroupBox3.Controls.Add(Me.lblRazonSocial_CD)
        Me.GroupBox3.Controls.Add(Me.lblRfcEmisor_CD)
        Me.GroupBox3.Controls.Add(Me.Label47)
        Me.GroupBox3.Controls.Add(Me.Label48)
        Me.GroupBox3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(767, 162)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(474, 282)
        Me.GroupBox3.TabIndex = 152
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Información del Proveedor"
        '
        'lblcMONEDA
        '
        Me.lblcMONEDA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblcMONEDA.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcMONEDA.Location = New System.Drawing.Point(164, 243)
        Me.lblcMONEDA.Name = "lblcMONEDA"
        Me.lblcMONEDA.Size = New System.Drawing.Size(133, 15)
        Me.lblcMONEDA.TabIndex = 179
        '
        'Label67
        '
        Me.Label67.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label67.Location = New System.Drawing.Point(23, 244)
        Me.Label67.Name = "Label67"
        Me.Label67.Size = New System.Drawing.Size(129, 15)
        Me.Label67.TabIndex = 178
        Me.Label67.Text = "MONEDA:"
        '
        'lblcIMPORTE
        '
        Me.lblcIMPORTE.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblcIMPORTE.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcIMPORTE.Location = New System.Drawing.Point(164, 213)
        Me.lblcIMPORTE.Name = "lblcIMPORTE"
        Me.lblcIMPORTE.Size = New System.Drawing.Size(133, 15)
        Me.lblcIMPORTE.TabIndex = 177
        Me.lblcIMPORTE.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label65
        '
        Me.Label65.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label65.Location = New System.Drawing.Point(23, 214)
        Me.Label65.Name = "Label65"
        Me.Label65.Size = New System.Drawing.Size(129, 15)
        Me.Label65.TabIndex = 176
        Me.Label65.Text = "IMPORTE"
        '
        'lblcFECHAFACTURA
        '
        Me.lblcFECHAFACTURA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblcFECHAFACTURA.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcFECHAFACTURA.Location = New System.Drawing.Point(164, 184)
        Me.lblcFECHAFACTURA.Name = "lblcFECHAFACTURA"
        Me.lblcFECHAFACTURA.Size = New System.Drawing.Size(292, 15)
        Me.lblcFECHAFACTURA.TabIndex = 175
        '
        'Label63
        '
        Me.Label63.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label63.Location = New System.Drawing.Point(25, 185)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(129, 15)
        Me.Label63.TabIndex = 174
        Me.Label63.Text = "FECHA FACTURA:"
        '
        'lblcFOLIO
        '
        Me.lblcFOLIO.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblcFOLIO.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcFOLIO.Location = New System.Drawing.Point(164, 152)
        Me.lblcFOLIO.Name = "lblcFOLIO"
        Me.lblcFOLIO.Size = New System.Drawing.Size(292, 15)
        Me.lblcFOLIO.TabIndex = 173
        '
        'Label61
        '
        Me.Label61.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label61.Location = New System.Drawing.Point(25, 154)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(129, 15)
        Me.Label61.TabIndex = 172
        Me.Label61.Text = "FOLIO:"
        '
        'lblcUUID
        '
        Me.lblcUUID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblcUUID.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcUUID.Location = New System.Drawing.Point(164, 125)
        Me.lblcUUID.Name = "lblcUUID"
        Me.lblcUUID.Size = New System.Drawing.Size(292, 15)
        Me.lblcUUID.TabIndex = 171
        '
        'Label59
        '
        Me.Label59.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label59.Location = New System.Drawing.Point(23, 126)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(129, 15)
        Me.Label59.TabIndex = 170
        Me.Label59.Text = "UUID:"
        '
        'lblRfcReceptor_CD
        '
        Me.lblRfcReceptor_CD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRfcReceptor_CD.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRfcReceptor_CD.Location = New System.Drawing.Point(164, 100)
        Me.lblRfcReceptor_CD.Name = "lblRfcReceptor_CD"
        Me.lblRfcReceptor_CD.Size = New System.Drawing.Size(157, 15)
        Me.lblRfcReceptor_CD.TabIndex = 165
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(23, 100)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(129, 15)
        Me.Label11.TabIndex = 164
        Me.Label11.Text = "RFC RECEPTOR:"
        '
        'lblId_CD
        '
        Me.lblId_CD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblId_CD.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblId_CD.Location = New System.Drawing.Point(164, 26)
        Me.lblId_CD.Name = "lblId_CD"
        Me.lblId_CD.Size = New System.Drawing.Size(126, 15)
        Me.lblId_CD.TabIndex = 162
        '
        'Label32
        '
        Me.Label32.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(23, 27)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(129, 15)
        Me.Label32.TabIndex = 161
        Me.Label32.Text = "ID:"
        '
        'lblRazonSocial_CD
        '
        Me.lblRazonSocial_CD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRazonSocial_CD.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRazonSocial_CD.Location = New System.Drawing.Point(164, 50)
        Me.lblRazonSocial_CD.Name = "lblRazonSocial_CD"
        Me.lblRazonSocial_CD.Size = New System.Drawing.Size(292, 15)
        Me.lblRazonSocial_CD.TabIndex = 154
        '
        'lblRfcEmisor_CD
        '
        Me.lblRfcEmisor_CD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRfcEmisor_CD.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRfcEmisor_CD.Location = New System.Drawing.Point(164, 74)
        Me.lblRfcEmisor_CD.Name = "lblRfcEmisor_CD"
        Me.lblRfcEmisor_CD.Size = New System.Drawing.Size(157, 15)
        Me.lblRfcEmisor_CD.TabIndex = 153
        '
        'Label47
        '
        Me.Label47.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label47.Location = New System.Drawing.Point(23, 75)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(129, 15)
        Me.Label47.TabIndex = 149
        Me.Label47.Text = "RFC EMISOR:"
        '
        'Label48
        '
        Me.Label48.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label48.Location = New System.Drawing.Point(23, 50)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(129, 15)
        Me.Label48.TabIndex = 148
        Me.Label48.Text = "RAZON SOCIAL:"
        '
        'Label51
        '
        Me.Label51.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label51.Location = New System.Drawing.Point(256, 403)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(129, 15)
        Me.Label51.TabIndex = 168
        Me.Label51.Text = "ACUSE SAT:"
        '
        'panel2
        '
        Me.panel2.BackColor = System.Drawing.Color.White
        Me.panel2.Controls.Add(Me.Label45)
        Me.panel2.Controls.Add(Me.Label26)
        Me.panel2.Controls.Add(Me.Label40)
        Me.panel2.Controls.Add(Me.btnBuscarImagen)
        Me.panel2.Controls.Add(Me.tbDireccionPDF)
        Me.panel2.Controls.Add(Me.pictureBox1)
        Me.panel2.Controls.Add(Me.btnGuardarEn)
        Me.panel2.Controls.Add(Me.Label41)
        Me.panel2.Controls.Add(Me.PictureBox2)
        Me.panel2.Controls.Add(Me.tbRutaXML)
        Me.panel2.Controls.Add(Me.PictureBox3)
        Me.panel2.Location = New System.Drawing.Point(109, 129)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(200, 220)
        Me.panel2.TabIndex = 155
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.Label45.Location = New System.Drawing.Point(18, 12)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(157, 18)
        Me.Label45.TabIndex = 8
        Me.Label45.Text = "Logo de la empresa"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.Label26.Location = New System.Drawing.Point(-3, 34)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(101, 18)
        Me.Label26.TabIndex = 7
        Me.Label26.Text = "Ubicaciones"
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.ForeColor = System.Drawing.Color.Gray
        Me.Label40.Location = New System.Drawing.Point(8, 111)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(267, 16)
        Me.Label40.TabIndex = 6
        Me.Label40.Text = "Ruta del documento en formato (.pdf) "
        '
        'btnBuscarImagen
        '
        Me.btnBuscarImagen.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.btnBuscarImagen.FlatAppearance.BorderSize = 0
        Me.btnBuscarImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscarImagen.ForeColor = System.Drawing.Color.White
        Me.btnBuscarImagen.Location = New System.Drawing.Point(95, 186)
        Me.btnBuscarImagen.Name = "btnBuscarImagen"
        Me.btnBuscarImagen.Size = New System.Drawing.Size(91, 23)
        Me.btnBuscarImagen.TabIndex = 5
        Me.btnBuscarImagen.Text = "Buscar i&magen"
        Me.btnBuscarImagen.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnBuscarImagen.UseVisualStyleBackColor = False
        '
        'tbDireccionPDF
        '
        Me.tbDireccionPDF.Enabled = False
        Me.tbDireccionPDF.Location = New System.Drawing.Point(11, 137)
        Me.tbDireccionPDF.Name = "tbDireccionPDF"
        Me.tbDireccionPDF.Size = New System.Drawing.Size(483, 20)
        Me.tbDireccionPDF.TabIndex = 5
        '
        'pictureBox1
        '
        Me.pictureBox1.Location = New System.Drawing.Point(10, 33)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(176, 147)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBox1.TabIndex = 1
        Me.pictureBox1.TabStop = False
        '
        'btnGuardarEn
        '
        Me.btnGuardarEn.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.btnGuardarEn.FlatAppearance.BorderSize = 0
        Me.btnGuardarEn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardarEn.ForeColor = System.Drawing.Color.White
        Me.btnGuardarEn.Location = New System.Drawing.Point(-25, 165)
        Me.btnGuardarEn.Name = "btnGuardarEn"
        Me.btnGuardarEn.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardarEn.TabIndex = 7
        Me.btnGuardarEn.Text = "Guar&dar en"
        Me.btnGuardarEn.UseVisualStyleBackColor = False
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.ForeColor = System.Drawing.Color.Gray
        Me.Label41.Location = New System.Drawing.Point(6, 55)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(424, 16)
        Me.Label41.TabIndex = 3
        Me.Label41.Text = "Ruta del Comprobante Fiscal Dígital (CFDI) en formato (.xml)"
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(489, 71)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(50, 42)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 156
        Me.PictureBox2.TabStop = False
        '
        'tbRutaXML
        '
        Me.tbRutaXML.Enabled = False
        Me.tbRutaXML.Location = New System.Drawing.Point(9, 81)
        Me.tbRutaXML.Name = "tbRutaXML"
        Me.tbRutaXML.Size = New System.Drawing.Size(483, 20)
        Me.tbRutaXML.TabIndex = 2
        '
        'PictureBox3
        '
        Me.PictureBox3.Location = New System.Drawing.Point(489, 131)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(50, 42)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 157
        Me.PictureBox3.TabStop = False
        '
        'lblFechaPago_Consulta
        '
        Me.lblFechaPago_Consulta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFechaPago_Consulta.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaPago_Consulta.Location = New System.Drawing.Point(397, 370)
        Me.lblFechaPago_Consulta.Name = "lblFechaPago_Consulta"
        Me.lblFechaPago_Consulta.Size = New System.Drawing.Size(292, 15)
        Me.lblFechaPago_Consulta.TabIndex = 167
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(327, 278)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(83, 37)
        Me.TabControl1.TabIndex = 153
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.panel1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(75, 11)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Conversión de archivo"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'panel1
        '
        Me.panel1.BackColor = System.Drawing.Color.White
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel1.Location = New System.Drawing.Point(3, 3)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(69, 5)
        Me.panel1.TabIndex = 8
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Panel3)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(75, 11)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Conversión por carpeta"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.Label42)
        Me.Panel3.Controls.Add(Me.Label43)
        Me.Panel3.Controls.Add(Me.tbRutaCarpetaPDF)
        Me.Panel3.Controls.Add(Me.btnCarpetaPDF)
        Me.Panel3.Controls.Add(Me.Label44)
        Me.Panel3.Controls.Add(Me.tbRutaCarpetaXML)
        Me.Panel3.Controls.Add(Me.btnCarpetaXML)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(3, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(69, 5)
        Me.Panel3.TabIndex = 9
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.Label42.Location = New System.Drawing.Point(5, 8)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(101, 18)
        Me.Label42.TabIndex = 7
        Me.Label42.Text = "Ubicaciones"
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.ForeColor = System.Drawing.Color.Gray
        Me.Label43.Location = New System.Drawing.Point(20, 121)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(282, 16)
        Me.Label43.TabIndex = 6
        Me.Label43.Text = "Guardar documento en formato (.pdf) en"
        '
        'tbRutaCarpetaPDF
        '
        Me.tbRutaCarpetaPDF.Location = New System.Drawing.Point(23, 147)
        Me.tbRutaCarpetaPDF.Name = "tbRutaCarpetaPDF"
        Me.tbRutaCarpetaPDF.Size = New System.Drawing.Size(483, 20)
        Me.tbRutaCarpetaPDF.TabIndex = 5
        '
        'btnCarpetaPDF
        '
        Me.btnCarpetaPDF.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.btnCarpetaPDF.FlatAppearance.BorderSize = 0
        Me.btnCarpetaPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCarpetaPDF.ForeColor = System.Drawing.Color.White
        Me.btnCarpetaPDF.Location = New System.Drawing.Point(431, 173)
        Me.btnCarpetaPDF.Name = "btnCarpetaPDF"
        Me.btnCarpetaPDF.Size = New System.Drawing.Size(75, 23)
        Me.btnCarpetaPDF.TabIndex = 7
        Me.btnCarpetaPDF.Text = "Guar&dar en"
        Me.btnCarpetaPDF.UseVisualStyleBackColor = False
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.ForeColor = System.Drawing.Color.Gray
        Me.Label44.Location = New System.Drawing.Point(20, 36)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(424, 16)
        Me.Label44.TabIndex = 3
        Me.Label44.Text = "Ruta del Comprobante Fiscal Dígital (CFDI) en formato (.xml)"
        '
        'tbRutaCarpetaXML
        '
        Me.tbRutaCarpetaXML.Location = New System.Drawing.Point(23, 62)
        Me.tbRutaCarpetaXML.Name = "tbRutaCarpetaXML"
        Me.tbRutaCarpetaXML.Size = New System.Drawing.Size(483, 20)
        Me.tbRutaCarpetaXML.TabIndex = 2
        '
        'btnCarpetaXML
        '
        Me.btnCarpetaXML.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.btnCarpetaXML.FlatAppearance.BorderSize = 0
        Me.btnCarpetaXML.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCarpetaXML.ForeColor = System.Drawing.Color.White
        Me.btnCarpetaXML.Location = New System.Drawing.Point(431, 88)
        Me.btnCarpetaXML.Name = "btnCarpetaXML"
        Me.btnCarpetaXML.Size = New System.Drawing.Size(75, 23)
        Me.btnCarpetaXML.TabIndex = 4
        Me.btnCarpetaXML.Text = "&Elegir"
        Me.btnCarpetaXML.UseVisualStyleBackColor = False
        '
        'Label50
        '
        Me.Label50.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label50.Location = New System.Drawing.Point(256, 371)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(129, 15)
        Me.Label50.TabIndex = 166
        Me.Label50.Text = "FECHA PAGO:"
        '
        'btnExaminar
        '
        Me.btnExaminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.btnExaminar.FlatAppearance.BorderSize = 0
        Me.btnExaminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExaminar.ForeColor = System.Drawing.Color.White
        Me.btnExaminar.Location = New System.Drawing.Point(119, 367)
        Me.btnExaminar.Name = "btnExaminar"
        Me.btnExaminar.Size = New System.Drawing.Size(75, 23)
        Me.btnExaminar.TabIndex = 4
        Me.btnExaminar.Text = "&Elegir"
        Me.btnExaminar.UseVisualStyleBackColor = False
        '
        'lblOrdenCompra_CD
        '
        Me.lblOrdenCompra_CD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOrdenCompra_CD.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrdenCompra_CD.Location = New System.Drawing.Point(397, 192)
        Me.lblOrdenCompra_CD.Name = "lblOrdenCompra_CD"
        Me.lblOrdenCompra_CD.Size = New System.Drawing.Size(292, 15)
        Me.lblOrdenCompra_CD.TabIndex = 155
        '
        'Label46
        '
        Me.Label46.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label46.Location = New System.Drawing.Point(256, 193)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(129, 15)
        Me.Label46.TabIndex = 150
        Me.Label46.Text = "ORDEN DE COMPRA:"
        '
        'frmConsultaFacturas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1265, 553)
        Me.Controls.Add(Me.PanelConsultaDocumentos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmConsultaFacturas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta Facturas"
        Me.PanelConsultaDocumentos.ResumeLayout(False)
        Me.PanelConsultaDocumentos.PerformLayout()
        CType(Me.Grid_CD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.panel2.ResumeLayout(False)
        Me.panel2.PerformLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelConsultaDocumentos As Panel
    Friend WithEvents Grid_CD As DataGridView
    Private WithEvents btnCrearPDF As Button
    Friend WithEvents lblTotalRegistros_CD As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents txtProveedor_CD As TextBox
    Friend WithEvents txtRFC_CD As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents btnBuscaLista_CD As Button
    Friend WithEvents Label25 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents lblcMONEDA As Label
    Friend WithEvents Label67 As Label
    Friend WithEvents lblcIMPORTE As Label
    Friend WithEvents Label65 As Label
    Friend WithEvents lblcFECHAFACTURA As Label
    Friend WithEvents Label63 As Label
    Friend WithEvents lblcFOLIO As Label
    Friend WithEvents Label61 As Label
    Friend WithEvents lblcUUID As Label
    Friend WithEvents Label59 As Label
    Friend WithEvents lblAcuseSAt As Label
    Friend WithEvents Label51 As Label
    Friend WithEvents lblFechaPago_Consulta As Label
    Friend WithEvents Label50 As Label
    Friend WithEvents lblRfcReceptor_CD As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lblId_CD As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents lblOrdenCompra_CD As Label
    Friend WithEvents lblRazonSocial_CD As Label
    Friend WithEvents lblRfcEmisor_CD As Label
    Friend WithEvents Label46 As Label
    Friend WithEvents Label47 As Label
    Friend WithEvents Label48 As Label
    Private WithEvents panel2 As Panel
    Private WithEvents Label45 As Label
    Private WithEvents Label26 As Label
    Private WithEvents Label40 As Label
    Private WithEvents btnBuscarImagen As Button
    Private WithEvents tbDireccionPDF As TextBox
    Private WithEvents pictureBox1 As PictureBox
    Private WithEvents btnGuardarEn As Button
    Private WithEvents Label41 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Private WithEvents tbRutaXML As TextBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Private WithEvents panel1 As Panel
    Friend WithEvents TabPage2 As TabPage
    Private WithEvents Panel3 As Panel
    Private WithEvents Label42 As Label
    Private WithEvents Label43 As Label
    Private WithEvents tbRutaCarpetaPDF As TextBox
    Private WithEvents btnCarpetaPDF As Button
    Private WithEvents Label44 As Label
    Private WithEvents tbRutaCarpetaXML As TextBox
    Private WithEvents btnCarpetaXML As Button
    Private WithEvents btnExaminar As Button
End Class
