<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Item
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Frm_Item))
        GbPesquisa = New GroupBox()
        LbContaLinhas = New Label()
        BtBuscar = New Button()
        DgItemCad = New DataGridView()
        Tpesquisa = New TextBox()
        GbDados = New GroupBox()
        Label6 = New Label()
        TCodigo = New TextBox()
        CbAtivo = New ComboBox()
        Label5 = New Label()
        CbTipo = New ComboBox()
        TObs = New TextBox()
        Label3 = New Label()
        TSenha = New TextBox()
        Label2 = New Label()
        TNome = New TextBox()
        Label1 = New Label()
        Label4 = New Label()
        PnBotoes = New Panel()
        BtCancelar = New Button()
        BtFechar = New Button()
        BtSalvar = New Button()
        BtAtualizar = New Button()
        BtNovo = New Button()
        BtEditar = New Button()
        BtExcluir = New Button()
        MenuStrip1 = New MenuStrip()
        Envioemail = New ToolStripMenuItem()
        RelatóriosToolStripMenuItem = New ToolStripMenuItem()
        AgrupadoPorEmailToolStripMenuItem = New ToolStripMenuItem()
        ListagemEmailItemToolStripMenuItem = New ToolStripMenuItem()
        Button1 = New Button()
        GbPesquisa.SuspendLayout()
        CType(DgItemCad, ComponentModel.ISupportInitialize).BeginInit()
        GbDados.SuspendLayout()
        PnBotoes.SuspendLayout()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' GbPesquisa
        ' 
        GbPesquisa.Controls.Add(LbContaLinhas)
        GbPesquisa.Controls.Add(BtBuscar)
        GbPesquisa.Controls.Add(DgItemCad)
        GbPesquisa.Controls.Add(Tpesquisa)
        GbPesquisa.Location = New Point(3, 27)
        GbPesquisa.Name = "GbPesquisa"
        GbPesquisa.Size = New Size(387, 387)
        GbPesquisa.TabIndex = 40
        GbPesquisa.TabStop = False
        GbPesquisa.Text = "Quadro de pesquisa"' 
        ' LbContaLinhas
        ' 
        LbContaLinhas.AutoSize = True
        LbContaLinhas.Location = New Point(6, 358)
        LbContaLinhas.Name = "LbContaLinhas"
        LbContaLinhas.Size = New Size(41, 15)
        LbContaLinhas.TabIndex = 43
        LbContaLinhas.Text = "Label6"' 
        ' BtBuscar
        ' 
        BtBuscar.BackColor = Color.FromArgb(CByte(51), CByte(51), CByte(76))
        BtBuscar.FlatStyle = FlatStyle.Flat
        BtBuscar.ForeColor = SystemColors.Window
        BtBuscar.ImageAlign = ContentAlignment.MiddleLeft
        BtBuscar.Location = New Point(301, 24)
        BtBuscar.Name = "BtBuscar"
        BtBuscar.RightToLeft = RightToLeft.No
        BtBuscar.Size = New Size(80, 25)
        BtBuscar.TabIndex = 39
        BtBuscar.Text = "Buscar"
        BtBuscar.UseVisualStyleBackColor = True
        ' 
        ' DgItemCad
        ' 
        DgItemCad.AllowUserToAddRows = False
        DgItemCad.AllowUserToDeleteRows = False
        DgItemCad.AllowUserToResizeRows = False
        DgItemCad.BackgroundColor = Color.FromArgb(CByte(51), CByte(51), CByte(76))
        DgItemCad.BorderStyle = BorderStyle.None
        DgItemCad.CellBorderStyle = DataGridViewCellBorderStyle.None
        DgItemCad.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        DgItemCad.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        DgItemCad.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        DgItemCad.DefaultCellStyle = DataGridViewCellStyle2
        DgItemCad.GridColor = SystemColors.ScrollBar
        DgItemCad.Location = New Point(6, 53)
        DgItemCad.Name = "DgItemCad"
        DgItemCad.ReadOnly = True
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = SystemColors.Control
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        DgItemCad.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        DgItemCad.RowHeadersVisible = False
        DgItemCad.RowTemplate.Height = 25
        DgItemCad.ScrollBars = ScrollBars.Vertical
        DgItemCad.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DgItemCad.Size = New Size(375, 302)
        DgItemCad.TabIndex = 40
        ' 
        ' Tpesquisa
        ' 
        Tpesquisa.CharacterCasing = CharacterCasing.Upper
        Tpesquisa.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Tpesquisa.Location = New Point(6, 24)
        Tpesquisa.Name = "Tpesquisa"
        Tpesquisa.Size = New Size(289, 25)
        Tpesquisa.TabIndex = 42
        ' 
        ' GbDados
        ' 
        GbDados.Controls.Add(Label6)
        GbDados.Controls.Add(TCodigo)
        GbDados.Controls.Add(CbAtivo)
        GbDados.Controls.Add(Label5)
        GbDados.Controls.Add(CbTipo)
        GbDados.Controls.Add(TObs)
        GbDados.Controls.Add(Label3)
        GbDados.Controls.Add(TSenha)
        GbDados.Controls.Add(Label2)
        GbDados.Controls.Add(TNome)
        GbDados.Controls.Add(Label1)
        GbDados.Controls.Add(Label4)
        GbDados.Location = New Point(402, 27)
        GbDados.Name = "GbDados"
        GbDados.Size = New Size(394, 249)
        GbDados.TabIndex = 41
        GbDados.TabStop = False
        GbDados.Text = "Dados Principais:"' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(255, 28)
        Label6.Name = "Label6"
        Label6.Size = New Size(46, 15)
        Label6.TabIndex = 13
        Label6.Text = "Código"' 
        ' TCodigo
        ' 
        TCodigo.Location = New Point(255, 49)
        TCodigo.Name = "TCodigo"
        TCodigo.Size = New Size(128, 23)
        TCodigo.TabIndex = 12
        ' 
        ' CbAtivo
        ' 
        CbAtivo.DropDownStyle = ComboBoxStyle.DropDownList
        CbAtivo.FormattingEnabled = True
        CbAtivo.Items.AddRange(New Object() {"Sim", "Não"})
        CbAtivo.Location = New Point(306, 137)
        CbAtivo.Name = "CbAtivo"
        CbAtivo.Size = New Size(77, 23)
        CbAtivo.TabIndex = 4
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(6, 28)
        Label5.Name = "Label5"
        Label5.Size = New Size(99, 15)
        Label5.TabIndex = 11
        Label5.Text = "Tipo Lançamento"' 
        ' CbTipo
        ' 
        CbTipo.DropDownStyle = ComboBoxStyle.DropDownList
        CbTipo.FormattingEnabled = True
        CbTipo.Items.AddRange(New Object() {"E-mail", "Item", "Modelo"})
        CbTipo.Location = New Point(7, 49)
        CbTipo.Name = "CbTipo"
        CbTipo.Size = New Size(118, 23)
        CbTipo.TabIndex = 1
        ' 
        ' TObs
        ' 
        TObs.Location = New Point(7, 181)
        TObs.MaxLength = 250
        TObs.Multiline = True
        TObs.Name = "TObs"
        TObs.Size = New Size(376, 58)
        TObs.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(7, 163)
        Label3.Name = "Label3"
        Label3.Size = New Size(69, 15)
        Label3.TabIndex = 4
        Label3.Text = "Observação"' 
        ' TSenha
        ' 
        TSenha.Location = New Point(7, 137)
        TSenha.MaxLength = 15
        TSenha.Name = "TSenha"
        TSenha.Size = New Size(293, 23)
        TSenha.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(7, 119)
        Label2.Name = "Label2"
        Label2.Size = New Size(76, 15)
        Label2.TabIndex = 2
        Label2.Text = "Senha e-mail"' 
        ' TNome
        ' 
        TNome.Location = New Point(7, 93)
        TNome.MaxLength = 100
        TNome.Name = "TNome"
        TNome.Size = New Size(376, 23)
        TNome.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(6, 75)
        Label1.Name = "Label1"
        Label1.Size = New Size(70, 15)
        Label1.TabIndex = 0
        Label1.Text = "Item\E-mail"' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(306, 119)
        Label4.Name = "Label4"
        Label4.Size = New Size(35, 15)
        Label4.TabIndex = 7
        Label4.Text = "Ativo"' 
        ' PnBotoes
        ' 
        PnBotoes.BackColor = Color.FromArgb(CByte(51), CByte(51), CByte(76))
        PnBotoes.Controls.Add(BtCancelar)
        PnBotoes.Controls.Add(BtFechar)
        PnBotoes.Controls.Add(BtSalvar)
        PnBotoes.Controls.Add(BtAtualizar)
        PnBotoes.Controls.Add(BtNovo)
        PnBotoes.Controls.Add(BtEditar)
        PnBotoes.Controls.Add(BtExcluir)
        PnBotoes.Dock = DockStyle.Bottom
        PnBotoes.Location = New Point(0, 420)
        PnBotoes.Name = "PnBotoes"
        PnBotoes.Size = New Size(801, 43)
        PnBotoes.TabIndex = 42
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
        BtCancelar.Location = New Point(120, 3)
        BtCancelar.Name = "BtCancelar"
        BtCancelar.Size = New Size(111, 39)
        BtCancelar.TabIndex = 29
        BtCancelar.Text = "Cancelar"
        BtCancelar.TextAlign = ContentAlignment.MiddleLeft
        BtCancelar.TextImageRelation = TextImageRelation.ImageBeforeText
        BtCancelar.UseVisualStyleBackColor = False
        ' 
        ' BtFechar
        ' 
        BtFechar.BackColor = Color.FromArgb(CByte(51), CByte(51), CByte(76))
        BtFechar.FlatAppearance.BorderSize = 0
        BtFechar.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(51), CByte(51), CByte(50))
        BtFechar.FlatStyle = FlatStyle.Flat
        BtFechar.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        BtFechar.ForeColor = SystemColors.Window
        BtFechar.Image = CType(resources.GetObject("BtFechar.Image"), Image)
        BtFechar.ImageAlign = ContentAlignment.MiddleLeft
        BtFechar.Location = New Point(352, 3)
        BtFechar.Name = "BtFechar"
        BtFechar.Size = New Size(111, 39)
        BtFechar.TabIndex = 29
        BtFechar.Text = "Fechar"
        BtFechar.TextAlign = ContentAlignment.MiddleLeft
        BtFechar.TextImageRelation = TextImageRelation.ImageBeforeText
        BtFechar.UseVisualStyleBackColor = False
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
        BtSalvar.Location = New Point(3, 3)
        BtSalvar.Name = "BtSalvar"
        BtSalvar.Size = New Size(111, 39)
        BtSalvar.TabIndex = 26
        BtSalvar.Text = "Salva"
        BtSalvar.TextAlign = ContentAlignment.MiddleLeft
        BtSalvar.TextImageRelation = TextImageRelation.ImageBeforeText
        BtSalvar.UseVisualStyleBackColor = False
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
        BtAtualizar.Location = New Point(3, 3)
        BtAtualizar.Name = "BtAtualizar"
        BtAtualizar.Size = New Size(111, 39)
        BtAtualizar.TabIndex = 30
        BtAtualizar.Text = "Atualizar"
        BtAtualizar.TextAlign = ContentAlignment.MiddleLeft
        BtAtualizar.TextImageRelation = TextImageRelation.ImageBeforeText
        BtAtualizar.UseVisualStyleBackColor = False
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
        BtNovo.Location = New Point(3, 3)
        BtNovo.Name = "BtNovo"
        BtNovo.Size = New Size(111, 39)
        BtNovo.TabIndex = 25
        BtNovo.Text = "Novo"
        BtNovo.TextAlign = ContentAlignment.MiddleLeft
        BtNovo.TextImageRelation = TextImageRelation.ImageBeforeText
        BtNovo.UseVisualStyleBackColor = False
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
        BtEditar.Location = New Point(120, 3)
        BtEditar.Name = "BtEditar"
        BtEditar.Size = New Size(111, 39)
        BtEditar.TabIndex = 27
        BtEditar.Text = "Editar"
        BtEditar.TextAlign = ContentAlignment.MiddleLeft
        BtEditar.TextImageRelation = TextImageRelation.ImageBeforeText
        BtEditar.UseVisualStyleBackColor = False
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
        BtExcluir.Location = New Point(237, 3)
        BtExcluir.Name = "BtExcluir"
        BtExcluir.Size = New Size(111, 39)
        BtExcluir.TabIndex = 28
        BtExcluir.Text = "Excluir"
        BtExcluir.TextAlign = ContentAlignment.MiddleLeft
        BtExcluir.TextImageRelation = TextImageRelation.ImageBeforeText
        BtExcluir.UseVisualStyleBackColor = False
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {Envioemail, RelatóriosToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(801, 24)
        MenuStrip1.TabIndex = 44
        MenuStrip1.Text = "Envio de email"' 
        ' Envioemail
        ' 
        Envioemail.Name = "Envioemail"
        Envioemail.Size = New Size(96, 20)
        Envioemail.Text = "Envio de Email"' 
        ' RelatóriosToolStripMenuItem
        ' 
        RelatóriosToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AgrupadoPorEmailToolStripMenuItem, ListagemEmailItemToolStripMenuItem})
        RelatóriosToolStripMenuItem.Name = "RelatóriosToolStripMenuItem"
        RelatóriosToolStripMenuItem.Size = New Size(71, 20)
        RelatóriosToolStripMenuItem.Text = "Relatórios"' 
        ' AgrupadoPorEmailToolStripMenuItem
        ' 
        AgrupadoPorEmailToolStripMenuItem.Name = "AgrupadoPorEmailToolStripMenuItem"
        AgrupadoPorEmailToolStripMenuItem.Size = New Size(238, 22)
        AgrupadoPorEmailToolStripMenuItem.Text = "Agrupado por email"' 
        ' ListagemEmailItemToolStripMenuItem
        ' 
        ListagemEmailItemToolStripMenuItem.Name = "ListagemEmailItemToolStripMenuItem"
        ListagemEmailItemToolStripMenuItem.Size = New Size(238, 22)
        ListagemEmailItemToolStripMenuItem.Text = "Listagem com filtro Email\Item"' 
        ' Button1
        ' 
        Button1.Location = New Point(479, 319)
        Button1.Name = "Button1"
        Button1.Size = New Size(103, 41)
        Button1.TabIndex = 45
        Button1.Text = "Button1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Frm_Item
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSizeMode = AutoSizeMode.GrowAndShrink
        ClientSize = New Size(801, 463)
        Controls.Add(Button1)
        Controls.Add(GbPesquisa)
        Controls.Add(PnBotoes)
        Controls.Add(GbDados)
        Controls.Add(MenuStrip1)
        FormBorderStyle = FormBorderStyle.SizableToolWindow
        MainMenuStrip = MenuStrip1
        Name = "Frm_Item"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Cadastro de tipo de item"
        GbPesquisa.ResumeLayout(False)
        GbPesquisa.PerformLayout()
        CType(DgItemCad, ComponentModel.ISupportInitialize).EndInit()
        GbDados.ResumeLayout(False)
        GbDados.PerformLayout()
        PnBotoes.ResumeLayout(False)
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents GbPesquisa As GroupBox
    Friend WithEvents BtBuscar As Button
    Friend WithEvents DgItemCad As DataGridView
    Friend WithEvents Tpesquisa As TextBox
    Friend WithEvents GbDados As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents CbAtivo As ComboBox
    Friend WithEvents TObs As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TSenha As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TNome As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents CbTipo As ComboBox
    Friend WithEvents PnBotoes As Panel
    Friend WithEvents BtSalvar As Button
    Friend WithEvents BtAtualizar As Button
    Friend WithEvents BtEditar As Button
    Friend WithEvents BtExcluir As Button
    Friend WithEvents BtNovo As Button
    Friend WithEvents BtCancelar As Button
    Friend WithEvents LbContaLinhas As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TCodigo As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents Envioemail As ToolStripMenuItem
    Friend WithEvents BtFechar As Button
    Friend WithEvents RelatóriosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgrupadoPorEmailToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListagemEmailItemToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Button1 As Button
End Class
