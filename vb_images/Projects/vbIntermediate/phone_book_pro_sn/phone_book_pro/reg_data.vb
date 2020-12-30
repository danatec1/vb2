Public Class reg_data
    Private Sub reg_data_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.save_butt.Enabled = False
        Me.info_groupbox.Enabled = False
    End Sub

    Private Sub new_butt_Click(sender As Object, e As EventArgs) Handles new_butt.Click
        Me.new_butt.Enabled = False
        Me.save_butt.Enabled = True
        '--------------------------
        Me.info_groupbox.Enabled = True
        '------------ Reset yhe text of all textboxes--------
        Me.id_TextBox1.ResetText()
        Me.fn_TextBox2.ResetText()
        Me.ln_TextBox3.ResetText()
        Me.tel_TextBox4.ResetText()
        Me.cell_TextBox5.ResetText()
        Me.email_TextBox6.ResetText()
        Me.address_TextBox7.ResetText()
        Me.comment_textbox.ResetText()
        '----------------------------------------------------
    End Sub

    Private Sub save_butt_Click(sender As Object, e As EventArgs) Handles save_butt.Click
        '-----------------------------
        If (Me.id_TextBox1.Text = "") Then
            MessageBox.Show("Please enter your ID!")
            Exit Sub
        End If
        '-----------------------------
        Me.save_butt.Enabled = False
        Me.new_butt.Enabled = True
        '----------------------------
        Me.info_groupbox.Enabled = False
        '-------------------------------
        Dim fn As String
        fn = "E:\tuts\" + Me.id_TextBox1.Text
        '----------------------------------
        Dim p As String
        '----------- first name --------------------------------------------------------
        p = fn + "_fn.txt"
        System.IO.File.WriteAllText(p, Me.fn_TextBox2.Text, System.Text.Encoding.UTF8)
        '------------------------------------------------------------------------------
        '----------- last name --------------------------------------------------------
        p = fn + "_ln.txt"
        System.IO.File.WriteAllText(p, Me.ln_TextBox3.Text, System.Text.Encoding.UTF8)
        '------------------------------------------------------------------------------
        '----------- tel --------------------------------------------------------
        p = fn + "_tel.txt"
        System.IO.File.WriteAllText(p, Me.tel_TextBox4.Text, System.Text.Encoding.UTF8)
        '------------------------------------------------------------------------------
        '----------- cellphone --------------------------------------------------------
        p = fn + "_cell.txt"
        System.IO.File.WriteAllText(p, Me.cell_TextBox5.Text, System.Text.Encoding.UTF8)
        '------------------------------------------------------------------------------
        '----------- email --------------------------------------------------------
        p = fn + "_email.txt"
        System.IO.File.WriteAllText(p, Me.email_TextBox6.Text, System.Text.Encoding.UTF8)
        '------------------------------------------------------------------------------
        '----------- address --------------------------------------------------------
        p = fn + "_address.txt"
        System.IO.File.WriteAllText(p, Me.address_TextBox7.Text, System.Text.Encoding.UTF8)
        '------------------------------------------------------------------------------
        '----------- comment --------------------------------------------------------
        p = fn + "_comm.txt"
        System.IO.File.WriteAllText(p, Me.comment_textbox.Text, System.Text.Encoding.UTF8)
        '------------------------------------------------------------------------------
        MessageBox.Show("Saved!")
    End Sub
End Class