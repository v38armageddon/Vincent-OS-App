using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Vincent_OS
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(Notepad));
            RichTextBox1 = new RichTextBox();
            MenuStrip1 = new MenuStrip();
            FichierToolStripMenuItem = new ToolStripMenuItem();
            NouveauToolStripMenuItem = new ToolStripMenuItem();
            NouveauToolStripMenuItem.Click += new EventHandler(NouveauToolStripMenuItem_Click);
            OuvrirToolStripMenuItem = new ToolStripMenuItem();
            OuvrirToolStripMenuItem.Click += new EventHandler(OuvrirToolStripMenuItem_Click);
            EnrengisterToolStripMenuItem = new ToolStripMenuItem();
            EnrengisterToolStripMenuItem.Click += new EventHandler(EnrengisterToolStripMenuItem_Click);
            EnrengisterSousToolStripMenuItem = new ToolStripMenuItem();
            EnrengisterSousToolStripMenuItem.Click += new EventHandler(EnrengisterSousToolStripMenuItem_Click);
            ImprimerToolStripMenuItem = new ToolStripMenuItem();
            AperçuToolStripMenuItem = new ToolStripMenuItem();
            AperçuToolStripMenuItem.Click += new EventHandler(AperçuToolStripMenuItem_Click);
            ImprimerToolStripMenuItem1 = new ToolStripMenuItem();
            ImprimerToolStripMenuItem1.Click += new EventHandler(ImprimerToolStripMenuItem1_Click);
            ÉditionToolStripMenuItem = new ToolStripMenuItem();
            AnnulerToolStripMenuItem = new ToolStripMenuItem();
            AnnulerToolStripMenuItem.Click += new EventHandler(AnnulerToolStripMenuItem_Click);
            RétablirToolStripMenuItem = new ToolStripMenuItem();
            RétablirToolStripMenuItem.Click += new EventHandler(RétablirToolStripMenuItem_Click);
            CopierToolStripMenuItem = new ToolStripMenuItem();
            CopierToolStripMenuItem.Click += new EventHandler(CopierToolStripMenuItem_Click);
            CouperToolStripMenuItem = new ToolStripMenuItem();
            CouperToolStripMenuItem.Click += new EventHandler(CouperToolStripMenuItem_Click);
            CollerToolStripMenuItem = new ToolStripMenuItem();
            CollerToolStripMenuItem.Click += new EventHandler(CollerToolStripMenuItem_Click);
            TexteToolStripMenuItem = new ToolStripMenuItem();
            CouleurToolStripMenuItem = new ToolStripMenuItem();
            CouleurToolStripMenuItem.Click += new EventHandler(CouleurToolStripMenuItem_Click);
            PoliceToolStripMenuItem = new ToolStripMenuItem();
            PoliceToolStripMenuItem.Click += new EventHandler(PoliceToolStripMenuItem_Click);
            PageToolStripMenuItem = new ToolStripMenuItem();
            CouleurDeFondToolStripMenuItem = new ToolStripMenuItem();
            CouleurDeFondToolStripMenuItem.Click += new EventHandler(CouleurDeFondToolStripMenuItem_Click);
            CheckBox1 = new CheckBox();
            CheckBox1.CheckedChanged += new EventHandler(CheckBox1_CheckedChanged);
            ColorDialog1 = new ColorDialog();
            FontDialog1 = new FontDialog();
            PrintDialog1 = new PrintDialog();
            PrintDocument1 = new System.Drawing.Printing.PrintDocument();
            PrintDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(PrintDocument1_PrintPage);
            PrintPreviewDialog1 = new PrintPreviewDialog();
            SaveFileDialog1 = new SaveFileDialog();
            OpenFileDialog1 = new OpenFileDialog();
            MenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // RichTextBox1
            // 
            RichTextBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            RichTextBox1.Location = new Point(0, 24);
            RichTextBox1.Name = "RichTextBox1";
            RichTextBox1.Size = new Size(762, 391);
            RichTextBox1.TabIndex = 0;
            RichTextBox1.Text = "";
            // 
            // MenuStrip1
            // 
            MenuStrip1.Items.AddRange(new ToolStripItem[] { FichierToolStripMenuItem, ÉditionToolStripMenuItem, TexteToolStripMenuItem, PageToolStripMenuItem });
            MenuStrip1.Location = new Point(0, 0);
            MenuStrip1.Name = "MenuStrip1";
            MenuStrip1.Size = new Size(762, 24);
            MenuStrip1.TabIndex = 1;
            MenuStrip1.Text = "MenuStrip1";
            // 
            // FichierToolStripMenuItem
            // 
            FichierToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { NouveauToolStripMenuItem, OuvrirToolStripMenuItem, EnrengisterToolStripMenuItem, EnrengisterSousToolStripMenuItem, ImprimerToolStripMenuItem });
            FichierToolStripMenuItem.Name = "FichierToolStripMenuItem";
            FichierToolStripMenuItem.Size = new Size(54, 20);
            FichierToolStripMenuItem.Text = "Fichier";
            // 
            // NouveauToolStripMenuItem
            // 
            NouveauToolStripMenuItem.Name = "NouveauToolStripMenuItem";
            NouveauToolStripMenuItem.Size = new Size(160, 22);
            NouveauToolStripMenuItem.Text = "Nouveau";
            // 
            // OuvrirToolStripMenuItem
            // 
            OuvrirToolStripMenuItem.Name = "OuvrirToolStripMenuItem";
            OuvrirToolStripMenuItem.Size = new Size(160, 22);
            OuvrirToolStripMenuItem.Text = "Ouvrir";
            // 
            // EnrengisterToolStripMenuItem
            // 
            EnrengisterToolStripMenuItem.Name = "EnrengisterToolStripMenuItem";
            EnrengisterToolStripMenuItem.Size = new Size(160, 22);
            EnrengisterToolStripMenuItem.Text = "Enrengister";
            // 
            // EnrengisterSousToolStripMenuItem
            // 
            EnrengisterSousToolStripMenuItem.Name = "EnrengisterSousToolStripMenuItem";
            EnrengisterSousToolStripMenuItem.Size = new Size(160, 22);
            EnrengisterSousToolStripMenuItem.Text = "Enrengister sous";
            // 
            // ImprimerToolStripMenuItem
            // 
            ImprimerToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { AperçuToolStripMenuItem, ImprimerToolStripMenuItem1 });
            ImprimerToolStripMenuItem.Name = "ImprimerToolStripMenuItem";
            ImprimerToolStripMenuItem.Size = new Size(160, 22);
            ImprimerToolStripMenuItem.Text = "Imprimer";
            // 
            // AperçuToolStripMenuItem
            // 
            AperçuToolStripMenuItem.Name = "AperçuToolStripMenuItem";
            AperçuToolStripMenuItem.Size = new Size(123, 22);
            AperçuToolStripMenuItem.Text = "Aperçu";
            // 
            // ImprimerToolStripMenuItem1
            // 
            ImprimerToolStripMenuItem1.Name = "ImprimerToolStripMenuItem1";
            ImprimerToolStripMenuItem1.Size = new Size(123, 22);
            ImprimerToolStripMenuItem1.Text = "Imprimer";
            // 
            // ÉditionToolStripMenuItem
            // 
            ÉditionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { AnnulerToolStripMenuItem, RétablirToolStripMenuItem, CopierToolStripMenuItem, CouperToolStripMenuItem, CollerToolStripMenuItem });
            ÉditionToolStripMenuItem.Name = "ÉditionToolStripMenuItem";
            ÉditionToolStripMenuItem.Size = new Size(56, 20);
            ÉditionToolStripMenuItem.Text = "Édition";
            // 
            // AnnulerToolStripMenuItem
            // 
            AnnulerToolStripMenuItem.Name = "AnnulerToolStripMenuItem";
            AnnulerToolStripMenuItem.Size = new Size(116, 22);
            AnnulerToolStripMenuItem.Text = "Annuler";
            // 
            // RétablirToolStripMenuItem
            // 
            RétablirToolStripMenuItem.Name = "RétablirToolStripMenuItem";
            RétablirToolStripMenuItem.Size = new Size(116, 22);
            RétablirToolStripMenuItem.Text = "Rétablir";
            // 
            // CopierToolStripMenuItem
            // 
            CopierToolStripMenuItem.Name = "CopierToolStripMenuItem";
            CopierToolStripMenuItem.Size = new Size(116, 22);
            CopierToolStripMenuItem.Text = "Copier";
            // 
            // CouperToolStripMenuItem
            // 
            CouperToolStripMenuItem.Name = "CouperToolStripMenuItem";
            CouperToolStripMenuItem.Size = new Size(116, 22);
            CouperToolStripMenuItem.Text = "Couper";
            // 
            // CollerToolStripMenuItem
            // 
            CollerToolStripMenuItem.Name = "CollerToolStripMenuItem";
            CollerToolStripMenuItem.Size = new Size(116, 22);
            CollerToolStripMenuItem.Text = "Coller";
            // 
            // TexteToolStripMenuItem
            // 
            TexteToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { CouleurToolStripMenuItem, PoliceToolStripMenuItem });
            TexteToolStripMenuItem.Name = "TexteToolStripMenuItem";
            TexteToolStripMenuItem.Size = new Size(47, 20);
            TexteToolStripMenuItem.Text = "Texte";
            // 
            // CouleurToolStripMenuItem
            // 
            CouleurToolStripMenuItem.Name = "CouleurToolStripMenuItem";
            CouleurToolStripMenuItem.Size = new Size(167, 22);
            CouleurToolStripMenuItem.Text = "Couleur de police";
            // 
            // PoliceToolStripMenuItem
            // 
            PoliceToolStripMenuItem.Name = "PoliceToolStripMenuItem";
            PoliceToolStripMenuItem.Size = new Size(167, 22);
            PoliceToolStripMenuItem.Text = "Police";
            // 
            // PageToolStripMenuItem
            // 
            PageToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { CouleurDeFondToolStripMenuItem });
            PageToolStripMenuItem.Name = "PageToolStripMenuItem";
            PageToolStripMenuItem.Size = new Size(45, 20);
            PageToolStripMenuItem.Text = "Page";
            // 
            // CouleurDeFondToolStripMenuItem
            // 
            CouleurDeFondToolStripMenuItem.Name = "CouleurDeFondToolStripMenuItem";
            CouleurDeFondToolStripMenuItem.Size = new Size(160, 22);
            CouleurDeFondToolStripMenuItem.Text = "Couleur de fond";
            // 
            // CheckBox1
            // 
            CheckBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CheckBox1.AutoSize = true;
            CheckBox1.Location = new Point(207, 7);
            CheckBox1.Name = "CheckBox1";
            CheckBox1.Size = new Size(192, 17);
            CheckBox1.TabIndex = 2;
            CheckBox1.Text = "Revenir à la ligne automatiquement";
            CheckBox1.UseVisualStyleBackColor = true;
            // 
            // PrintDialog1
            // 
            PrintDialog1.Document = PrintDocument1;
            PrintDialog1.UseEXDialog = true;
            // 
            // PrintDocument1
            // 
            // 
            // PrintPreviewDialog1
            // 
            PrintPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            PrintPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            PrintPreviewDialog1.ClientSize = new Size(400, 300);
            PrintPreviewDialog1.Document = PrintDocument1;
            PrintPreviewDialog1.Enabled = true;
            PrintPreviewDialog1.Icon = (Icon)resources.GetObject("PrintPreviewDialog1.Icon");
            PrintPreviewDialog1.Name = "PrintPreviewDialog1";
            PrintPreviewDialog1.Visible = false;
            // 
            // OpenFileDialog1
            // 
            OpenFileDialog1.FileName = "OpenFileDialog1";
            // 
            // Notepad
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(762, 415);
            Controls.Add(CheckBox1);
            Controls.Add(RichTextBox1);
            Controls.Add(MenuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = MenuStrip1;
            MinimumSize = new Size(778, 449);
            Name = "Notepad";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Notepad";
            MenuStrip1.ResumeLayout(false);
            MenuStrip1.PerformLayout();
            Load += new EventHandler(Notepad_Load);
            FormClosed += new FormClosedEventHandler(Notepad_FormClosed);
            ResumeLayout(false);
            PerformLayout();

        }
        internal RichTextBox RichTextBox1;
        internal MenuStrip MenuStrip1;
        internal CheckBox CheckBox1;
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
    }
}