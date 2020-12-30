<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.path_TextBox1 = New System.Windows.Forms.TextBox()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.font_TextBox1 = New System.Windows.Forms.TextBox()
        Me.font_Button3 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.save_TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ColorDialog1
        '
        Me.ColorDialog1.FullOpen = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(162, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(136, 25)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Choose Color"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(34, 55)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(72, 25)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Browse"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'path_TextBox1
        '
        Me.path_TextBox1.Location = New System.Drawing.Point(112, 57)
        Me.path_TextBox1.Name = "path_TextBox1"
        Me.path_TextBox1.ReadOnly = True
        Me.path_TextBox1.Size = New System.Drawing.Size(340, 20)
        Me.path_TextBox1.TabIndex = 2
        '
        'font_TextBox1
        '
        Me.font_TextBox1.Location = New System.Drawing.Point(112, 92)
        Me.font_TextBox1.Name = "font_TextBox1"
        Me.font_TextBox1.ReadOnly = True
        Me.font_TextBox1.Size = New System.Drawing.Size(340, 20)
        Me.font_TextBox1.TabIndex = 4
        Me.font_TextBox1.Text = "Hi"
        '
        'font_Button3
        '
        Me.font_Button3.Location = New System.Drawing.Point(34, 90)
        Me.font_Button3.Name = "font_Button3"
        Me.font_Button3.Size = New System.Drawing.Size(72, 25)
        Me.font_Button3.TabIndex = 3
        Me.font_Button3.Text = "Font"
        Me.font_Button3.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(223, 284)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(113, 23)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "Select Image"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(192, 119)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(167, 159)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Filter = "Jpg FIles|*.jpg|Png Files|*.png|All Files|*.*|All Images(jpg,png,ico|*.jpg;*.png;" &
    "*.ico"
        Me.OpenFileDialog1.Title = "Hi"
        '
        'save_TextBox1
        '
        Me.save_TextBox1.Location = New System.Drawing.Point(112, 351)
        Me.save_TextBox1.Name = "save_TextBox1"
        Me.save_TextBox1.ReadOnly = True
        Me.save_TextBox1.Size = New System.Drawing.Size(340, 20)
        Me.save_TextBox1.TabIndex = 8
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(34, 349)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(72, 25)
        Me.Button4.TabIndex = 7
        Me.Button4.Text = "Save As"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.Filter = "Text Files ( *.txt )|*.txt"
        Me.SaveFileDialog1.Title = "Please Save Your File"
        '
        'Form1
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(497, 403)
        Me.Controls.Add(Me.save_TextBox1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.font_TextBox1)
        Me.Controls.Add(Me.font_Button3)
        Me.Controls.Add(Me.path_TextBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents path_TextBox1 As TextBox
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents FontDialog1 As FontDialog
    Friend WithEvents font_TextBox1 As TextBox
    Friend WithEvents font_Button3 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents save_TextBox1 As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
End Class
