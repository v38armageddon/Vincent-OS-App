Public Class paints
    Dim b As New Bitmap(1000, 1000)
    Dim tool As String = "pencil"
    Dim color As String
    Dim del As String = "0"
    Dim size As String = "2"
    Dim penS As New Pen(Brushes.Black, 2)
    Dim penBS As New Pen(Brushes.Blue, 2)
    Dim penYS As New Pen(Brushes.Yellow, 2)
    Dim penRS As New Pen(Brushes.Red, 2)
    Dim penGS As New Pen(Brushes.Green, 2)
    Dim pen As New Pen(Brushes.Black, 5)
    Dim penB As New Pen(Brushes.Blue, 5)
    Dim penY As New Pen(Brushes.Yellow, 5)
    Dim penR As New Pen(Brushes.Red, 5)
    Dim penG As New Pen(Brushes.Green, 5)
    Dim deleteS As New Pen(Brushes.White, 8)
    Dim delete As New Pen(Brushes.White, 20)
    Private Sub PictureBox1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseMove
        Dim g As Graphics = Graphics.FromImage(b)
        Static coord As New Point
        If e.Button = Windows.Forms.MouseButtons.Left And tool = "pencil" Then
            g.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
            If color = "blue" And size = "2" Then
                penBS.StartCap = Drawing2D.LineCap.Round
                penBS.EndCap = Drawing2D.LineCap.Round
                g.DrawLine(penBS, coord.X, coord.Y, e.X, e.Y)
            ElseIf color = "blue" And size = "5" Then
                penB.StartCap = Drawing2D.LineCap.Round
                penB.EndCap = Drawing2D.LineCap.Round
                g.DrawLine(penB, coord.X, coord.Y, e.X, e.Y)
            ElseIf color = "yellow" And size = "2" Then
                penYS.StartCap = Drawing2D.LineCap.Round
                penYS.EndCap = Drawing2D.LineCap.Round
                g.DrawLine(penYS, coord.X, coord.Y, e.X, e.Y)
            ElseIf color = "yellow" And size = "5" Then
                penY.StartCap = Drawing2D.LineCap.Round
                penY.EndCap = Drawing2D.LineCap.Round
                g.DrawLine(penY, coord.X, coord.Y, e.X, e.Y)
            ElseIf color = "red" And size = "2" Then
                penRS.StartCap = Drawing2D.LineCap.Round
                penRS.EndCap = Drawing2D.LineCap.Round
                g.DrawLine(penRS, coord.X, coord.Y, e.X, e.Y)
            ElseIf color = "red" And size = "5" Then
                penR.StartCap = Drawing2D.LineCap.Round
                penR.EndCap = Drawing2D.LineCap.Round
                g.DrawLine(penR, coord.X, coord.Y, e.X, e.Y)
            ElseIf color = "green" And size = "2" Then
                penGS.StartCap = Drawing2D.LineCap.Round
                penGS.EndCap = Drawing2D.LineCap.Round
                g.DrawLine(penGS, coord.X, coord.Y, e.X, e.Y)
            ElseIf color = "green" And size = "5" Then
                penG.StartCap = Drawing2D.LineCap.Round
                penG.EndCap = Drawing2D.LineCap.Round
                g.DrawLine(penG, coord.X, coord.Y, e.X, e.Y)
            ElseIf color = "none" And del = "1" And size = "2" Then
                deleteS.StartCap = Drawing2D.LineCap.Round
                deleteS.EndCap = Drawing2D.LineCap.Round
                g.DrawLine(deleteS, coord.X, coord.Y, e.X, e.Y)
            ElseIf color = "none" And del = "1" And size = "5" Then
                delete.StartCap = Drawing2D.LineCap.Round
                delete.EndCap = Drawing2D.LineCap.Round
                g.DrawLine(delete, coord.X, coord.Y, e.X, e.Y)
            Else
                If size = "2" Then
                    penS.StartCap = Drawing2D.LineCap.Round
                    penS.EndCap = Drawing2D.LineCap.Round
                    g.DrawLine(penS, coord.X, coord.Y, e.X, e.Y)
                ElseIf size = "5" Then
                    pen.StartCap = Drawing2D.LineCap.Round
                    pen.EndCap = Drawing2D.LineCap.Round
                    g.DrawLine(pen, coord.X, coord.Y, e.X, e.Y)
                End If
            End If
            g.Dispose()
            PictureBox1.BackgroundImage = b
            Me.Refresh()
        End If
        coord = e.Location
    End Sub
    Private Sub PictureBox1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        If tool = "fill" Then
            PictureBox1.BackgroundImage = Nothing
            Dim g As Graphics = Graphics.FromImage(b)
            g.Clear(Drawing.Color.Transparent)
            If color = "blue" Then
                PictureBox1.BackColor = Drawing.Color.Blue
            ElseIf color = "yellow" Then
                PictureBox1.BackColor = Drawing.Color.Yellow
            ElseIf color = "red" Then
                PictureBox1.BackColor = Drawing.Color.Red
            ElseIf color = "green" Then
                PictureBox1.BackColor = Drawing.Color.Green
            Else
                PictureBox1.BackColor = Drawing.Color.Black
            End If
        End If
    End Sub
    Private Sub Panel1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel1.Click
        color = "red"
    End Sub
    Private Sub Panel2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel2.Click
        color = "green"
    End Sub
    Private Sub Panel3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel3.Click
        color = "blue"
    End Sub
    Private Sub Panel4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel4.Click
        color = "yellow"
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        size = "2"
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        size = "5"
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        color = "none"
        tool = "pencil"
        del = "1"
    End Sub
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim g As Graphics = Graphics.FromImage(b)
        g.Clear(Drawing.Color.White)
        PictureBox1.BackColor = Drawing.Color.White
        PictureBox1.BackgroundImage = Nothing
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        del = "0"
        tool = "pencil"
    End Sub
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        del = "0"
        tool = "fill"
    End Sub
End Class