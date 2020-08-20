<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cuentas
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
        Me.Button4 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnEliminarM = New System.Windows.Forms.Button()
        Me.btnModificarM = New System.Windows.Forms.Button()
        Me.btnAgregarM = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.boxpaciente = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.boxcedula = New System.Windows.Forms.TextBox()
        Me.boxmail = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.boxapellido = New System.Windows.Forms.TextBox()
        Me.boxnombre = New System.Windows.Forms.TextBox()
        Me.btnGuardarP = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnEliminarP = New System.Windows.Forms.Button()
        Me.btnModificarP = New System.Windows.Forms.Button()
        Me.btnAgregarP = New System.Windows.Forms.Button()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtmedico = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtcedula = New System.Windows.Forms.TextBox()
        Me.txtmail = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtapellido = New System.Windows.Forms.TextBox()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(1, 1)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.Padding = New System.Drawing.Point(199, 25)
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(892, 583)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.Controls.Add(Me.Panel1)
        Me.TabPage1.Controls.Add(Me.Button4)
        Me.TabPage1.Controls.Add(Me.DataGridView1)
        Me.TabPage1.Controls.Add(Me.btnEliminarM)
        Me.TabPage1.Controls.Add(Me.btnModificarM)
        Me.TabPage1.Controls.Add(Me.btnAgregarM)
        Me.TabPage1.ImageKey = "(ninguno)"
        Me.TabPage1.Location = New System.Drawing.Point(4, 66)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(884, 513)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Medicos"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Aquamarine
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Button4.Location = New System.Drawing.Point(215, 25)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(142, 38)
        Me.Button4.TabIndex = 24
        Me.Button4.Text = "Actualizar"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(26, 82)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(513, 342)
        Me.DataGridView1.TabIndex = 15
        '
        'btnEliminarM
        '
        Me.btnEliminarM.BackColor = System.Drawing.Color.LightCoral
        Me.btnEliminarM.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEliminarM.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnEliminarM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnEliminarM.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminarM.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarM.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.btnEliminarM.Location = New System.Drawing.Point(397, 430)
        Me.btnEliminarM.Name = "btnEliminarM"
        Me.btnEliminarM.Size = New System.Drawing.Size(142, 38)
        Me.btnEliminarM.TabIndex = 9
        Me.btnEliminarM.Text = "Eliminar"
        Me.btnEliminarM.UseVisualStyleBackColor = False
        '
        'btnModificarM
        '
        Me.btnModificarM.BackColor = System.Drawing.Color.Khaki
        Me.btnModificarM.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnModificarM.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnModificarM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnModificarM.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificarM.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificarM.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.btnModificarM.Location = New System.Drawing.Point(215, 430)
        Me.btnModificarM.Name = "btnModificarM"
        Me.btnModificarM.Size = New System.Drawing.Size(142, 38)
        Me.btnModificarM.TabIndex = 8
        Me.btnModificarM.Text = "Modificar"
        Me.btnModificarM.UseVisualStyleBackColor = False
        '
        'btnAgregarM
        '
        Me.btnAgregarM.BackColor = System.Drawing.Color.LightGreen
        Me.btnAgregarM.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAgregarM.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnAgregarM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnAgregarM.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarM.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarM.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.btnAgregarM.Location = New System.Drawing.Point(26, 430)
        Me.btnAgregarM.Name = "btnAgregarM"
        Me.btnAgregarM.Size = New System.Drawing.Size(142, 38)
        Me.btnAgregarM.TabIndex = 7
        Me.btnAgregarM.Text = "Agregar"
        Me.btnAgregarM.UseVisualStyleBackColor = False
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Button3)
        Me.TabPage2.Controls.Add(Me.Panel2)
        Me.TabPage2.Controls.Add(Me.btnEliminarP)
        Me.TabPage2.Controls.Add(Me.btnModificarP)
        Me.TabPage2.Controls.Add(Me.btnAgregarP)
        Me.TabPage2.Controls.Add(Me.DataGridView2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 66)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TabPage2.Size = New System.Drawing.Size(884, 513)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Pacientes"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Aquamarine
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Button3.Location = New System.Drawing.Point(215, 21)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(142, 38)
        Me.Button3.TabIndex = 23
        Me.Button3.Text = "Actualizar"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel2.Controls.Add(Me.boxpaciente)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.boxcedula)
        Me.Panel2.Controls.Add(Me.boxmail)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.boxapellido)
        Me.Panel2.Controls.Add(Me.boxnombre)
        Me.Panel2.Controls.Add(Me.btnGuardarP)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Location = New System.Drawing.Point(568, 18)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(310, 468)
        Me.Panel2.TabIndex = 22
        Me.Panel2.Visible = False
        '
        'boxpaciente
        '
        Me.boxpaciente.Enabled = False
        Me.boxpaciente.Location = New System.Drawing.Point(82, 311)
        Me.boxpaciente.Name = "boxpaciente"
        Me.boxpaciente.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.boxpaciente.Size = New System.Drawing.Size(213, 20)
        Me.boxpaciente.TabIndex = 26
        Me.boxpaciente.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label9.Location = New System.Drawing.Point(17, 261)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label9.Size = New System.Drawing.Size(54, 17)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "Cedula:"
        '
        'boxcedula
        '
        Me.boxcedula.Enabled = False
        Me.boxcedula.Location = New System.Drawing.Point(82, 260)
        Me.boxcedula.Name = "boxcedula"
        Me.boxcedula.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.boxcedula.Size = New System.Drawing.Size(213, 20)
        Me.boxcedula.TabIndex = 24
        '
        'boxmail
        '
        Me.boxmail.Location = New System.Drawing.Point(82, 203)
        Me.boxmail.Name = "boxmail"
        Me.boxmail.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.boxmail.Size = New System.Drawing.Size(213, 20)
        Me.boxmail.TabIndex = 23
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label6.Location = New System.Drawing.Point(17, 204)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(42, 17)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Email:"
        '
        'boxapellido
        '
        Me.boxapellido.Location = New System.Drawing.Point(82, 144)
        Me.boxapellido.Name = "boxapellido"
        Me.boxapellido.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.boxapellido.Size = New System.Drawing.Size(213, 20)
        Me.boxapellido.TabIndex = 21
        '
        'boxnombre
        '
        Me.boxnombre.Location = New System.Drawing.Point(82, 86)
        Me.boxnombre.Name = "boxnombre"
        Me.boxnombre.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.boxnombre.Size = New System.Drawing.Size(213, 20)
        Me.boxnombre.TabIndex = 19
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
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label5.Location = New System.Drawing.Point(17, 145)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(61, 17)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Apellido:"
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
        Me.Label8.Size = New System.Drawing.Size(149, 19)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Modificar Sintoma"
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
        Me.btnEliminarP.TabIndex = 17
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
        Me.btnModificarP.Location = New System.Drawing.Point(215, 430)
        Me.btnModificarP.Name = "btnModificarP"
        Me.btnModificarP.Size = New System.Drawing.Size(142, 38)
        Me.btnModificarP.TabIndex = 16
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
        Me.btnAgregarP.TabIndex = 15
        Me.btnAgregarP.Text = "Agregar"
        Me.btnAgregarP.UseVisualStyleBackColor = False
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AllowUserToResizeColumns = False
        Me.DataGridView2.AllowUserToResizeRows = False
        Me.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(26, 82)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DataGridView2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView2.Size = New System.Drawing.Size(513, 342)
        Me.DataGridView2.TabIndex = 14
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel1.Controls.Add(Me.txtmedico)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtcedula)
        Me.Panel1.Controls.Add(Me.txtmail)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtapellido)
        Me.Panel1.Controls.Add(Me.txtnombre)
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Location = New System.Drawing.Point(568, 25)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(310, 468)
        Me.Panel1.TabIndex = 25
        Me.Panel1.Visible = False
        '
        'txtmedico
        '
        Me.txtmedico.Enabled = False
        Me.txtmedico.Location = New System.Drawing.Point(82, 311)
        Me.txtmedico.Name = "txtmedico"
        Me.txtmedico.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtmedico.Size = New System.Drawing.Size(213, 20)
        Me.txtmedico.TabIndex = 26
        Me.txtmedico.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(17, 261)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(54, 17)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Cedula:"
        '
        'txtcedula
        '
        Me.txtcedula.Enabled = False
        Me.txtcedula.Location = New System.Drawing.Point(82, 260)
        Me.txtcedula.Name = "txtcedula"
        Me.txtcedula.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtcedula.Size = New System.Drawing.Size(213, 20)
        Me.txtcedula.TabIndex = 24
        '
        'txtmail
        '
        Me.txtmail.Location = New System.Drawing.Point(82, 203)
        Me.txtmail.Name = "txtmail"
        Me.txtmail.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtmail.Size = New System.Drawing.Size(213, 20)
        Me.txtmail.TabIndex = 23
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(17, 204)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(42, 17)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Email:"
        '
        'txtapellido
        '
        Me.txtapellido.Location = New System.Drawing.Point(82, 144)
        Me.txtapellido.Name = "txtapellido"
        Me.txtapellido.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtapellido.Size = New System.Drawing.Size(213, 20)
        Me.txtapellido.TabIndex = 21
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(82, 86)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtnombre.Size = New System.Drawing.Size(213, 20)
        Me.txtnombre.TabIndex = 19
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.LightGreen
        Me.Button5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button5.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Button5.Location = New System.Drawing.Point(89, 395)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(142, 38)
        Me.Button5.TabIndex = 18
        Me.Button5.Text = "Guardar"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(17, 145)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(61, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Apellido:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.Location = New System.Drawing.Point(17, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(59, 17)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Nombre:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label10.Location = New System.Drawing.Point(89, 11)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(149, 19)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Modificar Sintoma"
        '
        'Cuentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(895, 585)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Cuentas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Private WithEvents btnEliminarM As Button
    Private WithEvents btnModificarM As Button
    Private WithEvents btnAgregarM As Button
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents boxapellido As TextBox
    Friend WithEvents boxnombre As TextBox
    Private WithEvents btnGuardarP As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Private WithEvents btnEliminarP As Button
    Private WithEvents btnModificarP As Button
    Private WithEvents btnAgregarP As Button
    Friend WithEvents boxpaciente As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents boxcedula As TextBox
    Friend WithEvents boxmail As TextBox
    Friend WithEvents Label6 As Label
    Private WithEvents Button3 As Button
    Private WithEvents Button4 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtmedico As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtcedula As TextBox
    Friend WithEvents txtmail As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtapellido As TextBox
    Friend WithEvents txtnombre As TextBox
    Private WithEvents Button5 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label10 As Label
End Class
