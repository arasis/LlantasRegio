Imports System.Drawing.Printing
Module ImprimirKardex
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

        '  End If

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

                    ' Draw Header
                    'e.Graphics.DrawString(Header, New Font(DataGridViewToPrint.Font, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Top - e.Graphics.MeasureString(Header, New Font(DataGridViewToPrint.Font, FontStyle.Bold), e.MarginBounds.Width).Height - 13)
                    'e.Graphics.DrawString(Header, New Font(DataGridViewToPrint.Font, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Top - e.Graphics.MeasureString(Header, New Font(DataGridViewToPrint.Font, FontStyle.Bold), e.MarginBounds.Width).Height - 18)


                    ' Para imprimir imágenes
                    ' Create image.
                    ' Dim newImage As Image = Image.FromFile("C:\logo\logo varabal.jpg")

                    ' e.Graphics.DrawImage(logo, PosY, PosX)
                    'e.Graphics.DrawImage(newImage, 25, 20, 196, 134)

                    'segundo logo

                    Dim newImage2 As Image = Image.FromFile("C:\logo\SIEL.jpg")

                    ' e.Graphics.DrawImage(logo, PosY, PosX)
                    e.Graphics.DrawImage(newImage2, 315, 5, 186, 124)
                    'titulo del reporte
                    e.Graphics.DrawString(Variables.print_titulo_reporte, nombre_empresa, Brushes.Black, 320, 130)


                    'Dibujo los rectangulos
                    'e.Graphics.DrawRectangle(Lapiz, 25, 155, 132, 40) 'Folio
                    'e.Graphics.DrawRectangle(Lapiz, 25, 195, 132, 40) 'Prioridad
                    'e.Graphics.DrawRectangle(Lapiz, 25, 235, 132, 40) 'Fecha Entrega
                    ''*******************************************************
                    'e.Graphics.DrawRectangle(Lapiz, 157, 155, 615, 40)
                    'e.Graphics.DrawRectangle(Lapiz, 157, 195, 615, 40)
                    'e.Graphics.DrawRectangle(Lapiz, 157, 235, 615, 40)
                    '*******************************************************
                    e.Graphics.DrawRectangle(Lapiz, 25, 285, 750, 620)

                    '****************************************************************************************
                    '+ " " + Now.ToShortTimeString
                    ' e.Graphics.DrawString("Tampico, Tams., a " & Now.ToLongDateString & ".", headfont, Brushes.Black, 480, 180)
                    ''e.Graphics.DrawString(lblID.Text, headfont, Brushes.Black, 100, 80)

                    'e.Graphics.DrawString("Folio", headfont, Brushes.Black, 26, 156)
                    'e.Graphics.DrawString(Variables.print_id_documento, FONTDESCR, Brushes.Black, 26, 176)

                    e.Graphics.DrawString("FECHA: ", FONTDESCR, Brushes.Black, 26, 165)
                    e.Graphics.DrawString(Now.ToLongDateString, headfont, Brushes.Black, 100, 165)
                    e.Graphics.DrawString("FOLIO:", FONTDESCR, Brushes.Black, 565, 165)
                    e.Graphics.DrawString(Variables.print_id_documento, headfont, Brushes.Black, 695, 165)

                    e.Graphics.DrawRectangle(Lapiz2, 100, 185, 460, 1) 'proveedor
                    e.Graphics.DrawRectangle(Lapiz2, 635, 185, 130, 1) 'Folio

                    e.Graphics.DrawString("PROV O EMP:", FONTDESCR, Brushes.Black, 26, 200)
                    e.Graphics.DrawString(Variables.print_proveedor, headfont, Brushes.Black, 130, 200)

                    ' e.Graphics.DrawString("PERIODO:", FONTDESCR, Brushes.Black, 565, 200)
                    'e.Graphics.DrawString(Variables.PERIODO, headfont, Brushes.Black, 665, 200)

                    e.Graphics.DrawRectangle(Lapiz2, 100, 220, 632, 1) 'PROV O EMP
                    'e.Graphics.DrawRectangle(Lapiz2, 635, 220, 130, 1) 'PERIODO


                    e.Graphics.DrawString("FACTURA/SALIDA:", FONTDESCR, Brushes.Black, 26, 235)
                    e.Graphics.DrawString(Variables.REFER_FACTURA, headfont, Brushes.Black, 210, 235)

                    e.Graphics.DrawRectangle(Lapiz2, 195, 250, 160, 1) 'PERIODO
                    'e.Graphics.DrawString(Variables.printOC_fecha_entregas, FONTDESCR, Brushes.Black, 26, 255)

                    ''*****************************************************************************************

                    'e.Graphics.DrawString("Proveedor", headfont, Brushes.Black, 158, 156)
                    'e.Graphics.DrawString(Variables.print_proveedor, FONTDESCR, Brushes.Black, 158, 176)


                    ' e.Graphics.DrawString("______________________________________________________________", FONTDESCR, Brushes.Black, 56, 215)

                    'e.Graphics.DrawString("__________", FONTDESCR, Brushes.Black, 180, 215)


                    'e.Graphics.DrawString("Solicitante", headfont, Brushes.Black, 158, 235)
                    'e.Graphics.DrawString(Variables.print_solicitante, FONTDESCR, Brushes.Black, 158, 255)

                    ' Draw Columns
                    nTop = e.MarginBounds.Top + 255
                    i = 0
                    For Each oColumn As DataGridViewColumn In DataGridViewToPrint.Columns
                        If oColumn.Visible = True Then

                            If oColumn.Name = "Código" Then
                                oStringFormat = New StringFormat
                                oStringFormat.Alignment = StringAlignment.Center
                                oStringFormat.LineAlignment = StringAlignment.Center
                                oStringFormat.Trimming = StringTrimming.EllipsisCharacter

                                e.Graphics.FillRectangle(New SolidBrush(Drawing.Color.LightGray), New Rectangle(oColumnLefts(i), nTop, oColumnWidths(i), nHeight))
                                e.Graphics.DrawRectangle(Pens.Black, New Rectangle(oColumnLefts(i), nTop, oColumnWidths(i), nHeight))
                                e.Graphics.DrawString(oColumn.HeaderText, oColumn.InheritedStyle.Font, New SolidBrush(oColumn.InheritedStyle.ForeColor), New RectangleF(oColumnLefts(i), nTop, oColumnWidths(i), nHeight), oStringFormat)

                            End If

                            If oColumn.Name = "Articulo descripción" Then
                                oStringFormat = New StringFormat
                                oStringFormat.Alignment = StringAlignment.Near
                                oStringFormat.LineAlignment = StringAlignment.Center
                                oStringFormat.Trimming = StringTrimming.EllipsisCharacter

                                e.Graphics.FillRectangle(New SolidBrush(Drawing.Color.LightGray), New Rectangle(oColumnLefts(i), nTop, oColumnWidths(i), nHeight))
                                e.Graphics.DrawRectangle(Pens.Black, New Rectangle(oColumnLefts(i), nTop, oColumnWidths(i), nHeight))
                                e.Graphics.DrawString(oColumn.HeaderText, oColumn.InheritedStyle.Font, New SolidBrush(oColumn.InheritedStyle.ForeColor), New RectangleF(oColumnLefts(i), nTop, oColumnWidths(i), nHeight), oStringFormat)

                            End If

                            If oColumn.Name = "Cantidad" Then
                                oStringFormat = New StringFormat
                                oStringFormat.Alignment = StringAlignment.Center
                                oStringFormat.LineAlignment = StringAlignment.Center
                                oStringFormat.Trimming = StringTrimming.EllipsisCharacter

                                e.Graphics.FillRectangle(New SolidBrush(Drawing.Color.LightGray), New Rectangle(oColumnLefts(i), nTop, oColumnWidths(i), nHeight))
                                e.Graphics.DrawRectangle(Pens.Black, New Rectangle(oColumnLefts(i), nTop, oColumnWidths(i), nHeight))
                                e.Graphics.DrawString(oColumn.HeaderText, oColumn.InheritedStyle.Font, New SolidBrush(oColumn.InheritedStyle.ForeColor), New RectangleF(oColumnLefts(i), nTop, oColumnWidths(i), nHeight), oStringFormat)

                            End If
                            If oColumn.Name = "U.M." Then
                                oStringFormat = New StringFormat
                                oStringFormat.Alignment = StringAlignment.Center
                                oStringFormat.LineAlignment = StringAlignment.Center
                                oStringFormat.Trimming = StringTrimming.EllipsisCharacter

                                e.Graphics.FillRectangle(New SolidBrush(Drawing.Color.LightGray), New Rectangle(oColumnLefts(i), nTop, oColumnWidths(i), nHeight))
                                e.Graphics.DrawRectangle(Pens.Black, New Rectangle(oColumnLefts(i), nTop, oColumnWidths(i), nHeight))
                                e.Graphics.DrawString(oColumn.HeaderText, oColumn.InheritedStyle.Font, New SolidBrush(oColumn.InheritedStyle.ForeColor), New RectangleF(oColumnLefts(i), nTop, oColumnWidths(i), nHeight), oStringFormat)

                            End If
                            'If oColumn.Name = "P.Unitario" Then
                            '    oStringFormat = New StringFormat
                            '    oStringFormat.Alignment = StringAlignment.Center
                            '    oStringFormat.LineAlignment = StringAlignment.Center
                            '    oStringFormat.Trimming = StringTrimming.EllipsisCharacter

                            '    e.Graphics.FillRectangle(New SolidBrush(Drawing.Color.LightGray), New Rectangle(oColumnLefts(i), nTop, oColumnWidths(i), nHeight))
                            '    e.Graphics.DrawRectangle(Pens.Black, New Rectangle(oColumnLefts(i), nTop, oColumnWidths(i), nHeight))
                            '    e.Graphics.DrawString(oColumn.HeaderText, oColumn.InheritedStyle.Font, New SolidBrush(oColumn.InheritedStyle.ForeColor), New RectangleF(oColumnLefts(i), nTop, oColumnWidths(i), nHeight), oStringFormat)

                            'End If

                            'If oColumn.Name = "Importe" Then
                            '    oStringFormat = New StringFormat
                            '    oStringFormat.Alignment = StringAlignment.Center
                            '    oStringFormat.LineAlignment = StringAlignment.Center
                            '    oStringFormat.Trimming = StringTrimming.EllipsisCharacter

                            '    e.Graphics.FillRectangle(New SolidBrush(Drawing.Color.LightGray), New Rectangle(oColumnLefts(i), nTop, oColumnWidths(i), nHeight))
                            '    e.Graphics.DrawRectangle(Pens.Black, New Rectangle(oColumnLefts(i), nTop, oColumnWidths(i), nHeight))
                            '    e.Graphics.DrawString(oColumn.HeaderText, oColumn.InheritedStyle.Font, New SolidBrush(oColumn.InheritedStyle.ForeColor), New RectangleF(oColumnLefts(i), nTop, oColumnWidths(i), nHeight), oStringFormat)

                            'End If

                            'If oColumn.Name = "OC" Then
                            '    oStringFormat = New StringFormat
                            '    oStringFormat.Alignment = StringAlignment.Center
                            '    oStringFormat.LineAlignment = StringAlignment.Center
                            '    oStringFormat.Trimming = StringTrimming.EllipsisCharacter

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
                                oStringFormat.Alignment = StringAlignment.Near
                                oStringFormat.LineAlignment = StringAlignment.Center
                                oStringFormat.Trimming = StringTrimming.EllipsisCharacter
                                e.Graphics.DrawString(oCell.Value.ToString, oCell.InheritedStyle.Font, New SolidBrush(oCell.InheritedStyle.ForeColor), New RectangleF(oColumnLefts(i), nTop, oColumnWidths(i), nHeight), oStringFormat)
                            End If


                            If i = 2 Then
                                oStringFormat = New StringFormat
                                oStringFormat.Alignment = StringAlignment.Center
                                oStringFormat.LineAlignment = StringAlignment.Center
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

                            'If i = 3 Then
                            '    oStringFormat = New StringFormat
                            '    oStringFormat.Alignment = StringAlignment.Far
                            '    oStringFormat.LineAlignment = StringAlignment.Center
                            '    oStringFormat.Trimming = StringTrimming.EllipsisCharacter
                            '    e.Graphics.DrawString(oCell.Value.ToString, oCell.InheritedStyle.Font, New SolidBrush(oCell.InheritedStyle.ForeColor), New RectangleF(oColumnLefts(i), nTop, oColumnWidths(i), nHeight), oStringFormat)
                            'End If
                            'If i = 4 Then
                            '    oStringFormat = New StringFormat
                            '    oStringFormat.Alignment = StringAlignment.Far
                            '    oStringFormat.LineAlignment = StringAlignment.Center
                            '    oStringFormat.Trimming = StringTrimming.EllipsisCharacter
                            '    e.Graphics.DrawString(oCell.Value.ToString, oCell.InheritedStyle.Font, New SolidBrush(oCell.InheritedStyle.ForeColor), New RectangleF(oColumnLefts(i), nTop, oColumnWidths(i), nHeight), oStringFormat)
                            'End If
                            'If i = 5 Then
                            '    oStringFormat = New StringFormat
                            '    oStringFormat.Alignment = StringAlignment.Center
                            '    oStringFormat.LineAlignment = StringAlignment.Center
                            '    oStringFormat.Trimming = StringTrimming.EllipsisCharacter
                            '    e.Graphics.DrawString(oCell.Value.ToString, oCell.InheritedStyle.Font, New SolidBrush(oCell.InheritedStyle.ForeColor), New RectangleF(oColumnLefts(i), nTop, oColumnWidths(i), nHeight), oStringFormat)
                            'End If




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

        If nPageNo = "1" Then

            lPageNo = Math.Ceiling((DataGridViewToPrint.Rows.Count) / RowsPerPage).ToString()
            sPageNo = nPageNo.ToString + " / " + lPageNo

        Else

            sPageNo = nPageNo.ToString + " / " + lPageNo

        End If

        '**********************************************************************************************
        'e.Graphics.DrawString("_________________________________________________", DataGridViewToPrint.Font, Brushes.Black, 24, 985)
        'e.Graphics.DrawString("Autorizó", DataGridViewToPrint.Font, Brushes.Black, 160, 1000)

        'e.Graphics.DrawString("Pág. " & sPageNo, DataGridViewToPrint.Font, Brushes.Black, 650, 1000)
        '**********************************************************************************************

        e.Graphics.DrawString("PROV O EMP", DataGridViewToPrint.Font, Brushes.Black, 90, 945)
        e.Graphics.DrawString("ALMACEN", DataGridViewToPrint.Font, Brushes.Black, 370, 945)
        e.Graphics.DrawString("AUTORIZÓ", DataGridViewToPrint.Font, Brushes.Black, 625, 945)


        e.Graphics.DrawString(Variables.print_proveedor, DataGridViewToPrint.Font, Brushes.Black, 24, 985)
        e.Graphics.DrawString("_____________________________________", DataGridViewToPrint.Font, Brushes.Black, 24, 990)
        e.Graphics.DrawString("FIRMA", DataGridViewToPrint.Font, Brushes.Black, 110, 1005)

        e.Graphics.DrawString("_____________________________________", DataGridViewToPrint.Font, Brushes.Black, 285, 990)
        e.Graphics.DrawString("PERSONA INGRESA", DataGridViewToPrint.Font, Brushes.Black, 330, 1005)


        e.Graphics.DrawString("_____________________________________", DataGridViewToPrint.Font, Brushes.Black, 550, 990)
        e.Graphics.DrawString("PERSONA AUTORIZA", DataGridViewToPrint.Font, Brushes.Black, 585, 1005)


        '' Right Align - User Name
        'e.Graphics.DrawString(FooterComment, DataGridViewToPrint.Font, Brushes.Black, e.MarginBounds.Left + (e.MarginBounds.Width - e.Graphics.MeasureString(FooterComment, DataGridViewToPrint.Font, e.MarginBounds.Width).Width), e.MarginBounds.Top + e.MarginBounds.Height + 7)

        '' Left Align - Date/Time
        'e.Graphics.DrawString(Now.ToLongDateString + " " + Now.ToShortTimeString, DataGridViewToPrint.Font, Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Top + e.MarginBounds.Height + 7)

        '' Center - Page No. Info
        'e.Graphics.DrawString(sPageNo, DataGridViewToPrint.Font, Brushes.Black, e.MarginBounds.Left + (e.MarginBounds.Width - e.Graphics.MeasureString(sPageNo, DataGridViewToPrint.Font, e.MarginBounds.Width).Width) / 2, e.MarginBounds.Top + e.MarginBounds.Height + 7)

    End Sub
End Module

