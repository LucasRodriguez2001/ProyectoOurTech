<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Modificar
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PanelPat = New System.Windows.Forms.Panel()
        Me.boxide = New System.Windows.Forms.TextBox()
        Me.descpatologia = New System.Windows.Forms.RichTextBox()
        Me.boxpatologia = New System.Windows.Forms.TextBox()
        Me.btnGuardarP = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.btnEliminarP = New System.Windows.Forms.Button()
        Me.btnModificarP = New System.Windows.Forms.Button()
        Me.btnAgregarP = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PanelSin = New System.Windows.Forms.Panel()
        Me.boxids = New System.Windows.Forms.TextBox()
        Me.descsintomas = New System.Windows.Forms.RichTextBox()
        Me.boxregion = New System.Windows.Forms.TextBox()
        Me.boxsintoma = New System.Windows.Forms.TextBox()
        Me.btnGuardarS = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnEliminarS = New System.Windows.Forms.Button()
        Me.btnModificarS = New System.Windows.Forms.Button()
        Me.btnAgregarS = New System.Windows.Forms.Button()
        Me.DataGridView4 = New System.Windows.Forms.DataGridView()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.PanelPat.SuspendLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.PanelSin.SuspendLayout()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(1, 2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.Padding = New System.Drawing.Point(199, 25)
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(892, 583)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.Controls.Add(Me.Button2)
        Me.TabPage1.Controls.Add(Me.PanelPat)
        Me.TabPage1.Controls.Add(Me.DataGridView3)
        Me.TabPage1.Controls.Add(Me.btnEliminarP)
        Me.TabPage1.Controls.Add(Me.btnModificarP)
        Me.TabPage1.Controls.Add(Me.btnAgregarP)
        Me.TabPage1.ImageKey = "(ninguno)"
        Me.TabPage1.Location = New System.Drawing.Point(4, 66)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(884, 513)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Patologias"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Aquamarine
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Button2.Location = New System.Drawing.Point(210, 22)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(142, 38)
        Me.Button2.TabIndex = 22
        Me.Button2.Text = "Actualizar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'PanelPat
        '
        Me.PanelPat.BackColor = System.Drawing.Color.RoyalBlue
        Me.PanelPat.Controls.Add(Me.boxide)
        Me.PanelPat.Controls.Add(Me.descpatologia)
        Me.PanelPat.Controls.Add(Me.boxpatologia)
        Me.PanelPat.Controls.Add(Me.btnGuardarP)
        Me.PanelPat.Controls.Add(Me.Label6)
        Me.PanelPat.Controls.Add(Me.Label7)
        Me.PanelPat.Controls.Add(Me.Label8)
        Me.PanelPat.Location = New System.Drawing.Point(568, 19)
        Me.PanelPat.Name = "PanelPat"
        Me.PanelPat.Size = New System.Drawing.Size(310, 468)
        Me.PanelPat.TabIndex = 21
        Me.PanelPat.Visible = False
        '
        'boxide
        '
        Me.boxide.Enabled = False
        Me.boxide.Location = New System.Drawing.Point(82, 51)
        Me.boxide.Name = "boxide"
        Me.boxide.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.boxide.Size = New System.Drawing.Size(41, 20)
        Me.boxide.TabIndex = 24
        Me.boxide.Visible = False
        '
        'descpatologia
        '
        Me.descpatologia.Location = New System.Drawing.Point(105, 144)
        Me.descpatologia.Name = "descpatologia"
        Me.descpatologia.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.descpatologia.Size = New System.Drawing.Size(190, 166)
        Me.descpatologia.TabIndex = 23
        Me.descpatologia.Text = ""
        '
        'boxpatologia
        '
        Me.boxpatologia.Location = New System.Drawing.Point(82, 86)
        Me.boxpatologia.Name = "boxpatologia"
        Me.boxpatologia.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.boxpatologia.Size = New System.Drawing.Size(213, 20)
        Me.boxpatologia.TabIndex = 19
        '
        'btnGuardarP
        '
        Me.btnGuardarP.BackColor = System.Drawing.Color.LightGreen
        Me.btnGuardarP.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGuardarP.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnGuardarP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnGuardarP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardarP.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardarP.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.btnGuardarP.Location = New System.Drawing.Point(89, 395)
        Me.btnGuardarP.Name = "btnGuardarP"
        Me.btnGuardarP.Size = New System.Drawing.Size(142, 38)
        Me.btnGuardarP.TabIndex = 18
        Me.btnGuardarP.Text = "Guardar"
        Me.btnGuardarP.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label6.Location = New System.Drawing.Point(17, 144)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(82, 17)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Descripcion:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label7.Location = New System.Drawing.Point(17, 87)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(59, 17)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Nombre:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label8.Location = New System.Drawing.Point(89, 11)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(160, 19)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Modificar Patologia"
        '
        'DataGridView3
        '
        Me.DataGridView3.AllowUserToAddRows = False
        Me.DataGridView3.AllowUserToDeleteRows = False
        Me.DataGridView3.AllowUserToResizeColumns = False
        Me.DataGridView3.AllowUserToResizeRows = False
        Me.DataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Location = New System.Drawing.Point(26, 82)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.ReadOnly = True
        Me.DataGridView3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DataGridView3.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.DataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView3.Size = New System.Drawing.Size(513, 342)
        Me.DataGridView3.TabIndex = 16
        '
        'btnEliminarP
        '
        Me.btnEliminarP.BackColor = System.Drawing.Color.LightCoral
        Me.btnEliminarP.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEliminarP.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnEliminarP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnEliminarP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminarP.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarP.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.btnEliminarP.Location = New System.Drawing.Point(397, 430)
        Me.btnEliminarP.Name = "btnEliminarP"
        Me.btnEliminarP.Size = New System.Drawing.Size(142, 38)
        Me.btnEliminarP.TabIndex = 9
        Me.btnEliminarP.Text = "Eliminar"
        Me.btnEliminarP.UseVisualStyleBackColor = False
        '
        'btnModificarP
        '
        Me.btnModificarP.BackColor = System.Drawing.Color.Khaki
        Me.btnModificarP.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnModificarP.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnModificarP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnModificarP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificarP.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificarP.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.btnModificarP.Location = New System.Drawing.Point(210, 430)
        Me.btnModificarP.Name = "btnModificarP"
        Me.btnModificarP.Size = New System.Drawing.Size(142, 38)
        Me.btnModificarP.TabIndex = 8
        Me.btnModificarP.Text = "Modificar"
        Me.btnModificarP.UseVisualStyleBackColor = False
        '
        'btnAgregarP
        '
        Me.btnAgregarP.BackColor = System.Drawing.Color.LightGreen
        Me.btnAgregarP.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAgregarP.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnAgregarP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnAgregarP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarP.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarP.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.btnAgregarP.Location = New System.Drawing.Point(26, 430)
        Me.btnAgregarP.Name = "btnAgregarP"
        Me.btnAgregarP.Size = New System.Drawing.Size(142, 38)
        Me.btnAgregarP.TabIndex = 7
        Me.btnAgregarP.Text = "Agregar"
        Me.btnAgregarP.UseVisualStyleBackColor = False
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Button1)
        Me.TabPage2.Controls.Add(Me.PanelSin)
        Me.TabPage2.Controls.Add(Me.btnEliminarS)
        Me.TabPage2.Controls.Add(Me.btnModificarS)
        Me.TabPage2.Controls.Add(Me.btnAgregarS)
        Me.TabPage2.Controls.Add(Me.DataGridView4)
        Me.TabPage2.Location = New System.Drawing.Point(4, 66)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TabPage2.Size = New System.Drawing.Size(884, 513)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Sintomas"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Aquamarine
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Button1.Location = New System.Drawing.Point(210, 22)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(142, 38)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "Actualizar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PanelSin
        '
        Me.PanelSin.BackColor = System.Drawing.Color.RoyalBlue
        Me.PanelSin.Controls.Add(Me.boxids)
        Me.PanelSin.Controls.Add(Me.descsintomas)
        Me.PanelSin.Controls.Add(Me.boxregion)
        Me.PanelSin.Controls.Add(Me.boxsintoma)
        Me.PanelSin.Controls.Add(Me.btnGuardarS)
        Me.PanelSin.Controls.Add(Me.Label4)
        Me.PanelSin.Controls.Add(Me.Label3)
        Me.PanelSin.Controls.Add(Me.Label2)
        Me.PanelSin.Controls.Add(Me.Label1)
        Me.PanelSin.Location = New System.Drawing.Point(568, 19)
        Me.PanelSin.Name = "PanelSin"
        Me.PanelSin.Size = New System.Drawing.Size(310, 468)
        Me.PanelSin.TabIndex = 20
        Me.PanelSin.Visible = False
        '
        'boxids
        '
        Me.boxids.Enabled = False
        Me.boxids.Location = New System.Drawing.Point(82, 49)
        Me.boxids.Name = "boxids"
        Me.boxids.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.boxids.Size = New System.Drawing.Size(38, 20)
        Me.boxids.TabIndex = 24
        Me.boxids.Visible = False
        '
        'descsintomas
        '
        Me.descsintomas.Location = New System.Drawing.Point(105, 144)
        Me.descsintomas.Name = "descsintomas"
        Me.descsintomas.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.descsintomas.Size = New System.Drawing.Size(190, 166)
        Me.descsintomas.TabIndex = 23
        Me.descsintomas.Text = ""
        '
        'boxregion
        '
        Me.boxregion.Location = New System.Drawing.Point(82, 326)
        Me.boxregion.Name = "boxregion"
        Me.boxregion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.boxregion.Size = New System.Drawing.Size(213, 20)
        Me.boxregion.TabIndex = 21
        '
        'boxsintoma
        '
        Me.boxsintoma.Location = New System.Drawing.Point(82, 86)
        Me.boxsintoma.Name = "boxsintoma"
        Me.boxsintoma.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.boxsintoma.Size = New System.Drawing.Size(213, 20)
        Me.boxsintoma.TabIndex = 19
        '
        'btnGuardarS
        '
        Me.btnGuardarS.BackColor = System.Drawing.Color.LightGreen
        Me.btnGuardarS.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGuardarS.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnGuardarS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnGuardarS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardarS.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardarS.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.btnGuardarS.Location = New System.Drawing.Point(89, 395)
        Me.btnGuardarS.Name = "btnGuardarS"
        Me.btnGuardarS.Size = New System.Drawing.Size(142, 38)
        Me.btnGuardarS.TabIndex = 18
        Me.btnGuardarS.Text = "Guardar"
        Me.btnGuardarS.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.Location = New System.Drawing.Point(17, 327)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(52, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Region:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(17, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(82, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Descripcion:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(17, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(59, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(89, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(149, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Modificar Sintoma"
        '
        'btnEliminarS
        '
        Me.btnEliminarS.BackColor = System.Drawing.Color.LightCoral
        Me.btnEliminarS.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEliminarS.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnEliminarS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnEliminarS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminarS.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarS.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.btnEliminarS.Location = New System.Drawing.Point(397, 430)
        Me.btnEliminarS.Name = "btnEliminarS"
        Me.btnEliminarS.Size = New System.Drawing.Size(142, 38)
        Me.btnEliminarS.TabIndex = 19
        Me.btnEliminarS.Text = "Eliminar"
        Me.btnEliminarS.UseVisualStyleBackColor = False
        '
        'btnModificarS
        '
        Me.btnModificarS.BackColor = System.Drawing.Color.Khaki
        Me.btnModificarS.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnModificarS.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnModificarS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnModificarS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificarS.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificarS.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.btnModificarS.Location = New System.Drawing.Point(210, 430)
        Me.btnModificarS.Name = "btnModificarS"
        Me.btnModificarS.Size = New System.Drawing.Size(142, 38)
        Me.btnModificarS.TabIndex = 18
        Me.btnModificarS.Text = "Modificar"
        Me.btnModificarS.UseVisualStyleBackColor = False
        '
        'btnAgregarS
        '
        Me.btnAgregarS.BackColor = System.Drawing.Color.LightGreen
        Me.btnAgregarS.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAgregarS.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnAgregarS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnAgregarS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarS.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarS.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.btnAgregarS.Location = New System.Drawing.Point(26, 430)
        Me.btnAgregarS.Name = "btnAgregarS"
        Me.btnAgregarS.Size = New System.Drawing.Size(142, 38)
        Me.btnAgregarS.TabIndex = 17
        Me.btnAgregarS.Text = "Agregar"
        Me.btnAgregarS.UseVisualStyleBackColor = False
        '
        'DataGridView4
        '
        Me.DataGridView4.AllowUserToAddRows = False
        Me.DataGridView4.AllowUserToDeleteRows = False
        Me.DataGridView4.AllowUserToResizeColumns = False
        Me.DataGridView4.AllowUserToResizeRows = False
        Me.DataGridView4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView4.Location = New System.Drawing.Point(26, 82)
        Me.DataGridView4.Name = "DataGridView4"
        Me.DataGridView4.ReadOnly = True
        Me.DataGridView4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DataGridView4.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.DataGridView4.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView4.Size = New System.Drawing.Size(513, 342)
        Me.DataGridView4.TabIndex = 16
        '
        'Modificar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(895, 585)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Modificar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.PanelPat.ResumeLayout(False)
        Me.PanelPat.PerformLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.PanelSin.ResumeLayout(False)
        Me.PanelSin.PerformLayout()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Private WithEvents btnEliminarP As Button
    Private WithEvents btnModificarP As Button
    Private WithEvents btnAgregarP As Button
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents PanelSin As Panel
    Friend WithEvents boxregion As TextBox
    Friend WithEvents boxsintoma As TextBox
    Private WithEvents btnGuardarS As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Private WithEvents btnEliminarS As Button
    Private WithEvents btnModificarS As Button
    Private WithEvents btnAgregarS As Button
    Friend WithEvents descsintomas As RichTextBox
    Friend WithEvents PanelPat As Panel
    Friend WithEvents descpatologia As RichTextBox
    Friend WithEvents boxpatologia As TextBox
    Private WithEvents btnGuardarP As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents boxids As TextBox
    Friend WithEvents boxide As TextBox
    Private WithEvents Button1 As Button
    Private WithEvents Button2 As Button
    Public WithEvents DataGridView4 As DataGridView
End Class
