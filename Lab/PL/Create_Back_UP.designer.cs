namespace Lab.PL
{
    partial class Create_Back_UP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Create_Back_UP));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_find_name = new System.Windows.Forms.TextBox();
            this.btn_Browse = new System.Windows.Forms.Button();
            this.btn_Create_Back_Up = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(304, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "رجاء تحديد مسار النسخة الإحتياطية";
            // 
            // txt_find_name
            // 
            this.txt_find_name.Font = new System.Drawing.Font("Traditional Arabic", 12F, System.Drawing.FontStyle.Bold);
            this.txt_find_name.Location = new System.Drawing.Point(125, 86);
            this.txt_find_name.Name = "txt_find_name";
            this.txt_find_name.Size = new System.Drawing.Size(401, 32);
            this.txt_find_name.TabIndex = 1;
            // 
            // btn_Browse
            // 
            this.btn_Browse.BackColor = System.Drawing.Color.Honeydew;
            this.btn_Browse.Font = new System.Drawing.Font("Traditional Arabic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btn_Browse.Location = new System.Drawing.Point(38, 86);
            this.btn_Browse.Name = "btn_Browse";
            this.btn_Browse.Size = new System.Drawing.Size(65, 32);
            this.btn_Browse.TabIndex = 2;
            this.btn_Browse.Text = "...";
            this.btn_Browse.UseVisualStyleBackColor = false;
            this.btn_Browse.Click += new System.EventHandler(this.btn_Browse_Click);
            // 
            // btn_Create_Back_Up
            // 
            this.btn_Create_Back_Up.BackColor = System.Drawing.Color.Honeydew;
            this.btn_Create_Back_Up.Location = new System.Drawing.Point(296, 177);
            this.btn_Create_Back_Up.Name = "btn_Create_Back_Up";
            this.btn_Create_Back_Up.Size = new System.Drawing.Size(152, 33);
            this.btn_Create_Back_Up.TabIndex = 3;
            this.btn_Create_Back_Up.Text = "انشاء نسخة احتياطية";
            this.btn_Create_Back_Up.UseVisualStyleBackColor = false;
            this.btn_Create_Back_Up.Click += new System.EventHandler(this.btn_Create_Back_Up_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.Color.Honeydew;
            this.btn_Cancel.Location = new System.Drawing.Point(104, 177);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(110, 33);
            this.btn_Cancel.TabIndex = 4;
            this.btn_Cancel.Text = "الغـاء";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btn_Cancel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_Create_Back_Up);
            this.groupBox1.Controls.Add(this.txt_find_name);
            this.groupBox1.Controls.Add(this.btn_Browse);
            this.groupBox1.Font = new System.Drawing.Font("Traditional Arabic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(547, 269);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // Create_Back_UP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(571, 293);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Create_Back_UP";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "انشاء نسخة احتياطية";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_find_name;
        private System.Windows.Forms.Button btn_Browse;
        private System.Windows.Forms.Button btn_Create_Back_Up;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
       
    }
}