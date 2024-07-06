<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_donoGerenFunc
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_donoGerenFunc))
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btn_cadastrar = New Guna.UI2.WinForms.Guna2Button()
        Me.txt_email = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_tel = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_nome = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_cpf = New Guna.UI2.WinForms.Guna2TextBox()
        Me.cmb_data_nasc = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmb_cargo = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btn_editar = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_excluir = New Guna.UI2.WinForms.Guna2Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.dgv_func = New System.Windows.Forms.DataGridView()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.btn_buscar = New Guna.UI2.WinForms.Guna2Button()
        Me.txt_pesq = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dgv_loginFunc = New System.Windows.Forms.DataGridView()
        Me.Panel2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgv_func, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.dgv_loginFunc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 0
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(919, 61)
        Me.Panel2.TabIndex = 96
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Yu Gothic UI Semilight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(22, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(196, 25)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Gerenciar Funcionários"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("Yu Gothic UI Semilight", 14.25!)
        Me.TabControl1.ItemSize = New System.Drawing.Size(62, 30)
        Me.TabControl1.Location = New System.Drawing.Point(0, 61)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(919, 545)
        Me.TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight
        Me.TabControl1.TabIndex = 97
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btn_cadastrar)
        Me.TabPage1.Controls.Add(Me.txt_email)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.txt_tel)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.txt_nome)
        Me.TabPage1.Controls.Add(Me.txt_cpf)
        Me.TabPage1.Controls.Add(Me.cmb_data_nasc)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.cmb_cargo)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.btn_editar)
        Me.TabPage1.Controls.Add(Me.btn_excluir)
        Me.TabPage1.Font = New System.Drawing.Font("Yu Gothic UI Semilight", 14.0!)
        Me.TabPage1.Location = New System.Drawing.Point(4, 34)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(911, 507)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Cadastrar Novo Funcionário"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btn_cadastrar
        '
        Me.btn_cadastrar.Animated = True
        Me.btn_cadastrar.BackColor = System.Drawing.SystemColors.Control
        Me.btn_cadastrar.BorderColor = System.Drawing.Color.BlanchedAlmond
        Me.btn_cadastrar.BorderRadius = 6
        Me.btn_cadastrar.CheckedState.Parent = Me.btn_cadastrar
        Me.btn_cadastrar.CustomImages.Parent = Me.btn_cadastrar
        Me.btn_cadastrar.FillColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.btn_cadastrar.Font = New System.Drawing.Font("Yu Gothic UI Semilight", 14.25!)
        Me.btn_cadastrar.ForeColor = System.Drawing.Color.White
        Me.btn_cadastrar.HoverState.Parent = Me.btn_cadastrar
        Me.btn_cadastrar.Location = New System.Drawing.Point(365, 308)
        Me.btn_cadastrar.Name = "btn_cadastrar"
        Me.btn_cadastrar.ShadowDecoration.Parent = Me.btn_cadastrar
        Me.btn_cadastrar.Size = New System.Drawing.Size(355, 45)
        Me.btn_cadastrar.TabIndex = 134
        Me.btn_cadastrar.Text = "Cadastrar"
        '
        'txt_email
        '
        Me.txt_email.BorderRadius = 7
        Me.txt_email.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_email.DefaultText = ""
        Me.txt_email.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_email.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_email.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_email.DisabledState.Parent = Me.txt_email
        Me.txt_email.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_email.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_email.FocusedState.Parent = Me.txt_email
        Me.txt_email.Font = New System.Drawing.Font("Yu Gothic UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_email.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_email.HoverState.Parent = Me.txt_email
        Me.txt_email.Location = New System.Drawing.Point(382, 230)
        Me.txt_email.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_email.PlaceholderText = ""
        Me.txt_email.SelectedText = ""
        Me.txt_email.ShadowDecoration.Parent = Me.txt_email
        Me.txt_email.Size = New System.Drawing.Size(338, 36)
        Me.txt_email.TabIndex = 133
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Yu Gothic UI Semilight", 14.25!)
        Me.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label7.Location = New System.Drawing.Point(377, 202)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 25)
        Me.Label7.TabIndex = 132
        Me.Label7.Text = "EMAIL"
        '
        'txt_tel
        '
        Me.txt_tel.BorderRadius = 7
        Me.txt_tel.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_tel.DefaultText = ""
        Me.txt_tel.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_tel.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_tel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_tel.DisabledState.Parent = Me.txt_tel
        Me.txt_tel.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_tel.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_tel.FocusedState.Parent = Me.txt_tel
        Me.txt_tel.Font = New System.Drawing.Font("Yu Gothic UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_tel.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_tel.HoverState.Parent = Me.txt_tel
        Me.txt_tel.Location = New System.Drawing.Point(202, 230)
        Me.txt_tel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_tel.Name = "txt_tel"
        Me.txt_tel.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_tel.PlaceholderText = "11 99999-9999"
        Me.txt_tel.SelectedText = ""
        Me.txt_tel.ShadowDecoration.Parent = Me.txt_tel
        Me.txt_tel.Size = New System.Drawing.Size(161, 36)
        Me.txt_tel.TabIndex = 131
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Yu Gothic UI Semilight", 14.25!)
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(197, 202)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 25)
        Me.Label2.TabIndex = 130
        Me.Label2.Text = "TELEFONE"
        '
        'txt_nome
        '
        Me.txt_nome.BorderRadius = 7
        Me.txt_nome.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_nome.DefaultText = ""
        Me.txt_nome.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_nome.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_nome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_nome.DisabledState.Parent = Me.txt_nome
        Me.txt_nome.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_nome.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_nome.FocusedState.Parent = Me.txt_nome
        Me.txt_nome.Font = New System.Drawing.Font("Yu Gothic UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nome.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_nome.HoverState.Parent = Me.txt_nome
        Me.txt_nome.Location = New System.Drawing.Point(201, 154)
        Me.txt_nome.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_nome.Name = "txt_nome"
        Me.txt_nome.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_nome.PlaceholderText = ""
        Me.txt_nome.SelectedText = ""
        Me.txt_nome.ShadowDecoration.Parent = Me.txt_nome
        Me.txt_nome.Size = New System.Drawing.Size(519, 36)
        Me.txt_nome.TabIndex = 129
        '
        'txt_cpf
        '
        Me.txt_cpf.BorderRadius = 7
        Me.txt_cpf.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_cpf.DefaultText = ""
        Me.txt_cpf.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_cpf.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_cpf.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_cpf.DisabledState.Parent = Me.txt_cpf
        Me.txt_cpf.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_cpf.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_cpf.FocusedState.Parent = Me.txt_cpf
        Me.txt_cpf.Font = New System.Drawing.Font("Yu Gothic UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cpf.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_cpf.HoverState.Parent = Me.txt_cpf
        Me.txt_cpf.Location = New System.Drawing.Point(201, 84)
        Me.txt_cpf.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_cpf.Name = "txt_cpf"
        Me.txt_cpf.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_cpf.PlaceholderText = "000.000.000-00"
        Me.txt_cpf.SelectedText = ""
        Me.txt_cpf.ShadowDecoration.Parent = Me.txt_cpf
        Me.txt_cpf.Size = New System.Drawing.Size(253, 36)
        Me.txt_cpf.TabIndex = 128
        '
        'cmb_data_nasc
        '
        Me.cmb_data_nasc.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.cmb_data_nasc.BorderRadius = 7
        Me.cmb_data_nasc.CheckedState.Parent = Me.cmb_data_nasc
        Me.cmb_data_nasc.FillColor = System.Drawing.Color.White
        Me.cmb_data_nasc.Font = New System.Drawing.Font("Yu Gothic UI Semilight", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_data_nasc.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.cmb_data_nasc.HoverState.Parent = Me.cmb_data_nasc
        Me.cmb_data_nasc.Location = New System.Drawing.Point(483, 84)
        Me.cmb_data_nasc.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.cmb_data_nasc.MinDate = New Date(1920, 1, 1, 0, 0, 0, 0)
        Me.cmb_data_nasc.Name = "cmb_data_nasc"
        Me.cmb_data_nasc.ShadowDecoration.Parent = Me.cmb_data_nasc
        Me.cmb_data_nasc.Size = New System.Drawing.Size(202, 36)
        Me.cmb_data_nasc.TabIndex = 127
        Me.cmb_data_nasc.Value = New Date(2000, 1, 1, 0, 0, 0, 0)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Yu Gothic UI Semilight", 14.25!)
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(478, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(207, 25)
        Me.Label5.TabIndex = 126
        Me.Label5.Text = "DATA DE NASCIMENTO"
        '
        'cmb_cargo
        '
        Me.cmb_cargo.BackColor = System.Drawing.Color.Transparent
        Me.cmb_cargo.BorderRadius = 7
        Me.cmb_cargo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmb_cargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_cargo.FocusedColor = System.Drawing.Color.Empty
        Me.cmb_cargo.FocusedState.Parent = Me.cmb_cargo
        Me.cmb_cargo.Font = New System.Drawing.Font("Yu Gothic UI Semilight", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_cargo.ForeColor = System.Drawing.Color.Black
        Me.cmb_cargo.FormattingEnabled = True
        Me.cmb_cargo.HoverState.Parent = Me.cmb_cargo
        Me.cmb_cargo.ItemHeight = 30
        Me.cmb_cargo.Items.AddRange(New Object() {"Funcionário", "Gerente"})
        Me.cmb_cargo.ItemsAppearance.Parent = Me.cmb_cargo
        Me.cmb_cargo.Location = New System.Drawing.Point(201, 308)
        Me.cmb_cargo.Name = "cmb_cargo"
        Me.cmb_cargo.ShadowDecoration.Parent = Me.cmb_cargo
        Me.cmb_cargo.Size = New System.Drawing.Size(140, 36)
        Me.cmb_cargo.TabIndex = 125
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Yu Gothic UI Semilight", 14.25!)
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(197, 280)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 25)
        Me.Label4.TabIndex = 124
        Me.Label4.Text = "CARGO"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Yu Gothic UI Semilight", 14.25!)
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(196, 126)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(166, 25)
        Me.Label3.TabIndex = 123
        Me.Label3.Text = "NOME COMPLETO"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Yu Gothic UI Semilight", 14.25!)
        Me.Label8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label8.Location = New System.Drawing.Point(197, 56)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 25)
        Me.Label8.TabIndex = 122
        Me.Label8.Text = "CPF"
        '
        'btn_editar
        '
        Me.btn_editar.Animated = True
        Me.btn_editar.BackColor = System.Drawing.SystemColors.Control
        Me.btn_editar.BorderColor = System.Drawing.Color.BlanchedAlmond
        Me.btn_editar.BorderRadius = 6
        Me.btn_editar.CheckedState.Parent = Me.btn_editar
        Me.btn_editar.CustomImages.Parent = Me.btn_editar
        Me.btn_editar.FillColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.btn_editar.Font = New System.Drawing.Font("Yu Gothic UI Semilight", 14.25!)
        Me.btn_editar.ForeColor = System.Drawing.Color.White
        Me.btn_editar.HoverState.Parent = Me.btn_editar
        Me.btn_editar.Location = New System.Drawing.Point(365, 308)
        Me.btn_editar.Name = "btn_editar"
        Me.btn_editar.ShadowDecoration.Parent = Me.btn_editar
        Me.btn_editar.Size = New System.Drawing.Size(355, 45)
        Me.btn_editar.TabIndex = 121
        Me.btn_editar.Text = "Editar"
        Me.btn_editar.Visible = False
        '
        'btn_excluir
        '
        Me.btn_excluir.Animated = True
        Me.btn_excluir.BorderRadius = 6
        Me.btn_excluir.CheckedState.Parent = Me.btn_excluir
        Me.btn_excluir.CustomImages.Parent = Me.btn_excluir
        Me.btn_excluir.FillColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.btn_excluir.Font = New System.Drawing.Font("Yu Gothic UI Semilight", 14.25!)
        Me.btn_excluir.ForeColor = System.Drawing.Color.White
        Me.btn_excluir.HoverState.Parent = Me.btn_excluir
        Me.btn_excluir.Location = New System.Drawing.Point(365, 387)
        Me.btn_excluir.Name = "btn_excluir"
        Me.btn_excluir.ShadowDecoration.Parent = Me.btn_excluir
        Me.btn_excluir.Size = New System.Drawing.Size(157, 45)
        Me.btn_excluir.TabIndex = 116
        Me.btn_excluir.Text = "Excluir"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.dgv_func)
        Me.TabPage2.Location = New System.Drawing.Point(4, 34)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(911, 507)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Listagem Geral"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'dgv_func
        '
        Me.dgv_func.AllowUserToAddRows = False
        Me.dgv_func.AllowUserToDeleteRows = False
        Me.dgv_func.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_func.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_func.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.dgv_func.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_func.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgv_func.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(36, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Yu Gothic UI Semilight", 14.25!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(36, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_func.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_func.ColumnHeadersHeight = 35
        Me.dgv_func.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(57, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Yu Gothic UI Semilight", 14.25!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(209, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_func.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_func.EnableHeadersVisualStyles = False
        Me.dgv_func.GridColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.dgv_func.Location = New System.Drawing.Point(8, 6)
        Me.dgv_func.Name = "dgv_func"
        Me.dgv_func.ReadOnly = True
        Me.dgv_func.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(57, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Yu Gothic UI Semilight", 14.25!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(209, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_func.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_func.RowHeadersVisible = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(57, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Yu Gothic UI Semilight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(209, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        Me.dgv_func.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgv_func.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_func.Size = New System.Drawing.Size(895, 493)
        Me.dgv_func.TabIndex = 93
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.btn_buscar)
        Me.TabPage3.Controls.Add(Me.txt_pesq)
        Me.TabPage3.Controls.Add(Me.Label6)
        Me.TabPage3.Controls.Add(Me.dgv_loginFunc)
        Me.TabPage3.Location = New System.Drawing.Point(4, 34)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(911, 507)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Entradas e Saídas"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'btn_buscar
        '
        Me.btn_buscar.Animated = True
        Me.btn_buscar.BorderRadius = 6
        Me.btn_buscar.CheckedState.Parent = Me.btn_buscar
        Me.btn_buscar.CustomImages.Parent = Me.btn_buscar
        Me.btn_buscar.FillColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.btn_buscar.Font = New System.Drawing.Font("Yu Gothic UI Semilight", 14.25!)
        Me.btn_buscar.ForeColor = System.Drawing.Color.White
        Me.btn_buscar.HoverState.Parent = Me.btn_buscar
        Me.btn_buscar.Image = CType(resources.GetObject("btn_buscar.Image"), System.Drawing.Image)
        Me.btn_buscar.Location = New System.Drawing.Point(450, 11)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.ShadowDecoration.Parent = Me.btn_buscar
        Me.btn_buscar.Size = New System.Drawing.Size(57, 36)
        Me.btn_buscar.TabIndex = 120
        '
        'txt_pesq
        '
        Me.txt_pesq.BorderRadius = 7
        Me.txt_pesq.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_pesq.DefaultText = ""
        Me.txt_pesq.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_pesq.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_pesq.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_pesq.DisabledState.Parent = Me.txt_pesq
        Me.txt_pesq.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_pesq.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_pesq.FocusedState.Parent = Me.txt_pesq
        Me.txt_pesq.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_pesq.HoverState.Parent = Me.txt_pesq
        Me.txt_pesq.Location = New System.Drawing.Point(265, 13)
        Me.txt_pesq.Margin = New System.Windows.Forms.Padding(7, 10, 7, 10)
        Me.txt_pesq.Name = "txt_pesq"
        Me.txt_pesq.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_pesq.PlaceholderText = ""
        Me.txt_pesq.SelectedText = ""
        Me.txt_pesq.ShadowDecoration.Parent = Me.txt_pesq
        Me.txt_pesq.Size = New System.Drawing.Size(175, 34)
        Me.txt_pesq.TabIndex = 118
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Yu Gothic UI Semilight", 14.25!)
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(18, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(237, 25)
        Me.Label6.TabIndex = 119
        Me.Label6.Text = "Digite o CPF do Funcionário"
        '
        'dgv_loginFunc
        '
        Me.dgv_loginFunc.AllowUserToAddRows = False
        Me.dgv_loginFunc.AllowUserToDeleteRows = False
        Me.dgv_loginFunc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_loginFunc.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_loginFunc.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.dgv_loginFunc.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_loginFunc.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgv_loginFunc.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(36, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Yu Gothic UI Semilight", 14.25!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(36, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_loginFunc.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgv_loginFunc.ColumnHeadersHeight = 35
        Me.dgv_loginFunc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(57, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Yu Gothic UI Semilight", 14.25!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(209, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_loginFunc.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgv_loginFunc.EnableHeadersVisualStyles = False
        Me.dgv_loginFunc.GridColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.dgv_loginFunc.Location = New System.Drawing.Point(8, 60)
        Me.dgv_loginFunc.Name = "dgv_loginFunc"
        Me.dgv_loginFunc.ReadOnly = True
        Me.dgv_loginFunc.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(57, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Yu Gothic UI Semilight", 14.25!)
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(209, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_loginFunc.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgv_loginFunc.RowHeadersVisible = False
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(57, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Yu Gothic UI Semilight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(209, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White
        Me.dgv_loginFunc.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.dgv_loginFunc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_loginFunc.Size = New System.Drawing.Size(895, 440)
        Me.dgv_loginFunc.TabIndex = 94
        '
        'frm_donoGerenFunc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(919, 606)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_donoGerenFunc"
        Me.Text = "frm_donoGerenFunc"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.dgv_func, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.dgv_loginFunc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents btn_editar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_excluir As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents dgv_func As DataGridView
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents dgv_loginFunc As DataGridView
    Friend WithEvents btn_buscar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txt_pesq As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btn_cadastrar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txt_email As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_tel As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_nome As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_cpf As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents cmb_data_nasc As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents cmb_cargo As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label8 As Label
End Class
