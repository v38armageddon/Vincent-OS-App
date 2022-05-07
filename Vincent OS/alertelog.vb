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
                Bureau.Hide()
                Login.Show()
                Me.Close()
            ElseIf Bureau2.Visible = True Then
                Bureau2.Hide()
                Login.Show()
                Me.Close()
            ElseIf Login.Visible = True Then
                MessageBox.Show("Vous ne pouvez pas vous déconnecter dans l'écran de connexion.")
            ElseIf Avant.Visible = True Then
                MessageBox.Show("Vous ne pouvez pas vous déconnecter dans les paramètres d'affichages.")
            End If
        ElseIf ComboBox1.SelectedItem = "Ne rien faire" Then
            Me.Close()
        Else
            MessageBox.Show("J'ai une question essentiel : Pourquoi tu modifie ça ? Je veux dire, t'est même pas censé de faire ça en fait. Enfin bon, normalement il devrait être patché (enfin j'espère...).")
        End If
    End Sub
End Class