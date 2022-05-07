Public Class Applications

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
        ''Media.Show()
        MessageBox.Show("Cette application est désactivé pour le moment. Désolé du dérangement...", "Erreur")
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Visio.Show()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        exewin.Show()
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
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

    Private Sub CheckBox5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox5.CheckedChanged
        If CheckBox5.Checked = True Then
            If Bureau.Visible = True Then
                Bureau.Button6.Visible = True
            End If
            If Bureau2.Visible = True Then
                Bureau2.Button6.Visible = True
            End If
        ElseIf CheckBox5.Checked = False Then
            If Bureau.Visible = True Then
                Bureau.Button6.Visible = False
            End If
            If Bureau2.Visible = True Then
                Bureau2.Button6.Visible = False
            End If
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            If Bureau.Visible = True Then
                Bureau.Button3.Visible = True
            End If
            If Bureau2.Visible = True Then
                Bureau2.Button3.Visible = True
            End If
        ElseIf CheckBox2.Checked = False Then
            If Bureau.Visible = True Then
                Bureau.Button3.Visible = False
            End If
            If Bureau2.Visible = True Then
                Bureau2.Button3.Visible = False
            End If
        End If
    End Sub

    Private Sub CheckBox6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox6.CheckedChanged
        If CheckBox6.Checked = True Then
            If Bureau.Visible = True Then
                Bureau.Button4.Visible = True
            End If
            If Bureau2.Visible = True Then
                Bureau2.Button4.Visible = True
            End If
        ElseIf CheckBox6.Checked = False Then
            If Bureau.Visible = True Then
                Bureau.Button4.Visible = False
            End If
            If Bureau2.Visible = True Then
                Bureau2.Button4.Visible = False
            End If
        End If
    End Sub

    Private Sub CheckBox4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.Checked = True Then
            If Bureau.Visible = True Then
                Bureau.Button5.Visible = True
            End If
            If Bureau2.Visible = True Then
                Bureau2.Button5.Visible = True
            End If
        ElseIf CheckBox4.Checked = False Then
            If Bureau.Visible = True Then
                Bureau.Button5.Visible = False
            End If
            If Bureau2.Visible = True Then
                Bureau2.Button5.Visible = False
            End If
        End If
    End Sub

    Private Sub CheckBox7_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox7.CheckedChanged
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

    Private Sub CheckBox8_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox8.CheckedChanged
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

    Private Sub CheckBox9_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox9.CheckedChanged
        If CheckBox9.Checked = True Then
            If Bureau.Visible = True Then
                Bureau.Button14.Visible = True
            End If
            If Bureau2.Visible = True Then
                Bureau2.Button14.Visible = True
            End If
        ElseIf CheckBox9.Checked = False Then
            If Bureau.Visible = True Then
                Bureau.Button14.Visible = False
            End If
            If Bureau2.Visible = True Then
                Bureau2.Button14.Visible = False
            End If
        End If
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        paints.Show()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        game.Show()
    End Sub

    Private Sub Applications_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Bureau.Visible = True Then
            Bureau.Button26.Visible = True
        ElseIf Bureau2.Visible = True Then
            Bureau2.Button26.Visible = True
        End If
    End Sub

    Private Sub Applications_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        If Bureau.Visible = True Then
            Bureau.Button26.Visible = False
        ElseIf Bureau2.Visible = True Then
            Bureau2.Button26.Visible = False
        End If
    End Sub
End Class