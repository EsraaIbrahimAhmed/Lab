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
    public partial class Group_management : Form
    {
        SqlConnection con = new SqlConnection(@"Server=highfix-pc\sara;Database=Lab;Integrated Security=true");
        SqlDataAdapter da;
        DataTable dt = new DataTable();
        BindingManagerBase bmb;
        int id;
        BL.group_management g_m = new BL.group_management();

        public Group_management()
        {
            InitializeComponent();
            da = new SqlDataAdapter("select * from groups", con);
            da.Fill(dt);
            bmb = this.BindingContext[dt];

            if (dt.Rows.Count < 1)
            {
                id = 1;
            }

            else
            {

                id = Convert.ToInt32(dt.Rows[dt.Rows.Count - 1][0]) + 1;
            }
            id_txt.Text = id.ToString();


            cmb_name.DataSource = g_m.Get_all_groups();
            cmb_name.DisplayMember = "group_name";
            cmb_name.ValueMember = "group_id";

           
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                dt = g_m.Search_group(cmb_name.Text);

                foreach (DataRow row in dt.Rows)
                {
                    if (row["group_name"].ToString()== cmb_name.Text)
                    {
                        id_txt.Text=row["group_id"].ToString();
                        analysis_num_txt.Text = row["analysis_num"].ToString();

                    }
                }

            }
            catch

            {
                
               MessageBox.Show("الرجاء التأكد من البيانات");
            }

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {

                g_m.Add_group(cmb_name.Text, Convert.ToInt32(analysis_num_txt.Text));
                MessageBox.Show("تمت اضافة المجموعة بنجاح ! ");
                cmb_name.Text = "";
                analysis_num_txt.Text = "";

            }
            catch(Exception ee)
            {
                MessageBox.Show(ee.Message);
               // MessageBox.Show("الرجاء التأكد من البيانات المدخلة");
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد فعلا حذف هذه المجموعة", "عملية الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                g_m.Delete_group(Convert.ToInt32(id_txt.Text));
                MessageBox.Show("تمت عملية الحذف بنجاح", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("تم الغاء عملية الحذف", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                g_m.Update_group(Convert.ToInt32(id_txt.Text),cmb_name.Text,Convert.ToInt32(analysis_num_txt.Text));
                MessageBox.Show("تم التعديل الطلب بنجاح ! ");

            }
            catch
            {
               
                 MessageBox.Show("الرجاء التأكد من صحة البيانات المدخلة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning); }

            }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            id_txt.Text = "";
            cmb_name.Text = "";
            analysis_num_txt.Text = "";

        }

        private void analysis_num_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar))
            {
                btn_add.Enabled = false;
                int visabletime = 1000;
                ToolTip t1 = new ToolTip();
                t1.Show("عدد التحاليل يجب ان يكون رقم ", analysis_num_txt, 0, 0, visabletime);
                e.Handled = true;
            }
            else
            {
                btn_add.Enabled = true;
            }
        }

       
        }

        
        
    }

