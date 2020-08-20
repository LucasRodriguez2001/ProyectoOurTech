Imports System.Data
Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Windows.Forms
Public Class Mecanicas
    Inherits Conexion

    Public Function RecuperarContraseña(recuperaruser As String) As String
        Using con = Conex()
            con.Open()
            Using command = New MySqlCommand()
                command.Connection = con
                command.CommandText = "Select * from usuario where cedula = @cedula or mail = @mail"
                command.Parameters.AddWithValue("@cedula", recuperaruser)
                command.Parameters.AddWithValue("@mail", recuperaruser)
                command.CommandType = CommandType.Text

                Dim reader As MySqlDataReader = command.ExecuteReader()
                If reader.Read() = True Then
                    Dim Nombre = reader.GetString(1) & ", " & reader.GetString(2)
                    Dim Mail = reader.GetString(3)
                    Dim Contraseña = reader.GetString(4)
                    Dim Cedula = reader.GetString(0)


                    Dim EnviaMail As New EmailSistema()

                    EnviaMail.EnviaMail(subject:="Sistema: Solicitud de restauracion de contraseña",
                                        body:="Hola " & Nombre & vbNewLine & "Usted solicito una restauracion de contraseña." & vbNewLine &
                                        "Tu contraseña actual es: " & Contraseña,
                                        RecibirMail:=New List(Of String) From {Mail})
                    Return "Hola " & Nombre & vbNewLine & "tu solicitaste una restauracion de contraseña." & vbNewLine &
                                        "Porfavor revisa tu correo electronico: " & Mail & vbNewLine &
                                        "Se le recomienda cambiar la contraseña la proxima vez que entre al sistema."
                Else
                    Return "Lo sentimos, no tiene una cuenta con esta cedula o correo electronico."

                End If
            End Using
        End Using
    End Function

    Public Function Login(cedula As String, contraseña As String) As Boolean
        Using con = Conex()
            con.Open()
            Using command = New MySqlCommand()
                command.Connection = con
                command.CommandText = "Select * from usuario where cedula = @cedula and contrasenia = @contrasenia"
                command.Parameters.AddWithValue("@cedula", cedula)
                command.Parameters.AddWithValue("@contrasenia", contraseña)
                command.CommandType = CommandType.Text
                Dim reader = command.ExecuteReader()
                If reader.HasRows Then
                    While reader.Read()
                        DatosUser.Nombre = reader.GetString(1)
                        DatosUser.Apellido = reader.GetString(2)
                        DatosUser.Cedula = reader.GetString(0)
                        DatosUser.Mail = reader.GetString(3)
                    End While
                    reader.Dispose()
                    Return True
                Else
                    Return False
                End If
            End Using
        End Using
    End Function

    Public Function SintomasTronco() As String()
        Dim myConnection = New MySqlConnection("server = 127.0.0.1; database = proyecto; Uid = root; pwd =;")
        Try
            myConnection.Open()

            Dim myCMD As MySqlCommand = New MySqlCommand("SELECT * FROM sintoma where region = 'Tronco'", myConnection)
            Dim myReader As MySqlDataReader = myCMD.ExecuteReader()
            Dim fileName As String = "C:\Users\RaiseCool\Desktop\Textos\Tronco.txt"
            Dim outputStream As StreamWriter = New StreamWriter(fileName)

            Do While myReader.Read
                Dim valor(myReader.FieldCount - 1) As Object
                myReader.GetValues(valor)

                Dim line As String = String.Join(",", valor)
                outputStream.WriteLine(line)
            Loop
            myReader.Close()
            outputStream.Close()
            myConnection.Close()
        Catch ex As Exception
        End Try
#Disable Warning BC42105 ' La función no devuelve un valor en todas las rutas de código
    End Function
#Enable Warning BC42105 ' La función no devuelve un valor en todas las rutas de código

    Public Function SintomasCabeza() As String()
        Dim myConnection = New MySqlConnection("server = 127.0.0.1; database = proyecto; Uid = root; pwd =;")
        Try
            myConnection.Open()

            Dim myCMD As MySqlCommand = New MySqlCommand("SELECT * FROM sintoma where region = 'Cabeza'", myConnection)
            Dim myReader As MySqlDataReader = myCMD.ExecuteReader()
            Dim fileName As String = "C:\Users\RaiseCool\Desktop\Textos\Cabeza.txt"
            Dim outputStream As StreamWriter = New StreamWriter(fileName)

            Do While myReader.Read
                Dim valor(myReader.FieldCount - 1) As Object
                myReader.GetValues(valor)

                Dim line As String = String.Join(",", valor)
                outputStream.WriteLine(line)
            Loop
            myReader.Close()
            outputStream.Close()
            myConnection.Close()
        Catch ex As Exception
        End Try
