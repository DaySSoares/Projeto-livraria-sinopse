<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_cadastro_clientes
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
        Me.txt_cpf = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmb_data_nasc = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_nome = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_tel = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_email = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btn_voltar = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_cadastrar = New Guna.UI2.WinForms.Guna2Button()
        Me.lbl_nomeFunc = New System.Windows.Forms.Label()
        Me.SuspendLayout()
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
        Me.txt_cpf.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_cpf.HoverState.Parent = Me.txt_cpf
        Me.txt_cpf.Location = New System.Drawing.Point(358, 159)
        Me.txt_cpf.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_cpf.Name = "txt_cpf"
        Me.txt_cpf.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_cpf.PlaceholderText = "000.000.000-00"
        Me.txt_cpf.SelectedText = ""
        Me.txt_cpf.ShadowDecoration.Parent = Me.txt_cpf
        Me.txt_cpf.Size = New System.Drawing.Size(144, 36)
        Me.txt_cpf.TabIndex = 1
        Me.txt_cpf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Yu Gothic UI Semilight", 14.25!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(354, 131)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 25)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "CPF"
        '
        'cmb_data_nasc
        '
        Me.cmb_data_nasc.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.cmb_data_nasc.BorderRadius = 7
        Me.cmb_data_nasc.CheckedState.Parent = Me.cmb_data_nasc
        Me.cmb_data_nasc.FillColor = System.Drawing.Color.White
        Me.cmb_data_nasc.Font = New System.Drawing.Font("Yu Gothic UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_data_nasc.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.cmb_data_nasc.HoverState.Parent = Me.cmb_data_nasc
        Me.cmb_data_nasc.Location = New System.Drawing.Point(530, 159)
        Me.cmb_data_nasc.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.cmb_data_nasc.MinDate = New Date(1920, 1, 1, 0, 0, 0, 0)
        Me.cmb_data_nasc.Name = "cmb_data_nasc"
        Me.cmb_data_nasc.ShadowDecoration.Parent = Me.cmb_data_nasc
        Me.cmb_data_nasc.Size = New System.Drawing.Size(239, 36)
        Me.cmb_data_nasc.TabIndex = 5
        Me.cmb_data_nasc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.cmb_data_nasc.Value = New Date(2000, 1, 1, 0, 0, 0, 0)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Yu Gothic UI Semilight", 14.25!)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(534, 131)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(207, 25)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "DATA DE NASCIMENTO"
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
        Me.txt_nome.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_nome.HoverState.Parent = Me.txt_nome
        Me.txt_nome.Location = New System.Drawing.Point(358, 238)
        Me.txt_nome.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_nome.Name = "txt_nome"
        Me.txt_nome.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_nome.PlaceholderText = ""
        Me.txt_nome.SelectedText = ""
        Me.txt_nome.ShadowDecoration.Parent = Me.txt_nome
        Me.txt_nome.Size = New System.Drawing.Size(411, 36)
        Me.txt_nome.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Yu Gothic UI Semilight", 14.25!)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(353, 210)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(166, 25)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "NOME COMPLETO"
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
        Me.txt_tel.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_tel.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_tel.HoverState.Parent = Me.txt_tel
        Me.txt_tel.Location = New System.Drawing.Point(358, 325)
        Me.txt_tel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_tel.Name = "txt_tel"
        Me.txt_tel.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_tel.PlaceholderText = "11 99999-9999"
        Me.txt_tel.SelectedText = ""
        Me.txt_tel.ShadowDecoration.Parent = Me.txt_tel
        Me.txt_tel.Size = New System.Drawing.Size(119, 36)
        Me.txt_tel.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Yu Gothic UI Semilight", 14.25!)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(353, 297)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 25)
        Me.Label6.TabIndex = 46
        Me.Label6.Text = "TELEFONE"
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
        Me.txt_email.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_email.HoverState.Parent = Me.txt_email
        Me.txt_email.Location = New System.Drawing.Point(483, 325)
        Me.txt_email.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_email.PlaceholderText = ""
        Me.txt_email.SelectedText = ""
        Me.txt_email.ShadowDecoration.Parent = Me.txt_email
        Me.txt_email.Size = New System.Drawing.Size(286, 36)
        Me.txt_email.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Yu Gothic UI Semilight", 14.25!)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label7.Location = New System.Drawing.Point(478, 297)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 25)
        Me.Label7.TabIndex = 48
        Me.Label7.Text = "EMAIL"
        '
        'btn_voltar
        '
        Me.btn_voltar.Animated = True
        Me.btn_voltar.BorderRadius = 6
        Me.btn_voltar.CheckedState.Parent = Me.btn_voltar
        Me.btn_voltar.CustomImages.Parent = Me.btn_voltar
        Me.btn_voltar.FillColor = System.Drawing.Color.White
        Me.btn_voltar.Font = New System.Drawing.Font("Yu Gothic UI Semilight", 14.25!)
        Me.btn_voltar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.btn_voltar.HoverState.Parent = Me.btn_voltar
        Me.btn_voltar.Location = New System.Drawing.Point(586, 388)
        Me.btn_voltar.Name = "btn_voltar"
        Me.btn_voltar.ShadowDecoration.Parent = Me.btn_voltar
        Me.btn_voltar.Size = New System.Drawing.Size(150, 45)
        Me.btn_voltar.TabIndex = 51
        Me.btn_voltar.Text = "VOLTAR"
        '
        'btn_cadastrar
        '
        Me.btn_cadastrar.Animated = True
        Me.btn_cadastrar.BorderRadius = 6
        Me.btn_cadastrar.CheckedState.Parent = Me.btn_cadastrar
        Me.btn_cadastrar.CustomImages.Parent = Me.btn_cadastrar
        Me.btn_cadastrar.FillColor = System.Drawing.Color.White
        Me.btn_cadastrar.Font = New System.Drawing.Font("Yu Gothic UI Semilight", 14.25!)
        Me.btn_cadastrar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.btn_cadastrar.HoverState.Parent = Me.btn_cadastrar
        Me.btn_cadastrar.Location = New System.Drawing.Point(381, 388)
        Me.btn_cadastrar.Name = "btn_cadastrar"
        Me.btn_cadastrar.ShadowDecoration.Parent = Me.btn_cadastrar
        Me.btn_cadastrar.Size = New System.Drawing.Size(199, 45)
        Me.btn_cadastrar.TabIndex = 50
        Me.btn_cadastrar.Text = "CADASTRAR"
        '
        'lbl_nomeFunc
        '
        Me.lbl_nomeFunc.AutoSize = True
        Me.lbl_nomeFunc.Font = New System.Drawing.Font("Yu Gothic UI Semilight", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nomeFunc.ForeColor = System.Drawing.Color.White
        Me.lbl_nomeFunc.Location = New System.Drawing.Point(22, 18)
        Me.lbl_nomeFunc.Name = "lbl_nomeFunc"
        Me.lbl_nomeFunc.Size = New System.Drawing.Size(179, 40)
        Me.lbl_nomeFunc.TabIndex = 59
        Me.lbl_nomeFunc.Text = "Novo Cliente"
        '
        'frm_cadastro_clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1118, 585)
        Me.Controls.Add(Me.lbl_nomeFunc)
        Me.Controls.Add(Me.btn_voltar)
        Me.Controls.Add(Me.btn_cadastrar)
        Me.Controls.Add(Me.txt_email)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_tel)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_nome)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmb_data_nasc)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_cpf)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_cadastro_clientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_cadastro_clientes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_cpf As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmb_data_nasc As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_nome As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_tel As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_email As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btn_voltar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_cadastrar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lbl_nomeFunc As Label
End Class
