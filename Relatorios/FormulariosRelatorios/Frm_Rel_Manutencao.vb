Imports Microsoft.Reporting.WinForms
Imports System.Data.SqlClient

Public Class Frm_Rel_Manutencao
    Private Sub Frm_Rel_Manutencao_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            Dim id As Integer
            id = FrmCadMaquinas.tidmaquina.Text
            Using cn = New SqlConnection(strcon)
                cn.Open()
                Dim sql = "SELECT E.ID_EQUIPAMENTO, e.equipamento, e.usuario,M.CODIGO,M.NOME,M.dtlan,M.RESPONSAVEL,M.VALOR
                             FROM equipamento E
                             INNER Join manutencao M ON M.ID_EQUIPAMENTO = E.ID_EQUIPAMENTO
                                and e.id_equipamento= " & id & "
                                 group by E.ID_EQUIPAMENTO, e.equipamento, e.usuario,M.CODIGO,M.NOME,M.dtlan,M.RESPONSAVEL,M.VALOR "
                Using dap = New SqlDataAdapter(sql, cn)
                    Using dt = New DataTable()
                        dap.Fill(dt)
                        ReportViewer1.LocalReport.DataSources.Clear()
                        Dim Source = New ReportDataSource("DataSet1", dt)
                        Dim source1 = New ReportDataSource("manutencao", dt)
                        Dim caminho_relatorio = Caminho
                        ReportViewer1.LocalReport.ReportPath = caminho_relatorio & ":\ControlMachine\Relatorios\RDLC\Rel_Listagem_Manutencao.rdlc"
                        ReportViewer1.LocalReport.DataSources.Add(Source)
                        ReportViewer1.LocalReport.DataSources.Add(source1)
                        ReportViewer1.RefreshReport()
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Ops... ocorreu um erro,favor verifique a conexão!#carregarelatório ", vbExclamation, "Aviso! ")
        End Try
    End Sub
End Class