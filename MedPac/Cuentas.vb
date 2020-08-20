Imports BaseDeDatos

Public Class Cuentas
    Dim dt As New DataTable

    Sub mostrarpaciente()
        Try
            Dim funcion As New Mecanicas
            dt = funcion.datagridpaciente

            If dt.Rows.Count <> 0 Then
                DataGridView2.DataSource = dt
            Else
                DataGridView2.DataSource = Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub mostrarmedico()
        Try
            Dim funcion As New Mecanicas
            dt = funcion.datagridmedico

            If dt.Rows.Count <> 0 Then
                DataGridView1.DataSource = dt
            Else
                DataGridView1.DataSource = Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Cuentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrarmedico()
        mostrarpaciente()
    End Sub

    Private Sub btnGuardarP_Click(sender As Object, e As EventArgs) Handles btnGuardarP.Click
        Dim usuarios As New Mecanicas
        Dim modificar = usuarios.ModificarPaciente(boxcedula.Text, boxnombre.Text, boxapellido.Text, boxmail.Text, boxpaciente.Text)
        Try
            MsgBox("El paciente se modifico correctamente")

        Catch
            MsgBox("El paciente no se puedo modificar")
        End Try
        Panel2.Visible = False
        btnAgregarP.Enabled = True
        btnEliminarP.Enabled = True
        mostrarpaciente()
    End Sub

    Private Sub btnModificarP_Click(sender As Object, e As EventArgs) Handles btnModificarP.Click
        Panel2.Visible = True
        Dim FilaActual As Integer
        FilaActual = DataGridView2.CurrentRow.Index
        boxcedula.Text = DataGridView2.Rows(FilaActual).Cells(2).Value
        boxnombre.Text = DataGridView2.Rows(FilaActual).Cells(0).Value
        boxapellido.Text = DataGridView2.Rows(FilaActual).Cells(1).Value
        boxmail.Text = DataGridView2.Rows(FilaActual).Cells(3).Value
        btnAgregarP.Enabled = False
        btnEliminarP.Enabled = False
    End Sub

    Private Sub btnAgregarP_Click(sender As Object, e As EventArgs) Handles btnAgregarP.Click
        Dim Agregar As New AgregarP()
        Agregar.ShowDialog()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        mostrarpaciente()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        mostrarmedico()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnModificarM.Click
        Panel1.Visible = True
        Dim FilaActual As Integer
        FilaActual = DataGridView1.CurrentRow.Index
        txtcedula.Text = DataGridView1.Rows(FilaActual).Cells(2).Value
        txtnombre.Text = DataGridView1.Rows(FilaActual).Cells(0).Value
        txtapellido.Text = DataGridView1.Rows(FilaActual).Cells(1).Value
        txtmail.Text = DataGridView1.Rows(FilaActual).Cells(3).Value
        btnAgregarM.Enabled = False
        btnEliminarM.Enabled = False
    End Sub

    Private Sub btnDiag_Click(sender As Object, e As EventArgs) Handles btnAgregarM.Click
        AgregarMedico.ShowDialog()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim usuarios As New Mecanicas
        Dim modificar = usuarios.ModificarPaciente(txtcedula.Text, txtnombre.Text, txtapellido.Text, txtmail.Text, txtmedico.Text)
        Try
            MsgBox("El medico se modifico correctamente")

        Catch
            MsgBox("El medico no se puedo modificar")
        End Try
        Panel1.Visible = False
        btnAgregarM.Enabled = True
        btnEliminarM.Enabled = True
        mostrarmedico()
    End Sub
End Class