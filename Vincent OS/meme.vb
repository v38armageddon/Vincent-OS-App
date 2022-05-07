Public Class meme

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        WebBrowser1.GoBack()
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        WebBrowser1.GoForward()
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        WebBrowser1.Navigate(TextBox1.Text)
    End Sub

    Private Sub meme_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Bureau.Visible = True Then
            Bureau.Button16.Visible = True
        ElseIf Bureau2.Visible = True Then
            Bureau2.Button16.Visible = True
        End If
    End Sub

    Private Sub meme_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        If Bureau.Visible = True Then
            Bureau.Button16.Visible = False
        ElseIf Bureau2.Visible = True Then
            Bureau2.Button16.Visible = False
        End If
    End Sub
End Class