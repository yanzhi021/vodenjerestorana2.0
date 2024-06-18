namespace vodenjerestorana
{
    partial class Upravitelj
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            unosNovihProizvodaToolStripMenuItem = new ToolStripMenuItem();
            prikazProizvodaToolStripMenuItem = new ToolStripMenuItem();
            listBox1 = new ListBox();
            btnPrikažiNarudžbu = new Button();
            btnObriši = new Button();
            btnZatvori = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { unosNovihProizvodaToolStripMenuItem, prikazProizvodaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(317, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // unosNovihProizvodaToolStripMenuItem
            // 
            unosNovihProizvodaToolStripMenuItem.Name = "unosNovihProizvodaToolStripMenuItem";
            unosNovihProizvodaToolStripMenuItem.Size = new Size(167, 24);
            unosNovihProizvodaToolStripMenuItem.Text = "Unos novih proizvoda";
            unosNovihProizvodaToolStripMenuItem.Click += unosNovihProizvodaToolStripMenuItem_Click;
            // 
            // prikazProizvodaToolStripMenuItem
            // 
            prikazProizvodaToolStripMenuItem.Name = "prikazProizvodaToolStripMenuItem";
            prikazProizvodaToolStripMenuItem.Size = new Size(133, 24);
            prikazProizvodaToolStripMenuItem.Text = "Prikaz proizvoda";
            prikazProizvodaToolStripMenuItem.Click += prikazProizvodaToolStripMenuItem_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(28, 88);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(264, 204);
            listBox1.TabIndex = 1;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // btnPrikažiNarudžbu
            // 
            btnPrikažiNarudžbu.Location = new Point(28, 53);
            btnPrikažiNarudžbu.Name = "btnPrikažiNarudžbu";
            btnPrikažiNarudžbu.Size = new Size(150, 29);
            btnPrikažiNarudžbu.TabIndex = 2;
            btnPrikažiNarudžbu.Text = "Prikaži narudžbu";
            btnPrikažiNarudžbu.UseVisualStyleBackColor = true;
            btnPrikažiNarudžbu.Click += btnPrikažiNarudžbu_Click;
            // 
            // btnObriši
            // 
            btnObriši.Location = new Point(28, 376);
            btnObriši.Name = "btnObriši";
            btnObriši.Size = new Size(94, 29);
            btnObriši.TabIndex = 3;
            btnObriši.Text = "Obriši";
            btnObriši.UseVisualStyleBackColor = true;
            btnObriši.Click += btnObriši_Click;
            // 
            // btnZatvori
            // 
            btnZatvori.Location = new Point(198, 376);
            btnZatvori.Name = "btnZatvori";
            btnZatvori.Size = new Size(94, 29);
            btnZatvori.TabIndex = 4;
            btnZatvori.Text = "Zatvori";
            btnZatvori.UseVisualStyleBackColor = true;
            btnZatvori.Click += btnZatvori_Click;
            // 
            // Upravitelj
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(317, 450);
            Controls.Add(btnZatvori);
            Controls.Add(btnObriši);
            Controls.Add(btnPrikažiNarudžbu);
            Controls.Add(listBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Upravitelj";
            Text = "Upravitelj";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem unosNovihProizvodaToolStripMenuItem;
        private ToolStripMenuItem prikazProizvodaToolStripMenuItem;
        private ListBox listBox1;
        private Button btnPrikažiNarudžbu;
        private Button btnObriši;
        private Button btnZatvori;
    }
}