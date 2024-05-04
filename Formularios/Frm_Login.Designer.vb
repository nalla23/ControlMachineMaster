<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class Frm_Login
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
    Friend WithEvents TSenha As System.Windows.Forms.TextBox

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Frm_Login))
        TSenha = New TextBox()
        BtAcessar = New Button()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        CbUsuario = New ComboBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TSenha
        ' 
        TSenha.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TSenha.Location = New Point(126, 195)
        TSenha.Name = "TSenha"
        TSenha.PasswordChar = "*"c
        TSenha.PlaceholderText = "Senha"
        TSenha.Size = New Size(355, 29)
        TSenha.TabIndex = 2
        ' 
        ' BtAcessar
        ' 
        BtAcessar.BackColor = Color.FromArgb(CByte(21), CByte(86), CByte(99))
        BtAcessar.BackgroundImageLayout = ImageLayout.None
        BtAcessar.FlatAppearance.BorderColor = Color.FromArgb(CByte(21), CByte(86), CByte(99))
        BtAcessar.FlatAppearance.BorderSize = 0
        BtAcessar.FlatStyle = FlatStyle.Flat
        BtAcessar.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        BtAcessar.ForeColor = SystemColors.Window
        BtAcessar.ImageAlign = ContentAlignment.BottomCenter
        BtAcessar.Location = New Point(126, 242)
        BtAcessar.Name = "BtAcessar"
        BtAcessar.Size = New Size(355, 43)
        BtAcessar.TabIndex = 3
        BtAcessar.Text = "Acessar"
        BtAcessar.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(126, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(355, 94)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 10
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(564, 12)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(26, 19)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 11
        PictureBox2.TabStop = False
        ' 
        ' CbUsuario
        ' 
        CbUsuario.AutoCompleteCustomSource.AddRange(New String() {"order by nome"})
        CbUsuario.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        CbUsuario.AutoCompleteSource = AutoCompleteSource.ListItems
        CbUsuario.DropDownStyle = ComboBoxStyle.DropDownList
        CbUsuario.FlatStyle = FlatStyle.System
        CbUsuario.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        CbUsuario.FormattingEnabled = True
        CbUsuario.Location = New Point(126, 145)
        CbUsuario.Name = "CbUsuario"
        CbUsuario.Size = New Size(355, 29)
        CbUsuario.TabIndex = 1
        CbUsuario.Tag = "Usuário"' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = SystemColors.Window
        Label1.Location = New Point(126, 127)
        Label1.Name = "Label1"
        Label1.Size = New Size(50, 15)
        Label1.TabIndex = 12
        Label1.Text = "Usuário:"' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.ForeColor = SystemColors.Window
        Label2.Location = New Point(126, 177)
        Label2.Name = "Label2"
        Label2.Size = New Size(42, 15)
        Label2.TabIndex = 13
        Label2.Text = "Senha:"' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.ForeColor = SystemColors.ControlDarkDark
        Label3.Location = New Point(12, 308)
        Label3.Name = "Label3"
        Label3.Size = New Size(79, 15)
        Label3.TabIndex = 14
        Label3.Text = "Configuração"' 
        ' Frm_Login
        ' 
        AcceptButton = BtAcessar
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        BackColor = Color.FromArgb(CByte(41), CByte(56), CByte(89))
        ClientSize = New Size(602, 332)
        Controls.Add(Label3)
        Controls.Add(CbUsuario)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(BtAcessar)
        Controls.Add(TSenha)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        KeyPreview = True
        MaximizeBox = False
        MinimizeBox = False
        Name = "Frm_Login"
        SizeGripStyle = SizeGripStyle.Hide
        StartPosition = FormStartPosition.CenterScreen
        Text = "Control Machine"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents BtAcessar As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents CbUsuario As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
