Public Class Applications
    Dim execute As New Process

    Private Sub Applications_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Button11.Visible = True Or Button12.Visible = True Or Button13.Visible = True Or Button14.Visible = True Or Button15.Visible = True Then
            Label1.Visible = False
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Bing_Chrome.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Notepad.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        meme.Show()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Media.Show()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Visio.Show()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        exewin.Show()
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        paints.Show()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        game.Show()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Terminal.Show()
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        If Bureau.Visible = True Then
            Store.Show()
        ElseIf Bureau2.Visible = True Then
            UAC.Text = "Bureau2.SerVOS a besoin de votre autorisation !"
            UAC.Show()
        End If
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        chrono.Show()
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        If IsError(True) Then
            Dim errorsound As New System.Media.SoundPlayer(My.Resources.errorSound)
            errorsound.Play()
            MessageBox.Show("ERREUR : Cette application n'existe pas, il se peut qu'il se situe dans un autre emplacement que prévu, dans ce cas Vincent OS ne prends pas en charge l'exécution du fichier, si tel est le cas, veuillez signaler cette erreur.", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf IsError(False) Then
            '' /!\ Bien regarder si des changements de versions ont lieu pour mettre à jour la localisation du fichier ! /!\
            System.Diagnostics.Process.Start("C:\Users\%Username%\AppData\Local\Discord\app-1.0.9002\Discord.exe")
        End If
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        If IsError(True) Then
            Dim errorsound As New System.Media.SoundPlayer(My.Resources.errorSound)
            errorsound.Play()
            MessageBox.Show("ERREUR : Cette application n'existe pas, il se peut qu'il se situe dans un autre emplacement que prévu, dans ce cas Vincent OS ne prends pas en charge l'exécution du fichier, si tel est le cas, veuillez signaler cette erreur.", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            System.Diagnostics.Process.Start("firefox.exe")
        End If
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        If IsError(True) Then
            Dim errorsound As New System.Media.SoundPlayer(My.Resources.errorSound)
            errorsound.Play()
            MessageBox.Show("ERREUR : Cette application n'existe pas, il se peut qu'il se situe dans un autre emplacement que prévu, dans ce cas Vincent OS ne prends pas en charge l'exécution du fichier, si tel est le cas, veuillez signaler cette erreur.", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            System.Diagnostics.Process.Start("chrome.exe")
        End If
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        If IsError(True) Then
            Dim errorsound As New System.Media.SoundPlayer(My.Resources.errorSound)
            errorsound.Play()
            MessageBox.Show("ERREUR : Cette application n'existe pas, il se peut qu'il se situe dans un autre emplacement que prévu, dans ce cas Vincent OS ne prends pas en charge l'exécution du fichier, si tel est le cas, veuillez signaler cette erreur.", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            System.Diagnostics.Process.Start("C:\Program Files (x86)\Steam\Steam.exe")
        End If
    End Sub
End Class