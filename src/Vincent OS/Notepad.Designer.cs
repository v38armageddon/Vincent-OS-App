using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Vincent_OS
{
    public partial class Notepad : Form
    {

        // Form remplace la méthode Dispose pour nettoyer la liste des composants.
        [DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components is not null)
                {
                    components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        // Requise par le Concepteur Windows Form
        private System.ComponentModel.IContainer components;

        // REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
        // Elle peut être modifiée à l'aide du Concepteur Windows Form.  
        // Ne la modifiez pas à l'aide de l'éditeur de code.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Notepad));
            this.RichTextBox1 = new System.Windows.Forms.RichTextBox();
            this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NouveauToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OuvrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.EnrengisterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EnrengisterSousToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.ImprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AperçuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ImprimerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ÉditionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AnnulerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RétablirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.CopierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CouperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CollerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TexteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CouleurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PoliceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CouleurDeFondToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.revenirÀLaLigneAutomatiquementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ColorDialog1 = new System.Windows.Forms.ColorDialog();
            this.FontDialog1 = new System.Windows.Forms.FontDialog();
            this.PrintDialog1 = new System.Windows.Forms.PrintDialog();
            this.PrintDocument1 = new System.Drawing.Printing.PrintDocument();
            this.PrintPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.SaveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.OpenFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.MenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RichTextBox1
            // 
            this.RichTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RichTextBox1.Location = new System.Drawing.Point(0, 28);
            this.RichTextBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.RichTextBox1.Name = "RichTextBox1";
            this.RichTextBox1.Size = new System.Drawing.Size(888, 451);
            this.RichTextBox1.TabIndex = 0;
            this.RichTextBox1.Text = "";
            // 
            // MenuStrip1
            // 
            this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FichierToolStripMenuItem,
            this.ÉditionToolStripMenuItem,
            this.TexteToolStripMenuItem,
            this.PageToolStripMenuItem});
            this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip1.Name = "MenuStrip1";
            this.MenuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.MenuStrip1.Size = new System.Drawing.Size(889, 24);
            this.MenuStrip1.TabIndex = 1;
            this.MenuStrip1.Text = "MenuStrip1";
            // 
            // FichierToolStripMenuItem
            // 
            this.FichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NouveauToolStripMenuItem,
            this.OuvrirToolStripMenuItem,
            this.toolStripMenuItem2,
            this.EnrengisterToolStripMenuItem,
            this.EnrengisterSousToolStripMenuItem,
            this.toolStripMenuItem3,
            this.ImprimerToolStripMenuItem});
            this.FichierToolStripMenuItem.Name = "FichierToolStripMenuItem";
            this.FichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.FichierToolStripMenuItem.Text = "Fichier";
            // 
            // NouveauToolStripMenuItem
            // 
            this.NouveauToolStripMenuItem.Name = "NouveauToolStripMenuItem";
            this.NouveauToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.NouveauToolStripMenuItem.Text = "Nouveau";
            this.NouveauToolStripMenuItem.Click += new System.EventHandler(this.NouveauToolStripMenuItem_Click);
            // 
            // OuvrirToolStripMenuItem
            // 
            this.OuvrirToolStripMenuItem.Name = "OuvrirToolStripMenuItem";
            this.OuvrirToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.OuvrirToolStripMenuItem.Text = "Ouvrir";
            this.OuvrirToolStripMenuItem.Click += new System.EventHandler(this.OuvrirToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(157, 6);
            // 
            // EnrengisterToolStripMenuItem
            // 
            this.EnrengisterToolStripMenuItem.Name = "EnrengisterToolStripMenuItem";
            this.EnrengisterToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.EnrengisterToolStripMenuItem.Text = "Enrengister";
            this.EnrengisterToolStripMenuItem.Click += new System.EventHandler(this.EnrengisterToolStripMenuItem_Click);
            // 
            // EnrengisterSousToolStripMenuItem
            // 
            this.EnrengisterSousToolStripMenuItem.Name = "EnrengisterSousToolStripMenuItem";
            this.EnrengisterSousToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.EnrengisterSousToolStripMenuItem.Text = "Enrengister sous";
            this.EnrengisterSousToolStripMenuItem.Click += new System.EventHandler(this.EnrengisterSousToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(157, 6);
            // 
            // ImprimerToolStripMenuItem
            // 
            this.ImprimerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AperçuToolStripMenuItem,
            this.ImprimerToolStripMenuItem1});
            this.ImprimerToolStripMenuItem.Name = "ImprimerToolStripMenuItem";
            this.ImprimerToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.ImprimerToolStripMenuItem.Text = "Imprimer";
            // 
            // AperçuToolStripMenuItem
            // 
            this.AperçuToolStripMenuItem.Name = "AperçuToolStripMenuItem";
            this.AperçuToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.AperçuToolStripMenuItem.Text = "Aperçu";
            this.AperçuToolStripMenuItem.Click += new System.EventHandler(this.AperçuToolStripMenuItem_Click);
            // 
            // ImprimerToolStripMenuItem1
            // 
            this.ImprimerToolStripMenuItem1.Name = "ImprimerToolStripMenuItem1";
            this.ImprimerToolStripMenuItem1.Size = new System.Drawing.Size(123, 22);
            this.ImprimerToolStripMenuItem1.Text = "Imprimer";
            this.ImprimerToolStripMenuItem1.Click += new System.EventHandler(this.ImprimerToolStripMenuItem1_Click);
            // 
            // ÉditionToolStripMenuItem
            // 
            this.ÉditionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AnnulerToolStripMenuItem,
            this.RétablirToolStripMenuItem,
            this.toolStripMenuItem1,
            this.CopierToolStripMenuItem,
            this.CouperToolStripMenuItem,
            this.CollerToolStripMenuItem});
            this.ÉditionToolStripMenuItem.Name = "ÉditionToolStripMenuItem";
            this.ÉditionToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.ÉditionToolStripMenuItem.Text = "Édition";
            // 
            // AnnulerToolStripMenuItem
            // 
            this.AnnulerToolStripMenuItem.Name = "AnnulerToolStripMenuItem";
            this.AnnulerToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.AnnulerToolStripMenuItem.Text = "Annuler";
            this.AnnulerToolStripMenuItem.Click += new System.EventHandler(this.AnnulerToolStripMenuItem_Click);
            // 
            // RétablirToolStripMenuItem
            // 
            this.RétablirToolStripMenuItem.Name = "RétablirToolStripMenuItem";
            this.RétablirToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.RétablirToolStripMenuItem.Text = "Rétablir";
            this.RétablirToolStripMenuItem.Click += new System.EventHandler(this.RétablirToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(113, 6);
            // 
            // CopierToolStripMenuItem
            // 
            this.CopierToolStripMenuItem.Name = "CopierToolStripMenuItem";
            this.CopierToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.CopierToolStripMenuItem.Text = "Copier";
            this.CopierToolStripMenuItem.Click += new System.EventHandler(this.CopierToolStripMenuItem_Click);
            // 
            // CouperToolStripMenuItem
            // 
            this.CouperToolStripMenuItem.Name = "CouperToolStripMenuItem";
            this.CouperToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.CouperToolStripMenuItem.Text = "Couper";
            this.CouperToolStripMenuItem.Click += new System.EventHandler(this.CouperToolStripMenuItem_Click);
            // 
            // CollerToolStripMenuItem
            // 
            this.CollerToolStripMenuItem.Name = "CollerToolStripMenuItem";
            this.CollerToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.CollerToolStripMenuItem.Text = "Coller";
            this.CollerToolStripMenuItem.Click += new System.EventHandler(this.CollerToolStripMenuItem_Click);
            // 
            // TexteToolStripMenuItem
            // 
            this.TexteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CouleurToolStripMenuItem,
            this.PoliceToolStripMenuItem});
            this.TexteToolStripMenuItem.Name = "TexteToolStripMenuItem";
            this.TexteToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.TexteToolStripMenuItem.Text = "Texte";
            // 
            // CouleurToolStripMenuItem
            // 
            this.CouleurToolStripMenuItem.Name = "CouleurToolStripMenuItem";
            this.CouleurToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.CouleurToolStripMenuItem.Text = "Couleur de police";
            this.CouleurToolStripMenuItem.Click += new System.EventHandler(this.CouleurToolStripMenuItem_Click);
            // 
            // PoliceToolStripMenuItem
            // 
            this.PoliceToolStripMenuItem.Name = "PoliceToolStripMenuItem";
            this.PoliceToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.PoliceToolStripMenuItem.Text = "Police";
            this.PoliceToolStripMenuItem.Click += new System.EventHandler(this.PoliceToolStripMenuItem_Click);
            // 
            // PageToolStripMenuItem
            // 
            this.PageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CouleurDeFondToolStripMenuItem,
            this.revenirÀLaLigneAutomatiquementToolStripMenuItem});
            this.PageToolStripMenuItem.Name = "PageToolStripMenuItem";
            this.PageToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.PageToolStripMenuItem.Text = "Page";
            // 
            // CouleurDeFondToolStripMenuItem
            // 
            this.CouleurDeFondToolStripMenuItem.Name = "CouleurDeFondToolStripMenuItem";
            this.CouleurDeFondToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.CouleurDeFondToolStripMenuItem.Text = "Couleur de fond";
            this.CouleurDeFondToolStripMenuItem.Click += new System.EventHandler(this.CouleurDeFondToolStripMenuItem_Click);
            // 
            // revenirÀLaLigneAutomatiquementToolStripMenuItem
            // 
            this.revenirÀLaLigneAutomatiquementToolStripMenuItem.CheckOnClick = true;
            this.revenirÀLaLigneAutomatiquementToolStripMenuItem.Name = "revenirÀLaLigneAutomatiquementToolStripMenuItem";
            this.revenirÀLaLigneAutomatiquementToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.revenirÀLaLigneAutomatiquementToolStripMenuItem.Text = "Revenir à la ligne automatiquement";
            this.revenirÀLaLigneAutomatiquementToolStripMenuItem.Click += new System.EventHandler(this.revenirÀLaLigneAutomatiquementToolStripMenuItem_Click);
            // 
            // PrintDialog1
            // 
            this.PrintDialog1.Document = this.PrintDocument1;
            this.PrintDialog1.UseEXDialog = true;
            // 
            // PrintDocument1
            // 
            this.PrintDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDocument1_PrintPage);
            // 
            // PrintPreviewDialog1
            // 
            this.PrintPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.PrintPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.PrintPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.PrintPreviewDialog1.Document = this.PrintDocument1;
            this.PrintPreviewDialog1.Enabled = true;
            this.PrintPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("PrintPreviewDialog1.Icon")));
            this.PrintPreviewDialog1.Name = "PrintPreviewDialog1";
            this.PrintPreviewDialog1.Visible = false;
            // 
            // OpenFileDialog1
            // 
            this.OpenFileDialog1.FileName = "OpenFileDialog1";
            // 
            // Notepad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 479);
            this.Controls.Add(this.RichTextBox1);
            this.Controls.Add(this.MenuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimumSize = new System.Drawing.Size(905, 512);
            this.Name = "Notepad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notepad";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Notepad_FormClosed);
            this.Load += new System.EventHandler(this.Notepad_Load);
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        internal RichTextBox RichTextBox1;
        internal MenuStrip MenuStrip1;
        internal ToolStripMenuItem FichierToolStripMenuItem;
        internal ToolStripMenuItem NouveauToolStripMenuItem;
        internal ToolStripMenuItem OuvrirToolStripMenuItem;
        internal ToolStripMenuItem EnrengisterToolStripMenuItem;
        internal ToolStripMenuItem EnrengisterSousToolStripMenuItem;
        internal ToolStripMenuItem ImprimerToolStripMenuItem;
        internal ToolStripMenuItem AperçuToolStripMenuItem;
        internal ToolStripMenuItem ImprimerToolStripMenuItem1;
        internal ToolStripMenuItem ÉditionToolStripMenuItem;
        internal ToolStripMenuItem AnnulerToolStripMenuItem;
        internal ToolStripMenuItem RétablirToolStripMenuItem;
        internal ToolStripMenuItem CopierToolStripMenuItem;
        internal ToolStripMenuItem CouperToolStripMenuItem;
        internal ToolStripMenuItem CollerToolStripMenuItem;
        internal ToolStripMenuItem TexteToolStripMenuItem;
        internal ToolStripMenuItem CouleurToolStripMenuItem;
        internal ToolStripMenuItem PoliceToolStripMenuItem;
        internal ToolStripMenuItem PageToolStripMenuItem;
        internal ToolStripMenuItem CouleurDeFondToolStripMenuItem;
        internal ColorDialog ColorDialog1;
        internal FontDialog FontDialog1;
        internal PrintDialog PrintDialog1;
        internal System.Drawing.Printing.PrintDocument PrintDocument1;
        internal PrintPreviewDialog PrintPreviewDialog1;
        internal SaveFileDialog SaveFileDialog1;
        internal OpenFileDialog OpenFileDialog1;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripSeparator toolStripMenuItem3;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem revenirÀLaLigneAutomatiquementToolStripMenuItem;
    }
}