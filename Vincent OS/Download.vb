Public Class Download

    Private Sub Button5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If Button6.Enabled = False Or Button7.Enabled = False Or Button8.Enabled = False Or Button1.Enabled = False Or Button2.Enabled = False Or Button3.Enabled = False Then
            Dim errorsound As New System.Media.SoundPlayer(My.Resources.errorSound)
            errorsound.Play()
            MessageBox.Show("ERREUR : Vous ne pouvez lancer qu'un téléchargement à la fois.", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Button5.Text = "Téléchargement..."
            Button5.Enabled = False
            ProgressBar1.Visible = True
            Timer1.Start()
        End If
    End Sub

    Private Sub Button6_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If Button5.Enabled = False Or Button7.Enabled = False Or Button8.Enabled = False Or Button1.Enabled = False Or Button2.Enabled = False Or Button3.Enabled = False Then
            Dim errorsound As New System.Media.SoundPlayer(My.Resources.errorSound)
            errorsound.Play()
            MessageBox.Show("ERREUR : Vous ne pouvez lancer qu'un téléchargement à la fois.", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Button6.Text = "Téléchargement..."
            Button6.Enabled = False
            ProgressBar2.Visible = True
            Timer1.Start()
        End If
    End Sub

    Private Sub Button7_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        If Button6.Enabled = False Or Button5.Enabled = False Or Button8.Enabled = False Or Button1.Enabled = False Or Button2.Enabled = False Or Button3.Enabled = False Then
            Dim errorsound As New System.Media.SoundPlayer(My.Resources.errorSound)
            errorsound.Play()
            MessageBox.Show("ERREUR : Vous ne pouvez lancer qu'un téléchargement à la fois.", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Button7.Text = "Téléchargement..."
            Button7.Enabled = False
            ProgressBar3.Visible = True
            Timer1.Start()
        End If
    End Sub

    Private Sub Button8_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        If Button6.Enabled = False Or Button7.Enabled = False Or Button5.Enabled = False Or Button1.Enabled = False Or Button2.Enabled = False Or Button3.Enabled = False Then
            Dim errorsound As New System.Media.SoundPlayer(My.Resources.errorSound)
            errorsound.Play()
            MessageBox.Show("ERREUR : Vous ne pouvez lancer qu'un téléchargement à la fois.", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Button8.Text = "Téléchargement..."
            Button8.Enabled = False
            ProgressBar4.Visible = True
            Timer1.Start()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Button6.Enabled = False Or Button7.Enabled = False Or Button5.Enabled = False Or Button8.Enabled = False Or Button2.Enabled = False Or Button3.Enabled = False Then
            Dim errorsound As New System.Media.SoundPlayer(My.Resources.errorSound)
            errorsound.Play()
            MessageBox.Show("ERREUR : Vous ne pouvez lancer qu'un téléchargement à la fois.", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf Button1.Text = "Téléchargé !" Then
            Dim errorsound As New System.Media.SoundPlayer(My.Resources.errorSound)
            errorsound.Play()
            MessageBox.Show("ERREUR : Votre logiciel a déjà été téléchargé.", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Button1.Text = "Téléchargement..."
            Button1.Enabled = False
            ProgressBar5.Visible = True
            Timer1.Start()
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If Button6.Enabled = False Or Button7.Enabled = False Or Button5.Enabled = False Or Button1.Enabled = False Or Button8.Enabled = False Or Button3.Enabled = False Then
            Dim errorsound As New System.Media.SoundPlayer(My.Resources.errorSound)
            errorsound.Play()
            MessageBox.Show("ERREUR : Vous ne pouvez lancer qu'un téléchargement à la fois.", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf Button2.Text = "Téléchargé !" Then
            Dim errorsound As New System.Media.SoundPlayer(My.Resources.errorSound)
            errorsound.Play()
            MessageBox.Show("ERREUR : Votre logiciel a déjà été téléchargé.", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Button2.Text = "Téléchargement..."
            Button2.Enabled = False
            ProgressBar6.Visible = True
            Timer1.Start()
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If Button6.Enabled = False Or Button7.Enabled = False Or Button5.Enabled = False Or Button1.Enabled = False Or Button2.Enabled = False Or Button8.Enabled = False Then
            Dim errorsound As New System.Media.SoundPlayer(My.Resources.errorSound)
            errorsound.Play()
            MessageBox.Show("ERREUR : Vous ne pouvez lancer qu'un téléchargement à la fois.", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Button3.Text = "Téléchargement..."
            Button3.Enabled = False
            ProgressBar7.Visible = True
            Timer1.Start()
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Button5.Enabled = False Then
            ProgressBar1.Increment(0.75)
            If ProgressBar1.Value = 100 Then
                Timer1.Stop()
                System.Diagnostics.Process.Start("https://discord.com/api/downloads/distributions/app/installers/latest?channel=stable&platform=win&arch=x86")
                Button5.Text = "Lancer le téléchargement"
                Button5.Enabled = True
                ProgressBar1.Value = 0
                ProgressBar1.Visible = False
                Applications.Button12.Visible = True
                Applications.Label1.Visible = False
            End If
        ElseIf Button6.Enabled = False Then
            ProgressBar2.Increment(0.75)
            If ProgressBar2.Value = 100 Then
                Timer1.Stop()
                '' POURQUOI GOOGLE FONT DES LIENS ULTRA LONG SA MERE ???
                System.Diagnostics.Process.Start("https://dl.google.com/tag/s/appguid%3D%7B8A69D345-D564-463C-AFF1-A69D9E530F96%7D%26iid%3D%7BC4F38CD2-40DE-EBE5-18B2-99D3A077C899%7D%26lang%3Dfr%26browser%3D2%26usagestats%3D1%26appname%3DGoogle%2520Chrome%26needsadmin%3Dprefers%26ap%3Dx64-stable-statsdef_1%26installdataindex%3Dempty/update2/installers/ChromeSetup.exe")
                Button6.Text = "Lancer le téléchargemnt"
                Button6.Enabled = True
                ProgressBar2.Value = 0
                ProgressBar2.Visible = False
                Applications.Button13.Visible = True
                Applications.Label1.Visible = False
            End If
        ElseIf Button7.Enabled = False Then
            ProgressBar3.Increment(0.75)
            If ProgressBar3.Value = 100 Then
                Timer1.Stop()
                System.Diagnostics.Process.Start("https://download.mozilla.org/?product=firefox-stub&os=win&lang=fr")
                Button7.Text = "Lancer le téléchargement"
                Button7.Enabled = True
                ProgressBar3.Value = 0
                ProgressBar3.Visible = False
                Applications.Button15.Visible = True
                Applications.Label1.Visible = False
            End If
        ElseIf Button8.Enabled = False Then
            ProgressBar4.Increment(0.75)
            If ProgressBar4.Value = 100 Then
                Timer1.Stop()
                System.Diagnostics.Process.Start("https://cdn.akamai.steamstatic.com/client/installer/SteamSetup.exe")
                Button8.Text = "Lancer le téléchargement"
                Button8.Enabled = True
                ProgressBar4.Value = 0
                ProgressBar4.Visible = False
                Applications.Button14.Visible = True
                Applications.Label1.Visible = False
            End If
        ElseIf Button1.Enabled = False Then
            ProgressBar5.Increment(0.75)
            If ProgressBar5.Value = 100 Then
                Timer1.Stop()
                game.Label12.Visible = True
                game.Label2.Visible = True
                Button1.Text = "Téléchargé !"
                Button1.Enabled = True
                ProgressBar5.Value = 0
                ProgressBar5.Visible = False
                Dim alertSound As New System.Media.SoundPlayer(My.Resources.alertSound)
                alertSound.Play()
                MessageBox.Show("Votre téléchargement est désormais terminé !", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        ElseIf Button2.Enabled = False Then
            ProgressBar6.Increment(0.75)
            If ProgressBar6.Value = 100 Then
                Timer1.Stop()
                Applications.Label1.Visible = False
                Applications.Button11.Visible = True
                Button2.Text = "Téléchargé !"
                Button2.Enabled = True
                ProgressBar6.Value = 0
                ProgressBar6.Visible = False
                Dim alertSound As New System.Media.SoundPlayer(My.Resources.alertSound)
                alertSound.Play()
                MessageBox.Show("Votre téléchargement est désormais terminé !", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        ElseIf Button3.Enabled = False Then
            ProgressBar7.Increment(0.75)
            If ProgressBar7.Value = 100 Then
                Timer1.Stop()
                System.Diagnostics.Process.Start("https://github.com/v38armageddon/Lecteur-PDF/archive/refs/heads/main.zip")
                Button3.Text = "Lancer le téléchargement"
                Button3.Enabled = True
                ProgressBar7.Value = 0
                ProgressBar7.Visible = False
            End If
        End If
    End Sub
End Class