namespace ZeaMart_System
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.searchlabel = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxedjumlah = new System.Windows.Forms.TextBox();
            this.textBoxedharga = new System.Windows.Forms.TextBox();
            this.textBoxednama = new System.Windows.Forms.TextBox();
            this.textBoxedkode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.datagrid_novel = new System.Windows.Forms.DataGridView();
            this.textBoxjumlah = new System.Windows.Forms.TextBox();
            this.textBoxharga = new System.Windows.Forms.TextBox();
            this.textBoxnama = new System.Windows.Forms.TextBox();
            this.buttonpicture = new System.Windows.Forms.Button();
            this.picturebx = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_novel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturebx)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(226)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(803, 69);
            this.panel1.TabIndex = 0;
            // 
            // searchlabel
            // 
            this.searchlabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchlabel.Location = new System.Drawing.Point(282, 17);
            this.searchlabel.Multiline = true;
            this.searchlabel.Name = "searchlabel";
            this.searchlabel.Size = new System.Drawing.Size(504, 31);
            this.searchlabel.TabIndex = 20;
            this.searchlabel.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(198)))), ((int)(((byte)(231)))));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(153, 17);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(104, 31);
            this.button5.TabIndex = 19;
            this.button5.Text = "Search:";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Goudy Old Style", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(68, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "mart";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Goudy Stout", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 66);
            this.label2.TabIndex = 0;
            this.label2.Text = "Z";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.searchlabel);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.button5);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.textBoxedjumlah);
            this.panel3.Controls.Add(this.textBoxedharga);
            this.panel3.Controls.Add(this.textBoxednama);
            this.panel3.Controls.Add(this.textBoxedkode);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.btnedit);
            this.panel3.Controls.Add(this.btnsave);
            this.panel3.Controls.Add(this.datagrid_novel);
            this.panel3.Controls.Add(this.textBoxjumlah);
            this.panel3.Controls.Add(this.textBoxharga);
            this.panel3.Controls.Add(this.textBoxnama);
            this.panel3.Controls.Add(this.buttonpicture);
            this.panel3.Controls.Add(this.picturebx);
            this.panel3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(0, 64);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(799, 504);
            this.panel3.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(581, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 17);
            this.label7.TabIndex = 30;
            this.label7.Text = "Jumlah Novel";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(578, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 17);
            this.label8.TabIndex = 29;
            this.label8.Text = "Harga Novel";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(577, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 17);
            this.label9.TabIndex = 28;
            this.label9.Text = "Nama Novel";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(577, 51);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 17);
            this.label10.TabIndex = 27;
            this.label10.Text = "Kode Novel";
            // 
            // textBoxedjumlah
            // 
            this.textBoxedjumlah.Location = new System.Drawing.Point(580, 212);
            this.textBoxedjumlah.Name = "textBoxedjumlah";
            this.textBoxedjumlah.Size = new System.Drawing.Size(206, 23);
            this.textBoxedjumlah.TabIndex = 26;
            // 
            // textBoxedharga
            // 
            this.textBoxedharga.Location = new System.Drawing.Point(580, 164);
            this.textBoxedharga.Name = "textBoxedharga";
            this.textBoxedharga.Size = new System.Drawing.Size(206, 23);
            this.textBoxedharga.TabIndex = 25;
            // 
            // textBoxednama
            // 
            this.textBoxednama.Location = new System.Drawing.Point(580, 116);
            this.textBoxednama.Name = "textBoxednama";
            this.textBoxednama.Size = new System.Drawing.Size(206, 23);
            this.textBoxednama.TabIndex = 24;
            this.textBoxednama.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBoxedkode
            // 
            this.textBoxedkode.Location = new System.Drawing.Point(580, 71);
            this.textBoxedkode.Name = "textBoxedkode";
            this.textBoxedkode.Size = new System.Drawing.Size(206, 23);
            this.textBoxedkode.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(152, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 17);
            this.label6.TabIndex = 22;
            this.label6.Text = "Jumlah Novel";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(152, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "Harga Novel";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(152, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "Nama Novel";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(152, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 19;
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // btnedit
            // 
            this.btnedit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(198)))), ((int)(((byte)(231)))));
            this.btnedit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnedit.FlatAppearance.BorderSize = 0;
            this.btnedit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnedit.ForeColor = System.Drawing.Color.White;
            this.btnedit.Location = new System.Drawing.Point(472, 204);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(102, 31);
            this.btnedit.TabIndex = 17;
            this.btnedit.Text = "Ubah";
            this.btnedit.UseVisualStyleBackColor = false;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(198)))), ((int)(((byte)(231)))));
            this.btnsave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsave.FlatAppearance.BorderSize = 0;
            this.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsave.ForeColor = System.Drawing.Color.White;
            this.btnsave.Location = new System.Drawing.Point(155, 204);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(104, 31);
            this.btnsave.TabIndex = 16;
            this.btnsave.Text = "Tambah";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // datagrid_novel
            // 
            this.datagrid_novel.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.datagrid_novel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagrid_novel.DefaultCellStyle = dataGridViewCellStyle1;
            this.datagrid_novel.GridColor = System.Drawing.Color.SkyBlue;
            this.datagrid_novel.Location = new System.Drawing.Point(12, 251);
            this.datagrid_novel.Name = "datagrid_novel";
            this.datagrid_novel.Size = new System.Drawing.Size(770, 238);
            this.datagrid_novel.TabIndex = 15;
            this.datagrid_novel.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // textBoxjumlah
            // 
            this.textBoxjumlah.Location = new System.Drawing.Point(155, 162);
            this.textBoxjumlah.Name = "textBoxjumlah";
            this.textBoxjumlah.Size = new System.Drawing.Size(206, 23);
            this.textBoxjumlah.TabIndex = 14;
            this.textBoxjumlah.TextChanged += new System.EventHandler(this.textBoxjumlah_TextChanged);
            // 
            // textBoxharga
            // 
            this.textBoxharga.Location = new System.Drawing.Point(155, 116);
            this.textBoxharga.Name = "textBoxharga";
            this.textBoxharga.Size = new System.Drawing.Size(206, 23);
            this.textBoxharga.TabIndex = 13;
            this.textBoxharga.TextChanged += new System.EventHandler(this.textBoxharga_TextChanged);
            // 
            // textBoxnama
            // 
            this.textBoxnama.Location = new System.Drawing.Point(155, 71);
            this.textBoxnama.Name = "textBoxnama";
            this.textBoxnama.Size = new System.Drawing.Size(206, 23);
            this.textBoxnama.TabIndex = 12;
            this.textBoxnama.TextChanged += new System.EventHandler(this.textBoxnama_TextChanged);
            // 
            // buttonpicture
            // 
            this.buttonpicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(198)))), ((int)(((byte)(231)))));
            this.buttonpicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonpicture.FlatAppearance.BorderSize = 0;
            this.buttonpicture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonpicture.ForeColor = System.Drawing.Color.White;
            this.buttonpicture.Location = new System.Drawing.Point(16, 204);
            this.buttonpicture.Name = "buttonpicture";
            this.buttonpicture.Size = new System.Drawing.Size(122, 31);
            this.buttonpicture.TabIndex = 1;
            this.buttonpicture.Text = "Cari";
            this.buttonpicture.UseVisualStyleBackColor = false;
            this.buttonpicture.Click += new System.EventHandler(this.buttonpicture_Click);
            // 
            // picturebx
            // 
            this.picturebx.BackColor = System.Drawing.Color.White;
            this.picturebx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picturebx.Location = new System.Drawing.Point(16, 17);
            this.picturebx.Name = "picturebx";
            this.picturebx.Size = new System.Drawing.Size(122, 168);
            this.picturebx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturebx.TabIndex = 0;
            this.picturebx.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("DeVinne Txt BT", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(273, 6);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(264, 56);
            this.label11.TabIndex = 21;
            this.label11.Text = "Novel Store";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 565);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_novel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturebx)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonpicture;
        private System.Windows.Forms.PictureBox picturebx;
        private System.Windows.Forms.TextBox searchlabel;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.DataGridView datagrid_novel;
        private System.Windows.Forms.TextBox textBoxjumlah;
        private System.Windows.Forms.TextBox textBoxharga;
        private System.Windows.Forms.TextBox textBoxnama;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxedjumlah;
        private System.Windows.Forms.TextBox textBoxedharga;
        private System.Windows.Forms.TextBox textBoxednama;
        private System.Windows.Forms.TextBox textBoxedkode;
        private System.Windows.Forms.Label label11;
    }
}

