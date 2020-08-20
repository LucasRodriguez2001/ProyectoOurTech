Imports Logica
Public Class RecuperarPass
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim usuario As New Usuario()
        Dim resultado = usuario.RecuperarContra(TextBox1.Text)
        Label2.Text = resultado
    End Sub
End Class