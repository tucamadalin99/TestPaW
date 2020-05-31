using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        List<Student> listStud = new List<Student>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int cod = Convert.ToInt32(tbCod.Text);
                string nume = tbNume.Text;
                int nota = Convert.ToInt32(tbNota.Text);

                listStud.Add(new Student(cod, nume, nota));
                MessageBox.Show("Adaugat");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                tbCod.Clear();
                tbNume.Clear();
                tbNota.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2(listStud);
            frm2.ShowDialog();
        }
    }
}
