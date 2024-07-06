Public Class frm_admin
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        frm_cadastro_prod.ShowDialog()
    End Sub

    Private Sub frm_admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub EsconderSubMenu()
        If (panel_cadastros.Visible = True) Then
            panel_cadastros.Visible = False
        End If
    End Sub

    Private Sub MostrarSubMenu()
        If (panel_cadastros.Visible = False) Then
            EsconderSubMenu()
            panel_cadastros.Visible = True
        Else
            panel_cadastros.Visible = False
        End If
    End Sub

    Private Sub btn_cadastrar_Click(sender As Object, e As EventArgs) Handles btn_cadastrar.Click
        MostrarSubMenu()
    End Sub
End Class