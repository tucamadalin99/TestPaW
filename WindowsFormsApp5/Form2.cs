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
    public partial class Form2 : Form
    {
        List<Student> list2;
        public Form2(List<Student> list)
        {
            list2 = list;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach(var s in list2)
            {
                ListViewItem itm = new ListViewItem(s.cod.ToString());
                itm.SubItems.Add(s.nume);
                itm.SubItems.Add(s.nota.ToString());
                listView1.Items.Add(itm);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem itm in listView1.Items)
            {
                if (itm.Checked)
                    itm.Remove();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem itm in listView1.Items)
            {
                if (itm.Selected)
                    itm.Remove();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TreeNode parinte = new TreeNode("Student");
            treeView1.Nodes.Add(parinte);
            foreach(Student s in list2)
            {
                TreeNode copil = new TreeNode(s.cod + "-" + s.nume + "-" + s.nota);
                parinte.Nodes.Add(copil);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
           foreach(Student s in list2)
            {
                dataGridView1.Rows.Add(s.cod.ToString(), s.nume, s.nota.ToString());
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(rowIndex);
        }
    }
}
