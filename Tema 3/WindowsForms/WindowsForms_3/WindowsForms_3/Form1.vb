Public Class Form1
    Dim radio As Double = 0
    Dim altura As Integer = 0
    Dim resultado As Double

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim diametro As Integer = TextBox1.Text
            radio = diametro / 2
            Label4.Text = radio
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            altura = TextBox2.Text
            Label5.Text = altura
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        resultado = Math.PI * Math.Pow(radio, 2) * altura
        Label3.Text = " π * " & radio.ToString() & " * " & radio.ToString() & " * " & altura.ToString() & " = " & Math.Round(resultado, 2).ToString() + "cm3"
    End Sub
End Class
