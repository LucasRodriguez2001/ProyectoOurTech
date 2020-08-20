Imports System.IO
Imports BaseDeDatos
Public Class AgregarPatologia
    Private Sub pictureBox4_Click(sender As Object, e As EventArgs) Handles pictureBox4.Click
        Me.Close()
    End Sub

    Private Sub btnregister_Click(sender As Object, e As EventArgs) Handles btnregister.Click
        Dim usuarios As New Mecanicas
        Dim modificar1 = usuarios.AgregarPatologia(txtpatologia.Text, txtdesc.Text)
        Dim agregar = usuarios.Asociada(boxsintoma.SelectedItem, txtpatologia.Text)
        MsgBox("Se agrego la patologia correctamente")
        txtpatologia.Clear()
        txtdesc.Clear()
        Modificar.mostrarpatologias()
        Me.Close()
    End Sub

    Private Sub AgregarPatologia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim usuarios As New Mecanicas()
        usuarios.SintomasTronco()
        usuarios.SintomasCabeza()
        usuarios.SintomasCuello()
        usuarios.SintomasMInferiores()
        usuarios.SintomasMSuperiores()
        '--------------------------------'
        Try
            Dim sr As StreamReader = New StreamReader("C:\Users\RaiseCool\Desktop\Textos\Tronco.txt")

            While (sr.Peek() >= 0)
                boxsintoma.Items.Add(sr.ReadLine().Split(",")(1))
            End While
        Catch

        End Try
        '--------------------------------'
        Try
            Dim sr As StreamReader = New StreamReader("C:\Users\RaiseCool\Desktop\Textos\Cuello.txt")

            While (sr.Peek() >= 0)
                boxsintoma.Items.Add(sr.ReadLine().Split(",")(1))
            End While
        Catch

        End Try
        '--------------------------------'
        Try
            Dim sr As StreamReader = New StreamReader("C:\Users\RaiseCool\Desktop\Textos\Cabeza.txt")

            While (sr.Peek() >= 0)
                boxsintoma.Items.Add(sr.ReadLine().Split(",")(1))
            End While
        Catch

        End Try
        '--------------------------------'
        Try
            Dim sr As StreamReader = New StreamReader("C:\Users\RaiseCool\Desktop\Textos\MiembrosSuperiores.txt")

            While (sr.Peek() >= 0)
                boxsintoma.Items.Add(sr.ReadLine().Split(",")(1))
            End While
        Catch

        End Try
        '--------------------------------'
        Try
            Dim sr As StreamReader = New StreamReader("C:\Users\RaiseCool\Desktop\Textos\MiembrosInferiores.txt")

            While (sr.Peek() >= 0)
                boxsintoma.Items.Add(sr.ReadLine().Split(",")(1))
            End While
        Catch

        End Try
        boxsintoma.SelectedIndex = -1
    End Sub
End Class