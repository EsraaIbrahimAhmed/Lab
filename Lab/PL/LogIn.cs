using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab.PL
{
    public partial class LogIn : Form
    {
        BL.Cls_LogIn log = new BL.Cls_LogIn();
        public LogIn()
        {
            InitializeComponent();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            MainForm frmstart = new MainForm();
            DataTable Dt = log.LogIN(Convert.ToInt32(txt_username.Text), txt_pwd.Text, cb_job.Text);
            if (Dt.Rows.Count > 0 &&cb_job.Text == "Admin")
            {
                //frmstart.المخزن.Enabled = false;
                //frmstart.تقارير.Enabled = false;
                frmstart.ShowDialog();             
            }
            else if (Dt.Rows.Count > 0 && cb_job.Text == "Assistant")
            { 
                frmstart.الموردينToolStripMenuItem.Enabled = false;
                frmstart.ادارةالبياناتToolStripMenuItem.Enabled = false;
                frmstart.أطباءToolStripMenuItem.Enabled = false;
                frmstart.المتعاقدينToolStripMenuItem.Enabled = false;
                frmstart.معاملخارجيةToolStripMenuItem.Enabled = false;
                frmstart.التحاليلToolStripMenuItem.Enabled = false;
                frmstart.العاملينToolStripMenuItem.Enabled = false;
                //frmstart.المخزن.Enabled = false;
                //frmstart.تقارير.Enabled = false;
                frmstart.ShowDialog();
            }
            else
            {
                MessageBox.Show("الرجاء التأكد من ادخال البيانات الصحيحة");
            }
            //LogIn frm = new LogIn();
            //frm.Close();
        }
    }
}
