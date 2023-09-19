Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        txtDateAndTime.Text = Date.Now.ToString("dd MMM yyyy HH:mm:ss")
    End Sub
End Class
