Imports System.Data.SqlClient
Imports System.IO

Public Class frmConsultaFacturas
    '*********MODULO CONSULTA DOCUMENTOS************************************
    Private table_CD As System.Data.DataTable
    Private row_CD As System.Data.DataRow
    Dim idDoc As String
    Dim nombre_archivo As String
    Dim extension As String
    Dim ruta_archivo As String
    Private Sub frmConsultaFacturas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub txtRFC_CD_TextChanged(sender As Object, e As EventArgs) Handles txtRFC_CD.TextChanged
        If txtRFC_CD.Text <> "" Then

            SQL = "SELECT id " &
                   ",folio " &
                   ",version " &
                   ",TipodeComprobante " &
                   ",Emirfc " &
                   ",Receprfc " &
                   ",Fecha " &
                   ",proceso_status " &
                   ",proceso_fecha " &
                   ",enviado_status " &
                   ",enviado_fecha " &
                   ",recibido_status " &
                   ",recibido_fecha " &
                   ",asig_pago_status " &
                   ",asig_pago_fecha " &
                   ",fecha_pago,orden_compra " &
                   ",EmiNombre,acuseSat " &
               "FROM dw_xml_encabezado " &
              "WHERE proceso_status = '1' " &
                "AND enviado_status = '1' " &
                "AND recibido_status = '1' " &
                "AND Emirfc like '%" & txtRFC_CD.Text & "%' "

            Dim da As New SqlDataAdapter(SQL, DB.obtenerConexionDB)
            Dim ds As New DataSet

            Try
                da.Fill(ds)

                If ds.Tables(0).Rows.Count = 0 Then
                    ' MsgBox("Registro No Encontrado, Verifique", MsgBoxStyle.Information)
                    Me.Grid_CD.DataSource = Nothing

                    lblTotalRegistros_CD.Text = "0"

                Else
                    table_CD = New System.Data.DataTable()
                    table_CD.Columns.Add("Id", GetType(System.String))
                    table_CD.Columns.Add("Folio", GetType(System.String))
                    table_CD.Columns.Add("Versión", GetType(System.String))
                    table_CD.Columns.Add("Comprobante", GetType(System.String))
                    table_CD.Columns.Add("Razón Social", GetType(System.String))
                    table_CD.Columns.Add("Emisor", GetType(System.String))
                    table_CD.Columns.Add("Receptor", GetType(System.String))
                    table_CD.Columns.Add("Orden Compra", GetType(System.String))
                    table_CD.Columns.Add("Fecha", GetType(System.String))
                    table_CD.Columns.Add("Fecha Pago", GetType(System.String))
                    table_CD.Columns.Add("Acuse SAT", GetType(System.String))


                    lblTotalRegistros_CD.Text = ds.Tables(0).Rows.Count

                    For i As Integer = 0 To ds.Tables(0).Rows.Count - 1

                        row_CD = table_CD.NewRow()
                        row_CD("Id") = ds.Tables(0).Rows(i)(0).ToString
                        row_CD("Folio") = ds.Tables(0).Rows(i)(1).ToString
                        row_CD("Versión") = ds.Tables(0).Rows(i)(2).ToString
                        row_CD("Comprobante") = ds.Tables(0).Rows(i)(3).ToString
                        row_CD("Emisor") = ds.Tables(0).Rows(i)(4).ToString
                        row_CD("Receptor") = ds.Tables(0).Rows(i)(5).ToString
                        row_CD("Fecha") = ds.Tables(0).Rows(i)(6).ToString
                        row_CD("Orden Compra") = ds.Tables(0).Rows(i)(16).ToString
                        row_CD("Razón Social") = ds.Tables(0).Rows(i)(17).ToString
                        row_CD("Fecha Pago") = ds.Tables(0).Rows(i)(15).ToString
                        row_CD("Acuse SAT") = ds.Tables(0).Rows(i)(18).ToString

                        table_CD.Rows.Add(row_CD)

                        Me.Grid_CD.DataSource = table_CD

                    Next

                    Grid_CD.Columns(0).Width = 35  'Id
                    Grid_CD.Columns(1).Width = 90  'Folio
                    Grid_CD.Columns(2).Width = 60  'Versión
                    Grid_CD.Columns(3).Width = 100 'Comprobante
                    Grid_CD.Columns(4).Width = 350 'Razón Social 
                    Grid_CD.Columns(5).Width = 120 'Emisor 
                    Grid_CD.Columns(6).Width = 120 'Receptor 
                    Grid_CD.Columns(7).Width = 120 'Fecha 
                    Grid_CD.Columns(8).Width = 120 'Orden Compra
                    Grid_CD.Columns(9).Width = 120 'Fecha Pago"
                    Grid_CD.Columns(10).Width = 160 'Acuse SAT"
                End If

            Catch ex As Exception
                MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical)
                Exit Sub
            End Try
        End If
    End Sub

    Private Sub txtProveedor_CD_TextChanged(sender As Object, e As EventArgs) Handles txtProveedor_CD.TextChanged
        If txtProveedor_CD.Text <> "" Then

            SQL = "SELECT id " &
                   ",folio " &
                   ",version " &
                   ",TipodeComprobante " &
                   ",Emirfc " &
                   ",Receprfc " &
                   ",Fecha " &
                   ",proceso_status " &
                   ",proceso_fecha " &
                   ",enviado_status " &
                   ",enviado_fecha " &
                   ",recibido_status " &
                   ",recibido_fecha " &
                   ",asig_pago_status " &
                   ",asig_pago_fecha " &
                   ",fecha_pago,orden_compra " &
                   ",EmiNombre,acuseSat " &
               "FROM dw_xml_encabezado " &
              "WHERE proceso_status = '1' " &
                "AND enviado_status = '1' " &
                "AND recibido_status = '1' " &
                "AND Emirfc like '%" & txtProveedor_CD.Text & "%' "

            Dim da As New SqlDataAdapter(SQL, DB.obtenerConexionDB)
            Dim ds As New DataSet

            Try
                da.Fill(ds)

                If ds.Tables(0).Rows.Count = 0 Then
                    ' MsgBox("Registro No Encontrado, Verifique", MsgBoxStyle.Information)
                    Me.Grid_CD.DataSource = Nothing

                    lblTotalRegistros_CD.Text = "0"

                Else
                    table_CD = New System.Data.DataTable()
                    table_CD.Columns.Add("Id", GetType(System.String))
                    table_CD.Columns.Add("Folio", GetType(System.String))
                    table_CD.Columns.Add("Versión", GetType(System.String))
                    table_CD.Columns.Add("Comprobante", GetType(System.String))
                    table_CD.Columns.Add("Razón Social", GetType(System.String))
                    table_CD.Columns.Add("Emisor", GetType(System.String))
                    table_CD.Columns.Add("Receptor", GetType(System.String))
                    table_CD.Columns.Add("Orden Compra", GetType(System.String))
                    table_CD.Columns.Add("Fecha", GetType(System.String))
                    table_CD.Columns.Add("Fecha Pago", GetType(System.String))
                    table_CD.Columns.Add("Acuse SAT", GetType(System.String))


                    lblTotalRegistros_CD.Text = ds.Tables(0).Rows.Count

                    For i As Integer = 0 To ds.Tables(0).Rows.Count - 1

                        row_CD = table_CD.NewRow()
                        row_CD("Id") = ds.Tables(0).Rows(i)(0).ToString
                        row_CD("Folio") = ds.Tables(0).Rows(i)(1).ToString
                        row_CD("Versión") = ds.Tables(0).Rows(i)(2).ToString
                        row_CD("Comprobante") = ds.Tables(0).Rows(i)(3).ToString
                        row_CD("Emisor") = ds.Tables(0).Rows(i)(4).ToString
                        row_CD("Receptor") = ds.Tables(0).Rows(i)(5).ToString
                        row_CD("Fecha") = ds.Tables(0).Rows(i)(6).ToString
                        row_CD("Orden Compra") = ds.Tables(0).Rows(i)(16).ToString
                        row_CD("Razón Social") = ds.Tables(0).Rows(i)(17).ToString
                        row_CD("Fecha Pago") = ds.Tables(0).Rows(i)(15).ToString
                        row_CD("Acuse SAT") = ds.Tables(0).Rows(i)(18).ToString

                        table_CD.Rows.Add(row_CD)

                        Me.Grid_CD.DataSource = table_CD

                    Next

                    Grid_CD.Columns(0).Width = 35  'Id
                    Grid_CD.Columns(1).Width = 90  'Folio
                    Grid_CD.Columns(2).Width = 60  'Versión
                    Grid_CD.Columns(3).Width = 100 'Comprobante
                    Grid_CD.Columns(4).Width = 350 'Razón Social 
                    Grid_CD.Columns(5).Width = 120 'Emisor 
                    Grid_CD.Columns(6).Width = 120 'Receptor 
                    Grid_CD.Columns(7).Width = 120 'Fecha 
                    Grid_CD.Columns(8).Width = 120 'Orden Compra
                    Grid_CD.Columns(9).Width = 120 'Fecha Pago"
                    Grid_CD.Columns(10).Width = 160 'Acuse SAT"
                End If

            Catch ex As Exception
                MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical)
                Exit Sub
            End Try
        End If
    End Sub

    Private Sub btnBuscaLista_CD_Click(sender As Object, e As EventArgs) Handles btnBuscaLista_CD.Click
        SQL = "SELECT id " &
                   ",folio " &
                   ",version " &
                   ",TipodeComprobante " &
                   ",Emirfc " &
                   ",Receprfc " &
                   ",Fecha " &
                   ",proceso_status " &
                   ",proceso_fecha " &
                   ",enviado_status " &
                   ",enviado_fecha " &
                   ",recibido_status " &
                   ",recibido_fecha " &
                   ",asig_pago_status " &
                   ",asig_pago_fecha " &
                   ",fecha_pago " &
                   ",orden_compra " &
                   ",EmiNombre " &
                   ",EmiNombre " &
                   ",[Moneda] " &
                   ",[subTotal] " &
                   ",[total] " &
                   ",[UUID] " &
               "FROM [ARASIS_XML_ENCABEZADO] " &
              "WHERE [status_xml] = '1' "

        Dim da As New SqlDataAdapter(SQL, DB.obtenerConexionDB)
        Dim ds As New DataSet

        Try
            da.Fill(ds)

            If ds.Tables(0).Rows.Count = 0 Then
                ' MsgBox("Registro No Encontrado, Verifique", MsgBoxStyle.Information)
                Me.Grid_CD.DataSource = Nothing

                lblTotalRegistros_CD.Text = "0"

            Else
                table_CD = New System.Data.DataTable()
                table_CD.Columns.Add("Id", GetType(System.String))
                table_CD.Columns.Add("Folio", GetType(System.String))
                table_CD.Columns.Add("Versión", GetType(System.String))
                table_CD.Columns.Add("Comprobante", GetType(System.String))
                table_CD.Columns.Add("Razón Social", GetType(System.String))
                table_CD.Columns.Add("Emisor", GetType(System.String))
                table_CD.Columns.Add("Receptor", GetType(System.String))
                table_CD.Columns.Add("Orden Compra", GetType(System.String))
                table_CD.Columns.Add("Fecha", GetType(System.String))
                table_CD.Columns.Add("Fecha Pago", GetType(System.String))
                'table_CD.Columns.Add("Acuse SAT", GetType(System.String))

                table_CD.Columns.Add("UUID", GetType(System.String))
                table_CD.Columns.Add("Importe", GetType(System.String))
                table_CD.Columns.Add("Moneda", GetType(System.String))
                'table_CD.Columns.Add("FechaFactura", GetType(System.String))



                lblTotalRegistros_CD.Text = ds.Tables(0).Rows.Count

                For i As Integer = 0 To ds.Tables(0).Rows.Count - 1

                    row_CD = table_CD.NewRow()
                    row_CD("Id") = ds.Tables(0).Rows(i)(0).ToString
                    row_CD("Folio") = ds.Tables(0).Rows(i)(1).ToString
                    row_CD("Versión") = ds.Tables(0).Rows(i)(2).ToString
                    row_CD("Comprobante") = ds.Tables(0).Rows(i)(3).ToString
                    row_CD("Emisor") = ds.Tables(0).Rows(i)(4).ToString
                    row_CD("Receptor") = ds.Tables(0).Rows(i)(5).ToString
                    row_CD("Fecha") = ds.Tables(0).Rows(i)(6).ToString
                    row_CD("Orden Compra") = ds.Tables(0).Rows(i)(16).ToString
                    row_CD("Razón Social") = ds.Tables(0).Rows(i)(17).ToString
                    row_CD("Fecha Pago") = ds.Tables(0).Rows(i)(15).ToString
                    'row_CD("Acuse SAT") = ds.Tables(0).Rows(i)(18).ToString

                    row_CD("UUID") = ds.Tables(0).Rows(i)(22).ToString
                    row_CD("Importe") = ds.Tables(0).Rows(i)(21).ToString
                    row_CD("Moneda") = ds.Tables(0).Rows(i)(19).ToString
                    'row_CD("FechaFactura") = ds.Tables(0).Rows(i)(6).ToString




                    table_CD.Rows.Add(row_CD)

                    Me.Grid_CD.DataSource = table_CD

                Next

                Grid_CD.Columns(0).Width = 35  'Id
                Grid_CD.Columns(1).Width = 90  'Folio
                Grid_CD.Columns(2).Width = 60  'Versión
                Grid_CD.Columns(3).Width = 100 'Comprobante
                Grid_CD.Columns(4).Width = 350 'Razón Social 
                Grid_CD.Columns(5).Width = 120 'Emisor 
                Grid_CD.Columns(6).Width = 120 'Receptor 
                Grid_CD.Columns(7).Width = 120 'Fecha 
                Grid_CD.Columns(8).Width = 120 'Orden Compra
                Grid_CD.Columns(9).Width = 120 'Fecha Pago"
                ' Grid_CD.Columns(10).Width = 160 'Acuse SAT"
            End If

        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical)
            Exit Sub
        End Try

    End Sub

    Private Sub Grid_CD_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grid_CD.CellContentClick

    End Sub

    Private Sub Grid_CD_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grid_CD.CellDoubleClick
        lblId_CD.Text = ""
        lblRazonSocial_CD.Text = ""
        lblRfcEmisor_CD.Text = ""
        lblRfcReceptor_CD.Text = ""
        lblOrdenCompra_CD.Text = ""
        lblFechaPago_Consulta.Text = ""
        lblAcuseSAt.Text = ""

        lblcFECHAFACTURA.Text = ""
        lblcFOLIO.Text = ""
        lblcIMPORTE.Text = ""
        lblcMONEDA.Text = ""
        lblcUUID.Text = ""





        'table_CD.Columns.Add("Id", GetType(System.String))
        'table_CD.Columns.Add("Folio", GetType(System.String))
        'table_CD.Columns.Add("Versión", GetType(System.String))
        'table_CD.Columns.Add("Comprobante", GetType(System.String))
        'table_CD.Columns.Add("Razón Social", GetType(System.String))
        'table_CD.Columns.Add("Emisor", GetType(System.String))
        'table_CD.Columns.Add("Receptor", GetType(System.String))
        'table_CD.Columns.Add("Orden Compra", GetType(System.String))
        'table_CD.Columns.Add("Fecha", GetType(System.String))
        'table_CD.Columns.Add("Fecha Pago", GetType(System.String))
        'table_CD.Columns.Add("Acuse SAT", GetType(System.String))

        'table_CD.Columns.Add("UUID", GetType(System.String))
        'table_CD.Columns.Add("Importe", GetType(System.String))
        'table_CD.Columns.Add("Moneda", GetType(System.String))

        lblId_CD.Text = Grid_CD.Item(0, Grid_CD.CurrentRow.Index).Value
        lblRazonSocial_CD.Text = Grid_CD.Item(4, Grid_CD.CurrentRow.Index).Value
        lblRfcEmisor_CD.Text = Grid_CD.Item(5, Grid_CD.CurrentRow.Index).Value
        lblRfcReceptor_CD.Text = Grid_CD.Item(6, Grid_CD.CurrentRow.Index).Value
        lblOrdenCompra_CD.Text = Grid_CD.Item(7, Grid_CD.CurrentRow.Index).Value
        lblFechaPago_Consulta.Text = Grid_CD.Item(9, Grid_CD.CurrentRow.Index).Value
        lblAcuseSAt.Text = Grid_CD.Item(10, Grid_CD.CurrentRow.Index).Value


        lblcFOLIO.Text = Grid_CD.Item(1, Grid_CD.CurrentRow.Index).Value
        lblcFECHAFACTURA.Text = Grid_CD.Item(8, Grid_CD.CurrentRow.Index).Value

        Dim Impor As Double = Grid_CD.Item(11, Grid_CD.CurrentRow.Index).Value
        lblcIMPORTE.Text = Format(Impor, "$ ###,###,###.#0")



        lblcMONEDA.Text = Grid_CD.Item(12, Grid_CD.CurrentRow.Index).Value
        lblcUUID.Text = Grid_CD.Item(10, Grid_CD.CurrentRow.Index).Value


        BUSCA_ARCHIVO()
    End Sub
    Sub BUSCA_ARCHIVO()

        SQL = "SELECT [docId], [nombre_archivo],[extension] " &
                "FROM [dbo].[ARASIS_ARCHIVOS] " &
               "WHERE [docId] = '" & lblId_CD.Text & "' "

        Dim da As New SqlDataAdapter(SQL, DB.obtenerConexionDB)
        Dim ds As New DataSet

        Try
            da.Fill(ds)

            If ds.Tables(0).Rows.Count = 0 Then
                Exit Sub
            Else

                For i = 0 To ds.Tables(0).Rows.Count - 1

                    idDoc = ds.Tables(0).Rows(i)(0).ToString()
                    nombre_archivo = ds.Tables(0).Rows(i)(1).ToString()
                    extension = ds.Tables(0).Rows(i)(2).ToString()
                    crea_documento()
                    creaPDF()
                Next
            End If

        Catch ex As Exception
            MsgBox("ERROR: " & ex.Message, MsgBoxStyle.Critical)
            Exit Sub
        End Try


    End Sub
    Sub crea_documento()

        Dim data As Byte() = Nothing
        Dim exten As String = ".pdf"
        Try
            ' Construimos los correspondientes objetos para
            ' conectarnos a la base de datos de SQL Server,
            ' utilizando la seguridad integrada de Windows NT.
            '
            SQL = "SELECT [archivo] FROM .[dbo].ARASIS_ARCHIVOS where docId = '" & lblId_CD.Text & "' "

            Dim conectar As New SqlConnection(DB.obtenerConexionDB)
            Dim cmd As New SqlCommand(SQL, conectar)


            ' Abrimos la conexión.
            '
            conectar.Open()

            ' Creamos un DataReader.
            '
            Dim dr As SqlDataReader = cmd.ExecuteReader(CommandBehavior.CloseConnection)

            ' Leemos el registro.
            '
            dr.Read()

            ' El tamaño del búfer debe ser el adecuado para poder
            ' escribir en el archivo todos los datos leídos.
            '
            ' Si el parámetro 'buffer' lo pasamos como Nothing, obtendremos
            ' la longitud del campo en bytes.
            '
            Dim bufferSize As Integer = Convert.ToInt32(dr.GetBytes(0, 0, Nothing, 0, 0))

            ' Creamos el array de bytes. Como el índice está
            ' basado en cero, la longitud del array será la
            ' longitud del campo menos una unidad.
            '
            data = New Byte(bufferSize - 1) {}

            ' Leemos el campo.
            '
            dr.GetBytes(0, 0, data, 0, bufferSize)

            ' Cerramos el objeto DataReader, e implícitamente la conexión.
            '
            dr.Close()
            conectar.Close()


            ' Procedemos a crear el archivo, en el ejemplo
            ' un documento de Microsoft Word.
            crea_carpeta_temporal()



            Dim fechaHora As String = DateTime.Now.ToString("yyyyMMddhhmmss")
            'ruta_archivo = String.Format("C:\DescargaXML\" & nombre_archivo.Trim & "_{0}" & extension.Trim & "", fechaHora)
            ruta_archivo = "C:\DocumentosTemporales\" & nombre_archivo.Trim
            WriteBinaryFile(ruta_archivo, data)

            tbRutaXML.Text = ruta_archivo
            tbDireccionPDF.Text = "C:\DocumentosTemporales\" & nombre_archivo.Trim

            System.Diagnostics.Process.Start(ruta_archivo) ' ESTA FUNCION SIRVE PARA ABRIR EL DOCUMENT

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

    End Sub
    Sub crea_carpeta_temporal()

        Dim exists As Boolean
        exists = System.IO.Directory.Exists("C:\DocumentosTemporales")


        If exists = True Then
            ' My.Computer.FileSystem.DeleteDirectory("C:\MC_Temporales", FileIO.DeleteDirectoryOption.DeleteAllContents)

            'Dim fileslist As String() = Directory.GetFiles("C:\MC_Temporales")
            'For Each item As String In fileslist
            '    File.Delete(item)
            'Next
        Else
            Try
                System.IO.Directory.CreateDirectory("C:\DocumentosTemporales")

            Catch ex As Exception
                MsgBox("Error al crear la carpeta, Error: " & ex.Message, MsgBoxStyle.Critical)
                Exit Sub
            End Try

        End If
    End Sub
    Private Sub btnBuscarImagen_Click(sender As Object, e As EventArgs) Handles btnBuscarImagen.Click

    End Sub
    Private Sub btnExaminar_Click_1(sender As Object, e As EventArgs) Handles btnExaminar.Click
        Dim open = New OpenFileDialog()
        open.Filter = "Archivo XML (*.xml)|*.xml"
        open.FilterIndex = 4
        If (open.ShowDialog() <> DialogResult.OK) Then
            Return
        End If
        tbRutaXML.Text = open.FileName


    End Sub
    Private Sub btnCrearPDF_Click(sender As Object, e As EventArgs) Handles btnCrearPDF.Click



    End Sub
    Sub creaPDF()
        Dim crearPdf As CreaPDF

        If tbRutaXML.Text <> "" Then
            If (TabControl1.SelectedTab.Name = "TabPage1") Then
                'DocumentoPDF.CreaPDF crearPDF = new DocumentoPDF.CreaPDF(tbRutaXML.Text, Path.GetTempFileName() + ".pdf",pictureBox1.Image);  
                crearPdf = New CreaPDF(tbRutaXML.Text, tbDireccionPDF.Text, pictureBox1.Image)

                Try
                    System.Diagnostics.Process.Start(tbRutaXML.Text) ' ESTA FUNCION SIRVE PARA ABRIR EL DOCUMENT XML
                    System.Diagnostics.Process.Start(tbDireccionPDF.Text) ' ESTA FUNCION SIRVE PARA ABRIR EL DOCUMENT PDF
                Catch ex As Exception

                End Try


            ElseIf (TabControl1.SelectedTab.Name = "TabPage2") Then
                Dim di As DirectoryInfo = New DirectoryInfo(tbRutaCarpetaXML.Text)
                Dim nuevaRuta As String
                For Each fi In di.GetFiles("*.xml")
                    nuevaRuta = tbRutaCarpetaPDF.Text + "\\" + fi.Name.Replace(".xml", ".pdf")
                    crearPdf = New CreaPDF(fi.FullName, nuevaRuta, pictureBox1.Image)
                Next

            Else
                MessageBox.Show("No se ha seleccionado una pestaña")
            End If
        Else
            MsgBox("Seleccione un Registro de la Lista para Consultarlo", MsgBoxStyle.Information)
            Exit Sub
        End If
    End Sub
    Private Shared Sub WriteBinaryFile(ByVal fileName As String, ByVal data As Byte())

        ' Comprobación de los valores de los parámetros.
        '
        If (String.IsNullOrEmpty(fileName)) Then _
        Throw New ArgumentException("No se ha especificado el archivo de destino.", "fileName")

        If (data Is Nothing) Then _
            Throw New ArgumentException("Los datos no son válidos para crear un archivo.", "data")

        ' Crear el archivo. Se producirá una excepción si ya existe
        ' un archivo con el mismo nombre.
        Using fs As New IO.FileStream(fileName, IO.FileMode.CreateNew, IO.FileAccess.Write)

            ' Crea el escritor para la secuencia.
            Dim bw As New IO.BinaryWriter(fs)

            ' Escribir los datos en la secuencia.
            bw.Write(data)

        End Using

    End Sub
End Class