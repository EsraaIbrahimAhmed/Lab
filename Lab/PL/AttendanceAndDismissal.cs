using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Lab.PL
{
    public partial class AttendanceAndDismissal : Form
    {
        BL.Cls_attendance attend = new BL.Cls_attendance();
        public AttendanceAndDismissal()
        {
            InitializeComponent();


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now.Date;
            this.dataGridView2.DataSource = attend.dismisal(txt_userid.Text,date);
            dataGridView2.Rows[0].Cells[0].Value = DateTime.Now.ToLongTimeString();

            string dimisal = dataGridView2.Rows[0].Cells[0].Value.ToString();
            attend.GetDimisal(Convert.ToInt32(txt_userid.Text), Convert.ToDateTime(dimisal));             
                     
        }



        private void btn_attendance_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_userid.Text != "")
                {
                    DateTime date = DateTime.Now.Date;

                    this.dataGridView1.DataSource = attend.Attendance(txt_userid.Text);
                    dataGridView1.Rows[0].Cells[0].Value = DateTime.Now.ToLongTimeString();

                    string atten = dataGridView1.Rows[0].Cells[0].Value.ToString();
                    attend.GetAttend(Convert.ToInt32(txt_userid.Text), Convert.ToDateTime(atten), date);
                   
                }
                else
                { MessageBox.Show("ادخل كود العامل"); }

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }
        //******************************validate numbers*****************************************************************
        private void txt_userid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar))
            {
                btn_dimissal.Enabled = false;
                btn_attendance.Enabled = false;

                int visabletime = 1000;
                ToolTip t1 = new ToolTip();
                t1.Show("الكود يجـب ان يكون رقم ", txt_userid, 0, 0, visabletime);
                e.Handled = true;
            }
            else
            {
                btn_dimissal.Enabled = true;
                btn_attendance.Enabled = true;

            }
        }

      
    }
       
    }

