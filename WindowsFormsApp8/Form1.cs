using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        Rezervari rezervari = new Rezervari(1);
        public Form1()
        {
            InitializeComponent();
        }

        private void tbPreturi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != ','))
                e.Handled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbNume.Text == "")
            {
                errorProvider1.SetError(tbNume, "Nu ati introdus numel!");
            }
            else if (tbNr.Text == "")
            {
                errorProvider1.SetError(tbNr, "Nu ati introdus numarul de camere!");
            }
            else if (tbPreturi.Text == "")
                errorProvider1.SetError(tbPreturi, "Nu ati introdus preturile camerelor!");
            else
            {
                try
                {
                    int nrCamere = Convert.ToInt32(tbNr.Text);
                    string nume = tbNume.Text;
                    string[] strVect = tbPreturi.Text.Split(',');
                    float[] valVect = new float[strVect.Length];
                    for(int i = 0; i < valVect.Length; i++)
                    {
                        valVect[i] = (float)Convert.ToDouble(strVect[i]);
                    }
                    Hotel h = new Hotel(nrCamere, nume, valVect);
                    rezervari = rezervari + h;
                    MessageBox.Show("S-a adaugat un Hotel!");
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    tbNume.Clear();
                    tbNr.Clear();
                    tbPreturi.Clear();
                }
            }
        }

        private void tbNr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != ','))
                e.Handled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2(rezervari);
            frm2.ShowDialog();
        }
    }
}
