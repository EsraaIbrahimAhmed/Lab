namespace Lab.PL
{
    partial class Reservation
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmb_analysis = new System.Windows.Forms.ComboBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.doc_txt = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.con_txt = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.cmb_patient = new System.Windows.Forms.ComboBox();
            this.cmb_group = new System.Windows.Forms.ComboBox();
            this.btn_Calcu = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.group_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name_en = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.analysis_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rest_txt = new System.Windows.Forms.TextBox();
            this.total_txt = new System.Windows.Forms.TextBox();
            this.dis_txt = new System.Windows.Forms.TextBox();
            this.price_after_txt = new System.Windows.Forms.TextBox();
            this.paid_txt = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.p_id_txt = new System.Windows.Forms.TextBox();
            this.id_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmb_analysis);
            this.groupBox1.Controls.Add(this.btn_clear);
            this.groupBox1.Controls.Add(this.btn_add);
            this.groupBox1.Controls.Add(this.doc_txt);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.con_txt);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.cmb_patient);
            this.groupBox1.Controls.Add(this.cmb_group);
            this.groupBox1.Controls.Add(this.btn_Calcu);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.p_id_txt);
            this.groupBox1.Controls.Add(this.id_txt);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.groupBox1.Location = new System.Drawing.Point(11, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(899, 462);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بيانات الحجز";
            // 
            // cmb_analysis
            // 
            this.cmb_analysis.FormattingEnabled = true;
            this.cmb_analysis.Location = new System.Drawing.Point(330, 115);
            this.cmb_analysis.Name = "cmb_analysis";
            this.cmb_analysis.Size = new System.Drawing.Size(144, 27);
            this.cmb_analysis.TabIndex = 32;
            this.cmb_analysis.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_analysis_KeyPress);
            this.cmb_analysis.MouseEnter += new System.EventHandler(this.cmb_analysis_MouseEnter);
            // 
            // btn_clear
            // 
            this.btn_clear.BackgroundImage = global::Lab.Properties.Resources.unnamed;
            this.btn_clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_clear.Location = new System.Drawing.Point(134, 368);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(93, 62);
            this.btn_clear.TabIndex = 31;
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackgroundImage = global::Lab.Properties.Resources.add_button_icon_16545;
            this.btn_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_add.Location = new System.Drawing.Point(19, 368);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(93, 64);
            this.btn_add.TabIndex = 30;
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // doc_txt
            // 
            this.doc_txt.Location = new System.Drawing.Point(13, 104);
            this.doc_txt.Name = "doc_txt";
            this.doc_txt.Size = new System.Drawing.Size(121, 27);
            this.doc_txt.TabIndex = 29;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(148, 107);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(115, 19);
            this.label14.TabIndex = 28;
            this.label14.Text = "الطبيب المعالج:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(274, 44);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 27);
            this.dateTimePicker1.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(516, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 19);
            this.label8.TabIndex = 26;
            this.label8.Text = "تاريخ الحجز:";
            // 
            // con_txt
            // 
            this.con_txt.Location = new System.Drawing.Point(13, 73);
            this.con_txt.Name = "con_txt";
            this.con_txt.ReadOnly = true;
            this.con_txt.Size = new System.Drawing.Size(121, 27);
            this.con_txt.TabIndex = 25;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(57, 34);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(77, 33);
            this.button4.TabIndex = 24;
            this.button4.Text = "مريض جديد";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // cmb_patient
            // 
            this.cmb_patient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_patient.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmb_patient.FormattingEnabled = true;
            this.cmb_patient.Location = new System.Drawing.Point(641, 76);
            this.cmb_patient.Name = "cmb_patient";
            this.cmb_patient.Size = new System.Drawing.Size(121, 27);
            this.cmb_patient.TabIndex = 23;
            this.cmb_patient.SelectedValueChanged += new System.EventHandler(this.cmb_patient_SelectedValueChanged);
            // 
            // cmb_group
            // 
            this.cmb_group.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_group.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmb_group.FormattingEnabled = true;
            this.cmb_group.Location = new System.Drawing.Point(641, 110);
            this.cmb_group.Name = "cmb_group";
            this.cmb_group.Size = new System.Drawing.Size(121, 27);
            this.cmb_group.TabIndex = 22;
            this.cmb_group.SelectionChangeCommitted += new System.EventHandler(this.cmb_group_SelectionChangeCommitted);
            // 
            // btn_Calcu
            // 
            this.btn_Calcu.Location = new System.Drawing.Point(587, 426);
            this.btn_Calcu.Name = "btn_Calcu";
            this.btn_Calcu.Size = new System.Drawing.Size(84, 30);
            this.btn_Calcu.TabIndex = 18;
            this.btn_Calcu.Text = "احسب";
            this.btn_Calcu.UseVisualStyleBackColor = true;
            this.btn_Calcu.Click += new System.EventHandler(this.btn_Calcu_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.group_name,
            this.name_en,
            this.analysis_price});
            this.dataGridView1.Location = new System.Drawing.Point(311, 158);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(579, 258);
            this.dataGridView1.TabIndex = 0;
            // 
            // group_name
            // 
            this.group_name.HeaderText = "اسم المجموعة";
            this.group_name.Name = "group_name";
            // 
            // name_en
            // 
            this.name_en.HeaderText = "اسم التحليل";
            this.name_en.Name = "name_en";
            // 
            // analysis_price
            // 
            this.analysis_price.HeaderText = "سعر التحليل";
            this.analysis_price.Name = "analysis_price";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rest_txt);
            this.groupBox2.Controls.Add(this.total_txt);
            this.groupBox2.Controls.Add(this.dis_txt);
            this.groupBox2.Controls.Add(this.price_after_txt);
            this.groupBox2.Controls.Add(this.paid_txt);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(13, 131);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(257, 192);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            // 
            // rest_txt
            // 
            this.rest_txt.Location = new System.Drawing.Point(21, 140);
            this.rest_txt.Name = "rest_txt";
            this.rest_txt.ReadOnly = true;
            this.rest_txt.Size = new System.Drawing.Size(100, 27);
            this.rest_txt.TabIndex = 27;
            this.rest_txt.Click += new System.EventHandler(this.rest_txt_Click);
            // 
            // total_txt
            // 
            this.total_txt.Location = new System.Drawing.Point(21, 24);
            this.total_txt.Name = "total_txt";
            this.total_txt.ReadOnly = true;
            this.total_txt.Size = new System.Drawing.Size(100, 27);
            this.total_txt.TabIndex = 26;
            // 
            // dis_txt
            // 
            this.dis_txt.Location = new System.Drawing.Point(21, 54);
            this.dis_txt.Name = "dis_txt";
            this.dis_txt.ReadOnly = true;
            this.dis_txt.Size = new System.Drawing.Size(100, 27);
            this.dis_txt.TabIndex = 25;
            // 
            // price_after_txt
            // 
            this.price_after_txt.Location = new System.Drawing.Point(21, 83);
            this.price_after_txt.Name = "price_after_txt";
            this.price_after_txt.ReadOnly = true;
            this.price_after_txt.Size = new System.Drawing.Size(100, 27);
            this.price_after_txt.TabIndex = 24;
            // 
            // paid_txt
            // 
            this.paid_txt.Location = new System.Drawing.Point(21, 110);
            this.paid_txt.Name = "paid_txt";
            this.paid_txt.Size = new System.Drawing.Size(100, 27);
            this.paid_txt.TabIndex = 22;
            this.paid_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.paid_txt_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(160, 140);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 19);
            this.label13.TabIndex = 21;
            this.label13.Text = "المتبقي:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(162, 113);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 19);
            this.label12.TabIndex = 20;
            this.label12.Text = "المدفوع:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(121, 86);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(130, 19);
            this.label11.TabIndex = 19;
            this.label11.Text = "السعر بعد الخصم:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(168, 57);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 19);
            this.label10.TabIndex = 18;
            this.label10.Text = "الخصم:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(160, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 19);
            this.label9.TabIndex = 17;
            this.label9.Text = "الإجمالي:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(503, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 19);
            this.label7.TabIndex = 11;
            this.label7.Text = "اسم التحليل:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(768, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "اسم المجموعة:";
            // 
            // p_id_txt
            // 
            this.p_id_txt.Location = new System.Drawing.Point(353, 76);
            this.p_id_txt.Name = "p_id_txt";
            this.p_id_txt.ReadOnly = true;
            this.p_id_txt.Size = new System.Drawing.Size(121, 27);
            this.p_id_txt.TabIndex = 7;
            // 
            // id_txt
            // 
            this.id_txt.Location = new System.Drawing.Point(641, 43);
            this.id_txt.Name = "id_txt";
            this.id_txt.ReadOnly = true;
            this.id_txt.Size = new System.Drawing.Size(121, 27);
            this.id_txt.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(157, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "جهة التعاقد:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 19);
            this.label4.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(779, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "اسم المريض:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(513, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "كود المريض:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(799, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "كود الحجز:";
            // 
            // Reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(913, 500);
            this.Controls.Add(this.groupBox1);
            this.Name = "Reservation";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox total_txt;
        private System.Windows.Forms.TextBox dis_txt;
        private System.Windows.Forms.TextBox price_after_txt;
       // private System.Windows.Forms.TextBox rest;
        private System.Windows.Forms.TextBox paid_txt;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox p_id_txt;
        private System.Windows.Forms.TextBox id_txt;
        private System.Windows.Forms.Button btn_Calcu;
        private System.Windows.Forms.ComboBox cmb_group;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox con_txt;
        public System.Windows.Forms.ComboBox cmb_patient;
        private System.Windows.Forms.DataGridViewTextBoxColumn group_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_en;
        private System.Windows.Forms.DataGridViewTextBoxColumn analysis_price;
        private System.Windows.Forms.TextBox rest_txt;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox doc_txt;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.ComboBox cmb_analysis;
    }
}