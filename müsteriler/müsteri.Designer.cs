namespace müsteriler
{
    partial class müsteri
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtYil = new System.Windows.Forms.TextBox();
            this.TxtAy = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtFirma = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtSube = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtTutar1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtTutar2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtTtutar3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtTarih = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.BtnTemizle = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(32, 128);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(677, 110);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(14, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "YIL";
            // 
            // TxtYil
            // 
            this.TxtYil.Location = new System.Drawing.Point(66, 5);
            this.TxtYil.Name = "TxtYil";
            this.TxtYil.Size = new System.Drawing.Size(100, 20);
            this.TxtYil.TabIndex = 2;
            this.TxtYil.TextChanged += new System.EventHandler(this.TxtYil_TextChanged_1);
            // 
            // TxtAy
            // 
            this.TxtAy.Location = new System.Drawing.Point(66, 35);
            this.TxtAy.Name = "TxtAy";
            this.TxtAy.Size = new System.Drawing.Size(100, 20);
            this.TxtAy.TabIndex = 4;
            this.TxtAy.TextChanged += new System.EventHandler(this.TxtAy_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(14, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "AY";
            // 
            // TxtFirma
            // 
            this.TxtFirma.Location = new System.Drawing.Point(241, 5);
            this.TxtFirma.Name = "TxtFirma";
            this.TxtFirma.Size = new System.Drawing.Size(100, 20);
            this.TxtFirma.TabIndex = 6;
            this.TxtFirma.TextChanged += new System.EventHandler(this.TxtFirma_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(189, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "FİRMA";
            // 
            // TxtSube
            // 
            this.TxtSube.Location = new System.Drawing.Point(241, 33);
            this.TxtSube.Name = "TxtSube";
            this.TxtSube.Size = new System.Drawing.Size(100, 20);
            this.TxtSube.TabIndex = 8;
            this.TxtSube.TextChanged += new System.EventHandler(this.TxtSube_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(189, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "SUBE";
            // 
            // TxtTutar1
            // 
            this.TxtTutar1.Location = new System.Drawing.Point(433, 12);
            this.TxtTutar1.Name = "TxtTutar1";
            this.TxtTutar1.Size = new System.Drawing.Size(100, 20);
            this.TxtTutar1.TabIndex = 10;
            this.TxtTutar1.TextChanged += new System.EventHandler(this.TxtTutar1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Monotype Corsiva", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(381, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "TUTAR1";
            // 
            // TxtTutar2
            // 
            this.TxtTutar2.Location = new System.Drawing.Point(433, 35);
            this.TxtTutar2.Name = "TxtTutar2";
            this.TxtTutar2.Size = new System.Drawing.Size(100, 20);
            this.TxtTutar2.TabIndex = 12;
            this.TxtTutar2.TextChanged += new System.EventHandler(this.TxtTutar2_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Monotype Corsiva", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(381, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "TUTAR2";
            // 
            // TxtTtutar3
            // 
            this.TxtTtutar3.Location = new System.Drawing.Point(433, 63);
            this.TxtTtutar3.Name = "TxtTtutar3";
            this.TxtTtutar3.Size = new System.Drawing.Size(100, 20);
            this.TxtTtutar3.TabIndex = 14;
            this.TxtTtutar3.TextChanged += new System.EventHandler(this.TxtTtutar3_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Monotype Corsiva", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(381, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "TUTAR3";
            // 
            // TxtTarih
            // 
            this.TxtTarih.Location = new System.Drawing.Point(66, 69);
            this.TxtTarih.Name = "TxtTarih";
            this.TxtTarih.Size = new System.Drawing.Size(100, 20);
            this.TxtTarih.TabIndex = 16;
            this.TxtTarih.TextChanged += new System.EventHandler(this.TxtTarih_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Monotype Corsiva", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(14, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 15);
            this.label8.TabIndex = 15;
            this.label8.Text = "TARİH";
            // 
            // BtnTemizle
            // 
            this.BtnTemizle.Location = new System.Drawing.Point(660, 5);
            this.BtnTemizle.Name = "BtnTemizle";
            this.BtnTemizle.Size = new System.Drawing.Size(75, 23);
            this.BtnTemizle.TabIndex = 17;
            this.BtnTemizle.Text = "Temizle";
            this.BtnTemizle.UseVisualStyleBackColor = true;
            this.BtnTemizle.Click += new System.EventHandler(this.BtnTemizle_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Monotype Corsiva", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(552, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 15);
            this.label9.TabIndex = 18;
            this.label9.Text = "Silinecek ID";
            // 
            // TxtID
            // 
            this.TxtID.Location = new System.Drawing.Point(622, 7);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(32, 20);
            this.TxtID.TabIndex = 19;
            this.TxtID.TextChanged += new System.EventHandler(this.TxtID_TextChanged);
            // 
            // müsteri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(747, 250);
            this.Controls.Add(this.TxtID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.BtnTemizle);
            this.Controls.Add(this.TxtTarih);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TxtTtutar3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtTutar2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtTutar1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtSube);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtFirma);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtAy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtYil);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "müsteri";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "müsteri";
            this.Load += new System.EventHandler(this.müsteri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtYil;
        private System.Windows.Forms.TextBox TxtAy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtFirma;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtSube;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtTutar1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtTutar2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtTtutar3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtTarih;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BtnTemizle;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtID;
    }
}