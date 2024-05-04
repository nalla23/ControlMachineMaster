Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms

Public Class Frm_Rel_Agrupado_equipamento
    Private Sub FrmItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            Dim nome As String

            id = FrmCadMaquinas.tidmaquina.Text
            nome = FrmCadMaquinas.TNome.Text

            Using cn = New SqlConnection(strcon)
                cn.Open()
                Dim sql = "SELECT E.ID_EQUIPAMENTO, e.equipamento, e.usuario,I.ITEM,i.id_item,i.dtlan,i.OBS,CASE WHEN i.REALIZADO=1 THEN 'Sim' ELSE 'Não' END AS realizado
                            FROM equipamento E
                            INNER Join ITEM_EQUIPAMENTO I ON I.ID_EQUIPAMENTO = E.ID_EQUIPAMENTO
                            and e.id_equipamento=" & id & "
                            group by E.ID_EQUIPAMENTO, e.equipamento,I.ITEM,i.OBS,I.REALIZADO,e.usuario,i.id_item,i.dtlan "
                Using dap = New SqlDataAdapter(sql, cn)
                    Using dt = New DataTable()
                        dap.Fill(dt)
                        ReportViewer1.LocalReport.DataSources.Clear()
                        Dim Source = New ReportDataSource("DataSet1", dt)
                        Dim source1 = New ReportDataSource("DataSet2", dt)
                        Dim caminho_relatorio = Caminho
                        ReportViewer1.LocalReport.ReportPath = caminho_relatorio & ":\ControlMachine\Relatorios\RDLC\Rel_Agrupado_equipamento.rdlc"
                        ReportViewer1.LocalReport.DataSources.Add(Source)
                        ReportViewer1.LocalReport.DataSources.Add(source1)
                        ReportViewer1.RefreshReport()
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Ops... ocorreu um erro,favor verifique a conexão!#carregagrid ", vbExclamation, "Aviso! ")
        End Try
    End Sub

End Class