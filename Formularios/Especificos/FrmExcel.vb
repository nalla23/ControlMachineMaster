Imports System.CodeDom
Imports System.Configuration
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.Security.Cryptography.X509Certificates
Imports Microsoft.Reporting.WinForms
Imports System.Windows.Forms

Public Class FrmExcel
    Private Sub ABRIR()
        Dim arquivo = Tcaminho.Text
        Dim planilha = "select * from [TESTE$]"
        Dim strcon = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & arquivo & ";Extended Properties=""Excel 12.0;HDR=Yes;IMEX=0"""
        Dim dt = New DataTable()
        Using con = New OleDbConnection(strcon)
            Using da = New OleDbDataAdapter(planilha, con)
                da.Fill(dt)
                DG1.DataSource = dt
                DG1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            End Using
        End Using

    End Sub
    Public Shared Function salvar(dg1 As DataGridView) As Boolean

        Dim sql = ""
        Try
            Using cn = New SqlConnection(conn)
                cn.Open()
                For Each r As DataGridViewRow In dg1.Rows
                    If Convert.ToInt32("0" + r.Cells("ID").Value) = 0 Then
                        sql = "INSERT INTO IMPNOTAS (CHAVEACESSO,NUMERONFE,DATAEMISSAO, NCM,NOMEITEM,CODMUN,PRCITEM,CFOP,NATUREZA,CST,ALIQICMS,VICMS)
                                VALUES (@CHAVEACESSO,@NUMERONFE,@DATAEMISSAO, @NCM,@NOMEITEM,@CODMUN,@PRCITEM,@CFOP,@NATUREZA,@CST,@ALIQICMS,@VICMS)"
                    End If

                    Using cmd = New SqlCommand(sql, cn)
                        ' dg1.Columns(0).Visible = False
                        cmd.Parameters.AddWithValue("@CHAVEACESSO", r.Cells("CHAVE_ACESSO").Value)
                        cmd.Parameters.AddWithValue("@NUMERONFE", r.Cells("NUM_DOC").Value)
                        cmd.Parameters.AddWithValue("@DATAEMISSAO", r.Cells("DATA_EMISSAO").Value)
                        cmd.Parameters.AddWithValue("@NCM", r.Cells("NCM").Value)
                        cmd.Parameters.AddWithValue("@NOMEITEM", r.Cells("ITEM").Value)
                        cmd.Parameters.AddWithValue("@CODMUN", r.Cells("CO_CMUN_EMIT").Value)
                        cmd.Parameters.AddWithValue("@PRCITEM", r.Cells("TOTAL_ITEM").Value)
                        cmd.Parameters.AddWithValue("@CFOP", r.Cells("CO_CFOP").Value)
                        cmd.Parameters.AddWithValue("@NATUREZA", r.Cells("DESCRICAO_CFOP").Value)
                        cmd.Parameters.AddWithValue("@CST", r.Cells("ICMS_CST_A").Value)
                        cmd.Parameters.AddWithValue("@ALIQICMS", r.Cells("ALIQ_ICM").Value)
                        cmd.Parameters.AddWithValue("@VICMS", r.Cells("ICMS").Value)
                        If Convert.ToInt32("0" + r.Cells("id").Value) > 0 Then
                            cmd.Parameters.AddWithValue("@id", Convert.ToInt32("0" + r.Cells("id").Value))
                        End If
                        cmd.ExecuteNonQuery()
                    End Using
                Next
            End Using
            MsgBox("Registros incluidos com sucesso!", vbInformation, "Aviso!")
            Return True

        Catch ex As Exception
            MessageBox.Show("Erro: " + ex.Message)
            Return False
        End Try
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        ' Cria uma instância do OpenFileDialog
        Dim openFileDialog1 As New OpenFileDialog()

        ' Define o título da janela do diálogo
        openFileDialog1.Title = "Selecionar Arquivo"

        ' Define o filtro de extensões de arquivo permitidas
        openFileDialog1.Filter = "Arquivos de Texto|*.*|Todos os Arquivos|*.*"

        ' Define o diretório inicial do diálogo (opcional)
        openFileDialog1.InitialDirectory = "C:\"

        ' Define se o diálogo permite a seleção de vários arquivos (opcional)
        openFileDialog1.Multiselect = False

        ' Exibe o diálogo e verifica se o usuário pressionou OK
        If openFileDialog1.ShowDialog() = DialogResult.OK Then
            ' Obtém o caminho do arquivo selecionado
            Dim caminhoArquivo As String = openFileDialog1.FileName
            Tcaminho.Text = caminhoArquivo
            BtAbrir.Enabled = True
            BtSalvar.Enabled = False
            Tcaminho.Enabled = False
            Button1.Enabled = False
            ' Exibe o caminho do arquivo (você pode fazer o que quiser com o caminho aqui)
            'MessageBox.Show("Caminho do arquivo: " & caminhoArquivo)
        End If
    End Sub

    Private Sub BtSalvar_Click(sender As Object, e As EventArgs) Handles BtSalvar.Click
        DG1.AllowUserToAddRows = False
        FrmExcel.salvar(DG1)
    End Sub

    Private Sub BtAbrir_Click(sender As Object, e As EventArgs) Handles BtAbrir.Click
        ABRIR()
        contarlinhas()
        BtAbrir.Enabled = False
        BtSalvar.Enabled = True
        Tcaminho.Enabled = False
        Button1.Enabled = False
    End Sub

    Private Sub FrmExcel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BtAbrir.Enabled = False
        BtSalvar.Enabled = False
        Tcaminho.Enabled = False

    End Sub
    Public Sub contarlinhas()
        Dim numlinhas As Integer = DG1.RowCount - 1
        Dim contador As Integer = 0
        While (numlinhas >= 0)
            contador = contador + 1
            numlinhas = numlinhas - 1
        End While
        LbContaLinhas.Text = contador & "Linhas  "
    End Sub
    Private Sub somagrid()
        Dim linha As DataGridViewRow
        Dim valor As Double
        For Each linha In DG1.Rows
            valor = valor + linha.Cells(4).Value

        Next
        LbContaLinhas.Text = FormatCurrency(valor)

    End Sub

End Class