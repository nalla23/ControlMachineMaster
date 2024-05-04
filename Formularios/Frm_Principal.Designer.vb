<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Principal
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
        components = New ComponentModel.Container()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Frm_Principal))
        Dim ChartArea1 As DataVisualization.Charting.ChartArea = New DataVisualization.Charting.ChartArea()
        Dim ChartArea2 As DataVisualization.Charting.ChartArea = New DataVisualization.Charting.ChartArea()
        StatusStrip = New StatusStrip()
        ToolStripDropDownButton1 = New ToolStripDropDownButton()
        Tlblogoff = New ToolStripMenuItem()
        ToolStripSeparator1 = New ToolStripSeparator()
        HelpToolStripMenuItem = New ToolStripMenuItem()
        ToolStripSeparator2 = New ToolStripSeparator()
        CadastroDeUsuárioToolStripMenuItem = New ToolStripMenuItem()
        ToolStripSeparator3 = New ToolStripSeparator()
        ExcelToolStripMenuItem = New ToolStripMenuItem()
        PDVToolStripMenuItem = New ToolStripMenuItem()
        StVersaoDb = New ToolStripMenuItem()
        BuscarDadosDoSistemaToolStripMenuItem = New ToolStripMenuItem()
        EmpresaToolStripMenuItem = New ToolStripMenuItem()
        TlbNomeusuario = New ToolStripStatusLabel()
        ToolStripStatusLabel1 = New ToolStripStatusLabel()
        ToolTip = New ToolTip(components)
        PanelLateral = New Panel()
        BtOs = New Button()
        BtConfiguracao = New Button()
        BtRelatorio = New Button()
        BtCadastro = New Button()
        BtMenu = New Button()
        PictureBox1 = New PictureBox()
        PanelTop = New Panel()
        BtMin = New Button()
        Label2 = New Label()
        BtMax = New Button()
        BtNormal = New Button()
        BtFechar = New Button()
        PanelSubTopo = New Panel()
        Label9 = New Label()
        Label8 = New Label()
        PanelCentro = New Panel()
        Chart3 = New DataVisualization.Charting.Chart()
        USUARIO = New Label()
        TableLayoutPanel1 = New TableLayoutPanel()
        Panel3 = New Panel()
        Label7 = New Label()
        LAplicativodesatualizado = New Label()
        Label5 = New Label()
        Panel2 = New Panel()
        Lbequipamentoinativo = New Label()
        Label3 = New Label()
        Panel1 = New Panel()
        LQtdeMaquinas = New Label()
        Label1 = New Label()
        Chart2 = New DataVisualization.Charting.Chart()
        ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        PanelCadastro = New Panel()
        BtCliente = New Button()
        BtEmail = New Button()
        BtServidor = New Button()
        BtEquipamentos = New Button()
        ItauToolStripMenuItem = New ToolStripMenuItem()
        StatusStrip.SuspendLayout()
        PanelLateral.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        PanelTop.SuspendLayout()
        PanelSubTopo.SuspendLayout()
        PanelCentro.SuspendLayout()
        CType(Chart3, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel1.SuspendLayout()
        Panel3.SuspendLayout()
        Panel2.SuspendLayout()
        Panel1.SuspendLayout()
        CType(Chart2, ComponentModel.ISupportInitialize).BeginInit()
        PanelCadastro.SuspendLayout()
        SuspendLayout()
        ' 
        ' StatusStrip
        ' 
        StatusStrip.Items.AddRange(New ToolStripItem() {ToolStripDropDownButton1, TlbNomeusuario, ToolStripStatusLabel1})
        StatusStrip.Location = New Point(242, 752)
        StatusStrip.Name = "StatusStrip"
        StatusStrip.Padding = New Padding(1, 0, 16, 0)
        StatusStrip.Size = New Size(1073, 22)
        StatusStrip.TabIndex = 7
        StatusStrip.Text = "StatusStrip"' 
        ' ToolStripDropDownButton1
        ' 
        ToolStripDropDownButton1.DisplayStyle = ToolStripItemDisplayStyle.Image
        ToolStripDropDownButton1.DropDownItems.AddRange(New ToolStripItem() {Tlblogoff, ToolStripSeparator1, HelpToolStripMenuItem, ToolStripSeparator2, CadastroDeUsuárioToolStripMenuItem, ToolStripSeparator3, ExcelToolStripMenuItem, PDVToolStripMenuItem, StVersaoDb, BuscarDadosDoSistemaToolStripMenuItem, EmpresaToolStripMenuItem, ItauToolStripMenuItem})
        ToolStripDropDownButton1.Image = CType(resources.GetObject("ToolStripDropDownButton1.Image"), Image)
        ToolStripDropDownButton1.ImageTransparentColor = Color.Magenta
        ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        ToolStripDropDownButton1.Size = New Size(29, 20)
        ToolStripDropDownButton1.Text = "ToolStripDropDownButton1"' 
        ' Tlblogoff
        ' 
        Tlblogoff.Image = CType(resources.GetObject("Tlblogoff.Image"), Image)
        Tlblogoff.Name = "Tlblogoff"
        Tlblogoff.Size = New Size(204, 22)
        Tlblogoff.Text = "Logoff"' 
        ' ToolStripSeparator1
        ' 
        ToolStripSeparator1.Name = "ToolStripSeparator1"
        ToolStripSeparator1.Size = New Size(201, 6)
        ' 
        ' HelpToolStripMenuItem
        ' 
        HelpToolStripMenuItem.Image = CType(resources.GetObject("HelpToolStripMenuItem.Image"), Image)
        HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        HelpToolStripMenuItem.Size = New Size(204, 22)
        HelpToolStripMenuItem.Text = "Help"' 
        ' ToolStripSeparator2
        ' 
        ToolStripSeparator2.Name = "ToolStripSeparator2"
        ToolStripSeparator2.Size = New Size(201, 6)
        ' 
        ' CadastroDeUsuárioToolStripMenuItem
        ' 
        CadastroDeUsuárioToolStripMenuItem.Image = CType(resources.GetObject("CadastroDeUsuárioToolStripMenuItem.Image"), Image)
        CadastroDeUsuárioToolStripMenuItem.Name = "CadastroDeUsuárioToolStripMenuItem"
        CadastroDeUsuárioToolStripMenuItem.Size = New Size(204, 22)
        CadastroDeUsuárioToolStripMenuItem.Text = "Cadastro de usuário"' 
        ' ToolStripSeparator3
        ' 
        ToolStripSeparator3.Name = "ToolStripSeparator3"
        ToolStripSeparator3.Size = New Size(201, 6)
        ' 
        ' ExcelToolStripMenuItem
        ' 
        ExcelToolStripMenuItem.Name = "ExcelToolStripMenuItem"
        ExcelToolStripMenuItem.Size = New Size(204, 22)
        ExcelToolStripMenuItem.Text = "Excel"' 
        ' PDVToolStripMenuItem
        ' 
        PDVToolStripMenuItem.Name = "PDVToolStripMenuItem"
        PDVToolStripMenuItem.Size = New Size(204, 22)
        PDVToolStripMenuItem.Text = "PDV"' 
        ' StVersaoDb
        ' 
        StVersaoDb.Name = "StVersaoDb"
        StVersaoDb.Size = New Size(204, 22)
        StVersaoDb.Text = "Versão"' 
        ' BuscarDadosDoSistemaToolStripMenuItem
        ' 
        BuscarDadosDoSistemaToolStripMenuItem.Name = "BuscarDadosDoSistemaToolStripMenuItem"
        BuscarDadosDoSistemaToolStripMenuItem.Size = New Size(204, 22)
        BuscarDadosDoSistemaToolStripMenuItem.Text = "Buscar dados do sistema"' 
        ' EmpresaToolStripMenuItem
        ' 
        EmpresaToolStripMenuItem.Name = "EmpresaToolStripMenuItem"
        EmpresaToolStripMenuItem.Size = New Size(204, 22)
        EmpresaToolStripMenuItem.Text = "Empresa"' 
        ' TlbNomeusuario
        ' 
        TlbNomeusuario.Name = "TlbNomeusuario"
        TlbNomeusuario.Size = New Size(85, 17)
        TlbNomeusuario.Text = "Nome usuário."' 
        ' ToolStripStatusLabel1
        ' 
        ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        ToolStripStatusLabel1.Size = New Size(80, 17)
        ToolStripStatusLabel1.Text = "Versão 1.10.02"' 
        ' PanelLateral
        ' 
        PanelLateral.BackColor = Color.FromArgb(CByte(51), CByte(51), CByte(76))
        PanelLateral.Controls.Add(BtOs)
        PanelLateral.Controls.Add(BtConfiguracao)
        PanelLateral.Controls.Add(BtRelatorio)
        PanelLateral.Controls.Add(BtCadastro)
        PanelLateral.Controls.Add(BtMenu)
        PanelLateral.Controls.Add(PictureBox1)
        PanelLateral.Dock = DockStyle.Left
        PanelLateral.Location = New Point(0, 0)
        PanelLateral.Name = "PanelLateral"
        PanelLateral.Size = New Size(242, 774)
        PanelLateral.TabIndex = 9
        ' 
        ' BtOs
        ' 
        BtOs.Dock = DockStyle.Top
        BtOs.FlatAppearance.BorderSize = 0
        BtOs.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(39), CByte(39), CByte(51))
        BtOs.FlatStyle = FlatStyle.Flat
        BtOs.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        BtOs.ForeColor = SystemColors.Window
        BtOs.Image = CType(resources.GetObject("BtOs.Image"), Image)
        BtOs.ImageAlign = ContentAlignment.MiddleLeft
        BtOs.Location = New Point(0, 348)
        BtOs.Name = "BtOs"
        BtOs.Padding = New Padding(9, 10, 10, 10)
        BtOs.Size = New Size(242, 52)
        BtOs.TabIndex = 5
        BtOs.Text = "Ordem Serviço"
        BtOs.TextAlign = ContentAlignment.MiddleLeft
        BtOs.TextImageRelation = TextImageRelation.ImageBeforeText
        BtOs.UseVisualStyleBackColor = True
        ' 
        ' BtConfiguracao
        ' 
        BtConfiguracao.Dock = DockStyle.Top
        BtConfiguracao.FlatAppearance.BorderSize = 0
        BtConfiguracao.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(39), CByte(39), CByte(51))
        BtConfiguracao.FlatStyle = FlatStyle.Flat
        BtConfiguracao.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        BtConfiguracao.ForeColor = SystemColors.Window
        BtConfiguracao.Image = CType(resources.GetObject("BtConfiguracao.Image"), Image)
        BtConfiguracao.ImageAlign = ContentAlignment.MiddleLeft
        BtConfiguracao.Location = New Point(0, 296)
        BtConfiguracao.Name = "BtConfiguracao"
        BtConfiguracao.Padding = New Padding(9, 10, 10, 10)
        BtConfiguracao.Size = New Size(242, 52)
        BtConfiguracao.TabIndex = 4
        BtConfiguracao.Text = " Configuração"
        BtConfiguracao.TextAlign = ContentAlignment.MiddleLeft
        BtConfiguracao.TextImageRelation = TextImageRelation.ImageBeforeText
        BtConfiguracao.UseVisualStyleBackColor = True
        ' 
        ' BtRelatorio
        ' 
        BtRelatorio.Dock = DockStyle.Top
        BtRelatorio.FlatAppearance.BorderSize = 0
        BtRelatorio.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(39), CByte(39), CByte(51))
        BtRelatorio.FlatStyle = FlatStyle.Flat
        BtRelatorio.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        BtRelatorio.ForeColor = SystemColors.Window
        BtRelatorio.Image = CType(resources.GetObject("BtRelatorio.Image"), Image)
        BtRelatorio.ImageAlign = ContentAlignment.MiddleLeft
        BtRelatorio.Location = New Point(0, 244)
        BtRelatorio.Name = "BtRelatorio"
        BtRelatorio.Padding = New Padding(9, 10, 10, 10)
        BtRelatorio.Size = New Size(242, 52)
        BtRelatorio.TabIndex = 3
        BtRelatorio.Text = " Relatórios"
        BtRelatorio.TextAlign = ContentAlignment.MiddleLeft
        BtRelatorio.TextImageRelation = TextImageRelation.ImageBeforeText
        BtRelatorio.UseVisualStyleBackColor = True
        ' 
        ' BtCadastro
        ' 
        BtCadastro.Dock = DockStyle.Top
        BtCadastro.FlatAppearance.BorderSize = 0
        BtCadastro.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(39), CByte(39), CByte(51))
        BtCadastro.FlatStyle = FlatStyle.Flat
        BtCadastro.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        BtCadastro.ForeColor = SystemColors.Window
        BtCadastro.Image = CType(resources.GetObject("BtCadastro.Image"), Image)
        BtCadastro.ImageAlign = ContentAlignment.MiddleLeft
        BtCadastro.Location = New Point(0, 192)
        BtCadastro.Name = "BtCadastro"
        BtCadastro.Padding = New Padding(9, 10, 10, 10)
        BtCadastro.Size = New Size(242, 52)
        BtCadastro.TabIndex = 2
        BtCadastro.Text = "Cadastro "
        BtCadastro.TextAlign = ContentAlignment.MiddleLeft
        BtCadastro.TextImageRelation = TextImageRelation.ImageBeforeText
        BtCadastro.UseVisualStyleBackColor = True
        ' 
        ' BtMenu
        ' 
        BtMenu.Dock = DockStyle.Top
        BtMenu.FlatAppearance.BorderSize = 0
        BtMenu.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(39), CByte(39), CByte(51))
        BtMenu.FlatStyle = FlatStyle.Flat
        BtMenu.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        BtMenu.ForeColor = SystemColors.Window
        BtMenu.Image = CType(resources.GetObject("BtMenu.Image"), Image)
        BtMenu.ImageAlign = ContentAlignment.MiddleLeft
        BtMenu.Location = New Point(0, 140)
        BtMenu.Name = "BtMenu"
        BtMenu.Padding = New Padding(9, 10, 10, 10)
        BtMenu.Size = New Size(242, 52)
        BtMenu.TabIndex = 1
        BtMenu.Text = " Menu"
        BtMenu.TextAlign = ContentAlignment.MiddleLeft
        BtMenu.TextImageRelation = TextImageRelation.ImageBeforeText
        BtMenu.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.FromArgb(CByte(39), CByte(39), CByte(51))
        PictureBox1.Dock = DockStyle.Top
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(242, 140)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' PanelTop
        ' 
        PanelTop.BackColor = Color.FromArgb(CByte(39), CByte(39), CByte(51))
        PanelTop.Controls.Add(BtMin)
        PanelTop.Controls.Add(Label2)
        PanelTop.Controls.Add(BtMax)
        PanelTop.Controls.Add(BtNormal)
        PanelTop.Controls.Add(BtFechar)
        PanelTop.Dock = DockStyle.Top
        PanelTop.Location = New Point(242, 0)
        PanelTop.Name = "PanelTop"
        PanelTop.Size = New Size(1073, 25)
        PanelTop.TabIndex = 10
        ' 
        ' BtMin
        ' 
        BtMin.Dock = DockStyle.Right
        BtMin.FlatAppearance.CheckedBackColor = Color.Navy
        BtMin.FlatAppearance.MouseOverBackColor = Color.Navy
        BtMin.FlatStyle = FlatStyle.Popup
        BtMin.Image = CType(resources.GetObject("BtMin.Image"), Image)
        BtMin.Location = New Point(969, 0)
        BtMin.Name = "BtMin"
        BtMin.Size = New Size(26, 25)
        BtMin.TabIndex = 2
        BtMin.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Dock = DockStyle.Left
        Label2.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = SystemColors.Window
        Label2.Location = New Point(0, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(131, 21)
        Label2.TabIndex = 0
        Label2.Text = "Control Machine"' 
        ' BtMax
        ' 
        BtMax.Dock = DockStyle.Right
        BtMax.FlatAppearance.CheckedBackColor = Color.Navy
        BtMax.FlatAppearance.MouseOverBackColor = Color.Navy
        BtMax.FlatStyle = FlatStyle.Popup
        BtMax.Image = CType(resources.GetObject("BtMax.Image"), Image)
        BtMax.Location = New Point(995, 0)
        BtMax.Name = "BtMax"
        BtMax.Size = New Size(26, 25)
        BtMax.TabIndex = 4
        BtMax.UseVisualStyleBackColor = True
        ' 
        ' BtNormal
        ' 
        BtNormal.Dock = DockStyle.Right
        BtNormal.FlatAppearance.CheckedBackColor = Color.Navy
        BtNormal.FlatAppearance.MouseOverBackColor = Color.Navy
        BtNormal.FlatStyle = FlatStyle.Popup
        BtNormal.Image = CType(resources.GetObject("BtNormal.Image"), Image)
        BtNormal.Location = New Point(1021, 0)
        BtNormal.Name = "BtNormal"
        BtNormal.Size = New Size(26, 25)
        BtNormal.TabIndex = 1
        BtNormal.UseVisualStyleBackColor = True
        ' 
        ' BtFechar
        ' 
        BtFechar.Dock = DockStyle.Right
        BtFechar.FlatAppearance.CheckedBackColor = Color.Navy
        BtFechar.FlatAppearance.MouseOverBackColor = Color.Navy
        BtFechar.FlatStyle = FlatStyle.Popup
        BtFechar.Image = CType(resources.GetObject("BtFechar.Image"), Image)
        BtFechar.Location = New Point(1047, 0)
        BtFechar.Name = "BtFechar"
        BtFechar.Size = New Size(26, 25)
        BtFechar.TabIndex = 3
        BtFechar.UseVisualStyleBackColor = True
        ' 
        ' PanelSubTopo
        ' 
        PanelSubTopo.BackColor = Color.FromArgb(CByte(51), CByte(51), CByte(76))
        PanelSubTopo.Controls.Add(Label9)
        PanelSubTopo.Controls.Add(Label8)
        PanelSubTopo.Dock = DockStyle.Top
        PanelSubTopo.Location = New Point(242, 25)
        PanelSubTopo.Name = "PanelSubTopo"
        PanelSubTopo.Size = New Size(1073, 59)
        PanelSubTopo.TabIndex = 10
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label9.ForeColor = SystemColors.Window
        Label9.Location = New Point(54, 41)
        Label9.Name = "Label9"
        Label9.Size = New Size(137, 15)
        Label9.TabIndex = 2
        Label9.Text = "Resultados simplificados"' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.ForeColor = SystemColors.Window
        Label8.Location = New Point(6, 20)
        Label8.Name = "Label8"
        Label8.Size = New Size(96, 21)
        Label8.TabIndex = 1
        Label8.Text = "DashBoards"' 
        ' PanelCentro
        ' 
        PanelCentro.Controls.Add(Chart3)
        PanelCentro.Controls.Add(USUARIO)
        PanelCentro.Controls.Add(TableLayoutPanel1)
        PanelCentro.Controls.Add(Chart2)
        PanelCentro.Dock = DockStyle.Fill
        PanelCentro.Location = New Point(242, 159)
        PanelCentro.Name = "PanelCentro"
        PanelCentro.Size = New Size(1073, 593)
        PanelCentro.TabIndex = 10
        ' 
        ' Chart3
        ' 
        ChartArea1.Name = "ChartArea1"
        Chart3.ChartAreas.Add(ChartArea1)
        Chart3.Location = New Point(6, 137)
        Chart3.Name = "Chart3"
        Chart3.Size = New Size(524, 221)
        Chart3.TabIndex = 5
        Chart3.Text = "Chart3"' 
        ' USUARIO
        ' 
        USUARIO.AutoSize = True
        USUARIO.Location = New Point(6, 567)
        USUARIO.Name = "USUARIO"
        USUARIO.Size = New Size(41, 15)
        USUARIO.TabIndex = 1
        USUARIO.Text = "Label4"
        USUARIO.Visible = False
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.BackColor = Color.WhiteSmoke
        TableLayoutPanel1.ColumnCount = 3
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 47.27047F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 52.72953F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 266F))
        TableLayoutPanel1.Controls.Add(Panel3, 2, 0)
        TableLayoutPanel1.Controls.Add(Panel2, 1, 0)
        TableLayoutPanel1.Controls.Add(Panel1, 0, 0)
        TableLayoutPanel1.Dock = DockStyle.Top
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel1.Size = New Size(1073, 131)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.LightSeaGreen
        Panel3.Controls.Add(Label7)
        Panel3.Controls.Add(LAplicativodesatualizado)
        Panel3.Controls.Add(Label5)
        Panel3.Dock = DockStyle.Fill
        Panel3.Location = New Point(809, 3)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(261, 125)
        Panel3.TabIndex = 2
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(-340, 79)
        Label7.Name = "Label7"
        Label7.Size = New Size(42, 15)
        Label7.TabIndex = 1
        Label7.Text = "Label2"' 
        ' LAplicativodesatualizado
        ' 
        LAplicativodesatualizado.AutoSize = True
        LAplicativodesatualizado.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point)
        LAplicativodesatualizado.ForeColor = SystemColors.Window
        LAplicativodesatualizado.Location = New Point(0, 84)
        LAplicativodesatualizado.Name = "LAplicativodesatualizado"
        LAplicativodesatualizado.Size = New Size(27, 32)
        LAplicativodesatualizado.TabIndex = 5
        LAplicativodesatualizado.Text = "0"' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.ForeColor = SystemColors.Window
        Label5.Location = New Point(3, 15)
        Label5.Name = "Label5"
        Label5.Size = New Size(122, 15)
        Label5.TabIndex = 4
        Label5.Text = "Programas pendentes"' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Salmon
        Panel2.Controls.Add(Lbequipamentoinativo)
        Panel2.Controls.Add(Label3)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(384, 3)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(419, 125)
        Panel2.TabIndex = 1
        ' 
        ' Lbequipamentoinativo
        ' 
        Lbequipamentoinativo.AutoSize = True
        Lbequipamentoinativo.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Lbequipamentoinativo.ForeColor = SystemColors.Window
        Lbequipamentoinativo.Location = New Point(3, 84)
        Lbequipamentoinativo.Name = "Lbequipamentoinativo"
        Lbequipamentoinativo.Size = New Size(27, 32)
        Lbequipamentoinativo.TabIndex = 3
        Lbequipamentoinativo.Text = "0"' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.ForeColor = SystemColors.Window
        Label3.Location = New Point(3, 15)
        Label3.Name = "Label3"
        Label3.Size = New Size(127, 15)
        Label3.TabIndex = 2
        Label3.Text = "Equipamentos Inativos"' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.YellowGreen
        Panel1.Controls.Add(LQtdeMaquinas)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(3, 3)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(375, 125)
        Panel1.TabIndex = 0
        ' 
        ' LQtdeMaquinas
        ' 
        LQtdeMaquinas.AutoSize = True
        LQtdeMaquinas.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point)
        LQtdeMaquinas.ForeColor = SystemColors.Window
        LQtdeMaquinas.Location = New Point(3, 79)
        LQtdeMaquinas.Name = "LQtdeMaquinas"
        LQtdeMaquinas.Size = New Size(27, 32)
        LQtdeMaquinas.TabIndex = 1
        LQtdeMaquinas.Text = "0"' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.Window
        Label1.Location = New Point(3, 15)
        Label1.Name = "Label1"
        Label1.Size = New Size(119, 15)
        Label1.TabIndex = 0
        Label1.Text = "Equipamentos Ativos"' 
        ' Chart2
        ' 
        ChartArea2.Name = "ChartArea1"
        Chart2.ChartAreas.Add(ChartArea2)
        Chart2.Location = New Point(546, 134)
        Chart2.Name = "Chart2"
        Chart2.Size = New Size(524, 224)
        Chart2.TabIndex = 4
        Chart2.Text = "Chart2"' 
        ' ReportViewer1
        ' 
        ReportViewer1.Location = New Point(0, 0)
        ReportViewer1.Name = "ReportViewer"
        ReportViewer1.ServerReport.BearerToken = Nothing
        ReportViewer1.Size = New Size(396, 246)
        ReportViewer1.TabIndex = 0
        ' 
        ' PanelCadastro
        ' 
        PanelCadastro.BackColor = Color.FromArgb(CByte(51), CByte(51), CByte(76))
        PanelCadastro.Controls.Add(BtCliente)
        PanelCadastro.Controls.Add(BtEmail)
        PanelCadastro.Controls.Add(BtServidor)
        PanelCadastro.Controls.Add(BtEquipamentos)
        PanelCadastro.Dock = DockStyle.Top
        PanelCadastro.Location = New Point(242, 84)
        PanelCadastro.Name = "PanelCadastro"
        PanelCadastro.Size = New Size(1073, 75)
        PanelCadastro.TabIndex = 12
        PanelCadastro.Visible = False
        ' 
        ' BtCliente
        ' 
        BtCliente.Dock = DockStyle.Left
        BtCliente.FlatAppearance.BorderSize = 0
        BtCliente.FlatStyle = FlatStyle.Popup
        BtCliente.ForeColor = SystemColors.Window
        BtCliente.Image = CType(resources.GetObject("BtCliente.Image"), Image)
        BtCliente.ImageAlign = ContentAlignment.TopCenter
        BtCliente.Location = New Point(336, 0)
        BtCliente.Name = "BtCliente"
        BtCliente.Size = New Size(112, 75)
        BtCliente.TabIndex = 3
        BtCliente.Text = "Cliente"
        BtCliente.TextAlign = ContentAlignment.BottomCenter
        BtCliente.UseVisualStyleBackColor = True
        ' 
        ' BtEmail
        ' 
        BtEmail.Dock = DockStyle.Left
        BtEmail.FlatAppearance.BorderSize = 0
        BtEmail.FlatStyle = FlatStyle.Popup
        BtEmail.ForeColor = SystemColors.Window
        BtEmail.Image = CType(resources.GetObject("BtEmail.Image"), Image)
        BtEmail.ImageAlign = ContentAlignment.TopCenter
        BtEmail.Location = New Point(224, 0)
        BtEmail.Name = "BtEmail"
        BtEmail.Size = New Size(112, 75)
        BtEmail.TabIndex = 2
        BtEmail.Text = "E-mail"
        BtEmail.TextAlign = ContentAlignment.BottomCenter
        BtEmail.UseVisualStyleBackColor = True
        ' 
        ' BtServidor
        ' 
        BtServidor.Dock = DockStyle.Left
        BtServidor.FlatAppearance.BorderSize = 0
        BtServidor.FlatStyle = FlatStyle.Popup
        BtServidor.ForeColor = SystemColors.Window
        BtServidor.Image = CType(resources.GetObject("BtServidor.Image"), Image)
        BtServidor.ImageAlign = ContentAlignment.TopCenter
        BtServidor.Location = New Point(112, 0)
        BtServidor.Name = "BtServidor"
        BtServidor.Size = New Size(112, 75)
        BtServidor.TabIndex = 1
        BtServidor.Text = "Servidor online"
        BtServidor.TextAlign = ContentAlignment.BottomCenter
        BtServidor.UseVisualStyleBackColor = True
        ' 
        ' BtEquipamentos
        ' 
        BtEquipamentos.Dock = DockStyle.Left
        BtEquipamentos.FlatAppearance.BorderSize = 0
        BtEquipamentos.FlatStyle = FlatStyle.Popup
        BtEquipamentos.ForeColor = SystemColors.Window
        BtEquipamentos.Image = CType(resources.GetObject("BtEquipamentos.Image"), Image)
        BtEquipamentos.ImageAlign = ContentAlignment.TopCenter
        BtEquipamentos.Location = New Point(0, 0)
        BtEquipamentos.Name = "BtEquipamentos"
        BtEquipamentos.Size = New Size(112, 75)
        BtEquipamentos.TabIndex = 0
        BtEquipamentos.Text = "Equipamentos"
        BtEquipamentos.TextAlign = ContentAlignment.BottomCenter
        BtEquipamentos.UseVisualStyleBackColor = True
        ' 
        ' ItauToolStripMenuItem
        ' 
        ItauToolStripMenuItem.Name = "ItauToolStripMenuItem"
        ItauToolStripMenuItem.Size = New Size(204, 22)
        ItauToolStripMenuItem.Text = "Itau"' 
        ' Frm_Principal
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImageLayout = ImageLayout.Zoom
        ClientSize = New Size(1315, 774)
        Controls.Add(PanelCentro)
        Controls.Add(StatusStrip)
        Controls.Add(PanelCadastro)
        Controls.Add(PanelSubTopo)
        Controls.Add(PanelTop)
        Controls.Add(PanelLateral)
        FormBorderStyle = FormBorderStyle.None
        IsMdiContainer = True
        Margin = New Padding(4, 3, 4, 3)
        Name = "Frm_Principal"
        Text = "Control Machine"
        WindowState = FormWindowState.Maximized
        StatusStrip.ResumeLayout(False)
        StatusStrip.PerformLayout()
        PanelLateral.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        PanelTop.ResumeLayout(False)
        PanelTop.PerformLayout()
        PanelSubTopo.ResumeLayout(False)
        PanelSubTopo.PerformLayout()
        PanelCentro.ResumeLayout(False)
        PanelCentro.PerformLayout()
        CType(Chart3, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel1.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(Chart2, ComponentModel.ISupportInitialize).EndInit()
        PanelCadastro.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents TlbNomeusuario As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents PanelLateral As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PanelTop As Panel
    Friend WithEvents PanelSubTopo As Panel
    Friend WithEvents PanelCentro As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents LAplicativodesatualizado As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Lbequipamentoinativo As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LQtdeMaquinas As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents BtRelatorio As Button
    Friend WithEvents BtCadastro As Button
    Friend WithEvents BtMenu As Button
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents BtMax As Button
    Friend WithEvents BtFechar As Button
    Friend WithEvents BtMin As Button
    Friend WithEvents BtNormal As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents BtConfiguracao As Button
    Friend WithEvents ToolStripDropDownButton1 As ToolStripDropDownButton
    Friend WithEvents Tlblogoff As ToolStripMenuItem
    Friend WithEvents PanelCadastro As Panel
    Friend WithEvents BtEmail As Button
    Friend WithEvents BtServidor As Button
    Friend WithEvents BtEquipamentos As Button
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents CadastroDeUsuárioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents USUARIO As Label
    Friend WithEvents Chart2 As DataVisualization.Charting.Chart
    Friend WithEvents Chart3 As DataVisualization.Charting.Chart
    Friend WithEvents ExcelToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PDVToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StVersaoDb As ToolStripMenuItem
    Friend WithEvents BuscarDadosDoSistemaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmpresaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BtOs As Button
    Friend WithEvents BtCliente As Button
    Friend WithEvents ItauToolStripMenuItem As ToolStripMenuItem
End Class
