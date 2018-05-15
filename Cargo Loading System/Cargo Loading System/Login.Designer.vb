<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.usernameBox = New System.Windows.Forms.TextBox()
        Me.passwordBox = New System.Windows.Forms.TextBox()
        Me.bypassButton = New System.Windows.Forms.Button()
        Me.errLabel = New System.Windows.Forms.Label()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.bunifuImageButton2 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.bunifuImageButton1 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.bunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pictureBox3 = New System.Windows.Forms.PictureBox()
        Me.pictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.loginButton = New System.Windows.Forms.Button()
        CType(Me.bunifuImageButton2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bunifuImageButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'usernameBox
        '
        Me.usernameBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.usernameBox.Location = New System.Drawing.Point(77, 224)
        Me.usernameBox.Margin = New System.Windows.Forms.Padding(2)
        Me.usernameBox.Name = "usernameBox"
        Me.usernameBox.Size = New System.Drawing.Size(131, 13)
        Me.usernameBox.TabIndex = 2
        '
        'passwordBox
        '
        Me.passwordBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.passwordBox.Location = New System.Drawing.Point(77, 266)
        Me.passwordBox.Margin = New System.Windows.Forms.Padding(2)
        Me.passwordBox.Name = "passwordBox"
        Me.passwordBox.Size = New System.Drawing.Size(110, 13)
        Me.passwordBox.TabIndex = 3
        Me.passwordBox.UseSystemPasswordChar = True
        '
        'bypassButton
        '
        Me.bypassButton.Location = New System.Drawing.Point(222, 402)
        Me.bypassButton.Margin = New System.Windows.Forms.Padding(2)
        Me.bypassButton.Name = "bypassButton"
        Me.bypassButton.Size = New System.Drawing.Size(51, 20)
        Me.bypassButton.TabIndex = 7
        Me.bypassButton.Text = "Bypass"
        Me.bypassButton.UseVisualStyleBackColor = True
        '
        'errLabel
        '
        Me.errLabel.AutoSize = True
        Me.errLabel.Location = New System.Drawing.Point(131, 441)
        Me.errLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.errLabel.Name = "errLabel"
        Me.errLabel.Size = New System.Drawing.Size(0, 13)
        Me.errLabel.TabIndex = 8
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
        'bunifuImageButton2
        '
        Me.bunifuImageButton2.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.bunifuImageButton2.Image = CType(resources.GetObject("bunifuImageButton2.Image"), System.Drawing.Image)
        Me.bunifuImageButton2.ImageActive = Nothing
        Me.bunifuImageButton2.Location = New System.Drawing.Point(240, 4)
        Me.bunifuImageButton2.Name = "bunifuImageButton2"
        Me.bunifuImageButton2.Size = New System.Drawing.Size(22, 19)
        Me.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.bunifuImageButton2.TabIndex = 21
        Me.bunifuImageButton2.TabStop = False
        Me.bunifuImageButton2.Zoom = 10
        '
        'bunifuImageButton1
        '
        Me.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.bunifuImageButton1.Image = CType(resources.GetObject("bunifuImageButton1.Image"), System.Drawing.Image)
        Me.bunifuImageButton1.ImageActive = Nothing
        Me.bunifuImageButton1.Location = New System.Drawing.Point(263, 4)
        Me.bunifuImageButton1.Name = "bunifuImageButton1"
        Me.bunifuImageButton1.Size = New System.Drawing.Size(22, 19)
        Me.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.bunifuImageButton1.TabIndex = 20
        Me.bunifuImageButton1.TabStop = False
        Me.bunifuImageButton1.Zoom = 10
        '
        'bunifuCustomLabel1
        '
        Me.bunifuCustomLabel1.AutoSize = True
        Me.bunifuCustomLabel1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.bunifuCustomLabel1.Location = New System.Drawing.Point(54, 138)
        Me.bunifuCustomLabel1.Name = "bunifuCustomLabel1"
        Me.bunifuCustomLabel1.Size = New System.Drawing.Size(178, 46)
        Me.bunifuCustomLabel1.TabIndex = 19
        Me.bunifuCustomLabel1.Text = "CARGO LOADING " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "          SYSTEM"
        '
        'pictureBox1
        '
        Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Image)
        Me.pictureBox1.Location = New System.Drawing.Point(96, 42)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(100, 93)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBox1.TabIndex = 18
        Me.pictureBox1.TabStop = False
        '
        'pictureBox3
        '
        Me.pictureBox3.Image = CType(resources.GetObject("pictureBox3.Image"), System.Drawing.Image)
        Me.pictureBox3.Location = New System.Drawing.Point(56, 243)
        Me.pictureBox3.Name = "pictureBox3"
        Me.pictureBox3.Size = New System.Drawing.Size(168, 56)
        Me.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBox3.TabIndex = 23
        Me.pictureBox3.TabStop = False
        '
        'pictureBox2
        '
        Me.pictureBox2.Image = CType(resources.GetObject("pictureBox2.Image"), System.Drawing.Image)
        Me.pictureBox2.Location = New System.Drawing.Point(56, 202)
        Me.pictureBox2.Name = "pictureBox2"
        Me.pictureBox2.Size = New System.Drawing.Size(168, 56)
        Me.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBox2.TabIndex = 22
        Me.pictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(110, 202)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 15)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(110, 243)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 15)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(72, 368)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(134, 16)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "No account? Sign up!"
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.White
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(188, 262)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(24, 19)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 28
        Me.PictureBox4.TabStop = False
        '
        'loginButton
        '
        Me.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.loginButton.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.loginButton.Location = New System.Drawing.Point(99, 315)
        Me.loginButton.Name = "loginButton"
        Me.loginButton.Size = New System.Drawing.Size(88, 28)
        Me.loginButton.TabIndex = 29
        Me.loginButton.Text = "Login"
        Me.loginButton.UseVisualStyleBackColor = True
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(293, 433)
        Me.Controls.Add(Me.loginButton)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bunifuImageButton2)
        Me.Controls.Add(Me.bunifuImageButton1)
        Me.Controls.Add(Me.bunifuCustomLabel1)
        Me.Controls.Add(Me.pictureBox1)
        Me.Controls.Add(Me.errLabel)
        Me.Controls.Add(Me.bypassButton)
        Me.Controls.Add(Me.passwordBox)
        Me.Controls.Add(Me.usernameBox)
        Me.Controls.Add(Me.pictureBox3)
        Me.Controls.Add(Me.pictureBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.bunifuImageButton2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bunifuImageButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents passwordBox As TextBox
    Friend WithEvents usernameBox As TextBox
    Friend WithEvents bypassButton As Button
    Friend WithEvents errLabel As Label
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Private WithEvents pictureBox3 As PictureBox
    Private WithEvents pictureBox2 As PictureBox
    Private WithEvents bunifuImageButton2 As Bunifu.Framework.UI.BunifuImageButton
    Private WithEvents bunifuImageButton1 As Bunifu.Framework.UI.BunifuImageButton
    Private WithEvents bunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Private WithEvents pictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Private WithEvents Label3 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents loginButton As Button
End Class
