Imports System.IO
Public Class Media

    Private Sub Media_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Bureau.Visible = True Then
            Bureau.Button19.Visible = True
        ElseIf Bureau2.Visible = True Then
            Bureau2.Button19.Visible = True
        End If
    End Sub

    Private Sub Media_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        If Bureau.Visible = True Then
            Bureau.Button19.Visible = False
        ElseIf Bureau2.Visible = True Then
            Bureau2.Button19.Visible = False
        End If
    End Sub

    Private Sub ArrêterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ArrêterToolStripMenuItem.Click
        AxWindowsMediaPlayer2.URL = ""
    End Sub

    Private Sub PleinÉcranToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PleinÉcranToolStripMenuItem.Click
        If AxWindowsMediaPlayer2.URL = Nothing Then
            MessageBox.Show("Veuillez d'abord lancer un média...", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            AxWindowsMediaPlayer2.fullScreen = True
        End If
    End Sub

    Private Sub QuitterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuitterToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub OptionsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OptionsToolStripMenuItem.Click
        AxWindowsMediaPlayer2.ShowPropertyPages()
    End Sub

    Private Sub MusiqueToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MusiqueToolStripMenuItem.Click
        OpenFileDialog2.Filter = "Musique|*.mp3;*.wav;*.midi;*.wma"
        OpenFileDialog2.RestoreDirectory = True
        If OpenFileDialog2.ShowDialog = DialogResult.OK Then
            AxWindowsMediaPlayer2.URL = OpenFileDialog2.FileName
        End If
    End Sub

    Private Sub VidéoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VidéoToolStripMenuItem.Click
        OpenFileDialog2.Filter = "Vidéos|*.mp4;*.mkv;*.wmv;*.avi"
        OpenFileDialog2.RestoreDirectory = True
        If OpenFileDialog2.ShowDialog = DialogResult.OK Then
            AxWindowsMediaPlayer2.URL = OpenFileDialog2.FileName
        End If
    End Sub
End Class
