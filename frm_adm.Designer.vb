<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_adm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_adm))
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_genFunc = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_venda = New Guna.UI2.WinForms.Guna2Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_sair = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_genUsers = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_genProd = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_genCli = New Guna.UI2.WinForms.Guna2Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.Guna2ControlBox2 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.drag_panel = New System.Windows.Forms.Panel()
        Me.lbl_hora = New System.Windows.Forms.Label()
        Me.lbl_dia = New System.Windows.Forms.Label()
        Me.Guna2CirclePictureBox1 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.lbl_nomeFunc = New System.Windows.Forms.Label()
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.panel_forms = New System.Windows.Forms.Panel()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.drag_panel.SuspendLayout()
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 12
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btn_genFunc)
        Me.Panel1.Controls.Add(Me.btn_venda)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btn_sair)
        Me.Panel1.Controls.Add(Me.btn_genUsers)
        Me.Panel1.Controls.Add(Me.btn_genProd)
        Me.Panel1.Controls.Add(Me.btn_genCli)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.MenuStrip1)
        Me.Panel1.Location = New System.Drawing.Point(0, -2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(229, 663)
        Me.Panel1.TabIndex = 0
        '
        'btn_genFunc
        '
        Me.btn_genFunc.BorderRadius = 8
        Me.btn_genFunc.CheckedState.Parent = Me.btn_genFunc
        Me.btn_genFunc.CustomImages.Parent = Me.btn_genFunc
        Me.btn_genFunc.FillColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.btn_genFunc.Font = New System.Drawing.Font("Yu Gothic UI Semilight", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_genFunc.ForeColor = System.Drawing.Color.White
        Me.btn_genFunc.HoverState.Parent = Me.btn_genFunc
        Me.btn_genFunc.Image = CType(resources.GetObject("btn_genFunc.Image"), System.Drawing.Image)
        Me.btn_genFunc.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btn_genFunc.Location = New System.Drawing.Point(12, 363)
        Me.btn_genFunc.Name = "btn_genFunc"
        Me.btn_genFunc.ShadowDecoration.Parent = Me.btn_genFunc
        Me.btn_genFunc.Size = New System.Drawing.Size(205, 43)
        Me.btn_genFunc.TabIndex = 9
        Me.btn_genFunc.Text = "  Gerenciar Func."
        Me.btn_genFunc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'btn_venda
        '
        Me.btn_venda.BorderRadius = 8
        Me.btn_venda.CheckedState.Parent = Me.btn_venda
        Me.btn_venda.CustomImages.Parent = Me.btn_venda
        Me.btn_venda.FillColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.btn_venda.Font = New System.Drawing.Font("Yu Gothic UI Semilight", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_venda.ForeColor = System.Drawing.Color.White
        Me.btn_venda.HoverState.Parent = Me.btn_venda
        Me.btn_venda.Image = CType(resources.GetObject("btn_venda.Image"), System.Drawing.Image)
        Me.btn_venda.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btn_venda.Location = New System.Drawing.Point(12, 412)
        Me.btn_venda.Name = "btn_venda"
        Me.btn_venda.ShadowDecoration.Parent = Me.btn_venda
        Me.btn_venda.Size = New System.Drawing.Size(205, 43)
        Me.btn_venda.TabIndex = 8
        Me.btn_venda.Text = "  Realizar Venda"
        Me.btn_venda.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Yu Gothic UI Semilight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(25, 162)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(174, 25)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Perfil Administrador"
        '
        'btn_sair
        '
        Me.btn_sair.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_sair.BorderRadius = 8
        Me.btn_sair.CheckedState.Parent = Me.btn_sair
        Me.btn_sair.CustomImages.Parent = Me.btn_sair
        Me.btn_sair.FillColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.btn_sair.Font = New System.Drawing.Font("Yu Gothic UI Semilight", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_sair.ForeColor = System.Drawing.Color.White
        Me.btn_sair.HoverState.Parent = Me.btn_sair
        Me.btn_sair.Image = CType(resources.GetObject("btn_sair.Image"), System.Drawing.Image)
        Me.btn_sair.Location = New System.Drawing.Point(12, 607)
        Me.btn_sair.Name = "btn_sair"
        Me.btn_sair.ShadowDecoration.Parent = Me.btn_sair
        Me.btn_sair.Size = New System.Drawing.Size(205, 43)
        Me.btn_sair.TabIndex = 3
        Me.btn_sair.Text = "  Sair"
        '
        'btn_genUsers
        '
        Me.btn_genUsers.BorderRadius = 8
        Me.btn_genUsers.CheckedState.Parent = Me.btn_genUsers
        Me.btn_genUsers.CustomImages.Parent = Me.btn_genUsers
        Me.btn_genUsers.FillColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.btn_genUsers.Font = New System.Drawing.Font("Yu Gothic UI Semilight", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_genUsers.ForeColor = System.Drawing.Color.White
        Me.btn_genUsers.HoverState.Parent = Me.btn_genUsers
        Me.btn_genUsers.Image = CType(resources.GetObject("btn_genUsers.Image"), System.Drawing.Image)
        Me.btn_genUsers.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btn_genUsers.Location = New System.Drawing.Point(13, 314)
        Me.btn_genUsers.Name = "btn_genUsers"
        Me.btn_genUsers.ShadowDecoration.Parent = Me.btn_genUsers
        Me.btn_genUsers.Size = New System.Drawing.Size(205, 43)
        Me.btn_genUsers.TabIndex = 2
        Me.btn_genUsers.Text = "  Gerenciar Usuários"
        Me.btn_genUsers.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'btn_genProd
        '
        Me.btn_genProd.BorderRadius = 8
        Me.btn_genProd.CheckedState.Parent = Me.btn_genProd
        Me.btn_genProd.CustomImages.Parent = Me.btn_genProd
        Me.btn_genProd.FillColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.btn_genProd.Font = New System.Drawing.Font("Yu Gothic UI Semilight", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_genProd.ForeColor = System.Drawing.Color.White
        Me.btn_genProd.HoverState.Parent = Me.btn_genProd
        Me.btn_genProd.Image = CType(resources.GetObject("btn_genProd.Image"), System.Drawing.Image)
        Me.btn_genProd.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btn_genProd.Location = New System.Drawing.Point(13, 265)
        Me.btn_genProd.Name = "btn_genProd"
        Me.btn_genProd.ShadowDecoration.Parent = Me.btn_genProd
        Me.btn_genProd.Size = New System.Drawing.Size(205, 43)
        Me.btn_genProd.TabIndex = 2
        Me.btn_genProd.Text = "  Gerenciar Produtos"
        Me.btn_genProd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'btn_genCli
        '
        Me.btn_genCli.BorderRadius = 8
        Me.btn_genCli.CheckedState.Parent = Me.btn_genCli
        Me.btn_genCli.CustomImages.Parent = Me.btn_genCli
        Me.btn_genCli.FillColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.btn_genCli.Font = New System.Drawing.Font("Yu Gothic UI Semilight", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_genCli.ForeColor = System.Drawing.Color.White
        Me.btn_genCli.HoverState.Parent = Me.btn_genCli
        Me.btn_genCli.Image = CType(resources.GetObject("btn_genCli.Image"), System.Drawing.Image)
        Me.btn_genCli.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btn_genCli.Location = New System.Drawing.Point(12, 216)
        Me.btn_genCli.Name = "btn_genCli"
        Me.btn_genCli.ShadowDecoration.Parent = Me.btn_genCli
        Me.btn_genCli.Size = New System.Drawing.Size(205, 43)
        Me.btn_genCli.TabIndex = 1
        Me.btn_genCli.Text = "  Gerenciar Clientes"
        Me.btn_genCli.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-11, -47)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(240, 194)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(229, 24)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
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
        Me.Guna2ControlBox2.Location = New System.Drawing.Point(843, 11)
        Me.Guna2ControlBox2.Name = "Guna2ControlBox2"
        Me.Guna2ControlBox2.ShadowDecoration.Parent = Me.Guna2ControlBox2
        Me.Guna2ControlBox2.Size = New System.Drawing.Size(30, 26)
        Me.Guna2ControlBox2.TabIndex = 47
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
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(879, 11)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.ShadowDecoration.Parent = Me.Guna2ControlBox1
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(30, 26)
        Me.Guna2ControlBox1.TabIndex = 46
        '
        'drag_panel
        '
        Me.drag_panel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.drag_panel.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.drag_panel.Controls.Add(Me.lbl_hora)
        Me.drag_panel.Controls.Add(Me.lbl_dia)
        Me.drag_panel.Controls.Add(Me.Guna2CirclePictureBox1)
        Me.drag_panel.Controls.Add(Me.lbl_nomeFunc)
        Me.drag_panel.Controls.Add(Me.Guna2ControlBox2)
        Me.drag_panel.Controls.Add(Me.Guna2ControlBox1)
        Me.drag_panel.Location = New System.Drawing.Point(224, -2)
        Me.drag_panel.Name = "drag_panel"
        Me.drag_panel.Size = New System.Drawing.Size(927, 46)
        Me.drag_panel.TabIndex = 48
        '
        'lbl_hora
        '
        Me.lbl_hora.AutoSize = True
        Me.lbl_hora.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_hora.ForeColor = System.Drawing.Color.White
        Me.lbl_hora.Location = New System.Drawing.Point(135, 7)
        Me.lbl_hora.Name = "lbl_hora"
        Me.lbl_hora.Size = New System.Drawing.Size(60, 30)
        Me.lbl_hora.TabIndex = 64
        Me.lbl_hora.Text = "Hora"
        '
        'lbl_dia
        '
        Me.lbl_dia.AutoSize = True
        Me.lbl_dia.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_dia.ForeColor = System.Drawing.Color.White
        Me.lbl_dia.Location = New System.Drawing.Point(11, 8)
        Me.lbl_dia.Name = "lbl_dia"
        Me.lbl_dia.Size = New System.Drawing.Size(44, 30)
        Me.lbl_dia.TabIndex = 63
        Me.lbl_dia.Text = "Dia"
        '
        'Guna2CirclePictureBox1
        '
        Me.Guna2CirclePictureBox1.Image = CType(resources.GetObject("Guna2CirclePictureBox1.Image"), System.Drawing.Image)
        Me.Guna2CirclePictureBox1.Location = New System.Drawing.Point(600, 9)
        Me.Guna2CirclePictureBox1.Name = "Guna2CirclePictureBox1"
        Me.Guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CirclePictureBox1.ShadowDecoration.Parent = Me.Guna2CirclePictureBox1
        Me.Guna2CirclePictureBox1.Size = New System.Drawing.Size(28, 31)
        Me.Guna2CirclePictureBox1.TabIndex = 48
        Me.Guna2CirclePictureBox1.TabStop = False
        '
        'lbl_nomeFunc
        '
        Me.lbl_nomeFunc.AutoSize = True
        Me.lbl_nomeFunc.Font = New System.Drawing.Font("Yu Gothic UI Semilight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nomeFunc.ForeColor = System.Drawing.Color.White
        Me.lbl_nomeFunc.Location = New System.Drawing.Point(634, 12)
        Me.lbl_nomeFunc.Name = "lbl_nomeFunc"
        Me.lbl_nomeFunc.Size = New System.Drawing.Size(174, 25)
        Me.lbl_nomeFunc.TabIndex = 5
        Me.lbl_nomeFunc.Text = "Perfil Administrador"
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.TargetControl = Me.drag_panel
        '
        'panel_forms
        '
        Me.panel_forms.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panel_forms.BackColor = System.Drawing.Color.White
        Me.panel_forms.Location = New System.Drawing.Point(227, 44)
        Me.panel_forms.Name = "panel_forms"
        Me.panel_forms.Size = New System.Drawing.Size(921, 617)
        Me.panel_forms.TabIndex = 49
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'Timer
        '
        Me.Timer.Enabled = True
        Me.Timer.Interval = 60000
        '
        'frm_adm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1145, 660)
        Me.Controls.Add(Me.panel_forms)
        Me.Controls.Add(Me.drag_panel)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frm_adm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_adm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.drag_panel.ResumeLayout(False)
        Me.drag_panel.PerformLayout()
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btn_sair As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_genUsers As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_genProd As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_genCli As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents drag_panel As Panel
    Friend WithEvents Guna2ControlBox2 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2CirclePictureBox1 As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents lbl_nomeFunc As Label
    Friend WithEvents panel_forms As Panel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents btn_genFunc As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_venda As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lbl_dia As Label
    Friend WithEvents lbl_hora As Label
    Friend WithEvents Timer As Timer
End Class
