Imports System.ComponentModel
Imports System.Data.SqlClient
Imports Microsoft.CodeAnalysis.Operations

Public Class Frm_Usuario
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
        grbox.Enabled = False
        gbpesq.Enabled = True
        'Controle de datagrid
        dgusuario.DataSource = Nothing
        carregagridusuario()
        dgusuario.Enabled = True

    End Sub
    Private Sub controlebotoesfinal()
        BtNovo.Visible = False
        BtSalvar.Visible = True
        BtCancelar.Visible = True
        BtEditar.Visible = False
        BtAtualizar.Visible = False
        BtExcluir.Enabled = False
        BtFechar.Enabled = False
        grbox.Enabled = True
        'Limpeza de campos.
        'CbTipo.SelectedIndex = 0
        'cbativo.SelectedIndex = 0
        'Tnome.Text = ""
        'Tsenha.Text = ""
        'TObs.Text = ""
        'Tcodigo.Text = ""
        'DgItemCad.DataSource = Nothing ' limpa grid
        'DgItemCad.Enabled = False
        'GbPesquisa.Enabled = False
    End Sub
    Private Sub controlebotoesatualizar()
        BtNovo.Visible = False
        BtSalvar.Visible = False
        BtCancelar.Visible = True
        BtEditar.Visible = False
        BtAtualizar.Visible = True
        BtExcluir.Enabled = False
        BtFechar.Enabled = False
        grbox.Enabled = True
        gbpesq.Enabled = False
        dgusuario.Refresh()

    End Sub
    Private Sub Frm_Usuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carregagridusuario()
        controlebotoesinicial()
        controlebotoesinicial()
    End Sub
    Private Sub carregagridusuario()
        Try

            Using cn = New SqlConnection(strcon)
                cn.Open()
                Dim sql = "SELECT a.id_usuarios Código,a.nome Nome,a.ativo Ativo	
                            FROM usuarios A WHERE (PATINDEX('%" & txtpesquisa.Text & "%',a.nome)>0)"
                Using dap = New SqlDataAdapter(sql, cn)
                    Using dt = New DataTable()
                        dap.Fill(dt)
                        dgusuario.DataSource = dt
                        With dgusuario 'with significa com e substitui variavel a frente dele
                            .Columns(0).Width = 80
                            .Columns(1).Width = 460
                            .Columns(2).Width = 80

                        End With
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Ops... ocorreu um erro,favor verifique a conexão! ", vbExclamation, "Aviso! ")
        End Try
        txtpesquisa.Text = ""
    End Sub
    Private Sub BtFechar_Click(sender As Object, e As EventArgs) Handles BtFechar.Click
        If BtNovo.Visible = False Then
            MsgBox("Formulário em edição", vbInformation, "Aviso!")
        Else
            Close()
        End If

    End Sub

    Private Sub BtSalvar_Click(sender As Object, e As EventArgs) Handles BtSalvar.Click
        INSERIRDADOS()
        controlebotoesinicial()

    End Sub

    Private Sub BtAtualizar_Click(sender As Object, e As EventArgs) Handles BtAtualizar.Click
        ALTERARDADOS()
        controlebotoesinicial()

    End Sub

    Private Sub BtCancelar_Click(sender As Object, e As EventArgs) Handles BtCancelar.Click
        controlebotoesinicial()
    End Sub

    Private Sub BtEditar_Click(sender As Object, e As EventArgs) Handles BtEditar.Click
        If Tcodigo.Text = "" Then
            MsgBox("Nenhum registro selecionado", vbInformation, "Aviso!")
        Else
            controlebotoesatualizar()
            TabControl1.SelectedTab = tbdados
        End If

    End Sub

    Private Sub BtNovo_Click(sender As Object, e As EventArgs) Handles BtNovo.Click
        controlebotoesfinal()
        'LIMPAR OS CAMPOS DO FORMULARIO
        Tnome.Text = ""
        Tsenha.Text = ""
        Cbacesso.SelectedIndex = -1
        Tcodigo.Text = ""
        cbativo.SelectedIndex = 0

        TabControl1.SelectedTab = tbdados
    End Sub
    Private Sub txtpesquisa_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtpesquisa.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            SendKeys.Send("{TAB}")
            carregagridusuario()
        End If
    End Sub

    Private Sub BtExcluir_Click(sender As Object, e As EventArgs) Handles BtExcluir.Click
        If Tcodigo.Text = "" Then
            MsgBox("Selecione um registro para exclusão", vbExclamation, "Aviso!")

        Else
            EXCLUIRREGISTRO()

        End If
    End Sub
    Private Sub INSERIRDADOS()

        Try
            Using cn = New SqlConnection(strcon)
                cn.Open()
                Dim sql = "INSERT INTO USUARIOS 
                                               (NOME,ATIVO,SENHA)
                           VALUES  (@NOME,@ATIVO,@SENHA)"
                Using cmd = New SqlCommand(sql, cn)
                    cmd.Parameters.AddWithValue("@NOME", Tnome.Text)
                    cmd.Parameters.AddWithValue("@ATIVO", IIf(Microsoft.VisualBasic.Left(cbativo.Text, 1) = "S", 1, 0))
                    cmd.Parameters.AddWithValue("@SENHA", Tsenha.Text)
                    ' cmd.Parameters.AddWithValue("@SENHA", Tsenha.Text.Replace(",", ".")) CONVERTER PARA INCLUSÃO NO BANCO
                    ' cmd.Parameters.AddWithValue("@ID_NIVEL", Microsoft.VisualBasic.Left(Cbacesso.Text, 1))
                    cmd.ExecuteNonQuery()

                    MsgBox("Registro salvo com sucesso!", vbInformation, "Aviso!")

                End Using
            End Using
        Catch ex As Exception
            MsgBox("Algo deu errado com a conexão!" & vbNewLine & vbNewLine & ex.Message, vbCritical)
        End Try
    End Sub
    Private Sub SELECIONADADOS()

        ' Tcodigo.Text = id

        Try
            Using cn = New SqlConnection(strcon)
                Dim id = dgusuario.Rows(dgusuario.CurrentCell.RowIndex).Cells(0).Value
                cn.Close()
                cn.Open()
                Dim sql = "select * from usuarios where id_usuarios=" & id
                Using cmd = New SqlCommand(sql, cn)
                    Using dr = cmd.ExecuteReader
                        If dr.HasRows Then
                            If dr.Read Then
                                'tidfuncionario.Text = dr("id_func")
                                Tcodigo.Text = dr("id_usuarios")
                                Tnome.Text = dr("nome")
                                Tsenha.Text = dr("Senha")
                                Cbacesso.SelectedIndex = 0
                                If dr("ATIVO") Then
                                    cbativo.Text = "SIM"
                                Else
                                    cbativo.Text = "NÃO"
                                End If
                            End If
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            Dim unused = MsgBox("Algo deu errado com a conexão!" & vbNewLine & vbNewLine & ex.Message, vbCritical)
        End Try

    End Sub
    Private Sub ALTERARDADOS()
        Dim id = dgusuario.Rows(dgusuario.CurrentCell.RowIndex).Cells(0).Value
        Try
            Using cn = New SqlConnection(strcon)
                cn.Open()

                Dim sql = "UPDATE USUARIOS SET NOME=@NOME, ATIVO=@ATIVO,ID_NIVEL=@ID_NIVEL WHERE ID_USUARIOS=" & id
                Using cmd = New SqlCommand(sql, cn)
                    cmd.Parameters.AddWithValue("@NOME", Tnome.Text)
                    ' cmd.Parameters.AddWithValue("@ID_FUNC", tidfuncionario.Text)
                    cmd.Parameters.AddWithValue("@ATIVO", IIf(Microsoft.VisualBasic.Left(cbativo.Text, 1) = "S", 1, 0))
                    cmd.Parameters.AddWithValue("@ID_NIVEL", 1)
                    cmd.ExecuteNonQuery()

                    MsgBox("Registro atualizado com sucesso!", vbInformation, "Aviso!")

                End Using
            End Using
        Catch ex As Exception
            MsgBox("Algo deu errado com a conexão!" & vbNewLine & vbNewLine & ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub dgusuario_DoubleClick(sender As Object, e As EventArgs) Handles dgusuario.DoubleClick
        SELECIONADADOS()
        ' pegafuncionario()
        TabControl1.SelectedTab = tbdados
    End Sub
    Private Sub EXCLUIRREGISTRO()
        Dim id = dgusuario.Rows(dgusuario.CurrentCell.RowIndex).Cells(0).Value
        If MsgBox("Desea excluir o registro? ", vbQuestion + vbYesNo, "Aviso!") = vbYes Then
            Try
                Using cn = New SqlConnection(strcon)
                    cn.Open()
                    Dim sql = "DELETE FROM USUARIOS WHERE ID_USUARIOS=" & id
                    Using cmd = New SqlCommand(sql, cn)
                        cmd.ExecuteNonQuery()
                    End Using
                End Using
            Catch ex As Exception
                MsgBox("Algo deu errado com a conexão!" & vbNewLine & vbNewLine & ex.Message, vbCritical)
            End Try
        End If
    End Sub

    Private Sub Bt_Buscar_Click(sender As Object, e As EventArgs) Handles Bt_Buscar.Click
        carregagridusuario()
    End Sub
End Class