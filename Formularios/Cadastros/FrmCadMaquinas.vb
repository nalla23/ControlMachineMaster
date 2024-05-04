Imports System.Data.SqlClient
Imports System.DirectoryServices.ActiveDirectory
Imports System.Net

Public Class FrmCadMaquinas
    Private Sub controlebotoesinicial()
        BtNovo.Visible = True
        BtSalvar.Visible = False
        BtCancelar.Visible = False
        BtEditar.Visible = True
        BtAtualizar.Visible = False
        BtExcluir.Enabled = True
        BtFechar.Enabled = True
        GbDados.Enabled = False
        GbListagem.Enabled = False
        Gbsenha.Enabled = False
        'Limpeza de campos.
        TNome.Text = ""
        TUsuario.Text = ""
        CbAtivo.Text = ""
        TSenha.Text = ""
        tidmaquina.Text = ""
        Tprocessador.Text = ""
        TGhz.Text = ""
        TMemoria.Text = ""
        TDdr.Text = ""
        THd1.Text = ""
        THd2.Text = ""
        TWindows.Text = ""
        TSenhaEmail.Text = ""
        CbEmail.Text = ""
        TSenhaOffice.Text = ""
        Cbemailoffice.Text = ""
        CbAtivo.SelectedIndex = 0
        CbContaAntiVirus.Text = ""
        CbModelo.SelectedIndex = -1
        TIdentificacao.Text = ""
        TNHD.Text = ""
        ' DG1.DataSource = Nothing
        DgEquipamentos.Enabled = True
        GbPesquisaEquipamento.Enabled = True
        MenuStrip1.Enabled = True
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
        Gbsenha.Enabled = True
        GbListagem.Enabled = False
        'Limpeza de campos.
        TNome.Text = ""
        TUsuario.Text = ""
        CbAtivo.Text = ""
        TSenha.Text = ""
        tidmaquina.Text = ""
        Tprocessador.Text = ""
        TGhz.Text = ""
        TMemoria.Text = ""
        TDdr.Text = ""
        THd1.Text = ""
        THd2.Text = ""
        TWindows.Text = ""
        TSenhaEmail.Text = ""
        CbEmail.Text = ""
        TSenhaOffice.Text = ""
        Cbemailoffice.Text = ""
        CbModelo.SelectedIndex = -1
        TIdentificacao.Text = ""
        CbAtivo.SelectedIndex = 0
        CbContaAntiVirus.Text = ""
        TNHD.Text = ""
        CbRealizado.SelectedIndex = 0
        DG1.DataSource = Nothing ' limpa grid de itens.
        DgEquipamentos.Enabled = False
        GbPesquisaEquipamento.Enabled = False
        MenuStrip1.Enabled = False

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
        Gbsenha.Enabled = True
        GbListagem.Enabled = True
        CbRealizado.SelectedIndex = 1
        DgEquipamentos.Enabled = False
        GbPesquisaEquipamento.Enabled = False
        MenuStrip1.Enabled = False


    End Sub


    Private Sub BtAtualizar_Click(sender As Object, e As EventArgs) Handles BtAtualizar.Click
        AlterarRegistro()
        controlebotoesinicial()
        DgEquipamentos.DataSource = Nothing
        DG1.DataSource = Nothing
        carregagridequipamento()
    End Sub

    Private Sub BtCancelar_Click(sender As Object, e As EventArgs) Handles BtCancelar.Click
        controlebotoesinicial()
    End Sub
    Private Sub BtEditar_Click(sender As Object, e As EventArgs) Handles BtEditar.Click
        If tidmaquina.Text = "" Then
            MsgBox("Precisa selecionar um registro no quando ao lado!", vbInformation, "Aviso!")
        Else
            controlebotoesatualizar()
        End If
    End Sub

    Private Sub BtExcluir_Click(sender As Object, e As EventArgs) Handles BtExcluir.Click
        If tidmaquina.Text = "" Then
            MsgBox("Precisa selecionar um registro no quando ao lado!", vbInformation, "Aviso!")
        Else
            ExcluirRegistro()
        End If
    End Sub

    Private Sub BtFechar_Click(sender As Object, e As EventArgs) Handles BtFechar.Click
        Close()
    End Sub
    Private Sub BtNovo_Click(sender As Object, e As EventArgs) Handles BtNovo.Click
        controlebotoesfinal()
    End Sub

    Private Sub BtSalvar_Click(sender As Object, e As EventArgs) Handles BtSalvar.Click
        INSERIRDADOS()
        controlebotoesinicial()
        DgEquipamentos.DataSource = Nothing
        carregagridequipamento()
    End Sub
    Private Sub INSERIRDADOS()
        Try
            Using cn = New SqlConnection(strcon)
                cn.Open()
                Dim sql = "INSERT INTO EQUIPAMENTO 
                                               (EQUIPAMENTO,USUARIO,SENHA,PROCESSADOR,GHZ,MEMORIA,HD1,HD2,WINDOWS,DDR,ATIVO,OBS, EMAIL,EMAIL_SENHA,EMAIL_ANTIVIRUS,
                                                SENHA_ANTIVIRUS,SENHA_OFFICE,EMAIL_OFFICE, MODELO,IDENTIFICACAO,NUMERO_HD, ID_MODELO) 
                           VALUES  (@EQUIPAMENTO,@USUARIO,@SENHA,@PROCESSADOR,@GHZ,@MEMORIA,@HD1,@HD2,@WINDOWS,@DDR,@ATIVO,@OBS,@EMAIL,@EMAIL_SENHA,@EMAIL_ANTIVIRUS,
                                    @SENHA_ANTIVIRUS,@SENHA_OFFICE,@EMAIL_OFFICE,@MODELO,@IDENTIFICACAO,@NHD,@IDMODELO)"
                Using cmd = New SqlCommand(sql, cn)
                    cmd.Parameters.AddWithValue("@EQUIPAMENTO", TNome.Text)
                    cmd.Parameters.AddWithValue("@USUARIO", TUsuario.Text)
                    cmd.Parameters.AddWithValue("@SENHA", TSenha.Text)
                    cmd.Parameters.AddWithValue("@PROCESSADOR", Tprocessador.Text)
                    cmd.Parameters.AddWithValue("@GHZ", TGhz.Text)
                    cmd.Parameters.AddWithValue("@MEMORIA", TMemoria.Text)
                    cmd.Parameters.AddWithValue("@HD1", THd1.Text)
                    cmd.Parameters.AddWithValue("@HD2", THd2.Text)
                    cmd.Parameters.AddWithValue("@WINDOWS", TWindows.Text)
                    cmd.Parameters.AddWithValue("@OBS", TObsEquipamento.Text)
                    cmd.Parameters.AddWithValue("@DDR", TDdr.Text)
                    cmd.Parameters.AddWithValue("@EMAIL", CbEmail.Text)
                    cmd.Parameters.AddWithValue("@EMAIL_SENHA", TSenhaEmail.Text)
                    cmd.Parameters.AddWithValue("@EMAIL_ANTIVIRUS", CbContaAntiVirus.Text)
                    cmd.Parameters.AddWithValue("@SENHA_ANTIVIRUS", TSenhaAntiVirus.Text)
                    cmd.Parameters.AddWithValue("@EMAIL_OFFICE", Cbemailoffice.Text)
                    cmd.Parameters.AddWithValue("@SENHA_OFFICE", TSenhaOffice.Text)
                    cmd.Parameters.AddWithValue("@MODELO", CbModelo.Text)
                    cmd.Parameters.AddWithValue("@IDENTIFICACAO", CbModelo.Text)
                    cmd.Parameters.AddWithValue("@NHD", TNHD.Text)
                    cmd.Parameters.AddWithValue("@ATIVO", IIf(Microsoft.VisualBasic.Left(CbAtivo.Text, 1) = "S", 1, 0))
                    cmd.Parameters.AddWithValue("@IDMODELO", CbModelo.SelectedValue)
                    cmd.ExecuteNonQuery()
                End Using
                MsgBox("Registro salvo com sucesso ", vbInformation, "Aviso!")
                cn.Close()
            End Using
        Catch ex As Exception
            MsgBox("Ops, ocorreu um erro ao inserir o registro de conta " & vbNewLine & vbNewLine & ex.Message, vbCritical)
        End Try
    End Sub
    Private Sub inserirItem()
        Dim id = DgEquipamentos.Rows(DgEquipamentos.CurrentCell.RowIndex).Cells(0).Value
        Try
            Using cn = New SqlConnection(strcon)
                cn.Open()
                Dim sql = "INSERT INTO ITEM_EQUIPAMENTO (ITEM,REALIZADO,DTLAN,ID_EQUIPAMENTO,OBS) 
                           VALUES (@ITEM,@REALIZADO,@DTLAN,@ID_EQUIPAMENTO,@OBS)"
                Using cmd = New SqlCommand(sql, cn)
                    cmd.Parameters.AddWithValue("@ITEM", CbItem.Text)
                    cmd.Parameters.AddWithValue("@REALIZADO", IIf(Microsoft.VisualBasic.Left(CbRealizado.Text, 1) = "S", 1, 0))
                    cmd.Parameters.AddWithValue("@DTLAN", DtData.Text)
                    cmd.Parameters.AddWithValue("@OBS", TObsItem.Text)
                    cmd.Parameters.AddWithValue("@ID_EQUIPAMENTO", id)
                    ' cmd.Parameters.AddWithValue("@GHZ", TGhz.Text)
                    cmd.ExecuteNonQuery()
                End Using
                'MsgBox("Registro salvo com sucesso ", vbInformation, "Aviso!")
                cn.Close()
            End Using
        Catch ex As Exception
            MsgBox("Ops, ocorreu um erro ao inserir o registro de conta " & vbNewLine & vbNewLine & ex.Message, vbCritical)
        End Try
    End Sub
    Sub carregagriditem()

        Try
            Using cn = New SqlConnection(strcon)
                cn.Open()
                Dim sql = "SELECT ID_ITEM,ITEM,REALIZADO,DTLAN,OBS FROM ITEM_EQUIPAMENTO WHERE  id_equipamento = '" & tidmaquina.Text & "'"
                Using dap = New SqlDataAdapter(sql, cn)
                    Using dt = New DataTable()
                        dap.Fill(dt)
                        DG1.DataSource = dt
                        With DG1 'with significa com e substitui variavel a frente dele
                            .Columns(0).Width = 30
                            .Columns(1).Width = 230
                            .Columns(2).Width = 80
                            .Columns(3).Width = 100
                            .Columns(4).Width = 300
                            For Each row As DataGridViewRow In .Rows
                                If row.Cells(2).Value = 0 Then
                                    row.Cells(2).Style.ForeColor = Color.Red
                                    row.DefaultCellStyle.ForeColor = Color.Red
                                End If
                            Next
                        End With
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Ops... ocorreu um erro,favor verifique a conexão!#carregagrid ", vbExclamation, "Aviso! ")
        End Try
    End Sub
    Sub carregagridequipamento()
        Try
            Using cn = New SqlConnection(strcon)
                cn.Open()
                Dim sql = "SELECT ID_EQUIPAMENTO,EQUIPAMENTO, USUARIO FROM EQUIPAMENTO where EQUIPAMENTO LIKE '%" & Tpesquisa.Text & "%' or usuario like '%" & Tpesquisa.Text & "%' ORDER BY EQUIPAMENTO"
                Using dap = New SqlDataAdapter(sql, cn)
                    Using dt = New DataTable()
                        dap.Fill(dt)
                        DgEquipamentos.DataSource = dt
                        With DgEquipamentos 'with significa com e substitui variavel a frente dele
                            .Columns(0).Visible = False
                            .Columns(1).Width = 180
                            .Columns(2).Width = 120
                        End With
                    End Using
                    contarlinhas()
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Ops... ocorreu um erro,favor verifique a conexão!#carregaequipamento ", vbExclamation, "Aviso! ")
        End Try
    End Sub
    Private Sub SELECTIONAEQUIPAMENTO()
        Try
            Using cn = New SqlConnection(strcon)
                Dim id = DgEquipamentos.Rows(DgEquipamentos.CurrentCell.RowIndex).Cells(0).Value
                cn.Open()
                Dim sql = "SELECT e.*,i.nome mode, i.ID_ITEM idmode
                            FROM EQUIPAMENTO e 
                            inner join 
                            email_item i on i.id_item = e.ID_MODELO
                            WHERE e.id_equipamento=" & id
                Using cmd = New SqlCommand(sql, cn)

                    Using dr = cmd.ExecuteReader
                        If dr.HasRows Then
                            If dr.Read Then
                                Dim idmode = dr("idmode")
                                tidmaquina.Text = dr("ID_EQUIPAMENTO")
                                TNome.Text = dr("EQUIPAMENTO")
                                TUsuario.Text = dr("USUARIO")
                                TSenha.Text = dr("SENHA")
                                TGhz.Text = dr("GHZ")
                                TMemoria.Text = dr("MEMORIA")
                                Tprocessador.Text = dr("PROCESSADOR")
                                THd1.Text = dr("HD1")
                                THd2.Text = dr("HD2")
                                TWindows.Text = dr("WINDOWS")
                                TDdr.Text = dr("DDR")
                                TObsEquipamento.Text = dr("OBS")
                                CbEmail.Text = dr("email")
                                TSenhaEmail.Text = dr("email_senha")
                                CbContaAntiVirus.Text = dr("EMAIL_ANTIVIRUS")
                                TSenhaAntiVirus.Text = dr("SENHA_ANTIVIRUS")
                                Cbemailoffice.Text = dr("EMAIL_OFFICE")
                                TSenhaOffice.Text = dr("SENHA_OFFICE")
                                CbModelo.Text = dr("mode")
                                Lidmodelo.Text = dr("idmode")
                                TIdentificacao.Text = dr("IDENTIFICACAO")
                                TNHD.Text = dr("NUMERO_HD")
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
            Dim unused = MsgBox("Algo deu errado com a conexão! #selecionadados" & vbNewLine & vbNewLine & ex.Message, vbCritical)
        End Try
    End Sub
    Private Sub SELECTIONAITEM()
        Try
            Using cn = New SqlConnection(strcon)
                Dim id = DG1.Rows(DG1.CurrentCell.RowIndex).Cells(0).Value
                cn.Open()
                Dim sql = "SELECT * FROM ITEM_EQUIPAMENTO WHERE ID_ITEM=" & id
                Using cmd = New SqlCommand(sql, cn)
                    Using dr = cmd.ExecuteReader
                        If dr.HasRows Then
                            If dr.Read Then
                                CbItem.Text = dr("ITEM")
                                DtData.Text = dr("DTLAN")
                                TObsItem.Text = dr("OBS")
                                If dr("REALIZADO") Then
                                    CbRealizado.Text = "Sim"
                                Else
                                    CbRealizado.Text = "Não"
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

    Private Sub AlterarRegistro()
        Try
            Using cn = New SqlConnection(strcon)

                cn.Open()
                Dim id = DgEquipamentos.Rows(DgEquipamentos.CurrentCell.RowIndex).Cells(0).Value

                Dim sql = "UPDATE EQUIPAMENTO SET EQUIPAMENTO=@EQUIPAMENTO,USUARIO=@USUARIO,SENHA=@SENHA,
                            PROCESSADOR=@PROCESSADOR,GHZ=@GHZ,MEMORIA=@MEMORIA,HD1=@HD1,HD2=@HD2,WINDOWS=@WINDOWS,DDR=@DDR,
                             ATIVO=@ATIVO,OBS=@OBS,EMAIL=@EMAIL,EMAIL_SENHA=@EMAIL_SENHA,EMAIL_ANTIVIRUS=@EMAIL_ANTIVIRUS, 
                              SENHA_ANTIVIRUS=@SENHA_ANTIVIRUS,EMAIL_OFFICE=@EMAIL_OFFICE, 
                              SENHA_OFFICE=@SENHA_OFFICE,ID_MODELO = @ID_MODELO,MODELO=@MODELO, IDENTIFICACAO=@IDENTIFICACAO, NUMERO_HD=@NHD WHERE ID_EQUIPAMENTO=" & id
                Using cmd = New SqlCommand(sql, cn)
                    cmd.Parameters.AddWithValue("@EQUIPAMENTO", TNome.Text)
                    cmd.Parameters.AddWithValue("@USUARIO", TUsuario.Text)
                    cmd.Parameters.AddWithValue("@SENHA", TSenha.Text)
                    cmd.Parameters.AddWithValue("@PROCESSADOR", Tprocessador.Text)
                    cmd.Parameters.AddWithValue("@GHZ", TGhz.Text)
                    cmd.Parameters.AddWithValue("@MEMORIA", TMemoria.Text)
                    cmd.Parameters.AddWithValue("@HD1", THd1.Text)
                    cmd.Parameters.AddWithValue("@HD2", THd2.Text)
                    cmd.Parameters.AddWithValue("@WINDOWS", TWindows.Text)
                    cmd.Parameters.AddWithValue("@DDR", TDdr.Text)
                    cmd.Parameters.AddWithValue("@OBS", TObsEquipamento.Text)
                    cmd.Parameters.AddWithValue("@EMAIL", CbEmail.Text)
                    cmd.Parameters.AddWithValue("@EMAIL_ANTIVIRUS", CbContaAntiVirus.Text)
                    cmd.Parameters.AddWithValue("@SENHA_ANTIVIRUS", TSenhaAntiVirus.Text)
                    cmd.Parameters.AddWithValue("@EMAIL_SENHA", TSenhaEmail.Text)
                    cmd.Parameters.AddWithValue("@SENHA_OFFICE", TSenhaOffice.Text)
                    cmd.Parameters.AddWithValue("@EMAIL_OFFICE", Cbemailoffice.Text)
                    cmd.Parameters.AddWithValue("@ID_MODELO", Lidmodelo.Text)
                    cmd.Parameters.AddWithValue("@MODELO", CbModelo.Text)
                    cmd.Parameters.AddWithValue("@IDENTIFICACAO", TIdentificacao.Text)
                    cmd.Parameters.AddWithValue("@NHD", TNHD.Text)
                    cmd.Parameters.AddWithValue("@ATIVO", IIf(Microsoft.VisualBasic.Left(CbAtivo.Text, 1) = "S", 1, 0))
                    cmd.ExecuteNonQuery()
                    MsgBox("Registro atualizado com sucesso!", vbInformation, "Aviso!")
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Algo deu errado com a conexão!" & vbNewLine & vbNewLine & ex.Message, vbCritical)
        End Try
    End Sub
    Private Sub AlterarRegistroitem()
        Try
            Using cn = New SqlConnection(strcon)

                cn.Open()
                Dim id = DG1.Rows(DG1.CurrentCell.RowIndex).Cells(0).Value
                Dim sql = "UPDATE ITEM_EQUIPAMENTO SET ITEM=@ITEM,OBS=@OBS,REALIZADO=@REALIZADO,DTLAN=@DTLAN 
                           WHERE ID_ITEM=" & id
                Using cmd = New SqlCommand(sql, cn)
                    cmd.Parameters.AddWithValue("@ITEM", CbItem.Text)
                    cmd.Parameters.AddWithValue("@DTLAN", DtData.Text)
                    cmd.Parameters.AddWithValue("@OBS", TObsItem.Text)
                    cmd.Parameters.AddWithValue("@REALIZADO", IIf(Microsoft.VisualBasic.Left(CbRealizado.Text, 1) = "S", 1, 0))
                    cmd.ExecuteNonQuery()
                    MsgBox("Registro atualizado com sucesso!", vbInformation, "Aviso!")
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Algo deu errado com a conexão! #alteraregistroitem" & vbNewLine & vbNewLine & ex.Message, vbCritical)
        End Try
    End Sub
    Private Sub ExcluirRegistro()
        Dim id = DgEquipamentos.Rows(DgEquipamentos.CurrentCell.RowIndex).Cells(0).Value
        If MsgBox("Deseja excluir o equipamento (" & TNome.Text & ") Código " & id & " ?", vbQuestion + vbYesNo, "Aviso!") = vbYes Then
            Try
                Using cn = New SqlConnection(strcon)
                    cn.Open()
                    Dim sql = "DELETE FROM EQUIPAMENTO WHERE ID_EQUIPAMENTO=" & id
                    Using cmd = New SqlCommand(sql, cn)
                        cmd.ExecuteNonQuery()
                    End Using
                End Using
                MsgBox("Resgistro - " & id & " excluído com sucesso!", vbInformation, "Aviso!")
                controlebotoesinicial()
            Catch ex As Exception
                MsgBox("Algo deu errado com a conexão!" & vbNewLine & vbNewLine & ex.Message, vbCritical)
            End Try
        End If
    End Sub
    Private Sub ExcluirRegistroItem()
        Dim id = DG1.Rows(DG1.CurrentCell.RowIndex).Cells(0).Value
        If MsgBox("Deseja excluir o registro selecionado? ", vbQuestion + vbYesNo, "Aviso!") = vbYes Then
            Try
                Using cn = New SqlConnection(strcon)
                    cn.Open()
                    Dim sql = "DELETE FROM ITEM_EQUIPAMENTO WHERE ID_ITEM=" & id
                    Using cmd = New SqlCommand(sql, cn)
                        cmd.ExecuteNonQuery()
                    End Using
                End Using
            Catch ex As Exception
                MsgBox("Algo deu errado com a conexão!" & vbNewLine & vbNewLine & ex.Message, vbCritical)
            End Try
            DG1.DataSource = Nothing
        End If
    End Sub

    Private Sub BtIncluir_Click(sender As Object, e As EventArgs) Handles BtIncluir.Click
        If CbItem.Text = "" Then
            MsgBox("Sem item para incluir!", vbInformation, "Aviso!")
        Else
            inserirItem()
            carregagriditem()
        End If

    End Sub
    Public Sub CarregaEmail()
        Try

            Using cn = New SqlConnection(strcon)
                cn.Open()
                Dim sql As String = "SELECT ID_ITEM, NOME,SENHA FROM EMAIL_ITEM  WHERE TIPO = 'E-mail' AND ATIVO = 1 ORDER BY NOME"
                Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                da.Fill(dt)
                CbEmail.DisplayMember = ("NOME")
                CbEmail.ValueMember = ("SENHA")
                CbEmail.DataSource = dt
            End Using
        Catch ex As Exception
            Dim unused = MsgBox("Algo deu errado com a conexão!" & vbNewLine & vbNewLine & ex.Message, vbCritical)
        End Try
    End Sub
    Private Sub CarregaContaAntiVirus()
        Try
            Using cn = New SqlConnection(strcon)
                cn.Open()
                Dim sql As String = "SELECT ID_ITEM, NOME,SENHA FROM EMAIL_ITEM  WHERE TIPO = 'E-mail' AND ATIVO = 1 ORDER BY NOME"
                Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                da.Fill(dt)
                CbContaAntiVirus.DisplayMember = ("NOME")
                CbContaAntiVirus.ValueMember = ("Senha")
                CbContaAntiVirus.DataSource = dt
            End Using
        Catch ex As Exception
            Dim unused = MsgBox("Algo deu errado com a conexão!" & vbNewLine & vbNewLine & ex.Message, vbCritical)
        End Try
    End Sub
    Private Sub CarregaContaMicrosoft()
        Try
            Using cn = New SqlConnection(strcon)
                cn.Open()
                Dim sql As String = "SELECT ID_ITEM, NOME,SENHA FROM EMAIL_ITEM  WHERE TIPO = 'E-mail' AND ATIVO = 1 ORDER BY NOME"
                Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                da.Fill(dt)
                Cbemailoffice.DisplayMember = ("NOME")
                Cbemailoffice.ValueMember = ("SENHA")
                Cbemailoffice.DataSource = dt
            End Using
        Catch ex As Exception
            Dim unused = MsgBox("Algo deu errado com a conexão!" & vbNewLine & vbNewLine & ex.Message, vbCritical)
        End Try
    End Sub
    Private Sub CarregaItem()
        Try
            Using cn = New SqlConnection(strcon)
                cn.Open()
                Dim sql As String = "SELECT ID_ITEM, NOME FROM EMAIL_ITEM  WHERE TIPO = 'Item' AND ATIVO = 1 ORDER BY NOME"
                Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                da.Fill(dt)
                CbItem.DisplayMember = ("NOME")
                CbItem.ValueMember = ("ID_ITEM")
                CbItem.DataSource = dt
            End Using
        Catch ex As Exception
            Dim unused = MsgBox("Algo deu errado com a conexão!" & vbNewLine & vbNewLine & ex.Message, vbCritical)
        End Try
    End Sub
    Private Sub CarregaModelo()
        Try
            Using cn = New SqlConnection(strcon)
                cn.Open()
                Dim sql As String = "SELECT ID_ITEM, NOME FROM EMAIL_ITEM  WHERE TIPO = 'Modelo' AND ATIVO = 1 ORDER BY NOME"
                Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                da.Fill(dt)
                CbModelo.DisplayMember = ("NOME")
                CbModelo.ValueMember = ("ID_ITEM")
                CbModelo.DataSource = dt
            End Using
        Catch ex As Exception
            Dim unused = MsgBox("Algo deu errado com a conexão!" & vbNewLine & vbNewLine & ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub FrmCadMaquinas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carregagridequipamento()
        controlebotoesinicial()
        GbDados.Enabled = False
        GbListagem.Enabled = False
        Gbsenha.Enabled = False
        BtAtualizarItem.Visible = False
        BtExcluirItem.Visible = False
        BtCancelarItem.Visible = True
        BtIncluir.Visible = True

    End Sub


    Private Sub DG1_DoubleClick(sender As Object, e As EventArgs) Handles DG1.DoubleClick

        If tidmaquina.Text = "" Then
            MsgBox("Primeiro selecione um registro da lista de itens!", vbInformation, "Aviso!")
        Else
            SELECTIONAITEM()
            BtAtualizarItem.Visible = True
            BtCancelarItem.Visible = True
            BtExcluirItem.Visible = True
            BtIncluir.Visible = False
        End If

    End Sub

    Private Sub BtAtualizarItem_Click(sender As Object, e As EventArgs) Handles BtAtualizarItem.Click
        BtAtualizarItem.Visible = False
        BtCancelarItem.Visible = True
        BtExcluirItem.Visible = False
        BtIncluir.Visible = True
        AlterarRegistroitem()
        CbItem.Text = ""
        CbRealizado.SelectedIndex = -1
        DtData.Text = Today
        TObsItem.Text = ""
        DG1.DataSource = Nothing
        carregagriditem()
    End Sub

    Private Sub BtCancelarItem_Click(sender As Object, e As EventArgs) Handles BtCancelarItem.Click
        BtAtualizarItem.Visible = False
        BtCancelarItem.Visible = True
        BtExcluirItem.Visible = False
        BtIncluir.Visible = True
        CbItem.SelectedIndex = -1
        CbRealizado.SelectedIndex = -1
        DtData.Text = Today
        TObsItem.Text = ""
    End Sub
    Private Sub BuscaCep()
        'Buscar CEP de forma automatica.
        Try
            Dim ds As New DataSet
            Dim xml As String = " http://cep.republicavirtual.com.br/web_cep.php?cep=@cep&formato=xml".Replace("@cep", TSenha.Text)
            ds.ReadXml(xml)
            'linha Logradouro,bairro, cidade, uf.
            TNome.Text = ds.Tables(0).Rows(0)("logradouro").ToString()
            ' Tbairro.Text = ds.Tables(0).Rows(0)("bairro").ToString()
            ' Cbcidade.Text = ds.Tables(0).Rows(0)("cidade").ToString()
            ' tuf.Text = ds.Tables(0).Rows(0)("uf").ToString()
        Catch ex As Exception
            MessageBox.Show("Err:" & ex.Message, "Err", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MbServico_Click(sender As Object, e As EventArgs) Handles MbServico.Click
        If tidmaquina.Text = "" Then
            MsgBox("Deve primeiro selecionar um equipamento!", vbInformation, "Aviso!")
        Else
            DgEquipamentos.Enabled = False
            Panel1.Enabled = False
            Frm_Servico.ShowDialog()
        End If
    End Sub
    Private Sub BtExcluirItem_Click(sender As Object, e As EventArgs) Handles BtExcluirItem.Click
        ExcluirRegistroItem()
        carregagriditem()
        BtAtualizarItem.Visible = False
        BtCancelarItem.Visible = True
        BtExcluirItem.Visible = False
        BtIncluir.Visible = True
    End Sub

    Private Sub RelatToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RelatToolStripMenuItem.Click
        If tidmaquina.Text = "" Then
            MsgBox("Deve primeiro selecionar um equipamento!", vbInformation, "Aviso!")
        Else
            Frm_Rel_Manutencao.ShowDialog()
        End If

    End Sub

    Private Sub RelatórioAgrupadoEquipamentoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RelatórioAgrupadoEquipamentoToolStripMenuItem.Click
        If tidmaquina.Text = "" Then
            MsgBox("Deve primeiro selecionar um equipamento!", vbInformation, "Aviso!")
        Else
            Frm_Rel_Agrupado_equipamento.Show()
        End If

    End Sub

    Private Sub ListagemEquipamentoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListagemEquipamentoToolStripMenuItem.Click
        Frm_Relatorio_Equipamentos.ShowDialog()
    End Sub

    Private Sub ListagemChklistToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListagemChklistToolStripMenuItem.Click
        Frm_Relatorio_comp.ShowDialog()
    End Sub
    Public Sub contarlinhas()
        Dim numlinhas As Integer = DgEquipamentos.RowCount - 1
        Dim contador As Integer = 0
        While (numlinhas >= 0)
            contador = contador + 1
            numlinhas = numlinhas - 1
        End While
        LbContaLinhas.Text = contador & " Registros"
    End Sub
    Private Sub Tpesquisa_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Tpesquisa.KeyPress
        carregagridequipamento()
    End Sub

    Private Sub EmailToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmailToolStripMenuItem.Click
        Frm_Item.Show()
    End Sub


    Private Sub CbItem_GotFocus(sender As Object, e As EventArgs) Handles CbItem.GotFocus
        CarregaItem()
    End Sub
    Private Sub DgEquipamentos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgEquipamentos.CellClick
        SELECTIONAEQUIPAMENTO()
        carregagriditem()
    End Sub

    Private Sub Pfolhosenha_Click(sender As Object, e As EventArgs) Handles Pfolhosenha.Click
        Polhosenha.Visible = True
        Pfolhosenha.Visible = False
        TSenhaEmail.PasswordChar = ""
    End Sub

    Private Sub PfOlhovirus_Click(sender As Object, e As EventArgs) Handles PfOlhovirus.Click
        POlhoVirus.Visible = True
        PfOlhovirus.Visible = False
        TSenhaAntiVirus.PasswordChar = ""
    End Sub

    Private Sub PfOlhoMicrosoft_Click(sender As Object, e As EventArgs) Handles PfOlhoMicrosoft.Click
        POlhoMicrosoft.Visible = True
        PfOlhoMicrosoft.Visible = False
        TSenhaOffice.PasswordChar = ""
    End Sub

    Private Sub Polhosenha_Click(sender As Object, e As EventArgs) Handles Polhosenha.Click
        Polhosenha.Visible = False
        Pfolhosenha.Visible = True
        TSenhaEmail.PasswordChar = "*"
    End Sub

    Private Sub POlhoVirus_Click(sender As Object, e As EventArgs) Handles POlhoVirus.Click
        POlhoVirus.Visible = False
        PfOlhovirus.Visible = True
        TSenhaAntiVirus.PasswordChar = "*"
    End Sub

    Private Sub POlhoMicrosoft_Click(sender As Object, e As EventArgs) Handles POlhoMicrosoft.Click
        POlhoMicrosoft.Visible = False
        PfOlhoMicrosoft.Visible = True
        TSenhaOffice.PasswordChar = "*"
    End Sub
    Private Sub CbContaAntiVirus_LostFocus(sender As Object, e As EventArgs) Handles CbContaAntiVirus.LostFocus
        TSenhaAntiVirus.Text = CbContaAntiVirus.SelectedValue
    End Sub
    Private Sub Cbemailoffice_LostFocus(sender As Object, e As EventArgs) Handles Cbemailoffice.LostFocus

        TSenhaOffice.Text = Cbemailoffice.SelectedValue
    End Sub

    Private Sub CbEmail_DropDown(sender As Object, e As EventArgs) Handles CbEmail.DropDown
        CarregaEmail()
    End Sub

    Private Sub CbEmail_LostFocus(sender As Object, e As EventArgs) Handles CbEmail.LostFocus
        TSenhaEmail.Text = CbEmail.SelectedValue
    End Sub
    Private Sub CbContaAntiVirus_DropDown(sender As Object, e As EventArgs) Handles CbContaAntiVirus.DropDown
        CarregaContaAntiVirus()
    End Sub

    Private Sub Cbemailoffice_DropDown(sender As Object, e As EventArgs) Handles Cbemailoffice.DropDown
        CarregaContaMicrosoft()
    End Sub

    Private Sub CbEmail_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbEmail.SelectedIndexChanged

    End Sub

    Private Sub CbModelo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbModelo.SelectedIndexChanged

    End Sub

    Private Sub CbModelo_GotFocus(sender As Object, e As EventArgs) Handles CbModelo.GotFocus
        CarregaModelo()
    End Sub
End Class