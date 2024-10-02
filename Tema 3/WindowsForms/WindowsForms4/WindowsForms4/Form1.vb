Public Class Form1
    Dim precio1, precio2, precio3 As Double
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            precio1 = TextBox1.Text
            precio2 = TextBox2.Text
            precio3 = TextBox3.Text
            Label1.Text = "La media de los 3 precios es: " & Math.Round(((precio1 + precio2 + precio3) / 3)).ToString()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class
