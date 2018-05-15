Imports System.Data.OleDb
Public Class Login
    'Variable Declarations
    Dim ctr As Boolean = True
    Dim User As New UserData.Person
    Private Sub signupButton_Click(sender As Object, e As EventArgs)
        'Function to signup form
        Me.Hide()
        Signup.Show()
    End Sub
    Private Sub bypassButton_Click(sender As Object, e As EventArgs) Handles bypassButton.Click
        'Function to bypass the login process for ease of access ( FOR TESTING ONLY, DELETE IN PRODUCTION )
        usernameBox.Text = "jcfloirendo"
        passwordBox.Text = "admin"
        loginButton.PerformClick()
    End Sub
    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        'Function to reveal the text inside the password textbox
        If ctr Then
            passwordBox.UseSystemPasswordChar = False
            ctr = False
        Else
            passwordBox.UseSystemPasswordChar = True
            ctr = True
        End If
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        'Function to signup form
        Me.Hide()
        Signup.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles loginButton.Click
        'Function for the login process
        Dim con As OleDbConnection
        Dim cb As OleDbCommand
        Dim dr As OleDbDataReader

        Dim username As String = usernameBox.Text
        Dim password As String = passwordBox.Text
        Dim success As Boolean

        con = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\cargo.mdb")
        cb = New OleDbCommand("SELECT * FROM Users WHERE user_username = '" + username + "' AND user_password ='" + password + "';", con)

        Try
            con.Open()
            dr = cb.ExecuteReader()
            success = dr.Read()
            If success Then
                MessageBox.Show("Success! Thank you for logging in " + dr("user_name") + ".")
                User.id = dr("user_id")
                User.name = dr("user_name")
                User.username = dr("user_username")
                Me.Hide()
                Dashboard.Show()
                Dashboard.Init(User)
                'Dashboard.Init(Identity)
            Else
                errLabel.Text = "Username or password is incorrect, try again!"
                'MessageBox.Show("Oops! It seems that the username and/or the password is incorrect! Try again.")
            End If
            con.Close()
        Catch ex As Exception
            errLabel.Text = "Please check if 'cargo.mdb' exists and try again!"
            'MessageBox.Show("Please check if the database 'cargo.mdb' exists and try again!")
        End Try
    End Sub
End Class
