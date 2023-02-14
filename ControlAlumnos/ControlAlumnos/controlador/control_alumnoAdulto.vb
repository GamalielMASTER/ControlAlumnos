Public Class control_alumnoAdulto

    Public Function registrarAlumno_control(nam As String, dniA As Integer, cel As String, dir As String, pol As String) As Boolean

        Dim alumnoAdulto As New AlumnosAdulto_consultaSQL(nam, dniA, cel, dir, pol)

        If alumnoAdulto.registrarAdulto(alumnoAdulto) = True Then
            Return True
        Else
            Return False
        End If

    End Function

End Class
