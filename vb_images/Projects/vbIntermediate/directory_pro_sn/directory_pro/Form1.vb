Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim fn As String
        fn = "E:\tuts\" + Me.TextBox1.Text
        System.IO.Directory.CreateDirectory(fn)
        '-----------------------------------
        ''''''''Dim i As Int32
        ''''''''For i = 0 To 1000 Step 1
        ''''''''    fn = "E:\tuts\" + i.ToString()
        ''''''''    System.IO.Directory.CreateDirectory(fn)
        ''''''''Next
        '-----------------------------------
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        System.IO.Directory.Delete("E:\tuts\hi", True)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim b As Boolean
        b = System.IO.Directory.Exists("E:\tuts\hi")
        Me.Text = b.ToString()
        If (b = True) Then
            MessageBox.Show("I found your folder!")
        Else
            MessageBox.Show("I Could not find your folder!")
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        System.IO.Directory.Move("C:\temp\koala\", "C:\temp\bad_koala\")
    End Sub
End Class
