<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKardexXML
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
        Me.GridOC_Detalle = New System.Windows.Forms.DataGridView()
        Me.lblOC_TotalRegistrosDetalle = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.lblFechaRegistro = New System.Windows.Forms.Label()
        Me.lblFechaXML = New System.Windows.Forms.Label()
        Me.lblProveedor = New System.Windows.Forms.Label()
        Me.lblRFC = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblIVA = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblSubTotal = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TextBox_RespuestaWS = New System.Windows.Forms.TextBox()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.btnCancelarCFDI = New System.Windows.Forms.Button()
        Me.btnXML = New System.Windows.Forms.Button()
        Me.btnPDF = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtUUID = New System.Windows.Forms.TextBox()
        CType(Me.GridOC_Detalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridOC_Detalle
        '
        Me.GridOC_Detalle.AllowUserToAddRows = False
        Me.GridOC_Detalle.AllowUserToDeleteRows = False
        Me.GridOC_Detalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridOC_Detalle.Location = New System.Drawing.Point(6, 21)
        Me.GridOC_Detalle.Name = "GridOC_Detalle"
        Me.GridOC_Detalle.ReadOnly = True
        Me.GridOC_Detalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridOC_Detalle.Size = New System.Drawing.Size(943, 216)
        Me.GridOC_Detalle.TabIndex = 36
        '
        'lblOC_TotalRegistrosDetalle
        '
        Me.lblOC_TotalRegistrosDetalle.AutoSize = True
        Me.lblOC_TotalRegistrosDetalle.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOC_TotalRegistrosDetalle.Location = New System.Drawing.Point(106, 262)
        Me.lblOC_TotalRegistrosDetalle.Name = "lblOC_TotalRegistrosDetalle"
        Me.lblOC_TotalRegistrosDetalle.Size = New System.Drawing.Size(15, 16)
        Me.lblOC_TotalRegistrosDetalle.TabIndex = 38
        Me.lblOC_TotalRegistrosDetalle.Text = "0"
        '
        'lblTotal
        '
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotal.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(848, 290)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(101, 15)
        Me.lblTotal.TabIndex = 80
        Me.lblTotal.Text = "0"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(6, 262)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(105, 16)
        Me.Label30.TabIndex = 37
        Me.Label30.Text = "Total Regsitros:"
        '
        'lblEstado
        '
        Me.lblEstado.Location = New System.Drawing.Point(1219, 198)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(245, 17)
        Me.lblEstado.TabIndex = 11
        Me.lblEstado.Text = "Label12"
        '
        'lblFechaRegistro
        '
        Me.lblFechaRegistro.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFechaRegistro.Location = New System.Drawing.Point(625, 66)
        Me.lblFechaRegistro.Name = "lblFechaRegistro"
        Me.lblFechaRegistro.Size = New System.Drawing.Size(315, 17)
        Me.lblFechaRegistro.TabIndex = 10
        Me.lblFechaRegistro.Text = "Label11"
        '
        'lblFechaXML
        '
        Me.lblFechaXML.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFechaXML.Location = New System.Drawing.Point(625, 30)
        Me.lblFechaXML.Name = "lblFechaXML"
        Me.lblFechaXML.Size = New System.Drawing.Size(315, 17)
        Me.lblFechaXML.TabIndex = 9
        Me.lblFechaXML.Text = "Label10"
        '
        'lblProveedor
        '
        Me.lblProveedor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblProveedor.Location = New System.Drawing.Point(165, 103)
        Me.lblProveedor.Name = "lblProveedor"
        Me.lblProveedor.Size = New System.Drawing.Size(326, 17)
        Me.lblProveedor.TabIndex = 8
        Me.lblProveedor.Text = "Label9"
        '
        'lblRFC
        '
        Me.lblRFC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRFC.Location = New System.Drawing.Point(165, 67)
        Me.lblRFC.Name = "lblRFC"
        Me.lblRFC.Size = New System.Drawing.Size(326, 17)
        Me.lblRFC.TabIndex = 7
        Me.lblRFC.Text = "Label8"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(758, 240)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(74, 15)
        Me.Label34.TabIndex = 77
        Me.Label34.Text = "SUB TOTAL:"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(758, 262)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(34, 15)
        Me.Label26.TabIndex = 76
        Me.Label26.Text = "I.V.A."
        '
        'lblID
        '
        Me.lblID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblID.Location = New System.Drawing.Point(165, 31)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(326, 17)
        Me.lblID.TabIndex = 6
        Me.lblID.Text = "Label7"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(758, 288)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(47, 15)
        Me.Label35.TabIndex = 78
        Me.Label35.Text = "TOTAL:"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(1094, 198)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(119, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Estado:"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(23, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(138, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Proveedor:"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "RFC:"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Folio:"
        '
        'lblIVA
        '
        Me.lblIVA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblIVA.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIVA.Location = New System.Drawing.Point(848, 263)
        Me.lblIVA.Name = "lblIVA"
        Me.lblIVA.Size = New System.Drawing.Size(101, 15)
        Me.lblIVA.TabIndex = 79
        Me.lblIVA.Text = "0"
        Me.lblIVA.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(500, 66)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(119, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Fecha Registro:"
        '
        'lblSubTotal
        '
        Me.lblSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSubTotal.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubTotal.Location = New System.Drawing.Point(848, 239)
        Me.lblSubTotal.Name = "lblSubTotal"
        Me.lblSubTotal.Size = New System.Drawing.Size(101, 15)
        Me.lblSubTotal.TabIndex = 75
        Me.lblSubTotal.Text = "0"
        Me.lblSubTotal.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtUUID)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.lblFechaXML)
        Me.GroupBox1.Controls.Add(Me.lblProveedor)
        Me.GroupBox1.Controls.Add(Me.lblFechaRegistro)
        Me.GroupBox1.Controls.Add(Me.lblRFC)
        Me.GroupBox1.Controls.Add(Me.lblID)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(10, 11)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(955, 133)
        Me.GroupBox1.TabIndex = 71
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "FACTURA XML"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(500, 100)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(119, 20)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "UUID:"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.TextBox_RespuestaWS)
        Me.GroupBox2.Controls.Add(Me.GridOC_Detalle)
        Me.GroupBox2.Controls.Add(Me.lblOC_TotalRegistrosDetalle)
        Me.GroupBox2.Controls.Add(Me.lblTotal)
        Me.GroupBox2.Controls.Add(Me.Label30)
        Me.GroupBox2.Controls.Add(Me.lblSubTotal)
        Me.GroupBox2.Controls.Add(Me.Label34)
        Me.GroupBox2.Controls.Add(Me.lblIVA)
        Me.GroupBox2.Controls.Add(Me.btnImprimir)
        Me.GroupBox2.Controls.Add(Me.Label26)
        Me.GroupBox2.Controls.Add(Me.Label35)
        Me.GroupBox2.Location = New System.Drawing.Point(10, 150)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(955, 308)
        Me.GroupBox2.TabIndex = 72
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "DETALLE"
        '
        'TextBox_RespuestaWS
        '
        Me.TextBox_RespuestaWS.BackColor = System.Drawing.Color.Red
        Me.TextBox_RespuestaWS.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.TextBox_RespuestaWS.ForeColor = System.Drawing.Color.White
        Me.TextBox_RespuestaWS.Location = New System.Drawing.Point(157, 243)
        Me.TextBox_RespuestaWS.Multiline = True
        Me.TextBox_RespuestaWS.Name = "TextBox_RespuestaWS"
        Me.TextBox_RespuestaWS.Size = New System.Drawing.Size(584, 59)
        Me.TextBox_RespuestaWS.TabIndex = 83
        Me.TextBox_RespuestaWS.Visible = False
        '
        'btnImprimir
        '
        Me.btnImprimir.Image = Global.ef33LlantasRegio.My.Resources.Resources.icons8_Print_48
        Me.btnImprimir.Location = New System.Drawing.Point(540, 89)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(104, 83)
        Me.btnImprimir.TabIndex = 81
        Me.btnImprimir.Text = "IMPRIMIR"
        Me.btnImprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnImprimir.UseVisualStyleBackColor = True
        Me.btnImprimir.Visible = False
        '
        'btnCancelarCFDI
        '
        Me.btnCancelarCFDI.Image = Global.ef33LlantasRegio.My.Resources.Resources.icons8_delete_document_filled_50
        Me.btnCancelarCFDI.Location = New System.Drawing.Point(277, 464)
        Me.btnCancelarCFDI.Name = "btnCancelarCFDI"
        Me.btnCancelarCFDI.Size = New System.Drawing.Size(104, 83)
        Me.btnCancelarCFDI.TabIndex = 84
        Me.btnCancelarCFDI.Text = "CANCELAR CFDI"
        Me.btnCancelarCFDI.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCancelarCFDI.UseVisualStyleBackColor = True
        '
        'btnXML
        '
        Me.btnXML.Image = Global.ef33LlantasRegio.My.Resources.Resources.icons8_xml_40
        Me.btnXML.Location = New System.Drawing.Point(539, 464)
        Me.btnXML.Name = "btnXML"
        Me.btnXML.Size = New System.Drawing.Size(104, 83)
        Me.btnXML.TabIndex = 83
        Me.btnXML.Text = "XML"
        Me.btnXML.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnXML.UseVisualStyleBackColor = True
        '
        'btnPDF
        '
        Me.btnPDF.Image = Global.ef33LlantasRegio.My.Resources.Resources.icons8_pdf_48
        Me.btnPDF.Location = New System.Drawing.Point(408, 464)
        Me.btnPDF.Name = "btnPDF"
        Me.btnPDF.Size = New System.Drawing.Size(104, 83)
        Me.btnPDF.TabIndex = 82
        Me.btnPDF.Text = "PDF"
        Me.btnPDF.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnPDF.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Image = Global.ef33LlantasRegio.My.Resources.Resources.icons8_close_window_48__1_
        Me.Button1.Location = New System.Drawing.Point(858, 465)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 83)
        Me.Button1.TabIndex = 73
        Me.Button1.Text = "CERRAR"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.ef33LlantasRegio.My.Resources.Resources.LogoFacrura33
        Me.PictureBox5.Location = New System.Drawing.Point(10, 464)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(111, 83)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 74
        Me.PictureBox5.TabStop = False
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(500, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Fecha XML:"
        '
        'txtUUID
        '
        Me.txtUUID.Location = New System.Drawing.Point(625, 96)
        Me.txtUUID.Name = "txtUUID"
        Me.txtUUID.ReadOnly = True
        Me.txtUUID.Size = New System.Drawing.Size(315, 22)
        Me.txtUUID.TabIndex = 12
        '
        'frmKardexXML
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(977, 560)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnCancelarCFDI)
        Me.Controls.Add(Me.btnXML)
        Me.Controls.Add(Me.btnPDF)
        Me.Controls.Add(Me.lblEstado)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmKardexXML"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Kardex Factura XML"
        CType(Me.GridOC_Detalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents GridOC_Detalle As DataGridView
    Friend WithEvents lblOC_TotalRegistrosDetalle As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Label30 As Label
    Friend WithEvents lblEstado As Label
    Friend WithEvents lblFechaRegistro As Label
    Friend WithEvents lblFechaXML As Label
    Friend WithEvents lblProveedor As Label
    Friend WithEvents lblRFC As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents lblID As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblIVA As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnImprimir As Button
    Friend WithEvents lblSubTotal As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnPDF As Button
    Friend WithEvents btnXML As Button
    Friend WithEvents btnCancelarCFDI As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox_RespuestaWS As TextBox
    Friend WithEvents txtUUID As TextBox
    Friend WithEvents Label4 As Label
End Class
