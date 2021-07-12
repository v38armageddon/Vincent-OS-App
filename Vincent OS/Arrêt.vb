Public Class Arrêt

    Private Sub Arrêt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim backmusic As New System.Media.SoundPlayer(My.Resources.shutdownSound)
        backmusic.Play()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(2)
        If ProgressBar1.Value = 100 Then
            Timer1.Stop()
            Démarrage.Close()
            Bureau.Close()
            Login.Close()
            Bureau2.Close()
            alertelog.Close()
            Avant.Close()
            Login2bureau.Close()
            Login2bureau2.Close()
            Me.Close()
            Application.Exit()
        End If
    End Sub
End Class