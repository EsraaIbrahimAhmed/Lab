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
    public partial class ListPriceAfrterDiscouintForDoctors : Form
    {
        BL.Cls_Discounts dis = new BL.Cls_Discounts();
        DataTable dt = new DataTable();
        int s = 1;
        
        public ListPriceAfrterDiscouintForDoctors()
        {
            InitializeComponent();
           
            cb_DoctorName.DataSource = dis.GetContractors(s);
            cb_DoctorName.DisplayMember = "contractor_name";
            cb_DoctorName.ValueMember = "contractor_id";
            dataGridView1.DataSource = dis.GetAnalysisPrice();
        }


        
        public void total(double diss)
        {
           
            for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
            {
                double equation;
                double price, price1;
                price = Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value);
                price1 = price * (diss / 100);
                equation = price - price1;
                dataGridView1.Rows[i].Cells[0].Value = equation.ToString();
           }
        }

        private void btn_calculate_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dis.GetAnalysisPrice();
            double txt = Convert.ToDouble (txt_discountDoctor.Text);
            total(txt);
        }

        private void cb_DoctorName_TextChanged(object sender, EventArgs e)
        {
            try
            {

                dt = dis.GetContractors(s);
                foreach (DataRow row in dt.Rows)
                {
                    if (row["contractor_name"].ToString() == cb_DoctorName.Text)
                    {
                        txt_discountDoctor.Text = row["con_discount"].ToString();

                    }
                }

            }
            catch { MessageBox.Show("الرجاء التأكد من البيانات"); }
        }
    }
}
