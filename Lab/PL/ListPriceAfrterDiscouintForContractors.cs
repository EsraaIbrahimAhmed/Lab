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
    public partial class ListPriceAfrterDiscouintForContractors : Form
    {
        BL.Cls_Discounts dis = new BL.Cls_Discounts();
        DataTable dt = new DataTable();
        int sss = 3;

        public ListPriceAfrterDiscouintForContractors()
        {
            InitializeComponent();
           
            cb_ContractorsName.DataSource = dis.GetContractors(sss);
            cb_ContractorsName.DisplayMember = "contractor_name";
            cb_ContractorsName.ValueMember = "contractor_id";
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
            double txt = Convert.ToDouble(txt_discountContractors.Text);
            total(txt);
        }

        private void cb_ContractorsName_TextChanged(object sender, EventArgs e)
        {
            try
            {

                dt = dis.GetContractors(sss);
                foreach (DataRow row in dt.Rows)
                {
                    if (row["contractor_name"].ToString() == cb_ContractorsName.Text)
                    {
                        txt_discountContractors.Text = row["con_discount"].ToString();

                    }
                }

            }
            catch { MessageBox.Show("الرجاء التأكد من البيانات"); }
        }
    }
}
