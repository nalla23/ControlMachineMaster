<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_ConexaoDb
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Frm_ConexaoDb))
        BtConectar = New Button()
        BtFechar = New Button()
        Label1 = New Label()
        Label2 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        Label3 = New Label()
        TextBox4 = New TextBox()
        Label4 = New Label()
        bttestar = New Button()
        Label5 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label8 = New Label()
        Panel3 = New Panel()
        TServidor = New TextBox()
        TNome = New TextBox()
        TSenha = New TextBox()
        TUsuario = New TextBox()
        btsalvar = New Button()
        Panel1 = New Panel()
        Label9 = New Label()
        PictureBox2 = New PictureBox()
        PictureBox1 = New PictureBox()
        Panel2 = New Panel()
        TCaminhorelatorio = New TextBox()
        Panel3.SuspendLayout()
        Panel1.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' BtConectar
        ' 
        BtConectar.Location = New Point(111, 200)
        BtConectar.Name = "BtConectar"
        BtConectar.Size = New Size(101, 43)
        BtConectar.TabIndex = 0
        BtConectar.Text = "Conectar"
        BtConectar.UseVisualStyleBackColor = True
        ' 
        ' BtFechar
        ' 
        BtFechar.Location = New Point(218, 200)
        BtFechar.Name = "BtFechar"
        BtFechar.Size = New Size(101, 43)
        BtFechar.TabIndex = 1
        BtFechar.Text = "Fechar"
        BtFechar.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 28)
        Label1.Name = "Label1"
        Label1.Size = New Size(53, 15)
        Label1.TabIndex = 2
        Label1.Text = "Servidor:"' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 70)
        Label2.Name = "Label2"
        Label2.Size = New Size(93, 15)
        Label2.TabIndex = 3
        Label2.Text = "Nome do Banco"' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(111, 25)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(233, 23)
        TextBox1.TabIndex = 4
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(111, 67)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(233, 23)
        TextBox2.TabIndex = 5
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(111, 106)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(233, 23)
        TextBox3.TabIndex = 7
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 109)
        Label3.Name = "Label3"
        Label3.Size = New Size(50, 15)
        Label3.TabIndex = 6
        Label3.Text = "Usuário:"' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(111, 148)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(233, 23)
        TextBox4.TabIndex = 9
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(12, 156)
        Label4.Name = "Label4"
        Label4.Size = New Size(42, 15)
        Label4.TabIndex = 8
        Label4.Text = "Senha:"' 
        ' bttestar
        ' 
        bttestar.BackColor = Color.FromArgb(CByte(51), CByte(51), CByte(66))
        bttestar.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        bttestar.ForeColor = SystemColors.Window
        bttestar.Image = CType(resources.GetObject("bttestar.Image"), Image)
        bttestar.ImageAlign = ContentAlignment.MiddleLeft
        bttestar.Location = New Point(6, 203)
        bttestar.Name = "bttestar"
        bttestar.Size = New Size(179, 55)
        bttestar.TabIndex = 4
        bttestar.Text = "Testar Conexão"
        bttestar.TextImageRelation = TextImageRelation.ImageBeforeText
        bttestar.UseVisualStyleBackColor = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.ForeColor = Color.White
        Label5.Location = New Point(23, 116)
        Label5.Name = "Label5"
        Label5.Size = New Size(68, 25)
        Label5.TabIndex = 2
        Label5.Text = "Senha:"' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.ForeColor = Color.White
        Label7.Location = New Point(23, 81)
        Label7.Name = "Label7"
        Label7.Size = New Size(81, 25)
        Label7.TabIndex = 1
        Label7.Text = "Usuário:"' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.ForeColor = Color.White
        Label6.Location = New Point(23, 46)
        Label6.Name = "Label6"
        Label6.Size = New Size(69, 25)
        Label6.TabIndex = 0
        Label6.Text = "Dados:"' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.ForeColor = Color.White
        Label8.Location = New Point(23, 11)
        Label8.Name = "Label8"
        Label8.Size = New Size(86, 25)
        Label8.TabIndex = 0
        Label8.Text = "Servidor:"' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.WhiteSmoke
        Panel3.Controls.Add(TCaminhorelatorio)
        Panel3.Controls.Add(bttestar)
        Panel3.Controls.Add(TServidor)
        Panel3.Controls.Add(TNome)
        Panel3.Controls.Add(TSenha)
        Panel3.Controls.Add(TUsuario)
        Panel3.Controls.Add(btsalvar)
        Panel3.Dock = DockStyle.Fill
        Panel3.Location = New Point(138, 49)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(376, 270)
        Panel3.TabIndex = 15
        ' 
        ' TServidor
        ' 
        TServidor.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TServidor.Location = New Point(6, 8)
        TServidor.Name = "TServidor"
        TServidor.Size = New Size(351, 29)
        TServidor.TabIndex = 0
        ' 
        ' TNome
        ' 
        TNome.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TNome.Location = New Point(6, 46)
        TNome.Name = "TNome"
        TNome.Size = New Size(351, 29)
        TNome.TabIndex = 1
        ' 
        ' TSenha
        ' 
        TSenha.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TSenha.Location = New Point(6, 116)
        TSenha.Name = "TSenha"
        TSenha.PasswordChar = "#"c
        TSenha.Size = New Size(351, 29)
        TSenha.TabIndex = 3
        ' 
        ' TUsuario
        ' 
        TUsuario.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TUsuario.Location = New Point(6, 81)
        TUsuario.Name = "TUsuario"
        TUsuario.Size = New Size(351, 29)
        TUsuario.TabIndex = 2
        ' 
        ' btsalvar
        ' 
        btsalvar.BackColor = Color.FromArgb(CByte(51), CByte(51), CByte(66))
        btsalvar.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btsalvar.ForeColor = SystemColors.Window
        btsalvar.Image = CType(resources.GetObject("btsalvar.Image"), Image)
        btsalvar.ImageAlign = ContentAlignment.MiddleLeft
        btsalvar.Location = New Point(191, 203)
        btsalvar.Name = "btsalvar"
        btsalvar.Size = New Size(166, 55)
        btsalvar.TabIndex = 5
        btsalvar.Text = "Salvar"
        btsalvar.TextImageRelation = TextImageRelation.ImageBeforeText
        btsalvar.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(51), CByte(51), CByte(66))
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label8)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 49)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(138, 270)
        Panel1.TabIndex = 14
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label9.ForeColor = Color.White
        Label9.Location = New Point(23, 151)
        Label9.Name = "Label9"
        Label9.Size = New Size(122, 25)
        Label9.TabIndex = 6
        Label9.Text = "Caminho Rel."' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(459, 9)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(36, 34)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 1
        PictureBox2.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.FromArgb(CByte(51), CByte(51), CByte(66))
        PictureBox1.Dock = DockStyle.Left
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(138, 49)
        PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(51), CByte(51), CByte(66))
        Panel2.Controls.Add(PictureBox2)
        Panel2.Controls.Add(PictureBox1)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(514, 49)
        Panel2.TabIndex = 13
        ' 
        ' TCaminhorelatorio
        ' 
        TCaminhorelatorio.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TCaminhorelatorio.Location = New Point(6, 151)
        TCaminhorelatorio.Name = "TCaminhorelatorio"
        TCaminhorelatorio.Size = New Size(351, 29)
        TCaminhorelatorio.TabIndex = 6
        ' 
        ' Frm_ConexaoDb
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(514, 319)
        Controls.Add(Panel3)
        Controls.Add(Panel1)
        Controls.Add(Panel2)
        Controls.Add(TextBox4)
        Controls.Add(Label4)
        Controls.Add(TextBox3)
        Controls.Add(Label3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(BtFechar)
        Controls.Add(BtConectar)
        FormBorderStyle = FormBorderStyle.None
        Name = "Frm_ConexaoDb"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Conexão de banco de dados."
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BtConectar As Button
    Friend WithEvents BtFechar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents bttestar As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TServidor As TextBox
    Friend WithEvents TNome As TextBox
    Friend WithEvents TSenha As TextBox
    Friend WithEvents TUsuario As TextBox
    Friend WithEvents btsalvar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents TCaminhorelatorio As TextBox
End Class
