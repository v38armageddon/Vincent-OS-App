Public Class exewin
    Dim executeur As New Process
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "Jeu de combinaisons" Then
            MessageBox.Show("Ceci et un jeu qui a été abandonné au cours de son développement, des bugs peuvent avoir", "Alerte")
            mathingGame.Show()
        Else
            executeur.StartInfo.FileName = TextBox1.Text
            executeur.Start()
        End If
    End Sub
End Class