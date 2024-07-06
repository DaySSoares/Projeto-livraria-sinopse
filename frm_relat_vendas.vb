Imports System.Data.SqlClient

Public Class frm_relat_vendas
    Private Sub frm_relat_vendas_Load(sender As Object, e As EventArgs) Handles Me.Load
        CarregarVendas()
        CalcTot()
        QtdVendas()
    End Sub

    Private Sub CarregarVendas()
        Try
            Using conn = New SqlConnection(connStr)
                conn.Open()

                Dim sql = "select * from tb_vendas"
                Using cmd = New SqlCommand(sql, conn)
                    Dim ds As New DataSet
                    da = New SqlDataAdapter(sql, conn)
                    da.Fill(ds)

                    dgv_vendas.DataSource = ds.Tables(0)
                    dgv_vendas.Columns("idVenda").HeaderText = "cod. venda"
                    dgv_vendas.Columns("cpfFunc").HeaderText = "CPF"
                    dgv_vendas.Columns("total").HeaderText = "Total"
                    dgv_vendas.Columns("dataVenda").HeaderText = "Data"
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Erro ao carregar vendas!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Private Sub CalcTot()
        Dim total As Decimal = 0

        For Each row As DataGridViewRow In dgv_vendas.Rows
            If Not row.IsNewRow Then
                total += Convert.ToDecimal(row.Cells("total").Value)
                'Dim tot As Decimal = Convert.ToDecimal(row.Cells("total").Value)
            End If
        Next

        lbl_valTot.Text = "R$ " & total.ToString("F2")

    End Sub

    Private Sub BuscarFunc()
        Try
            Using conn = New SqlConnection(connStr)
                conn.Open()

                Dim sql = "select * from tb_vendas where cpf=@cpf"
                Using cmd = New SqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@cpf", txt_pesq.Text)
                    dr = cmd.ExecuteReader 'Recebe os dados do comando
                    If dr.Read Then 'Se existir o cpf
                        da.Fill(dt)
                        dgv_vendas.DataSource = dt
                    Else
                        MsgBox("Não possuem vendas com esse CPF", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                    End If
                End Using
            End Using
        Catch ex As Exception
            MsgBox("CPF não encontrado!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        BuscarFunc()
        CalcTot()
        QtdVendas()
    End Sub

    Private Sub QtdVendas()
        Dim qtd As Integer = 0

        For Each row As DataGridViewRow In dgv_vendas.Rows
            If Not row.IsNewRow Then
                qtd += 1
            End If
        Next

        lbl_qtdVenda.Text = "" & qtd.ToString()
    End Sub

    Private Sub txt_pesq_TextChanged(sender As Object, e As EventArgs) Handles txt_pesq.TextChanged
        'Máscara para o CPF
        Dim cpf As String = txt_pesq.Text.Replace(".", "").Replace("-", "").Trim()

        ' Verifica se o CPF está vazio ou tem mais de 11 caracteres
        If cpf.Length = 0 OrElse cpf.Length > 11 Then
            txt_pesq.Text = ""
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

        txt_pesq.Text = cpf
        txt_pesq.SelectionStart = txt_pesq.Text.Length ' Coloca o cursor no final do texto
    End Sub
End Class