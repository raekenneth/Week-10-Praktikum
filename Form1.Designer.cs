namespace PraktikumWeek8
{
    partial class FormHasilPertandingan
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
            this.comboBoxTim1 = new System.Windows.Forms.ComboBox();
            this.comboBoxTim2 = new System.Windows.Forms.ComboBox();
            this.labelManager1 = new System.Windows.Forms.Label();
            this.labelManager2 = new System.Windows.Forms.Label();
            this.labelCaptain2 = new System.Windows.Forms.Label();
            this.labelCaptain1 = new System.Windows.Forms.Label();
            this.labelVS = new System.Windows.Forms.Label();
            this.labelStadium = new System.Windows.Forms.Label();
            this.labelCapacity = new System.Windows.Forms.Label();
            this.labelTanggal = new System.Windows.Forms.Label();
            this.labelSkor = new System.Windows.Forms.Label();
            this.buttonCheck = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dgvPlayer = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxTim1
            // 
            this.comboBoxTim1.FormattingEnabled = true;
            this.comboBoxTim1.Location = new System.Drawing.Point(266, 11);
            this.comboBoxTim1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxTim1.Name = "comboBoxTim1";
            this.comboBoxTim1.Size = new System.Drawing.Size(92, 21);
            this.comboBoxTim1.TabIndex = 0;
            this.comboBoxTim1.SelectedIndexChanged += new System.EventHandler(this.comboBoxTim1_SelectedIndexChanged);
            // 
            // comboBoxTim2
            // 
            this.comboBoxTim2.FormattingEnabled = true;
            this.comboBoxTim2.Location = new System.Drawing.Point(513, 11);
            this.comboBoxTim2.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxTim2.Name = "comboBoxTim2";
            this.comboBoxTim2.Size = new System.Drawing.Size(92, 21);
            this.comboBoxTim2.TabIndex = 1;
            // 
            // labelManager1
            // 
            this.labelManager1.AutoSize = true;
            this.labelManager1.Location = new System.Drawing.Point(263, 66);
            this.labelManager1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelManager1.Name = "labelManager1";
            this.labelManager1.Size = new System.Drawing.Size(55, 13);
            this.labelManager1.TabIndex = 2;
            this.labelManager1.Text = "Manager :";
            // 
            // labelManager2
            // 
            this.labelManager2.AutoSize = true;
            this.labelManager2.Location = new System.Drawing.Point(511, 66);
            this.labelManager2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelManager2.Name = "labelManager2";
            this.labelManager2.Size = new System.Drawing.Size(55, 13);
            this.labelManager2.TabIndex = 3;
            this.labelManager2.Text = "Manager :";
            // 
            // labelCaptain2
            // 
            this.labelCaptain2.AutoSize = true;
            this.labelCaptain2.Location = new System.Drawing.Point(511, 97);
            this.labelCaptain2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCaptain2.Name = "labelCaptain2";
            this.labelCaptain2.Size = new System.Drawing.Size(49, 13);
            this.labelCaptain2.TabIndex = 4;
            this.labelCaptain2.Text = "Captain :";
            // 
            // labelCaptain1
            // 
            this.labelCaptain1.AutoSize = true;
            this.labelCaptain1.Location = new System.Drawing.Point(263, 97);
            this.labelCaptain1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCaptain1.Name = "labelCaptain1";
            this.labelCaptain1.Size = new System.Drawing.Size(49, 13);
            this.labelCaptain1.TabIndex = 5;
            this.labelCaptain1.Text = "Captain :";
            // 
            // labelVS
            // 
            this.labelVS.AutoSize = true;
            this.labelVS.Location = new System.Drawing.Point(426, 13);
            this.labelVS.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelVS.Name = "labelVS";
            this.labelVS.Size = new System.Drawing.Size(21, 13);
            this.labelVS.TabIndex = 6;
            this.labelVS.Text = "VS";
            // 
            // labelStadium
            // 
            this.labelStadium.AutoSize = true;
            this.labelStadium.Location = new System.Drawing.Point(381, 154);
            this.labelStadium.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStadium.Name = "labelStadium";
            this.labelStadium.Size = new System.Drawing.Size(51, 13);
            this.labelStadium.TabIndex = 7;
            this.labelStadium.Text = "Stadium :";
            // 
            // labelCapacity
            // 
            this.labelCapacity.AutoSize = true;
            this.labelCapacity.Location = new System.Drawing.Point(378, 181);
            this.labelCapacity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCapacity.Name = "labelCapacity";
            this.labelCapacity.Size = new System.Drawing.Size(54, 13);
            this.labelCapacity.TabIndex = 8;
            this.labelCapacity.Text = "Capacity :";
            // 
            // labelTanggal
            // 
            this.labelTanggal.AutoSize = true;
            this.labelTanggal.Location = new System.Drawing.Point(378, 249);
            this.labelTanggal.Name = "labelTanggal";
            this.labelTanggal.Size = new System.Drawing.Size(52, 13);
            this.labelTanggal.TabIndex = 9;
            this.labelTanggal.Text = "Tanggal :";
            // 
            // labelSkor
            // 
            this.labelSkor.AutoSize = true;
            this.labelSkor.Location = new System.Drawing.Point(381, 276);
            this.labelSkor.Name = "labelSkor";
            this.labelSkor.Size = new System.Drawing.Size(35, 13);
            this.labelSkor.TabIndex = 10;
            this.labelSkor.Text = "Skor :";
            // 
            // buttonCheck
            // 
            this.buttonCheck.Location = new System.Drawing.Point(429, 209);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(75, 23);
            this.buttonCheck.TabIndex = 11;
            this.buttonCheck.Text = "Check";
            this.buttonCheck.UseVisualStyleBackColor = true;
            this.buttonCheck.Click += new System.EventHandler(this.buttonCheck_Click);
            // 
            // dgvPlayer
            // 
            this.dgvPlayer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlayer.Location = new System.Drawing.Point(4, 307);
            this.dgvPlayer.Name = "dgvPlayer";
            this.dgvPlayer.Size = new System.Drawing.Size(864, 354);
            this.dgvPlayer.TabIndex = 12;
            // 
            // FormHasilPertandingan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 663);
            this.Controls.Add(this.dgvPlayer);
            this.Controls.Add(this.buttonCheck);
            this.Controls.Add(this.labelSkor);
            this.Controls.Add(this.labelTanggal);
            this.Controls.Add(this.labelCapacity);
            this.Controls.Add(this.labelStadium);
            this.Controls.Add(this.labelVS);
            this.Controls.Add(this.labelCaptain1);
            this.Controls.Add(this.labelCaptain2);
            this.Controls.Add(this.labelManager2);
            this.Controls.Add(this.labelManager1);
            this.Controls.Add(this.comboBoxTim2);
            this.Controls.Add(this.comboBoxTim1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormHasilPertandingan";
            this.Text = "Hasil Pertandingan";
            this.Load += new System.EventHandler(this.FormHasilPertandingan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxTim1;
        private System.Windows.Forms.ComboBox comboBoxTim2;
        private System.Windows.Forms.Label labelManager1;
        private System.Windows.Forms.Label labelManager2;
        private System.Windows.Forms.Label labelCaptain2;
        private System.Windows.Forms.Label labelCaptain1;
        private System.Windows.Forms.Label labelVS;
        private System.Windows.Forms.Label labelStadium;
        private System.Windows.Forms.Label labelCapacity;
        private System.Windows.Forms.Label labelTanggal;
