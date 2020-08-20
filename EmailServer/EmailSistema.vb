Public Class EmailSistema
    Inherits EmailMaster

    Public Sub New()
        EnviarMail = "systemourtech@gmail.com"
        contraseña = "ourtech2020"
        host = "smtp.gmail.com"
        puerto = 587
        ssl = True
        IniciarSmtpCliente()
    End Sub

    Public Sub Notificaciones()

    End Sub

End Class
