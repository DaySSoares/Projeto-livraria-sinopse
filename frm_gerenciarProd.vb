Imports System.Data.SqlClient

Public Class frm_gerenciarProd

    ' Dim img As Byte() = Nothing
    ' Private imgPadrao As Image = Image.FromFile("\bin\Debug\Imagens\px\livro.png")

    ' Private Sub img_produto_Click(sender As Object, e As EventArgs) Handles img_produto.Click
    'Using ofd As New OpenFileDialog
    '        ofd.Filter = "Arquivos de Imagem|*.jpg;*.jpeg;*.png;"
    '        If ofd.ShowDialog() = DialogResult.OK Then
    '            img_produto.Image = Image.FromFile(ofd.FileName)

    '            Using fs As New IO.FileStream(ofd.FileName, IO.FileMode.Open, IO.FileAccess.Read)
    '                Using br As New IO.BinaryReader(fs)
    '                    img = br.ReadBytes(CType(fs.Length, Integer))
    '                End Using
    '            End Using
    '        End If
    '    End Using
    'End Sub

    Private Sub btn_salvar_Click(sender As Object, e As EventArgs) Handles btn_salvar.Click
        'Cadastrar novo Prod
        Try
            Using conn = New SqlConnection(connStr)
                conn.Open()

                Dim sqlCheck = "select count(*) from tb_produtos where cod_prod=@cod"
                Using cmdCheck = New SqlCommand(sqlCheck, conn)
                    cmdCheck.Parameters.AddWithValue("@cod", txt_codprod.Text)

                    Dim count As Integer = Convert.ToInt32(cmdCheck.ExecuteScalar())

                    If count = 0 Then 'Se o código existir
                        Dim sql = "insert into tb_produtos (cod_prod, nome, genero, preco, qtdEstoque, dispo, imagem) values (@cod, @nome, @gen, @preco, @qtd, @dispo, @img)"

                        Using cmd = New SqlCommand(sql, conn)

                            cmd.Parameters.AddWithValue("@cod", txt_codprod.Text)
                            cmd.Parameters.AddWithValue("@nome", txt_nomeprod.Text)
                            cmd.Parameters.AddWithValue("@gen", cmb_gen.Text)
                            cmd.Parameters.AddWithValue("@preco", CDec(txt_preco.Text))
                            cmd.Parameters.AddWithValue("@qtd", txt_qtd.Text)
                            cmd.Parameters.AddWithValue("@dispo", cmb_dispon.Text)

                            'If img IsNot Nothing Then
                            'cmd.Parameters.AddWithValue("@img", img)
                            'End If

                            cmd.ExecuteNonQuery()
                            MsgBox("Produto cadastrado com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                            LimparCampos()
                        End Using
                    Else
                        EditarProduto()
                    End If

                End Using
            End Using
        Catch ex As Exception
            MsgBox("Erro ao cadastrar!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Private Sub EditarProduto()
        Using conn = New SqlConnection(connStr)
            conn.Open()

            Dim sql = "update tb_produtos set nome=@nome, genero=@gen, preco=@preco, qtdEstoque=@qtd, dispo=@dispo where cod_prod=@cod"

            Using cmd = New SqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@nome", txt_nomeprod.Text)
                cmd.Parameters.AddWithValue("@gen", cmb_gen.Text)
                cmd.Parameters.AddWithValue("@preco", CDec(txt_preco.Text))
                cmd.Parameters.AddWithValue("@qtd", txt_qtd.Text)
                cmd.Parameters.AddWithValue("@dispo", cmb_dispon.Text)
                cmd.ExecuteNonQuery()
                MsgBox("Dados alterados com Sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
            End Using
        End Using
    End Sub

    Private Sub LimparCampos()
        txt_codprod.Clear()
        txt_nomeprod.Clear()
        txt_preco.Clear()
        txt_pesquisa.Clear()
        txt_qtd.Clear()
        cmb_dispon.SelectedIndex = -1
        cmb_gen.SelectedIndex = -1
        'img_produto.Image = imgPadrao
        'img = Nothing
        txt_codprod.Focus()
    End Sub

    Private Sub CarregarLivros()
        'Carregar os dados de produtos no dgv
        Try
            Using conn = New SqlConnection(connStr)
                conn.Open()

                Dim sql = "select cod_prod, nome, genero, preco, qtdEstoque from tb_produtos"

                Using cmd = New SqlCommand(sql, conn)
                    da = New SqlDataAdapter(sql, conn)
                    Dim ds As New DataSet
                    da.Fill(ds)

                    dgv_prod.DataSource = ds.Tables(0)
                    dgv_prod.Columns("cod_prod").HeaderText = "Código"
                    dgv_prod.Columns("nome").HeaderText = "Nome"
                    dgv_prod.Columns("genero").HeaderText = "Genero"
                    dgv_prod.Columns("preco").HeaderText = "Preço"
                    dgv_prod.Columns("qtdEstoque").HeaderText = "Quantidade"
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Algo deu errado!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Private Sub frm_gerenciarProd_Load(sender As Object, e As EventArgs) Handles Me.Load
        CarregarLivros()
        dgv_prod.RowTemplate.Height = 30
    End Sub

    Private Sub btn_limpar_Click(sender As Object, e As EventArgs) Handles btn_limpar.Click
        LimparCampos()
    End Sub

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        'Busca pelo produto (Código, nome ou setor)
        Try
            Using conn = New SqlConnection(connStr)
                conn.Open()

                Dim sql = "select cod_prod, nome, genero, preco, qtdEstoque, dispo from tb_produtos where nome like @pesq or cod_prod= @pesqID"

                Using cmd = New SqlCommand(sql, conn)
                    da = New SqlDataAdapter(sql, conn)
                    cmd.Parameters.AddWithValue("@pesq", "%" & txt_pesquisa.Text & "%")
                    cmd.Parameters.AddWithValue("@pesqID", txt_pesquisa.Text)
                    dr = cmd.ExecuteReader()

                    If dr.HasRows Then
                        If dr.Read Then
                            txt_codprod.Text = dr("cod_prod")
                            txt_nomeprod.Text = dr("nome")
                            txt_preco.Text = dr("preco")
                            txt_qtd.Text = dr("qtdEstoque")
                            cmb_gen.Text = dr("genero")
                            cmb_dispon.Text = dr("dispo")
                        End If
                    Else
                        MsgBox("Produto não encontrado!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                    End If
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Algo deu errado!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Private Sub btn_excluir_Click(sender As Object, e As EventArgs) Handles btn_excluir.Click
        Try
            Dim msg = MsgBox("Certeza que deseja excluir esse item?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")

            If msg = vbYes Then
                Using conn = New SqlConnection(connStr)
                    conn.Open()

                    Dim sql = "delete from tb_produtos where cod_prod= @cod"
                    Using cmd = New SqlCommand(sql, conn)
                        cmd.Parameters.AddWithValue("@cod", txt_codprod.Text)
                        cmd.ExecuteNonQuery()
                        MsgBox("Item Excluído com Sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                        LimparCampos()
                    End Using
                End Using
            End If
        Catch ex As Exception
            MsgBox("Erro ao Excluir!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub


End Class