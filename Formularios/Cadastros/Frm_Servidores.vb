Imports System.Data.SqlClient

Public Class Frm_Servidores
    Private Sub Frm_Servidores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CarregaGridServidores()
        controlebotoesinicial()
        controlebtusuariosinicial()
    End Sub
    Private Sub controlebtusuariosinicial()
        BtAtualizarItem.Visible = False
        BtExcluirItem.Enabled = False
        BtCancelarItem.Enabled = False
        BtIncluirUsuario.Visible = True
    End Sub
    Private Sub controlebtusuariosfinal()
        BtAtualizarItem.Visible = True
        BtExcluirItem.Enabled = True
        BtCancelarItem.Enabled = True
        BtIncluirUsuario.Visible = False
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
        GbPesquisa.Enabled = True
        'Controle de datagrid
        DgUsuarios.DataSource = Nothing
        CarregaGridServidores()
        DgUsuarios.Enabled = True
        GbPesquisa.Enabled = True
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
        CbAtivo.SelectedIndex = 0
        TNome.Text = ""
        TSenha.Text = ""
        TCodigo.Text = ""
        DgUsuarios.Enabled = False
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
        DgUsuarios.Enabled = True
        GbPesquisa.Enabled = False
    End Sub
    Sub CarregaGridServidores()

        Try
            Using cn = New SqlConnection(strcon)
                cn.Open()
                Dim sql = "SELECT ID_SERVIDOR Código,NOME Nome,IP,ATIVO Ativo 
                            FROM SERVIDORES
                            where NOME  LIKE '%" & Tpesquisa.Text & "%' OR IP  LIKE '%" & Tpesquisa.Text & "%'"
                Using dap = New SqlDataAdapter(sql, cn)
                    Using dt = New DataTable()
                        dap.Fill(dt)
                        DgServidores.DataSource = dt
                        With DgServidores 'with significa com e substitui variavel a frente dele
                            .Columns(0).Width = 60
                            .Columns(1).Width = 100
                            .Columns(2).Width = 80
                            .Columns(3).Width = 80
                            For Each row As DataGridViewRow In .Rows
                                If row.Cells(3).Value = 0 Then
                                    row.Cells(3).Style.ForeColor = Color.Red
                                    row.DefaultCellStyle.ForeColor = Color.Red
                                End If
                            Next
                            contarlinhasServidor()
                        End With
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Ops... ocorreu um erro,favor verifique a conexão!#carregagrid ", vbExclamation, "Aviso! ")
        End Try
    End Sub
    Sub CarregaGridUsuarios()
        Dim id = DgServidores.Rows(DgServidores.CurrentCell.RowIndex).Cells(0).Value
        Try
            Using cn = New SqlConnection(strcon)
                cn.Open()
                Dim sql = "SELECT ID_USUARIO Código,NOME Nome,SENHA Senha 
                            FROM SERVIDORES_USUARIOS WHERE ID_SERVIDOR = " & id
                Using dap = New SqlDataAdapter(sql, cn)
                    Using dt = New DataTable()
                        dap.Fill(dt)
                        DgUsuarios.DataSource = dt
                        With DgUsuarios 'with significa com e substitui variavel a frente dele
                            .Columns(0).Width = 80
                            .Columns(1).Width = 180
                            .Columns(2).Width = 120
                            contarlinhasUsuarios()
                        End With
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Ops... ocorreu um erro,favor verifique a conexão!#carregagrid ", vbExclamation, "Aviso! ")
        End Try
    End Sub
    Private Sub SalvarServidor()
        Try
            Using cn = New SqlConnection(strcon)
                cn.Open()
                Dim sql = "INSERT INTO SERVIDORES (NOME,IP,ATIVO) 
                           VALUES (@NOME,@IP,@ATIVO)"
                Using cmd = New SqlCommand(sql, cn)
                    cmd.Parameters.AddWithValue("@NOME", TNome.Text)
                    cmd.Parameters.AddWithValue("@ATIVO", IIf(Microsoft.VisualBasic.Left(CbAtivo.Text, 1) = "S", 1, 0))
                    cmd.Parameters.AddWithValue("@IP", Tip.Text)
                    cmd.ExecuteNonQuery()
                End Using
                MsgBox("Registro salvo com sucesso ", vbInformation, "Aviso!")
                CarregaGridServidores()
                cn.Close()
            End Using
        Catch ex As Exception
            MsgBox("Ops, ocorreu um erro ao inserir o registro.#Itens " & vbNewLine & vbNewLine & ex.Message, vbCritical)
        End Try
    End Sub
    Private Sub SalvarUsuarioServidor()
        Try
            Using cn = New SqlConnection(strcon)
                cn.Open()
                Dim sql = "INSERT INTO SERVIDORES_USUARIOS (NOME,SENHA,ID_SERVIDOR,NOME_SERVIDOR) 
                           VALUES (@NOME,@SENHA,@ID_SERVIDOR,@NOME_SERVIDOR)"
                Using cmd = New SqlCommand(sql, cn)
                    cmd.Parameters.AddWithValue("@NOME", TUsuarios.Text)
                    cmd.Parameters.AddWithValue("@SENHA", TSenha.Text)
                    cmd.Parameters.AddWithValue("@NOME_SERVIDOR", TNome.Text)
                    cmd.Parameters.AddWithValue("@ID_SERVIDOR", TCodigo.Text)
                    cmd.ExecuteNonQuery()
                End Using
                CarregaGridUsuarios()
                cn.Close()
            End Using
        Catch ex As Exception
            MsgBox("Ops, ocorreu um erro ao inserir o registro.#Itens " & vbNewLine & vbNewLine & ex.Message, vbCritical)
        End Try
    End Sub
    Private Sub SelecionaServidores()
        Try
            Using cn = New SqlConnection(strcon)
                Dim id = DgServidores.Rows(DgServidores.CurrentCell.RowIndex).Cells(0).Value
                cn.Open()
                Dim sql = "SELECT * FROM SERVIDORES WHERE ID_SERVIDOR=" & id
                Using cmd = New SqlCommand(sql, cn)
                    Using dr = cmd.ExecuteReader
                        If dr.HasRows Then
                            If dr.Read Then
                                TNome.Text = dr("NOME")
                                Tip.Text = dr("IP")
                                TCodigo.Text = dr("ID_SERVIDOR")
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
    Private Sub SelecionaUsusarios()
        Try
            Using cn = New SqlConnection(strcon)
                Dim id = DgUsuarios.Rows(DgUsuarios.CurrentCell.RowIndex).Cells(0).Value
                cn.Open()
                Dim sql = "SELECT * FROM SERVIDORES_USUARIOS WHERE ID_USUARIO=" & id
                Using cmd = New SqlCommand(sql, cn)
                    Using dr = cmd.ExecuteReader
                        If dr.HasRows Then
                            If dr.Read Then
                                TUsuarios.Text = dr("NOME")
                                TSenha.Text = dr("SENHA")
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
    Private Sub AlterarServidores()
        Try
            Using cn = New SqlConnection(strcon)

                cn.Open()
                Dim id = DgServidores.Rows(DgServidores.CurrentCell.RowIndex).Cells(0).Value
                Dim sql = "UPDATE SERVIDORES SET NOME=@NOME,IP=@IP,ATIVO=@ATIVO WHERE ID_SERVIDOR=" & id
                Using cmd = New SqlCommand(sql, cn)
                    cmd.Parameters.AddWithValue("@NOME", TNome.Text)
                    cmd.Parameters.AddWithValue("@IP", Tip.Text)
                    cmd.Parameters.AddWithValue("@ATIVO", IIf(Microsoft.VisualBasic.Left(CbAtivo.Text, 1) = "S", 1, 0))
                    cmd.ExecuteNonQuery()
                    MsgBox("Registro atualizado com sucesso!", vbInformation, "Aviso!")
                    CarregaGridServidores()
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Algo deu errado com a conexão! #alteraregistroitem" & vbNewLine & vbNewLine & ex.Message, vbCritical)
        End Try
    End Sub
    Private Sub AlterarUsuarios()
        Try
            Using cn = New SqlConnection(strcon)

                cn.Open()
                Dim id = DgUsuarios.Rows(DgUsuarios.CurrentCell.RowIndex).Cells(0).Value
                Dim sql = "UPDATE SERVIDORES_USUARIOS SET NOME=@NOME,SENHA=@SENHA,NOME_SERVIDOR=@NOME_SERVIDOR WHERE ID_USUARIO=" & id
                Using cmd = New SqlCommand(sql, cn)
                    cmd.Parameters.AddWithValue("@NOME", TUsuarios.Text)
                    cmd.Parameters.AddWithValue("@SENHA", TSenha.Text)
                    cmd.Parameters.AddWithValue("@NOME_SERVIDOR", TNome.Text)
                    cmd.ExecuteNonQuery()
                    MsgBox("Registro atualizado com sucesso!", vbInformation, "Aviso!")
                    CarregaGridUsuarios()
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Algo deu errado com a conexão! #alteraregistroitem" & vbNewLine & vbNewLine & ex.Message, vbCritical)
        End Try
    End Sub
    Private Sub ExcluirServidores()
        Dim id = DgServidores.Rows(DgServidores.CurrentCell.RowIndex).Cells(0).Value
        If MsgBox("Deseja excluir o registro selecionado? ", vbQuestion + vbYesNo, "Aviso!") = vbYes Then
            Try
                Using cn = New SqlConnection(strcon)
                    cn.Open()
                    Dim sql = "DELETE FROM SERVIDORES WHERE ID_SERVIDOR=" & id
                    Using cmd = New SqlCommand(sql, cn)
                        cmd.ExecuteNonQuery()
                    End Using
                End Using
                CarregaGridServidores()
            Catch ex As Exception
                MsgBox("Algo deu errado com a conexão!" & vbNewLine & vbNewLine & ex.Message, vbCritical)
            End Try
        End If
    End Sub
    Private Sub ExcluirUsuarios()
        Dim id = DgUsuarios.Rows(DgUsuarios.CurrentCell.RowIndex).Cells(0).Value
        If MsgBox("Deseja excluir o registro selecionado? ", vbQuestion + vbYesNo, "Aviso!") = vbYes Then
            Try
                Using cn = New SqlConnection(strcon)
                    cn.Open()
                    Dim sql = "DELETE FROM SERVIDORES_USUARIOS WHERE ID_USUARIO=" & id
                    Using cmd = New SqlCommand(sql, cn)
                        cmd.ExecuteNonQuery()
                    End Using
                End Using
                CarregaGridUsuarios()
            Catch ex As Exception
                MsgBox("Algo deu errado com a conexão!" & vbNewLine & vbNewLine & ex.Message, vbCritical)
            End Try
        End If
    End Sub
    Public Sub contarlinhasServidor()
        Dim numlinhas As Integer = DgServidores.RowCount - 1
        Dim contador As Integer = 0
        While (numlinhas >= 0)
            contador = contador + 1
            numlinhas = numlinhas - 1
        End While
        LQtdeServidores.Text = contador & " Registros"
    End Sub
    Public Sub contarlinhasUsuarios()
        Dim numlinhas As Integer = DgUsuarios.RowCount - 1
        Dim contador As Integer = 0
        While (numlinhas >= 0)
            contador = contador + 1
            numlinhas = numlinhas - 1
        End While
        LQtdeUsuarios.Text = contador & " Registros"
    End Sub

    Private Sub BtSalvar_Click(sender As Object, e As EventArgs) Handles BtSalvar.Click
        SalvarServidor()
        controlebotoesinicial()

    End Sub

    Private Sub BtNovo_Click(sender As Object, e As EventArgs) Handles BtNovo.Click
        controlebotoesfinal()

    End Sub

    Private Sub DgServidores_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgServidores.CellContentClick

    End Sub

    Private Sub DgServidores_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgServidores.CellClick
        SelecionaServidores()
        CarregaGridUsuarios()
    End Sub

    Private Sub BtFechar_Click(sender As Object, e As EventArgs) Handles BtFechar.Click
        Close()
    End Sub

    Private Sub BtExcluir_Click(sender As Object, e As EventArgs) Handles BtExcluir.Click
        If TCodigo.Text = "" Then
            MsgBox("Primeiro deve selecionar um registro!", vbInformation, "Aviso")
        Else
            ExcluirServidores()
            controlebotoesinicial()
        End If

    End Sub

    Private Sub BtEditar_Click(sender As Object, e As EventArgs) Handles BtEditar.Click
        If TCodigo.Text = "" Then
            MsgBox("Primeiro deve selecionar um registro!", vbInformation, "Aviso")
        Else
            controlebotoesatualizar()
        End If

    End Sub

    Private Sub BtAtualizar_Click(sender As Object, e As EventArgs) Handles BtAtualizar.Click
        AlterarServidores()
        controlebotoesinicial()
    End Sub

    Private Sub BtBuscar_Click(sender As Object, e As EventArgs) Handles BtBuscar.Click
        CarregaGridServidores()
    End Sub

    Private Sub BtCancelar_Click(sender As Object, e As EventArgs) Handles BtCancelar.Click
        controlebotoesinicial()
    End Sub

    Private Sub BtExcluirItem_Click(sender As Object, e As EventArgs) Handles BtExcluirItem.Click
        ExcluirUsuarios()
        'controle de botões
        TUsuarios.Text = ""
        TSenha.Text = ""
        'controle de botções
        controlebtusuariosinicial()
    End Sub

    Private Sub BtAtualizarItem_Click(sender As Object, e As EventArgs) Handles BtAtualizarItem.Click
        AlterarUsuarios()
        'controle de botões
        TUsuarios.Text = ""
        TSenha.Text = ""
        'controle de botções
        controlebtusuariosinicial()
    End Sub

    Private Sub BtIncluirUsuario_Click(sender As Object, e As EventArgs) Handles BtIncluirUsuario.Click
        SalvarUsuarioServidor()
    End Sub

    Private Sub DgUsuarios_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgUsuarios.CellClick
        SelecionaUsusarios()
    End Sub

    Private Sub BtCancelarItem_Click(sender As Object, e As EventArgs) Handles BtCancelarItem.Click
        'controle de botões
        TUsuarios.Text = ""
        TSenha.Text = ""
        'controle de botções
        controlebtusuariosinicial()
    End Sub

    Private Sub DgUsuarios_DoubleClick(sender As Object, e As EventArgs) Handles DgUsuarios.DoubleClick
        SelecionaUsusarios()
        'controle de botções
        controlebtusuariosfinal()
    End Sub

    Private Sub Tpesquisa_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Tpesquisa.KeyPress
        CarregaGridServidores()
    End Sub

    Private Sub ImprimirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImprimirToolStripMenuItem.Click
        If TCodigo.Text = "" Then
            MsgBox("Primeiro deve selecionar um registro!", vbInformation, "Aviso")
        Else
            Frm_Rel_Detalhado_Servidor.ShowDialog()
        End If

    End Sub

    Private Sub ListagemServidorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListagemServidorToolStripMenuItem.Click
        Frm_Rel_Listagem_Servidor.ShowDialog()
    End Sub

    Private Sub AgrupadoPorServidorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgrupadoPorServidorToolStripMenuItem.Click
        Frm_Rel_Agrupado_Servidor.ShowDialog()
    End Sub

    Private Sub Tpesquisa_TextChanged(sender As Object, e As EventArgs) Handles Tpesquisa.TextChanged

    End Sub
End Class