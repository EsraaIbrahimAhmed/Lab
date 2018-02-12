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
    public partial class Doctor : Form
    {
        BL.CLS_CONTRACT D = new BL.CLS_CONTRACT();
        public Doctor()
        {
            InitializeComponent();
            txt_sign.Text = "1";
            this.dgv_allDoctors.DataSource = D.Get_All_Doctors(Convert.ToInt32( txt_sign.Text));
            dgv_allDoctors.Columns[2].Visible = false;
            dgv_allDoctors.Columns[3].Visible = false;
            dgv_allDoctors.Columns[4].Visible = false;
            dgv_allDoctors.Columns[5].Visible = false;
            dgv_allDoctors.Columns[6].Visible = false;
           // dgv_allDoctors.Columns[7].Visible = false;

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgv_allDoctors_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                int i = dgv_allDoctors.CurrentCell.RowIndex;
                txt_DId.Text = dgv_allDoctors.Rows[i].Cells["كود الطبيب "].Value.ToString();
                txt_DName.Text = dgv_allDoctors.Rows[i].Cells["اسم الطبيب"].Value.ToString();
                txt_DSpecilize.Text = dgv_allDoctors.Rows[i].Cells["التخصص"].Value.ToString();
                txt_DAddress.Text = dgv_allDoctors.Rows[i].Cells["العنوان"].Value.ToString();
                txt_DPhone.Text = dgv_allDoctors.Rows[i].Cells["رقم الهاتف"].Value.ToString();
                txt_DMail.Text = dgv_allDoctors.Rows[i].Cells["البريد الالكترونى"].Value.ToString();
                txt_DDiscont.Text = dgv_allDoctors.Rows[i].Cells["نسبة الخصم"].Value.ToString();

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_DName.Text == "" || txt_DSpecilize.Text == "" || txt_DDiscont.Text == "")
                {
                    MessageBox.Show(" !(الرجاء التأكد من ادخال البيانات الاساسية (الاسم-التخصص-الخصم ", "عملية الأضافة", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                   
                }
                else
                {
                    D.Add_CONTRACT(txt_DName.Text, txt_DSpecilize.Text, txt_DAddress.Text, txt_DPhone.Text, txt_DMail.Text, txt_DDiscont.Text, Convert.ToInt32(txt_sign.Text));
                    txt_DName.Text = "";
                    txt_DSpecilize.Text = "";
                    txt_DAddress.Text = "";
                    txt_DPhone.Text = "";
                    txt_DMail.Text = "";
                    txt_DDiscont.Text = "";
                    this.dgv_allDoctors.DataSource = D.Get_All_Doctors(Convert.ToInt32(txt_sign.Text));
                    MessageBox.Show("تمت الأضافة بنجاح ! ");
                }
            }

           catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
           {
                D.UpDate_CONTRACT( txt_DName.Text, txt_DSpecilize.Text, txt_DAddress.Text,
                                txt_DPhone.Text, txt_DMail.Text, txt_DDiscont.Text,Convert.ToInt32(txt_DId.Text));
                txt_DId.Text = "";
                txt_DName.Text = "";
                txt_DSpecilize.Text = "";
                txt_DAddress.Text = "";
                txt_DPhone.Text = "";
                txt_DMail.Text = "";
                txt_DDiscont.Text = "";
                this.dgv_allDoctors.DataSource = D.Get_All_Doctors(Convert.ToInt32(txt_sign.Text));
                MessageBox.Show("تمت تعديل البيانات بنجاح ! ");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد فعلا حذف هذا الطبيب ", "عملية الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                D.delete_CONTRACT(Convert.ToInt32(this.dgv_allDoctors.CurrentRow.Cells[0].Value.ToString()));

                txt_DId.Text = "";
                txt_DName.Text = "";
                txt_DSpecilize.Text = "";
                txt_DAddress.Text = "";
                txt_DPhone.Text = "";
                txt_DMail.Text = "";
                txt_DDiscont.Text = "";
                MessageBox.Show("تمت عملية الحذف بنجاح", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("تم الغاء عملية الحذف", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            this.dgv_allDoctors.DataSource = D.Get_All_Doctors(Convert.ToInt32(txt_sign.Text));
        }

      private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_DName.Text != "" && txt_DSpecilize.Text == "")
                {
                    dgv_allDoctors.DataSource = D.SearchDoctorByName(txt_DName.Text ,Convert.ToInt32(txt_sign.Text));
                }
                else if (txt_DSpecilize.Text != "" && txt_DName.Text == "")
                {
                    dgv_allDoctors.DataSource = D.SearchDoctorBySpecialization(txt_DSpecilize.Text, Convert.ToInt32(txt_sign.Text));
                }
                else
                {
                    this.dgv_allDoctors.DataSource = D.Get_All_Doctors(Convert.ToInt32(txt_sign.Text));
                    MessageBox.Show("عفوا لم يتم العثور على هذا الطبيب برجاء ادخال اسم هذا الطبيب او تخصصه ", "عملية البحث", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex){ MessageBox.Show(ex.Message); }
            
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            this.dgv_allDoctors.DataSource = D.Get_All_Doctors(Convert.ToInt32(txt_sign.Text));
            txt_DId.Text = "";
            txt_DName.Text = "";
            txt_DSpecilize.Text = "";
            txt_DAddress.Text = "";
            txt_DPhone.Text = "";
            txt_DMail.Text = "";
            txt_DDiscont.Text = "";
        }
        //******************************validate letters*****************************************************************
        private void txt_DName_KeyPress(object sender, KeyPressEventArgs e)
        {
       
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsSeparator(e.KeyChar))
            {
                btn_add.Enabled = false;
               // btn_del.Enabled = false;
                btn_search.Enabled = false;
                int visabletime = 1000;
                ToolTip t1 = new ToolTip();
                t1.Show(" الاسم " + "يجـب ان يكون مكون من حروف فقط", txt_DName, 0, 0, visabletime);
                e.Handled = true;
            }
            else
            {
                btn_add.Enabled = true;
                //btn_del.Enabled = true;
                btn_search.Enabled = true;
            }
        
        }
        //******************************validate numbers*****************************************************************
        private void txt_DPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar))
            {
                btn_add.Enabled = false;
                btn_update.Enabled = false;

                int visabletime = 1000; 
                ToolTip t1 = new ToolTip();
                t1.Show("رقم الهاتف لايحتوى عى حروف ", txt_DPhone, 0, 0, visabletime);
                e.Handled = true;
            }
            else
            {
                btn_add.Enabled = true;
                btn_update.Enabled = true;

            }
        }
//********************************************************************************************************
        private void txt_DDiscont_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar))
            {
                btn_add.Enabled = false;
                btn_update.Enabled = false;

                int visabletime = 1000;
                ToolTip t1 = new ToolTip();
                t1.Show("الخصم يجب ان يكون رقم ", txt_DDiscont, 0, 0, visabletime);
                e.Handled = true;
            }
            else
            {
                btn_add.Enabled = true;
                btn_update.Enabled = true;

            }
        }
    }
}