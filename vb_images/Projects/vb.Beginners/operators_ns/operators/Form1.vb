Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim fn As Double
        Dim sn As Double
        Dim rn As Double
        '---------------------
        Double.TryParse(Me.first_num_TextBox1.Text, fn)
        Double.TryParse(Me.second_numTextBox2.Text, sn)
        '----------------------
        rn = fn + sn
        '------------
        Me.result_TextBox3.Text = rn.ToString()
        '------------
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim fn As Double
        Dim sn As Double
        Dim rn As Double
        '---------------------
        Double.TryParse(Me.first_num_TextBox1.Text, fn)
        Double.TryParse(Me.second_numTextBox2.Text, sn)
        '----------------------
        rn = fn - sn
        '------------
        Me.result_TextBox3.Text = rn.ToString()
        '------------
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim fn As Double
        Dim sn As Double
        Dim rn As Double
        '---------------------
        Double.TryParse(Me.first_num_TextBox1.Text, fn)
        Double.TryParse(Me.second_numTextBox2.Text, sn)
        '----------------------
        rn = fn * sn
        '------------
        Me.result_TextBox3.Text = rn.ToString()
        '------------
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim fn As Double
        Dim sn As Double
        Dim rn As Double
        '---------------------
        Double.TryParse(Me.first_num_TextBox1.Text, fn)
        Double.TryParse(Me.second_numTextBox2.Text, sn)
        '----------------------
        rn = fn / sn
        '------------
        Me.result_TextBox3.Text = rn.ToString()
        '------------
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim fn As Double
        Dim sn As Double
        Dim rn As Double
        '---------------------
        Double.TryParse(Me.first_num_TextBox1.Text, fn)
        Double.TryParse(Me.second_numTextBox2.Text, sn)
        '----------------------
        rn = fn \ sn
        '------------
        Me.result_TextBox3.Text = rn.ToString()
        '------------
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim fn As Double
        Dim sn As Double
        Dim rn As Double
        '---------------------
        Double.TryParse(Me.first_num_TextBox1.Text, fn)
        Double.TryParse(Me.second_numTextBox2.Text, sn)
        '----------------------
        rn = fn ^ sn
        '------------
        Me.result_TextBox3.Text = rn.ToString()
        '------------
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim fn As Double
        Dim sn As Double
        Dim rn As Double
        '---------------------
        Double.TryParse(Me.first_num_TextBox1.Text, fn)
        Double.TryParse(Me.second_numTextBox2.Text, sn)
        '----------------------
        rn = fn Mod sn
        '------------
        Me.result_TextBox3.Text = rn.ToString()
        '------------
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim fn As Int64
        Dim sn As Int64
        '----------------
        Int64.TryParse(Me.com_first_numTextBox2.Text, fn)
        Int64.TryParse(Me.com_second_TextBox1.Text, sn)
        '----------------
        If (fn > sn) Then
            MessageBox.Show("First Number is greater than second one")
        End If
        If (fn < sn) Then
            MessageBox.Show("First Number is Less than second one")
        End If
        If (fn = sn) Then
            MessageBox.Show("First Number and second one are equal")
        End If
        '-----------------
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim fn As Int64
        Dim sn As Int64
        '----------------
        Int64.TryParse(Me.com_first_numTextBox2.Text, fn)
        Int64.TryParse(Me.com_second_TextBox1.Text, sn)
        '----------------
        If (fn = sn) Then
            MessageBox.Show("First Number and second one are equal")
        End If
        If (fn <> sn) Then
            MessageBox.Show("First Number and second one are not equal")
        End If
        '----------------
    End Sub
End Class
