Public Class MazeGame
    Private startSoundPlayer = New System.Media.SoundPlayer("C:\Windows\Media\ding.wav")
    Private finishSoundPlayer = New System.Media.SoundPlayer("C:\Windows\Media\tada.wav")
    Public Sub New()
        InitializeComponent()
        MoveToStart()
    End Sub

    ''' <summary>
    ''' Move the mouse pointer to a point 10 pixels down and to the right
    ''' of the starting point in the upper-left corner of the maze.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub MoveToStart()
        startSoundPlayer.Play()
        Dim startingPoint = Panel1.Location
        startingPoint.Offset(10, 10)
        Cursor.Position = PointToScreen(startingPoint)
    End Sub
    Private Sub finishLabel_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles finishLabel.MouseEnter
        MessageBox.Show("Félicitation ! Vous avez réussi le labyrinth !")
        Me.Close()
    End Sub

    Private Sub wall_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label65.MouseEnter, Label64.MouseEnter, Label63.MouseEnter, Label62.MouseEnter, Label61.MouseEnter, Label60.MouseEnter, Label59.MouseEnter, Label58.MouseEnter, Label57.MouseEnter, Label56.MouseEnter, Label55.MouseEnter, Label54.MouseEnter, Label53.MouseEnter, Label52.MouseEnter, Label51.MouseEnter, Label50.MouseEnter, Label49.MouseEnter, Label48.MouseEnter, Label47.MouseEnter, Label46.MouseEnter, Label45.MouseEnter, Label44.MouseEnter, Label43.MouseEnter, Label42.MouseEnter, Label41.MouseEnter, Label40.MouseEnter, Label39.MouseEnter, Label38.MouseEnter, Label37.MouseEnter, Label36.MouseEnter, Label35.MouseEnter, Label34.MouseEnter, Label33.MouseEnter, Label32.MouseEnter, Label31.MouseEnter, Label30.MouseEnter, Label29.MouseEnter, Label28.MouseEnter, Label27.MouseEnter, Label26.MouseEnter, Label25.MouseEnter, Label24.MouseEnter, Label23.MouseEnter, Label22.MouseEnter, Label21.MouseEnter, Label20.MouseEnter, Label19.MouseEnter, Label18.MouseEnter, Label17.MouseEnter, Label16.MouseEnter, Label15.MouseEnter, Label14.MouseEnter, Label13.MouseEnter, Label12.MouseEnter, Label11.MouseEnter, Label10.MouseEnter
        finishSoundPlayer.Play()
        MoveToStart()
    End Sub
End Class