﻿Public Class game

    Private Sub game_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Bureau.Visible = True Then
            Bureau.Button22.Visible = True
        ElseIf Bureau2.Visible = True Then
            Bureau2.Button22.Visible = True
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        exewin.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MazeGame.Show()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        ''Si aucun jeu n'est détecté, commenter
        ''Store.Show()
        Dim errorsound As New System.Media.SoundPlayer(My.Resources.errorSound)
        errorsound.Play()
        MessageBox.Show("ERREUR : Aucun jeu supplémentaire n'as été détecté sur le Store.", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Private Sub game_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        If Bureau.Visible = True Then
            Bureau.Button22.Visible = False
        ElseIf Bureau2.Visible = True Then
            Bureau2.Button22.Visible = False
        End If
    End Sub
End Class