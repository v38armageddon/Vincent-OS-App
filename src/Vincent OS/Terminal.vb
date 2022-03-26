Public Class Terminal

    Private Sub Terminal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Bureau.Visible = True Then
            Bureau.Button24.Visible = True
        ElseIf Bureau2.Visible = True Then
            Bureau2.Button24.Visible = True
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        '' Création d'un Private Sub pour mieux se retrouver
        commande()
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        '' Faire en sorte que la touche Entrée puisse marcher
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            commande()
        End If
    End Sub

    Private Sub Terminal_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        If Bureau.Visible = True Then
            Bureau.Button24.Visible = False
        ElseIf Bureau2.Visible = True Then
            Bureau2.Button24.Visible = False
        End If
    End Sub

    Private Sub commande()
        If TextBox1.Text = "ver" Then
            ''ATTENTION A BIEN CHANGER LA VERSION CAR JE VAIS SUREMENT OUBLIER A LA PROCHAINE VERSION !!!!!!!!!!!
            RichTextBox1.Text = "Nom du système d'exploitation : Vincent OS" & vbCrLf & "Version : 7.1" & vbCrLf & "Branche : Beta"
            TextBox1.Text = ""
        ElseIf TextBox1.Text = "help" Then
            RichTextBox1.Text = "Bing Chrome        Lance Bing Chrome." & vbCrLf & "Calc       Lance la calculatrice" & vbCrLf & "Chrono       Lance le chronomètre" & vbCrLf & "Exewin       Lance l'exécuteur d'application non Vincent OS." & vbCrLf & "Game        Lance le gestionnaire de jeux." & vbCrLf & "MediaPlayer      Lance le Media Player." & vbCrLf & "Meme        Lance l'explorateur de fichiers." & vbCrLf & "Notepad        Lance le Bloc Note." & vbCrLf & "Paint       Lance Paint." & vbCrLf & "Store        Lance Vincent OS Store." & vbCrLf & "Terminal     Lance une autre fenêtre d'un Terminal." & vbCrLf & "Visio       Lance la visionneuse d'images." & vbCrLf & vbCrLf & "Certaines commandes sont cachées !"
            TextBox1.Text = ""
        ElseIf TextBox1.Text = "Bing Chrome" Then
            Bing_Chrome.Show()
            TextBox1.Text = ""
        ElseIf TextBox1.Text = "Calc" Then
            Calc.Show()
            TextBox1.Text = ""
        ElseIf TextBox1.Text = "Exewin" Then
            exewin.Show()
            TextBox1.Text = ""
        ElseIf TextBox1.Text = "Game" Then
            game.Show()
            TextBox1.Text = ""
        ElseIf TextBox1.Text = "MediaPlayer" Then
            Media.Show()
            TextBox1.Text = ""
        ElseIf TextBox1.Text = "Meme" Then
            meme.Show()
            TextBox1.Text = ""
        ElseIf TextBox1.Text = "Notepad" Then
            Notepad.Show()
            TextBox1.Text = ""
        ElseIf TextBox1.Text = "Paint" Then
            paints.Show()
            TextBox1.Text = ""
        ElseIf TextBox1.Text = "Store" Then
            Store.Show()
            TextBox1.Text = ""
        ElseIf TextBox1.Text = "Terminal" Then
            Dim cp As New Terminal
            cp.Show()
            TextBox1.Text = ""
        ElseIf TextBox1.Text = "Visio" Then
            Visio.Show()
            TextBox1.Text = ""
            '' Applications disponible sur le store
        ElseIf TextBox1.Text = "Chrono" Then
            If Applications.Button11.Visible = True Then
                chrono.Show()
            Else
                RichTextBox1.Text = "ERREUR : Cette application n'est pas installé."
            End If
            TextBox1.Text = ""
            ''Ici commence les commandes de Debug, à utiliser avec précaution !

        ElseIf TextBox1.Text = "Debug_Options" Then
            RichTextBox1.Text = "DEBUG_ERREUR : Veuillez rentrer une sous option" & vbCrLf & "Pour savoir les différentes commandes, tapez : Debug_Options_ Help"
            TextBox1.Text = ""
        ElseIf TextBox1.Text = "Debug_Options_Custom" Then
            If Bureau.Visible = True Or Bureau2.Visible = True Then
                Custom.Show()
            Else
                MessageBox.Show("DEBUG_ERREUR : Il n'y a pas d'interface graphique et/ou de bureau d'ouvert", "DEBUG_ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            TextBox1.Text = ""
        ElseIf TextBox1.Text = "Debug_Options_Help" Then
            RichTextBox1.Text = "Debug_Options_Custom"
            TextBox1.Text = ""
        ElseIf TextBox1.Text = "Debug_AlerteLog_ForceCrash" Then
            Application.Exit()
        ElseIf TextBox1.Text = "Debug_AlerteLog" Then
            alertelog.Show()
            TextBox1.Text = ""
        ElseIf TextBox1.Text = "Debug_Help" Then
            RichTextBox1.Text = "Debug_AlerteLog" & vbCrLf & "Debug_AlerteLog_ForceCrash" & vbCrLf & "Debug_Options"
            TextBox1.Text = ""
        Else
            RichTextBox1.Text = "Commande non reconnu."
            TextBox1.Text = ""
        End If
    End Sub
End Class