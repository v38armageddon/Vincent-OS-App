Public Class Bureau2
    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MonthCalendar1.Visible = True
    End Sub

    Private Sub Bureau_MouthClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.MouseClick
        MonthCalendar1.Visible = False
        Panel1.Visible = False
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label2.Text = TimeOfDay
    End Sub

    Private Sub Bureau_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Arrêt.Timer1.Start()
        Arrêt.Show()
        Dim son2 = New System.Media.SoundPlayer("C:\Users\v38armageddon\Music\9763.wav")
        son2.Play()
        Me.Hide()
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Panel1.Visible = True
    End Sub

    Private Sub Bureau2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MessageBox.Show("Quand vous utilisez la session <<Invité>>, les données ne sont pas sauvegardé et les paramètres ne sont pas affichés")
        Dim son = New System.Media.SoundPlayer("C:\Users\v38armageddon\Music\9760.wav")
        son.Play()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Bing_Chrome.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        meme.Show()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Media.Show()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Visio.Show()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Notepad.Show()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        pdf.Show()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Me.Hide()
        Login.Show()
    End Sub
End Class