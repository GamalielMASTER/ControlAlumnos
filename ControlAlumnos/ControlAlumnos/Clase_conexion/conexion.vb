Imports MySql.Data.MySqlClient

Public Class conexion
    Protected con As New MySqlConnection("server=localhost;database=dby_sistemaventa1;user=root;password=rootleon")

    Public Function conectar() As Boolean
        Try
            con.Open()
            Return True
        Catch ex As Exception
            MsgBox("No se puede conectar a la base de datos --error en la capa Datos: " & ex.Message)
            Return False
        End Try
    End Function

    Public Sub desconectar()

        Try
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        Catch ex As Exception
            MsgBox("No se pudo cerrar la conexion --error en la capa Datos: " & ex.Message)
        End Try

    End Sub
End Class
