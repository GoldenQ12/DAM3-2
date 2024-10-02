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
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        Label2 = New Label()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(782, 682)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 41)
        Label1.TabIndex = 0
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' TextBox1
        ' 
        TextBox1.BorderStyle = BorderStyle.FixedSingle
        TextBox1.Font = New Font("Segoe UI", 18F)
        TextBox1.Location = New Point(771, 312)
        TextBox1.Name = "TextBox1"
        TextBox1.PlaceholderText = "Introduce un precio..."
        TextBox1.RightToLeft = RightToLeft.No
        TextBox1.Size = New Size(368, 47)
        TextBox1.TabIndex = 1
        TextBox1.TextAlign = HorizontalAlignment.Center
        ' 
        ' TextBox2
        ' 
        TextBox2.BorderStyle = BorderStyle.FixedSingle
        TextBox2.Font = New Font("Segoe UI", 18F)
        TextBox2.Location = New Point(771, 400)
        TextBox2.Name = "TextBox2"
        TextBox2.PlaceholderText = "Introduce un precio..."
        TextBox2.RightToLeft = RightToLeft.No
        TextBox2.Size = New Size(368, 47)
        TextBox2.TabIndex = 2
        TextBox2.TextAlign = HorizontalAlignment.Center
        ' 
        ' TextBox3
        ' 
        TextBox3.BorderStyle = BorderStyle.FixedSingle
        TextBox3.Font = New Font("Segoe UI", 18F)
        TextBox3.Location = New Point(771, 490)
        TextBox3.Name = "TextBox3"
        TextBox3.PlaceholderText = "Introduce un precio..."
        TextBox3.RightToLeft = RightToLeft.No
        TextBox3.Size = New Size(368, 47)
        TextBox3.TabIndex = 3
        TextBox3.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(673, 161)
        Label2.Name = "Label2"
        Label2.Size = New Size(582, 81)
        Label2.TabIndex = 4
        Label2.Text = "MEDIA DE PRECIOS"
        ' 
        ' Button1
        ' 
        Button1.AutoSize = True
        Button1.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(815, 591)
        Button1.Name = "Button1"
        Button1.Size = New Size(263, 51)
        Button1.TabIndex = 5
        Button1.Text = "MOSTRAR MEDIA"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1979, 913)
        Controls.Add(Button1)
        Controls.Add(Label2)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button

End Class
