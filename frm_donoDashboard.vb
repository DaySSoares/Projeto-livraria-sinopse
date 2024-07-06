Imports System.Data.SqlClient

Public Class frm_donoDashboard
    Private Sub frm_donoDashboard_Load(sender As Object, e As EventArgs) Handles Me.Load
        lbl_hora.Text = DateTime.Now.ToString("HH:mm")
        lbl_dia.Text = DateTime.Now.ToString("dd/MM/yyyy")
        Timer.Start()
        EstatisticasVendas()
        ItensFaltando()
        QtdCli()
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        lbl_hora.Text = DateTime.Now.ToString("HH:mm")
    End Sub

    Private Sub ItensFaltando()
        Using conn As New SqlConnection(connStr)
            conn.Open()
            Try
                Dim sql = "select nome from tb_produtos where qtdEstoque = 0"
                Using cmd = New SqlCommand(sql, conn)
                    Dim rd As SqlDataReader
                    rd = cmd.ExecuteReader()
                    Dim nomeProd As New System.Text.StringBuilder()

                    While rd.Read()
                        nomeProd.AppendLine(rd("nome").ToString())
                    End While
                    lbl_est.Text = nomeProd.ToString()
                End Using
            Catch ex As Exception
                MsgBox("Falha ao carregar Dados!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
            End Try
        End Using
    End Sub

    Private Sub QtdCli()
        Using conn As New SqlConnection(connStr)
            conn.Open()

            Try
                Dim sql = "select count(*) as qtdCli from tb_clientes"
                Using cmd = New SqlCommand(sql, conn)
                    Dim rd As SqlDataReader
                    rd = cmd.ExecuteReader
                    If rd.Read Then
                        Dim qtdCli As Integer = rd("qtdCli")

                        lbl_qtdCli.Text = qtdCli.ToString()
                    Else
                        lbl_qtdCli.Text = "Não há clientes cadastrados"
                    End If
                End Using
            Catch ex As Exception

            End Try
        End Using
    End Sub

    Private Sub EstatisticasVendas()
        Using conn As New SqlConnection(connStr)
            conn.Open()
            Try
                'Conta o total e qtd de vendas do mês
                Dim sqlmes = "select count(*) as qtdVendasMes, sum(total) as fatuMes from tb_vendas where year(dataVenda) = year(getdate()) and month(dataVenda) = month(getdate())"
                Using cmdmes = New SqlCommand(sqlmes, conn)
                    Dim rdMes As SqlDataReader
                    rdMes = cmdmes.ExecuteReader()
                    If rdMes.Read() Then
                        Dim qtdVendasMes As Integer = rdMes("qtdVendasMes")
                        Dim fatuMes As Decimal = rdMes("fatuMes")

                        lbl_fatuMes.Text = fatuMes.ToString()
                        lbl_qtdMes.Text = qtdVendasMes.ToString()
                    End If
                End Using

                'Conta o total  e qtd de vendas do dia
                Dim sqldia = "select count(*) as qtdVendasDia, sum(total) as fatuDia from tb_vendas where year(dataVenda) = year(getdate()) and month(dataVenda) = month(getdate()) and day(dataVenda) = day(getdate())"
                Using cmddia = New SqlCommand(sqldia, conn)
                    Dim rdDia As SqlDataReader
                    rdDia = cmddia.ExecuteReader()
                    If rdDia.Read() Then
                        Dim qtdVendasDia As Integer = rdDia("qtdVendasDia")
                        Dim fatuDia As Decimal = rdDia("fatuDia")

                        lbl_fatuDia.Text = fatuDia.ToString()
                        lbl_qtdCli.Text = qtdVendasDia.ToString()
                    End If
                End Using
            Catch ex As Exception
                MsgBox("Falha ao carregar Dados!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
            End Try
        End Using
    End Sub
End Class