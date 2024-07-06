Imports System.Data.SqlClient

Public Class frm_Vendas
    Private Sub Carregar_Prod()
        Try
            Using conn = New SqlConnection(connStr)
                conn.Open()

                Dim sql = "select cod_prod, nome, preco from tb_produtos where cod_prod=@pesq"
                Using cmd = New SqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@pesq", txt_codprod.Text)

                    Using dr = cmd.ExecuteReader()
                        Dim dt As New DataTable
                        dt.Load(dr)

                        If dt.Rows.Count = 0 Then
                            MsgBox("Produto não cadastrado!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                            Return
                        End If

                        For Each row As DataRow In dt.Rows
                            Dim jaAdd As Boolean = False

                            ' Verificar se a linha já existe no dgv
                            For Each dgvRow As DataGridViewRow In dgv_prod.Rows
                                If dgvRow.Cells("cod_prod").Value.ToString() = row("cod_prod").ToString() Then
                                    dgvRow.Cells("qtd").Value = Convert.ToInt32(dgvRow.Cells("qtd").Value) + 1
                                    jaAdd = True
                                    Exit For
                                End If
                            Next

                            If jaAdd = False Then
                                'count += 1

                                dgv_prod.Rows.Add(row("cod_prod"), row("nome"), 1, row("preco"))
                            End If
                        Next

                    End Using
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Algo deu errado!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Private Function CalcTotal() As Decimal

        Dim tot As Decimal = 0

        For Each row As DataGridViewRow In dgv_prod.Rows
            If Not row.IsNewRow Then
                Dim preco As Decimal = Convert.ToDecimal(row.Cells("preco").Value)
                Dim qtd As Integer = Convert.ToInt32(row.Cells("qtd").Value)
                tot += preco * qtd
            End If
        Next

        ' Atualizar a Label com o valor total
        lbl_valTot.Text = " R$ " & tot.ToString("F2")
        Return tot
    End Function

    Private Sub ValoresProd()

        If dgv_prod.Rows.Count > 0 Then
            Dim ultLinha As Integer = dgv_prod.Rows.Count - 1

            Dim nomeProd As String = dgv_prod.Rows(ultLinha).Cells("prod").Value.ToString()
            Dim qtd As String = dgv_prod.Rows(ultLinha).Cells("qtd").Value.ToString()
            Dim valor As String = dgv_prod.Rows(ultLinha).Cells("preco").Value.ToString()
            lbl_nomeProd.Text = nomeProd
            lbl_valProd.Text = "R$ " & valor
            lbl_qtd.Text = qtd
        End If

    End Sub

    Private Sub CalcTroco(tot As Decimal)
        'Pega o valor recebido
        Dim rec As Decimal = txt_rec.Text
        Dim troco As Decimal

        troco += rec - tot

        lbl_troco.Text = "R$ " & troco
    End Sub

    Private Sub btn_troco_Click(sender As Object, e As EventArgs) Handles btn_troco.Click
        Try
            'Pega o valor total de dentro da Função CalcTotal() e atribue para total
            Dim total As Decimal = CalcTotal()
            'Passa o total como parametro
            CalcTroco(total)
        Catch ex As Exception
            MsgBox("Algo deu errado!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        Carregar_Prod()
    End Sub

    Private Sub frm_Vendas_Load(sender As Object, e As EventArgs) Handles Me.Load
        lbl_valTot.Text = " R$ 0,00"
        dgv_prod.RowTemplate.Height = 30
        txt_codprod.Focus()
    End Sub

    Private Sub dgv_prod_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs)
        CalcTotal()
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs)
        frm_cadastro_prod.ShowDialog()
    End Sub

    Private Sub btn_fimvenda_Click(sender As Object, e As EventArgs) Handles btn_fimvenda.Click
        'Pega o valor total de dentro da Função CalcTotal() e atribue para total
        Dim total As Decimal = CalcTotal()
        'Passa o total como parametro
        FinalizarVenda(total)
    End Sub

    Private Sub FinalizarVenda(tot As Decimal)
        'Pega os dados da venda
        Dim cpfCli As String = txt_cpfCli.Text
        Dim dataVenda As DateTime = DateTime.Now

        Using conn = New SqlConnection(connStr)
            conn.Open()
            Try
                'Registrar a Venda
                Dim sqlVenda = "insert into tb_vendas (cpfFunc, cpfCli, total, dataVenda) output inserted.idVenda values (@cpfF, @cpfC, @tot, @data)"
                Using cmdVenda = New SqlCommand(sqlVenda, conn)
                    cmdVenda.Parameters.AddWithValue("@cpfF", logcpf)
                    cmdVenda.Parameters.AddWithValue("@cpfC", txt_cpfCli.Text)
                    cmdVenda.Parameters.AddWithValue("@tot", tot)
                    cmdVenda.Parameters.AddWithValue("@data", dataVenda)
                    Dim idVenda As Integer = Convert.ToInt32(cmdVenda.ExecuteScalar())

                    'Inserir os itens da venda e atualizar o estoque
                    For Each row As DataGridViewRow In dgv_prod.Rows
                        If Not row.IsNewRow Then
                            Dim cod_prod As String = row.Cells("cod_prod").Value
                            Dim qtd As Integer = Convert.ToInt32(row.Cells("qtd").Value)
                            Dim precoUni As Decimal = Convert.ToDecimal(row.Cells("preco").Value)

                            'Inserindo os itens
                            Dim sql = "insert into tb_itensVenda (idVenda, cod_prod, qtd, precoUni) values (@idVenda, @codP, @qtd, @preco)"
                            Using cmdItem = New SqlCommand(sql, conn)
                                cmdItem.Parameters.AddWithValue("@idVenda", idVenda)
                                cmdItem.Parameters.AddWithValue("@codP", cod_prod)
                                cmdItem.Parameters.AddWithValue("@qtd", qtd)
                                cmdItem.Parameters.AddWithValue("@preco", precoUni)
                                cmdItem.ExecuteNonQuery()

                                'Atualizar o estoque
                                Dim sqlEst = "update tb_produtos set qtdEstoque = qtdEstoque - @qtd where cod_prod=@cod_prod"
                                Using cmdEst = New SqlCommand(sqlEst, conn)
                                    cmdEst.Parameters.AddWithValue("@qtd", qtd)
                                    cmdEst.Parameters.AddWithValue("@cod_prod", cod_prod)
                                    cmdEst.ExecuteNonQuery()
                                End Using
                            End Using
                        End If
                    Next
                    MessageBox.Show("Compra finalizada com sucesso!")

                End Using
            Catch ex As Exception
                MsgBox("Erro ao finalizar a compra!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
            End Try
        End Using
    End Sub

    Private Sub txt_cpfCli_TextChanged(sender As Object, e As EventArgs) Handles txt_cpfCli.TextChanged
        'Máscara para o CPF
        Dim cpf As String = txt_cpfCli.Text.Replace(".", "").Replace("-", "").Trim()

        ' Verifica se o CPF está vazio ou tem mais de 11 caracteres
        If cpf.Length = 0 OrElse cpf.Length > 11 Then
            txt_cpfCli.Text = ""
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

        txt_cpfCli.Text = cpf
        txt_cpfCli.SelectionStart = txt_cpfCli.Text.Length ' Coloca o cursor no final do texto
    End Sub

    Private Sub dgv_prod_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_prod.CellValueChanged
        CalcTotal()
        ValoresProd()
    End Sub

    Private Sub dgv_prod_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles dgv_prod.RowsAdded
        CalcTotal()
        ValoresProd()
    End Sub
End Class