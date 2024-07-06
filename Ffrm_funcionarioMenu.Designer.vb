<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ffrm_funcionarioMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ffrm_funcionarioMenu))
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btn_estoque = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_sair = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_cadastroCli = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_venda = New Guna.UI2.WinForms.Guna2Button()
        Me.lbl_nomeFunc = New System.Windows.Forms.Label()
        Me.panel_form = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.lbl_hora = New System.Windows.Forms.Label()
        Me.lbl_dia = New System.Windows.Forms.Label()
        Me.Guna2ControlBox2 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 12
        Me.Guna2Elipse1.TargetControl = Me
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-25, -54)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(214, 171)
        Me.PictureBox1.TabIndex = 53
        Me.PictureBox1.TabStop = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.btn_estoque, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_sair, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_cadastroCli, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_venda, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(636, 12)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(411, 67)
        Me.TableLayoutPanel1.TabIndex = 54
        '
        'btn_estoque
        '
        Me.btn_estoque.Animated = True
        Me.btn_estoque.BorderRadius = 7
        Me.btn_estoque.CheckedState.Parent = Me.btn_estoque
        Me.btn_estoque.CustomImages.Parent = Me.btn_estoque
        Me.btn_estoque.FillColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.btn_estoque.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_estoque.ForeColor = System.Drawing.Color.White
        Me.btn_estoque.HoverState.Parent = Me.btn_estoque
        Me.btn_estoque.Location = New System.Drawing.Point(238, 3)
        Me.btn_estoque.Name = "btn_estoque"
        Me.btn_estoque.ShadowDecoration.Parent = Me.btn_estoque
        Me.btn_estoque.Size = New System.Drawing.Size(95, 58)
        Me.btn_estoque.TabIndex = 2
        Me.btn_estoque.Text = "Estoque"
        '
        'btn_sair
        '
        Me.btn_sair.Animated = True
        Me.btn_sair.BorderRadius = 7
        Me.btn_sair.CheckedState.Parent = Me.btn_sair
        Me.btn_sair.CustomImages.Parent = Me.btn_sair
        Me.btn_sair.FillColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.btn_sair.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_sair.ForeColor = System.Drawing.Color.White
        Me.btn_sair.HoverState.Parent = Me.btn_sair
        Me.btn_sair.Location = New System.Drawing.Point(339, 3)
        Me.btn_sair.Name = "btn_sair"
        Me.btn_sair.ShadowDecoration.Parent = Me.btn_sair
        Me.btn_sair.Size = New System.Drawing.Size(61, 58)
        Me.btn_sair.TabIndex = 3
        Me.btn_sair.Text = "Sair"
        '
        'btn_cadastroCli
        '
        Me.btn_cadastroCli.Animated = True
        Me.btn_cadastroCli.BorderRadius = 7
        Me.btn_cadastroCli.CheckedState.Parent = Me.btn_cadastroCli
        Me.btn_cadastroCli.CustomImages.Parent = Me.btn_cadastroCli
        Me.btn_cadastroCli.FillColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.btn_cadastroCli.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cadastroCli.ForeColor = System.Drawing.Color.White
        Me.btn_cadastroCli.HoverState.Parent = Me.btn_cadastroCli
        Me.btn_cadastroCli.Location = New System.Drawing.Point(3, 3)
        Me.btn_cadastroCli.Name = "btn_cadastroCli"
        Me.btn_cadastroCli.ShadowDecoration.Parent = Me.btn_cadastroCli
        Me.btn_cadastroCli.Size = New System.Drawing.Size(110, 58)
        Me.btn_cadastroCli.TabIndex = 1
        Me.btn_cadastroCli.Text = "Cadastro de Cliente"
        '
        'btn_venda
        '
        Me.btn_venda.Animated = True
        Me.btn_venda.BorderRadius = 7
        Me.btn_venda.CheckedState.Parent = Me.btn_venda
        Me.btn_venda.CustomImages.Parent = Me.btn_venda
        Me.btn_venda.FillColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.btn_venda.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_venda.ForeColor = System.Drawing.Color.White
        Me.btn_venda.HoverState.Parent = Me.btn_venda
        Me.btn_venda.Location = New System.Drawing.Point(119, 3)
        Me.btn_venda.Name = "btn_venda"
        Me.btn_venda.ShadowDecoration.Parent = Me.btn_venda
        Me.btn_venda.Size = New System.Drawing.Size(113, 58)
        Me.btn_venda.TabIndex = 0
        Me.btn_venda.Text = "Menu de Vendas"
        '
        'lbl_nomeFunc
        '
        Me.lbl_nomeFunc.AutoSize = True
        Me.lbl_nomeFunc.Font = New System.Drawing.Font("Yu Gothic UI Semilight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nomeFunc.ForeColor = System.Drawing.Color.White
        Me.lbl_nomeFunc.Location = New System.Drawing.Point(207, 13)
        Me.lbl_nomeFunc.Name = "lbl_nomeFunc"
        Me.lbl_nomeFunc.Size = New System.Drawing.Size(161, 25)
        Me.lbl_nomeFunc.TabIndex = 58
        Me.lbl_nomeFunc.Text = "Nome Funcionário"
        '
        'panel_form
        '
        Me.panel_form.Location = New System.Drawing.Point(12, 133)
        Me.panel_form.Name = "panel_form"
        Me.panel_form.Size = New System.Drawing.Size(1118, 585)
        Me.panel_form.TabIndex = 59
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 743)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1142, 41)
        Me.Panel2.TabIndex = 60
        '
        'Timer
        '
        Me.Timer.Enabled = True
        Me.Timer.Interval = 60000
        '
        'lbl_hora
        '
        Me.lbl_hora.AutoSize = True
        Me.lbl_hora.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_hora.ForeColor = System.Drawing.Color.White
        Me.lbl_hora.Location = New System.Drawing.Point(207, 87)
        Me.lbl_hora.Name = "lbl_hora"
        Me.lbl_hora.Size = New System.Drawing.Size(60, 30)
        Me.lbl_hora.TabIndex = 61
        Me.lbl_hora.Text = "Hora"
        '
        'lbl_dia
        '
        Me.lbl_dia.AutoSize = True
        Me.lbl_dia.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_dia.ForeColor = System.Drawing.Color.White
        Me.lbl_dia.Location = New System.Drawing.Point(207, 49)
        Me.lbl_dia.Name = "lbl_dia"
        Me.lbl_dia.Size = New System.Drawing.Size(44, 30)
        Me.lbl_dia.TabIndex = 62
        Me.lbl_dia.Text = "Dia"
        '
        'Guna2ControlBox2
        '
        Me.Guna2ControlBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox2.BorderRadius = 5
        Me.Guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.Guna2ControlBox2.CustomIconSize = 20.0!
        Me.Guna2ControlBox2.FillColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Guna2ControlBox2.HoverState.Parent = Me.Guna2ControlBox2
        Me.Guna2ControlBox2.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox2.Location = New System.Drawing.Point(1064, 15)
        Me.Guna2ControlBox2.Name = "Guna2ControlBox2"
        Me.Guna2ControlBox2.ShadowDecoration.Parent = Me.Guna2ControlBox2
        Me.Guna2ControlBox2.Size = New System.Drawing.Size(30, 26)
        Me.Guna2ControlBox2.TabIndex = 64
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox1.BorderRadius = 5
        Me.Guna2ControlBox1.CustomIconSize = 20.0!
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Guna2ControlBox1.HoverState.Parent = Me.Guna2ControlBox1
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(1100, 15)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.ShadowDecoration.Parent = Me.Guna2ControlBox1
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(30, 26)
        Me.Guna2ControlBox1.TabIndex = 63
        '
        'Ffrm_funcionarioMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1142, 784)
        Me.Controls.Add(Me.Guna2ControlBox2)
        Me.Controls.Add(Me.Guna2ControlBox1)
        Me.Controls.Add(Me.lbl_dia)
        Me.Controls.Add(Me.lbl_hora)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.panel_form)
        Me.Controls.Add(Me.lbl_nomeFunc)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Ffrm_funcionarioMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ffrm_funcionarioMenu"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btn_venda As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_cadastroCli As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_estoque As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_sair As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents panel_form As Panel
    Friend WithEvents lbl_nomeFunc As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lbl_dia As Label
    Friend WithEvents lbl_hora As Label
    Friend WithEvents Timer As Timer
    Friend WithEvents Guna2ControlBox2 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
End Class
