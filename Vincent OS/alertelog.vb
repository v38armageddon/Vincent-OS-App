Public Class alertelog

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Login.Visible = True Then
            Arrêt.Timer1.Start()
            Arrêt.Show()
        ElseIf Avant.Visible = True Then
            Avant.Close()
            Me.Close()
        End If
    End Sub
End Class