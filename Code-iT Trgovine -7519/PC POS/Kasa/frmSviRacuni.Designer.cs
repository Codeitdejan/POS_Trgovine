﻿namespace PCPOS.Kasa
{
    partial class frmSviRacuni
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSpremiExcelGrupiraj = new System.Windows.Forms.Button();
            this.btnSpremiExcel = new System.Windows.Forms.Button();
            this.chbNaplatni = new System.Windows.Forms.CheckBox();
            this.cbNaplatni = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.chbPoslovnica = new System.Windows.Forms.CheckBox();
            this.cbPoslovnica = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSveFakture = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnDodajPartneraNaRacun = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnSpremiExcelGrupiraj);
            this.groupBox1.Controls.Add(this.btnSpremiExcel);
            this.groupBox1.Controls.Add(this.chbNaplatni);
            this.groupBox1.Controls.Add(this.cbNaplatni);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.chbPoslovnica);
            this.groupBox1.Controls.Add(this.cbPoslovnica);
            this.groupBox1.Controls.Add(this.label5);
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
            this.groupBox1.Location = new System.Drawing.Point(13, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(979, 129);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pretraživanje fakture";
            // 
            // btnSpremiExcelGrupiraj
            // 
            this.btnSpremiExcelGrupiraj.Location = new System.Drawing.Point(808, 49);
            this.btnSpremiExcelGrupiraj.Name = "btnSpremiExcelGrupiraj";
            this.btnSpremiExcelGrupiraj.Size = new System.Drawing.Size(165, 65);
            this.btnSpremiExcelGrupiraj.TabIndex = 79;
            this.btnSpremiExcelGrupiraj.Text = "Spremi u excel grupirano po partnerima";
            this.btnSpremiExcelGrupiraj.UseVisualStyleBackColor = true;
            this.btnSpremiExcelGrupiraj.Click += new System.EventHandler(this.btnSpremiExcel_Click);
            // 
            // btnSpremiExcel
            // 
            this.btnSpremiExcel.Location = new System.Drawing.Point(808, 17);
            this.btnSpremiExcel.Name = "btnSpremiExcel";
            this.btnSpremiExcel.Size = new System.Drawing.Size(164, 27);
            this.btnSpremiExcel.TabIndex = 79;
            this.btnSpremiExcel.Text = "Spremi u excel";
            this.btnSpremiExcel.UseVisualStyleBackColor = true;
            this.btnSpremiExcel.Click += new System.EventHandler(this.btnSpremiExcel_Click);
            // 
            // chbNaplatni
            // 
            this.chbNaplatni.AutoSize = true;
            this.chbNaplatni.Enabled = false;
            this.chbNaplatni.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chbNaplatni.Location = new System.Drawing.Point(581, 106);
            this.chbNaplatni.Name = "chbNaplatni";
            this.chbNaplatni.Size = new System.Drawing.Size(15, 14);
            this.chbNaplatni.TabIndex = 78;
            this.chbNaplatni.UseVisualStyleBackColor = true;
            // 
            // cbNaplatni
            // 
            this.cbNaplatni.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbNaplatni.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbNaplatni.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNaplatni.Enabled = false;
            this.cbNaplatni.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbNaplatni.FormattingEnabled = true;
            this.cbNaplatni.Location = new System.Drawing.Point(410, 101);
            this.cbNaplatni.Name = "cbNaplatni";
            this.cbNaplatni.Size = new System.Drawing.Size(168, 24);
            this.cbNaplatni.TabIndex = 77;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(323, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 17);
            this.label6.TabIndex = 76;
            this.label6.Text = "Nap. uređaj:";
            // 
            // chbPoslovnica
            // 
            this.chbPoslovnica.AutoSize = true;
            this.chbPoslovnica.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chbPoslovnica.Location = new System.Drawing.Point(294, 107);
            this.chbPoslovnica.Name = "chbPoslovnica";
            this.chbPoslovnica.Size = new System.Drawing.Size(15, 14);
            this.chbPoslovnica.TabIndex = 75;
            this.chbPoslovnica.UseVisualStyleBackColor = true;
            this.chbPoslovnica.CheckedChanged += new System.EventHandler(this.chbPoslovnica_CheckedChanged);
            // 
            // cbPoslovnica
            // 
            this.cbPoslovnica.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbPoslovnica.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbPoslovnica.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPoslovnica.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbPoslovnica.FormattingEnabled = true;
            this.cbPoslovnica.Location = new System.Drawing.Point(123, 102);
            this.cbPoslovnica.Name = "cbPoslovnica";
            this.cbPoslovnica.Size = new System.Drawing.Size(168, 24);
            this.cbPoslovnica.TabIndex = 74;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(22, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 17);
            this.label5.TabIndex = 73;
            this.label5.Text = "Poslovnica:";
            // 
            // chbDO
            // 
            this.chbDO.AutoSize = true;
            this.chbDO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chbDO.Location = new System.Drawing.Point(581, 52);
            this.chbDO.Name = "chbDO";
            this.chbDO.Size = new System.Drawing.Size(15, 14);
            this.chbDO.TabIndex = 68;
            this.chbDO.UseVisualStyleBackColor = true;
            // 
            // chbArtikl
            // 
            this.chbArtikl.AutoSize = true;
            this.chbArtikl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chbArtikl.Location = new System.Drawing.Point(581, 78);
            this.chbArtikl.Name = "chbArtikl";
            this.chbArtikl.Size = new System.Drawing.Size(15, 14);
            this.chbArtikl.TabIndex = 66;
            this.chbArtikl.UseVisualStyleBackColor = true;
            // 
            // chbSifra
            // 
            this.chbSifra.AutoSize = true;
            this.chbSifra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chbSifra.Location = new System.Drawing.Point(294, 55);
            this.chbSifra.Name = "chbSifra";
            this.chbSifra.Size = new System.Drawing.Size(15, 14);
            this.chbSifra.TabIndex = 67;
            this.chbSifra.UseVisualStyleBackColor = true;
            // 
            // chbOD
            // 
            this.chbOD.AutoSize = true;
            this.chbOD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chbOD.Location = new System.Drawing.Point(581, 26);
            this.chbOD.Name = "chbOD";
            this.chbOD.Size = new System.Drawing.Size(15, 14);
            this.chbOD.TabIndex = 72;
            this.chbOD.UseVisualStyleBackColor = true;
            // 
            // chbIzradio
            // 
            this.chbIzradio.AutoSize = true;
            this.chbIzradio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chbIzradio.Location = new System.Drawing.Point(294, 81);
            this.chbIzradio.Name = "chbIzradio";
            this.chbIzradio.Size = new System.Drawing.Size(15, 14);
            this.chbIzradio.TabIndex = 70;
            this.chbIzradio.UseVisualStyleBackColor = true;
            // 
            // chbBroj
            // 
            this.chbBroj.AutoSize = true;
            this.chbBroj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chbBroj.Location = new System.Drawing.Point(294, 30);
            this.chbBroj.Name = "chbBroj";
            this.chbBroj.Size = new System.Drawing.Size(15, 14);
            this.chbBroj.TabIndex = 69;
            this.chbBroj.UseVisualStyleBackColor = true;
            // 
            // cbArtikl
            // 
            this.cbArtikl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbArtikl.Location = new System.Drawing.Point(410, 75);
            this.cbArtikl.Name = "cbArtikl";
            this.cbArtikl.Size = new System.Drawing.Size(168, 23);
            this.cbArtikl.TabIndex = 49;
            // 
            // txtPartner
            // 
            this.txtPartner.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPartner.Location = new System.Drawing.Point(123, 51);
            this.txtPartner.Name = "txtPartner";
            this.txtPartner.Size = new System.Drawing.Size(168, 23);
            this.txtPartner.TabIndex = 50;
            // 
            // cbIzradio
            // 
            this.cbIzradio.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbIzradio.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbIzradio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbIzradio.FormattingEnabled = true;
            this.cbIzradio.Location = new System.Drawing.Point(123, 76);
            this.cbIzradio.Name = "cbIzradio";
            this.cbIzradio.Size = new System.Drawing.Size(168, 24);
            this.cbIzradio.TabIndex = 63;
            // 
            // dtpDO
            // 
            this.dtpDO.CustomFormat = "dd.MM.yyyy HH:mm:ss";
            this.dtpDO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtpDO.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDO.Location = new System.Drawing.Point(410, 49);
            this.dtpDO.Name = "dtpDO";
            this.dtpDO.Size = new System.Drawing.Size(168, 23);
            this.dtpDO.TabIndex = 61;
            // 
            // txtBroj
            // 
            this.txtBroj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBroj.Location = new System.Drawing.Point(123, 26);
            this.txtBroj.Name = "txtBroj";
            this.txtBroj.Size = new System.Drawing.Size(168, 23);
            this.txtBroj.TabIndex = 51;
            // 
            // dtpOD
            // 
            this.dtpOD.CustomFormat = "dd.MM.yyyy HH:mm:ss";
            this.dtpOD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtpOD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpOD.Location = new System.Drawing.Point(410, 23);
            this.dtpOD.Name = "dtpOD";
            this.dtpOD.Size = new System.Drawing.Size(168, 23);
            this.dtpOD.TabIndex = 60;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(22, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 52;
            this.label1.Text = "Broj računa:";
            // 
            // ch
            // 
            this.ch.AutoSize = true;
            this.ch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ch.Location = new System.Drawing.Point(325, 78);
            this.ch.Name = "ch";
            this.ch.Size = new System.Drawing.Size(83, 17);
            this.ch.TabIndex = 58;
            this.ch.Text = "Šifra artikla:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(323, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 17);
            this.label4.TabIndex = 59;
            this.label4.Text = "Do datuma:";
            // 
            // lbIzradio
            // 
            this.lbIzradio.AutoSize = true;
            this.lbIzradio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbIzradio.Location = new System.Drawing.Point(22, 79);
            this.lbIzradio.Name = "lbIzradio";
            this.lbIzradio.Size = new System.Drawing.Size(81, 17);
            this.lbIzradio.TabIndex = 55;
            this.lbIzradio.Text = "Izradio zap:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(22, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 57;
            this.label2.Text = "Šifra partnera:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(323, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 53;
            this.label3.Text = "Od datuma:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::PCPOS.Properties.Resources._1059;
            this.pictureBox1.Location = new System.Drawing.Point(616, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pic_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pic_MouseLeave);
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
            this.dgv.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.GridColor = System.Drawing.Color.Gainsboro;
            this.dgv.Location = new System.Drawing.Point(13, 208);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(979, 342);
            this.dgv.TabIndex = 13;
            this.dgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellDoubleClick);
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
            this.button1.TabIndex = 26;
            this.button1.Text = "Izlaz      ";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSveFakture
            // 
            this.btnSveFakture.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSveFakture.Image = global::PCPOS.Properties.Resources.print_printer;
            this.btnSveFakture.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSveFakture.Location = new System.Drawing.Point(12, 12);
            this.btnSveFakture.Name = "btnSveFakture";
            this.btnSveFakture.Size = new System.Drawing.Size(167, 40);
            this.btnSveFakture.TabIndex = 25;
            this.btnSveFakture.Text = "Ispis računa na A4";
            this.btnSveFakture.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSveFakture.UseVisualStyleBackColor = true;
            this.btnSveFakture.Click += new System.EventHandler(this.btnSveFakture_Click);
            // 
            // btnDodajPartneraNaRacun
            // 
            this.btnDodajPartneraNaRacun.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDodajPartneraNaRacun.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDodajPartneraNaRacun.Location = new System.Drawing.Point(185, 12);
            this.btnDodajPartneraNaRacun.Name = "btnDodajPartneraNaRacun";
            this.btnDodajPartneraNaRacun.Size = new System.Drawing.Size(179, 40);
            this.btnDodajPartneraNaRacun.TabIndex = 27;
            this.btnDodajPartneraNaRacun.Text = "Dodaj partnera na račun";
            this.btnDodajPartneraNaRacun.UseVisualStyleBackColor = true;
            this.btnDodajPartneraNaRacun.Click += new System.EventHandler(this.btnDodajPartneraNaRacun_Click);
            // 
            // frmSviRacuni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(1004, 562);
            this.Controls.Add(this.btnDodajPartneraNaRacun);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSveFakture);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv);
            this.Name = "frmSviRacuni";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Svi računi";
            this.Load += new System.EventHandler(this.frmSviRacuni_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

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
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSveFakture;
        private System.Windows.Forms.CheckBox chbNaplatni;
        private System.Windows.Forms.ComboBox cbNaplatni;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chbPoslovnica;
        private System.Windows.Forms.ComboBox cbPoslovnica;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSpremiExcelGrupiraj;
        private System.Windows.Forms.Button btnSpremiExcel;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnDodajPartneraNaRacun;
    }
}