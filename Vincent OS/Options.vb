Public Class Options

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        apropos.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Ecran.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Alerte.Show()
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        MessageBox.Show("Du au développement de la version de Vincent OS 4, cette fonctionnalité n'est malheureusement pas disponible. Désolé du dérangement...")
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            If Bureau.Visible = True Then
                Bureau.Location = New Point(480, 300)
                Login.Location = New Point(480, 300)
                Bureau.StartPosition = FormStartPosition.CenterScreen
                Démarrage.StartPosition = FormStartPosition.CenterScreen
                Login.StartPosition = FormStartPosition.CenterScreen
                Arrêt.StartPosition = FormStartPosition.CenterScreen
                Bureau.Width = 863
                Bureau.Height = 442
                Arrêt.Width = 863
                Arrêt.Height = 442
                Démarrage.Width = 863
                Démarrage.Height = 442
                Login.Width = 863
                Login.Height = 442
            End If
            If Bureau2.Visible = True Then
                Bureau2.Location = New Point(480, 300)
                Login.Location = New Point(480, 300)
                Bureau2.StartPosition = FormStartPosition.CenterScreen
                Démarrage.StartPosition = FormStartPosition.CenterScreen
                Login.StartPosition = FormStartPosition.CenterScreen
                Arrêt.StartPosition = FormStartPosition.CenterScreen
                Bureau2.Width = 863
                Bureau2.Height = 442
                Arrêt.Width = 863
                Arrêt.Height = 442
                Démarrage.Width = 863
                Démarrage.Height = 442
                Login.Width = 863
                Login.Height = 442
            End If
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            If Bureau.Visible = True Then
                Bureau.Location = New Point(0, 0)
                Login.Location = New Point(0, 0)
                Bureau.StartPosition = FormStartPosition.Manual
                Démarrage.StartPosition = FormStartPosition.Manual
                Login.StartPosition = FormStartPosition.Manual
                Arrêt.StartPosition = FormStartPosition.Manual
                Bureau.Width = My.Computer.Screen.Bounds.Width
                Bureau.Height = My.Computer.Screen.Bounds.Height
                Arrêt.Width = My.Computer.Screen.Bounds.Width
                Arrêt.Height = My.Computer.Screen.Bounds.Height
                Démarrage.Width = My.Computer.Screen.Bounds.Width
                Démarrage.Height = My.Computer.Screen.Bounds.Height
                Login.Width = My.Computer.Screen.Bounds.Width
                Login.Height = My.Computer.Screen.Bounds.Height
            End If
            If Bureau2.Visible = True Then
                Bureau2.Location = New Point(0, 0)
                Login.Location = New Point(0, 0)
                Bureau2.StartPosition = FormStartPosition.Manual
                Démarrage.StartPosition = FormStartPosition.Manual
                Login.StartPosition = FormStartPosition.Manual
                Arrêt.StartPosition = FormStartPosition.Manual
                Bureau2.Width = My.Computer.Screen.Bounds.Width
                Bureau2.Height = My.Computer.Screen.Bounds.Height
                Arrêt.Width = My.Computer.Screen.Bounds.Width
                Arrêt.Height = My.Computer.Screen.Bounds.Height
                Démarrage.Width = My.Computer.Screen.Bounds.Width
                Démarrage.Height = My.Computer.Screen.Bounds.Height
                Login.Width = My.Computer.Screen.Bounds.Width
                Login.Height = My.Computer.Screen.Bounds.Height
            End If
        End If
    End Sub
End Class