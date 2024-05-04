Imports System.Data.SqlClient

Public Class FrmPDV
    Private Sub FrmPDV_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CarregaGridProdutos()

    End Sub
    Sub CarregaGridProdutos()

        Try
            Using cn = New SqlConnection(strcon)
                cn.Open()
                Dim sql = "SELECT ID_SERVIDOR Código,NOME Nome,IP,ATIVO Ativo FROM SERVIDORES"
                Using dap = New SqlDataAdapter(sql, cn)
                    Using dt = New DataTable()
                        dap.Fill(dt)
                        DgProdutos.DataSource = dt
                        With DgProdutos 'with significa com e substitui variavel a frente dele
                            .Columns(0).Width = 60
                            .Columns(1).Width = 100
                            .Columns(2).Width = 80
                            .Columns(3).Width = 80
                            For Each row As DataGridViewRow In .Rows
                                If row.Cells(3).Value = 0 Then
                                    row.Cells(3).Style.ForeColor = Color.Red
                                    row.DefaultCellStyle.ForeColor = Color.Red
                                End If
                            Next

                        End With
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Ops... ocorreu um erro,favor verifique a conexão!#carregagrid ", vbExclamation, "Aviso! ")
        End Try
    End Sub
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        CarregaGridProdutos()

    End Sub
End Class