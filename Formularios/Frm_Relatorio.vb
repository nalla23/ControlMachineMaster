Imports System.Runtime.Intrinsics

Public Class Frm_Relatorio
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Using frm = New Frm_Relatorio_Equipamentos()
            frm.ShowDialog()
        End Using
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Frm_Relatorio_comp.ShowDialog()
    End Sub

    Private Sub BtAgrup_email_Click(sender As Object, e As EventArgs) Handles BtAgrup_email.Click
        Frm_Rel_Agrupado_Email.ShowDialog()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Frm_Rel_Formulario_Branco.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Frm_Rel_Agrupado_Conta_AntiVirus.ShowDialog()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Frm_Rel_ListagemEmail_Item.ShowDialog()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Frm_Rel_Listagem_Equipamento_Config.ShowDialog()
    End Sub
End Class