<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Servidores
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Frm_Servidores))
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        PnBotoes = New Panel()
        BtSalvar = New Button()
        BtAtualizar = New Button()
        BtFechar = New Button()
        BtEditar = New Button()
        BtExcluir = New Button()
        BtNovo = New Button()
        BtCancelar = New Button()
        GbPesquisa = New GroupBox()
        DgServidores = New DataGridView()
        LQtdeServidores = New Label()
        BtBuscar = New Button()
        Tpesquisa = New TextBox()
        TSenha = New TextBox()
        Label5 = New Label()
        Label3 = New Label()
        DataGridView1 = New DataGridView()
        CbAtivo = New ComboBox()
        TNome = New TextBox()
        Label1 = New Label()
        Label4 = New Label()
        TextBox1 = New TextBox()
        GbDados = New GroupBox()
        Label8 = New Label()
        TCodigo = New TextBox()
        Tip = New TextBox()
        Label2 = New Label()
        LQtdeUsuarios = New Label()
        TUsuarios = New TextBox()
        DgUsuarios = New DataGridView()
        GbUsuarios = New GroupBox()
        BtCancelarItem = New Button()
        BtAtualizarItem = New Button()
        BtExcluirItem = New Button()
        BtIncluirUsuario = New Button()
        MenuStrip1 = New MenuStrip()
        ImprimirToolStripMenuItem = New ToolStripMenuItem()
        RelatóriosToolStripMenuItem = New ToolStripMenuItem()
        AgrupadoPorServidorToolStripMenuItem = New ToolStripMenuItem()
        ListagemServidorToolStripMenuItem = New ToolStripMenuItem()
        PnBotoes.SuspendLayout()
        GbPesquisa.SuspendLayout()
        CType(DgServidores, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        GbDados.SuspendLayout()
        CType(DgUsuarios, ComponentModel.ISupportInitialize).BeginInit()
        GbUsuarios.SuspendLayout()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' PnBotoes
        ' 
        PnBotoes.BackColor = Color.FromArgb(CByte(51), CByte(51), CByte(76))
        PnBotoes.Controls.Add(BtSalvar)
        PnBotoes.Controls.Add(BtAtualizar)
        PnBotoes.Controls.Add(BtFechar)
        PnBotoes.Controls.Add(BtEditar)
        PnBotoes.Controls.Add(BtExcluir)
        PnBotoes.Controls.Add(BtNovo)
        PnBotoes.Controls.Add(BtCancelar)
        PnBotoes.Dock = DockStyle.Bottom
        PnBotoes.Location = New Point(0, 475)
        PnBotoes.Name = "PnBotoes"
        PnBotoes.Size = New Size(778, 53)
        PnBotoes.TabIndex = 43
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
        BtSalvar.Location = New Point(12, 8)
        BtSalvar.Name = "BtSalvar"
        BtSalvar.Size = New Size(107, 45)
        BtSalvar.TabIndex = 6
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
        BtAtualizar.Location = New Point(12, 8)
        BtAtualizar.Name = "BtAtualizar"
        BtAtualizar.Size = New Size(107, 45)
        BtAtualizar.TabIndex = 30
        BtAtualizar.Text = "Atualizar"
        BtAtualizar.TextAlign = ContentAlignment.MiddleLeft
        BtAtualizar.TextImageRelation = TextImageRelation.ImageBeforeText
        BtAtualizar.UseVisualStyleBackColor = False
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
        BtFechar.Location = New Point(351, 8)
        BtFechar.Name = "BtFechar"
        BtFechar.Size = New Size(107, 45)
        BtFechar.TabIndex = 31
        BtFechar.Text = "Fechar"
        BtFechar.TextAlign = ContentAlignment.MiddleLeft
        BtFechar.TextImageRelation = TextImageRelation.ImageBeforeText
        BtFechar.UseVisualStyleBackColor = False
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
        BtEditar.Location = New Point(125, 8)
        BtEditar.Name = "BtEditar"
        BtEditar.Size = New Size(107, 45)
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
        BtExcluir.Location = New Point(238, 8)
        BtExcluir.Name = "BtExcluir"
        BtExcluir.Size = New Size(107, 45)
        BtExcluir.TabIndex = 28
        BtExcluir.Text = "Excluir"
        BtExcluir.TextAlign = ContentAlignment.MiddleLeft
        BtExcluir.TextImageRelation = TextImageRelation.ImageBeforeText
        BtExcluir.UseVisualStyleBackColor = False
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
        BtNovo.Location = New Point(12, 8)
        BtNovo.Name = "BtNovo"
        BtNovo.Size = New Size(107, 45)
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
        BtCancelar.Location = New Point(125, 8)
        BtCancelar.Name = "BtCancelar"
        BtCancelar.Size = New Size(107, 45)
        BtCancelar.TabIndex = 29
        BtCancelar.Text = "Cancelar"
        BtCancelar.TextAlign = ContentAlignment.MiddleLeft
        BtCancelar.TextImageRelation = TextImageRelation.ImageBeforeText
        BtCancelar.UseVisualStyleBackColor = False
        ' 
        ' GbPesquisa
        ' 
        GbPesquisa.Controls.Add(DgServidores)
        GbPesquisa.Controls.Add(LQtdeServidores)
        GbPesquisa.Controls.Add(BtBuscar)
        GbPesquisa.Controls.Add(Tpesquisa)
        GbPesquisa.Location = New Point(0, 27)
        GbPesquisa.Name = "GbPesquisa"
        GbPesquisa.Size = New Size(364, 442)
        GbPesquisa.TabIndex = 47
        GbPesquisa.TabStop = False
        GbPesquisa.Text = "Quadro de pesquisa"' 
        ' DgServidores
        ' 
        DgServidores.AllowUserToAddRows = False
        DgServidores.AllowUserToDeleteRows = False
        DgServidores.AllowUserToResizeRows = False
        DgServidores.BackgroundColor = Color.FromArgb(CByte(51), CByte(51), CByte(76))
        DgServidores.BorderStyle = BorderStyle.None
        DgServidores.CellBorderStyle = DataGridViewCellBorderStyle.None
        DgServidores.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        DgServidores.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        DgServidores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        DgServidores.DefaultCellStyle = DataGridViewCellStyle2
        DgServidores.GridColor = SystemColors.ScrollBar
        DgServidores.Location = New Point(6, 55)
        DgServidores.Name = "DgServidores"
        DgServidores.ReadOnly = True
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = SystemColors.Control
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        DgServidores.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        DgServidores.RowHeadersVisible = False
        DgServidores.RowTemplate.Height = 25
        DgServidores.ScrollBars = ScrollBars.Vertical
        DgServidores.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DgServidores.Size = New Size(346, 356)
        DgServidores.TabIndex = 58
        ' 
        ' LQtdeServidores
        ' 
        LQtdeServidores.AutoSize = True
        LQtdeServidores.Location = New Point(6, 414)
        LQtdeServidores.Name = "LQtdeServidores"
        LQtdeServidores.Size = New Size(94, 15)
        LQtdeServidores.TabIndex = 57
        LQtdeServidores.Text = "Total de registro."' 
        ' BtBuscar
        ' 
        BtBuscar.BackColor = Color.FromArgb(CByte(51), CByte(51), CByte(76))
        BtBuscar.FlatStyle = FlatStyle.Flat
        BtBuscar.ForeColor = SystemColors.Window
        BtBuscar.ImageAlign = ContentAlignment.MiddleLeft
        BtBuscar.Location = New Point(266, 24)
        BtBuscar.Name = "BtBuscar"
        BtBuscar.RightToLeft = RightToLeft.No
        BtBuscar.Size = New Size(80, 25)
        BtBuscar.TabIndex = 39
        BtBuscar.Text = "Buscar"
        BtBuscar.UseVisualStyleBackColor = True
        ' 
        ' Tpesquisa
        ' 
        Tpesquisa.CharacterCasing = CharacterCasing.Upper
        Tpesquisa.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Tpesquisa.Location = New Point(6, 24)
        Tpesquisa.Name = "Tpesquisa"
        Tpesquisa.Size = New Size(254, 25)
        Tpesquisa.TabIndex = 42
        ' 
        ' TSenha
        ' 
        TSenha.Location = New Point(218, 34)
        TSenha.MaxLength = 30
        TSenha.Name = "TSenha"
        TSenha.Size = New Size(172, 23)
        TSenha.TabIndex = 6
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(5, 16)
        Label5.Name = "Label5"
        Label5.Size = New Size(50, 15)
        Label5.TabIndex = 54
        Label5.Text = "Usuário:"' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(218, 16)
        Label3.Name = "Label3"
        Label3.Size = New Size(42, 15)
        Label3.TabIndex = 56
        Label3.Text = "Senha:"' 
        ' DataGridView1
        ' 
        DataGridView1.Location = New Point(0, 0)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(240, 150)
        DataGridView1.TabIndex = 0
        ' 
        ' CbAtivo
        ' 
        CbAtivo.DropDownStyle = ComboBoxStyle.DropDownList
        CbAtivo.FormattingEnabled = True
        CbAtivo.Items.AddRange(New Object() {"Sim", "Não"})
        CbAtivo.Location = New Point(195, 83)
        CbAtivo.Name = "CbAtivo"
        CbAtivo.Size = New Size(77, 23)
        CbAtivo.TabIndex = 3
        ' 
        ' TNome
        ' 
        TNome.Location = New Point(6, 39)
        TNome.MaxLength = 60
        TNome.Name = "TNome"
        TNome.Size = New Size(385, 23)
        TNome.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(5, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(89, 15)
        Label1.TabIndex = 48
        Label1.Text = "Nome Servidor:"' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(195, 65)
        Label4.Name = "Label4"
        Label4.Size = New Size(38, 15)
        Label4.TabIndex = 53
        Label4.Text = "Ativo:"' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(0, 0)
        TextBox1.MaxLength = 15
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(100, 23)
        TextBox1.TabIndex = 0
        ' 
        ' GbDados
        ' 
        GbDados.Controls.Add(Label8)
        GbDados.Controls.Add(TCodigo)
        GbDados.Controls.Add(Tip)
        GbDados.Controls.Add(Label2)
        GbDados.Controls.Add(Label1)
        GbDados.Controls.Add(Label4)
        GbDados.Controls.Add(CbAtivo)
        GbDados.Controls.Add(TNome)
        GbDados.Location = New Point(370, 27)
        GbDados.Name = "GbDados"
        GbDados.Size = New Size(398, 121)
        GbDados.TabIndex = 59
        GbDados.TabStop = False
        GbDados.Text = "Dados servidores"' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(278, 65)
        Label8.Name = "Label8"
        Label8.Size = New Size(49, 15)
        Label8.TabIndex = 58
        Label8.Text = "Código:"' 
        ' TCodigo
        ' 
        TCodigo.Enabled = False
        TCodigo.Location = New Point(278, 83)
        TCodigo.Name = "TCodigo"
        TCodigo.Size = New Size(114, 23)
        TCodigo.TabIndex = 57
        ' 
        ' Tip
        ' 
        Tip.Location = New Point(7, 83)
        Tip.MaxLength = 30
        Tip.Name = "Tip"
        Tip.Size = New Size(182, 23)
        Tip.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(7, 65)
        Label2.Name = "Label2"
        Label2.Size = New Size(57, 15)
        Label2.TabIndex = 55
        Label2.Text = "Server\IP:"' 
        ' LQtdeUsuarios
        ' 
        LQtdeUsuarios.AutoSize = True
        LQtdeUsuarios.Location = New Point(5, 287)
        LQtdeUsuarios.Name = "LQtdeUsuarios"
        LQtdeUsuarios.Size = New Size(94, 15)
        LQtdeUsuarios.TabIndex = 58
        LQtdeUsuarios.Text = "Total de registro."' 
        ' TUsuarios
        ' 
        TUsuarios.Location = New Point(5, 34)
        TUsuarios.MaxLength = 30
        TUsuarios.Name = "TUsuarios"
        TUsuarios.Size = New Size(207, 23)
        TUsuarios.TabIndex = 5
        ' 
        ' DgUsuarios
        ' 
        DgUsuarios.AllowUserToAddRows = False
        DgUsuarios.AllowUserToDeleteRows = False
        DgUsuarios.AllowUserToResizeRows = False
        DgUsuarios.BackgroundColor = Color.FromArgb(CByte(51), CByte(51), CByte(76))
        DgUsuarios.BorderStyle = BorderStyle.Fixed3D
        DgUsuarios.CellBorderStyle = DataGridViewCellBorderStyle.None
        DgUsuarios.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DgUsuarios.Location = New Point(5, 92)
        DgUsuarios.MultiSelect = False
        DgUsuarios.Name = "DgUsuarios"
        DgUsuarios.RowHeadersVisible = False
        DgUsuarios.RowTemplate.Height = 25
        DgUsuarios.ShowCellErrors = False
        DgUsuarios.ShowCellToolTips = False
        DgUsuarios.ShowEditingIcon = False
        DgUsuarios.ShowRowErrors = False
        DgUsuarios.Size = New Size(385, 192)
        DgUsuarios.TabIndex = 61
        ' 
        ' GbUsuarios
        ' 
        GbUsuarios.Controls.Add(BtCancelarItem)
        GbUsuarios.Controls.Add(BtAtualizarItem)
        GbUsuarios.Controls.Add(BtExcluirItem)
        GbUsuarios.Controls.Add(BtIncluirUsuario)
        GbUsuarios.Controls.Add(TSenha)
        GbUsuarios.Controls.Add(LQtdeUsuarios)
        GbUsuarios.Controls.Add(DgUsuarios)
        GbUsuarios.Controls.Add(Label3)
        GbUsuarios.Controls.Add(TUsuarios)
        GbUsuarios.Controls.Add(Label5)
        GbUsuarios.Location = New Point(370, 154)
        GbUsuarios.Name = "GbUsuarios"
        GbUsuarios.Size = New Size(396, 315)
        GbUsuarios.TabIndex = 62
        GbUsuarios.TabStop = False
        GbUsuarios.Text = "Dados usuários."' 
        ' BtCancelarItem
        ' 
        BtCancelarItem.BackColor = Color.FromArgb(CByte(51), CByte(51), CByte(76))
        BtCancelarItem.FlatStyle = FlatStyle.Flat
        BtCancelarItem.ForeColor = SystemColors.Window
        BtCancelarItem.Image = CType(resources.GetObject("BtCancelarItem.Image"), Image)
        BtCancelarItem.ImageAlign = ContentAlignment.TopLeft
        BtCancelarItem.Location = New Point(234, 63)
        BtCancelarItem.Name = "BtCancelarItem"
        BtCancelarItem.Size = New Size(75, 23)
        BtCancelarItem.TabIndex = 8
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
        BtAtualizarItem.Location = New Point(153, 63)
        BtAtualizarItem.Name = "BtAtualizarItem"
        BtAtualizarItem.Size = New Size(75, 23)
        BtAtualizarItem.TabIndex = 64
        BtAtualizarItem.Text = "Atualizar"
        BtAtualizarItem.TextAlign = ContentAlignment.TopLeft
        BtAtualizarItem.TextImageRelation = TextImageRelation.ImageBeforeText
        BtAtualizarItem.UseVisualStyleBackColor = False
        ' 
        ' BtExcluirItem
        ' 
        BtExcluirItem.BackColor = Color.FromArgb(CByte(51), CByte(51), CByte(76))
        BtExcluirItem.FlatStyle = FlatStyle.Flat
        BtExcluirItem.ForeColor = SystemColors.Window
        BtExcluirItem.Image = CType(resources.GetObject("BtExcluirItem.Image"), Image)
        BtExcluirItem.ImageAlign = ContentAlignment.TopLeft
        BtExcluirItem.Location = New Point(315, 63)
        BtExcluirItem.Name = "BtExcluirItem"
        BtExcluirItem.Size = New Size(75, 23)
        BtExcluirItem.TabIndex = 63
        BtExcluirItem.Text = "Excluir"
        BtExcluirItem.TextAlign = ContentAlignment.TopLeft
        BtExcluirItem.TextImageRelation = TextImageRelation.ImageBeforeText
        BtExcluirItem.UseVisualStyleBackColor = False
        ' 
        ' BtIncluirUsuario
        ' 
        BtIncluirUsuario.BackColor = Color.FromArgb(CByte(51), CByte(51), CByte(76))
        BtIncluirUsuario.FlatStyle = FlatStyle.Flat
        BtIncluirUsuario.ForeColor = SystemColors.Window
        BtIncluirUsuario.Image = CType(resources.GetObject("BtIncluirUsuario.Image"), Image)
        BtIncluirUsuario.ImageAlign = ContentAlignment.TopLeft
        BtIncluirUsuario.Location = New Point(153, 63)
        BtIncluirUsuario.Name = "BtIncluirUsuario"
        BtIncluirUsuario.Size = New Size(75, 23)
        BtIncluirUsuario.TabIndex = 7
        BtIncluirUsuario.Text = "Incluir"
        BtIncluirUsuario.TextAlign = ContentAlignment.TopLeft
        BtIncluirUsuario.TextImageRelation = TextImageRelation.ImageBeforeText
        BtIncluirUsuario.UseVisualStyleBackColor = False
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {ImprimirToolStripMenuItem, RelatóriosToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(778, 24)
        MenuStrip1.TabIndex = 63
        MenuStrip1.Text = "MenuStrip1"' 
        ' ImprimirToolStripMenuItem
        ' 
        ImprimirToolStripMenuItem.Name = "ImprimirToolStripMenuItem"
        ImprimirToolStripMenuItem.Size = New Size(65, 20)
        ImprimirToolStripMenuItem.Text = "Imprimir"' 
        ' RelatóriosToolStripMenuItem
        ' 
        RelatóriosToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AgrupadoPorServidorToolStripMenuItem, ListagemServidorToolStripMenuItem})
        RelatóriosToolStripMenuItem.Name = "RelatóriosToolStripMenuItem"
        RelatóriosToolStripMenuItem.Size = New Size(71, 20)
        RelatóriosToolStripMenuItem.Text = "Relatórios"' 
        ' AgrupadoPorServidorToolStripMenuItem
        ' 
        AgrupadoPorServidorToolStripMenuItem.Name = "AgrupadoPorServidorToolStripMenuItem"
        AgrupadoPorServidorToolStripMenuItem.Size = New Size(194, 22)
        AgrupadoPorServidorToolStripMenuItem.Text = "Agrupado por Servidor"' 
        ' ListagemServidorToolStripMenuItem
        ' 
        ListagemServidorToolStripMenuItem.Name = "ListagemServidorToolStripMenuItem"
        ListagemServidorToolStripMenuItem.Size = New Size(194, 22)
        ListagemServidorToolStripMenuItem.Text = "Listagem Servidor"' 
        ' Frm_Servidores
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        CancelButton = BtFechar
        ClientSize = New Size(778, 528)
        Controls.Add(GbUsuarios)
        Controls.Add(GbDados)
        Controls.Add(GbPesquisa)
        Controls.Add(PnBotoes)
        Controls.Add(MenuStrip1)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        MainMenuStrip = MenuStrip1
        Name = "Frm_Servidores"
        Text = "Cadastro de Servidores"
        PnBotoes.ResumeLayout(False)
        GbPesquisa.ResumeLayout(False)
        GbPesquisa.PerformLayout()
        CType(DgServidores, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        GbDados.ResumeLayout(False)
        GbDados.PerformLayout()
        CType(DgUsuarios, ComponentModel.ISupportInitialize).EndInit()
        GbUsuarios.ResumeLayout(False)
        GbUsuarios.PerformLayout()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PnBotoes As Panel
    Friend WithEvents BtSalvar As Button
    Friend WithEvents BtAtualizar As Button
    Friend WithEvents BtFechar As Button
    Friend WithEvents BtEditar As Button
    Friend WithEvents BtExcluir As Button
    Friend WithEvents BtNovo As Button
    Friend WithEvents BtCancelar As Button
    Friend WithEvents GbPesquisa As GroupBox
    Friend WithEvents BtBuscar As Button
    Friend WithEvents Tpesquisa As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents CbAtivo As ComboBox
    Friend WithEvents TSenha As TextBox
    Friend WithEvents TNome As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TUsuarios As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GbDados As GroupBox
    Friend WithEvents LQtdeServidores As Label
    Friend WithEvents Tip As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents LQtdeUsuarios As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TCodigo As TextBox
    Friend WithEvents DgUsuarios As DataGridView
    Friend WithEvents DgServidores As DataGridView
    Friend WithEvents GbUsuarios As GroupBox
    Friend WithEvents BtCancelarItem As Button
    Friend WithEvents BtAtualizarItem As Button
    Friend WithEvents BtExcluirItem As Button
    Friend WithEvents BtIncluirUsuario As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ImprimirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RelatóriosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgrupadoPorServidorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListagemServidorToolStripMenuItem As ToolStripMenuItem
End Class
