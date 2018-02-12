namespace Lab.PL
{
    partial class Patient
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
            this.cb_Pcontractor = new System.Windows.Forms.ComboBox();
            this.cb_Pstatus = new System.Windows.Forms.ComboBox();
            this.txt_Page = new System.Windows.Forms.TextBox();
            this.cb_Pyear = new System.Windows.Forms.ComboBox();
            this.cb_Pgender = new System.Windows.Forms.ComboBox();
            this.txt_pname = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_Paddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Pmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Pphone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Pcode = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.PB_LOGO = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_LOGO)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_Pcontractor);
            this.groupBox1.Controls.Add(this.cb_Pstatus);
            this.groupBox1.Controls.Add(this.txt_Page);
            this.groupBox1.Controls.Add(this.cb_Pyear);
            this.groupBox1.Controls.Add(this.cb_Pgender);
            this.groupBox1.Controls.Add(this.txt_pname);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txt_Paddress);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_Pmail);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_Pphone);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_Pcode);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 14F);
            this.groupBox1.Location = new System.Drawing.Point(423, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(498, 450);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بيانات المريض:";
            // 
            // cb_Pcontractor
            // 
            this.cb_Pcontractor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Pcontractor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb_Pcontractor.FormattingEnabled = true;
            this.cb_Pcontractor.Location = new System.Drawing.Point(15, 409);
            this.cb_Pcontractor.Name = "cb_Pcontractor";
            this.cb_Pcontractor.Size = new System.Drawing.Size(288, 31);
            this.cb_Pcontractor.TabIndex = 8;
            // 
            // cb_Pstatus
            // 
            this.cb_Pstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Pstatus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb_Pstatus.FormattingEnabled = true;
            this.cb_Pstatus.Items.AddRange(new object[] {
            "مريض كبد ",
            "مريض كلي ",
            "مريض سكر ",
            "مريض سيولة",
            "مريض قلب"});
            this.cb_Pstatus.Location = new System.Drawing.Point(15, 361);
            this.cb_Pstatus.Name = "cb_Pstatus";
            this.cb_Pstatus.Size = new System.Drawing.Size(288, 31);
            this.cb_Pstatus.TabIndex = 7;
            // 
            // txt_Page
            // 
            this.txt_Page.Location = new System.Drawing.Point(162, 168);
            this.txt_Page.Name = "txt_Page";
            this.txt_Page.Size = new System.Drawing.Size(141, 30);
            this.txt_Page.TabIndex = 6;
            this.txt_Page.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Page_KeyPress);
            // 
            // cb_Pyear
            // 
            this.cb_Pyear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Pyear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb_Pyear.FormattingEnabled = true;
            this.cb_Pyear.Items.AddRange(new object[] {
            "day",
            "month",
            "year"});
            this.cb_Pyear.Location = new System.Drawing.Point(15, 167);
            this.cb_Pyear.Name = "cb_Pyear";
            this.cb_Pyear.Size = new System.Drawing.Size(121, 31);
            this.cb_Pyear.TabIndex = 5;
            // 
            // cb_Pgender
            // 
            this.cb_Pgender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Pgender.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb_Pgender.FormattingEnabled = true;
            this.cb_Pgender.Items.AddRange(new object[] {
            "male",
            "famale"});
            this.cb_Pgender.Location = new System.Drawing.Point(15, 126);
            this.cb_Pgender.Name = "cb_Pgender";
            this.cb_Pgender.Size = new System.Drawing.Size(288, 31);
            this.cb_Pgender.TabIndex = 4;
            // 
            // txt_pname
            // 
            this.txt_pname.Location = new System.Drawing.Point(15, 77);
            this.txt_pname.Name = "txt_pname";
            this.txt_pname.Size = new System.Drawing.Size(288, 30);
            this.txt_pname.TabIndex = 3;
            this.txt_pname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_pname_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(356, 360);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 23);
            this.label8.TabIndex = 0;
            this.label8.Text = "حالة المريض :";
            // 
            // txt_Paddress
            // 
            this.txt_Paddress.Location = new System.Drawing.Point(15, 264);
            this.txt_Paddress.Name = "txt_Paddress";
            this.txt_Paddress.Size = new System.Drawing.Size(288, 30);
            this.txt_Paddress.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(415, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "العمر :";
            // 
            // txt_Pmail
            // 
            this.txt_Pmail.Location = new System.Drawing.Point(15, 314);
            this.txt_Pmail.Name = "txt_Pmail";
            this.txt_Pmail.Size = new System.Drawing.Size(288, 30);
            this.txt_Pmail.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(396, 267);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 23);
            this.label7.TabIndex = 0;
            this.label7.Text = "العنوان : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(322, 314);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 23);
            this.label6.TabIndex = 0;
            this.label6.Text = "البريد الاليكترونى :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(361, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "اسم المريض :";
            // 
            // txt_Pphone
            // 
            this.txt_Pphone.Location = new System.Drawing.Point(15, 215);
            this.txt_Pphone.Name = "txt_Pphone";
            this.txt_Pphone.Size = new System.Drawing.Size(288, 30);
            this.txt_Pphone.TabIndex = 1;
            this.txt_Pphone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Pphone_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(417, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "النوع :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(392, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "التليفون :";
            // 
            // txt_Pcode
            // 
            this.txt_Pcode.Location = new System.Drawing.Point(15, 29);
            this.txt_Pcode.Name = "txt_Pcode";
            this.txt_Pcode.ReadOnly = true;
            this.txt_Pcode.Size = new System.Drawing.Size(288, 30);
            this.txt_Pcode.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(357, 408);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 23);
            this.label9.TabIndex = 0;
            this.label9.Text = "جهة التعاقد:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(365, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "كود المريض :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_clear);
            this.groupBox2.Controls.Add(this.btn_exit);
            this.groupBox2.Controls.Add(this.btn_delete);
            this.groupBox2.Controls.Add(this.btn_search);
            this.groupBox2.Controls.Add(this.btn_update);
            this.groupBox2.Controls.Add(this.btn_add);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 14F);
            this.groupBox2.Location = new System.Drawing.Point(262, 468);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(659, 101);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // btn_clear
            // 
            this.btn_clear.BackgroundImage = global::Lab.Properties.Resources.unnamed;
            this.btn_clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_clear.Location = new System.Drawing.Point(115, 27);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(93, 62);
            this.btn_clear.TabIndex = 2;
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.BackgroundImage = global::Lab.Properties.Resources.exitbtn;
            this.btn_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_exit.Location = new System.Drawing.Point(6, 27);
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
            this.btn_delete.Location = new System.Drawing.Point(223, 26);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(93, 64);
            this.btn_delete.TabIndex = 0;
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_search
            // 
            this.btn_search.BackgroundImage = global::Lab.Properties.Resources.Button_15_128;
            this.btn_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_search.Location = new System.Drawing.Point(555, 25);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(93, 64);
            this.btn_search.TabIndex = 0;
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackgroundImage = global::Lab.Properties.Resources.images__2_;
            this.btn_update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_update.Location = new System.Drawing.Point(332, 25);
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
            this.btn_add.Location = new System.Drawing.Point(444, 25);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(93, 64);
            this.btn_add.TabIndex = 0;
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(393, 408);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 14F);
            this.groupBox3.Location = new System.Drawing.Point(12, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(405, 443);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "قائمة المرضى:";
            // 
            // PB_LOGO
            // 
            this.PB_LOGO.BackgroundImage = global::Lab.Properties.Resources.second_try;
            this.PB_LOGO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PB_LOGO.Location = new System.Drawing.Point(12, 462);
            this.PB_LOGO.Name = "PB_LOGO";
            this.PB_LOGO.Size = new System.Drawing.Size(167, 123);
            this.PB_LOGO.TabIndex = 6;
            this.PB_LOGO.TabStop = false;
            // 
            // Patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(933, 589);
            this.Controls.Add(this.PB_LOGO);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Patient";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PB_LOGO)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_Paddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Pmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Pphone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Pcode;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_pname;
        private System.Windows.Forms.ComboBox cb_Pgender;
        private System.Windows.Forms.TextBox txt_Page;
        private System.Windows.Forms.ComboBox cb_Pyear;
        private System.Windows.Forms.ComboBox cb_Pstatus;
        private System.Windows.Forms.ComboBox cb_Pcontractor;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox PB_LOGO;
    }
}