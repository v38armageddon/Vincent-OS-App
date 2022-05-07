Public Class Media

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If OpenFileDialog2.ShowDialog = Windows.Forms.DialogResult.OK Then
            TextBox1.Text = OpenFileDialog2.FileName
            AxWindowsMediaPlayer1.URL = TextBox1.Text
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        AxWindowsMediaPlayer1.ShowPropertyPages()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        TextBox1.Clear()
        AxWindowsMediaPlayer1.URL = ""
        CheckBox1.Checked = False
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If TextBox1.Text = Nothing Then
            CheckBox1.Checked = False
            MessageBox.Show("Veuillez d'abord lancer un média...", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf CheckBox1.Checked = True Then
            AxWindowsMediaPlayer1.fullScreen = True
        Else
            AxWindowsMediaPlayer1.fullScreen = False
        End If
    End Sub

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
End Class
