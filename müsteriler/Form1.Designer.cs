namespace müsteriler
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mÜŞTERİLERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eKLEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sİLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gÜNCELLEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mÜŞTERİLERToolStripMenuItem,
            this.eKLEToolStripMenuItem,
            this.sİLToolStripMenuItem,
            this.gÜNCELLEToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(759, 26);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mÜŞTERİLERToolStripMenuItem
            // 
            this.mÜŞTERİLERToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.mÜŞTERİLERToolStripMenuItem.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mÜŞTERİLERToolStripMenuItem.ForeColor = System.Drawing.Color.RoyalBlue;
            this.mÜŞTERİLERToolStripMenuItem.Name = "mÜŞTERİLERToolStripMenuItem";
            this.mÜŞTERİLERToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.mÜŞTERİLERToolStripMenuItem.Text = "MÜŞTERİLER";
            this.mÜŞTERİLERToolStripMenuItem.Click += new System.EventHandler(this.mÜŞTERİLERToolStripMenuItem_Click);
            // 
            // eKLEToolStripMenuItem
            // 
            this.eKLEToolStripMenuItem.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.eKLEToolStripMenuItem.ForeColor = System.Drawing.Color.RoyalBlue;
            this.eKLEToolStripMenuItem.Name = "eKLEToolStripMenuItem";
            this.eKLEToolStripMenuItem.Size = new System.Drawing.Size(60, 22);
            this.eKLEToolStripMenuItem.Text = "EKLE";
            this.eKLEToolStripMenuItem.Click += new System.EventHandler(this.eKLEToolStripMenuItem_Click);
            // 
            // sİLToolStripMenuItem
            // 
            this.sİLToolStripMenuItem.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sİLToolStripMenuItem.ForeColor = System.Drawing.Color.RoyalBlue;
            this.sİLToolStripMenuItem.Name = "sİLToolStripMenuItem";
            this.sİLToolStripMenuItem.Size = new System.Drawing.Size(42, 22);
            this.sİLToolStripMenuItem.Text = "SİL";
            this.sİLToolStripMenuItem.Click += new System.EventHandler(this.sİLToolStripMenuItem_Click);
            // 
            // gÜNCELLEToolStripMenuItem
            // 
            this.gÜNCELLEToolStripMenuItem.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gÜNCELLEToolStripMenuItem.ForeColor = System.Drawing.Color.RoyalBlue;
            this.gÜNCELLEToolStripMenuItem.Name = "gÜNCELLEToolStripMenuItem";
            this.gÜNCELLEToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.gÜNCELLEToolStripMenuItem.Text = "GÜNCELLE";
            this.gÜNCELLEToolStripMenuItem.Click += new System.EventHandler(this.gÜNCELLEToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(759, 332);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mÜŞTERİLERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eKLEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sİLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gÜNCELLEToolStripMenuItem;
    }
}

