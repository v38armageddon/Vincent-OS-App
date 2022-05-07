Public Class Bing_Chrome
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        WebBrowser2.GoBack()
        TabPage2.Text = WebBrowser2.DocumentTitle
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        WebBrowser2.GoForward()
        TabPage2.Text = WebBrowser2.DocumentTitle
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        WebBrowser2.GoHome()
        TabPage2.Text = WebBrowser2.DocumentTitle
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        WebBrowser2.Stop()
        TabPage2.Text = WebBrowser2.DocumentTitle
    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        WebBrowser2.Refresh()
        TabPage2.Text = WebBrowser2.DocumentTitle
    End Sub

    Private Sub PictureBox6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox6.Click
        WebBrowser2.Navigate(TextBox1.Text)
        TabPage2.Text = WebBrowser2.DocumentTitle
    End Sub

    Private Sub PictureBox7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        WebBrowser2.Navigate("http://www.bing.com/search?q=" & TextBox1.Text)
        TabPage2.Text = WebBrowser2.DocumentTitle
    End Sub

    Private Sub Bing_Chrome_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        If Bureau.Visible = True Then
            Bureau.Button15.Visible = False
        ElseIf Bureau2.Visible = True Then
            Bureau2.Button15.Visible = False
        End If
    End Sub

    Private Sub Bing_Chrome_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TabPage2.Text = WebBrowser2.DocumentTitle
        If Bureau.Visible = True Then
            Bureau.Button15.Visible = True
        ElseIf Bureau2.Visible = True Then
            Bureau2.Button15.Visible = True
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim newPage As New TabPage()
        newPage.Text = WebBrowser2.DocumentTitle
        TabControl1.TabPages.Add(newPage)
        Dim webbrowswer As New WebBrowser()
        webbrowswer.Dock = DockStyle.Fill
        webbrowswer.Navigate("https://www.bing.com")
        newPage.Controls.Add(webbrowswer)
        TabControl1.SelectedTab = newPage
    End Sub
End Class
