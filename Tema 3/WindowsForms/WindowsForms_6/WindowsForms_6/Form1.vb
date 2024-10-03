Public Class Form1
    Dim numero1 As Double
    Dim numero2 As Double
    Dim operacion As String
    Dim esOperacionRealizada As Boolean = False 'Comprueba si la operacion esta activa en el resultado
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub Numbers_Click(sender As Object, e As EventArgs) Handles Button1.Click, Button2.Click, Button3.Click, Button4.Click, Button5.Click, Button6.Click, Button7.Click, Button8.Click, Button9.Click, Button10.Click
        Dim button As Button = CType(sender, Button)
        labelInput.Text &= button.Text
    End Sub

    Private Sub Operators_Click(sender As Object, e As EventArgs) Handles buttonMultiply.Click, buttonDiv.Click, buttonMin.Click, buttonSum.Click
        Dim operatorButton As Button = CType(sender, Button)
        Try
            numero1 = Double.Parse(labelInput.Text)
            operacion = operatorButton.Text
            labelInput.Text &= " " & operacion & " "
            esOperacionRealizada = True
        Catch ex As Exception
            buttonEquals_Click(sender, e)
        End Try
    End Sub

    Private Sub buttonDelete_click(sender As Object, e As EventArgs) Handles buttonDelete.Click
        labelInput.Text = ""
        numero1 = 0
        numero2 = 0
        operacion = ""

    End Sub

    Private Sub buttonEquals_Click(sender As Object, e As EventArgs) Handles buttonEquals.Click
        Try
            Dim partes As String() = labelInput.Text.Split(" "c)
            numero2 = Double.Parse(partes(2))

            Select Case operacion
                Case "+"
                    labelInput.Text = (numero1 + numero2).ToString()
                    numero1 = labelInput.Text
                Case "-"
                    labelInput.Text = (numero1 - numero2).ToString()
                    numero1 = labelInput.Text
                Case "*"
                    labelInput.Text = (numero1 * numero2).ToString()
                    numero1 = labelInput.Text
                Case "/"
                    labelInput.Text = Math.Round((numero1 / numero2), 2).ToString()
                    numero1 = labelInput.Text
            End Select

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


End Class
