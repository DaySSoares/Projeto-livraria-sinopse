<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_gerenciarProd
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_gerenciarProd))
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.panel_cadastrosProd = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.dgv_prod = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btn_limpar = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_buscar = New Guna.UI2.WinForms.Guna2Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_pesquisa = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_nomeprod = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btn_excluir = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_editar = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_salvar = New Guna.UI2.WinForms.Guna2Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmb_dispon = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmb_gen = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.txt_codprod = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_preco = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_qtd = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.img_produto = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.panel_cadastrosProd.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgv_prod, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.img_produto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 0
        Me.Guna2Elipse1.TargetControl = Me
        '
        'panel_cadastrosProd
        '
        Me.panel_cadastrosProd.AutoScroll = True
        Me.panel_cadastrosProd.BackColor = System.Drawing.Color.White
        Me.panel_cadastrosProd.Controls.Add(Me.TabControl1)
        Me.panel_cadastrosProd.Controls.Add(Me.Panel2)
        Me.panel_cadastrosProd.Location = New System.Drawing.Point(0, 0)
        Me.panel_cadastrosProd.Name = "panel_cadastrosProd"
        Me.panel_cadastrosProd.Size = New System.Drawing.Size(907, 603)
        Me.panel_cadastrosProd.TabIndex = 39
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("Yu Gothic UI Semilight", 14.25!)
        Me.TabControl1.ItemSize = New System.Drawing.Size(62, 30)
        Me.TabControl1.Location = New System.Drawing.Point(0, 61)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(907, 542)
        Me.TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight
        Me.TabControl1.TabIndex = 94
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.dgv_prod)
        Me.TabPage1.Font = New System.Drawing.Font("Yu Gothic UI Semilight", 14.0!)
        Me.TabPage1.Location = New System.Drawing.Point(4, 34)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(899, 504)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Lista de Livros"
        Me.TabPage1.UseVisualStyleBackColor = True
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
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(57, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Yu Gothic UI Semilight", 14.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(209, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_prod.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_prod.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_prod.EnableHeadersVisualStyles = False
        Me.dgv_prod.GridColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.dgv_prod.Location = New System.Drawing.Point(3, 3)
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
        Me.dgv_prod.Size = New System.Drawing.Size(893, 498)
        Me.dgv_prod.TabIndex = 94
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btn_limpar)
        Me.TabPage2.Controls.Add(Me.btn_buscar)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.txt_pesquisa)
        Me.TabPage2.Controls.Add(Me.txt_nomeprod)
        Me.TabPage2.Controls.Add(Me.btn_excluir)
        Me.TabPage2.Controls.Add(Me.btn_editar)
        Me.TabPage2.Controls.Add(Me.btn_salvar)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.cmb_dispon)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.cmb_gen)
        Me.TabPage2.Controls.Add(Me.txt_codprod)
        Me.TabPage2.Controls.Add(Me.txt_preco)
        Me.TabPage2.Controls.Add(Me.txt_qtd)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.img_produto)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 34)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(899, 504)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Cadastrar Novo Livro"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btn_limpar
        '
        Me.btn_limpar.Animated = True
        Me.btn_limpar.BorderRadius = 6
        Me.btn_limpar.CheckedState.Parent = Me.btn_limpar
        Me.btn_limpar.CustomImages.Parent = Me.btn_limpar
        Me.btn_limpar.FillColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.btn_limpar.Font = New System.Drawing.Font("Yu Gothic UI Semilight", 14.25!)
        Me.btn_limpar.ForeColor = System.Drawing.Color.White
        Me.btn_limpar.HoverState.Parent = Me.btn_limpar
        Me.btn_limpar.Location = New System.Drawing.Point(531, 407)
        Me.btn_limpar.Name = "btn_limpar"
        Me.btn_limpar.ShadowDecoration.Parent = Me.btn_limpar
        Me.btn_limpar.Size = New System.Drawing.Size(111, 45)
        Me.btn_limpar.TabIndex = 107
        Me.btn_limpar.Text = "Limpar"
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
        Me.btn_buscar.Location = New System.Drawing.Point(651, 37)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.ShadowDecoration.Parent = Me.btn_buscar
        Me.btn_buscar.Size = New System.Drawing.Size(121, 36)
        Me.btn_buscar.TabIndex = 106
        Me.btn_buscar.Text = "Buscar"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Yu Gothic UI Semilight", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(125, 37)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(190, 30)
        Me.Label9.TabIndex = 105
        Me.Label9.Text = "Pesquisar produtos"
        '
        'txt_pesquisa
        '
        Me.txt_pesquisa.BorderRadius = 9
        Me.txt_pesquisa.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_pesquisa.DefaultText = ""
        Me.txt_pesquisa.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_pesquisa.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_pesquisa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_pesquisa.DisabledState.Parent = Me.txt_pesquisa
        Me.txt_pesquisa.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_pesquisa.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_pesquisa.FocusedState.Parent = Me.txt_pesquisa
        Me.txt_pesquisa.Font = New System.Drawing.Font("Yu Gothic UI", 14.0!)
        Me.txt_pesquisa.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_pesquisa.HoverState.Parent = Me.txt_pesquisa
        Me.txt_pesquisa.Location = New System.Drawing.Point(324, 37)
        Me.txt_pesquisa.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txt_pesquisa.Name = "txt_pesquisa"
        Me.txt_pesquisa.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_pesquisa.PlaceholderText = "Digite o Nome, ID ou Setor"
        Me.txt_pesquisa.SelectedText = ""
        Me.txt_pesquisa.ShadowDecoration.Parent = Me.txt_pesquisa
        Me.txt_pesquisa.Size = New System.Drawing.Size(318, 36)
        Me.txt_pesquisa.TabIndex = 104
        '
        'txt_nomeprod
        '
        Me.txt_nomeprod.BorderRadius = 7
        Me.txt_nomeprod.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_nomeprod.DefaultText = ""
        Me.txt_nomeprod.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_nomeprod.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_nomeprod.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_nomeprod.DisabledState.Parent = Me.txt_nomeprod
        Me.txt_nomeprod.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_nomeprod.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_nomeprod.FocusedState.Parent = Me.txt_nomeprod
        Me.txt_nomeprod.Font = New System.Drawing.Font("Yu Gothic UI Semilight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nomeprod.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_nomeprod.HoverState.Parent = Me.txt_nomeprod
        Me.txt_nomeprod.Location = New System.Drawing.Point(405, 189)
        Me.txt_nomeprod.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.txt_nomeprod.Name = "txt_nomeprod"
        Me.txt_nomeprod.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_nomeprod.PlaceholderText = ""
        Me.txt_nomeprod.SelectedText = ""
        Me.txt_nomeprod.ShadowDecoration.Parent = Me.txt_nomeprod
        Me.txt_nomeprod.Size = New System.Drawing.Size(365, 36)
        Me.txt_nomeprod.TabIndex = 91
        Me.txt_nomeprod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.btn_excluir.Location = New System.Drawing.Point(659, 407)
        Me.btn_excluir.Name = "btn_excluir"
        Me.btn_excluir.ShadowDecoration.Parent = Me.btn_excluir
        Me.btn_excluir.Size = New System.Drawing.Size(111, 45)
        Me.btn_excluir.TabIndex = 103
        Me.btn_excluir.Text = "Excluir"
        '
        'btn_editar
        '
        Me.btn_editar.Animated = True
        Me.btn_editar.BorderRadius = 6
        Me.btn_editar.CheckedState.Parent = Me.btn_editar
        Me.btn_editar.CustomImages.Parent = Me.btn_editar
        Me.btn_editar.FillColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.btn_editar.Font = New System.Drawing.Font("Yu Gothic UI Semilight", 14.25!)
        Me.btn_editar.ForeColor = System.Drawing.Color.White
        Me.btn_editar.HoverState.Parent = Me.btn_editar
        Me.btn_editar.Location = New System.Drawing.Point(405, 407)
        Me.btn_editar.Name = "btn_editar"
        Me.btn_editar.ShadowDecoration.Parent = Me.btn_editar
        Me.btn_editar.Size = New System.Drawing.Size(111, 45)
        Me.btn_editar.TabIndex = 102
        Me.btn_editar.Text = "Editar"
        '
        'btn_salvar
        '
        Me.btn_salvar.Animated = True
        Me.btn_salvar.BackColor = System.Drawing.SystemColors.Control
        Me.btn_salvar.BorderColor = System.Drawing.Color.BlanchedAlmond
        Me.btn_salvar.BorderRadius = 6
        Me.btn_salvar.CheckedState.Parent = Me.btn_salvar
        Me.btn_salvar.CustomImages.Parent = Me.btn_salvar
        Me.btn_salvar.FillColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.btn_salvar.Font = New System.Drawing.Font("Yu Gothic UI Semilight", 14.25!)
        Me.btn_salvar.ForeColor = System.Drawing.Color.White
        Me.btn_salvar.HoverState.Parent = Me.btn_salvar
        Me.btn_salvar.Location = New System.Drawing.Point(132, 407)
        Me.btn_salvar.Name = "btn_salvar"
        Me.btn_salvar.ShadowDecoration.Parent = Me.btn_salvar
        Me.btn_salvar.Size = New System.Drawing.Size(247, 45)
        Me.btn_salvar.TabIndex = 101
        Me.btn_salvar.Text = "Salvar"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Yu Gothic UI Semilight", 14.25!)
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(406, 316)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(138, 25)
        Me.Label6.TabIndex = 100
        Me.Label6.Text = "Disponibilidade"
        '
        'cmb_dispon
        '
        Me.cmb_dispon.BackColor = System.Drawing.Color.Transparent
        Me.cmb_dispon.BorderRadius = 6
        Me.cmb_dispon.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmb_dispon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_dispon.FocusedColor = System.Drawing.Color.Empty
        Me.cmb_dispon.FocusedState.Parent = Me.cmb_dispon
        Me.cmb_dispon.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmb_dispon.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmb_dispon.FormattingEnabled = True
        Me.cmb_dispon.HoverState.Parent = Me.cmb_dispon
        Me.cmb_dispon.ItemHeight = 30
        Me.cmb_dispon.Items.AddRange(New Object() {"Disponível", "Fora de Estoque"})
        Me.cmb_dispon.ItemsAppearance.Parent = Me.cmb_dispon
        Me.cmb_dispon.Location = New System.Drawing.Point(406, 344)
        Me.cmb_dispon.Name = "cmb_dispon"
        Me.cmb_dispon.ShadowDecoration.Parent = Me.cmb_dispon
        Me.cmb_dispon.Size = New System.Drawing.Size(169, 36)
        Me.cmb_dispon.TabIndex = 99
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Yu Gothic UI Semilight", 14.25!)
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(613, 316)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(143, 25)
        Me.Label5.TabIndex = 98
        Me.Label5.Text = "Gênero do Livro"
        '
        'cmb_gen
        '
        Me.cmb_gen.BackColor = System.Drawing.Color.Transparent
        Me.cmb_gen.BorderRadius = 6
        Me.cmb_gen.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmb_gen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_gen.FocusedColor = System.Drawing.Color.Empty
        Me.cmb_gen.FocusedState.Parent = Me.cmb_gen
        Me.cmb_gen.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmb_gen.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmb_gen.FormattingEnabled = True
        Me.cmb_gen.HoverState.Parent = Me.cmb_gen
        Me.cmb_gen.ItemHeight = 30
        Me.cmb_gen.Items.AddRange(New Object() {"Fantasia", "Ficcção Científica", "Ação e Aventura", "Terror", "Romance", "Infantil", "Conto", "Biografia"})
        Me.cmb_gen.ItemsAppearance.Parent = Me.cmb_gen
        Me.cmb_gen.Location = New System.Drawing.Point(613, 344)
        Me.cmb_gen.Name = "cmb_gen"
        Me.cmb_gen.ShadowDecoration.Parent = Me.cmb_gen
        Me.cmb_gen.Size = New System.Drawing.Size(159, 36)
        Me.cmb_gen.TabIndex = 97
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
        Me.txt_codprod.Location = New System.Drawing.Point(563, 107)
        Me.txt_codprod.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.txt_codprod.Name = "txt_codprod"
        Me.txt_codprod.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_codprod.PlaceholderText = ""
        Me.txt_codprod.SelectedText = ""
        Me.txt_codprod.ShadowDecoration.Parent = Me.txt_codprod
        Me.txt_codprod.Size = New System.Drawing.Size(131, 36)
        Me.txt_codprod.TabIndex = 88
        Me.txt_codprod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_preco
        '
        Me.txt_preco.BorderRadius = 7
        Me.txt_preco.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_preco.DefaultText = ""
        Me.txt_preco.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_preco.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_preco.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_preco.DisabledState.Parent = Me.txt_preco
        Me.txt_preco.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_preco.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_preco.FocusedState.Parent = Me.txt_preco
        Me.txt_preco.Font = New System.Drawing.Font("Yu Gothic UI Semilight", 14.0!)
        Me.txt_preco.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_preco.HoverState.Parent = Me.txt_preco
        Me.txt_preco.Location = New System.Drawing.Point(622, 265)
        Me.txt_preco.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.txt_preco.Name = "txt_preco"
        Me.txt_preco.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_preco.PlaceholderText = "R$ 999,99"
        Me.txt_preco.SelectedText = ""
        Me.txt_preco.ShadowDecoration.Parent = Me.txt_preco
        Me.txt_preco.Size = New System.Drawing.Size(150, 36)
        Me.txt_preco.TabIndex = 89
        '
        'txt_qtd
        '
        Me.txt_qtd.BorderRadius = 7
        Me.txt_qtd.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_qtd.DefaultText = ""
        Me.txt_qtd.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_qtd.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_qtd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_qtd.DisabledState.Parent = Me.txt_qtd
        Me.txt_qtd.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_qtd.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_qtd.FocusedState.Parent = Me.txt_qtd
        Me.txt_qtd.Font = New System.Drawing.Font("Yu Gothic UI Semilight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_qtd.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_qtd.HoverState.Parent = Me.txt_qtd
        Me.txt_qtd.Location = New System.Drawing.Point(406, 265)
        Me.txt_qtd.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.txt_qtd.Name = "txt_qtd"
        Me.txt_qtd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_qtd.PlaceholderText = ""
        Me.txt_qtd.SelectedText = ""
        Me.txt_qtd.ShadowDecoration.Parent = Me.txt_qtd
        Me.txt_qtd.Size = New System.Drawing.Size(206, 36)
        Me.txt_qtd.TabIndex = 90
        Me.txt_qtd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Yu Gothic UI Semilight", 14.25!)
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(402, 237)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(210, 25)
        Me.Label4.TabIndex = 96
        Me.Label4.Text = "Quantidade em Estoque"
        '
        'img_produto
        '
        Me.img_produto.Image = CType(resources.GetObject("img_produto.Image"), System.Drawing.Image)
        Me.img_produto.Location = New System.Drawing.Point(132, 107)
        Me.img_produto.Name = "img_produto"
        Me.img_produto.Size = New System.Drawing.Size(247, 273)
        Me.img_produto.TabIndex = 95
        Me.img_produto.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Yu Gothic UI Semilight", 14.25!)
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(618, 237)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(155, 25)
        Me.Label3.TabIndex = 94
        Me.Label3.Text = "Preço do Produto"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Yu Gothic UI Semilight", 14.25!)
        Me.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label7.Location = New System.Drawing.Point(400, 158)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(160, 25)
        Me.Label7.TabIndex = 93
        Me.Label7.Text = "Nome do Produto"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Yu Gothic UI Semilight", 14.25!)
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(490, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 25)
        Me.Label2.TabIndex = 92
        Me.Label2.Text = "Código "
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(907, 61)
        Me.Panel2.TabIndex = 93
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Yu Gothic UI Semilight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(22, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(168, 25)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Gerenciar Produtos"
        '
        'frm_gerenciarProd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(915, 608)
        Me.Controls.Add(Me.panel_cadastrosProd)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_gerenciarProd"
        Me.Text = "frm_gerenciarProd"
        Me.panel_cadastrosProd.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.dgv_prod, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.img_produto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents panel_cadastrosProd As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents txt_nomeprod As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btn_excluir As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_editar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_salvar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label6 As Label
    Friend WithEvents cmb_dispon As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cmb_gen As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents txt_codprod As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_preco As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_qtd As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents img_produto As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_buscar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_pesquisa As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btn_limpar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents dgv_prod As DataGridView
End Class
