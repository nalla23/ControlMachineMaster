Imports Microsoft.Reporting.WinForms
Imports System.Data.SqlClient

Public Class Frm_Rel_Detalhado_Servidor
    Private Sub Frm_Rel_Detalhado_Servidor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gerarrelatorio()
    End Sub
    Sub gerarrelatorio()
        Dim id = Frm_Servidores.TCodigo.Text
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
                Dim sql = "SELECT S.NOME, U.NOME, U.SENHA,U.ID_SERVIDOR,S.IP,u.id_usuario
                            FROM  SERVIDORES_USUARIOS U
                            INNER JOIN SERVIDORES S ON S.ID_SERVIDOR = U.ID_SERVIDOR
                            WHERE u.ID_servidor= " & id & "
                            GROUP BY S.NOME, U.NOME, U.SENHA,U.ID_SERVIDOR,S.IP,u.id_usuario"
                Using dap = New SqlDataAdapter(sql, cn)
                    Using dt = New DataTable()
                        dap.Fill(dt)
                        ReportViewer1.LocalReport.DataSources.Clear()
                        Dim Source = New ReportDataSource("Srv", dt)
                        Dim Source1 = New ReportDataSource("User", dt)
                        Dim caminho_relatorio = Caminho
                        ReportViewer1.LocalReport.ReportPath = caminho_relatorio & ":\ControlMachine\Relatorios\RDLC\Rel_Detalhado_Servidor.rdlc"
                        ReportViewer1.LocalReport.DataSources.Add(Source)
                        ReportViewer1.LocalReport.DataSources.Add(Source1)
                        ReportViewer1.RefreshReport()
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Ops... ocorreu um erro,favor verifique a conexão!#carregarelatório ", vbExclamation, "Aviso! ")
        End Try
    End Sub
End Class