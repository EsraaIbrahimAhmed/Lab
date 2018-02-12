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
    public partial class supplier : Form
    {
        BL.Cls_Supplier sup = new BL.Cls_Supplier();
        public supplier()
        {
            InitializeComponent();
            this.dataGridView1.DataSource = sup.Get_All_Supplier();
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;

        }

        private void search_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_supname.Text != "")
                {
                    dataGridView1.DataSource = sup.SearchSupByName(txt_supname.Text);
                }
               
                else
                {
                    MessageBox.Show("عفوا لم يتم العثور على هذا المورد برجاء ادخال اسم صحيح ", "عملية البحث", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            
        }

        private void add_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_supname.Text == "" || txt_supaddress.Text == "" || txt_supphone.Text == "" || sup_specialization.Text == "")
                {
                    MessageBox.Show("(الرجاء التاكد من ادخال البيانات الاساسية(الاسم - العنوان -التخصص - التليفون", "عملية الاضافة", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    sup.Add_Supplier(txt_supname.Text, sup_specialization.Text, txt_supaddress.Text, txt_supphone.Text, txt_supmail.Text);
                    txt_supname.Text = "";
                    sup_specialization.Text = "";
                    txt_supaddress.Text = "";
                    txt_supphone.Text = "";
                    txt_supmail.Text = "";
                    this.dataGridView1.DataSource = sup.Get_All_Supplier();
                    MessageBox.Show("تمت الاضافة ");


                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void update_Click(object sender, EventArgs e)
        {
            try
            {
                sup.UpDate_Supplier(Convert.ToInt32(txt_supcode.Text), txt_supname.Text, sup_specialization.Text, txt_supaddress.Text, txt_supphone.Text, txt_supmail.Text);
                txt_supcode.Text = "";
                txt_supname.Text = "";
                sup_specialization.Text = "";
                txt_supaddress.Text = "";
                txt_supphone.Text = "";
                txt_supmail.Text = "";
                this.dataGridView1.DataSource = sup.Get_All_Supplier();
                MessageBox.Show("تم تعديل البيانات بنجاح ");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد حذف هذا المورد ", "عملية الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                sup.Delete_Supplier(Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value.ToString()));
                txt_supname.Text = "";
                sup_specialization.Text = "";
                txt_supaddress.Text = "";
                txt_supphone.Text = "";
                txt_supmail.Text = "";
                this.dataGridView1.DataSource = sup.Get_All_Supplier();
                MessageBox.Show("تم الحذف ", " عملية الحذف ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("تم الغاء عملية الحذف", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            this.dataGridView1.DataSource = sup.Get_All_Supplier();
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                int i = dataGridView1.CurrentCell.RowIndex;
                txt_supcode.Text = dataGridView1.Rows[i].Cells["كودالمورد"].Value.ToString();
                txt_supname.Text = dataGridView1.Rows[i].Cells["اسم المورد"].Value.ToString();
                sup_specialization.Text = dataGridView1.Rows[i].Cells["تخصص المورد"].Value.ToString();
                txt_supaddress.Text = dataGridView1.Rows[i].Cells["العنوان"].Value.ToString();
                txt_supphone.Text = dataGridView1.Rows[i].Cells["رقم الهاتف"].Value.ToString();
                txt_supmail.Text = dataGridView1.Rows[i].Cells["البريد الالكترونى"].Value.ToString();
            
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_supname.Text = "";
            sup_specialization.Text = "";
            txt_supaddress.Text = "";
            txt_supphone.Text = "";
            txt_supmail.Text = "";
            this.dataGridView1.DataSource = sup.Get_All_Supplier();
        }

    }
}