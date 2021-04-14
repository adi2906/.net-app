using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Proiect.PagPrincipala
{
    public partial class UCDrepturi : UserControl
    {
        public UCDrepturi()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //treeView1.Nodes[0].Nodes.Add("test");

           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btAdaugaUtilizator_Click(object sender, EventArgs e)
        {
            treeView1.Nodes[0].Nodes.Clear();
            treeView1.Nodes[1].Nodes.Clear();
            treeView1.Nodes[2].Nodes.Clear();

            using (StreamReader ReadFile = new StreamReader(@"..\\..\\DateUtilizatori.txt"))
            {
                Utilizatori u = new Utilizatori();
                string rf = ReadFile.ReadLine();
                while (rf != null)
                {
                    string[] str = rf.Split(',');
                    u.nume = str[0];
                    if (str[3] == "Membru")
                    {
                        treeView1.Nodes[0].Nodes.Add(u.nume);
                    }
                    if (str[3] == "Moderator")
                    {
                        treeView1.Nodes[1].Nodes.Add(u.nume);
                    }
                    if (str[3] == "Admin")
                    {
                        treeView1.Nodes[2].Nodes.Add(u.nume);
                    }
                    rf = ReadFile.ReadLine();

                }
                ReadFile.Close();
                ReadFile.Dispose();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (treeView1.Nodes[0].IsSelected || treeView1.Nodes[1].IsSelected || treeView1.Nodes[2].IsSelected)
                {
                    MessageBox.Show("Nodul acesta nu poate fi sters. Pot fi sterse persoanele din grupul respectiv");
                }
                else
                {
                    treeView1.SelectedNode.Remove();
                }
            }
            catch
            {
                MessageBox.Show("Niciun nod nu a fost selectat");
            }
        }

        private void UCDrepturi_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void treeView1_DragEnter(object sender, DragEventArgs e)
        {
            
        }

        private void listBox1_DragEnter(object sender, DragEventArgs e)
        {
            
        }

        private void utilizatoriBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.utilizatoriBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);

        }
    }
}
