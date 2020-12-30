Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' System.IO.File.Copy("C:\temp\Koala.jpg", "E:\tuts\new_koala.jpg", True)
        Me.OpenFileDialog1.ShowDialog()
        Dim fn As String
        fn = Me.OpenFileDialog1.FileName
        '-----------------------------
        System.IO.File.Copy(fn, "E:\tuts\new_koala.jpg", True)
        '-----------------------------
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.OpenFileDialog1.ShowDialog()
        Dim fn As String
        fn = Me.OpenFileDialog1.FileName
        '-----------------------------
        Dim df As String
        df = "E:\tuts\moved_koala.jpg"
        '------------------------------
        Dim b As Boolean
        b = System.IO.File.Exists(df)
        '-----------------------------
        If (b = True) Then
            System.IO.File.Delete(df)
        End If
        '-----------------------------
        System.IO.File.Move(fn, df)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.OpenFileDialog1.ShowDialog()
        Dim fn As String
        fn = Me.OpenFileDialog1.FileName
        '-----------------------------
        System.IO.File.Delete(fn)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim b As Boolean
        b = System.IO.File.Exists("C:\temp\Koala.jpg")
        If (b = True) Then
            MessageBox.Show("I found your file!")
        Else
            MessageBox.Show("I didn't find your file!")
        End If
    End Sub
End Class
