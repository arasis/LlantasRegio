
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Data
Imports System.Data.SqlClient

Module DB

    Function obtenerRutaXMLST() As String
        Return My.Settings.rutaXMLST
    End Function

    Function obtenerRutaXML() As String
        Return My.Settings.rutaXML
    End Function

    Function obtenerUsuarioFD() As String
        Return My.Settings.usuarioFD
    End Function

    Function contrasenaFD() As String
        Return My.Settings.contrasenaFD
    End Function

    Function obtenerFolio() As Integer
        Return My.Settings.folio
    End Function

    Function obtenerRutaCertificado() As String
        Return My.Settings.rutaCertificado
    End Function

    Function obtenerRutaPFX() As String
        Return My.Settings.rutaPFX
    End Function

    Function obtenerContrasenaPFX() As String
        Return My.Settings.contrasenaPFX
    End Function

    Function obtenerEmisorRFC() As String
        Return My.Settings.emisorRFC
    End Function

    Function obtenerEmisorRazonSocial() As String
        Return My.Settings.emisorRazonSocial
    End Function

    Function obtenerEmisorRegimenFiscal() As String
        Return My.Settings.emisorRegimenFiscal
    End Function

    Function obtenerEmisorLugarExpedicion() As String
        Return My.Settings.emisorLugarExpedicion
    End Function

    Sub guadarConfiguracionConexion(ByVal usuarioFD As String, ByVal contrasenaFD As String)
        My.Settings.usuarioFD = usuarioFD
        My.Settings.contrasenaFD = contrasenaFD
        My.Settings.Save()
    End Sub

    Sub guadarConfiguracionInformacionFiscal(ByVal rfc As String, ByVal razonSocial As String, ByVal regimenFiscal As String, ByVal lugarExpedicion As String)
        My.Settings.emisorRFC = rfc
        My.Settings.emisorRazonSocial = razonSocial
        My.Settings.emisorRegimenFiscal = regimenFiscal
        My.Settings.emisorLugarExpedicion = lugarExpedicion
        My.Settings.Save()
    End Sub

    Sub guadarConfiguracionFacturacion(ByVal rutaXMLST As String, ByVal rutaXML As String, ByVal rutaPFX As String, ByVal contraPFX As String, ByVal rutaCertificado As String)
        My.Settings.rutaXMLST = rutaXMLST
        My.Settings.rutaXML = rutaXML
        My.Settings.rutaPFX = rutaPFX
        My.Settings.contrasenaPFX = contraPFX
        My.Settings.rutaCertificado = rutaCertificado
        ' My.Settings.Host = Host
        My.Settings.Save()
    End Sub

    Function obtenerBase64PFXCancelacion() As String
        Return My.Settings.Base64PFXCancelacion
    End Function
    Function obtenerSerieFactura() As String
        Return My.Settings.SerieFactura
    End Function
    'Function obtenerConexionds() As String
    '    My.Settings.Host = "facturacion33.arasis.com.mx"
    '    My.Settings.Save()
    '    Dim cadena As String = String.Empty
    '    cadena += "Data Source="
    '    cadena += My.Settings.Host & ";"
    '    cadena += "Database="
    '    cadena += My.Settings.Database & ";"
    '    cadena += "User ID="
    '    cadena += My.Settings.DBUser & ";"
    '    cadena += "password="
    '    cadena += My.Settings.DBPassword
    '    Return cadena
    'End Function
    Function obtenerConexionDB() As String
        'If Variables.rfc_login = "DSP061215SL4" Then
        '    Dim cadena As String = String.Empty
        '    cadena += "Data Source=DSP061215SL4.arasis.com.mx;Initial Catalog=arasisco_ds_petroleos;Integrated Security=False;User ID=arasisco_ds_petroleos;Password=Aramos1977@;Connect Timeout=15;Encrypt=False;Packet Size=4096"
        '    Return cadena
        'End If
        'If Variables.rfc_login = "OCD120403JU9" Then
        '    Dim cadena As String = String.Empty
        '    cadena += "Data Source=OCD120403JU9.arasis.com.mx;Initial Catalog=arasisco_dwf;Integrated Security=False;User ID=arasisco_dwf;Password=Aramos1977@;Connect Timeout=15;Encrypt=False;Packet Size=4096"
        '    Return cadena
        'End If
        If Variables.rfc_login = "TEST010203001" Then
            Dim cadena As String = String.Empty
            cadena += "Data Source=192.168.1.200;Initial Catalog=BD_LLANTASREGIO;Integrated Security=False;User ID=sa;Password=Ximena2005;Connect Timeout=15;Encrypt=False;Packet Size=4096"
            Return cadena
        End If
        If Variables.rfc_login = "FEHJ730109BC9" Then
            Dim cadena As String = String.Empty
            cadena += "Data Source=FEHJ730109BC9.arasis.com.mx;Initial Catalog=arasisco_FEHJ730109BC9;Integrated Security=False;User ID=arasisco_juliofernandez;Password=Aramos1977@;Connect Timeout=15;Encrypt=False;Packet Size=4096"
            Return cadena
        End If
    End Function

    Function ProbarConexion() As Boolean
        Dim conn As MySQLQ = New MySQLQ
        conn.EjecutaSQL("SELECT * FROM tblctipocomprobante")
        If conn.[Error] IsNot Nothing Then Return False
        Return True
    End Function

    Function obtenerTiposComprobante() As List(Of cTipoComprobante)
        Dim lista As List(Of cTipoComprobante) = New List(Of cTipoComprobante)()
        Dim conn As MySQLQ = New MySQLQ
        conn.EjecutaSQL("select * from tblctipocomprobante")
        For Each r As DataRow In conn.Tabla.Rows
            lista.Add(New cTipoComprobante(Integer.Parse(r("id").ToString()), r("tipoComprobante").ToString(), r("descripcion").ToString()))
        Next
        Return lista
    End Function

    Function obtenerRegimenesFiscales() As List(Of cRegimenFiscal)
        Dim lista As List(Of cRegimenFiscal) = New List(Of cRegimenFiscal)()
        Dim conn As MySQLQ = New MySQLQ
        conn.EjecutaSQL("select * from tblcregimenfiscal")
        For Each r As DataRow In conn.Tabla.Rows
            lista.Add(New cRegimenFiscal(r("id"), r("regimenFiscal").ToString(), r("descripcion").ToString()))
        Next

        Return lista
    End Function

    Function obtenerMonedas() As List(Of cMoneda)
        Dim lista As List(Of cMoneda) = New List(Of cMoneda)()
        Dim conn As MySQLQ = New MySQLQ
        conn.EjecutaSQL("select * from tblcMoneda")
        For Each r As DataRow In conn.Tabla.Rows
            lista.Add(New cMoneda(Integer.Parse(r("id").ToString()), r("moneda").ToString(), r("descripcion").ToString()))
        Next

        Return lista
    End Function

    Function obtenerFormasPago() As List(Of cFormaPago)
        Dim lista As List(Of cFormaPago) = New List(Of cFormaPago)()
        Dim conn As MySQLQ = New MySQLQ
        conn.EjecutaSQL("select * from tblcformapago")
        For Each r As DataRow In conn.Tabla.Rows
            lista.Add(New cFormaPago(Integer.Parse(r("id").ToString()), r("formaPago").ToString(), r("descripcion").ToString()))
        Next

        Return lista
    End Function

    Function obtenerMetodosPago() As List(Of cMetodoPago)
        Dim lista As List(Of cMetodoPago) = New List(Of cMetodoPago)()
        Dim conn As MySQLQ = New MySQLQ
        conn.EjecutaSQL("select * from tblcmetodopago")
        For Each r As DataRow In conn.Tabla.Rows
            lista.Add(New cMetodoPago(Integer.Parse(r("id").ToString()), r("metodoPago").ToString(), r("descripcion").ToString()))
        Next

        Return lista
    End Function

    Function obtenerClavesProdServ() As List(Of cClaveProdServ)
        Dim lista As List(Of cClaveProdServ) = New List(Of cClaveProdServ)()
        Dim conn As MySQLQ = New MySQLQ
        conn.EjecutaSQL("select * from tblcclaveprodserv ORDER BY descripcion")
        lista = (From dr In conn.Tabla.Rows Select New cClaveProdServ() With {.Id = Integer.Parse(dr("id").ToString()), .ClaveProdServ = dr("claveProdServ").ToString(), .Descripcion = dr("descripcion").ToString()}).ToList()
        Return lista
    End Function

    Function obtenerClavesUnidad() As List(Of cClaveUnidad)
        Dim lista As List(Of cClaveUnidad) = New List(Of cClaveUnidad)()
        Dim conn As MySQLQ = New MySQLQ
        conn.EjecutaSQL("select * from tblcclaveunidad ORDER BY nombre")
        For Each r As DataRow In conn.Tabla.Rows
            lista.Add(New cClaveUnidad(Integer.Parse(r("id").ToString()), r("claveUnidad").ToString(), r("nombre").ToString()))
        Next

        Return lista
    End Function

    Function obtenerUsosCfdi() As List(Of cUsoCFDI)
        Dim lista As List(Of cUsoCFDI) = New List(Of cUsoCFDI)()
        Dim conn As MySQLQ = New MySQLQ
        conn.EjecutaSQL("select * from tblcusocfdi")
        For Each r As DataRow In conn.Tabla.Rows
            lista.Add(New cUsoCFDI() With {.Id = Integer.Parse(r("id").ToString()), .Descripcion = r("descripcion").ToString(), .UsoCFDI = r("usoCfdi").ToString()})
        Next
        Return lista
    End Function
    Function obtenerActividades() As List(Of cActividad)
        Dim lista As List(Of cActividad) = New List(Of cActividad)()
        Dim conn As MySQLQ = New MySQLQ
        conn.EjecutaSQL("select * from tblcActividad;")
        For Each r As DataRow In conn.Tabla.Rows
            lista.Add(New cActividad() With {.Descripcion = r("descripcion").ToString(), .Actividad = r("actividad").ToString()})
        Next
        Return lista
    End Function
    Function obtenerSubactividades(ByVal actividad As String) As List(Of cSubactividad)
        Dim lista As List(Of cSubactividad) = New List(Of cSubactividad)()
        Dim conn As MySQLQ = New MySQLQ
        conn.EjecutaSQL("select * from tblcSubactividad where actividad = '" + actividad + "';")
        For Each r As DataRow In conn.Tabla.Rows
            lista.Add(New cSubactividad() With {.Actividad = r("actividad").ToString(), .Descripcion = r("descripcion").ToString(), .Subactividad = r("subactividad").ToString()})
        Next
        Return lista
    End Function
    Function obtenerTareas(ByVal subactividad As String) As List(Of cTarea)
        Dim lista As List(Of cTarea) = New List(Of cTarea)()
        Dim conn As MySQLQ = New MySQLQ
        conn.EjecutaSQL("select * from tblcTareas where subactividad = '" + subactividad + "';")
        For Each r As DataRow In conn.Tabla.Rows
            lista.Add(New cTarea() With {.Tarea = r("tarea").ToString(), .Actividad = r("actividad").ToString(), .Descripcion = r("descripcion").ToString(), .Subactividad = r("subactividad").ToString()})
        Next
        Return lista
    End Function
    Function obtenerPedimentos() As List(Of cClavePedimento)
        Dim lista As List(Of cClavePedimento) = New List(Of cClavePedimento)()
        Dim conn As MySQLQ = New MySQLQ
        conn.EjecutaSQL("select * from tblcClavePedimento ORDER BY descripcion")
        For Each r As DataRow In conn.Tabla.Rows
            lista.Add(New cClavePedimento() With {.ClavePedimento = r("clavePedimento").ToString(), .Descripcion = r("descripcion").ToString()})
        Next
        Return lista
    End Function
    Function obtenerPagoPedimentos() As List(Of cClavePagoPedimento)
        Dim lista As List(Of cClavePagoPedimento) = New List(Of cClavePagoPedimento)()
        Dim conn As MySQLQ = New MySQLQ
        conn.EjecutaSQL("select * from tblcClavePagoPedimento order by descripcion")
        For Each r As DataRow In conn.Tabla.Rows
            lista.Add(New cClavePagoPedimento() With {.ClavePagoPedimento = r("clavePagoPedimento").ToString(), .Descripcion = r("descripcion").ToString()})
        Next
        Return lista
    End Function

    Function obtenerClientes() As List(Of Cliente)
        Dim conn As MySQLQ = New MySQLQ
        conn.EjecutaSQL("SELECT * FROM tblClientes")
        Dim clientes As List(Of Cliente) = New List(Of Cliente)()
        clientes = (From dr In conn.Tabla.Rows Select New Cliente() With {.IdCliente = dr("idCliente").ToString(), .RFC = dr("rfc").ToString(), .RazonSocial = dr("razonSocial").ToString(), .Calle = dr("calle").ToString(), .NumeroInterior = dr("numeroInt").ToString(), .NumeroExterior = dr("numeroExt").ToString(), .Colonia = dr("colonia").ToString(), .Localidad = dr("localidad").ToString(), .Referencia = dr("Referencia").ToString(), .CP = dr("cp").ToString(), .Municipio = dr("municipio").ToString(), .Estado = dr("estado").ToString(), .Pais = dr("pais").ToString(), .IdUsoCFDI = dr("idUsoCfdi").ToString()}).ToList()
        Return clientes
    End Function

    Sub guardarCliente(ByVal rfc As String, ByVal razonSocial As String, ByVal idUsoCfdi As String, ByVal calle As String, ByVal numeroExt As String, ByVal numeroInt As String, ByVal colonia As String, ByVal localidad As String, ByVal referencia As String, ByVal municipio As String, ByVal estado As String, ByVal pais As String, ByVal codigoPostal As String)
        Dim cadena As String
        cadena = "INSERT INTO tblclientes (rfc, razonSocial, idUsoCfdi, calle, numeroExt, numeroInt, colonia, localidad, referencia, municipio, estado, pais, cp,usuario) VALUES ("
        cadena += "'" & rfc & "', "
        cadena += "'" & razonSocial & "', "
        cadena += "'" & idUsoCfdi & "', "
        cadena += "'" & calle & "', "
        cadena += "'" & numeroExt & "', "
        cadena += "'" & numeroInt & "', "
        cadena += "'" & colonia & "', "
        cadena += "'" & localidad & "', "
        cadena += "'" & referencia & "', "
        cadena += "'" & municipio & "', "
        cadena += "'" & estado & "', "
        cadena += "'" & pais & "', "
        cadena += "'" & codigoPostal & "',"
        cadena += "'" & Variables.USUARIO_SISTEMA & "');"
        Dim conn As MySQLQ = New MySQLQ
        conn.EjecutaSQL(cadena)
    End Sub

    Sub eliminarCliente(ByVal idCliente As Object)
        Dim conn As MySQLQ = New MySQLQ
        conn.EjecutaSQL("DELETE FROM tblclientes where idCliente =" & idCliente & ";")
    End Sub

    Function buscarClaveProductos(ByVal filtro As String) As List(Of cClaveProdServ)
        Dim lista As List(Of cClaveProdServ) = New List(Of cClaveProdServ)()
        Dim conn As MySQLQ = New MySQLQ
        conn.EjecutaSQL("select * from tblcclaveprodserv WHERE (UPPER(descripcion) LIKE '%" & filtro & "%') ;")
        lista = (From dr In conn.Tabla.Rows Select New cClaveProdServ() With {.Id = Integer.Parse(dr("id").ToString()), .ClaveProdServ = dr("claveProdServ").ToString(), .Descripcion = dr("descripcion").ToString()}).ToList()
        Return lista
    End Function

    Function buscarUnidades(ByVal filtro As String) As List(Of cClaveUnidad)
        Dim lista As List(Of cClaveUnidad) = New List(Of cClaveUnidad)()
        Dim conn As MySQLQ = New MySQLQ
        conn.EjecutaSQL("select * from tblcclaveunidad WHERE (UPPER(nombre) LIKE '%" & filtro & "%') ;")
        For Each r As DataRow In conn.Tabla.Rows
            lista.Add(New cClaveUnidad(Integer.Parse(r("id").ToString()), r("claveUnidad").ToString(), r("nombre").ToString()))
        Next

        Return lista
    End Function

    Sub guardarProducto(ByVal idClaveProdServ As String, ByVal idClaveUnidad As String, ByVal unidad As String, ByVal noIdentificacion As String, ByVal descripcion As String, ByVal precio As Decimal)
        Dim cadena As String
        cadena = "INSERT INTO tblProductos (codigo, descripcion, precio, unidad, idClaveProdServ, idClaveUnidad,usuario) VALUES ("
        cadena += "'" & noIdentificacion & "', "
        cadena += "'" & descripcion & "', "
        cadena += "'" & precio.ToString() & "', "
        cadena += "'" & unidad & "', "
        cadena += "'" & idClaveProdServ & "', "
        cadena += "'" & idClaveUnidad & "', "
        cadena += "'" & Variables.USUARIO_SISTEMA & "');"
        Dim conn As MySQLQ = New MySQLQ
        conn.EjecutaSQL(cadena)
    End Sub

    Function obtenerProductos() As List(Of Producto)
        Dim conn As MySQLQ = New MySQLQ
        conn.EjecutaSQL("SELECT * FROM tblProductos")
        Dim clientes As List(Of Producto) = New List(Of Producto)()
        clientes = (From dr In conn.Tabla.Rows Select New Producto() With {.IdProducto = dr("idProducto").ToString(), .Codigo = dr("codigo").ToString(), .Descripcion = dr("descripcion").ToString(), .IdClaveProdServ = dr("idClaveProdServ").ToString(), .IdUnidad = dr("idClaveUnidad").ToString(), .Precio = Single.Parse(dr("precio").ToString()), .Unidad = dr("unidad").ToString()}).ToList()
        Return clientes
    End Function

    Sub eliminarProducto(ByVal idProducto As Object)
        Dim conn As MySQLQ = New MySQLQ
        conn.EjecutaSQL("DELETE FROM tblProductos where idProducto =" & idProducto & ";")
    End Sub

    Function buscarProductos(ByVal filtro As String) As List(Of Producto)
        Dim conn As MySQLQ = New MySQLQ
        conn.EjecutaSQL("select * from tblProductos WHERE (UPPER(codigo) LIKE '%" & filtro & "%') ;")
        Dim clientes As List(Of Producto) = New List(Of Producto)()
        clientes = (From dr In conn.Tabla.Rows Select New Producto() With {.IdProducto = dr("idProducto").ToString(), .Codigo = dr("codigo").ToString(), .Descripcion = dr("descripcion").ToString(), .IdClaveProdServ = dr("idClaveProdServ").ToString(), .IdUnidad = dr("idClaveUnidad").ToString(), .Precio = Single.Parse(dr("precio").ToString()), .Unidad = dr("unidad").ToString()}).ToList()
        Return clientes
    End Function
    Function guardarUsuario(ByVal usuario As String, ByVal empresa As String, ByVal nivel As String, ByVal email As String, ByVal password As String)
        Dim cadena As String
        cadena = "UPDATE [dbo].[arasis_usuarios] SET "
        cadena += "[us_nombre]= '" & usuario & "', "
        cadena += "[us_empresa] = '" & empresa & "', "
        cadena += "[us_nivel] = '" & nivel & "', "
        cadena += "[us_mail] = '" & email & "', "
        cadena += "[us_pass] = ENCRYPTBYPASSPHRASE('Desk', '" & password & "', 1, CONVERT(varbinary,'ARASIS')) "
        cadena += " WHERE [us_nombre] = '" & Variables.USUARIO_SISTEMA & "'; "
        Dim conn As MySQLQ = New MySQLQ
        conn.EjecutaSQL(cadena)
    End Function
End Module


