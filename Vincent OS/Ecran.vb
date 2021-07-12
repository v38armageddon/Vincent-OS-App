Public Class Ecran

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        OpenFileDialog1.Filter = "Images|*.jpeg;*.jpg;*.png;*.bmp;"
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            If Bureau.Visible = True Then
                Bureau.FlowLayoutPanel1.BackgroundImage = Image.FromFile(OpenFileDialog1.FileName)
                If Bureau.FlowLayoutPanel1.BackgroundImage.Width > 864 And Bureau.FlowLayoutPanel1.BackgroundImage.Height > 420 Or My.Computer.Screen.Bounds.Width And My.Computer.Screen.Bounds.Height Then
                    Bureau.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Stretch
                Else
                    Bureau.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Zoom
                End If
                Panel1.Visible = True
            ElseIf Bureau2.Visible = True Then
                Bureau2.FlowLayoutPanel1.BackgroundImage = Image.FromFile(OpenFileDialog1.FileName)
                If Bureau2.FlowLayoutPanel1.Width > 864 And Bureau2.FlowLayoutPanel1.BackgroundImage.Height > 420 Or My.Computer.Screen.Bounds.Width And My.Computer.Screen.Bounds.Height Then
                    Bureau2.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Stretch
                Else
                    Bureau2.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Zoom
                End If
                Panel1.Visible = True
            End If
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If RadioButton1.Checked = True Then
            If Bureau.Visible = True Then
                Bureau.FlowLayoutPanel1.BackgroundImage = My.Resources.fond_écran_login
                If Bureau.FlowLayoutPanel1.BackgroundImage.Width > 864 And Bureau.FlowLayoutPanel1.BackgroundImage.Height > 420 Or My.Computer.Screen.Bounds.Width And My.Computer.Screen.Bounds.Height Then
                    Bureau.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Stretch
                Else
                    Bureau.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Zoom
                End If
                Panel2.Visible = True
            ElseIf Bureau2.Visible = True Then
                Bureau2.FlowLayoutPanel1.BackgroundImage = My.Resources.fond_écran_login
                If Bureau2.FlowLayoutPanel1.Width > 864 And Bureau2.FlowLayoutPanel1.BackgroundImage.Height > 420 Or My.Computer.Screen.Bounds.Width And My.Computer.Screen.Bounds.Height Then
                    Bureau2.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Stretch
                Else
                    Bureau2.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Zoom
                End If
                Panel2.Visible = True
            End If
        ElseIf RadioButton2.Checked = True Then
            If Bureau.Visible = True Then
                Bureau.FlowLayoutPanel1.BackgroundImage = My.Resources.fond_écran_superutilisateur
                If Bureau.FlowLayoutPanel1.BackgroundImage.Width > 864 And Bureau.FlowLayoutPanel1.BackgroundImage.Height > 420 Or My.Computer.Screen.Bounds.Width And My.Computer.Screen.Bounds.Height Then
                    Bureau.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Stretch
                Else
                    Bureau.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Zoom
                End If
                Panel2.Visible = True
            ElseIf Bureau2.Visible = True Then
                Bureau2.FlowLayoutPanel1.BackgroundImage = My.Resources.fond_écran_superutilisateur
                If Bureau2.FlowLayoutPanel1.Width > 864 And Bureau2.FlowLayoutPanel1.BackgroundImage.Height > 420 Or My.Computer.Screen.Bounds.Width And My.Computer.Screen.Bounds.Height Then
                    Bureau2.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Stretch
                Else
                    Bureau2.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Zoom
                End If
                Panel2.Visible = True
            End If
        ElseIf RadioButton3.Checked = True Then
            If Bureau.Visible = True Then
                Bureau.FlowLayoutPanel1.BackgroundImage = My.Resources.fond_écran_invité
                If Bureau.FlowLayoutPanel1.BackgroundImage.Width > 864 And Bureau.FlowLayoutPanel1.BackgroundImage.Height > 420 Or My.Computer.Screen.Bounds.Width And My.Computer.Screen.Bounds.Height Then
                    Bureau.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Stretch
                Else
                    Bureau.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Zoom
                End If
                Panel2.Visible = True
            ElseIf Bureau2.Visible = True Then
                Bureau2.FlowLayoutPanel1.BackgroundImage = My.Resources.fond_écran_invité
                If Bureau2.FlowLayoutPanel1.Width > 864 And Bureau2.FlowLayoutPanel1.BackgroundImage.Height > 420 Or My.Computer.Screen.Bounds.Width And My.Computer.Screen.Bounds.Height Then
                    Bureau2.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Stretch
                Else
                    Bureau2.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Zoom
                End If
                Panel2.Visible = True
            End If
        ElseIf RadioButton4.Checked = True Then
            If Bureau.Visible = True Then
                Bureau.FlowLayoutPanel1.BackgroundImage = My.Resources.Fond_decran6
                If Bureau.FlowLayoutPanel1.BackgroundImage.Width > 864 And Bureau.FlowLayoutPanel1.BackgroundImage.Height > 420 Or My.Computer.Screen.Bounds.Width And My.Computer.Screen.Bounds.Height Then
                    Bureau.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Stretch
                Else
                    Bureau.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Zoom
                End If
                Panel2.Visible = True
            ElseIf Bureau2.Visible = True Then
                Bureau2.FlowLayoutPanel1.BackgroundImage = My.Resources.Fond_decran6
                If Bureau2.FlowLayoutPanel1.Width > 864 And Bureau2.FlowLayoutPanel1.BackgroundImage.Height > 420 Or My.Computer.Screen.Bounds.Width And My.Computer.Screen.Bounds.Height Then
                    Bureau2.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Stretch
                Else
                    Bureau2.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Zoom
                End If
                Panel2.Visible = True
            End If
        ElseIf RadioButton5.Checked = True Then
            If Bureau.Visible = True Then
                Bureau.FlowLayoutPanel1.BackgroundImage = My.Resources.image0
                If Bureau.FlowLayoutPanel1.BackgroundImage.Width > 864 And Bureau.FlowLayoutPanel1.BackgroundImage.Height > 420 Or My.Computer.Screen.Bounds.Width And My.Computer.Screen.Bounds.Height Then
                    Bureau.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Stretch
                Else
                    Bureau.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Zoom
                End If
                Panel2.Visible = True
            ElseIf Bureau2.Visible = True Then
                Bureau2.FlowLayoutPanel1.BackgroundImage = My.Resources.image0
                If Bureau2.FlowLayoutPanel1.Width > 864 And Bureau2.FlowLayoutPanel1.BackgroundImage.Height > 420 Or My.Computer.Screen.Bounds.Width And My.Computer.Screen.Bounds.Height Then
                    Bureau2.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Stretch
                Else
                    Bureau2.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Zoom
                End If
                Panel2.Visible = True
            End If
        ElseIf RadioButton6.Checked = True Then
            If Bureau.Visible = True Then
                Bureau.FlowLayoutPanel1.BackgroundImage = My.Resources.fond_écran_kiki
                If Bureau.FlowLayoutPanel1.BackgroundImage.Width > 864 And Bureau.FlowLayoutPanel1.BackgroundImage.Height > 420 Or My.Computer.Screen.Bounds.Width And My.Computer.Screen.Bounds.Height Then
                    Bureau.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Stretch
                Else
                    Bureau.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Zoom
                End If
                Panel2.Visible = True
            ElseIf Bureau2.Visible = True Then
                Bureau2.FlowLayoutPanel1.BackgroundImage = My.Resources.fond_écran_kiki
                If Bureau2.FlowLayoutPanel1.Width > 864 And Bureau2.FlowLayoutPanel1.BackgroundImage.Height > 420 Or My.Computer.Screen.Bounds.Width And My.Computer.Screen.Bounds.Height Then
                    Bureau2.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Stretch
                Else
                    Bureau2.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Zoom
                End If
                Panel2.Visible = True
            End If
        ElseIf RadioButton7.Checked = True Then
            If Bureau.Visible = True Then
                Bureau.FlowLayoutPanel1.BackgroundImage = My.Resources.Fond_decran1
                If Bureau.FlowLayoutPanel1.BackgroundImage.Width > 864 And Bureau.FlowLayoutPanel1.BackgroundImage.Height > 420 Or My.Computer.Screen.Bounds.Width And My.Computer.Screen.Bounds.Height Then
                    Bureau.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Stretch
                Else
                    Bureau.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Zoom
                End If
                Panel2.Visible = True
            ElseIf Bureau2.Visible = True Then
                Bureau2.FlowLayoutPanel1.BackgroundImage = My.Resources.Fond_decran1
                If Bureau2.FlowLayoutPanel1.Width > 864 And Bureau2.FlowLayoutPanel1.BackgroundImage.Height > 420 Or My.Computer.Screen.Bounds.Width And My.Computer.Screen.Bounds.Height Then
                    Bureau2.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Stretch
                Else
                    Bureau2.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Zoom
                End If
                Panel2.Visible = True
            End If
        ElseIf RadioButton8.Checked = True Then
            If Bureau.Visible = True Then
                Bureau.FlowLayoutPanel1.BackgroundImage = My.Resources.Fond_decran2
                If Bureau.FlowLayoutPanel1.BackgroundImage.Width > 864 And Bureau.FlowLayoutPanel1.BackgroundImage.Height > 420 Or My.Computer.Screen.Bounds.Width And My.Computer.Screen.Bounds.Height Then
                    Bureau.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Stretch
                Else
                    Bureau.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Zoom
                End If
                Panel2.Visible = True
            ElseIf Bureau2.Visible = True Then
                Bureau2.FlowLayoutPanel1.BackgroundImage = My.Resources.Fond_decran2
                If Bureau2.FlowLayoutPanel1.Width > 864 And Bureau2.FlowLayoutPanel1.BackgroundImage.Height > 420 Or My.Computer.Screen.Bounds.Width And My.Computer.Screen.Bounds.Height Then
                    Bureau2.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Stretch
                Else
                    Bureau2.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Zoom
                End If
                Panel2.Visible = True
            End If
        Else
            MessageBox.Show("ERREUR : Vous n'avez sélectionné aucun fond d'écran.", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If RadioButton15.Checked = True Then
            If Bureau.Visible = True Then
                Bureau.FlowLayoutPanel1.BackgroundImage = My.Resources.zeyatsu1
                If Bureau.FlowLayoutPanel1.BackgroundImage.Width > 864 And Bureau.FlowLayoutPanel1.BackgroundImage.Height > 420 Or My.Computer.Screen.Bounds.Width And My.Computer.Screen.Bounds.Height Then
                    Bureau.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Stretch
                Else
                    Bureau.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Zoom
                End If
                Panel2.Visible = True
            ElseIf Bureau2.Visible = True Then
                Bureau2.FlowLayoutPanel1.BackgroundImage = My.Resources.zeyatsu1
                If Bureau2.FlowLayoutPanel1.Width > 864 And Bureau2.FlowLayoutPanel1.BackgroundImage.Height > 420 Or My.Computer.Screen.Bounds.Width And My.Computer.Screen.Bounds.Height Then
                    Bureau2.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Stretch
                Else
                    Bureau2.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Zoom
                End If
                Panel2.Visible = True
            End If
        ElseIf RadioButton14.Checked = True Then
            If Bureau.Visible = True Then
                Bureau.FlowLayoutPanel1.BackgroundImage = My.Resources.spaceutilisateur
                If Bureau.FlowLayoutPanel1.BackgroundImage.Width > 864 And Bureau.FlowLayoutPanel1.BackgroundImage.Height > 420 Or My.Computer.Screen.Bounds.Width And My.Computer.Screen.Bounds.Height Then
                    Bureau.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Stretch
                Else
                    Bureau.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Zoom
                End If
                Panel2.Visible = True
            ElseIf Bureau2.Visible = True Then
                Bureau2.FlowLayoutPanel1.BackgroundImage = My.Resources.spaceutilisateur
                If Bureau2.FlowLayoutPanel1.Width > 864 And Bureau2.FlowLayoutPanel1.BackgroundImage.Height > 420 Or My.Computer.Screen.Bounds.Width And My.Computer.Screen.Bounds.Height Then
                    Bureau2.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Stretch
                Else
                    Bureau2.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Zoom
                End If
                Panel2.Visible = True
            End If
        ElseIf RadioButton13.Checked = True Then
            If Bureau.Visible = True Then
                Bureau.FlowLayoutPanel1.BackgroundImage = My.Resources.fond_écran_kiki2
                If Bureau.FlowLayoutPanel1.BackgroundImage.Width > 864 And Bureau.FlowLayoutPanel1.BackgroundImage.Height > 420 Or My.Computer.Screen.Bounds.Width And My.Computer.Screen.Bounds.Height Then
                    Bureau.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Stretch
                Else
                    Bureau.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Zoom
                End If
                Panel2.Visible = True
            ElseIf Bureau2.Visible = True Then
                Bureau2.FlowLayoutPanel1.BackgroundImage = My.Resources.fond_écran_kiki2
                If Bureau2.FlowLayoutPanel1.Width > 864 And Bureau2.FlowLayoutPanel1.BackgroundImage.Height > 420 Or My.Computer.Screen.Bounds.Width And My.Computer.Screen.Bounds.Height Then
                    Bureau2.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Stretch
                Else
                    Bureau2.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Zoom
                End If
                Panel2.Visible = True
            End If
        ElseIf RadioButton12.Checked = True Then
            If Bureau.Visible = True Then
                Bureau.FlowLayoutPanel1.BackgroundImage = My.Resources.fond_vincentOS_11
                If Bureau.FlowLayoutPanel1.BackgroundImage.Width > 864 And Bureau.FlowLayoutPanel1.BackgroundImage.Height > 420 Or My.Computer.Screen.Bounds.Width And My.Computer.Screen.Bounds.Height Then
                    Bureau.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Stretch
                Else
                    Bureau.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Zoom
                End If
                Panel2.Visible = True
            ElseIf Bureau2.Visible = True Then
                Bureau2.FlowLayoutPanel1.BackgroundImage = My.Resources.fond_vincentOS_11
                If Bureau2.FlowLayoutPanel1.Width > 864 And Bureau2.FlowLayoutPanel1.BackgroundImage.Height > 420 Or My.Computer.Screen.Bounds.Width And My.Computer.Screen.Bounds.Height Then
                    Bureau2.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Stretch
                Else
                    Bureau2.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Zoom
                End If
                Panel2.Visible = True
            End If
        ElseIf RadioButton11.Checked = True Then
            If Bureau.Visible = True Then
                Bureau.FlowLayoutPanel1.BackgroundImage = My.Resources.Wallpaper_2
                If Bureau.FlowLayoutPanel1.BackgroundImage.Width > 864 And Bureau.FlowLayoutPanel1.BackgroundImage.Height > 420 Or My.Computer.Screen.Bounds.Width And My.Computer.Screen.Bounds.Height Then
                    Bureau.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Stretch
                Else
                    Bureau.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Zoom
                End If
                Panel2.Visible = True
            ElseIf Bureau2.Visible = True Then
                Bureau2.FlowLayoutPanel1.BackgroundImage = My.Resources.Wallpaper_2
                If Bureau2.FlowLayoutPanel1.Width > 864 And Bureau2.FlowLayoutPanel1.BackgroundImage.Height > 420 Or My.Computer.Screen.Bounds.Width And My.Computer.Screen.Bounds.Height Then
                    Bureau2.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Stretch
                Else
                    Bureau2.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Zoom
                End If
                Panel2.Visible = True
            End If
        ElseIf RadioButton10.Checked = True Then
            If Bureau.Visible = True Then
                Bureau.FlowLayoutPanel1.BackgroundImage = My.Resources.Wallpaper_3
                If Bureau.FlowLayoutPanel1.BackgroundImage.Width > 864 And Bureau.FlowLayoutPanel1.BackgroundImage.Height > 420 Or My.Computer.Screen.Bounds.Width And My.Computer.Screen.Bounds.Height Then
                    Bureau.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Stretch
                Else
                    Bureau.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Zoom
                End If
                Panel2.Visible = True
            ElseIf Bureau2.Visible = True Then
                Bureau2.FlowLayoutPanel1.BackgroundImage = My.Resources.Wallpaper_3
                If Bureau2.FlowLayoutPanel1.Width > 864 And Bureau2.FlowLayoutPanel1.BackgroundImage.Height > 420 Or My.Computer.Screen.Bounds.Width And My.Computer.Screen.Bounds.Height Then
                    Bureau2.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Stretch
                Else
                    Bureau2.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Zoom
                End If
                Panel2.Visible = True
            End If
        ElseIf RadioButton11.Checked = True Then
            If Bureau.Visible = True Then
                Bureau.FlowLayoutPanel1.BackgroundImage = My.Resources.Wallpaper_3
                If Bureau.FlowLayoutPanel1.BackgroundImage.Width > 864 And Bureau.FlowLayoutPanel1.BackgroundImage.Height > 420 Or My.Computer.Screen.Bounds.Width And My.Computer.Screen.Bounds.Height Then
                    Bureau.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Stretch
                Else
                    Bureau.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Zoom
                End If
                Panel2.Visible = True
            ElseIf Bureau2.Visible = True Then
                Bureau2.FlowLayoutPanel1.BackgroundImage = My.Resources.Wallpaper_3
                If Bureau2.FlowLayoutPanel1.Width > 864 And Bureau2.FlowLayoutPanel1.BackgroundImage.Height > 420 Or My.Computer.Screen.Bounds.Width And My.Computer.Screen.Bounds.Height Then
                    Bureau2.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Stretch
                Else
                    Bureau2.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Zoom
                End If
                Panel2.Visible = True
            End If
        ElseIf RadioButton9.Checked = True Then
            If Bureau.Visible = True Then
                Bureau.FlowLayoutPanel1.BackgroundImage = My.Resources.Wallpaper_4
                If Bureau.FlowLayoutPanel1.BackgroundImage.Width > 864 And Bureau.FlowLayoutPanel1.BackgroundImage.Height > 420 Or My.Computer.Screen.Bounds.Width And My.Computer.Screen.Bounds.Height Then
                    Bureau.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Stretch
                Else
                    Bureau.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Zoom
                End If
                Panel2.Visible = True
            ElseIf Bureau2.Visible = True Then
                Bureau2.FlowLayoutPanel1.BackgroundImage = My.Resources.Wallpaper_4
                If Bureau2.FlowLayoutPanel1.Width > 864 And Bureau2.FlowLayoutPanel1.BackgroundImage.Height > 420 Or My.Computer.Screen.Bounds.Width And My.Computer.Screen.Bounds.Height Then
                    Bureau2.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Stretch
                Else
                    Bureau2.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Zoom
                End If
                Panel2.Visible = True
            End If
        Else
            MessageBox.Show("ERREUR : Vous n'avez sélectionné aucun fond d'écran.", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class