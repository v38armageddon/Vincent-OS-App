Public Class pdf

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            TextBox1.Text = OpenFileDialog1.FileName
            WebBrowser1.Navigate(OpenFileDialog1.FileName)
        End If
        OpenFileDialog1.Filter = "Fichier PDF (*.pdf)|*.pdf"
        OpenFileDialog1.FileName = ""
    End Sub
End Class
