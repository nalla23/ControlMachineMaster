<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Usuario
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Frm_Usuario))
        TabControl1 = New TabControl()
        tbconsulta = New TabPage()
        gbpesq = New GroupBox()
        dgusuario = New DataGridView()
        Bt_Buscar = New Button()
        Label2 = New Label()
        txtpesquisa = New TextBox()
        tbdados = New TabPage()
        tidfuncionario = New TextBox()
        Panel2 = New Panel()
        PictureBox1 = New PictureBox()
        grbox = New GroupBox()
        cbfuncionario = New ComboBox()
        cbativo = New ComboBox()
        Bt_reset = New Button()
        Cbacesso = New ComboBox()
        Label6 = New Label()
        Label5 = New Label()
        Tcodigo = New TextBox()
        Tsenha = New TextBox()
        Tnome = New TextBox()
        Label8 = New Label()
        Label1 = New Label()
        Label7 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        ImageList1 = New ImageList(components)
        PnBotoes = New Panel()
        BtEditar = New Button()
        BtAtualizar = New Button()
        BtFechar = New Button()
        BtExcluir = New Button()
        BtSalvar = New Button()
        BtNovo = New Button()
        BtCancelar = New Button()
        TabControl1.SuspendLayout()
        tbconsulta.SuspendLayout()
        gbpesq.SuspendLayout()
        CType(dgusuario, ComponentModel.ISupportInitialize).BeginInit()
        tbdados.SuspendLayout()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        grbox.SuspendLayout()
        PnBotoes.SuspendLayout()
        SuspendLayout()
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(tbconsulta)
        TabControl1.Controls.Add(tbdados)
        TabControl1.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        TabControl1.ImageList = ImageList1
        TabControl1.Location = New Point(3, 1)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(703, 347)
        TabControl1.TabIndex = 33
        ' 
        ' tbconsulta
        ' 
        tbconsulta.Controls.Add(gbpesq)
        tbconsulta.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        tbconsulta.ImageIndex = 0
        tbconsulta.Location = New Point(4, 26)
        tbconsulta.Name = "tbconsulta"
        tbconsulta.Padding = New Padding(3)
        tbconsulta.Size = New Size(695, 317)
        tbconsulta.TabIndex = 0
        tbconsulta.Text = "Pesquisa"
        tbconsulta.UseVisualStyleBackColor = True
        ' 
        ' gbpesq
        ' 
        gbpesq.Controls.Add(dgusuario)
        gbpesq.Controls.Add(Bt_Buscar)
        gbpesq.Controls.Add(Label2)
        gbpesq.Controls.Add(txtpesquisa)
        gbpesq.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        gbpesq.Location = New Point(6, 6)
        gbpesq.Name = "gbpesq"
        gbpesq.Size = New Size(682, 305)
        gbpesq.TabIndex = 31
        gbpesq.TabStop = False
        gbpesq.Text = "Consulta:"' 
        ' dgusuario
        ' 
        dgusuario.AllowUserToAddRows = False
        dgusuario.AllowUserToDeleteRows = False
        dgusuario.AllowUserToResizeRows = False
        dgusuario.BackgroundColor = Color.WhiteSmoke
        dgusuario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgusuario.Location = New Point(6, 51)
        dgusuario.MultiSelect = False
        dgusuario.Name = "dgusuario"
        dgusuario.ReadOnly = True
        dgusuario.RowHeadersVisible = False
        dgusuario.RowTemplate.Height = 25
        dgusuario.ShowCellErrors = False
        dgusuario.ShowCellToolTips = False
        dgusuario.ShowEditingIcon = False
        dgusuario.ShowRowErrors = False
        dgusuario.Size = New Size(668, 248)
        dgusuario.TabIndex = 28
        ' 
        ' Bt_Buscar
        ' 
        Bt_Buscar.BackColor = SystemColors.ControlLight
        Bt_Buscar.BackgroundImageLayout = ImageLayout.None
        Bt_Buscar.FlatStyle = FlatStyle.Popup
        Bt_Buscar.Image = CType(resources.GetObject("Bt_Buscar.Image"), Image)
        Bt_Buscar.Location = New Point(595, 20)
        Bt_Buscar.Name = "Bt_Buscar"
        Bt_Buscar.Size = New Size(72, 25)
        Bt_Buscar.TabIndex = 2
        Bt_Buscar.TextImageRelation = TextImageRelation.ImageBeforeText
        Bt_Buscar.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(5, 23)
        Label2.Name = "Label2"
        Label2.Size = New Size(133, 17)
        Label2.TabIndex = 23
        Label2.Text = "Digite o que procura:"' 
        ' txtpesquisa
        ' 
        txtpesquisa.CharacterCasing = CharacterCasing.Upper
        txtpesquisa.Location = New Point(144, 20)
        txtpesquisa.MaxLength = 60
        txtpesquisa.Name = "txtpesquisa"
        txtpesquisa.Size = New Size(446, 25)
        txtpesquisa.TabIndex = 1
        ' 
        ' tbdados
        ' 
        tbdados.Controls.Add(tidfuncionario)
        tbdados.Controls.Add(Panel2)
        tbdados.Controls.Add(grbox)
        tbdados.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        tbdados.ImageIndex = 1
        tbdados.Location = New Point(4, 26)
        tbdados.Name = "tbdados"
        tbdados.Padding = New Padding(3)
        tbdados.Size = New Size(695, 317)
        tbdados.TabIndex = 1
        tbdados.Text = "Dados principais"
        tbdados.UseVisualStyleBackColor = True
        ' 
        ' tidfuncionario
        ' 
        tidfuncionario.CharacterCasing = CharacterCasing.Upper
        tidfuncionario.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        tidfuncionario.Location = New Point(530, 187)
        tidfuncionario.Name = "tidfuncionario"
        tidfuncionario.Size = New Size(157, 25)
        tidfuncionario.TabIndex = 30
        tidfuncionario.Visible = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(51), CByte(51), CByte(76))
        Panel2.Controls.Add(PictureBox1)
        Panel2.Location = New Point(6, 3)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(689, 41)
        Panel2.TabIndex = 3
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Dock = DockStyle.Left
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(100, 41)
        PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' grbox
        ' 
        grbox.Controls.Add(cbfuncionario)
        grbox.Controls.Add(cbativo)
        grbox.Controls.Add(Bt_reset)
        grbox.Controls.Add(Cbacesso)
        grbox.Controls.Add(Label6)
        grbox.Controls.Add(Label5)
        grbox.Controls.Add(Tcodigo)
        grbox.Controls.Add(Tsenha)
        grbox.Controls.Add(Tnome)
        grbox.Controls.Add(Label8)
        grbox.Controls.Add(Label1)
        grbox.Controls.Add(Label7)
        grbox.Controls.Add(Label4)
        grbox.Controls.Add(Label3)
        grbox.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        grbox.Location = New Point(3, 50)
        grbox.Name = "grbox"
        grbox.Size = New Size(690, 131)
        grbox.TabIndex = 0
        grbox.TabStop = False
        grbox.Text = "Dados Principais"' 
        ' cbfuncionario
        ' 
        cbfuncionario.AutoCompleteMode = AutoCompleteMode.Suggest
        cbfuncionario.AutoCompleteSource = AutoCompleteSource.ListItems
        cbfuncionario.BackColor = SystemColors.Window
        cbfuncionario.DropDownStyle = ComboBoxStyle.DropDownList
        cbfuncionario.FlatStyle = FlatStyle.System
        cbfuncionario.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        cbfuncionario.FormattingEnabled = True
        cbfuncionario.Location = New Point(108, 56)
        cbfuncionario.Name = "cbfuncionario"
        cbfuncionario.Size = New Size(264, 29)
        cbfuncionario.TabIndex = 4
        ' 
        ' cbativo
        ' 
        cbativo.DisplayMember = "SIM"
        cbativo.DropDownStyle = ComboBoxStyle.DropDownList
        cbativo.ImeMode = ImeMode.NoControl
        cbativo.ItemHeight = 20
        cbativo.Items.AddRange(New Object() {"SIM", "NÃO"})
        cbativo.Location = New Point(527, 89)
        cbativo.MaxDropDownItems = 2
        cbativo.MaxLength = 3
        cbativo.Name = "cbativo"
        cbativo.Size = New Size(157, 28)
        cbativo.TabIndex = 7
        cbativo.ValueMember = "SIM"' 
        ' Bt_reset
        ' 
        Bt_reset.AccessibleDescription = "resdadada"
        Bt_reset.FlatAppearance.BorderSize = 0
        Bt_reset.FlatStyle = FlatStyle.Flat
        Bt_reset.Image = CType(resources.GetObject("Bt_reset.Image"), Image)
        Bt_reset.Location = New Point(435, 89)
        Bt_reset.Name = "Bt_reset"
        Bt_reset.RightToLeft = RightToLeft.Yes
        Bt_reset.Size = New Size(27, 28)
        Bt_reset.TabIndex = 29
        Bt_reset.Tag = ""
        Bt_reset.UseVisualStyleBackColor = True
        ' 
        ' Cbacesso
        ' 
        Cbacesso.DropDownStyle = ComboBoxStyle.DropDownList
        Cbacesso.FormattingEnabled = True
        Cbacesso.Items.AddRange(New Object() {"1-ADMINISTRADOR", "2-VENDAS"})
        Cbacesso.Location = New Point(492, 56)
        Cbacesso.MaxLength = 30
        Cbacesso.Name = "Cbacesso"
        Cbacesso.Size = New Size(192, 28)
        Cbacesso.TabIndex = 5
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(6, 100)
        Label6.Name = "Label6"
        Label6.Size = New Size(46, 17)
        Label6.TabIndex = 19
        Label6.Text = "Senha:"' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(336, 100)
        Label5.Name = "Label5"
        Label5.Size = New Size(88, 17)
        Label5.TabIndex = 18
        Label5.Text = "Alterar senha:"' 
        ' Tcodigo
        ' 
        Tcodigo.CharacterCasing = CharacterCasing.Upper
        Tcodigo.Location = New Point(527, 23)
        Tcodigo.Name = "Tcodigo"
        Tcodigo.Size = New Size(157, 27)
        Tcodigo.TabIndex = 16
        ' 
        ' Tsenha
        ' 
        Tsenha.Location = New Point(108, 90)
        Tsenha.MaxLength = 30
        Tsenha.Name = "Tsenha"
        Tsenha.PasswordChar = "#"c
        Tsenha.Size = New Size(222, 27)
        Tsenha.TabIndex = 6
        ' 
        ' Tnome
        ' 
        Tnome.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        Tnome.AutoCompleteSource = AutoCompleteSource.CustomSource
        Tnome.CharacterCasing = CharacterCasing.Upper
        Tnome.ForeColor = SystemColors.WindowText
        Tnome.Location = New Point(108, 23)
        Tnome.MaxLength = 30
        Tnome.Name = "Tnome"
        Tnome.Size = New Size(343, 27)
        Tnome.TabIndex = 3
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.Location = New Point(467, 33)
        Label8.Name = "Label8"
        Label8.Size = New Size(54, 17)
        Label8.TabIndex = 12
        Label8.Text = "Código:"' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(481, 100)
        Label1.Name = "Label1"
        Label1.Size = New Size(40, 17)
        Label1.TabIndex = 12
        Label1.Text = "Ativo:"' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.Location = New Point(375, 67)
        Label7.Name = "Label7"
        Label7.Size = New Size(111, 17)
        Label7.TabIndex = 12
        Label7.Text = "Classe de acesso:"' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(8, 67)
        Label4.Name = "Label4"
        Label4.Size = New Size(78, 17)
        Label4.TabIndex = 13
        Label4.Text = "Funcionário:"' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(8, 32)
        Label3.Name = "Label3"
        Label3.Size = New Size(94, 17)
        Label3.TabIndex = 11
        Label3.Text = "Nome usuário:"' 
        ' ImageList1
        ' 
        ImageList1.ColorDepth = ColorDepth.Depth8Bit
        ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), ImageListStreamer)
        ImageList1.TransparentColor = Color.Transparent
        ImageList1.Images.SetKeyName(0, "Consulta")
        ImageList1.Images.SetKeyName(1, "Dados")
        ' 
        ' PnBotoes
        ' 
        PnBotoes.BackColor = Color.FromArgb(CByte(51), CByte(51), CByte(76))
        PnBotoes.Controls.Add(BtEditar)
        PnBotoes.Controls.Add(BtAtualizar)
        PnBotoes.Controls.Add(BtFechar)
        PnBotoes.Controls.Add(BtExcluir)
        PnBotoes.Controls.Add(BtSalvar)
        PnBotoes.Controls.Add(BtNovo)
        PnBotoes.Controls.Add(BtCancelar)
        PnBotoes.Dock = DockStyle.Bottom
        PnBotoes.Location = New Point(0, 363)
        PnBotoes.Name = "PnBotoes"
        PnBotoes.Size = New Size(709, 50)
        PnBotoes.TabIndex = 43
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
        BtEditar.Location = New Point(120, 2)
        BtEditar.Name = "BtEditar"
        BtEditar.Size = New Size(111, 50)
        BtEditar.TabIndex = 27
        BtEditar.Text = "Editar"
        BtEditar.TextAlign = ContentAlignment.MiddleLeft
        BtEditar.TextImageRelation = TextImageRelation.ImageBeforeText
        BtEditar.UseVisualStyleBackColor = False
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
        BtAtualizar.Location = New Point(3, 2)
        BtAtualizar.Name = "BtAtualizar"
        BtAtualizar.Size = New Size(111, 50)
        BtAtualizar.TabIndex = 30
        BtAtualizar.Text = "Atualizar"
        BtAtualizar.TextAlign = ContentAlignment.MiddleLeft
        BtAtualizar.TextImageRelation = TextImageRelation.ImageBeforeText
        BtAtualizar.UseVisualStyleBackColor = False
        ' 
        ' BtFechar
        ' 
        BtFechar.BackColor = Color.FromArgb(CByte(51), CByte(51), CByte(76))
        BtFechar.FlatAppearance.BorderColor = Color.FromArgb(CByte(51), CByte(51), CByte(76))
        BtFechar.FlatAppearance.BorderSize = 0
        BtFechar.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(51), CByte(51), CByte(76))
        BtFechar.FlatStyle = FlatStyle.Flat
        BtFechar.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        BtFechar.ForeColor = SystemColors.Window
        BtFechar.Image = CType(resources.GetObject("BtFechar.Image"), Image)
        BtFechar.ImageAlign = ContentAlignment.MiddleLeft
        BtFechar.Location = New Point(351, 2)
        BtFechar.Name = "BtFechar"
        BtFechar.Size = New Size(111, 50)
        BtFechar.TabIndex = 31
        BtFechar.Text = "Fechar"
        BtFechar.TextAlign = ContentAlignment.MiddleLeft
        BtFechar.TextImageRelation = TextImageRelation.ImageBeforeText
        BtFechar.UseVisualStyleBackColor = True
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
        BtExcluir.Location = New Point(238, 2)
        BtExcluir.Name = "BtExcluir"
        BtExcluir.Size = New Size(111, 50)
        BtExcluir.TabIndex = 28
        BtExcluir.Text = "Excluir"
        BtExcluir.TextAlign = ContentAlignment.MiddleLeft
        BtExcluir.TextImageRelation = TextImageRelation.ImageBeforeText
        BtExcluir.UseVisualStyleBackColor = False
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
        BtSalvar.Location = New Point(3, 2)
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
        BtNovo.Location = New Point(3, 2)
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
        BtCancelar.Location = New Point(120, 2)
        BtCancelar.Name = "BtCancelar"
        BtCancelar.Size = New Size(111, 50)
        BtCancelar.TabIndex = 29
        BtCancelar.Text = "Cancelar"
        BtCancelar.TextAlign = ContentAlignment.MiddleLeft
        BtCancelar.TextImageRelation = TextImageRelation.ImageBeforeText
        BtCancelar.UseVisualStyleBackColor = False
        ' 
        ' Frm_Usuario
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        CancelButton = BtFechar
        ClientSize = New Size(709, 413)
        Controls.Add(PnBotoes)
        Controls.Add(TabControl1)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "Frm_Usuario"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Cadastro de usuário"
        TabControl1.ResumeLayout(False)
        tbconsulta.ResumeLayout(False)
        gbpesq.ResumeLayout(False)
        gbpesq.PerformLayout()
        CType(dgusuario, ComponentModel.ISupportInitialize).EndInit()
        tbdados.ResumeLayout(False)
        tbdados.PerformLayout()
        Panel2.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        grbox.ResumeLayout(False)
        grbox.PerformLayout()
        PnBotoes.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tbconsulta As TabPage
    Friend WithEvents gbpesq As GroupBox
    Friend WithEvents dgusuario As DataGridView
    Friend WithEvents Bt_Buscar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtpesquisa As TextBox
    Friend WithEvents tbdados As TabPage
    Friend WithEvents tidfuncionario As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents grbox As GroupBox
    Friend WithEvents cbfuncionario As ComboBox
    Friend WithEvents cbativo As ComboBox
    Friend WithEvents Bt_reset As Button
    Friend WithEvents Cbacesso As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Tcodigo As TextBox
    Friend WithEvents Tsenha As TextBox
    Friend WithEvents Tnome As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PnBotoes As Panel
    Friend WithEvents BtSalvar As Button
    Friend WithEvents BtAtualizar As Button
    Friend WithEvents BtFechar As Button
    Friend WithEvents BtEditar As Button
    Friend WithEvents BtExcluir As Button
    Friend WithEvents BtNovo As Button
    Friend WithEvents BtCancelar As Button
    Friend WithEvents ImageList1 As ImageList
End Class
