Imports Microsoft.Reporting.Map.WebForms.BingMaps
Imports Microsoft.Reporting.WinForms
Imports Microsoft.ReportingServices.Diagnostics.Internal
Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Tab

Public Class Frm_Relatorio_Equipamentos
    Private Sub Frm_Relatorio_Equipamentos_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        ReportViewer1.LocalReport.ReportEmbeddedResource = "ControlMachine.Relatorio_Equipamentos.rdlc"
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
                Dim sql = "SELECT ID_EQUIPAMENTO, EQUIPAMENTO, USUARIO,SENHA, EMAIL, OBS FROM EQUIPAMENTO"
                Using dap = New SqlDataAdapter(sql, cn)
                    Using dt = New DataTable()
                        dap.Fill(dt)
                        ReportViewer1.LocalReport.DataSources.Clear()
                        Dim Source = New ReportDataSource("DataSet1", dt)
                        Dim caminho_relatorio = Caminho
                        ReportViewer1.LocalReport.ReportPath = caminho_relatorio & ":\ControlMachine\Relatorios\RDLC\Relatorio_Equipamentos.rdlc"
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