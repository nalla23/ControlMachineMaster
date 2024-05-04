Imports System.Windows.Forms

Public Class Form1
    Private Async Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        ' Instanciar a classe MinhaClasse
        Dim minhaInstancia As New MinhaClasse()

        ' Chamar o método FazerChamadaOAuth2
        minhaInstancia.FazerChamadaOAuth2().Wait() ' Usando Wait() para bloquear o thread principal até a chamada ser concluída
    End Sub
End Class