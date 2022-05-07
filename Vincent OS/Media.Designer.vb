<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Media
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Media))
        Me.AxWindowsMediaPlayer2 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OuvrirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MusiqueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VidéoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LectureToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArrêterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PleinÉcranToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AutresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileDialog2 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.AxWindowsMediaPlayer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'AxWindowsMediaPlayer2
        '
        Me.AxWindowsMediaPlayer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AxWindowsMediaPlayer2.Enabled = True
        Me.AxWindowsMediaPlayer2.Location = New System.Drawing.Point(0, 24)
        Me.AxWindowsMediaPlayer2.Name = "AxWindowsMediaPlayer2"
        Me.AxWindowsMediaPlayer2.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer2.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer2.Size = New System.Drawing.Size(546, 320)
        Me.AxWindowsMediaPlayer2.TabIndex = 5
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OuvrirToolStripMenuItem, Me.LectureToolStripMenuItem, Me.AutresToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(546, 24)
        Me.MenuStrip1.TabIndex = 7
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OuvrirToolStripMenuItem
        '
        Me.OuvrirToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MusiqueToolStripMenuItem, Me.VidéoToolStripMenuItem})
        Me.OuvrirToolStripMenuItem.Name = "OuvrirToolStripMenuItem"
        Me.OuvrirToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.OuvrirToolStripMenuItem.Text = "Ouvrir"
        '
        'MusiqueToolStripMenuItem
        '
        Me.MusiqueToolStripMenuItem.Name = "MusiqueToolStripMenuItem"
        Me.MusiqueToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.MusiqueToolStripMenuItem.Text = "Musique"
        '
        'VidéoToolStripMenuItem
        '
        Me.VidéoToolStripMenuItem.Name = "VidéoToolStripMenuItem"
        Me.VidéoToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.VidéoToolStripMenuItem.Text = "Vidéo"
        '
        'LectureToolStripMenuItem
        '
        Me.LectureToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArrêterToolStripMenuItem, Me.PleinÉcranToolStripMenuItem})
        Me.LectureToolStripMenuItem.Name = "LectureToolStripMenuItem"
        Me.LectureToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.LectureToolStripMenuItem.Text = "Lecture"
        '
        'ArrêterToolStripMenuItem
        '
        Me.ArrêterToolStripMenuItem.Name = "ArrêterToolStripMenuItem"
        Me.ArrêterToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.ArrêterToolStripMenuItem.Text = "Arrêter"
        '
        'PleinÉcranToolStripMenuItem
        '
        Me.PleinÉcranToolStripMenuItem.Name = "PleinÉcranToolStripMenuItem"
        Me.PleinÉcranToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.PleinÉcranToolStripMenuItem.Text = "Plein écran"
        '
        'AutresToolStripMenuItem
        '
        Me.AutresToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OptionsToolStripMenuItem, Me.QuitterToolStripMenuItem})
        Me.AutresToolStripMenuItem.Name = "AutresToolStripMenuItem"
        Me.AutresToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.AutresToolStripMenuItem.Text = "Autres"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.OptionsToolStripMenuItem.Text = "Options"
        '
        'QuitterToolStripMenuItem
        '
        Me.QuitterToolStripMenuItem.Name = "QuitterToolStripMenuItem"
        Me.QuitterToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.QuitterToolStripMenuItem.Text = "Quitter"
        '
        'OpenFileDialog2
        '
        Me.OpenFileDialog2.CheckFileExists = False
        Me.OpenFileDialog2.CheckPathExists = False
        Me.OpenFileDialog2.FileName = "OpenFileDialog2"
        Me.OpenFileDialog2.RestoreDirectory = True
        '
        'Media
        '
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(546, 344)
        Me.Controls.Add(Me.AxWindowsMediaPlayer2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MinimumSize = New System.Drawing.Size(562, 360)
        Me.Name = "Media"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Media Player"
        CType(Me.AxWindowsMediaPlayer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents AxWindowsMediaPlayer2 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents OpenFileDialog2 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents OuvrirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MusiqueToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VidéoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LectureToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ArrêterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PleinÉcranToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AutresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QuitterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
