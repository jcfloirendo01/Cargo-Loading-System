Imports System.Data.OleDb
Public Class Signup
    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        Login.Show()
        Me.Close()
    End Sub

    Private Sub signupButton_Click(sender As Object, e As EventArgs) Handles signupButton.Click
        If nameBox.Text.Length < 1 Or usernameBox.Text.Length < 1 Or passwordBox.Text.Length < 1 Or repeatBox.Text.Length < 1 Then
            MessageBox.Show("Please do not leave any empty field!")
        Else
            If passwordBox.Text.Length >= 4 Then
                If passwordBox.Text = repeatBox.Text Then
                    Dim con As OleDbConnection
                    Dim cb As OleDbCommand
                    Dim dr As OleDbDataReader

                    Dim username As String = usernameBox.Text
                    Dim password As String = passwordBox.Text
                    Dim success As Boolean

                    con = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\cargo.mdb")
                    cb = New OleDbCommand("SELECT * FROM Users WHERE user_username = '" + username + "';", con)

                    Try
                        'Read if the user exists
                        con.Open()
                        dr = cb.ExecuteReader()
                        success = dr.Read()
                        con.Close()
                        If success Then
                            MessageBox.Show("User already exists!")
                        Else
                            'Write to Users Table
                            cb = New OleDbCommand("INSERT INTO Users (user_name, user_username, user_password) VALUES('" + nameBox.Text + "', '" + usernameBox.Text + "', '" + passwordBox.Text + "');", con)
                            con.Open()
                            cb.ExecuteNonQuery()
                            con.Close()
                            MessageBox.Show("Thank you for signing up, " + nameBox.Text + ". Logging you in....")

                            'Read the Id of the new User
                            cb = New OleDbCommand("SELECT * FROM Users WHERE user_username = '" + username + "';", con)
                            con.Open()
                            dr = cb.ExecuteReader()
                            success = dr.Read()
                            If success Then
                                'Go to the Dashboard
                                Dim User As UserData.Person
                                User.id = dr("user_id")
                                User.name = dr("user_name")
                                User.username = dr("user_username")
                                Dashboard.Show()
                                Dashboard.Init(User)
                                Me.Close()
                            Else
                                MessageBox.Show("Somehow something went wrong")
                            End If
                            con.Close()
                        End If
                    Catch ex As Exception
                        MessageBox.Show(ex.ToString)
                        'MessageBox.Show("Please check if the database 'cargo.mdb' exists and try again!")
                    End Try
                Else
                    MessageBox.Show("The passwords are not equal.")
                End If
            Else
                MessageBox.Show("Password must be at least 4 characters")
            End If
        End If
    End Sub
End Class