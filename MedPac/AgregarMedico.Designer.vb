<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgregarMedico
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AgregarMedico))
        Me.txtrol = New System.Windows.Forms.TextBox()
        Me.txtmail = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtapellido = New System.Windows.Forms.TextBox()
        Me.label7 = New System.Windows.Forms.Label()
        Me.label9 = New System.Windows.Forms.Label()
        Me.btnregister = New System.Windows.Forms.Button()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.txtcontraseña = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.txtcedula1 = New System.Windows.Forms.TextBox()
        Me.label8 = New System.Windows.Forms.Label()
        Me.label6 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.pictureBox4 = New System.Windows.Forms.PictureBox()
        Me.panel1 = New System.Windows.Forms.Panel()
        CType(Me.pictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtrol
        '
        Me.txtrol.BackColor = System.Drawing.SystemColors.Control
        Me.txtrol.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtrol.Enabled = False
        Me.txtrol.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtrol.Location = New System.Drawing.Point(12, 568)
        Me.txtrol.Name = "txtrol"
        Me.txtrol.Size = New System.Drawing.Size(86, 17)
        Me.txtrol.TabIndex = 81
        Me.txtrol.Text = "medico"
        Me.txtrol.Visible = False
        '
        'txtmail
        '
        Me.txtmail.BackColor = System.Drawing.SystemColors.Control
        Me.txtmail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmail.Location = New System.Drawing.Point(70, 495)
        Me.txtmail.Name = "txtmail"
        Me.txtmail.Size = New System.Drawing.Size(270, 17)
        Me.txtmail.TabIndex = 68
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(67, 507)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(277, 13)
        Me.Label24.TabIndex = 80
        Me.Label24.Text = "_____________________________________________"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.Color.Transparent
        Me.Label25.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(67, 467)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(48, 18)
        Me.Label25.TabIndex = 79
        Me.Label25.Text = "Email"
        '
        'txtapellido
        '
        Me.txtapellido.BackColor = System.Drawing.SystemColors.Control
        Me.txtapellido.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtapellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtapellido.Location = New System.Drawing.Point(70, 267)
        Me.txtapellido.Name = "txtapellido"
        Me.txtapellido.Size = New System.Drawing.Size(270, 17)
        Me.txtapellido.TabIndex = 65
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Location = New System.Drawing.Point(67, 279)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(277, 13)
        Me.label7.TabIndex = 78
        Me.label7.Text = "_____________________________________________"
        '
        'label9
        '
        Me.label9.AutoSize = True
        Me.label9.BackColor = System.Drawing.Color.Transparent
        Me.label9.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label9.Location = New System.Drawing.Point(67, 239)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(71, 18)
        Me.label9.TabIndex = 77
        Me.label9.Text = "Apellido"
        '
        'btnregister
        '
        Me.btnregister.BackColor = System.Drawing.Color.SteelBlue
        Me.btnregister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnregister.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnregister.FlatAppearance.BorderSize = 0
        Me.btnregister.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnregister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua
        Me.btnregister.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnregister.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnregister.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btnregister.Location = New System.Drawing.Point(136, 555)
        Me.btnregister.Name = "btnregister"
        Me.btnregister.Size = New System.Drawing.Size(134, 43)
        Me.btnregister.TabIndex = 69
        Me.btnregister.Text = "Registrar"
        Me.btnregister.UseVisualStyleBackColor = False
        '
        'txtnombre
        '
        Me.txtnombre.BackColor = System.Drawing.SystemColors.Control
        Me.txtnombre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtnombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnombre.Location = New System.Drawing.Point(70, 191)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(270, 17)
        Me.txtnombre.TabIndex = 64
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(67, 203)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(277, 13)
        Me.label1.TabIndex = 76
        Me.label1.Text = "_____________________________________________"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.BackColor = System.Drawing.Color.Transparent
        Me.label3.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.Location = New System.Drawing.Point(67, 163)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(68, 18)
        Me.label3.TabIndex = 75
        Me.label3.Text = "Nombre"
        '
        'txtcontraseña
        '
        Me.txtcontraseña.BackColor = System.Drawing.SystemColors.Control
        Me.txtcontraseña.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtcontraseña.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcontraseña.Location = New System.Drawing.Point(72, 420)
        Me.txtcontraseña.Name = "txtcontraseña"
        Me.txtcontraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtcontraseña.Size = New System.Drawing.Size(270, 17)
        Me.txtcontraseña.TabIndex = 67
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.BackColor = System.Drawing.Color.Transparent
        Me.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.label2.Font = New System.Drawing.Font("Century Gothic", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.ForeColor = System.Drawing.Color.White
        Me.label2.Location = New System.Drawing.Point(101, 37)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(217, 56)
        Me.label2.TabIndex = 1
        Me.label2.Text = "Agregar"
        '
        'txtcedula1
        '
        Me.txtcedula1.BackColor = System.Drawing.SystemColors.Control
        Me.txtcedula1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtcedula1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcedula1.Location = New System.Drawing.Point(70, 338)
        Me.txtcedula1.MaxLength = 8
        Me.txtcedula1.Name = "txtcedula1"
        Me.txtcedula1.Size = New System.Drawing.Size(270, 17)
        Me.txtcedula1.TabIndex = 66
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.Location = New System.Drawing.Point(68, 430)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(277, 13)
        Me.label8.TabIndex = 74
        Me.label8.Text = "_____________________________________________"
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.BackColor = System.Drawing.Color.Transparent
        Me.label6.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label6.Location = New System.Drawing.Point(67, 391)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(93, 18)
        Me.label6.TabIndex = 73
        Me.label6.Text = "Contraseña"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(67, 350)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(277, 13)
        Me.label5.TabIndex = 72
        Me.label5.Text = "_____________________________________________"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.BackColor = System.Drawing.Color.Transparent
        Me.label4.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.Location = New System.Drawing.Point(67, 310)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(63, 18)
        Me.label4.TabIndex = 71
        Me.label4.Text = "Cedula"
        '
        'pictureBox4
        '
        Me.pictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pictureBox4.Image = CType(resources.GetObject("pictureBox4.Image"), System.Drawing.Image)
        Me.pictureBox4.Location = New System.Drawing.Point(3, 3)
        Me.pictureBox4.Name = "pictureBox4"
        Me.pictureBox4.Size = New System.Drawing.Size(23, 25)
        Me.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBox4.TabIndex = 22
        Me.pictureBox4.TabStop = False
        '
        'panel1
        '
        Me.panel1.BackgroundImage = CType(resources.GetObject("panel1.BackgroundImage"), System.Drawing.Image)
        Me.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.panel1.Controls.Add(Me.pictureBox4)
        Me.panel1.Controls.Add(Me.label2)
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel1.Location = New System.Drawing.Point(0, 0)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(413, 143)
        Me.panel1.TabIndex = 70
        '
        'AgregarMedico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(413, 632)
        Me.Controls.Add(Me.txtrol)
        Me.Controls.Add(Me.txtmail)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.txtapellido)
        Me.Controls.Add(Me.label7)
        Me.Controls.Add(Me.label9)
        Me.Controls.Add(Me.btnregister)
        Me.Controls.Add(Me.txtnombre)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.txtcontraseña)
        Me.Controls.Add(Me.txtcedula1)
        Me.Controls.Add(Me.label8)
        Me.Controls.Add(Me.label6)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AgregarMedico"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AgregarMedico"
        CType(Me.pictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents txtrol As TextBox
    Private WithEvents txtmail As TextBox
    Private WithEvents Label24 As Label
    Private WithEvents Label25 As Label
    Private WithEvents txtapellido As TextBox
    Private WithEvents label7 As Label
    Private WithEvents label9 As Label
    Private WithEvents btnregister As Button
    Private WithEvents txtnombre As TextBox
    Private WithEvents label1 As Label
    Private WithEvents label3 As Label
    Private WithEvents txtcontraseña As TextBox
    Private WithEvents label2 As Label
    Private WithEvents txtcedula1 As TextBox
    Private WithEvents label8 As Label
    Private WithEvents label6 As Label
    Private WithEvents label5 As Label
    Private WithEvents label4 As Label
    Private WithEvents pictureBox4 As PictureBox
    Private WithEvents panel1 As Panel
End Class
