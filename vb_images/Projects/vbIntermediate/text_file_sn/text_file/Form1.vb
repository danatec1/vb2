Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        System.IO.File.WriteAllText("E:\tuts\info.dat", Me.TextBox1.Text, System.Text.Encoding.UTF8)
        MessageBox.Show("Done!")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim r As String
        r = System.IO.File.ReadAllText("E:\tuts\info.dat", System.Text.Encoding.UTF8)
        Me.TextBox1.Text = r
        MessageBox.Show("Done!")
    End Sub
End Class
