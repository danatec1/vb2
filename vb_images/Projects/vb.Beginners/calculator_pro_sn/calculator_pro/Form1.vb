Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.display_Label1.Text = Me.display_Label1.Text + "0"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.display_Label1.Text = Me.display_Label1.Text + "1"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.display_Label1.Text = Me.display_Label1.Text + "2"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.display_Label1.Text = Me.display_Label1.Text + "3"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.display_Label1.Text = Me.display_Label1.Text + "4"
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        Me.display_Label1.Text = Me.display_Label1.Text + "5"
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Me.display_Label1.Text = Me.display_Label1.Text + "6"
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Me.display_Label1.Text = Me.display_Label1.Text + "7"
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Me.display_Label1.Text = Me.display_Label1.Text + "8"
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Me.display_Label1.Text = Me.display_Label1.Text + "9"
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        '  Me.display_Label1.Text = ""
        Me.display_Label1.ResetText()
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Me.operator_Label1.Text = "+"
        '-------------------------------
        If (Me.display_Label1.Text = "") Then
        Else
            Me.first_num_Label2.Text = Me.display_Label1.Text
        End If
        '-------------------------------
        Me.display_Label1.Text = ""
        '--------------------------------
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Me.operator_Label1.Text = "-"
        '-------------------------------
        If (Me.display_Label1.Text = "") Then
        Else
            Me.first_num_Label2.Text = Me.display_Label1.Text
        End If
        '-------------------------------
        Me.display_Label1.Text = ""
        '--------------------------------
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Me.operator_Label1.Text = "x"
        '-------------------------------
        If (Me.display_Label1.Text = "") Then
        Else
            Me.first_num_Label2.Text = Me.display_Label1.Text
        End If
        '-------------------------------
        Me.display_Label1.Text = ""
        '--------------------------------
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Me.operator_Label1.Text = "%"
        '-------------------------------
        If (Me.display_Label1.Text = "") Then
        Else
            Me.first_num_Label2.Text = Me.display_Label1.Text
        End If
        '-------------------------------
        Me.display_Label1.Text = ""
        '--------------------------------
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim fn As Double
        Dim sn As Double
        Dim rn As Double
        '-------------------
        Double.TryParse(Me.first_num_Label2.Text, fn)
        'Double.TryParse(Me.display_Label1.Text, sn)
        sn = Val(Me.display_Label1.Text)
        '-------------------------------
        If (Me.operator_Label1.Text = "+") Then
            rn = fn + sn
        End If
        '--------------------------------
        If (Me.operator_Label1.Text = "-") Then
            rn = fn - sn
        End If
        '--------------------------------
        If (Me.operator_Label1.Text = "x") Then
            rn = fn * sn
        End If
        '--------------------------------
        If (Me.operator_Label1.Text = "%") Then
            rn = fn / sn
        End If
        '--------------------------------
        Me.display_Label1.Text = rn.ToString()
        Me.operator_Label1.Text = ""
        Me.first_num_Label2.ResetText()
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        Me.display_Label1.Text = Me.display_Label1.Text + "."
    End Sub
End Class
