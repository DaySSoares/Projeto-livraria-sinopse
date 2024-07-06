<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_Vendas
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_cpfCli = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btn_add = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.btn_fimvenda = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_troco = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2ComboBox1 = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.lbl_valTot = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lbl_troco = New System.Windows.Forms.Label()
        Me.txt_rec = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lbl_valProd = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbl_desc = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbl_qtd = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_nomeProd = New System.Windows.Forms.Label()
        Me.txt_codprod = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgv_prod = New System.Windows.Forms.DataGridView()
        Me.cod_prod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.qtd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.preco = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Guna2Panel1.SuspendLayout()
        Me.Guna2Panel2.SuspendLayout()
        Me.Guna2Panel3.SuspendLayout()
        CType(Me.dgv_prod, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 12
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BorderRadius = 10
        Me.Guna2Panel1.Controls.Add(Me.dgv_prod)
        Me.Guna2Panel1.Controls.Add(Me.Label1)
        Me.Guna2Panel1.Controls.Add(Me.txt_cpfCli)
        Me.Guna2Panel1.Controls.Add(Me.btn_add)
        Me.Guna2Panel1.Controls.Add(Me.Guna2Panel2)
        Me.Guna2Panel1.Controls.Add(Me.txt_codprod)
        Me.Guna2Panel1.Controls.Add(Me.Label2)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(1118, 585)
        Me.Guna2Panel1.TabIndex = 49
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(709, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(180, 37)
        Me.Label1.TabIndex = 79
        Me.Label1.Text = "CPF CLIENTE:"
        '
        'txt_cpfCli
        '
        Me.txt_cpfCli.BorderRadius = 7
        Me.txt_cpfCli.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_cpfCli.DefaultText = ""
        Me.txt_cpfCli.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_cpfCli.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_cpfCli.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_cpfCli.DisabledState.Parent = Me.txt_cpfCli
        Me.txt_cpfCli.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_cpfCli.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_cpfCli.FocusedState.Parent = Me.txt_cpfCli
        Me.txt_cpfCli.Font = New System.Drawing.Font("Yu Gothic UI Semilight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cpfCli.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_cpfCli.HoverState.Parent = Me.txt_cpfCli
        Me.txt_cpfCli.Location = New System.Drawing.Point(898, 14)
        Me.txt_cpfCli.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.txt_cpfCli.Name = "txt_cpfCli"
        Me.txt_cpfCli.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_cpfCli.PlaceholderText = ""
        Me.txt_cpfCli.SelectedText = ""
        Me.txt_cpfCli.ShadowDecoration.Parent = Me.txt_cpfCli
        Me.txt_cpfCli.Size = New System.Drawing.Size(201, 36)
        Me.txt_cpfCli.TabIndex = 78
        Me.txt_cpfCli.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btn_add
        '
        Me.btn_add.Animated = True
        Me.btn_add.BorderRadius = 7
        Me.btn_add.CheckedState.Parent = Me.btn_add
        Me.btn_add.CustomImages.Parent = Me.btn_add
        Me.btn_add.FillColor = System.Drawing.Color.White
        Me.btn_add.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.btn_add.HoverState.Parent = Me.btn_add
        Me.btn_add.Location = New System.Drawing.Point(371, 15)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.ShadowDecoration.Parent = Me.btn_add
        Me.btn_add.Size = New System.Drawing.Size(172, 35)
        Me.btn_add.TabIndex = 77
        Me.btn_add.Text = "Adicionar"
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BackColor = System.Drawing.Color.White
        Me.Guna2Panel2.BorderRadius = 7
        Me.Guna2Panel2.Controls.Add(Me.btn_fimvenda)
        Me.Guna2Panel2.Controls.Add(Me.btn_troco)
        Me.Guna2Panel2.Controls.Add(Me.Guna2ComboBox1)
        Me.Guna2Panel2.Controls.Add(Me.Guna2Panel3)
        Me.Guna2Panel2.Controls.Add(Me.lbl_troco)
        Me.Guna2Panel2.Controls.Add(Me.txt_rec)
        Me.Guna2Panel2.Controls.Add(Me.Label17)
        Me.Guna2Panel2.Controls.Add(Me.Label16)
        Me.Guna2Panel2.Controls.Add(Me.Label13)
        Me.Guna2Panel2.Controls.Add(Me.lbl_valProd)
        Me.Guna2Panel2.Controls.Add(Me.Label7)
        Me.Guna2Panel2.Controls.Add(Me.lbl_desc)
        Me.Guna2Panel2.Controls.Add(Me.Label5)
        Me.Guna2Panel2.Controls.Add(Me.lbl_qtd)
        Me.Guna2Panel2.Controls.Add(Me.Label3)
        Me.Guna2Panel2.Controls.Add(Me.lbl_nomeProd)
        Me.Guna2Panel2.Location = New System.Drawing.Point(698, 60)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.ShadowDecoration.Parent = Me.Guna2Panel2
        Me.Guna2Panel2.Size = New System.Drawing.Size(401, 501)
        Me.Guna2Panel2.TabIndex = 76
        '
        'btn_fimvenda
        '
        Me.btn_fimvenda.Animated = True
        Me.btn_fimvenda.BorderRadius = 7
        Me.btn_fimvenda.CheckedState.Parent = Me.btn_fimvenda
        Me.btn_fimvenda.CustomImages.Parent = Me.btn_fimvenda
        Me.btn_fimvenda.FillColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.btn_fimvenda.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_fimvenda.ForeColor = System.Drawing.Color.White
        Me.btn_fimvenda.HoverState.Parent = Me.btn_fimvenda
        Me.btn_fimvenda.Location = New System.Drawing.Point(19, 454)
        Me.btn_fimvenda.Name = "btn_fimvenda"
        Me.btn_fimvenda.ShadowDecoration.Parent = Me.btn_fimvenda
        Me.btn_fimvenda.Size = New System.Drawing.Size(362, 35)
        Me.btn_fimvenda.TabIndex = 81
        Me.btn_fimvenda.Text = "Finalizar Venda"
        '
        'btn_troco
        '
        Me.btn_troco.Animated = True
        Me.btn_troco.BorderRadius = 7
        Me.btn_troco.CheckedState.Parent = Me.btn_troco
        Me.btn_troco.CustomImages.Parent = Me.btn_troco
        Me.btn_troco.FillColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.btn_troco.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_troco.ForeColor = System.Drawing.Color.White
        Me.btn_troco.HoverState.Parent = Me.btn_troco
        Me.btn_troco.Location = New System.Drawing.Point(188, 399)
        Me.btn_troco.Name = "btn_troco"
        Me.btn_troco.ShadowDecoration.Parent = Me.btn_troco
        Me.btn_troco.Size = New System.Drawing.Size(193, 35)
        Me.btn_troco.TabIndex = 80
        Me.btn_troco.Text = "Calcular Troco"
        '
        'Guna2ComboBox1
        '
        Me.Guna2ComboBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.Guna2ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Guna2ComboBox1.FocusedColor = System.Drawing.Color.Empty
        Me.Guna2ComboBox1.FocusedState.Parent = Me.Guna2ComboBox1
        Me.Guna2ComboBox1.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2ComboBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Guna2ComboBox1.FormattingEnabled = True
        Me.Guna2ComboBox1.HoverState.Parent = Me.Guna2ComboBox1
        Me.Guna2ComboBox1.ItemHeight = 30
        Me.Guna2ComboBox1.Items.AddRange(New Object() {"Dinheiro", "Débito", "Crédito"})
        Me.Guna2ComboBox1.ItemsAppearance.Parent = Me.Guna2ComboBox1
        Me.Guna2ComboBox1.Location = New System.Drawing.Point(235, 304)
        Me.Guna2ComboBox1.Name = "Guna2ComboBox1"
        Me.Guna2ComboBox1.ShadowDecoration.Parent = Me.Guna2ComboBox1
        Me.Guna2ComboBox1.Size = New System.Drawing.Size(140, 36)
        Me.Guna2ComboBox1.TabIndex = 78
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Guna2Panel3.Controls.Add(Me.lbl_valTot)
        Me.Guna2Panel3.Controls.Add(Me.Label9)
        Me.Guna2Panel3.Location = New System.Drawing.Point(0, 219)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.ShadowDecoration.Parent = Me.Guna2Panel3
        Me.Guna2Panel3.Size = New System.Drawing.Size(401, 65)
        Me.Guna2Panel3.TabIndex = 59
        '
        'lbl_valTot
        '
        Me.lbl_valTot.AutoSize = True
        Me.lbl_valTot.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbl_valTot.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_valTot.ForeColor = System.Drawing.Color.White
        Me.lbl_valTot.Location = New System.Drawing.Point(162, 20)
        Me.lbl_valTot.Name = "lbl_valTot"
        Me.lbl_valTot.Size = New System.Drawing.Size(98, 30)
        Me.lbl_valTot.TabIndex = 60
        Me.lbl_valTot.Text = "valor Tot"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label9.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(12, 14)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(160, 37)
        Me.Label9.TabIndex = 59
        Me.Label9.Text = "Valor Total: "
        '
        'lbl_troco
        '
        Me.lbl_troco.AutoSize = True
        Me.lbl_troco.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbl_troco.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_troco.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.lbl_troco.Location = New System.Drawing.Point(85, 404)
        Me.lbl_troco.Name = "lbl_troco"
        Me.lbl_troco.Size = New System.Drawing.Size(85, 30)
        Me.lbl_troco.TabIndex = 57
        Me.lbl_troco.Text = "R$ 0,00"
        '
        'txt_rec
        '
        Me.txt_rec.BorderRadius = 7
        Me.txt_rec.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_rec.DefaultText = ""
        Me.txt_rec.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_rec.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_rec.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_rec.DisabledState.Parent = Me.txt_rec
        Me.txt_rec.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_rec.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_rec.FocusedState.Parent = Me.txt_rec
        Me.txt_rec.Font = New System.Drawing.Font("Yu Gothic UI Semilight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_rec.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_rec.HoverState.Parent = Me.txt_rec
        Me.txt_rec.Location = New System.Drawing.Point(188, 354)
        Me.txt_rec.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.txt_rec.Name = "txt_rec"
        Me.txt_rec.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_rec.PlaceholderText = ""
        Me.txt_rec.SelectedText = ""
        Me.txt_rec.ShadowDecoration.Parent = Me.txt_rec
        Me.txt_rec.Size = New System.Drawing.Size(153, 36)
        Me.txt_rec.TabIndex = 77
        Me.txt_rec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label17.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Label17.Location = New System.Drawing.Point(14, 404)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(78, 30)
        Me.Label17.TabIndex = 66
        Me.Label17.Text = "Troco: "
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label16.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(14, 354)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(166, 30)
        Me.Label16.TabIndex = 65
        Me.Label16.Text = "Total Recebido: "
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label13.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(13, 306)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(231, 30)
        Me.Label13.TabIndex = 62
        Me.Label13.Text = "Forma de Pagamento: "
        '
        'lbl_valProd
        '
        Me.lbl_valProd.AutoSize = True
        Me.lbl_valProd.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbl_valProd.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_valProd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.lbl_valProd.Location = New System.Drawing.Point(155, 168)
        Me.lbl_valProd.Name = "lbl_valProd"
        Me.lbl_valProd.Size = New System.Drawing.Size(85, 30)
        Me.lbl_valProd.TabIndex = 58
        Me.lbl_valProd.Text = "R$ 0,00"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(11, 162)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(108, 37)
        Me.Label7.TabIndex = 57
        Me.Label7.Text = "VALOR "
        '
        'lbl_desc
        '
        Me.lbl_desc.AutoSize = True
        Me.lbl_desc.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbl_desc.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_desc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.lbl_desc.Location = New System.Drawing.Point(155, 110)
        Me.lbl_desc.Name = "lbl_desc"
        Me.lbl_desc.Size = New System.Drawing.Size(85, 30)
        Me.lbl_desc.TabIndex = 56
        Me.lbl_desc.Text = "R$ 0,00"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(13, 110)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(115, 30)
        Me.Label5.TabIndex = 55
        Me.Label5.Text = "Desconto: "
        '
        'lbl_qtd
        '
        Me.lbl_qtd.AutoSize = True
        Me.lbl_qtd.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbl_qtd.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_qtd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.lbl_qtd.Location = New System.Drawing.Point(155, 58)
        Me.lbl_qtd.Name = "lbl_qtd"
        Me.lbl_qtd.Size = New System.Drawing.Size(0, 30)
        Me.lbl_qtd.TabIndex = 54
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(13, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 30)
        Me.Label3.TabIndex = 53
        Me.Label3.Text = "Quantidade: "
        '
        'lbl_nomeProd
        '
        Me.lbl_nomeProd.AutoSize = True
        Me.lbl_nomeProd.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbl_nomeProd.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nomeProd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.lbl_nomeProd.Location = New System.Drawing.Point(13, 9)
        Me.lbl_nomeProd.Name = "lbl_nomeProd"
        Me.lbl_nomeProd.Size = New System.Drawing.Size(72, 30)
        Me.lbl_nomeProd.TabIndex = 52
        Me.lbl_nomeProd.Text = "Nome"
        '
        'txt_codprod
        '
        Me.txt_codprod.BorderRadius = 7
        Me.txt_codprod.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_codprod.DefaultText = ""
        Me.txt_codprod.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_codprod.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_codprod.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_codprod.DisabledState.Parent = Me.txt_codprod
        Me.txt_codprod.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_codprod.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_codprod.FocusedState.Parent = Me.txt_codprod
        Me.txt_codprod.Font = New System.Drawing.Font("Yu Gothic UI Semilight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_codprod.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_codprod.HoverState.Parent = Me.txt_codprod
        Me.txt_codprod.Location = New System.Drawing.Point(185, 15)
        Me.txt_codprod.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.txt_codprod.Name = "txt_codprod"
        Me.txt_codprod.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_codprod.PlaceholderText = ""
        Me.txt_codprod.SelectedText = ""
        Me.txt_codprod.ShadowDecoration.Parent = Me.txt_codprod
        Me.txt_codprod.Size = New System.Drawing.Size(178, 36)
        Me.txt_codprod.TabIndex = 75
        Me.txt_codprod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Yu Gothic UI Semilight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(8, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(169, 25)
        Me.Label2.TabIndex = 51
        Me.Label2.Text = "Código do Produto"
        '
        'dgv_prod
        '
        Me.dgv_prod.AllowUserToAddRows = False
        Me.dgv_prod.AllowUserToDeleteRows = False
        Me.dgv_prod.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_prod.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_prod.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.dgv_prod.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_prod.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgv_prod.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(36, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Yu Gothic UI Semilight", 14.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(36, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_prod.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_prod.ColumnHeadersHeight = 35
        Me.dgv_prod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgv_prod.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cod_prod, Me.prod, Me.qtd, Me.preco})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(57, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Yu Gothic UI Semilight", 14.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(209, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_prod.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_prod.EnableHeadersVisualStyles = False
        Me.dgv_prod.GridColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.dgv_prod.Location = New System.Drawing.Point(12, 60)
        Me.dgv_prod.Name = "dgv_prod"
        Me.dgv_prod.ReadOnly = True
        Me.dgv_prod.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(57, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Yu Gothic UI Semilight", 14.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(209, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_prod.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_prod.RowHeadersVisible = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(57, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Yu Gothic UI Semilight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(209, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        Me.dgv_prod.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgv_prod.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_prod.Size = New System.Drawing.Size(671, 501)
        Me.dgv_prod.TabIndex = 97
        '
        'cod_prod
        '
        Me.cod_prod.HeaderText = "Código"
        Me.cod_prod.Name = "cod_prod"
        Me.cod_prod.ReadOnly = True
        '
        'prod
        '
        Me.prod.HeaderText = "Produto"
        Me.prod.Name = "prod"
        Me.prod.ReadOnly = True
        '
        'qtd
        '
        Me.qtd.HeaderText = "Qtd"
        Me.qtd.Name = "qtd"
        Me.qtd.ReadOnly = True
        '
        'preco
        '
        Me.preco.HeaderText = "Preço"
        Me.preco.Name = "preco"
        Me.preco.ReadOnly = True
        '
        'frm_Vendas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1118, 585)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_Vendas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_Vendas"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        Me.Guna2Panel3.ResumeLayout(False)
        Me.Guna2Panel3.PerformLayout()
        CType(Me.dgv_prod, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lbl_qtd As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lbl_nomeProd As Label
    Friend WithEvents txt_codprod As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lbl_valTot As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lbl_valProd As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lbl_desc As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lbl_troco As Label
    Friend WithEvents txt_rec As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Guna2ComboBox1 As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents btn_add As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_troco As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_fimvenda As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_cpfCli As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents dgv_prod As DataGridView
    Friend WithEvents cod_prod As DataGridViewTextBoxColumn
    Friend WithEvents prod As DataGridViewTextBoxColumn
    Friend WithEvents qtd As DataGridViewTextBoxColumn
    Friend WithEvents preco As DataGridViewTextBoxColumn
End Class
