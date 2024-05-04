<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPDV
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(FrmPDV))
        Button1 = New Button()
        DgProdutos = New DataGridView()
        TextBox10 = New TextBox()
        Button8 = New Button()
        TextBox9 = New TextBox()
        Button7 = New Button()
        TextBox8 = New TextBox()
        Button6 = New Button()
        TextBox7 = New TextBox()
        Button5 = New Button()
        TextBox6 = New TextBox()
        Button4 = New Button()
        TextBox5 = New TextBox()
        PictureBox1 = New PictureBox()
        TextBox4 = New TextBox()
        TextBox3 = New TextBox()
        ComboBox1 = New ComboBox()
        TextBox1 = New TextBox()
        Button3 = New Button()
        Button2 = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Button9 = New Button()
        ComboBox2 = New ComboBox()
        TextBox2 = New TextBox()
        Button10 = New Button()
        Button11 = New Button()
        Button12 = New Button()
        Button13 = New Button()
        CType(DgProdutos, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(59), CByte(59), CByte(59))
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.ForeColor = SystemColors.Window
        Button1.Location = New Point(12, 62)
        Button1.Name = "Button1"
        Button1.Size = New Size(583, 25)
        Button1.TabIndex = 29
        Button1.Text = "ITENS ADICIONADOS"
        Button1.TextAlign = ContentAlignment.MiddleLeft
        Button1.UseVisualStyleBackColor = False
        ' 
        ' DgProdutos
        ' 
        DgProdutos.AllowUserToDeleteRows = False
        DgProdutos.AllowUserToOrderColumns = True
        DgProdutos.BackgroundColor = SystemColors.Window
        DgProdutos.BorderStyle = BorderStyle.None
        DgProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DgProdutos.Location = New Point(12, 87)
        DgProdutos.Name = "DgProdutos"
        DgProdutos.RowTemplate.Height = 25
        DgProdutos.Size = New Size(583, 529)
        DgProdutos.TabIndex = 28
        ' 
        ' TextBox10
        ' 
        TextBox10.Font = New Font("Segoe UI", 28F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox10.ForeColor = Color.SaddleBrown
        TextBox10.Location = New Point(1025, 559)
        TextBox10.MaxLength = 20
        TextBox10.Name = "TextBox10"
        TextBox10.Size = New Size(378, 57)
        TextBox10.TabIndex = 52
        TextBox10.Text = "R$ 0,00"' 
        ' Button8
        ' 
        Button8.BackColor = Color.SaddleBrown
        Button8.FlatStyle = FlatStyle.Flat
        Button8.Font = New Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Button8.ForeColor = SystemColors.Window
        Button8.Location = New Point(1025, 528)
        Button8.Name = "Button8"
        Button8.Size = New Size(378, 25)
        Button8.TabIndex = 51
        Button8.Text = "TROCO"
        Button8.TextAlign = ContentAlignment.MiddleLeft
        Button8.UseVisualStyleBackColor = False
        ' 
        ' TextBox9
        ' 
        TextBox9.Font = New Font("Segoe UI", 28F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox9.Location = New Point(1025, 281)
        TextBox9.MaxLength = 20
        TextBox9.Name = "TextBox9"
        TextBox9.Size = New Size(378, 57)
        TextBox9.TabIndex = 50
        TextBox9.Text = "R$ 0,00"' 
        ' Button7
        ' 
        Button7.BackColor = Color.Gray
        Button7.FlatStyle = FlatStyle.Flat
        Button7.Font = New Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Button7.ForeColor = SystemColors.Window
        Button7.Location = New Point(1025, 340)
        Button7.Name = "Button7"
        Button7.Size = New Size(378, 25)
        Button7.TabIndex = 49
        Button7.Text = "VALOR RECEBIDO"
        Button7.TextAlign = ContentAlignment.MiddleLeft
        Button7.UseVisualStyleBackColor = False
        ' 
        ' TextBox8
        ' 
        TextBox8.Font = New Font("Segoe UI", 28F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox8.ForeColor = Color.DarkOliveGreen
        TextBox8.Location = New Point(1025, 465)
        TextBox8.MaxLength = 20
        TextBox8.Name = "TextBox8"
        TextBox8.Size = New Size(378, 57)
        TextBox8.TabIndex = 48
        TextBox8.Text = "R$ 0,00"' 
        ' Button6
        ' 
        Button6.BackColor = Color.DarkOliveGreen
        Button6.FlatStyle = FlatStyle.Flat
        Button6.Font = New Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Button6.ForeColor = SystemColors.Window
        Button6.Location = New Point(1025, 434)
        Button6.Name = "Button6"
        Button6.Size = New Size(378, 25)
        Button6.TabIndex = 47
        Button6.Text = "TOTAL DA VENDA"
        Button6.TextAlign = ContentAlignment.MiddleLeft
        Button6.UseVisualStyleBackColor = False
        ' 
        ' TextBox7
        ' 
        TextBox7.Font = New Font("Segoe UI", 28F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox7.Location = New Point(1025, 187)
        TextBox7.MaxLength = 20
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(378, 57)
        TextBox7.TabIndex = 46
        TextBox7.Text = "R$ 0,00"' 
        ' Button5
        ' 
        Button5.BackColor = Color.FromArgb(CByte(59), CByte(59), CByte(59))
        Button5.FlatStyle = FlatStyle.Flat
        Button5.Font = New Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Button5.ForeColor = SystemColors.Window
        Button5.Location = New Point(1025, 250)
        Button5.Name = "Button5"
        Button5.Size = New Size(378, 25)
        Button5.TabIndex = 45
        Button5.Text = "DESCONTO"
        Button5.TextAlign = ContentAlignment.MiddleLeft
        Button5.UseVisualStyleBackColor = False
        ' 
        ' TextBox6
        ' 
        TextBox6.Font = New Font("Segoe UI", 28F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox6.Location = New Point(1025, 371)
        TextBox6.MaxLength = 20
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(378, 57)
        TextBox6.TabIndex = 44
        TextBox6.Text = "R$ 0,00"' 
        ' Button4
        ' 
        Button4.BackColor = Color.FromArgb(CByte(59), CByte(59), CByte(59))
        Button4.FlatStyle = FlatStyle.Flat
        Button4.Font = New Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Button4.ForeColor = SystemColors.Window
        Button4.Location = New Point(1025, 156)
        Button4.Name = "Button4"
        Button4.Size = New Size(378, 25)
        Button4.TabIndex = 43
        Button4.Text = "SUB TOTAL"
        Button4.TextAlign = ContentAlignment.MiddleLeft
        Button4.UseVisualStyleBackColor = False
        ' 
        ' TextBox5
        ' 
        TextBox5.Font = New Font("Segoe UI", 28F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox5.Location = New Point(1025, 93)
        TextBox5.MaxLength = 20
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(378, 57)
        TextBox5.TabIndex = 42
        TextBox5.Text = "R$ 0,00"' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(615, 93)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(391, 173)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 41
        PictureBox1.TabStop = False
        ' 
        ' TextBox4
        ' 
        TextBox4.Font = New Font("Segoe UI", 28F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox4.Location = New Point(615, 561)
        TextBox4.MaxLength = 20
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(391, 57)
        TextBox4.TabIndex = 39
        TextBox4.Text = "R$ 0,00"' 
        ' TextBox3
        ' 
        TextBox3.Font = New Font("Segoe UI", 28F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox3.Location = New Point(613, 483)
        TextBox3.MaxLength = 20
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(391, 57)
        TextBox3.TabIndex = 37
        TextBox3.Text = "0,00"' 
        ' ComboBox1
        ' 
        ComboBox1.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(613, 429)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(391, 33)
        ComboBox1.TabIndex = 35
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI Semibold", 28F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox1.Location = New Point(613, 303)
        TextBox1.MaxLength = 20
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(391, 57)
        TextBox1.TabIndex = 32
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.FromArgb(CByte(59), CByte(59), CByte(59))
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Button3.ForeColor = SystemColors.Window
        Button3.Location = New Point(1025, 62)
        Button3.Name = "Button3"
        Button3.Size = New Size(378, 25)
        Button3.TabIndex = 31
        Button3.Text = "VLR. ULTIMO ITEM"
        Button3.TextAlign = ContentAlignment.MiddleLeft
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(59), CByte(59), CByte(59))
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.ForeColor = SystemColors.Window
        Button2.Location = New Point(613, 272)
        Button2.Name = "Button2"
        Button2.Size = New Size(391, 25)
        Button2.TabIndex = 30
        Button2.Text = "CÓDIGO PRODUTO (fabricante)"
        Button2.TextAlign = ContentAlignment.MiddleLeft
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(613, 363)
        Label1.Name = "Label1"
        Label1.Size = New Size(105, 15)
        Label1.TabIndex = 34
        Label1.Text = "Descrição do Item:"' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(613, 414)
        Label2.Name = "Label2"
        Label2.Size = New Size(100, 15)
        Label2.TabIndex = 36
        Label2.Text = "Nome do Cliente:"' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(613, 465)
        Label3.Name = "Label3"
        Label3.Size = New Size(72, 15)
        Label3.TabIndex = 38
        Label3.Text = "Quantidade:"' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(613, 543)
        Label4.Name = "Label4"
        Label4.Size = New Size(87, 15)
        Label4.TabIndex = 40
        Label4.Text = "Preço Unitários"' 
        ' Button9
        ' 
        Button9.BackColor = Color.FromArgb(CByte(59), CByte(59), CByte(59))
        Button9.FlatStyle = FlatStyle.Flat
        Button9.Font = New Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Button9.ForeColor = SystemColors.Window
        Button9.Location = New Point(615, 62)
        Button9.Name = "Button9"
        Button9.Size = New Size(391, 25)
        Button9.TabIndex = 53
        Button9.Text = "IMAGEM DO PRODUITO"
        Button9.TextAlign = ContentAlignment.MiddleLeft
        Button9.UseVisualStyleBackColor = False
        ' 
        ' ComboBox2
        ' 
        ComboBox2.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(613, 378)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(391, 33)
        ComboBox2.TabIndex = 54
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Segoe UI Semibold", 28F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox2.Location = New Point(12, 1)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(1391, 57)
        TextBox2.TabIndex = 55
        TextBox2.Text = "Venda Livre"
        TextBox2.TextAlign = HorizontalAlignment.Center
        ' 
        ' Button10
        ' 
        Button10.BackColor = Color.FromArgb(CByte(59), CByte(59), CByte(59))
        Button10.FlatStyle = FlatStyle.Flat
        Button10.Font = New Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Button10.ForeColor = SystemColors.Window
        Button10.Location = New Point(12, 622)
        Button10.Name = "Button10"
        Button10.Size = New Size(89, 55)
        Button10.TabIndex = 56
        Button10.Text = "NOVO"
        Button10.TextAlign = ContentAlignment.MiddleLeft
        Button10.UseVisualStyleBackColor = False
        ' 
        ' Button11
        ' 
        Button11.BackColor = Color.FromArgb(CByte(59), CByte(59), CByte(59))
        Button11.FlatStyle = FlatStyle.Flat
        Button11.Font = New Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Button11.ForeColor = SystemColors.Window
        Button11.Location = New Point(107, 622)
        Button11.Name = "Button11"
        Button11.Size = New Size(89, 55)
        Button11.TabIndex = 57
        Button11.Text = "SALVAR"
        Button11.TextAlign = ContentAlignment.MiddleLeft
        Button11.UseVisualStyleBackColor = False
        ' 
        ' Button12
        ' 
        Button12.BackColor = Color.FromArgb(CByte(59), CByte(59), CByte(59))
        Button12.FlatStyle = FlatStyle.Flat
        Button12.Font = New Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Button12.ForeColor = SystemColors.Window
        Button12.Location = New Point(202, 622)
        Button12.Name = "Button12"
        Button12.Size = New Size(89, 55)
        Button12.TabIndex = 58
        Button12.Text = "LIMPAR"
        Button12.TextAlign = ContentAlignment.MiddleLeft
        Button12.UseVisualStyleBackColor = False
        ' 
        ' Button13
        ' 
        Button13.BackColor = Color.FromArgb(CByte(59), CByte(59), CByte(59))
        Button13.FlatStyle = FlatStyle.Flat
        Button13.Font = New Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Button13.ForeColor = SystemColors.Window
        Button13.Location = New Point(297, 622)
        Button13.Name = "Button13"
        Button13.Size = New Size(89, 55)
        Button13.TabIndex = 59
        Button13.Text = "FECHAR"
        Button13.TextAlign = ContentAlignment.MiddleLeft
        Button13.UseVisualStyleBackColor = False
        ' 
        ' FrmPDV
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.GradientInactiveCaption
        ClientSize = New Size(1405, 697)
        Controls.Add(Button13)
        Controls.Add(Button12)
        Controls.Add(Button11)
        Controls.Add(Button10)
        Controls.Add(TextBox2)
        Controls.Add(TextBox7)
        Controls.Add(TextBox1)
        Controls.Add(ComboBox2)
        Controls.Add(ComboBox1)
        Controls.Add(Button1)
        Controls.Add(Label4)
        Controls.Add(DgProdutos)
        Controls.Add(Label3)
        Controls.Add(TextBox5)
        Controls.Add(TextBox4)
        Controls.Add(Button3)
        Controls.Add(TextBox3)
        Controls.Add(TextBox10)
        Controls.Add(Label2)
        Controls.Add(Button4)
        Controls.Add(Button6)
        Controls.Add(Label1)
        Controls.Add(Button8)
        Controls.Add(TextBox8)
        Controls.Add(Button2)
        Controls.Add(TextBox6)
        Controls.Add(PictureBox1)
        Controls.Add(Button9)
        Controls.Add(TextBox9)
        Controls.Add(Button7)
        Controls.Add(Button5)
        FormBorderStyle = FormBorderStyle.SizableToolWindow
        KeyPreview = True
        Name = "FrmPDV"
        StartPosition = FormStartPosition.CenterScreen
        Text = "PDV"
        WindowState = FormWindowState.Maximized
        CType(DgProdutos, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents DgProdutos As DataGridView
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents Button8 As Button
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents Button7 As Button
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents Button6 As Button
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Button5 As Button
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button9 As Button
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button10 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents Button12 As Button
    Friend WithEvents Button13 As Button
End Class
