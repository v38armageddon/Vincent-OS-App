Public Class Store

    Private Sub Store_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Bureau.Visible = True Then
            Bureau.Button8.Visible = True
        ElseIf Bureau2.Visible = True Then
            Bureau2.Button8.Visible = True
        End If
    End Sub

    ' Premier onglet
    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        System.Diagnostics.Process.Start("https://github.com/v38armageddon/Vincent-OS-Legacy/releases/tag/Release")
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        System.Diagnostics.Process.Start("https://github.com/v38armageddon/Vincent-OS-Legacy/releases/tag/2.0")
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        System.Diagnostics.Process.Start("https://github.com/v38armageddon/Vincent-OS-Legacy/releases/tag/2.1")
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        System.Diagnostics.Process.Start("https://github.com/v38armageddon/Vincent-OS-Legacy/releases/tag/3.0")
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        System.Diagnostics.Process.Start("https://github.com/v38armageddon/Vincent-OS-Legacy/releases/tag/3.1")
    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        System.Diagnostics.Process.Start("https://github.com/v38armageddon/Vincent-OS-Legacy/releases/tag/3.1.1")
    End Sub

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click
        System.Diagnostics.Process.Start("https://github.com/v38armageddon/Vincent-OS-Legacy/releases/tag/4")
    End Sub

    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click
        System.Diagnostics.Process.Start("https://github.com/v38armageddon/Vincent-OS-Legacy/releases/tag/4.1")
    End Sub

    Private Sub Button19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button19.Click
        System.Diagnostics.Process.Start("https://github.com/v38armageddon/Vincent-OS-Legacy/releases/tag/4.2")
    End Sub

    Private Sub Button20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button20.Click
        System.Diagnostics.Process.Start("https://github.com/v38armageddon/Vincent-OS-Legacy/releases/tag/5")
    End Sub

    Private Sub Button21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button21.Click
        System.Diagnostics.Process.Start("https://github.com/v38armageddon/Vincent-OS-Legacy/releases/tag/5.1")
    End Sub

    '' Lecteur PDF
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Button5.Text = "Ajouté !"
        Button5.Enabled = False
        Download.Panel7.Visible = True
    End Sub

    '' Chrono
    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Button9.Text = "Ajouté !"
        Button9.Enabled = False
        Download.Panel6.Visible = True
    End Sub

    '' Jeu de combinaisons
    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Button10.Text = "Ajouté !"
        Button10.Enabled = False
        Download.Panel5.Visible = True
    End Sub

    ' Deuxième onglet
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Button1.Text = "Ajouté !"
        Button1.Enabled = False
        Download.Panel1.Visible = True
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Button2.Text = "Ajouté !"
        Button2.Enabled = False
        Download.Panel2.Visible = True
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Button3.Text = "Ajouté !"
        Button3.Enabled = False
        Download.Panel3.Visible = True
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Button4.Text = "Ajouté !"
        Button4.Enabled = False
        Download.Panel4.Visible = True
    End Sub

    Private Sub VosTéléchargementsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VosTéléchargementsToolStripMenuItem.Click
        Download.Show()
    End Sub

    Private Sub Store_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        If Bureau.Visible = True Then
            Bureau.Button8.Visible = False
        ElseIf Bureau2.Visible = True Then
            Bureau2.Button8.Visible = False
        End If
    End Sub
End Class