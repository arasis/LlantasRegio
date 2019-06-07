Public Class frmContadorTimbres
    Private Sub frmContadorTimbres_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        limbia()

        If Variables.USUARIO_SISTEMA = "TEST010203001" Then
            INFORMACION_TIMBRADO_TEST()
        Else
            INFORMACION_TIMBRADO_PRODUCTIVO()
        End If



    End Sub
    Sub limbia()

        tbActivacion.Text = ""
        tbPaquete.Text = ""
        tbRestantes.Text = ""
        tbTimbres.Text = ""
        tbUsados.Text = ""
        tbVencimiento.Text = ""


    End Sub
    Private Sub btnGuardarCliente_Click(sender As Object, e As EventArgs) Handles btnGuardarCliente.Click
        Me.Close()
    End Sub

    Sub INFORMACION_TIMBRADO_TEST()

        'En el proyecto se agrego una referencia de servicio apuntando al WS de Timbrado a la cual se llamó WSCFDI33
        'La URL es la siguiente.
        'https://www.foliosdigitalespac.com/WSTimbrado33Test/WSCFDI33.svc?WSDL

        'Se instancia el WS de Timbrado.
        Dim ServicioTimbrado As New WSCFDI33.WSCFDI33Client

        'Se instancia la Respuesta del WS de Timbrado.
        Dim RespuestaServicio As New WSCFDI33.RespuestaCreditos
        Dim RespuestaDetalleCreditos As New List(Of WSCFDI33.DetallesPaqueteCreditos)

        'Se realiza la petición al WebService, almacenando la respuesta en el objeto RespuestaCreditos (RespuestaServicio)
        'Los parametros son usuario,password
        'Los datos de acceso se deben solicitar.
        'RespuestaServicio = ServicioTimbrado.ConsultarCreditos("DEMO010233001", "Pruebas1a$")
        'RespuestaServicio = ServicioTimbrado.ConsultarCreditos("DSP061215SL4", "th8T$YE+")
        RespuestaServicio = ServicioTimbrado.ConsultarCreditos(My.Settings.usuarioFD, My.Settings.contrasenaFD)

        'Obteniendo la respuesta se valida que haya sido exitosa.
        If RespuestaServicio.OperacionExitosa = True Then

            'Se limpia el TextBox
            ' TextBox_RespuestaWS.Clear()

            'Se asigna la respuesta al objeto que contendra la operación de todos los UUID a cancelar.
            RespuestaDetalleCreditos = RespuestaServicio.Paquetes.ToList()

            'Se recorre el objeto para obtener la operacion independiente de cada CFDi.
            For Each Paquete As WSCFDI33.DetallesPaqueteCreditos In RespuestaDetalleCreditos

                ' TextBox_RespuestaWS.Text += Paquete.EnUso.ToString + vbNewLine
                tbActivacion.Text = Paquete.FechaActivacion
                tbVencimiento.Text = Paquete.FechaVencimiento
                tbPaquete.Text = Paquete.Paquete
                tbTimbres.Text = Paquete.Timbres.ToString
                tbRestantes.Text = Paquete.TimbresRestantes.ToString
                tbUsados.Text = Paquete.TimbresUsados.ToString
                ' TextBox_RespuestaWS.Text += Paquete.Vigente.ToString + vbNewLine

            Next

        Else

            'Se limpia el TextBox
            'TextBox_RespuestaWS.Clear()
            limbia()
            'Si la petición fue erronea muestro el error.
            ' TextBox_RespuestaWS.Text = RespuestaServicio.MensajeError + vbNewLine

            MsgBox(RespuestaServicio.MensajeError, MsgBoxStyle.Critical)

        End If


    End Sub
    Sub INFORMACION_TIMBRADO_PRODUCTIVO()

        'En el proyecto se agrego una referencia de servicio apuntando al WS de Timbrado a la cual se llamó WSCFDI33
        'La URL es la siguiente.
        'https://www.foliosdigitalespac.com/WSTimbrado33Test/WSCFDI33.svc?WSDL

        'Se instancia el WS de Timbrado.
        Dim ServicioTimbrado As New WSCFD133PROD.WSCFDI33Client

        'Se instancia la Respuesta del WS de Timbrado.
        Dim RespuestaServicio As New WSCFD133PROD.RespuestaCreditos
        Dim RespuestaDetalleCreditos As New List(Of WSCFD133PROD.DetallesPaqueteCreditos)

        'Se realiza la petición al WebService, almacenando la respuesta en el objeto RespuestaCreditos (RespuestaServicio)
        'Los parametros son usuario,password
        'Los datos de acceso se deben solicitar.
        'RespuestaServicio = ServicioTimbrado.ConsultarCreditos("DEMO010233001", "Pruebas1a$")
        'RespuestaServicio = ServicioTimbrado.ConsultarCreditos("DSP061215SL4", "th8T$YE+")
        RespuestaServicio = ServicioTimbrado.ConsultarCreditos(My.Settings.usuarioFD, My.Settings.contrasenaFD)

        'Obteniendo la respuesta se valida que haya sido exitosa.
        If RespuestaServicio.OperacionExitosa = True Then

            'Se limpia el TextBox
            ' TextBox_RespuestaWS.Clear()

            'Se asigna la respuesta al objeto que contendra la operación de todos los UUID a cancelar.
            RespuestaDetalleCreditos = RespuestaServicio.Paquetes.ToList()

            'Se recorre el objeto para obtener la operacion independiente de cada CFDi.
            For Each Paquete As WSCFD133PROD.DetallesPaqueteCreditos In RespuestaDetalleCreditos

                ' TextBox_RespuestaWS.Text += Paquete.EnUso.ToString + vbNewLine
                tbActivacion.Text = Paquete.FechaActivacion
                tbVencimiento.Text = Paquete.FechaVencimiento
                tbPaquete.Text = Paquete.Paquete
                tbTimbres.Text = Paquete.Timbres.ToString
                tbRestantes.Text = Paquete.TimbresRestantes.ToString
                tbUsados.Text = Paquete.TimbresUsados.ToString
                ' TextBox_RespuestaWS.Text += Paquete.Vigente.ToString + vbNewLine

            Next

        Else

            'Se limpia el TextBox
            'TextBox_RespuestaWS.Clear()
            limbia()
            'Si la petición fue erronea muestro el error.
            ' TextBox_RespuestaWS.Text = RespuestaServicio.MensajeError + vbNewLine

            MsgBox(RespuestaServicio.MensajeError, MsgBoxStyle.Critical)

        End If


    End Sub
    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles tableLayoutPanel1.Paint

    End Sub
End Class