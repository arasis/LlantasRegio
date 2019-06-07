Imports System.Data.SqlClient
Imports System.IO

Public Class frmArchivos_efactura33
    '******ARCHIVOS*********
    Private table As System.Data.DataTable
    Private row As System.Data.DataRow
    Dim idDoc As String
    Dim nombre_archivo As String
    Dim extension As String
    Dim ruta_archivo As String
    Dim nombrearchivoPDF_ As String
    Dim rutaPDF_ As String

    Private Sub frmArchivos_efactura33_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        abrir_archivo_asistencia()
    End Sub
    Sub abrir_archivo_asistencia()

        SQL = "SELECT A.DOCID, " &
                   "A.NOMBRE_ARCHIVO, " &
                   "B.RECEPRFC, " &
                   "B.RECEPNOMBRE, " &
                   "B.RECEPUSOCFDI, " &
                   "B.FECHATIMBRADO, " &
                   "B.UUID," &
                   "B.VERSION, " &
                   "B.FECHA, " &
                   "B.TIPODECOMPROBANTE, " &
                   "B.MONEDA, " &
                   "B.SUBTOTAL, " &
                   "B.TOTAL   " &
            "FROM [dbo].[ARASIS_ARCHIVOS] A, " &
                 "[dbo].[ARASIS_XML_ENCABEZADO] B " &
            "WHERE A.FOLIO = B.FOLIO " &
            "AND A.ORIGEN = 'XML' "

        Dim da As New SqlDataAdapter(SQL, DB.obtenerConexionDB)
        Dim ds As New DataSet
        Try
            da.Fill(ds)

            If ds.Tables(0).Rows.Count = 0 Then
                ' MsgBox("Registro No Encontrado, Verifique", MsgBoxStyle.Information)
                Me.dgvArchivos.DataSource = Nothing
                ' lblRegistroArchivosEquipo.Text = "0"

            Else
                table = New System.Data.DataTable()
                table.Columns.Add("IdDcto", GetType(System.String))
                table.Columns.Add("Nombre Archivo", GetType(System.String))
                table.Columns.Add("RFC", GetType(System.String))
                table.Columns.Add("Cliente", GetType(System.String))
                table.Columns.Add("UsiCFDI", GetType(System.String))
                table.Columns.Add("FechaTmbrado", GetType(System.String))
                table.Columns.Add("UUID", GetType(System.String))
                table.Columns.Add("Versión", GetType(System.String))
                table.Columns.Add("FechaRegistro", GetType(System.String))
                table.Columns.Add("TipoComprobante", GetType(System.String))
                table.Columns.Add("Moneda", GetType(System.String))
                table.Columns.Add("SubTotal", GetType(System.String))
                table.Columns.Add("Total", GetType(System.String))


                For i As Integer = 0 To ds.Tables(0).Rows.Count - 1

                    row = table.NewRow()

                    row("IdDcto") = ds.Tables(0).Rows(i)(0).ToString
                    row("Nombre Archivo") = ds.Tables(0).Rows(i)(1).ToString
                    row("RFC") = ds.Tables(0).Rows(i)(2).ToString
                    row("Cliente") = ds.Tables(0).Rows(i)(3).ToString
                    row("UsiCFDI") = ds.Tables(0).Rows(i)(4).ToString
                    row("FechaTmbrado") = ds.Tables(0).Rows(i)(5).ToString
                    row("UUID") = ds.Tables(0).Rows(i)(6).ToString
                    row("Versión") = ds.Tables(0).Rows(i)(7).ToString
                    row("FechaRegistro") = ds.Tables(0).Rows(i)(8).ToString
                    row("TipoComprobante") = ds.Tables(0).Rows(i)(9).ToString
                    row("Moneda") = ds.Tables(0).Rows(i)(10).ToString
                    row("SubTotal") = ds.Tables(0).Rows(i)(11).ToString
                    row("Total") = ds.Tables(0).Rows(i)(12).ToString


                    table.Rows.Add(row)

                    Me.dgvArchivos.DataSource = table

                Next

                'lblRegistroArchivosEquipo.Text = dgvArchivos.Rows.Count

                dgvArchivos.Columns(0).Visible = False 'idDoc
                dgvArchivos.Columns(1).Width = 120  'nombre archivo
                dgvArchivos.Columns(2).Width = 180  'extension
                'GridArchivos.Columns(3).Width = 180  'Fecha

            End If

        Catch ex As Exception
            Beep()
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical)
            Exit Sub
        End Try
        ' NoArchivosAdjuntosOC = GridArchivos.Rows.Count
    End Sub


    Sub abrir_documento()

        Dim data As Byte() = Nothing

        Try
            ' Construimos los correspondientes objetos para
            ' conectarnos a la base de datos de SQL Server,
            ' utilizando la seguridad integrada de Windows NT.
            '
            SQL = "SELECT [archivo] FROM [ARASIS_ARCHIVOS] where docId = '" & idDoc & "'"
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



            ruta_archivo = "C:\eFactura_Temporales\" & nombre_archivo.Trim
            WriteBinaryFile(ruta_archivo, data)


        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

    End Sub
    Sub crea_carpeta()
        Dim exists As Boolean
        exists = System.IO.Directory.Exists("C:\eFactura_Temporales")


        If exists = True Then
            ' My.Computer.FileSystem.DeleteDirectory("C:\MC_Temporales", FileIO.DeleteDirectoryOption.DeleteAllContents)

            'Dim fileslist As String() = Directory.GetFiles("C:\MC_Temporales")
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
    Sub crea_pdf()
        nombrearchivoPDF_ = Path.GetFileNameWithoutExtension(ruta_archivo)
        rutaPDF_ = "C:\eFactura_Temporales\" & nombrearchivoPDF_ & ".pdf"
        Dim CreaPDF As CreaPDF = New CreaPDF(ruta_archivo, rutaPDF_, Nothing)

    End Sub

    Private Sub btnAgregarUsuario_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub dgvArchivos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvArchivos.CellContentClick

    End Sub

    Private Sub dgvArchivos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvArchivos.CellDoubleClick
        If dgvArchivos.Rows.Count > 0 Then
            idDoc = dgvArchivos.Item(0, dgvArchivos.CurrentRow.Index).Value
            nombre_archivo = dgvArchivos.Item(1, dgvArchivos.CurrentRow.Index).Value
            extension = dgvArchivos.Item(2, dgvArchivos.CurrentRow.Index).Value

            abrir_documento()
            crea_pdf()
            System.Diagnostics.Process.Start(ruta_archivo)
            System.Diagnostics.Process.Start(rutaPDF_)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class