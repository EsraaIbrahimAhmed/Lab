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
    public partial class Reservation : Form
    {

        SqlConnection con = new SqlConnection(@"Server=highfix-pc\sara;Database=Lab;Integrated Security=true");
        SqlDataAdapter da;
        DataTable dt = new DataTable();
        DataTable dt2 = new DataTable();
        BindingManagerBase bmb;
        int id;
        BL.group_management g_m = new BL.group_management();
        BL.CLS_PATIENT p = new BL.CLS_PATIENT();
        BL.analysis_management a_m = new BL.analysis_management();
        BL.Cls_Reservation r = new BL.Cls_Reservation();
        BL.Cls_Reservation r2 = new BL.Cls_Reservation();
        Patient pp = new Patient();
        int i = 0;
        double total = 0.0;
        double dis = 0.0;
        double total_after = 0.0;
        double paid = 0.0;
        double rest = 0.0;



        public Reservation()
        {
            InitializeComponent();
            total_txt.Text = "0";
            dis_txt.Text = "0";
            da = new SqlDataAdapter("select * from reservation", con);
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


            cmb_group.DataSource = g_m.Get_all_groups();
            cmb_group.DisplayMember = "group_name";
            cmb_group.ValueMember = "group_id";


            cmb_patient.DataSource = p.GET_ALL_PATIENT5();
            cmb_patient.DisplayMember = "patient_name";
            cmb_patient.ValueMember = "patient_id";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            cmb_patient.DataSource = null;
            cmb_patient.Items.Clear();
            pp.ShowDialog();
            cmb_patient.DataSource = p.GET_ALL_PATIENT5();
            cmb_patient.DisplayMember = "patient_name";
        }


        private void btn_Calcu_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                total = Convert.ToDouble(total_txt.Text) + Convert.ToDouble(dataGridView1.Rows[i].Cells[2].Value);
                total_txt.Text = total.ToString();
                dis = Convert.ToDouble(dis_txt.Text);
                total_after = total - ((total * dis) / 100);
                price_after_txt.Text = total_after.ToString();


            }



        }

        private void cmb_patient_SelectedValueChanged(object sender, EventArgs e)
        {
            dt2 = r.select_patient(cmb_patient.Text);
            foreach (DataRow row in dt2.Rows)
            {
                p_id_txt.Text = row[0].ToString();
                con_txt.Text = row[1].ToString();
                dis_txt.Text = row[2].ToString();
            }
        }

        private void cmb_group_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cmb_analysis.DataSource = r.select_group(cmb_group.Text);
            cmb_analysis.DisplayMember = "name_en";
            cmb_analysis.ValueMember = "analysis_id";
            
        }


        private void cmb_analysis_KeyPress(object sender, KeyPressEventArgs e)
        {
            dt = r.select_analysis(cmb_analysis.Text,cmb_group.Text);
            foreach (DataRow dr in dt.Rows)
            {
                String[] row = new String[3];
                row[0] = dr[0].ToString();
                row[1] = dr[1].ToString();
                row[2] = dr[2].ToString();
                dataGridView1.Rows.Add(row);
                i++;
            }
        }

      
        private void rest_txt_Click(object sender, EventArgs e)
        {
            total_after = Convert.ToDouble(price_after_txt.Text);
            paid = Convert.ToDouble(paid_txt.Text);
            rest = total_after - paid;
            rest_txt.Text = rest.ToString();
        }

        private void paid_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar))
            {
                // btn_add.Enabled = false;
                int visabletime = 1000;
                ToolTip t1 = new ToolTip();
                t1.Show("العمر يجب ان يكون رقم ", paid_txt, 0, 0, visabletime);
                e.Handled = true;
            }
            else
            {
                // btn_add.Enabled = true;
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {

                r.add_reservation(dateTimePicker1.Value.Date.ToString("yyyy-MM-dd HH:mm"), Convert.ToInt32(p_id_txt.Text), doc_txt.Text, Convert.ToDouble(total_txt.Text), Convert.ToDouble(dis_txt.Text), Convert.ToDouble(price_after_txt.Text), Convert.ToDouble(paid_txt.Text), Convert.ToDouble(rest_txt.Text));
                for (int j = 0; j < dataGridView1.Rows.Count - 1; j++)
                {

                    r2.add_reservation_analysis(Convert.ToInt32(id_txt.Text), dataGridView1.Rows[j].Cells[1].Value.ToString());
                }
                MessageBox.Show("تمت اضافة المجموعة بنجاح ! ");


            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
                
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {

        }

        

        private void cmb_analysis_MouseEnter(object sender, EventArgs e)
        {

        }

        
       
    }
}






