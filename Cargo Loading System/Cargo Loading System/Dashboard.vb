Public Class Dashboard
    Dim User As New UserData.Person
    Public Sub Init(data As UserData.Person)
        User = data
        nameLabel.Text = User.name
    End Sub

    Private Sub logoutButton_Click(sender As Object, e As EventArgs) Handles logoutButton.Click
        Login.Show()
        Me.Close()
    End Sub

    Private Sub sendCargoButton_Click(sender As Object, e As EventArgs) Handles sendCargoButton.Click
        SendCargo.Show()
        Me.Close()
    End Sub
End Class