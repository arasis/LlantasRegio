Imports System.Data.SqlClient
Imports System.Drawing.Drawing2D

Public Class frmReporteXML
    '*****************************************XML
    Dim sFile As String
    Dim sName As String
    Dim sExt As String
    Dim sPath As String
    Dim pos As Integer = 0
    Private table_xml As System.Data.DataTable
    Private row_xml As System.Data.DataRow
    '*************************************************************
    Private tableXML As System.Data.DataTable
    Private rowXML As System.Data.DataRow
    Dim consulta_XML As String
    Private Sub frmReporteXML_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carga_proveedor()
        GRID()
    End Sub
    Sub GRID()
        'GridXML_

        GridXML_.ColumnHeadersDefaultCellStyle.Font = New Font("Tahoma", 9, FontStyle.Bold, GraphicsUnit.Point)
        GridXML_.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.ControlDark
        GridXML_.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        GridXML_.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        GridXML_.DefaultCellStyle.Font = New Font("Tahoma", 8, FontStyle.Regular, GraphicsUnit.Point)
        GridXML_.DefaultCellStyle.BackColor = Color.Empty
        GridXML_.AlternatingRowsDefaultCellStyle.BackColor = SystemColors.ControlLight
        GridXML_.CellBorderStyle = DataGridViewCellBorderStyle.Single
        GridXML_.GridColor = SystemColors.ControlDarkDark
        GridXML_.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)


    End Sub
    '*********************BOTONES REDONDOS*******************************
    Private Sub btnExporaExvelXML_Paint(sender As Object, e As PaintEventArgs) Handles btnExporaExvelXML.Paint
        'podemos mejorar el aspecto del borde redondeado aplicando antialias
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias
        'creamos un objeto de la clase GraphicsPath
        Dim figura As GraphicsPath = New GraphicsPath
        'manipulando las variables que se corresponden con los puntos x e y, el ancho y el alto de la figura, podemos variar su aspecto
        Dim x, y, ancho, alto As Integer
        'anchura y altura de la figura (círculo en este caso)
        ancho = 110
        alto = 110
        'posiciones x e y de la figura (centrada en el control PictureBox)
        x = (btnExporaExvelXML.Width - ancho) / 2
        y = (btnExporaExvelXML.Height - alto) / 2
        'usamos el método AddEllipse para conseguir la figura de un círculo,
        'que aplicaremos sobre el control PictureBox.
        figura.AddEllipse(New Rectangle(x, y, ancho, alto))
        'en el control PictureBox creamos una región que se corresponde
        'con la figura del objeto GraphicsPath
        btnExporaExvelXML.Region = New Region(figura)
    End Sub
    Private Sub btnImprimirReporteXML_Paint(sender As Object, e As PaintEventArgs) Handles btnImprimirReporteXML.Paint
        'podemos mejorar el aspecto del borde redondeado aplicando antialias
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias
        'creamos un objeto de la clase GraphicsPath
        Dim figura As GraphicsPath = New GraphicsPath
        'manipulando las variables que se corresponden con los puntos x e y, el ancho y el alto de la figura, podemos variar su aspecto
        Dim x, y, ancho, alto As Integer
        'anchura y altura de la figura (círculo en este caso)
        ancho = 110
        alto = 110
        'posiciones x e y de la figura (centrada en el control PictureBox)
        x = (btnImprimirReporteXML.Width - ancho) / 2
        y = (btnImprimirReporteXML.Height - alto) / 2
        'usamos el método AddEllipse para conseguir la figura de un círculo,
        'que aplicaremos sobre el control PictureBox.
        figura.AddEllipse(New Rectangle(x, y, ancho, alto))
        'en el control PictureBox creamos una región que se corresponde
        'con la figura del objeto GraphicsPath
        btnImprimirReporteXML.Region = New Region(figura)
    End Sub
    Sub carga_proveedor()

        cmbProveedorXML.Items.Clear()

        SQL = "SELECT  EmiNombre  from   ARASIS_XML_ENCABEZADO  group by EmiNombre order by EmiNombre asc "

        Dim da As New SqlDataAdapter(SQL, DB.obtenerConexionDB)
        Dim ds As New DataSet

        Try
            da.Fill(ds)

            If ds.Tables(0).Rows.Count = 0 Then
                Exit Sub
            Else

                Dim i As Integer
                cmbProveedorXML.Items.Add("")

                For i = 0 To ds.Tables(0).Rows.Count - 1
                    cmbProveedorXML.Items.Add(ds.Tables(0).Rows(i)(0).ToString())
                Next

            End If

        Catch ex As Exception
            MsgBox("ERROR: " & ex.Message, MsgBoxStyle.Critical)
            Exit Sub
        End Try


    End Sub
    Private Sub chkRangoFechasXML_CheckedChanged(sender As Object, e As EventArgs) Handles chkRangoFechasXML.CheckedChanged
        If chkRangoFechasXML.Checked = True Then
            GroupRangoFechasXML.Enabled = True
        End If
        If chkRangoFechasXML.Checked = False Then
            GroupRangoFechasXML.Enabled = False
        End If
    End Sub
    '******************************BOTON BUSQUEDA********************************************************
    Private Sub btrnBuscarXML_Click(sender As Object, e As EventArgs) Handles btrnBuscarXML.Click
        CREA_SCRIPT_XM()
        cmbProveedorXML.Text = ""
        txtFacturaXML.Text = ""
        chkRangoFechasXML.Checked = False
    End Sub
    Sub CREA_SCRIPT_XM()

        Dim factura_xml As String = ""
        Dim proveedor_xml As String = ""
        Dim fecha_registro As String = ""

        consulta_XML = ""
        lblTotalRegistrolXML.Text = 0

        If txtFacturaXML.Text <> "" Then
            factura_xml = " AND folio  = '" & txtFacturaXML.Text & "' "
        End If

        If cmbProveedorXML.Text <> "" Then
            proveedor_xml = " AND EmiNombre  = '" & cmbProveedorXML.Text & "' "

            If factura_xml <> "" Then
                proveedor_xml = " AND EmiNombre  = '" & cmbProveedorXML.Text & "' "
            End If

        End If

        If chkRangoFechasXML.Checked = True Then

            fecha_registro = " AND fecha_registro_xml  between '" & Format(dtpFechaIncialXML.Value, "yyyyMMdd") & " 00:00:00" & "' AND '" & Format(dtpFechaFinalXML.Value, "yyyyMMdd") & " 23:59:59" & "' "

            If factura_xml <> "" Then
                fecha_registro = "AND  fecha_registro_xml  between '" & Format(dtpFechaIncialXML.Value, "yyyyMMdd") & " 00:00:00" & "' AND '" & Format(dtpFechaFinalXML.Value, "yyyyMMdd") & " 23:59:59" & "' "
            End If

            If proveedor_xml <> "" Then
                fecha_registro = "AND  fecha_registro_xml  between '" & Format(dtpFechaIncialXML.Value, "yyyyMMdd") & " 00:00:00" & "' AND '" & Format(dtpFechaFinalXML.Value, "yyyyMMdd") & " 23:59:59" & "' "
            End If

        End If

        If factura_xml = "" And proveedor_xml = "" And fecha_registro = "" Then

            consulta_XML = "SELECT   id " &
                                   ", folio " &
                                   ", TipodeComprobante " &
                                   ", Moneda" &
                                   ", subTotal " &
                                   ", total " &
                                   ", Emirfc " &
                                   ", EmiNombre " &
                                   ", TotalImpuestosTrasladados " &
                                   ", TotalImpuestosRetenidos " &
                                   ", RetencionesTotalImporte " &
                                   ", RetencionesTotalImpuesto " &
                                   ", TrasladosTotalImporte " &
                                   ", TrasladosTotalTasaOCuota " &
                                   ", TrasladosTotalTipoFactor " &
                                   ", TrasladosTotalImpuesto " &
                                   ", fecha_registro_xml " &
                                   ", UUID,serie,AcuseCancelacion,status_xml " &
                                " from ARASIS_XML_ENCABEZADO WHERE [status_xml] in ('1','0')  order by id desc "
        Else

            consulta_XML = "SELECT  id " &
                                   ", folio  " &
                                   ", TipodeComprobante  " &
                                   ", Moneda " &
                                   ", subTotal  " &
                                   ", total  " &
                                   ", Emirfc  " &
                                   ", EmiNombre " &
                                   ", TotalImpuestosTrasladados " &
                                   ", TotalImpuestosRetenidos " &
                                   ", RetencionesTotalImporte " &
                                   ", RetencionesTotalImpuesto " &
                                   ", TrasladosTotalImporte " &
                                   ", TrasladosTotalTasaOCuota " &
                                   ", TrasladosTotalTipoFactor " &
                                   ", TrasladosTotalImpuesto " &
                                   ", fecha_registro_xml " &
                                   ", UUID,serie,AcuseCancelacion,status_xml " &
                                " from ARASIS_XML_ENCABEZADO WHERE [status_xml] in ('1','0') " & factura_xml & " " & proveedor_xml & " " & fecha_registro & " order by id desc "

        End If

        BUSQUEDA_XML()
    End Sub
    Sub BUSQUEDA_XML()


        Dim precio_unitario As Double
        Dim importe As Double
        Dim impuesto As Double



        Me.GridXML_.DataSource = Nothing

        If consulta_XML <> "" Then

            SQL = consulta_XML

            Dim da As New SqlDataAdapter(SQL, DB.obtenerConexionDB)
            Dim ds As New DataSet
            Try
                da.Fill(ds)

                If ds.Tables(0).Rows.Count = 0 Then
                    MsgBox("Registro No Encontrado, Verifique", MsgBoxStyle.Information)
                    Me.GridXML_.DataSource = Nothing
                    lblTotalRegistrolXML.Text = "0"


                Else
                    table_xml = New System.Data.DataTable()
                    table_xml.Columns.Add("Id", GetType(System.String))
                    table_xml.Columns.Add("Serie", GetType(System.String))
                    table_xml.Columns.Add("Folio", GetType(System.String))
                    table_xml.Columns.Add("TipodeComprobante", GetType(System.String))
                    table_xml.Columns.Add("RFC", GetType(System.String))
                    table_xml.Columns.Add("Proveedor", GetType(System.String))
                    table_xml.Columns.Add("Moneda", GetType(System.String))
                    table_xml.Columns.Add("SubTotal", GetType(System.String))
                    table_xml.Columns.Add("Impuesto", GetType(System.String))
                    table_xml.Columns.Add("Total", GetType(System.String))
                    table_xml.Columns.Add("Fecha Registro", GetType(System.String))
                    table_xml.Columns.Add("UUID", GetType(System.String))
                    table_xml.Columns.Add("AcuseCancelacion", GetType(System.String))
                    table_xml.Columns.Add("Status", GetType(System.String))

                    lblTotalRegistrolXML.Text = ds.Tables(0).Rows.Count
                    barra.Value = 0
                    barra.Minimum = 0
                    barra.Maximum = ds.Tables(0).Rows.Count

                    For i As Integer = 0 To ds.Tables(0).Rows.Count - 1

                        barra.Value = barra.Value + 1

                        row_xml = table_xml.NewRow()

                        row_xml("Id") = ds.Tables(0).Rows(i)(0).ToString
                        row_xml("Serie") = ds.Tables(0).Rows(i)(18).ToString
                        row_xml("Folio") = ds.Tables(0).Rows(i)(1).ToString
                        row_xml("TipodeComprobante") = ds.Tables(0).Rows(i)(2).ToString
                        row_xml("RFC") = ds.Tables(0).Rows(i)(6).ToString
                        row_xml("Proveedor") = ds.Tables(0).Rows(i)(7).ToString
                        row_xml("Moneda") = ds.Tables(0).Rows(i)(3).ToString


                        precio_unitario = ds.Tables(0).Rows(i)(4).ToString
                        importe = ds.Tables(0).Rows(i)(5).ToString

                        Dim impuesto_tem As String = ds.Tables(0).Rows(i)(12).ToString

                        If impuesto_tem <> "" Then
                            impuesto = impuesto_tem
                        End If




                        row_xml("SubTotal") = Format(precio_unitario, "$ ###,###,###.#0")
                        row_xml("Impuesto") = Format(impuesto, "$ ###,###,###.#0")
                        row_xml("Total") = Format(importe, "$ ###,###,###.#0")

                        row_xml("Fecha Registro") = ds.Tables(0).Rows(i)(16).ToString
                        row_xml("UUID") = ds.Tables(0).Rows(i)(17).ToString
                        row_xml("AcuseCancelacion") = ds.Tables(0).Rows(i)(19).ToString
                        row_xml("Status") = ds.Tables(0).Rows(i)(20).ToString


                        table_xml.Rows.Add(row_xml)

                        Me.GridXML_.DataSource = table_xml

                    Next
                    color_status()
                    GridXML_.Columns(0).Visible = False    'Id
                    GridXML_.Columns(1).Width = 60    'Serie 
                    GridXML_.Columns(2).Width = 65    'Folio 
                    GridXML_.Columns(3).Width = 140   'TipodeComprobante
                    GridXML_.Columns(4).Width = 120   'RFC
                    GridXML_.Columns(5).Width = 250   'Proveedor
                    GridXML_.Columns(6).Width = 90   'Moneda
                    GridXML_.Columns(7).Width = 120   'SubTotal
                    GridXML_.Columns(8).Width = 120   'Impuesto
                    GridXML_.Columns(9).Width = 120   'Total
                    GridXML_.Columns(10).Width = 150   'Fecha Registro
                    GridXML_.Columns(11).Width = 250   'UUID
                    GridXML_.Columns(12).Width = 250   'AcuseCancelacion
                    GridXML_.Columns(13).Visible = False   'status


                    GridXML_.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter
                    GridXML_.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
                    GridXML_.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
                    GridXML_.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
                    GridXML_.Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter

                    ' GridXML_.Columns("Total").DefaultCellStyle.BackColor = Color.YellowGreen


                    '   LIMPIA()
                End If

            Catch ex As Exception
                MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical)
                Exit Sub
            End Try
        End If
    End Sub
    Sub color_status()

        If GridXML_.RowCount > 0 Then

            For Each Row As DataGridViewRow In GridXML_.Rows

                If Row.Cells("Status").Value = "0" Then
                    Row.DefaultCellStyle.BackColor = Color.Red
                    Row.DefaultCellStyle.ForeColor = Color.White
                End If
            Next

        End If
    End Sub
    Private Sub GridXML__CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GridXML_.CellContentClick

    End Sub
    Private Sub GridXML__CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles GridXML_.CellDoubleClick
        Variables.ID_FOLIO_XML = GridXML_.Item(0, GridXML_.CurrentRow.Index).Value
        frmKardexXML.ShowDialog()
    End Sub


    '******************************BOTON IMPRIMIR********************************************************
    Private Sub btnImprimirReporteXML_Click(sender As Object, e As EventArgs) Handles btnImprimirReporteXML.Click
        If MsgBox("¿ Desea Imprimir el Reporte ?", MsgBoxStyle.YesNo, "eFactura33") = MsgBoxResult.Yes Then

            Variables.print_titulo_reporte = "Reporte XML"

            Dim encabezdo As String

            encabezdo = "eFactura33"

            ImprimirReportes.StartPrint(GridXML_, False, True, encabezdo, "eFactura33")

        End If
    End Sub
    '******************************BOTON EXPORTA EXCEL********************************************************
    Private Sub btnExporaExvelXML_Click(sender As Object, e As EventArgs) Handles btnExporaExvelXML.Click
        If MsgBox("¿ Desea Exportar a Excel los Registro ?", MsgBoxStyle.YesNo, "eFactura33") = MsgBoxResult.Yes Then
            GridAExcel(GridXML_)
        End If
    End Sub
    Function GridAExcel(ByVal ElGrid As DataGridView) As Boolean

        'Creamos las variables
        Dim exApp As New Microsoft.Office.Interop.Excel.Application
        Dim exLibro As Microsoft.Office.Interop.Excel.Workbook
        Dim exHoja As Microsoft.Office.Interop.Excel.Worksheet

        Try
            'Añadimos el Libro al programa, y la hoja al libro
            exLibro = exApp.Workbooks.Add
            exHoja = exLibro.Worksheets.Add()

            ' ¿Cuantas columnas y cuantas filas?
            Dim NCol As Integer = ElGrid.ColumnCount
            Dim NRow As Integer = ElGrid.RowCount

            'Aqui recorremos todas las filas, y por cada fila todas las columnas y vamos escribiendo.

            For i As Integer = 1 To NCol
                exHoja.Cells.Item(1, i) = ElGrid.Columns(i - 1).Name.ToString
                'exHoja.Cells.Item(1, i).HorizontalAlignment = 3
            Next

            barra.Visible = True
            barra.Value = 0
            barra.Minimum = 0
            barra.Maximum = NRow


            For Fila As Integer = 0 To NRow - 1
                For Col As Integer = 0 To NCol - 1
                    exHoja.Cells.Item(Fila + 2, Col + 1) = ElGrid.Rows(Fila).Cells(Col).Value
                Next
                barra.Value = barra.Value + 1
            Next
            'Titulo en negrita, Alineado al centro y que el tamaño de la columna seajuste al texto
            exHoja.Rows.Item(1).Font.Bold = 1
            exHoja.Rows.Item(1).HorizontalAlignment = 3
            exHoja.Columns.AutoFit()


            'Aplicación visible
            exApp.Application.Visible = True

            exHoja = Nothing
            exLibro = Nothing
            exApp = Nothing

            MsgBox("Reporte Exportado Correctamente", MsgBoxStyle.Information)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al exportar a Excel")

            Return False
        End Try

        Return True

    End Function

    Private Sub TxtFacturaXML_TextChanged(sender As Object, e As EventArgs) Handles txtFacturaXML.TextChanged

    End Sub
End Class