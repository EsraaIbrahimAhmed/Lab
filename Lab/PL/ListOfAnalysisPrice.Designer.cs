namespace Lab.PL
{
    partial class ListOfAnalysisPrice
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_exit = new System.Windows.Forms.Button();
            this.ContractorDis = new System.Windows.Forms.LinkLabel();
            this.DoctorDis = new System.Windows.Forms.LinkLabel();
            this.ELabDis = new System.Windows.Forms.LinkLabel();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 14F);
            this.groupBox2.Location = new System.Drawing.Point(27, 110);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(789, 340);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(6, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(777, 314);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "name_en";
            this.Column1.HeaderText = "اسم التحليل";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "analysis_price";
            this.Column2.HeaderText = "السعر قبل الخصم";
            this.Column2.Name = "Column2";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_exit);
            this.groupBox1.Controls.Add(this.ContractorDis);
            this.groupBox1.Controls.Add(this.DoctorDis);
            this.groupBox1.Controls.Add(this.ELabDis);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 14F);
            this.groupBox1.Location = new System.Drawing.Point(27, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(789, 84);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // btn_exit
            // 
            this.btn_exit.BackgroundImage = global::Lab.Properties.Resources.exitbtn;
            this.btn_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_exit.Location = new System.Drawing.Point(6, 15);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(93, 64);
            this.btn_exit.TabIndex = 1;
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // ContractorDis
            // 
            this.ContractorDis.AutoSize = true;
            this.ContractorDis.LinkColor = System.Drawing.Color.Black;
            this.ContractorDis.Location = new System.Drawing.Point(163, 36);
            this.ContractorDis.Name = "ContractorDis";
            this.ContractorDis.Size = new System.Drawing.Size(153, 23);
            this.ContractorDis.TabIndex = 0;
            this.ContractorDis.TabStop = true;
            this.ContractorDis.Text = "خصومات التعاقدات";
            this.ContractorDis.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ContractorDis_LinkClicked);
            // 
            // DoctorDis
            // 
            this.DoctorDis.AutoSize = true;
            this.DoctorDis.LinkColor = System.Drawing.Color.Black;
            this.DoctorDis.Location = new System.Drawing.Point(638, 36);
            this.DoctorDis.Name = "DoctorDis";
            this.DoctorDis.Size = new System.Drawing.Size(133, 23);
            this.DoctorDis.TabIndex = 0;
            this.DoctorDis.TabStop = true;
            this.DoctorDis.Text = "خصومات الأطباء";
            this.DoctorDis.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.DoctorDis_LinkClicked);
            // 
            // ELabDis
            // 
            this.ELabDis.AutoSize = true;
            this.ELabDis.LinkColor = System.Drawing.Color.Black;
            this.ELabDis.Location = new System.Drawing.Point(372, 36);
            this.ELabDis.Name = "ELabDis";
            this.ELabDis.Size = new System.Drawing.Size(217, 23);
            this.ELabDis.TabIndex = 0;
            this.ELabDis.TabStop = true;
            this.ELabDis.Text = "خصومات المعامل الخارجية";
            this.ELabDis.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ELabDis_LinkClicked);
            // 
            // ListOfAnalysisPrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(843, 470);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ListOfAnalysisPrice";
            this.Text = "ListOfAnalysisPrice";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.LinkLabel ContractorDis;
        private System.Windows.Forms.LinkLabel DoctorDis;
        private System.Windows.Forms.LinkLabel ELabDis;
        private System.Windows.Forms.Button btn_exit;
    }
}