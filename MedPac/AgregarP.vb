Imports BaseDeDatos
Public Class AgregarP

    Dim dt As New DataTable

    Sub mostrarpaciente()
        Try
            Dim funcion As New Mecanicas
            dt = funcion.datagridpaciente

            If dt.Rows.Count <> 0 Then
                Cuentas.DataGridView2.DataSource = dt
            Else
                Cuentas.DataGridView2.DataSource = Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Asc(e.KeyChar) <> 9 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub btnregister_Click(sender As Object, e As EventArgs) Handles btnregister.Click
        Dim usuarios As New Mecanicas
        Dim modificar = usuarios.AgregarPaciente(txtcedula1.Text, txtnombre.Text, txtapellido.Text, txtmail.Text, txtcontraseña.Text, txtrol.Text)
        mostrarpaciente()
        AgregarP2.txtcedula2.Text = Me.txtcedula1.Text
        AgregarP2.ShowDialog()
        Me.Close()
    End Sub

    Private Sub txtcedula1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcedula1.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub pictureBox4_Click(sender As Object, e As EventArgs) Handles pictureBox4.Click
        Me.Close()
    End Sub

    Private Sub txtedad_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtestatura_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtpeso_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
End Class