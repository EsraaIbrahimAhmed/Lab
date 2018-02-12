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
    public partial class Patient : Form
    {
        
        DataTable dt1 = new DataTable();
        DataTable dt2 = new DataTable();
        
        BL.CLS_PATIENT cust = new BL.CLS_PATIENT();
        int id;
        
        BL.CLS_CONTRACT c = new BL.CLS_CONTRACT();

        public Patient()
        {
            InitializeComponent();
            this.dataGridView1.DataSource = cust.GET_ALL_PATIENT();
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;
          



            cb_Pcontractor.DataSource = c.GET_ALL_CONTRACT();
            cb_Pcontractor.DisplayMember = "contractor_name";

        }


       
//*********************************خروج**************************************
        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
            

        }


//*********************************بحث ********************************************
        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_pname.Text != "")
                { dataGridView1.DataSource = cust.SEARCH_PATIENT(txt_pname.Text);
                dataGridView1.Columns[2].Visible = false;
                dataGridView1.Columns[3].Visible = false;
                dataGridView1.Columns[4].Visible = false;
                dataGridView1.Columns[5].Visible = false;
                dataGridView1.Columns[6].Visible = false;
                dataGridView1.Columns[7].Visible = false;
                dataGridView1.Columns[8].Visible = false;
                dataGridView1.Columns[9].Visible = false;
                }
                else
                    this.dataGridView1.DataSource = cust.GET_ALL_PATIENT();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


//**********************************اضافة مريض******************************
        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {

                if (txt_pname.Text != "" && cb_Pgender.Text != "" && txt_Page.Text != "" && cb_Pyear.Text != "" && txt_Pphone.Text != "")
                {
                    cust.Add_patient(txt_pname.Text,Convert.ToInt32(txt_Page.Text),cb_Pyear.Text, cb_Pgender.Text, cb_Pstatus.Text, txt_Pmail.Text, txt_Paddress.Text, txt_Pphone.Text,cb_Pcontractor.Text);
                    MessageBox.Show("تمت الاضافة بالنجاح", "الاضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.dataGridView1.DataSource = cust.GET_ALL_PATIENT();
                    


                    txt_pname.Text = "";
                    txt_Pcode.Text = "";
                    txt_Paddress.Text = "";
                    txt_Page.Text = "";
                    txt_Pmail.Text = "";
                    txt_Pphone.Text = "";
                    cb_Pcontractor.Text = "";
                    cb_Pgender.Text = "";
                    cb_Pstatus.Text = "";
                    cb_Pyear.Text = "";
                    
                   
                   
                }
                else
                    MessageBox.Show("لايمكن الاضافة والحقول فارغة املي الحقول اولا ");
            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

//************************تعديل ***********************************************
        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                if (id == 0)
                {
                    MessageBox.Show("هذا العميل الذي تريد تعديله غير موجود");
                    return;
                }
                cust.edit_patient(txt_pname.Text, txt_Pphone.Text, txt_Paddress.Text,Convert.ToInt32(txt_Page.Text),cb_Pyear.Text, txt_Pmail.Text, id);
                MessageBox.Show("تمت التعديل بالنجاح", "التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dataGridView1.DataSource = cust.GET_ALL_PATIENT();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

//**********************************************************************************
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            this.txt_Pcode.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            this.txt_pname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            this.txt_Page.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            this.cb_Pgender.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            this.txt_Paddress.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            this.txt_Pphone.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            this.txt_Pmail.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            this.cb_Pstatus.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();


        }


 //***********************الحذف*******************************************
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
                    cust.delete_patient(id);
                    MessageBox.Show("تمت الحذف بالنجاح", "الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.dataGridView1.DataSource = cust.GET_ALL_PATIENT();
                    txt_Pcode.Text = "";
                    txt_pname.Text = "";
                    txt_Pphone.Text = "";
                    txt_Paddress.Text = "";
                    txt_Page.Text = "";
                    txt_Pmail.Text = "";
                    cb_Pgender.Text = "";
                    cb_Pstatus.Text = "";

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
//*****************************clear******************************************************************
        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_Pcode.Text = "";
            txt_pname.Text = "";
            txt_Pphone.Text = "";
            txt_Paddress.Text = "";
            txt_Page.Text = "";
            txt_Pmail.Text = "";
            cb_Pgender.Text = "";
            cb_Pstatus.Text = "";
            this.dataGridView1.DataSource = cust.GET_ALL_PATIENT();
        }

//*************************************************************************************************************
        private void txt_pname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsSeparator(e.KeyChar))
            {
                btn_add.Enabled = false;
                btn_search.Enabled = false;
                int visabletime = 1000;
                ToolTip t1 = new ToolTip();
                t1.Show(" اسم المريض" + "يجـب ان يكون مكون من حروف فقط", txt_pname, 0, 0, visabletime);
                e.Handled = true;
            }
            else
            {
                btn_add.Enabled = true;
                btn_search.Enabled = true;
            }
        }
//**********************************************************************************************************************
        private void txt_Page_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar))
            {
                btn_add.Enabled = false;
                int visabletime = 1000;
                ToolTip t1 = new ToolTip();
                t1.Show("العمر يجب ان يكون رقم ", txt_Page, 0, 0, visabletime);
                e.Handled = true;
            }
            else
            {
                btn_add.Enabled = true;
            }  
        }
//******************************************************************************************************************
        private void txt_Pphone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar))
            {
                btn_add.Enabled = false;
                int visabletime = 1000;
                ToolTip t1 = new ToolTip();
                t1.Show("رقم الهاتف لايحتوى على ارقام ", txt_Pphone, 0, 0, visabletime);
                e.Handled = true;
            }
            else
            {
                btn_add.Enabled = true;
            }
        }

      
      
    }
}
