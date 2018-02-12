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
    public partial class Analysis : Form
    {
        SqlConnection con = new SqlConnection(@"Server=highfix-pc\sara;Database=Lab;Integrated Security=true");
        SqlDataAdapter da;
        DataTable dt = new DataTable();
        BindingManagerBase bmb;
        int id;
        BL.analysis_management a_m = new BL.analysis_management();
        BL.group_management g_m = new BL.group_management();

        public Analysis()
        {

            InitializeComponent();
            da = new SqlDataAdapter("select * from analysis", con);
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
            analysis_id_txt.Text = id.ToString();


            analysis_list_box.DataSource = g_m.Get_all_groups();
            analysis_list_box.DisplayMember = "group_name";
            analysis_list_box.ValueMember = "group_id";

            cmb_name_en.DataSource = a_m.Get_all_analysis();
            cmb_name_en.DisplayMember = "name_en";
            cmb_name_en.ValueMember = "analysis_id";



        }
        //

        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                
                dt = a_m.Search_analysis(cmb_name_en.Text);
                
                foreach (DataRow row in dt.Rows)
                {
                    if (row["name_en"].ToString() == cmb_name_en.Text)
                    {
                        
                        analysis_id_txt.Text = row["analysis_id"].ToString();
                        price_txt.Text=row["analysis_price"].ToString();
                        how_txt.Text=row["how_to_analysis"].ToString();
                        time_txt.Text=row["analysis_time"].ToString();
                        result_txt.Text=row["result"].ToString();
                        notes_txt.Text = row["notes"].ToString();
                        analysis_list_box.Text=row["group_name"].ToString();

                    }
                }

            }
            catch
            {
                //MessageBox.Show(ee.Message);

                MessageBox.Show("الرجاء التأكد من البيانات");
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {


                a_m.Add_analysis(cmb_name_en.Text, price_txt.Text, how_txt.Text, time_txt.Text, result_txt.Text, notes_txt.Text);

                for (int j = 0; j < analysis_list_box.Items.Count; j++)
                {
                    if (analysis_list_box.GetSelected(j) == true)
                    {
                        a_m.add_groups_analysis(analysis_list_box.SelectedValue.ToString(), Convert.ToInt32(analysis_id_txt.Text));
                        analysis_list_box.SetSelected(j, false);  
                    }  
                }



               

                
                MessageBox.Show("تمت اضافة التحليل بنجاح ! ");
                //cmb_group_name.Text = "";
                cmb_name_en.Text = "";
                price_txt.Text = "";
                how_txt.Text = "";
                notes_txt.Text = "";
                time_txt.Text = "";
                result_txt.Text = "";

                cmb_name_en.DataSource = a_m.Get_all_analysis();
                cmb_name_en.DisplayMember = "name_en";

                analysis_id_txt.Text = Convert.ToString(++id);


            }
            catch
            {
                //MessageBox.Show(ee.Message);
               MessageBox.Show("الرجاء التأكد من البيانات المدخلة");
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                ///////error//////
                a_m.Update_analysis(Convert.ToInt32(analysis_id_txt.Text),cmb_name_en.Text,price_txt.Text,how_txt.Text,time_txt.Text, result_txt.Text,notes_txt.Text);
                for (int j = 0; j < analysis_list_box.Items.Count; j++)
                {
                    if (analysis_list_box.GetSelected(j) == true)
                    {
                    
                        a_m.Update_groups_analysis(analysis_list_box.SelectedItem.ToString(), Convert.ToInt32(analysis_id_txt.Text));
                        analysis_list_box.SetSelected(j, false);
                    }
                }
             
                
              
                MessageBox.Show("تم تعديل الطلب بنجاح ! ");

            }
            catch(Exception ee)
            {
                MessageBox.Show(ee.Message);
               // MessageBox.Show("الرجاء التأكد من صحة البيانات المدخلة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            
        }

         //      


        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد فعلا حذف هذا التحليل؟", "عملية الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                a_m.Delete_analysis(Convert.ToInt32(analysis_id_txt.Text));
                MessageBox.Show("تمت عملية الحذف بنجاح", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("تم الغاء عملية الحذف", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }
 //******************************validate numbers*****************************************************************
        private void price_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar))
            {
                btn_add.Enabled = false;
                int visabletime = 1000;
                ToolTip t1 = new ToolTip();
                t1.Show("السعر يجـب ان يكون رقم ", price_txt, 0, 0, visabletime);
                e.Handled = true;
            }
            else
            {
                btn_add.Enabled = true;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
        

      
    }
}
