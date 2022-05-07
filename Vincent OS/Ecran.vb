Public Class Ecran

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        OpenFileDialog1.Filter = "Images|*.jpeg;*.jpg;*.png;*.bmp;"
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            If Bureau.Visible = True Then
                Bureau.FlowLayoutPanel1.BackgroundImage = Image.FromFile(OpenFileDialog1.FileName)
                If Bureau.FlowLayoutPanel1.BackgroundImage.Width > 864 And Bureau.FlowLayoutPanel1.BackgroundImage.Height > 420 Or My.Computer.Screen.Bounds.Width And My.Computer.Screen.Bounds.Height Then
                    Bureau.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Stretch
                Else
                    Bureau.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Zoom
                End If
                Panel1.Visible = True
            ElseIf Bureau2.Visible = True Then
                Bureau2.FlowLayoutPanel1.BackgroundImage = Image.FromFile(OpenFileDialog1.FileName)
                If Bureau2.FlowLayoutPanel1.Width > 864 And Bureau2.FlowLayoutPanel1.BackgroundImage.Height > 420 Or My.Computer.Screen.Bounds.Width And My.Computer.Screen.Bounds.Height Then
                    Bureau2.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Stretch
                Else
                    Bureau2.FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Zoom
                End If
                Panel1.Visible = True
            End If
        End If
    End Sub
End Class