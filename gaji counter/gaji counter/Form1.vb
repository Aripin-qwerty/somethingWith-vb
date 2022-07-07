Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub hitung_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hitung.Click

        Dim total As Double

        total = Me.kerja.Text * 15000 + Me.lembur.Text * 10000 - (Me.absen.Text * 100000)
        Me.Label8.Text = total


        Dim uang_makan As Double
        uang_makan = Me.kerja.Text * 10000
        Me.Label7.Text = uang_makan













    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        Dim ob As New Form2

        ob.Show()


    End Sub
End Class
