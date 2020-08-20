<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AgregarPatologia
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AgregarPatologia))
        Me.btnregister = New System.Windows.Forms.Button()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.pictureBox4 = New System.Windows.Forms.PictureBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.txtpatologia = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtdesc = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.boxsintoma = New System.Windows.Forms.ComboBox()
        Me.panel1.SuspendLayout()
        CType(Me.pictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.btnregister.Location = New System.Drawing.Point(127, 567)
        Me.btnregister.Name = "btnregister"
        Me.btnregister.Size = New System.Drawing.Size(134, 43)
        Me.btnregister.TabIndex = 121
        Me.btnregister.Text = "Agregar"
        Me.btnregister.UseVisualStyleBackColor = False
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
        Me.panel1.Size = New System.Drawing.Size(394, 116)
        Me.panel1.TabIndex = 122
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
        Me.pictureBox4.TabIndex = 23
        Me.pictureBox4.TabStop = False
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.BackColor = System.Drawing.Color.Transparent
        Me.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.label2.Font = New System.Drawing.Font("Century Gothic", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.ForeColor = System.Drawing.Color.White
        Me.label2.Location = New System.Drawing.Point(76, 27)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(247, 56)
        Me.label2.TabIndex = 1
        Me.label2.Text = "Patologia"
        '
        'txtpatologia
        '
        Me.txtpatologia.BackColor = System.Drawing.SystemColors.Control
        Me.txtpatologia.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtpatologia.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpatologia.Location = New System.Drawing.Point(64, 175)
        Me.txtpatologia.MaxLength = 300
        Me.txtpatologia.Name = "txtpatologia"
        Me.txtpatologia.Size = New System.Drawing.Size(270, 17)
        Me.txtpatologia.TabIndex = 120
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(61, 147)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(144, 18)
        Me.Label13.TabIndex = 124
        Me.Label13.Text = "Nombre patologia"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(61, 187)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(277, 13)
        Me.Label12.TabIndex = 125
        Me.Label12.Text = "_____________________________________________"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(61, 223)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(215, 18)
        Me.Label11.TabIndex = 126
        Me.Label11.Text = "Descripcion de la patologia"
        '
        'txtdesc
        '
        Me.txtdesc.Location = New System.Drawing.Point(64, 255)
        Me.txtdesc.Name = "txtdesc"
        Me.txtdesc.Size = New System.Drawing.Size(274, 167)
        Me.txtdesc.TabIndex = 128
        Me.txtdesc.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(61, 445)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 18)
        Me.Label1.TabIndex = 129
        Me.Label1.Text = "Sintoma asociado"
        '
        'boxsintoma
        '
        Me.boxsintoma.FormattingEnabled = True
        Me.boxsintoma.Location = New System.Drawing.Point(64, 467)
        Me.boxsintoma.Name = "boxsintoma"
        Me.boxsintoma.Size = New System.Drawing.Size(121, 21)
        Me.boxsintoma.TabIndex = 130
        '
        'AgregarPatologia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(394, 639)
        Me.Controls.Add(Me.boxsintoma)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtpatologia)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.btnregister)
        Me.Controls.Add(Me.panel1)
        Me.Controls.Add(Me.txtdesc)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AgregarPatologia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "w"
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        CType(Me.pictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents btnregister As Button
    Private WithEvents panel1 As Panel
    Private WithEvents pictureBox4 As PictureBox
    Private WithEvents label2 As Label
    Private WithEvents txtpatologia As TextBox
    Private WithEvents Label13 As Label
    Private WithEvents Label12 As Label
    Private WithEvents Label11 As Label
    Friend WithEvents txtdesc As RichTextBox
    Private WithEvents Label1 As Label
    Friend WithEvents boxsintoma As ComboBox
End Class
