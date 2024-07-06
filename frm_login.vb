
Imports System.Data.SqlClient
Public Class frm_login

    Private Sub btn_sair_Click(sender As Object, e As EventArgs) Handles btn_sair.Click
        Application.Exit()
    End Sub

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        Login()
    End Sub

    Private Sub Login()
        Dim acessoLiberado, cargoGeren, cargoDono, userExiste As Boolean


        Try
            Using conn As New SqlConnection(connStr)
                conn.Open()

                Dim logTempo As DateTime = DateTime.Now
                Dim usercpf As String
                Dim usernome As String

                ' Usuário existe?
                Dim sqlVerUser As String = "select cpf, cargo from tb_usuarios where usuario= @user"
                Using cmdVerUser As New SqlCommand(sqlVerUser, conn)
                    cmdVerUser.Parameters.AddWithValue("@user", txt_usuario.Text)
                    Using drUser As SqlDataReader = cmdVerUser.ExecuteReader()
                        If drUser.HasRows Then
                            userExiste = True
                        End If
                    End Using
                End Using

                If userExiste Then 'Testar se a senha está correta
                    'Dim sql As String = "select cpf, usuario, senha, cargo FROM tb_usuarios where usuario= @user and senha= @senha"

                    Dim sql As String = "select u.cpf, u.usuario, u.senha, u.cargo, f.nome from tb_usuarios u join tb_funcionarios f on u.cpf = f.cpf where u.usuario = @user and u.senha = @senha"

                    Using cmd As New SqlCommand(sql, conn)
                        cmd.Parameters.AddWithValue("@user", txt_usuario.Text)
                        cmd.Parameters.AddWithValue("@senha", txt_senha.Text)
                        Using dr As SqlDataReader = cmd.ExecuteReader()
                            If dr.HasRows Then
                                If dr.Read() Then
                                    acessoLiberado = True

                                    usercpf = dr("cpf").ToString()
                                    usernome = dr("nome").ToString()

                                    RegistraHora(usercpf, logTempo)

                                    Module2.logcpf = usercpf
                                    Module2.lognome = usernome

                                    If dr("cargo").ToString() = "Gerente" Then
                                        cargoGeren = True
                                    ElseIf dr("cargo").ToString() = "Dono" Then
                                        cargoDono = True
                                    End If
                                End If
                            End If
                        End Using
                    End Using
                End If

                If userExiste = True Then
                    If acessoLiberado = True Then
                        If cargoDono = True Then
                            frm_donoMenu.ShowDialog()
                            Me.Close()
                        ElseIf cargoGeren = True Then
                            frm_adm.ShowDialog()
                            Me.Close()
                        Else
                            Ffrm_funcionarioMenu.ShowDialog()
                            Me.Close()
                        End If
                    Else
                        MsgBox("Senha inválida!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                        txt_senha.Clear()
                        txt_senha.Focus()
                    End If
                Else
                    MsgBox("Usuário não cadastrado!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                    txt_usuario.Clear()
                    txt_senha.Clear()
                    txt_usuario.Focus()
                End If
            End Using
        Catch ex As Exception
            MsgBox("Algo deu errado!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
        End Try

    End Sub

    Public Sub RegistraHora(cpf As String, logTempo As DateTime)
        Try
            Using conn = New SqlConnection(connStr)
                conn.Open()

                Dim sql = "insert into tb_login (cpf, entra) values (@cpf, @entra)"
                Using cmd = New SqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@cpf", cpf)
                    cmd.Parameters.AddWithValue("@entra", logTempo)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Algo deu errado!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
        End Try
    End Sub

End Class