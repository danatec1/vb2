Public Class Search_form
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim fn As String
        fn = "E:\tuts\" + Me.id_search_TextBox1.Text
        '----------------------------------
        Dim p As String
        Dim r As String
        '----------- first name --------------------------------------------------------
        p = fn + "_fn.txt"
        '-----------------
        If (System.IO.File.Exists(p) = True) Then
            r = System.IO.File.ReadAllText(p, System.Text.Encoding.UTF8)
            Me.fn_TextBox2.Text = r
        Else
            Me.fn_TextBox2.Text = "Not Found"
        End If
        '------------last name-------------------------------------------------------------------
        p = fn + "_ln.txt"
        '------------------
        If (System.IO.File.Exists(p) = True) Then
            r = System.IO.File.ReadAllText(p, System.Text.Encoding.UTF8)
            Me.ln_TextBox3.Text = r
        Else
            Me.ln_TextBox3.Text = "Not Found"
        End If
        '-----------tel--------------------------------------------------------------------
        p = fn + "_tel.txt"
        '------------------
        If (System.IO.File.Exists(p) = True) Then
            r = System.IO.File.ReadAllText(p, System.Text.Encoding.UTF8)
            Me.tel_TextBox4.Text = r
        Else
            Me.tel_TextBox4.Text = "Not Found"
        End If
        '-------------cellphone------------------------------------------------------------------
        p = fn + "_cell.txt"
        '------------------
        If (System.IO.File.Exists(p) = True) Then
            r = System.IO.File.ReadAllText(p, System.Text.Encoding.UTF8)
            Me.cell_TextBox5.Text = r
        Else
            Me.cell_TextBox5.Text = "Not Found"
        End If
        '---------------------email----------------------------------------------------------
        p = fn + "_email.txt"
        '------------------
        If (System.IO.File.Exists(p) = True) Then
            r = System.IO.File.ReadAllText(p, System.Text.Encoding.UTF8)
            Me.email_TextBox6.Text = r
        Else
            Me.email_TextBox6.Text = "Not Found"
        End If
        '-------------------address------------------------------------------------------------
        p = fn + "_address.txt"
        '------------------
        If (System.IO.File.Exists(p) = True) Then
            r = System.IO.File.ReadAllText(p, System.Text.Encoding.UTF8)
            Me.address_TextBox7.Text = r
        Else
            Me.address_TextBox7.Text = "Not Found"
        End If
        '-------------------------------------------------------------------------------
        p = fn + "_comm.txt"
        '------------------
        If (System.IO.File.Exists(p) = True) Then
            r = System.IO.File.ReadAllText(p, System.Text.Encoding.UTF8)
            Me.comment_textbox.Text = r
        Else
            Me.comment_textbox.Text = "Not Found"
        End If
        '-------------------------------------------------------------------------------
        Me.id_TextBox1.Text = Me.id_search_TextBox1.Text
    End Sub
End Class