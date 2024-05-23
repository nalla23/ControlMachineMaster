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
        FrmFormulario.ContarLinhasGrid(DgCliente, Lbcontalinhas)
    End Sub
    Private Sub carregagridcliente()
        Try

            Using cn = New SqlConnection(strcon)
                cn.Open()
                Dim sql = "select p.id_pessoa,p.codigo,p.nome, p.APELIDO, p.documento, p.RG,c.nome,c.uf,p.ENDERECO,p.numero, p.bairro, p.fone
                            from pessoas p
                            inner join
                            cidades c on c.id_cidade = p.id_cidade
                            where (PATINDEX('%" & TPesquisa.Text & "%',p.nome)>0)   or (PATINDEX('%" & TPesquisa.Text & "%',p.documento)>0) or  (PATINDEX('%" & TPesquisa.Text & "%',p.apelido)>0)
                            order by p.nome"
                '(PATINDEX('%" & txtpesquisa.Text & "%',a.nome)>0)
                Using dap = New SqlDataAdapter(sql, cn)
                    Using dt = New DataTable()
                        dap.Fill(dt)
                        DgCliente.DataSource = dt
                        With DgCliente 'with significa com e substitui variavel a frente dele
                            .Columns(0).HeaderText = "ID_CLIENTE"
                            .Columns(0).Width = 80
                            .Columns(0).Visible = False
                            .Columns(1).HeaderText = "Código"
                            .Columns(1).Width = 60
                            .Columns(2).HeaderText = "Nome\Razão"
                            .Columns(2).Width = 250
                            .Columns(3).HeaderText = "Apelido\Fantasia"
                            .Columns(3).Width = 200
                            .Columns(4).HeaderText = "Documento"
                            .Columns(4).Width = 120
                            .Columns(5).HeaderText = "Registro"
                            .Columns(5).Width = 80
                            .Columns(6).HeaderText = "Cidade"
                            .Columns(6).Width = 120
                            .Columns(7).HeaderText = "UF"
                            .Columns(7).Width = 30
                            .Columns(8).HeaderText = "Endereço"
                            .Columns(8).Width = 150
                            .Columns(9).HeaderText = "Número"
                            .Columns(9).Width = 80
                            .Columns(10).HeaderText = "Bairro"
                            .Columns(10).Width = 100
                            .Columns(11).HeaderText = "Telefone"
                            .Columns(11).Width = 80


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
    End Sub

    Private Sub DgCliente_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgCliente.CellContentClick

    End Sub

    Private Sub DgCliente_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DgCliente.CellEnter
        With DgCliente.Rows(DgCliente.CurrentCell.RowIndex)
            campo(0) = .Cells("id_pessoa").Value
        End With
    End Sub
    Private Sub TPesquisa_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TPesquisa.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            SendKeys.Send("{TAB}")
            carregagridcliente()
        End If
    End Sub
End Class