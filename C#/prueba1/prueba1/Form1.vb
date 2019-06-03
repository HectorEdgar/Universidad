Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim numero As Integer
        numero = Val(TextBox1.Text)
        If numero > 10 And numero < 20 Then
            MessageBox.Show("El número introducido:" & numero)
        Else
            MessageBox.Show(" el numero introducido no esta en el rango de 10 y 20")
            TextBox1.Text = ""
        End If

    End Sub
End Class
