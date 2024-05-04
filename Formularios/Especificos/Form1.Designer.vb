<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Button1 = New Button()
        Button2 = New Button()
        Label1 = New Label()
        Tclienteid = New TextBox()
        Tclientesecret = New TextBox()
        Label2 = New Label()
        Ttoken = New TextBox()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(240, 187)
        Button1.Name = "Button1"
        Button1.Size = New Size(186, 45)
        Button1.TabIndex = 0
        Button1.Text = "Button1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(29, 187)
        Button2.Name = "Button2"
        Button2.Size = New Size(186, 45)
        Button2.TabIndex = 1
        Button2.Text = "gerar token"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(29, 22)
        Label1.Name = "Label1"
        Label1.Size = New Size(60, 15)
        Label1.TabIndex = 2
        Label1.Text = "Cliente_ID"' 
        ' Tclienteid
        ' 
        Tclienteid.Location = New Point(29, 40)
        Tclienteid.Name = "Tclienteid"
        Tclienteid.Size = New Size(397, 23)
        Tclienteid.TabIndex = 3
        Tclienteid.Text = "b4c26229-d805-3b0e-9240-34ca863fb009"' 
        ' Tclientesecret
        ' 
        Tclientesecret.Location = New Point(29, 84)
        Tclientesecret.Name = "Tclientesecret"
        Tclientesecret.Size = New Size(397, 23)
        Tclientesecret.TabIndex = 5
        Tclientesecret.Text = "3df7a719-3ead-409b-a446-4bd44f24b3a2"' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(29, 66)
        Label2.Name = "Label2"
        Label2.Size = New Size(81, 15)
        Label2.TabIndex = 4
        Label2.Text = "Cliente_Secret"' 
        ' Ttoken
        ' 
        Ttoken.Location = New Point(29, 129)
        Ttoken.Name = "Ttoken"
        Ttoken.Size = New Size(397, 23)
        Ttoken.TabIndex = 7
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(29, 111)
        Label3.Name = "Label3"
        Label3.Size = New Size(38, 15)
        Label3.TabIndex = 6
        Label3.Text = "Token"' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(465, 244)
        Controls.Add(Ttoken)
        Controls.Add(Label3)
        Controls.Add(Tclientesecret)
        Controls.Add(Label2)
        Controls.Add(Tclienteid)
        Controls.Add(Label1)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Tclienteid As TextBox
    Friend WithEvents Tclientesecret As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Ttoken As TextBox
    Friend WithEvents Label3 As Label
End Class
