﻿namespace PCPOS.Robno
{
    partial class frmSveOdjave_komisione
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.btnUrediSifru = new System.Windows.Forms.Button();
            this.btnSveFakture = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.chbDO = new System.Windows.Forms.CheckBox();
            this.chbArtikl = new System.Windows.Forms.CheckBox();
            this.chbSifra = new System.Windows.Forms.CheckBox();
            this.chbOD = new System.Windows.Forms.CheckBox();
            this.chbIzradio = new System.Windows.Forms.CheckBox();
            this.chbBroj = new System.Windows.Forms.CheckBox();
            this.cbArtikl = new System.Windows.Forms.TextBox();
            this.txtPartner = new System.Windows.Forms.TextBox();
            this.cbIzradio = new System.Windows.Forms.ComboBox();
            this.dtpDO = new System.Windows.Forms.DateTimePicker();
            this.txtBroj = new System.Windows.Forms.TextBox();
            this.dtpOD = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.ch = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbIzradio = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.Image = global::PCPOS.Properties.Resources.Actions_application_exit_icon;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(862, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 40);
            this.button1.TabIndex = 29;
            this.button1.Text = "Izlaz      ";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnUrediSifru
            // 
            this.btnUrediSifru.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnUrediSifru.Image = global::PCPOS.Properties.Resources.edit_icon;
            this.btnUrediSifru.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUrediSifru.Location = new System.Drawing.Point(148, 12);
            this.btnUrediSifru.Name = "btnUrediSifru";
            this.btnUrediSifru.Size = new System.Drawing.Size(130, 40);
            this.btnUrediSifru.TabIndex = 28;
            this.btnUrediSifru.Text = "Uredi odjavu";
            this.btnUrediSifru.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUrediSifru.UseVisualStyleBackColor = true;
            this.btnUrediSifru.Click += new System.EventHandler(this.btnUrediSifru_Click);
            // 
            // btnSveFakture
            // 
            this.btnSveFakture.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSveFakture.Image = global::PCPOS.Properties.Resources.print_printer;
            this.btnSveFakture.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSveFakture.Location = new System.Drawing.Point(12, 12);
            this.btnSveFakture.Name = "btnSveFakture";
            this.btnSveFakture.Size = new System.Drawing.Size(130, 40);
            this.btnSveFakture.TabIndex = 27;
            this.btnSveFakture.Text = "Ispis odjave";
            this.btnSveFakture.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSveFakture.UseVisualStyleBackColor = true;
            this.btnSveFakture.Click += new System.EventHandler(this.btnSveFakture_Click);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.BackgroundColor = System.Drawing.Color.White;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.GridColor = System.Drawing.Color.Gainsboro;
            this.dgv.Location = new System.Drawing.Point(12, 197);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dgv.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(979, 446);
            this.dgv.TabIndex = 26;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            this.dgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.chbDO);
            this.groupBox1.Controls.Add(this.chbArtikl);
            this.groupBox1.Controls.Add(this.chbSifra);
            this.groupBox1.Controls.Add(this.chbOD);
            this.groupBox1.Controls.Add(this.chbIzradio);
            this.groupBox1.Controls.Add(this.chbBroj);
            this.groupBox1.Controls.Add(this.cbArtikl);
            this.groupBox1.Controls.Add(this.txtPartner);
            this.groupBox1.Controls.Add(this.cbIzradio);
            this.groupBox1.Controls.Add(this.dtpDO);
            this.groupBox1.Controls.Add(this.txtBroj);
            this.groupBox1.Controls.Add(this.dtpOD);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ch);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lbIzradio);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(12, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(980, 120);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pretraživanje ponuda";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::PCPOS.Properties.Resources._1059;
            this.pictureBox2.Location = new System.Drawing.Point(274, 66);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(23, 22);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 49;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // chbDO
            // 
            this.chbDO.AutoSize = true;
            this.chbDO.Location = new System.Drawing.Point(550, 66);
            this.chbDO.Name = "chbDO";
            this.chbDO.Size = new System.Drawing.Size(15, 14);
            this.chbDO.TabIndex = 45;
            this.chbDO.UseVisualStyleBackColor = true;
            // 
            // chbArtikl
            // 
            this.chbArtikl.AutoSize = true;
            this.chbArtikl.Location = new System.Drawing.Point(831, 37);
            this.chbArtikl.Name = "chbArtikl";
            this.chbArtikl.Size = new System.Drawing.Size(15, 14);
            this.chbArtikl.TabIndex = 44;
            this.chbArtikl.UseVisualStyleBackColor = true;
            // 
            // chbSifra
            // 
            this.chbSifra.AutoSize = true;
            this.chbSifra.Location = new System.Drawing.Point(275, 100);
            this.chbSifra.Name = "chbSifra";
            this.chbSifra.Size = new System.Drawing.Size(15, 14);
            this.chbSifra.TabIndex = 44;
            this.chbSifra.UseVisualStyleBackColor = true;
            this.chbSifra.Visible = false;
            // 
            // chbOD
            // 
            this.chbOD.AutoSize = true;
            this.chbOD.Location = new System.Drawing.Point(550, 40);
            this.chbOD.Name = "chbOD";
            this.chbOD.Size = new System.Drawing.Size(15, 14);
            this.chbOD.TabIndex = 48;
            this.chbOD.UseVisualStyleBackColor = true;
            // 
            // chbIzradio
            // 
            this.chbIzradio.AutoSize = true;
            this.chbIzradio.Location = new System.Drawing.Point(831, 61);
            this.chbIzradio.Name = "chbIzradio";
            this.chbIzradio.Size = new System.Drawing.Size(15, 14);
            this.chbIzradio.TabIndex = 47;
            this.chbIzradio.UseVisualStyleBackColor = true;
            // 
            // chbBroj
            // 
            this.chbBroj.AutoSize = true;
            this.chbBroj.Location = new System.Drawing.Point(275, 44);
            this.chbBroj.Name = "chbBroj";
            this.chbBroj.Size = new System.Drawing.Size(15, 14);
            this.chbBroj.TabIndex = 46;
            this.chbBroj.UseVisualStyleBackColor = true;
            // 
            // cbArtikl
            // 
            this.cbArtikl.Location = new System.Drawing.Point(660, 34);
            this.cbArtikl.Name = "cbArtikl";
            this.cbArtikl.Size = new System.Drawing.Size(168, 23);
            this.cbArtikl.TabIndex = 31;
            // 
            // txtPartner
            // 
            this.txtPartner.Location = new System.Drawing.Point(114, 65);
            this.txtPartner.Name = "txtPartner";
            this.txtPartner.Size = new System.Drawing.Size(158, 23);
            this.txtPartner.TabIndex = 31;
            this.txtPartner.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPartner_KeyDown);
            // 
            // cbIzradio
            // 
            this.cbIzradio.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbIzradio.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbIzradio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIzradio.FormattingEnabled = true;
            this.cbIzradio.Location = new System.Drawing.Point(660, 59);
            this.cbIzradio.Name = "cbIzradio";
            this.cbIzradio.Size = new System.Drawing.Size(168, 24);
            this.cbIzradio.TabIndex = 42;
            // 
            // dtpDO
            // 
            this.dtpDO.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDO.Location = new System.Drawing.Point(388, 63);
            this.dtpDO.Name = "dtpDO";
            this.dtpDO.Size = new System.Drawing.Size(159, 23);
            this.dtpDO.TabIndex = 40;
            // 
            // txtBroj
            // 
            this.txtBroj.Location = new System.Drawing.Point(114, 40);
            this.txtBroj.Name = "txtBroj";
            this.txtBroj.Size = new System.Drawing.Size(158, 23);
            this.txtBroj.TabIndex = 32;
            // 
            // dtpOD
            // 
            this.dtpOD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpOD.Location = new System.Drawing.Point(388, 37);
            this.dtpOD.Name = "dtpOD";
            this.dtpOD.Size = new System.Drawing.Size(159, 23);
            this.dtpOD.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 33;
            this.label1.Text = "Broj odjave:";
            // 
            // ch
            // 
            this.ch.AutoSize = true;
            this.ch.Location = new System.Drawing.Point(575, 40);
            this.ch.Name = "ch";
            this.ch.Size = new System.Drawing.Size(83, 17);
            this.ch.TabIndex = 37;
            this.ch.Text = "Šifra artikla:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(303, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 17);
            this.label4.TabIndex = 38;
            this.label4.Text = "Do datuma:";
            // 
            // lbIzradio
            // 
            this.lbIzradio.AutoSize = true;
            this.lbIzradio.Location = new System.Drawing.Point(575, 66);
            this.lbIzradio.Name = "lbIzradio";
            this.lbIzradio.Size = new System.Drawing.Size(81, 17);
            this.lbIzradio.TabIndex = 36;
            this.lbIzradio.Text = "Izradio zap:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 37;
            this.label2.Text = "Šifra partnera:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(303, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 34;
            this.label3.Text = "Od datuma:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::PCPOS.Properties.Resources._1059;
            this.pictureBox1.Location = new System.Drawing.Point(860, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pic_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pic_MouseLeave);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.AliceBlue;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.GridColor = System.Drawing.Color.Gainsboro;
            this.dataGridView1.Location = new System.Drawing.Point(13, 644);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(979, 181);
            this.dataGridView1.TabIndex = 39;
            this.dataGridView1.Visible = false;
            // 
            // frmSveOdjave_komisione
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(1004, 837);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnUrediSifru);
            this.Controls.Add(this.btnSveFakture);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmSveOdjave_komisione";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sve odjave komisione robe";
            this.Load += new System.EventHandler(this.frmSveOdjave_komisione_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnUrediSifru;
        private System.Windows.Forms.Button btnSveFakture;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chbDO;
        private System.Windows.Forms.CheckBox chbArtikl;
        private System.Windows.Forms.CheckBox chbSifra;
        private System.Windows.Forms.CheckBox chbOD;
        private System.Windows.Forms.CheckBox chbIzradio;
        private System.Windows.Forms.CheckBox chbBroj;
        public System.Windows.Forms.TextBox cbArtikl;
        public System.Windows.Forms.TextBox txtPartner;
        private System.Windows.Forms.ComboBox cbIzradio;
        private System.Windows.Forms.DateTimePicker dtpDO;
        public System.Windows.Forms.TextBox txtBroj;
        private System.Windows.Forms.DateTimePicker dtpOD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbIzradio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}