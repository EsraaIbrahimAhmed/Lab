using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Lab.PL
{
    public partial class Create_Back_UP : Form
    {
        SqlConnection con = new SqlConnection(@"Server=(localdb)\v11.0;Database=ELab;Integrated Security=true");
        SqlCommand cmd;
        public Create_Back_UP()
        {
            InitializeComponent();
        }

        private void btn_Browse_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            { txt_find_name.Text = folderBrowserDialog1.SelectedPath; }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Create_Back_Up_Click(object sender, EventArgs e)
        {
            if (txt_find_name.Text == "")
            { MessageBox.Show("رجاء اختر المكان اولا", "خطأ"); }
            else
            {
                try
                {
                    //مع استبدال الداش بشئ اخر مقبول 
                    string fileName = txt_find_name.Text + "\\ELab" + DateTime.Now.ToShortDateString().Replace('/', '-') + "-" + DateTime.Now.ToLongTimeString().Replace(':', '-');
                    string strQuery = "Backup database ELab to disk ='" + fileName + ".bak'";
                    cmd = new SqlCommand(strQuery, con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("تم انشاء النسخة الاحتياطية بنجاح ", "إنشاء نسخة إحتياطية", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }

      
    }
}
