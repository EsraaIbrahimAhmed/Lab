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
    public partial class PRINT : Form
    {
        /* string id;
         string gender;
         string age;
         string name;
         string group;
         string doctor;
         DateTime date;*/
        public PRINT()
        {
            InitializeComponent();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            StringFormat format = new StringFormat(StringFormatFlags.DirectionRightToLeft);
           

            // e.Graphics.DrawString(label1.Text, new Font("Arial", 30, FontStyle.Bold), Brushes.Black, new Point(400, 90));
            e.Graphics.DrawString("الاسم" + ":" + com_name.Text, new Font("Arial", 15, FontStyle.Bold), Brushes.Black, 800, 180, format);
            e.Graphics.DrawString("التاريخ" + ":" + txt_date.Value.ToString("yyyy/MM/dd"), new Font("Arial", 15, FontStyle.Bold), Brushes.Black, 800, 250, format);
            e.Graphics.DrawString("الدكتور المعالج" + ": أ.د /" + txt_doc.Text, new Font("Arial", 15, FontStyle.Bold), Brushes.Black, 800, 320, format);//390

            e.Graphics.DrawString("ID" + ":" + txt_id.Text, new Font("Arial", 15, FontStyle.Bold), Brushes.Black, 80, 180);//320
            e.Graphics.DrawString("Gender" + ":"/*+txt_gender*/+ txt_gender.Text, new Font("Arial", 15, FontStyle.Bold), Brushes.Black, 80, 250);
            e.Graphics.DrawString("Age" + ":"/*+txt_age*/+ txt_age.Text, new Font("Arial", 15, FontStyle.Bold), Brushes.Black, 80, 320);

            e.Graphics.DrawLine(new Pen(Color.Black, 2), 50, 400, 800, 400);

            string group = dataGridView2.Rows[0].Cells[0].Value.ToString();
            e.Graphics.DrawString(group, new Font("Arial", 30, FontStyle.Underline), Brushes.Black, 500, 400);//460

            e.Graphics.DrawString("Ref.renge", new Font("Arial", 10, FontStyle.Underline), Brushes.Black, 600, 470);
            /*  for(int i= 0;i<dataGridView2.Rows.Count ; i++)
              {
                  if (dataGridView2.Rows[i].Cells[0].Value.ToString() == group)
                  {*/
            foreach (int i in dataGridView2.Rows.Count.ToString())
            {
                if (dataGridView2.Rows[i].Cells[0].Value.Equals(group))
                {
                    string analysis = dataGridView2.Rows[i].Cells[1].Value.ToString();
                    e.Graphics.DrawString(analysis, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, 80, 500);

                    string result = dataGridView2.Rows[i].Cells[3].Value.ToString();
                    e.Graphics.DrawString(result, new Font("Arial", 15, FontStyle.Bold), Brushes.Black, 400, 500);

                    e.Graphics.DrawString("pg", new Font("Arial", 10, FontStyle.Italic), Brushes.Black, 500, 500);

                    string normal = dataGridView2.Rows[i].Cells[2].Value.ToString();
                    e.Graphics.DrawString(normal, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, 600, 500);
                }
            }
            if (group == "cbc")
            {
                e.Graphics.DrawString("Different white cell count", new Font("Arial", 15, FontStyle.Underline), Brushes.Black, 80, 550);
                e.Graphics.DrawString("Relative", new Font("Arial", 10, FontStyle.Underline), Brushes.Black, 300, 600);
                e.Graphics.DrawString("Absolute", new Font("Arial", 10, FontStyle.Underline), Brushes.Black, 600, 600);
                e.Graphics.DrawString("Result %", new Font("Arial", 10, FontStyle.Underline), Brushes.Black, 200, 620);
                e.Graphics.DrawString("Normal", new Font("Arial", 10, FontStyle.Underline), Brushes.Black, 400, 620);
                e.Graphics.DrawString("Result /cmm", new Font("Arial", 10, FontStyle.Underline), Brushes.Black, 500, 620);
                e.Graphics.DrawString("Normal", new Font("Arial", 10, FontStyle.Underline), Brushes.Black, 650, 620);
                e.Graphics.DrawString("Neutrophils", new Font("Arial", 10, FontStyle.Italic), Brushes.Black, 100, 640);
                e.Graphics.DrawString("Bands", new Font("Arial", 10, FontStyle.Italic), Brushes.Black, 120, 660);
                e.Graphics.DrawString("Segmented", new Font("Arial", 10, FontStyle.Italic), Brushes.Black, 120, 680);
                e.Graphics.DrawString("Lymphocytes", new Font("Arial", 10, FontStyle.Italic), Brushes.Black, 100, 700);
                e.Graphics.DrawString("Monocytes", new Font("Arial", 10, FontStyle.Italic), Brushes.Black, 100, 720);
                e.Graphics.DrawString("Eosinophils", new Font("Arial", 10, FontStyle.Italic), Brushes.Black, 100, 740);
                e.Graphics.DrawString("Basophils", new Font("Arial", 10, FontStyle.Italic), Brushes.Black, 100, 760);

                /* string result = dataGridView2.Rows[0].Cells[3].Value.ToString();
                 e.Graphics.DrawString(result, new Font("Arial", 15, FontStyle.Bold), Brushes.Black, 400, 500);
  */


            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pageSetupDialog1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();
        }

        private void PRINT_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
