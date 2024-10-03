Public Class Form1
    Private Sub buttonBuscar_Click(sender As Object, e As EventArgs) Handles buttonBuscar.Click
        OpenFileDialog1.ShowDialog()
        Dim filePath As String = OpenFileDialog1.FileName
        PictureBox1.Image = Image.FromFile(filePath)
    End Sub

    Private Sub buttonInsert_Click(sender As Object, e As EventArgs) Handles buttonInsert.Click
        If PictureBox1.Image Is Nothing Or DateTimePicker1.Text > DateTime.Now() Or TextBox1.Text = "" Or TextBox2.Text = "" Then
            MessageBox.Show("Todos los campos son requeridos")
        ElseIf TextBox1.Text.Length < 6 Then
            MessageBox.Show("El usuario tiene que tener mas de 6 caracteres")
        ElseIf DateTimePicker1.Value.Year > DateTime.Now().Year - 18 Then
            MessageBox.Show("El usuario no es mayor de edad")
        Else
            MessageBox.Show("Usuario registrado correctamente")
        End If
    End Sub


    Private Sub buttonSalir_Click(sender As Object, e As EventArgs) Handles buttonSalir.Click
        If MessageBox.Show("Seguro que quieres salir?", "Confirm", MessageBoxButtons.YesNo) <> DialogResult.No Then
            Me.Close()
        End If
    End Sub
End Class
