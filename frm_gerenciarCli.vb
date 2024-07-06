Imports System.Data.SqlClient

Public Class frm_gerenciarCli
    Private Sub frm_gerenciarCli_Load(sender As Object, e As EventArgs) Handles Me.Load
        CarregarClientes()
    End Sub

    Private Sub btn_cadastrar_Click(sender As Object, e As EventArgs) Handles btn_cadastrar.Click
        Try
            Using conn = New SqlConnection(connStr)
                conn.Open()
                Dim sqlCheck = "select * from tb_clientes where cpf=@cpf"
                Using cmdCheck = New SqlCommand(sqlCheck, conn)
                    cmdCheck.Parameters.AddWithValue("@cpf", txt_cpf.Text)

                    Using dr = cmdCheck.ExecuteReader
                        If dr.HasRows Then
                            MsgBox("Cliente já cadastrado!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
                            PegarDados()
                        Else
                            dr.Close()

                            Dim sql = "insert into tb_clientes (cpf, nome, data_nasc, telefone, email) values (@cpf, @nome, @data, @tel, @email)"
                            Using cmd = New SqlCommand(sql, conn)
                                cmd.Parameters.AddWithValue("@cpf", txt_cpf.Text)
                                cmd.Parameters.AddWithValue("@nome", txt_nome.Text)
                                cmd.Parameters.AddWithValue("@data", cmb_data_nasc.Text)
                                cmd.Parameters.AddWithValue("@tel", txt_tel.Text)
                                cmd.Parameters.AddWithValue("@email", txt_email.Text)
                                cmd.ExecuteNonQuery()
                                MsgBox("Cliente cadastrado com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
                            End Using
                        End If
                    End Using

                End Using
            End Using
        Catch ex As Exception
            MsgBox("Algo deu errado!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub
    Private Sub CarregarClientes()
        'Carregar os dados de clientes no dgv
        Try
            Using conn = New SqlConnection(connStr)
                conn.Open()

                Dim sql = "select cpf, nome, data_nasc, telefone, email from tb_clientes"

                Using cmd = New SqlCommand(sql, conn)
                    da = New SqlDataAdapter(sql, conn)
                    Dim ds As New DataSet
                    da.Fill(ds)

                    dgv_clientes.DataSource = ds.Tables(0)
                    dgv_clientes.Columns("cpf").HeaderText = "CPF"
                    dgv_clientes.Columns("nome").HeaderText = "Nome"
                    dgv_clientes.Columns("data_nasc").HeaderText = "Data Nasc."
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

    Private Sub EditarClientes()
        Try
            Using conn = New SqlConnection(connStr)
                conn.Open()

                Dim sql = "update tb_clientes set nome=@nome, data_nasc=@data, email=@email, telefone=@tel where cpf=@cpf"
                Using cmd = New SqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@cpf", txt_cpf.Text)
                    cmd.Parameters.AddWithValue("@nome", txt_nome.Text)
                    cmd.Parameters.AddWithValue("@data", cmb_data_nasc.Text)
                    cmd.Parameters.AddWithValue("@email", txt_email.Text)
                    cmd.Parameters.AddWithValue("@tel", txt_tel.Text)
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

    Private Sub PegarDados()
        Try
            Using conn = New SqlConnection(connStr)
                conn.Open()

                Dim sql = "select * from tb_clientes where cpf=@cpf"
                Using cmd = New SqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@cpf", txt_cpf.Text)
                    dr = cmd.ExecuteReader 'Recebe os dados do comando
                    If dr.Read Then 'Se existir o cpf
                        txt_nome.Text = dr("nome")
                        cmb_data_nasc.Text = dr("data_nasc")
                        txt_tel.Text = dr("telefone")
                        txt_email.Text = dr("email")
                        btn_editar.Visible = True
                        btn_cadastrar.Visible = False
                    End If
                End Using
            End Using
        Catch ex As Exception

        End Try
    End Sub
    Private Sub LimparCampos()
        txt_cpf.Clear()
        txt_nome.Clear()
        txt_tel.Clear()
        txt_email.Clear()
        'cmb_data_nasc.clear()
    End Sub

    Private Sub btn_excluir_Click(sender As Object, e As EventArgs) Handles btn_excluir.Click
        Dim msg As String = MsgBox("Deseja mesmo excluir esse registro?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "AVISO")

        Try
            If msg = vbYes Then
                Using conn = New SqlConnection(connStr)
                    conn.Open()

                    Dim sql = "delete from tb_clientes where cpf=@cpf"
                    Using cmd = New SqlCommand(sql, conn)
                        cmd.Parameters.AddWithValue("@cpf", txt_cpf.Text)
                        cmd.ExecuteNonQuery()
                        MsgBox("Registro Excluído com Sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                        LimparCampos()
                    End Using
                End Using
            End If
        Catch ex As Exception
            MsgBox("Erro ao Excluir Registro!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Private Sub btn_editar_Click(sender As Object, e As EventArgs) Handles btn_editar.Click
        EditarClientes()
    End Sub

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
End Class