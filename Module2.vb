Imports System.Data.SqlClient

Module Module2

    Public da As SqlDataAdapter
    Public dr As SqlDataReader
    Public dt As DataTable

    Public logcpf As String
    Public lognome As String

    Private server = "LAPTOP-2M1OBMSB" '"DESKTOP-8UN1UBR\SQLEXPRESS"
    Private banco = "Livraria_Sinopse"

    Public ReadOnly connStr = "Data Source=" & server & ";Initial Catalog=" & banco & ";Integrated Security=True"


    Public Sub Saida()

        Using conn = New SqlConnection(connStr)
            conn.Open()

            Dim logSaida As DateTime = DateTime.Now

            Dim sql = "update tb_login set saida = @logsaida where cpf=@cpf and saida is null"
            Using cmd As New SqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@cpf", logcpf)
                cmd.Parameters.AddWithValue("@logsaida", logSaida)
                cmd.ExecuteNonQuery()
            End Using
        End Using

        Module2.logcpf = String.Empty
        Module2.lognome = String.Empty

        Application.Exit()
    End Sub

End Module
