Public Class Ecran

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Bureau.Visible = True Then
            Bureau.BackgroundImage = Image.FromFile(TextBox1.Text)
            Panel1.Visible = True
        End If
        If Bureau2.Visible = True Then
            Bureau2.BackgroundImage = Image.FromFile(TextBox1.Text)
            Panel1.Visible = True
        End If
    End Sub
End Class