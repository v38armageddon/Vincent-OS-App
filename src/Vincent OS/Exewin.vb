Public Class exewin
    Dim executeur As New Process

    Private Sub exewin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Bureau.Visible = True Then
            Bureau.Button23.Visible = True
        ElseIf Bureau2.Visible = True Then
            Bureau2.Button23.Visible = True
        End If
    End Sub
    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
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
        If TextBox1.Text = "" Then
            Dim alertsound As New System.Media.SoundPlayer(My.Resources.alertSound)
            alertsound.Play()
            MessageBox.Show("ALERTE : Vous n'avez rentré aucune destination.", "Alerte", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf TextBox1.Text.Contains(".exe") Then '' Regarde si le fichier est un fichier exécutable
            If IsError(False) Then
                executeur.Start()
            ElseIf IsError(True) Then
                Dim errorsound As New System.Media.SoundPlayer(My.Resources.errorSound)
                errorsound.Play()
                MessageBox.Show("ERREUR : Le fichier exécutable que vous souhaitez est introuvable.", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            Dim errorsound As New System.Media.SoundPlayer(My.Resources.errorSound)
            errorsound.Play()
            MessageBox.Show("ERREUR : Le fichier exécutable que vous souhaitez est introuvable.", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class