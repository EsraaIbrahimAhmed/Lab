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
    public partial class ListPriceAfrterDiscouintForELabs : Form
    {
        BL.Cls_Discounts dis = new BL.Cls_Discounts();
        DataTable dt = new DataTable();
        int ss = 2;
        public ListPriceAfrterDiscouintForELabs()
        {
            InitializeComponent();
           
            cb_ELabName.DataSource = dis.GetContractors(ss);
            cb_ELabName.DisplayMember = "contractor_name";
            cb_ELabName.ValueMember = "contractor_id";
            dataGridView1.DataSource = dis.GetAnalysisPrice();
        }
        public void total(double diss)
        {

            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
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
            double txt = Convert.ToDouble(txt_discountELab.Text);
            total(txt);
        }

        private void cb_ELabName_TextChanged(object sender, EventArgs e)
        {
            try
            {

                dt = dis.GetContractors(ss);
                foreach (DataRow row in dt.Rows)
                {
                    if (row["contractor_name"].ToString() == cb_ELabName.Text)
                    {
                        txt_discountELab.Text = row["con_discount"].ToString();

                    }
                }

            }
            catch { MessageBox.Show("الرجاء التأكد من البيانات"); }
        }

    }
}
