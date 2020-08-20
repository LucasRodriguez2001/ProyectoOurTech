<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgregarSintoma
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AgregarSintoma))
        Me.txtsintoma = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.btnregister = New System.Windows.Forms.Button()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.label2 = New System.Windows.Forms.Label()
        Me.boxregion = New System.Windows.Forms.ComboBox()
        Me.txtdesc = New System.Windows.Forms.RichTextBox()
        Me.pictureBox4 = New System.Windows.Forms.PictureBox()
        Me.panel1.SuspendLayout()
        CType(Me.pictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtsintoma
        '
        Me.txtsintoma.BackColor = System.Drawing.SystemColors.Control
        Me.txtsintoma.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtsintoma.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsintoma.Location = New System.Drawing.Point(65, 174)
        Me.txtsintoma.MaxLength = 300
        Me.txtsintoma.Name = "txtsintoma"
        Me.txtsintoma.Size = New System.Drawing.Size(270, 17)
        Me.txtsintoma.TabIndex = 102
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(62, 222)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(186, 18)
        Me.Label11.TabIndex = 117
        Me.Label11.Text = "Descripcion del sintoma"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(62, 186)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(277, 13)
        Me.Label12.TabIndex = 116
        Me.Label12.Text = "_____________________________________________"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(62, 146)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(129, 18)
        Me.Label13.TabIndex = 115
        Me.Label13.Text = "Nombre sintoma"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(62, 439)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(60, 18)
        Me.Label17.TabIndex = 111
        Me.Label17.Text = "Region"
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
        Me.btnregister.Location = New System.Drawing.Point(130, 537)
        Me.btnregister.Name = "btnregister"
        Me.btnregister.Size = New System.Drawing.Size(134, 43)
        Me.btnregister.TabIndex = 109
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
        Me.panel1.Size = New System.Drawing.Size(395, 116)
        Me.panel1.TabIndex = 110
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.BackColor = System.Drawing.Color.Transparent
        Me.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.label2.Font = New System.Drawing.Font("Century Gothic", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.ForeColor = System.Drawing.Color.White
        Me.label2.Location = New System.Drawing.Point(91, 28)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(212, 56)
        Me.label2.TabIndex = 1
        Me.label2.Text = "Sintoma"
        '
        'boxregion
        '
        Me.boxregion.FormattingEnabled = True
        Me.boxregion.Items.AddRange(New Object() {"Cabeza", "Cuello", "Tronco", "Miembros Superiores", "Miembros Inferiores"})
        Me.boxregion.Location = New System.Drawing.Point(137, 440)
        Me.boxregion.Name = "boxregion"
        Me.boxregion.Size = New System.Drawing.Size(121, 21)
        Me.boxregion.TabIndex = 118
        '
        'txtdesc
        '
        Me.txtdesc.Location = New System.Drawing.Point(65, 254)
        Me.txtdesc.Name = "txtdesc"
        Me.txtdesc.Size = New System.Drawing.Size(274, 167)
        Me.txtdesc.TabIndex = 119
        Me.txtdesc.Text = ""
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
        'AgregarSintoma
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(395, 605)
        Me.Controls.Add(Me.txtdesc)
        Me.Controls.Add(Me.boxregion)
        Me.Controls.Add(Me.txtsintoma)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.btnregister)
        Me.Controls.Add(Me.panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AgregarSintoma"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AgregarSintoma"
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        CType(Me.pictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents txtsintoma As TextBox
    Private WithEvents Label11 As Label
    Private WithEvents Label12 As Label
    Private WithEvents Label13 As Label
    Private WithEvents Label17 As Label
    Private WithEvents btnregister As Button
    Private WithEvents panel1 As Panel
    Private WithEvents label2 As Label
    Friend WithEvents boxregion As ComboBox
    Friend WithEvents txtdesc As RichTextBox
    Private WithEvents pictureBox4 As PictureBox
End Class
