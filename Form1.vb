Imports BaseDeDatos
Public Class Form1
    Private Sub btncerrar_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        If MessageBox.Show("Esta seguro que quiere salir?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub btnopciones_Click(sender As Object, e As EventArgs) Handles btnopciones.Click
        If MenuVertical.Width = 233 Then
            MenuVertical.Width = 80
        Else
            MenuVertical.Width = 233
        End If
    End Sub
    Private Sub AbrirFormInPanel(ByVal Formhijo As Object)
        If Me.PanelContenedor.Controls.Count > 0 Then Me.PanelContenedor.Controls.RemoveAt(0)
        Dim fh As Form = TryCast(Formhijo, Form)
        fh.TopLevel = False
        fh.Dock = DockStyle.Fill
        Me.PanelContenedor.Controls.Add(fh)
        Me.PanelContenedor.Tag = fh
        fh.Show()
    End Sub

    Private Sub btnInicio_Click(sender As Object, e As EventArgs) Handles btnInicio.Click
        AbrirFormInPanel(New Hora())
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AbrirFormInPanel(New Hora())
        lblnombre.Text = DatosUser.Nombre + ", " + DatosUser.Apellido
        lblcedula.Text = DatosUser.Cedula
    End Sub

    Private Sub btnDiag_Click(sender As Object, e As EventArgs) Handles btnDiag.Click
        AbrirFormInPanel(New Modificar())
    End Sub

    Private Sub btnDiagnostico_Click(sender As Object, e As EventArgs) Handles btnDiagnostico.Click
        AbrirFormInPanel(New Cuentas())
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        If MessageBox.Show("Esta seguro que quiere cerrar sesion?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        AbrirFormInPanel(New Cuenta())
    End Sub
End Class