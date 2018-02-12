namespace Lab.PL
{
    partial class result
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(result));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmb_groups = new System.Windows.Forms.ComboBox();
            this.btn_preview = new System.Windows.Forms.Button();
            this.btn_print = new System.Windows.Forms.Button();
            this.dt_result = new System.Windows.Forms.DataGridView();
            this.group_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.analysis_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.normal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.result_test = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender_txt = new System.Windows.Forms.TextBox();
            this.age_txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.doctor_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_patient = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dt_patient = new System.Windows.Forms.DataGridView();
            this.reservation_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patient_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_txt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.con_txt = new System.Windows.Forms.TextBox();
            this.id_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.other = new System.Windows.Forms.RichTextBox();
            this.comment = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_result)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_patient)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comment);
            this.groupBox1.Controls.Add(this.other);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cmb_groups);
            this.groupBox1.Controls.Add(this.btn_preview);
            this.groupBox1.Controls.Add(this.btn_print);
            this.groupBox1.Controls.Add(this.dt_result);
            this.groupBox1.Controls.Add(this.gender_txt);
            this.groupBox1.Controls.Add(this.age_txt);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.doctor_txt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmb_patient);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dt_patient);
            this.groupBox1.Controls.Add(this.date_txt);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.con_txt);
            this.groupBox1.Controls.Add(this.id_txt);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(837, 361);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Results";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(136, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 47;
            this.label7.Text = "groups:";
            // 
            // cmb_groups
            // 
            this.cmb_groups.FormattingEnabled = true;
            this.cmb_groups.Location = new System.Drawing.Point(197, 87);
            this.cmb_groups.Name = "cmb_groups";
            this.cmb_groups.Size = new System.Drawing.Size(121, 21);
            this.cmb_groups.TabIndex = 46;
            this.cmb_groups.SelectedValueChanged += new System.EventHandler(this.cmb_groups_SelectedValueChanged);
            // 
            // btn_preview
            // 
            this.btn_preview.Location = new System.Drawing.Point(232, 316);
            this.btn_preview.Name = "btn_preview";
            this.btn_preview.Size = new System.Drawing.Size(75, 23);
            this.btn_preview.TabIndex = 45;
            this.btn_preview.Text = "preview";
            this.btn_preview.UseVisualStyleBackColor = true;
            this.btn_preview.Click += new System.EventHandler(this.btn_preview_Click);
            // 
            // btn_print
            // 
            this.btn_print.Location = new System.Drawing.Point(116, 316);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(75, 23);
            this.btn_print.TabIndex = 44;
            this.btn_print.Text = "print";
            this.btn_print.UseVisualStyleBackColor = true;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // dt_result
            // 
            this.dt_result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_result.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.group_name,
            this.analysis_name,
            this.normal,
            this.result_test,
            this.unit});
            this.dt_result.Location = new System.Drawing.Point(17, 114);
            this.dt_result.Name = "dt_result";
            this.dt_result.Size = new System.Drawing.Size(535, 196);
            this.dt_result.TabIndex = 43;
            // 
            // group_name
            // 
            this.group_name.HeaderText = "group_name";
            this.group_name.Name = "group_name";
            // 
            // analysis_name
            // 
            this.analysis_name.HeaderText = "analysis_name";
            this.analysis_name.Name = "analysis_name";
            // 
            // normal
            // 
            this.normal.HeaderText = "normal";
            this.normal.Name = "normal";
            // 
            // result_test
            // 
            this.result_test.HeaderText = "result_test";
            this.result_test.Name = "result_test";
            // 
            // unit
            // 
            this.unit.HeaderText = "unit";
            this.unit.Name = "unit";
            // 
            // gender_txt
            // 
            this.gender_txt.Location = new System.Drawing.Point(275, 47);
            this.gender_txt.Name = "gender_txt";
            this.gender_txt.ReadOnly = true;
            this.gender_txt.Size = new System.Drawing.Size(121, 20);
            this.gender_txt.TabIndex = 42;
            // 
            // age_txt
            // 
            this.age_txt.Location = new System.Drawing.Point(431, 47);
            this.age_txt.Name = "age_txt";
            this.age_txt.ReadOnly = true;
            this.age_txt.Size = new System.Drawing.Size(121, 20);
            this.age_txt.TabIndex = 41;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(224, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 40;
            this.label6.Text = "gender:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(396, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "age:";
            // 
            // doctor_txt
            // 
            this.doctor_txt.Location = new System.Drawing.Point(92, 50);
            this.doctor_txt.Name = "doctor_txt";
            this.doctor_txt.ReadOnly = true;
            this.doctor_txt.Size = new System.Drawing.Size(121, 20);
            this.doctor_txt.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Doctor_Name:";
            // 
            // cmb_patient
            // 
            this.cmb_patient.FormattingEnabled = true;
            this.cmb_patient.Location = new System.Drawing.Point(632, 12);
            this.cmb_patient.Name = "cmb_patient";
            this.cmb_patient.Size = new System.Drawing.Size(189, 21);
            this.cmb_patient.TabIndex = 36;
            this.cmb_patient.SelectedValueChanged += new System.EventHandler(this.cmb_patient_SelectedValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(588, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Name:";
            // 
            // dt_patient
            // 
            this.dt_patient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_patient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.reservation_id,
            this.patient_Name});
            this.dt_patient.Location = new System.Drawing.Point(581, 39);
            this.dt_patient.Name = "dt_patient";
            this.dt_patient.Size = new System.Drawing.Size(246, 271);
            this.dt_patient.TabIndex = 1;
            this.dt_patient.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dt_patient_CellClick);
            // 
            // reservation_id
            // 
            this.reservation_id.HeaderText = "reservation_id";
            this.reservation_id.Name = "reservation_id";
            // 
            // patient_Name
            // 
            this.patient_Name.HeaderText = "patient_Name";
            this.patient_Name.Name = "patient_Name";
            // 
            // date_txt
            // 
            this.date_txt.Location = new System.Drawing.Point(197, 13);
            this.date_txt.Name = "date_txt";
            this.date_txt.ReadOnly = true;
            this.date_txt.Size = new System.Drawing.Size(121, 20);
            this.date_txt.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(157, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "Date:";
            // 
            // con_txt
            // 
            this.con_txt.Location = new System.Drawing.Point(399, 13);
            this.con_txt.Name = "con_txt";
            this.con_txt.ReadOnly = true;
            this.con_txt.Size = new System.Drawing.Size(121, 20);
            this.con_txt.TabIndex = 31;
            // 
            // id_txt
            // 
            this.id_txt.Location = new System.Drawing.Point(92, 13);
            this.id_txt.Name = "id_txt";
            this.id_txt.ReadOnly = true;
            this.id_txt.Size = new System.Drawing.Size(50, 20);
            this.id_txt.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(333, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Contractor:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "reservation_id:";
            // 
            // printDialog1
            // 
            this.printDialog1.Document = this.printDocument1;
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // other
            // 
            this.other.Location = new System.Drawing.Point(632, 231);
            this.other.Name = "other";
            this.other.Size = new System.Drawing.Size(100, 96);
            this.other.TabIndex = 48;
            this.other.Text = "";
            // 
            // comment
            // 
            this.comment.Location = new System.Drawing.Point(632, 87);
            this.comment.Name = "comment";
            this.comment.Size = new System.Drawing.Size(100, 96);
            this.comment.TabIndex = 49;
            this.comment.Text = "";
            // 
            // result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(851, 385);
            this.Controls.Add(this.groupBox1);
            this.Name = "result";
            this.Text = "result";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_result)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_patient)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox date_txt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox con_txt;
        private System.Windows.Forms.TextBox id_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dt_patient;
        private System.Windows.Forms.TextBox gender_txt;
        private System.Windows.Forms.TextBox age_txt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox doctor_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_patient;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_preview;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.DataGridView dt_result;
        private System.Windows.Forms.DataGridViewTextBoxColumn group_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn analysis_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn normal;
        private System.Windows.Forms.DataGridViewTextBoxColumn result_test;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn reservation_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn patient_Name;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmb_groups;
        private System.Windows.Forms.RichTextBox comment;
        private System.Windows.Forms.RichTextBox other;
    }
}