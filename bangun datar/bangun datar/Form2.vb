Public Class Form2

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim luas As Double
        Dim keliling As Double

        luas = Me.TextBox1.Text * Me.TextBox2.Text
        Me.Label6.Text = luas

        keliling = 2 * (Me.TextBox1.Text + Me.TextBox2.Text)
        Me.Label7.Text = keliling



    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim luas As Double
        Dim keliling As Double

        luas = Me.TextBox1.Text * Me.TextBox2.Text
        Me.Label6.Text = luas

        keliling = 2 * (Me.TextBox1.Text + Me.TextBox2.Text)
        Me.Label7.Text = keliling
    End Sub
End Class