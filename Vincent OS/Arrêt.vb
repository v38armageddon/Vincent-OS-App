Public Class Arrêt

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(2)
        If ProgressBar1.Value = 100 Then
            Timer1.Stop()
            Démarrage.Close()
            Bureau.Close()
            Login.Close()
            Bureau2.Close()
            Me.Close()
        End If
    End Sub
End Class