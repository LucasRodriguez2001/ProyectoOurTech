Imports BaseDeDatos
Public Class AgregarP2
    Private Sub btnregister_Click(sender As Object, e As EventArgs) Handles btnregister.Click
        Dim usuarios As New Mecanicas
        Dim modificar = usuarios.AgregarPaciente2(txtcedula2.Text, txtedad.Text, txtestatura.Text, txtpeso.Text, boxsexo.SelectedItem, txtcalle.Text, txttelefono.Text, txtbarrio.Text)
        MsgBox("Se agrego el usuario")
        AgregarP.mostrarpaciente()
        Me.Close()
    End Sub
End Class