Public Class Hora
    Private Sub horafecha_Tick(sender As Object, e As EventArgs) Handles horafecha.Tick
        Label1.Text = DateTime.Now.ToLongTimeString()
        fecha.Text = DateTime.Now.ToLongDateString()
    End Sub
End Class