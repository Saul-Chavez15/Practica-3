Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim mat1, mat2, mat3, mat4, mat5, mat6, mat7, mat8, mat9, mat10, mat11, mat12, mat13 As Double
        Dim promedio As Double

        mat1 = Val(Materia1.Text)
        mat2 = Val(Materia2.Text)
        mat3 = Val(Materia3.Text)
        mat4 = Val(Materia4.Text)
        mat5 = Val(Materia5.Text)
        mat6 = Val(Materia6.Text)
        mat7 = Val(Materia7.Text)
        mat8 = Val(Materia8.Text)
        mat9 = Val(Materia9.Text)
        mat10 = Val(Materia10.Text)
        mat11 = Val(Materia11.Text)
        mat12 = Val(Materia12.Text)
        mat13 = Val(Materia13.Text)

        promedio = (mat1 + mat2 + mat3 + mat4 + mat5 + mat6 + mat7 + mat8 + mat9 + mat10 + mat11 + mat12 + mat13) / 13

        resultado.Text = promedio.ToString()

    End Sub


End Class
