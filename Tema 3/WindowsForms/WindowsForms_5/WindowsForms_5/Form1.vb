Public Class Form1
    Dim claseSueldo As Integer = 0
    Dim sindicatoSueldo As Integer = 0
    Dim aniosServicioSueldo As Integer = 0
    Dim numeroHijosSueldo As Integer = 0
    Dim sueldoTotal As Integer = 0

    Dim numeroHijos As Integer

    Dim opcionClase As String
    Dim opcionAnios As String

    Dim opcionSindicato As Boolean
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.SelectedIndex = 0
        ComboBox2.SelectedIndex = 0

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        opcionClase = ComboBox1.SelectedItem
        Select Case ComboBox1.SelectedIndex
            Case 0 'Obrero
                claseSueldo = 800
            Case 1 'Administrativo
                claseSueldo = 900
            Case 2 'Técnico
                claseSueldo = 1000
            Case 3 'Profesional
                claseSueldo = 1200
            Case Else
                claseSueldo = 800
        End Select
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        opcionAnios = ComboBox2.SelectedItem
        Select Case ComboBox2.SelectedIndex
            Case 1 '5-10 anios
                aniosServicioSueldo = 100
            Case 2
                aniosServicioSueldo = 200
        End Select

    End Sub

    Private Sub checkBoxSindicato_CheckedChanged(sender As Object, e As EventArgs) Handles checkBoxSindicato.CheckedChanged
        opcionSindicato = checkBoxSindicato.Checked
        If checkBoxSindicato.Checked Then
            sindicatoSueldo = 50
        End If
    End Sub


    'IIf Defines ternary operator value == value2 ? true : false
    Private Sub buttonCalcular_Click(sender As Object, e As EventArgs) Handles buttonCalcular.Click
        sueldoTotal = claseSueldo + aniosServicioSueldo + numeroHijosSueldo + sindicatoSueldo
        labelData.Text =
            "CLASE OBRERA: " & opcionClase.ToString() & " - " & claseSueldo.ToString() & "€" & Environment.NewLine &
            "SINDICATO: " & IIf(opcionSindicato = True, " ACTIVO - ", " INACTIVO - ") & sindicatoSueldo.ToString() & "€" & Environment.NewLine &
            "AÑOS DE SERVICIO: " & opcionAnios.ToString() & " - " & aniosServicioSueldo.ToString() & "€" & Environment.NewLine &
            "NUMERO DE HIJOS: " & numeroHijos.ToString() & " - " & numeroHijosSueldo.ToString() & "€" & Environment.NewLine & Environment.NewLine & Environment.NewLine &
            "SUELDO TOTAL: " & sueldoTotal.ToString() & "€"
    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
        numeroHijosSueldo = NumericUpDown1.Value * 100
        numeroHijos = NumericUpDown1.Value
    End Sub

    Private Sub buttonBorrar_Click(sender As Object, e As EventArgs) Handles buttonBorrar.Click
        If MessageBox.Show("Seguro que quieres borrar los datos introducidos?", "Advertencia", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            checkBoxSindicato.Checked = False
            NumericUpDown1.Value = 0
            ComboBox1.SelectedIndex = 0
            ComboBox2.SelectedIndex = 0
            labelData.Text = ""
        End If

    End Sub

    Private Sub buttonSalir_Click(sender As Object, e As EventArgs) Handles buttonSalir.Click
        If MessageBox.Show("Seguro que quieres salir?", "Advertencia", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub
End Class
