Imports System.Data.SqlClient

Public Class frm_donoGerenFunc
    Private Sub txt_cpf_TextChanged(sender As Object, e As EventArgs)
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


    Private Sub CarregarLogins()
        'Carregar os dados de funcionários no dgv
        Try
            Using conn = New SqlConnection(connStr)
                conn.Open()

                Dim sql = "select cpf, entra, saida from tb_login where saida is not null"

                Using cmd = New SqlCommand(sql, conn)
                    da = New SqlDataAdapter(sql, conn)
                    Dim ds As New DataSet
                    da.Fill(ds)

                    dgv_loginFunc.DataSource = ds.Tables(0)
                    dgv_loginFunc.Columns("cpf").HeaderText = "CPF"
                    dgv_loginFunc.Columns("entra").HeaderText = "Entrada"
                    dgv_loginFunc.Columns("saida").HeaderText = "Saída"
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Algo deu errado!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub
    Private Sub CarregarFunc()
        'Carregar os dados de funcionários no dgv
        Try
            Using conn = New SqlConnection(connStr)
                conn.Open()

                Dim sql = "select cpf, nome, data_nasc, email, cargo from tb_funcionarios"

                Using cmd = New SqlCommand(sql, conn)
                    da = New SqlDataAdapter(sql, conn)
                    Dim ds As New DataSet
                    da.Fill(ds)

                    dgv_func.DataSource = ds.Tables(0)
                    dgv_func.Columns("cpf").HeaderText = "CPF"
                    dgv_func.Columns("nome").HeaderText = "Nome"
                    dgv_func.Columns("data_nasc").HeaderText = "Data Nasc."
                    dgv_func.Columns("email").HeaderText = "Email"
                    dgv_func.Columns("cargo").HeaderText = "Cargo"
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Algo deu errado!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Private Sub btn_cadastrar_Click(sender As Object, e As EventArgs)
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
                            PegarDados()
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

    Private Sub PegarDados()
        Try
            Using conn = New SqlConnection(connStr)
                conn.Open()

                Dim sql = "select * from tb_funcionarios where cpf=@cpf"
                Using cmd = New SqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@cpf", txt_cpf.Text)
                    dr = cmd.ExecuteReader 'Recebe os dados do comando
                    If dr.Read Then 'Se existir o cpf
                        txt_nome.Text = dr("nome")
                        cmb_data_nasc.Text = dr("data_nasc")
                        cmb_cargo.Text = dr("cargo")
                        txt_tel.Text = dr("telefone")
                        txt_email.Text = dr("email")
                        btn_editar.Visible = True
                        btn_cadastrar.Visible = False
                        EditarFuncionario()
                    End If
                End Using
            End Using
        Catch ex As Exception

        End Try
    End Sub

    Private Sub EditarFuncionario()
        Try
            Using conn = New SqlConnection(connStr)
                conn.Open()

                Dim sql = "update tb_funcionarios set nome=@nome, data_nasc=@data, telefone=@tel, email=@email, cargo=@cargo where cpf=@cpf"
                Using cmd = New SqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@cpf", txt_cpf.Text)
                    cmd.Parameters.AddWithValue("@nome", txt_nome.Text)
                    cmd.Parameters.AddWithValue("@data", cmb_data_nasc.Text)
                    cmd.Parameters.AddWithValue("@tel", txt_tel.Text)
                    cmd.Parameters.AddWithValue("@email", txt_email.Text)
                    cmd.Parameters.AddWithValue("@cargo", cmb_cargo.Text)
                    cmd.ExecuteNonQuery()
                    MsgBox("Dados do funcionário editados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                    LimparCampos()
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Algo deu errado!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Private Sub LimparCampos()
        txt_cpf.Clear()
        txt_nome.Clear()
        txt_tel.Clear()
        txt_email.Clear()
        cmb_cargo.SelectedIndex = -1
        txt_cpf.Focus()
        'cmb_data_nasc.clear()
    End Sub

    Private Sub txt_cpf_TextChanged_1(sender As Object, e As EventArgs) Handles txt_cpf.TextChanged
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

    Private Sub btn_excluir_Click(sender As Object, e As EventArgs) Handles btn_excluir.Click
        Dim msg As String = MsgBox("Deseja mesmo excluir esse registro?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "AVISO")

        Try
            If msg = vbYes Then
                Using conn = New SqlConnection(connStr)
                    conn.Open()

                    Dim sql = "delete from tb_funcionarios where cpf=@cpf"
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

    Private Sub frm_donoGerenFunc_Load(sender As Object, e As EventArgs) Handles Me.Load
        CarregarFunc()
        CarregarLogins()
    End Sub

    Private Sub BuscarCPF()
        Try
            Using conn = New SqlConnection(connStr)
                conn.Open()

                Dim sql = "select cpf, entra, saida from tb_login where cpf= @cpf and saida is not null"

                Using cmd = New SqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@cpf", txt_pesq.Text)
                    Dim da As New SqlDataAdapter(cmd)
                    Dim dt As New DataTable
                    da.Fill(dt)
                    dgv_loginFunc.DataSource = dt
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Algo deu errado!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        BuscarCPF()
    End Sub
End Class