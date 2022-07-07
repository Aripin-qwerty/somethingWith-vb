Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim result As Double

        result = Me.TextBox1.Text / (Me.TextBox2.Text * Me.TextBox2.Text)
        Me.Label5.Text = result

    End Sub
End Class
