namespace WindowsFormsApp24
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
            this.cboxhome = new System.Windows.Forms.ComboBox();
            this.cboxaway = new System.Windows.Forms.ComboBox();
            this.lblmanager1 = new System.Windows.Forms.Label();
            this.lblmanager2 = new System.Windows.Forms.Label();
            this.lblcaptain1 = new System.Windows.Forms.Label();
            this.lblcaptain2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblstadium = new System.Windows.Forms.Label();
            this.lblcapacity = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cboxhome
            // 
            this.cboxhome.FormattingEnabled = true;
            this.cboxhome.Location = new System.Drawing.Point(41, 39);
            this.cboxhome.Name = "cboxhome";
            this.cboxhome.Size = new System.Drawing.Size(121, 28);
            this.cboxhome.TabIndex = 0;
            this.cboxhome.SelectedIndexChanged += new System.EventHandler(this.cboxhome_SelectedIndexChanged);
            // 
            // cboxaway
            // 
            this.cboxaway.FormattingEnabled = true;
            this.cboxaway.Location = new System.Drawing.Point(395, 39);
            this.cboxaway.Name = "cboxaway";
            this.cboxaway.Size = new System.Drawing.Size(121, 28);
            this.cboxaway.TabIndex = 1;
            this.cboxaway.SelectedIndexChanged += new System.EventHandler(this.cboxaway_SelectedIndexChanged);
            // 
            // lblmanager1
            // 
            this.lblmanager1.AutoSize = true;
            this.lblmanager1.Location = new System.Drawing.Point(37, 86);
            this.lblmanager1.Name = "lblmanager1";
            this.lblmanager1.Size = new System.Drawing.Size(76, 20);
            this.lblmanager1.TabIndex = 2;
            this.lblmanager1.Text = "Manager:";
            // 
            // lblmanager2
            // 
            this.lblmanager2.AutoSize = true;
            this.lblmanager2.Location = new System.Drawing.Point(391, 86);
            this.lblmanager2.Name = "lblmanager2";
            this.lblmanager2.Size = new System.Drawing.Size(76, 20);
            this.lblmanager2.TabIndex = 3;
            this.lblmanager2.Text = "Manager:";
            // 
            // lblcaptain1
            // 
            this.lblcaptain1.AutoSize = true;
            this.lblcaptain1.Location = new System.Drawing.Point(37, 138);
            this.lblcaptain1.Name = "lblcaptain1";
            this.lblcaptain1.Size = new System.Drawing.Size(68, 20);
            this.lblcaptain1.TabIndex = 4;
            this.lblcaptain1.Text = "Captain:";
            // 
            // lblcaptain2
            // 
            this.lblcaptain2.AutoSize = true;
            this.lblcaptain2.Location = new System.Drawing.Point(391, 138);
            this.lblcaptain2.Name = "lblcaptain2";
            this.lblcaptain2.Size = new System.Drawing.Size(68, 20);
            this.lblcaptain2.TabIndex = 5;
            this.lblcaptain2.Text = "Captain:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(256, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "label5";
            // 
            // lblstadium
            // 
            this.lblstadium.AutoSize = true;
            this.lblstadium.Location = new System.Drawing.Point(238, 197);
            this.lblstadium.Name = "lblstadium";
            this.lblstadium.Size = new System.Drawing.Size(69, 20);
            this.lblstadium.TabIndex = 7;
            this.lblstadium.Text = "stadium:";
            // 
            // lblcapacity
            // 
            this.lblcapacity.AutoSize = true;
            this.lblcapacity.Location = new System.Drawing.Point(236, 235);
            this.lblcapacity.Name = "lblcapacity";
            this.lblcapacity.Size = new System.Drawing.Size(71, 20);
            this.lblcapacity.TabIndex = 8;
            this.lblcapacity.Text = "capacity:";
            this.lblcapacity.Click += new System.EventHandler(this.lblcapacity_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(232, 278);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 39);
            this.button1.TabIndex = 9;
            this.button1.Text = "CHECK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(238, 368);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Skor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 330);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Tanggal:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 391);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(798, 350);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 734);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblcapacity);
            this.Controls.Add(this.lblstadium);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblcaptain2);
            this.Controls.Add(this.lblcaptain1);
            this.Controls.Add(this.lblmanager2);
            this.Controls.Add(this.lblmanager1);
            this.Controls.Add(this.cboxaway);
            this.Controls.Add(this.cboxhome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboxhome;
        private System.Windows.Forms.ComboBox cboxaway;
        private System.Windows.Forms.Label lblmanager1;
        private System.Windows.Forms.Label lblmanager2;
        private System.Windows.Forms.Label lblcaptain1;
        private System.Windows.Forms.Label lblcaptain2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblstadium;
        private System.Windows.Forms.Label lblcapacity;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

