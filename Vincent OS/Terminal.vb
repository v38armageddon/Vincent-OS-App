Public Class Terminal

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "ver" Then
            RichTextBox1.Text = "Nom du système d'exploitation : Vincent OS" & vbCrLf & "Version : 4.1"
            TextBox1.Text = ""
        ElseIf TextBox1.Text = "help" Then
            RichTextBox1.Text = "Bing Chrome        Lance Bing Chrome." & vbCrLf & "Exewin       Lance l'exécuteur d'application non Vincent OS." & vbCrLf & "Game        Lance le gestionnaire de jeux." & vbCrLf & "MediaPlayer      Lancer le Media Player." & vbCrLf & "Meme        Lance l'explorateur de fichiers." & vbCrLf & "News       Savoir les derniers changements." & vbCrLf & "Notepad        Lance le Bloc Note." & vbCrLf & "Paint       Lance Paint." & vbCrLf & "PDF        Lance le lecteur PDF." & vbCrLf & "Terminal     Lance une autre fenêtre d'un Terminal." & vbCrLf & "Visio       Lance la visionneuse d'images." & vbCrLf & vbCrLf & "Certaines commandes sont cachées !"
        ElseIf TextBox1.Text = "Bing Chrome" Then
            Bing_Chrome.Show()
            TextBox1.Text = ""
        ElseIf TextBox1.Text = "Exewin" Then
            exewin.Show()
            TextBox1.Text = ""
        ElseIf TextBox1.Text = "Game" Then
            game.Show()
            TextBox1.Text = ""
        ElseIf TextBox1.Text = "mathingGame" Then
            MessageBox.Show("Ceci et un jeu qui a été abandonné au cours de son développement, des bugs peuvent avoir", "Alerte")
            mathingGame.Show()
        ElseIf TextBox1.Text = "MediaPlayer" Then
            ''Media.Show()
            RichTextBox1.Text = "ERREUR : Cette application est désactivé pour le moment. Désolé du dérangement..."
            TextBox1.Text = ""
        ElseIf TextBox1.Text = "Meme" Then
            meme.Show()
            TextBox1.Text = ""
        ElseIf TextBox1.Text = "News" Then
            RichTextBox1.Text = "Version 4.1 :" & vbCrLf & "- Nouvelle écran de déconnection" & vbCrLf & "- - Suppresion du lecteur PDF, il ne marche plus trop bien mais vous pouvez toujours le télécharger avec ce lien : http://www.mediafire.com/file/nl4xa09md89rkfg/LecteurPDF.zip/file" & vbCrLf & "- "
            TextBox1.Text = ""
        ElseIf TextBox1.Text = "Notepad" Then
            Notepad.Show()
            TextBox1.Text = ""
        ElseIf TextBox1.Text = "Paint" Then
            paints.Show()
            TextBox1.Text = ""
        ElseIf TextBox1.Text = "PDF" Then
            RichTextBox1.Text = "RIP Lecteur PDF : 1.0 - 4.1"
        ElseIf TextBox1.Text = "Terminal" Then
            Me.Show()
            TextBox1.Text = ""
        ElseIf TextBox1.Text = "Visio" Then
            Visio.Show()
            TextBox1.Text = ""
        Else
            RichTextBox1.Text = "Commande non reconnu."
        End If
    End Sub

    Private Sub Terminal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Bureau.Visible = True Then
            Bureau.Button24.Visible = True
        ElseIf Bureau2.Visible = True Then
            Bureau2.Button24.Visible = True
        End If
    End Sub

    Private Sub Terminal_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        If Bureau.Visible = True Then
            Bureau.Button24.Visible = False
        ElseIf Bureau2.Visible = True Then
            Bureau2.Button24.Visible = False
        End If
    End Sub
End Class