Public Class mathingGame
    Private firstClicked As Label = Nothing
    Private secondClicked As Label = Nothing
    Private random As New Random
    Private icons =
        New List(Of String) From {"!", "!", "N", "N", ",", ",", "k", "k", "b", "b", "v", "v", "w", "w", "z", "z"}
    Private Sub AssignIconsToSquares()
        For Each control In TableLayoutPanel1.Controls
            Dim iconLabel = TryCast(control, Label)
            If iconLabel IsNot Nothing Then
                Dim randomNumber = random.Next(icons.Count)
                iconLabel.Text = icons(randomNumber)
                icons.RemoveAt(randomNumber)
            End If
            iconLabel.ForeColor = iconLabel.BackColor
        Next
    End Sub

    Private Sub mathingGame_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AssignIconsToSquares()
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click, Label10.Click, Label11.Click, Label12.Click, Label13.Click, Label14.Click, Label15.Click, Label16.Click, Label2.Click, Label3.Click, Label4.Click, Label5.Click, Label6.Click, Label7.Click, Label8.Click, Label9.Click
        If Timer1.Enabled Then Exit Sub
        Dim clickedLabel = TryCast(sender, Label)
        If clickedLabel IsNot Nothing Then
            If clickedLabel.ForeColor = Color.Black Then Exit Sub
            If firstClicked Is Nothing Then
                firstClicked = clickedLabel
                firstClicked.ForeColor = Color.Black
            End If
            secondClicked = clickedLabel
            secondClicked.ForeColor = Color.Black
            If firstClicked.Text = secondClicked.Text Then
                firstClicked = Nothing
                secondClicked = Nothing
            End If
            Timer1.Start()
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        firstClicked = Nothing
        secondClicked = Nothing
    End Sub
End Class