Public Class frm_adm
    Public Sub ChamarForm(ByRef frm As Form)

        For Each ctl As Control In panel_forms.Controls
            If TypeOf ctl Is Form Then
                CType(ctl, Form).Close()
            End If
        Next

        With frm
            .TopLevel = False
            panel_forms.Controls.Add(frm)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btn_genCli_Click(sender As Object, e As EventArgs) Handles btn_genCli.Click
        Dim frm As New frm_gerenciarCli()
        ChamarForm(frm)
    End Sub

    Private Sub btn_genProd_Click(sender As Object, e As EventArgs) Handles btn_genProd.Click
        Dim frm As New frm_gerenciarProd()
        ChamarForm(frm)
    End Sub


    Private Sub btn_genUsers_Click(sender As Object, e As EventArgs) Handles btn_genUsers.Click
        Dim frm As New frm_gerenciar_user()
        ChamarForm(frm)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim frm As New frm_relat_vendas()
        ChamarForm(frm)
    End Sub

    Private Sub frm_adm_Load(sender As Object, e As EventArgs) Handles Me.Load
        lbl_hora.Text = DateTime.Now.ToString("HH:mm")
        lbl_dia.Text = DateTime.Now.ToString("dd/MM/yyyy")
        Timer.Start()

        Dim frm As New frm_relat_vendas()
        ChamarForm(frm)
        lbl_nomeFunc.Text = lognome
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        lbl_hora.Text = DateTime.Now.ToString("HH:mm")
    End Sub

    Private Sub btn_venda_Click(sender As Object, e As EventArgs) Handles btn_venda.Click
        Ffrm_funcionarioMenu.ShowDialog()
    End Sub

    Private Sub btn_genFunc_Click(sender As Object, e As EventArgs) Handles btn_genFunc.Click
        Dim frm As New frm_cadastro_func()
        ChamarForm(frm)
    End Sub

    Private Sub btn_sair_Click(sender As Object, e As EventArgs) Handles btn_sair.Click
        Saida()
    End Sub

    Private Sub Guna2ControlBox1_Click(sender As Object, e As EventArgs) Handles Guna2ControlBox1.Click
        Saida()
    End Sub

End Class