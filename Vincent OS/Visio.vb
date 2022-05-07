Imports System.IO
Public Class Visio
    Private Declare Auto Function SystemParametersInfo Lib "user32.dll" (ByVal uAction As Integer, ByVal uParam As Integer,
                                                                         ByVal lpvParam As String, ByVal fuWinIni As Integer) As Integer
    Dim Images As List(Of String)
    Dim Index As Integer = 0

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Images = New List(Of String)
        Panel1.Controls.Add(PictureBox1)
    End Sub

    Private Sub OuvrirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OuvrirToolStripMenuItem.Click
        Using open As New OpenFileDialog
            open.Filter = "Images|*.jpeg;*.jpg;*.png;*.bmp;*.ico;*.cur"
            If open.ShowDialog = DialogResult.OK Then
                If PictureBox1.Image IsNot Nothing Then
                    PictureBox1.Image.Dispose()
                End If
                PictureBox1.Image = Image.FromFile(open.FileName)
                PictureBoxManager()
                Dim dossier As String = open.FileName.Substring(0, open.FileName.LastIndexOf("\"))
                Dim r = From i In Directory.GetFiles(dossier)
                        Where i.ToLower().EndsWith("jpeg") Or i.ToLower().EndsWith("jpg") Or i.ToLower().EndsWith("png") Or i.ToLower().EndsWith("bmp") Or i.ToLower().EndsWith("ico") Or i.ToLower().EndsWith("cur")
                        Select i
                Images.Clear()
                For x As Integer = 0 To r.Count
                    Images.Add(r(x))
                    If r(x) = open.FileName Then
                        Index = x
                    End If
                Next
            End If
        End Using
    End Sub
    Private Sub PictureBoxManager()
        If PictureBox1.Image.Width > Panel1.Width And PictureBox1.Image.Height > Panel1.Height Then
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
            PictureBox1.Dock = DockStyle.Fill
        ElseIf PictureBox1.Image.Width > Panel1.Width Or PictureBox1.Image.Height > Panel1.Height Then
            PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
            PictureBox1.Dock = DockStyle.Fill
        Else
            PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
            PictureBox1.Dock = DockStyle.Fill
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'suivant
        If Images.Count > 1 Then
            If Index + 1 > Images.Count - 1 Then
                Index = 0
            Else
                Index = Index + 1
            End If
            PictureBox1.Image.Dispose()
            PictureBox1.Image = Image.FromFile(Images(Index))
            PictureBoxManager()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Images.Count > 1 Then
            If Index - 1 < 0 Then
                Index = Images.Count - 1
            Else
                Index = Index - 1
            End If
            PictureBox1.Image.Dispose()
            PictureBox1.Image = Image.FromFile(Images(Index))
            PictureBoxManager()
        End If
    End Sub

    Private Sub PictureBox1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.DoubleClick
        If PictureBox1.Dock = DockStyle.Fill Then
            PictureBox1.Dock = DockStyle.None
            PictureBox1.Size = New Size(PictureBox1.Image.Width * 2, PictureBox1.Image.Height * 2)
            PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
            If PictureBox1.Width < Panel1.Width Then
                PictureBox1.Location = New Point((Panel1.Width / 2) - PictureBox1.Width, PictureBox1.Location.Y)
            End If
        Else
            PictureBoxManager()
        End If
    End Sub

    Private Sub Form1_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        If PictureBox1.Image IsNot Nothing Then
            PictureBoxManager()
            PictureBox1.Location = New Point(0, 0)
        End If
    End Sub

    Private Sub SupprimerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SupprimerToolStripMenuItem.Click
        If Images.Count > 0 Then
            PictureBox1.Image.Dispose()
            Try
                File.Delete(Images(Index))
                Images.RemoveAt(Index)
                If Images.Count > 0 Then
                    If Index > Images.Count - 1 Then
                        Index = 0
                    End If
                    PictureBox1.Image = Image.FromFile(Images(Index))
                Else
                    PictureBox1.Image = Nothing
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub DéfinirEnTantQuarrièrePlanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DéfinirEnTantQuarrièrePlanToolStripMenuItem.Click
        If Images.Count > 0 Then
            Const param1 As Integer = 20
            Const param2 As Integer = &H1
            Const param3 As Integer = &H2
            SystemParametersInfo(param1, 0, Images(Index), param2 Or param3)
        End If
    End Sub
End Class
