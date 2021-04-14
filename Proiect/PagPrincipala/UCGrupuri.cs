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
    public partial class UCGrupuri : UserControl
    {
        private ComboBox cbGrup;

        public UCGrupuri()
        {
            InitializeComponent();
        }

        public UCGrupuri(ComboBox cbGrup)
        {
            InitializeComponent();
            this.cbGrup = cbGrup;  
        }

        private void btAdaugaUtilizator_Click(object sender, EventArgs e)
        {
            treeView1.BeginUpdate();
            treeView1.Nodes[0].Nodes.Clear();
            treeView1.Nodes[1].Nodes.Clear();
            treeView1.Nodes[2].Nodes.Clear();
            using (StreamReader ReadFile = new StreamReader("..\\..\\DateUtilizatori.txt"))
            {
                var contor = 0;
                Utilizatori u = new Utilizatori();
                string rf = ReadFile.ReadLine();
                while (rf != null)
                {
                    
                    string[] str = rf.Split(',');
                    u.nume = str[0];
                    if (str[4] == "Membri")
                    {
                        treeView1.Nodes[0].Nodes.Add(u.nume);
                    }
                    else if (str[4] == "STAFF")
                    {
                        treeView1.Nodes[1].Nodes.Add(u.nume);
                    }

                    else if (contor ==0)
                    {
                        
                        //if (treeView1.Nodes[2].Nodes.ContainsKey(str[4]))
                        //{
                        //    //treeView1.Nodes[2].Nodes[contor].Nodes.Add(u.nume);
                        //    MessageBox.Show("AAA");
                        //}

                        treeView1.Nodes[2].Nodes.Add(str[4]);
                        treeView1.Nodes[2].Nodes[contor].Nodes.Add(u.nume);
                        contor++;
                    }
                    else
                    {
                        treeView1.Nodes[2].Nodes.Add(str[4]);
                        treeView1.Nodes[2].Nodes[contor].Nodes.Add(u.nume);
                        contor++;
                        // bool ok = true;
                        // for (int i = 0; i < contor; i++)
                        // {

                        //     if (treeView1.Nodes[2].Nodes[i].Text == "ddd")
                        //     {
                        //         treeView1.Nodes[2].Nodes[i].Nodes.Add(u.nume);
                        //         MessageBox.Show("AAA");
                        //         contor++;
                        //         ok = false;
                        //         break;
                        //     }
                        // }
                        //if (ok ==true)
                        // {
                        //     treeView1.Nodes[2].Nodes.Add(str[4]);
                        //     treeView1.Nodes[2].Nodes[contor].Nodes.Add(u.nume);
                        //     contor++;
                        // }

                    }
                    rf = ReadFile.ReadLine();
                }
                treeView1.EndUpdate();
                
                ReadFile.Close();
                ReadFile.Dispose();
            }
        }
        //stergere
        private void button1_Click(object sender, EventArgs e)
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

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void btAdaugaUtilizator_KeyDown(object sender, KeyEventArgs e)
        {
            //if(e.Control ==true && e.KeyCode.ToString() == "A")
            //{
            //    MessageBox.Show("test");
            //    btAdaugaUtilizator.PerformClick();
            //}
        }

        private void btAdaugaUtilizator_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
           
        }

        private void tbGrup_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
