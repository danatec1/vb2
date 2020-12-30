Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.ColorDialog1.ShowDialog()
        Me.BackColor = Me.ColorDialog1.Color
        Me.Button1.ForeColor = Me.ColorDialog1.Color
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.FolderBrowserDialog1.ShowDialog()
        Dim fn As String
        fn = Me.FolderBrowserDialog1.SelectedPath
        If (fn = "") Then ' user did not select any folder
            MessageBox.Show("You did not select any folder!")
        Else
            Me.path_TextBox1.Text = fn
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles font_Button3.Click
        Me.FontDialog1.ShowDialog()
        Me.font_Button3.Font = Me.FontDialog1.Font
        'Me.Font = Me.FontDialog1.Font
        Me.font_TextBox1.Font = Me.FontDialog1.Font
        Me.font_TextBox1.Text = Me.FontDialog1.Font.ToString()

    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Me.OpenFileDialog1.ShowDialog()
        Dim fn As String
        fn = Me.OpenFileDialog1.FileName
        Me.PictureBox1.Image = Image.FromFile(fn)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.SaveFileDialog1.ShowDialog()
        Dim fn As String
        fn = Me.SaveFileDialog1.FileName
        Me.save_TextBox1.Text = fn
    End Sub
End Class
