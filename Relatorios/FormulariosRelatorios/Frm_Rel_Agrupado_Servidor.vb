Imports Microsoft.Reporting.WinForms
Imports System.Data.SqlClient

Public Class Frm_Rel_Agrupado_Servidor
    Private Sub Frm_Rel_Agrupado_Servidor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
                Dim sql = "SELECT ID_USUARIO,NOME,SENHA, NOME_SERVIDOR FROM  SERVIDORES_USUARIOS GROUP BY ID_USUARIO,NOME,SENHA, NOME_SERVIDOR"
                Using dap = New SqlDataAdapter(sql, cn)
                    Using dt = New DataTable()
                        dap.Fill(dt)
                        ReportViewer1.LocalReport.DataSources.Clear()
                        Dim Source = New ReportDataSource("DataSet1", dt)
                        Dim caminho_relatorio = Caminho
                        ReportViewer1.LocalReport.ReportPath = caminho_relatorio & ":\ControlMachine\Relatorios\RDLC\Rel_Agrupado_Servidor.rdlc"
                        ReportViewer1.LocalReport.DataSources.Add(Source)
                        ReportViewer1.RefreshReport()
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Ops... ocorreu um erro,favor verifique a conexão!#carregarelatório ", vbExclamation, "Aviso! ")
        End Try
    End Sub
End Class