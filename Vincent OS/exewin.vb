Public Class exewin
    Dim executeur As New Process
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        executeur.StartInfo.FileName = TextBox1.Text
        executeur.Start()
    End Sub
End Class