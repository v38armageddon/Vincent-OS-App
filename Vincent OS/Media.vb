Public Class Media
    ''Régler tout le lecteur média qui marche plus
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

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Using open As New OpenFileDialog
            If open.ShowDialog = DialogResult.OK Then
                AxWindowsMediaPlayer1.URL = OpenFileDialog2.FileName
                TextBox1.Text = OpenFileDialog2.FileName
            End If
        End Using
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        TextBox1.Text = ""
        AxWindowsMediaPlayer1.URL = ""
        CheckBox1.Checked = False
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        AxWindowsMediaPlayer1.ShowPropertyPages()
    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If TextBox1.Text = Nothing Then
            CheckBox2.Checked = False
            MessageBox.Show("Veuillez d'abord lancer un média...", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf CheckBox2.Checked = True Then
            AxWindowsMediaPlayer1.fullScreen = True
        Else
            AxWindowsMediaPlayer1.fullScreen = False
        End If
    End Sub
End Class
