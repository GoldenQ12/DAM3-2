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
        TextBox1 = New TextBox()
        Button1 = New Button()
        Label1 = New Label()
        Label2 = New Label()
        TextBox2 = New TextBox()
        Button2 = New Button()
        Button3 = New Button()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI", 18.0F)
        TextBox1.Location = New Point(452, 406)
        TextBox1.Name = "TextBox1"
        TextBox1.PlaceholderText = "Introduce el diametro..."
        TextBox1.Size = New Size(357, 47)
        TextBox1.TabIndex = 0
        ' 
        ' Button1
        ' 
        Button1.AutoSize = True
        Button1.Font = New Font("Segoe UI", 18.0F)
        Button1.Location = New Point(516, 497)
        Button1.Name = "Button1"
        Button1.Size = New Size(171, 51)
        Button1.TabIndex = 1
        Button1.Text = "ENVIAR"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(879, 575)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 41)
        Label1.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 18.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(665, 301)
        Label2.Name = "Label2"
        Label2.Size = New Size(577, 41)
        Label2.TabIndex = 3
        Label2.Text = "CALCULAR VOLUMEN DE UN CILINDRO"
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Segoe UI", 18.0F)
        TextBox2.Location = New Point(1000, 406)
        TextBox2.Name = "TextBox2"
        TextBox2.PlaceholderText = "Introduce la altura..."
        TextBox2.Size = New Size(357, 47)
        TextBox2.TabIndex = 4
        ' 
        ' Button2
        ' 
        Button2.AutoSize = True
        Button2.Font = New Font("Segoe UI", 18.0F)
        Button2.Location = New Point(1105, 497)
        Button2.Name = "Button2"
        Button2.Size = New Size(171, 51)
        Button2.TabIndex = 5
        Button2.Text = "ENVIAR"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.AutoSize = True
        Button3.Font = New Font("Segoe UI", 18.0F)
        Button3.Location = New Point(838, 651)
        Button3.Name = "Button3"
        Button3.Size = New Size(171, 51)
        Button3.TabIndex = 6
        Button3.Text = "CALCULAR"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.Font = New Font("Segoe UI", 18.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ImageAlign = ContentAlignment.MiddleRight
        Label3.Location = New Point(516, 760)
        Label3.Name = "Label3"
        Label3.Size = New Size(841, 41)
        Label3.TabIndex = 7
        Label3.Text = "EL RESULTADO ES: "
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 18.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(591, 575)
        Label4.Name = "Label4"
        Label4.Size = New Size(0, 41)
        Label4.TabIndex = 8
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 18.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(1161, 575)
        Label5.Name = "Label5"
        Label5.Size = New Size(0, 41)
        Label5.TabIndex = 9
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1986, 927)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(TextBox2)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Button1)
        Controls.Add(TextBox1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label

End Class
