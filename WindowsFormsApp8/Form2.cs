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
    public partial class Form2 : Form
    {
        Rezervari rezNou;
        public Form2(Rezervari rez)
        {
            rezNou = rez;
            InitializeComponent();
            foreach(var r in rezNou.ListaHoteluri)
            {
                MessageBox.Show(r.ToString());
            }
        }

        
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TreeNode parinte = new TreeNode("Achitat");
            treeView1.Nodes.Add(parinte);
            foreach (var rez in rezNou.ListaHoteluri)
            {
                float suma = 0;

                for (int i =0; i < rez.PretCamere.Length; i++)
                {
                    suma += rez.PretCamere[i];
                }
                TreeNode copil = new TreeNode(rez.NumeHotel + "-" + rez.NrCamere + "-" + suma);
               // parinte.Nodes.Add(copil);

                TreeNode nepot = new TreeNode("Neachitat");
                treeView1.Nodes.Add(nepot);
                if (suma > 0)
                {
                      nepot.Text = "Achitat";
                    nepot.Nodes.Add(copil);
                }
                else
                {
                    nepot.Text = "Neachitat";
                    nepot.Nodes.Add(copil);
                }
             
            }
        }

        private void stergeElementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreeNode nodSelected = treeView1.SelectedNode;
            try
            {
                treeView1.Nodes.Remove(nodSelected);
                rezNou.ListaHoteluri.RemoveAt(rezNou.ListaHoteluri.Count - 1);
                MessageBox.Show("Element sters din lista si din Tree view!");
            }catch(Exception ex){
                MessageBox.Show(ex.Message);
            }
        }
    }
}
