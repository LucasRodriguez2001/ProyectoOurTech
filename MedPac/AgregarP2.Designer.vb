<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgregarP2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AgregarP2))
        Me.txttelefono = New System.Windows.Forms.TextBox()
        Me.boxsexo = New System.Windows.Forms.ComboBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtestatura = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtpeso = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtbarrio = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtedad = New System.Windows.Forms.TextBox()
        Me.txtcalle = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtcedula2 = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.btnregister = New System.Windows.Forms.Button()
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txttelefono
        '
        Me.txttelefono.BackColor = System.Drawing.SystemColors.Control
        Me.txttelefono.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txttelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttelefono.Location = New System.Drawing.Point(66, 189)
        Me.txttelefono.MaxLength = 9
        Me.txttelefono.Name = "txttelefono"
        Me.txttelefono.Size = New System.Drawing.Size(270, 17)
        Me.txttelefono.TabIndex = 69
        '
        'boxsexo
        '
        Me.boxsexo.FormattingEnabled = True
        Me.boxsexo.Items.AddRange(New Object() {"M", "H", "O"})
        Me.boxsexo.Location = New System.Drawing.Point(203, 502)
        Me.boxsexo.Name = "boxsexo"
        Me.boxsexo.Size = New System.Drawing.Size(107, 21)
        Me.boxsexo.TabIndex = 75
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.BackColor = System.Drawing.Color.Transparent
        Me.Label26.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(200, 476)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(44, 18)
        Me.Label26.TabIndex = 100
        Me.Label26.Text = "Sexo"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(256, 418)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(80, 17)
        Me.Label21.TabIndex = 99
        Me.Label21.Text = "centimetros"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(120, 504)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(27, 20)
        Me.Label20.TabIndex = 98
        Me.Label20.Text = "kg"
        '
        'txtestatura
        '
        Me.txtestatura.BackColor = System.Drawing.SystemColors.Control
        Me.txtestatura.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtestatura.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtestatura.Location = New System.Drawing.Point(203, 418)
        Me.txtestatura.Name = "txtestatura"
        Me.txtestatura.Size = New System.Drawing.Size(45, 17)
        Me.txtestatura.TabIndex = 73
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(200, 428)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(61, 13)
        Me.Label18.TabIndex = 97
        Me.Label18.Text = "_________"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(200, 389)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(64, 18)
        Me.Label19.TabIndex = 96
        Me.Label19.Text = "Estatura"
        '
        'txtpeso
        '
        Me.txtpeso.BackColor = System.Drawing.SystemColors.Control
        Me.txtpeso.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtpeso.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpeso.Location = New System.Drawing.Point(66, 505)
        Me.txtpeso.MaxLength = 8
        Me.txtpeso.Name = "txtpeso"
        Me.txtpeso.Size = New System.Drawing.Size(48, 17)
        Me.txtpeso.TabIndex = 74
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(63, 515)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(55, 13)
        Me.Label22.TabIndex = 95
        Me.Label22.Text = "________"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(63, 476)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(42, 18)
        Me.Label23.TabIndex = 94
        Me.Label23.Text = "Peso"
        '
        'txtbarrio
        '
        Me.txtbarrio.BackColor = System.Drawing.SystemColors.Control
        Me.txtbarrio.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtbarrio.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbarrio.Location = New System.Drawing.Point(66, 265)
        Me.txtbarrio.Name = "txtbarrio"
        Me.txtbarrio.Size = New System.Drawing.Size(270, 17)
        Me.txtbarrio.TabIndex = 70
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(63, 277)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(277, 13)
        Me.Label10.TabIndex = 93
        Me.Label10.Text = "_____________________________________________"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(63, 237)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(51, 18)
        Me.Label11.TabIndex = 92
        Me.Label11.Text = "Barrio"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(63, 201)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(277, 13)
        Me.Label12.TabIndex = 91
        Me.Label12.Text = "_____________________________________________"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(63, 161)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(71, 18)
        Me.Label13.TabIndex = 90
        Me.Label13.Text = "Telefono"
        '
        'txtedad
        '
        Me.txtedad.BackColor = System.Drawing.SystemColors.Control
        Me.txtedad.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtedad.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtedad.Location = New System.Drawing.Point(66, 418)
        Me.txtedad.Name = "txtedad"
        Me.txtedad.Size = New System.Drawing.Size(68, 17)
        Me.txtedad.TabIndex = 72
        '
        'txtcalle
        '
        Me.txtcalle.BackColor = System.Drawing.SystemColors.Control
        Me.txtcalle.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtcalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcalle.Location = New System.Drawing.Point(66, 336)
        Me.txtcalle.MaxLength = 200
        Me.txtcalle.Name = "txtcalle"
        Me.txtcalle.Size = New System.Drawing.Size(270, 17)
        Me.txtcalle.TabIndex = 71
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(63, 428)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(73, 13)
        Me.Label14.TabIndex = 89
        Me.Label14.Text = "___________"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(63, 389)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(46, 18)
        Me.Label15.TabIndex = 88
        Me.Label15.Text = "Edad"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(63, 348)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(277, 13)
        Me.Label16.TabIndex = 87
        Me.Label16.Text = "_____________________________________________"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(63, 308)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(48, 18)
        Me.Label17.TabIndex = 86
        Me.Label17.Text = "Calle"
        '
        'txtcedula2
        '
        Me.txtcedula2.BackColor = System.Drawing.SystemColors.Control
        Me.txtcedula2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtcedula2.Enabled = False
        Me.txtcedula2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcedula2.Location = New System.Drawing.Point(142, 610)
        Me.txtcedula2.MaxLength = 8
        Me.txtcedula2.Name = "txtcedula2"
        Me.txtcedula2.Size = New System.Drawing.Size(106, 17)
        Me.txtcedula2.TabIndex = 66
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.BackColor = System.Drawing.Color.Transparent
        Me.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.label2.Font = New System.Drawing.Font("Century Gothic", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.ForeColor = System.Drawing.Color.White
        Me.label2.Location = New System.Drawing.Point(93, 39)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(217, 56)
        Me.label2.TabIndex = 1
        Me.label2.Text = "Agregar"
        '
        'panel1
        '
        Me.panel1.BackgroundImage = CType(resources.GetObject("panel1.BackgroundImage"), System.Drawing.Image)
        Me.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.panel1.Controls.Add(Me.label2)
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel1.Location = New System.Drawing.Point(0, 0)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(402, 143)
        Me.panel1.TabIndex = 77
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
        Me.btnregister.Location = New System.Drawing.Point(130, 561)
        Me.btnregister.Name = "btnregister"
        Me.btnregister.Size = New System.Drawing.Size(134, 43)
        Me.btnregister.TabIndex = 76
        Me.btnregister.Text = "Registrar"
        Me.btnregister.UseVisualStyleBackColor = False
        '
        'AgregarP2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(402, 638)
        Me.Controls.Add(Me.txttelefono)
        Me.Controls.Add(Me.boxsexo)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.txtestatura)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.txtpeso)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.txtbarrio)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtedad)
        Me.Controls.Add(Me.txtcalle)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.btnregister)
        Me.Controls.Add(Me.txtcedula2)
        Me.Controls.Add(Me.panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AgregarP2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AgregarP2"
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents txttelefono As TextBox
    Friend WithEvents boxsexo As ComboBox
    Private WithEvents Label26 As Label
    Private WithEvents Label21 As Label
    Private WithEvents Label20 As Label
    Private WithEvents txtestatura As TextBox
    Private WithEvents Label18 As Label
    Private WithEvents Label19 As Label
    Private WithEvents txtpeso As TextBox
    Private WithEvents Label22 As Label
    Private WithEvents Label23 As Label
    Private WithEvents txtbarrio As TextBox
    Private WithEvents Label10 As Label
    Private WithEvents Label11 As Label
    Private WithEvents Label12 As Label
    Private WithEvents Label13 As Label
    Private WithEvents txtedad As TextBox
    Private WithEvents txtcalle As TextBox
    Private WithEvents Label14 As Label
    Private WithEvents Label15 As Label
    Private WithEvents Label16 As Label
    Private WithEvents Label17 As Label
    Private WithEvents label2 As Label
    Private WithEvents panel1 As Panel
    Private WithEvents btnregister As Button
    Public WithEvents txtcedula2 As TextBox
End Class
