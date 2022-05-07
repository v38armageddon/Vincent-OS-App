Public Class Avant

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Options.RadioButton1.Checked = True
        Démarrage.StartPosition = FormStartPosition.CenterScreen
        Démarrage.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Options.RadioButton2.Checked = True
        Démarrage.Show()
        If Démarrage.Visible = True Then
            Démarrage.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            Arrêt.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            Login.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            Login2bureau.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            Login2bureau2.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            Bureau.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            Bureau2.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            Bureau.Width = My.Computer.Screen.Bounds.Width
            Bureau.Height = My.Computer.Screen.Bounds.Height
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
        Me.Hide()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        alertelog.Show()
    End Sub
End Class