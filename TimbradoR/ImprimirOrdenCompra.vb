Imports System.Drawing.Printing
Module ImprimirOrdenCompra
    Public DataGridViewToPrint As New DataGridView

    Public DefaultPageSettings As PageSettings = New PageSettings()

    Public WithEvents DocToPrint As New PrintDocument

    Private lPageNo As String = ""
    Private sPageNo As String = ""
    Private oStringFormat As StringFormat
    Private oStringFormatComboBox As StringFormat
    Private oButton As Button
    Private oCheckbox As CheckBox
    Private oComboBox As ComboBox
    Private nTotalWidth As Int16
    Private nRowPos As Int16
    Private NewPage As Boolean
    Private nPageNo As Int16
    Private Header As String
    Private FooterComment As String = ""

    Public Sub StartPrint(ByVal GridToPrint As DataGridView, ByVal PrintAsLandscape As Boolean, ByVal ShowPrintPreview As Boolean, ByVal HeaderToPrint As String, ByVal CommentToPrint As String)

        DataGridViewToPrint = GridToPrint
        Header = HeaderToPrint
        FooterComment = CommentToPrint

        'DataGridViewToPrint.Columns(2).Visible = False ' Use to hide a col. (index no.)

        ' Set up Default Page Settings
        DocToPrint.DefaultPageSettings.Landscape = PrintAsLandscape

        DocToPrint.DefaultPageSettings.Margins.Left = 25
        DocToPrint.DefaultPageSettings.Margins.Right = 75
        DocToPrint.DefaultPageSettings.Margins.Top = 25
        DocToPrint.DefaultPageSettings.Margins.Bottom = 75

        DocToPrint.OriginAtMargins = True ' takes margins into account 

        'If ShowPrintPreview = True Then

        '    Dim dlgPrintPreview As New EnhancedPrintPreviewDialog

        '    dlgPrintPreview.ClientSize = New System.Drawing.Size(600, 600)
        'dlgPrintPreview.Document = DocToPrint ' Previews print
        ' dlgPrintPreview.ShowDialog()

        'Else

        '  Allow the user to choose a printer and specify other settings.
        Dim dlgPrint As New PrintDialog

        With dlgPrint
            .AllowSelection = False
            .ShowNetwork = False
            .AllowCurrentPage = True
            .AllowSomePages = True
            .Document = DocToPrint
        End With

        '  If the user clicked OK, print the document.
        If dlgPrint.ShowDialog = Windows.Forms.DialogResult.OK Then
            DocToPrint.Print()
        End If

    End Sub

    Public Sub DocToPrint_BeginPrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles DocToPrint.BeginPrint

        oStringFormat = New StringFormat
        oStringFormat.Alignment = StringAlignment.Near
        oStringFormat.LineAlignment = StringAlignment.Center
        oStringFormat.Trimming = StringTrimming.EllipsisCharacter



        oStringFormatComboBox = New StringFormat
        oStringFormatComboBox.LineAlignment = StringAlignment.Center
        oStringFormatComboBox.FormatFlags = StringFormatFlags.NoWrap
        oStringFormatComboBox.Trimming = StringTrimming.EllipsisCharacter

        oButton = New Button
        oCheckbox = New CheckBox
        oComboBox = New ComboBox

        nTotalWidth = 0

        For Each oColumn As DataGridViewColumn In DataGridViewToPrint.Columns
            If oColumn.Visible = True Then ' Prints only Visible columns
                nTotalWidth += oColumn.Width
            End If
        Next

        nPageNo = 1
        NewPage = True
        nRowPos = 0

    End Sub

    Public Sub DocToPrint_EndPrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles DocToPrint.EndPrint
        'Not currently used
    End Sub

    Public Sub DocToPrint_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles DocToPrint.PrintPage

        Dim headfont As Font
        Dim FONTDESCR As Font
        Dim nombre_empresa As Font

        nombre_empresa = New Font("Arial", 12, FontStyle.Bold)
        headfont = New Font("Arial", 8, FontStyle.Bold)
        FONTDESCR = New Font("Arial", 9, FontStyle.Regular)

        'Creo el lapicero para dibujar
        Dim Lapiz As New Pen(Color.Black, 0.3F)
        Dim Lapiz2 As New Pen(Color.Black, 1.3F)

        Static oColumnRights As New ArrayList
        Static oColumnLefts As New ArrayList
        Static oColumnWidths As New ArrayList
        Static oColumnTypes As New ArrayList
        Static nHeight As Int16

        Dim nWidth, i, nRowsPerPage As Int16
        Dim nTop As Int16 = e.MarginBounds.Top
        Dim nLeft As Int16 = e.MarginBounds.Left
        Dim nRight As Int16 = e.MarginBounds.Right

        If nPageNo = 1 Then

            oColumnLefts.Clear()
            oColumnWidths.Clear()
            oColumnTypes.Clear()
            oColumnRights.Clear()

            For Each oColumn As DataGridViewColumn In DataGridViewToPrint.Columns
                If oColumn.Visible = True Then
                    nWidth = CType(Math.Floor(oColumn.Width / nTotalWidth * nTotalWidth * (e.MarginBounds.Width / nTotalWidth)), Int16)

                    nHeight = e.Graphics.MeasureString(oColumn.HeaderText, oColumn.InheritedStyle.Font, nWidth).Height + 11

                    oColumnLefts.Add(nLeft)
                    oColumnWidths.Add(nWidth)
                    oColumnTypes.Add(oColumn.GetType)
                    nLeft += nWidth


                End If
            Next

        End If

        Do While nRowPos < DataGridViewToPrint.Rows.Count

            Dim oRow As DataGridViewRow = DataGridViewToPrint.Rows(nRowPos)

            If nTop + nHeight >= e.MarginBounds.Height + e.MarginBounds.Top Then

                DrawFooter(e, nRowsPerPage)

                NewPage = True
                nPageNo += 1
                e.HasMorePages = True
                Exit Sub

            Else

                If NewPage Then

                    'logo

                    Dim newImage2 As Image = Image.FromFile("C:\logo\ENCABEZADO GRUPO SIEL.jpg")

                    ' e.Graphics.DrawImage(logo, PosY, PosX)
                    e.Graphics.DrawImage(newImage2, -3, -5, 767, 130)


                    '*******************************************************
                    'e.Graphics.DrawRectangle(Lapiz, 25, 300, 747, 585)
                    '****************************************************************************************

                    '+ " " + Now.ToShortTimeString
                    e.Graphics.DrawString(Now.ToLongDateString, headfont, Brushes.Black, 520, 130)

                    e.Graphics.DrawString("PROVEEDOR: ", FONTDESCR, Brushes.Black, 26, 165)
                    e.Graphics.DrawString(Variables.print_proveedor, headfont, Brushes.Black, 130, 165)
                    ' e.Graphics.DrawRectangle(Lapiz2, 100, 185, 470, 1) 'Linea de Fecha

                    e.Graphics.DrawString("AT'N:", FONTDESCR, Brushes.Black, 26, 185)
                    e.Graphics.DrawString(Variables.contactoOrdenCompra, headfont, Brushes.Black, 130, 185)
                    ' e.Graphics.DrawRectangle(Lapiz2, 635, 185, 130, 1) 'Linea Folio

                    e.Graphics.DrawString("TEL:", FONTDESCR, Brushes.Black, 26, 205)
                    e.Graphics.DrawString(Variables.telContactoOrdenCompra, headfont, Brushes.Black, 130, 205)
                    'e.Graphics.DrawRectangle(Lapiz2, 100, 220, 450, 1) 'Linea Proveedor

                    e.Graphics.DrawString("E-MAIL:", FONTDESCR, Brushes.Black, 26, 225)
                    e.Graphics.DrawString(Variables.eMailContactoOrdenCompra, headfont, Brushes.Black, 130, 225)
                    ' e.Graphics.DrawRectangle(Lapiz2, 635, 220, 130, 1) 'Linea Proveedor

                    e.Graphics.DrawString("ORDEN DE COMPRA: ", FONTDESCR, Brushes.Black, 520, 245)
                    e.Graphics.DrawString(Variables.print_id_documento, headfont, Brushes.Black, 660, 245)
                    'e.Graphics.DrawRectangle(Lapiz2, 100, 220, 450, 1) 'Linea Proveedor

                    e.Graphics.DrawString("COND. DE PAGO:", FONTDESCR, Brushes.Black, 520, 265)
                    e.Graphics.DrawString(Variables.CondicionesPago, headfont, Brushes.Black, 630, 265)

                    e.Graphics.DrawString("Por medio de la Presente solicitamos el siguiente pedido:", FONTDESCR, Brushes.Black, 26, 285)

                    '*****************************************************************************************

                    ' Draw Columns
                    nTop = e.MarginBounds.Top + 300
                    i = 0
                    For Each oColumn As DataGridViewColumn In DataGridViewToPrint.Columns

                        If oColumn.Visible = True Then

                            'table_detalle.Columns.Add("ID", GetType(System.String))
                            'table_detalle.Columns.Add("CÓDIGO", GetType(System.String))
                            'table_detalle.Columns.Add("CONCEPTO", GetType(System.String))
                            'table_detalle.Columns.Add("CANT.", GetType(System.String))
                            'table_detalle.Columns.Add("UNID", GetType(System.String))
                            'table_detalle.Columns.Add("P.UNITARIO", GetType(System.String))
                            'table_detalle.Columns.Add("TOTAL", GetType(System.String))

                            If oColumn.Name = "ID" Then
                                oStringFormat = New StringFormat
                                oStringFormat.Alignment = StringAlignment.Center
                                oStringFormat.LineAlignment = StringAlignment.Center
                                oStringFormat.Trimming = StringTrimming.None

                                e.Graphics.FillRectangle(New SolidBrush(Drawing.Color.LightGray), New Rectangle(oColumnLefts(i), nTop, oColumnWidths(i), nHeight))
                                e.Graphics.DrawRectangle(Pens.Black, New Rectangle(oColumnLefts(i), nTop, oColumnWidths(i), nHeight))
                                e.Graphics.DrawString(oColumn.HeaderText, oColumn.InheritedStyle.Font, New SolidBrush(oColumn.InheritedStyle.ForeColor), New RectangleF(oColumnLefts(i), nTop, oColumnWidths(i), nHeight), oStringFormat)

                            End If

                            If oColumn.Name = "CÓDIGO" Then
                                oStringFormat = New StringFormat
                                oStringFormat.Alignment = StringAlignment.Center
                                oStringFormat.LineAlignment = StringAlignment.Center
                                oStringFormat.Trimming = StringTrimming.EllipsisCharacter

                                e.Graphics.FillRectangle(New SolidBrush(Drawing.Color.LightGray), New Rectangle(oColumnLefts(i), nTop, oColumnWidths(i), nHeight))
                                e.Graphics.DrawRectangle(Pens.Black, New Rectangle(oColumnLefts(i), nTop, oColumnWidths(i), nHeight))
                                e.Graphics.DrawString(oColumn.HeaderText, oColumn.InheritedStyle.Font, New SolidBrush(oColumn.InheritedStyle.ForeColor), New RectangleF(oColumnLefts(i), nTop, oColumnWidths(i), nHeight), oStringFormat)

                            End If

                            If oColumn.Name = "CONCEPTO" Then
                                oStringFormat = New StringFormat
                                oStringFormat.Alignment = StringAlignment.Near
                                oStringFormat.LineAlignment = StringAlignment.Center
                                oStringFormat.Trimming = StringTrimming.EllipsisCharacter

                                e.Graphics.FillRectangle(New SolidBrush(Drawing.Color.LightGray), New Rectangle(oColumnLefts(i), nTop, oColumnWidths(i), nHeight))
                                e.Graphics.DrawRectangle(Pens.Black, New Rectangle(oColumnLefts(i), nTop, oColumnWidths(i), nHeight))
                                e.Graphics.DrawString(oColumn.HeaderText, oColumn.InheritedStyle.Font, New SolidBrush(oColumn.InheritedStyle.ForeColor), New RectangleF(oColumnLefts(i), nTop, oColumnWidths(i), nHeight), oStringFormat)

                            End If



                            If oColumn.Name = "CANT." Then
                                oStringFormat = New StringFormat
                                oStringFormat.Alignment = StringAlignment.Center
                                oStringFormat.LineAlignment = StringAlignment.Center
                                oStringFormat.Trimming = StringTrimming.EllipsisCharacter

                                e.Graphics.FillRectangle(New SolidBrush(Drawing.Color.LightGray), New Rectangle(oColumnLefts(i), nTop, oColumnWidths(i), nHeight))
                                e.Graphics.DrawRectangle(Pens.Black, New Rectangle(oColumnLefts(i), nTop, oColumnWidths(i), nHeight))
                                e.Graphics.DrawString(oColumn.HeaderText, oColumn.InheritedStyle.Font, New SolidBrush(oColumn.InheritedStyle.ForeColor), New RectangleF(oColumnLefts(i), nTop, oColumnWidths(i), nHeight), oStringFormat)

                            End If

                            If oColumn.Name = "UNID" Then
                                oStringFormat = New StringFormat
                                oStringFormat.Alignment = StringAlignment.Center
                                oStringFormat.LineAlignment = StringAlignment.Center
                                oStringFormat.Trimming = StringTrimming.EllipsisCharacter

                                e.Graphics.FillRectangle(New SolidBrush(Drawing.Color.LightGray), New Rectangle(oColumnLefts(i), nTop, oColumnWidths(i), nHeight))
                                e.Graphics.DrawRectangle(Pens.Black, New Rectangle(oColumnLefts(i), nTop, oColumnWidths(i), nHeight))
                                e.Graphics.DrawString(oColumn.HeaderText, oColumn.InheritedStyle.Font, New SolidBrush(oColumn.InheritedStyle.ForeColor), New RectangleF(oColumnLefts(i), nTop, oColumnWidths(i), nHeight), oStringFormat)

                            End If

                            If oColumn.Name = "P.UNITARIO" Then
                                oStringFormat = New StringFormat
                                oStringFormat.Alignment = StringAlignment.Center
                                oStringFormat.LineAlignment = StringAlignment.Center
                                oStringFormat.Trimming = StringTrimming.EllipsisCharacter

                                e.Graphics.FillRectangle(New SolidBrush(Drawing.Color.LightGray), New Rectangle(oColumnLefts(i), nTop, oColumnWidths(i), nHeight))
                                e.Graphics.DrawRectangle(Pens.Black, New Rectangle(oColumnLefts(i), nTop, oColumnWidths(i), nHeight))
                                e.Graphics.DrawString(oColumn.HeaderText, oColumn.InheritedStyle.Font, New SolidBrush(oColumn.InheritedStyle.ForeColor), New RectangleF(oColumnLefts(i), nTop, oColumnWidths(i), nHeight), oStringFormat)

                            End If


                            If oColumn.Name = "    TOTAL    " Then
                                oStringFormat = New StringFormat
                                oStringFormat.Alignment = StringAlignment.Center
                                oStringFormat.LineAlignment = StringAlignment.Center
                                oStringFormat.Trimming = StringTrimming.EllipsisCharacter

                                e.Graphics.FillRectangle(New SolidBrush(Drawing.Color.LightGray), New Rectangle(oColumnLefts(i), nTop, oColumnWidths(i), nHeight))
                                e.Graphics.DrawRectangle(Pens.Black, New Rectangle(oColumnLefts(i), nTop, oColumnWidths(i), nHeight))
                                e.Graphics.DrawString(oColumn.HeaderText, oColumn.InheritedStyle.Font, New SolidBrush(oColumn.InheritedStyle.ForeColor), New RectangleF(oColumnLefts(i), nTop, oColumnWidths(i), nHeight), oStringFormat)

                            End If

                            'If oColumn.Name = "     Importe     " Then
                            '    oStringFormat = New StringFormat
                            '    oStringFormat.Alignment = StringAlignment.Center
                            '    oStringFormat.LineAlignment = StringAlignment.Center
                            '    oStringFormat.Trimming = StringTrimming.None

                            '    e.Graphics.FillRectangle(New SolidBrush(Drawing.Color.LightGray), New Rectangle(oColumnLefts(i), nTop, oColumnWidths(i), nHeight))
                            '    e.Graphics.DrawRectangle(Pens.Black, New Rectangle(oColumnLefts(i), nTop, oColumnWidths(i), nHeight))
                            '    e.Graphics.DrawString(oColumn.HeaderText, oColumn.InheritedStyle.Font, New SolidBrush(oColumn.InheritedStyle.ForeColor), New RectangleF(oColumnLefts(i), nTop, oColumnWidths(i), nHeight), oStringFormat)

                            'End If





                            i += 1
                        End If

                    Next
                    NewPage = False

                End If

                nTop += nHeight
                i = 0
                For Each oCell As DataGridViewCell In oRow.Cells
                    If oCell.Visible = True Then
                        If oColumnTypes(i) Is GetType(DataGridViewTextBoxColumn) OrElse oColumnTypes(i) Is GetType(DataGridViewLinkColumn) Then

                            If i = 0 Then
                                oStringFormat = New StringFormat
                                oStringFormat.Alignment = StringAlignment.Center
                                oStringFormat.LineAlignment = StringAlignment.Center
                                oStringFormat.Trimming = StringTrimming.EllipsisCharacter
                                e.Graphics.DrawString(oCell.Value.ToString, oCell.InheritedStyle.Font, New SolidBrush(oCell.InheritedStyle.ForeColor), New RectangleF(oColumnLefts(i), nTop, oColumnWidths(i), nHeight), oStringFormat)
                            End If
                            If i = 1 Then
                                oStringFormat = New StringFormat
                                oStringFormat.Alignment = StringAlignment.Center
                                oStringFormat.LineAlignment = StringAlignment.Center
                                oStringFormat.Trimming = StringTrimming.EllipsisCharacter
                                e.Graphics.DrawString(oCell.Value.ToString, oCell.InheritedStyle.Font, New SolidBrush(oCell.InheritedStyle.ForeColor), New RectangleF(oColumnLefts(i), nTop, oColumnWidths(i), nHeight), oStringFormat)
                            End If
                            If i = 2 Then
                                oStringFormat = New StringFormat
                                oStringFormat.Alignment = StringAlignment.Near
                                oStringFormat.LineAlignment = StringAlignment.Far
                                oStringFormat.Trimming = StringTrimming.EllipsisCharacter
                                e.Graphics.DrawString(oCell.Value.ToString, oCell.InheritedStyle.Font, New SolidBrush(oCell.InheritedStyle.ForeColor), New RectangleF(oColumnLefts(i), nTop, oColumnWidths(i), nHeight), oStringFormat)
                            End If
                            If i = 3 Then
                                oStringFormat = New StringFormat
                                oStringFormat.Alignment = StringAlignment.Center
                                oStringFormat.LineAlignment = StringAlignment.Center
                                oStringFormat.Trimming = StringTrimming.EllipsisCharacter
                                e.Graphics.DrawString(oCell.Value.ToString, oCell.InheritedStyle.Font, New SolidBrush(oCell.InheritedStyle.ForeColor), New RectangleF(oColumnLefts(i), nTop, oColumnWidths(i), nHeight), oStringFormat)
                            End If
                            If i = 4 Then
                                oStringFormat = New StringFormat
                                oStringFormat.Alignment = StringAlignment.Center
                                oStringFormat.LineAlignment = StringAlignment.Center
                                oStringFormat.Trimming = StringTrimming.EllipsisCharacter
                                e.Graphics.DrawString(oCell.Value.ToString, oCell.InheritedStyle.Font, New SolidBrush(oCell.InheritedStyle.ForeColor), New RectangleF(oColumnLefts(i), nTop, oColumnWidths(i), nHeight), oStringFormat)
                            End If
                            If i = 5 Then
                                oStringFormat = New StringFormat
                                oStringFormat.Alignment = StringAlignment.Center
                                oStringFormat.LineAlignment = StringAlignment.Center
                                oStringFormat.Trimming = StringTrimming.EllipsisCharacter
                                e.Graphics.DrawString(oCell.Value.ToString, oCell.InheritedStyle.Font, New SolidBrush(oCell.InheritedStyle.ForeColor), New RectangleF(oColumnLefts(i), nTop, oColumnWidths(i), nHeight), oStringFormat)
                            End If
                            If i = 6 Then
                                oStringFormat = New StringFormat
                                oStringFormat.Alignment = StringAlignment.Center
                                oStringFormat.LineAlignment = StringAlignment.Center
                                oStringFormat.Trimming = StringTrimming.None
                                e.Graphics.DrawString(oCell.Value.ToString, oCell.InheritedStyle.Font, New SolidBrush(oCell.InheritedStyle.ForeColor), New RectangleF(oColumnLefts(i), nTop, oColumnWidths(i), nHeight), oStringFormat)
                            End If




                        End If

                        'ElseIf oColumnTypes(i) Is GetType(DataGridViewButtonColumn) Then

                        '        oButton.Text = oCell.Value.ToString
                        '        oButton.Size = New Size(oColumnWidths(i), nHeight)
                        '        Dim oBitmap As New Bitmap(oButton.Width, oButton.Height)
                        '        oButton.DrawToBitmap(oBitmap, New Rectangle(0, 0, oBitmap.Width, oBitmap.Height))
                        '        e.Graphics.DrawImage(oBitmap, New Point(oColumnLefts(i), nTop))

                        '    ElseIf oColumnTypes(i) Is GetType(DataGridViewCheckBoxColumn) Then

                        '        oCheckbox.Size = New Size(14, 14)
                        '        oCheckbox.Checked = CType(oCell.Value, Boolean)
                        '        Dim oBitmap As New Bitmap(oColumnWidths(i), nHeight)
                        '        Dim oTempGraphics As Graphics = Graphics.FromImage(oBitmap)
                        '        oTempGraphics.FillRectangle(Brushes.White, New Rectangle(0, 0, oBitmap.Width, oBitmap.Height))
                        '        oCheckbox.DrawToBitmap(oBitmap, New Rectangle(CType((oBitmap.Width - oCheckbox.Width) / 2, Int32), CType((oBitmap.Height - oCheckbox.Height) / 2, Int32), oCheckbox.Width, oCheckbox.Height))
                        '        e.Graphics.DrawImage(oBitmap, New Point(oColumnLefts(i), nTop))

                        '    ElseIf oColumnTypes(i) Is GetType(DataGridViewComboBoxColumn) Then

                        '        oComboBox.Size = New Size(oColumnWidths(i), nHeight)
                        '        Dim oBitmap As New Bitmap(oComboBox.Width, oComboBox.Height)
                        '        oComboBox.DrawToBitmap(oBitmap, New Rectangle(0, 0, oBitmap.Width, oBitmap.Height))
                        '        e.Graphics.DrawImage(oBitmap, New Point(oColumnLefts(i), nTop))
                        '        e.Graphics.DrawString(oCell.Value.ToString, oCell.InheritedStyle.Font, New SolidBrush(oCell.InheritedStyle.ForeColor), New RectangleF(oColumnLefts(i) + 1, nTop, oColumnWidths(i) - 16, nHeight), oStringFormatComboBox)

                        '    ElseIf oColumnTypes(i) Is GetType(DataGridViewImageColumn) Then

                        '        Dim oCellSize As Rectangle = New Rectangle(oColumnLefts(i), nTop, oColumnWidths(i), nHeight)
                        '        Dim oImageSize As Size = CType(oCell.Value, Image).Size
                        '        e.Graphics.DrawImage(oCell.Value, New Rectangle(oColumnLefts(i) + CType(((oCellSize.Width - oImageSize.Width) / 2), Int32), nTop + CType(((oCellSize.Height - oImageSize.Height) / 2), Int32), CType(oCell.Value, Image).Width, CType(oCell.Value, Image).Height))

                        '    End If

                        e.Graphics.DrawRectangle(Pens.Black, New Rectangle(oColumnLefts(i), nTop, oColumnWidths(i), nHeight))

                        i += 1
                    End If
                Next

            End If

            nRowPos += 1
            nRowsPerPage += 1

        Loop

        DrawFooter(e, nRowsPerPage)

        e.HasMorePages = False

    End Sub

    Public Sub DrawFooter(ByVal e As System.Drawing.Printing.PrintPageEventArgs, ByVal RowsPerPage As Int32)

        Dim sPageNo As String = nPageNo.ToString + " / "

        'Creo el lapicero para dibujar
        Dim Lapiz As New Pen(Color.Black, 3.9F)

        If nPageNo = "1" Then

            lPageNo = Math.Ceiling((DataGridViewToPrint.Rows.Count) / RowsPerPage).ToString()
            sPageNo = nPageNo.ToString + " / " + lPageNo

        Else

            sPageNo = nPageNo.ToString + " / " + lPageNo

        End If

        'e.Graphics.DrawString("_________________________________________________", DataGridViewToPrint.Font, Brushes.Black, 250, 920)
        'e.Graphics.DrawString("AUTORIZA", DataGridViewToPrint.Font, Brushes.Black, 370, 935)


        'Dim newImage2 As Image = Image.FromFile("C:\logo\PIE DE PAGINA GRUPO SIEL.jpg")

        '' e.Graphics.DrawImage(logo, PosY, PosX)
        'e.Graphics.DrawImage(newImage2, 5, 995)

        Dim FOOT As Font
        Dim FOOT1 As Font
        Dim FOOT2 As Font


        FOOT = New Font("Arial", 10, FontStyle.Regular)
        FOOT1 = New Font("Arial", 12, FontStyle.Bold)
        FOOT2 = New Font("Arial", 10, FontStyle.Regular)


        ' e.Graphics.DrawString(, DataGridViewToPrint.Font, Brushes.Black, 20, 725)
        e.Graphics.DrawString("NOTAS: " & Variables.ObservacionesOrdenCompra, FOOT, Brushes.Black, 20, 725)

        e.Graphics.DrawString("Sin otro particular enviamos un cordial saludo.", FOOT, Brushes.Black, 20, 795)

        e.Graphics.DrawString("Atentamente", FOOT1, Brushes.Black, 20, 835)
        e.Graphics.DrawString("Lic. " & Variables.print_solicitante, FOOT1, Brushes.Black, 20, 865)
        e.Graphics.DrawString("DEPARTAMENTO DE COMPRAS", FOOT1, Brushes.Black, 20, 895)

        'e.Graphics.DrawString("_______________________", DataGridViewToPrint.Font, Brushes.Black, 185, 990)
        'e.Graphics.DrawString("Almacen/Embarques Recibe", GridFont, Brushes.Black, 210, 1010)

        'e.Graphics.DrawString("____________", DataGridViewToPrint.Font, Brushes.Black, 420, 990)
        'e.Graphics.DrawString("Chofer", GridFont, Brushes.Black, 460, 1010)

        'e.Graphics.DrawString("____________________", DataGridViewToPrint.Font, Brushes.Black, 565, 990)
        'e.Graphics.DrawString("Depto. de Vigilancia", GridFont, Brushes.Black, 595, 1010)


        'e.Graphics.DrawString("_________________________________________________", DataGridViewToPrint.Font, Brushes.Black, 250, 920)
        'e.Graphics.DrawString("AUTORIZA", DataGridViewToPrint.Font, Brushes.Black, 370, 935)


        Dim newImage2 As Image = Image.FromFile("C:\logo\PIE DE PAGINA GRUPO SIEL.jpg")

        ' e.Graphics.DrawImage(logo, PosY, PosX)
        e.Graphics.DrawImage(newImage2, 0, 1015)


        'e.Graphics.DrawString("Grupo SIEL", DataGridViewToPrint.Font, Brushes.Black, 370, 965)
        'e.Graphics.DrawRectangle(Lapiz, 25, 985, 747, 1) 'Folio
        'e.Graphics.DrawString("1° de Mayo No 803 Pte. Cd Madero, Tamps Email: gruposiel@prodigy.net.mx", DataGridViewToPrint.Font, Brushes.Black, 255, 995)
        'e.Graphics.DrawString("Tel: 833 215.6362                   www.gruposiel.com", DataGridViewToPrint.Font, Brushes.Black, 275, 1015)
        ' e.Graphics.DrawString("Pág. " & sPageNo, DataGridViewToPrint.Font, Brushes.Black, 650, 1000)




        '' Right Align - User Name
        'e.Graphics.DrawString(FooterComment, DataGridViewToPrint.Font, Brushes.Black, e.MarginBounds.Left + (e.MarginBounds.Width - e.Graphics.MeasureString(FooterComment, DataGridViewToPrint.Font, e.MarginBounds.Width).Width), e.MarginBounds.Top + e.MarginBounds.Height + 7)

        '' Left Align - Date/Time
        'e.Graphics.DrawString(Now.ToLongDateString + " " + Now.ToShortTimeString, DataGridViewToPrint.Font, Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Top + e.MarginBounds.Height + 7)

        '' Center - Page No. Info
        'e.Graphics.DrawString(sPageNo, DataGridViewToPrint.Font, Brushes.Black, e.MarginBounds.Left + (e.MarginBounds.Width - e.Graphics.MeasureString(sPageNo, DataGridViewToPrint.Font, e.MarginBounds.Width).Width) / 2, e.MarginBounds.Top + e.MarginBounds.Height + 7)

    End Sub
End Module

