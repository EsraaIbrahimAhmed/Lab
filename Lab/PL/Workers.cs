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
    public partial class Workers : Form
    {
        BL.Cls_Workers worker = new BL.Cls_Workers();
        public Workers()
        {
            InitializeComponent();
           this.dataGridView1.DataSource = worker.Get_All_USER();
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[10].Visible = false;
            dataGridView1.Columns[11].Visible = false;
           
        }

      

        private void add_Click(object sender, EventArgs e)
        {
             try
            {
                if (txt_workername.Text == "" || txt_workeraddress.Text == "" || txt_workerphone.Text == "" || password.Text == "")
                {
                    MessageBox.Show("(الرجاء التاكد من ادخال البيانات الاساسية(الاسم - العنوان -التخصص - التليفون", "عملية الاضافة", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    worker.Add_User(txt_workername.Text, password.Text, txt_workeraddress.Text,Convert.ToInt32(txt_workerphone.Text),
                        Convert.ToInt32(idnumber.Text),dateofbirth.Value,workeremail.Text,job.Text,wages.Text,notes.Text);
                    txt_workername.Text = "";
                    password.Text = "";
                    txt_workeraddress.Text = "";
                    txt_workerphone.Text = "";
                    idnumber.Text = "";
                    workeremail.Text = "";
                   
                    job.Text = "";
                    wages.Text = "";
                    notes.Text = "";
                    this.dataGridView1.DataSource = worker.Get_All_USER();
                    MessageBox.Show("تمت الاضافة ");
                }
            }
             catch (Exception ex) { MessageBox.Show(ex.Message); }
        

        }

        private void update_Click(object sender, EventArgs e)
        {
             try
            {
                worker.UpDate_User(Convert.ToInt32(txt_workercode.Text), txt_workername.Text, password.Text, txt_workeraddress.Text,Convert.ToInt32(txt_workerphone.Text),
                  Convert.ToInt32(idnumber.Text),dateofbirth.Value,workeremail.Text, job.Text,Convert.ToInt32(wages.Text), notes.Text);
                txt_workercode.Text = "";
                txt_workername.Text = "";
                password.Text = "";
                txt_workeraddress.Text = "";
                txt_workerphone.Text = "";
                idnumber.Text = "";
               ///dateofbirth.Value = "";
                workeremail.Text= "";
                
                job.Text = "";
                wages.Text = "";
                notes.Text = "";
               this.dataGridView1.DataSource = worker.Get_All_USER();
                MessageBox.Show("تم تعديل البيانات بنجاح ");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            
  
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void AddImage_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files | *.PNG; *.JPG; *GIF";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = worker.Get_All_USER();
            txt_workercode.Text = "";
            txt_workername.Text = "";
            password.Text = "";
            txt_workeraddress.Text = "";
            txt_workerphone.Text = "";
            idnumber.Text = "";
            ///dateofbirth.Value = "";
            workeremail.Text = "";
            job.Text = "";
            wages.Text = "";
            notes.Text = "";
        }
    }
}
