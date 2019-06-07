Imports System.Data.SqlClient
Imports System.IO
Imports SpreadsheetLight
Imports System.Xml
Imports System.Math
Imports System.Net
Imports TipodeCambio.Banxico
Imports System.ServiceModel
Imports <xmlns:bm=’http://www.banxico.org.mx/structure/key_families/dgie/sie/series/compact‘>

Public Class Principal
    Dim error_timbrado As String
    Dim contador_timer As Integer
    Dim rutaPDF As String
    Dim contador As Byte = 4
    Dim contador2 As Byte = 95
    Public Const CEROS_MAX = 6
    Private _c As Comprobante
    Private bs As BindingSource = New BindingSource()
    Private bsComprobante As BindingSource = New BindingSource()
    Private _editarConcepto As Boolean = False
    Private _editarConceptoIndex As Integer
    Dim archivo As String
    Dim sFile As String
    Dim sName As String
    Dim sExt As String
    Dim sPath As String
    Dim idCveProdSer As String
    Dim idCvedUnidad As String
    '****************************************XML ENCABEZADO
    Dim Folio As String
    Dim Version_xml As String
    Dim Serie As String
    Dim Fecha As String
    Dim LugarExpedicion As String
    Dim NumCtaPago As String
    Dim TipoComprobante As String
    Dim CondicionesPago As String
    Dim MetodoPago As String
    Dim FormaPago As String
    Dim TipoCambio As String
    Dim Moneda As String
    Dim SubTotal As String
    Dim Total As String
    Dim Certificado As String
    Dim NoCertificado As String
    Dim Sello As String
    Dim Descuento As String
    Dim TipoRelacion As String
    Dim RelacionadosUUID As String
    Dim Emirfc As String
    Dim EmiNombre As String
    Dim EmiCalle As String
    Dim EminoExterior As String
    Dim EminoInterior As String
    Dim EmiColonia As String
    Dim Emilocalidad As String
    Dim EmiMunicipio As String
    Dim EmiEstado As String
    Dim EmiPais As String
    Dim EmiCodigoPostal As String
    Dim EmiRegimenFiscal As String
    Dim Receprfc As String
    Dim RecepNombre As String
    Dim UsoCFDI As String
    Dim NumRegIdTrib As String
    Dim ResidenciaFiscal As String
    Dim RecepCalle As String
    Dim RecepnoExterior As String
    Dim RecepnoInterior As String
    Dim RecepColonia As String
    Dim RecepLocalidad As String
    Dim RecepMunicipio As String
    Dim RecepEstado As String
    Dim RecepPais As String
    Dim RecepCodigoPostal As String
    Dim TotalImpuestosTrasladados As String
    Dim TotalImpuestosRetenidos As String
    Dim RetencionesTotalImporte As String
    Dim RetencionesTotalImpuesto As String
    Dim TrasladosTotalImporte As String
    Dim TrasladosTotalTasaOCuota As String
    Dim TrasladosTotalTipoFactor As String
    Dim TrasladosTotalImpuesto As String
    Dim VersionTimbreFiscal As String
    Dim xsiSchemaLocation As String
    Dim selloSAT As String
    Dim noCertificadoSAT As String
    Dim selloCFD As String
    Dim FechaTimbrado As String
    Dim UUID As String
    Dim RfcProvCertif As String
    Dim IVA As String
    Dim IEPS As String
    Dim rfc_user As String
    '******************************************************DETALLE XML
    Dim idDetalle As String
    Dim Cantidad As String
    Dim Descripcion As String
    Dim Unidad As String
    Dim ValorUnitario As String
    Dim Importe As String
    Dim NoIdentificacion As String
    Dim ClaveUnidad As String
    Dim ClaveProdServ As String
    Dim TrasladoImporte As String
    Dim TrasladoTasaOCuota As String
    Dim TrasladoTipoFactor As String
    Dim TrasladoImpuesto As String
    Dim TrasladoBase As String
    Dim RetencionImporte As String
    Dim RetencionTasaOCuota As String
    Dim RetencionTipoFactor As String
    Dim RetencionImpuesto As String
    Dim RetencionBase As String
    Dim CuentaPredialNumero As String
    Dim InformacionAduaneraNumeroPedimento As String
    Dim ParteImporte As String
    Dim ParteValorUnitario As String
    Dim ParteDescripcion As String
    Dim ParteUnidad As String
    Dim ParteCantidad As String
    Dim ParteNoIdentificacion As String
    Dim ParteClaveProdServ As String
    '******************************************************ADDENDA
    Dim adenda_folio As String
    Dim adenda_renglon As String
    Dim adenda_codigo As String
    Dim adenda_concepto As String
    Dim adenda_unidad_medida As String
    Dim adenda_peso As String
    Dim adenda_referencia As String
    Dim adenda_calibre As String
    Dim adenda_ancho As String
    Dim adenda_metros As String
    Dim adenda_posision As Integer
    Dim consecutivo As Integer
    '*************************************************************
    Dim pos As Integer = 0
    Private table_details As System.Data.DataTable
    Private row_details As System.Data.DataRow
    Dim vistaPreviaPath As String
    '************INTELISIS***************
    Dim FormaPagoTipo As String
    Dim renglon As Integer = 0
    Dim renglonSUB As Integer = 0
    Dim consecutivoIntelisis As Integer
    Dim Intelisis_Unidad As String
    Dim Intelsis_Impuesto1 As String
    Dim Intelsis_CostoReposicion As Double
    Dim Intelisis_CB As String
    Dim ArtIntelisis As String
    Dim artDisponible As Double
    Dim IdIntelisis As Integer
    Dim AutoComp As New AutoCompleteStringCollection()
    Dim AgenteIntelisis As String
    Dim EmpresaIntelisis As String
    Dim CVE_CTE_INTELISIS As String

    Public Sub Principal()
        InitializeComponent()
        RefreshDataBindings()

    End Sub
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        RefreshDataBindings()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If Not DB.ProbarConexion() Then Return

        cbUsoCfdi.ValueMember = "Id"
        cbUsoCfdi.DisplayMember = "ClaveYDescripcion"
        cbUsoCfdi.DataSource = DB.obtenerUsosCfdi()

        cbTipoComprobante.DataSource = DB.obtenerTiposComprobante()
        'CARGA_TIPO_COMPROBANTE()

        cbRegimenesFiscales.DataSource = DB.obtenerRegimenesFiscales()
        ''CARGA_REGIMENES_FISCALES()

        cbFormaPago.DataSource = DB.obtenerFormasPago()
        ''CARGA_FORMAS_PAGO()

        cbMoneda.Items.Add("")
        cbMoneda.DataSource = DB.obtenerMonedas
        ''cargarMonedas()

        cbMetodoPago.DataSource = DB.obtenerMetodosPago()
        ''cargarMetodosPago()

        '' CARGA_CLAVE_PRODUCTOS_SERVICIOS()

        'cbClaveUnidad.ValueMember = "claveUnidad"
        'cbClaveUnidad.DataSource = DB.obtenerClavesUnidad()
        'CARGA_CLAVE_UNIDAD_SERVICIOS()

        'cbClientes.DisplayMember = "RFC"
        'cbClientes.DataSource = DB.obtenerClientes()
        'carga_clientes()
        carga_clientes_intelisis()

        carga_productos()

        carga_agente()
        carga_almacen()
        carga_sucursal()
        carga_concepto()
        carga_condiciones()
        carga_empresa()
        carga_formaPago()

        CARGA_CONSECUTIVO()
        '''carga_uso_cfdi()

        ''cargarDatosDB()

        'cbClaveProdServ.SelectedValue = "50749"
        'cbClaveUnidad.SelectedValue = "1452"
        'tbConceptoDescripcion.Text = "Servicios de cooperativas o consorcios"
        'tbConceptoNoIdentificacion.Text = "80101705"
        'tbConceptoUnidad.Text = "Unidad"
        'nudConceptoValorUnitario.Value = CDec("1")


    End Sub
    Private Sub obtenerCamposConfiguracion()
        _c.Emisor.Nombre = DB.obtenerEmisorRazonSocial()
        _c.Emisor.Rfc = DB.obtenerEmisorRFC()
        _c.LugarExpedicion = DB.obtenerEmisorLugarExpedicion()
        cbRegimenesFiscales.SelectedValue = DB.obtenerEmisorRegimenFiscal()
        bsComprobante.ResetBindings(False)
    End Sub

    Private Sub btnAgregarCliente_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAgregarCliente.Click
        'If rbSinDB.Checked Then
        '    MessageBox.Show("No puedes agregar clientes en el modo sin conexion a DB")
        '    Return
        'End If
        'Dim cliente As wCliente = New wCliente()
        'cliente.ShowDialog()
        'If rbConDB.Checked Then
        '    cbClientes.DisplayMember = "RFC"
        '    cbClientes.DataSource = DB.obtenerClientes()
        'End If
    End Sub
    '*********************CARGA DATOS SIN CONEXION**************************************
    Private Sub cargarDatosSinDB()
        cargarRegimenesFiscales()
        cargarClientes()
        cargarTiposComprobante()
        cargarFormasPago()
        cargarMonedas()
        cargarMetodosPago()
        cargarClavesProdServ()
        cargarClavesUnidad()
        cargarUsosCfdi()
    End Sub
    Private Sub cargarRegimenesFiscales()
        Dim lista As List(Of cRegimenFiscal) = New List(Of cRegimenFiscal)()
        lista.Add(New cRegimenFiscal(1, "601", "General de Ley Personas Morales"))
        lista.Add(New cRegimenFiscal(2, "603", "Personas Morales con Fines no Lucrativos"))
        lista.Add(New cRegimenFiscal(3, "605", "Sueldos y Salarios e Ingresos Asimilados a Salarios"))
        lista.Add(New cRegimenFiscal(4, "606", "Arrendamiento"))
        lista.Add(New cRegimenFiscal(5, "608", "Demás ingresos"))
        lista.Add(New cRegimenFiscal(6, "609", "Consolidación"))
        lista.Add(New cRegimenFiscal(7, "610", "Residentes en el Extranjero sin Establecimiento Permanente en México"))
        lista.Add(New cRegimenFiscal(8, "611", "Ingresos por Dividendos lista.Add(new cRegimenFiscal(socios y accionistas));"))
        lista.Add(New cRegimenFiscal(9, "612", "Personas Físicas con Actividades Empresariales y Profesionales"))
        lista.Add(New cRegimenFiscal(10, "614", "Ingresos por intereses"))
        lista.Add(New cRegimenFiscal(11, "616", "Sin obligaciones fiscales"))
        lista.Add(New cRegimenFiscal(12, "620", "Sociedades Cooperativas de Producción que optan por diferir sus ingresos"))
        lista.Add(New cRegimenFiscal(13, "621", "Incorporación Fiscal"))
        lista.Add(New cRegimenFiscal(14, "622", "Actividades Agrícolas, Ganaderas, Silvícolas y Pesqueras"))
        lista.Add(New cRegimenFiscal(15, "623", "Opcional para Grupos de Sociedades"))
        lista.Add(New cRegimenFiscal(16, "624", "Coordinados"))
        lista.Add(New cRegimenFiscal(17, "628", "Hidrocarburos"))
        lista.Add(New cRegimenFiscal(18, "607", "Régimen de Enajenación o Adquisición de Bienes"))
        lista.Add(New cRegimenFiscal(19, "629", "De los Regímenes Fiscales Preferentes y de las Empresas Multinacionales"))
        lista.Add(New cRegimenFiscal(20, "630", "Enajenación de acciones en bolsa de valores"))
        lista.Add(New cRegimenFiscal(21, "615", "Régimen de los ingresos por obtención de premios"))
        cbRegimenesFiscales.ValueMember = "RegimenFiscal"
        cbRegimenesFiscales.DataSource = lista
    End Sub
    Private Sub cargarClientes()
        Dim lista As List(Of Cliente) = New List(Of Cliente)()
        lista.Add(New Cliente() With {.RazonSocial = "Faustino Rojas Arellano", .RFC = "TEST010203001", .CP = "74160", .IdUsoCFDI = "1"})
        cbClientes.DisplayMember = "RazonSocial"
        cbClientes.DataSource = lista
    End Sub
    Private Sub cargarTiposComprobante()
        Dim lista As List(Of cTipoComprobante) = New List(Of cTipoComprobante)()
        lista.Add(New cTipoComprobante(1, "I", "Ingreso"))
        lista.Add(New cTipoComprobante(1, "E", "Egreso"))
        lista.Add(New cTipoComprobante(1, "T", "Traslado"))
        lista.Add(New cTipoComprobante(1, "N", "Nomina"))
        lista.Add(New cTipoComprobante(1, "P", "Pago"))
        cbTipoComprobante.DataSource = lista
    End Sub
    Private Sub cargarFormasPago()
        Dim lista As List(Of cFormaPago) = New List(Of cFormaPago)()
        lista.Add(New cFormaPago(1, "01", "Efectivo"))
        lista.Add(New cFormaPago(2, "02", "Cheque nominativo"))
        lista.Add(New cFormaPago(3, "03", "Transferencia electrónica de fondos"))
        lista.Add(New cFormaPago(4, "04", "Tarjeta de crédito"))
        lista.Add(New cFormaPago(5, "05", "Monedero electrónico"))
        lista.Add(New cFormaPago(6, "06", "Dinero electrónico"))
        lista.Add(New cFormaPago(7, "08", "Vales de despensa"))
        lista.Add(New cFormaPago(8, "12", "Dación en pago"))
        lista.Add(New cFormaPago(9, "13", "Pago por subrogación"))
        lista.Add(New cFormaPago(10, "14", "Pago por consignación"))
        lista.Add(New cFormaPago(11, "15", "Condonación"))
        lista.Add(New cFormaPago(12, "17", "Compensación"))
        lista.Add(New cFormaPago(13, "23", "Novación"))
        lista.Add(New cFormaPago(14, "24", "Confusión"))
        lista.Add(New cFormaPago(15, "25", "Remisión de deuda"))
        lista.Add(New cFormaPago(16, "26", "Prescripción o caducidad"))
        lista.Add(New cFormaPago(17, "27", "A satisfacción del acreedor"))
        lista.Add(New cFormaPago(18, "28", "Tarjeta de débito"))
        lista.Add(New cFormaPago(19, "29", "Tarjeta de servicios"))
        lista.Add(New cFormaPago(20, "99", "Por definir"))
        cbFormaPago.DataSource = lista
    End Sub
    Private Sub cargarMonedas()
        Dim lista As List(Of cMoneda) = New List(Of cMoneda)()
        lista.Add(New cMoneda(1, "MXN", "Peso Mexicano"))
        lista.Add(New cMoneda(2, "USD", "Dolar americano"))
        cbMoneda.DataSource = lista
    End Sub
    Private Sub cargarMetodosPago()
        Dim lista As List(Of cMetodoPago) = New List(Of cMetodoPago)()
        lista.Add(New cMetodoPago(1, "PUE", "Pago en una sola exhibición"))
        lista.Add(New cMetodoPago(2, "PIP", "Pago inicial y parcialidades"))
        lista.Add(New cMetodoPago(3, "PPD", "Pago en parcialidades o diferido"))
        cbMetodoPago.DataSource = lista
    End Sub
    Private Sub cargarClavesProdServ()
        Dim lista As List(Of cClaveProdServ) = New List(Of cClaveProdServ)()
        Dim lines As String() = System.IO.File.ReadAllLines(".\dbClaveProdServ.txt", System.Text.Encoding.GetEncoding("iso-8859-1"))
        For Each line As String In lines
            Dim substrings As String() = line.Split(","c)
            If substrings.Count() >= 2 Then lista.Add(New cClaveProdServ(1, substrings(0), substrings(1)))
        Next

        'cbClaveProdServ.DataSource = lista
    End Sub
    Private Sub cargarClavesUnidad()
        Dim lista As List(Of cClaveUnidad) = New List(Of cClaveUnidad)()
        Dim lines As String() = System.IO.File.ReadAllLines(".\dbClaveUnidad.txt", System.Text.Encoding.GetEncoding("iso-8859-1"))
        For Each line As String In lines
            Dim substrings As String() = line.Split(","c)
            If substrings.Count() >= 2 Then lista.Add(New cClaveUnidad(1, substrings(0), substrings(1)))
        Next

        'cbClaveUnidad.DataSource = lista
    End Sub
    Private Sub cargarUsosCfdi()
        Dim lista As List(Of cUsoCFDI) = New List(Of cUsoCFDI)()
        lista.Add(New cUsoCFDI(1, "G01", "Adquisición de mercancias"))
        lista.Add(New cUsoCFDI(2, "G02", "Devoluciones, descuentos o bonificaciones"))
        lista.Add(New cUsoCFDI(3, "G03", "Gastos en general"))
        lista.Add(New cUsoCFDI(4, "I01", "Construcciones"))
        lista.Add(New cUsoCFDI(5, "I02", "Mobilario y equipo de oficina por inversiones"))
        lista.Add(New cUsoCFDI(6, "I03", "Equipo de transporte"))
        lista.Add(New cUsoCFDI(7, "I04", "Equipo de computo y accesorios"))
        lista.Add(New cUsoCFDI(8, "I05", "Dados, troqueles, moldes, matrices y herramental"))
        lista.Add(New cUsoCFDI(9, "G01", "Adquisición de mercancias"))
        lista.Add(New cUsoCFDI(10, "G02", "Devoluciones, descuentos o bonificaciones"))
        lista.Add(New cUsoCFDI(11, "G03", "Gastos en general"))
        lista.Add(New cUsoCFDI(12, "I01", "Construcciones"))
        lista.Add(New cUsoCFDI(13, "I02", "Mobilario y equipo de oficina por inversiones"))
        lista.Add(New cUsoCFDI(14, "I03", "Equipo de transporte"))
        lista.Add(New cUsoCFDI(15, "I04", "Equipo de computo y accesorios"))
        lista.Add(New cUsoCFDI(16, "I05", "Dados, troqueles, moldes, matrices y herramental"))
        lista.Add(New cUsoCFDI(17, "I06", "Comunicaciones telefónicas"))
        lista.Add(New cUsoCFDI(18, "I07", "Comunicaciones satelitales"))
        lista.Add(New cUsoCFDI(19, "I08", "Otra maquinaria y equipo"))
        lista.Add(New cUsoCFDI(20, "D01", "Honorarios médicos, dentales y gastos hospitalarios."))
        lista.Add(New cUsoCFDI(21, "D02", "Gastos médicos por incapacidad o discapacidad"))
        lista.Add(New cUsoCFDI(22, "D03", "Gastos funerales."))
        lista.Add(New cUsoCFDI(23, "D04", "Donativos."))
        lista.Add(New cUsoCFDI(24, "D05", "Intereses reales efectivamente pagados por créditos hipotecarios (casa habitación)."))
        lista.Add(New cUsoCFDI(25, "D06", "Aportaciones voluntarias al SAR."))
        lista.Add(New cUsoCFDI(26, "D07", "Primas por seguros de gastos médicos."))
        lista.Add(New cUsoCFDI(27, "D08", "Gastos de transportación escolar obligatoria."))
        lista.Add(New cUsoCFDI(28, "D09", "Depósitos en cuentas para el ahorro, primas que tengan como base planes de pensiones."))
        lista.Add(New cUsoCFDI(29, "D10", "Pagos por servicios educativos (colegiaturas)"))
        lista.Add(New cUsoCFDI(30, "P01", "Por definir"))
        lista.Add(New cUsoCFDI(31, "I06", "Comunicaciones telefónicas"))
        lista.Add(New cUsoCFDI(32, "I07", "Comunicaciones satelitales"))
        lista.Add(New cUsoCFDI(33, "I08", "Otra maquinaria y equipo"))
        lista.Add(New cUsoCFDI(34, "D01", "Honorarios médicos, dentales y gastos hospitalarios."))
        lista.Add(New cUsoCFDI(35, "D02", "Gastos médicos por incapacidad o discapacidad"))
        lista.Add(New cUsoCFDI(36, "D03", "Gastos funerales."))
        lista.Add(New cUsoCFDI(37, "D04", "Donativos."))
        lista.Add(New cUsoCFDI(38, "D05", "Intereses reales efectivamente pagados por créditos hipotecarios (casa habitación)."))
        lista.Add(New cUsoCFDI(39, "D06", "Aportaciones voluntarias al SAR."))
        lista.Add(New cUsoCFDI(40, "D07", "Primas por seguros de gastos médicos."))
        lista.Add(New cUsoCFDI(41, "D08", "Gastos de transportación escolar obligatoria."))
        lista.Add(New cUsoCFDI(42, "D09", "Depósitos en cuentas para el ahorro, primas que tengan como base planes de pensiones."))
        lista.Add(New cUsoCFDI(43, "D10", "Pagos por servicios educativos (colegiaturas)"))
        lista.Add(New cUsoCFDI(44, "P01", "Por definir"))
        cbUsoCfdi.ValueMember = "Id"
        cbUsoCfdi.DisplayMember = "ClaveYDescripcion"
        cbUsoCfdi.DataSource = lista
    End Sub
    '*********************CARGA DATOS CON CONEXION**************************************
    Private Sub cargarDatosDB()
        If Not DB.ProbarConexion() Then Return
        cbTipoComprobante.DataSource = DB.obtenerTiposComprobante()
        cbRegimenesFiscales.DataSource = DB.obtenerRegimenesFiscales()

        cbFormaPago.DataSource = DB.obtenerFormasPago()
        cbMoneda.DataSource = DB.obtenerMonedas()
        cbMetodoPago.DataSource = DB.obtenerMetodosPago()
        'cbClaveProdServ.ValueMember = "claveProdServ"
        'Id, claveProdServ"
        'cbClaveProdServ.DataSource = DB.obtenerClavesProdServ()

        'cbClaveUnidad.ValueMember = "claveUnidad"
        'cbClaveUnidad.DataSource = DB.obtenerClavesUnidad()


        cbClientes.DisplayMember = "RFC"
        cbClientes.DataSource = DB.obtenerClientes()
        'cbUsoCfdi.ValueMember = "Id"
        'cbUsoCfdi.DisplayMember = "ClaveYDescripcion"
        'cbUsoCfdi.DataSource = DB.obtenerUsosCfdi()

        ''*********************DATOS? EN LOS TEXTBOX***********************
        'tbConceptoDescripcion.Text = "Servicios de cooperativas o consorcios"
        ''cbClaveProdServ.SelectedItem = "80101705- Servicios de cooperativas o consorcios"
        ''tbConceptoNoIdentificacion.Text = "S001"
        ''tbConceptoUnidad.Text = "PZA"

        ''cbClaveUnidad.Text = ""

        ''cbClaveUnidad.SelectedValue = "E48- Unidad de servicio"

        'cbClaveProdServ.SelectedValue = "80101705"
        'cbClaveUnidad.SelectedValue = "E48"
        ''tbConceptoDescripcion.Text = wb.producto.Descripcion
        ''tbConceptoNoIdentificacion.Text = wb.producto.Codigo
        ''tbConceptoUnidad.Text = wb.producto.Unidad
        ''nudConceptoValorUnitario.Value = CDec(wb.producto.Precio)

        'tbConceptoNoIdentificacion.Text = "S001"
        'tbConceptoUnidad.Text = "PZA"
        'tbSerie.Text = "F"
        ''Clave Prod.Serv. 80101705 No. Identificación - S001
        '' E48 - Unidad de servicio

        'cbClaveProdServ.SelectedValue = "50749"
        'cbClaveUnidad.SelectedValue = "1452"
        'tbConceptoDescripcion.Text = "Servicios de cooperativas o consorcios"
        'tbConceptoNoIdentificacion.Text = "80101705"
        'tbConceptoUnidad.Text = "Unidad"
        'nudConceptoValorUnitario.Value = CDec("1")

    End Sub
    Public Sub RefreshDataBindings()
        _c = New Comprobante()
        If _c.Fecha.Year < 1973 Then _c.Fecha = DateTime.Now
        obtenerCamposConfiguracion()
        bsComprobante.DataSource = _c
        tbEmisorRFC.DataBindings.Add("Text", bsComprobante, "Emisor.Rfc", False, DataSourceUpdateMode.OnPropertyChanged)
        tbEmisorRazonSocial.DataBindings.Add("Text", bsComprobante, "Emisor.Nombre", False, DataSourceUpdateMode.OnPropertyChanged)
        tbReceptorRFC.DataBindings.Add("Text", bsComprobante, "Receptor.Rfc", False, DataSourceUpdateMode.OnPropertyChanged)
        nupTipoCambio.DataBindings.Add("Value", bsComprobante, "TipoCambio", False, DataSourceUpdateMode.OnPropertyChanged)
        tbReceptorRazonSocial.DataBindings.Add("Text", bsComprobante, "Receptor.Nombre", False, DataSourceUpdateMode.OnPropertyChanged)
        dtpFecha.DataBindings.Add("Value", bsComprobante, "Fecha", False, DataSourceUpdateMode.OnPropertyChanged)
        tbSerie.DataBindings.Add("Text", bsComprobante, "Serie", False, DataSourceUpdateMode.OnPropertyChanged)
        tbFolio.DataBindings.Add("Text", bsComprobante, "Folio", False, DataSourceUpdateMode.OnPropertyChanged)
        tbConfirmacion.DataBindings.Add("Text", bsComprobante, "Confirmacion", False, DataSourceUpdateMode.OnPropertyChanged)
        tbReceptorResidenciaFiscal.DataBindings.Add("Text", bsComprobante, "Receptor.ResidenciaFiscal", False, DataSourceUpdateMode.OnPropertyChanged)
        tbReceptorNumeroRegistro.DataBindings.Add("Text", bsComprobante, "Receptor.NumRegIdTrib", False, DataSourceUpdateMode.OnPropertyChanged)
        lSubtotal.DataBindings.Add(New Binding("Text", bsComprobante, "SubTotal", True, DataSourceUpdateMode.OnPropertyChanged, 0, "C2"))

        ' lIVA.DataBindings.Add(New Binding("Text", bsComprobante, "I.V.A.", True, DataSourceUpdateMode.OnPropertyChanged, 0, "C2"))
        'lIVA.DataBindings.Add("Text", bsComprobante, "I.V.A.", True, DataSourceUpdateMode.OnPropertyChanged, 0, "C2")

        lTotal.DataBindings.Add("Text", bsComprobante, "Total", True, DataSourceUpdateMode.OnPropertyChanged, 0, "C2")
        lDescuento.DataBindings.Add("Text", bsComprobante, "Descuento", True, DataSourceUpdateMode.OnPropertyChanged, 0, "C2")
        lImporteLetra.DataBindings.Add("Text", bsComprobante, "TotalLetra", False, DataSourceUpdateMode.OnPropertyChanged)
        tbLugarExpedicion.DataBindings.Add("Text", bsComprobante, "LugarExpedicion", False, DataSourceUpdateMode.OnPropertyChanged)

        bs.DataSource = _c.Conceptos

        dgvConceptos.DataSource = bs
        dgvConceptos.AutoGenerateColumns = False
        dgvConceptos.Columns("Impuestos").Visible = False
        dgvConceptos.Columns("CuentaPredial").Visible = False
        dgvConceptos.Columns("ClaveProdServ").DisplayIndex = 0
        dgvConceptos.Columns("NoIdentificacion").DisplayIndex = 2
        dgvConceptos.Columns("ClaveUnidad").DisplayIndex = 3
        dgvConceptos.Columns("Cantidad").DisplayIndex = 4
        dgvConceptos.Columns("Unidad").DisplayIndex = 5
        dgvConceptos.Columns("Descripcion").DisplayIndex = 6
        dgvConceptos.Columns("ValorUnitario").DisplayIndex = 7
        dgvConceptos.Columns("Importe").DisplayIndex = 8
        dgvConceptos.Columns("Descuento").DisplayIndex = 9
        dgvConceptos.Columns("Cantidad").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvConceptos.Columns("Importe").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvConceptos.Columns("ValorUnitario").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvConceptos.Columns("Descuento").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvConceptos.Columns("Descuento").DefaultCellStyle.Format = "C2"
        dgvConceptos.Columns("ValorUnitario").DefaultCellStyle.Format = "C2"
        dgvConceptos.Columns("Importe").DefaultCellStyle.Format = "C2"
        dgvConceptos.Columns("Complemento").Visible = False

        'Dim colImpuestos As DataGridViewLinkColumn = New DataGridViewLinkColumn()
        'colImpuestos.Name = "LImpuestos"
        'colImpuestos.HeaderText = "I"
        'colImpuestos.Text = "I"
        'colImpuestos.DataPropertyName = "LImpuestos1"
        'colImpuestos.ToolTipText = "Impuestos"

        'Dim colEditar As DataGridViewButtonColumn = New DataGridViewButtonColumn()
        'colEditar.Name = "LEditar"
        'colEditar.HeaderText = "Editar"
        'colEditar.Text = "E"
        'colEditar.DataPropertyName = "LEditar"
        'colEditar.ToolTipText = "Editar"

        Dim colEliminar As DataGridViewButtonColumn = New DataGridViewButtonColumn()
        colEliminar.Name = "LEliminar"
        colEliminar.HeaderText = "Eliminar"
        colEliminar.Text = "Eliminar"
        colEliminar.DataPropertyName = "LEditar"
        colEliminar.ToolTipText = "Eliminar"


        'Dim colVentaVehiculos As DataGridViewLinkColumn = New DataGridViewLinkColumn()
        'colVentaVehiculos.Name = "LVentaVehiculos"
        'colVentaVehiculos.HeaderText = "VV"
        'colVentaVehiculos.Text = "VV"
        'colVentaVehiculos.DataPropertyName = "LVentaVehiculos1"
        'colVentaVehiculos.ToolTipText = "Complemento venta vehiculos"
        'dgvConceptos.Columns.Insert(12, colImpuestos)
        ' dgvConceptos.Columns.Insert(13, colVentaVehiculos)
        ' dgvConceptos.Columns.Insert(14, colEditar)
        dgvConceptos.Columns.Insert(12, colEliminar)
        'dgvConceptos.Columns("LImpuestos").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        'dgvConceptos.Columns("LVentaVehiculos").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgvConceptos.Refresh()
    End Sub
    Private Sub agregarlink()
        For Each r As DataGridViewRow In dgvConceptos.Rows
            'r.Cells("LImpuestos").Value = "I"
            ' r.Cells("LVentaVehiculos").Value = "V"
            'r.Cells("LEditar").Value = "Editar"
            r.Cells("LEliminar").Value = "Eliminar"
        Next
    End Sub
    Private Function getImpuestos(ByVal conceptos As List(Of Concepto)) As Impuestos
        Dim index As Integer
        Dim traslado As Traslado = New Traslado()
        Dim retencion As Retencion = New Retencion()
        Dim traslados As List(Of Traslado) = New List(Of Traslado)()
        Dim retenciones As List(Of Retencion) = New List(Of Retencion)()
        Dim totalImpuestosRetenidos As Decimal = 0
        Dim totalImpuestosTrasladados As Decimal = 0
        Dim impuestos As Impuestos = New Impuestos()
        For Each c As Concepto In conceptos
            For Each t As TrasladoC In c.Impuestos.Traslados
                If (traslados.Exists(Function(x) (x.Impuesto = t.Impuesto) AndAlso (x.TasaOCuota = t.TasaOCuota))) Then
                    index = traslados.FindIndex(Function(x) x.Impuesto = t.Impuesto)
                    traslados(index).Importe = traslados(index).Importe + t.Importe
                Else
                    traslado = New Traslado()
                    traslado.Importe = t.Importe
                    traslado.Impuesto = t.Impuesto
                    traslado.TasaOCuota = t.TasaOCuota
                    traslado.TipoFactor = t.TipoFactor
                    traslados.Add(traslado)
                End If
            Next

            For Each r As RetencionC In c.Impuestos.Retenciones
                If (retenciones.Exists(Function(x) (x.Impuesto = r.Impuesto))) Then
                    index = traslados.FindIndex(Function(x) x.Impuesto = r.Impuesto)
                    retenciones(index).Importe = retenciones(index).Importe + r.Importe
                Else
                    retencion = New Retencion()
                    retencion.Importe = r.Importe
                    retenciones.Add(retencion)
                End If
            Next
        Next

        For Each r As Retencion In retenciones
            totalImpuestosRetenidos = totalImpuestosRetenidos + r.Importe
        Next

        For Each t As Traslado In traslados
            totalImpuestosTrasladados = totalImpuestosTrasladados + t.Importe
        Next

        impuestos.TotalImpuestosRetenidos = totalImpuestosRetenidos
        impuestos.TotalImpuestosTrasladados = totalImpuestosTrasladados
        impuestos.Traslados = traslados
        impuestos.Retenciones = retenciones
        Return impuestos
    End Function
    Private Sub nudValorUnitario_ValueChanged(sender As Object, e As EventArgs) Handles nudConceptoValorUnitario.ValueChanged, nudConceptoCantidad.ValueChanged
        nudConceptoImporte.Value = nudConceptoCantidad.Value * nudConceptoValorUnitario.Value
    End Sub
    Private Function hayErrorConcepto() As Boolean
        Dim hayError As Boolean = False
        'If cbClaveProdServ.SelectedItem Is Nothing Then
        '    lError.Text = "El campo Clave de producto es obligatorio"
        '    hayError = True
        'ElseIf cbClaveUnidad.SelectedItem Is Nothing Then
        '    lError.Text = "El campo Clave de unidad es obligatorio"
        '    hayError = True
        'ElseIf tbConceptoDescripcion.Text.Trim() = String.Empty Then
        '    lError.Text = "El campo Descripción es obligatorio"
        '    hayError = True
        'ElseIf nudConceptoImporte.Value <= 0 Then
        '    lError.Text = "El importe debe ser mayor que cero"
        '    hayError = True
        'End If


        '****+***********modificacion alex ramos 31/03/2019
        If txtClaveProducto.Text = "" Then
            lError.Text = "El campo Clave de producto es obligatorio"
            hayError = True
        ElseIf txtDescProdServ.Text = "" Then
            lError.Text = "El campo Clave de unidad es obligatorio"
            hayError = True
        ElseIf tbConceptoDescripcion.Text.Trim() = String.Empty Then
            lError.Text = "El campo Descripción es obligatorio"
            hayError = True
        ElseIf nudConceptoImporte.Value <= 0 Then
            lError.Text = "El importe debe ser mayor que cero"
            hayError = True
        End If


        If hayError Then
            tlpError.Visible = True
            timer1.Enabled = True
        End If

        Return hayError
    End Function
    Private Function getImpuestosConcepto() As ImpuestosC
        Dim impuesto As ImpuestosC = New ImpuestosC()
        If ckImpuestoTrasladoIVA0.Checked Then
            impuesto.Traslados.Add(New TrasladoC() With {.TasaOCuota = 0D, .Base = (nudConceptoValorUnitario.Value * nudConceptoCantidad.Value) - nudConceptoDescuento.Value, .Impuesto = "002", .Importe = ((nudConceptoValorUnitario.Value * nudConceptoCantidad.Value) - nudConceptoDescuento.Value) * 0D, .TipoFactor = "Tasa"})
        End If

        If ckImpuestoTrasladoIVA16.Checked Then
            impuesto.Traslados.Add(New TrasladoC() With {.TasaOCuota = 0.16D, .Base = (nudConceptoValorUnitario.Value * nudConceptoCantidad.Value) - nudConceptoDescuento.Value, .Impuesto = "002", .Importe = ((nudConceptoValorUnitario.Value * nudConceptoCantidad.Value) - nudConceptoDescuento.Value) * 0.16D, .TipoFactor = "Tasa"})
        End If

        Return impuesto
    End Function

    Private Sub btnConceptoAgregar_Click(sender As Object, e As EventArgs) Handles btnConceptoAgregar.Click
        If (_editarConcepto) Then
            If hayErrorConcepto() Then Return
            If (_editarConceptoIndex >= 0) Then
                Dim c As Concepto = New Concepto()

                c.Importe = nudConceptoImporte.Value
                c.Cantidad = nudConceptoCantidad.Value

                'If cbClaveProdServ.SelectedItem IsNot Nothing Then c.ClaveProdServ = (CType(cbClaveProdServ.SelectedItem, cClaveProdServ)).ClaveProdServ
                'If cbClaveUnidad.SelectedItem IsNot Nothing Then c.ClaveUnidad = (CType(cbClaveUnidad.SelectedItem, cClaveUnidad)).ClaveUnidad


                c.ClaveProdServ = txtClaveProducto.Text.Trim
                c.ClaveUnidad = txtCvedUnidad.Text.Trim

                c.Descripcion = tbConceptoDescripcion.Text.Trim()
                c.Descuento = nudConceptoDescuento.Value
                c.Importe = nudConceptoImporte.Value
                c.NoIdentificacion = tbConceptoNoIdentificacion.Text
                c.Unidad = tbConceptoUnidad.Text
                c.ValorUnitario = nudConceptoValorUnitario.Value
                c.Impuestos = getImpuestosConcepto()

                _c.Conceptos(_editarConceptoIndex) = c

                bs.ResetBindings(False)
                agregarlink()
                calculaTotales()
                limpiarCampos()
                btnConceptoAgregar.Text = "Agregar"
                'btnLimpiarCampos.Text = "Limpiar"
                _editarConcepto = False
            End If
        Else
            If hayErrorConcepto() Then Return
            '  For i = 0 To 3
            Dim c As Concepto = New Concepto()
            c.Importe = nudConceptoImporte.Value
            c.Cantidad = nudConceptoCantidad.Value

            'If cbClaveProdServ.SelectedItem IsNot Nothing Then c.ClaveProdServ = (CType(cbClaveProdServ.SelectedItem, cClaveProdServ)).ClaveProdServ
            'If cbClaveUnidad.SelectedItem IsNot Nothing Then c.ClaveUnidad = (CType(cbClaveUnidad.SelectedItem, cClaveUnidad)).ClaveUnidad

            c.ClaveProdServ = txtClaveProducto.Text.Trim
            c.ClaveUnidad = txtCvedUnidad.Text.Trim

            c.Descripcion = tbConceptoDescripcion.Text.Trim()
            c.Descuento = nudConceptoDescuento.Value
            c.Importe = nudConceptoImporte.Value
            c.NoIdentificacion = tbConceptoNoIdentificacion.Text
            c.Unidad = tbConceptoUnidad.Text
            c.ValorUnitario = nudConceptoValorUnitario.Value

            c.Impuestos = getImpuestosConcepto()

            _c.Conceptos.Add(c)

            bs.ResetBindings(False)

            '  Next
            agregarlink()
            calculaTotales()
            limpiarCampos()
        End If

    End Sub
    Private Sub calculaTotales()
        _c.Impuestos = getImpuestos(_c.Conceptos)
        Dim subtotal As Decimal = 0D
        Dim descuento As Decimal = 0D
        Dim iva As Decimal = 0D
        For Each c As Concepto In _c.Conceptos
            subtotal = subtotal + c.Importe
            descuento = c.Descuento
        Next
        Dim total_iva As Decimal = 0

        _c.SubTotal = subtotal
        _c.Descuento = descuento
        _c.Total = _c.SubTotal + _c.Impuestos.TotalImpuestosRetenidos + _c.Impuestos.TotalImpuestosTrasladados

        total_iva = _c.Impuestos.TotalImpuestosRetenidos + _c.Impuestos.TotalImpuestosTrasladados

        lIVA.Text = ""
        lIVA.Text = Format(total_iva, "$###,###,###.#0")

        '  _c.TotalLetra = New Numalet().ToCustomString(_c.Total)

        Dim Timporte As Decimal = _c.Total

        Timporte = Round(Timporte, 2)

        Dim NumToLetters As String

        Dim Tmoneda As String = cbMoneda.Text.Trim

        Tmoneda = Tmoneda.Substring(0, 3)
        If Timporte > 0 Then
            NumToLetters = ""
            'La Funcion es llamada GetMyNumberToWords es llamada de la siguiente manera desde el evento Change de un txtbox
            Dim largo = Len(CStr(Format(CDbl(Timporte), "#,###.00")))
            Dim decimales = Mid(CStr(Format(CDbl(Timporte), "#,###.00")), largo - 2)
            NumToLetters = GetMyNumberToWords(Timporte - decimales) & "  " & Mid(decimales, Len(decimales) - 1) & "/100 " & Tmoneda

            _c.TotalLetra = NumToLetters
            bsComprobante.ResetBindings(False)
        End If

    End Sub
    Private Sub timer1_Tick(sender As Object, e As EventArgs) Handles timer1.Tick
        tlpError.Visible = False
        lError.Text = String.Empty
        timer1.Enabled = False
    End Sub
    Private Sub getCamposCombox()
        If cbRegimenesFiscales.SelectedItem IsNot Nothing Then _c.Emisor.RegimenFiscal = (CType(cbRegimenesFiscales.SelectedItem, cRegimenFiscal)).RegimenFiscal
        If cbTipoComprobante.SelectedItem IsNot Nothing Then _c.TipoDeComprobante = (CType(cbTipoComprobante.SelectedItem, cTipoComprobante)).TipoComprobante
        If cbMoneda.SelectedItem IsNot Nothing Then _c.Moneda = (CType(cbMoneda.SelectedItem, cMoneda)).Moneda
        If cbMetodoPago.SelectedItem IsNot Nothing Then _c.MetodoPago = (CType(cbMetodoPago.SelectedItem, cMetodoPago)).MetodoPago
        If cbFormaPago.SelectedItem IsNot Nothing Then _c.FormaPago = (CType(cbFormaPago.SelectedItem, cFormaPago)).FormaPago
        If cbClientes.SelectedItem IsNot Nothing Then
            _c.Receptor.Nombre = (CType(cbClientes.SelectedItem, Cliente)).RazonSocial
            _c.Receptor.Rfc = (CType(cbClientes.SelectedItem, Cliente)).RFC
            _c.Receptor.UsoCFDI = (CType(cbUsoCfdi.SelectedItem, cUsoCFDI)).UsoCFDI
        End If
    End Sub
    Private Sub limpiarCampos()
        tbConceptoUnidad.Text = String.Empty
        tbConceptoNoIdentificacion.Text = String.Empty
        tbConceptoDescripcion.Text = String.Empty
        nudConceptoDescuento.Value = 0
        nudConceptoValorUnitario.Value = 0
        nudConceptoCantidad.Value = 0
        nudConceptoImporte.Value = 0

        txtClaveProducto.Text = String.Empty
        txtCvedUnidad.Text = String.Empty
        txtDescProdServ.Text = String.Empty
        txtBuscaProducto.Text = ""
    End Sub
    Private Sub btnConceptoLimpiar_Click(sender As Object, e As EventArgs) Handles btnConceptoLimpiar.Click
        If (_editarConcepto) Then
            btnConceptoAgregar.Text = "Agregar"
            'btnLimpiarCampos.Text = "Limpiar"
            _editarConcepto = False
        Else
            limpiarCampos()
        End If

    End Sub
    Private Sub rbSinDB_CheckedChanged(sender As Object, e As EventArgs)
        cargarDatosSinDB()
    End Sub
    Private Sub rbConDB_CheckedChanged(sender As Object, e As EventArgs)
        cargarDatosDB()
    End Sub
    Private Sub btnBuscarClaveProd_Click(ByVal sender As Object, ByVal e As EventArgs)
    End Sub
    Private Sub btnBuscarUnidad_Click(ByVal sender As Object, ByVal e As EventArgs)
    End Sub
    'Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
    '    Dim wb As wBuscar = New wBuscar(TipoBusqueda.Producto)
    '    If wb.ShowDialog() = System.Windows.Forms.DialogResult.Yes Then

    '        idCveProdSer = wb.producto.IdClaveProdServ
    '        busca_producto_servicio()




    '        'cbClaveProdServ.SelectedValue = wb.producto.IdClaveProdServ
    '        'cbClaveUnidad.SelectedValue = wb.producto.IdUnidad

    '        idCvedUnidad = wb.producto.IdUnidad
    '        busca_clave_unidad()

    '        tbConceptoDescripcion.Text = wb.producto.Descripcion
    '        tbConceptoNoIdentificacion.Text = wb.producto.Codigo
    '        tbConceptoUnidad.Text = wb.producto.Unidad
    '        nudConceptoValorUnitario.Value = CDec(wb.producto.Precio)
    '    End If
    'End Sub

    Private Sub cbClientes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbClientes.SelectedIndexChanged
        If (cbClientes.SelectedValue = Nothing) Then
            Return
        Else
            Dim c As Cliente = DirectCast(cbClientes.SelectedItem, Cliente)
            tbReceptorRazonSocial.Text = c.RazonSocial
            tbReceptorRFC.Text = c.RFC
            ' cbUsoCfdi.SelectedValue = 22
            cbUsoCfdi.SelectedValue = Integer.Parse(c.IdUsoCFDI.ToString())
            Label40.Text = c.RazonSocial
            busca_cve_cte()
        End If

    End Sub
    Private Sub dgvConceptos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvConceptos.CellContentClick
        'If (e.ColumnIndex = dgvConceptos.Columns("LImpuestos").Index) Then
        '    Dim c As Concepto = dgvConceptos.Rows(e.RowIndex).DataBoundItem
        '    Dim fi As frmImpuestos = New frmImpuestos(c.Impuestos)
        '    fi.ShowDialog()
        'ElseIf (e.ColumnIndex = dgvConceptos.Columns("LVentaVehiculos").Index) Then
        '    Dim c As Concepto = dgvConceptos.Rows(e.RowIndex).DataBoundItem
        '    Dim cvv As frmComplementoVentaVehiculos = New frmComplementoVentaVehiculos(c.Complemento.VentaVehiculos)
        '    If (cvv.ShowDialog() = Windows.Forms.DialogResult.Yes) Then
        '        _c.Conceptos(e.RowIndex).Complemento.VentaVehiculos = cvv.VentaVehiculos
        '        bs.ResetBindings(False)
        '        agregarlink()
        '    End If
        'ElseIf (e.ColumnIndex = dgvConceptos.Columns("LEliminar").Index) Then
        '    If (dgvConceptos.SelectedCells.Count > 0) Then
        '        _c.Conceptos.RemoveAt(dgvConceptos.SelectedCells.Item(0).RowIndex)
        '        calculaTotales()
        '        bs.ResetBindings(False)
        '    End If

        'ElseIf (dgvConceptos.Columns(e.ColumnIndex).Name = "LEditar") Then
        '    btnConceptoAgregar.Text = "Guardar"
        '    btnConceptoLimpiar.Text = "Cancelar"
        '    _editarConcepto = True
        '    _editarConceptoIndex = e.RowIndex

        '    Dim c As Concepto = dgvConceptos.Rows(e.RowIndex).DataBoundItem
        '    nudConceptoImporte.Value = c.Importe
        '    nudConceptoCantidad.Value = c.Cantidad

        '    tbConceptoDescripcion.Text = c.Descripcion
        '    nudConceptoDescuento.Value = c.Descuento
        '    nudConceptoImporte.Value = c.Importe
        '    tbConceptoNoIdentificacion.Text = c.NoIdentificacion
        '    tbConceptoUnidad.Text = c.Unidad
        '    nudConceptoValorUnitario.Value = c.ValorUnitario

        '    cbClaveProdServ.SelectedIndex = cbClaveProdServ.FindString(c.ClaveProdServ)
        '    cbClaveUnidad.SelectedIndex = cbClaveProdServ.FindString(c.ClaveUnidad)

        '    'c.Impuestos = getImpuestosConcepto()

        '    'If cbClaveProdServ.SelectedItem IsNot Nothing Then c.ClaveProdServ = (CType(cbClaveProdServ.SelectedItem, cClaveProdServ)).ClaveProdServ
        '    'If cbClaveUnidad.SelectedItem IsNot Nothing Then c.ClaveUnidad = (CType(cbClaveUnidad.SelectedItem, cClaveUnidad)).ClaveUnidad

        '    '_c.Conceptos.Add(c)
        '    'bs.ResetBindings(False)
        '    'agregarlink()
        '    'calculaTotales()
        '    'limpiarCampos()
        'End If
        If (e.ColumnIndex = dgvConceptos.Columns("LEliminar").Index) Then
            If (dgvConceptos.SelectedCells.Count > 0) Then
                _c.Conceptos.RemoveAt(dgvConceptos.SelectedCells.Item(0).RowIndex)
                calculaTotales()
                bs.ResetBindings(False)
            End If
        End If

    End Sub
    Private Sub nudConceptoDescuento_Enter(sender As Object, e As EventArgs) Handles nudConceptoDescuento.Enter

    End Sub
    Private Sub dgvConceptos_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles dgvConceptos.CellPainting
        'If (e.ColumnIndex > 0 And dgvConceptos.Columns(e.ColumnIndex).Name = "LEditar") Then
        '    e.Paint(e.CellBounds, DataGridViewPaintParts.All)
        '    Dim celBoton As DataGridViewButtonCell = DirectCast(dgvConceptos.Rows(e.RowIndex).Cells("LEditar"), DataGridViewButtonCell)
        '    Icon
        'End If
    End Sub
    Private Sub btnHidroCarburos_Click(sender As Object, e As EventArgs)
        'Dim fgh As frmGastosHidrocarburos = New frmGastosHidrocarburos(_c.Complemento.GastosHidrocarburos)
        'fgh.ShowDialog()
        'nudConceptoValorUnitario.Value = Variables.TtMontoErogacion
        'SOLO PARA COMPLEMENTO HIDROCARBUROS



    End Sub

    '***********************carga arasis MS SSQL****************************************************
    Sub CARGA_TIPO_COMPROBANTE()

        cbTipoComprobante.Items.Clear()

        SQL = "Select [id],[tipoComprobante],[descripcion] " &
                "FROM [dbo].[tblctipocomprobante] " &
            "ORDER BY [id] ASC"

        Dim da As New SqlDataAdapter(SQL, DB.obtenerConexionDB)
        Dim ds As New DataSet

        Try
            da.Fill(ds)

            If ds.Tables(0).Rows.Count = 0 Then
                Exit Sub
            Else

                Dim i As Integer

                Dim lista As List(Of cTipoComprobante) = New List(Of cTipoComprobante)()
                For i = 0 To ds.Tables(0).Rows.Count - 1
                    lista.Add(New cTipoComprobante(ds.Tables(0).Rows(i)(0).ToString(), ds.Tables(0).Rows(i)(1).ToString(), ds.Tables(0).Rows(i)(2).ToString()))
                Next
                cbTipoComprobante.Items.Add("")
                cbTipoComprobante.DataSource = lista

            End If

        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical)
            Exit Sub
        End Try


    End Sub
    Sub CARGA_REGIMENES_FISCALES()

        cbRegimenesFiscales.Items.Clear()

        SQL = "SELECT [id],[regimenFiscal],[descripcion] FROM [dbo].[tblcregimenfiscal] ORDER BY [id] ASC"

        Dim da As New SqlDataAdapter(SQL, DB.obtenerConexionDB)
        Dim ds As New DataSet

        Try
            da.Fill(ds)

            If ds.Tables(0).Rows.Count = 0 Then
                Exit Sub
            Else

                Dim i As Integer

                Dim lista As List(Of cRegimenFiscal) = New List(Of cRegimenFiscal)()
                For i = 0 To ds.Tables(0).Rows.Count - 1
                    lista.Add(New cRegimenFiscal(ds.Tables(0).Rows(i)(0).ToString(), ds.Tables(0).Rows(i)(1).ToString(), ds.Tables(0).Rows(i)(2).ToString()))
                Next
                cbRegimenesFiscales.Items.Add("")
                cbRegimenesFiscales.DataSource = lista

            End If

        Catch ex As Exception
            MsgBox("ERROR: " & ex.Message, MsgBoxStyle.Critical)
            Exit Sub
        End Try


        ' lista.Add(New cRegimenFiscal(1, "601", "General de Ley Personas Morales"))
    End Sub
    Sub CARGA_FORMAS_PAGO()

        cbFormaPago.Items.Clear()

        SQL = "SELECT [id],[formaPago],[descripcion] FROM [dbo].[tblcformapago] ORDER BY [id] ASC"

        Dim da As New SqlDataAdapter(SQL, DB.obtenerConexionDB)
        Dim ds As New DataSet

        Try
            da.Fill(ds)

            If ds.Tables(0).Rows.Count = 0 Then
                Exit Sub
            Else

                Dim i As Integer

                Dim lista As List(Of cFormaPago) = New List(Of cFormaPago)()
                For i = 0 To ds.Tables(0).Rows.Count - 1
                    lista.Add(New cFormaPago(ds.Tables(0).Rows(i)(0).ToString(), ds.Tables(0).Rows(i)(1).ToString(), ds.Tables(0).Rows(i)(2).ToString()))
                Next
                cbFormaPago.Items.Add("")
                cbFormaPago.DataSource = lista

            End If

        Catch ex As Exception
            MsgBox("ERROR: " & ex.Message, MsgBoxStyle.Critical)
            Exit Sub
        End Try


        ' lista.Add(New cRegimenFiscal(1, "601", "General de Ley Personas Morales"))
    End Sub
    Sub CARGA_CLAVE_PRODUCTOS_SERVICIOS()

        'cbClaveProdServ.Items.Clear()

        'SQL = "SELECT [id],[claveProdServ],[descripcion] FROM [dbo].[tblcclaveprodserv] ORDER BY [id] ASC"

        'Dim da As New SqlDataAdapter(SQL, DB.obtenerConexionDB)
        'Dim ds As New DataSet

        'Try
        '    da.Fill(ds)

        '    If ds.Tables(0).Rows.Count = 0 Then
        '        Exit Sub
        '    Else

        '        Dim i As Integer
        '        MDIPrincipal.barra.Visible = True
        '        MDIPrincipal.barra.Value = 0
        '        MDIPrincipal.barra.Minimum = 0
        '        MDIPrincipal.barra.Maximum = ds.Tables(0).Rows.Count
        '        Dim lista As List(Of cClaveProdServ) = New List(Of cClaveProdServ)()
        '        For i = 0 To ds.Tables(0).Rows.Count - 1
        '            lista.Add(New cClaveProdServ(ds.Tables(0).Rows(i)(0).ToString(), ds.Tables(0).Rows(i)(1).ToString(), ds.Tables(0).Rows(i)(2).ToString()))
        '            MDIPrincipal.barra.Value = MDIPrincipal.barra.Value + 1
        '        Next
        '        cbClaveProdServ.Items.Add("")
        '        cbClaveProdServ.DataSource = lista

        '    End If

        'Catch ex As Exception
        '    MsgBox("ERROR: " & ex.Message, MsgBoxStyle.Critical)
        '    Exit Sub
        'End Try
    End Sub
    Sub CARGA_CLAVE_UNIDAD_SERVICIOS()

        ' cbClaveUnidad.Items.Clear()

        'SQL = "SELECT [id],[claveUnidad],[nombre] FROM [dbo].[tblcclaveunidad] ORDER BY [id] ASC"

        'Dim da As New SqlDataAdapter(SQL, DB.obtenerConexionDB)
        'Dim ds As New DataSet

        'Try
        '    da.Fill(ds)

        '    If ds.Tables(0).Rows.Count = 0 Then
        '        Exit Sub
        '    Else

        '        Dim i As Integer
        '        'MDIPrincipal.barra.Visible = True
        '        'MDIPrincipal.barra.Value = 0
        '        'MDIPrincipal.barra.Minimum = 0
        '        'MDIPrincipal.barra.Maximum = ds.Tables(0).Rows.Count
        '        Dim lista As List(Of cClaveUnidad) = New List(Of cClaveUnidad)()
        '        For i = 0 To ds.Tables(0).Rows.Count - 1
        '            lista.Add(New cClaveUnidad(ds.Tables(0).Rows(i)(0).ToString(), ds.Tables(0).Rows(i)(1).ToString(), ds.Tables(0).Rows(i)(2).ToString()))
        '            ' MDIPrincipal.barra.Value = MDIPrincipal.barra.Value + 1
        '        Next
        '        cbClaveUnidad.Items.Add("")
        '        cbClaveUnidad.DataSource = lista

        '    End If

        'Catch ex As Exception
        '    MsgBox("ERROR: " & ex.Message, MsgBoxStyle.Critical)
        '    Exit Sub
        'End Try
    End Sub
    Sub carga_clientes()


        SQL = "SELECT [idCliente] " &
                      ",[RFC] " &
                      ",[razonSocial] " &
                      ",[cp] " &
                      ",[idUsoCfdi] " &
                  "FROM [dbo].[tblclientes] ORDER BY [RFC] ASC"

        Dim da As New SqlDataAdapter(SQL, DB.obtenerConexionDB)
        Dim ds As New DataSet

        Try
            da.Fill(ds)

            If ds.Tables(0).Rows.Count = 0 Then
                Exit Sub
            Else

                Dim i As Integer

                Dim lista As List(Of Cliente) = New List(Of Cliente)()
                For i = 0 To ds.Tables(0).Rows.Count - 1
                    lista.Add(New Cliente() With {.RazonSocial = ds.Tables(0).Rows(i)(2).ToString(), .RFC = ds.Tables(0).Rows(i)(1).ToString(), .CP = ds.Tables(0).Rows(i)(3).ToString(), .IdUsoCFDI = ds.Tables(0).Rows(i)(4).ToString()})
                Next
                cbClientes.Items.Add("")
                cbClientes.DisplayMember = "RazonSocial"
                cbClientes.DataSource = lista

            End If

        Catch ex As Exception
            MsgBox("ERROR: " & ex.Message, MsgBoxStyle.Critical)
            Exit Sub
        End Try


    End Sub
    Sub carga_clientes_intelisis()


        'SQL = "SELECT [idCliente] " &
        '            ",[RFC] " &
        '            ",[razonSocial] " &
        '            ",[cp] " &
        '            ",[idUsoCfdi] " &
        '        "FROM [dbo].[tblclientes] ORDER BY [RFC] ASC"

        SQL = "SELECT [Cliente] " &
                    ",[RFC] " &
                    ",[Nombre] " &
                    ",[CodigoPostal] " &
                    ",[idUsoCfdi] " &
                "FROM [American].[dbo].[Cte] ORDER BY [Nombre] ASC"

        Dim da As New SqlDataAdapter(SQL, DB.obtenerConexionDB)
        Dim ds As New DataSet

        Try
            da.Fill(ds)

            If ds.Tables(0).Rows.Count = 0 Then
                Exit Sub
            Else

                Dim i As Integer

                Dim lista As List(Of Cliente) = New List(Of Cliente)()
                For i = 0 To ds.Tables(0).Rows.Count - 1
                    lista.Add(New Cliente() With {.RazonSocial = ds.Tables(0).Rows(i)(2).ToString(), .RFC = ds.Tables(0).Rows(i)(1).ToString(), .CP = ds.Tables(0).Rows(i)(3).ToString(), .IdUsoCFDI = ds.Tables(0).Rows(i)(4).ToString()})
                Next
                cbClientes.Items.Add("")
                cbClientes.DisplayMember = "RazonSocial"
                cbClientes.DataSource = lista

            End If

        Catch ex As Exception
            MsgBox("ERROR: " & ex.Message, MsgBoxStyle.Critical)
            Exit Sub
        End Try


    End Sub
    Sub carga_uso_cfdi()

        cbUsoCfdi.Items.Clear()

        SQL = "SELECT [id],[usoCfdi],[descripcion] FROM [dbo].[tblcusocfdi] ORDER BY [id] ASC"

        Dim da As New SqlDataAdapter(SQL, DB.obtenerConexionDB)
        Dim ds As New DataSet

        Try
            da.Fill(ds)

            If ds.Tables(0).Rows.Count = 0 Then
                Exit Sub
            Else

                Dim i As Integer



                'MDIPrincipal.barra.Visible = True
                'MDIPrincipal.barra.Value = 0
                'MDIPrincipal.barra.Minimum = 0
                'MDIPrincipal.barra.Maximum = ds.Tables(0).Rows.Count

                Dim lista As List(Of cUsoCFDI) = New List(Of cUsoCFDI)()
                For i = 0 To ds.Tables(0).Rows.Count - 1
                    lista.Add(New cUsoCFDI(ds.Tables(0).Rows(i)(0).ToString(), ds.Tables(0).Rows(i)(1).ToString(), ds.Tables(0).Rows(i)(2).ToString()))
                    ' MDIPrincipal.barra.Value = MDIPrincipal.barra.Value + 1
                Next
                cbUsoCfdi.Items.Add("")
                cbUsoCfdi.ValueMember = "Id"
                cbUsoCfdi.DisplayMember = "ClaveYDescripcion"
                cbUsoCfdi.DataSource = lista


            End If

        Catch ex As Exception
            MsgBox("ERROR: " & ex.Message, MsgBoxStyle.Critical)
            Exit Sub
        End Try

    End Sub
    Sub carga_productos()


        ' cbBuscaProducto.Items.Clear()

        'SQL = "SELECT [idProducto] " &
        '            ",[codigo] " &
        '            ",[descripcion] " &
        '            ",[precio] " &
        '            ",[unidad] " &
        '            ",[idClaveProdServ] " &
        '            ",[idClaveUnidad] " &
        '        "FROM [dbo].[tblproductos] " &
        '    "ORDER BY [descripcion] ASC"

        SQL = "SELECT [Descripcion1] " &
                "FROM [American].[dbo].[Art]  " &
               "WHERE [Descripcion1] IS NOT NULL " &
            "ORDER BY [Descripcion1] ASC"

        Dim da As New SqlDataAdapter(SQL, DB.obtenerConexionDB)
        Dim ds As New DataSet

        Try
            da.Fill(ds)

            If ds.Tables(0).Rows.Count = 0 Then
                Exit Sub
            Else

                Dim i As Integer

                ' cbBuscaProducto.Items.Add("")
                For i = 0 To ds.Tables(0).Rows.Count - 1
                    '  cbBuscaProducto.Items.Add(ds.Tables(0).Rows(i)(1).ToString())
                    AutoComp.Add(ds.Tables(0).Rows(i)(0).ToString())
                Next



                'Set the some propersties of the text box to allow auto                   search
                'Or you may set this manaully on the textbox property window
                'txtProveedor.AutoCompleteMode = AutoCompleteMode.SuggestAppend
                'txtProveedor.AutoCompleteSource = AutoCompleteSource.ListItems
                'txtProveedor.AutoCompleteCustomSource = AutoComp

                txtBuscaProducto.AutoCompleteSource = AutoCompleteSource.CustomSource
                txtBuscaProducto.AutoCompleteCustomSource = AutoComp
                txtBuscaProducto.AutoCompleteMode = AutoCompleteMode.Suggest

            End If

        Catch ex As Exception
            MsgBox("ERROR: " & ex.Message, MsgBoxStyle.Critical)
            Exit Sub
        End Try

    End Sub
    '****************************************GENERA XML********************************
    Private Sub btnGenerarXML_Click(sender As Object, e As EventArgs) Handles btnGenerarXML.Click
        If dgvConceptos.Rows.Count = 0 Then
            MsgBox("Es necesario un concepto como minimo para generar la Vista Previa, Verifique", MsgBoxStyle.Critical)
            Exit Sub
        Else
            If MsgBox("¿ Desea Generar la Vista Previa ?", MsgBoxStyle.YesNo, "efactura33") = MsgBoxResult.Yes Then
                Try

                    getCamposCombox()
                    Variables.ObservacionesCFDI = String.Empty
                    If txtObservaciones.Text <> "" Then
                        Variables.ObservacionesCFDI = "Observaciones: " & txtObservaciones.Text
                    End If

                    'Dim rutaXMLST As String = "C:\XMLST\xmlPrueba" & _c.Serie + _c.Folio & ".xml"

                    Dim nombrearchivo = String.Format("{0}_{1:yyyyMMddHHmmss}.{2}", _c.Serie + _c.Folio, DateTime.Now, "xml")

                    'Dim rutaXMLST As String = ".\XMLST\" & nombrearchivo
                    'Dim rutaXMLST As String = ".\XMLST\xmlPrueba" & _c.Serie + _c.Folio & ".xml"
                    Dim rutaXMLST As String = My.Settings.rutaXMLST & "\" & nombrearchivo
                    'C:\XMLST
                    Dim rutaPFX As String = DB.obtenerRutaPFX()
                    Dim rutaCertificado As String = DB.obtenerRutaCertificado()
                    Dim contrasenaPFX As String = DB.obtenerContrasenaPFX()
                    Dim crearXML As CrearXML = New CrearXML()

                    crearXML.Create(_c, rutaXMLST, rutaPFX, contrasenaPFX, rutaCertificado)


                    Threading.Thread.Sleep(6000) ' 1 segundo
                    '************************crea PDF**************************
                    nombrearchivoPDF_ = String.Format("{0}_{1:yyyyMMddHHmmss}.{2}", _c.Serie + _c.Folio, DateTime.Now, "pdf")
                    ' nombrearchivoXML_ = String.Format("{0}_{1:yyyyMMddHHmmss}.{2}", _c.Serie + _c.Folio, DateTime.Now, "xml")
                    rutaPDF_ = My.Settings.rutaXMLST & "\" & nombrearchivoPDF_
                    'rutaXML_ = My.Settings.rutaXMLST & "\" & nombrearchivo
                    Dim CreaPDF As CreaPDF = New CreaPDF(rutaXMLST, rutaPDF_, Nothing)

                    Threading.Thread.Sleep(10000) ' 1 segundo
                    System.Diagnostics.Process.Start(rutaPDF_)
                    System.Diagnostics.Process.Start(rutaXMLST)
                Catch ex As Exception
                    MsgBox("ERROR: " & ex.Message, MsgBoxStyle.Critical)
                    Exit Sub
                End Try
            End If

        End If

        'validarXML.LoadValidatedXDocument(rutaXMLST, "C:\TimbradoArasis\SAT\GastosHidrocarburos10.xsd")
        'validarXML.LoadValidatedXDocument(rutaXMLST, "C:\TimbradoArasis\SAT\cfdv33.xsd")

        ' validarXML.LoadValidatedXDocument(rutaXMLST, ".\GastosHidrocarburos10.xsd")
        ' validarXML.LoadValidatedXDocument(rutaXMLST, ".\cfdv33.xsd")

        'Try
        '    ' Leer el archivo binario especificado en el control TextBox.
        '    Dim blob As Byte() = ReadBinaryFile(rutaXMLST)

        '    SQL = "INSERT INTO [ARASIS_ARCHIVOS] " &
        '                  "([nombre_archivo],[archivo],[extension],[fecha_registro],[origen],[Folio]) " &
        '            "VALUES(@nombre_archivo,@archivo,@extension,GETDATE(),'XML', '1')"

        '    ',[FolioAC],
        '    Dim cmd As New SqlCommand(SQL, conectar)

        '    cmd.Parameters.AddWithValue("@nombre_archivo", nombrearchivo)
        '    cmd.Parameters.AddWithValue("@archivo", If(blob IsNot Nothing, blob, CObj(DBNull.Value)))
        '    cmd.Parameters.AddWithValue("@extension", ".xml")

        '    'cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtIdBlob.Text))

        '    ' La función ReadBinaryFile tal cual se encuentra implementada no devolverá un valor Nothing,
        '    ' pero muestro cómo especificar un valor NULL al parámetro de entrada si el valor del campo
        '    ' binario fuese Nothing. Para insertar un valor NULL, el campo de la tabla lo tiene que permitir.


        '    conectar.Open()

        '    Dim n As Integer = cmd.ExecuteNonQuery()

        '    If (n > 0) Then

        '        'MessageBox.Show("Se ha Guardado el Archivo satisfactoriamente.")
        '        conectar.Close()
        '        'Dim exists As Boolean
        '        'exists = System.IO.Directory.Exists("C:\OrdenesCompra")
        '        'If exists = True Then
        '        '    My.Computer.FileSystem.DeleteDirectory("C:\OrdenesCompra", FileIO.DeleteDirectoryOption.DeleteAllContents)
        '        'End If

        '        sName = nombrearchivo
        '        sPath = rutaXMLST
        '        sExt = Path.GetExtension(rutaXMLST)


        '        'If ValidaExtension(sExt) Then
        '        '    LIMPIA_XML()
        '        '    limpia_detalle_XML()
        '        '    saca_version()
        '        '    'TextPathExcel.Text = ""
        '        'Else
        '        '    MsgBox("El Archivo no es valido, Favor de Verificar.", MsgBoxStyle.Critical)
        '        '    'TextPathExcel.Text = ""
        '        '    Exit Sub
        '        'End If



        '        System.Diagnostics.Process.Start(rutaXMLST)
        '    Else
        '        ' MessageBox.Show("No se ha guardado ningún documento.")

        '    End If

        'Catch ex As Exception
        '    ' Se ha producido un error.
        '    MessageBox.Show(ex.Message)
        '    conectar.Close()

        'End Try


    End Sub
    Private Function ValidaExtension(ByVal sExtension As String) As Boolean
        Select Case sExtension
            Case ".xml", ".XML"
                Return True
            Case Else
                Return False
        End Select
    End Function
    '****************************************TIMBRA XML********************************
    Private Sub btnTimbrar_Click(sender As Object, e As EventArgs) Handles btnTimbrar.Click

        If dgvConceptos.Rows.Count = 0 Then
            MsgBox("Es necesario un concepto como minimo para generar la Vista Previa, Verifique", MsgBoxStyle.Critical)
            Exit Sub
        Else
            If MsgBox("¿ Desea Generar el Timbrado de la Factura ?", MsgBoxStyle.YesNo, "efactura33") = MsgBoxResult.Yes Then
                Timer2.Start()
                Timer2.Interval = 1000
                barra.Visible = True
                barra.Value = 0
                barra.Minimum = 0
                barra.Maximum = 25
                contador_timer = 0
            End If

        End If

    End Sub
    '****************************************CREA PDF********************************
    Sub crea_pdf()

        nombrearchivoPDF_ = _c.Serie + _c.Folio & ".pdf"
        nombrearchivoXML_ = _c.Serie + _c.Folio & ".xml"
        rutaPDF_ = My.Settings.rutaXMLST & "\" & nombrearchivoPDF_
        rutaXML_ = My.Settings.rutaXMLST & "\" & nombrearchivoXML_
        Dim CreaPDF As CreaPDF = New CreaPDF(rutaXML_, rutaPDF_, Nothing)


        guardaPDF()

    End Sub
    Sub verifica_carpeta()

        Try
            ' My.Computer.FileSystem.DeleteDirectory(ruta, FileIO.DeleteDirectoryOption.DeleteAllContents)

            If Not Directory.Exists("C:\eFacturaTemporales") Then
                Directory.CreateDirectory("C:\eFacturaTemporales")
            Else

                'Directory.Delete(ruta)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub guardaPDF()


        Try
            'Dim sFiles As String = Path.GetFileName(RutaArchivoS)

            ' Leer el archivo binario especificado en el control TextBox.
            Dim blob As Byte()
            blob = Nothing
            blob = ReadBinaryFile(rutaPDF_)

            SQL = "INSERT INTO [dbo].[ARASIS_ARCHIVOS] " &
                             "([nombre_archivo],[archivo],[extension],[fecha_registro],[origen],[Folio],[usuario]) " &
                    "VALUES(@nombre_archivo,@archivo,@extension,GETDATE(),'PDF','" & tbFolio.Text.Trim & "','" & Variables.USUARIO_SISTEMA & "' )"

            Dim conectar As New SqlConnection(DB.obtenerConexionDB)

            Dim cmd As New SqlCommand(SQL, conectar)

            cmd.Parameters.AddWithValue("@nombre_archivo", nombrearchivoPDF_)
            cmd.Parameters.AddWithValue("@archivo", If(blob IsNot Nothing, blob, CObj(DBNull.Value)))
            cmd.Parameters.AddWithValue("@extension", ".pdf")

            conectar.Open()

            Dim n As Integer = cmd.ExecuteNonQuery()

            If (n > 0) Then
                conectar.Close()
            Else
                conectar.Close()
            End If

        Catch ex As Exception
            ' Se ha producido un error.
            MessageBox.Show(ex.Message)

            Exit Sub
        End Try
    End Sub
    Sub guardaXML()
        nombrearchivoXML_ = _c.Serie + _c.Folio & ".xml"
        rutaXML_ = My.Settings.rutaXMLST & "\" & nombrearchivoXML_
        Try
            'Dim sFiles As String = Path.GetFileName(RutaArchivoS)

            ' Leer el archivo binario especificado en el control TextBox.
            Dim blobXML As Byte()
            blobXML = Nothing
            blobXML = ReadBinaryFileXML(rutaXML_.Trim)

            Dim SQL1 As String = ""

            SQL1 = "INSERT INTO [dbo].[ARASIS_ARCHIVOS] " &
                             "([nombre_archivo],[archivo],[extension],[fecha_registro],[origen],[Folio],[usuario]) " &
                    "VALUES(@nombre_archivo,@archivo,@extension,GETDATE(),'XML','" & tbFolio.Text.Trim & "','" & Variables.USUARIO_SISTEMA & "' )"


            Dim conectar As New SqlConnection(DB.obtenerConexionDB)

            Dim cmd1 As New SqlCommand(SQL1, conectar)

            cmd1.Parameters.AddWithValue("@nombre_archivo", NArchivoS.Trim)
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
    Private Shared Function ReadBinaryFile(ByVal fileNameXML As String) As Byte()

        ' Generar una excepción si no existe el archivo.
        '
        If (Not IO.File.Exists(fileNameXML)) Then
            Throw New IO.FileNotFoundException("No existe el archivo especificado.")
        End If

        ' Leer el archivo especificado devolviendo una matriz de bytes con su contenido.
        '
        Return IO.File.ReadAllBytes(fileNameXML)

    End Function
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
    '********************************SUBIR XML***************************************************
    Sub LIMPIA_XML()

        Folio = ""
        Version_xml = ""
        Serie = ""
        Fecha = ""
        LugarExpedicion = ""
        NumCtaPago = ""
        TipoComprobante = ""
        CondicionesPago = ""
        MetodoPago = ""
        FormaPago = ""
        TipoCambio = ""
        Moneda = ""
        SubTotal = ""
        Total = ""
        Certificado = ""
        NoCertificado = ""
        Sello = ""
        Descuento = ""
        TipoRelacion = ""
        RelacionadosUUID = ""
        Emirfc = ""
        EmiNombre = ""
        EmiCalle = ""
        EminoExterior = ""
        EminoInterior = ""
        EmiColonia = ""
        Emilocalidad = ""
        EmiMunicipio = ""
        EmiEstado = ""
        EmiPais = ""
        EmiCodigoPostal = ""
        EmiRegimenFiscal = ""
        Receprfc = ""
        RecepNombre = ""
        UsoCFDI = ""
        NumRegIdTrib = ""
        ResidenciaFiscal = ""
        RecepCalle = ""
        RecepnoExterior = ""
        RecepnoInterior = ""
        RecepColonia = ""
        RecepLocalidad = ""
        RecepMunicipio = ""
        RecepEstado = ""
        RecepPais = ""
        RecepCodigoPostal = ""
        TotalImpuestosTrasladados = ""
        TotalImpuestosRetenidos = ""
        RetencionesTotalImporte = ""
        RetencionesTotalImpuesto = ""
        TrasladosTotalImporte = ""
        TrasladosTotalTasaOCuota = ""
        TrasladosTotalTipoFactor = ""
        TrasladosTotalImpuesto = ""
        VersionTimbreFiscal = ""
        xsiSchemaLocation = ""
        selloSAT = ""
        noCertificadoSAT = ""
        selloCFD = ""
        FechaTimbrado = ""
        UUID = ""
        RfcProvCertif = ""
        IVA = ""
        IEPS = ""
        rfc_user = ""





    End Sub
    Sub limpia_detalle_XML()

        'DETALLE

        '  idDetalle = ""
        Cantidad = ""
        Descripcion = ""
        Unidad = ""
        ValorUnitario = ""
        Importe = ""
        NoIdentificacion = ""
        ClaveUnidad = ""
        ClaveProdServ = ""
        TrasladoImporte = ""
        TrasladoTasaOCuota = ""
        TrasladoTipoFactor = ""
        TrasladoImpuesto = ""
        TrasladoBase = ""
        RetencionImporte = ""
        RetencionTasaOCuota = ""
        RetencionTipoFactor = ""
        RetencionImpuesto = ""
        RetencionBase = ""
        CuentaPredialNumero = ""
        InformacionAduaneraNumeroPedimento = ""
        ParteImporte = ""
        ParteValorUnitario = ""
        ParteDescripcion = ""
        ParteUnidad = ""
        ParteCantidad = ""
        ParteNoIdentificacion = ""
        ParteClaveProdServ = ""

    End Sub
    Sub saca_version()
        Try


            Dim xDoc As New XmlDocument
            Dim xNodo As XmlNodeList
            Dim xAtt As XmlElement


            '*************************************

            'Dim value As String = File.ReadAllText(sPath)
            'Dim xmldoc As XElement = XElement.Parse(value)
            'XElement nodeEquip = xmldoc.Element("Equip");


            'Dim objXML As New XmlDocument
            'objXML.Load("c:\fichero.xml")

            '*************************************


            xDoc.Load(sPath)

            'COMPROBANTE
            xNodo = xDoc.GetElementsByTagName("cfdi:Comprobante")
            If xNodo.Count > 0 Then

                For Each xAtt In xNodo

                    '3.2
                    Version_xml = VarXml(xAtt, "version") 'Serie
                    Folio = VarXml(xAtt, "folio") 'folio

                    If Version_xml <> "" And Folio <> "" Then
                        'valida_folio()
                        ' busca_xml()
                        ' Exit Sub
                    Else
                        '3.3
                        Version_xml = VarXml(xAtt, "Version") 'Serie
                        Folio = VarXml(xAtt, "Folio") 'folio
                        'valida_folio()
                        ' busca_xml()
                    End If
                Next
            End If

            '***********************************************************
            '                VALIDA CON UUID
            '***********************************************************   'COMPLEMENTOS
            xNodo = xDoc.GetElementsByTagName("cfdi:Complemento")
            If xNodo.Count > 0 Then
                For Each xAtt In xNodo

                Next
            End If


            For Each xAtt In xNodo.Item(0)
                If xAtt.LocalName Like "*TimbreFiscalDigital*" Then
                    UUID = VarXml(xAtt, "UUID") 'UUID
                    valida_uuid()
                End If

            Next

        Catch ex As Exception
            MsgBox("ERROR: " & ex.Message, MsgBoxStyle.Critical)
            Exit Sub
        End Try

    End Sub
    Sub valida_uuid()


        SQL = "SELECT * FROM ARASIS_XML_ENCABEZADO WHERE [UUID] = '" & UUID & "' "

        Dim da As New SqlDataAdapter(SQL, DB.obtenerConexionDB)
        Dim ds As New DataSet

        da.Fill(ds)

        If ds.Tables(0).Rows.Count = 0 Then

            If Version_xml = "3.2" Then
                extrae_xml_3_2()
            End If

            If Version_xml = "3.3" Then
                extrae_xml_3_3()
            End If

        Else
            ' MsgBox("Archivo ya importado con Número de Folio: " & Folio, MsgBoxStyle.Information)
            Exit Sub

        End If

    End Sub
    Sub valida_folio()


        SQL = "SELECT * FROM ARASIS_XML_ENCABEZADO WHERE folio = '" & Folio & "' "

        Dim da As New SqlDataAdapter(SQL, DB.obtenerConexionDB)
        Dim ds As New DataSet

        da.Fill(ds)

        If ds.Tables(0).Rows.Count = 0 Then

            If Version_xml = "3.2" Then
                extrae_xml_3_2()
            End If

            If Version_xml = "3.3" Then
                extrae_xml_3_3()
            End If

        Else
            ' MsgBox("Archivo ya importado con Número de Folio: " & Folio, MsgBoxStyle.Information)


        End If

    End Sub
    '*********VERSION 3.2****
    Sub extrae_xml_3_2()

        Try
            ' lblmensaje.Text = ""
            LIMPIA_XML()
            Dim xDoc As XmlDocument
            Dim xNodo As XmlNodeList
            Dim xAtt As XmlElement

            xDoc = New XmlDocument
            xDoc.Load(sPath)

            'COMPROBANTE
            xNodo = xDoc.GetElementsByTagName("cfdi:Comprobante")
            If xNodo.Count > 0 Then
                '  row = Table.NewRow()

                For Each xAtt In xNodo

                    Folio = VarXml(xAtt, "folio") 'folio

                    Version_xml = VarXml(xAtt, "version") 'Serie
                    Serie = VarXml(xAtt, "serie") 'Serie
                    Fecha = VarXml(xAtt, "fecha") 'Fecha

                    LugarExpedicion = VarXml(xAtt, "LugarExpedicion") 'Lugar de Expedición
                    NumCtaPago = VarXml(xAtt, "NumCtaPago") 'NumCtaPago
                    TipoComprobante = VarXml(xAtt, "tipoDeComprobante") 'TipoComprobante

                    CondicionesPago = VarXml(xAtt, "condicionesDePago") 'Condiciones de Pago
                    MetodoPago = VarXml(xAtt, "metodoDePago") 'Metodo de Pago
                    FormaPago = VarXml(xAtt, "formaDePago") 'Forma de Pago

                    TipoCambio = VarXml(xAtt, "TipoCambio") 'Tipo de Cambio
                    Moneda = VarXml(xAtt, "Moneda") 'Moneda

                    SubTotal = VarXml(xAtt, "subTotal") 'Total
                    Total = VarXml(xAtt, "total") 'Total

                    Certificado = VarXml(xAtt, "certificado") 'Certificado
                    NoCertificado = VarXml(xAtt, "noCertificado") 'No Certificado
                    Sello = VarXml(xAtt, "sello") 'Sello


                Next
            End If

            'EMISOR
            xNodo = xDoc.GetElementsByTagName("cfdi:Emisor")
            If xNodo.Count > 0 Then
                For Each xAtt In xNodo

                    Emirfc = VarXml(xAtt, "rfc") 'Certificado 'RFC
                    EmiNombre = VarXml(xAtt, "nombre") 'Certificado 'Nombre Emisor

                Next

                For Each xAtt In xNodo.Item(0)
                    If xAtt.LocalName Like "*DomicilioFiscal*" Then


                        EmiCalle = VarXml(xAtt, "calle") 'Calle
                        EminoExterior = VarXml(xAtt, "noExterior") 'noExterior
                        EminoInterior = VarXml(xAtt, "noInterior") 'noInterior
                        EmiColonia = VarXml(xAtt, "colonia") 'Colonia
                        Emilocalidad = VarXml(xAtt, "localidad") 'Localidad
                        EmiMunicipio = VarXml(xAtt, "municipio") 'Municipio
                        EmiEstado = VarXml(xAtt, "estado") 'Estado
                        EmiPais = VarXml(xAtt, "pais") 'País
                        EmiCodigoPostal = VarXml(xAtt, "codigoPostal") 'Código Postal


                    End If
                    If xAtt.LocalName Like "*RegimenFiscal*" Then
                        EmiRegimenFiscal = VarXml(xAtt, "Regimen") 'regimen
                    End If
                Next


            End If

            'RECEPTOR
            xNodo = xDoc.GetElementsByTagName("cfdi:Receptor")
            If xNodo.Count > 0 Then
                For Each xAtt In xNodo

                    Receprfc = VarXml(xAtt, "rfc") 'rfc
                    RecepNombre = VarXml(xAtt, "nombre") 'Sello

                Next

                For Each xAtt In xNodo.Item(0)
                    If xAtt.LocalName Like "*Domicilio*" Then



                        RecepCalle = VarXml(xAtt, "calle") 'Calle
                        RecepnoExterior = VarXml(xAtt, "noExterior") 'noExterior
                        RecepnoInterior = VarXml(xAtt, "noInterior") 'noInterior
                        RecepColonia = VarXml(xAtt, "colonia") 'Colonia
                        RecepMunicipio = VarXml(xAtt, "municipio") 'Municipio
                        RecepLocalidad = VarXml(xAtt, "localidad") 'Localidad
                        RecepEstado = VarXml(xAtt, "estado") 'Estado
                        RecepPais = VarXml(xAtt, "pais") 'País
                        RecepCodigoPostal = VarXml(xAtt, "codigoPostal") 'Código Postal

                    End If

                Next

            End If



            'COMPLEMENTOS
            xNodo = xDoc.GetElementsByTagName("cfdi:Complemento")
            If xNodo.Count > 0 Then
                For Each xAtt In xNodo

                Next
            End If

            For Each xAtt In xNodo.Item(0)
                If xAtt.LocalName Like "*TimbreFiscalDigital*" Then

                    VersionTimbreFiscal = VarXml(xAtt, "version") 'Version
                    xsiSchemaLocation = VarXml(xAtt, "xsi:schemaLocation") 'xsi:schemaLocation
                    selloSAT = VarXml(xAtt, "selloSAT") 'selloSAT
                    noCertificadoSAT = VarXml(xAtt, "noCertificadoSAT") 'noCertificadoSAT
                    selloCFD = VarXml(xAtt, "selloCFD") 'selloCFD
                    FechaTimbrado = VarXml(xAtt, "FechaTimbrado") 'FechaTimbrado
                    UUID = VarXml(xAtt, "UUID") 'UUID

                End If

            Next



            'IMPUESTOS
            xNodo = xDoc.GetElementsByTagName("cfdi:Impuestos")

            If xNodo.Count > 0 Then
                For Each xAtt2 In xNodo.Item(0)

                    If xAtt2.Name = "cfdi:Traslados" Then
                        xNodo = xDoc.GetElementsByTagName("cfdi:Traslados")

                        For Each xAtt3 In xNodo.Item(0)

                            Dim TIPO_IMPUESTO As String

                            TIPO_IMPUESTO = VarXml(xAtt3, "impuesto")

                            If TIPO_IMPUESTO = "IVA" Then
                                IVA = VarXml(xAtt3, "importe")
                            End If

                            If TIPO_IMPUESTO = "IEPS" Then
                                IEPS = VarXml(xAtt3, "importe")
                            End If
                        Next
                    End If
                Next
            End If
            guarda_encabezado()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Information)
            Exit Sub
        End Try

    End Sub
    Sub detalle_conceptos_3_2()


        Try


            Dim xDoc As XmlDocument
            Dim xNodo As XmlNodeList
            Dim xAtt As XmlElement

            xDoc = New XmlDocument
            xDoc.Load(sPath)
            adenda_posision = 0
            pos = 0

            'CONCEPTOS
            xNodo = xDoc.GetElementsByTagName("cfdi:Conceptos")
            If xNodo.Count > 0 Then
                For Each xAtt2 In xNodo

                Next
                'CONCEPTO
                For Each xAtt In xNodo.Item(0)

                    If xAtt.LocalName Like "*Concepto*" Then

                        Importe = VarXml(xAtt, "importe") 'Importe
                        ValorUnitario = VarXml(xAtt, "valorUnitario") 'ValorUnitario
                        Descripcion = VarXml(xAtt, "descripcion") 'Descripción
                        NoIdentificacion = VarXml(xAtt, "noIdentificacion") 'NoIdentificacion
                        Unidad = VarXml(xAtt, "unidad") 'Unidad
                        Cantidad = VarXml(xAtt, "cantidad") 'Cantidad


                        pos = pos + 1
                        adenda_posision = adenda_posision + 1

                        detalle_adenda()
                        inserta_detalle()

                    End If
                Next

            End If


        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Information)

        End Try

        ''IMPUESTOS

    End Sub
    '*********VERSION 3.3****
    Sub extrae_xml_3_3()


        Try

            Dim xDoc As XmlDocument
            Dim xNodo As XmlNodeList
            Dim xAtt As XmlElement

            xDoc = New XmlDocument
            xDoc.Load(sPath)

            'COMPROBANTE
            xNodo = xDoc.GetElementsByTagName("cfdi:Comprobante")
            If xNodo.Count > 0 Then

                For Each xAtt In xNodo

                    Folio = VarXml(xAtt, "Folio") 'folio

                    Version_xml = VarXml(xAtt, "Version") 'Serie
                    Serie = VarXml(xAtt, "Serie") 'Serie
                    Fecha = VarXml(xAtt, "Fecha") 'Fecha

                    LugarExpedicion = VarXml(xAtt, "LugarExpedicion") 'Lugar de Expedición
                    NumCtaPago = VarXml(xAtt, "NumCtaPago") 'NumCtaPago
                    TipoComprobante = VarXml(xAtt, "TipoDeComprobante") 'TipoComprobante

                    CondicionesPago = VarXml(xAtt, "CondicionesDePago") 'Condiciones de Pago
                    MetodoPago = VarXml(xAtt, "MetodoPago") 'Metodo de Pago
                    FormaPago = VarXml(xAtt, "FormaPago") 'Forma de Pago

                    TipoCambio = VarXml(xAtt, "TipoCambio") 'Tipo de Cambio
                    Moneda = VarXml(xAtt, "Moneda") 'Moneda

                    SubTotal = VarXml(xAtt, "SubTotal") 'Total

                    Total = VarXml(xAtt, "Total") ' AUN SIN CONFIRMAR

                    Certificado = VarXml(xAtt, "Certificado") 'Certificado
                    NoCertificado = VarXml(xAtt, "NoCertificado") 'No Certificado
                    Sello = VarXml(xAtt, "Sello") 'Sello

                    'nuevos campos
                    Descuento = VarXml(xAtt, "Descuento") 'SelloOK
                Next
            End If

            'RELACIONADOS
            xNodo = xDoc.GetElementsByTagName("cfdi:CfdiRelacionados")
            If xNodo.Count > 0 Then
                For Each xAtt In xNodo
                    TipoRelacion = VarXml(xAtt, "TipoRelacion") 'TipoRelacionOK
                Next

                For Each xAtt In xNodo.Item(0)
                    If xAtt.LocalName Like "*CfdiRelacionado*" Then

                        RelacionadosUUID = VarXml(xAtt, "UUID") 'RelacionadosUUID_OK

                    End If
                Next

            End If

            'EMISOR
            xNodo = xDoc.GetElementsByTagName("cfdi:Emisor")
            If xNodo.Count > 0 Then
                For Each xAtt In xNodo

                    Emirfc = VarXml(xAtt, "Rfc") 'RFC
                    EmiNombre = VarXml(xAtt, "Nombre") 'Nombre Emisor
                    EmiRegimenFiscal = VarXml(xAtt, "RegimenFiscal") 'RegimenFiscal

                Next

                For Each xAtt In xNodo.Item(0)
                    If xAtt.LocalName Like "*DomicilioFiscal*" Then

                        EmiCalle = VarXml(xAtt, "calle") 'Calle
                        EminoExterior = VarXml(xAtt, "noExterior") 'noExterior
                        EminoInterior = VarXml(xAtt, "noInterior") 'noInterior
                        EmiColonia = VarXml(xAtt, "colonia") 'Colonia
                        Emilocalidad = VarXml(xAtt, "localidad") 'Localidad
                        EmiMunicipio = VarXml(xAtt, "municipio") 'Municipio
                        EmiEstado = VarXml(xAtt, "estado") 'Estado
                        EmiPais = VarXml(xAtt, "pais") 'País
                        EmiCodigoPostal = VarXml(xAtt, "codigoPostal") 'Código Postal


                    End If

                Next


            End If

            'RECEPTOR
            xNodo = xDoc.GetElementsByTagName("cfdi:Receptor")
            If xNodo.Count > 0 Then
                For Each xAtt In xNodo
                    Receprfc = VarXml(xAtt, "Rfc")        'rfc
                    RecepNombre = VarXml(xAtt, "Nombre")  'Nombre

                    UsoCFDI = VarXml(xAtt, "UsoCFDI")      'UsoCFDI
                    NumRegIdTrib = VarXml(xAtt, "NumRegIdTrib")      'UsoCFDI
                    ResidenciaFiscal = VarXml(xAtt, "ResidenciaFiscal")      'UsoCFDI

                Next

                For Each xAtt In xNodo.Item(0)
                    If xAtt.LocalName Like "*Domicilio*" Then

                        RecepCalle = VarXml(xAtt, "calle") 'Calle
                        RecepnoExterior = VarXml(xAtt, "noExterior") 'noExterior
                        RecepnoInterior = VarXml(xAtt, "noInterior") 'noInterior
                        RecepColonia = VarXml(xAtt, "colonia") 'Colonia
                        RecepMunicipio = VarXml(xAtt, "municipio") 'Municipio
                        RecepLocalidad = VarXml(xAtt, "localidad") 'Localidad
                        RecepEstado = VarXml(xAtt, "estado") 'Estado
                        RecepPais = VarXml(xAtt, "pais") 'País
                        RecepCodigoPostal = VarXml(xAtt, "codigoPostal") 'Código Postal

                    End If

                Next

            End If

            'IMPUESTOS


            ' TOTAL DE IMPUESTOS IMPUESTOS
            xNodo = xDoc.GetElementsByTagName("cfdi:Impuestos")

            If xNodo.Count > 0 Then
                For Each xAtt In xNodo
                    TotalImpuestosTrasladados = VarXml(xAtt, "TotalImpuestosTrasladados")
                    TotalImpuestosRetenidos = VarXml(xAtt, "TotalImpuestosRetenidos")
                Next

                For Each xAtt2 In xNodo.Item(0)


                    If xAtt2.Name = "cfdi:Retenciones" Then
                        xNodo = xDoc.GetElementsByTagName("cfdi:Retenciones")
                        For Each xAtt3 In xNodo.Item(0)


                            RetencionesTotalImporte = VarXml(xAtt3, "Importe")
                            RetencionesTotalImpuesto = VarXml(xAtt3, "Impuesto")


                        Next
                    End If
                    If xAtt2.Name = "cfdi:Traslados" Then
                        xNodo = xDoc.GetElementsByTagName("cfdi:Traslados")
                        For Each xAtt3 In xNodo.Item(0)


                            TrasladosTotalImporte = VarXml(xAtt3, "Importe")
                            TrasladosTotalTasaOCuota = VarXml(xAtt3, "TasaOCuota")
                            TrasladosTotalTipoFactor = VarXml(xAtt3, "TipoFactor")
                            TrasladosTotalImpuesto = VarXml(xAtt3, "Impuesto")


                        Next
                    End If
                Next
            End If


            'COMPLEMENTOS
            xNodo = xDoc.GetElementsByTagName("cfdi:Complemento")
            If xNodo.Count > 0 Then
                For Each xAtt In xNodo

                Next
            End If


            For Each xAtt In xNodo.Item(0)
                If xAtt.LocalName Like "*TimbreFiscalDigital*" Then

                    VersionTimbreFiscal = VarXml(xAtt, "Version") 'Version
                    xsiSchemaLocation = VarXml(xAtt, "xsi:schemaLocation") 'xsi:schemaLocation
                    selloSAT = VarXml(xAtt, "selloSAT") 'selloSAT
                    noCertificadoSAT = VarXml(xAtt, "NoCertificadoSAT") 'noCertificadoSAT
                    selloCFD = VarXml(xAtt, "SelloCFD") 'selloCFD
                    FechaTimbrado = VarXml(xAtt, "FechaTimbrado") 'FechaTimbrado
                    UUID = VarXml(xAtt, "UUID") 'UUID

                    'NUEVO
                    RfcProvCertif = VarXml(xAtt, "RfcProvCertif") 'UUID


                End If

            Next

            guarda_encabezado()

        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Information)

        End Try

    End Sub
    Sub detalle_conceptos_3_3()

        Try
            limpia_detalle_XML()
            Dim xDoc As XmlDocument
            Dim xNodo As XmlNodeList
            Dim xAtt2 As XmlElement
            xDoc = New XmlDocument
            xDoc.Load(sPath)
            pos = 0


            'CONCEPTOS
            xNodo = xDoc.GetElementsByTagName("cfdi:Conceptos")
            If xNodo.Count > 0 Then

                'CONCEPTO
                For Each xAtt In xNodo.Item(0)

                    If xAtt.LocalName = "Concepto" Then
                        Importe = VarXml(xAtt, "Importe") 'Importe OK
                        ValorUnitario = VarXml(xAtt, "ValorUnitario") 'ValorUnitario OK
                        Descripcion = VarXml(xAtt, "Descripcion") 'Descripción OK
                        ClaveUnidad = VarXml(xAtt, "ClaveUnidad") 'NoIdentificacion
                        ClaveProdServ = VarXml(xAtt, "ClaveProdServ") 'NoIdentificacion
                        NoIdentificacion = VarXml(xAtt, "NoIdentificacion") 'NoIdentificacion
                        Unidad = VarXml(xAtt, "Unidad") 'Unidad OK
                        Cantidad = VarXml(xAtt, "Cantidad") 'Cantidad OK

                        If Unidad = "TO" Then
                            Cantidad = Cantidad * 1000
                            Unidad = "KGS"
                        End If

                        For Each listNode In xAtt.ChildNodes

                            If listNode.Name = "cfdi:CuentaPredial" Then
                                CuentaPredialNumero = VarXml(listNode, "Numero") 'Importe OK
                            End If
                            If listNode.Name = "cfdi:InformacionAduanera" Then
                                InformacionAduaneraNumeroPedimento = VarXml(listNode, "NumeroPedimento") 'Importe OK
                            End If
                            If listNode.Name = "cfdi:Parte" Then
                                ParteImporte = VarXml(listNode, "Importe") 'Importe OK
                                ParteValorUnitario = VarXml(listNode, "ValorUnitario") 'Importe OK
                                ParteDescripcion = VarXml(listNode, "Descripcion") 'Importe OK

                                ParteUnidad = VarXml(listNode, "Unidad") 'Importe OK
                                ParteCantidad = VarXml(listNode, "Cantidad") 'Importe OK
                                If ParteUnidad = "TO" Then
                                    ParteCantidad = ParteCantidad * 1000
                                    ParteUnidad = "KGS"
                                End If

                                ParteNoIdentificacion = VarXml(listNode, "NoIdentificacion") 'Importe OK
                                ParteClaveProdServ = VarXml(listNode, "ClaveProdServ") 'Importe OK
                            End If

                            For Each fieldNode In listNode.ChildNodes

                                For Each xAtt2 In fieldNode.ChildNodes

                                    If xAtt2.Name = "cfdi:Traslado" Then
                                        TrasladoImporte = VarXml(xAtt2, "Importe") 'Importe OK
                                        TrasladoTasaOCuota = VarXml(xAtt2, "TasaOCuota") 'Importe OK
                                        TrasladoTipoFactor = VarXml(xAtt2, "TipoFactor") 'Importe OK
                                        TrasladoImpuesto = VarXml(xAtt2, "Impuesto") 'Importe OK
                                        TrasladoBase = VarXml(xAtt2, "Base") 'Importe OK
                                    End If

                                    If xAtt2.Name = "cfdi:Retencion" Then
                                        RetencionImporte = VarXml(xAtt2, "Importe") 'Importe OK
                                        RetencionTasaOCuota = VarXml(xAtt2, "TasaOCuota") 'Importe OK
                                        RetencionTipoFactor = VarXml(xAtt2, "TipoFactor") 'Importe OK
                                        RetencionImpuesto = VarXml(xAtt2, "Impuesto") 'Importe OK
                                        RetencionBase = VarXml(xAtt2, "Base") 'Importe OK
                                    End If

                                Next

                            Next fieldNode
                        Next listNode
                    End If
                    pos = pos + 1




                    renglonSUB = renglonSUB + 1
                    renglon = renglon + 2048
                    insertaVentaDInteslis()
                    inserta_detalle()
                Next

            End If

            detalle_adenda()
        Catch ex As Exception
            MsgBox("Error:    " & ex.Message, MsgBoxStyle.Information)
            Exit Sub
        End Try

        ''IMPUESTOS

    End Sub
    Sub detalle_adenda()

        'Me.GridXML.DataSource = Nothing
        'lblTotalregistrosXML.Text = ""
        Dim xDoc As XmlDocument
        Dim xNodo As XmlNodeList
        Dim xAtt As XmlElement

        xDoc = New XmlDocument
        xDoc.Load(sPath)
        'CONCEPTOS
        xNodo = xDoc.GetElementsByTagName("cfdi:Addenda")
        If xNodo.Count > 0 Then
            'CONCEPTO
            For Each xAtt In xNodo.Item(0)

                If xAtt.LocalName = "FacturaInterfactura" Then

                    For Each listNode In xAtt.ChildNodes

                        For Each fieldNode In listNode.ChildNodes

                            If fieldNode.Name = "if:Cuerpo" Then
                                adenda_renglon = VarXml(fieldNode, "Renglon")

                                'If adenda_posision = adenda_renglon Then

                                'adenda_renglon = ""
                                adenda_codigo = ""
                                adenda_concepto = ""
                                adenda_peso = ""
                                adenda_referencia = ""
                                adenda_calibre = ""
                                adenda_ancho = ""
                                adenda_unidad_medida = ""
                                adenda_metros = ""

                                adenda_renglon = VarXml(fieldNode, "Renglon")
                                adenda_codigo = VarXml(fieldNode, "Codigo")
                                adenda_concepto = VarXml(fieldNode, "Concepto")
                                adenda_peso = VarXml(fieldNode, "PesoTotal")
                                adenda_referencia = VarXml(fieldNode, "FolioReferencia")
                                adenda_calibre = VarXml(fieldNode, "Calibre")
                                adenda_ancho = VarXml(fieldNode, "Ancho")
                                adenda_metros = VarXml(fieldNode, "Metros")
                                adenda_unidad_medida = VarXml(fieldNode, "U_x0020_de_x0020_M")
                                'End If

                            End If
                            inserta_adenda()
                        Next fieldNode
                    Next listNode
                End If
                ' pos = pos + 1

            Next

        End If






    End Sub
    '************************
    Private Function VarXml(ByRef xAtt As XmlElement, ByVal strVar As String) As String
        VarXml = xAtt.GetAttribute(strVar)
        If VarXml = Nothing Then VarXml = ""
    End Function
    Sub guarda_encabezado()

        SQL = "INSERT INTO ARASIS_XML_ENCABEZADO " &
                                            "(folio, " &
                                            "version, " &
                                            "serie, " &
                                            "fecha, " &
                                            "LugarExpedicion, " &
                                            "NumCtaPago, " &
                                            "TipodeComprobante, " &
                                            "condicionesDePago, " &
                                            "metodoDePago, " &
                                            "formaDePago, " &
                                            "TipoCambio, " &
                                            "Moneda, " &
                                            "subTotal, " &
                                            "total, " &
                                            "certificado, " &
                                            "noCertificado, " &
                                            "sello, " &
                                            "Descuento, " &
                                            "TipoRelacion, " &
                                            "RelacionadosUUID, " &
                                            "Emirfc, " &
                                            "EmiNombre, " &
                                            "EmiCalle, " &
                                            "EmiNoExterior, " &
                                            "EmiNoInterior, " &
                                            "EmiColonia, " &
                                            "Emilocalidad, " &
                                            "EmiMunicipio, " &
                                            "EmiEstado, " &
                                            "EmiPais, " &
                                            "EmiCodigoPostal, " &
                                            "EmiRegimenFiscal, " &
                                            "Receprfc, " &
                                            "RecepNombre, " &
                                            "RecepUsoCFDI, " &
                                            "RecepNumRegIdTrib, " &
                                            "RecepResidenciaFiscal, " &
                                            "RecepCalle, " &
                                            "RecepnoExterior, " &
                                            "RecepnoInterior, " &
                                            "RecepColonia, " &
                                            "RecepLocalidad, " &
                                            "RecepMunicipio, " &
                                            "RecepEstado, " &
                                            "RecepPaIs, " &
                                            "RecepCodigoPostal, " &
                                            "TotalImpuestosTrasladados, " &
                                            "TotalImpuestosRetenidos, " &
                                            "RetencionesTotalImporte, " &
                                            "RetencionesTotalImpuesto, " &
                                            "TrasladosTotalImporte, " &
                                            "TrasladosTotalTasaOCuota, " &
                                            "TrasladosTotalTipoFactor, " &
                                            "TrasladosTotalImpuesto, " &
                                            "VersionTimbreFiscal, " &
                                            "xsiSchemaLocation, " &
                                            "selloSAT, " &
                                            "noCertificadoSAT, " &
                                            "selloCFD, " &
                                            "FechaTimbrado, " &
                                            "UUID, " &
                                            "RfcProvCertif, " &
                                            "IVA, " &
                                            "IEPS,fecha_registro_xml,status_xml,usuario,Observaciones) " &
                                    "VALUES " &
                                            "('" & Folio & "' " &
                                            ",'" & Version_xml & "' " &
                                            ",'" & Serie & "' " &
                                            ",'" & Fecha & "' " &
                                            ",'" & LugarExpedicion & "' " &
                                            ",'" & NumCtaPago & "' " &
                                            ",'" & TipoComprobante & "' " &
                                            ",'" & CondicionesPago & "' " &
                                            ",'" & MetodoPago & "' " &
                                            ",'" & FormaPago & "' " &
                                            ",'" & TipoCambio & "' " &
                                            ",'" & Moneda & "' " &
                                            ",'" & SubTotal & "' " &
                                            ",'" & Total & "' " &
                                            ",'" & Certificado & "' " &
                                            ",'" & NoCertificado & "' " &
                                            ",'" & Sello & "' " &
                                            ",'" & Descuento & "' " &
                                            ",'" & TipoRelacion & "' " &
                                            ",'" & RelacionadosUUID & "' " &
                                            ",'" & Emirfc & "' " &
                                            ",'" & EmiNombre & "' " &
                                            ",'" & EmiCalle & "' " &
                                            ",'" & EminoExterior & "' " &
                                            ",'" & EminoInterior & "' " &
                                            ",'" & EmiColonia & "' " &
                                            ",'" & Emilocalidad & "' " &
                                            ",'" & EmiMunicipio & "' " &
                                            ",'" & EmiEstado & "' " &
                                            ",'" & EmiPais & "' " &
                                            ",'" & EmiCodigoPostal & "' " &
                                            ",'" & EmiRegimenFiscal & "' " &
                                            ",'" & Receprfc & "' " &
                                            ",'" & RecepNombre & "' " &
                                            ",'" & UsoCFDI & "' " &
                                            ",'" & NumRegIdTrib & "' " &
                                            ",'" & ResidenciaFiscal & "' " &
                                            ",'" & RecepCalle & "' " &
                                            ",'" & RecepnoExterior & "' " &
                                            ",'" & RecepnoInterior & "' " &
                                            ",'" & RecepColonia & "' " &
                                            ",'" & RecepLocalidad & "' " &
                                            ",'" & RecepMunicipio & "' " &
                                            ",'" & RecepEstado & "' " &
                                            ",'" & RecepPais & "' " &
                                            ",'" & RecepCodigoPostal & "' " &
                                            ",'" & TotalImpuestosTrasladados & "' " &
                                            ",'" & TotalImpuestosRetenidos & "' " &
                                            ",'" & RetencionesTotalImporte & "' " &
                                            ",'" & RetencionesTotalImpuesto & "' " &
                                            ",'" & TrasladosTotalImporte & "' " &
                                            ",'" & TrasladosTotalTasaOCuota & "' " &
                                            ",'" & TrasladosTotalTipoFactor & "' " &
                                            ",'" & TrasladosTotalImpuesto & "' " &
                                            ",'" & VersionTimbreFiscal & "' " &
                                            ",'" & xsiSchemaLocation & "' " &
                                            ",'" & selloSAT & "' " &
                                            ",'" & noCertificadoSAT & "' " &
                                            ",'" & selloCFD & "' " &
                                            ",'" & FechaTimbrado & "' " &
                                            ",'" & UUID & "' " &
                                            ",'" & RfcProvCertif & "' " &
                                            ",'" & IVA & "' " &
                                            ",'" & IEPS & "' " &
                                            ",GETDATE() " &
                                            ",'1' " &
                                            ",'" & Variables.USUARIO_SISTEMA & "','" & txtObservaciones.Text & "' );          SELECT @@IDENTITY AS ID"

        Dim da As New SqlDataAdapter(SQL, DB.obtenerConexionDB)
        Dim ds As New DataSet

        Try
            da.Fill(ds)
            If ds.Tables(0).Rows.Count = 0 Then

            Else
                idDetalle = ds.Tables(0).Rows(0)(0).ToString

                ' IMPORTAR_XML()
                If Version_xml = "3.2" Then
                    detalle_conceptos_3_2()
                End If

                If Version_xml = "3.3" Then
                    InsertaVentaIntelisis()
                    detalle_conceptos_3_3()
                    aplica_factura()
                End If

            End If





        Catch ex As Exception
            'Log.descripcion = ex.Message
            'Log.INSERTA_LOG()
            Beep()
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Information)
            Exit Sub
        End Try


        '  inserta_detalle()


    End Sub
    Sub inserta_detalle()

        Descripcion = Replace(Descripcion, "'", "")
        Unidad = Replace(Unidad, "'", "")

        SQL = "INSERT INTO ARASIS_XML_DETALLE " &
                                   "(id " &
                                   ",folio " &
                                   ",cantidad " &
                                   ",descripcion " &
                                   ",unidad " &
                                   ",valor_unitario " &
                                   ",importe " &
                                   ",noIdentificacion " &
                                   ",ClaveUnidad " &
                                   ",ClaveProdServ " &
                                   ",TrasladoImporte " &
                                   ",TrasladoTasaOCuota " &
                                   ",TrasladoTipoFactor " &
                                   ",TrasladoImpuesto " &
                                   ",TrasladoBase " &
                                   ",RetencionImporte " &
                                   ",RetencionTasaOCuota " &
                                   ",RetencionTipoFactor " &
                                   ",RetencionImpuesto " &
                                   ",RetencionBase " &
                                   ",CuentaPredialNumero " &
                                   ",InformacionAduaneraNumeroPedimento " &
                                   ",ParteImporte " &
                                   ",ParteValorUnitario " &
                                   ",ParteDescripcion " &
                                   ",ParteUnidad " &
                                   ",ParteCantidad " &
                                   ",ParteNoIdentificacion " &
                                   ",ParteClaveProdServ " &
                                   ",posicion,referencia,adenda_codigo,adenda_concepto,adenda_peso,adenda_calibre,adenda_ancho,adenda_unidad_medida)   " &
                             "VALUES " &
                                   "('" & idDetalle & "' " &
                                   ",'" & Folio & "' " &
                                   ",'" & Cantidad & "' " &
                                   ",'" & Descripcion & "' " &
                                   ",'" & Unidad & "' " &
                                   ",'" & ValorUnitario & "' " &
                                   ",'" & Importe & "' " &
                                   ",'" & NoIdentificacion & "' " &
                                   ",'" & ClaveUnidad & "' " &
                                   ",'" & ClaveProdServ & "' " &
                                   ",'" & TrasladoImporte & "' " &
                                   ",'" & TrasladoTasaOCuota & "' " &
                                   ",'" & TrasladoTipoFactor & "' " &
                                   ",'" & TrasladoImpuesto & "' " &
                                   ",'" & TrasladoBase & "' " &
                                   ",'" & RetencionImporte & "' " &
                                   ",'" & RetencionTasaOCuota & "' " &
                                   ",'" & RetencionTipoFactor & "' " &
                                   ",'" & RetencionImpuesto & "' " &
                                   ",'" & RetencionBase & "' " &
                                   ",'" & CuentaPredialNumero & "' " &
                                   ",'" & InformacionAduaneraNumeroPedimento & "' " &
                                   ",'" & ParteImporte & "' " &
                                   ",'" & ParteValorUnitario & "' " &
                                   ",'" & ParteDescripcion & "' " &
                                   ",'" & ParteUnidad & "' " &
                                   ",'" & ParteCantidad & "' " &
                                   ",'" & ParteNoIdentificacion & "' " &
                                   ",'" & ParteClaveProdServ & "' " &
                                   ", " & pos & " " &
                                   ",'" & adenda_referencia & "' " &
                                   ",'" & adenda_codigo & "' " &
                                   ",'" & adenda_concepto & "' " &
                                   ",'" & adenda_peso & "' " &
                                   ",'" & adenda_calibre & "' " &
                                   ",'" & adenda_ancho & "' " &
                                   ",'" & adenda_unidad_medida & "')                                   SELECT @@IDENTITY AS ID"

        Dim da As New SqlDataAdapter(SQL, DB.obtenerConexionDB)
        Dim ds As New DataSet

        Try
            da.Fill(ds)

            If ds.Tables(0).Rows.Count = 0 Then

            Else
                consecutivo = ds.Tables(0).Rows(0)(0).ToString


            End If

            limpia_detalle_XML()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Information)
            Exit Sub
        End Try

    End Sub
    Sub inserta_adenda()

        Descripcion = Replace(Descripcion, "'", "")
        Unidad = Replace(Unidad, "'", "")

        SQL = "INSERT INTO  [ARASIS_XML_ADDENDA] " &
                         "([id] " &
                         ",[folio] " &
                         ",[renglon] " &
                         ",[codigo] " &
                         ",[concepto] " &
                         ",[pesoTotal] " &
                         ",[FolioReferencia] " &
                         ",[Calibre] " &
                         ",[Ancho] " &
                         ",[Metros] " &
                         ",[fecha_creacion] " &
                         ",[usuario_creacion] " &
                         ",[status],[unidad_medida]) " &
                     "VALUES " &
                         "('" & idDetalle & "' " &
                         ",'" & Folio & "' " &
                         ",'" & adenda_renglon & "' " &
                         ",'" & adenda_codigo & "' " &
                         ",'" & adenda_concepto & "' " &
                         ",'" & adenda_peso & "' " &
                         ",'" & adenda_referencia & "' " &
                         ",'" & adenda_calibre & "' " &
                         ",'" & adenda_ancho & "' " &
                         ",'" & adenda_metros & "' " &
                         ",GETDATE() " &
                         ",'" & Variables.USUARIO_SISTEMA & "' " &
                         ",'1','" & adenda_unidad_medida & "')"

        Dim da As New SqlDataAdapter(SQL, DB.obtenerConexionDB)
        Dim ds As New DataSet

        Try
            da.Fill(ds)


        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Information)
            Exit Sub
        End Try

    End Sub
    'Sub LIMPIA_ETIQUETAS_XML()

    '    'TextPathExcel.Text = ""
    '    'lblProveedorXML.Text = ""
    '    'lblRFCXML.Text = ""
    '    'lblFolioXML.Text = ""
    '    'lblFechaXML.Text = ""

    '    'GridXML.DataSource = Nothing

    'End Sub
    Sub CARGA_CONSECUTIVO()

        Variables.ID_FAC = ""
        tbFolio.Text = ""
        tbSerie.Text = DB.obtenerSerieFactura.Trim

        SQL = "SELECT count(*) FROM [dbo].[ARASIS_XML_ENCABEZADO] WHERE [usuario] = '" & Variables.USUARIO_SISTEMA & "'"

        Dim da As New SqlDataAdapter(SQL, DB.obtenerConexionDB)
        Dim ds As New DataSet

        Try
            da.Fill(ds)

            If ds.Tables(0).Rows.Count = 0 Then
                tbFolio.Text = "1"
                Variables.ID_FAC = "1"
                tbFolio.Text = ceros(Variables.ID_FAC, CEROS_MAX)

            Else

                Dim i As Integer

                For i = 0 To ds.Tables(0).Rows.Count - 1
                    Variables.ID_FAC = ds.Tables(0).Rows(i)(0).ToString()
                Next

                If Variables.ID_FAC = "" Then
                    tbFolio.Text = ceros("1", CEROS_MAX)
                    Variables.ID_FAC = tbFolio.Text
                    Exit Sub
                End If



                Variables.ID_FAC = Variables.ID_FAC + 1
                tbFolio.Text = ceros(Variables.ID_FAC, CEROS_MAX)

            End If

        Catch ex As Exception
            tbFolio.Text = ceros("1", CEROS_MAX)
            Variables.ID_FAC = tbFolio.Text
            Exit Sub
        End Try

    End Sub
    Public Function ceros(Nro As String, Cantidad As Integer) As String
        Dim numero As String, cuantos As String, i As Integer
        numero = Trim(Nro) 'Trim quita los espacion en blanco
        cuantos = "0"
        For i = 1 To Cantidad
            cuantos = cuantos & "0"
        Next i
        ceros = Mid(cuantos, 1, Cantidad - Len(numero)) & numero
    End Function
    Private Sub cbMoneda_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbMoneda.SelectedIndexChanged

        If cbMoneda.Text <> "" Then
            'Variables.TipoMoneda = cbMoneda.Text.Trim
            calculaTotales()
            nupTipoCambio.Focus()
            ActualizarTC()
        End If

    End Sub
    Private Sub ckImpuestoTrasladoIVA16_CheckedChanged(sender As Object, e As EventArgs) Handles ckImpuestoTrasladoIVA16.CheckedChanged
        If ckImpuestoTrasladoIVA16.Checked = True Then
            ckImpuestoTrasladoIVA0.Checked = False
        End If

    End Sub
    Private Sub cbBuscaProducto_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub
    Sub VALIDA_EXISTENCIA_INTELISIS()

        SQL = "SELECT [Disponible] FROM [American].[dbo].[ArtDisponible] " &
                      "WHERE [Empresa] = 'DEPOT' " &
                        "AND [Almacen] = 'MONCLOVA 1' " &
               "AND [Articulo] = '" & ArtIntelisis & "' "

        Dim da As New SqlDataAdapter(SQL, DB.obtenerConexionDB)
        Dim ds As New DataSet

        Try
            da.Fill(ds)
            If ds.Tables(0).Rows.Count = 0 Then
                artDisponible = 0
                nudConceptoValorUnitario.Value = 0
                tbConceptoUnidad.Text = ""
                tbConceptoNoIdentificacion.Text = ""
                tbConceptoDescripcion.Text = ""
            Else
                artDisponible = ds.Tables(0).Rows(0)(0).ToString

            End If

        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Information)
            Exit Sub
        End Try



    End Sub
    Sub busca_producto_servicio()

        SQL = "SELECT [id],[claveProdServ],[descripcion] FROM [dbo].[tblcclaveprodserv] where [claveProdServ] = '" & idCveProdSer.Trim & "' "

        Dim da As New SqlDataAdapter(SQL, DB.obtenerConexionDB)
        Dim ds As New DataSet

        Try
            da.Fill(ds)

            If ds.Tables(0).Rows.Count = 0 Then
                Exit Sub
            Else

                Dim i As Integer

                Dim lista As List(Of cClaveProdServ) = New List(Of cClaveProdServ)()
                For i = 0 To ds.Tables(0).Rows.Count - 1
                    txtClaveProducto.Text = ""
                    txtDescProdServ.Text = ""
                    txtClaveProducto.Text = ds.Tables(0).Rows(i)(1).ToString()
                    txtDescProdServ.Text = ds.Tables(0).Rows(i)(2).ToString()

                Next
                ' cbClaveProdServ.Items.Add("")
                ' cbClaveProdServ.DataSource = lista

            End If

        Catch ex As Exception
            MsgBox("ERROR: " & ex.Message, MsgBoxStyle.Critical)
            Exit Sub
        End Try

    End Sub
    Sub busca_clave_unidad()

        SQL = "SELECT [id],[claveUnidad],[nombre] FROM [dbo].[tblcclaveunidad] WHERE [id] = '" & idCvedUnidad & "' "

        Dim da As New SqlDataAdapter(SQL, DB.obtenerConexionDB)
        Dim ds As New DataSet

        Try
            da.Fill(ds)

            If ds.Tables(0).Rows.Count = 0 Then
                Exit Sub
            Else

                Dim i As Integer

                Dim lista As List(Of cClaveUnidad) = New List(Of cClaveUnidad)()
                For i = 0 To ds.Tables(0).Rows.Count - 1
                    txtCvedUnidad.Text = ""
                    txtCvedUnidad.Text = ds.Tables(0).Rows(i)(1).ToString()
                Next

            End If

        Catch ex As Exception
            MsgBox("ERROR: " & ex.Message, MsgBoxStyle.Critical)
            Exit Sub
        End Try



    End Sub
    Public Sub ActualizarTC()

        Try

            Dim dbTC As Double

            Dim lErrCode As Integer

            Dim lRetCode, sErrMsg As String

            Dim httpBanxico As HttpWebRequest = CType(WebRequest.Create(“http://www.banxico.org.mx/DgieWSWeb/DgieWS?WSDL“), HttpWebRequest)

            WebRequest.DefaultWebProxy = httpBanxico.Proxy

            Dim TipoCambio As New Banxico.DgieWSPortClient

            Dim strTipoCambio As String

            strTipoCambio = TipoCambio.tiposDeCambioBanxico

            Dim doc As XElement = XElement.Parse(strTipoCambio)

            Dim queryTC As IEnumerable(Of XElement) = From d In doc.<bm:DataSet>.<bm:Series> Where d.@IDSERIE = “SF60653”

            ' TipoCambio.TipoCambio.DgieWSPortClient TC = New Tipocambio.TipoCambio.DgieWSPortClient();
            ' textBox1.Text = TC.tiposDeCambioBanxico();

            'Dim number As Integer = 8
            'Select Case number
            '    Case 
            'End Select

            'Select Case d

            For Each d As XElement In queryTC


                dbTC = d.<bm:Obs>.@OBS_VALUE

            Next

            nupTipoCambio.Value = 0
            nupTipoCambio.Value = dbTC

            'Dim binding As New BasicHttpBinding
            'Dim endpointAdress As New EndpointAddress("http://www.banxico.org.mx/DgieWSWeb/DgieWS?WSDL")
            'Dim sclient As New Banxico.DgieWSPortClient(binding, endpointAdress)
            'Dim SimonLoco As String
            'SimonLoco = sclient.tiposDeCambioBanxico()

            'oSBObob = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoBridge)

            'oSBObob.SetCurrencyRate(“USD”, Today, dbTC, False)

            'oCompany.GetLastError(lErrCode, sErrMsg)

            '    If lErrCode <> 0 Then

            '        SBO_Application.SetStatusBarMessage(sErrMsg, SAPbouiCOM.BoMessageTime.bmt_Short, True)

            '    End If

            '    SBO_Application.SetStatusBarMessage(“Tipo de cambio actualizado: ” & dbTC.ToString, SAPbouiCOM.BoMessageTime.bmt_Long, False)



        Catch ex As Exception

            'SBO_Application.SetStatusBarMessage(ex.Message, SAPbouiCOM.BoMessageTime.bmt_Long, False)

        End Try

    End Sub
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Try


            contador_timer = contador_timer + 1
            barra.Value = barra.Value + 1

            Label44.Text = contador_timer

            If contador_timer = 4 Then
                Timer2.Stop()

                If Variables.USUARIO_SISTEMA = "TEST010203001" Then
                    TimbraXMLPrueba()
                End If

                If Variables.USUARIO_SISTEMA = "DSP061215SL4" Then
                    TimbraXML()
                End If

                If Variables.USUARIO_SISTEMA = "OCD120403JU9" Then
                    TimbraXML()
                End If

                If Variables.ErrorMensajeTimbrado = "" Then
                    Timer2.Start()
                Else
                    Exit Sub
                End If


            End If

            If contador_timer = 11 Then
                Timer2.Stop()
                crea_pdf()
                Timer2.Start()
            End If


            If contador_timer = 25 Then
                Timer2.Stop()
                CARGA_CONSECUTIVO()
                MsgBox("Factura generada Correctamente", MsgBoxStyle.OkOnly)
                System.Diagnostics.Process.Start(rutaXMLT)
                System.Diagnostics.Process.Start(rutaPDF)
                Me.Close()
            End If

        Catch ex As Exception
            Timer2.Stop()
            MessageBox.Show(ex.Message, "Validando información...")
            Exit Sub
        End Try

    End Sub
    Sub TimbraXML()

        If cbMoneda.Text = "MXN- Peso Mexicano" Then
            nupTipoCambio.Value = 0
        End If

        Variables.ObservacionesCFDI = String.Empty
        If txtObservaciones.Text <> "" Then
            Variables.ObservacionesCFDI = "Observaciones: " & txtObservaciones.Text
        End If

        _c.Impuestos = getImpuestos(_c.Conceptos)
        verifica_carpeta()
        getCamposCombox()

        'Dim nombrearchivoXML = String.Format("{0}_{1:yyyyMMddHHmmss}.{2}", _c.Serie + _c.Folio, DateTime.Now, "xml")
        'Dim nombrearchivoPDF = String.Format("{0}_{1:yyyyMMddHHmmss}.{2}", _c.Serie + _c.Folio, DateTime.Now, "pdf")
        Dim nombrearchivoXML = _c.Serie + _c.Folio & ".xml"
        Dim nombrearchivoPDF = _c.Serie + _c.Folio & ".pdf"

        rutaXMLT = My.Settings.rutaXMLST & "\" & nombrearchivoXML

        Dim rutaXMLST As String = My.Settings.rutaXMLST & "\" & nombrearchivoXML
        Dim rutaPFX As String = DB.obtenerRutaPFX()
        Dim rutaCertificado As String = DB.obtenerRutaCertificado()
        Dim contrasenaPFX As String = DB.obtenerContrasenaPFX()
        'Dim rutaPDF As String = DB.obtenerRutaXML() + _c.Serie + _c.Folio & ".pdf"
        rutaPDF = My.Settings.rutaXMLST & "\" & nombrearchivoPDF

        Dim crearXML As CrearXML = New CrearXML()
        Dim errorC As CError = _c.EsInfoCorrecta()

        If Not errorC.HayError Then
            crearXML.Create(_c, rutaXMLST, rutaPFX, contrasenaPFX, rutaCertificado)

            ' validarXML.LoadValidatedXDocument(rutaXMLST, ".\GastosHidrocarburos10.xsd")
            ' validarXML.LoadValidatedXDocument(rutaXMLST, ".\cfdv33.xsd")
            Threading.Thread.Sleep(6000) ' 1 segundo
            'validarXML.LoadValidatedXDocument(rutaXMLST, ".\SAT\GastosHidrocarburos10.xsd")
            'validarXML.LoadValidatedXDocument(rutaXMLST, ".\SAT\cfdv33.xsd")
            statusTimbre = ""
            If Timbrar.timbrar(rutaXMLST, rutaXMLT, DB.obtenerUsuarioFD(), DB.contrasenaFD()) Then

                NArchivoS = ""
                RutaArchivoS = ""
                TipoArchivo = ""
                sExt = ""
                Threading.Thread.Sleep(10000)
                NArchivoS = nombrearchivoXML.Trim
                RutaArchivoS = "C:\eFacturaTemporales\" & nombrearchivoXML.Trim  'rutaXMLT.Trim
                TipoArchivo = "XML"
                guardaXML()

                LIMPIA_XML()
                limpia_detalle_XML()
                sPath = rutaXMLT.Trim
                saca_version()

                'Threading.Thread.Sleep(10000)

                'Threading.Thread.Sleep(6000) ' 1 segundo
                'MsgBox("Factura generada Correctamente", MsgBoxStyle.OkOnly)
                'System.Diagnostics.Process.Start(rutaXMLT)
                'System.Diagnostics.Process.Start(rutaPDF)
                'CARGA_CONSECUTIVO()
                'Me.Close()


            Else
                Timer2.Stop()

            End If
        Else
            Timer2.Stop()
            error_timbrado = "ERROR"
            MessageBox.Show(errorC.Error, "Validando información...")
        End If




    End Sub
    Sub TimbraXMLPrueba()

        If cbMoneda.Text = "MXN- Peso Mexicano" Then
            nupTipoCambio.Value = 0
        End If

        Variables.ObservacionesCFDI = String.Empty
        If txtObservaciones.Text <> "" Then
            Variables.ObservacionesCFDI = "Observaciones: " & txtObservaciones.Text
        End If

        _c.Impuestos = getImpuestos(_c.Conceptos)
        verifica_carpeta()
        getCamposCombox()

        'Dim nombrearchivoXML = String.Format("{0}_{1:yyyyMMddHHmmss}.{2}", _c.Serie + _c.Folio, DateTime.Now, "xml")
        'Dim nombrearchivoPDF = String.Format("{0}_{1:yyyyMMddHHmmss}.{2}", _c.Serie + _c.Folio, DateTime.Now, "pdf")
        Dim nombrearchivoXML = _c.Serie + _c.Folio & ".xml"
        Dim nombrearchivoPDF = _c.Serie + _c.Folio & ".pdf"

        rutaXMLT = My.Settings.rutaXMLST & "\" & nombrearchivoXML

        Dim rutaXMLST As String = My.Settings.rutaXMLST & "\" & nombrearchivoXML
        Dim rutaPFX As String = DB.obtenerRutaPFX()
        Dim rutaCertificado As String = DB.obtenerRutaCertificado()
        Dim contrasenaPFX As String = DB.obtenerContrasenaPFX()
        'Dim rutaPDF As String = DB.obtenerRutaXML() + _c.Serie + _c.Folio & ".pdf"
        rutaPDF = My.Settings.rutaXMLST & "\" & nombrearchivoPDF

        Dim crearXML As CrearXML = New CrearXML()
        Dim errorC As CError = _c.EsInfoCorrecta()

        If Not errorC.HayError Then
            crearXML.Create(_c, rutaXMLST, rutaPFX, contrasenaPFX, rutaCertificado)

            ' validarXML.LoadValidatedXDocument(rutaXMLST, ".\GastosHidrocarburos10.xsd")
            ' validarXML.LoadValidatedXDocument(rutaXMLST, ".\cfdv33.xsd")
            Threading.Thread.Sleep(6000) ' 1 segundo
            'validarXML.LoadValidatedXDocument(rutaXMLST, ".\SAT\GastosHidrocarburos10.xsd")
            'validarXML.LoadValidatedXDocument(rutaXMLST, ".\SAT\cfdv33.xsd")
            statusTimbre = ""
            If TimbrarPrueba.timbrar(rutaXMLST, rutaXMLT, DB.obtenerUsuarioFD(), DB.contrasenaFD()) Then

                NArchivoS = ""
                RutaArchivoS = ""
                TipoArchivo = ""
                sExt = ""
                Threading.Thread.Sleep(10000)
                NArchivoS = nombrearchivoXML.Trim
                RutaArchivoS = "C:\eFacturaTemporales\" & nombrearchivoXML.Trim  'rutaXMLT.Trim
                TipoArchivo = "XML"
                sExt = Path.GetExtension(rutaXMLT.Trim)
                guardaXML()

                LIMPIA_XML()
                limpia_detalle_XML()
                sPath = rutaXMLT.Trim
                saca_version()

                'Threading.Thread.Sleep(10000)

                'Threading.Thread.Sleep(6000) ' 1 segundo
                'MsgBox("Factura generada Correctamente", MsgBoxStyle.OkOnly)
                'System.Diagnostics.Process.Start(rutaXMLT)
                'System.Diagnostics.Process.Start(rutaPDF)
                'CARGA_CONSECUTIVO()
                'Me.Close()

            Else
                Timer2.Stop()
            End If
        Else
            Timer2.Stop()
            error_timbrado = "ERROR"
            MessageBox.Show(errorC.Error, "Validando información...")
        End If




    End Sub
    Private Sub CkImpuestoTrasladoIVA0_CheckedChanged(sender As Object, e As EventArgs) Handles ckImpuestoTrasladoIVA0.CheckedChanged
        If ckImpuestoTrasladoIVA0.Checked = True Then
            ckImpuestoTrasladoIVA16.Checked = False
        End If
    End Sub
    '***************************MODULO DE PREFACTURA**************************************************************************
    Sub _PREFACTURA()

        Folio = ""
        Version_xml = ""
        Serie = ""
        Fecha = ""
        LugarExpedicion = tbLugarExpedicion.Text
        NumCtaPago = ""
        TipoComprobante = cbTipoComprobante.Text
        CondicionesPago = tbCondicionesPago.Text
        MetodoPago = cbMetodoPago.Text
        FormaPago = cbFormaPago.Text
        TipoCambio = nupTipoCambio.Value
        Moneda = ""
        SubTotal = ""
        Total = ""
        Certificado = ""
        NoCertificado = ""
        Sello = ""
        Descuento = ""
        TipoRelacion = ""
        RelacionadosUUID = ""
        Emirfc = ""
        EmiNombre = ""
        EmiCalle = ""
        EminoExterior = ""
        EminoInterior = ""
        EmiColonia = ""
        Emilocalidad = ""
        EmiMunicipio = ""
        EmiEstado = ""
        EmiPais = ""
        EmiCodigoPostal = ""
        EmiRegimenFiscal = ""
        Receprfc = ""
        RecepNombre = ""
        UsoCFDI = ""
        NumRegIdTrib = ""
        ResidenciaFiscal = ""
        RecepCalle = ""
        RecepnoExterior = ""
        RecepnoInterior = ""
        RecepColonia = ""
        RecepLocalidad = ""
        RecepMunicipio = ""
        RecepEstado = ""
        RecepPais = ""
        RecepCodigoPostal = ""
        TotalImpuestosTrasladados = ""
        TotalImpuestosRetenidos = ""
        RetencionesTotalImporte = ""
        RetencionesTotalImpuesto = ""
        TrasladosTotalImporte = ""
        TrasladosTotalTasaOCuota = ""
        TrasladosTotalTipoFactor = ""
        TrasladosTotalImpuesto = ""
        VersionTimbreFiscal = ""
        xsiSchemaLocation = ""
        selloSAT = ""
        noCertificadoSAT = ""
        selloCFD = ""
        FechaTimbrado = ""
        UUID = ""
        RfcProvCertif = ""
        IVA = ""
        IEPS = ""
        rfc_user = ""





    End Sub
    Private Sub getCamposCombox_prefactura()
        If cbRegimenesFiscales.SelectedItem IsNot Nothing Then _c.Emisor.RegimenFiscal = (CType(cbRegimenesFiscales.SelectedItem, cRegimenFiscal)).RegimenFiscal
        If cbTipoComprobante.SelectedItem IsNot Nothing Then _c.TipoDeComprobante = (CType(cbTipoComprobante.SelectedItem, cTipoComprobante)).TipoComprobante
        If cbMoneda.SelectedItem IsNot Nothing Then _c.Moneda = (CType(cbMoneda.SelectedItem, cMoneda)).Moneda
        If cbMetodoPago.SelectedItem IsNot Nothing Then _c.MetodoPago = (CType(cbMetodoPago.SelectedItem, cMetodoPago)).MetodoPago
        If cbFormaPago.SelectedItem IsNot Nothing Then _c.FormaPago = (CType(cbFormaPago.SelectedItem, cFormaPago)).FormaPago
        If cbClientes.SelectedItem IsNot Nothing Then
            _c.Receptor.Nombre = (CType(cbClientes.SelectedItem, Cliente)).RazonSocial
            _c.Receptor.Rfc = (CType(cbClientes.SelectedItem, Cliente)).RFC
            _c.Receptor.UsoCFDI = (CType(cbUsoCfdi.SelectedItem, cUsoCFDI)).UsoCFDI
        End If
    End Sub
    Sub guarda_encabezado_prefactura()

        SQL = "INSERT INTO ARASIS_XML_ENCABEZADO " &
                                            "(folio, " &
                                            "version, " &
                                            "serie, " &
                                            "fecha, " &
                                            "LugarExpedicion, " &
                                            "NumCtaPago, " &
                                            "TipodeComprobante, " &
                                            "condicionesDePago, " &
                                            "metodoDePago, " &
                                            "formaDePago, " &
                                            "TipoCambio, " &
                                            "Moneda, " &
                                            "subTotal, " &
                                            "total, " &
                                            "certificado, " &
                                            "noCertificado, " &
                                            "sello, " &
                                            "Descuento, " &
                                            "TipoRelacion, " &
                                            "RelacionadosUUID, " &
                                            "Emirfc, " &
                                            "EmiNombre, " &
                                            "EmiCalle, " &
                                            "EmiNoExterior, " &
                                            "EmiNoInterior, " &
                                            "EmiColonia, " &
                                            "Emilocalidad, " &
                                            "EmiMunicipio, " &
                                            "EmiEstado, " &
                                            "EmiPais, " &
                                            "EmiCodigoPostal, " &
                                            "EmiRegimenFiscal, " &
                                            "Receprfc, " &
                                            "RecepNombre, " &
                                            "RecepUsoCFDI, " &
                                            "RecepNumRegIdTrib, " &
                                            "RecepResidenciaFiscal, " &
                                            "RecepCalle, " &
                                            "RecepnoExterior, " &
                                            "RecepnoInterior, " &
                                            "RecepColonia, " &
                                            "RecepLocalidad, " &
                                            "RecepMunicipio, " &
                                            "RecepEstado, " &
                                            "RecepPaIs, " &
                                            "RecepCodigoPostal, " &
                                            "TotalImpuestosTrasladados, " &
                                            "TotalImpuestosRetenidos, " &
                                            "RetencionesTotalImporte, " &
                                            "RetencionesTotalImpuesto, " &
                                            "TrasladosTotalImporte, " &
                                            "TrasladosTotalTasaOCuota, " &
                                            "TrasladosTotalTipoFactor, " &
                                            "TrasladosTotalImpuesto, " &
                                            "VersionTimbreFiscal, " &
                                            "xsiSchemaLocation, " &
                                            "selloSAT, " &
                                            "noCertificadoSAT, " &
                                            "selloCFD, " &
                                            "FechaTimbrado, " &
                                            "UUID, " &
                                            "RfcProvCertif, " &
                                            "IVA, " &
                                            "IEPS,fecha_registro_xml,status_xml,usuario,Observaciones) " &
                                    "VALUES " &
                                            "('" & Folio & "' " &
                                            ",'" & Version_xml & "' " &
                                            ",'" & Serie & "' " &
                                            ",'" & Fecha & "' " &
                                            ",'" & LugarExpedicion & "' " &
                                            ",'" & NumCtaPago & "' " &
                                            ",'" & TipoComprobante & "' " &
                                            ",'" & CondicionesPago & "' " &
                                            ",'" & MetodoPago & "' " &
                                            ",'" & FormaPago & "' " &
                                            ",'" & TipoCambio & "' " &
                                            ",'" & Moneda & "' " &
                                            ",'" & SubTotal & "' " &
                                            ",'" & Total & "' " &
                                            ",'" & Certificado & "' " &
                                            ",'" & NoCertificado & "' " &
                                            ",'" & Sello & "' " &
                                            ",'" & Descuento & "' " &
                                            ",'" & TipoRelacion & "' " &
                                            ",'" & RelacionadosUUID & "' " &
                                            ",'" & Emirfc & "' " &
                                            ",'" & EmiNombre & "' " &
                                            ",'" & EmiCalle & "' " &
                                            ",'" & EminoExterior & "' " &
                                            ",'" & EminoInterior & "' " &
                                            ",'" & EmiColonia & "' " &
                                            ",'" & Emilocalidad & "' " &
                                            ",'" & EmiMunicipio & "' " &
                                            ",'" & EmiEstado & "' " &
                                            ",'" & EmiPais & "' " &
                                            ",'" & EmiCodigoPostal & "' " &
                                            ",'" & EmiRegimenFiscal & "' " &
                                            ",'" & Receprfc & "' " &
                                            ",'" & RecepNombre & "' " &
                                            ",'" & UsoCFDI & "' " &
                                            ",'" & NumRegIdTrib & "' " &
                                            ",'" & ResidenciaFiscal & "' " &
                                            ",'" & RecepCalle & "' " &
                                            ",'" & RecepnoExterior & "' " &
                                            ",'" & RecepnoInterior & "' " &
                                            ",'" & RecepColonia & "' " &
                                            ",'" & RecepLocalidad & "' " &
                                            ",'" & RecepMunicipio & "' " &
                                            ",'" & RecepEstado & "' " &
                                            ",'" & RecepPais & "' " &
                                            ",'" & RecepCodigoPostal & "' " &
                                            ",'" & TotalImpuestosTrasladados & "' " &
                                            ",'" & TotalImpuestosRetenidos & "' " &
                                            ",'" & RetencionesTotalImporte & "' " &
                                            ",'" & RetencionesTotalImpuesto & "' " &
                                            ",'" & TrasladosTotalImporte & "' " &
                                            ",'" & TrasladosTotalTasaOCuota & "' " &
                                            ",'" & TrasladosTotalTipoFactor & "' " &
                                            ",'" & TrasladosTotalImpuesto & "' " &
                                            ",'" & VersionTimbreFiscal & "' " &
                                            ",'" & xsiSchemaLocation & "' " &
                                            ",'" & selloSAT & "' " &
                                            ",'" & noCertificadoSAT & "' " &
                                            ",'" & selloCFD & "' " &
                                            ",'" & FechaTimbrado & "' " &
                                            ",'" & UUID & "' " &
                                            ",'" & RfcProvCertif & "' " &
                                            ",'" & IVA & "' " &
                                            ",'" & IEPS & "' " &
                                            ",GETDATE() " &
                                            ",'1' " &
                                            ",'" & Variables.USUARIO_SISTEMA & "','" & txtObservaciones.Text & "' );          SELECT @@IDENTITY AS ID"

        Dim da As New SqlDataAdapter(SQL, DB.obtenerConexionDB)
        Dim ds As New DataSet

        Try
            da.Fill(ds)
            If ds.Tables(0).Rows.Count = 0 Then

            Else
                idDetalle = ds.Tables(0).Rows(0)(0).ToString
                consecutivoIntelisis = ds.Tables(0).Rows(0)(0).ToString
                ' IMPORTAR_XML()
                'If Version_xml = "3.2" Then
                '    detalle_conceptos_3_2()
                'End If

                'If Version_xml = "3.3" Then
                detalle_conceptos_3_3()
                'End If

            End If





        Catch ex As Exception
            'Log.descripcion = ex.Message
            'Log.INSERTA_LOG()
            Beep()
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Information)
            Exit Sub
        End Try


        '  inserta_detalle()


    End Sub
    Sub inserta_detalle_prefactura()

        Descripcion = Replace(Descripcion, "'", "")
        Unidad = Replace(Unidad, "'", "")

        SQL = "INSERT INTO ARASIS_XML_DETALLE " &
                                   "(id " &
                                   ",folio " &
                                   ",cantidad " &
                                   ",descripcion " &
                                   ",unidad " &
                                   ",valor_unitario " &
                                   ",importe " &
                                   ",noIdentificacion " &
                                   ",ClaveUnidad " &
                                   ",ClaveProdServ " &
                                   ",TrasladoImporte " &
                                   ",TrasladoTasaOCuota " &
                                   ",TrasladoTipoFactor " &
                                   ",TrasladoImpuesto " &
                                   ",TrasladoBase " &
                                   ",RetencionImporte " &
                                   ",RetencionTasaOCuota " &
                                   ",RetencionTipoFactor " &
                                   ",RetencionImpuesto " &
                                   ",RetencionBase " &
                                   ",CuentaPredialNumero " &
                                   ",InformacionAduaneraNumeroPedimento " &
                                   ",ParteImporte " &
                                   ",ParteValorUnitario " &
                                   ",ParteDescripcion " &
                                   ",ParteUnidad " &
                                   ",ParteCantidad " &
                                   ",ParteNoIdentificacion " &
                                   ",ParteClaveProdServ " &
                                   ",posicion,referencia,adenda_codigo,adenda_concepto,adenda_peso,adenda_calibre,adenda_ancho,adenda_unidad_medida)   " &
                             "VALUES " &
                                   "('" & idDetalle & "' " &
                                   ",'" & Folio & "' " &
                                   ",'" & Cantidad & "' " &
                                   ",'" & Descripcion & "' " &
                                   ",'" & Unidad & "' " &
                                   ",'" & ValorUnitario & "' " &
                                   ",'" & Importe & "' " &
                                   ",'" & NoIdentificacion & "' " &
                                   ",'" & ClaveUnidad & "' " &
                                   ",'" & ClaveProdServ & "' " &
                                   ",'" & TrasladoImporte & "' " &
                                   ",'" & TrasladoTasaOCuota & "' " &
                                   ",'" & TrasladoTipoFactor & "' " &
                                   ",'" & TrasladoImpuesto & "' " &
                                   ",'" & TrasladoBase & "' " &
                                   ",'" & RetencionImporte & "' " &
                                   ",'" & RetencionTasaOCuota & "' " &
                                   ",'" & RetencionTipoFactor & "' " &
                                   ",'" & RetencionImpuesto & "' " &
                                   ",'" & RetencionBase & "' " &
                                   ",'" & CuentaPredialNumero & "' " &
                                   ",'" & InformacionAduaneraNumeroPedimento & "' " &
                                   ",'" & ParteImporte & "' " &
                                   ",'" & ParteValorUnitario & "' " &
                                   ",'" & ParteDescripcion & "' " &
                                   ",'" & ParteUnidad & "' " &
                                   ",'" & ParteCantidad & "' " &
                                   ",'" & ParteNoIdentificacion & "' " &
                                   ",'" & ParteClaveProdServ & "' " &
                                   ", " & pos & " " &
                                   ",'" & adenda_referencia & "' " &
                                   ",'" & adenda_codigo & "' " &
                                   ",'" & adenda_concepto & "' " &
                                   ",'" & adenda_peso & "' " &
                                   ",'" & adenda_calibre & "' " &
                                   ",'" & adenda_ancho & "' " &
                                   ",'" & adenda_unidad_medida & "')                                   SELECT @@IDENTITY AS ID"

        Dim da As New SqlDataAdapter(SQL, DB.obtenerConexionDB)
        Dim ds As New DataSet

        Try
            da.Fill(ds)

            If ds.Tables(0).Rows.Count = 0 Then

            Else
                consecutivo = ds.Tables(0).Rows(0)(0).ToString


            End If

            limpia_detalle_XML()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Information)
            Exit Sub
        End Try

    End Sub

    '***************************************inserta Venta y VentaD a ERP Intelisis 30/05/2019
    Sub InsertaVentaIntelisis()


        Dim SUBtOTAL As Double = lSubtotal.Text
        Dim IVAINTELISIS As Double = lIVA.Text



        SQL = "INSERT INTO [American].[dbo].[Venta] " &
                               "([EMPRESA] " &
                               ",[Mov] " &
                               ",[MovID] " &
                               ",[FechaEmision] " &
                               ",[UltimoCambio] " &
                               ",[Concepto] " &
                               ",[Proyecto] " &
                               ",[UEN] " &
                               ",[Moneda] " &
                               ",[TipoCambio] " &
                               ",[Usuario] " &
                               ",[Autorizacion] " &
                               ",[Referencia] " &
                               ",[DocFuente] " &
                               ",[Observaciones] " &
                               ",[Estatus] " &
                               ",[Situacion] " &
                               ",[SituacionFecha] " &
                               ",[SituacionUsuario] " &
                               ",[SituacionNota] " &
                               ",[Directo] " &
                               ",[Prioridad] " &
                               ",[RenglonID] " &
                               ",[FechaOriginal] " &
                               ",[Codigo] " &
                               ",[Cliente] " &
                               ",[EnviarA] " &
                               ",[Almacen] " &
                               ",[AlmacenDestino] " &
                               ",[Agente] " &
                               ",[AgenteServicio] " &
                               ",[AgenteComision] " &
                               ",[FormaEnvio] " &
                               ",[FechaRequerida] " &
                               ",[HoraRequerida] " &
                               ",[FechaProgramadaEnvio] " &
                               ",[FechaOrdenCompra] " &
                               ",[ReferenciaOrdenCompra] " &
                               ",[OrdenCompra] " &
                               ",[Condicion] " &
                               ",[Vencimiento] " &
                               ",[CtaDinero] " &
                               ",[Descuento] " &
                               ",[DescuentoGlobal] " &
                               ",[Importe] " &
                               ",[Impuestos] " &
                               ",[Saldo] " &
                               ",[AnticiposFacturados] " &
                               ",[AnticiposImpuestos] " &
                               ",[Retencion] " &
                               ",[DescuentoLineal] " &
                               ",[ComisionTotal] " &
                               ",[CostoTotal] " &
                               ",[PrecioTotal] " &
                               ",[Paquetes] " &
                               ",[ServicioTipo] " &
                               ",[ServicioArticulo] " &
                               ",[ServicioSerie] " &
                               ",[ServicioContrato] " &
                               ",[ServicioContratoID] " &
                               ",[ServicioContratoTipo] " &
                               ",[ServicioGarantia] " &
                               ",[ServicioDescripcion] " &
                               ",[ServicioFecha] " &
                               ",[ServicioFlotilla] " &
                               ",[ServicioRampa] " &
                               ",[ServicioIdentificador] " &
                               ",[ServicioPlacas] " &
                               ",[ServicioKms] " &
                               ",[ServicioTipoOrden] " &
                               ",[ServicioTipoOperacion] " &
                               ",[ServicioSiniestro] " &
                               ",[ServicioExpress] " &
                               ",[ServicioDemerito] " &
                               ",[ServicioDeducible] " &
                               ",[ServicioDeducibleImporte] " &
                               ",[ServicioNumero] " &
                               ",[ServicioNumeroEconomico] " &
                               ",[ServicioAseguradora] " &
                               ",[ServicioPuntual] " &
                               ",[ServicioPoliza] " &
                               ",[OrigenTipo] " &
                               ",[Origen] " &
                               ",[OrigenID] " &
                               ",[Poliza] " &
                               ",[PolizaID] " &
                               ",[GenerarPoliza] " &
                               ",[ContID] " &
                               ",[Ejercicio] " &
                               ",[Periodo] " &
                               ",[FechaRegistro] " &
                               ",[FechaConclusion] " &
                               ",[FechaCancelacion] " &
                               ",[FechaEntrega] " &
                               ",[EmbarqueEstado] " &
                               ",[EmbarqueGastos] " &
                               ",[Peso] " &
                               ",[Volumen] " &
                               ",[Causa] " &
                               ",[Atencion] " &
                               ",[AtencionTelefono] " &
                               ",[ListaPreciosEsp] " &
                               ",[ZonaImpuesto] " &
                               ",[Extra] " &
                               ",[CancelacionID] " &
                               ",[Mensaje] " &
                               ",[Departamento] " &
                               ",[Sucursal] " &
                               ",[GenerarOP] " &
                               ",[DesglosarImpuestos] " &
                               ",[DesglosarImpuesto2] " &
                               ",[ExcluirPlaneacion] " &
                               ",[ConVigencia] " &
                               ",[VigenciaDesde] " &
                               ",[VigenciaHasta] " &
                               ",[Enganche] " &
                               ",[Bonificacion] " &
                               ",[IVAFiscal] " &
                               ",[IEPSFiscal] " &
                               ",[EstaImpreso] " &
                               ",[Periodicidad] " &
                               ",[SubModulo] " &
                               ",[ContUso] " &
                               ",[Espacio] " &
                               ",[AutoCorrida] " &
                               ",[AutoCorridaHora] " &
                               ",[AutoCorridaServicio] " &
                               ",[AutoCorridaRol] " &
                               ",[AutoCorridaOrigen] " &
                               ",[AutoCorridaDestino] " &
                               ",[AutoCorridaKms] " &
                               ",[AutoCorridaLts] " &
                               ",[AutoCorridaRuta] " &
                               ",[AutoOperador2] " &
                               ",[AutoBoleto] " &
                               ",[AutoKms] " &
                               ",[AutoKmsActuales] " &
                               ",[AutoBomba] " &
                               ",[AutoBombaContador] " &
                               ",[Logico1] " &
                               ",[Logico2] " &
                               ",[Logico3] " &
                               ",[Logico4] " &
                               ",[DifCredito] " &
                               ",[EspacioResultado] " &
                               ",[Clase] " &
                               ",[Subclase] " &
                               ",[GastoAcreedor] " &
                               ",[GastoConcepto] " &
                               ",[Comentarios] " &
                               ",[Pagado] " &
                               ",[GenerarDinero] " &
                               ",[Dinero] " &
                               ",[DineroID] " &
                               ",[DineroCtaDinero] " &
                               ",[DineroConciliado] " &
                               ",[DineroFechaConciliacion] " &
                               ",[Extra1] " &
                               ",[Extra2] " &
                               ",[Extra3] " &
                               ",[Reabastecido] " &
                               ",[SucursalVenta] " &
                               ",[AF] " &
                               ",[AFArticulo] " &
                               ",[AFSerie] " &
                               ",[ContratoTipo] " &
                               ",[ContratoDescripcion] " &
                               ",[ContratoSerie] " &
                               ",[ContratoValor] " &
                               ",[ContratoValorMoneda] " &
                               ",[ContratoSeguro] " &
                               ",[ContratoVencimiento] " &
                               ",[ContratoResponsable] " &
                               ",[Incentivo] " &
                               ",[IncentivoConcepto] " &
                               ",[EndosarA] " &
                               ",[InteresTasa] " &
                               ",[InteresIVA] " &
                               ",[AnexoID] " &
                               ",[FordVisitoOASIS] " &
                               ",[LineaCredito] " &
                               ",[TipoAmortizacion] " &
                               ",[TipoTasa] " &
                               ",[Comisiones] " &
                               ",[ComisionesIVA] " &
                               ",[CompraID] " &
                               ",[OperacionRelevante] " &
                               ",[TieneTasaEsp] " &
                               ",[TasaEsp] " &
                               ",[FormaPagoTipo] " &
                               ",[SobrePrecio] " &
                               ",[SincroC] " &
                               ",[SucursalOrigen] " &
                               ",[SucursalDestino] " &
                               ",[CFDFlexEstatus] " &
                               ",[CFDTimbrado]) " &
                         "VALUES " &
                               "('" & EmpresaIntelisis & "' " &
                               ",'Factura' " &
                               ",NULL " &
                               ",'" & Format(Now, "yyyy-dd-MM") & "' " &
                               ",GETDATE() " &
                               ",'" & cmbConcepto.Text.Trim & "' " &
                               ",NULL " &
                               ",NULL " &
                               ",'Pesos' " &
                               ",1 " &
                               ",'INT' " &
                               ",NULL " &
                               ",'" & txtReferenciaIntelisis.Text & "' " &
                               ",NULL " &
                               ",'" & txtObservaciones.Text & "' " &
                               ",'SINAFECTAR' " &
                               ",NULL " &
                               ",NULL " &
                               ",NULL " &
                               ",NULL " &
                               ",1 " &
                               ",'Normal' " &
                               ",1 " &
                               ",NULL " &
                               ",NULL " &
                               ",'" & CVE_CTE_INTELISIS & "' " &
                               ",NULL " &
                               ",'" & cmbAlmacenIntelisis.Text.Trim & "' " &
                               ",NULL " &
                               ",'" & AgenteIntelisis & "' " &
                               ",NULL " &
                               ",NULL " &
                               ",NULL " &
                               ",'" & Format(Now, "yyyy-dd-MM") & "' " &
                               ",NULL " &
                               ",NULL " &
                               ",NULL " &
                               ",NULL " &
                               ",NULL " &
                               ",'" & cmbCondicionesIntelisis.Text.Trim & "' " &
                               ",'" & Format(Now, "yyyy-dd-MM") & "' " &
                               ",NULL " &
                               ",NULL " &
                               ",NULL " &
                               "," & SUBtOTAL & " " &
                               "," & IVAINTELISIS & " " &
                               ",NULL " &
                               ",NULL " &
                               ",NULL " &
                               ",NULL " &
                               ",NULL " &
                               ",NULL " &
                               ",NULL " &
                               ",NULL " &
                               ",NULL " &
                               ",NULL " &
                               ",NULL " &
                               ",NULL " &
                               ",NULL " &
                               ",NULL " &
                               ",NULL " &
                               ",0 " &
                               ",NULL " &
                               ",NULL " &
                               ",0 " &
                               ",0 " &
                               ",NULL " &
                               ",NULL " &
                               ",NULL " &
                               ",NULL " &
                               ",NULL " &
                               ",NULL " &
                               ",0 " &
                               ",0 " &
                               ",0 " &
                               ",NULL " &
                               ",NULL " &
                               ",NULL " &
                               ",NULL " &
                               ",0 " &
                               ",NULL " &
                               ",NULL " &
                               ",NULL " &
                               ",NULL " &
                               ",NULL " &
                               ",NULL " &
                               ",0 " &
                               ",NULL " &
                               ",NULL " &
                               ",NULL " &
                               ",NULL " &
                               ",NULL " &
                               ",NULL " &
                               ",NULL " &
                               ",NULL " &
                               ",NULL " &
                               ",NULL " &
                               ",NULL " &
                               ",NULL " &
                               ",NULL " &
                               ",NULL " &
                               ",'(Precio Lista)' " &
                               ",NULL " &
                               ",0 " &
                               ",NULL " &
                               ",NULL " &
                               ",NULL " &
                               ",0 " &
                               ",0 " &
                               ",1 " &
                               ",0 " &
                               ",0 " &
                               ",0 " &
                               ",NULL " &
                               ",NULL " &
                               ",NULL " &
                               ",NULL " &
                               ",NULL " &
                               ",NULL " &
                               ",0 " &
                               ",NULL " &
                               ",'VTAS' " &
                               ",NULL " &
                               ",NULL " &
                               ",NULL " &
                               ",NULL " &
                               ",NULL " &
                               ",NULL " &
                               ",NULL " &
                               ",NULL " &
                               ",NULL " &
                               ",NULL " &
                               ",NULL " &
                               ",NULL " &
                               ",NULL " &
                               ",NULL " &
                               ",NULL " &
                               ",NULL " &
                               ",NULL " &
                               ",0 " &
                               ",0 " &
                               ",0 " &
                               ",0 " &
                               ",NULL " &
                               ",0 " &
                               ",NULL " &
                               ",NULL " &
                               ",NULL " &
                               ",NULL " &
                               ",'' " &
                               ",NULL " &
                               ",0 " &
                               ",NULL " &
                               ",NULL " &
                               ",NULL " &
                               ",0 " &
                               ",NULL " &
                               ",0 " &
                               ",0 " &
                               ",0 " &
                               ",0 " &
                               ",0 " &
                               ",0 " &
                               ",NULL " &
                               ",NULL " &
                               ",NULL " &
                               ",NULL " &
                               ",NULL " &
                               ",NULL " &
                               ",NULL " &
                               ",NULL " &
                               ",NULL " &
                               ",NULL " &
                               ",NULL " &
                               ",NULL " &
                               ",NULL " &
                               ",NULL " &
                               ",NULL " &
                               ",NULL " &
                               ",0 " &
                               ",NULL " &
                               ",NULL " &
                               ",NULL  " &
                               ",NULL " &
                               ",NULL " &
                               ",NULL " &
                               ",NULL " &
                               ",0 " &
                               ",NULL " &
                               ",'" & cmbFormaPagoIntelisis.Text & "' " &
                               ",NULL " &
                               ",1 " &
                               ",0 " &
                               ",NULL " &
                               ",NULL " &
                               ",0);          SELECT @@IDENTITY AS ID; "

        Dim da As New SqlDataAdapter(SQL, DB.obtenerConexionDB)
        Dim ds As New DataSet

        Try
            da.Fill(ds)
            If ds.Tables(0).Rows.Count = 0 Then

            Else
                consecutivoIntelisis = ds.Tables(0).Rows(0)(0).ToString
                IdIntelisis = ds.Tables(0).Rows(0)(0).ToString
            End If

        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Information)
            Exit Sub
        End Try

    End Sub

    Sub insertaVentaDInteslis()

        BUSCA_ART_INTELISIS()
        BUSCA_CB_INTELISIS()

        SQL = "INSERT INTO [American].[dbo].[VentaD] " &
           "([ID] " &
           ",[Renglon] " &
           ",[RenglonSub] " &
           ",[RenglonID] " &
           ",[RenglonTipo] " &
           ",[Cantidad] " &
           ",[Almacen] " &
           ",[EnviarA] " &
           ",[Codigo] " &
           ",[Articulo] " &
           ",[SubCuenta] " &
           ",[Precio] " &
           ",[PrecioSugerido] " &
           ",[DescuentoTipo] " &
           ",[DescuentoLinea] " &
           ",[DescuentoImporte] " &
           ",[Impuesto1] " &
           ",[Impuesto2] " &
           ",[Impuesto3] " &
           ",[DescripcionExtra] " &
           ",[Costo] " &
           ",[CostoActividad] " &
           ",[Paquete] " &
           ",[ContUso] " &
           ",[Comision] " &
           ",[Aplica] " &
           ",[AplicaID] " &
           ",[CantidadPendiente] " &
           ",[CantidadReservada] " &
           ",[CantidadCancelada] " &
           ",[CantidadOrdenada] " &
           ",[CantidadEmbarcada] " &
           ",[CantidadA] " &
           ",[Unidad] " &
           ",[Factor] " &
           ",[CantidadInventario] " &
           ",[SustitutoArticulo] " &
           ",[SustitutoSubCuenta] " &
           ",[FechaRequerida] " &
           ",[HoraRequerida] " &
           ",[Instruccion] " &
           ",[Agente] " &
           ",[Departamento] " &
           ",[UltimoReservadoCantidad] " &
           ",[UltimoReservadoFecha] " &
           ",[Sucursal] " &
           ",[PoliticaPrecios] " &
           ",[SucursalOrigen] " &
           ",[AutoLocalidad] " &
           ",[UEN] " &
           ",[Espacio] " &
           ",[CantidadAlterna] " &
           ",[PrecioMoneda] " &
           ",[PrecioTipoCambio] " &
           ",[Estado] " &
           ",[ServicioNumero] " &
           ",[AgentesAsignados] " &
           ",[AFArticulo] " &
           ",[AFSerie] " &
           ",[ExcluirPlaneacion] " &
           ",[Anexo] " &
           ",[AjusteCosteo] " &
           ",[CostoUEPS] " &
           ",[CostoPEPS] " &
           ",[UltimoCosto] " &
           ",[PrecioLista] " &
           ",[DepartamentoDetallista] " &
           ",[PresupuestoEsp] " &
           ",[Posicion] " &
           ",[Puntos] " &
           ",[CantidadObsequio] " &
           ",[OfertaID] " &
           ",[ProveedorRef] " &
           ",[TransferirA] " &
           ",[ArtEstatus] " &
           ",[ArtSituacion] " &
           ",[ExcluirISAN] " &
           ",[idClaveProdServ]   " &
           ",[ClaveUnidad]) " &
     "VALUES " &
           "(" & consecutivoIntelisis & " " &
           "," & renglon & " " &
           "," & renglonSUB & " " &
           ",1 " &
           ",'N' " &
           ",'" & Cantidad & "' " &
           ",'MONCLOVA 1' " &
           ",NULL " &
           ",'" & Intelisis_CB.Trim & "' " &
           ",'" & NoIdentificacion & "' " &
           ",NULL " &
           "," & ValorUnitario & " " &
           "," & ValorUnitario & " " &
           ",NULL " &
           ",NULL " &
           ",NULL " &
           ",16 " &
           ",0 " &
           ",0 " &
           ",NULL " &
           "," & Intelsis_CostoReposicion & " " &
           ",NULL " &
           ",NULL " &
           ",NULL " &
           ",NULL " &
           ",NULL " &
           ",NULL " &
           ",NULL " &
           ",NULL " &
           ",NULL " &
           ",NULL " &
           ",NULL " &
           ",NULL " &
           ",NULL " &
           ",1 " &
           ",NULL " &
           ",NULL " &
           ",NULL " &
           ",'" & Format(Now, "yyyy-dd-MM") & "' " &
           ",NULL " &
           ",NULL " &
           ",'0002' " &
           ",NULL " &
           ",NULL " &
           ",NULL " &
           ",0 " &
           ",NULL " &
           ",0 " &
           ",NULL " &
           ",NULL " &
           ",NULL " &
           ",NULL " &
           ",'Pesos' " &
           ",1 " &
           ",NULL " &
           ",NULL " &
           ",NULL " &
           ",NULL " &
           ",NULL " &
           ",0 " &
           ",0 " &
           ",NULL " &
           ",NULL " &
           ",NULL " &
           ",NULL " &
           ",NULL " &
           ",NULL " &
           ",0 " &
           ",NULL " &
           ",NULL " &
           ",NULL " &
           ",NULL " &
           ",NULL " &
           ",NULL " &
           ",NULL " &
           ",NULL " &
           ",0 " &
           ",'" & ClaveProdServ & "'  " &
           ",'" & ClaveUnidad & "')"

        Dim da As New SqlDataAdapter(SQL, DB.obtenerConexionDB)
        Dim ds As New DataSet

        Try
            da.Fill(ds)


        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Information)
            Exit Sub
        End Try
    End Sub
    Sub BUSCA_ART_INTELISIS()

        SQL = "SELECT [Unidad],[Impuesto1],[CostoReposicion]  FROM [American].[dbo].[Art] WHERE ARTICULO = '" & NoIdentificacion.Trim & "'"


        Dim da As New SqlDataAdapter(SQL, DB.obtenerConexionDB)
        Dim ds As New DataSet

        Try
            da.Fill(ds)
            If ds.Tables(0).Rows.Count = 0 Then
                Intelisis_Unidad = "NULL"
                Intelsis_Impuesto1 = "NULL"
                Intelsis_CostoReposicion = "NULL"
            Else
                Intelisis_Unidad = ds.Tables(0).Rows(0)(0).ToString
                Intelsis_Impuesto1 = ds.Tables(0).Rows(0)(1).ToString
                Intelsis_CostoReposicion = ds.Tables(0).Rows(0)(2).ToString


            End If

        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Information)
            Exit Sub
        End Try
    End Sub

    Sub BUSCA_CB_INTELISIS()

        SQL = "SELECT [Codigo] FROM [American].[dbo].[CB] WHERE [Cuenta] = '" & NoIdentificacion.Trim & "'"

        Dim da As New SqlDataAdapter(SQL, DB.obtenerConexionDB)
        Dim ds As New DataSet

        Try
            da.Fill(ds)
            If ds.Tables(0).Rows.Count = 0 Then
                Intelisis_CB = ""
            Else
                Intelisis_CB = ds.Tables(0).Rows(0)(0).ToString

            End If

        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Information)
            Exit Sub
        End Try

    End Sub
    Sub aplica_factura()

        Dim conectar As New SqlConnection(DB.obtenerConexionDB)
        Dim sqlcomando As New SqlClient.SqlCommand ' Declarado a niver de Formulario 
        Try

            conectar.Open()
            sqlcomando.Connection = conectar


            sqlcomando.CommandType = CommandType.StoredProcedure
            sqlcomando.CommandText = "[American].[dbo].[spAfectar]"

            sqlcomando.Parameters.Add("@Modulo", SqlDbType.NVarChar)
            sqlcomando.Parameters("@Modulo").Value = "VTAS"

            sqlcomando.Parameters.Add("@Id", SqlDbType.Int)
            sqlcomando.Parameters("@Id").Value = IdIntelisis

            ' sqlcomando.Parameters(CONSECUTIVO).Value()
            sqlcomando.Parameters.Add("@Usuario", SqlDbType.NVarChar)
            sqlcomando.Parameters("@Usuario").Value = "INT"

            sqlcomando.ExecuteNonQuery()
            conectar.Close()

        Catch ex As Exception
            conectar.Close()
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Information)
            Exit Sub
        End Try


        ' spAfectar() 'VTAS', 130138, 'CONSECUTIVO', @Usuario = 'TI-SGIN'

    End Sub

    Private Sub CbFormaPago_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbFormaPago.SelectedIndexChanged
        FormaPagoTipo = ""




        'Cheque
        'Deposito
        'Efectivo
        'No Identificado
        'Tarjeta Debito
        'TDC
        'Transferencia Electronica


    End Sub

    Sub carga_agente()

        cmbAgenteIntelisis.Items.Clear()

        SQL = "SELECT [Agente] " &
                    ",[Nombre] " &
                    ",[Tipo]    " &
                "FROM [American].[dbo].[Agente]"


        Dim da As New SqlDataAdapter(SQL, DB.obtenerConexionDB)
        Dim ds As New DataSet

        Try
            da.Fill(ds)

            If ds.Tables(0).Rows.Count = 0 Then

            Else

                Dim i As Integer

                cmbAgenteIntelisis.Items.Add("")
                For i = 0 To ds.Tables(0).Rows.Count - 1
                    cmbAgenteIntelisis.Items.Add(ds.Tables(0).Rows(i)(1).ToString())
                Next

            End If

        Catch ex As Exception
            MsgBox("ERROR: " & ex.Message, MsgBoxStyle.Critical)
            Exit Sub
        End Try

    End Sub
    Sub carga_almacen()

        cmbAlmacenIntelisis.Items.Clear()

        SQL = "SELECT [Almacen] " &
                    ",[Nombre] " &
                "FROM [American].[dbo].[Alm] " &
               "WHERE [Estatus] = 'ALTA' " &
                 "AND [wMostrar] = 1"


        Dim da As New SqlDataAdapter(SQL, DB.obtenerConexionDB)
        Dim ds As New DataSet

        Try
            da.Fill(ds)

            If ds.Tables(0).Rows.Count = 0 Then

            Else

                Dim i As Integer

                cmbAlmacenIntelisis.Items.Add("")
                For i = 0 To ds.Tables(0).Rows.Count - 1
                    cmbAlmacenIntelisis.Items.Add(ds.Tables(0).Rows(i)(0).ToString())
                Next

            End If

        Catch ex As Exception
            MsgBox("ERROR: " & ex.Message, MsgBoxStyle.Critical)
            Exit Sub
        End Try


    End Sub
    Sub carga_sucursal()

        cmbSucursalIntelisis.Items.Clear()

        SQL = "SELECT  [Sucursal] " &
                      ",[Nombre] " &
                     " ,[AlmacenPrincipal] " &
                  "FROM [American].[dbo].[Sucursal]"

        Dim da As New SqlDataAdapter(SQL, DB.obtenerConexionDB)
        Dim ds As New DataSet

        Try
            da.Fill(ds)

            If ds.Tables(0).Rows.Count = 0 Then

            Else

                Dim i As Integer

                cmbSucursalIntelisis.Items.Add("")
                For i = 0 To ds.Tables(0).Rows.Count - 1
                    cmbSucursalIntelisis.Items.Add(ds.Tables(0).Rows(i)(2).ToString())
                Next

            End If

        Catch ex As Exception
            MsgBox("ERROR: " & ex.Message, MsgBoxStyle.Critical)
            Exit Sub
        End Try


    End Sub

    Private Sub TxtBuscaProducto_TextChanged(sender As Object, e As EventArgs) Handles txtBuscaProducto.TextChanged
        tlpError.Visible = False
        lError.Text = ""
        If txtBuscaProducto.Text <> "" Then

            'SQL = "SELECT [idProducto] " &
            '            ",[codigo] " &
            '            ",[descripcion] " &
            '            ",[precio] " &
            '            ",[unidad] " &
            '            ",[idClaveProdServ] " &
            '            ",[idClaveUnidad] " &
            '       "FROM  [dbo].[tblproductos] " &
            '      "WHERE [descripcion] = '" & cbBuscaProducto.Text.Trim & "' " &
            '   "ORDER BY [descripcion] ASC"

            SQL = "SELECT [Articulo] " &
                    ",[Descripcion1] " &
                    ",[PrecioLista] " &
                    ",[Unidad] " &
                    ",[idClaveProdServ] " &
                    ",[idClaveUnidad] " &
                "FROM [American].[dbo].[Art]  " &
               "WHERE [Descripcion1] LIKE '" & txtBuscaProducto.Text.Trim & "' " &
            "ORDER BY [Descripcion1] ASC"

            Dim da As New SqlDataAdapter(SQL, DB.obtenerConexionDB)
            Dim ds As New DataSet

            Try
                da.Fill(ds)

                If ds.Tables(0).Rows.Count = 0 Then
                    nudConceptoValorUnitario.Value = 0
                    tbConceptoUnidad.Text = ""
                    tbConceptoNoIdentificacion.Text = ""
                    tbConceptoDescripcion.Text = ""
                    tlpError.Visible = False
                    lError.Text = ""
                Else

                    Dim i As Integer
                    nudConceptoValorUnitario.Value = 0
                    tbConceptoUnidad.Text = ""
                    tbConceptoNoIdentificacion.Text = ""
                    tbConceptoDescripcion.Text = ""
                    tlpError.Visible = False
                    lError.Text = ""
                    For i = 0 To ds.Tables(0).Rows.Count - 1

                        ArtIntelisis = ds.Tables(0).Rows(i)(0).ToString()
                        VALIDA_EXISTENCIA_INTELISIS()

                        If artDisponible > 0 Then

                            tbConceptoNoIdentificacion.Text = ds.Tables(0).Rows(i)(0).ToString()
                            tbConceptoDescripcion.Text = ds.Tables(0).Rows(i)(1).ToString()
                            nudConceptoValorUnitario.Value = ds.Tables(0).Rows(i)(2).ToString()
                            tbConceptoUnidad.Text = ds.Tables(0).Rows(i)(3).ToString()

                            idCveProdSer = ds.Tables(0).Rows(i)(4).ToString()
                            busca_producto_servicio()
                            idCvedUnidad = ds.Tables(0).Rows(i)(5).ToString()
                            busca_clave_unidad()

                            'tbConceptoNoIdentificacion.Text = ds.Tables(0).Rows(i)(1).ToString()
                            'tbConceptoDescripcion.Text = ds.Tables(0).Rows(i)(2).ToString()
                            'nudConceptoValorUnitario.Value = ds.Tables(0).Rows(i)(3).ToString()
                            'tbConceptoUnidad.Text = ds.Tables(0).Rows(i)(4).ToString()

                            'idCveProdSer = ds.Tables(0).Rows(i)(5).ToString()
                            'busca_producto_servicio()
                            'idCvedUnidad = ds.Tables(0).Rows(i)(6).ToString()
                            'busca_clave_unidad()

                        Else
                            nudConceptoValorUnitario.Value = 0
                            tbConceptoUnidad.Text = ""
                            tbConceptoNoIdentificacion.Text = ""
                            tbConceptoDescripcion.Text = ""

                            tlpError.Visible = True
                            lError.Text = ""
                            lError.Text = "Artículo sin Existencia, Verifique"

                        End If



                    Next
                    nudConceptoCantidad.Value = 1
                End If

            Catch ex As Exception
                MsgBox("ERROR: " & ex.Message, MsgBoxStyle.Critical)
                Exit Sub
            End Try


        End If
    End Sub

    Private Sub CmbAgenteIntelisis_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbAgenteIntelisis.SelectedIndexChanged

        If cmbAgenteIntelisis.Text <> "" Then

            SQL = "SELECT [Agente] " &
                        ",[Nombre] " &
                        ",[Tipo]    " &
                    "FROM [American].[dbo].[Agente] " &
                   "WHERE [Nombre] = '" & cmbAgenteIntelisis.Text.Trim & "'"


            Dim da As New SqlDataAdapter(SQL, DB.obtenerConexionDB)
            Dim ds As New DataSet

            Try
                da.Fill(ds)

                If ds.Tables(0).Rows.Count = 0 Then

                Else

                    Dim i As Integer
                    AgenteIntelisis = ""
                    For i = 0 To ds.Tables(0).Rows.Count - 1
                        AgenteIntelisis = ds.Tables(0).Rows(i)(0).ToString()
                    Next

                End If

            Catch ex As Exception
                MsgBox("ERROR: " & ex.Message, MsgBoxStyle.Critical)
                Exit Sub
            End Try


        End If

    End Sub
    Sub carga_concepto()

        cmbConcepto.Items.Clear()

        SQL = "SELECT [Concepto] " &
                "FROM [American].[dbo].[Concepto] " &
                "WHERE [Modulo] = 'VTAS'"

        Dim da As New SqlDataAdapter(SQL, DB.obtenerConexionDB)
        Dim ds As New DataSet

        Try
            da.Fill(ds)

            If ds.Tables(0).Rows.Count = 0 Then

            Else

                Dim i As Integer

                cmbConcepto.Items.Add("")
                For i = 0 To ds.Tables(0).Rows.Count - 1
                    cmbConcepto.Items.Add(ds.Tables(0).Rows(i)(0).ToString())
                Next

            End If

        Catch ex As Exception
            MsgBox("ERROR: " & ex.Message, MsgBoxStyle.Critical)
            Exit Sub
        End Try

    End Sub
    Sub carga_condiciones()

        cmbCondicionesIntelisis.Items.Clear()

        SQL = "SELECT [Condicion] FROM [American].[dbo].[Condicion]"

        Dim da As New SqlDataAdapter(SQL, DB.obtenerConexionDB)
        Dim ds As New DataSet

        Try
            da.Fill(ds)

            If ds.Tables(0).Rows.Count = 0 Then

            Else

                Dim i As Integer

                cmbCondicionesIntelisis.Items.Add("")
                For i = 0 To ds.Tables(0).Rows.Count - 1
                    cmbCondicionesIntelisis.Items.Add(ds.Tables(0).Rows(i)(0).ToString())
                Next

            End If

        Catch ex As Exception
            MsgBox("ERROR: " & ex.Message, MsgBoxStyle.Critical)
            Exit Sub
        End Try
    End Sub
    Sub carga_empresa()

        cmbEmpresaIntelisis.Items.Clear()

        SQL = "SELECT [Empresa],[Nombre] FROM [American].[dbo].[Empresa]"

        Dim da As New SqlDataAdapter(SQL, DB.obtenerConexionDB)
        Dim ds As New DataSet

        Try
            da.Fill(ds)

            If ds.Tables(0).Rows.Count = 0 Then

            Else

                Dim i As Integer

                cmbEmpresaIntelisis.Items.Add("")
                For i = 0 To ds.Tables(0).Rows.Count - 1
                    cmbEmpresaIntelisis.Items.Add(ds.Tables(0).Rows(i)(1).ToString())
                Next

            End If

        Catch ex As Exception
            MsgBox("ERROR: " & ex.Message, MsgBoxStyle.Critical)
            Exit Sub
        End Try

    End Sub

    Private Sub CmbEmpresaIntelisis_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbEmpresaIntelisis.SelectedIndexChanged
        If cmbEmpresaIntelisis.Text <> "" Then

            SQL = "SELECT [Empresa],[Nombre] FROM [American].[dbo].[Empresa] WHERE [Nombre] = '" & cmbEmpresaIntelisis.Text.Trim & "' "

            Dim da As New SqlDataAdapter(SQL, DB.obtenerConexionDB)
            Dim ds As New DataSet

            Try
                da.Fill(ds)

                If ds.Tables(0).Rows.Count = 0 Then

                Else

                    Dim i As Integer

                    EmpresaIntelisis = ""
                    For i = 0 To ds.Tables(0).Rows.Count - 1
                        EmpresaIntelisis = ds.Tables(0).Rows(i)(0).ToString()
                    Next

                End If

            Catch ex As Exception
                MsgBox("ERROR: " & ex.Message, MsgBoxStyle.Critical)
                Exit Sub
            End Try


        End If
    End Sub
    Sub busca_cve_cte()
        'CVE_CTE_INTELISIS
        SQL = "SELECT [Cliente] " &
                  ",[RFC] " &
                  ",[Nombre] " &
                  ",[CodigoPostal] " &
                  ",[idUsoCfdi] " &
              "FROM [American].[dbo].[Cte] WHERE [Nombre] = '" & cbClientes.Text & "'"

        Dim da As New SqlDataAdapter(SQL, DB.obtenerConexionDB)
        Dim ds As New DataSet

        Try
            da.Fill(ds)

            If ds.Tables(0).Rows.Count = 0 Then

            Else

                Dim i As Integer

                CVE_CTE_INTELISIS = ""
                For i = 0 To ds.Tables(0).Rows.Count - 1
                    CVE_CTE_INTELISIS = ds.Tables(0).Rows(i)(0).ToString()
                Next

            End If

        Catch ex As Exception
            MsgBox("ERROR: " & ex.Message, MsgBoxStyle.Critical)
            Exit Sub
        End Try



    End Sub
    Sub carga_formaPago()

        cmbFormaPagoIntelisis.Items.Clear()

        SQL = "SELECT [Tipo] FROM [American].[dbo].[FormaPagoTipo]"

        Dim da As New SqlDataAdapter(SQL, DB.obtenerConexionDB)
        Dim ds As New DataSet

        Try
            da.Fill(ds)

            If ds.Tables(0).Rows.Count = 0 Then

            Else

                Dim i As Integer

                cmbFormaPagoIntelisis.Items.Add("")
                For i = 0 To ds.Tables(0).Rows.Count - 1
                    cmbFormaPagoIntelisis.Items.Add(ds.Tables(0).Rows(i)(0).ToString())
                Next

            End If

        Catch ex As Exception
            MsgBox("ERROR: " & ex.Message, MsgBoxStyle.Critical)
            Exit Sub
        End Try
    End Sub
    Private Sub BtnGenerarXML_Click_1(sender As Object, e As EventArgs) Handles btnGenerarXML.Click

    End Sub

    Private Sub CmbConcepto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbConcepto.SelectedIndexChanged

    End Sub

    Private Sub CmbAlmacenIntelisis_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbAlmacenIntelisis.SelectedIndexChanged

    End Sub

    Private Sub CmbSucursalIntelisis_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSucursalIntelisis.SelectedIndexChanged

    End Sub
End Class