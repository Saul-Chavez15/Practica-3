Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim mat1, mat2, mat3, mat4, mat5 As Double
        Dim promedio As Double

        mat1 = Val(Materia1.Text)
        mat2 = Val(Materia2.Text)
        mat3 = Val(Materia3.Text)
        mat4 = Val(Materia4.Text)
        mat5 = Val(Materia5.Text)

        promedio = (mat1 + mat2 + mat3 + mat4 + mat5) / 5

        resultado.Text = promedio.ToString()

    End Sub
End Class
