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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        DateTimePicker1 = New DateTimePicker()
        PictureBox1 = New PictureBox()
        buttonBuscar = New Button()
        buttonInsert = New Button()
        buttonSalir = New Button()
        OpenFileDialog1 = New OpenFileDialog()
        Label5 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(188, 220)
        Label1.Name = "Label1"
        Label1.Size = New Size(169, 54)
        Label1.TabIndex = 0
        Label1.Text = "Nombre"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(188, 385)
        Label2.Name = "Label2"
        Label2.Size = New Size(188, 54)
        Label2.TabIndex = 1
        Label2.Text = "Password"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(188, 560)
        Label3.Name = "Label3"
        Label3.Size = New Size(395, 54)
        Label3.TabIndex = 2
        Label3.Text = "Fecha de Nacimiento"
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(642, 227)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(235, 47)
        TextBox1.TabIndex = 3
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox2.Location = New Point(642, 392)
        TextBox2.Name = "TextBox2"
        TextBox2.PasswordChar = "*"c
        TextBox2.Size = New Size(235, 47)
        TextBox2.TabIndex = 4
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.CustomFormat = ""
        DateTimePicker1.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DateTimePicker1.Location = New Point(642, 567)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(544, 47)
        DateTimePicker1.TabIndex = 5
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = SystemColors.ActiveBorder
        PictureBox1.Location = New Point(1235, 148)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(606, 334)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 6
        PictureBox1.TabStop = False
        ' 
        ' buttonBuscar
        ' 
        buttonBuscar.Font = New Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        buttonBuscar.Location = New Point(1363, 554)
        buttonBuscar.Name = "buttonBuscar"
        buttonBuscar.Size = New Size(386, 60)
        buttonBuscar.TabIndex = 7
        buttonBuscar.Text = "Buscar foto"
        buttonBuscar.UseVisualStyleBackColor = True
        ' 
        ' buttonInsert
        ' 
        buttonInsert.Font = New Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        buttonInsert.Location = New Point(491, 755)
        buttonInsert.Name = "buttonInsert"
        buttonInsert.Size = New Size(386, 60)
        buttonInsert.TabIndex = 8
        buttonInsert.Text = "Insertar"
        buttonInsert.UseVisualStyleBackColor = True
        ' 
        ' buttonSalir
        ' 
        buttonSalir.Font = New Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        buttonSalir.Location = New Point(1088, 755)
        buttonSalir.Name = "buttonSalir"
        buttonSalir.Size = New Size(386, 60)
        buttonSalir.TabIndex = 9
        buttonSalir.Text = "Salir"
        buttonSalir.UseVisualStyleBackColor = True
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(677, 9)
        Label5.Name = "Label5"
        Label5.Size = New Size(729, 81)
        Label5.TabIndex = 11
        Label5.Text = "FORMULARIO REGISTRO"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1957, 911)
        Controls.Add(Label5)
        Controls.Add(buttonSalir)
        Controls.Add(buttonInsert)
        Controls.Add(buttonBuscar)
        Controls.Add(PictureBox1)
        Controls.Add(DateTimePicker1)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents buttonBuscar As Button
    Friend WithEvents buttonInsert As Button
    Friend WithEvents buttonSalir As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Label5 As Label

End Class
