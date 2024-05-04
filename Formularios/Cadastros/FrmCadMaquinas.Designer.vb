<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCadMaquinas
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(FrmCadMaquinas))
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Label4 = New Label()
        DtData = New DateTimePicker()
        BtExcluirItem = New Button()
        Label5 = New Label()
        CbRealizado = New ComboBox()
        Label6 = New Label()
        CbItem = New ComboBox()
        BtIncluir = New Button()
        GbListagem = New GroupBox()
        BtCancelarItem = New Button()
        BtAtualizarItem = New Button()
        Label15 = New Label()
        TObsItem = New TextBox()
        DG1 = New DataGridView()
        Lidmodelo = New Label()
        Label14 = New Label()
        Label3 = New Label()
        TDdr = New TextBox()
        Label13 = New Label()
        TGhz = New TextBox()
        Label12 = New Label()
        GbDados = New GroupBox()
        TNHD = New TextBox()
        Label27 = New Label()
        CbModelo = New ComboBox()
        Label26 = New Label()
        Label25 = New Label()
        TIdentificacao = New TextBox()
        Label16 = New Label()
        CbAtivo = New ComboBox()
        Label17 = New Label()
        Label11 = New Label()
        TObsEquipamento = New TextBox()
        THd2 = New TextBox()
        TWindows = New TextBox()
        Label10 = New Label()
        THd1 = New TextBox()
        Label9 = New Label()
        TMemoria = New TextBox()
        Label8 = New Label()
        Tprocessador = New TextBox()
        Label7 = New Label()
        TNome = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        tidmaquina = New TextBox()
        TSenha = New TextBox()
        TUsuario = New TextBox()
        BtSalvar = New Button()
        BtNovo = New Button()
        BtCancelar = New Button()
        BtExcluir = New Button()
        BtEditar = New Button()
        BtFechar = New Button()
        BtAtualizar = New Button()
        GbPesquisaEquipamento = New GroupBox()
        Label24 = New Label()
        LbContaLinhas = New Label()
        Tpesquisa = New TextBox()
        DgEquipamentos = New DataGridView()
        Panel1 = New Panel()
        Gbsenha = New GroupBox()
        Pfolhosenha = New PictureBox()
        PfOlhovirus = New PictureBox()
        PfOlhoMicrosoft = New PictureBox()
        Polhosenha = New PictureBox()
        POlhoVirus = New PictureBox()
        POlhoMicrosoft = New PictureBox()
        CbContaAntiVirus = New ComboBox()
        CbEmail = New ComboBox()
        Cbemailoffice = New ComboBox()
        TSenhaOffice = New TextBox()
        Label22 = New Label()
        Label23 = New Label()
        TSenhaAntiVirus = New TextBox()
        Label21 = New Label()
        Label20 = New Label()
        TSenhaEmail = New TextBox()
        Label19 = New Label()
        Label18 = New Label()
        MenuStrip1 = New MenuStrip()
        CadastrosToolStripMenuItem = New ToolStripMenuItem()
        EmailToolStripMenuItem = New ToolStripMenuItem()
        MbServico = New ToolStripMenuItem()
        RelatóriosToolStripMenuItem = New ToolStripMenuItem()
        RelatórioAgrupadoEquipamentoToolStripMenuItem = New ToolStripMenuItem()
        RelatToolStripMenuItem = New ToolStripMenuItem()
        ListagemEquipamentoToolStripMenuItem = New ToolStripMenuItem()
        ListagemChklistToolStripMenuItem = New ToolStripMenuItem()
        GbListagem.SuspendLayout()
        CType(DG1, ComponentModel.ISupportInitialize).BeginInit()
        GbDados.SuspendLayout()
        GbPesquisaEquipamento.SuspendLayout()
        CType(DgEquipamentos, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        Gbsenha.SuspendLayout()
        CType(Pfolhosenha, ComponentModel.ISupportInitialize).BeginInit()
        CType(PfOlhovirus, ComponentModel.ISupportInitialize).BeginInit()
        CType(PfOlhoMicrosoft, ComponentModel.ISupportInitialize).BeginInit()
        CType(Polhosenha, ComponentModel.ISupportInitialize).BeginInit()
        CType(POlhoVirus, ComponentModel.ISupportInitialize).BeginInit()
        CType(POlhoMicrosoft, ComponentModel.ISupportInitialize).BeginInit()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(425, 19)
        Label4.Name = "Label4"
        Label4.Size = New Size(34, 15)
        Label4.TabIndex = 28
        Label4.Text = "Data:"' 
        ' DtData
        ' 
        DtData.CalendarFont = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        DtData.Format = DateTimePickerFormat.Short
        DtData.Location = New Point(425, 40)
        DtData.Name = "DtData"
        DtData.Size = New Size(102, 23)
        DtData.TabIndex = 23
        ' 
        ' BtExcluirItem
        ' 
        BtExcluirItem.BackColor = Color.FromArgb(CByte(51), CByte(51), CByte(76))
        BtExcluirItem.FlatStyle = FlatStyle.Flat
        BtExcluirItem.ForeColor = SystemColors.Window
        BtExcluirItem.Image = CType(resources.GetObject("BtExcluirItem.Image"), Image)
        BtExcluirItem.ImageAlign = ContentAlignment.TopLeft
        BtExcluirItem.Location = New Point(549, 69)
        BtExcluirItem.Name = "BtExcluirItem"
        BtExcluirItem.Size = New Size(75, 23)
        BtExcluirItem.TabIndex = 26
        BtExcluirItem.Text = "Excluir"
        BtExcluirItem.TextAlign = ContentAlignment.TopLeft
        BtExcluirItem.TextImageRelation = TextImageRelation.ImageBeforeText
        BtExcluirItem.UseVisualStyleBackColor = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(317, 19)
        Label5.Name = "Label5"
        Label5.Size = New Size(60, 15)
        Label5.TabIndex = 25
        Label5.Text = "Realizado:"' 
        ' CbRealizado
        ' 
        CbRealizado.DropDownStyle = ComboBoxStyle.DropDownList
        CbRealizado.FormattingEnabled = True
        CbRealizado.Items.AddRange(New Object() {"Sim", "Não"})
        CbRealizado.Location = New Point(317, 40)
        CbRealizado.Name = "CbRealizado"
        CbRealizado.Size = New Size(102, 23)
        CbRealizado.TabIndex = 22
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(7, 19)
        Label6.Name = "Label6"
        Label6.Size = New Size(34, 15)
        Label6.TabIndex = 23
        Label6.Text = "Item:"' 
        ' CbItem
        ' 
        CbItem.FormattingEnabled = True
        CbItem.Location = New Point(7, 40)
        CbItem.Name = "CbItem"
        CbItem.Size = New Size(304, 23)
        CbItem.TabIndex = 21
        ' 
        ' BtIncluir
        ' 
        BtIncluir.BackColor = Color.FromArgb(CByte(51), CByte(51), CByte(76))
        BtIncluir.FlatStyle = FlatStyle.Flat
        BtIncluir.ForeColor = SystemColors.Window
        BtIncluir.Image = CType(resources.GetObject("BtIncluir.Image"), Image)
        BtIncluir.ImageAlign = ContentAlignment.TopLeft
        BtIncluir.Location = New Point(549, 69)
        BtIncluir.Name = "BtIncluir"
        BtIncluir.Size = New Size(75, 23)
        BtIncluir.TabIndex = 25
        BtIncluir.Text = "Incluir"
        BtIncluir.TextAlign = ContentAlignment.TopLeft
        BtIncluir.TextImageRelation = TextImageRelation.ImageBeforeText
        BtIncluir.UseVisualStyleBackColor = False
        ' 
        ' GbListagem
        ' 
        GbListagem.Controls.Add(BtCancelarItem)
        GbListagem.Controls.Add(BtAtualizarItem)
        GbListagem.Controls.Add(Label15)
        GbListagem.Controls.Add(TObsItem)
        GbListagem.Controls.Add(Label4)
        GbListagem.Controls.Add(DtData)
        GbListagem.Controls.Add(BtExcluirItem)
        GbListagem.Controls.Add(Label5)
        GbListagem.Controls.Add(CbRealizado)
        GbListagem.Controls.Add(Label6)
        GbListagem.Controls.Add(CbItem)
        GbListagem.Controls.Add(DG1)
        GbListagem.Controls.Add(BtIncluir)
        GbListagem.Location = New Point(332, 320)
        GbListagem.Name = "GbListagem"
        GbListagem.Size = New Size(711, 260)
        GbListagem.TabIndex = 33
        GbListagem.TabStop = False
        GbListagem.Text = "Listagem"' 
        ' BtCancelarItem
        ' 
        BtCancelarItem.BackColor = Color.FromArgb(CByte(51), CByte(51), CByte(76))
        BtCancelarItem.FlatStyle = FlatStyle.Flat
        BtCancelarItem.ForeColor = SystemColors.Window
        BtCancelarItem.Image = CType(resources.GetObject("BtCancelarItem.Image"), Image)
        BtCancelarItem.ImageAlign = ContentAlignment.TopLeft
        BtCancelarItem.Location = New Point(630, 69)
        BtCancelarItem.Name = "BtCancelarItem"
        BtCancelarItem.Size = New Size(75, 23)
        BtCancelarItem.TabIndex = 41
        BtCancelarItem.Text = "Cancelar"
        BtCancelarItem.TextAlign = ContentAlignment.TopLeft
        BtCancelarItem.TextImageRelation = TextImageRelation.ImageBeforeText
        BtCancelarItem.UseVisualStyleBackColor = False
        ' 
        ' BtAtualizarItem
        ' 
        BtAtualizarItem.BackColor = Color.FromArgb(CByte(51), CByte(51), CByte(76))
        BtAtualizarItem.FlatStyle = FlatStyle.Flat
        BtAtualizarItem.ForeColor = SystemColors.Window
        BtAtualizarItem.Image = CType(resources.GetObject("BtAtualizarItem.Image"), Image)
        BtAtualizarItem.ImageAlign = ContentAlignment.TopLeft
        BtAtualizarItem.Location = New Point(468, 69)
        BtAtualizarItem.Name = "BtAtualizarItem"
        BtAtualizarItem.Size = New Size(75, 23)
        BtAtualizarItem.TabIndex = 40
        BtAtualizarItem.Text = "Atualizar"
        BtAtualizarItem.TextAlign = ContentAlignment.TopLeft
        BtAtualizarItem.TextImageRelation = TextImageRelation.ImageBeforeText
        BtAtualizarItem.UseVisualStyleBackColor = False
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Location = New Point(533, 19)
        Label15.Name = "Label15"
        Label15.Size = New Size(116, 15)
        Label15.TabIndex = 39
        Label15.Text = "Observação do item:"' 
        ' TObsItem
        ' 
        TObsItem.Location = New Point(533, 40)
        TObsItem.MaxLength = 250
        TObsItem.Name = "TObsItem"
        TObsItem.Size = New Size(172, 23)
        TObsItem.TabIndex = 24
        ' 
        ' DG1
        ' 
        DG1.AllowUserToAddRows = False
        DG1.AllowUserToDeleteRows = False
        DG1.AllowUserToOrderColumns = True
        DG1.AllowUserToResizeRows = False
        DG1.BackgroundColor = Color.FromArgb(CByte(51), CByte(51), CByte(76))
        DG1.BorderStyle = BorderStyle.None
        DG1.CellBorderStyle = DataGridViewCellBorderStyle.None
        DG1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        DG1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        DG1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        DG1.DefaultCellStyle = DataGridViewCellStyle2
        DG1.GridColor = SystemColors.ScrollBar
        DG1.Location = New Point(6, 99)
        DG1.Name = "DG1"
        DG1.ReadOnly = True
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = SystemColors.Control
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        DG1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        DG1.RowHeadersVisible = False
        DG1.RowTemplate.Height = 25
        DG1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DG1.Size = New Size(699, 155)
        DG1.TabIndex = 11
        ' 
        ' Lidmodelo
        ' 
        Lidmodelo.AutoSize = True
        Lidmodelo.Location = New Point(252, 65)
        Lidmodelo.Name = "Lidmodelo"
        Lidmodelo.Size = New Size(58, 15)
        Lidmodelo.TabIndex = 42
        Lidmodelo.Text = "idmodelo"
        Lidmodelo.Visible = False
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Location = New Point(8, 138)
        Label14.Name = "Label14"
        Label14.Size = New Size(49, 15)
        Label14.TabIndex = 37
        Label14.Text = "Código:"' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(252, 51)
        Label3.Name = "Label3"
        Label3.Size = New Size(42, 15)
        Label3.TabIndex = 36
        Label3.Text = "Senha:"' 
        ' TDdr
        ' 
        TDdr.CharacterCasing = CharacterCasing.Upper
        TDdr.Location = New Point(627, 48)
        TDdr.MaxLength = 5
        TDdr.Name = "TDdr"
        TDdr.Size = New Size(78, 23)
        TDdr.TabIndex = 10
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(586, 51)
        Label13.Name = "Label13"
        Label13.Size = New Size(30, 15)
        Label13.TabIndex = 34
        Label13.Text = "DDR"' 
        ' TGhz
        ' 
        TGhz.CharacterCasing = CharacterCasing.Upper
        TGhz.Location = New Point(649, 19)
        TGhz.MaxLength = 10
        TGhz.Name = "TGhz"
        TGhz.Size = New Size(56, 23)
        TGhz.TabIndex = 8
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(614, 22)
        Label12.Name = "Label12"
        Label12.Size = New Size(29, 15)
        Label12.TabIndex = 32
        Label12.Text = "GHz"' 
        ' GbDados
        ' 
        GbDados.Controls.Add(Lidmodelo)
        GbDados.Controls.Add(TNHD)
        GbDados.Controls.Add(Label27)
        GbDados.Controls.Add(CbModelo)
        GbDados.Controls.Add(Label26)
        GbDados.Controls.Add(Label25)
        GbDados.Controls.Add(TIdentificacao)
        GbDados.Controls.Add(Label16)
        GbDados.Controls.Add(CbAtivo)
        GbDados.Controls.Add(Label3)
        GbDados.Controls.Add(TDdr)
        GbDados.Controls.Add(Label13)
        GbDados.Controls.Add(TGhz)
        GbDados.Controls.Add(Label12)
        GbDados.Controls.Add(Label17)
        GbDados.Controls.Add(Label11)
        GbDados.Controls.Add(TObsEquipamento)
        GbDados.Controls.Add(THd2)
        GbDados.Controls.Add(TWindows)
        GbDados.Controls.Add(Label10)
        GbDados.Controls.Add(THd1)
        GbDados.Controls.Add(Label9)
        GbDados.Controls.Add(TMemoria)
        GbDados.Controls.Add(Label8)
        GbDados.Controls.Add(Tprocessador)
        GbDados.Controls.Add(Label7)
        GbDados.Controls.Add(TNome)
        GbDados.Controls.Add(Label1)
        GbDados.Controls.Add(Label2)
        GbDados.Controls.Add(tidmaquina)
        GbDados.Controls.Add(TSenha)
        GbDados.Controls.Add(TUsuario)
        GbDados.Controls.Add(Label14)
        GbDados.Location = New Point(331, 27)
        GbDados.Name = "GbDados"
        GbDados.Size = New Size(711, 166)
        GbDados.TabIndex = 32
        GbDados.TabStop = False
        GbDados.Text = "Dados principais:"' 
        ' TNHD
        ' 
        TNHD.CharacterCasing = CharacterCasing.Upper
        TNHD.Location = New Point(505, 106)
        TNHD.MaxLength = 100
        TNHD.Name = "TNHD"
        TNHD.Size = New Size(200, 23)
        TNHD.TabIndex = 13
        ' 
        ' Label27
        ' 
        Label27.AutoSize = True
        Label27.Location = New Point(425, 109)
        Label27.Name = "Label27"
        Label27.Size = New Size(44, 15)
        Label27.TabIndex = 57
        Label27.Text = "N° HD:"' 
        ' CbModelo
        ' 
        CbModelo.FormattingEnabled = True
        CbModelo.Location = New Point(301, 77)
        CbModelo.Name = "CbModelo"
        CbModelo.Size = New Size(119, 23)
        CbModelo.TabIndex = 5
        ' 
        ' Label26
        ' 
        Label26.AutoSize = True
        Label26.Location = New Point(253, 80)
        Label26.Name = "Label26"
        Label26.Size = New Size(51, 15)
        Label26.TabIndex = 55
        Label26.Text = "Modelo:"' 
        ' Label25
        ' 
        Label25.AutoSize = True
        Label25.Location = New Point(7, 80)
        Label25.Name = "Label25"
        Label25.Size = New Size(78, 15)
        Label25.TabIndex = 54
        Label25.Text = "Identificação:"' 
        ' TIdentificacao
        ' 
        TIdentificacao.CharacterCasing = CharacterCasing.Upper
        TIdentificacao.Location = New Point(122, 77)
        TIdentificacao.MaxLength = 15
        TIdentificacao.Name = "TIdentificacao"
        TIdentificacao.Size = New Size(125, 23)
        TIdentificacao.TabIndex = 4
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Location = New Point(246, 138)
        Label16.Name = "Label16"
        Label16.Size = New Size(38, 15)
        Label16.TabIndex = 30
        Label16.Text = "Ativo:"' 
        ' CbAtivo
        ' 
        CbAtivo.DropDownStyle = ComboBoxStyle.DropDownList
        CbAtivo.FormattingEnabled = True
        CbAtivo.Items.AddRange(New Object() {"Sim", "Não"})
        CbAtivo.Location = New Point(295, 135)
        CbAtivo.Name = "CbAtivo"
        CbAtivo.Size = New Size(125, 23)
        CbAtivo.TabIndex = 4
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Location = New Point(7, 109)
        Label17.Name = "Label17"
        Label17.Size = New Size(72, 15)
        Label17.TabIndex = 52
        Label17.Text = "Observação:"' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(425, 138)
        Label11.Name = "Label11"
        Label11.Size = New Size(59, 15)
        Label11.TabIndex = 30
        Label11.Text = "Windows:"' 
        ' TObsEquipamento
        ' 
        TObsEquipamento.CharacterCasing = CharacterCasing.Upper
        TObsEquipamento.Location = New Point(122, 106)
        TObsEquipamento.MaxLength = 250
        TObsEquipamento.Name = "TObsEquipamento"
        TObsEquipamento.Size = New Size(297, 23)
        TObsEquipamento.TabIndex = 6
        ' 
        ' THd2
        ' 
        THd2.CharacterCasing = CharacterCasing.Upper
        THd2.Location = New Point(627, 77)
        THd2.MaxLength = 15
        THd2.Name = "THd2"
        THd2.Size = New Size(78, 23)
        THd2.TabIndex = 12
        ' 
        ' TWindows
        ' 
        TWindows.CharacterCasing = CharacterCasing.Upper
        TWindows.Location = New Point(505, 135)
        TWindows.MaxLength = 15
        TWindows.Name = "TWindows"
        TWindows.Size = New Size(200, 23)
        TWindows.TabIndex = 14
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(586, 80)
        Label10.Name = "Label10"
        Label10.Size = New Size(38, 15)
        Label10.TabIndex = 28
        Label10.Text = "HD-2:"' 
        ' THd1
        ' 
        THd1.CharacterCasing = CharacterCasing.Upper
        THd1.Location = New Point(505, 77)
        THd1.MaxLength = 15
        THd1.Name = "THd1"
        THd1.Size = New Size(75, 23)
        THd1.TabIndex = 11
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(425, 80)
        Label9.Name = "Label9"
        Label9.Size = New Size(38, 15)
        Label9.TabIndex = 26
        Label9.Text = "HD-1:"' 
        ' TMemoria
        ' 
        TMemoria.CharacterCasing = CharacterCasing.Upper
        TMemoria.Location = New Point(505, 48)
        TMemoria.MaxLength = 5
        TMemoria.Name = "TMemoria"
        TMemoria.Size = New Size(75, 23)
        TMemoria.TabIndex = 9
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(425, 51)
        Label8.Name = "Label8"
        Label8.Size = New Size(58, 15)
        Label8.TabIndex = 24
        Label8.Text = "Memoria:"' 
        ' Tprocessador
        ' 
        Tprocessador.CharacterCasing = CharacterCasing.Upper
        Tprocessador.Location = New Point(505, 19)
        Tprocessador.MaxLength = 15
        Tprocessador.Name = "Tprocessador"
        Tprocessador.Size = New Size(103, 23)
        Tprocessador.TabIndex = 7
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(425, 22)
        Label7.Name = "Label7"
        Label7.Size = New Size(74, 15)
        Label7.TabIndex = 22
        Label7.Text = "Processador:"' 
        ' TNome
        ' 
        TNome.CharacterCasing = CharacterCasing.Upper
        TNome.Location = New Point(121, 19)
        TNome.MaxLength = 60
        TNome.Name = "TNome"
        TNome.Size = New Size(299, 23)
        TNome.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(6, 22)
        Label1.Name = "Label1"
        Label1.Size = New Size(109, 15)
        Label1.TabIndex = 0
        Label1.Text = "Nome da maquina:"' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(6, 51)
        Label2.Name = "Label2"
        Label2.Size = New Size(50, 15)
        Label2.TabIndex = 12
        Label2.Text = "Usuário:"' 
        ' tidmaquina
        ' 
        tidmaquina.Enabled = False
        tidmaquina.Location = New Point(121, 135)
        tidmaquina.Name = "tidmaquina"
        tidmaquina.Size = New Size(119, 23)
        tidmaquina.TabIndex = 5
        ' 
        ' TSenha
        ' 
        TSenha.Location = New Point(300, 48)
        TSenha.MaxLength = 15
        TSenha.Name = "TSenha"
        TSenha.Size = New Size(119, 23)
        TSenha.TabIndex = 3
        ' 
        ' TUsuario
        ' 
        TUsuario.CharacterCasing = CharacterCasing.Upper
        TUsuario.Location = New Point(121, 48)
        TUsuario.MaxLength = 30
        TUsuario.Name = "TUsuario"
        TUsuario.Size = New Size(125, 23)
        TUsuario.TabIndex = 2
        ' 
        ' BtSalvar
        ' 
        BtSalvar.BackColor = Color.FromArgb(CByte(51), CByte(51), CByte(76))
        BtSalvar.FlatAppearance.BorderSize = 0
        BtSalvar.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(51), CByte(51), CByte(50))
        BtSalvar.FlatStyle = FlatStyle.Flat
        BtSalvar.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        BtSalvar.ForeColor = SystemColors.Window
        BtSalvar.Image = CType(resources.GetObject("BtSalvar.Image"), Image)
        BtSalvar.ImageAlign = ContentAlignment.MiddleLeft
        BtSalvar.Location = New Point(12, 0)
        BtSalvar.Name = "BtSalvar"
        BtSalvar.Size = New Size(111, 50)
        BtSalvar.TabIndex = 26
        BtSalvar.Text = "Salva"
        BtSalvar.TextAlign = ContentAlignment.MiddleLeft
        BtSalvar.TextImageRelation = TextImageRelation.ImageBeforeText
        BtSalvar.UseVisualStyleBackColor = False
        ' 
        ' BtNovo
        ' 
        BtNovo.BackColor = Color.FromArgb(CByte(51), CByte(51), CByte(76))
        BtNovo.BackgroundImageLayout = ImageLayout.None
        BtNovo.FlatAppearance.BorderSize = 0
        BtNovo.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(51), CByte(51), CByte(50))
        BtNovo.FlatStyle = FlatStyle.Flat
        BtNovo.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        BtNovo.ForeColor = SystemColors.Window
        BtNovo.Image = CType(resources.GetObject("BtNovo.Image"), Image)
        BtNovo.ImageAlign = ContentAlignment.MiddleLeft
        BtNovo.Location = New Point(12, 0)
        BtNovo.Name = "BtNovo"
        BtNovo.Size = New Size(111, 50)
        BtNovo.TabIndex = 25
        BtNovo.Text = "Novo"
        BtNovo.TextAlign = ContentAlignment.MiddleLeft
        BtNovo.TextImageRelation = TextImageRelation.ImageBeforeText
        BtNovo.UseVisualStyleBackColor = False
        ' 
        ' BtCancelar
        ' 
        BtCancelar.BackColor = Color.FromArgb(CByte(51), CByte(51), CByte(76))
        BtCancelar.FlatAppearance.BorderSize = 0
        BtCancelar.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(51), CByte(51), CByte(50))
        BtCancelar.FlatStyle = FlatStyle.Flat
        BtCancelar.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        BtCancelar.ForeColor = SystemColors.Window
        BtCancelar.Image = CType(resources.GetObject("BtCancelar.Image"), Image)
        BtCancelar.ImageAlign = ContentAlignment.MiddleLeft
        BtCancelar.Location = New Point(129, 0)
        BtCancelar.Name = "BtCancelar"
        BtCancelar.Size = New Size(111, 50)
        BtCancelar.TabIndex = 29
        BtCancelar.Text = "Cancelar"
        BtCancelar.TextAlign = ContentAlignment.MiddleLeft
        BtCancelar.TextImageRelation = TextImageRelation.ImageBeforeText
        BtCancelar.UseVisualStyleBackColor = False
        ' 
        ' BtExcluir
        ' 
        BtExcluir.BackColor = Color.FromArgb(CByte(51), CByte(51), CByte(76))
        BtExcluir.FlatAppearance.BorderSize = 0
        BtExcluir.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(51), CByte(51), CByte(50))
        BtExcluir.FlatStyle = FlatStyle.Flat
        BtExcluir.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        BtExcluir.ForeColor = SystemColors.Window
        BtExcluir.Image = CType(resources.GetObject("BtExcluir.Image"), Image)
        BtExcluir.ImageAlign = ContentAlignment.MiddleLeft
        BtExcluir.Location = New Point(246, 0)
        BtExcluir.Name = "BtExcluir"
        BtExcluir.Size = New Size(111, 50)
        BtExcluir.TabIndex = 28
        BtExcluir.Text = "Excluir"
        BtExcluir.TextAlign = ContentAlignment.MiddleLeft
        BtExcluir.TextImageRelation = TextImageRelation.ImageBeforeText
        BtExcluir.UseVisualStyleBackColor = False
        ' 
        ' BtEditar
        ' 
        BtEditar.BackColor = Color.FromArgb(CByte(51), CByte(51), CByte(76))
        BtEditar.FlatAppearance.BorderSize = 0
        BtEditar.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(51), CByte(51), CByte(50))
        BtEditar.FlatStyle = FlatStyle.Flat
        BtEditar.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        BtEditar.ForeColor = SystemColors.Window
        BtEditar.Image = CType(resources.GetObject("BtEditar.Image"), Image)
        BtEditar.ImageAlign = ContentAlignment.MiddleLeft
        BtEditar.Location = New Point(129, 0)
        BtEditar.Name = "BtEditar"
        BtEditar.Size = New Size(111, 50)
        BtEditar.TabIndex = 27
        BtEditar.Text = "Editar"
        BtEditar.TextAlign = ContentAlignment.MiddleLeft
        BtEditar.TextImageRelation = TextImageRelation.ImageBeforeText
        BtEditar.UseVisualStyleBackColor = False
        ' 
        ' BtFechar
        ' 
        BtFechar.BackColor = Color.FromArgb(CByte(51), CByte(51), CByte(76))
        BtFechar.FlatAppearance.BorderColor = Color.FromArgb(CByte(51), CByte(51), CByte(76))
        BtFechar.FlatAppearance.BorderSize = 0
        BtFechar.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(51), CByte(51), CByte(50))
        BtFechar.FlatStyle = FlatStyle.Flat
        BtFechar.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        BtFechar.ForeColor = SystemColors.Window
        BtFechar.Image = CType(resources.GetObject("BtFechar.Image"), Image)
        BtFechar.ImageAlign = ContentAlignment.MiddleLeft
        BtFechar.Location = New Point(363, 0)
        BtFechar.Name = "BtFechar"
        BtFechar.Size = New Size(111, 50)
        BtFechar.TabIndex = 31
        BtFechar.Text = "Fechar"
        BtFechar.TextAlign = ContentAlignment.MiddleLeft
        BtFechar.TextImageRelation = TextImageRelation.ImageBeforeText
        BtFechar.UseVisualStyleBackColor = False
        ' 
        ' BtAtualizar
        ' 
        BtAtualizar.BackColor = Color.FromArgb(CByte(51), CByte(51), CByte(76))
        BtAtualizar.FlatAppearance.BorderSize = 0
        BtAtualizar.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(51), CByte(51), CByte(50))
        BtAtualizar.FlatStyle = FlatStyle.Flat
        BtAtualizar.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        BtAtualizar.ForeColor = SystemColors.Window
        BtAtualizar.Image = CType(resources.GetObject("BtAtualizar.Image"), Image)
        BtAtualizar.ImageAlign = ContentAlignment.MiddleLeft
        BtAtualizar.Location = New Point(12, 0)
        BtAtualizar.Name = "BtAtualizar"
        BtAtualizar.Size = New Size(111, 50)
        BtAtualizar.TabIndex = 30
        BtAtualizar.Text = "Atualizar"
        BtAtualizar.TextAlign = ContentAlignment.MiddleLeft
        BtAtualizar.TextImageRelation = TextImageRelation.ImageBeforeText
        BtAtualizar.UseVisualStyleBackColor = False
        ' 
        ' GbPesquisaEquipamento
        ' 
        GbPesquisaEquipamento.Controls.Add(Label24)
        GbPesquisaEquipamento.Controls.Add(LbContaLinhas)
        GbPesquisaEquipamento.Controls.Add(Tpesquisa)
        GbPesquisaEquipamento.Controls.Add(DgEquipamentos)
        GbPesquisaEquipamento.Location = New Point(10, 27)
        GbPesquisaEquipamento.Name = "GbPesquisaEquipamento"
        GbPesquisaEquipamento.Size = New Size(316, 553)
        GbPesquisaEquipamento.TabIndex = 39
        GbPesquisaEquipamento.TabStop = False
        GbPesquisaEquipamento.Text = "Buscar por nome da maquina:"' 
        ' Label24
        ' 
        Label24.AutoSize = True
        Label24.BackColor = Color.Transparent
        Label24.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label24.ForeColor = SystemColors.WindowFrame
        Label24.Location = New Point(270, 528)
        Label24.Name = "Label24"
        Label24.Size = New Size(17, 19)
        Label24.TabIndex = 44
        Label24.Text = "0"' 
        ' LbContaLinhas
        ' 
        LbContaLinhas.AutoSize = True
        LbContaLinhas.BackColor = Color.Transparent
        LbContaLinhas.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point)
        LbContaLinhas.ForeColor = SystemColors.WindowFrame
        LbContaLinhas.Location = New Point(6, 528)
        LbContaLinhas.Name = "LbContaLinhas"
        LbContaLinhas.Size = New Size(17, 19)
        LbContaLinhas.TabIndex = 43
        LbContaLinhas.Text = "0"' 
        ' Tpesquisa
        ' 
        Tpesquisa.CharacterCasing = CharacterCasing.Upper
        Tpesquisa.Location = New Point(2, 24)
        Tpesquisa.Name = "Tpesquisa"
        Tpesquisa.Size = New Size(308, 23)
        Tpesquisa.TabIndex = 42
        ' 
        ' DgEquipamentos
        ' 
        DgEquipamentos.AllowUserToAddRows = False
        DgEquipamentos.AllowUserToDeleteRows = False
        DgEquipamentos.AllowUserToResizeRows = False
        DgEquipamentos.BackgroundColor = Color.FromArgb(CByte(51), CByte(51), CByte(76))
        DgEquipamentos.BorderStyle = BorderStyle.None
        DgEquipamentos.CellBorderStyle = DataGridViewCellBorderStyle.None
        DgEquipamentos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = SystemColors.Control
        DataGridViewCellStyle4.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle4.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.True
        DgEquipamentos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        DgEquipamentos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = SystemColors.Window
        DataGridViewCellStyle5.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle5.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = DataGridViewTriState.False
        DgEquipamentos.DefaultCellStyle = DataGridViewCellStyle5
        DgEquipamentos.GridColor = SystemColors.ScrollBar
        DgEquipamentos.Location = New Point(2, 53)
        DgEquipamentos.Name = "DgEquipamentos"
        DgEquipamentos.ReadOnly = True
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = SystemColors.Control
        DataGridViewCellStyle6.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle6.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = DataGridViewTriState.True
        DgEquipamentos.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        DgEquipamentos.RowHeadersVisible = False
        DgEquipamentos.RowTemplate.Height = 25
        DgEquipamentos.ScrollBars = ScrollBars.Vertical
        DgEquipamentos.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DgEquipamentos.Size = New Size(308, 472)
        DgEquipamentos.TabIndex = 40
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(51), CByte(51), CByte(76))
        Panel1.Controls.Add(BtSalvar)
        Panel1.Controls.Add(BtAtualizar)
        Panel1.Controls.Add(BtFechar)
        Panel1.Controls.Add(BtEditar)
        Panel1.Controls.Add(BtExcluir)
        Panel1.Controls.Add(BtNovo)
        Panel1.Controls.Add(BtCancelar)
        Panel1.Dock = DockStyle.Bottom
        Panel1.Location = New Point(0, 589)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1054, 50)
        Panel1.TabIndex = 40
        ' 
        ' Gbsenha
        ' 
        Gbsenha.Controls.Add(Pfolhosenha)
        Gbsenha.Controls.Add(PfOlhovirus)
        Gbsenha.Controls.Add(PfOlhoMicrosoft)
        Gbsenha.Controls.Add(Polhosenha)
        Gbsenha.Controls.Add(POlhoVirus)
        Gbsenha.Controls.Add(POlhoMicrosoft)
        Gbsenha.Controls.Add(CbContaAntiVirus)
        Gbsenha.Controls.Add(CbEmail)
        Gbsenha.Controls.Add(Cbemailoffice)
        Gbsenha.Controls.Add(TSenhaOffice)
        Gbsenha.Controls.Add(Label22)
        Gbsenha.Controls.Add(Label23)
        Gbsenha.Controls.Add(TSenhaAntiVirus)
        Gbsenha.Controls.Add(Label21)
        Gbsenha.Controls.Add(Label20)
        Gbsenha.Controls.Add(TSenhaEmail)
        Gbsenha.Controls.Add(Label19)
        Gbsenha.Controls.Add(Label18)
        Gbsenha.Location = New Point(331, 199)
        Gbsenha.Name = "Gbsenha"
        Gbsenha.Size = New Size(711, 115)
        Gbsenha.TabIndex = 41
        Gbsenha.TabStop = False
        Gbsenha.Text = "Contas e Senhas:"' 
        ' Pfolhosenha
        ' 
        Pfolhosenha.Image = CType(resources.GetObject("Pfolhosenha.Image"), Image)
        Pfolhosenha.Location = New Point(540, 22)
        Pfolhosenha.Name = "Pfolhosenha"
        Pfolhosenha.Size = New Size(19, 23)
        Pfolhosenha.SizeMode = PictureBoxSizeMode.StretchImage
        Pfolhosenha.TabIndex = 72
        Pfolhosenha.TabStop = False
        ' 
        ' PfOlhovirus
        ' 
        PfOlhovirus.Image = CType(resources.GetObject("PfOlhovirus.Image"), Image)
        PfOlhovirus.Location = New Point(540, 51)
        PfOlhovirus.Name = "PfOlhovirus"
        PfOlhovirus.Size = New Size(19, 20)
        PfOlhovirus.SizeMode = PictureBoxSizeMode.StretchImage
        PfOlhovirus.TabIndex = 71
        PfOlhovirus.TabStop = False
        ' 
        ' PfOlhoMicrosoft
        ' 
        PfOlhoMicrosoft.Image = CType(resources.GetObject("PfOlhoMicrosoft.Image"), Image)
        PfOlhoMicrosoft.Location = New Point(540, 80)
        PfOlhoMicrosoft.Name = "PfOlhoMicrosoft"
        PfOlhoMicrosoft.Size = New Size(19, 20)
        PfOlhoMicrosoft.SizeMode = PictureBoxSizeMode.StretchImage
        PfOlhoMicrosoft.TabIndex = 70
        PfOlhoMicrosoft.TabStop = False
        ' 
        ' Polhosenha
        ' 
        Polhosenha.Image = CType(resources.GetObject("Polhosenha.Image"), Image)
        Polhosenha.Location = New Point(540, 22)
        Polhosenha.Name = "Polhosenha"
        Polhosenha.Size = New Size(19, 23)
        Polhosenha.SizeMode = PictureBoxSizeMode.StretchImage
        Polhosenha.TabIndex = 69
        Polhosenha.TabStop = False
        ' 
        ' POlhoVirus
        ' 
        POlhoVirus.Image = CType(resources.GetObject("POlhoVirus.Image"), Image)
        POlhoVirus.Location = New Point(540, 51)
        POlhoVirus.Name = "POlhoVirus"
        POlhoVirus.Size = New Size(19, 20)
        POlhoVirus.SizeMode = PictureBoxSizeMode.StretchImage
        POlhoVirus.TabIndex = 68
        POlhoVirus.TabStop = False
        ' 
        ' POlhoMicrosoft
        ' 
        POlhoMicrosoft.Image = CType(resources.GetObject("POlhoMicrosoft.Image"), Image)
        POlhoMicrosoft.Location = New Point(540, 80)
        POlhoMicrosoft.Name = "POlhoMicrosoft"
        POlhoMicrosoft.Size = New Size(19, 20)
        POlhoMicrosoft.SizeMode = PictureBoxSizeMode.StretchImage
        POlhoMicrosoft.TabIndex = 67
        POlhoMicrosoft.TabStop = False
        ' 
        ' CbContaAntiVirus
        ' 
        CbContaAntiVirus.FormattingEnabled = True
        CbContaAntiVirus.Location = New Point(113, 51)
        CbContaAntiVirus.Name = "CbContaAntiVirus"
        CbContaAntiVirus.Size = New Size(319, 23)
        CbContaAntiVirus.TabIndex = 16
        ' 
        ' CbEmail
        ' 
        CbEmail.FormattingEnabled = True
        CbEmail.Location = New Point(113, 22)
        CbEmail.Name = "CbEmail"
        CbEmail.Size = New Size(319, 23)
        CbEmail.TabIndex = 15
        ' 
        ' Cbemailoffice
        ' 
        Cbemailoffice.FormattingEnabled = True
        Cbemailoffice.Location = New Point(113, 80)
        Cbemailoffice.Name = "Cbemailoffice"
        Cbemailoffice.Size = New Size(319, 23)
        Cbemailoffice.TabIndex = 17
        ' 
        ' TSenhaOffice
        ' 
        TSenhaOffice.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        TSenhaOffice.Location = New Point(565, 80)
        TSenhaOffice.MaxLength = 30
        TSenhaOffice.Name = "TSenhaOffice"
        TSenhaOffice.PasswordChar = "*"c
        TSenhaOffice.Size = New Size(140, 23)
        TSenhaOffice.TabIndex = 20
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.Location = New Point(438, 83)
        Label22.Name = "Label22"
        Label22.Size = New Size(96, 15)
        Label22.TabIndex = 64
        Label22.Text = "Senha Microsoft:"' 
        ' Label23
        ' 
        Label23.AutoSize = True
        Label23.Location = New Point(6, 83)
        Label23.Name = "Label23"
        Label23.Size = New Size(96, 15)
        Label23.TabIndex = 63
        Label23.Text = "Conta Microsoft:"' 
        ' TSenhaAntiVirus
        ' 
        TSenhaAntiVirus.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        TSenhaAntiVirus.Location = New Point(565, 51)
        TSenhaAntiVirus.MaxLength = 30
        TSenhaAntiVirus.Name = "TSenhaAntiVirus"
        TSenhaAntiVirus.PasswordChar = "*"c
        TSenhaAntiVirus.Size = New Size(140, 23)
        TSenhaAntiVirus.TabIndex = 19
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Location = New Point(438, 54)
        Label21.Name = "Label21"
        Label21.Size = New Size(95, 15)
        Label21.TabIndex = 60
        Label21.Text = "Senha anti-virus:"' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Location = New Point(6, 54)
        Label20.Name = "Label20"
        Label20.Size = New Size(94, 15)
        Label20.TabIndex = 58
        Label20.Text = "Conta Anti-virus"' 
        ' TSenhaEmail
        ' 
        TSenhaEmail.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        TSenhaEmail.Location = New Point(565, 22)
        TSenhaEmail.MaxLength = 30
        TSenhaEmail.Name = "TSenhaEmail"
        TSenhaEmail.PasswordChar = "*"c
        TSenhaEmail.Size = New Size(140, 23)
        TSenhaEmail.TabIndex = 18
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Location = New Point(438, 25)
        Label19.Name = "Label19"
        Label19.Size = New Size(42, 15)
        Label19.TabIndex = 56
        Label19.Text = "Senha:"' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Location = New Point(6, 25)
        Label18.Name = "Label18"
        Label18.Size = New Size(39, 15)
        Label18.TabIndex = 54
        Label18.Text = "Email:"' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {CadastrosToolStripMenuItem, MbServico, RelatóriosToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(1054, 24)
        MenuStrip1.TabIndex = 42
        MenuStrip1.Text = "MenuStrip1"' 
        ' CadastrosToolStripMenuItem
        ' 
        CadastrosToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {EmailToolStripMenuItem})
        CadastrosToolStripMenuItem.Name = "CadastrosToolStripMenuItem"
        CadastrosToolStripMenuItem.Size = New Size(71, 20)
        CadastrosToolStripMenuItem.Text = "Cadastros"' 
        ' EmailToolStripMenuItem
        ' 
        EmailToolStripMenuItem.Name = "EmailToolStripMenuItem"
        EmailToolStripMenuItem.Size = New Size(99, 22)
        EmailToolStripMenuItem.Text = "&Itens"' 
        ' MbServico
        ' 
        MbServico.Name = "MbServico"
        MbServico.Size = New Size(122, 20)
        MbServico.Text = "Serviços\Perifericos"' 
        ' RelatóriosToolStripMenuItem
        ' 
        RelatóriosToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {RelatórioAgrupadoEquipamentoToolStripMenuItem, RelatToolStripMenuItem, ListagemEquipamentoToolStripMenuItem, ListagemChklistToolStripMenuItem})
        RelatóriosToolStripMenuItem.Name = "RelatóriosToolStripMenuItem"
        RelatóriosToolStripMenuItem.Size = New Size(71, 20)
        RelatóriosToolStripMenuItem.Text = "Relatórios"' 
        ' RelatórioAgrupadoEquipamentoToolStripMenuItem
        ' 
        RelatórioAgrupadoEquipamentoToolStripMenuItem.Name = "RelatórioAgrupadoEquipamentoToolStripMenuItem"
        RelatórioAgrupadoEquipamentoToolStripMenuItem.Size = New Size(265, 22)
        RelatórioAgrupadoEquipamentoToolStripMenuItem.Text = "Check List"' 
        ' RelatToolStripMenuItem
        ' 
        RelatToolStripMenuItem.Name = "RelatToolStripMenuItem"
        RelatToolStripMenuItem.Size = New Size(265, 22)
        RelatToolStripMenuItem.Text = "Listagem manutenção"' 
        ' ListagemEquipamentoToolStripMenuItem
        ' 
        ListagemEquipamentoToolStripMenuItem.Name = "ListagemEquipamentoToolStripMenuItem"
        ListagemEquipamentoToolStripMenuItem.Size = New Size(265, 22)
        ListagemEquipamentoToolStripMenuItem.Text = "Listagem equipamento"' 
        ' ListagemChklistToolStripMenuItem
        ' 
        ListagemChklistToolStripMenuItem.Name = "ListagemChklistToolStripMenuItem"
        ListagemChklistToolStripMenuItem.Size = New Size(265, 22)
        ListagemChklistToolStripMenuItem.Text = "Listagem completa de equipamento"' 
        ' FrmCadMaquinas
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        CancelButton = BtFechar
        ClientSize = New Size(1054, 639)
        Controls.Add(Gbsenha)
        Controls.Add(Panel1)
        Controls.Add(GbPesquisaEquipamento)
        Controls.Add(GbListagem)
        Controls.Add(GbDados)
        Controls.Add(MenuStrip1)
        FormBorderStyle = FormBorderStyle.SizableToolWindow
        MainMenuStrip = MenuStrip1
        Name = "FrmCadMaquinas"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Controle de equipamentos:"
        GbListagem.ResumeLayout(False)
        GbListagem.PerformLayout()
        CType(DG1, ComponentModel.ISupportInitialize).EndInit()
        GbDados.ResumeLayout(False)
        GbDados.PerformLayout()
        GbPesquisaEquipamento.ResumeLayout(False)
        GbPesquisaEquipamento.PerformLayout()
        CType(DgEquipamentos, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Gbsenha.ResumeLayout(False)
        Gbsenha.PerformLayout()
        CType(Pfolhosenha, ComponentModel.ISupportInitialize).EndInit()
        CType(PfOlhovirus, ComponentModel.ISupportInitialize).EndInit()
        CType(PfOlhoMicrosoft, ComponentModel.ISupportInitialize).EndInit()
        CType(Polhosenha, ComponentModel.ISupportInitialize).EndInit()
        CType(POlhoVirus, ComponentModel.ISupportInitialize).EndInit()
        CType(POlhoMicrosoft, ComponentModel.ISupportInitialize).EndInit()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents DtData As DateTimePicker
    Friend WithEvents BtExcluirItem As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents CbRealizado As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents CbItem As ComboBox
    Friend WithEvents BtIncluir As Button
    Friend WithEvents GbListagem As GroupBox
    Friend WithEvents DG1 As DataGridView
    Friend WithEvents Label14 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TDdr As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents TGhz As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents GbDados As GroupBox
    Friend WithEvents Label11 As Label
    Friend WithEvents THd2 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents THd1 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TMemoria As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Tprocessador As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TNome As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tidmaquina As TextBox
    Friend WithEvents TSenha As TextBox
    Friend WithEvents TUsuario As TextBox
    Friend WithEvents BtSalvar As Button
    Friend WithEvents BtNovo As Button
    Friend WithEvents BtCancelar As Button
    Friend WithEvents BtExcluir As Button
    Friend WithEvents BtEditar As Button
    Friend WithEvents BtFechar As Button
    Friend WithEvents BtAtualizar As Button
    Friend WithEvents Label16 As Label
    Friend WithEvents CbAtivo As ComboBox
    Friend WithEvents GbPesquisaEquipamento As GroupBox
    Friend WithEvents Tpesquisa As TextBox
    Friend WithEvents DgEquipamentos As DataGridView
    Friend WithEvents Label15 As Label
    Friend WithEvents TObsItem As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtAtualizarItem As Button
    Friend WithEvents BtCancelarItem As Button
    Friend WithEvents Label17 As Label
    Friend WithEvents TObsEquipamento As TextBox
    Friend WithEvents TWindows As TextBox
    Friend WithEvents Gbsenha As GroupBox
    Friend WithEvents TSenhaAntiVirus As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents TSenhaEmail As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents TEmail As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MbServico As ToolStripMenuItem
    Friend WithEvents RelatóriosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RelatórioAgrupadoEquipamentoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RelatToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListagemEquipamentoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListagemChklistToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CadastrosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LbContaLinhas As Label
    Friend WithEvents EmailToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TSenhaOffice As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Cbemailoffice As ComboBox
    Friend WithEvents CbEmail As ComboBox
    Friend WithEvents CbContaAntiVirus As ComboBox
    Friend WithEvents Polhosenha As PictureBox
    Friend WithEvents POlhoVirus As PictureBox
    Friend WithEvents POlhoMicrosoft As PictureBox
    Friend WithEvents Pfolhosenha As PictureBox
    Friend WithEvents PfOlhovirus As PictureBox
    Friend WithEvents PfOlhoMicrosoft As PictureBox
    Friend WithEvents Label24 As Label
    Friend WithEvents CbModelo As ComboBox
    Friend WithEvents Label26 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents TIdentificacao As TextBox
    Friend WithEvents TNHD As TextBox
    Friend WithEvents Label27 As Label
    Friend WithEvents Lidmodelo As Label
End Class
