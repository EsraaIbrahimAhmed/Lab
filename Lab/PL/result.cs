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
    public partial class result : Form
    {
        BL.CLS_PATIENT p = new BL.CLS_PATIENT();
        BL.Cls_result res = new BL.Cls_result();
        DataTable dt = new DataTable();
        DataTable dt2 = new DataTable();
        int i = 0;
        public result()
        {
            InitializeComponent();

            cmb_patient.DataSource = p.GET_ALL_PATIENT5();
            cmb_patient.DisplayMember = "patient_name";
            cmb_patient.ValueMember = "patient_id";
        }

        private void cmb_patient_SelectedValueChanged(object sender, EventArgs e)
        {
            dt_patient.Controls.Clear();

            dt = res.select_patient_reservation(cmb_patient.Text);
            foreach (DataRow dr in dt.Rows)
            {
                String[] row = new String[2];
                row[0] = dr[1].ToString();
                row[1] = dr[0].ToString();
                dt_patient.Controls.Clear();
                dt_patient.Rows.Add(row);
                i++;
            }
        }

        private void dt_patient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id_txt.Text = dt_patient.CurrentCell.Value.ToString();
            dt = res.select_analysis_patient(Convert.ToInt32(dt_patient.CurrentCell.Value));
            foreach (DataRow row in dt.Rows)
            {
                con_txt.Text = row[0].ToString();
                age_txt.Text = row[1].ToString();
                gender_txt.Text = row[2].ToString();
                date_txt.Text = row[3].ToString();
                doctor_txt.Text = row[4].ToString();
            }
            cmb_groups.DataSource = res.select_group_patient(Convert.ToInt32(dt_patient.CurrentCell.Value));
            cmb_groups.DisplayMember = "group_name";

        }
        private void cmb_groups_SelectedValueChanged(object sender, EventArgs e)
        {
            dt_result.Rows.Clear();
            dt2 = res.select_group_analysis_normal(cmb_groups.Text, Convert.ToInt32(id_txt.Text));
            foreach (DataRow dr in dt2.Rows)
            {
                String[] row = new String[5];
                row[0] = dr[0].ToString();
                row[1] = dr[1].ToString();
                row[2] = dr[2].ToString();
                row[4] = dr[3].ToString();

                dt_result.Rows.Add(row);
                i++;
            }

        }

        private void btn_preview_Click(object sender, EventArgs e)
        {
            ////
            try
            {
                for (int i = 0; i < dt_result.Rows.Count - 1; i++)
                {

                    res.add_result(Convert.ToInt32(id_txt.Text), dt_result.Rows[i].Cells[1].Value.ToString(), Convert.ToString(dt_result.Rows[i].Cells[3].Value), Convert.ToString(dt_result.Rows[i].Cells[2].Value), comment.Text, other.Text);
                    MessageBox.Show("تم حفظ النتيجة");
                }


            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
                // MessageBox.Show("الرجاء التأكد من البيانات المدخلة");
            }
            ////
            printPreviewDialog1.ShowDialog();

        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();
        }
        string group;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            StringFormat format = new StringFormat(StringFormatFlags.DirectionRightToLeft);

            e.Graphics.DrawString("الاسم" + ":" + cmb_patient.Text, new Font("Arial", 15, FontStyle.Bold), Brushes.Black, 800, 180, format);
            e.Graphics.DrawString("التاريخ" + ":" + date_txt.Text, new Font("Arial", 15, FontStyle.Bold), Brushes.Black, 800, 210, format);

            if (doctor_txt.Text != "")
                e.Graphics.DrawString("الدكتور المعالج" + ": أ.د /" + doctor_txt.Text, new Font("Arial", 15, FontStyle.Bold), Brushes.Black, 800, 240, format);//390

            e.Graphics.DrawString("ID" + ":" + id_txt.Text, new Font("Arial", 15, FontStyle.Bold), Brushes.Black, 80, 180);//320
            e.Graphics.DrawString("Gender" + ":" + gender_txt.Text, new Font("Arial", 15, FontStyle.Bold), Brushes.Black, 80, 210);
            e.Graphics.DrawString("Age" + ":" + age_txt.Text, new Font("Arial", 15, FontStyle.Bold), Brushes.Black, 80, 240);

            e.Graphics.DrawLine(new Pen(Color.Black, 2), 50, 280, 800, 280);
            e.Graphics.DrawString("Test Name", new Font("Arial", 15, FontStyle.Underline), Brushes.Black, 110, 360);
            e.Graphics.DrawString("Result", new Font("Arial", 15, FontStyle.Underline), Brushes.Black, 410, 360);
            e.Graphics.DrawString("Ref.renge", new Font("Arial", 15, FontStyle.Underline), Brushes.Black, 650, 360);

            group = dt_result.Rows[0].Cells[0].Value.ToString();
            e.Graphics.DrawString(group, new Font("Tahoma", 30, FontStyle.Underline), Brushes.Black, 300, 290);

            int x = 390, y = 100, c = dt_result.Rows.Count - 1, row = 0;
            for (int z = 0; z < dt_result.Rows.Count - 1; z++)
            {
                string analysis = dt_result.Rows[z].Cells[1].Value.ToString();
                string result = dt_result.Rows[z].Cells[3].Value.ToString();
                string normal = dt_result.Rows[z].Cells[2].Value.ToString();


                if (group == "cbc" && c != 1)
                {
                    e.Graphics.DrawString("Different white cell count", new Font("Arial", 15, FontStyle.Underline), Brushes.Black, 80, 630);
                    e.Graphics.DrawString("Relative", new Font("Arial", 10, FontStyle.Underline), Brushes.Black, 430, 660);
                    e.Graphics.DrawString("Absolute", new Font("Arial", 10, FontStyle.Underline), Brushes.Black, 680, 660);
                    e.Graphics.DrawString("Result %", new Font("Arial", 10, FontStyle.Underline), Brushes.Black, 360, 690);
                    e.Graphics.DrawString("Normal", new Font("Arial", 10, FontStyle.Underline), Brushes.Black, 500, 690);
                    e.Graphics.DrawString("Result /cmm", new Font("Arial", 10, FontStyle.Underline), Brushes.Black, 600, 690);
                    e.Graphics.DrawString("Normal", new Font("Arial", 10, FontStyle.Underline), Brushes.Black, 750, 690);
                    if (comment.Text != "")
                    {
                        e.Graphics.DrawString("comment", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, 360, 920);
                        e.Graphics.DrawString(comment.Text, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, 360, 920);
                    }
                }
                int x2 = 630;
                if (group == "cbc" && analysis == "Neutrophils")
                {
                    int n = (Convert.ToInt32(result) * 136);
                    string ns = n.ToString();
                    e.Graphics.DrawString("Neutrophils", new Font("Arial", 10, FontStyle.Italic), Brushes.Black, 140, x2 + 90);
                    e.Graphics.DrawString(result, new Font("Arial", 15, FontStyle.Bold), Brushes.Black, 360, x2 + 90);
                    e.Graphics.DrawString(normal, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, 500, x2 + 90);
                    e.Graphics.DrawString(ns, new Font("Arial", 15, FontStyle.Bold), Brushes.Black, 600, x2 + 90);
                    e.Graphics.DrawString("2500 - 7200", new Font("Arial", 10, FontStyle.Underline), Brushes.Black, 730, x2 + 90);

                }
                else if (group == "cbc" && analysis == "Bands")
                {
                    e.Graphics.DrawString("Bands", new Font("Arial", 10, FontStyle.Italic), Brushes.Black, 160, x2 + 120);
                    e.Graphics.DrawString(result, new Font("Arial", 15, FontStyle.Bold), Brushes.Black, 360, x2 + 120);
                }
                else if (group == "cbc" && analysis == "Segmented")
                {
                    e.Graphics.DrawString("Segmented", new Font("Arial", 10, FontStyle.Italic), Brushes.Black, 160, x2 + 150);
                    e.Graphics.DrawString(result, new Font("Arial", 15, FontStyle.Bold), Brushes.Black, 360, x2 + 150);
                }


                else if (group == "cbc" && analysis == "Lymphocytes")
                {
                    int l = Convert.ToInt32(result) * 136;
                    string ls = l.ToString();
                    e.Graphics.DrawString("Lymphocytes", new Font("Arial", 10, FontStyle.Italic), Brushes.Black, 140, x2 + 180);
                    e.Graphics.DrawString(result, new Font("Arial", 15, FontStyle.Bold), Brushes.Black, 360, x2 + 180);
                    e.Graphics.DrawString(normal, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, 500, x2 + 180);
                    e.Graphics.DrawString(ls, new Font("Arial", 15, FontStyle.Bold), Brushes.Black, 600, x2 + 180);
                    e.Graphics.DrawString("2500 - 9000", new Font("Arial", 10, FontStyle.Underline), Brushes.Black, 730, x2 + 180);
                }
                else if (group == "cbc" && analysis == "Monocytes")
                {
                    int m = Convert.ToInt32(result) * 136;
                    string ms = m.ToString();
                    e.Graphics.DrawString("Monocytes", new Font("Arial", 10, FontStyle.Italic), Brushes.Black, 140, x2 + 210);
                    e.Graphics.DrawString(result, new Font("Arial", 15, FontStyle.Bold), Brushes.Black, 360, x2 + 210);
                    e.Graphics.DrawString(normal, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, 500, x2 + 210);
                    e.Graphics.DrawString(ms, new Font("Arial", 15, FontStyle.Bold), Brushes.Black, 600, x2 + 210);
                    e.Graphics.DrawString("100 - 1200", new Font("Arial", 10, FontStyle.Underline), Brushes.Black, 730, x2 + 210);


                }
                else if (group == "cbc" && analysis == "Eosinophils")
                {
                    int eo = Convert.ToInt32(result) * 136;
                    string eos = eo.ToString();
                    e.Graphics.DrawString("Eosinophils", new Font("Arial", 10, FontStyle.Italic), Brushes.Black, 140, x2 + 240);
                    e.Graphics.DrawString(result, new Font("Arial", 15, FontStyle.Bold), Brushes.Black, 360, x2 + 240);
                    e.Graphics.DrawString(normal, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, 500, x2 + 240);
                    e.Graphics.DrawString(eos, new Font("Arial", 15, FontStyle.Bold), Brushes.Black, 600, x2 + 240);
                    e.Graphics.DrawString("40 - 400", new Font("Arial", 10, FontStyle.Underline), Brushes.Black, 730, x2 + 240);
                }
                else if (group == "cbc" && analysis == "Basophils")
                {
                    int b = Convert.ToInt32(result) * 136;
                    string bs = b.ToString();
                    e.Graphics.DrawString("Basophils", new Font("Arial", 10, FontStyle.Italic), Brushes.Black, 140, x2 + 270);
                    e.Graphics.DrawString(result, new Font("Arial", 15, FontStyle.Bold), Brushes.Black, 360, x2 + 270);
                    e.Graphics.DrawString(normal, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, 500, x2 + 270);
                    e.Graphics.DrawString(bs, new Font("Arial", 15, FontStyle.Bold), Brushes.Black, 600, x2 + 270);
                    e.Graphics.DrawString("0 - 150", new Font("Arial", 10, FontStyle.Underline), Brushes.Black, 730, x2 + 270);
                }
                else
                {
                    e.Graphics.DrawString(analysis, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, y, x);

                    string unit = dt_result.Rows[z].Cells[4].Value.ToString();
                    e.Graphics.DrawString(unit, new Font("Arial", 15, FontStyle.Italic), Brushes.Black, y + 350, x);


                    e.Graphics.DrawString(normal, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, y + 550, x);
                    // test normal
                    if (group == "urine" || group == "stool analysis")
                    {
                        e.Graphics.DrawString(result, new Font("Arial", 15, FontStyle.Bold), Brushes.Black, y + 300, x);
                    }
                    else
                    {
                        int j = 0;
                        string low = "";
                        string high = "";
                        for (int i = 0; i < normal.Length; i++)
                        {
                            if (normal[i].Equals('-'))
                                break;
                            else
                                low += normal[i];
                        }

                        norm(normal, ref j);
                        for (int k = j + 1; k < normal.Length; k++)
                        { high += normal[k]; }

                        int lo = Convert.ToInt32(low);
                        int h = Convert.ToInt32(high);
                        int r = Convert.ToInt32(result);
                        if (r < lo || r > h)
                        { e.Graphics.DrawString(result + "*", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, y + 300, x); }
                        else
                        {
                            e.Graphics.DrawString(result, new Font("Arial", 15, FontStyle.Bold), Brushes.Black, y + 300, x);
                        }
                    }

                    x += 30;
                    row++;
                }

                if (comment.Text != "")
                {
                    e.Graphics.DrawString("comment", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, y, x + 100);
                    e.Graphics.DrawString(comment.Text, new Font("Arial", 15, FontStyle.Bold), Brushes.Black, y + 300, x + 100);
                }
                if (other.Text != "" && (group == "urine" || group == "stool analysis"))
                {
                    e.Graphics.DrawString("other", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, y, x + 200);
                    e.Graphics.DrawString(other.Text, new Font("Arial", 15, FontStyle.Bold), Brushes.Black, y + 300, x + 200);
                }

            }
        }
        public static void norm(string s, ref int j)
        {
            for (int i = 0; i < s.Length; i++)
            {
                //low += normal[i];
                if (s[i].Equals('-'))
                {
                    j = i;
                    break;
                }
            }
        }
    }
}