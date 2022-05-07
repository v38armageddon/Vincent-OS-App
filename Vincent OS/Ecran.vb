Public Class Ecran

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Bureau.BackgroundImage = Image.FromFile(TextBox1.Text)
        Panel1.Visible = True
    End Sub
End Class