Public Class Login

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        verifylog()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Login2bureau2.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        MessageBox.Show("Le mot de passe est : << Vincent OS >> ")
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        alertelog.Show()
    End Sub

    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Panel1.BackColor = Color.Transparent
    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            verifylog()
        End If
    End Sub

    Private Sub verifylog()
        If TextBox2.Text = "Vincent OS" Then
            Login2bureau.Show()
            Me.Hide()
        Else
            Dim backmusic As New System.Media.SoundPlayer(My.Resources.errorSound)
            backmusic.Play()
            MessageBox.Show("Le mot de passe est incorrecte")
        End If
    End Sub
End Class