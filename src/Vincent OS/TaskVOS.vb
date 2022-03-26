Public Class TaskVOS

    Private Sub TaskVOS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '' Application
        If Bing_Chrome.Visible = True Then
            PictureBox1.Visible = True
            RadioButton2.Visible = True
        End If
        If Calc.Visible = True Then
            PictureBox2.Visible = True
            RadioButton12.Visible = True
        End If
        If chrono.Visible = True Then
            PictureBox3.Visible = True
            RadioButton20.Visible = True
        End If
        If exewin.Visible = True Then
            PictureBox4.Visible = True
            RadioButton10.Visible = True
        End If
        If game.Visible = True Then
            PictureBox5.Visible = True
            RadioButton8.Visible = True
        End If
        If meme.Visible = True Then
            PictureBox8.Visible = True
            RadioButton3.Visible = True
        End If
        If Notepad.Visible = True Then
            PictureBox9.Visible = True
            RadioButton4.Visible = True
        End If
        If MazeGame.Visible = True Then
            PictureBox6.Visible = True
            RadioButton9.Visible = True
        End If
        If Media.Visible = True Then
            PictureBox7.Visible = True
            RadioButton5.Visible = True
        End If
        If paints.Visible = True Then
            PictureBox10.Visible = True
            RadioButton7.Visible = True
        End If
        If Store.Visible = True Then
            PictureBox11.Visible = True
            RadioButton19.Visible = True
        End If
        If Terminal.Visible = True Then
            PictureBox13.Visible = True
            RadioButton11.Visible = True
        End If
        If Visio.Visible = True Then
            PictureBox14.Visible = True
            RadioButton6.Visible = True
        End If

        '' Service

        If Applications.Visible = True Then
            PictureBox15.Visible = True
            RadioButton15.Visible = True
        End If
        If Bureau.Visible = True Then
            PictureBox16.Visible = True
            RadioButton13.Visible = True
            PictureBox19.Visible = True
            RadioButton17.Visible = True
        End If
        If Bureau2.Visible = True Then
            PictureBox17.Visible = True
            RadioButton14.Visible = True
            PictureBox20.Visible = True
            RadioButton18.Visible = True
        End If
        If Paramètres.Visible = True Then
            PictureBox18.Visible = True
            RadioButton16.Visible = True
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If RadioButton2.Checked = True Then
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
            Calc.Close()
        ElseIf RadioButton19.Checked = True Then
            Store.Close()
        ElseIf RadioButton20.Checked = True Then
            chrono.Close()
        Else
            Dim backmusic As New System.Media.SoundPlayer(My.Resources.errorSound)
        backmusic.Play()
        MessageBox.Show("Erreur : Vous n'avez sélectionné aucune application à arrêter.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
            Dim backmusic As New System.Media.SoundPlayer(My.Resources.errorSound)
            backmusic.Play()
            MessageBox.Show("Erreur : Vous avez sélectionné aucun utilisateur à arrêter.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If RadioButton13.Checked = True Then
            Bureau.Close()
        ElseIf RadioButton14.Checked = True Then
            Bureau2.Close()
        ElseIf RadioButton15.Checked = True Then
            Applications.Close()
        ElseIf RadioButton16.Checked = True Then
            Paramètres.Close()
        Else
            Dim backmusic As New System.Media.SoundPlayer(My.Resources.errorSound)
            backmusic.Play()
            MessageBox.Show("Erreur : Vous avez sélectionné aucun service à arrêter.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class