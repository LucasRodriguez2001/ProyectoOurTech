Imports BaseDeDatos
Public Class Cuenta
    Private Sub Cuenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblNombre.Text = DatosUser.Nombre
        lblapellido.Text = DatosUser.Apellido
        lblcedula.Text = DatosUser.Cedula
        lblmail.Text = DatosUser.Mail
    End Sub
End Class