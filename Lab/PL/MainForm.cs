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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void انشاءنسخةاحتياطيةToolStripMenuItem_Click(object sender, EventArgs e)  
        {
            Create_Back_UP frm = new Create_Back_UP();
            frm.ShowDialog();
        }

        private void استعادةنسخةاحتياطيةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Restor_Back_UP frm = new Restor_Back_UP();
            frm.ShowDialog();
        }

        private void أطباءToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Doctor frm = new Doctor();
            frm.ShowDialog();
        }

        private void معاملخارجيةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExternalLab frm = new ExternalLab();
            frm.ShowDialog();


        }

        private void toolStripLabel8_Click(object sender, EventArgs e)
        {
            Reservation frm = new Reservation();
            frm.ShowDialog();

        }

       
        private void الموردينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            supplier frm = new supplier();
            frm.ShowDialog();
        }

        private void العاملينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Workers frm = new Workers();
            frm.ShowDialog();
        }

        private void مجموعاترئيسيةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Group_management frm = new Group_management();
            frm.ShowDialog();
        }

        private void تحاليلمنفصلةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Analysis frm = new Analysis();
            frm.ShowDialog();
        }

       
        private void حضوروانصرافToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AttendanceAndDismissal frm = new AttendanceAndDismissal();
            frm.ShowDialog();
        }

       
        private void المتعاقدينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Company frm = new Company();
            frm.ShowDialog();
        }

        private void toolStripLabel9_Click(object sender, EventArgs e)
        {
            ListOfAnalysisPrice frm = new ListOfAnalysisPrice();
            frm.ShowDialog();
        }

        private void normalsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Normals frm = new Normals();
            frm.ShowDialog();
        }

        private void بياناتالمريضToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Patient frm = new Patient();
            frm.ShowDialog();
        }

        private void toolStripLabel10_Click(object sender, EventArgs e)
        {
            result frm = new result();
            frm.ShowDialog();
        }

        private void قائمةالرضىToolStripMenuItem_Click(object sender, EventArgs e)
        {
            list_patient frm = new list_patient();
            frm.ShowDialog();
        }

        

       
      
      
    }
}
