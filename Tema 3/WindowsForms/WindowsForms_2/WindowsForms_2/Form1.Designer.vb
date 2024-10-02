Imports System.Net.Security

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        BluePill = New PictureBox()
        RedPill = New PictureBox()
        Label1 = New Label()
        CType(BluePill, ComponentModel.ISupportInitialize).BeginInit()
        CType(RedPill, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' BluePill
        ' 
        BluePill.BackgroundImage = CType(resources.GetObject("BluePill.BackgroundImage"), Image)
        BluePill.Location = New Point(121, 104)
        BluePill.Name = "BluePill"
        BluePill.Size = New Size(134, 325)
        BluePill.TabIndex = 0
        BluePill.TabStop = False
        ' 
        ' RedPill
        ' 
        RedPill.BackgroundImage = CType(resources.GetObject("RedPill.BackgroundImage"), Image)
        RedPill.Location = New Point(534, 104)
        RedPill.Name = "RedPill"
        RedPill.Size = New Size(118, 325)
        RedPill.TabIndex = 1
        RedPill.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 24.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(152, 24)
        Label1.Name = "Label1"
        Label1.Size = New Size(478, 54)
        Label1.TabIndex = 2
        Label1.Text = "EL JUEGO DE LA PILDORA"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label1)
        Controls.Add(RedPill)
        Controls.Add(BluePill)
        Name = "Form1"
        Text = "Form1"
        CType(BluePill, ComponentModel.ISupportInitialize).EndInit()
        CType(RedPill, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BluePill As PictureBox
    Friend WithEvents RedPill As PictureBox
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents Label1 As Label

End Class
