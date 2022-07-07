Public Class Form3

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        Dim ob As New Form1

        ob.Show()

    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        Dim ab As New Form2

        ab.Show()

    End Sub

    Private Sub hitung_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hitung.Click

        Dim luas As Double
        Dim keliling As Double

        luas = Me.sisi.Text * Me.sisi.Text
        Me.Label5.Text = luas

        keliling = 4 * Me.sisi.Text
        Me.Label6.Text = keliling


    End Sub
End Class