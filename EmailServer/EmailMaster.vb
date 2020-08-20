Imports System.Net
Imports System.Net.Mail
Public MustInherit Class EmailMaster

    Private smtpCliente As SmtpClient
    Protected EnviarMail As String
    Protected contraseña As String
    Protected host As String
    Protected puerto As Integer
    Protected ssl As Boolean

    Protected Sub IniciarSmtpCliente()
        smtpCliente = New SmtpClient()
        smtpCliente.Credentials = New NetworkCredential(EnviarMail, contraseña)
        smtpCliente.Host = host
        smtpCliente.Port = puerto
        smtpCliente.EnableSsl = ssl
    End Sub

    Public Sub EnviaMail(subject As String, body As String, RecibirMail As List(Of String))
        Dim MensajeMail As New MailMessage()
        Try
            MensajeMail.From = New MailAddress(EnviarMail)
            For Each ContenidoMail As String In RecibirMail
                MensajeMail.To.Add(ContenidoMail)
            Next
            MensajeMail.Subject = subject
            MensajeMail.Body = body
            MensajeMail.Priority = MailPriority.Normal

            smtpCliente.Send(MensajeMail)

        Catch ex As Exception
        Finally
            MensajeMail.Dispose()
            smtpCliente.Dispose()
        End Try
    End Sub
End Class
