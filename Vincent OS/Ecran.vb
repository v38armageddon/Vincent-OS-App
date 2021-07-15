Public Class Ecran

    ' Onglet Autre/Personnalisé
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
            ElseIf Bureau2.Visible = True Then
                Bureau2.FlowLayoutPanel1.BackgroundImage = Image.FromFile(OpenFileDialog1.FileName)
                If Bureau2.FlowLayoutPanel1.Width > 864 And Bureau2.FlowLayoutPanel1.BackgroundImage.Height > 420 Or My.Computer.Screen.Bounds.Width And My.Computer.Screen.Bounds.Height Then
                    Bureau2.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Stretch
                Else
                    Bureau2.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Zoom
                End If
            End If
        End If
    End Sub

    ' Onglet Vincent OS 4
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If RadioButton1.Checked = True Then
            If Bureau.Visible = True Then
                Bureau.FlowLayoutPanel1.BackgroundImage = PictureBox1.Image
                If Bureau.FlowLayoutPanel1.BackgroundImage.Width > 864 And Bureau.FlowLayoutPanel1.BackgroundImage.Height > 420 Or My.Computer.Screen.Bounds.Width And My.Computer.Screen.Bounds.Height Then
                    Bureau.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Stretch
                Else
                    Bureau.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Zoom
                End If
            ElseIf Bureau2.Visible = True Then
                Bureau2.FlowLayoutPanel1.BackgroundImage = PictureBox1.Image
                If Bureau2.FlowLayoutPanel1.Width > 864 And Bureau2.FlowLayoutPanel1.BackgroundImage.Height > 420 Or My.Computer.Screen.Bounds.Width And My.Computer.Screen.Bounds.Height Then
                    Bureau2.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Stretch
                Else
                    Bureau2.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Zoom
                End If
            End If
        ElseIf RadioButton2.Checked = True Then
            If Bureau.Visible = True Then
                Bureau.FlowLayoutPanel1.BackgroundImage = PictureBox2.Image
                If Bureau.FlowLayoutPanel1.BackgroundImage.Width > 864 And Bureau.FlowLayoutPanel1.BackgroundImage.Height > 420 Or My.Computer.Screen.Bounds.Width And My.Computer.Screen.Bounds.Height Then
                    Bureau.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Stretch
                Else
                    Bureau.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Zoom
                End If
            ElseIf Bureau2.Visible = True Then
                Bureau2.FlowLayoutPanel1.BackgroundImage = PictureBox2.Image
                If Bureau2.FlowLayoutPanel1.Width > 864 And Bureau2.FlowLayoutPanel1.BackgroundImage.Height > 420 Or My.Computer.Screen.Bounds.Width And My.Computer.Screen.Bounds.Height Then
                    Bureau2.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Stretch
                Else
                    Bureau2.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Zoom
                End If
            End If
        ElseIf RadioButton3.Checked = True Then
            If Bureau.Visible = True Then
                Bureau.FlowLayoutPanel1.BackgroundImage = PictureBox3.Image
                If Bureau.FlowLayoutPanel1.BackgroundImage.Width > 864 And Bureau.FlowLayoutPanel1.BackgroundImage.Height > 420 Or My.Computer.Screen.Bounds.Width And My.Computer.Screen.Bounds.Height Then
                    Bureau.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Stretch
                Else
                    Bureau.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Zoom
                End If
            ElseIf Bureau2.Visible = True Then
                Bureau2.FlowLayoutPanel1.BackgroundImage = PictureBox3.Image
                If Bureau2.FlowLayoutPanel1.Width > 864 And Bureau2.FlowLayoutPanel1.BackgroundImage.Height > 420 Or My.Computer.Screen.Bounds.Width And My.Computer.Screen.Bounds.Height Then
                    Bureau2.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Stretch
                Else
                    Bureau2.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Zoom
                End If
            End If
        ElseIf RadioButton4.Checked = True Then
            If Bureau.Visible = True Then
                Bureau.FlowLayoutPanel1.BackgroundImage = PictureBox4.Image
                If Bureau.FlowLayoutPanel1.BackgroundImage.Width > 864 And Bureau.FlowLayoutPanel1.BackgroundImage.Height > 420 Or My.Computer.Screen.Bounds.Width And My.Computer.Screen.Bounds.Height Then
                    Bureau.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Stretch
                Else
                    Bureau.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Zoom
                End If
            ElseIf Bureau2.Visible = True Then
                Bureau2.FlowLayoutPanel1.BackgroundImage = PictureBox4.Image
                If Bureau2.FlowLayoutPanel1.Width > 864 And Bureau2.FlowLayoutPanel1.BackgroundImage.Height > 420 Or My.Computer.Screen.Bounds.Width And My.Computer.Screen.Bounds.Height Then
                    Bureau2.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Stretch
                Else
                    Bureau2.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Zoom
                End If
            End If
        ElseIf RadioButton5.Checked = True Then
            If Bureau.Visible = True Then
                Bureau.FlowLayoutPanel1.BackgroundImage = PictureBox5.Image
                If Bureau.FlowLayoutPanel1.BackgroundImage.Width > 864 And Bureau.FlowLayoutPanel1.BackgroundImage.Height > 420 Or My.Computer.Screen.Bounds.Width And My.Computer.Screen.Bounds.Height Then
                    Bureau.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Stretch
                Else
                    Bureau.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Zoom
                End If
            ElseIf Bureau2.Visible = True Then
                Bureau2.FlowLayoutPanel1.BackgroundImage = PictureBox5.Image
                If Bureau2.FlowLayoutPanel1.Width > 864 And Bureau2.FlowLayoutPanel1.BackgroundImage.Height > 420 Or My.Computer.Screen.Bounds.Width And My.Computer.Screen.Bounds.Height Then
                    Bureau2.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Stretch
                Else
                    Bureau2.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Zoom
                End If
            End If
        ElseIf RadioButton6.Checked = True Then
            If Bureau.Visible = True Then
                Bureau.FlowLayoutPanel1.BackgroundImage = PictureBox6.Image
                If Bureau.FlowLayoutPanel1.BackgroundImage.Width > 864 And Bureau.FlowLayoutPanel1.BackgroundImage.Height > 420 Or My.Computer.Screen.Bounds.Width And My.Computer.Screen.Bounds.Height Then
                    Bureau.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Stretch
                Else
                    Bureau.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Zoom
                End If
            ElseIf Bureau2.Visible = True Then
                Bureau2.FlowLayoutPanel1.BackgroundImage = PictureBox6.Image
                If Bureau2.FlowLayoutPanel1.Width > 864 And Bureau2.FlowLayoutPanel1.BackgroundImage.Height > 420 Or My.Computer.Screen.Bounds.Width And My.Computer.Screen.Bounds.Height Then
                    Bureau2.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Stretch
                Else
                    Bureau2.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Zoom
                End If
            End If
        ElseIf RadioButton7.Checked = True Then
            If Bureau.Visible = True Then
                Bureau.FlowLayoutPanel1.BackgroundImage = PictureBox7.Image
                If Bureau.FlowLayoutPanel1.BackgroundImage.Width > 864 And Bureau.FlowLayoutPanel1.BackgroundImage.Height > 420 Or My.Computer.Screen.Bounds.Width And My.Computer.Screen.Bounds.Height Then
                    Bureau.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Stretch
                Else
                    Bureau.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Zoom
                End If
            ElseIf Bureau2.Visible = True Then
                Bureau2.FlowLayoutPanel1.BackgroundImage = PictureBox7.Image
                If Bureau2.FlowLayoutPanel1.Width > 864 And Bureau2.FlowLayoutPanel1.BackgroundImage.Height > 420 Or My.Computer.Screen.Bounds.Width And My.Computer.Screen.Bounds.Height Then
                    Bureau2.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Stretch
                Else
                    Bureau2.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Zoom
                End If
            End If
        ElseIf RadioButton8.Checked = True Then
            If Bureau.Visible = True Then
                Bureau.FlowLayoutPanel1.BackgroundImage = PictureBox8.Image
                If Bureau.FlowLayoutPanel1.BackgroundImage.Width > 864 And Bureau.FlowLayoutPanel1.BackgroundImage.Height > 420 Or My.Computer.Screen.Bounds.Width And My.Computer.Screen.Bounds.Height Then
                    Bureau.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Stretch
                Else
                    Bureau.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Zoom
                End If
            ElseIf Bureau2.Visible = True Then
                Bureau2.FlowLayoutPanel1.BackgroundImage = PictureBox8.Image
                If Bureau2.FlowLayoutPanel1.Width > 864 And Bureau2.FlowLayoutPanel1.BackgroundImage.Height > 420 Or My.Computer.Screen.Bounds.Width And My.Computer.Screen.Bounds.Height Then
                    Bureau2.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Stretch
                Else
                    Bureau2.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Zoom
                End If
            End If
        Else
            MessageBox.Show("ERREUR : Vous n'avez sélectionné aucun fond d'écran.", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    ' Onglet Vincent OS 5
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If RadioButton15.Checked = True Then
            If Bureau.Visible = True Then
                Bureau.FlowLayoutPanel1.BackgroundImage = PictureBox15.Image
                If Bureau.FlowLayoutPanel1.BackgroundImage.Width > 864 And Bureau.FlowLayoutPanel1.BackgroundImage.Height > 420 Or My.Computer.Screen.Bounds.Width And My.Computer.Screen.Bounds.Height Then
                    Bureau.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Stretch
                Else
                    Bureau.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Zoom
                End If
            ElseIf Bureau2.Visible = True Then
                Bureau2.FlowLayoutPanel1.BackgroundImage = PictureBox15.Image
                If Bureau2.FlowLayoutPanel1.Width > 864 And Bureau2.FlowLayoutPanel1.BackgroundImage.Height > 420 Or My.Computer.Screen.Bounds.Width And My.Computer.Screen.Bounds.Height Then
                    Bureau2.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Stretch
                Else
                    Bureau2.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Zoom
                End If
            End If
        ElseIf RadioButton14.Checked = True Then
            If Bureau.Visible = True Then
                Bureau.FlowLayoutPanel1.BackgroundImage = PictureBox14.Image
                If Bureau.FlowLayoutPanel1.BackgroundImage.Width > 864 And Bureau.FlowLayoutPanel1.BackgroundImage.Height > 420 Or My.Computer.Screen.Bounds.Width And My.Computer.Screen.Bounds.Height Then
                    Bureau.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Stretch
                Else
                    Bureau.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Zoom
                End If
            ElseIf Bureau2.Visible = True Then
                Bureau2.FlowLayoutPanel1.BackgroundImage = PictureBox14.Image
                If Bureau2.FlowLayoutPanel1.Width > 864 And Bureau2.FlowLayoutPanel1.BackgroundImage.Height > 420 Or My.Computer.Screen.Bounds.Width And My.Computer.Screen.Bounds.Height Then
                    Bureau2.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Stretch
                Else
                    Bureau2.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Zoom
                End If
            End If
        ElseIf RadioButton13.Checked = True Then
            If Bureau.Visible = True Then
                Bureau.FlowLayoutPanel1.BackgroundImage = PictureBox13.Image
                If Bureau.FlowLayoutPanel1.BackgroundImage.Width > 864 And Bureau.FlowLayoutPanel1.BackgroundImage.Height > 420 Or My.Computer.Screen.Bounds.Width And My.Computer.Screen.Bounds.Height Then
                    Bureau.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Stretch
                Else
                    Bureau.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Zoom
                End If
            ElseIf Bureau2.Visible = True Then
                Bureau2.FlowLayoutPanel1.BackgroundImage = PictureBox13.Image
                If Bureau2.FlowLayoutPanel1.Width > 864 And Bureau2.FlowLayoutPanel1.BackgroundImage.Height > 420 Or My.Computer.Screen.Bounds.Width And My.Computer.Screen.Bounds.Height Then
                    Bureau2.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Stretch
                Else
                    Bureau2.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Zoom
                End If
            End If
        ElseIf RadioButton12.Checked = True Then
            If Bureau.Visible = True Then
                Bureau.FlowLayoutPanel1.BackgroundImage = PictureBox12.Image
                If Bureau.FlowLayoutPanel1.BackgroundImage.Width > 864 And Bureau.FlowLayoutPanel1.BackgroundImage.Height > 420 Or My.Computer.Screen.Bounds.Width And My.Computer.Screen.Bounds.Height Then
                    Bureau.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Stretch
                Else
                    Bureau.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Zoom
                End If
            ElseIf Bureau2.Visible = True Then
                Bureau2.FlowLayoutPanel1.BackgroundImage = PictureBox12.Image
                If Bureau2.FlowLayoutPanel1.Width > 864 And Bureau2.FlowLayoutPanel1.BackgroundImage.Height > 420 Or My.Computer.Screen.Bounds.Width And My.Computer.Screen.Bounds.Height Then
                    Bureau2.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Stretch
                Else
                    Bureau2.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Zoom
                End If
            End If
        ElseIf RadioButton11.Checked = True Then
            If Bureau.Visible = True Then
                Bureau.FlowLayoutPanel1.BackgroundImage = PictureBox11.Image
                If Bureau.FlowLayoutPanel1.BackgroundImage.Width > 864 And Bureau.FlowLayoutPanel1.BackgroundImage.Height > 420 Or My.Computer.Screen.Bounds.Width And My.Computer.Screen.Bounds.Height Then
                    Bureau.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Stretch
                Else
                    Bureau.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Zoom
                End If
            ElseIf Bureau2.Visible = True Then
                Bureau2.FlowLayoutPanel1.BackgroundImage = PictureBox11.Image
                If Bureau2.FlowLayoutPanel1.Width > 864 And Bureau2.FlowLayoutPanel1.BackgroundImage.Height > 420 Or My.Computer.Screen.Bounds.Width And My.Computer.Screen.Bounds.Height Then
                    Bureau2.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Stretch
                Else
                    Bureau2.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Zoom
                End If
            End If
        ElseIf RadioButton10.Checked = True Then
            If Bureau.Visible = True Then
                Bureau.FlowLayoutPanel1.BackgroundImage = PictureBox10.Image
                If Bureau.FlowLayoutPanel1.BackgroundImage.Width > 864 And Bureau.FlowLayoutPanel1.BackgroundImage.Height > 420 Or My.Computer.Screen.Bounds.Width And My.Computer.Screen.Bounds.Height Then
                    Bureau.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Stretch
                Else
                    Bureau.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Zoom
                End If
            ElseIf Bureau2.Visible = True Then
                Bureau2.FlowLayoutPanel1.BackgroundImage = PictureBox10.Image
                If Bureau2.FlowLayoutPanel1.Width > 864 And Bureau2.FlowLayoutPanel1.BackgroundImage.Height > 420 Or My.Computer.Screen.Bounds.Width And My.Computer.Screen.Bounds.Height Then
                    Bureau2.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Stretch
                Else
                    Bureau2.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Zoom
                End If
            End If
        ElseIf RadioButton9.Checked = True Then
            If Bureau.Visible = True Then
                Bureau.FlowLayoutPanel1.BackgroundImage = PictureBox9.Image
                If Bureau.FlowLayoutPanel1.BackgroundImage.Width > 864 And Bureau.FlowLayoutPanel1.BackgroundImage.Height > 420 Or My.Computer.Screen.Bounds.Width And My.Computer.Screen.Bounds.Height Then
                    Bureau.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Stretch
                Else
                    Bureau.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Zoom
                End If
            ElseIf Bureau2.Visible = True Then
                Bureau2.FlowLayoutPanel1.BackgroundImage = PictureBox9.Image
                If Bureau2.FlowLayoutPanel1.Width > 864 And Bureau2.FlowLayoutPanel1.BackgroundImage.Height > 420 Or My.Computer.Screen.Bounds.Width And My.Computer.Screen.Bounds.Height Then
                    Bureau2.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Stretch
                Else
                    Bureau2.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Zoom
                End If
            End If
        Else
            MessageBox.Show("ERREUR : Vous n'avez sélectionné aucun fond d'écran.", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    ' Onglet Vincent OS 6
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If RadioButton16.Checked = True Then
            If Bureau.Visible = True Then
                Bureau.FlowLayoutPanel1.BackgroundImage = PictureBox16.Image
                If Bureau.FlowLayoutPanel1.BackgroundImage.Width > 864 And Bureau.FlowLayoutPanel1.BackgroundImage.Height > 420 Or My.Computer.Screen.Bounds.Width And My.Computer.Screen.Bounds.Height Then
                    Bureau.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Stretch
                Else
                    Bureau.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Zoom
                End If
            ElseIf Bureau2.Visible = True Then
                Bureau2.FlowLayoutPanel1.BackgroundImage = PictureBox16.Image
                If Bureau2.FlowLayoutPanel1.Width > 864 And Bureau2.FlowLayoutPanel1.BackgroundImage.Height > 420 Or My.Computer.Screen.Bounds.Width And My.Computer.Screen.Bounds.Height Then
                    Bureau2.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Stretch
                Else
                    Bureau2.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Zoom
                End If
            End If
        ElseIf RadioButton17.Checked = True Then
            If Bureau.Visible = True Then
                Bureau.FlowLayoutPanel1.BackgroundImage = PictureBox17.Image
                If Bureau.FlowLayoutPanel1.BackgroundImage.Width > 864 And Bureau.FlowLayoutPanel1.BackgroundImage.Height > 420 Or My.Computer.Screen.Bounds.Width And My.Computer.Screen.Bounds.Height Then
                    Bureau.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Stretch
                Else
                    Bureau.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Zoom
                End If
            ElseIf Bureau2.Visible = True Then
                Bureau2.FlowLayoutPanel1.BackgroundImage = PictureBox17.Image
                If Bureau2.FlowLayoutPanel1.Width > 864 And Bureau2.FlowLayoutPanel1.BackgroundImage.Height > 420 Or My.Computer.Screen.Bounds.Width And My.Computer.Screen.Bounds.Height Then
                    Bureau2.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Stretch
                Else
                    Bureau2.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Zoom
                End If
            End If
        ElseIf RadioButton18.Checked = True Then
            If Bureau.Visible = True Then
                Bureau.FlowLayoutPanel1.BackgroundImage = PictureBox18.Image
                If Bureau.FlowLayoutPanel1.BackgroundImage.Width > 864 And Bureau.FlowLayoutPanel1.BackgroundImage.Height > 420 Or My.Computer.Screen.Bounds.Width And My.Computer.Screen.Bounds.Height Then
                    Bureau.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Stretch
                Else
                    Bureau.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Zoom
                End If
            ElseIf Bureau2.Visible = True Then
                Bureau2.FlowLayoutPanel1.BackgroundImage = PictureBox18.Image
                If Bureau2.FlowLayoutPanel1.Width > 864 And Bureau2.FlowLayoutPanel1.BackgroundImage.Height > 420 Or My.Computer.Screen.Bounds.Width And My.Computer.Screen.Bounds.Height Then
                    Bureau2.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Stretch
                Else
                    Bureau2.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Zoom
                End If
            End If
        Else
            MessageBox.Show("ERREUR : Vous n'avez sélectionné aucun fond d'écran.", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class