Imports MySql.Data.MySqlClient
Imports BaseDeDatos
Imports Logica
Imports System.Data.SqlClient
Public Class Login
    Private Sub pictureBox3_Click(sender As Object, e As EventArgs) Handles pictureBox3.Click
        Application.Exit()
    End Sub

    Private Sub txtcedula1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcedula.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        Dim usuarios As New Mecanicas
        Dim valido = usuarios.Login(txtcedula.Text, txtcontraseña.Text)
        If valido = True Then
            Me.Hide()
            Dim FormBien As New Bienvenido()
            FormBien.ShowDialog()
            Dim form As New Form1()
            form.Show()
            AddHandler form.FormClosed, AddressOf Me.LogOut

        Else
            MessageBox.Show("Cedula o Contraseña Incorrecta" + vbNewLine + "Porfavor intente denuevo")
            txtcontraseña.Clear()
            txtcontraseña.Focus()
        End If
    End Sub
    Private Sub LogOut(sender As Object, e As FormClosedEventArgs)
        txtcedula.Clear()
        txtcontraseña.Clear()
        Me.Show()
        txtcedula.Focus()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim RecuperarPass As New RecuperarPass()
        RecuperarPass.ShowDialog()
    End Sub
End Class