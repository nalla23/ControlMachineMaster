Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms

Public Class Frm_Rel_Formulario_Branco
    Private Sub Frm_Rel_Formulario_Branco_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Gerarelatorio()
    End Sub
    ' Private Sub GeraRelatorio()
    ' Dim caminho_relatorio = Caminho
    '     ReportViewer1.LocalReport.ReportPath = caminho_relatorio & ":\ControlMachine\Relatorios\RDLC\Rel_Formulario_Branco.rdlc"
    '     ReportViewer1.RefreshReport()
    'End Sub
    Sub Gerarelatorio()

        Try
            ' Substitua 'ReportViewer1' pelo nome do seu controle ReportViewer.
            Dim reportViewer As ReportViewer = ReportViewer1
            ' Defina o modo de exibição como Layout de Impressão.
            reportViewer.SetDisplayMode(DisplayMode.PrintLayout)
            ' Ajuste o zoom para 100%.
            reportViewer.ZoomMode = ZoomMode.Percent
            reportViewer.ZoomPercent = 100
            Using cn = New SqlConnection(strcon)
                cn.Open()
                Dim sql = "SELECT * FROM EMAIL_ITEM  WHERE TIPO = 'ITEM'"
                Using dap = New SqlDataAdapter(sql, cn)
                    Using dt = New DataTable()
                        dap.Fill(dt)
                        ReportViewer1.LocalReport.DataSources.Clear()
                        Dim Source = New ReportDataSource("DataSet1", dt)
                        Dim caminho_relatorio = Caminho
                        ReportViewer1.LocalReport.ReportPath = caminho_relatorio & ":\ControlMachine\Relatorios\RDLC\Rel_Formulario_Branco.rdlc"
                        ReportViewer1.LocalReport.DataSources.Add(Source)
                        ReportViewer1.RefreshReport()
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Ops... ocorreu um erro,favor verifique a conexão!#carregagrid ", vbExclamation, "Aviso! ")
        End Try
    End Sub
End Class