
Imports System.Data.SqlClient
Imports ControlMachine.ControlMachine

Public Class Frm_Cliente

    Private Sub controlebotoesinicial()
        'controle de botões
        BtNovo.Visible = True
        BtSalvar.Visible = False
        BtCancelar.Visible = False
        BtEditar.Visible = True
        BtAtualizar.Visible = False
        BtExcluir.Enabled = True
        BtFechar.Enabled = True
        'Limpeza de campos.
        CbTipo.SelectedIndex = -1
        cbativo.SelectedIndex = -1
        TNome.Text = ""
        Tdoc.Text = ""
        TObs.Text = ""
        TCodigo.Text = ""
        TNome.Text = ""
        Tdoc.Text = ""
        TObs.Text = ""
        TCodigo.Text = ""
        TNome.Text = ""
        Tdoc.Text = ""
        TObs.Text = ""
        TCodigo.Text = ""
        TNome.Text = ""
        Tdoc.Text = ""
        TObs.Text = ""
        TCodigo.Text = ""
        TNome.Text = ""
        Tdoc.Text = ""
        TObs.Text = ""

        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is TextBox Then
                CType(ctrl, TextBox).Text = ""
            ElseIf TypeOf ctrl Is Panel Then
                For Each subCtrl As Control In ctrl.Controls
                    If TypeOf subCtrl Is TextBox Then
                        CType(subCtrl, TextBox).Text = ""
                    End If
                Next
            End If
        Next






        'DgItemCad.DataSource = Nothing ' limpa grid
        'DgItemCad.Enabled = False
        'GbPesquisa.Enabled = False

    End Sub
    Private Sub controlebotoesfinal()
        BtNovo.Visible = False
        BtSalvar.Visible = True
        BtCancelar.Visible = True
        BtEditar.Visible = False
        BtAtualizar.Visible = False
        BtExcluir.Enabled = False
        BtFechar.Enabled = False


    End Sub
    Private Sub controlebotoesatualizar()
        BtNovo.Visible = False
        BtSalvar.Visible = False
        BtCancelar.Visible = True
        BtEditar.Visible = False
        BtAtualizar.Visible = True
        BtExcluir.Enabled = False
        BtFechar.Enabled = False


    End Sub
    Private Sub Frm_Cliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        controlebotoesinicial()
        TCodigo.Text = campo(0)
        If TCodigo.Text > 0 Then
            SELECIONADADOS()
        Else
            MsgBox("sem regitro.")
        End If

    End Sub
    Private Sub ObterCnpj(cnpj As String)
        Try
            Dim cliente = Empresa.ObterCnpj(cnpj)
            TNome.Text = cliente.nome
            DtCad.Text = cliente.abertura
            TEnde.Text = cliente.logradouro
            Tnumero.Text = cliente.numero
            TObs.Text = cliente.complemento
            TBairro.Text = cliente.bairro
            TCep.Text = cliente.cep
            CbCidade.Text = cliente.municipio
            TUF.Text = cliente.uf
            ' Tmotivo.Text = cliente.motivo_situacao
            TFone.Text = cliente.telefone

        Catch ex As Exception
            MsgBox("Ocorreu um erro ao efetuar a consulta do CNPJ!", vbInformation, "Aviso!")
        End Try

    End Sub

    Private Sub CbTipo_LostFocus(sender As Object, e As EventArgs) Handles CbTipo.LostFocus
        If CbTipo.Text = "1-CPF" Then
            Tdoc.Mask = "###,###,###-##"
            Label1.Text = "CPF:"
            Label2.Text = "RG:"
            Label3.Text = "Nome:"
            Label4.Text = "Apelido:"
            Tdoc.Enabled = True
            Bbuscacnpj.Enabled = False
        Else
            Tdoc.Mask = "##,###,###/####-##"
            Label1.Text = "CNPJ:"
            Label2.Text = "IE:"
            Label3.Text = "Nome razão:"
            Label4.Text = "Fantasia:"
            Tdoc.Enabled = True
            Bbuscacnpj.Enabled = True
        End If
    End Sub
    Private Sub buscaCNPJ()
        Dim result = MessageBox.Show("Deseja consultar o CNPJ?", "Aviso!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = DialogResult.OK Then
            Dim cpf = Tdoc.Text

            Tdoc.Mask = Nothing
            ObterCnpj(Tdoc.Text)
            Tdoc.Mask = "##,###,###/####-##"
            Tdoc.Text = cpf
        End If
    End Sub

    Private Sub CbTipo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CbTipo.KeyPress
        ChangeFocusOnEnterKeyPress(sender, e)
    End Sub

    Private Sub Tdoc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Tdoc.KeyPress
        ChangeFocusOnEnterKeyPress(sender, e)
    End Sub


    Private Sub TReg_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TReg.KeyPress
        ChangeFocusOnEnterKeyPress(sender, e)
    End Sub

    Private Sub TObs_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TObs.KeyPress
        ChangeFocusOnEnterKeyPress(sender, e)
    End Sub

    Private Sub TUF_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TUF.KeyPress
        ChangeFocusOnEnterKeyPress(sender, e)
    End Sub

    Private Sub TApelido_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TApelido.KeyPress
        ChangeFocusOnEnterKeyPress(sender, e)
    End Sub

    Private Sub TBairro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBairro.KeyPress
        ChangeFocusOnEnterKeyPress(sender, e)
    End Sub

    Private Sub TEmail_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TEmail.KeyPress
        ChangeFocusOnEnterKeyPress(sender, e)
    End Sub

    Private Sub TFone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TFone.KeyPress
        ChangeFocusOnEnterKeyPress(sender, e)
    End Sub

    Private Sub TNome_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TNome.KeyPress
        ChangeFocusOnEnterKeyPress(sender, e)
    End Sub

    Private Sub Tnumero_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Tnumero.KeyPress
        ChangeFocusOnEnterKeyPress(sender, e)
    End Sub

    Private Sub Bbuscacnpj_Click(sender As Object, e As EventArgs) Handles Bbuscacnpj.Click
        buscaCNPJ()
    End Sub

    Private Sub INSERIRDADOS()

        Try
            Using cn = New SqlConnection(strcon)
                cn.Open()
                Dim sql = "INSERT INTO PESSOAS (NOME,DOCUMENTO,ENDERECO, NUMERO, BAIRRO, ID_CIDADE, CELULAR,APELIDO, RG, COMP,UF,CEP,TIPO,ATIVO,DATACAD,EMAIL, OBS,FONE, TIPOPESSOA)
                           VALUES  (@NOME,@DOCUMENTO,@ENDERECO, @NUMERO, @BAIRRO, @ID_CIDADE, @CELULAR,@APELIDO, @RG, @COMP,@UF,@CEP,@TIPO,@ATIVO,@DATACAD,@EMAIL,@OBS, @FONE,@TIPOPESSOA)"
                Using cmd = New SqlCommand(sql, cn)
                    cmd.Parameters.AddWithValue("@NOME", TNome.Text)
                    cmd.Parameters.AddWithValue("@documento", Tdoc.Text)
                    cmd.Parameters.AddWithValue("@ENDERECO", TEnde.Text)
                    cmd.Parameters.AddWithValue("@NUMERO", Tnumero.Text)
                    cmd.Parameters.AddWithValue("@BAIRRO", TBairro.Text)
                    cmd.Parameters.AddWithValue("@ID_CIDADE", 1)
                    cmd.Parameters.AddWithValue("@CELULAR", TCel.Text)
                    cmd.Parameters.AddWithValue("@APELIDO", TApelido.Text)
                    cmd.Parameters.AddWithValue("@RG", TReg.Text)
                    cmd.Parameters.AddWithValue("@COMP", Tcomp.Text)
                    cmd.Parameters.AddWithValue("@UF", TUF.Text)
                    cmd.Parameters.AddWithValue("@CEP", TCep.Text)
                    cmd.Parameters.AddWithValue("@TIPO", "CL")
                    cmd.Parameters.AddWithValue("@ATIVO", IIf(Microsoft.VisualBasic.Left(CbAtivo.Text, 1) = "S", 1, 0))
                    cmd.Parameters.AddWithValue("@TIPOPESSOA", IIf(Microsoft.VisualBasic.Left(CbTipo.Text, 1) = "2", 1, 0))
                    cmd.Parameters.AddWithValue("@DATACAD", DtCad.Text)
                    cmd.Parameters.AddWithValue("@EMAIL", TEmail.Text) 'Replace(",", "."))
                    cmd.Parameters.AddWithValue("@FONE", TFone.Text)
                    cmd.Parameters.AddWithValue("@OBS", TObs.Text)
                    cmd.ExecuteNonQuery()

                    MsgBox("Registro salvo com sucesso!", vbInformation, "Aviso!")

                End Using
            End Using
        Catch ex As Exception
            MsgBox("Algo deu errado com ao inserir os dados!" & vbNewLine & vbNewLine & ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub BtSalvar_Click(sender As Object, e As EventArgs) Handles BtSalvar.Click
        INSERIRDADOS()
    End Sub

    Private Sub TCel_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TCel.KeyPress
        ChangeFocusOnEnterKeyPress(sender, e)
    End Sub

    Private Sub BtNovo_Click(sender As Object, e As EventArgs) Handles BtNovo.Click
        controlebotoesfinal()
        CbTipo.SelectedIndex = 0
    End Sub

    Private Sub TEnde_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TEnde.KeyPress
        ChangeFocusOnEnterKeyPress(sender, e)
    End Sub

    Private Sub BtEditar_Click(sender As Object, e As EventArgs) Handles BtEditar.Click
        controlebotoesatualizar()
    End Sub

    Private Sub BtExcluir_Click(sender As Object, e As EventArgs) Handles BtExcluir.Click
        controlebotoesinicial()
    End Sub

    Private Sub BtFechar_Click(sender As Object, e As EventArgs) Handles BtFechar.Click
        Close()
    End Sub

    Private Sub BtAtualizar_Click(sender As Object, e As EventArgs) Handles BtAtualizar.Click
        controlebotoesinicial()

    End Sub

    Private Sub BtCancelar_Click(sender As Object, e As EventArgs) Handles BtCancelar.Click
        controlebotoesinicial()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is TextBox Then
                CType(ctrl, TextBox).Text = ""
            ElseIf TypeOf ctrl Is Panel Then
                For Each subCtrl As Control In ctrl.Controls
                    If TypeOf subCtrl Is TextBox Then
                        CType(subCtrl, TextBox).Text = ""
                    End If
                Next
            End If
        Next
    End Sub


    Private Sub SELECIONADADOS()

        ' Tcodigo.Text = id

        Try
            Using cn = New SqlConnection(strcon)
                cn.Close()
                cn.Open()
                Dim sql = "select p.*,c.nome cidade, c.uf uf
                            from pessoas p
                            inner join
                            cidades c on c.id_cidade = p.id_cidade
                            where id_pessoa =" & campo(0)
                Using cmd = New SqlCommand(sql, cn)
                    Using dr = cmd.ExecuteReader
                        If dr.HasRows Then
                            If dr.Read Then
                                If dr("tipopessoa") Then
                                    CbTipo.Text = "1-CPF"
                                Else
                                    CbTipo.Text = "2-CNPJ"
                                End If
                                TCodigo.Text = dr("codigo")
                                TNome.Text = dr("nome")
                                TApelido.Text = dr("apelido")
                                Tdoc.Text = dr("documento")
                                TReg.Text = dr("rg")
                                TCep.Text = dr("cep")
                                TEnde.Text = dr("endereco")
                                Tnumero.Text = dr("numero")
                                TBairro.Text = dr("bairro")
                                CbCidade.Text = dr("id_cidade")
                                TUF.Text = dr("uf")
                                TFone.Text = dr("fone")
                                TCel.Text = dr("celular")
                                TEmail.Text = dr("email")
                                If dr("ATIVO") Then
                                    CbAtivo.Text = "SIM"
                                Else
                                    CbAtivo.Text = "NÃO"
                                End If
                                DtCad.Text = dr("datacad")
                                TObs.Text = dr("obs")
                                TComp.Text = dr("comp")
                            End If
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            Dim unused = MsgBox("Algo deu errado com a conexão!" & vbNewLine & vbNewLine & ex.Message, vbCritical)
        End Try

    End Sub

End Class