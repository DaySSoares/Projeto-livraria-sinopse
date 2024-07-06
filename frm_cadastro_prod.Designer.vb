<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_cadastro_prod
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btn_buscar = New Guna.UI2.WinForms.Guna2Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_pesquisa = New Guna.UI2.WinForms.Guna2TextBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.dgv_prods = New System.Windows.Forms.DataGridView()
        CType(Me.dgv_prods, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_buscar
        '
        Me.btn_buscar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_buscar.Animated = True
        Me.btn_buscar.BorderRadius = 6
        Me.btn_buscar.CheckedState.Parent = Me.btn_buscar
        Me.btn_buscar.CustomImages.Parent = Me.btn_buscar
        Me.btn_buscar.FillColor = System.Drawing.Color.White
        Me.btn_buscar.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_buscar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.btn_buscar.HoverState.Parent = Me.btn_buscar
        Me.btn_buscar.Location = New System.Drawing.Point(763, 33)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.ShadowDecoration.Parent = Me.btn_buscar
        Me.btn_buscar.Size = New System.Drawing.Size(121, 36)
        Me.btn_buscar.TabIndex = 91
        Me.btn_buscar.Text = "Buscar"
        '
        'Label9
        '
        Me.Label9.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Yu Gothic UI Semilight", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(237, 33)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(190, 30)
        Me.Label9.TabIndex = 90
        Me.Label9.Text = "Pesquisar produtos"
        '
        'txt_pesquisa
        '
        Me.txt_pesquisa.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.txt_pesquisa.Location = New System.Drawing.Point(436, 33)
        Me.txt_pesquisa.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txt_pesquisa.Name = "txt_pesquisa"
        Me.txt_pesquisa.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_pesquisa.PlaceholderText = "Digite o Nome, ID ou Setor"
        Me.txt_pesquisa.SelectedText = ""
        Me.txt_pesquisa.ShadowDecoration.Parent = Me.txt_pesquisa
        Me.txt_pesquisa.Size = New System.Drawing.Size(318, 36)
        Me.txt_pesquisa.TabIndex = 89
        '
        'dgv_prods
        '
        Me.dgv_prods.AllowUserToAddRows = False
        Me.dgv_prods.AllowUserToDeleteRows = False
        Me.dgv_prods.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv_prods.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_prods.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.dgv_prods.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_prods.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgv_prods.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(36, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Yu Gothic UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(36, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_prods.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgv_prods.ColumnHeadersHeight = 35
        Me.dgv_prods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(57, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Yu Gothic UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(209, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_prods.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgv_prods.EnableHeadersVisualStyles = False
        Me.dgv_prods.GridColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.dgv_prods.Location = New System.Drawing.Point(138, 96)
        Me.dgv_prods.Name = "dgv_prods"
        Me.dgv_prods.ReadOnly = True
        Me.dgv_prods.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(57, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Yu Gothic UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(209, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_prods.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgv_prods.RowHeadersVisible = False
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(57, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Yu Gothic UI Semilight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(209, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White
        Me.dgv_prods.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.dgv_prods.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_prods.Size = New System.Drawing.Size(873, 468)
        Me.dgv_prods.TabIndex = 92
        '
        'frm_cadastro_prod
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1118, 585)
        Me.Controls.Add(Me.dgv_prods)
        Me.Controls.Add(Me.txt_pesquisa)
        Me.Controls.Add(Me.btn_buscar)
        Me.Controls.Add(Me.Label9)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_cadastro_prod"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_cadastro_prod"
        CType(Me.dgv_prods, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_buscar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_pesquisa As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents dgv_prods As DataGridView
End Class
