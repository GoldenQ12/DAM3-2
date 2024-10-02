Public Class Form1
    Dim cont As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cont += 1
        Label1.Text = "Contador: " & cont
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim nombre As String = TextBox1.Text
        Label3.Text = "Hola, buenos días " & nombre.ToString()
    End Sub

End Class
