Public Class Options

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        apropos.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MessageBox.Show("Cette fonctionnalité n'est malheureusement pas disponible. Veuillez nous excuser pour la gêne occasionnée...")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Alerte.Show()
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Terminal.Show()
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

    Private Sub Options_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Bureau.Visible = True Then
            Bureau.Button25.Visible = True
        ElseIf Bureau2.Visible = True Then
            Bureau2.Button25.Visible = True
        End If
    End Sub

    Private Sub Options_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        If Bureau.Visible = True Then
            Bureau.Button25.Visible = False
        ElseIf Bureau2.Visible = True Then
            Bureau2.Button25.Visible = False
        End If
    End Sub
End Class