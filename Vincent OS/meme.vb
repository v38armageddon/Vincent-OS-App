Public Class meme

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        WebBrowser1.GoBack()
        TabPage2.Text = WebBrowser1.DocumentTitle
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        WebBrowser1.GoForward()
        TabPage2.Text = WebBrowser1.DocumentTitle
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        WebBrowser1.Navigate(TextBox1.Text)
        TabPage2.Text = WebBrowser1.DocumentTitle
    End Sub

    Private Sub meme_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Bureau.Visible = True Then
            Bureau.Button16.Visible = True
        ElseIf Bureau2.Visible = True Then
            Bureau2.Button16.Visible = True
        End If
    End Sub

    Private Sub meme_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        If Bureau.Visible = True Then
            Bureau.Button16.Visible = False
        ElseIf Bureau2.Visible = True Then
            Bureau2.Button16.Visible = False
        End If
    End Sub

    Private Sub TextBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.Click
        If TextBox1.Text = "Entrez votre destination (exemple : C:\(nom de dossier))" Then
            TextBox1.Text = ""
        End If
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            WebBrowser1.Navigate(TextBox1.Text)
            TabPage2.Text = WebBrowser1.DocumentTitle
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim newPage As New TabPage()
        newPage.Text = WebBrowser1.DocumentTitle
        TabControl1.TabPages.Add(newPage)
        Dim webbrowswer As New WebBrowser()
        webbrowswer.Dock = DockStyle.Fill
        webbrowswer.Navigate("C:\Users\")
        newPage.Controls.Add(webbrowswer)
        TabControl1.SelectedTab = newPage
        TabPage2.Text = WebBrowser1.DocumentTitle
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TabControl1.Controls.RemoveAt(0)
        If TabControl1.TabPages.Count = 0 Then
            Me.Close()
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        WebBrowser1.Navigate("C:\Users\" + GetUserName() + "\Documents")
        TabPage2.Text = Button3.Text
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        WebBrowser1.Navigate("C:\Users\" + GetUserName() + "\Pictures")
        TabPage2.Text = Button4.Text
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        WebBrowser1.Navigate("C:\Users\" + GetUserName() + "\Music")
        TabPage2.Text = Button5.Text
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        WebBrowser1.Navigate("C:\Users\" + GetUserName() + "\Videos")
        TabPage2.Text = Button6.Text
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        WebBrowser1.Navigate("C:\")
        TabPage2.Text = Button7.Text
    End Sub
    Function GetUserName() As String
        If TypeOf My.User.CurrentPrincipal Is 
          Security.Principal.WindowsPrincipal Then
            Dim parts() As String = Split(My.User.Name, "\")
            Dim username As String = parts(1)
            Return username
        Else
            Return My.User.Name
        End If
    End Function
End Class