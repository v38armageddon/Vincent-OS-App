Public Class Azkan

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        Dim backmusic As New System.Media.SoundPlayer(My.Resources.alertSound)
        backmusic.Play()
        MessageBox.Show("Vous allez désormais afficher les processus systèmes, une fois que vous allez arrêter un processus système, il est impossible de le relancer, à vos risques et périls !", "Alerte", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        FlowLayoutPanel2.Visible = True
        CheckBox1.Enabled = False
    End Sub

    Private Sub Azkan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Bing_Chrome.Visible = True Then
            RadioButton2.Visible = True
        End If
        If exewin.Visible = True Then
            RadioButton10.Visible = True
        End If
        If game.Visible = True Then
            RadioButton8.Visible = True
        End If
        If meme.Visible = True Then
            RadioButton3.Visible = True
        End If
        If News.Visible = True Then
            RadioButton12.Visible = True
        End If
        If Notepad.Visible = True Then
            RadioButton4.Visible = True
        End If
        If MazeGame.Visible = True Then
            RadioButton9.Visible = True
        End If
        If Media.Visible = True Then
            RadioButton5.Visible = True
        End If
        If paints.Visible = True Then
            RadioButton7.Visible = True
        End If
        If Terminal.Visible = True Then
            RadioButton11.Visible = True
        End If
        If Visio.Visible = True Then
            RadioButton6.Visible = True
        End If
        If Applications.Visible = True Then
            RadioButton15.Visible = True
        End If
        If Bureau.Visible = True Then
            RadioButton13.Visible = True
            RadioButton17.Visible = True
        End If
        If Bureau2.Visible = True Then
            RadioButton14.Visible = True
            RadioButton18.Visible = True
        End If
        If Options.Visible = True Then
            RadioButton16.Visible = True
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If RadioButton1.Checked = True Then
            Me.Close()
        ElseIf RadioButton2.Checked = True Then
            Bing_Chrome.Close()
        ElseIf RadioButton3.Checked = True Then
            meme.Close()
        ElseIf RadioButton4.Checked = True Then
            Notepad.Close()
        ElseIf RadioButton5.Checked = True Then
            Media.Close()
        ElseIf RadioButton6.Checked = True Then
            Visio.Close()
        ElseIf RadioButton7.Checked = True Then
            paints.Close()
        ElseIf RadioButton8.Checked = True Then
            game.Close()
        ElseIf RadioButton9.Checked = True Then
            MazeGame.Close()
        ElseIf RadioButton10.Checked = True Then
            exewin.Close()
        ElseIf RadioButton11.Checked = True Then
            Terminal.Close()
        ElseIf RadioButton12.Checked = True Then
            News.Close()
        ElseIf RadioButton13.Checked = True Then
            Bureau.Close()
        ElseIf RadioButton14.Checked = True Then
            Bureau2.Close()
        ElseIf RadioButton15.Checked = True Then
            Applications.Close()
        ElseIf RadioButton16.Checked = True Then
            Options.Close()
        Else
            MessageBox.Show("Erreur : Vous avez sélectionné aucune application à arrêter", "Erreur")
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If RadioButton17.Checked = True Then
            Bureau.Close()
            Login.Show()
            Me.Close()
        ElseIf RadioButton18.Checked = True Then
            Bureau2.Close()
            Login.Show()
            Me.Close()
        Else
            MessageBox.Show("Erreur : Vous avez sélectionné aucune application à arrêter", "Erreur")
        End If
    End Sub
End Class