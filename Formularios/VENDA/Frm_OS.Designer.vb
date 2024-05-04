<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_OS
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Frm_OS))
        TextBox1 = New TextBox()
        DgProduto = New DataGridView()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
        TCod = New TextBox()
        TVlrItem = New TextBox()
        TDesc = New TextBox()
        TVlrTotal = New TextBox()
        TQtde = New TextBox()
        CNomeProduto = New ComboBox()
        CNomeCliente = New ComboBox()
        TVlrUnitario = New TextBox()
        ImgProduto = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        TOs = New TextBox()
        Panel1 = New Panel()
        BtSalvar = New Button()
        BtFechar = New Button()
        BtNovo = New Button()
        BtCancelar = New Button()
        Lqtde = New Label()
        Button1 = New Button()
        CType(DgProduto, ComponentModel.ISupportInitialize).BeginInit()
        CType(ImgProduto, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = SystemColors.HotTrack
        TextBox1.BorderStyle = BorderStyle.FixedSingle
        TextBox1.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox1.ForeColor = SystemColors.Window
        TextBox1.HideSelection = False
        TextBox1.Location = New Point(12, 9)
        TextBox1.Name = "TextBox1"
        TextBox1.ReadOnly = True
        TextBox1.Size = New Size(402, 29)
        TextBox1.TabIndex = 4
        TextBox1.TabStop = False
        TextBox1.Text = "PRODUTOS\SERVIÇOS"' 
        ' DgProduto
        ' 
        DgProduto.BackgroundColor = SystemColors.Window
        DgProduto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DgProduto.Location = New Point(12, 50)
        DgProduto.Name = "DgProduto"
        DgProduto.RowTemplate.Height = 25
        DgProduto.Size = New Size(402, 284)
        DgProduto.TabIndex = 9
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = SystemColors.HotTrack
        TextBox2.BorderStyle = BorderStyle.FixedSingle
        TextBox2.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox2.ForeColor = SystemColors.Window
        TextBox2.HideSelection = False
        TextBox2.Location = New Point(435, 9)
        TextBox2.Name = "TextBox2"
        TextBox2.ReadOnly = True
        TextBox2.Size = New Size(281, 29)
        TextBox2.TabIndex = 10
        TextBox2.TabStop = False
        TextBox2.Text = "CÓDIGO DO PRODUTO"' 
        ' TextBox3
        ' 
        TextBox3.BackColor = SystemColors.HotTrack
        TextBox3.BorderStyle = BorderStyle.FixedSingle
        TextBox3.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox3.ForeColor = SystemColors.Window
        TextBox3.HideSelection = False
        TextBox3.Location = New Point(737, 80)
        TextBox3.Name = "TextBox3"
        TextBox3.ReadOnly = True
        TextBox3.Size = New Size(300, 29)
        TextBox3.TabIndex = 11
        TextBox3.TabStop = False
        TextBox3.Text = "TOTAL PRODUTO "' 
        ' TextBox4
        ' 
        TextBox4.BackColor = SystemColors.HotTrack
        TextBox4.BorderStyle = BorderStyle.FixedSingle
        TextBox4.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox4.ForeColor = SystemColors.Window
        TextBox4.HideSelection = False
        TextBox4.Location = New Point(737, 160)
        TextBox4.Name = "TextBox4"
        TextBox4.ReadOnly = True
        TextBox4.Size = New Size(300, 29)
        TextBox4.TabIndex = 12
        TextBox4.TabStop = False
        TextBox4.Text = "DESCONTO"' 
        ' TextBox5
        ' 
        TextBox5.BackColor = SystemColors.HotTrack
        TextBox5.BorderStyle = BorderStyle.FixedSingle
        TextBox5.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox5.ForeColor = SystemColors.Window
        TextBox5.HideSelection = False
        TextBox5.Location = New Point(737, 244)
        TextBox5.Name = "TextBox5"
        TextBox5.ReadOnly = True
        TextBox5.Size = New Size(300, 29)
        TextBox5.TabIndex = 13
        TextBox5.TabStop = False
        TextBox5.Text = "TOTAL GERAL"' 
        ' TCod
        ' 
        TCod.Font = New Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point)
        TCod.Location = New Point(435, 50)
        TCod.Name = "TCod"
        TCod.Size = New Size(281, 43)
        TCod.TabIndex = 1
        ' 
        ' TVlrItem
        ' 
        TVlrItem.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        TVlrItem.Location = New Point(737, 121)
        TVlrItem.Name = "TVlrItem"
        TVlrItem.Size = New Size(300, 35)
        TVlrItem.TabIndex = 15
        TVlrItem.Text = "0,00"' 
        ' TDesc
        ' 
        TDesc.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        TDesc.ForeColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        TDesc.Location = New Point(737, 195)
        TDesc.Name = "TDesc"
        TDesc.Size = New Size(300, 35)
        TDesc.TabIndex = 16
        TDesc.Text = "0,00"' 
        ' TVlrTotal
        ' 
        TVlrTotal.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point)
        TVlrTotal.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        TVlrTotal.Location = New Point(737, 279)
        TVlrTotal.Name = "TVlrTotal"
        TVlrTotal.Size = New Size(300, 50)
        TVlrTotal.TabIndex = 17
        TVlrTotal.Text = "0,00"' 
        ' TQtde
        ' 
        TQtde.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        TQtde.Location = New Point(435, 241)
        TQtde.Name = "TQtde"
        TQtde.Size = New Size(151, 33)
        TQtde.TabIndex = 4
        TQtde.Text = "0,00"' 
        ' CNomeProduto
        ' 
        CNomeProduto.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        CNomeProduto.FormattingEnabled = True
        CNomeProduto.Location = New Point(435, 121)
        CNomeProduto.Name = "CNomeProduto"
        CNomeProduto.Size = New Size(281, 33)
        CNomeProduto.TabIndex = 2
        ' 
        ' CNomeCliente
        ' 
        CNomeCliente.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        CNomeCliente.FormattingEnabled = True
        CNomeCliente.Location = New Point(435, 181)
        CNomeCliente.Name = "CNomeCliente"
        CNomeCliente.Size = New Size(281, 33)
        CNomeCliente.TabIndex = 3
        ' 
        ' TVlrUnitario
        ' 
        TVlrUnitario.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        TVlrUnitario.Location = New Point(435, 301)
        TVlrUnitario.Name = "TVlrUnitario"
        TVlrUnitario.Size = New Size(151, 33)
        TVlrUnitario.TabIndex = 5
        TVlrUnitario.Text = "0,00"' 
        ' ImgProduto
        ' 
        ImgProduto.Image = CType(resources.GetObject("ImgProduto.Image"), Image)
        ImgProduto.Location = New Point(592, 241)
        ImgProduto.Name = "ImgProduto"
        ImgProduto.Size = New Size(124, 93)
        ImgProduto.SizeMode = PictureBoxSizeMode.Zoom
        ImgProduto.TabIndex = 22
        ImgProduto.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.ControlDarkDark
        Label1.Location = New Point(435, 97)
        Label1.Name = "Label1"
        Label1.Size = New Size(173, 21)
        Label1.TabIndex = 23
        Label1.Text = "Descrição do Produto:"' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = SystemColors.ControlDarkDark
        Label2.Location = New Point(432, 157)
        Label2.Name = "Label2"
        Label2.Size = New Size(114, 21)
        Label2.TabIndex = 24
        Label2.Text = "Nome Cliente:"' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = SystemColors.ControlDarkDark
        Label3.Location = New Point(435, 217)
        Label3.Name = "Label3"
        Label3.Size = New Size(99, 21)
        Label3.TabIndex = 25
        Label3.Text = "Quantidade:"' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.ForeColor = SystemColors.ControlDarkDark
        Label4.Location = New Point(435, 277)
        Label4.Name = "Label4"
        Label4.Size = New Size(99, 21)
        Label4.TabIndex = 26
        Label4.Text = "Vlr. Unitário:"' 
        ' TOs
        ' 
        TOs.CharacterCasing = CharacterCasing.Upper
        TOs.Font = New Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point)
        TOs.HideSelection = False
        TOs.Location = New Point(737, 9)
        TOs.Multiline = True
        TOs.Name = "TOs"
        TOs.ReadOnly = True
        TOs.Size = New Size(300, 65)
        TOs.TabIndex = 27
        TOs.TabStop = False
        TOs.TextAlign = HorizontalAlignment.Center
        TOs.WordWrap = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.HotTrack
        Panel1.Controls.Add(BtSalvar)
        Panel1.Controls.Add(BtFechar)
        Panel1.Controls.Add(BtNovo)
        Panel1.Controls.Add(BtCancelar)
        Panel1.Dock = DockStyle.Bottom
        Panel1.Location = New Point(0, 379)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1059, 50)
        Panel1.TabIndex = 42
        ' 
        ' BtSalvar
        ' 
        BtSalvar.BackColor = SystemColors.HotTrack
        BtSalvar.FlatAppearance.BorderSize = 0
        BtSalvar.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(51), CByte(51), CByte(50))
        BtSalvar.FlatStyle = FlatStyle.Flat
        BtSalvar.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        BtSalvar.ForeColor = SystemColors.Window
        BtSalvar.Image = CType(resources.GetObject("BtSalvar.Image"), Image)
        BtSalvar.ImageAlign = ContentAlignment.MiddleLeft
        BtSalvar.Location = New Point(129, 0)
        BtSalvar.Name = "BtSalvar"
        BtSalvar.Size = New Size(111, 50)
        BtSalvar.TabIndex = 26
        BtSalvar.Text = "Salva"
        BtSalvar.TextAlign = ContentAlignment.MiddleLeft
        BtSalvar.TextImageRelation = TextImageRelation.ImageBeforeText
        BtSalvar.UseVisualStyleBackColor = False
        ' 
        ' BtFechar
        ' 
        BtFechar.BackColor = SystemColors.HotTrack
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
        ' BtNovo
        ' 
        BtNovo.BackColor = SystemColors.HotTrack
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
        BtCancelar.BackColor = SystemColors.HotTrack
        BtCancelar.FlatAppearance.BorderSize = 0
        BtCancelar.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(51), CByte(51), CByte(50))
        BtCancelar.FlatStyle = FlatStyle.Flat
        BtCancelar.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        BtCancelar.ForeColor = SystemColors.Window
        BtCancelar.Image = CType(resources.GetObject("BtCancelar.Image"), Image)
        BtCancelar.ImageAlign = ContentAlignment.MiddleLeft
        BtCancelar.Location = New Point(246, 0)
        BtCancelar.Name = "BtCancelar"
        BtCancelar.Size = New Size(111, 50)
        BtCancelar.TabIndex = 29
        BtCancelar.Text = "Cancelar"
        BtCancelar.TextAlign = ContentAlignment.MiddleLeft
        BtCancelar.TextImageRelation = TextImageRelation.ImageBeforeText
        BtCancelar.UseVisualStyleBackColor = False
        ' 
        ' Lqtde
        ' 
        Lqtde.AutoSize = True
        Lqtde.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Lqtde.ForeColor = SystemColors.ControlDarkDark
        Lqtde.Location = New Point(12, 337)
        Lqtde.Name = "Lqtde"
        Lqtde.Size = New Size(160, 21)
        Lqtde.TabIndex = 43
        Lqtde.Text = "Quantidade de Item:"' 
        ' Button1
        ' 
        Button1.Location = New Point(646, 349)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 44
        Button1.Text = "Button1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Frm_OS
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1059, 429)
        Controls.Add(Button1)
        Controls.Add(Lqtde)
        Controls.Add(Panel1)
        Controls.Add(TOs)
        Controls.Add(ImgProduto)
        Controls.Add(TextBox1)
        Controls.Add(DgProduto)
        Controls.Add(TVlrUnitario)
        Controls.Add(TextBox2)
        Controls.Add(CNomeCliente)
        Controls.Add(TextBox3)
        Controls.Add(CNomeProduto)
        Controls.Add(TextBox4)
        Controls.Add(TQtde)
        Controls.Add(TextBox5)
        Controls.Add(TVlrTotal)
        Controls.Add(TCod)
        Controls.Add(TDesc)
        Controls.Add(TVlrItem)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Frm_OS"
        Text = "Ordem de Serviços."
        CType(DgProduto, ComponentModel.ISupportInitialize).EndInit()
        CType(ImgProduto, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents DgProduto As DataGridView
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TCod As TextBox
    Friend WithEvents TVlrItem As TextBox
    Friend WithEvents TDesc As TextBox
    Friend WithEvents TVlrTotal As TextBox
    Friend WithEvents TQtde As TextBox
    Friend WithEvents CNomeProduto As ComboBox
    Friend WithEvents CNomeCliente As ComboBox
    Friend WithEvents TVlrUnitario As TextBox
    Friend WithEvents ImgProduto As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TOs As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtSalvar As Button
    Friend WithEvents BtFechar As Button
    Friend WithEvents BtNovo As Button
    Friend WithEvents BtCancelar As Button
    Friend WithEvents Lqtde As Label
    Friend WithEvents Button1 As Button
End Class
