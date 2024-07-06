Public Class Ffrm_funcionarioMenu
    Public Sub ChamarForm(ByRef frm As Form)

        For Each ctl As Control In panel_form.Controls
            If TypeOf ctl Is Form Then
                CType(ctl, Form).Close()
            End If
        Next

        With frm
            .TopLevel = False
            panel_form.Controls.Add(frm)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btn_estoque_Click(sender As Object, e As EventArgs) Handles btn_estoque.Click
        Dim frm As New frm_cadastro_prod()
        ChamarForm(frm)
    End Sub

    Private Sub btn_venda_Click(sender As Object, e As EventArgs) Handles btn_venda.Click
        Dim frm As New frm_Vendas()
        ChamarForm(frm)
    End Sub

    Private Sub btn_cadastroCli_Click(sender As Object, e As EventArgs) Handles btn_cadastroCli.Click
        Dim frm As New frm_cadastro_clientes
        ChamarForm(frm)
    End Sub

    Private Sub btn_sair_Click(sender As Object, e As EventArgs) Handles btn_sair.Click
        Saida()
    End Sub

    Private Sub Ffrm_funcionarioMenu_Load(sender As Object, e As EventArgs) Handles Me.Load
        lbl_nomeFunc.Text = lognome
        lbl_hora.Text = DateTime.Now.ToString("HH:mm")
        lbl_dia.Text = DateTime.Now.ToString("dd/MM/yyyy")
        Timer.Start()

        Dim frm As New frm_Vendas()
        ChamarForm(frm)
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        lbl_hora.Text = DateTime.Now.ToString("HH:mm")
    End Sub
End Class