Public Class Frm_adultoRegistro
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try

            Dim control_AlumAdul As New control_alumnoAdulto()
            control_AlumAdul.registrarAlumno_control(txtName.Text, txtDni.Text, txtCel.Text, txtDir.Text, txtPolo.Text)
            '(txtName.Text, txtDni.Text, txtCel.Text, txtDir.Text, txtPolo.Text)
        Catch ex As Exception
            MsgBox("Error en el formulario: " & ex.Message)
        End Try
    End Sub
End Class
