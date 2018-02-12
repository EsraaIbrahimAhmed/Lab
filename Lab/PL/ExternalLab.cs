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
    public partial class ExternalLab : Form
    {
        BL.CLS_CONTRACT ExL = new BL.CLS_CONTRACT();

        public ExternalLab()
        {
            InitializeComponent();
            txt_sgin.Text = "2";
            this.dgv_ELab.DataSource = ExL.Get_All_EXLab(Convert.ToInt32(txt_sgin.Text));
            dgv_ELab.Columns[2].Visible = false;
            dgv_ELab.Columns[3].Visible = false;
            dgv_ELab.Columns[4].Visible = false;
            dgv_ELab.Columns[5].Visible = false;
            dgv_ELab.Columns[6].Visible = false;
           
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgv_ELab_MouseDoubleClick(object sender, MouseEventArgs e)
        {
             try
            {
                int i = dgv_ELab.CurrentCell.RowIndex;
                txt_ELid.Text = dgv_ELab.Rows[i].Cells["كود المعمل "].Value.ToString();
                txt_ELname.Text = dgv_ELab.Rows[i].Cells["اسم المعمل "].Value.ToString();
                num_txt.Text = dgv_ELab.Rows[i].Cells["عدد الفروع"].Value.ToString();
                txt_ELaddress.Text = dgv_ELab.Rows[i].Cells["العنوان"].Value.ToString();
               // num_txt.Text = dgv_ELab.Rows[i].Cells["عدد الفروع"].Value.ToString();
                txt_ELphone.Text =dgv_ELab.Rows[i].Cells["رقم الهاتف"].Value.ToString();
                txt_ELemail.Text = dgv_ELab.Rows[i].Cells["البريد الالكترونى"].Value.ToString();
                txt_ELdiscont.Text =dgv_ELab.Rows[i].Cells["نسبة الخصم"].Value.ToString();
               

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_ELname.Text == "" || num_txt.Text=="" || txt_ELaddress.Text == "" || txt_ELphone.Text == "" || txt_ELdiscont.Text == "")
                {
                    MessageBox.Show("... الرجاء التأكد من ادخال البيانات فى الحقول الفارغة ", "عملية الأضافة", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    ExL.Add_CONTRACT(txt_ELname.Text,num_txt.Text, txt_ELaddress.Text, txt_ELphone.Text, txt_ELemail.Text, txt_ELdiscont.Text,Convert.ToInt32(txt_sgin.Text));
                    txt_ELname.Text = "";
                    num_txt.Text = "";
                    txt_ELaddress.Text = "";
                    txt_ELphone.Text = "";
                    txt_ELemail.Text = "";
                    txt_ELdiscont.Text = "";
                    this.dgv_ELab.DataSource = ExL.Get_All_EXLab(Convert.ToInt32(txt_sgin.Text));
                    MessageBox.Show("تمت الأضافة بنجاح ! ");
                }
            }

            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                ExL.UpDate_CONTRACT(txt_ELname.Text,num_txt.Text, txt_ELaddress.Text, txt_ELphone.Text, txt_ELemail.Text, txt_ELdiscont.Text, Convert.ToInt32(txt_ELid.Text));
                txt_ELid.Text = "";
                txt_ELname.Text = "";
                num_txt.Text = "";
                txt_ELaddress.Text = "";
                txt_ELphone.Text = "";
                txt_ELemail.Text = "";
                txt_ELdiscont.Text = "";
                this.dgv_ELab.DataSource = ExL.Get_All_EXLab(Convert.ToInt32(txt_sgin.Text));
                MessageBox.Show("تمت تعديل البيانات بنجاح ! ");
            }

            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد فعلا حذف هذا المعمل ", "عملية الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                ExL.delete_CONTRACT(Convert.ToInt32(this.dgv_ELab.CurrentRow.Cells[0].Value.ToString()));
                txt_ELid.Text = "";
                txt_ELname.Text = "";
                num_txt.Text = "";
                txt_ELaddress.Text = "";
                txt_ELphone.Text = "";
                txt_ELemail.Text = "";
                txt_ELdiscont.Text = "";
                MessageBox.Show("تمت عملية الحذف بنجاح", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dgv_ELab.DataSource = ExL.Get_All_EXLab(Convert.ToInt32(txt_sgin.Text));
            }
            else
            {
                MessageBox.Show("تم الغاء عملية الحذف", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            this.dgv_ELab.DataSource = ExL.Get_All_EXLab(Convert.ToInt32(txt_sgin.Text));
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_ELname.Text=="")
                    MessageBox.Show("عفوا لم تقم بادخال اسم المعمل للبحث عنه", "عملية البحث", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (txt_ELname.Text != "")
                {
                    dgv_ELab.DataSource = ExL.SearchExLabByName(txt_ELname.Text, Convert.ToInt32(txt_sgin.Text));
                }

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            this.dgv_ELab.DataSource = ExL.Get_All_EXLab(Convert.ToInt32(txt_sgin.Text));
            txt_ELid.Text = "";
            txt_ELname.Text = "";
            num_txt.Text = "";
            txt_ELaddress.Text = "";
            txt_ELphone.Text = "";
            txt_ELemail.Text = "";
            txt_ELdiscont.Text = "";
        }
//*******************************************************************************************************
        private void num_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar))
            {
                btn_add.Enabled = false;
                int visabletime = 1000;
                ToolTip t1 = new ToolTip();
                t1.Show("عدد الفروع يجب ان يكون ارقام ", num_txt, 0, 0, visabletime);
                e.Handled = true;
            }
            else
            {
                btn_add.Enabled = true;
            }
        }

        private void txt_ELphone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar))
            {
                btn_add.Enabled = false;
                int visabletime = 1000;
                ToolTip t1 = new ToolTip();
                t1.Show("رقم الهاتف لايحتوى على حروف ", txt_ELphone, 0, 0, visabletime);
                e.Handled = true;
            }
            else
            {
                btn_add.Enabled = true;
            }
        }

        private void txt_ELdiscont_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar))
            {
                btn_add.Enabled = false;
                int visabletime = 1000;
                ToolTip t1 = new ToolTip();
                t1.Show("الخصم يجب ان يكون رقم", txt_ELdiscont, 0, 0, visabletime);
                e.Handled = true;
            }
            else
            {
                btn_add.Enabled = true;
            }
        }
        
    }
}
