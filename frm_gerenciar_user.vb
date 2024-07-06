Imports System.Data.SqlClient

Public Class frm_gerenciar_user

    Private Sub btn_cadastrar_Click(sender As Object, e As EventArgs) Handles btn_cadastrar.Click
        NovoUser()
    End Sub

    Private Sub PegarDados()
        Try
            Using conn = New SqlConnection(connStr)
                conn.Open()

                Dim sql = "select * from tb_usuarios where cpf=@cpf"
                Using cmd = New SqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@cpf", txt_cpf.Text)
                    dr = cmd.ExecuteReader 'Recebe os dados do comando
                    If dr.Read Then 'Se existir o cpf
                        txt_user.Text = dr("usuario")
                        cmb_cargo.Text = dr("cargo")
                        btn_editar.Visible = True
                        btn_cadastrar.Visible = False
                    End If
                End Using
            End Using
        Catch ex As Exception

        End Try
    End Sub

    Private Sub NovoUser()
        Try
            Using conn = New SqlConnection(connStr)
                conn.Open()
                Dim sqlCheck = "select * from tb_usuarios where cpf=@cpf"
                Using cmdCheck = New SqlCommand(sqlCheck, conn)
                    cmdCheck.Parameters.AddWithValue("@cpf", txt_cpf.Text)

                    If txt_senha.Text = txt_confirmSenha.Text Then
                        Using dr = cmdCheck.ExecuteReader
                            If dr.HasRows Then
                                MsgBox("Usuário já cadastrado!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
                                PegarDados()
                            Else
                                dr.Close()

                                Dim sql = "insert into tb_usuarios (cpf, usuario, senha, cargo) values (@cpf, @user, @senha, @cargo)"
                                Using cmd = New SqlCommand(sql, conn)
                                    cmd.Parameters.AddWithValue("@cpf", txt_cpf.Text)
                                    cmd.Parameters.AddWithValue("@user", txt_user.Text)
                                    cmd.Parameters.AddWithValue("@cargo", cmb_cargo.Text)
                                    cmd.Parameters.AddWithValue("@senha", txt_senha.Text)
                                    cmd.ExecuteNonQuery()
                                    MsgBox("Usuário cadastrado com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
                                End Using
                            End If
                        End Using
                    Else
                        MsgBox("Senhas não Compativeis!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
                        txt_confirmSenha.Clear()
                        txt_confirmSenha.Focus()
                    End If

                End Using
            End Using
        Catch ex As Exception
            MsgBox("Algo deu errado!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub LimparCampos()
        txt_cpf.Clear()
        txt_user.Clear()
        txt_senha.Clear()
        txt_confirmSenha.Clear()
        cmb_cargo.SelectedIndex = -1
    End Sub

    Private Sub EditarUser()
        Try
            Using conn = New SqlConnection(connStr)
                conn.Open()

                Dim sql = "update tb_usuarios set cpf=@cpf, usuario=@user, senha=@senha, cargo=@cargo where cpf=@cpf"
                Using cmd = New SqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@cpf", txt_cpf.Text)
                    cmd.Parameters.AddWithValue("@user", txt_user.Text)
                    cmd.Parameters.AddWithValue("@cargo", cmb_cargo.Text)
                    cmd.Parameters.AddWithValue("@senha", txt_senha.Text)
                    cmd.ExecuteNonQuery()
                    MsgBox("Dados alterados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
                    btn_editar.Visible = False
                    btn_cadastrar.Visible = True
                    LimparCampos()
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Algo deu errado!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub frm_gerenciar_user_Load(sender As Object, e As EventArgs) Handles Me.Load
        CarregarUser()
    End Sub

    Private Sub CarregarUser()
        Try
            Using conn = New SqlConnection(connStr)
                conn.Open()

                Dim sql = "select cpf, usuario, cargo from tb_usuarios"

                Using cmd = New SqlCommand(sql, conn)
                    da = New SqlDataAdapter(sql, conn)
                    Dim ds As New DataSet
                    da.Fill(ds)

                    dgv_users.DataSource = ds.Tables(0)
                    dgv_users.Columns("cpf").HeaderText = "CPF"
                    dgv_users.Columns("usuario").HeaderText = "USUÁRIO"
                    dgv_users.Columns("cargo").HeaderText = "CARGO"
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Algo deu errado!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Private Sub btn_excluir_Click(sender As Object, e As EventArgs) Handles btn_excluir.Click
        Dim msg As String = MsgBox("Certeza que deseja excluir o cpf: " & txt_cpf.Text, MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÂO")
        Try
            Using conn = New SqlConnection(connStr)
                conn.Open()
                If msg = vbYes Then
                    Dim sql = "delete from tb_usuarios where cpf=@cpf"
                    Using cmd = New SqlCommand(sql, conn)
                        cmd.Parameters.AddWithValue("@cpf", txt_cpf.Text)
                        cmd.ExecuteNonQuery()
                        MsgBox("Usuários deletado!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                    End Using
                End If
            End Using
        Catch ex As Exception
            MsgBox("Algo deu errado!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Private Sub btn_editar_Click(sender As Object, e As EventArgs) Handles btn_editar.Click
        EditarUser()
    End Sub

    Private Sub txt_cpf_TextChanged(sender As Object, e As EventArgs) Handles txt_cpf.TextChanged
        'Máscara para o CPF
        Dim cpf As String = txt_cpf.Text.Replace(".", "").Replace("-", "").Trim()

        ' Verifica se o CPF está vazio ou tem mais de 11 caracteres
        If cpf.Length = 0 OrElse cpf.Length > 11 Then
            txt_cpf.Text = ""
            Exit Sub
        End If

        ' Aplica a máscara do CPF
        If cpf.Length > 3 Then
            cpf = cpf.Insert(3, ".")
        End If
        If cpf.Length > 7 Then
            cpf = cpf.Insert(7, ".")
        End If
        If cpf.Length > 11 Then
            cpf = cpf.Insert(11, "-")
        End If

        txt_cpf.Text = cpf
        txt_cpf.SelectionStart = txt_cpf.Text.Length ' Coloca o cursor no final do texto
    End Sub
End Class