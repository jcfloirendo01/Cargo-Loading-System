<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Signup
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
        Me.components = New System.ComponentModel.Container()
        Me.signupButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.nameBox = New System.Windows.Forms.TextBox()
        Me.usernameBox = New System.Windows.Forms.TextBox()
        Me.passwordBox = New System.Windows.Forms.TextBox()
        Me.repeatBox = New System.Windows.Forms.TextBox()
        Me.backButton = New System.Windows.Forms.Button()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.SuspendLayout()
        '
        'signupButton
        '
        Me.signupButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.signupButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.signupButton.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.signupButton.Location = New System.Drawing.Point(161, 181)
        Me.signupButton.Margin = New System.Windows.Forms.Padding(2)
        Me.signupButton.Name = "signupButton"
        Me.signupButton.Size = New System.Drawing.Size(104, 33)
        Me.signupButton.TabIndex = 0
        Me.signupButton.Text = "Sign Up"
        Me.signupButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(24, 92)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(24, 64)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Full Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(24, 121)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 15)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Password"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(24, 150)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 15)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Repeat Password"
        '
        'nameBox
        '
        Me.nameBox.Location = New System.Drawing.Point(141, 59)
        Me.nameBox.Margin = New System.Windows.Forms.Padding(2)
        Me.nameBox.Name = "nameBox"
        Me.nameBox.Size = New System.Drawing.Size(140, 20)
        Me.nameBox.TabIndex = 5
        '
        'usernameBox
        '
        Me.usernameBox.Location = New System.Drawing.Point(141, 87)
        Me.usernameBox.Margin = New System.Windows.Forms.Padding(2)
        Me.usernameBox.Name = "usernameBox"
        Me.usernameBox.Size = New System.Drawing.Size(140, 20)
        Me.usernameBox.TabIndex = 6
        '
        'passwordBox
        '
        Me.passwordBox.Location = New System.Drawing.Point(141, 116)
        Me.passwordBox.Margin = New System.Windows.Forms.Padding(2)
        Me.passwordBox.Name = "passwordBox"
        Me.passwordBox.Size = New System.Drawing.Size(140, 20)
        Me.passwordBox.TabIndex = 7
        Me.passwordBox.UseSystemPasswordChar = True
        '
        'repeatBox
        '
        Me.repeatBox.Location = New System.Drawing.Point(141, 145)
        Me.repeatBox.Margin = New System.Windows.Forms.Padding(2)
        Me.repeatBox.Name = "repeatBox"
        Me.repeatBox.Size = New System.Drawing.Size(140, 20)
        Me.repeatBox.TabIndex = 8
        Me.repeatBox.UseSystemPasswordChar = True
        '
        'backButton
        '
        Me.backButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.backButton.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.backButton.Location = New System.Drawing.Point(208, 11)
        Me.backButton.Margin = New System.Windows.Forms.Padding(2)
        Me.backButton.Name = "backButton"
        Me.backButton.Size = New System.Drawing.Size(73, 27)
        Me.backButton.TabIndex = 9
        Me.backButton.Text = "Go back"
        Me.backButton.UseVisualStyleBackColor = True
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me
        Me.BunifuDragControl1.Vertical = True
        '
        'Signup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(323, 237)
        Me.Controls.Add(Me.backButton)
        Me.Controls.Add(Me.repeatBox)
        Me.Controls.Add(Me.passwordBox)
        Me.Controls.Add(Me.usernameBox)
        Me.Controls.Add(Me.nameBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.signupButton)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Signup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Signup"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents signupButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents nameBox As TextBox
    Friend WithEvents usernameBox As TextBox
    Friend WithEvents passwordBox As TextBox
    Friend WithEvents repeatBox As TextBox
    Friend WithEvents backButton As Button
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
End Class
