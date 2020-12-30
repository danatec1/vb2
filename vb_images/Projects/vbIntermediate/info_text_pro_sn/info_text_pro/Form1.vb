Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (Me.id_TextBox1.Text = "") Then
            MessageBox.Show("Please enter your ID.")
            Exit Sub
        End If
        If (Me.info_TextBox2.Text = "") Then
            MessageBox.Show("Please enter your Info.")
            Exit Sub
        End If
        '-----------------------
        Dim fn As String
        fn = "E:\tuts\info_" + Me.id_TextBox1.Text + ".txt"
        '-----------------------
        System.IO.File.WriteAllText(fn, Me.info_TextBox2.Text, System.Text.Encoding.UTF8)
        MessageBox.Show("Saved!")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If (Me.id_TextBox1.Text = "") Then
            MessageBox.Show("Please enter your ID.")
            Exit Sub
        End If
        '-----------------------
        Dim fn As String
        fn = "E:\tuts\info_" + Me.id_TextBox1.Text + ".txt"
        '-----------------------
        ' System.IO.File.WriteAllText(fn, Me.info_TextBox2.Text, System.Text.Encoding.UTF8)
        '------------------------
        If (System.IO.File.Exists(fn) = True) Then
            '------------------------
            Dim r As String
            r = System.IO.File.ReadAllText(fn, System.Text.Encoding.UTF8)
            Me.info_TextBox2.Text = r

        Else 'if you didn't find the file
            MessageBox.Show("Your ID is invalid")
            Me.info_TextBox2.Text = ""
        End If
        '--------------------------

    End Sub
End Class
