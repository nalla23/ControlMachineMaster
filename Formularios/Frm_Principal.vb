Imports System.Data.SqlClient
Imports System.Windows.Forms.DataVisualization.Charting


Public Class Frm_Principal


    Private Sub BtMenu_Click(sender As Object, e As EventArgs) Handles BtMenu.Click
        PanelCentro.Visible = True
        PanelSubTopo.Visible = True
        PanelTop.Visible = True
        PanelCadastro.Visible = False
        Label8.Text = "DashBoards"
        Label9.Text = "Resultado Simplificados"
        contamaquina()
        AplicativoDesatualizado()

    End Sub

    Private Sub BtRelatorio_Click(sender As Object, e As EventArgs) Handles BtRelatorio.Click
        PanelCentro.Visible = False
        PanelSubTopo.Visible = True
        PanelTop.Visible = True
        PanelCadastro.Visible = False
        Label8.Text = "Relatórios"
        Label9.Text = "Selecione o modelo desejado"
        Frm_Relatorio.MdiParent = Me
        Frm_Relatorio.Show()
    End Sub
    Private Sub contamaquina()
        Try
            Using cn = New SqlConnection(strcon)
                cn.Close()
                cn.Open()
                Dim sql = "select count(equipamento) from equipamento where ativo = 1"
                Using cmd = New SqlCommand(sql, cn)
                    Using dr = cmd.ExecuteReader
                        If dr.HasRows Then
                            If dr.Read Then
                                LQtdeMaquinas.Text = dr("")
                            End If
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            Dim unused = MsgBox("Algo deu errado com a conexão!" & vbNewLine & vbNewLine & ex.Message, vbCritical)
        End Try
    End Sub
    Private Sub contamaquinainativa()
        Try
            Using cn = New SqlConnection(strcon)
                cn.Close()
                cn.Open()
                Dim sql = "select count(equipamento) from equipamento where ativo = 0"
                Using cmd = New SqlCommand(sql, cn)
                    Using dr = cmd.ExecuteReader
                        If dr.HasRows Then
                            If dr.Read Then
                                Lbequipamentoinativo.Text = dr("")
                            End If
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            Dim unused = MsgBox("Algo deu errado com a conexão!" & vbNewLine & vbNewLine & ex.Message, vbCritical)
        End Try
    End Sub
    Private Sub AplicativoDesatualizado()
        Try
            Using cn = New SqlConnection(strcon)
                cn.Close()
                cn.Open()
                Dim sql = "select count(item) from item_equipamento where realizado = 0"
                Using cmd = New SqlCommand(sql, cn)
                    Using dr = cmd.ExecuteReader
                        If dr.HasRows Then
                            If dr.Read Then
                                LAplicativodesatualizado.Text = dr("")
                            End If
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            Dim unused = MsgBox("Algo deu errado com a conexão!" & vbNewLine & vbNewLine & ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub Frm_Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AplicativoDesatualizado()
        contamaquina()
        contamaquinainativa()
        BtMax.Visible = False
        Frm_Login.ShowDialog()
        PanelCentro.Visible = True
        PanelSubTopo.Visible = True
        PanelTop.Visible = True
        PanelCadastro.Visible = False
        carrega_graf3()
    End Sub

    Private Sub BtFechar_Click(sender As Object, e As EventArgs) Handles BtFechar.Click
        Dim result = MessageBox.Show("Deseja sair do sistema?", "Aviso!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            ' Verifique se há algum formulário aberto
            For Each frm As Form In Application.OpenForms
                If frm IsNot Me Then ' Não verifique o próprio formulário principal
                    MessageBox.Show("Ainda existem formulários abertos. Feche-os primeiro.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return ' Impede o fechamento da aplicação
                    Exit Sub ' Saia do loop após a primeira verificação

                End If
            Next
            Application.Exit()
        Else

        End If
    End Sub

    Private Sub BtNormal_Click(sender As Object, e As EventArgs) Handles BtNormal.Click
        Me.WindowState = FormWindowState.Normal
        BtMax.Visible = True
        BtNormal.Visible = False
    End Sub
    Private Sub BtMax_Click(sender As Object, e As EventArgs) Handles BtMax.Click
        Me.WindowState = FormWindowState.Maximized
        BtMax.Visible = False
        BtNormal.Visible = True
    End Sub
    Private Sub BtMin_Click(sender As Object, e As EventArgs) Handles BtMin.Click
        Me.WindowState = FormWindowState.Minimized
        BtNormal.Visible = True
        BtMax.Visible = False
    End Sub
    Private Sub BtConfiguracao_Click(sender As Object, e As EventArgs) Handles BtConfiguracao.Click

        PanelCentro.Visible = False
        PanelSubTopo.Visible = True
        PanelTop.Visible = True
        PanelCadastro.Visible = False
        Label8.Text = "Configuração de conexão"
        Label9.Text = "Insira as credenciais"
        Frm_ConexaoDb.ShowDialog()
    End Sub
    Private Sub Tlblogoff_Click(sender As Object, e As EventArgs) Handles Tlblogoff.Click

        Dim result = MessageBox.Show("Fazer logoff desse usuário " & TlbNomeusuario.Text & " ", "Aviso!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            ' Verifique se há algum formulário aberto
            For Each frm As Form In Application.OpenForms
                If frm IsNot Me Then ' Não verifique o próprio formulário principal
                    MessageBox.Show("Ainda existem formulários abertos. Feche-os primeiro.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return ' Impede o fechamento da aplicação
                    Exit Sub ' Saia do loop após a primeira verificação

                End If
            Next
            Frm_Login.ShowDialog()
        Else

        End If
    End Sub
    Private Sub BtCadastro_Click(sender As Object, e As EventArgs) Handles BtCadastro.Click
        PanelCentro.Visible = False
        PanelTop.Visible = True
        PanelCadastro.Visible = True
        Label8.Text = "Menu"
        Label9.Text = "Cadastros"

    End Sub

    Private Sub BtEquipamentos_Click(sender As Object, e As EventArgs) Handles BtEquipamentos.Click
        FrmCadMaquinas.MdiParent = Me
        FrmCadMaquinas.Show()
        PanelCentro.Visible = False
        PanelSubTopo.Visible = True
        PanelTop.Visible = True
        PanelCadastro.Visible = False
    End Sub

    Private Sub BtServidor_Click(sender As Object, e As EventArgs) Handles BtServidor.Click
        If USUARIO.Text = "ALLAN" Then
            Frm_Servidores.MdiParent = Me
            Frm_Servidores.Show()
            PanelCentro.Visible = False
            PanelSubTopo.Visible = True
            PanelTop.Visible = True
            PanelCadastro.Visible = False

        Else
            MsgBox("Sem permissão! ", vbInformation, "Aviso!")
        End If
    End Sub

    Private Sub BtEmail_Click(sender As Object, e As EventArgs) Handles BtEmail.Click
        Frm_Item.MdiParent = Me
        Frm_Item.Show()
    End Sub

    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click
        MsgBox("Por enquanto em caso de duvida falar comigo mesmo (69) 9.8497-1714 *_* ", vbInformation, "Aviso! ")
    End Sub
    Private Sub gerargrafico()
        'segundo e complemento do cabeçalho
        Dim title2 = New Title
        title2.Font = New Font("Arial", 11, FontStyle.Bold Or FontStyle.Italic Or FontStyle.Underline)
        title2.ForeColor = Color.Blue
        title2.Text = "Ativos e Inativos"
        Chart2.Titles.Add(title2)
        'montagem do grafico EQUIPAMENTO ATIVO
        Chart2.Series.Add("Equipamentos ativos")
        With Chart2.Series("Equipamentos ativos")
            .ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
            .BorderWidth = 4
            .Color = Color.Green
            .Points.AddXY("Suporte01", 150)
            .Points.AddXY("Suporte02", 140)
            .Points.AddXY("Suporte03", 100)
            .Points.AddXY("Suporte04", 90)
            .Points.AddXY("Suporte05", 87)
            .Points.AddXY("Suporte06", 50)

        End With

        'montagem do grafico
        Chart2.Series.Add("Equipamentos Inativos")
        With Chart2.Series("Equipamentos Inativos")
            .ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
            .BorderWidth = 4
            .Color = Color.Red
            .Points.AddXY("Suporte07", 10)
            .Points.AddXY("Suporte08", 5)
        End With

    End Sub
    Private Sub carrega_graf3()
        Try
            Using cn = New SqlConnection(strcon)
                cn.Open()
                Dim sql As String = "SELECT ID_ITEM, NOME FROM EMAIL_ITEM  WHERE TIPO = 'Item' AND ATIVO = 1 ORDER BY NOME"
                Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                da.Fill(dt)

                Chart3.Series.Clear()
                Chart3.ChartAreas.Clear()
                Chart3.ChartAreas.Add(New ChartArea("ChartArea1"))
                Chart3.Series.Add(New Series("Nome"))

                Chart3.DataSource = dt
                Chart3.Series("Nome").XValueMember = "Nome"
                Chart3.Series("Nome").YValueMembers = "id_item"
                Chart3.Series("Nome").ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.[Line]

                Chart3.DataBind()
                '--------
                Chart2.Series.Clear()
                Chart2.ChartAreas.Clear()
                Chart2.ChartAreas.Add(New ChartArea("ChartArea1"))
                Chart2.Series.Add(New Series("Nome"))

                Chart2.DataSource = dt
                Chart2.Series("Nome").XValueMember = "Nome"
                Chart2.Series("Nome").YValueMembers = "id_item"
                'Chart2.Series("Nome").ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie

                Chart2.DataBind()
            End Using
        Catch ex As Exception
            Dim unused = MsgBox("Algo deu errado com a conexão!" & vbNewLine & vbNewLine & ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub CadastroDeUsuárioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CadastroDeUsuárioToolStripMenuItem.Click
        Frm_Usuario.MdiParent = Me
        Frm_Usuario.Show()
        PanelCentro.Visible = False
        PanelTop.Visible = True
        PanelCadastro.Visible = False

    End Sub
    Private Sub checaformaberto()
        ' Nome do formulário que você deseja verificar se está aberto
        Dim nomeDoFormulario As String = "frm_item" Or "frm_cadmaquinas"

        ' Verifique se o formulário está aberto
        Dim formularioEstaAberto As Boolean = False

        For Each frm As Form In Application.OpenForms
            If frm.Name = nomeDoFormulario Then
                formularioEstaAberto = True
                Exit For ' O formulário foi encontrado, não é necessário continuar a procurar
            End If
        Next

        ' Agora você pode usar a variável "formularioEstaAberto" para determinar se o formulário está aberto.
        If formularioEstaAberto Then
            MessageBox.Show("O formulário está aberto.")
        Else
            MessageBox.Show("O formulário não está aberto.")
        End If
    End Sub

    Private Sub ExcelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExcelToolStripMenuItem.Click
        FrmExcel.Show()
    End Sub

    Private Sub PDVToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PDVToolStripMenuItem.Click
        FrmPDV.ShowDialog()
    End Sub

    Private Sub StVersaoDb_Click(sender As Object, e As EventArgs) Handles StVersaoDb.Click
        inserirVersao()
    End Sub
    Private Sub inserirVersao()
        Dim versaodb = InputBox("Qual a versão do Banco")
        Dim versaoexe = InputBox("Qual a versão do EXE")

        If versaodb = "" Or versaoexe = "" Then
            MsgBox("Versão do banco de dads " & versaodb & " Versão do Executável " & versaoexe & " Não foi inserido valor")
        Else

            Try
                Using cn = New SqlConnection(strcon)
                    cn.Open()

                    Dim sql = "UPDATE VERSAO SET VERSAODB=@VERSAODB,VERSAOEXE=@VERSAOEXE,VERSAODB_OLD=VERSAODB,VERSAOEXE_OLD=VERSAOEXE"
                    Using cmd = New SqlCommand(sql, cn)
                        cmd.Parameters.AddWithValue("@VERSAODB", versaodb)
                        cmd.Parameters.AddWithValue("@VERSAOEXE", versaoexe)
                        cmd.ExecuteNonQuery()
                        MsgBox("Versão do banco de dads " & versaodb & " Versão do Executável " & versaoexe)
                        MsgBox("Registro atualizado com sucesso!", vbInformation, "Aviso!")
                    End Using
                End Using

            Catch ex As Exception
                MsgBox("Algo deu errado com a conexão! #alteraregistroitem" & vbNewLine & vbNewLine & ex.Message, vbCritical)
            End Try
        End If
    End Sub
    Private Sub ToolStripDropDownButton1_Click(sender As Object, e As EventArgs) Handles ToolStripDropDownButton1.Click
        If USUARIO.Text <> "ALLAN" Then
            StVersaoDb.Visible = False

        Else
            StVersaoDb.Visible = True

        End If
    End Sub

    Private Sub BuscarDadosDoSistemaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuscarDadosDoSistemaToolStripMenuItem.Click
        Frm_systema.Show()
    End Sub

    Private Sub EmpresaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmpresaToolStripMenuItem.Click
        FrmEmpresa.MdiParent = Me
        FrmEmpresa.Show()
    End Sub

    Private Sub BtOs_Click(sender As Object, e As EventArgs) Handles BtOs.Click
        PanelCentro.Visible = False
        PanelTop.Visible = True
        PanelCadastro.Visible = False
        Label8.Text = "Ordem de Serviço"
        Label9.Text = "Lançamento de Ordem de serviços"

        Frm_OS.Show()

    End Sub

    Private Sub BtCliente_Click(sender As Object, e As EventArgs) Handles BtCliente.Click
        PanelCentro.Visible = False
        PanelSubTopo.Visible = True
        PanelTop.Visible = True
        PanelCadastro.Visible = False
        Label8.Text = "Cadastro"
        Label9.Text = "Cadastro de Cliente"
        Frm_Cliente.MdiParent = Me
        Frm_Cliente.Show()
    End Sub

    Private Sub ItauToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ItauToolStripMenuItem.Click
        Form1.Show()
    End Sub
End Class
