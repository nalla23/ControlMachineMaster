<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_EnviarEmail
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Frm_EnviarEmail))
        Tremetente = New TextBox()
        TDestinatario = New TextBox()
        TAssunto = New TextBox()
        TMensagem = New TextBox()
        TAnexo = New TextBox()
        BtEnviar = New Button()
        BtAnexar = New Button()
        MenuStrip1 = New MenuStrip()
        ArquivoToolStripMenuItem = New ToolStripMenuItem()
        AnexarToolStripMenuItem = New ToolStripMenuItem()
        EnviarToolStripMenuItem = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Tremetente
        ' 
        Tremetente.BackColor = SystemColors.GradientInactiveCaption
        Tremetente.BorderStyle = BorderStyle.FixedSingle
        Tremetente.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Tremetente.ForeColor = Color.MidnightBlue
        Tremetente.Location = New Point(12, 27)
        Tremetente.Name = "Tremetente"
        Tremetente.PlaceholderText = "Remetente"
        Tremetente.Size = New Size(501, 29)
        Tremetente.TabIndex = 0
        ' 
        ' TDestinatario
        ' 
        TDestinatario.BackColor = SystemColors.GradientInactiveCaption
        TDestinatario.BorderStyle = BorderStyle.FixedSingle
        TDestinatario.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TDestinatario.ForeColor = Color.MidnightBlue
        TDestinatario.Location = New Point(12, 62)
        TDestinatario.Name = "TDestinatario"
        TDestinatario.PlaceholderText = "Destinatário"
        TDestinatario.Size = New Size(501, 29)
        TDestinatario.TabIndex = 1
        ' 
        ' TAssunto
        ' 
        TAssunto.BackColor = SystemColors.GradientInactiveCaption
        TAssunto.BorderStyle = BorderStyle.FixedSingle
        TAssunto.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TAssunto.ForeColor = Color.MidnightBlue
        TAssunto.Location = New Point(12, 97)
        TAssunto.Name = "TAssunto"
        TAssunto.PlaceholderText = "Assunto"
        TAssunto.Size = New Size(501, 29)
        TAssunto.TabIndex = 2
        ' 
        ' TMensagem
        ' 
        TMensagem.BackColor = SystemColors.GradientInactiveCaption
        TMensagem.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TMensagem.ForeColor = Color.MidnightBlue
        TMensagem.Location = New Point(12, 132)
        TMensagem.Multiline = True
        TMensagem.Name = "TMensagem"
        TMensagem.PlaceholderText = "Mensagem"
        TMensagem.Size = New Size(501, 97)
        TMensagem.TabIndex = 3
        ' 
        ' TAnexo
        ' 
        TAnexo.BackColor = SystemColors.GradientInactiveCaption
        TAnexo.BorderStyle = BorderStyle.FixedSingle
        TAnexo.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TAnexo.ForeColor = Color.MidnightBlue
        TAnexo.Location = New Point(12, 235)
        TAnexo.Name = "TAnexo"
        TAnexo.PlaceholderText = "Caminho do anexo"
        TAnexo.Size = New Size(501, 29)
        TAnexo.TabIndex = 4
        ' 
        ' BtEnviar
        ' 
        BtEnviar.FlatAppearance.BorderSize = 0
        BtEnviar.Image = CType(resources.GetObject("BtEnviar.Image"), Image)
        BtEnviar.ImageAlign = ContentAlignment.MiddleLeft
        BtEnviar.Location = New Point(12, 274)
        BtEnviar.Name = "BtEnviar"
        BtEnviar.Size = New Size(90, 31)
        BtEnviar.TabIndex = 5
        BtEnviar.Text = "Enviar"
        BtEnviar.UseVisualStyleBackColor = True
        ' 
        ' BtAnexar
        ' 
        BtAnexar.BackgroundImageLayout = ImageLayout.None
        BtAnexar.FlatAppearance.BorderSize = 0
        BtAnexar.Image = CType(resources.GetObject("BtAnexar.Image"), Image)
        BtAnexar.ImageAlign = ContentAlignment.MiddleLeft
        BtAnexar.Location = New Point(108, 276)
        BtAnexar.Name = "BtAnexar"
        BtAnexar.Size = New Size(75, 29)
        BtAnexar.TabIndex = 11
        BtAnexar.Text = "Anexo"
        BtAnexar.TextAlign = ContentAlignment.MiddleRight
        BtAnexar.UseVisualStyleBackColor = True
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {ArquivoToolStripMenuItem, AnexarToolStripMenuItem, EnviarToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(543, 24)
        MenuStrip1.TabIndex = 12
        MenuStrip1.Text = "MenuStrip1"' 
        ' ArquivoToolStripMenuItem
        ' 
        ArquivoToolStripMenuItem.Name = "ArquivoToolStripMenuItem"
        ArquivoToolStripMenuItem.Size = New Size(61, 20)
        ArquivoToolStripMenuItem.Text = "Arquivo"' 
        ' AnexarToolStripMenuItem
        ' 
        AnexarToolStripMenuItem.Name = "AnexarToolStripMenuItem"
        AnexarToolStripMenuItem.Size = New Size(56, 20)
        AnexarToolStripMenuItem.Text = "Anexar"' 
        ' EnviarToolStripMenuItem
        ' 
        EnviarToolStripMenuItem.Name = "EnviarToolStripMenuItem"
        EnviarToolStripMenuItem.Size = New Size(51, 20)
        EnviarToolStripMenuItem.Text = "Enviar"' 
        ' Frm_EnviarEmail
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(543, 397)
        Controls.Add(BtAnexar)
        Controls.Add(BtEnviar)
        Controls.Add(TAnexo)
        Controls.Add(TMensagem)
        Controls.Add(TAssunto)
        Controls.Add(TDestinatario)
        Controls.Add(Tremetente)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Frm_EnviarEmail"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Envio de Email"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Tremetente As TextBox
    Friend WithEvents TDestinatario As TextBox
    Friend WithEvents TAssunto As TextBox
    Friend WithEvents TMensagem As TextBox
    Friend WithEvents TAnexo As TextBox
    Friend WithEvents BtEnviar As Button
    Friend WithEvents BtAnexar As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ArquivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AnexarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EnviarToolStripMenuItem As ToolStripMenuItem
End Class
