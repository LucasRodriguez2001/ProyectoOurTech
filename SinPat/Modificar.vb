Imports BaseDeDatos
Public Class Modificar

    Dim dt As New DataTable
    Private Sub Modificar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrarpatologias()
        mostrarsintomas()

    End Sub

    Public Sub mostrarpatologias()
        Try
            Dim funcion As New Mecanicas
            dt = funcion.datagridpatologias

            If dt.Rows.Count <> 0 Then
                DataGridView3.DataSource = dt
            Else
                DataGridView3.DataSource = Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub mostrarsintomas()
        Try
            Dim funcion As New Mecanicas
            dt = funcion.datagridsintomas

            If dt.Rows.Count <> 0 Then
                DataGridView4.DataSource = dt
            Else
                DataGridView4.DataSource = Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnModificarS_Click(sender As Object, e As EventArgs) Handles btnModificarS.Click
        PanelSin.Visible = True
        Dim FilaActual As Integer
        FilaActual = DataGridView4.CurrentRow.Index
        boxids.Text = DataGridView4.Rows(FilaActual).Cells(0).Value
        boxsintoma.Text = DataGridView4.Rows(FilaActual).Cells(1).Value
        descsintomas.Text = DataGridView4.Rows(FilaActual).Cells(2).Value
        boxregion.Text = DataGridView4.Rows(FilaActual).Cells(3).Value
        btnAgregarS.Enabled = False
        btnEliminarS.Enabled = False
    End Sub

    Private Sub btnGuardarS_Click(sender As Object, e As EventArgs) Handles btnGuardarS.Click
        Dim usuarios As New Mecanicas
        Dim modificar = usuarios.ModificarSintoma(boxids.Text, boxsintoma.Text, descsintomas.Text, boxregion.Text)
        Try
            MsgBox("El sintoma se modifico correctamente")

        Catch
            MsgBox("El sintoma no se puedo modificar")
        End Try
        PanelSin.Visible = False
        btnAgregarS.Enabled = True
        btnEliminarS.Enabled = True
        mostrarsintomas()
    End Sub

    Private Sub btnModificarP_Click(sender As Object, e As EventArgs) Handles btnModificarP.Click
        PanelPat.Visible = True
        Dim FilaActual As Integer
        FilaActual = DataGridView3.CurrentRow.Index
        boxide.Text = DataGridView3.Rows(FilaActual).Cells(0).Value
        boxpatologia.Text = DataGridView3.Rows(FilaActual).Cells(1).Value
        descpatologia.Text = DataGridView3.Rows(FilaActual).Cells(2).Value
        btnAgregarP.Enabled = False
        btnEliminarP.Enabled = False
    End Sub

    Private Sub btnGuardarP_Click(sender As Object, e As EventArgs) Handles btnGuardarP.Click

        Dim usuarios As New Mecanicas
        Dim modificar = usuarios.ModificarPatologia(boxide.Text, boxpatologia.Text, descpatologia.Text)
        Try
            MsgBox("La patologia se modifico correctamente")

        Catch
            MsgBox("La patologia no se puedo modificar")
        End Try
        PanelPat.Visible = False
        btnAgregarP.Enabled = True
        btnEliminarP.Enabled = True
        mostrarpatologias()
    End Sub

    Private Sub btnAgregarS_Click(sender As Object, e As EventArgs) Handles btnAgregarS.Click
        AgregarSintoma.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        mostrarsintomas()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        mostrarpatologias()
    End Sub
    Dim NumeroDeColumna As Integer
    Private Sub btnEliminarS_Click(sender As Object, e As EventArgs) Handles btnEliminarS.Click
        Dim FilaActual As Integer
        FilaActual = DataGridView4.CurrentRow.Index
        NumeroDeColumna = DataGridView4.Rows(FilaActual).Cells(0).Value
        Dim usuarios As New Mecanicas
        Dim modificar = usuarios.BorrarSintoma(NumeroDeColumna)
    End Sub

    Private Sub btnAgregarP_Click(sender As Object, e As EventArgs) Handles btnAgregarP.Click
        AgregarPatologia.ShowDialog()
    End Sub

    Private Sub btnEliminarP_Click(sender As Object, e As EventArgs) Handles btnEliminarP.Click
        Dim FilaActual As Integer
        FilaActual = DataGridView3.CurrentRow.Index
        NumeroDeColumna = DataGridView3.Rows(FilaActual).Cells(0).Value
        Dim usuarios As New Mecanicas
        Dim modificar = usuarios.BorrarPatologia(NumeroDeColumna)
    End Sub
End Class