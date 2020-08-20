Imports BaseDeDatos

Public Class AgregarMedico
    Private Sub pictureBox4_Click(sender As Object, e As EventArgs) Handles pictureBox4.Click
        Me.Close()
    End Sub

    Private Sub txtcedula1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcedula1.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub btnregister_Click(sender As Object, e As EventArgs) Handles btnregister.Click
        Dim usuarios As New Mecanicas
        Dim modificar1 = usuarios.AgregarPaciente(txtcedula1.Text, txtnombre.Text, txtapellido.Text, txtmail.Text, txtcontraseña.Text, txtrol.Text)
        Try
            MsgBox("El medico se agrego correctamente")

        Catch
            MsgBox("El medico no se puedo agregar")
        End Try
        Cuentas.mostrarmedico()
        Me.Close()
    End Sub
End Class