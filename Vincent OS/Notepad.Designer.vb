<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Notepad
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Notepad))
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FichierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NouveauToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OuvrirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnrengisterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnrengisterSousToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImprimerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AperçuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImprimerToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ÉditionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnnulerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RétablirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CouperToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CollerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TexteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CouleurToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PoliceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CouleurDeFondToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBox1.Location = New System.Drawing.Point(0, 24)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(762, 391)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = ""
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FichierToolStripMenuItem, Me.ÉditionToolStripMenuItem, Me.TexteToolStripMenuItem, Me.PageToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(762, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FichierToolStripMenuItem
        '
        Me.FichierToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NouveauToolStripMenuItem, Me.OuvrirToolStripMenuItem, Me.EnrengisterToolStripMenuItem, Me.EnrengisterSousToolStripMenuItem, Me.ImprimerToolStripMenuItem})
        Me.FichierToolStripMenuItem.Name = "FichierToolStripMenuItem"
        Me.FichierToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.FichierToolStripMenuItem.Text = "Fichier"
        '
        'NouveauToolStripMenuItem
        '
        Me.NouveauToolStripMenuItem.Name = "NouveauToolStripMenuItem"
        Me.NouveauToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.NouveauToolStripMenuItem.Text = "Nouveau"
        '
        'OuvrirToolStripMenuItem
        '
        Me.OuvrirToolStripMenuItem.Name = "OuvrirToolStripMenuItem"
        Me.OuvrirToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.OuvrirToolStripMenuItem.Text = "Ouvrir"
        '
        'EnrengisterToolStripMenuItem
        '
        Me.EnrengisterToolStripMenuItem.Name = "EnrengisterToolStripMenuItem"
        Me.EnrengisterToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.EnrengisterToolStripMenuItem.Text = "Enrengister"
        '
        'EnrengisterSousToolStripMenuItem
        '
        Me.EnrengisterSousToolStripMenuItem.Name = "EnrengisterSousToolStripMenuItem"
        Me.EnrengisterSousToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.EnrengisterSousToolStripMenuItem.Text = "Enrengister sous"
        '
        'ImprimerToolStripMenuItem
        '
        Me.ImprimerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AperçuToolStripMenuItem, Me.ImprimerToolStripMenuItem1})
        Me.ImprimerToolStripMenuItem.Name = "ImprimerToolStripMenuItem"
        Me.ImprimerToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.ImprimerToolStripMenuItem.Text = "Imprimer"
        '
        'AperçuToolStripMenuItem
        '
        Me.AperçuToolStripMenuItem.Name = "AperçuToolStripMenuItem"
        Me.AperçuToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.AperçuToolStripMenuItem.Text = "Aperçu"
        '
        'ImprimerToolStripMenuItem1
        '
        Me.ImprimerToolStripMenuItem1.Name = "ImprimerToolStripMenuItem1"
        Me.ImprimerToolStripMenuItem1.Size = New System.Drawing.Size(123, 22)
        Me.ImprimerToolStripMenuItem1.Text = "Imprimer"
        '
        'ÉditionToolStripMenuItem
        '
        Me.ÉditionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AnnulerToolStripMenuItem, Me.RétablirToolStripMenuItem, Me.CopierToolStripMenuItem, Me.CouperToolStripMenuItem, Me.CollerToolStripMenuItem})
        Me.ÉditionToolStripMenuItem.Name = "ÉditionToolStripMenuItem"
        Me.ÉditionToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.ÉditionToolStripMenuItem.Text = "Édition"
        '
        'AnnulerToolStripMenuItem
        '
        Me.AnnulerToolStripMenuItem.Name = "AnnulerToolStripMenuItem"
        Me.AnnulerToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.AnnulerToolStripMenuItem.Text = "Annuler"
        '
        'RétablirToolStripMenuItem
        '
        Me.RétablirToolStripMenuItem.Name = "RétablirToolStripMenuItem"
        Me.RétablirToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.RétablirToolStripMenuItem.Text = "Rétablir"
        '
        'CopierToolStripMenuItem
        '
        Me.CopierToolStripMenuItem.Name = "CopierToolStripMenuItem"
        Me.CopierToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.CopierToolStripMenuItem.Text = "Copier"
        '
        'CouperToolStripMenuItem
        '
        Me.CouperToolStripMenuItem.Name = "CouperToolStripMenuItem"
        Me.CouperToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.CouperToolStripMenuItem.Text = "Couper"
        '
        'CollerToolStripMenuItem
        '
        Me.CollerToolStripMenuItem.Name = "CollerToolStripMenuItem"
        Me.CollerToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.CollerToolStripMenuItem.Text = "Coller"
        '
        'TexteToolStripMenuItem
        '
        Me.TexteToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CouleurToolStripMenuItem, Me.PoliceToolStripMenuItem})
        Me.TexteToolStripMenuItem.Name = "TexteToolStripMenuItem"
        Me.TexteToolStripMenuItem.Size = New System.Drawing.Size(47, 20)
        Me.TexteToolStripMenuItem.Text = "Texte"
        '
        'CouleurToolStripMenuItem
        '
        Me.CouleurToolStripMenuItem.Name = "CouleurToolStripMenuItem"
        Me.CouleurToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.CouleurToolStripMenuItem.Text = "Couleur de police"
        '
        'PoliceToolStripMenuItem
        '
        Me.PoliceToolStripMenuItem.Name = "PoliceToolStripMenuItem"
        Me.PoliceToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.PoliceToolStripMenuItem.Text = "Police"
        '
        'PageToolStripMenuItem
        '
        Me.PageToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CouleurDeFondToolStripMenuItem})
        Me.PageToolStripMenuItem.Name = "PageToolStripMenuItem"
        Me.PageToolStripMenuItem.Size = New System.Drawing.Size(45, 20)
        Me.PageToolStripMenuItem.Text = "Page"
        '
        'CouleurDeFondToolStripMenuItem
        '
        Me.CouleurDeFondToolStripMenuItem.Name = "CouleurDeFondToolStripMenuItem"
        Me.CouleurDeFondToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.CouleurDeFondToolStripMenuItem.Text = "Couleur de fond"
        '
        'CheckBox1
        '
        Me.CheckBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(207, 7)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(192, 17)
        Me.CheckBox1.TabIndex = 2
        Me.CheckBox1.Text = "Revenir à la ligne automatiquement"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'PrintDialog1
        '
        Me.PrintDialog1.Document = Me.PrintDocument1
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Notepad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(762, 415)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MinimumSize = New System.Drawing.Size(778, 449)
        Me.Name = "Notepad"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Notepad"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents FichierToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NouveauToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OuvrirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EnrengisterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EnrengisterSousToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImprimerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AperçuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImprimerToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ÉditionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AnnulerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RétablirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopierToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CouperToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CollerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TexteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CouleurToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PoliceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CouleurDeFondToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
End Class
