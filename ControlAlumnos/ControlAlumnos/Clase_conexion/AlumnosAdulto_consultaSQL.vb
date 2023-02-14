Imports MySql.Data.MySqlClient
Public Class AlumnosAdulto_consultaSQL
    Inherits conexion

    'variables
    Private nombres As String
    Private dni As Integer
    Private celular As String
    Private direccion As String
    Private polo As String

    'variables sql
    Private cmd As MySqlCommand

    'constructor
    Public Sub New()

    End Sub

    Public Sub New(nam As String, dniA As Integer, cel As String, dir As String, pol As String)
        nombres = nam
        dni = dniA
        celular = cel
        direccion = dir
        polo = pol
    End Sub
    '=================================================================


    Public Function registrarAdulto(adulto As AlumnosAdulto_consultaSQL) As Boolean
        Try
            conectar()

            Dim sql As String = "call dbg_controlalumnos.registrar_adulto('" & adulto.dni_adulto & "', '" & adulto.nom_adulto & "', '" & adulto.celu_adulto & "', '" & adulto.dir_adulto & "');"

            cmd = New MySqlCommand(sql, con)

            If cmd.ExecuteNonQuery Then
                MsgBox("Alumno registrado")
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox("No se pudo registrar la marca de producto - error clase_conexion : " & ex.Message)
            Return False

        Finally
            desconectar()
        End Try


    End Function

















    '=================================================================
    'metodos get y post
    Public Property nom_adulto As String
        Get
            Return nombres
        End Get
        Set(value As String)
            nombres = value
        End Set
    End Property

    Public Property dni_adulto As String
        Get
            Return dni
        End Get
        Set(value As String)
            dni = value
        End Set
    End Property

    Public Property celu_adulto As String
        Get
            Return celular
        End Get
        Set(value As String)
            celular = value
        End Set
    End Property

    Public Property dir_adulto As String
        Get
            Return direccion
        End Get
        Set(value As String)
            direccion = value
        End Set
    End Property

    Public Property polo_adulto As String
        Get
            Return polo
        End Get
        Set(value As String)
            polo = value
        End Set
    End Property

End Class
