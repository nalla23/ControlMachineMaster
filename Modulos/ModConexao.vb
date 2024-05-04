
Imports System.Data.SqlClient

Module ModConexao
    Public arquivo = "C:\ControlMachine\ControlMachine.ini"
    Public server = lerINI(arquivo, "CONFIG", "Servidor")
    Public database = lerINI(arquivo, "CONFIG", "Dados")
    Public user = lerINI(arquivo, "CONFIG", "Usuario")
    Public password = lerINI(arquivo, "CONFIG", "Senha")
    'apenas para demanda da alpha leitura de excel
    Public Servidor = lerINI(arquivo, "CONFIG", "Servidordestino")
    Public Banco = lerINI(arquivo, "CONFIG", "Dadosdestino")
    Public Usuario = lerINI(arquivo, "CONFIG", "Usuariodestino")
    Public Senha = lerINI(arquivo, "CONFIG", "Senhadestino")

    'apenas para demanda da alpha
    Public ReadOnly conn = $"Data Source= {Servidor}; Integrated Security=false;Initial Catalog={Banco}; user={Usuario};password={Senha}"
    'aqui abaixo é a conexão do control machine
    Public ReadOnly strcon = $"Data Source={server}; Integrated Security=false;Initial Catalog={database}; user={user};password={password}"
    Private con As SqlConnection
    Private ad As SqlDataAdapter
    Public ds As New DataSet

    'Caminho para arquivos relatórios
    Public Caminho = lerINI(arquivo, "RELATORIO", "Caminho")

    Public Sub Verifica_conexao()
        Try
            con = New SqlConnection(strcon)
            con.Open()
            MsgBox("Conexão realizado com sucesso!", MsgBoxStyle.Information, "Conexão com banco de dados!")

        Catch ex As Exception
            MsgBox("Erro ao efetuar a conexão com o banco de dados!", MsgBoxStyle.Critical, "Conexão com banco de dados!")
        End Try
        con.Close()
    End Sub
    Public Function lista(ByVal sql As String)
        con = New SqlConnection(strcon)
        Try
            con.Open()
            ad = New SqlDataAdapter(sql, con)
            ds.Clear()
            ad.Fill(ds)
        Catch ex As Exception
            MsgBox("Erro ao efetuar a conexão com o banco de dados!", MsgBoxStyle.Critical, "Erro ao carregar a grid!")
        End Try
        Return ds
    End Function
End Module
