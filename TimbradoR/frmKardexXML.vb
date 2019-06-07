Imports System.Data.SqlClient
Imports System.IO
Imports System.Math
Imports System.Xml

Public Class frmKardexXML
    Private tableOC_Detalle As System.Data.DataTable
    Private rowOC_Detalle As System.Data.DataRow
    Dim fecha_registro As String
    '**************ARCHIVOS***********************
    Dim idDoc As String

    Dim ruta_archivo As String
    Dim nombre_archivo As String
    Dim extension As String
    Dim nombrearchivoPDF_ As String
    Dim rutaPDF_ As String
    Dim idRegistro As String
    '*******************VARIABLES CANCELARCFDI***************
    Private uuidcancelar() As String
    Private RFCEmisor As String
    Private RFCReceptor As String
    Private TotalCFDI As String

    Private Sub frmKardexXML_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnCancelarCFDI.Enabled = True
        TextBox_RespuestaWS.Text = ""
        TextBox_RespuestaWS.Visible = False
        limpia()
        carga()
        crea_carpeta()
        ' Setting the style of the DataGridView control

        GRID()
    End Sub
    Sub GRID()

        GridOC_Detalle.ColumnHeadersDefaultCellStyle.Font = New Font("Tahoma", 9, FontStyle.Bold, GraphicsUnit.Point)
        GridOC_Detalle.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.ControlDark
        GridOC_Detalle.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        GridOC_Detalle.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        GridOC_Detalle.DefaultCellStyle.Font = New Font("Tahoma", 8, FontStyle.Regular, GraphicsUnit.Point)
        GridOC_Detalle.DefaultCellStyle.BackColor = Color.Empty
        GridOC_Detalle.AlternatingRowsDefaultCellStyle.BackColor = SystemColors.ControlLight
        GridOC_Detalle.CellBorderStyle = DataGridViewCellBorderStyle.Single
        GridOC_Detalle.GridColor = SystemColors.ControlDarkDark
        GridOC_Detalle.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)

    End Sub
    Sub limpia()

        lblID.Text = ""
        lblRFC.Text = ""
        lblProveedor.Text = ""
        lblFechaXML.Text = ""
        lblFechaRegistro.Text = ""
        lblEstado.Text = ""
        txtUUID.Text = ""
        Me.GridOC_Detalle.DataSource = Nothing

    End Sub
    Sub carga()

        SQL = "SELECT  id  " &
                      ", folio  " &
                      ", Emirfc  " &
                      ", EmiNombre " &
                      ", fecha " &
                      ", fecha_registro_xml " &
                      ", UUID ,status_xml ,AcuseCancelacion " &
                "FROM   [ARASIS_XML_ENCABEZADO]  where  id  = '" & Variables.ID_FOLIO_XML & "'"


        Dim da As New SqlDataAdapter(SQL, DB.obtenerConexionDB)
        Dim ds As New DataSet
        Try
            da.Fill(ds)

            If ds.Tables(0).Rows.Count = 0 Then
                MsgBox("Registro No Encontrado, Verifique", MsgBoxStyle.Information)
                Me.Close()
            Else

                For i As Integer = 0 To ds.Tables(0).Rows.Count - 1

                    lblID.Text = ds.Tables(0).Rows(i)(1).ToString
                    lblRFC.Text = ds.Tables(0).Rows(i)(2).ToString
                    lblProveedor.Text = ds.Tables(0).Rows(i)(3).ToString
                    lblFechaXML.Text = ds.Tables(0).Rows(i)(4).ToString
                    lblFechaRegistro.Text = ds.Tables(0).Rows(i)(5).ToString
                    txtUUID.Text = ds.Tables(0).Rows(i)(6).ToString
                    'fecha_registro = ds.Tables(0).Rows(i)(7).ToString

                    If ds.Tables(0).Rows(i)(7).ToString = "0" Then
                        btnCancelarCFDI.Enabled = False
                        TextBox_RespuestaWS.Visible = True
                        TextBox_RespuestaWS.Text = ""
                        TextBox_RespuestaWS.Text = ds.Tables(0).Rows(i)(8).ToString

                    End If


                Next
                detalle()
            End If

        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical)
            Exit Sub
        End Try


    End Sub
    Sub detalle()

        Me.GridOC_Detalle.DataSource = Nothing

        Dim precio_unitario As Double
        Dim importe As Double

        SQL = "SELECT  id  " &
                      ", ClaveProdServ  " &
                      ", descripcion  " &
                      ", cantidad  " &
                      ", noIdentificacion  " &
                      ", consecutivo , valor_unitario , importe,unidad  " &
                  "FROM   [ARASIS_XML_DETALLE]  where  id  = '" & Variables.ID_FOLIO_XML & "'"

        Dim da As New SqlDataAdapter(SQL, DB.obtenerConexionDB)
        Dim ds As New DataSet
        Try
            da.Fill(ds)

            If ds.Tables(0).Rows.Count = 0 Then
                MsgBox("Registro No Encontrado, Verifique", MsgBoxStyle.Information)
                Me.GridOC_Detalle.DataSource = Nothing
                lblOC_TotalRegistrosDetalle.Text = "0"


            Else
                tableOC_Detalle = New System.Data.DataTable()
                tableOC_Detalle.Columns.Add("Código", GetType(System.String))
                tableOC_Detalle.Columns.Add("Articulo descripción", GetType(System.String))
                tableOC_Detalle.Columns.Add("Cantidad", GetType(System.String))
                tableOC_Detalle.Columns.Add("U.M.", GetType(System.String))
                tableOC_Detalle.Columns.Add("P.Unitario", GetType(System.String))
                tableOC_Detalle.Columns.Add("Importe", GetType(System.String))



                lblOC_TotalRegistrosDetalle.Text = ds.Tables(0).Rows.Count


                For i As Integer = 0 To ds.Tables(0).Rows.Count - 1

                    rowOC_Detalle = tableOC_Detalle.NewRow()

                    idRegistro = ""
                    idRegistro = ds.Tables(0).Rows(i)(0).ToString


                    rowOC_Detalle("Código") = ds.Tables(0).Rows(i)(1).ToString
                    rowOC_Detalle("Articulo descripción") = ds.Tables(0).Rows(i)(2).ToString
                    rowOC_Detalle("Cantidad") = ds.Tables(0).Rows(i)(3).ToString
                    rowOC_Detalle("U.M.") = ds.Tables(0).Rows(i)(8).ToString

                    precio_unitario = ds.Tables(0).Rows(i)(6).ToString
                    importe = ds.Tables(0).Rows(i)(7).ToString

                    rowOC_Detalle("P.Unitario") = Format(precio_unitario, "$ ###,###,###.#0")
                    rowOC_Detalle("Importe") = Format(importe, "$ ###,###,###.#0")

                    tableOC_Detalle.Rows.Add(rowOC_Detalle)

                    Me.GridOC_Detalle.DataSource = tableOC_Detalle

                Next
                GRID_VALORES()
                'agregar renglon

                rowOC_Detalle = tableOC_Detalle.NewRow()

                rowOC_Detalle("Código") = "-----------"
                rowOC_Detalle("Articulo descripción") = "-----------"
                rowOC_Detalle("Cantidad") = "-----------"
                rowOC_Detalle("U.M.") = "-----------"
                rowOC_Detalle("P.Unitario") = "-----------"
                rowOC_Detalle("Importe") = "-----------"
                tableOC_Detalle.Rows.Add(rowOC_Detalle)
                Me.GridOC_Detalle.DataSource = tableOC_Detalle


                GridOC_Detalle.Columns(0).Width = 90  'ID ARTICULO
                GridOC_Detalle.Columns(1).Width = 450 'Articulo descripción
                GridOC_Detalle.Columns(2).Width = 80  'Cantidad
                GridOC_Detalle.Columns(3).Width = 130 'U.M.
                GridOC_Detalle.Columns(4).Width = 130 'Precio Unitario
                GridOC_Detalle.Columns(5).Width = 80  'Importe 

                GridOC_Detalle.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter
                GridOC_Detalle.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter
                GridOC_Detalle.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter
                GridOC_Detalle.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
                GridOC_Detalle.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight

                GridOC_Detalle.Columns("Importe").DefaultCellStyle.BackColor = Color.YellowGreen



                '' color_status()
                'GridOC_Detalle.Columns(0).Width = 30
                'GridOC_Detalle.Columns(1).Width = 350
                'GridOC_Detalle.Columns(2).Width = 80


                totales()
            End If

        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical)
            Exit Sub
        End Try


    End Sub
    Sub GRID_VALORES()

        Dim total_piezas = 0
        Dim importe_total As Double = 0

        Dim TOTAL As Double = 0
        Dim IVA As Double = 0

        If GridOC_Detalle.Rows.Count > 0 Then

            For i = 0 To GridOC_Detalle.Rows.Count - 1

                importe_total = importe_total + GridOC_Detalle.Item(5, i).Value

            Next

            IVA = 0.16 * importe_total

            TOTAL = Round(IVA + importe_total, 2)


            lblSubTotal.Text = Format(importe_total, "$ ###,###,###.#0")
            lblIVA.Text = Format(IVA, "$ ###,###,###.#0")
            lblTotal.Text = Format(TOTAL, "$ ###,###,###.#0")


            'Dim largo = Len(CStr(Format(CDbl(TOTAL), "#,###.00")))

            'Dim decimales = Mid(CStr(Format(CDbl(TOTAL), "#,###.00")), largo - 2)

            'Dim DEC As String = ""

            'DEC = Replace(decimales, ".", "")
            'Try
            '    lblCantidadLetra.Text = Num2Text(Int(TOTAL)) & " PESOS " & DEC & "/100 M.N."

            'Catch ex As Exception
            '    MsgBox("Error: " & ex.Message)

            'End Try

        Else

            lblSubTotal.Text = Format(0, "$ ###,###,###.#0")
            lblIVA.Text = Format(0, "$ ###,###,###.#0")
            lblTotal.Text = Format(0, "$ ###,###,###.#0")
            ' lblCantidadLetra.Text = ""
        End If


    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        If MsgBox("¿ Desea Imprimir la Factura ?", MsgBoxStyle.YesNo, "efactura33") = MsgBoxResult.Yes Then

            Dim fecha As Date = lblFechaRegistro.Text

            Variables.print_titulo_reporte = "FACTURA PROVEEDOR"

            Variables.print_id_documento = lblID.Text
            Variables.print_proveedor = lblRFC.Text
            Variables.printOC_fecha_entregas = Format(fecha, "dd/MM/yyyy")


            Variables.print_solicitante = lblProveedor.Text
            Variables.printOC_prioridad = lblFechaRegistro.Text
            Variables.print_fecha = fecha_registro

            Variables.print_tipo_documento = "XML"

            Dim encabezdo As String

            encabezdo = "Grupo SIEL"

            ImprimirOrdenCompra.StartPrint(GridOC_Detalle, False, True, encabezdo, "Grupo SIEL")
            Me.Close()
        End If

    End Sub
    Sub totales()

        Try
            'declaring variable as integer to store the value of the total rows in the datagridview
            Dim importe_total As Double = 0
            Dim max As Integer = GridOC_Detalle.Rows.Count - 1
            'getting the values of a specific rows
            GridOC_Detalle.Rows(max).Cells(0).Value = "-----------"
            GridOC_Detalle.Rows(max).Cells(1).Value = "-----------"
            GridOC_Detalle.Rows(max).Cells(2).Value = "-----------"
            GridOC_Detalle.Rows(max).Cells(3).Value = "-----------"
            GridOC_Detalle.Rows(max).Cells(4).Value = "Total ----------->"

            For I = 0 To GridOC_Detalle.Rows.Count - 2
                'formula for adding the values in the rows
                importe_total = importe_total + GridOC_Detalle.Rows(I).Cells(5).Value
            Next
            GridOC_Detalle.Rows(max).Cells(5).Value = Format(importe_total, "$ ###,###,###.#0")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnPDF_Click(sender As Object, e As EventArgs) Handles btnPDF.Click
        If MsgBox("¿ Desea abrir la Representacion Impresa de la Factura ?", MsgBoxStyle.YesNo, "efactura33") = MsgBoxResult.Yes Then
            extension = "XML"
            abrir_documento()
            crea_pdf()
        End If


    End Sub

    Private Sub btnXML_Click(sender As Object, e As EventArgs) Handles btnXML.Click
        If MsgBox("¿ Desea abrir el archivo XML ?", MsgBoxStyle.YesNo, "efactura33") = MsgBoxResult.Yes Then
            extension = "XML"
            abrir_documento()
        End If
    End Sub
    Sub crea_pdf()

        nombrearchivoPDF_ = Path.GetFileNameWithoutExtension(ruta_archivo)

        rutaPDF_ = "C:\eFactura_Temporales\" & nombrearchivoPDF_ & ".pdf"
        'rutaXML_ = My.Settings.rutaXMLST & "\" & nombrearchivoXML_
        Dim CreaPDF As CreaPDF = New CreaPDF(ruta_archivo, rutaPDF_, Nothing)
        System.Diagnostics.Process.Start(rutaPDF_)



    End Sub
    Sub abrir_documento()

        busca_archivo()
        Dim data As Byte() = Nothing

        Try
            ' Construimos los correspondientes objetos para
            ' conectarnos a la base de datos de SQL Server,
            ' utilizando la seguridad integrada de Windows NT.
            '
            SQL = "SELECT [archivo] FROM [ARASIS_ARCHIVOS] WHERE [Folio] = '" & lblID.Text.Trim & "'"

            Dim conectar As New SqlConnection(DB.obtenerConexionDB)
            Dim cmd As New SqlCommand(SQL, conectar)


            ' Abrimos la conexión.
            '
            conectar.Open()

            ' Creamos un DataReader.
            '
            Dim dr As SqlDataReader = cmd.ExecuteReader(CommandBehavior.CloseConnection)

            ' Leemos el registro.

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
            crea_carpeta()



            Dim fechaHora As String = DateTime.Now.ToString("yyyyMMddhhmmss")
            ruta_archivo = "C:\eFactura_Temporales\" & nombre_archivo.Trim
            WriteBinaryFile(ruta_archivo, data)
            System.Diagnostics.Process.Start(ruta_archivo)

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

    End Sub
    Sub crea_carpeta()
        Dim exists As Boolean
        exists = System.IO.Directory.Exists("C:\eFactura_Temporales")


        If exists = True Then
            ' My.Computer.FileSystem.DeleteDirectory("C:\eFactura_Temporales", FileIO.DeleteDirectoryOption.DeleteAllContents)

            'Dim fileslist As String() = Directory.GetFiles("C:\eFactura_Temporales")
            'For Each item As String In fileslist
            '    File.Delete(item)
            'Next
        Else
            Try
                System.IO.Directory.CreateDirectory("C:\eFactura_Temporales")

            Catch ex As Exception
                MsgBox("Error al crear la carpeta, Error: " & ex.Message, MsgBoxStyle.Critical)
                Exit Sub
            End Try
        End If
    End Sub
    Sub busca_archivo()

        SQL = "SELECT [docId] " &
                      ",[nombre_archivo] " &
                      ",[archivo] " &
                      ",[extension] " &
                      ",[Folio] " &
                      ",[fecha_registro] " &
                      ",[origen] " &
                  "FROM [dbo].[ARASIS_ARCHIVOS] " &
                 "WHERE [Folio] = '" & lblID.Text.Trim & "' " &
                   "AND [origen] = 'XML' "

        Dim da As New SqlDataAdapter(SQL, DB.obtenerConexionDB)
        Dim ds As New DataSet
        Try
            da.Fill(ds)

            If ds.Tables(0).Rows.Count = 0 Then

            Else
                For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
                    'idDoc = ds.Tables(0).Rows(i)(0).ToString
                    nombre_archivo = ds.Tables(0).Rows(i)(1).ToString
                    'extension = ds.Tables(0).Rows(i)(3).ToString
                Next
            End If

        Catch ex As Exception
            Beep()
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical)
            Exit Sub
        End Try


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

    Private Sub btnCancelarCFDI_Click(sender As Object, e As EventArgs) Handles btnCancelarCFDI.Click
        TextBox_RespuestaWS.Visible = False
        Dim resultado = CType(MessageBox.Show("¿ Desea cancelar la Factura con Folio:  " & lblID.Text & " ?", "efactura33", MessageBoxButtons.YesNo, MessageBoxIcon.Question), MsgBoxResult)

        If resultado = MsgBoxResult.No Then

        Else
            ' MsgBox("Módulo en Contrucción", MsgBoxStyle.Information)
            CANCELAR_CFDI()
            Exit Sub
        End If
    End Sub
    Sub CANCELAR_CFDI()

        Try
            ReDim uuidcancelar(0)
            abrir_xml_cancelar()

            Dim xmlCfdiRespuesta As New XmlDocument()
            Dim xmlAcuseRespuesta As New XmlDocument()
            Dim xmlAcuseCancelacion As New XmlDocument()

            Dim Base64PFXCancelacion As String = DB.obtenerBase64PFXCancelacion()
            Dim contrasenaPFX As String = DB.obtenerContrasenaPFX()
            Dim usuarioFD As String = DB.obtenerUsuarioFD()
            Dim passwordFD As String = DB.contrasenaFD()

            'En el proyecto se agrego una referencia de servicio apuntando al WS de Timbrado, a la cual se llamo WSCFDI33
            'La URL es la siguiente.
            'https://www.foliosdigitalespac.com/WSTimbrado33Test/WSCFDI33.svc?WSDL

            'Se instancia el WS de Timbrado.
            Dim ServicioTimbrado As New WSCFD133PROD.WSCFDI33Client

            'Se instancia la Respuesta del WS de Timbrado.
            Dim RespuestaServicio As New WSCFD133PROD.RespuestaCancelacion
            ' Dim RespuestaCancelacionDetallada As New List(Of CancelarCFDI33.WSCFDI33.DetalleCancelacion)

            Dim ServicioFI As New WSCFD133PROD.WSCFDI33Client
            Dim RespuestaFI As New WSCFD133PROD.RespuestaCancelacion

            Dim RespuestaCancelacionDetallada As New List(Of ef33LlantasRegio.WSCFD133PROD.DetalleCancelacion)


            'Se crea una lista de string que contendran los UUID a cancelar.
            ' Dim ListaUUID As New List(Of String)

            'Se agregan los UUID a cancelar.
            'ListaUUID.Add(lblUUID.Text.Trim)
            'ListaUUID.Add("D7898345-VB67-JUI9-LO8I-TY77A93ED858")
            'ListaUUID.Add("T5008864-NM6T-JUI9-F5T7-AL00A93ED858")

            Dim ListaCFDI = New WSCFD133PROD.DetalleCFDICancelacion
            ListaCFDI.UUID = uuidcancelar(0)
            ListaCFDI.RFCReceptor = RFCReceptor
            ListaCFDI.Total = TotalCFDI
            Dim ListaCFDI2() = New WSCFD133PROD.DetalleCFDICancelacion() {ListaCFDI}



            Dim CadenaDelPfxEnByte As Byte() = ReadFile(DB.obtenerRutaPFX)
            Dim CadenaDelPfxBase64 As String = Convert.ToBase64String(CadenaDelPfxEnByte)



            'Se realiza la petición al WebService, almacenando la respuesta en el objeto RespuestaCancelacion (RespuestaServicio)
            'Los parámetros son usuario,password,rfcEmisor,listaCFDi(), ClavePrivada_Base64, PasswordClavePrivada

            'Se utiliza el PFX de cancelación, consultar el SDK para el manual de creación en el API de Timbrado.

            'Los datos de acceso se deben solicitar.
            'RespuestaServicio = ServicioTimbrado.CancelarCFDI("DEMO010233001", "Pruebas1a$", "TES030201001", ListaUUID.ToArray(), "Base64 PFX Cancelación", "Contraseña PFX Cancelación")
            'RespuestaServicio = ServicioTimbrado.CancelarCFDI(usuarioFD, passwordFD, Variables.USUARIO_SISTEMA.Trim, ListaUUID.ToArray(), CadenaDelPfxBase64, contrasenaPFX)

            RespuestaServicio = ServicioTimbrado.CancelarCFDIConValidacion(usuarioFD, passwordFD, Variables.USUARIO_SISTEMA.Trim, ListaCFDI2, CadenaDelPfxBase64, contrasenaPFX)



            'Obteniendo la respuesta se valida que haya sido exitosa.
            If RespuestaServicio.OperacionExitosa = True Then

                'Se limpia el TextBox
                TextBox_RespuestaWS.Clear()

                'Se asigna la respuesta al objeto que contendra la operación de todos los UUID a cancelar.
                RespuestaCancelacionDetallada = RespuestaServicio.DetallesCancelacion.ToList()

                'Se recorre el objeto para obtener la operacion independiente de cada CFDi.
                For Each UUID As WSCFD133PROD.DetalleCancelacion In RespuestaCancelacionDetallada

                    TextBox_RespuestaWS.Text += UUID.CodigoResultado + vbNewLine
                    TextBox_RespuestaWS.Text += UUID.MensajeResultado + vbNewLine
                    TextBox_RespuestaWS.Text += UUID.UUID + vbNewLine

                Next

                'Se guarda localmente el acuse de cancelación que contendra el registro de todas las operaciones que realizamos, es decir, un acuse.

                Dim AcuseXML As New XmlDocument
                AcuseXML.LoadXml(RespuestaServicio.XMLAcuse)
                AcuseXML.Save("C:\eFactura_Temporales\AcuseCancelacion_" & lblID.Text.Trim & ".xml")
                actualiza_factura()
                guardaXMLAcuseCancelacion()
                MsgBox("CFDI Cancelado Correctamente", vbInformation)
                TextBox_RespuestaWS.Visible = True
                TextBox_RespuestaWS.BackColor = Color.Green
            Else
                TextBox_RespuestaWS.Visible = True

                'Se limpia el TextBox
                TextBox_RespuestaWS.Clear()

                'Si la petición fue erronea muestro el error.
                TextBox_RespuestaWS.Text = RespuestaServicio.MensajeError + vbNewLine
                TextBox_RespuestaWS.Text += RespuestaServicio.MensajeErrorDetallado + vbNewLine

                'Se asigna la respuesta al objeto que contendra la operación de todos los UUID a cancelar.
                RespuestaCancelacionDetallada = RespuestaServicio.DetallesCancelacion.ToList()

                'Se recorre el objeto para obtener la operacion independiente de cada CFDi.
                For Each UUID As WSCFD133PROD.DetalleCancelacion In RespuestaCancelacionDetallada

                    TextBox_RespuestaWS.Text += UUID.CodigoResultado + vbNewLine
                    TextBox_RespuestaWS.Text += UUID.MensajeResultado + vbNewLine
                    TextBox_RespuestaWS.Text += UUID.UUID + vbNewLine
                Next
                TextBox_RespuestaWS.BackColor = Color.Red

            End If

        Catch ex As Exception
            Beep()
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical)
            Exit Sub
        End Try


    End Sub

    Sub actualiza_factura()

        SQL = "UPDATE [dbo].[ARASIS_XML_ENCABEZADO] " &
                 "SET [AcuseCancelacion] = '" & TextBox_RespuestaWS.Text.Trim & "', " &
                     "[status_xml] = '0' " &
               "WHERE [id] = '" & idRegistro & "'  "

        Dim da As New SqlDataAdapter(SQL, DB.obtenerConexionDB)
        Dim ds As New DataSet
        Try
            da.Fill(ds)
        Catch ex As Exception
            Beep()
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical)
            Exit Sub
        End Try

    End Sub

    Public Function ReadFile(ByVal strArchivo As String) As Byte()
        Dim f As New FileStream(strArchivo, FileMode.Open, FileAccess.Read)
        Dim size As Integer = CInt(f.Length)
        Dim data As Byte() = New Byte(size - 1) {}
        size = f.Read(data, 0, size)
        f.Close()
        Return data
    End Function

    Sub abrir_xml_cancelar()

        busca_archivo()
        Dim data As Byte() = Nothing

        Try
            ' Construimos los correspondientes objetos para
            ' conectarnos a la base de datos de SQL Server,
            ' utilizando la seguridad integrada de Windows NT.
            '
            SQL = "SELECT [archivo] FROM [ARASIS_ARCHIVOS] WHERE [Folio] = '" & lblID.Text.Trim & "' AND [origen] = 'XML'"

            Dim conectar As New SqlConnection(DB.obtenerConexionDB)
            Dim cmd As New SqlCommand(SQL, conectar)


            ' Abrimos la conexión.
            '
            conectar.Open()

            ' Creamos un DataReader.
            '
            Dim dr As SqlDataReader = cmd.ExecuteReader(CommandBehavior.CloseConnection)

            ' Leemos el registro.

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
            crea_carpeta()



            Dim fechaHora As String = DateTime.Now.ToString("yyyyMMddhhmmss")
            ruta_archivo = "C:\eFactura_Temporales\" & nombre_archivo.Trim
            WriteBinaryFile(ruta_archivo, data)
            LeerXmlCancelacionFI()
            '  System.Diagnostics.Process.Start(ruta_archivo)

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try


    End Sub
    Private Sub LeerXmlCancelacionFI()
        Dim FlujoReader As Xml.XmlTextReader = Nothing
        Dim i As Integer
        'FlujoReader = New XmlTextReader(CarpetaAlmacenXML & "\" & String.Format("{0:00}", NumeroEmpresa) & SeriePrefijo & String.Format("{0:000000}", Convert.ToInt32(DataGridView1.CurrentRow.Cells(1).Value)) & ".xml")
        FlujoReader = New XmlTextReader(ruta_archivo)
        FlujoReader.WhitespaceHandling = WhitespaceHandling.None
        While FlujoReader.Read()
            Select Case FlujoReader.NodeType
                Case XmlNodeType.Element
                    If FlujoReader.Name = "cfdi:Comprobante" Then
                        For i = 0 To FlujoReader.AttributeCount - 1
                            FlujoReader.MoveToAttribute(i)
                            If FlujoReader.Name = "Total" Then
                                TotalCFDI = FlujoReader.Value
                            End If
                        Next
                    ElseIf FlujoReader.Name = "tfd:TimbreFiscalDigital" Then
                        For i = 0 To FlujoReader.AttributeCount - 1
                            FlujoReader.MoveToAttribute(i)
                            If FlujoReader.Name = "UUID" Then
                                uuidcancelar(0) = FlujoReader.Value
                            End If
                        Next
                    ElseIf FlujoReader.Name = "cfdi:Emisor" Then
                        For i = 0 To FlujoReader.AttributeCount - 1
                            FlujoReader.MoveToAttribute(i)
                            If FlujoReader.Name = "Rfc" Or FlujoReader.Name = "rfc" Then
                                RFCEmisor = FlujoReader.Value
                            End If
                        Next
                    ElseIf FlujoReader.Name = "cfdi:Receptor" Then
                        For i = 0 To FlujoReader.AttributeCount - 1
                            FlujoReader.MoveToAttribute(i)
                            If FlujoReader.Name = "Rfc" Or FlujoReader.Name = "rfc" Then
                                RFCReceptor = FlujoReader.Value
                            End If
                        Next
                    End If
            End Select
        End While
    End Sub
    Sub guardaXMLAcuseCancelacion()

        Try
            'Dim sFiles As String = Path.GetFileName(RutaArchivoS)

            ' Leer el archivo binario especificado en el control TextBox.
            Dim blobXML As Byte()
            blobXML = Nothing
            blobXML = ReadBinaryFileXML("C:\eFactura_Temporales\AcuseCancelacion_" & lblID.Text.Trim & ".xml")

            Dim SQL1 As String = ""

            SQL1 = "INSERT INTO [dbo].[ARASIS_ARCHIVOS] " &
                             "([nombre_archivo],[archivo],[extension],[fecha_registro],[origen],[Folio],[usuario]) " &
                    "VALUES(@nombre_archivo,@archivo,@extension,GETDATE(),'AcuseCancelacion','" & lblID.Text.Trim & "','" & Variables.USUARIO_SISTEMA & "' )"


            Dim conectar As New SqlConnection(DB.obtenerConexionDB)

            Dim cmd1 As New SqlCommand(SQL1, conectar)

            cmd1.Parameters.AddWithValue("@nombre_archivo", "AcuseCancelacion_" & nombre_archivo.Trim)
            cmd1.Parameters.AddWithValue("@archivo", If(blobXML IsNot Nothing, blobXML, CObj(DBNull.Value)))
            cmd1.Parameters.AddWithValue("@extension", ".xml")

            conectar.Open()

            Dim n1 As Integer = cmd1.ExecuteNonQuery()

            If (n1 > 0) Then
                conectar.Close()
            End If

        Catch ex As Exception
            ' Se ha producido un error.
            MessageBox.Show(ex.Message)
            'conectar.Close()
            Exit Sub
        End Try
    End Sub
    Private Shared Function ReadBinaryFileXML(ByVal fileNameXML As String) As Byte()

        ' Generar una excepción si no existe el archivo.
        '
        If (Not IO.File.Exists(fileNameXML)) Then
            Throw New IO.FileNotFoundException("No existe el archivo especificado.")
        End If

        ' Leer el archivo especificado devolviendo una matriz de bytes con su contenido.
        '
        Return IO.File.ReadAllBytes(fileNameXML)

    End Function

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtUUID.TextChanged

    End Sub
End Class