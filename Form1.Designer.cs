namespace vodenjerestorana
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            pictureBox1 = new PictureBox();
            btnGost = new Button();
            btnUpravitelj = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Algerian", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            textBox1.Location = new Point(162, 26);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(488, 87);
            textBox1.TabIndex = 0;
            textBox1.Text = "BIser Orijenta";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            textBox2.Location = new Point(365, 119);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(321, 134);
            textBox2.TabIndex = 1;
            textBox2.Text = "Ulica Jurje Dobrilina 1\r\nRadno vrijeme: 11-23 h\r\nKontakt 021 486 776\r\n";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(118, 119);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(224, 225);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // btnGost
            // 
            btnGost.Font = new Font("Lucida Calligraphy", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnGost.Location = new Point(365, 315);
            btnGost.Name = "btnGost";
            btnGost.Size = new Size(94, 29);
            btnGost.TabIndex = 3;
            btnGost.Text = "Gost";
            btnGost.UseVisualStyleBackColor = true;
            btnGost.Click += btnGost_Click;
            // 
            // btnUpravitelj
            // 
            btnUpravitelj.Font = new Font("Lucida Calligraphy", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpravitelj.Location = new Point(551, 315);
            btnUpravitelj.Name = "btnUpravitelj";
            btnUpravitelj.Size = new Size(135, 29);
            btnUpravitelj.TabIndex = 4;
            btnUpravitelj.Text = "Upravitelj";
            btnUpravitelj.UseVisualStyleBackColor = true;
            btnUpravitelj.Click += btnUpravitelj_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnUpravitelj);
            Controls.Add(btnGost);
            Controls.Add(pictureBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private PictureBox pictureBox1;
        private Button btnGost;
        private Button btnUpravitelj;
    }
}