Public Class Notepad

    Private Sub Notepad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Bureau.Visible = True Then
            Bureau.Button17.Visible = True
        ElseIf Bureau2.Visible = True Then
            Bureau2.Button17.Visible = True
        End If
    End Sub

    Private Sub NouveauToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NouveauToolStripMenuItem.Click
        RichTextBox1.Text = ""
    End Sub

    Private Sub OuvrirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OuvrirToolStripMenuItem.Click
        If OpenFileDialog1.ShowDialog = 1 Then
            RichTextBox1.LoadFile(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub EnrengisterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnrengisterToolStripMenuItem.Click
        RichTextBox1.SaveFile(SaveFileDialog1.FileName)
    End Sub

    Private Sub EnrengisterSousToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnrengisterSousToolStripMenuItem.Click
        If SaveFileDialog1.ShowDialog = 1 Then
            RichTextBox1.SaveFile(SaveFileDialog1.FileName)
        End If
    End Sub

    Private Sub AperçuToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AperçuToolStripMenuItem.Click
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub ImprimerToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImprimerToolStripMenuItem1.Click
        If PrintDialog1.ShowDialog = 1 Then
            PrintDocument1.Print()
        End If
    End Sub

    Private Sub AnnulerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AnnulerToolStripMenuItem.Click
        RichTextBox1.Undo()
    End Sub

    Private Sub RétablirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RétablirToolStripMenuItem.Click
        RichTextBox1.Redo()
    End Sub

    Private Sub CopierToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopierToolStripMenuItem.Click
        RichTextBox1.Copy()
    End Sub

    Private Sub CouperToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CouperToolStripMenuItem.Click
        RichTextBox1.Cut()
    End Sub

    Private Sub CollerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CollerToolStripMenuItem.Click
        RichTextBox1.Paste()
    End Sub

    Private Sub CouleurToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CouleurToolStripMenuItem.Click
        If ColorDialog1.ShowDialog = 1 Then
            RichTextBox1.SelectionColor = ColorDialog1.Color
        End If
    End Sub

    Private Sub PoliceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PoliceToolStripMenuItem.Click
        If FontDialog1.ShowDialog = 1 Then
            RichTextBox1.SelectionFont = FontDialog1.Font
        End If
    End Sub

    Private Sub CouleurDeFondToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CouleurDeFondToolStripMenuItem.Click
        If ColorDialog1.ShowDialog = 1 Then
            RichTextBox1.BackColor = ColorDialog1.Color
        End If
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawString(RichTextBox1.Text, RichTextBox1.SelectionFont, Brushes.Black, 100, 100)
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        RichTextBox1.WordWrap = CheckBox1.Checked
    End Sub

    Private Sub Notepad_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        If Bureau.Visible = True Then
            Bureau.Button17.Visible = False
        ElseIf Bureau2.Visible = True Then
            Bureau2.Button17.Visible = False
        End If
    End Sub
End Class