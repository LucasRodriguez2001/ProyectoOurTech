Imports BaseDeDatos

Public Class AgregarSintoma
    Private Sub btnregister_Click(sender As Object, e As EventArgs) Handles btnregister.Click
        Dim usuarios As New Mecanicas
        Dim modificar1 = usuarios.AgregarSintoma(txtsintoma.Text, txtdesc.Text, boxregion.SelectedItem)
        MsgBox("Se agrego el sintoma correctamente")
        txtsintoma.Clear()
        txtdesc.Clear()
        boxregion.SelectedIndex = -1
        Modificar.mostrarsintomas()
        Me.Close()
    End Sub

    Private Sub pictureBox4_Click(sender As Object, e As EventArgs) Handles pictureBox4.Click
        Me.Close()
    End Sub
End Class