#Disable Warning BC42105 ' La función no devuelve un valor en todas las rutas de código
    End Function
#Enable Warning BC42105 ' La función no devuelve un valor en todas las rutas de código

    Public Function SintomasCuello() As String()
        Dim myConnection = New MySqlConnection("server = 127.0.0.1; database = proyecto; Uid = root; pwd =;")
        Try
            myConnection.Open()

            Dim myCMD As MySqlCommand = New MySqlCommand("SELECT * FROM sintoma where region = 'Cuello'", myConnection)
            Dim myReader As MySqlDataReader = myCMD.ExecuteReader()
            Dim fileName As String = "C:\Users\RaiseCool\Desktop\Textos\Cuello.txt"
            Dim outputStream As StreamWriter = New StreamWriter(fileName)

            Do While myReader.Read
                Dim valor(myReader.FieldCount - 1) As Object
                myReader.GetValues(valor)

                Dim line As String = String.Join(",", valor)
                outputStream.WriteLine(line)
            Loop
            myReader.Close()
            outputStream.Close()
            myConnection.Close()
        Catch ex As Exception
        End Try
#Disable Warning BC42105 ' La función no devuelve un valor en todas las rutas de código
    End Function
#Enable Warning BC42105 ' La función no devuelve un valor en todas las rutas de código

    Public Function SintomasMSuperiores() As String()
        Dim myConnection = New MySqlConnection("server = 127.0.0.1; database = proyecto; Uid = root; pwd =;")
        Try
            myConnection.Open()

            Dim myCMD As MySqlCommand = New MySqlCommand("SELECT * FROM sintoma where region = 'Miembros Superiores'", myConnection)
            Dim myReader As MySqlDataReader = myCMD.ExecuteReader()
            Dim fileName As String = "C:\Users\RaiseCool\Desktop\Textos\MiembrosSuperiores.txt"
            Dim outputStream As StreamWriter = New StreamWriter(fileName)

            Do While myReader.Read
                Dim valor(myReader.FieldCount - 1) As Object
                myReader.GetValues(valor)

                Dim line As String = String.Join(",", valor)
                outputStream.WriteLine(line)
            Loop
            myReader.Close()
            outputStream.Close()
            myConnection.Close()
        Catch ex As Exception
        End Try
#Disable Warning BC42105 ' La función no devuelve un valor en todas las rutas de código
    End Function
#Enable Warning BC42105 ' La función no devuelve un valor en todas las rutas de código

    Public Function SintomasMInferiores() As String()
        Dim myConnection = New MySqlConnection("server = 127.0.0.1; database = proyecto; Uid = root; pwd =;")
        Try
            myConnection.Open()

            Dim myCMD As MySqlCommand = New MySqlCommand("SELECT * FROM sintoma where region = 'Miembros Inferiores'", myConnection)
            Dim myReader As MySqlDataReader = myCMD.ExecuteReader()
            Dim fileName As String = "C:\Users\RaiseCool\Desktop\Textos\MiembrosInferiores.txt"
            Dim outputStream As StreamWriter = New StreamWriter(fileName)

            Do While myReader.Read
                Dim valor(myReader.FieldCount - 1) As Object
                myReader.GetValues(valor)

                Dim line As String = String.Join(",", valor)
                outputStream.WriteLine(line)
            Loop
            myReader.Close()
            outputStream.Close()
            myConnection.Close()
        Catch ex As Exception
        End Try
#Disable Warning BC42105 ' La función no devuelve un valor en todas las rutas de código
    End Function
