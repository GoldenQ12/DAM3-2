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
        Button1 = New Button()
        Label1 = New Label()
        Button2 = New Button()
        TextBox1 = New TextBox()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.AutoSize = True
        Button1.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold)
        Button1.Location = New Point(362, 400)
        Button1.Name = "Button1"
        Button1.Size = New Size(137, 39)
        Button1.TabIndex = 0
        Button1.Text = "Agregar 1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold)
        Label1.Location = New Point(362, 333)
        Label1.Name = "Label1"
        Label1.Size = New Size(148, 29)
        Label1.TabIndex = 1
        Label1.Text = "Contador: 0"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Button2
        ' 
        Button2.AutoSize = True
        Button2.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold)
        Button2.Location = New Point(667, 462)
        Button2.Name = "Button2"
        Button2.Size = New Size(113, 39)
        Button2.TabIndex = 3
        Button2.Text = "Saludar"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold)
        TextBox1.ForeColor = SystemColors.ActiveBorder
        TextBox1.Location = New Point(597, 400)
        TextBox1.Name = "TextBox1"
        TextBox1.PlaceholderText = "Introduce tu nombre..."
        TextBox1.Size = New Size(280, 34)
        TextBox1.TabIndex = 4
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold)
        Label3.Location = New Point(597, 333)
        Label3.Name = "Label3"
        Label3.Size = New Size(0, 29)
        Label3.TabIndex = 5
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1997, 914)
        Controls.Add(Label3)
        Controls.Add(TextBox1)
        Controls.Add(Button2)
        Controls.Add(Label1)
        Controls.Add(Button1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label

End Class
