Imports System.Data.SqlClient

Public Class frm_cadastro_prod

    Private Sub frm_cadastro_prod_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Carregar os dados de produtos no dgv
        Try
            Using conn = New SqlConnection(connStr)
                conn.Open()

                Dim sql = "select cod_prod, nome, genero, preco, qtdEstoque, dispo from tb_produtos"

                Using cmd = New SqlCommand(sql, conn)
                    da = New SqlDataAdapter(sql, conn)
                    Dim ds As New DataSet
                    da.Fill(ds)

                    dgv_prods.DataSource = ds.Tables(0)
                    dgv_prods.RowTemplate.Height = 30
                    dgv_prods.Columns("cod_prod").HeaderText = "Código"
                    dgv_prods.Columns("nome").HeaderText = "Nome"
                    dgv_prods.Columns("genero").HeaderText = "Gênero"
                    dgv_prods.Columns("preco").HeaderText = "Preço"
                    dgv_prods.Columns("qtdEstoque").HeaderText = "Qtd"
                    dgv_prods.Columns("dispo").HeaderText = "Diponibilidade"
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Algo deu errado!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        'Busca pelo produto (Código, nome ou gênero)
        Try
            Using conn = New SqlConnection(connStr)
                conn.Open()

                Dim sql = "select cod_prod, nome, genero, preco, qtdEstoque, dispo from tb_produtos where nome like @pesq or genero like @pesq or cod_prod=@pesqID"

                Using cmd = New SqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@pesq", "%" & txt_pesquisa.Text & "%")
                    cmd.Parameters.AddWithValue("@pesqID", txt_pesquisa.Text)
                    Dim da As New SqlDataAdapter(cmd)
                    Dim dt As New DataTable
                    da.Fill(dt)
                    dgv_prods.DataSource = dt
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Pesquisa não encontrada", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Private Sub txt_pesquisa_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_pesquisa.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn_buscar.PerformClick()
            e.SuppressKeyPress = True
            txt_pesquisa.Clear()
            txt_pesquisa.Focus()
        End If
    End Sub
End Class