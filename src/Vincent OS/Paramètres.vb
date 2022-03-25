Public Class Paramètres

    Private Sub Options_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Bureau.Visible = True Then
            PictureBox1.Visible = True
            Label7.Text = "Utilisateur : Superutilisateur"
        ElseIf Bureau2.Visible = True Then
            PictureBox2.Visible = True
            Label7.Text = "Utilisateur : Invité"
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        About.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Custom.Show()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Terminal.Show()
    End Sub

    Private Sub Button4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        TaskVOS.Show()
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Custom.Show()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Utilisateur.Show()
    End Sub
End Class