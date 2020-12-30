Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Forms.settings.MdiParent = Me
        My.Forms.settings.BackColor = Color.White
        My.Forms.settings.MaximizeBox = False
        My.Forms.settings.MinimizeBox = False
        '-------------------
        My.Forms.settings.version_Label2.Text = "2019.02.1"
        My.Forms.settings.version_Label2.BorderStyle = BorderStyle.FixedSingle
        '--------------------
        My.Forms.settings.Show()
        'Dim sf As New settings
        'sf.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' My.Forms.Backup.Show()
        Dim bf As New Backup
        bf.MdiParent = Me
        bf.BackColor = Color.Red
        bf.MaximizeBox = False
        bf.MinimizeBox = False
        bf.Text = "Hi!"
        bf.Show()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        My.Forms.settings.ShowDialog()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim bf As New Backup
        bf.ShowDialog()
    End Sub
End Class
