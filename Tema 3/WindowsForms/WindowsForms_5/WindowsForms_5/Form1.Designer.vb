<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        labelTitulo = New Label()
        ComboBox1 = New ComboBox()
        checkBoxSindicato = New CheckBox()
        ComboBox2 = New ComboBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        NumericUpDown1 = New NumericUpDown()
        buttonCalcular = New Button()
        buttonBorrar = New Button()
        buttonSalir = New Button()
        labelData = New Label()
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' labelTitulo
        ' 
        labelTitulo.AutoSize = True
        labelTitulo.Font = New Font("Segoe UI", 36.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        labelTitulo.Location = New Point(260, 75)
        labelTitulo.Name = "labelTitulo"
        labelTitulo.Size = New Size(662, 81)
        labelTitulo.TabIndex = 0
        labelTitulo.Text = "CALCULO DE SALARIO"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.Font = New Font("Segoe UI", 18.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Obrero", "Administrativo", "Técnico", "Profesional"})
        ComboBox1.Location = New Point(373, 298)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(334, 49)
        ComboBox1.TabIndex = 1
        ' 
        ' checkBoxSindicato
        ' 
        checkBoxSindicato.AutoSize = True
        checkBoxSindicato.Font = New Font("Segoe UI", 18.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        checkBoxSindicato.Location = New Point(373, 375)
        checkBoxSindicato.Name = "checkBoxSindicato"
        checkBoxSindicato.Size = New Size(162, 45)
        checkBoxSindicato.TabIndex = 2
        checkBoxSindicato.Text = "Sindicato"
        checkBoxSindicato.UseVisualStyleBackColor = True
        ' 
        ' ComboBox2
        ' 
        ComboBox2.Font = New Font("Segoe UI", 18.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ComboBox2.FormattingEnabled = True
        ComboBox2.Items.AddRange(New Object() {"<5 Años", "5-10 Años", ">10 Años"})
        ComboBox2.Location = New Point(373, 490)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(334, 49)
        ComboBox2.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 22.2F, FontStyle.Bold)
        Label1.ImageAlign = ContentAlignment.TopCenter
        Label1.Location = New Point(373, 437)
        Label1.Name = "Label1"
        Label1.Size = New Size(358, 50)
        Label1.TabIndex = 4
        Label1.Text = "AÑOS DE SERVICIO"
        Label1.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 22.2F, FontStyle.Bold)
        Label2.ImageAlign = ContentAlignment.TopCenter
        Label2.Location = New Point(373, 231)
        Label2.Name = "Label2"
        Label2.Size = New Size(442, 50)
        Label2.TabIndex = 5
        Label2.Text = "CLASE DE TRABAJADOR"
        Label2.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 22.2F, FontStyle.Bold)
        Label3.ImageAlign = ContentAlignment.TopCenter
        Label3.Location = New Point(373, 568)
        Label3.Name = "Label3"
        Label3.Size = New Size(357, 50)
        Label3.TabIndex = 6
        Label3.Text = "NUMERO DE HIJOS"
        Label3.TextAlign = ContentAlignment.TopCenter
        ' 
        ' NumericUpDown1
        ' 
        NumericUpDown1.Font = New Font("Segoe UI", 18.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        NumericUpDown1.Location = New Point(373, 643)
        NumericUpDown1.Name = "NumericUpDown1"
        NumericUpDown1.Size = New Size(334, 47)
        NumericUpDown1.TabIndex = 7
        NumericUpDown1.TextAlign = HorizontalAlignment.Right
        ' 
        ' buttonCalcular
        ' 
        buttonCalcular.AutoSize = True
        buttonCalcular.Font = New Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        buttonCalcular.Location = New Point(73, 728)
        buttonCalcular.Name = "buttonCalcular"
        buttonCalcular.Size = New Size(207, 60)
        buttonCalcular.TabIndex = 8
        buttonCalcular.Text = "CALCULAR"
        buttonCalcular.UseVisualStyleBackColor = True
        ' 
        ' buttonBorrar
        ' 
        buttonBorrar.AutoSize = True
        buttonBorrar.Font = New Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        buttonBorrar.Location = New Point(420, 728)
        buttonBorrar.Name = "buttonBorrar"
        buttonBorrar.Size = New Size(207, 60)
        buttonBorrar.TabIndex = 10
        buttonBorrar.Text = "BORRAR"
        buttonBorrar.UseVisualStyleBackColor = True
        ' 
        ' buttonSalir
        ' 
        buttonSalir.AutoSize = True
        buttonSalir.Font = New Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        buttonSalir.Location = New Point(715, 728)
        buttonSalir.Name = "buttonSalir"
        buttonSalir.Size = New Size(207, 60)
        buttonSalir.TabIndex = 11
        buttonSalir.Text = "SALIR"
        buttonSalir.UseVisualStyleBackColor = True
        ' 
        ' labelData
        ' 
        labelData.Font = New Font("Segoe UI", 18.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        labelData.Location = New Point(1064, 91)
        labelData.Name = "labelData"
        labelData.Size = New Size(749, 697)
        labelData.TabIndex = 12
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1973, 902)
        Controls.Add(labelData)
        Controls.Add(buttonSalir)
        Controls.Add(buttonBorrar)
        Controls.Add(buttonCalcular)
        Controls.Add(NumericUpDown1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(ComboBox2)
        Controls.Add(checkBoxSindicato)
        Controls.Add(ComboBox1)
        Controls.Add(labelTitulo)
        Name = "Form1"
        Text = "Form1"
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents labelTitulo As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents checkBoxSindicato As CheckBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents buttonCalcular As Button
    Friend WithEvents buttonBorrar As Button
    Friend WithEvents buttonSalir As Button
    Friend WithEvents labelData As Label

End Class
