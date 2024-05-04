Imports System.Data.SqlClient
Imports System.Net.Security
'Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Header
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Tab

Public Class Frm_Item


    Private Sub Limparcampos()
        TNome.Text = ""
        TSenha.Text = ""
        TCodigo.Text = ""
        CbAtivo.SelectedIndex = -1
        TObs.Text = ""

    End Sub
    Private Sub controlebotoesinicial()
        'controle de botões
        BtNovo.Visible = True
        BtSalvar.Visible = False
        BtCancelar.Visible = False
        BtEditar.Visible = True
        BtAtualizar.Visible = False
        BtExcluir.Enabled = True
        BtFechar.Enabled = True
        'Controle de caixa em grupo
        GbDados.Enabled = False
        GbPesquisa.Enabled = True
        'Controle de datagrid
        DgItemCad.DataSource = Nothing
        carregagriditem()
        DgItemCad.Enabled = True
        GbPesquisa.Enabled = True
        Limparcampos()
    End Sub
    Private Sub controlebotoesfinal()
        BtNovo.Visible = False
        BtSalvar.Visible = True
        BtCancelar.Visible = True
        BtEditar.Visible = False
        BtAtualizar.Visible = False
        BtExcluir.Enabled = False
        BtFechar.Enabled = False
        GbDados.Enabled = True
        Limparcampos()
        'DgItemCad.DataSource = Nothing ' limpa grid
        DgItemCad.Enabled = False
        GbPesquisa.Enabled = False
    End Sub
    Private Sub controlebotoesatualizar()
        BtNovo.Visible = False
        BtSalvar.Visible = False
        BtCancelar.Visible = True
        BtEditar.Visible = False
        BtAtualizar.Visible = True
        BtExcluir.Enabled = False
        BtFechar.Enabled = False
        GbDados.Enabled = True
        DgItemCad.Enabled = False
        GbPesquisa.Enabled = False
        Limparcampos()
    End Sub
    Private Sub BtFechar_Click(sender As Object, e As EventArgs)
        Close()
    End Sub

    Private Sub Frm_Item_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        controlebotoesinicial()
    End Sub
    Private Sub inserirItem()
        Try
            Using cn = New SqlConnection(strcon)
                cn.Open()
                Dim sql = "INSERT INTO EMAIL_ITEM (NOME,TIPO,SENHA,ATIVO,OBS) 
                           VALUES (@NOME,@TIPO,@SENHA,@ATIVO,@OBS)"
                Using cmd = New SqlCommand(sql, cn)
                    cmd.Parameters.AddWithValue("@NOME", TNome.Text)
                    cmd.Parameters.AddWithValue("@ATIVO", IIf(Microsoft.VisualBasic.Left(CbAtivo.Text, 1) = "S", 1, 0))
                    cmd.Parameters.AddWithValue("@SENHA", TSenha.Text)
                    cmd.Parameters.AddWithValue("@TIPO", CbTipo.Text)
                    cmd.Parameters.AddWithValue("@OBS", TObs.Text)
                    cmd.ExecuteNonQuery()
                End Using
                MsgBox("Registro salvo com sucesso ", vbInformation, "Aviso!")
                cn.Close()
            End Using
        Catch ex As Exception
            MsgBox("Ops, ocorreu um erro ao inserir o registro.#Itens " & vbNewLine & vbNewLine & ex.Message, vbCritical)
        End Try

    End Sub
    Sub carregagriditem()

        Try
            Using cn = New SqlConnection(strcon)
                cn.Open()
                Dim sql = "SELECT ID_ITEM,NOME Nome,TIPO Tipo,ATIVO FROM EMAIL_ITEM where nome like '%" & Tpesquisa.Text & "%' or tipo like '%" & Tpesquisa.Text & "%'"
                Using dap = New SqlDataAdapter(sql, cn)
                    Using dt = New DataTable()
                        dap.Fill(dt)
                        DgItemCad.DataSource = dt
                        With DgItemCad 'with significa com e substitui variavel a frente dele
                            .Columns(0).Visible = False
                            .Columns(1).Width = 300
                            .Columns(2).Width = 100
                            .Columns(3).Visible = False
                            For Each row As DataGridViewRow In .Rows
                                If row.Cells(3).Value = 0 Then
                                    row.Cells(3).Style.ForeColor = Color.Red
                                    row.DefaultCellStyle.ForeColor = Color.Red
                                End If
                            Next
                            contarlinhas()
                        End With
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Ops... ocorreu um erro,favor verifique a conexão!#carregagrid ", vbExclamation, "Aviso! ")
        End Try
    End Sub
    Private Sub SelecionaItem()
        Try
            Using cn = New SqlConnection(strcon)
                Dim id = DgItemCad.Rows(DgItemCad.CurrentCell.RowIndex).Cells(0).Value
                cn.Open()
                Dim sql = "SELECT * FROM EMAIL_ITEM WHERE ID_ITEM=" & id
                Using cmd = New SqlCommand(sql, cn)
                    Using dr = cmd.ExecuteReader
                        If dr.HasRows Then
                            If dr.Read Then
                                CbTipo.Text = dr("TIPO")
                                TNome.Text = dr("NOME")
                                TObs.Text = dr("OBS")
                                TSenha.Text = dr("SENHA")
                                TCodigo.Text = dr("id_item")
                                If dr("ATIVO") Then
                                    CbAtivo.Text = "Sim"
                                Else
                                    CbAtivo.Text = "Não"
                                End If
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
    Private Sub AlterarRegistroitem()


        If TCodigo.Text = "" Then
            MsgBox("Primeiro deve selecionar um registro!", vbInformation, "Aviso!")
        Else
            Try


                Using cn = New SqlConnection(strcon)

                    cn.Open()
                    Dim id = DgItemCad.Rows(DgItemCad.CurrentCell.RowIndex).Cells(0).Value
                    Dim sql = "UPDATE EMAIL_ITEM SET NOME=@NOME,TIPO=@TIPO,SENHA=@SENHA,ATIVO=@ATIVO,OBS=@OBS WHERE ID_ITEM=" & id
                    Using cmd = New SqlCommand(sql, cn)
                        cmd.Parameters.AddWithValue("@TIPO", CbTipo.Text)
                        cmd.Parameters.AddWithValue("@NOME", TNome.Text)
                        cmd.Parameters.AddWithValue("@OBS", TObs.Text)
                        cmd.Parameters.AddWithValue("@SENHA", TSenha.Text)
                        cmd.Parameters.AddWithValue("@ATIVO", IIf(Microsoft.VisualBasic.Left(CbAtivo.Text, 1) = "S", 1, 0))
                        cmd.ExecuteNonQuery()
                        MsgBox("Registro atualizado com sucesso!", vbInformation, "Aviso!")
                    End Using
                End Using
            Catch ex As Exception
                MsgBox("Algo deu errado com a conexão! #alteraregistroitem" & vbNewLine & vbNewLine & ex.Message, vbCritical)
            End Try
        End If

    End Sub
    Private Sub ExcluirRegistro()
        Dim id = DgItemCad.Rows(DgItemCad.CurrentCell.RowIndex).Cells(0).Value
        If MsgBox("Deseja excluir o registro selecionado? ", vbQuestion + vbYesNo, "Aviso!") = vbYes Then
            Try
                Using cn = New SqlConnection(strcon)
                    cn.Open()
                    Dim sql = "DELETE FROM EMAIL_ITEM WHERE ID_ITEM=" & id
                    Using cmd = New SqlCommand(sql, cn)
                        cmd.ExecuteNonQuery()
                    End Using
                End Using
            Catch ex As Exception
                MsgBox("Algo deu errado com a conexão!" & vbNewLine & vbNewLine & ex.Message, vbCritical)
            End Try
        End If

    End Sub
    Public Sub contarlinhas()
        Dim numlinhas As Integer = DgItemCad.RowCount - 1
        Dim contador As Integer = 0
        While (numlinhas >= 0)
            contador = contador + 1
            numlinhas = numlinhas - 1
        End While
        LbContaLinhas.Text = contador & " Registros"
    End Sub

    Private Sub BtBuscar_Click(sender As Object, e As EventArgs) Handles BtBuscar.Click
        carregagriditem()
    End Sub


    Private Sub BtSalvar_Click(sender As Object, e As EventArgs) Handles BtSalvar.Click
        controlebotoesinicial()
        inserirItem()
    End Sub

    Private Sub BtNovo_Click(sender As Object, e As EventArgs) Handles BtNovo.Click
        controlebotoesfinal()
    End Sub

    Private Sub DgItemCad_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgItemCad.CellContentClick

    End Sub

    Private Sub DgItemCad_DoubleClick(sender As Object, e As EventArgs) Handles DgItemCad.DoubleClick
        SelecionaItem()
    End Sub

    Private Sub BtAtualizar_Click(sender As Object, e As EventArgs) Handles BtAtualizar.Click
        AlterarRegistroitem()
        controlebotoesinicial()
    End Sub

    Private Sub BtExcluir_Click(sender As Object, e As EventArgs) Handles BtExcluir.Click
        If TCodigo.Text = "" Then
            MsgBox("Primeiro deve selecionar um item!", vbInformation, "Aviso")
        Else
            ExcluirRegistro()
            controlebotoesinicial()
        End If

    End Sub

    Private Sub BtEditar_Click(sender As Object, e As EventArgs) Handles BtEditar.Click
        controlebotoesatualizar()
    End Sub

    Private Sub BtCancelar_Click(sender As Object, e As EventArgs) Handles BtCancelar.Click
        controlebotoesinicial()
    End Sub

    Private Sub Envioemail_Click(sender As Object, e As EventArgs) Handles Envioemail.Click
        Frm_EnviarEmail.ShowDialog()
    End Sub
    Private Sub Tpesquisa_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Tpesquisa.KeyPress
        carregagriditem()

    End Sub

    Private Sub BtFechar_Click_1(sender As Object, e As EventArgs) Handles BtFechar.Click
        Close()
    End Sub

    Private Sub AgrupadoPorEmailToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgrupadoPorEmailToolStripMenuItem.Click
        Frm_Rel_Agrupado_Email.ShowDialog()
    End Sub

    Private Sub ListagemEmailItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListagemEmailItemToolStripMenuItem.Click
        Frm_Rel_ListagemEmail_Item.ShowDialog()

    End Sub

    Private Sub DgItemCad_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgItemCad.CellClick
        SelecionaItem()
    End Sub

    Private Sub CbTipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbTipo.SelectedIndexChanged

    End Sub

    Private Sub CbTipo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CbTipo.KeyPress
        ChangeFocusOnEnterKeyPress(sender, e)
    End Sub
End Class