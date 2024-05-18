<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConsultaCliente
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
        BtSeleciona = New Button()
        Label1 = New Label()
        TPesquisa = New TextBox()
        Gpesquisa = New GroupBox()
        BtPesquisa = New Button()
        DgCliente = New DataGridView()
        GDados = New GroupBox()
        BtCadastro = New Button()
        BtFechar = New Button()
        Label2 = New Label()
        Gpesquisa.SuspendLayout()
        CType(DgCliente, ComponentModel.ISupportInitialize).BeginInit()
        GDados.SuspendLayout()
        SuspendLayout()
        ' 
        ' BtSeleciona
        ' 
        BtSeleciona.Location = New Point(16, 505)
        BtSeleciona.Name = "BtSeleciona"
        BtSeleciona.Size = New Size(90, 35)
        BtSeleciona.TabIndex = 0
        BtSeleciona.Text = "Seleciona"
        BtSeleciona.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(6, 425)
        Label1.Name = "Label1"
        Label1.Size = New Size(128, 15)
        Label1.TabIndex = 1
        Label1.Text = "Quantidade de registro"' 
        ' TPesquisa
        ' 
        TPesquisa.CharacterCasing = CharacterCasing.Upper
        TPesquisa.Location = New Point(6, 22)
        TPesquisa.MaxLength = 250
        TPesquisa.Name = "TPesquisa"
        TPesquisa.PlaceholderText = "Digite o que está procurando"
        TPesquisa.Size = New Size(832, 23)
        TPesquisa.TabIndex = 1
        ' 
        ' Gpesquisa
        ' 
        Gpesquisa.Controls.Add(BtPesquisa)
        Gpesquisa.Controls.Add(TPesquisa)
        Gpesquisa.Location = New Point(10, 0)
        Gpesquisa.Margin = New Padding(1)
        Gpesquisa.Name = "Gpesquisa"
        Gpesquisa.Size = New Size(954, 52)
        Gpesquisa.TabIndex = 3
        Gpesquisa.TabStop = False
        Gpesquisa.Text = "Pesquisa"' 
        ' BtPesquisa
        ' 
        BtPesquisa.Location = New Point(844, 21)
        BtPesquisa.Name = "BtPesquisa"
        BtPesquisa.Size = New Size(104, 23)
        BtPesquisa.TabIndex = 3
        BtPesquisa.Text = "Pesquisa"
        BtPesquisa.UseVisualStyleBackColor = True
        ' 
        ' DgCliente
        ' 
        DgCliente.AllowUserToAddRows = False
        DgCliente.AllowUserToDeleteRows = False
        DgCliente.AllowUserToResizeRows = False
        DgCliente.BackgroundColor = SystemColors.Window
        DgCliente.BorderStyle = BorderStyle.Fixed3D
        DgCliente.CellBorderStyle = DataGridViewCellBorderStyle.None
        DgCliente.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DgCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DgCliente.EditMode = DataGridViewEditMode.EditOnEnter
        DgCliente.Location = New Point(6, 22)
        DgCliente.MultiSelect = False
        DgCliente.Name = "DgCliente"
        DgCliente.ReadOnly = True
        DgCliente.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DgCliente.RowHeadersVisible = False
        DgCliente.RowTemplate.Height = 25
        DgCliente.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DgCliente.Size = New Size(942, 400)
        DgCliente.TabIndex = 4
        ' 
        ' GDados
        ' 
        GDados.Controls.Add(DgCliente)
        GDados.Controls.Add(Label1)
        GDados.Location = New Point(10, 56)
        GDados.Name = "GDados"
        GDados.Size = New Size(954, 443)
        GDados.TabIndex = 5
        GDados.TabStop = False
        GDados.Text = "Dados pesquisa"' 
        ' BtCadastro
        ' 
        BtCadastro.Location = New Point(112, 505)
        BtCadastro.Name = "BtCadastro"
        BtCadastro.Size = New Size(90, 35)
        BtCadastro.TabIndex = 6
        BtCadastro.Text = "Cadastro"
        BtCadastro.UseVisualStyleBackColor = True
        ' 
        ' BtFechar
        ' 
        BtFechar.Location = New Point(208, 505)
        BtFechar.Name = "BtFechar"
        BtFechar.Size = New Size(90, 35)
        BtFechar.TabIndex = 7
        BtFechar.Text = "Fechar"
        BtFechar.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(538, 515)
        Label2.Name = "Label2"
        Label2.Size = New Size(128, 15)
        Label2.TabIndex = 5
        Label2.Text = "Quantidade de registro"' 
        ' FrmConsultaCliente
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(976, 552)
        Controls.Add(Label2)
        Controls.Add(BtFechar)
        Controls.Add(BtCadastro)
        Controls.Add(GDados)
        Controls.Add(Gpesquisa)
        Controls.Add(BtSeleciona)
        FormBorderStyle = FormBorderStyle.SizableToolWindow
        Name = "FrmConsultaCliente"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Consulta Cliente"
        Gpesquisa.ResumeLayout(False)
        Gpesquisa.PerformLayout()
        CType(DgCliente, ComponentModel.ISupportInitialize).EndInit()
        GDados.ResumeLayout(False)
        GDados.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BtSeleciona As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TPesquisa As TextBox
    Friend WithEvents Gpesquisa As GroupBox
    Friend WithEvents DgCliente As DataGridView
    Friend WithEvents BtPesquisa As Button
    Friend WithEvents GDados As GroupBox
    Friend WithEvents BtCadastro As Button
    Friend WithEvents BtFechar As Button
    Friend WithEvents Label2 As Label
End Class
