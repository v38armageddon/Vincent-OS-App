Public Class pdf

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        OpenFileDialog1.Filter = "Fichier PDF (*.pdf)|*.pdf"
        OpenFileDialog1.FileName = ""
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            TextBox1.Text = OpenFileDialog1.FileName
            WebBrowser1.Navigate(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub pdf_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Bureau.Visible = True Then
            Bureau.Button18.Visible = True
        ElseIf Bureau2.Visible = True Then
            Bureau2.Button18.Visible = True
        End If
    End Sub

    Private Sub pdf_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        If Bureau.Visible = True Then
            Bureau.Button18.Visible = False
        ElseIf Bureau2.Visible = True Then
            Bureau2.Button18.Visible = False
        End If
    End Sub
End Class
