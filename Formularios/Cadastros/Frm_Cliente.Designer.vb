<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Cliente
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Frm_Cliente))
        Panel1 = New Panel()
        BtSalvar = New Button()
        BtAtualizar = New Button()
        BtFechar = New Button()
        BtEditar = New Button()
        BtExcluir = New Button()
        BtNovo = New Button()
        BtCancelar = New Button()
        GroupBox1 = New GroupBox()
        Label19 = New Label()
        Bbuscacnpj = New Button()
        Label18 = New Label()
        CbAtivo = New ComboBox()
        Label17 = New Label()
        TCodigo = New TextBox()
        Label16 = New Label()
        TEmail = New TextBox()
        Label15 = New Label()
        DtCad = New DateTimePicker()
        TCel = New MaskedTextBox()
        TFone = New MaskedTextBox()
        TCep = New MaskedTextBox()
        Tdoc = New MaskedTextBox()
        Label14 = New Label()
        TObs = New TextBox()
        Label13 = New Label()
        CbCidade = New ComboBox()
        Label12 = New Label()
        CbTipo = New ComboBox()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        TUF = New TextBox()
        TBairro = New TextBox()
        Tnumero = New TextBox()
        Label6 = New Label()
        TEnde = New TextBox()
        Label5 = New Label()
        Label4 = New Label()
        TApelido = New TextBox()
        TNome = New TextBox()
        Label2 = New Label()
        TReg = New TextBox()
        Label1 = New Label()
        Label3 = New Label()
        TComp = New TextBox()
        Button1 = New Button()
        Panel1.SuspendLayout()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(51), CByte(51), CByte(76))
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(BtSalvar)
        Panel1.Controls.Add(BtAtualizar)
        Panel1.Controls.Add(BtFechar)
        Panel1.Controls.Add(BtEditar)
        Panel1.Controls.Add(BtExcluir)
        Panel1.Controls.Add(BtNovo)
        Panel1.Controls.Add(BtCancelar)
        Panel1.Dock = DockStyle.Bottom
        Panel1.Location = New Point(0, 309)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(659, 50)
        Panel1.TabIndex = 43
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
        BtSalvar.TabIndex = 20
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
        BtAtualizar.Location = New Point(12, 0)
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
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label19)
        GroupBox1.Controls.Add(Bbuscacnpj)
        GroupBox1.Controls.Add(Label18)
        GroupBox1.Controls.Add(CbAtivo)
        GroupBox1.Controls.Add(Label17)
        GroupBox1.Controls.Add(TCodigo)
        GroupBox1.Controls.Add(Label16)
        GroupBox1.Controls.Add(TEmail)
        GroupBox1.Controls.Add(Label15)
        GroupBox1.Controls.Add(DtCad)
        GroupBox1.Controls.Add(TCel)
        GroupBox1.Controls.Add(TFone)
        GroupBox1.Controls.Add(TCep)
        GroupBox1.Controls.Add(Tdoc)
        GroupBox1.Controls.Add(Label14)
        GroupBox1.Controls.Add(TObs)
        GroupBox1.Controls.Add(Label13)
        GroupBox1.Controls.Add(CbCidade)
        GroupBox1.Controls.Add(Label12)
        GroupBox1.Controls.Add(CbTipo)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(Label8)
        GroupBox1.Controls.Add(Label9)
        GroupBox1.Controls.Add(Label10)
        GroupBox1.Controls.Add(Label11)
        GroupBox1.Controls.Add(TUF)
        GroupBox1.Controls.Add(TBairro)
        GroupBox1.Controls.Add(Tnumero)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(TEnde)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(TApelido)
        GroupBox1.Controls.Add(TNome)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(TReg)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(TComp)
        GroupBox1.Location = New Point(6, 9)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(648, 294)
        GroupBox1.TabIndex = 42
        GroupBox1.TabStop = False
        GroupBox1.Text = "Dados principais:"' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Location = New Point(335, 266)
        Label19.Name = "Label19"
        Label19.Size = New Size(87, 15)
        Label19.TabIndex = 47
        Label19.Text = "Complemento:"' 
        ' Bbuscacnpj
        ' 
        Bbuscacnpj.Image = CType(resources.GetObject("Bbuscacnpj.Image"), Image)
        Bbuscacnpj.ImageAlign = ContentAlignment.TopCenter
        Bbuscacnpj.Location = New Point(398, 25)
        Bbuscacnpj.Name = "Bbuscacnpj"
        Bbuscacnpj.Size = New Size(31, 27)
        Bbuscacnpj.TabIndex = 45
        Bbuscacnpj.UseVisualStyleBackColor = True
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Location = New Point(226, 232)
        Label18.Name = "Label18"
        Label18.Size = New Size(46, 15)
        Label18.TabIndex = 44
        Label18.Text = "Inativo:"' 
        ' CbAtivo
        ' 
        CbAtivo.DropDownStyle = ComboBoxStyle.DropDownList
        CbAtivo.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        CbAtivo.FormattingEnabled = True
        CbAtivo.Items.AddRange(New Object() {"Sim", "Não"})
        CbAtivo.Location = New Point(278, 225)
        CbAtivo.Name = "CbAtivo"
        CbAtivo.Size = New Size(117, 28)
        CbAtivo.TabIndex = 16
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Location = New Point(8, 232)
        Label17.Name = "Label17"
        Label17.Size = New Size(49, 15)
        Label17.TabIndex = 42
        Label17.Text = "Código:"' 
        ' TCodigo
        ' 
        TCodigo.CharacterCasing = CharacterCasing.Upper
        TCodigo.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        TCodigo.Location = New Point(83, 225)
        TCodigo.Name = "TCodigo"
        TCodigo.Size = New Size(137, 27)
        TCodigo.TabIndex = 15
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Location = New Point(351, 195)
        Label16.Name = "Label16"
        Label16.Size = New Size(44, 15)
        Label16.TabIndex = 36
        Label16.Text = "E-mail:"' 
        ' TEmail
        ' 
        TEmail.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        TEmail.Location = New Point(410, 192)
        TEmail.MaxLength = 60
        TEmail.Name = "TEmail"
        TEmail.Size = New Size(228, 27)
        TEmail.TabIndex = 14
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Location = New Point(401, 232)
        Label15.Name = "Label15"
        Label15.Size = New Size(84, 15)
        Label15.TabIndex = 34
        Label15.Text = "Data Cadastro:"' 
        ' DtCad
        ' 
        DtCad.Enabled = False
        DtCad.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        DtCad.Format = DateTimePickerFormat.Short
        DtCad.Location = New Point(491, 225)
        DtCad.MinDate = New DateTime(1990, 1, 1, 0, 0, 0, 0)
        DtCad.Name = "DtCad"
        DtCad.Size = New Size(147, 27)
        DtCad.TabIndex = 17
        ' 
        ' TCel
        ' 
        TCel.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        TCel.Location = New Point(237, 192)
        TCel.Mask = "(##)#####-####"
        TCel.Name = "TCel"
        TCel.Size = New Size(108, 27)
        TCel.TabIndex = 13
        ' 
        ' TFone
        ' 
        TFone.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        TFone.Location = New Point(83, 192)
        TFone.Mask = "(##)####-####"
        TFone.Name = "TFone"
        TFone.Size = New Size(108, 27)
        TFone.TabIndex = 12
        ' 
        ' TCep
        ' 
        TCep.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        TCep.Location = New Point(83, 125)
        TCep.Mask = "##.###-###"
        TCep.Name = "TCep"
        TCep.Size = New Size(87, 27)
        TCep.TabIndex = 6
        ' 
        ' Tdoc
        ' 
        Tdoc.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Tdoc.Location = New Point(196, 25)
        Tdoc.Name = "Tdoc"
        Tdoc.Size = New Size(199, 27)
        Tdoc.TabIndex = 2
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Location = New Point(8, 266)
        Label14.Name = "Label14"
        Label14.Size = New Size(72, 15)
        Label14.TabIndex = 27
        Label14.Text = "Observação:"' 
        ' TObs
        ' 
        TObs.CharacterCasing = CharacterCasing.Upper
        TObs.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        TObs.Location = New Point(83, 259)
        TObs.MaxLength = 250
        TObs.Name = "TObs"
        TObs.Size = New Size(245, 27)
        TObs.TabIndex = 18
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(249, 164)
        Label13.Name = "Label13"
        Label13.Size = New Size(47, 15)
        Label13.TabIndex = 25
        Label13.Text = "Cidade:"' 
        ' CbCidade
        ' 
        CbCidade.DropDownStyle = ComboBoxStyle.DropDownList
        CbCidade.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        CbCidade.FormattingEnabled = True
        CbCidade.Location = New Point(302, 157)
        CbCidade.Name = "CbCidade"
        CbCidade.Size = New Size(240, 28)
        CbCidade.TabIndex = 10
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(6, 32)
        Label12.Name = "Label12"
        Label12.Size = New Size(33, 15)
        Label12.TabIndex = 23
        Label12.Text = "Tipo:"' 
        ' CbTipo
        ' 
        CbTipo.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        CbTipo.AutoCompleteSource = AutoCompleteSource.ListItems
        CbTipo.DropDownStyle = ComboBoxStyle.DropDownList
        CbTipo.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        CbTipo.FormattingEnabled = True
        CbTipo.ItemHeight = 20
        CbTipo.Items.AddRange(New Object() {"1-CPF", "2-CNPJ"})
        CbTipo.Location = New Point(83, 25)
        CbTipo.MaxDropDownItems = 10
        CbTipo.Name = "CbTipo"
        CbTipo.Size = New Size(71, 28)
        CbTipo.TabIndex = 1
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(190, 195)
        Label7.Name = "Label7"
        Label7.Size = New Size(47, 15)
        Label7.TabIndex = 21
        Label7.Text = "Celular:"' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(6, 199)
        Label8.Name = "Label8"
        Label8.Size = New Size(54, 15)
        Label8.TabIndex = 20
        Label8.Text = "Telefone:"' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(548, 165)
        Label9.Name = "Label9"
        Label9.Size = New Size(24, 15)
        Label9.TabIndex = 19
        Label9.Text = "UF:"' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(6, 165)
        Label10.Name = "Label10"
        Label10.Size = New Size(41, 15)
        Label10.TabIndex = 18
        Label10.Text = "Bairro:"' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(506, 132)
        Label11.Name = "Label11"
        Label11.Size = New Size(54, 15)
        Label11.TabIndex = 17
        Label11.Text = "Número:"' 
        ' TUF
        ' 
        TUF.CharacterCasing = CharacterCasing.Upper
        TUF.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        TUF.Location = New Point(578, 158)
        TUF.MaxLength = 2
        TUF.Name = "TUF"
        TUF.Size = New Size(60, 27)
        TUF.TabIndex = 11
        ' 
        ' TBairro
        ' 
        TBairro.CharacterCasing = CharacterCasing.Upper
        TBairro.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        TBairro.Location = New Point(83, 158)
        TBairro.MaxLength = 60
        TBairro.Name = "TBairro"
        TBairro.Size = New Size(160, 27)
        TBairro.TabIndex = 9
        ' 
        ' Tnumero
        ' 
        Tnumero.CharacterCasing = CharacterCasing.Upper
        Tnumero.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Tnumero.Location = New Point(566, 125)
        Tnumero.MaxLength = 30
        Tnumero.Name = "Tnumero"
        Tnumero.Size = New Size(72, 27)
        Tnumero.TabIndex = 8
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(176, 132)
        Label6.Name = "Label6"
        Label6.Size = New Size(59, 15)
        Label6.TabIndex = 10
        Label6.Text = "Endereço:"' 
        ' TEnde
        ' 
        TEnde.CharacterCasing = CharacterCasing.Upper
        TEnde.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        TEnde.Location = New Point(237, 125)
        TEnde.MaxLength = 30
        TEnde.Name = "TEnde"
        TEnde.Size = New Size(263, 27)
        TEnde.TabIndex = 7
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(8, 132)
        Label5.Name = "Label5"
        Label5.Size = New Size(31, 15)
        Label5.TabIndex = 8
        Label5.Text = "CEP:"' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(6, 99)
        Label4.Name = "Label4"
        Label4.Size = New Size(51, 15)
        Label4.TabIndex = 6
        Label4.Text = "Apelido:"' 
        ' TApelido
        ' 
        TApelido.CharacterCasing = CharacterCasing.Upper
        TApelido.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        TApelido.Location = New Point(83, 92)
        TApelido.MaxLength = 60
        TApelido.Name = "TApelido"
        TApelido.Size = New Size(555, 27)
        TApelido.TabIndex = 5
        ' 
        ' TNome
        ' 
        TNome.CharacterCasing = CharacterCasing.Upper
        TNome.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        TNome.Location = New Point(83, 59)
        TNome.MaxLength = 100
        TNome.Name = "TNome"
        TNome.Size = New Size(555, 27)
        TNome.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(427, 32)
        Label2.Name = "Label2"
        Label2.Size = New Size(25, 15)
        Label2.TabIndex = 2
        Label2.Text = "RG:"' 
        ' TReg
        ' 
        TReg.CharacterCasing = CharacterCasing.Upper
        TReg.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        TReg.Location = New Point(458, 25)
        TReg.MaxLength = 15
        TReg.Name = "TReg"
        TReg.Size = New Size(180, 27)
        TReg.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(160, 32)
        Label1.Name = "Label1"
        Label1.Size = New Size(31, 15)
        Label1.TabIndex = 0
        Label1.Text = "CPF:"' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(6, 66)
        Label3.Name = "Label3"
        Label3.Size = New Size(43, 15)
        Label3.TabIndex = 4
        Label3.Text = "Nome:"' 
        ' TComp
        ' 
        TComp.CharacterCasing = CharacterCasing.Upper
        TComp.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        TComp.Location = New Point(427, 259)
        TComp.MaxLength = 200
        TComp.Name = "TComp"
        TComp.Size = New Size(211, 27)
        TComp.TabIndex = 19
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(541, 22)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 32
        Button1.Text = "Button1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Frm_Cliente
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(659, 359)
        Controls.Add(Panel1)
        Controls.Add(GroupBox1)
        Name = "Frm_Cliente"
        Text = "Controle de Cliente."
        Panel1.ResumeLayout(False)
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtSalvar As Button
    Friend WithEvents BtAtualizar As Button
    Friend WithEvents BtFechar As Button
    Friend WithEvents BtEditar As Button
    Friend WithEvents BtExcluir As Button
    Friend WithEvents BtNovo As Button
    Friend WithEvents BtCancelar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label16 As Label
    Friend WithEvents TEmail As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents DtCad As DateTimePicker
    Friend WithEvents TCel As MaskedTextBox
    Friend WithEvents TFone As MaskedTextBox
    Friend WithEvents TCep As MaskedTextBox
    Friend WithEvents Tdoc As MaskedTextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents TObs As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents CbCidade As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents CbTipo As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents TUF As TextBox
    Friend WithEvents TBairro As TextBox
    Friend WithEvents Tnumero As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TEnde As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TApelido As TextBox
    Friend WithEvents TNome As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TReg As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents CbAtivo As ComboBox
    Friend WithEvents Label17 As Label
    Friend WithEvents TCodigo As TextBox
    Friend WithEvents Bbuscacnpj As Button
    Friend WithEvents Label19 As Label
    Friend WithEvents TComp As TextBox
    Friend WithEvents Button1 As Button
End Class
