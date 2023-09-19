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
        components = New ComponentModel.Container()
        txtDateAndTime = New Label()
        Timer1 = New Timer(components)
        SuspendLayout()
        ' 
        ' txtDateAndTime
        ' 
        txtDateAndTime.AutoSize = True
        txtDateAndTime.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        txtDateAndTime.Location = New Point(219, 102)
        txtDateAndTime.Name = "txtDateAndTime"
        txtDateAndTime.Size = New Size(271, 48)
        txtDateAndTime.TabIndex = 0
        txtDateAndTime.Text = "Date And Time"
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 1000
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txtDateAndTime)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtDateAndTime As Label
    Friend WithEvents Timer1 As Timer
End Class
