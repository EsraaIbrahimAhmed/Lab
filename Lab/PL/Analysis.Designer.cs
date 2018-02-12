namespace Lab.PL
{
    partial class Analysis
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
            this.analysis_list_box = new System.Windows.Forms.ListBox();
            this.time_txt = new System.Windows.Forms.TextBox();
            this.result_txt = new System.Windows.Forms.TextBox();
            this.notes_txt = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.how_txt = new System.Windows.Forms.TextBox();
            this.price_txt = new System.Windows.Forms.TextBox();
            this.analysis_id_txt = new System.Windows.Forms.TextBox();
            this.cmb_name_en = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.analysis_list_box);
            this.groupBox1.Controls.Add(this.time_txt);
            this.groupBox1.Controls.Add(this.result_txt);
            this.groupBox1.Controls.Add(this.notes_txt);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.how_txt);
            this.groupBox1.Controls.Add(this.price_txt);
            this.groupBox1.Controls.Add(this.analysis_id_txt);
            this.groupBox1.Controls.Add(this.cmb_name_en);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 14F);
            this.groupBox1.Location = new System.Drawing.Point(22, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(495, 413);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بيانات التحاليل المنفصلة:";
            // 
            // analysis_list_box
            // 
            this.analysis_list_box.FormattingEnabled = true;
            this.analysis_list_box.ItemHeight = 23;
            this.analysis_list_box.Location = new System.Drawing.Point(7, 17);
            this.analysis_list_box.Name = "analysis_list_box";
            this.analysis_list_box.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.analysis_list_box.Size = new System.Drawing.Size(141, 73);
            this.analysis_list_box.TabIndex = 17;
            this.analysis_list_box.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // time_txt
            // 
            this.time_txt.Location = new System.Drawing.Point(253, 258);
            this.time_txt.Multiline = true;
            this.time_txt.Name = "time_txt";
            this.time_txt.Size = new System.Drawing.Size(99, 30);
            this.time_txt.TabIndex = 16;
            // 
            // result_txt
            // 
            this.result_txt.Location = new System.Drawing.Point(251, 308);
            this.result_txt.Multiline = true;
            this.result_txt.Name = "result_txt";
            this.result_txt.Size = new System.Drawing.Size(99, 30);
            this.result_txt.TabIndex = 15;
            // 
            // notes_txt
            // 
            this.notes_txt.Location = new System.Drawing.Point(45, 353);
            this.notes_txt.Multiline = true;
            this.notes_txt.Name = "notes_txt";
            this.notes_txt.Size = new System.Drawing.Size(315, 30);
            this.notes_txt.TabIndex = 14;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(394, 356);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 23);
            this.label12.TabIndex = 12;
            this.label12.Text = "ملاحظات:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(356, 311);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(124, 23);
            this.label11.TabIndex = 11;
            this.label11.Text = "نتيجة التحليل:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(358, 265);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 23);
            this.label10.TabIndex = 10;
            this.label10.Text = "وقت التحليل:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(374, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 23);
            this.label3.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(322, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 23);
            this.label8.TabIndex = 5;
            this.label8.Text = "اسم التحليل en :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(154, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 23);
            this.label7.TabIndex = 3;
            this.label7.Text = "اسم المجموعة:";
            // 
            // how_txt
            // 
            this.how_txt.Location = new System.Drawing.Point(45, 215);
            this.how_txt.Multiline = true;
            this.how_txt.Name = "how_txt";
            this.how_txt.Size = new System.Drawing.Size(315, 30);
            this.how_txt.TabIndex = 2;
            // 
            // price_txt
            // 
            this.price_txt.Location = new System.Drawing.Point(155, 157);
            this.price_txt.Name = "price_txt";
            this.price_txt.Size = new System.Drawing.Size(195, 30);
            this.price_txt.TabIndex = 2;
            this.price_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.price_txt_KeyPress);
            // 
            // analysis_id_txt
            // 
            this.analysis_id_txt.Location = new System.Drawing.Point(297, 47);
            this.analysis_id_txt.Name = "analysis_id_txt";
            this.analysis_id_txt.ReadOnly = true;
            this.analysis_id_txt.Size = new System.Drawing.Size(63, 30);
            this.analysis_id_txt.TabIndex = 2;
            // 
            // cmb_name_en
            // 
            this.cmb_name_en.FormattingEnabled = true;
            this.cmb_name_en.Location = new System.Drawing.Point(7, 95);
            this.cmb_name_en.Name = "cmb_name_en";
            this.cmb_name_en.Size = new System.Drawing.Size(315, 31);
            this.cmb_name_en.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(356, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "كيفية التحليل:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(356, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "سعر التحليل:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(366, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "كود التحليل:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_exit);
            this.groupBox2.Controls.Add(this.btn_delete);
            this.groupBox2.Controls.Add(this.btn_update);
            this.groupBox2.Controls.Add(this.btn_add);
            this.groupBox2.Controls.Add(this.btn_search);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 14F);
            this.groupBox2.Location = new System.Drawing.Point(558, 221);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(200, 468);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // btn_exit
            // 
            this.btn_exit.BackgroundImage = global::Lab.Properties.Resources.exitbtn;
            this.btn_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_exit.Location = new System.Drawing.Point(46, 387);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(93, 64);
            this.btn_exit.TabIndex = 0;
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackgroundImage = global::Lab.Properties.Resources.th;
            this.btn_delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_delete.Location = new System.Drawing.Point(46, 296);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(93, 64);
            this.btn_delete.TabIndex = 0;
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackgroundImage = global::Lab.Properties.Resources.images__2_;
            this.btn_update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_update.Location = new System.Drawing.Point(46, 215);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(93, 64);
            this.btn_update.TabIndex = 0;
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackgroundImage = global::Lab.Properties.Resources.add_button_icon_16545;
            this.btn_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_add.Location = new System.Drawing.Point(46, 123);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(93, 64);
            this.btn_add.TabIndex = 0;
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_search
            // 
            this.btn_search.BackgroundImage = global::Lab.Properties.Resources.Button_15_128;
            this.btn_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_search.Location = new System.Drawing.Point(46, 36);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(93, 64);
            this.btn_search.TabIndex = 0;
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // Analysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(780, 701);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Analysis";
            this.Text = "Analysis";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox how_txt;
        private System.Windows.Forms.TextBox price_txt;
        private System.Windows.Forms.TextBox analysis_id_txt;
        private System.Windows.Forms.ComboBox cmb_name_en;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox time_txt;
        private System.Windows.Forms.TextBox result_txt;
        private System.Windows.Forms.TextBox notes_txt;
        private System.Windows.Forms.ListBox analysis_list_box;
    }
}