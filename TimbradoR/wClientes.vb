Public Class wClientes
    Private Sub actualizarGrid()
        dgvClientes.DataSource = DB.obtenerClientes()
        dgvClientes.Columns("Calle").Visible = False
        dgvClientes.Columns("NumeroExterior").Visible = False
        dgvClientes.Columns("NumeroInterior").Visible = False
        dgvClientes.Columns("Colonia").Visible = False
        dgvClientes.Columns("Referencia").Visible = False
        dgvClientes.Columns("Localidad").Visible = False
        dgvClientes.Columns("Municipio").Visible = False
        dgvClientes.Columns("Estado").Visible = False
        dgvClientes.Columns("Pais").Visible = False
        dgvClientes.Columns("CP").Visible = False
        dgvClientes.Columns("idUsoCfdi").Visible = False
        dgvClientes.Columns("DireccionCompleta").HeaderText = "Dirección fiscal"
        dgvClientes.Columns("idCliente").Width = 125
        dgvClientes.Columns("idCliente").HeaderText = "Núm de cliente"
    End Sub

    Private Sub btnComprobante_Click(sender As Object, e As EventArgs) Handles btnAgregarCliente.Click
        Dim ac As wCliente = New wCliente()
        ac.ShowDialog()
        actualizarGrid()
    End Sub

    Private Sub dgvClientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

    End Sub

    Private Sub wClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        actualizarGrid()
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub dgvClientes_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles dgvClientes.CellContentClick

    End Sub

    Private Sub dgvClientes_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvClientes.CellDoubleClick
        If dgvClientes.CurrentCell Is Nothing Then
            MessageBox.Show("Selecciona un cliente", "Eliminar cliente...", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim result As DialogResult = MessageBox.Show("Confirma que deseas eliminar el cliente", "Eliminar cliente...", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = System.Windows.Forms.DialogResult.Yes Then
            Dim r As Integer = dgvClientes.CurrentCell.RowIndex
            DB.eliminarCliente(dgvClientes.Rows(r).Cells("idCliente").Value)
            actualizarGrid()
        End If
    End Sub
End Class