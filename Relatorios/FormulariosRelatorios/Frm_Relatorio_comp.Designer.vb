﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Relatorio_comp
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
        ReportViewer1.Dock = DockStyle.Fill
        ReportViewer1.Location = New Point(0, 0)
        ReportViewer1.Name = "ReportViewer1"
        ReportViewer1.ServerReport.BearerToken = Nothing
        ReportViewer1.Size = New Size(800, 450)
        ReportViewer1.TabIndex = 0
        ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth
        ' 
        ' Frm_Relatorio_comp
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(ReportViewer1)
        Name = "Frm_Relatorio_comp"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Relatório de configuração de equipamento."
        WindowState = FormWindowState.Maximized
        ResumeLayout(False)
    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
End Class
