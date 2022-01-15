Public Class Custom

    Private Sub Ecran_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Bureau.Visible = True Then
            PictureBox1.Image = Bureau.FlowLayoutPanel1.BackgroundImage
        ElseIf Bureau2.Visible = True Then
            PictureBox1.Image = Bureau2.FlowLayoutPanel1.BackgroundImage
        End If
    End Sub
    '' Fond d'écrans
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        OpenFileDialog1.Filter = "Images|*.jpeg;*.jpg;*.png;*.bmp;" '' Peut être rajouter d'autres types d'images ?
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            If Bureau.Visible = True Then
                Bureau.FlowLayoutPanel1.BackgroundImage = Image.FromFile(OpenFileDialog1.FileName)
                If Bureau.FlowLayoutPanel1.BackgroundImage.Width > 864 And Bureau.FlowLayoutPanel1.BackgroundImage.Height > 420 Or My.Computer.Screen.Bounds.Width And My.Computer.Screen.Bounds.Height Then
                    Bureau.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Stretch
                Else
                    Bureau.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Zoom
                End If
                PictureBox1.Image = Bureau.FlowLayoutPanel1.BackgroundImage
            ElseIf Bureau2.Visible = True Then
                Bureau2.FlowLayoutPanel1.BackgroundImage = Image.FromFile(OpenFileDialog1.FileName)
                If Bureau2.FlowLayoutPanel1.Width > 864 And Bureau2.FlowLayoutPanel1.BackgroundImage.Height > 420 Or My.Computer.Screen.Bounds.Width And My.Computer.Screen.Bounds.Height Then
                    Bureau2.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Stretch
                Else
                    Bureau2.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Zoom
                End If
                PictureBox1.Image = Bureau2.FlowLayoutPanel1.BackgroundImage
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Bureau.Visible = True Then
            Bureau.FlowLayoutPanel1.BackgroundImage = My.Resources.login
            If Bureau.FlowLayoutPanel1.BackgroundImage.Width > 864 And Bureau.FlowLayoutPanel1.BackgroundImage.Height > 420 Or My.Computer.Screen.Bounds.Width And My.Computer.Screen.Bounds.Height Then
                Bureau.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Stretch
            Else
                Bureau.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Zoom
            End If
            PictureBox1.Image = Bureau.FlowLayoutPanel1.BackgroundImage
        ElseIf Bureau2.Visible = True Then
            Bureau2.FlowLayoutPanel1.BackgroundImage = My.Resources.login
            If Bureau2.FlowLayoutPanel1.Width > 864 And Bureau2.FlowLayoutPanel1.BackgroundImage.Height > 420 Or My.Computer.Screen.Bounds.Width And My.Computer.Screen.Bounds.Height Then
                Bureau2.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Stretch
            Else
                Bureau2.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Zoom
            End If
            PictureBox1.Image = Bureau2.FlowLayoutPanel1.BackgroundImage
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Bureau.Visible = True Then
            Bureau.FlowLayoutPanel1.BackgroundImage = My.Resources.superutilisateur
            If Bureau.FlowLayoutPanel1.BackgroundImage.Width > 864 And Bureau.FlowLayoutPanel1.BackgroundImage.Height > 420 Or My.Computer.Screen.Bounds.Width And My.Computer.Screen.Bounds.Height Then
                Bureau.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Stretch
            Else
                Bureau.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Zoom
            End If
            PictureBox1.Image = Bureau.FlowLayoutPanel1.BackgroundImage
        ElseIf Bureau2.Visible = True Then
            Bureau2.FlowLayoutPanel1.BackgroundImage = My.Resources.superutilisateur
            If Bureau2.FlowLayoutPanel1.Width > 864 And Bureau2.FlowLayoutPanel1.BackgroundImage.Height > 420 Or My.Computer.Screen.Bounds.Width And My.Computer.Screen.Bounds.Height Then
                Bureau2.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Stretch
            Else
                Bureau2.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Zoom
            End If
            PictureBox1.Image = Bureau2.FlowLayoutPanel1.BackgroundImage
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If Bureau.Visible = True Then
            Bureau.FlowLayoutPanel1.BackgroundImage = My.Resources.invite
            If Bureau.FlowLayoutPanel1.BackgroundImage.Width > 864 And Bureau.FlowLayoutPanel1.BackgroundImage.Height > 420 Or My.Computer.Screen.Bounds.Width And My.Computer.Screen.Bounds.Height Then
                Bureau.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Stretch
            Else
                Bureau.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Zoom
            End If
            PictureBox1.Image = Bureau.FlowLayoutPanel1.BackgroundImage
        ElseIf Bureau2.Visible = True Then
            Bureau2.FlowLayoutPanel1.BackgroundImage = My.Resources.invite
            If Bureau2.FlowLayoutPanel1.Width > 864 And Bureau2.FlowLayoutPanel1.BackgroundImage.Height > 420 Or My.Computer.Screen.Bounds.Width And My.Computer.Screen.Bounds.Height Then
                Bureau2.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Stretch
            Else
                Bureau2.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Zoom
            End If
            PictureBox1.Image = Bureau2.FlowLayoutPanel1.BackgroundImage
        End If
    End Sub
    '' Icônes
    Private Sub CheckBox1_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            If Bureau.Visible = True Then
                Bureau.Button2.Visible = True
            End If
            If Bureau2.Visible = True Then
                Bureau2.Button2.Visible = True
            End If
        ElseIf CheckBox1.Checked = False Then
            If Bureau.Visible = True Then
                Bureau.Button2.Visible = False
            End If
            If Bureau2.Visible = True Then
                Bureau2.Button2.Visible = False
            End If
        End If
    End Sub

    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox5.CheckedChanged
        If CheckBox5.Checked = True Then
            If Bureau.Visible = True Then
                Bureau.Button14.Visible = True
            End If
            If Bureau2.Visible = True Then
                Bureau2.Button14.Visible = True
            End If
        ElseIf CheckBox5.Checked = False Then
            If Bureau.Visible = True Then
                Bureau.Button14.Visible = False
            End If
            If Bureau2.Visible = True Then
                Bureau2.Button14.Visible = False
            End If
        End If
    End Sub

    Private Sub CheckBox9_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox9.CheckedChanged
        If CheckBox9.Checked = True Then
            If Bureau.Visible = True Then
                Bureau.Button7.Visible = True
            End If
            If Bureau2.Visible = True Then
                Bureau2.Button11.Visible = True
            End If
        ElseIf CheckBox9.Checked = False Then
            If Bureau.Visible = True Then
                Bureau.Button7.Visible = False
            End If
            If Bureau2.Visible = True Then
                Bureau2.Button11.Visible = False
            End If
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            If Bureau.Visible = True Then
                Bureau.Button6.Visible = True
            End If
            If Bureau2.Visible = True Then
                Bureau2.Button6.Visible = True
            End If
        ElseIf CheckBox2.Checked = False Then
            If Bureau.Visible = True Then
                Bureau.Button6.Visible = False
            End If
            If Bureau2.Visible = True Then
                Bureau2.Button6.Visible = False
            End If
        End If
    End Sub

    Private Sub CheckBox6_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox6.CheckedChanged
        If CheckBox6.Checked = True Then
            If Bureau.Visible = True Then
                Bureau.Button5.Visible = True
            End If
            If Bureau2.Visible = True Then
                Bureau2.Button5.Visible = True
            End If
        ElseIf CheckBox6.Checked = False Then
            If Bureau.Visible = True Then
                Bureau.Button5.Visible = False
            End If
            If Bureau2.Visible = True Then
                Bureau2.Button5.Visible = False
            End If
        End If
    End Sub

    Private Sub CheckBox10_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox10.CheckedChanged
        If CheckBox10.Checked = True Then
            If Bureau.Visible = True Then
                Bureau.Button10.Visible = True
            End If
            If Bureau2.Visible = True Then
                Bureau2.Button10.Visible = True
            End If
        ElseIf CheckBox10.Checked = False Then
            If Bureau.Visible = True Then
                Bureau.Button10.Visible = False
            End If
            If Bureau2.Visible = True Then
                Bureau2.Button10.Visible = False
            End If
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = True Then
            If Bureau.Visible = True Then
                Bureau.Button3.Visible = True
            End If
            If Bureau2.Visible = True Then
                Bureau2.Button3.Visible = True
            End If
        ElseIf CheckBox3.Checked = False Then
            If Bureau.Visible = True Then
                Bureau.Button3.Visible = False
            End If
            If Bureau2.Visible = True Then
                Bureau2.Button3.Visible = False
            End If
        End If
    End Sub

    Private Sub CheckBox7_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox7.CheckedChanged
        If CheckBox7.Checked = True Then
            If Bureau.Visible = True Then
                Bureau.Button11.Visible = True
            End If
            If Bureau2.Visible = True Then
                Bureau2.Button9.Visible = True
            End If
        ElseIf CheckBox7.Checked = False Then
            If Bureau.Visible = True Then
                Bureau.Button11.Visible = False
            End If
            If Bureau2.Visible = True Then
                Bureau2.Button9.Visible = False
            End If
        End If
    End Sub

    Private Sub CheckBox11_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox11.CheckedChanged
        If CheckBox11.Checked = True Then
            If Bureau.Visible = True Then
                Bureau.Button25.Visible = True
            End If
            If Bureau2.Visible = True Then
                Bureau2.Button25.Visible = True
            End If
        ElseIf CheckBox11.Checked = False Then
            If Bureau.Visible = True Then
                Bureau.Button25.Visible = False
            End If
            If Bureau2.Visible = True Then
                Bureau2.Button25.Visible = False
            End If
        End If
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.Checked = True Then
            If Bureau.Visible = True Then
                Bureau.Button4.Visible = True
            End If
            If Bureau2.Visible = True Then
                Bureau2.Button4.Visible = True
            End If
        ElseIf CheckBox4.Checked = False Then
            If Bureau.Visible = True Then
                Bureau.Button4.Visible = False
            End If
            If Bureau2.Visible = True Then
                Bureau2.Button4.Visible = False
            End If
        End If
    End Sub

    Private Sub CheckBox8_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox8.CheckedChanged
        If CheckBox8.Checked = True Then
            If Bureau.Visible = True Then
                Bureau.Button13.Visible = True
            End If
            If Bureau2.Visible = True Then
                Bureau2.Button13.Visible = True
            End If
        ElseIf CheckBox8.Checked = False Then
            If Bureau.Visible = True Then
                Bureau.Button13.Visible = False
            End If
            If Bureau2.Visible = True Then
                Bureau2.Button13.Visible = False
            End If
        End If
    End Sub
    '' Résolution
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            '' Essayer de regrouper Bureau et Bureau2 pour une optimisation du code ?
            If Bureau.Visible = True Then
                '' On change de mode de forme de la fenêtre
                Bureau.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
                Démarrage.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
                Arrêt.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
                Login.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
                Login2bureau.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
                '' On met une nouvelle localisation
                Bureau.Location = New Point(480, 300)
                Login.Location = New Point(480, 300)
                Login2bureau.Location = New Point(480, 300)
                '' On met la position au milieu de l'écran
                '' Bien qu'à revérifier si cela peut fonctionner sans ou non
                Bureau.StartPosition = FormStartPosition.CenterScreen
                Démarrage.StartPosition = FormStartPosition.CenterScreen
                Login.StartPosition = FormStartPosition.CenterScreen
                Arrêt.StartPosition = FormStartPosition.CenterScreen
                Login2bureau.StartPosition = FormStartPosition.CenterScreen
                '' On change la taille
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
                '' On change de mode de forme de la fenêtre
                Bureau2.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
                Démarrage.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
                Arrêt.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
                Login.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
                Login2bureau2.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
                '' On met une nouvelle localisation
                Bureau2.Location = New Point(480, 300)
                Login.Location = New Point(480, 300)
                Login2bureau2.Location = New Point(480, 300)
                '' On met la position au milieu de l'écran
                '' Bien qu'à revérifier si cela peut fonctionner sans ou non
                Bureau2.StartPosition = FormStartPosition.CenterScreen
                Démarrage.StartPosition = FormStartPosition.CenterScreen
                Login.StartPosition = FormStartPosition.CenterScreen
                Arrêt.StartPosition = FormStartPosition.CenterScreen
                Login2bureau2.StartPosition = FormStartPosition.CenterScreen
                '' On change la taille
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

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            '' Essayer de regrouper Bureau et Bureau2 pour une optimisation du code ?
            If Bureau.Visible = True Then
                '' On change de mode de forme de la fenêtre
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
                '' On change la taille en fonction de la taille de l'écran de l'utilisateur
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
                '' On change de mode de forme de la fenêtre
                Bureau2.FormBorderStyle = Windows.Forms.FormBorderStyle.None
                Démarrage.FormBorderStyle = Windows.Forms.FormBorderStyle.None
                Arrêt.FormBorderStyle = Windows.Forms.FormBorderStyle.None
                Login.FormBorderStyle = Windows.Forms.FormBorderStyle.None
                Login2bureau2.FormBorderStyle = Windows.Forms.FormBorderStyle.None
                '' On met une nouvelle localisation
                Bureau2.Location = New Point(0, 0)
                Login.Location = New Point(0, 0)
                Login2bureau2.Location = New Point(0, 0)
                '' On met la position au milieu de l'écran
                '' Bien qu'à revérifier si cela peut fonctionner sans ou non
                Bureau2.StartPosition = FormStartPosition.Manual
                Démarrage.StartPosition = FormStartPosition.Manual
                Login.StartPosition = FormStartPosition.Manual
                Arrêt.StartPosition = FormStartPosition.Manual
                Login2bureau2.StartPosition = FormStartPosition.Manual
                '' On change la taille en fonction de la taille de l'écran de l'utilisateur
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
End Class