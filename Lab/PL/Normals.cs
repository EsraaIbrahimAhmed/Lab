using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient
;

namespace Lab.PL
{
    public partial class Normals : Form
    {

        SqlConnection con = new SqlConnection(@"Server=highfix-pc\sara;Database=Lab;Integrated Security=true");
        SqlDataAdapter da;
        DataTable dt = new DataTable();
        BindingManagerBase bmb;
        int id;
        BL.group_management g_m = new BL.group_management();
        BL.Cls_Normals n = new BL.Cls_Normals();

        public Normals()
        {
            InitializeComponent();
            dataGridView1.DataSource = n.GetAllNormals();
            da = new SqlDataAdapter("select * from normals", con);
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


            cmb_name_en.DataSource = n.Get_all_analysis();
            cmb_name_en.DisplayMember = "name_en";
            cmb_name_en.ValueMember = "analysis_id";

           
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {

                n.Add_normal(cmb_name_en.Text,Convert.ToInt32(age_from_txt.Text),cmb_unit_from.Text,Convert.ToInt32(age_to_txt.Text),cmb_unit_to.Text, cmb_gender.Text, normal_txt.Text,normal_unit_txt.Text);
                dataGridView1.DataSource = n.GetAllNormals();
                MessageBox.Show("Normal added ");
               
            }
            catch(Exception ee)
            {
                MessageBox.Show(ee.Message);
               // MessageBox.Show("الرجاء التأكد من البيانات المدخلة");
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Delete Normal?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                n.Delete_normal(Convert.ToInt32(id_txt.Text));
                dataGridView1.DataSource = n.GetAllNormals();
               
                MessageBox.Show("Normal deleted", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Delete canceled", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                n.Update_normal(Convert.ToInt32(id_txt.Text),cmb_name_en.Text,Convert.ToInt32(age_from_txt.Text),cmb_unit_from.Text,Convert.ToInt32(age_to_txt.Text),cmb_unit_to.Text, cmb_gender.Text,normal_txt.Text,normal_unit_txt.Text);
                dataGridView1.DataSource = n.GetAllNormals();
                MessageBox.Show("تم التعديل بنجاح ! ");

            }
            catch
            {

                MessageBox.Show("الرجاء التأكد من صحة البيانات المدخلة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
               dt=n.Search_normal(cmb_name_en.Text);
               dataGridView1.DataSource = dt;

            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }

            
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                int i = dataGridView1.CurrentCell.RowIndex;
                id_txt.Text = dataGridView1.Rows[i].Cells["الكود"].Value.ToString();
                cmb_name_en.Text = dataGridView1.Rows[i].Cells["اسم التحليل"].Value.ToString();
                age_from_txt.Text = dataGridView1.Rows[i].Cells["العمر من"].Value.ToString();
                cmb_unit_from.Text = dataGridView1.Rows[i].Cells["الوحدة من"].Value.ToString();
                age_to_txt.Text = dataGridView1.Rows[i].Cells["الى العمر"].Value.ToString();
                cmb_unit_to.Text = dataGridView1.Rows[i].Cells["الوحدة إلى"].Value.ToString();
                cmb_gender.Text = dataGridView1.Rows[i].Cells["النوع"].Value.ToString();
                normal_txt.Text = dataGridView1.Rows[i].Cells["Normal"].Value.ToString();
                normal_unit_txt.Text=dataGridView1.Rows[i].Cells["Normal Unit"].Value.ToString();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
                id_txt.Text = "";
                cmb_name_en.Text = "";
                age_from_txt.Text = "";
                cmb_unit_from.Text = "";
                age_to_txt.Text = "";
                cmb_unit_to.Text = "";
                cmb_gender.Text ="";
                normal_txt.Text = "";
                normal_unit_txt.Text = "";
        }

        private void age_from_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
             if (!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar))
            {
                btn_add.Enabled = false;
                int visabletime = 1000;
                ToolTip t1 = new ToolTip();
                t1.Show("العمر يجب ان يكون رقم", age_from_txt, 0, 0, visabletime);
                e.Handled = true;
            }
            else
            {
                btn_add.Enabled = true;
            }
        }

        private void age_to_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar))
            {
                btn_add.Enabled = false;
                int visabletime = 1000;
                ToolTip t1 = new ToolTip();
                t1.Show("العمر يجب ان يكون رقم ", age_to_txt, 0, 0, visabletime);
                e.Handled = true;
            }
            else
            {
                btn_add.Enabled = true;
            }  
        }
   }

       
}

