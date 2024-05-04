<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Rel_Agrupado_equipamento
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
        ReportViewer1.AllowDrop = True
        ReportViewer1.AutoScroll = True
        ReportViewer1.AutoSize = True
        ReportViewer1.AutoSizeMode = AutoSizeMode.GrowAndShrink
        ReportViewer1.BackgroundImageLayout = ImageLayout.Center
        ReportViewer1.BorderStyle = BorderStyle.None
        ReportViewer1.Dock = DockStyle.Fill
        ReportViewer1.DocumentMapCollapsed = True
        ReportViewer1.Location = New Point(0, 0)
        ReportViewer1.Name = "ReportViewer"
        ReportViewer1.ServerReport.BearerToken = Nothing
        ReportViewer1.Size = New Size(667, 480)
        ReportViewer1.TabIndex = 0
        ' 
        ' Frm_Rel_Agrupado_equipamento
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(667, 480)
        Controls.Add(ReportViewer1)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "Frm_Rel_Agrupado_equipamento"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Check-list equipamento"
        WindowState = FormWindowState.Maximized
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
End Class
