<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.panel2 = New System.Windows.Forms.Panel()
        Me.PanelContenedor = New System.Windows.Forms.Panel()
        Me.BarraInicio = New System.Windows.Forms.Panel()
        Me.btnminimizar = New System.Windows.Forms.PictureBox()
        Me.btncerrar = New System.Windows.Forms.PictureBox()
        Me.btnopciones = New System.Windows.Forms.PictureBox()
        Me.MenuVertical = New System.Windows.Forms.Panel()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblCedula = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnDiagnostico = New System.Windows.Forms.Button()
        Me.btnDiag = New System.Windows.Forms.Button()
        Me.btnInicio = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.panel2.SuspendLayout()
        Me.BarraInicio.SuspendLayout()
        CType(Me.btnminimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btncerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnopciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuVertical.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panel2
        '
        Me.panel2.Controls.Add(Me.PanelContenedor)
        Me.panel2.Controls.Add(Me.BarraInicio)
        Me.panel2.Controls.Add(Me.MenuVertical)
        Me.panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel2.Location = New System.Drawing.Point(0, 0)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(1128, 635)
        Me.panel2.TabIndex = 3
        '
        'PanelContenedor
        '
        Me.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContenedor.Location = New System.Drawing.Point(233, 50)
        Me.PanelContenedor.Name = "PanelContenedor"
        Me.PanelContenedor.Size = New System.Drawing.Size(895, 585)
        Me.PanelContenedor.TabIndex = 2
        '
        'BarraInicio
        '
        Me.BarraInicio.Controls.Add(Me.btnminimizar)
        Me.BarraInicio.Controls.Add(Me.btncerrar)
        Me.BarraInicio.Controls.Add(Me.btnopciones)
        Me.BarraInicio.Dock = System.Windows.Forms.DockStyle.Top
        Me.BarraInicio.Location = New System.Drawing.Point(233, 0)
        Me.BarraInicio.Name = "BarraInicio"
        Me.BarraInicio.Size = New System.Drawing.Size(895, 50)
        Me.BarraInicio.TabIndex = 1
        '
        'btnminimizar
        '
        Me.btnminimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnminimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnminimizar.Image = CType(resources.GetObject("btnminimizar.Image"), System.Drawing.Image)
        Me.btnminimizar.Location = New System.Drawing.Point(837, 12)
        Me.btnminimizar.Name = "btnminimizar"
        Me.btnminimizar.Size = New System.Drawing.Size(20, 20)
        Me.btnminimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnminimizar.TabIndex = 4
        Me.btnminimizar.TabStop = False
        '
        'btncerrar
        '
        Me.btncerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btncerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btncerrar.Image = CType(resources.GetObject("btncerrar.Image"), System.Drawing.Image)
        Me.btncerrar.Location = New System.Drawing.Point(863, 12)
        Me.btncerrar.Name = "btncerrar"
        Me.btncerrar.Size = New System.Drawing.Size(20, 20)
        Me.btncerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btncerrar.TabIndex = 2
        Me.btncerrar.TabStop = False
        '
        'btnopciones
        '
        Me.btnopciones.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnopciones.Image = CType(resources.GetObject("btnopciones.Image"), System.Drawing.Image)
        Me.btnopciones.Location = New System.Drawing.Point(10, 9)
        Me.btnopciones.Name = "btnopciones"
        Me.btnopciones.Size = New System.Drawing.Size(35, 35)
        Me.btnopciones.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnopciones.TabIndex = 2
        Me.btnopciones.TabStop = False
        '
        'MenuVertical
        '
        Me.MenuVertical.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MenuVertical.Controls.Add(Me.lblNombre)
        Me.MenuVertical.Controls.Add(Me.lblCedula)
        Me.MenuVertical.Controls.Add(Me.PictureBox3)
        Me.MenuVertical.Controls.Add(Me.PictureBox2)
        Me.MenuVertical.Controls.Add(Me.btnDiagnostico)
        Me.MenuVertical.Controls.Add(Me.btnDiag)
        Me.MenuVertical.Controls.Add(Me.btnInicio)
        Me.MenuVertical.Controls.Add(Me.PictureBox1)
        Me.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left
        Me.MenuVertical.Location = New System.Drawing.Point(0, 0)
        Me.MenuVertical.Name = "MenuVertical"
        Me.MenuVertical.Size = New System.Drawing.Size(233, 635)
        Me.MenuVertical.TabIndex = 0
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.BackColor = System.Drawing.Color.Transparent
        Me.lblNombre.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(87, 565)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(64, 19)
        Me.lblNombre.TabIndex = 18
        Me.lblNombre.Text = "Nombre"
        '
        'lblCedula
        '
        Me.lblCedula.AutoSize = True
        Me.lblCedula.BackColor = System.Drawing.Color.Transparent
        Me.lblCedula.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCedula.Location = New System.Drawing.Point(87, 588)
        Me.lblCedula.Name = "lblCedula"
        Me.lblCedula.Size = New System.Drawing.Size(61, 19)
        Me.lblCedula.TabIndex = 17
        Me.lblCedula.Text = "Cedula"
        '
        'PictureBox3
        '
        Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(189, 598)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(44, 36)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 19
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(1, 560)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(80, 72)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 10
        Me.PictureBox2.TabStop = False
        '
        'btnDiagnostico
        '
        Me.btnDiagnostico.BackColor = System.Drawing.Color.Transparent
        Me.btnDiagnostico.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDiagnostico.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnDiagnostico.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnDiagnostico.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDiagnostico.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDiagnostico.ForeColor = System.Drawing.SystemColors.Menu
        Me.btnDiagnostico.Location = New System.Drawing.Point(85, 337)
        Me.btnDiagnostico.Name = "btnDiagnostico"
        Me.btnDiagnostico.Size = New System.Drawing.Size(142, 38)
        Me.btnDiagnostico.TabIndex = 7
        Me.btnDiagnostico.Text = "Cuentas"
        Me.btnDiagnostico.UseVisualStyleBackColor = False
        '
        'btnDiag
        '
        Me.btnDiag.BackColor = System.Drawing.Color.Transparent
        Me.btnDiag.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDiag.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnDiag.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnDiag.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDiag.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDiag.ForeColor = System.Drawing.SystemColors.Menu
        Me.btnDiag.Location = New System.Drawing.Point(85, 248)
        Me.btnDiag.Name = "btnDiag"
        Me.btnDiag.Size = New System.Drawing.Size(142, 38)
        Me.btnDiag.TabIndex = 6
        Me.btnDiag.Text = "Modificar"
        Me.btnDiag.UseVisualStyleBackColor = False
        '
        'btnInicio
        '
        Me.btnInicio.BackColor = System.Drawing.Color.Transparent
        Me.btnInicio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnInicio.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnInicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInicio.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInicio.ForeColor = System.Drawing.SystemColors.Menu
        Me.btnInicio.Location = New System.Drawing.Point(85, 166)
        Me.btnInicio.Name = "btnInicio"
        Me.btnInicio.Size = New System.Drawing.Size(142, 38)
        Me.btnInicio.TabIndex = 5
        Me.btnInicio.Text = "Inicio"
        Me.btnInicio.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(80, 76)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1128, 635)
        Me.Controls.Add(Me.panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.panel2.ResumeLayout(False)
        Me.BarraInicio.ResumeLayout(False)
        CType(Me.btnminimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btncerrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnopciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuVertical.ResumeLayout(False)
        Me.MenuVertical.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents panel2 As Panel
    Friend WithEvents BarraInicio As Panel
    Private WithEvents MenuVertical As Panel
    Private WithEvents btnopciones As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Private WithEvents btnDiagnostico As Button
    Private WithEvents btnDiag As Button
    Private WithEvents btnInicio As Button
    Friend WithEvents PanelContenedor As Panel
    Private WithEvents btnminimizar As PictureBox
    Private WithEvents btncerrar As PictureBox
    Public WithEvents lblNombre As Label
    Public WithEvents lblCedula As Label
    Friend WithEvents PictureBox3 As PictureBox
End Class
