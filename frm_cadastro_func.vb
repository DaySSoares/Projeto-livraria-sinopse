
Imports System.Data.SqlClient
Public Class frm_cadastro_func

    Private Sub txt_tel_TextChanged(sender As Object, e As EventArgs) Handles txt_tel.TextChanged
        'Máscara para o Telefone
        Dim tel As String = txt_tel.Text.Replace(" ", "").Replace("-", "").Trim()

        If tel.Length = 0 OrElse tel.Length > 11 Then
            txt_tel.Text = ""
            Exit Sub
        End If

        If tel.Length > 2 Then
            tel = tel.Insert(2, " ")
        End If
        If tel.Length > 8 Then
            tel = tel.Insert(8, "-")
        End If

        txt_tel.Text = tel
        txt_tel.SelectionStart = txt_tel.Text.Length
    End Sub

    Private Sub btn_cadastrar_Click(sender As Object, e As EventArgs) Handles btn_cadastrar.Click
        NovoFunc()
    End Sub

    Private Sub NovoFunc()
        Try
            Using conn = New SqlConnection(connStr)
                conn.Open()
                'Verifica se o funcionário já existe
                Dim sqlCheck = "select * from tb_funcionarios where cpf=@cpf"
                Using cmdCheck = New SqlCommand(sqlCheck, conn)
                    cmdCheck.Parameters.AddWithValue("@cpf", txt_cpf.Text)

                    Using dr = cmdCheck.ExecuteReader
                        If dr.HasRows Then
                            MsgBox("Funcionário já cadastrado!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                        Else
                            dr.Close()

                            Dim sql = "insert into tb_funcionarios (cpf, nome, data_nasc, telefone, email, cargo) values (@cpf, @nome, @data, @tel, @email, @cargo)"
                            Using cmd = New SqlCommand(sql, conn)
                                cmd.Parameters.AddWithValue("@cpf", txt_cpf.Text)
                                cmd.Parameters.AddWithValue("@nome", txt_nome.Text)
                                cmd.Parameters.AddWithValue("@data", cmb_data_nasc.Text)
                                cmd.Parameters.AddWithValue("@tel", txt_tel.Text)
                                cmd.Parameters.AddWithValue("@email", txt_email.Text)
                                cmd.Parameters.AddWithValue("@cargo", cmb_cargo.Text)
                                cmd.ExecuteNonQuery()
                                MsgBox("Funcionário cadastrado com Sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                            End Using
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Algo deu errado!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        End Try
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