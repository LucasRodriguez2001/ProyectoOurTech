Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
Public MustInherit Class Conexion
    Private Conection As String
    Protected Sub New()
        Conection = "server = 127.0.0.1; database = proyecto; Uid = root; pwd =;"
    End Sub
    Protected Function Conex() As MySqlConnection
        Return New MySqlConnection(Conection)
    End Function
End Class
