Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Tab
Imports Microsoft.CodeAnalysis

Public Class Frm_Servico
    Private Sub controlebotoesinicial()
        BtNovo.Visible = True
        BtSalvar.Visible = False
        BtCancelar.Visible = False
        BtEditar.Visible = True
        BtAtualizar.Visible = False
        BtExcluir.Enabled = True
        BtFechar.Enabled = True
        'Limpeza de campos.
        DtLan.Text = Today
        Tnumero.Text = ""
        TDescricao.Text = ""
        TResp.Text = ""
        TValor.Text = ""
        DgManutencao.DataSource = Nothing
        carregagridmanutencao()
        GroupBox1.Enabled = False
    End Sub
    Private Sub controlebotoesfinal()
        BtNovo.Visible = False
        BtSalvar.Visible = True
        BtCancelar.Visible = True
        BtEditar.Visible = False
        BtAtualizar.Visible = False
        BtExcluir.Enabled = False
        BtFechar.Enabled = False
        'Limpeza de campos.
        DtLan.Text = Today
        Tnumero.Text = ""
        TDescricao.Text = ""
        TResp.Text = ""
        TValor.Text = ""
        DgManutencao.DataSource = Nothing ' limpa grid de itens.
        carregagridmanutencao()
        GroupBox1.Enabled = True
    End Sub
    Private Sub controlebotoesatualizar()

        If Tnumero.Text = "" Then
            MsgBox("Não tem registro selecionado.", vbInformation, "Aviso")
        Else
            BtNovo.Visible = False
            BtSalvar.Visible = False
            BtCancelar.Visible = True
            BtEditar.Visible = False
            BtAtualizar.Visible = True
            BtExcluir.Enabled = False
            BtFechar.Enabled = False
            GroupBox1.Enabled = True
        End If
    End Sub
    Sub carregagridmanutencao()
        Try
            Dim idmaq = FrmCadMaquinas.tidmaquina.Text
            Using cn = New SqlConnection(strcon)
                cn.Open()
                Dim sql = "SELECT ID_MANUTENCAO,CODIGO, NOME,DTLAN,VALOR,RESPONSAVEL FROM MANUTENCAO WHERE ID_EQUIPAMENTO =" & idmaq
                Using dap = New SqlDataAdapter(sql, cn)
                    Using dt = New DataTable()
                        dap.Fill(dt)
                        DgManutencao.DataSource = dt
                        With DgManutencao 'with significa com e substitui variavel a frente dele
                            .Columns(0).Visible = False
                            .Columns(1).HeaderText = "Código"
                            .Columns(1).Width = 80
                            .Columns(2).HeaderText = "Descrição"
                            .Columns(2).Width = 200
                            .Columns(3).HeaderText = "Data Lanc"
                            .Columns(3).Width = 100
                            .Columns(4).HeaderText = "Valor"
                            .Columns(4).Width = 100
                            .Columns(5).HeaderText = "Responsável"
                            .Columns(5).Width = 120
                        End With
                    End Using
                End Using
                somagrid()
                contarlinhas()
            End Using
        Catch ex As Exception
            MsgBox("Ops... ocorreu um erro,favor verifique a conexão!#carregaequipamento ", vbExclamation, "Aviso! ")
        End Try

    End Sub

    Private Sub BtAtualizar_Click(sender As Object, e As EventArgs) Handles BtAtualizar.Click
        AlterarRegistro()
        controlebotoesinicial()
    End Sub

    Private Sub BtSalvar_Click(sender As Object, e As EventArgs) Handles BtSalvar.Click
        INSERIRDADOS()
        controlebotoesinicial()
    End Sub

    Private Sub BtNovo_Click(sender As Object, e As EventArgs) Handles BtNovo.Click
        controlebotoesfinal()
        gerarcodigo()
    End Sub

    Private Sub BtEditar_Click(sender As Object, e As EventArgs) Handles BtEditar.Click
        controlebotoesatualizar()
    End Sub

    Private Sub BtCancelar_Click(sender As Object, e As EventArgs) Handles BtCancelar.Click
        controlebotoesinicial()
    End Sub

    Private Sub BtExcluir_Click(sender As Object, e As EventArgs) Handles BtExcluir.Click
        controlebotoesinicial()
        ExcluirRegistro()
    End Sub

    Private Sub BtFechar_Click(sender As Object, e As EventArgs) Handles BtFechar.Click
        FrmCadMaquinas.Panel1.Enabled = True
        FrmCadMaquinas.DgEquipamentos.Enabled = True
        Close()
    End Sub

    Private Sub BtBuscar_Click(sender As Object, e As EventArgs) Handles BtBuscar.Click
        carregagridmanutencao()
    End Sub
    Private Sub INSERIRDADOS()
        Dim idmaq = FrmCadMaquinas.tidmaquina.Text
        If TValor.Text = "" Then
            TValor.Text = 0
        End If
        Try
            Using cn = New SqlConnection(strcon)
                cn.Open()
                Dim sql = "INSERT INTO MANUTENCAO 
                                               ( nome,responsavel,valor,DTLAN,id_equipamento) 
                           VALUES  (@nome,@RESPONSAVEL,@valor,@DTLAN,@id_equipamento)"
                Using cmd = New SqlCommand(sql, cn)
                    cmd.Parameters.AddWithValue("@NOME", TDescricao.Text)
                    cmd.Parameters.AddWithValue("@RESPONSAVEL", TResp.Text)
                    cmd.Parameters.AddWithValue("@VALOR", TValor.Text.Replace(",", ".").Replace("R$", ""))
                    cmd.Parameters.AddWithValue("@DTLAN", DtLan.Text)
                    cmd.Parameters.AddWithValue("@ID_EQUIPAMENTO", idmaq)
                    'cmd.Parameters.AddWithValue("@ATIVO", IIf(Microsoft.VisualBasic.Left(CbAtivo.Text, 1) = "S", 1, 0))
                    cmd.ExecuteNonQuery()
                End Using
                MsgBox("Registro salvo com sucesso ", vbInformation, "Aviso!")
                cn.Close()
            End Using
        Catch ex As Exception
            MsgBox("Ops, ocorreu um erro ao inserir o registro de #Manutenção" & vbNewLine & vbNewLine & ex.Message, vbCritical)
        End Try
    End Sub
    Private Sub SELECTIONAITEM()
        Try
            Using cn = New SqlConnection(strcon)
                Dim id = DgManutencao.Rows(DgManutencao.CurrentCell.RowIndex).Cells(0).Value
                cn.Open()
                Dim sql = "SELECT * FROM MANUTENCAO WHERE ID_MANUTENCAO=" & id
                Using cmd = New SqlCommand(sql, cn)
                    Using dr = cmd.ExecuteReader
                        If dr.HasRows Then
                            If dr.Read Then
                                DtLan.Text = dr("DTLAN")
                                Tnumero.Text = dr("CODIGO")
                                TDescricao.Text = dr("NOME")
                                TResp.Text = dr("RESPONSAVEL")
                                TValor.Text = dr("VALOR".Replace(".", ","))
                            End If
                        End If
                    End Using
                End Using

                cn.Close()
            End Using
        Catch ex As Exception
            Dim unused = MsgBox("Algo deu errado com a conexão, #selecionaitem!" & vbNewLine & vbNewLine & ex.Message, vbCritical)
        End Try
    End Sub
    Private Sub DgManutencao_DoubleClick(sender As Object, e As EventArgs) Handles DgManutencao.DoubleClick
        SELECTIONAITEM()
    End Sub
    Private Sub AlterarRegistro()
        Try
            Using cn = New SqlConnection(strcon)

                cn.Open()
                Dim id = DgManutencao.Rows(DgManutencao.CurrentCell.RowIndex).Cells(0).Value
                Dim sql = "UPDATE MANUTENCAO SET CODIGO=@codigo,NOME=@nome,RESPONSAVEL=@responsavel,VALOR=@valor,DTLAN=@DTLAN  
                            WHERE ID_MANUTENCAO=" & id
                Using cmd = New SqlCommand(sql, cn)
                    cmd.Parameters.AddWithValue("@codigo", Tnumero.Text)
                    cmd.Parameters.AddWithValue("@NOME", TDescricao.Text)
                    cmd.Parameters.AddWithValue("@responsavel", TResp.Text)
                    cmd.Parameters.AddWithValue("@valor", TValor.Text.Replace(",", ".").Replace("R$", ""))
                    cmd.Parameters.AddWithValue("@dtlan", DtLan.Text)
                    cmd.ExecuteNonQuery()
                    MsgBox("Registro atualizado com sucesso!", vbInformation, "Aviso!")
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Algo deu errado com a conexão! '#AlterarRegistro'" & vbNewLine & vbNewLine & ex.Message, vbCritical)
        End Try
    End Sub
    Private Sub ExcluirRegistro()
        Dim id = DgManutencao.Rows(DgManutencao.CurrentCell.RowIndex).Cells(0).Value
        If MsgBox("Deseja excluir o registro selecionado? ", vbQuestion + vbYesNo, "Aviso!") = vbYes Then
            Try
                Using cn = New SqlConnection(strcon)
                    cn.Open()
                    Dim sql = "DELETE FROM manutencao WHERE id_manutencao=" & id
                    Using cmd = New SqlCommand(sql, cn)
                        cmd.ExecuteNonQuery()
                    End Using
                End Using
            Catch ex As Exception
                MsgBox("Algo deu errado com a conexão!" & vbNewLine & vbNewLine & ex.Message, vbCritical)
            End Try
        End If
    End Sub

    Private Sub Frm_Servico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        controlebotoesinicial()
        carregagridmanutencao()
    End Sub
    Private Sub gerarcodigo()
        Try
            Using cn = New SqlConnection(strcon)
                cn.Open()
                Dim sql = "select max(id_manutencao + 1) as result from manutencao"
                Using cmd = New SqlCommand(sql, cn)

                    Using dr = cmd.ExecuteReader
                        If dr.HasRows Then
                            If dr.Read Then
                                Tnumero.Text = dr("result")
                            End If
                        End If
                    End Using
                End Using
                cn.Close()
            End Using
        Catch ex As Exception
            Dim unused = MsgBox("Algo deu errado com a conexão #gerarcodigo!" & vbNewLine & vbNewLine & ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub BtBuscar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BtBuscar.KeyPress
        carregagridmanutencao()
    End Sub

    Private Sub Frm_Servico_Closed(sender As Object, e As EventArgs) Handles MyBase.Closed
        FrmCadMaquinas.Panel1.Enabled = True
        FrmCadMaquinas.DgEquipamentos.Enabled = True
    End Sub
    Private Sub TDescricao_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TDescricao.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            SendKeys.Send("{TAB}")
            TResp.Focus()
        End If
    End Sub
    Private Sub somagrid()
        Dim linha As DataGridViewRow
        Dim valor As Double
        For Each linha In DgManutencao.Rows
            valor = valor + linha.Cells(4).Value

        Next
        LbTotal.Text = FormatCurrency(valor)

    End Sub

    Private Sub TValor_TextChanged(sender As Object, e As EventArgs) Handles TValor.TextChanged

    End Sub

    Private Sub TValor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TValor.KeyPress
        Format(TValor.Text, "Currency")
    End Sub
    Public Sub contarlinhas()
        Dim numlinhas As Integer = DgManutencao.RowCount - 1
        Dim contador As Integer = 0
        While (numlinhas >= 0)
            contador = contador + 1
            numlinhas = numlinhas - 1
        End While
        LbQtderegistro.Text = contador & " Registros"
    End Sub
End Class