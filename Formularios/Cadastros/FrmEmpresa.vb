Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Tab
Imports ControlMachine.ControlMachine

Public Class FrmEmpresa

    Private Sub controlebotoesinicial()
        'controle de botões
        BtNovo.Visible = True
        BtSalvar.Visible = False
        BtCancelar.Visible = False
        BtEditar.Visible = True
        BtAtualizar.Visible = False
        BtFechar.Enabled = True
        CbTipo.Enabled = True
        Tdoc.Enabled = True
        TNome.Enabled = True
    End Sub

    Private Sub controlebotoesfinal()
        BtNovo.Visible = False
        BtSalvar.Visible = True
        BtCancelar.Visible = True
        BtEditar.Visible = False
        BtAtualizar.Visible = False
        BtFechar.Enabled = False
    End Sub

    Private Sub controlebotoesatualizar()
        BtNovo.Visible = False
        BtSalvar.Visible = False
        BtCancelar.Visible = True
        BtEditar.Visible = False
        BtAtualizar.Visible = True
        BtFechar.Enabled = False
        CbTipo.Enabled = False
        Tdoc.Enabled = False
        TNome.Enabled = False
    End Sub
    Private Sub BtFechar_Click(sender As Object, e As EventArgs) Handles BtFechar.Click
        Close()
    End Sub

    Private Sub FrmEmpresa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        controlebotoesinicial()
        Tdoc.Enabled = False
        Selecionaempresapadrao()
        CarregaCidade()
        CbCidade.SelectedIndex = -1
    End Sub
    Public Sub ObterCnpj(cnpj As String)
        Try
            If Not String.IsNullOrEmpty(cnpj) Then ' Check if CNPJ is provided
                If CbTipo.SelectedIndex = 1 Then
                    Dim cliente = Empresa.ObterCnpj(cnpj)
                    ' Populate UI elements with retrieved data
                    TNome.Text = cliente.nome
                    DtCad.Text = cliente.abertura
                    TEnde.Text = cliente.logradouro
                    Tnumero.Text = cliente.numero
                    TObs.Text = cliente.complemento
                    TBairro.Text = cliente.bairro
                    TCep.Text = cliente.cep
                    CbCidade.Text = cliente.municipio
                    TUF.Text = cliente.uf
                    Tmotivo.Text = cliente.motivo_situacao
                    TFone.Text = cliente.telefone
                Else
                    MsgBox("Seleção inválida para tipo de CNPJ!", vbInformation, "Aviso!")
                End If
            Else
                MsgBox("Por favor, insira um CNPJ válido.", vbInformation, "Aviso!")
            End If
            ' Catch ex As CNPJNotFoundException ' Custom exception for CNPJ not found
            MsgBox("CNPJ não encontrado.", vbInformation, "Aviso!")
        Catch ex As Exception ' Catch any other unexpected exceptions
            MsgBox("Ocorreu um erro ao efetuar a consulta do CNPJ: " & ex.Message, vbInformation, "Aviso!")
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If CbTipo.SelectedIndex = 0 Or CbTipo.Text = "" Then
            MsgBox("Tipo de documento não permite consulta!", vbInformation, "Aviso!")
        Else
            Dim result = MessageBox.Show("Deseja consultar o CNPJ?", "Aviso!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                Dim cpf = Tdoc.Text
                Tdoc.Mask = Nothing
                ObterCnpj(Tdoc.Text)
                Tdoc.Mask = "##,###,###/####-##"
                Tdoc.Text = cpf
            End If
        End If
    End Sub

    Private Sub CbTipo_LostFocus(sender As Object, e As EventArgs) Handles CbTipo.LostFocus
        If CbTipo.Text = "1-CPF" Then
            Tdoc.Mask = "###,###,###-##"
            Label1.Text = "CPF:"
            Label2.Text = "RG:"
            Label3.Text = "Nome:"
            Label4.Text = "Apelido:"
            Tdoc.Enabled = True

        Else
            Tdoc.Mask = "##,###,###/####-##"
            Label1.Text = "CNPJ:"
            Label2.Text = "IE:"
            Label3.Text = "Nome razão:"
            Label4.Text = "Fantasia:"
            Tdoc.Enabled = True
        End If
    End Sub
    Private Function VerificarRegistroExistente() As Boolean

        Try
            Using cn = New SqlConnection(strcon)
                cn.Open()
                Dim sql = "SELECT COUNT(*) FROM EMPRESA"
                Dim registroExiste As Boolean = False
                Using cmd = New SqlCommand(sql, cn)
                    ' Executar comando e obter o número de registros
                    Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    ' Se count for maior que 0, significa que existem registros na tabela
                    If count > 0 Then
                        registroExiste = True
                        BtSalvar.Enabled = False
                    End If
                End Using
                ' Se registroExiste for False, exibir MessageBox
                If Not registroExiste Then
                    MessageBox.Show("Não existem registros no banco de dados, favor inserir os dados da empresa.")
                    BtNovo.Enabled = True
                    BtSalvar.Enabled = True

                End If

                ' Retornar o resultado da verificação
                Return registroExiste
                cn.Close()
            End Using

        Catch ex As Exception
            Dim unused = MsgBox("Algo deu errado com a conexão, #verificaempresa!" & vbNewLine & vbNewLine & ex.Message, vbCritical)
        End Try
    End Function
    Private Sub ALTERARDADOS()

        Try
            If TCodigo.Text = "" Then
                MsgBox("Precisa selecionar o registro primeiro!", vbInformation, "Aviso!")

            Else
                TNome.ReadOnly = True
                Tdoc.ReadOnly = True
                TCodigo.ReadOnly = True
                CbTipo.Enabled = True
                Using cn = New SqlConnection(strcon)
                    cn.Open()

                    Dim sql = "UPDATE EMPRESA SET FANTASIA=@FANTASIA, RG_IE=@RG_IE, ENDERECO=@ENDERECO,BAIRRO=@BAIRRO,
                                NUMERO=@NUMERO, ID_CIDADE=@ID_CIDADE,CEP=REPLACE(REPLACE(@CEP,'.',''),'-',''),FONE=REPLACE(REPLACE(REPLACE( REPLACE (@FONE,'(',''),	')',''),'.',''),'-',''),
                                CELULAR=REPLACE(REPLACE(REPLACE( REPLACE (@CELULAR,'(',''),	')',''),'.',''),'-',''), EMAIL=@EMAIL,OBS=@OBS WHERE ID_EMPRESA=" & TCodigo.Text
                    Using cmd = New SqlCommand(sql, cn)
                        'cmd.Parameters.AddWithValue("@NOME", TNome.Text)
                        cmd.Parameters.AddWithValue("@FANTASIA", TApelido.Text)
                        ' cmd.Parameters.AddWithValue("@CPF_CNPJ", Tdoc.Text)
                        cmd.Parameters.AddWithValue("@RG_IE", TReg.Text)
                        cmd.Parameters.AddWithValue("@ENDERECO", TEnde.Text)
                        cmd.Parameters.AddWithValue("@BAIRRO", TBairro.Text)
                        cmd.Parameters.AddWithValue("@NUMERO", Tnumero.Text)
                        cmd.Parameters.AddWithValue("@CEP", TCEP.Text)
                        cmd.Parameters.AddWithValue("@FONE", TFone.Text)
                        cmd.Parameters.AddWithValue("@CELULAR", TCel.Text)
                        cmd.Parameters.AddWithValue("@EMAIL", TEmail.Text)
                        cmd.Parameters.AddWithValue("@OBS", TObs.Text)
                        cmd.Parameters.AddWithValue("@ID_CIDADE", CbCidade.SelectedValue)
                        'cmd.Parameters.AddWithValue("@TIPODOC", CbTipo.Text)
                        cmd.ExecuteNonQuery()
                        MsgBox("Registro atualizado com sucesso!", vbInformation, "Aviso!")
                    End Using
                End Using
            End If
        Catch ex As Exception
            MsgBox("Algo deu errado com a conexão! #Inclusãodeempresa" & vbNewLine & vbNewLine & ex.Message, vbCritical)
        End Try
    End Sub
    Private Sub INSERIRDADOS()
        Try
            If CbTipo.Text = "" Or Tdoc.Text = "" Or TNome.Text = "" Or TReg.Text = "" Then
                MsgBox("Verifica os campos a embrancos", vbInformation, "Aviso!")
            Else
                Using cn = New SqlConnection(strcon)
                    cn.Open()
                    Dim sql = "INSERT INTO EMPRESA (NOME,FANTASIA, CPF_CNPJ, RG_IE, ENDERECO,BAIRRO, NUMERO, ID_CIDADE, TIPODOC,CEP,FONE, CELULAR,EMAIL,OBS)
                           VALUES  (@NOME,@FANTASIA, REPLACE(REPLACE (@CPF_CNPJ,'.',''),'-',''),REPLACE(REPLACE ( @RG_IE,'.',''),'-',''), @ENDERECO,@BAIRRO,
                                    @NUMERO, @ID_CIDADE, @TIPODOC,REPLACE(REPLACE(@CEP,'.',''),'-',''),REPLACE(REPLACE(REPLACE( REPLACE (@FONE,'(',''),	')',''),'.',''),'-','')	, 
                                    REPLACE(REPLACE(REPLACE( REPLACE (@CELULAR,'(',''),	')',''),'.',''),'-',''),@EMAIL,@OBS)"
                    Using cmd = New SqlCommand(sql, cn)
                        cmd.Parameters.AddWithValue("@NOME", TNome.Text)
                        cmd.Parameters.AddWithValue("@FANTASIA", TApelido.Text)
                        cmd.Parameters.AddWithValue("@CPF_CNPJ", Tdoc.Text)
                        cmd.Parameters.AddWithValue("@RG_IE", TReg.Text)
                        cmd.Parameters.AddWithValue("@ENDERECO", TEnde.Text)
                        cmd.Parameters.AddWithValue("@BAIRRO", TBairro.Text)
                        cmd.Parameters.AddWithValue("@NUMERO", Tnumero.Text)
                        cmd.Parameters.AddWithValue("@CEP", TCep.Text)
                        cmd.Parameters.AddWithValue("@FONE", TFone.Text)
                        cmd.Parameters.AddWithValue("@CELULAR", TCel.Text)
                        cmd.Parameters.AddWithValue("@EMAIL", TEmail.Text)
                        cmd.Parameters.AddWithValue("@OBS", TObs.Text)
                        cmd.Parameters.AddWithValue("@ID_CIDADE", CbCidade.SelectedValue)
                        cmd.Parameters.AddWithValue("@TIPODOC", CbTipo.Text)
                        cmd.ExecuteNonQuery()
                        MsgBox("Registro salvo com sucesso!", vbInformation, "Aviso!")
                    End Using
                End Using
            End If
        Catch ex As Exception
            MsgBox("Algo deu errado com a conexão! #Inclusãodeempresa" & vbNewLine & vbNewLine & ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub BtSalvar_Click(sender As Object, e As EventArgs) Handles BtSalvar.Click
        INSERIRDADOS()
        controlebotoesinicial()
    End Sub

    Private Sub BtNovo_Click(sender As Object, e As EventArgs) Handles BtNovo.Click
        VerificarRegistroExistente()
        controlebotoesfinal()
    End Sub

    Private Sub BtAtualizar_Click(sender As Object, e As EventArgs) Handles BtAtualizar.Click
        ALTERARDADOS()
        controlebotoesinicial()
    End Sub

    Private Sub BtEditar_Click(sender As Object, e As EventArgs) Handles BtEditar.Click
        controlebotoesatualizar()
    End Sub

    Private Sub BtCancelar_Click(sender As Object, e As EventArgs) Handles BtCancelar.Click
        controlebotoesinicial()
    End Sub
    Public Sub CarregaCidade()
        Try
            Using cn = New SqlConnection(strcon)
                cn.Open()
                Dim sql As String = "SELECT id_cidade, nome FROM cidades  WHERE  ATIVO = 1 ORDER BY NOME"
                Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                da.Fill(dt)
                CbCidade.DisplayMember = ("NOME")
                CbCidade.ValueMember = ("id_cidade")
                CbCidade.DataSource = dt
            End Using

        Catch ex As Exception
            Dim unused = MsgBox("Algo deu errado com a conexão!" & vbNewLine & vbNewLine & ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub CarregaUF()
        Try
            Using cn = New SqlConnection(strcon)
                Dim id = CbCidade.SelectedValue
                cn.Open()
                Dim sql = "SELECT ID_CIDADE, UF FROM cidades WHERE ID_CIDADE=" & id
                Using cmd = New SqlCommand(sql, cn)
                    Using dr = cmd.ExecuteReader
                        If dr.HasRows Then
                            If dr.Read Then
                                TUF.Text = dr("UF")
                                Label18.Text = id
                            End If
                        End If
                    End Using
                End Using
                cn.Close()
            End Using
        Catch ex As Exception
            Dim unused = MsgBox("Algo deu errado com a conexão, #selecionaCarregaUF!" & vbNewLine & vbNewLine & ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub CbCidade_GotFocus(sender As Object, e As EventArgs)
        CarregaCidade()
    End Sub
    Private Sub CbCidade_LostFocus(sender As Object, e As EventArgs)
        CarregaUF()
    End Sub

    Private Sub BuscaCep()
        Try
            Dim ds As New DataSet
            Dim xml As String = " http://cep.republicavirtual.com.br/web_cep.php?cep=@cep&formato=xml".Replace("@cep", TCep.Text)
            ds.ReadXml(xml)
            'linha Logradouro,bairro, cidade, uf.
            '  Tendereco.Text = ds.Tables(0).Rows(0)("logradouro").ToString()
            TBairro.Text = ds.Tables(0).Rows(0)("bairro").ToString()
            CbCidade.Text = ds.Tables(0).Rows(0)("cidade").ToString()
            TUF.Text = ds.Tables(0).Rows(0)("uf").ToString()

        Catch ex As Exception
            MessageBox.Show("Erro:" & ex.Message, "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub Selecionaempresapadrao()
        CarregaCidade()

        Try
            Using cn = New SqlConnection(strcon)
                cn.Open()
                Dim sql = "SELECT E.*, C.NOME nCidade, C.UF UF, C.ID_CIDADE
                            FROM EMPRESA E
                            INNER JOIN
                            CIDADES C ON C.ID_CIDADE = E.ID_CIDADE
                            AND ID_EMPRESA > 0"
                Using cmd = New SqlCommand(sql, cn)
                    Using dr = cmd.ExecuteReader
                        If dr.HasRows Then
                            If dr.Read Then
                                CbTipo.Text = dr("TIPODOC")
                                Tdoc.Text = dr("CPF_CNPJ")
                                TReg.Text = dr("RG_IE")
                                TCodigo.Text = dr("ID_EMPRESA")
                                TNome.Text = dr("NOME")
                                TApelido.Text = dr("FANTASIA")
                                TCep.Text = dr("CEP")
                                TEnde.Text = dr("ENDERECO")
                                Tnumero.Text = dr("NUMERO")
                                TBairro.Text = dr("BAIRRO")
                                CbCidade.Text = dr("ncidade")
                                CbCidade.Text = dr("ncidade")
                                TUF.Text = dr("UF")
                                TFone.Text = dr("FONE")
                                TCel.Text = dr("CELULAR")
                                TEmail.Text = dr("EMAIL")
                                TObs.Text = dr("OBS")
                            End If
                        End If
                    End Using
                End Using

                cn.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Algo deu errado com a conexão, #selecionaitem!:" & ex.Message, "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

End Class