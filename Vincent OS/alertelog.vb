Public Class alertelog
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If ComboBox1.SelectedItem = "Arrêter" Then
            If Login.Visible = True Then
                Arrêt.Timer1.Start()
                Login.Hide()
                Arrêt.Show()
                Me.Close()
            ElseIf Avant.Visible = True Then
                Avant.Close()
                Me.Close()
                Application.Exit()
            ElseIf Bureau.Visible = True Then
                Arrêt.Timer1.Start()
                Arrêt.Show()
                Bureau.Hide()
                Me.Close()
            ElseIf Bureau2.Visible = True Then
                Arrêt.Timer1.Start()
                Arrêt.Show()
                Bureau2.Hide()
                Me.Close()
            End If
        ElseIf ComboBox1.SelectedItem = "Déconnecter" Then
            If Bureau.Visible = True Then
                Bureau.Close()
                Login.Show()
                Me.Close()
            ElseIf Bureau2.Visible = True Then
                Bureau2.Close()
                Login.Show()
                Me.Close()
            ElseIf Login.Visible = True Then
                MessageBox.Show("Vous ne pouvez pas vous déconnecter dans l'écran de connexion.")
            ElseIf Avant.Visible = True Then
                MessageBox.Show("Vous ne pouvez pas vous déconnecter dans les paramètres d'affichages.")
            End If
        ElseIf ComboBox1.Text = "Debug.Terminal" Then
            Dim backmusic As New System.Media.SoundPlayer(My.Resources.alertSound)
            backmusic.Play()
            MessageBox.Show("Vous entrez dans un Terminal, certains commandes et certaines fonctionnalités peuvent ne pas fonctionner comme prévu !", "Alerte")
            Terminal.Show()
        Else
            Dim backmusic As New System.Media.SoundPlayer(My.Resources.errorSound)
            backmusic.Play()
            MessageBox.Show("Erreur : Cette option n'est pas reconnu par l'utilitaire des choix de sélections.", "Erreur")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class