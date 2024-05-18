Imports ControlMachine.ControlMachine
Imports System.Data.SqlClient

Public Class FrmConsultaCliente
    Private Sub BtCadastro_Click(sender As Object, e As EventArgs) Handles BtCadastro.Click
        Frm_Cliente.ShowDialog()
    End Sub
    Private Sub BtFechar_Click(sender As Object, e As EventArgs) Handles BtFechar.Click
        Close()
    End Sub

    Private Sub FrmConsultaCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carregagridcliente()
    End Sub
    Private Sub carregagridcliente()
        Try

            Using cn = New SqlConnection(strcon)
                cn.Open()
                Dim sql = "select p.id_pessoa,p.codigo,p.nome, p.APELIDO, p.documento, p.RG,c.nome,c.uf,p.ENDERECO,p.numero, p.bairro, p.fone
                            from pessoas p
                            inner join
                            cidades c on c.id_cidade = p.id_cidade
                            where (PATINDEX('%" & TPesquisa.Text & "%',p.nome)>0)   or (PATINDEX('%" & TPesquisa.Text & "%',p.documento)>0) 
                            order by p.nome"
                '(PATINDEX('%" & txtpesquisa.Text & "%',a.nome)>0)
                Using dap = New SqlDataAdapter(sql, cn)
                    Using dt = New DataTable()
                        dap.Fill(dt)
                        DgCliente.DataSource = dt
                        With DgCliente 'with significa com e substitui variavel a frente dele
                            .Columns(0).Width = 80
                            .Columns(0).HeaderText = "A"
                            ' .Columns(0).Visible = False
                            .Columns(1).Width = 460
                            .Columns(1).HeaderText = "AW"
                            .Columns(2).Width = 80
                            .Columns(3).Width = 460
                            .Columns(4).Width = 80
                            .Columns(5).Width = 460
                            .Columns(6).Width = 80
                            .Columns(7).Width = 460
                            .Columns(8).Width = 80
                            .Columns(9).Width = 460
                            .Columns(10).Width = 80
                            .Columns(11).Width = 460

                        End With
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Ops... ocorreu um erro,favor verifique a conexão! ", vbExclamation, "Aviso! ")
        End Try
        TPesquisa.Text = ""
    End Sub

    Private Sub BtPesquisa_Click(sender As Object, e As EventArgs) Handles BtPesquisa.Click
        carregagridcliente()
    End Sub

    Private Sub BtSeleciona_Click(sender As Object, e As EventArgs) Handles BtSeleciona.Click

        Frm_Cliente.ShowDialog()
        Label2.Text = campo(0)
    End Sub

    Private Sub DgCliente_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgCliente.CellContentClick

    End Sub

    Private Sub DgCliente_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DgCliente.CellEnter
        With DgCliente.Rows(DgCliente.CurrentCell.RowIndex)
            campo(0) = .Cells("id_pessoa").Value
        End With
    End Sub
End Class