<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_systema
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Frm_systema))
        Label1 = New Label()
        Tnome = New TextBox()
        Tusuario = New TextBox()
        Label2 = New Label()
        Tmemoria = New TextBox()
        Label3 = New Label()
        Tprocessador = New TextBox()
        Label4 = New Label()
        BBuscar = New Button()
        BFechar = New Button()
        Tsistema = New TextBox()
        Label5 = New Label()
        TFabMod = New TextBox()
        Label8 = New Label()
        PictureBox1 = New PictureBox()
        BtSalvar = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(5, 114)
        Label1.Name = "Label1"
        Label1.Size = New Size(129, 15)
        Label1.TabIndex = 0
        Label1.Text = "Nome do computador:"' 
        ' Tnome
        ' 
        Tnome.Location = New Point(137, 111)
        Tnome.Name = "Tnome"
        Tnome.Size = New Size(397, 23)
        Tnome.TabIndex = 1
        ' 
        ' Tusuario
        ' 
        Tusuario.Location = New Point(137, 140)
        Tusuario.Name = "Tusuario"
        Tusuario.Size = New Size(397, 23)
        Tusuario.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(5, 143)
        Label2.Name = "Label2"
        Label2.Size = New Size(102, 15)
        Label2.TabIndex = 2
        Label2.Text = "Nome do usuário:"' 
        ' Tmemoria
        ' 
        Tmemoria.Location = New Point(137, 198)
        Tmemoria.Name = "Tmemoria"
        Tmemoria.Size = New Size(397, 23)
        Tmemoria.TabIndex = 7
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(5, 201)
        Label3.Name = "Label3"
        Label3.Size = New Size(58, 15)
        Label3.TabIndex = 6
        Label3.Text = "Memoria:"' 
        ' Tprocessador
        ' 
        Tprocessador.Location = New Point(137, 169)
        Tprocessador.Name = "Tprocessador"
        Tprocessador.Size = New Size(397, 23)
        Tprocessador.TabIndex = 5
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(5, 172)
        Label4.Name = "Label4"
        Label4.Size = New Size(74, 15)
        Label4.TabIndex = 4
        Label4.Text = "Processador:"' 
        ' BBuscar
        ' 
        BBuscar.Location = New Point(137, 256)
        BBuscar.Name = "BBuscar"
        BBuscar.Size = New Size(94, 35)
        BBuscar.TabIndex = 8
        BBuscar.Text = "Buscar"
        BBuscar.UseVisualStyleBackColor = True
        ' 
        ' BFechar
        ' 
        BFechar.Location = New Point(337, 256)
        BFechar.Name = "BFechar"
        BFechar.Size = New Size(94, 35)
        BFechar.TabIndex = 9
        BFechar.Text = "Fechar"
        BFechar.UseVisualStyleBackColor = True
        ' 
        ' Tsistema
        ' 
        Tsistema.Location = New Point(137, 82)
        Tsistema.Name = "Tsistema"
        Tsistema.Size = New Size(397, 23)
        Tsistema.TabIndex = 11
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(5, 85)
        Label5.Name = "Label5"
        Label5.Size = New Size(118, 15)
        Label5.TabIndex = 10
        Label5.Text = "Sistema Operacional:"' 
        ' TFabMod
        ' 
        TFabMod.Location = New Point(137, 227)
        TFabMod.Name = "TFabMod"
        TFabMod.Size = New Size(397, 23)
        TFabMod.TabIndex = 13
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(5, 230)
        Label8.Name = "Label8"
        Label8.Size = New Size(111, 15)
        Label8.TabIndex = 12
        Label8.Text = "Fabricante\Modelo:"' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(258, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(100, 65)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 14
        PictureBox1.TabStop = False
        ' 
        ' BtSalvar
        ' 
        BtSalvar.Location = New Point(237, 256)
        BtSalvar.Name = "BtSalvar"
        BtSalvar.Size = New Size(94, 35)
        BtSalvar.TabIndex = 15
        BtSalvar.Text = "Salvar no DB"
        BtSalvar.UseVisualStyleBackColor = True
        ' 
        ' Frm_systema
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(551, 307)
        Controls.Add(BtSalvar)
        Controls.Add(PictureBox1)
        Controls.Add(TFabMod)
        Controls.Add(Label8)
        Controls.Add(Tsistema)
        Controls.Add(Label5)
        Controls.Add(BFechar)
        Controls.Add(BBuscar)
        Controls.Add(Tmemoria)
        Controls.Add(Label3)
        Controls.Add(Tprocessador)
        Controls.Add(Label4)
        Controls.Add(Tusuario)
        Controls.Add(Label2)
        Controls.Add(Tnome)
        Controls.Add(Label1)
        Name = "Frm_systema"
        Text = "Informação do sistema"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Tnome As TextBox
    Friend WithEvents Tusuario As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Tmemoria As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Tprocessador As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents BBuscar As Button
    Friend WithEvents BFechar As Button
    Friend WithEvents Tsistema As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TFabMod As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BtSalvar As Button
End Class
