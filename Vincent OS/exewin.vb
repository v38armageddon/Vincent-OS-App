Public Class exewin
    Dim executeur As New Process

    Private Sub exewin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Bureau.Visible = True Then
            Bureau.Button23.Visible = True
        ElseIf Bureau2.Visible = True Then
            Bureau2.Button23.Visible = True
        End If
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        exécution()
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            exécution()
        End If
    End Sub

    Private Sub exewin_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        If Bureau.Visible = True Then
            Bureau.Button23.Visible = False
        ElseIf Bureau2.Visible = True Then
            Bureau2.Button23.Visible = False
        End If
    End Sub
    Private Sub exécution()
        executeur.StartInfo.FileName = TextBox1.Text
        If TextBox1.Text = "Jeu de combinaisons" Then
            Dim backmusic As New System.Media.SoundPlayer(My.Resources.alertSound)
            backmusic.Play()
            MessageBox.Show("Ceci et un jeu qui a été abandonné au cours de son développement, des bugs peuvent avoir", "Alerte")
            mathingGame.Show()
        ElseIf TextBox1.Text = "" Then
            MessageBox.Show("Vous n'avez rentré aucune destination.", "Alerte")
        ElseIf TextBox1.Text.Contains(".exe") Then
            If IsError(False) Then
                executeur.Start()
            ElseIf IsError(True) Then
                MessageBox.Show("Erreur : Le fichier exécutable que vous souhaitez est introuvable")
            End If
        Else
            MessageBox.Show("Erreur : Le fichier exécutable que vous souhaitez est introuvable")
        End If
    End Sub
End Class