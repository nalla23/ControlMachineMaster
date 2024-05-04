<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Servico
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Frm_Servico))
        TValor = New TextBox()
        Panel1 = New Panel()
        Label6 = New Label()
        Panel2 = New Panel()
        BtFechar = New Button()
        PictureBox1 = New PictureBox()
        BtExcluir = New Button()
        BtEditar = New Button()
        BtCancelar = New Button()
        BtAtualizar = New Button()
        BtNovo = New Button()
        BtSalvar = New Button()
        GroupBox1 = New GroupBox()
        DtLan = New DateTimePicker()
        TResp = New TextBox()
        TDescricao = New TextBox()
        Tnumero = New TextBox()
        Label5 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label1 = New Label()
        Panel3 = New Panel()
        LbQtderegistro = New Label()
        LbTotal = New Label()
        TPesquisa = New TextBox()
        DgManutencao = New DataGridView()
        Label7 = New Label()
        BtBuscar = New Button()
        Codigo = New DataGridViewTextBoxColumn()
        Descricao = New DataGridViewTextBoxColumn()
        Valor = New DataGridViewTextBoxColumn()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        Panel3.SuspendLayout()
        CType(DgManutencao, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TValor
        ' 
        TValor.CharacterCasing = CharacterCasing.Upper
        TValor.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TValor.Location = New Point(6, 187)
        TValor.Name = "TValor"
        TValor.Size = New Size(156, 29)
        TValor.TabIndex = 5
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(51), CByte(51), CByte(66))
        Panel1.Controls.Add(Label6)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(391, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(615, 60)
        Panel1.TabIndex = 13
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.ForeColor = SystemColors.Window
        Label6.Location = New Point(118, 9)
        Label6.Name = "Label6"
        Label6.Size = New Size(378, 37)
        Label6.TabIndex = 29
        Label6.Text = "Manutenção de equipamento"' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(51), CByte(51), CByte(66))
        Panel2.Controls.Add(BtFechar)
        Panel2.Controls.Add(PictureBox1)
        Panel2.Controls.Add(BtExcluir)
        Panel2.Controls.Add(BtEditar)
        Panel2.Controls.Add(BtCancelar)
        Panel2.Controls.Add(BtAtualizar)
        Panel2.Controls.Add(BtNovo)
        Panel2.Controls.Add(BtSalvar)
        Panel2.Controls.Add(GroupBox1)
        Panel2.Dock = DockStyle.Left
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(391, 470)
        Panel2.TabIndex = 14
        ' 
        ' BtFechar
        ' 
        BtFechar.FlatAppearance.BorderSize = 0
        BtFechar.FlatStyle = FlatStyle.Flat
        BtFechar.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        BtFechar.ForeColor = SystemColors.Window
        BtFechar.Image = CType(resources.GetObject("BtFechar.Image"), Image)
        BtFechar.ImageAlign = ContentAlignment.MiddleLeft
        BtFechar.Location = New Point(295, 416)
        BtFechar.Name = "BtFechar"
        BtFechar.Size = New Size(89, 37)
        BtFechar.TabIndex = 32
        BtFechar.Text = "&Fechar"
        BtFechar.TextAlign = ContentAlignment.MiddleRight
        BtFechar.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.FromArgb(CByte(51), CByte(51), CByte(66))
        PictureBox1.Dock = DockStyle.Top
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(391, 116)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 31
        PictureBox1.TabStop = False
        ' 
        ' BtExcluir
        ' 
        BtExcluir.BackColor = Color.FromArgb(CByte(51), CByte(51), CByte(66))
        BtExcluir.BackgroundImageLayout = ImageLayout.None
        BtExcluir.FlatAppearance.BorderSize = 0
        BtExcluir.FlatStyle = FlatStyle.Flat
        BtExcluir.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        BtExcluir.ForeColor = SystemColors.Window
        BtExcluir.Image = CType(resources.GetObject("BtExcluir.Image"), Image)
        BtExcluir.ImageAlign = ContentAlignment.MiddleLeft
        BtExcluir.Location = New Point(200, 418)
        BtExcluir.Name = "BtExcluir"
        BtExcluir.Size = New Size(89, 37)
        BtExcluir.TabIndex = 11
        BtExcluir.Text = "&Excluir"
        BtExcluir.TextAlign = ContentAlignment.MiddleRight
        BtExcluir.UseVisualStyleBackColor = False
        ' 
        ' BtEditar
        ' 
        BtEditar.BackColor = Color.FromArgb(CByte(51), CByte(51), CByte(66))
        BtEditar.BackgroundImageLayout = ImageLayout.None
        BtEditar.FlatAppearance.BorderSize = 0
        BtEditar.FlatStyle = FlatStyle.Flat
        BtEditar.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        BtEditar.ForeColor = SystemColors.Window
        BtEditar.Image = CType(resources.GetObject("BtEditar.Image"), Image)
        BtEditar.ImageAlign = ContentAlignment.MiddleLeft
        BtEditar.Location = New Point(105, 418)
        BtEditar.Name = "BtEditar"
        BtEditar.Size = New Size(89, 37)
        BtEditar.TabIndex = 9
        BtEditar.Text = "&Editar"
        BtEditar.TextAlign = ContentAlignment.MiddleRight
        BtEditar.UseVisualStyleBackColor = False
        ' 
        ' BtCancelar
        ' 
        BtCancelar.BackColor = Color.FromArgb(CByte(51), CByte(51), CByte(66))
        BtCancelar.BackgroundImageLayout = ImageLayout.None
        BtCancelar.FlatAppearance.BorderSize = 0
        BtCancelar.FlatStyle = FlatStyle.Flat
        BtCancelar.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        BtCancelar.ForeColor = SystemColors.Window
        BtCancelar.Image = CType(resources.GetObject("BtCancelar.Image"), Image)
        BtCancelar.ImageAlign = ContentAlignment.MiddleLeft
        BtCancelar.Location = New Point(105, 416)
        BtCancelar.Name = "BtCancelar"
        BtCancelar.Size = New Size(89, 37)
        BtCancelar.TabIndex = 10
        BtCancelar.Text = "Cancelar"
        BtCancelar.TextAlign = ContentAlignment.MiddleRight
        BtCancelar.UseVisualStyleBackColor = False
        ' 
        ' BtAtualizar
        ' 
        BtAtualizar.BackColor = Color.FromArgb(CByte(51), CByte(51), CByte(66))
        BtAtualizar.BackgroundImageLayout = ImageLayout.None
        BtAtualizar.FlatAppearance.BorderSize = 0
        BtAtualizar.FlatStyle = FlatStyle.Flat
        BtAtualizar.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        BtAtualizar.ForeColor = SystemColors.Window
        BtAtualizar.Image = CType(resources.GetObject("BtAtualizar.Image"), Image)
        BtAtualizar.ImageAlign = ContentAlignment.BottomLeft
        BtAtualizar.Location = New Point(10, 418)
        BtAtualizar.Name = "BtAtualizar"
        BtAtualizar.Size = New Size(89, 37)
        BtAtualizar.TabIndex = 7
        BtAtualizar.Text = "&Atualizar"
        BtAtualizar.TextAlign = ContentAlignment.MiddleRight
        BtAtualizar.UseVisualStyleBackColor = False
        ' 
        ' BtNovo
        ' 
        BtNovo.BackColor = Color.FromArgb(CByte(51), CByte(51), CByte(66))
        BtNovo.BackgroundImageLayout = ImageLayout.None
        BtNovo.FlatAppearance.BorderSize = 0
        BtNovo.FlatStyle = FlatStyle.Flat
        BtNovo.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        BtNovo.ForeColor = SystemColors.Window
        BtNovo.Image = CType(resources.GetObject("BtNovo.Image"), Image)
        BtNovo.ImageAlign = ContentAlignment.MiddleLeft
        BtNovo.Location = New Point(10, 416)
        BtNovo.Name = "BtNovo"
        BtNovo.Size = New Size(89, 37)
        BtNovo.TabIndex = 8
        BtNovo.Text = "Novo"
        BtNovo.TextAlign = ContentAlignment.MiddleRight
        BtNovo.UseVisualStyleBackColor = False
        ' 
        ' BtSalvar
        ' 
        BtSalvar.BackColor = Color.FromArgb(CByte(51), CByte(51), CByte(66))
        BtSalvar.BackgroundImageLayout = ImageLayout.None
        BtSalvar.FlatAppearance.BorderSize = 0
        BtSalvar.FlatStyle = FlatStyle.Flat
        BtSalvar.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        BtSalvar.ForeColor = SystemColors.Window
        BtSalvar.Image = CType(resources.GetObject("BtSalvar.Image"), Image)
        BtSalvar.ImageAlign = ContentAlignment.BottomLeft
        BtSalvar.Location = New Point(10, 418)
        BtSalvar.Name = "BtSalvar"
        BtSalvar.Size = New Size(89, 37)
        BtSalvar.TabIndex = 6
        BtSalvar.Text = "Salvar"
        BtSalvar.TextAlign = ContentAlignment.MiddleRight
        BtSalvar.UseVisualStyleBackColor = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.FromArgb(CByte(51), CByte(51), CByte(66))
        GroupBox1.Controls.Add(DtLan)
        GroupBox1.Controls.Add(TValor)
        GroupBox1.Controls.Add(TResp)
        GroupBox1.Controls.Add(TDescricao)
        GroupBox1.Controls.Add(Tnumero)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.ForeColor = SystemColors.Window
        GroupBox1.Location = New Point(3, 122)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(381, 279)
        GroupBox1.TabIndex = 30
        GroupBox1.TabStop = False
        GroupBox1.Text = "Dados principais"' 
        ' DtLan
        ' 
        DtLan.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        DtLan.Format = DateTimePickerFormat.Short
        DtLan.Location = New Point(6, 37)
        DtLan.Name = "DtLan"
        DtLan.Size = New Size(156, 29)
        DtLan.TabIndex = 1
        ' 
        ' TResp
        ' 
        TResp.CharacterCasing = CharacterCasing.Upper
        TResp.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TResp.Location = New Point(6, 137)
        TResp.MaxLength = 30
        TResp.Name = "TResp"
        TResp.Size = New Size(366, 29)
        TResp.TabIndex = 4
        ' 
        ' TDescricao
        ' 
        TDescricao.CharacterCasing = CharacterCasing.Upper
        TDescricao.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TDescricao.Location = New Point(6, 87)
        TDescricao.MaxLength = 60
        TDescricao.Name = "TDescricao"
        TDescricao.Size = New Size(366, 29)
        TDescricao.TabIndex = 3
        ' 
        ' Tnumero
        ' 
        Tnumero.CharacterCasing = CharacterCasing.Upper
        Tnumero.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Tnumero.Location = New Point(168, 37)
        Tnumero.Name = "Tnumero"
        Tnumero.Size = New Size(204, 29)
        Tnumero.TabIndex = 2
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.ForeColor = SystemColors.Window
        Label5.Location = New Point(171, 19)
        Label5.Name = "Label5"
        Label5.Size = New Size(54, 15)
        Label5.TabIndex = 29
        Label5.Text = "Numero:"' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.ForeColor = SystemColors.Window
        Label2.Location = New Point(6, 119)
        Label2.Name = "Label2"
        Label2.Size = New Size(72, 15)
        Label2.TabIndex = 25
        Label2.Text = "Responsável"' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.ForeColor = SystemColors.Window
        Label3.Location = New Point(6, 169)
        Label3.Name = "Label3"
        Label3.Size = New Size(33, 15)
        Label3.TabIndex = 26
        Label3.Text = "Valor"' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.ForeColor = SystemColors.Window
        Label4.Location = New Point(9, 19)
        Label4.Name = "Label4"
        Label4.Size = New Size(34, 15)
        Label4.TabIndex = 28
        Label4.Text = "Data:"' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = SystemColors.Window
        Label1.Location = New Point(6, 69)
        Label1.Name = "Label1"
        Label1.Size = New Size(61, 15)
        Label1.TabIndex = 20
        Label1.Text = "Descrição:"' 
        ' Panel3
        ' 
        Panel3.Controls.Add(LbQtderegistro)
        Panel3.Controls.Add(LbTotal)
        Panel3.Controls.Add(TPesquisa)
        Panel3.Controls.Add(DgManutencao)
        Panel3.Controls.Add(Label7)
        Panel3.Controls.Add(BtBuscar)
        Panel3.Dock = DockStyle.Fill
        Panel3.Location = New Point(391, 60)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(615, 410)
        Panel3.TabIndex = 15
        ' 
        ' LbQtderegistro
        ' 
        LbQtderegistro.AutoSize = True
        LbQtderegistro.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        LbQtderegistro.Location = New Point(6, 344)
        LbQtderegistro.Name = "LbQtderegistro"
        LbQtderegistro.Size = New Size(25, 21)
        LbQtderegistro.TabIndex = 33
        LbQtderegistro.Text = "10"' 
        ' LbTotal
        ' 
        LbTotal.AutoSize = True
        LbTotal.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        LbTotal.Location = New Point(390, 344)
        LbTotal.Name = "LbTotal"
        LbTotal.Size = New Size(82, 21)
        LbTotal.TabIndex = 32
        LbTotal.Text = "R$ 300,00"' 
        ' TPesquisa
        ' 
        TPesquisa.CharacterCasing = CharacterCasing.Upper
        TPesquisa.Location = New Point(6, 23)
        TPesquisa.Multiline = True
        TPesquisa.Name = "TPesquisa"
        TPesquisa.Size = New Size(502, 32)
        TPesquisa.TabIndex = 13
        ' 
        ' DgManutencao
        ' 
        DgManutencao.AllowUserToAddRows = False
        DgManutencao.AllowUserToDeleteRows = False
        DgManutencao.AllowUserToResizeColumns = False
        DgManutencao.AllowUserToResizeRows = False
        DgManutencao.BackgroundColor = SystemColors.MenuBar
        DgManutencao.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DgManutencao.EditMode = DataGridViewEditMode.EditOnF2
        DgManutencao.Location = New Point(6, 62)
        DgManutencao.MultiSelect = False
        DgManutencao.Name = "DgManutencao"
        DgManutencao.ReadOnly = True
        DgManutencao.RowHeadersVisible = False
        DgManutencao.RowTemplate.Height = 25
        DgManutencao.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DgManutencao.ShowCellErrors = False
        DgManutencao.ShowCellToolTips = False
        DgManutencao.ShowEditingIcon = False
        DgManutencao.ShowRowErrors = False
        DgManutencao.Size = New Size(596, 279)
        DgManutencao.TabIndex = 31
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.ForeColor = SystemColors.Desktop
        Label7.Location = New Point(6, 3)
        Label7.Name = "Label7"
        Label7.Size = New Size(118, 15)
        Label7.TabIndex = 30
        Label7.Text = "Digita o que procura."' 
        ' BtBuscar
        ' 
        BtBuscar.Image = CType(resources.GetObject("BtBuscar.Image"), Image)
        BtBuscar.ImageAlign = ContentAlignment.MiddleLeft
        BtBuscar.Location = New Point(514, 23)
        BtBuscar.Name = "BtBuscar"
        BtBuscar.Size = New Size(88, 32)
        BtBuscar.TabIndex = 14
        BtBuscar.Text = "Buscar"
        BtBuscar.TextAlign = ContentAlignment.MiddleRight
        BtBuscar.TextImageRelation = TextImageRelation.ImageBeforeText
        BtBuscar.UseVisualStyleBackColor = True
        ' 
        ' Codigo
        ' 
        Codigo.HeaderText = "Codigo"
        Codigo.Name = "Codigo"' 
        ' Descricao
        ' 
        Descricao.HeaderText = "Descricao"
        Descricao.Name = "Descricao"' 
        ' Valor
        ' 
        Valor.HeaderText = "Valor"
        Valor.Name = "Valor"' 
        ' Frm_Servico
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1006, 470)
        Controls.Add(Panel3)
        Controls.Add(Panel1)
        Controls.Add(Panel2)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "Frm_Servico"
        StartPosition = FormStartPosition.CenterParent
        Text = "Lançamento de Manutenção"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(DgManutencao, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TValor As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DtLan As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents BtExcluir As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents BtEditar As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents BtCancelar As Button
    Friend WithEvents TDescricao As TextBox
    Friend WithEvents BtSalvar As Button
    Friend WithEvents Tnumero As TextBox
    Friend WithEvents BtAtualizar As Button
    Friend WithEvents TResp As TextBox
    Friend WithEvents BtNovo As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents BtBuscar As Button
    Friend WithEvents TPesquisa As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DgManutencao As DataGridView
    Friend WithEvents BtFechar As Button
    Friend WithEvents LbQtderegistro As Label
    Friend WithEvents LbTotal As Label
    Friend WithEvents Codigo As DataGridViewTextBoxColumn
    Friend WithEvents Descricao As DataGridViewTextBoxColumn
    Friend WithEvents Valor As DataGridViewTextBoxColumn
End Class
