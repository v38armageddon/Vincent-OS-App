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
        System.Diagnostics.Process.Start("https://github.com/v38armageddon/Vincent-OS-Legacy/")
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

    Private Sub MiseÀJourToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MiseÀJourToolStripMenuItem.Click
        UpdateStation.Show()
    End Sub
End Class