Public Class mathingGame
    Private firstClicked As Label = Nothing
    Private secondClicked As Label = Nothing
    Private random As New Random
    Private icons = New List(Of String) From {"!", "!", "N", "N", ",", ",", "k", "k", "b", "b", "v", "v", "w", "w", "z", "z"}

    Private Sub mathingGame_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AssignIconsToSquares()
    End Sub

    Private Sub AssignIconsToSquares()
        For Each control In TableLayoutPanel1.Controls
            Dim iconLabel = TryCast(control, Label)
            If iconLabel IsNot Nothing Then
                Dim randomNumber = random.Next(icons.Count)
                iconLabel.Text = icons(randomNumber)
                iconLabel.ForeColor = iconLabel.BackColor
                icons.RemoveAt(randomNumber)
            End If
        Next
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label9.Click, Label8.Click, Label7.Click, Label6.Click, Label5.Click, Label4.Click, Label3.Click, Label2.Click, Label16.Click, Label15.Click, Label14.Click, Label13.Click, Label12.Click, Label11.Click, Label10.Click, Label1.Click
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
            CheckForWinner()
            If firstClicked.Text = secondClicked.Text Then
                firstClicked = Nothing
                secondClicked = Nothing
            End If
            Timer1.Start()
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        '' Si vous plaît, si vous avez la solution, faites un Pull Request
        firstClicked.ForeColor = firstClicked.BackColor
        secondClicked.ForeColor = secondClicked.BackColor
        firstClicked = Nothing
        secondClicked = Nothing
    End Sub

    Private Sub CheckForWinner()
        For Each Control In TableLayoutPanel1.Controls
            Dim iconLabel = TryCast(Control, Label)
            If iconLabel IsNot Nothing AndAlso
               iconLabel.ForeColor = iconLabel.BackColor Then Exit Sub
        Next
        MessageBox.Show("Vous avez trouvé toutes les combinaisons d'icônes !", "Félicitations !")
        Me.Close()
    End Sub
End Class