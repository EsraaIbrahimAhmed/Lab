namespace Lab.PL
{
    partial class Doctor
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_DDiscont = new System.Windows.Forms.TextBox();
            this.txt_DMail = new System.Windows.Forms.TextBox();
            this.txt_DPhone = new System.Windows.Forms.TextBox();
            this.txt_DAddress = new System.Windows.Forms.TextBox();
            this.txt_DSpecilize = new System.Windows.Forms.TextBox();
            this.txt_sign = new System.Windows.Forms.TextBox();
            this.txt_DId = new System.Windows.Forms.TextBox();
            this.txt_DName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgv_allDoctors = new System.Windows.Forms.DataGridView();
            this.PB_LOGO = new System.Windows.Forms.PictureBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_allDoctors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_LOGO)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_clear);
            this.groupBox2.Controls.Add(this.btn_exit);
            this.groupBox2.Controls.Add(this.btn_delete);
            this.groupBox2.Controls.Add(this.btn_update);
            this.groupBox2.Controls.Add(this.btn_add);
            this.groupBox2.Controls.Add(this.btn_search);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 14F);
            this.groupBox2.Location = new System.Drawing.Point(35, 486);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(660, 113);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_DDiscont);
            this.groupBox1.Controls.Add(this.txt_DMail);
            this.groupBox1.Controls.Add(this.txt_DPhone);
            this.groupBox1.Controls.Add(this.txt_DAddress);
            this.groupBox1.Controls.Add(this.txt_DSpecilize);
            this.groupBox1.Controls.Add(this.txt_sign);
            this.groupBox1.Controls.Add(this.txt_DId);
            this.groupBox1.Controls.Add(this.txt_DName);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 14F);
            this.groupBox1.Location = new System.Drawing.Point(35, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(539, 468);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بيانات الطبيب :";
            // 
            // txt_DDiscont
            // 
            this.txt_DDiscont.Location = new System.Drawing.Point(23, 414);
            this.txt_DDiscont.Name = "txt_DDiscont";
            this.txt_DDiscont.Size = new System.Drawing.Size(327, 30);
            this.txt_DDiscont.TabIndex = 6;
            this.txt_DDiscont.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_DDiscont_KeyPress);
            // 
            // txt_DMail
            // 
            this.txt_DMail.Location = new System.Drawing.Point(23, 343);
            this.txt_DMail.Name = "txt_DMail";
            this.txt_DMail.Size = new System.Drawing.Size(327, 30);
            this.txt_DMail.TabIndex = 5;
            // 
            // txt_DPhone
            // 
            this.txt_DPhone.Location = new System.Drawing.Point(23, 283);
            this.txt_DPhone.Name = "txt_DPhone";
            this.txt_DPhone.Size = new System.Drawing.Size(327, 30);
            this.txt_DPhone.TabIndex = 4;
            this.txt_DPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_DPhone_KeyPress);
            // 
            // txt_DAddress
            // 
            this.txt_DAddress.Location = new System.Drawing.Point(23, 224);
            this.txt_DAddress.Name = "txt_DAddress";
            this.txt_DAddress.Size = new System.Drawing.Size(327, 30);
            this.txt_DAddress.TabIndex = 3;
            // 
            // txt_DSpecilize
            // 
            this.txt_DSpecilize.Location = new System.Drawing.Point(23, 161);
            this.txt_DSpecilize.Name = "txt_DSpecilize";
            this.txt_DSpecilize.Size = new System.Drawing.Size(327, 30);
            this.txt_DSpecilize.TabIndex = 2;
            // 
            // txt_sign
            // 
            this.txt_sign.Location = new System.Drawing.Point(34, 43);
            this.txt_sign.Name = "txt_sign";
            this.txt_sign.ReadOnly = true;
            this.txt_sign.Size = new System.Drawing.Size(88, 30);
            this.txt_sign.TabIndex = 1;
            // 
            // txt_DId
            // 
            this.txt_DId.Location = new System.Drawing.Point(262, 43);
            this.txt_DId.Name = "txt_DId";
            this.txt_DId.ReadOnly = true;
            this.txt_DId.Size = new System.Drawing.Size(88, 30);
            this.txt_DId.TabIndex = 1;
            // 
            // txt_DName
            // 
            this.txt_DName.Location = new System.Drawing.Point(23, 104);
            this.txt_DName.Name = "txt_DName";
            this.txt_DName.Size = new System.Drawing.Size(327, 30);
            this.txt_DName.TabIndex = 1;
            this.txt_DName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_DName_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(401, 421);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 23);
            this.label7.TabIndex = 0;
            this.label7.Text = "نسبة الخصم :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(376, 350);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 23);
            this.label6.TabIndex = 0;
            this.label6.Text = "البريد الالكترونى :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(419, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "رقم الهاتف :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(449, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "العنوان :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(434, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "التخصص :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(414, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "كود الطبيب :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(403, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "اسم الطبيب :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgv_allDoctors);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 14F);
            this.groupBox3.Location = new System.Drawing.Point(595, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox3.Size = new System.Drawing.Size(396, 468);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "الأطباء :";
            // 
            // dgv_allDoctors
            // 
            this.dgv_allDoctors.AllowUserToAddRows = false;
            this.dgv_allDoctors.AllowUserToDeleteRows = false;
            this.dgv_allDoctors.AllowUserToResizeRows = false;
            this.dgv_allDoctors.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_allDoctors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_allDoctors.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgv_allDoctors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_allDoctors.Location = new System.Drawing.Point(6, 29);
            this.dgv_allDoctors.Name = "dgv_allDoctors";
            this.dgv_allDoctors.ReadOnly = true;
            this.dgv_allDoctors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_allDoctors.Size = new System.Drawing.Size(384, 433);
            this.dgv_allDoctors.TabIndex = 0;
            this.dgv_allDoctors.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgv_allDoctors_MouseDoubleClick);
            // 
            // PB_LOGO
            // 
            this.PB_LOGO.BackgroundImage = global::Lab.Properties.Resources.second_try;
            this.PB_LOGO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PB_LOGO.Location = new System.Drawing.Point(824, 486);
            this.PB_LOGO.Name = "PB_LOGO";
            this.PB_LOGO.Size = new System.Drawing.Size(167, 123);
            this.PB_LOGO.TabIndex = 5;
            this.PB_LOGO.TabStop = false;
            // 
            // btn_clear
            // 
            this.btn_clear.BackgroundImage = global::Lab.Properties.Resources.unnamed;
            this.btn_clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_clear.Location = new System.Drawing.Point(114, 29);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(93, 62);
            this.btn_clear.TabIndex = 1;
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
            this.btn_delete.Location = new System.Drawing.Point(222, 28);
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
            this.btn_update.Location = new System.Drawing.Point(333, 27);
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
            this.btn_add.Location = new System.Drawing.Point(446, 28);
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
            this.btn_search.Location = new System.Drawing.Point(560, 29);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(93, 64);
            this.btn_search.TabIndex = 0;
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // Doctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1003, 611);
            this.Controls.Add(this.PB_LOGO);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.MaximizeBox = false;
            this.Name = "Doctor";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_allDoctors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_LOGO)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_DDiscont;
        private System.Windows.Forms.TextBox txt_DMail;
        private System.Windows.Forms.TextBox txt_DPhone;
        private System.Windows.Forms.TextBox txt_DAddress;
        private System.Windows.Forms.TextBox txt_DSpecilize;
        private System.Windows.Forms.TextBox txt_DName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgv_allDoctors;
        private System.Windows.Forms.TextBox txt_DId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.TextBox txt_sign;
        private System.Windows.Forms.PictureBox PB_LOGO;
    }
}