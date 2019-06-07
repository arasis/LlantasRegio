Public Class frmPozos
    Private _pozo As Pozos
    Public Property Pozo As Pozos
        Get
            Return _pozo
        End Get
        Set(value As Pozos)
            _pozo = value
        End Set
    End Property
    Public Sub New(ByVal pozo As Pozos)
        _pozo = pozo
        ' This call is required by the designer.
        InitializeComponent()
        tbDescripcion.Text = _pozo.Pozo
        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        _pozo.Pozo = tbDescripcion.Text.Trim()
        If (_pozo.Pozo = String.Empty) Then
            Return
        End If
        DialogResult = Windows.Forms.DialogResult.Yes
        Close()
    End Sub
End Class