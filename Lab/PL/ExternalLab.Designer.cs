namespace Lab.PL
{
    partial class ExternalLab
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
            this.dgv_ELab = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_sgin = new System.Windows.Forms.TextBox();
            this.num_txt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_ELdiscont = new System.Windows.Forms.TextBox();
            this.txt_ELemail = new System.Windows.Forms.TextBox();
            this.txt_ELphone = new System.Windows.Forms.TextBox();
            this.txt_ELaddress = new System.Windows.Forms.TextBox();
            this.txt_ELname = new System.Windows.Forms.TextBox();
            this.txt_ELid = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.PB_LOGO = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ELab)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_LOGO)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_ELab);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 14F);
            this.groupBox1.Location = new System.Drawing.Point(618, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(364, 436);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "معامل خارجية :";
            // 
            // dgv_ELab
            // 
            this.dgv_ELab.AllowUserToAddRows = false;
            this.dgv_ELab.AllowUserToDeleteRows = false;
            this.dgv_ELab.AllowUserToOrderColumns = true;
            this.dgv_ELab.AllowUserToResizeRows = false;
            this.dgv_ELab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_ELab.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ELab.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgv_ELab.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ELab.Location = new System.Drawing.Point(6, 39);
            this.dgv_ELab.Name = "dgv_ELab";
            this.dgv_ELab.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ELab.Size = new System.Drawing.Size(352, 391);
            this.dgv_ELab.TabIndex = 0;
            this.dgv_ELab.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgv_ELab_MouseDoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_sgin);
            this.groupBox2.Controls.Add(this.num_txt);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txt_ELdiscont);
            this.groupBox2.Controls.Add(this.txt_ELemail);
            this.groupBox2.Controls.Add(this.txt_ELphone);
            this.groupBox2.Controls.Add(this.txt_ELaddress);
            this.groupBox2.Controls.Add(this.txt_ELname);
            this.groupBox2.Controls.Add(this.txt_ELid);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 14F);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(584, 436);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "بيانات المعمل الخارجى :";
            // 
            // txt_sgin
            // 
            this.txt_sgin.Location = new System.Drawing.Point(56, 52);
            this.txt_sgin.Name = "txt_sgin";
            this.txt_sgin.ReadOnly = true;
            this.txt_sgin.Size = new System.Drawing.Size(100, 30);
            this.txt_sgin.TabIndex = 3;
            // 
            // num_txt
            // 
            this.num_txt.Location = new System.Drawing.Point(56, 149);
            this.num_txt.Name = "num_txt";
            this.num_txt.Size = new System.Drawing.Size(360, 30);
            this.num_txt.TabIndex = 6;
            this.num_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.num_txt_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(469, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 23);
            this.label7.TabIndex = 4;
            this.label7.Text = "عدد الفروع:";
            // 
            // txt_ELdiscont
            // 
            this.txt_ELdiscont.Location = new System.Drawing.Point(56, 364);
            this.txt_ELdiscont.Name = "txt_ELdiscont";
            this.txt_ELdiscont.Size = new System.Drawing.Size(360, 30);
            this.txt_ELdiscont.TabIndex = 5;
            this.txt_ELdiscont.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ELdiscont_KeyPress);
            // 
            // txt_ELemail
            // 
            this.txt_ELemail.Location = new System.Drawing.Point(56, 311);
            this.txt_ELemail.Name = "txt_ELemail";
            this.txt_ELemail.Size = new System.Drawing.Size(360, 30);
            this.txt_ELemail.TabIndex = 4;
            // 
            // txt_ELphone
            // 
            this.txt_ELphone.Location = new System.Drawing.Point(56, 255);
            this.txt_ELphone.Name = "txt_ELphone";
            this.txt_ELphone.Size = new System.Drawing.Size(360, 30);
            this.txt_ELphone.TabIndex = 3;
            this.txt_ELphone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ELphone_KeyPress);
            // 
            // txt_ELaddress
            // 
            this.txt_ELaddress.Location = new System.Drawing.Point(56, 202);
            this.txt_ELaddress.Name = "txt_ELaddress";
            this.txt_ELaddress.Size = new System.Drawing.Size(360, 30);
            this.txt_ELaddress.TabIndex = 2;
            // 
            // txt_ELname
            // 
            this.txt_ELname.Location = new System.Drawing.Point(56, 106);
            this.txt_ELname.Name = "txt_ELname";
            this.txt_ELname.Size = new System.Drawing.Size(360, 30);
            this.txt_ELname.TabIndex = 1;
            // 
            // txt_ELid
            // 
            this.txt_ELid.Location = new System.Drawing.Point(316, 52);
            this.txt_ELid.Name = "txt_ELid";
            this.txt_ELid.ReadOnly = true;
            this.txt_ELid.Size = new System.Drawing.Size(100, 30);
            this.txt_ELid.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(455, 371);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 23);
            this.label6.TabIndex = 0;
            this.label6.Text = "نسبة الخصم :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(430, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "البريد الالكترونى :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(465, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "رقم الهاتف :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(495, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "العنوان :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(447, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "اسم المعمل :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(458, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "كود المعمل :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_clear);
            this.groupBox3.Controls.Add(this.btn_exit);
            this.groupBox3.Controls.Add(this.btn_delete);
            this.groupBox3.Controls.Add(this.btn_update);
            this.groupBox3.Controls.Add(this.btn_add);
            this.groupBox3.Controls.Add(this.btn_search);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 14F);
            this.groupBox3.Location = new System.Drawing.Point(12, 454);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(664, 110);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            // 
            // btn_clear
            // 
            this.btn_clear.BackgroundImage = global::Lab.Properties.Resources.unnamed;
            this.btn_clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_clear.Location = new System.Drawing.Point(115, 29);
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
            this.btn_exit.Location = new System.Drawing.Point(6, 29);
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
            this.btn_delete.Location = new System.Drawing.Point(225, 27);
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
            this.btn_update.Location = new System.Drawing.Point(336, 27);
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
            this.btn_add.Location = new System.Drawing.Point(447, 29);
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
            this.btn_search.Location = new System.Drawing.Point(558, 27);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(93, 64);
            this.btn_search.TabIndex = 0;
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // PB_LOGO
            // 
            this.PB_LOGO.BackgroundImage = global::Lab.Properties.Resources.second_try;
            this.PB_LOGO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PB_LOGO.Location = new System.Drawing.Point(815, 454);
            this.PB_LOGO.Name = "PB_LOGO";
            this.PB_LOGO.Size = new System.Drawing.Size(167, 123);
            this.PB_LOGO.TabIndex = 6;
            this.PB_LOGO.TabStop = false;
            // 
            // ExternalLab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(994, 580);
            this.Controls.Add(this.PB_LOGO);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "ExternalLab";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ELab)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PB_LOGO)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_ELab;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_ELdiscont;
        private System.Windows.Forms.TextBox txt_ELemail;
        private System.Windows.Forms.TextBox txt_ELphone;
        private System.Windows.Forms.TextBox txt_ELaddress;
        private System.Windows.Forms.TextBox txt_ELname;
        private System.Windows.Forms.TextBox txt_ELid;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox num_txt;
        private System.Windows.Forms.TextBox txt_sgin;
        private System.Windows.Forms.PictureBox PB_LOGO;
    }
}