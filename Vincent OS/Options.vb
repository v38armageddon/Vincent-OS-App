Public Class Options

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        apropos.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Ecran.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Alerte.Show()
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Terminal.Show()
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            If Bureau.Visible = True Then
                Bureau.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
                Démarrage.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
                Arrêt.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
                Login.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
                Login2bureau.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
                Bureau.Location = New Point(480, 300)
                Login.Location = New Point(480, 300)
                Login2bureau.Location = New Point(480, 300)
                Bureau.StartPosition = FormStartPosition.CenterScreen
                Démarrage.StartPosition = FormStartPosition.CenterScreen
                Login.StartPosition = FormStartPosition.CenterScreen
                Arrêt.StartPosition = FormStartPosition.CenterScreen
                Login2bureau.StartPosition = FormStartPosition.CenterScreen
                Bureau.Width = 854
                Bureau.Height = 480
                Arrêt.Width = 854
                Arrêt.Height = 480
                Démarrage.Width = 854
                Démarrage.Height = 480
                Login.Width = 854
                Login.Height = 480
                Login2bureau.Width = 854
                Login2bureau.Height = 480
            End If
            If Bureau2.Visible = True Then
                Bureau2.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
                Démarrage.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
                Arrêt.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
                Login.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
                Login2bureau2.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
                Bureau2.Location = New Point(480, 300)
                Login.Location = New Point(480, 300)
                Login2bureau2.Location = New Point(480, 300)
                Bureau2.StartPosition = FormStartPosition.CenterScreen
                Démarrage.StartPosition = FormStartPosition.CenterScreen
                Login.StartPosition = FormStartPosition.CenterScreen
                Arrêt.StartPosition = FormStartPosition.CenterScreen
                Login2bureau2.StartPosition = FormStartPosition.CenterScreen
                Bureau2.Width = 854
                Bureau2.Height = 480
                Arrêt.Width = 854
                Arrêt.Height = 480
                Démarrage.Width = 854
                Démarrage.Height = 480
                Login.Width = 854
                Login.Height = 480
                Login2bureau2.Width = 854
                Login2bureau2.Height = 480
            End If
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            If Bureau.Visible = True Then
                Bureau.FormBorderStyle = Windows.Forms.FormBorderStyle.None
                Démarrage.FormBorderStyle = Windows.Forms.FormBorderStyle.None
                Arrêt.FormBorderStyle = Windows.Forms.FormBorderStyle.None
                Login.FormBorderStyle = Windows.Forms.FormBorderStyle.None
                Login2bureau.FormBorderStyle = Windows.Forms.FormBorderStyle.None
                Bureau.Location = New Point(0, 0)
                Login.Location = New Point(0, 0)
                Login2bureau.Location = New Point(0, 0)
                Bureau.StartPosition = FormStartPosition.Manual
                Démarrage.StartPosition = FormStartPosition.Manual
                Login.StartPosition = FormStartPosition.Manual
                Arrêt.StartPosition = FormStartPosition.Manual
                Login2bureau.StartPosition = FormStartPosition.Manual
                Bureau.Width = My.Computer.Screen.Bounds.Width
                Bureau.Height = My.Computer.Screen.Bounds.Height
                Arrêt.Width = My.Computer.Screen.Bounds.Width
                Arrêt.Height = My.Computer.Screen.Bounds.Height
                Démarrage.Width = My.Computer.Screen.Bounds.Width
                Démarrage.Height = My.Computer.Screen.Bounds.Height
                Login.Width = My.Computer.Screen.Bounds.Width
                Login.Height = My.Computer.Screen.Bounds.Height
                Login2bureau.Width = My.Computer.Screen.Bounds.Width
                Login2bureau.Height = My.Computer.Screen.Bounds.Height
            End If
            If Bureau2.Visible = True Then
                Bureau2.FormBorderStyle = Windows.Forms.FormBorderStyle.None
                Démarrage.FormBorderStyle = Windows.Forms.FormBorderStyle.None
                Arrêt.FormBorderStyle = Windows.Forms.FormBorderStyle.None
                Login.FormBorderStyle = Windows.Forms.FormBorderStyle.None
                Login2bureau2.FormBorderStyle = Windows.Forms.FormBorderStyle.None
                Bureau2.Location = New Point(0, 0)
                Login.Location = New Point(0, 0)
                Login2bureau2.Location = New Point(0, 0)
                Bureau2.StartPosition = FormStartPosition.Manual
                Démarrage.StartPosition = FormStartPosition.Manual
                Login.StartPosition = FormStartPosition.Manual
                Arrêt.StartPosition = FormStartPosition.Manual
                Login2bureau2.StartPosition = FormStartPosition.Manual
                Bureau2.Width = My.Computer.Screen.Bounds.Width
                Bureau2.Height = My.Computer.Screen.Bounds.Height
                Arrêt.Width = My.Computer.Screen.Bounds.Width
                Arrêt.Height = My.Computer.Screen.Bounds.Height
                Démarrage.Width = My.Computer.Screen.Bounds.Width
                Démarrage.Height = My.Computer.Screen.Bounds.Height
                Login.Width = My.Computer.Screen.Bounds.Width
                Login.Height = My.Computer.Screen.Bounds.Height
                Login2bureau.Width = My.Computer.Screen.Bounds.Width
                Login2bureau.Height = My.Computer.Screen.Bounds.Height
                Login2bureau2.Width = My.Computer.Screen.Bounds.Width
                Login2bureau2.Height = My.Computer.Screen.Bounds.Height
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

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Icones.Show()
    End Sub

    Private Sub Button4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Azkan.Show()
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Ecran.Show()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Utilisateur.Show()
    End Sub
End Class