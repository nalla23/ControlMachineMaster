<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmExcel
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(FrmExcel))
        Panel1 = New Panel()
        DG1 = New DataGridView()
        Panel3 = New Panel()
        Label1 = New Label()
        Panel2 = New Panel()
        LbContaLinhas = New Label()
        Button1 = New Button()
        Tcaminho = New TextBox()
        BtAbrir = New Button()
        BtSalvar = New Button()
        Panel1.SuspendLayout()
        CType(DG1, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(41), CByte(56), CByte(89))
        Panel1.Controls.Add(DG1)
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(Panel2)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(988, 749)
        Panel1.TabIndex = 2
        ' 
        ' DG1
        ' 
        DG1.AllowUserToAddRows = False
        DG1.AllowUserToDeleteRows = False
        DG1.AllowUserToOrderColumns = True
        DG1.BackgroundColor = Color.FromArgb(CByte(51), CByte(51), CByte(76))
        DG1.BorderStyle = BorderStyle.Fixed3D
        DG1.CellBorderStyle = DataGridViewCellBorderStyle.None
        DG1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DG1.Dock = DockStyle.Fill
        DG1.Location = New Point(0, 37)
        DG1.Name = "DG1"
        DG1.ReadOnly = True
        DG1.RowHeadersVisible = False
        DG1.RowTemplate.Height = 25
        DG1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DG1.ShowCellErrors = False
        DG1.ShowCellToolTips = False
        DG1.ShowEditingIcon = False
        DG1.ShowRowErrors = False
        DG1.Size = New Size(988, 593)
        DG1.TabIndex = 62
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(Label1)
        Panel3.Dock = DockStyle.Top
        Panel3.Location = New Point(0, 0)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(988, 37)
        Panel3.TabIndex = 65
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Dock = DockStyle.Left
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.Window
        Label1.Location = New Point(0, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(328, 32)
        Label1.TabIndex = 64
        Label1.Text = "Leitura de planilha do Excel"' 
        ' Panel2
        ' 
        Panel2.Controls.Add(LbContaLinhas)
        Panel2.Controls.Add(Button1)
        Panel2.Controls.Add(Tcaminho)
        Panel2.Controls.Add(BtAbrir)
        Panel2.Controls.Add(BtSalvar)
        Panel2.Dock = DockStyle.Bottom
        Panel2.Location = New Point(0, 630)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(988, 119)
        Panel2.TabIndex = 63
        ' 
        ' LbContaLinhas
        ' 
        LbContaLinhas.AutoSize = True
        LbContaLinhas.Dock = DockStyle.Right
        LbContaLinhas.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        LbContaLinhas.ForeColor = SystemColors.Window
        LbContaLinhas.Location = New Point(856, 0)
        LbContaLinhas.Name = "LbContaLinhas"
        LbContaLinhas.Size = New Size(132, 17)
        LbContaLinhas.TabIndex = 8
        LbContaLinhas.Text = "Quantidade de linhas"' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(21), CByte(86), CByte(99))
        Button1.BackgroundImageLayout = ImageLayout.Stretch
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Image = CType(resources.GetObject("Button1.Image"), Image)
        Button1.Location = New Point(340, 14)
        Button1.Name = "Button1"
        Button1.Size = New Size(40, 23)
        Button1.TabIndex = 7
        Button1.TextAlign = ContentAlignment.BottomRight
        Button1.TextImageRelation = TextImageRelation.ImageBeforeText
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Tcaminho
        ' 
        Tcaminho.Location = New Point(14, 14)
        Tcaminho.Name = "Tcaminho"
        Tcaminho.Size = New Size(320, 23)
        Tcaminho.TabIndex = 6
        ' 
        ' BtAbrir
        ' 
        BtAbrir.BackColor = Color.FromArgb(CByte(21), CByte(86), CByte(99))
        BtAbrir.BackgroundImageLayout = ImageLayout.None
        BtAbrir.FlatAppearance.BorderColor = Color.FromArgb(CByte(21), CByte(86), CByte(99))
        BtAbrir.FlatAppearance.BorderSize = 0
        BtAbrir.FlatStyle = FlatStyle.Flat
        BtAbrir.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        BtAbrir.ForeColor = SystemColors.Window
        BtAbrir.Image = CType(resources.GetObject("BtAbrir.Image"), Image)
        BtAbrir.ImageAlign = ContentAlignment.MiddleLeft
        BtAbrir.Location = New Point(12, 53)
        BtAbrir.Name = "BtAbrir"
        BtAbrir.Size = New Size(181, 54)
        BtAbrir.TabIndex = 4
        BtAbrir.Text = "Abrir Planilha"
        BtAbrir.UseVisualStyleBackColor = False
        ' 
        ' BtSalvar
        ' 
        BtSalvar.BackColor = Color.FromArgb(CByte(21), CByte(86), CByte(99))
        BtSalvar.BackgroundImageLayout = ImageLayout.None
        BtSalvar.FlatAppearance.BorderColor = Color.FromArgb(CByte(21), CByte(86), CByte(99))
        BtSalvar.FlatAppearance.BorderSize = 0
        BtSalvar.FlatStyle = FlatStyle.Flat
        BtSalvar.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        BtSalvar.ForeColor = SystemColors.Window
        BtSalvar.Image = CType(resources.GetObject("BtSalvar.Image"), Image)
        BtSalvar.ImageAlign = ContentAlignment.MiddleLeft
        BtSalvar.Location = New Point(199, 53)
        BtSalvar.Name = "BtSalvar"
        BtSalvar.Size = New Size(181, 54)
        BtSalvar.TabIndex = 5
        BtSalvar.Text = "Salvar"
        BtSalvar.UseVisualStyleBackColor = False
        ' 
        ' FrmExcel
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(988, 749)
        Controls.Add(Panel1)
        Name = "FrmExcel"
        StartPosition = FormStartPosition.CenterScreen
        WindowState = FormWindowState.Maximized
        Panel1.ResumeLayout(False)
        CType(DG1, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtAbrir As Button
    Friend WithEvents BtSalvar As Button
    Friend WithEvents DG1 As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Tcaminho As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents LbContaLinhas As Label
End Class
