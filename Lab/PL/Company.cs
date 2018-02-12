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
    public partial class Company : Form
    {
        BL.CLS_CONTRACT cust = new BL.CLS_CONTRACT();
        int id;
        public Company()
        {
            InitializeComponent();
            txt_sgin.Text = "3";
            this.dataGridView1.DataSource = cust.Get_All_Company(Convert.ToInt32(txt_sgin.Text));
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;   
        }

  //*********************************خروج**************************************
        private void btn_exit_Click(object sender, EventArgs e)
        {

            Close();

        }


//**********************************اضافة***************************************    
        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_cname.Text == "" || txt_specialization.Text == "" || txt_cdis.Text == "")
                {
                    MessageBox.Show(" !(الرجاء التأكد من ادخال البيانات الاساسية (الاسم-النوع-الخصم ", "عملية الأضافة", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    cust.Add_CONTRACT(txt_cname.Text, txt_specialization.Text, txt_caddress.Text, txt_cphone.Text, txt_cmaile.Text, txt_cdis.Text, Convert.ToInt32(txt_sgin.Text));
                    txt_cname.Text = "";
                    txt_specialization.Text = "";
                    txt_caddress.Text = "";
                    txt_cphone.Text = "";
                    txt_cmaile.Text = "";
                    txt_cdis.Text = "";
                    this.dataGridView1.DataSource = cust.Get_All_Company(Convert.ToInt32(txt_sgin.Text));
                    MessageBox.Show("تمت الأضافة بنجاح ! ");
                }
            }
          
            catch (Exception ex) {MessageBox.Show(ex.Message);}
        }

       

//*******************************تعديل ********************************************
        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                if (id == 0)
                {
                    MessageBox.Show("هذا العميل الذي تريد تعديله غير موجود");
                    return;
                }
                cust.UpDate_CONTRACT(txt_cname.Text, txt_specialization.Text, txt_caddress.Text, 
                                     txt_cphone.Text, txt_cmaile.Text, txt_cdis.Text,id);
                MessageBox.Show("تمت التعديل بالنجاح", "التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dataGridView1.DataSource = cust.Get_All_Company(Convert.ToInt32(txt_sgin.Text));
            }
            catch (Exception ex) {MessageBox.Show(ex.Message);}

        }
//*************************************************************************************
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           // id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            this.txt_ccode.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            this.txt_cname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            this.txt_specialization.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            this.txt_caddress.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            this.txt_cphone.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            this.txt_cmaile.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            this.txt_cdis.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }
//******************************البحث****************************************************************
        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_cname.Text != "")
                {
                    dataGridView1.DataSource = cust.SearchCompanyByName(txt_cname.Text, Convert.ToInt32(txt_sgin.Text));
                    dataGridView1.Columns[2].Visible = false;
                    dataGridView1.Columns[3].Visible = false;
                    dataGridView1.Columns[4].Visible = false;
                    dataGridView1.Columns[5].Visible = false;
                    dataGridView1.Columns[6].Visible = false;
                   
                }
                else
                    this.dataGridView1.DataSource = cust.Get_All_Company(Convert.ToInt32(txt_sgin.Text));
            }
            catch (Exception ex) {MessageBox.Show(ex.Message);}
        }


//**********************************الحذف************************************************************
        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                if (id == 0)
                {
                    MessageBox.Show("هذا العميل الذي تريد حذفه غير موجود");
                    return;
                }
                if (MessageBox.Show("هل تريد فعلا حذف هذا العميل؟", "الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cust.delete_CONTRACT(id);
                    MessageBox.Show("تمت الحذف بالنجاح", "الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.dataGridView1.DataSource = cust.Get_All_Company(Convert.ToInt32(txt_sgin.Text));
                    txt_ccode.Text = "";
                    txt_cname.Text = "";
                    txt_cphone.Text = "";
                    txt_caddress.Text = "";
                    txt_specialization.Text = "";
                    txt_cmaile.Text = "";
                    txt_cdis.Text = "";
                    

                }
            }
            catch (Exception ex) {MessageBox.Show(ex.Message);}
            

        }
//*********************clear*****************************************************************************************
        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_ccode.Text = "";
            txt_cname.Text = "";
            txt_cphone.Text = "";
            txt_caddress.Text = "";
            txt_specialization.Text = "";
            txt_cmaile.Text = "";
            txt_cdis.Text = "";
            this.dataGridView1.DataSource = cust.Get_All_Company(Convert.ToInt32(txt_sgin.Text));
        }
//******************************validate numbers*****************************************************************
        private void txt_cphone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar))
            {
                btn_add.Enabled = false;
                int visabletime = 1000;
                ToolTip t1 = new ToolTip();
                t1.Show("رقم التليفون لايحتوى على حروف ", txt_cphone, 0, 0, visabletime);
                e.Handled = true;
            }
            else
            {
                btn_add.Enabled = true;
            }
        }
 //******************************validate numbers*****************************************************************
        private void txt_cdis_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar))
            {
                btn_add.Enabled = false;
                int visabletime = 1000;
                ToolTip t1 = new ToolTip();
                t1.Show("الخصم يجـب ان يكون رقم ", txt_cdis, 0, 0, visabletime);
                e.Handled = true;
            }
            else
            {
                btn_add.Enabled = true;
            }
        }
    }
}
