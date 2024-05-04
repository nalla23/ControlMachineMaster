Imports Microsoft.Reporting.WinForms
Imports System.Data.SqlClient

Public Class Frm_Relatorio_comp
    Private Sub Frm_relatorio_inicial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReportViewer1.LocalReport.ReportEmbeddedResource = "ControlMachine.Rel_Completo_equipamentos.rdlc"
        ReportViewer1.RefreshReport()
        buscarelatorio()
    End Sub
    Sub buscarelatorio()
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
                Dim sql = "SELECT id_equipamento, equipamento, usuario,senha,processador,memoria,hd1,hd2,windows,modelo FROM EQUIPAMENTO "
                Using dap = New SqlDataAdapter(sql, cn)
                    Using dt = New DataTable()
                        dap.Fill(dt)
                        ReportViewer1.LocalReport.DataSources.Clear()
                        Dim Source = New ReportDataSource("DataSet1", dt)
                        Dim caminho_relatorio = Caminho
                        ReportViewer1.LocalReport.ReportPath = caminho_relatorio & ":\ControlMachine\Relatorios\RDLC\Rel_Completo_equipamentos.rdlc"
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