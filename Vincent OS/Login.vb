Public Class Login

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox2.Text = "Vincent OS" Then
            Bureau.Show()
            Me.Hide()
        Else
            MessageBox.Show("Le mot de passe est incorrecte")
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Bureau2.Show()
        Me.Hide()
    End Sub
End Class