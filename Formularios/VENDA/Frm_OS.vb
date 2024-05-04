Imports System.Data.SqlClient
Imports ControlMachine.ControlMachine

Public Class Frm_OS


    Private Sub BtFechar_Click(sender As Object, e As EventArgs)
        Close()
    End Sub

    Private Sub BtNovo_Click(sender As Object, e As EventArgs) Handles BtNovo.Click
        gerarcodigo()
    End Sub
    Private Sub INSERIRDADOS()

        Try
            Dim nomeDaMaquina As String = Environment.MachineName
            Using cn = New SqlConnection(strcon)
                cn.Open()
                Dim sql = "INSERT INTO OPERACAO (NUMERO, VLR_TOTAL, VLR_ITEM, VLR_DESC, ID_CLIENTE, ID_TECNICO, DT_LAN, DT_FECHAMENTO, DT_ABERTURA, ID_USUARIO_LAN, MAQUINA_LAN, OBS) 
                           VALUES  (@NUMERO, @VLR_TOTAL, @VLR_ITEM, @VLR_DESC, @ID_CLIENTE, @ID_TECNICO, @DT_LAN, @DT_FECHAMENTO, @DT_ABERTURA, @ID_USUARIO_LAN, @MAQUINA_LAN, @OBS)"
                Using cmd = New SqlCommand(sql, cn)
                    cmd.Parameters.AddWithValue("@NUMERO", TOs.Text)
                    cmd.Parameters.AddWithValue("@VLR_TOTAL", TVlrTotal.Text.Replace(",", ".").Replace("R$", ""))
                    cmd.Parameters.AddWithValue("@DATA", Date.Today)
                    cmd.Parameters.AddWithValue("@VLR_ITEM", TVlrItem.Text.Replace(",", ".").Replace("R$", ""))
                    cmd.Parameters.AddWithValue("@VLR_DESC", TDesc.Text.Replace(",", ".").Replace("R$", ""))
                    cmd.Parameters.AddWithValue("@ID_CLIENTE", CNomeCliente.SelectedValue)
                    cmd.Parameters.AddWithValue("@ID_TECNICO", 1)
                    cmd.Parameters.AddWithValue("@DT_LAN", Date.Today)
                    cmd.Parameters.AddWithValue("@DT_FECHAMENTO", Date.Today)
                    cmd.Parameters.AddWithValue("@DT_ABERTURA", Date.Today)
                    cmd.Parameters.AddWithValue("@ID_USUARIO_LAN", 1)
                    cmd.Parameters.AddWithValue("@MAQUINA_LAN", nomeDaMaquina)
                    cmd.Parameters.AddWithValue("@OBS", "ORDEM DE SERVIÇO: " + TOs.Text)
                    cmd.ExecuteNonQuery()
                End Using
                MsgBox("Registro salvo com sucesso", vbInformation, "Aviso!")
                cn.Close()
            End Using
        Catch ex As Exception
            MsgBox("Ops, ocorreu um erro ao inserir a Ordem de Serviço " + TOs.Text & vbNewLine & vbNewLine & ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub gerarcodigo()
        Try
            Using cn = New SqlConnection(strcon)
                cn.Open()
                Dim sql = "select max(id_operacao + 1) as result from operacao"
                Using cmd = New SqlCommand(sql, cn)

                    Using dr = cmd.ExecuteReader
                        If dr.HasRows Then
                            If dr.Read Then
                                TOs.Text = dr("result")
                            End If
                        End If
                    End Using
                End Using
                cn.Close()
            End Using
        Catch ex As Exception
            Dim unused = MsgBox("Algo deu errado na tentativa de gerar o numero da OS." & vbNewLine & vbNewLine & ex.Message, vbCritical)
        End Try
    End Sub
    Private Sub BuscarCliente()
        Try
            Using cn = New SqlConnection(strcon)
                cn.Open()
                Dim sql As String = "SELECT ID_PESSOA,NOME FROM PESSOAS WHERE TIPO = 'MB' ORDER BY NOME"
                Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                da.Fill(dt)
                CNomeCliente.DisplayMember = ("NOME")
                CNomeCliente.ValueMember = ("ID_PESSOA")
                CNomeCliente.DataSource = dt
            End Using
        Catch ex As Exception
            Dim unused = MsgBox("Algo deu errado com a conexão!" & vbNewLine & vbNewLine & ex.Message, vbCritical)
        End Try

    End Sub

    Private Sub carregaprodutos()
        Try
            Using cn = New SqlConnection(strcon)
                cn.Open()
                Dim sql As String = "SELECT ID_PRODUTO,NOME FROM PRODUTOS  ORDER BY NOME"
                Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                da.Fill(dt)
                CNomeProduto.DisplayMember = ("NOME")
                CNomeProduto.ValueMember = ("ID_PRODUTO")
                CNomeProduto.DataSource = dt
            End Using
        Catch ex As Exception
            Dim unused = MsgBox("Algo deu errado com a conexão!" & vbNewLine & vbNewLine & ex.Message, vbCritical)
        End Try

    End Sub

    Sub BuscaItem()
        Try
            Using cn = New SqlConnection(strcon)
                ' Dim id = DgProduto.Rows(DgProduto.CurrentCell.RowIndex).Cells(0).Value
                cn.Open()
                Dim sql = "SELECT P.COD, P.NOME,I.QTDE, I.VLR_UNITARIO, I.VLR_TOTAL	
                            FROM ITEM_OPERACAO I
                            INNER JOIN
                            PRODUTOS P ON P.ID_PRODUTO = I.ID_ITEM where I.id_operacao = '" & 1 & "'"
                Using dap = New SqlDataAdapter(sql, cn)
                    Using dt = New DataTable()
                        dap.Fill(dt)
                        DgProduto.DataSource = dt
                        With DgProduto 'with significa com e substitui variavel a frente dele
                            .Columns(0).Width = 60  ' Código
                            .Columns(1).Width = 150 ' Nome do produto
                            .Columns(2).Width = 70  ' Quantidade do produto
                            .Columns(3).Width = 80  ' Valor unitário
                            .Columns(3).DefaultCellStyle.Format = "c"
                            .Columns(4).Width = 100  ' Valor total
                            .Columns(4).DefaultCellStyle.Format = "c"


                        End With
                    End Using
                End Using
                cn.Close()
                somagrid()
                qtdegrid()
            End Using
        Catch ex As Exception
            MsgBox("Ops... ocorreu um erro, favor verifique a conexão! ", vbExclamation, "Aviso! ")
        End Try
    End Sub
    Private Sub somagrid()
        Dim linha As DataGridViewRow
        Dim valor As Double
        For Each linha In DgProduto.Rows
            valor = valor + linha.Cells(4).Value
        Next
        TVlrItem.Text = FormatCurrency(valor)
        ' qtdegrid()
    End Sub
    Private Sub qtdegrid()
        Dim numlinhas As Integer = DgProduto.RowCount - 1
        Dim contador As Integer = 0
        While (numlinhas >= 0)
            contador = contador + 1
            numlinhas = numlinhas - 1
        End While
        Lqtde.Text = contador
    End Sub

    Private Sub BtSalvar_Click(sender As Object, e As EventArgs) Handles BtSalvar.Click
        INSERIRDADOS()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        BuscaItem()
    End Sub
End Class