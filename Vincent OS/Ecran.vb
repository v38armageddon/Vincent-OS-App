Public Class Ecran
    Private Declare Auto Function SystemParametersInfo Lib "user32.dll" (ByVal uAction As Integer, ByVal uParam As Integer,
                                                                         ByVal lpvParam As String, ByVal fuWinIni As Integer) As Integer
    Dim Images As List(Of String)
    Dim Index As Integer = 0

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

    End Sub
End Class