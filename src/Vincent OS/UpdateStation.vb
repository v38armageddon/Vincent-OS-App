Public Class UpdateStation
    Private Sub UpdateStation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text = About.Label2.Text
        Label3.Text = About.Label5.Text
        If My.Computer.Network.IsAvailable Then
            '' Ne rien faire
        Else
            Dim backmusic As New System.Media.SoundPlayer(My.Resources.errorSound)
            backmusic.Play()
            MsgBox("Veuillez vous connecter à internet pour pouvoir effectuer les mises à jours.", MsgBoxStyle.Critical, "Erreur")
            Me.Close()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Start()
        Button1.Enabled = False
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(2)
        If ProgressBar1.Value = 100 Then
            Button1.Enabled = True
            If My.Computer.Network.Ping("https://github.com/v38armageddon/Vincent-OS/releases/tag/8") Then
                WebBrowser1.Visible = True
                WebBrowser1.Navigate("https://github.com/v38armageddon/Vincent-OS/releases/tag/8")
                Label4.Text = "Une mise à jour est disponible !"
                Label4.BackColor = Color.DarkOrange
                Label4.Visible = True
            Else
                Label4.Text = "Vous êtes à jour !"
                Label4.BackColor = Color.Green
                Label4.Visible = True
            End If
        End If
    End Sub
End Class