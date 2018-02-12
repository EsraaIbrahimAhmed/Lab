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
    public partial class list_patient : Form
    {
        BL.CLS_LISTPATIENT cust = new BL.CLS_LISTPATIENT();
        public list_patient()
        {
            InitializeComponent();
            this.dataGridView1.DataSource = cust.GET_List_PATIENT();
        }

    }
}
