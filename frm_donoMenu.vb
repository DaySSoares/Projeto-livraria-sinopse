Public Class frm_donoMenu
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

    Private Sub btn_genEstq_Click(sender As Object, e As EventArgs) Handles btn_genEstq.Click
        Dim frm As New frm_gerenciarProd()
        ChamarForm(frm)
    End Sub

    Private Sub btn_genUsers_Click(sender As Object, e As EventArgs) Handles btn_genUsers.Click
        Dim frm As New frm_gerenciar_user()
        ChamarForm(frm)
    End Sub

    Private Sub btn_sobreVendas_Click(sender As Object, e As EventArgs) Handles btn_sobreVendas.Click
        Dim frm As New frm_relat_vendas()
        ChamarForm(frm)
    End Sub

    Private Sub frm_donoMenu_Load(sender As Object, e As EventArgs) Handles Me.Load
        lbl_hora.Text = DateTime.Now.ToString("HH:mm")
        lbl_dia.Text = DateTime.Now.ToString("dd/MM/yyyy")
        Timer.Start()
        lbl_nomeLogin.Text = lognome

        Dim frm As New frm_donoDashboard()
        ChamarForm(frm)
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        lbl_hora.Text = DateTime.Now.ToString("HH:mm")
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim frm As New frm_donoDashboard()
        ChamarForm(frm)
    End Sub

    Private Sub btn_genrencFunc_Click(sender As Object, e As EventArgs) Handles btn_genrencFunc.Click
        Dim frm As New frm_donoGerenFunc()
        ChamarForm(frm)
    End Sub

End Class