Public Class UAC
    ' (!) Vérification du mot de passe (!)
    Private Sub verifylog()
        If TextBox1.Text = "Vincent OS" Then
            TextBox1.Text = ""
            '' /!\ Faire attention aux potentiels changements dans le futur ! /!\
            If Applications.Visible = True Then
                Store.Show()
                Me.Close()
            ElseIf Bureau2.Panel1.Visible = True Then
                Paramètres.Show()
                Me.Close()
            ElseIf Bureau2.Button11.Visible = True Then
                Store.Show()
                Me.Close()
            End If
        Else
            Dim backmusic As New System.Media.SoundPlayer(My.Resources.errorSound)
            backmusic.Play()
            MessageBox.Show("ERREUR : Le mot de passe est incorrecte.", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        verifylog()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            verifylog()
        End If
    End Sub

    Private Sub UAC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        My.Computer.Audio.PlaySystemSound(System.Media.SystemSounds.Exclamation)
    End Sub
End Class