#Enable Warning BC42105 ' La función no devuelve un valor en todas las rutas de código

    Public Function datagridpaciente() As DataTable
        Using con = Conex()
            con.Open()
            Try
                Dim cmd = New MySqlCommand("Select nombre, apellido, cedula, mail from usuario where rol = 'paciente'")
                cmd.CommandType = CommandType.Text
                cmd.Connection = con

                If cmd.ExecuteNonQuery Then
                    Dim dt As New DataTable
                    Dim da As New MySqlDataAdapter(cmd)
                    da.Fill(dt)
                    Return dt
                Else
                    Return Nothing
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
                Return Nothing
            End Try
        End Using
    End Function

    Public Function datagridmedico() As DataTable
        Using con = Conex()
            con.Open()
            Try
                Dim cmd = New MySqlCommand("Select nombre, apellido, cedula, mail from usuario where rol = 'medico'")
                cmd.CommandType = CommandType.Text
                cmd.Connection = con

                If cmd.ExecuteNonQuery Then
                    Dim dt As New DataTable
                    Dim da As New MySqlDataAdapter(cmd)
                    da.Fill(dt)
                    Return dt
                Else
                    Return Nothing
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
                Return Nothing
            End Try
        End Using
    End Function

    Public Function datagridpatologias() As DataTable
        Using con = Conex()
            con.Open()
            Try
                Dim cmd = New MySqlCommand("Select ide, nombre_e, descripcion_e from enfermedad")
                cmd.CommandType = CommandType.Text
                cmd.Connection = con

                If cmd.ExecuteNonQuery Then
                    Dim dt As New DataTable
                    Dim da As New MySqlDataAdapter(cmd)
                    da.Fill(dt)
                    Return dt
                Else
                    Return Nothing
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
                Return Nothing
            End Try
        End Using
    End Function

    Public Function datagridsintomas() As DataTable
        Using con = Conex()
            con.Open()
            Try
                Dim cmd = New MySqlCommand("Select ids, nombre_s, descripcion_s, region from sintoma")
                cmd.CommandType = CommandType.Text
                cmd.Connection = con

                If cmd.ExecuteNonQuery Then
                    Dim dt As New DataTable
                    Dim da As New MySqlDataAdapter(cmd)
                    da.Fill(dt)
                    Return dt
                Else
                    Return Nothing
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
                Return Nothing
            End Try
        End Using
    End Function

    Public Function ModificarSintoma(ids As String, sintoma As String, descripcion As String, region As String) As String
        Using con = Conex()
            con.Open()
            Using command = New MySqlCommand()
                command.Connection = con
                command.CommandText = "Update sintoma set ids=@ids, nombre_s=@sintoma, descripcion_s=@descripcion, region=@region where ids=@ids "
                command.Parameters.AddWithValue("@ids", ids)
                command.Parameters.AddWithValue("@sintoma", sintoma)
                command.Parameters.AddWithValue("@descripcion", descripcion)
                command.Parameters.AddWithValue("@region", region)
                command.CommandType = CommandType.Text
                command.ExecuteNonQuery()
            End Using
        End Using
    End Function

    Public Function ModificarPatologia(ide As String, patologia As String, descripcion As String) As String
        Using con = Conex()
            con.Open()
            Using command = New MySqlCommand()
                command.Connection = con
                command.CommandText = "Update enfermedad set ide=@ide, nombre_e=@sintoma, descripcion_e=@descripcion where ide=@ide "
                command.Parameters.AddWithValue("@ide", ide)
                command.Parameters.AddWithValue("@sintoma", patologia)
                command.Parameters.AddWithValue("@descripcion", descripcion)
                command.CommandType = CommandType.Text
                command.ExecuteNonQuery()
            End Using
        End Using
    End Function

    Public Function ModificarPaciente(cedula As String, Nombre As String, Apellido As String, Mail As String, Rol As String) As String
        Using con = Conex()
            con.Open()
            Using command = New MySqlCommand()
                command.Connection = con
                command.CommandText = "Update usuario set nombre=@Nombre, apellido=@Apellido, mail=@Mail where cedula=@Cedula and rol=@Rol "
                command.Parameters.AddWithValue("@Cedula", cedula)
                command.Parameters.AddWithValue("@Nombre", Nombre)
                command.Parameters.AddWithValue("@Apellido", Apellido)
                command.Parameters.AddWithValue("@Mail", Mail)
                command.Parameters.AddWithValue("@Rol", Rol)
                command.CommandType = CommandType.Text
                command.ExecuteNonQuery()
            End Using
        End Using
    End Function

    Public Function AgregarPaciente(Cedula As Integer, Nombre As String, Apellido As String, Mail As String, Contraseña As String, Rol As String) As String
        Using con = Conex()
            con.Open()
            Using command = New MySqlCommand()
                command.Connection = con
                command.CommandText = "Insert into usuario (cedula,nombre,apellido,mail,contrasenia,rol) values (@Cedula,@Nombre,@Apellido,@Mail,@Contraseña,@Rol)"
                command.Parameters.AddWithValue("@Cedula", Cedula)
                command.Parameters.AddWithValue("@Nombre", Nombre)
                command.Parameters.AddWithValue("@Apellido", Apellido)
                command.Parameters.AddWithValue("@Mail", Mail)
                command.Parameters.AddWithValue("@Contraseña", Contraseña)
                command.Parameters.AddWithValue("@Rol", Rol)
                command.CommandType = CommandType.Text
                command.ExecuteNonQuery()
            End Using
        End Using
    End Function

    Public Function AgregarPaciente2(Cedula As String, Edad As String, Estatura As String, Peso As String, Sexo As String, Calle As String, Telefono As String, Barrio As String) As String
        Using con = Conex()
            con.Open()
            Using command = New MySqlCommand()
                command.Connection = con
                command.CommandText = "Insert into paciente (cedula_p,edad,estatura,peso,sexo,calle,numero,localidad) values (@Cedula, @Edad, @Estatura, @Peso, @Sexo, @Calle, @Telefono, @Barrio)"
                command.Parameters.AddWithValue("@Cedula", Cedula)
                command.Parameters.AddWithValue("@Edad", Edad)
                command.Parameters.AddWithValue("@Estatura", Estatura)
                command.Parameters.AddWithValue("@Peso", Peso)
                command.Parameters.AddWithValue("@Sexo", Sexo)
                command.Parameters.AddWithValue("@Calle", Calle)
                command.Parameters.AddWithValue("@Telefono", Telefono)
                command.Parameters.AddWithValue("@Barrio", Barrio)
                command.CommandType = CommandType.Text
                command.ExecuteNonQuery()
            End Using
        End Using
    End Function

    Public Function AgregarSintoma(Nombre As String, Descripcion As String, Region As String) As String
        Using con = Conex()
            con.Open()
            Using command = New MySqlCommand()
                command.Connection = con
                command.CommandText = "Insert into sintoma (nombre_s,descripcion_s,region) values (@Nombre,@Descripcion,@Region)"
                command.Parameters.AddWithValue("@Nombre", Nombre)
                command.Parameters.AddWithValue("@Descripcion", Descripcion)
                command.Parameters.AddWithValue("@Region", Region)
                command.CommandType = CommandType.Text
                command.ExecuteNonQuery()
            End Using
        End Using
    End Function

    Public Function BorrarSintoma(nombre As String)
        Using con = Conex()
            con.Open()
            Dim cmd As New MySqlCommand
            Try
                cmd.Connection = con
                cmd.CommandText = "Delete From sintoma where ids=@nombre"
                cmd.Parameters.AddWithValue("@nombre", nombre)
                cmd.ExecuteNonQuery()
                If MessageBox.Show("Estas seguro que deseas eliminar este sintoma?", "Borrar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then
                    MsgBox("Operacion cancelada")
                End If
            Catch ex As Exception
                MessageBox.Show("Hubo un error" & ex.Message)
            Finally
                con.Close()
            End Try
        End Using
    End Function

    Public Function AgregarPatologia(Nombre As String, Descripcion As String) As String
        Using con = Conex()
            con.Open()
            Using command = New MySqlCommand()
                command.Connection = con
                command.CommandText = "Insert into enfermedad (nombre_e,descripcion_e) values (@Nombre,@Descripcion)"
                command.Parameters.AddWithValue("@Nombre", Nombre)
                command.Parameters.AddWithValue("@Descripcion", Descripcion)
                command.CommandType = CommandType.Text
                command.ExecuteNonQuery()
            End Using
        End Using
    End Function

    Public Function BorrarPatologia(nombre As String)
        Using con = Conex()
            con.Open()
            Dim cmd As New MySqlCommand
            Try
                cmd.Connection = con
                cmd.CommandText = "Delete From enfermedad where ide=@nombre"
                cmd.Parameters.AddWithValue("@nombre", nombre)
                cmd.ExecuteNonQuery()
                If MessageBox.Show("Estas seguro que deseas eliminar este sintoma?", "Borrar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then
                    MsgBox("Operacion cancelada")
                End If
            Catch ex As Exception
                MessageBox.Show("Hubo un error" & ex.Message)
            Finally
                con.Close()
            End Try
        End Using
    End Function

    Public Function Asociada(Nombre As String, asociar As String)
        Using con = Conex()
            con.Open()
            Using command = New MySqlCommand()
                command.Connection = con
                command.CommandText = "Update sintoma set asociada=@asociar where nombre_s=@nombre"
                command.Parameters.AddWithValue("@nombre", Nombre)
                command.Parameters.AddWithValue("@asociar", asociar)
                command.CommandType = CommandType.Text
                command.ExecuteNonQuery()
            End Using
        End Using
    End Function

End Class
