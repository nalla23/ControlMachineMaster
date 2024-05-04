<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Rel_Detalhado_Servidor
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
        ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        SuspendLayout()
        ' 
        ' ReportViewer1
        ' 
        ReportViewer1.AutoSize = True
        ReportViewer1.AutoSizeMode = AutoSizeMode.GrowAndShrink
        ReportViewer1.Dock = DockStyle.Fill
        ReportViewer1.Location = New Point(0, 0)
        ReportViewer1.Name = "ReportViewer"
        ReportViewer1.ServerReport.BearerToken = Nothing
        ReportViewer1.Size = New Size(800, 450)
        ReportViewer1.TabIndex = 0
        ' 
        ' Frm_Rel_Detalhado_Servidor
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(ReportViewer1)
        Name = "Frm_Rel_Detalhado_Servidor"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Detalhado Servidor"
        WindowState = FormWindowState.Maximized
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
End Class
