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
    public partial class ListOfAnalysisPrice : Form
    {
        BL.Cls_Discounts dis = new BL.Cls_Discounts();
        DataTable dt = new DataTable();
        public ListOfAnalysisPrice()
        {
            InitializeComponent();
            dataGridView1.DataSource = dis.GetAnalysisPrice();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DoctorDis_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ListPriceAfrterDiscouintForDoctors frm = new ListPriceAfrterDiscouintForDoctors();
            frm.ShowDialog();
        }

        private void ELabDis_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ListPriceAfrterDiscouintForELabs frm = new ListPriceAfrterDiscouintForELabs();
            frm.ShowDialog();
        }

        private void ContractorDis_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ListPriceAfrterDiscouintForContractors frm = new ListPriceAfrterDiscouintForContractors();
            frm.ShowDialog();
        }

        
    }
}
