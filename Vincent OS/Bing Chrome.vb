Public Class Bing_Chrome
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        WebBrowser2.GoBack()
        TabPage2.Text = WebBrowser2.DocumentTitle '' Bien que parfois cela puisse buger, à voir pour opter pour une alternative ?
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        WebBrowser2.GoForward()
        TabPage2.Text = WebBrowser2.DocumentTitle '' Bien que parfois cela puisse buger, à voir pour opter pour une alternative ?
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        WebBrowser2.GoHome()
        TabPage2.Text = WebBrowser2.DocumentTitle '' Bien que parfois cela puisse buger, à voir pour opter pour une alternative ?
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        WebBrowser2.Refresh()
        TabPage2.Text = WebBrowser2.DocumentTitle '' Bien que parfois cela puisse buger, à voir pour opter pour une alternative ?
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        WebBrowser2.Stop()
        TabPage2.Text = WebBrowser2.DocumentTitle '' Bien que parfois cela puisse buger, à voir pour opter pour une alternative ?
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        search()
    End Sub

    Private Sub Bing_Chrome_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        If Bureau.Visible = True Then
            Bureau.Button15.Visible = False
        ElseIf Bureau2.Visible = True Then
            Bureau2.Button15.Visible = False
        End If
    End Sub

    Private Sub Bing_Chrome_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Bureau.Visible = True Then
            Bureau.Button15.Visible = True
        ElseIf Bureau2.Visible = True Then
            Bureau2.Button15.Visible = True
        End If
        TabPage2.Text = WebBrowser2.DocumentTitle '' Bien que parfois cela puisse buger, à voir pour opter pour une alternative ?
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
        TabPage2.Text = WebBrowser2.DocumentTitle '' Bien que parfois cela puisse buger, à voir pour opter pour une alternative ?
    End Sub

    Private Sub TextBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.Click
        If TextBox1.Text = "Saisissez l'URL" Then
            TextBox1.Text = ""
        End If
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            search()
        End If
    End Sub

    Private Sub search()
        '' Regarder si dans la TextBox, cela contient soit http ou https
        If TextBox1.Text.Contains("http://") Or TextBox1.Text.Contains("https://") Then
            WebBrowser2.Navigate(TextBox1.Text)
            TabPage2.Text = WebBrowser2.DocumentTitle '' Bien que parfois cela puisse buger, à voir pour opter pour une alternative ?
        Else
            WebBrowser2.Navigate("http://www.bing.com/search?q=" & TextBox1.Text)
            TabPage2.Text = WebBrowser2.DocumentTitle '' Bien que parfois cela puisse buger, à voir pour opter pour une alternative ?
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TabControl1.Controls.RemoveAt(0)
        If TabControl1.TabPages.Count = 0 Then
            Me.Close()
        End If
    End Sub
End Class
