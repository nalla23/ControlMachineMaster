Imports System.Net.Mail
Public Class Frm_EnviarEmail
    Private Sub Frm_EnviarEmail_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub EnviarEmail()
        Try
            Using smtp As New SmtpClient
                Using email As New MailMessage
                    'servidor SMTP
                    smtp.Host = "smtp.gmail.com"
                    smtp.UseDefaultCredentials = False
                    smtp.Credentials = New Net.NetworkCredential("allanzinhopc@gmail.com", "simsbmvteapgtbhg")
                    smtp.Port = 587
                    smtp.EnableSsl = True
                    'email(mansagem)
                    email.From = New MailAddress(Tremetente.Text)
                    email.To.Add(TDestinatario.Text)
                    email.Subject = TAssunto.Text
                    email.IsBodyHtml = True
                    email.Body = TMensagem.Text
                    'enviar emaill
                    smtp.Send(email)
                End Using
            End Using
            MsgBox("Email enviado com sucesso!")
        Catch ex As Exception
            MsgBox("Erro:" & ex.Message)
        End Try
    End Sub

    Private Sub BtEnviar_Click(sender As Object, e As EventArgs) Handles BtEnviar.Click
        EnviarEmail()
    End Sub

    Private Sub EnviarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnviarToolStripMenuItem.Click
        EnviarEmail()
    End Sub
End Class