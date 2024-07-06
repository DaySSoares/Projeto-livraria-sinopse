<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_donoMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_donoMenu))
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2PictureBox2 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btn_genrencFunc = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_sobreVendas = New Guna.UI2.WinForms.Guna2Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2Button5 = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_genUsers = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_genEstq = New Guna.UI2.WinForms.Guna2Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.drag_panel = New System.Windows.Forms.Panel()
        Me.lbl_hora = New System.Windows.Forms.Label()
        Me.lbl_dia = New System.Windows.Forms.Label()
        Me.Guna2CirclePictureBox1 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.lbl_nomeLogin = New System.Windows.Forms.Label()
        Me.Guna2ControlBox2 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.panel_forms = New System.Windows.Forms.Panel()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.drag_panel.SuspendLayout()
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_forms.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 12
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Guna2PictureBox2
        '
        Me.Guna2PictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Guna2PictureBox2.Image = CType(resources.GetObject("Guna2PictureBox2.Image"), System.Drawing.Image)
        Me.Guna2PictureBox2.Location = New System.Drawing.Point(242, 106)
        Me.Guna2PictureBox2.Name = "Guna2PictureBox2"
        Me.Guna2PictureBox2.ShadowDecoration.Parent = Me.Guna2PictureBox2
        Me.Guna2PictureBox2.Size = New System.Drawing.Size(473, 339)
        Me.Guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.Guna2PictureBox2.TabIndex = 53
        Me.Guna2PictureBox2.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Panel2.Controls.Add(Me.btn_genrencFunc)
        Me.Panel2.Controls.Add(Me.btn_sobreVendas)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Guna2Button5)
        Me.Panel2.Controls.Add(Me.btn_genUsers)
        Me.Panel2.Controls.Add(Me.btn_genEstq)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.MenuStrip1)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(229, 663)
        Me.Panel2.TabIndex = 55
        '
        'btn_genrencFunc
        '
        Me.btn_genrencFunc.BorderRadius = 8
        Me.btn_genrencFunc.CheckedState.Parent = Me.btn_genrencFunc
        Me.btn_genrencFunc.CustomImages.Parent = Me.btn_genrencFunc
        Me.btn_genrencFunc.FillColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.btn_genrencFunc.Font = New System.Drawing.Font("Yu Gothic UI Semilight", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_genrencFunc.ForeColor = System.Drawing.Color.White
        Me.btn_genrencFunc.HoverState.Parent = Me.btn_genrencFunc
        Me.btn_genrencFunc.Image = CType(resources.GetObject("btn_genrencFunc.Image"), System.Drawing.Image)
        Me.btn_genrencFunc.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btn_genrencFunc.Location = New System.Drawing.Point(12, 308)
        Me.btn_genrencFunc.Name = "btn_genrencFunc"
        Me.btn_genrencFunc.ShadowDecoration.Parent = Me.btn_genrencFunc
        Me.btn_genrencFunc.Size = New System.Drawing.Size(205, 43)
        Me.btn_genrencFunc.TabIndex = 7
        Me.btn_genrencFunc.Text = "  Gerenciar Funcionários"
        Me.btn_genrencFunc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'btn_sobreVendas
        '
        Me.btn_sobreVendas.BorderRadius = 8
        Me.btn_sobreVendas.CheckedState.Parent = Me.btn_sobreVendas
        Me.btn_sobreVendas.CustomImages.Parent = Me.btn_sobreVendas
        Me.btn_sobreVendas.FillColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.btn_sobreVendas.Font = New System.Drawing.Font("Yu Gothic UI Semilight", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_sobreVendas.ForeColor = System.Drawing.Color.White
        Me.btn_sobreVendas.HoverState.Parent = Me.btn_sobreVendas
        Me.btn_sobreVendas.Image = CType(resources.GetObject("btn_sobreVendas.Image"), System.Drawing.Image)
        Me.btn_sobreVendas.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btn_sobreVendas.Location = New System.Drawing.Point(12, 357)
        Me.btn_sobreVendas.Name = "btn_sobreVendas"
        Me.btn_sobreVendas.ShadowDecoration.Parent = Me.btn_sobreVendas
        Me.btn_sobreVendas.Size = New System.Drawing.Size(205, 43)
        Me.btn_sobreVendas.TabIndex = 6
        Me.btn_sobreVendas.Text = "  Sobre Vendas"
        Me.btn_sobreVendas.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Yu Gothic UI Semilight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(25, 162)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 25)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Dono"
        '
        'Guna2Button5
        '
        Me.Guna2Button5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Guna2Button5.BorderRadius = 8
        Me.Guna2Button5.CheckedState.Parent = Me.Guna2Button5
        Me.Guna2Button5.CustomImages.Parent = Me.Guna2Button5
        Me.Guna2Button5.FillColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Guna2Button5.Font = New System.Drawing.Font("Yu Gothic UI Semilight", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button5.ForeColor = System.Drawing.Color.White
        Me.Guna2Button5.HoverState.Parent = Me.Guna2Button5
        Me.Guna2Button5.Image = CType(resources.GetObject("Guna2Button5.Image"), System.Drawing.Image)
        Me.Guna2Button5.Location = New System.Drawing.Point(12, 607)
        Me.Guna2Button5.Name = "Guna2Button5"
        Me.Guna2Button5.ShadowDecoration.Parent = Me.Guna2Button5
        Me.Guna2Button5.Size = New System.Drawing.Size(205, 43)
        Me.Guna2Button5.TabIndex = 3
        Me.Guna2Button5.Text = "  Sair"
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
        Me.btn_genUsers.Location = New System.Drawing.Point(12, 259)
        Me.btn_genUsers.Name = "btn_genUsers"
        Me.btn_genUsers.ShadowDecoration.Parent = Me.btn_genUsers
        Me.btn_genUsers.Size = New System.Drawing.Size(205, 43)
        Me.btn_genUsers.TabIndex = 2
        Me.btn_genUsers.Text = "  Gerenciar Usuários"
        Me.btn_genUsers.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'btn_genEstq
        '
        Me.btn_genEstq.BorderRadius = 8
        Me.btn_genEstq.CheckedState.Parent = Me.btn_genEstq
        Me.btn_genEstq.CustomImages.Parent = Me.btn_genEstq
        Me.btn_genEstq.FillColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.btn_genEstq.Font = New System.Drawing.Font("Yu Gothic UI Semilight", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_genEstq.ForeColor = System.Drawing.Color.White
        Me.btn_genEstq.HoverState.Parent = Me.btn_genEstq
        Me.btn_genEstq.Image = CType(resources.GetObject("btn_genEstq.Image"), System.Drawing.Image)
        Me.btn_genEstq.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btn_genEstq.Location = New System.Drawing.Point(12, 210)
        Me.btn_genEstq.Name = "btn_genEstq"
        Me.btn_genEstq.ShadowDecoration.Parent = Me.btn_genEstq
        Me.btn_genEstq.Size = New System.Drawing.Size(205, 43)
        Me.btn_genEstq.TabIndex = 2
        Me.btn_genEstq.Text = "  Gerenciar Estoque"
        Me.btn_genEstq.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
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
        'drag_panel
        '
        Me.drag_panel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.drag_panel.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.drag_panel.Controls.Add(Me.lbl_hora)
        Me.drag_panel.Controls.Add(Me.lbl_dia)
        Me.drag_panel.Controls.Add(Me.Guna2CirclePictureBox1)
        Me.drag_panel.Controls.Add(Me.lbl_nomeLogin)
        Me.drag_panel.Controls.Add(Me.Guna2ControlBox2)
        Me.drag_panel.Controls.Add(Me.Guna2ControlBox1)
        Me.drag_panel.Location = New System.Drawing.Point(226, 0)
        Me.drag_panel.Name = "drag_panel"
        Me.drag_panel.Size = New System.Drawing.Size(933, 52)
        Me.drag_panel.TabIndex = 56
        '
        'lbl_hora
        '
        Me.lbl_hora.AutoSize = True
        Me.lbl_hora.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_hora.ForeColor = System.Drawing.Color.White
        Me.lbl_hora.Location = New System.Drawing.Point(142, 7)
        Me.lbl_hora.Name = "lbl_hora"
        Me.lbl_hora.Size = New System.Drawing.Size(60, 30)
        Me.lbl_hora.TabIndex = 66
        Me.lbl_hora.Text = "Hora"
        '
        'lbl_dia
        '
        Me.lbl_dia.AutoSize = True
        Me.lbl_dia.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_dia.ForeColor = System.Drawing.Color.White
        Me.lbl_dia.Location = New System.Drawing.Point(18, 8)
        Me.lbl_dia.Name = "lbl_dia"
        Me.lbl_dia.Size = New System.Drawing.Size(44, 30)
        Me.lbl_dia.TabIndex = 65
        Me.lbl_dia.Text = "Dia"
        '
        'Guna2CirclePictureBox1
        '
        Me.Guna2CirclePictureBox1.Image = CType(resources.GetObject("Guna2CirclePictureBox1.Image"), System.Drawing.Image)
        Me.Guna2CirclePictureBox1.Location = New System.Drawing.Point(595, 11)
        Me.Guna2CirclePictureBox1.Name = "Guna2CirclePictureBox1"
        Me.Guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CirclePictureBox1.ShadowDecoration.Parent = Me.Guna2CirclePictureBox1
        Me.Guna2CirclePictureBox1.Size = New System.Drawing.Size(35, 32)
        Me.Guna2CirclePictureBox1.TabIndex = 48
        Me.Guna2CirclePictureBox1.TabStop = False
        '
        'lbl_nomeLogin
        '
        Me.lbl_nomeLogin.AutoSize = True
        Me.lbl_nomeLogin.Font = New System.Drawing.Font("Yu Gothic UI Semilight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nomeLogin.ForeColor = System.Drawing.Color.White
        Me.lbl_nomeLogin.Location = New System.Drawing.Point(636, 12)
        Me.lbl_nomeLogin.Name = "lbl_nomeLogin"
        Me.lbl_nomeLogin.Size = New System.Drawing.Size(104, 25)
        Me.lbl_nomeLogin.TabIndex = 5
        Me.lbl_nomeLogin.Text = "Perfil Dono"
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
        Me.Guna2ControlBox2.Location = New System.Drawing.Point(841, 11)
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
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(877, 11)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.ShadowDecoration.Parent = Me.Guna2ControlBox1
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(30, 26)
        Me.Guna2ControlBox1.TabIndex = 46
        '
        'panel_forms
        '
        Me.panel_forms.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panel_forms.BackColor = System.Drawing.Color.White
        Me.panel_forms.Controls.Add(Me.Guna2PictureBox2)
        Me.panel_forms.Location = New System.Drawing.Point(229, 52)
        Me.panel_forms.Name = "panel_forms"
        Me.panel_forms.Size = New System.Drawing.Size(915, 608)
        Me.panel_forms.TabIndex = 57
        '
        'Timer
        '
        Me.Timer.Enabled = True
        Me.Timer.Interval = 6000
        '
        'frm_donoMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1145, 660)
        Me.Controls.Add(Me.panel_forms)
        Me.Controls.Add(Me.drag_panel)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_donoMenu"
        Me.Text = "frm_donoMenu"
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.drag_panel.ResumeLayout(False)
        Me.drag_panel.PerformLayout()
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_forms.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2PictureBox2 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btn_sobreVendas As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2Button5 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_genUsers As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_genEstq As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents drag_panel As Panel
    Friend WithEvents Guna2CirclePictureBox1 As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents lbl_nomeLogin As Label
    Friend WithEvents Guna2ControlBox2 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents panel_forms As Panel
    Friend WithEvents btn_genrencFunc As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lbl_hora As Label
    Friend WithEvents lbl_dia As Label
    Friend WithEvents Timer As Timer
End Class
