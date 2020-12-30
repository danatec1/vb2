

Public Class Form1

    Dim s_m As String
    Dim nn As Int32




    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show("Hello World this Is my first vb.net code And i'm really happy!!!")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MessageBox.Show("I'm button 2")
        MessageBox.Show("I'm Line 2")
        MessageBox.Show("I'm Line 3")
        MessageBox.Show("I'm Line 4")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MessageBox.Show("I'm button 3")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub color_Button4_Click(sender As Object, e As EventArgs) Handles color_Button4.Click
        ' color_Button4.BackColor = Color.Red
        'color_Button4.ForeColor = Color.White
        'Button3.BackColor = Color.Yellow
        '-----------This is code to change my form background color----------------------
        Me.BackColor = Color.Red
        '---------------------------------------------------------------------------------
        Dim a As Int64

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.TextBox1.Text = "Hi ;I'm your beatifull textbox!!!"
        Me.color_Button4.Text = "Hi;Babe!!!"
        Me.Text = "I love you! Me Too!!!"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        Me.TextBox2.Text = DateTime.Now.ToString()
        '--------------------------------------------
        Me.hour_TextBox5.Text = DateTime.Now.Hour.ToString()
        Me.minute_TextBox4.Text = DateTime.Now.Minute.ToString()
        Me.second_TextBox3.Text = DateTime.Now.Second.ToString()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Panel1.Enabled = False
        'Me.Enabled = False
        Me.Button5.Enabled = False
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Panel1.Enabled = True

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.TextBox2.Text = DateTime.Now.ToString()
        '--------------------------------------------
        Me.hour_TextBox5.Text = DateTime.Now.Hour.ToString()
        Me.minute_TextBox4.Text = DateTime.Now.Minute.ToString()
        Me.second_TextBox3.Text = DateTime.Now.Second.ToString()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Me.dc_TextBox3.Text = DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString() + ":" + DateTime.Now.Second.ToString() + ":" + DateTime.Now.Millisecond.ToString()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Me.Timer2.Enabled = False
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Me.Timer2.Enabled = True
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        MessageBox.Show("Do you wanna exit?", "Hi", MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign)
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        'Me.PictureBox1.Image = Image.FromFile("E:\tuts\Koala.jpg")
        Me.PictureBox1.BackgroundImage = Image.FromFile("E:\tuts\Koala.jpg")
        Me.BackgroundImage = Image.FromFile("E:\tuts\Koala.jpg")
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Dim text_msg As String = Me.msg_TextBox3.Text

        MessageBox.Show("Hi: " + text_msg + " ; What's Up?")
        MessageBox.Show("Hi: " + text_msg + " ; Are you great?")
        MessageBox.Show("Hi: " + text_msg + " ; What's going on?")
    End Sub

    Dim my_var As String

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Dim fn As String
        Dim sn As String
        fn = Me.first_numTextBox4.Text
        sn = Me.second_numTextBox3.Text
        '-------------------------------
        Dim rn As String
        rn = fn + sn
        Me.result_TextBox5.Text = rn.ToString()
    End Sub



    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click


        ''''----------------------------
        Dim fn As Int32
        Dim sn As Int32
        Int32.TryParse(Me.first_numTextBox4.Text, fn)
        Int32.TryParse(Me.second_numTextBox3.Text, sn)
        '-------------------------------
        Dim rn As Int32
        rn = fn + sn
        Me.result_TextBox5.Text = rn.ToString()


    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click

        Dim fn As Int64
        Dim sn As Int64
        Int64.TryParse(Me.first_numTextBox4.Text, fn)
        Int64.TryParse(Me.second_numTextBox3.Text, sn)
        '-------------------------------
        Dim rn As Int64
        rn = fn + sn
        Me.result_TextBox5.Text = rn.ToString()

    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click

        Dim fn As Double
        Dim sn As Double
        Double.TryParse(Me.first_numTextBox4.Text, fn)
        Double.TryParse(Me.second_numTextBox3.Text, sn)
        '-------------------------------
        Dim rn As Double
        rn = fn + sn
        Me.result_TextBox5.Text = rn.ToString()

    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Dim fn As Decimal
        Dim sn As Decimal
        Decimal.TryParse(Me.first_numTextBox4.Text, fn)
        Decimal.TryParse(Me.second_numTextBox3.Text, sn)
        '-------------------------------
        Dim rn As Decimal
        rn = fn + sn
        Me.result_TextBox5.Text = rn.ToString()
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        Dim b As Boolean
        b = True
        b = Me.Button17.Enabled
        MessageBox.Show(b.ToString())
        Me.Button12.Enabled = b

    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        MessageBox.Show("Have a nce day", "Bye")
        Application.Exit()
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        Me.Close()
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        Me.Process1.StartInfo.FileName = "C:\Windows\System32\calc.exe"
        Me.Process1.Start()
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        Me.Process1.StartInfo.FileName = "C:\Windows\System32\mspaint.exe"
        Me.Process1.Start()
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        Me.Process1.StartInfo.FileName = "C:\Windows\System32\notepad.exe"
        Me.Process1.Start()
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click

        Me.Process1.StartInfo.FileName = "C:\Program Files (x86)\Audacity\audacity.exe"
        Me.Process1.Start()
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        '--------------------------------------
        Dim f_path As String
        f_path = Me.file_path_TextBox3.Text
        '----------Runs The Application Inside Textbox-------------------------
        Me.Process1.StartInfo.FileName = f_path
        Me.Process1.Start()
        '----------------------------------------------------------------------

    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        Dim age As Int32
        Dim yob As Int32
        Int32.TryParse(Me.birth_year_TextBox4.Text, yob)
        age = DateTime.Now.Year - yob
        'Me.age_TextBox3.Text = "Your Age Is: " + age.ToString()
        '---------------------------------------------
        If (age > 30) Then
            'MessageBox.Show("You are middle aged!")
            Me.age_TextBox3.Text = "Your Age Is: " + age.ToString() + " - " + "You are middle aged!"
        Else
            'MessageBox.Show("You are young!")
            Me.age_TextBox3.Text = "Your Age Is: " + age.ToString() + " - " + "You are young!"
        End If

    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
        Dim age As Int32
        Dim yob As Int32
        Int32.TryParse(Me.birth_year_TextBox4.Text, yob)
        age = DateTime.Now.Year - yob

        '---------------------------------------------
        If (age > 30) Then
            Me.age_TextBox3.Text = "Your Age Is: " + age.ToString() + " - " + "You are middle aged!"
            'Else
            '    Me.age_TextBox3.Text = "Your Age Is: " + age.ToString() + " - " + "You are young!"
        End If
        '-------------------------
        If (age < 30) Then
            Me.age_TextBox3.Text = "Your Age Is: " + age.ToString() + " - " + "You are young!"
        End If
        '-------------------------
        If (age = 30) Then
            Me.age_TextBox3.Text = "Your Age Is: " + age.ToString() + " - " + "I don't know who you are dude!!!"
        End If



    End Sub

    Private Sub Button28_Click(sender As Object, e As EventArgs) Handles Button28.Click
        Dim i As Integer

        For i = 0 To 4 Step 1
            MessageBox.Show("Hi;I am the number: " + i.ToString())
        Next
    End Sub

    Private Sub Button29_Click(sender As Object, e As EventArgs) Handles Button29.Click


        Dim i As Integer

        For i = 1 To 50000 Step 1
            Me.ComboBox1.Items.Add("Item: " + i.ToString)
        Next

    End Sub

    Private Sub Button30_Click(sender As Object, e As EventArgs) Handles Button30.Click
        Dim month_num As Int32
        Int32.TryParse(Me.month_numberTextBox4.Text, month_num)
        '----------------------------
        Dim month_name As String
        month_name = "Unknown"

        If (month_num = 1) Then
            month_name = "January"
        End If
        '----------------------------
        If (month_num = 2) Then
            month_name = "February"
        End If
        '----------------------------
        If (month_num = 3) Then
            month_name = "March"
        End If
        '----------------------------
        If (month_num = 4) Then
            month_name = "April"
        End If
        '----------------------------
        If (month_num = 5) Then
            month_name = "May"
        End If
        '----------------------------
        If (month_num = 6) Then
            month_name = "June"
        End If
        '----------------------------
        If (month_num = 7) Then
            month_name = "July"
        End If
        '----------------------------
        If (month_num = 8) Then
            month_name = "August"
        End If
        '----------------------------
        If (month_num = 9) Then
            month_name = "September"
        End If
        '----------------------------
        If (month_num = 10) Then
            month_name = "October"
        End If
        '----------------------------
        If (month_num = 11) Then
            month_name = "November"
        End If
        '----------------------------
        If (month_num = 12) Then
            month_name = "December"
        End If
        '----------------------------
        Me.month_nameTextBox3.Text = month_name
    End Sub

    Private Sub Button31_Click(sender As Object, e As EventArgs) Handles Button31.Click
        Dim month_num As Int32
        Int32.TryParse(Me.month_numberTextBox4.Text, month_num)
        '----------------------------
        Dim month_name As String

        '----------------------------
        Select Case month_num

            Case 1
                month_name = "January"

            Case 2
                month_name = "February"

            Case 3
                month_name = "March"

            Case 4
                month_name = "April"

            Case 5
                month_name = "May"

            Case 6
                month_name = "June"

            Case 7
                month_name = "July"

            Case 8
                month_name = "August"

            Case 9
                month_name = "September"

            Case 10
                month_name = "October"

            Case 11
                month_name = "November"

            Case 12
                month_name = "December"

            Case Else
                month_name = "Unknown"

        End Select
        '------------------------
        Me.month_nameTextBox3.Text = month_name
    End Sub

    Private Sub Button32_Click(sender As Object, e As EventArgs) Handles Button32.Click
        Dim month_name As String
        month_name = Me.my_month_name_TextBox4.Text
        '--------------------------------
        Dim month_number As Int32

        Select Case month_name

            Case "January"
                month_number = 1

            Case "February"
                month_number = 2

            Case "March"
                month_number = 3

            Case "April"
                month_number = 4

            Case "May"
                month_number = 5

            Case "June"
                month_number = 6

            Case "July"
                month_number = 7

            Case "August"
                month_number = 8

            Case "September"
                month_number = 9

            Case "October"
                month_number = 10

            Case "November"
                month_number = 11

            Case "December"
                month_number = 12

            Case Else
                month_number = -1

        End Select
        '---------------------------
        If (month_number = -1) Then
            Me.my_month_number_TextBox3.Text = "Invalid Month Name!"
        Else
            Me.my_month_number_TextBox3.Text = month_number.ToString()
        End If
        '---------------------------

    End Sub

    Private Sub Button33_Click(sender As Object, e As EventArgs) Handles Button33.Click
        Dim fn As Double
        Dim sn As Double
        ''Double.TryParse(Me.first_numTextBox4.Text, fn)
        ''Double.TryParse(Me.second_numTextBox3.Text, sn)

        fn = Val(Me.first_numTextBox4.Text)
        sn = Val(Me.second_numTextBox3.Text)
        '-------------------------------
        Dim rn As Double
        rn = fn + sn
        Me.result_TextBox5.Text = rn.ToString()

    End Sub
End Class



