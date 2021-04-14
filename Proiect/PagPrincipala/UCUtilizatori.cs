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
    public partial class UCUtilizatori : UserControl 
    {
        List<Utilizatori> listaUtilizatori = new List<Utilizatori>();


        public UCUtilizatori()
        {
            InitializeComponent();

        }

        private bool validare()
        {
            if (tbNume.TextLength == 0 || tbCnp.TextLength == 0 || tbVarsta.TextLength == 0)
            {
                if (tbNume.TextLength == 0)
                {
                    errorProvider1.SetError(tbNume, "Introdu date!");
                }
                if (tbCnp.TextLength == 0)
                {
                    errorProvider1.SetError(tbCnp, "Introdu date!");
                }
                if (tbVarsta.TextLength == 0)
                {
                    errorProvider1.SetError(tbVarsta, "Introdu date!");
                }
                return false;
            }
            return true;
        }



        public void btAdaugaUtilizator_Click(object sender, EventArgs e)
        {

            #region JustInCase
            //Utilizatori uz1 = new Utilizatori();
            //uz1.nume = tbNume.Text;
            //uz1.varsta = Convert.ToInt32(tbVarsta.Text);

            //string filePath = @"C:\Visual Studio Proiecte\Proiect\Proiect\test.txt";
            //File.ReadAllLines(filePath);

            //List<string> lines = File.ReadAllLines(filePath).ToList();
            //BUN
            //Utilizatori u = new Utilizatori("", 0, 0);
            //u.nume = tbNume.Text;
            //u.varsta = Convert.ToInt32(tbVarsta.Text);
            //u.cnp = Convert.ToInt32(tbCnp.Text);
            //listaUtilizatori.Add(u);
            //ListViewItem lvi = new ListViewItem(u.nume.ToString());
            //lvi.SubItems.Add(new ListViewItem.ListViewSubItem(lvi, u.varsta.ToString()));
            //lvi.SubItems.Add(new ListViewItem.ListViewSubItem(lvi, u.cnp.ToString()));
            //lvi.Tag = u;
            //listView1.Items.Add(lvi);

            //string filePath = @"C:\Visual Studio Proiecte\Proiect\Proiect\DateUtilizatori.txt";
            //List<Utilizatori> utilizatori = new List<Utilizatori>();
            //List<string> lines = File.ReadAllLines(filePath).ToList();
            //Utilizatori u = new Utilizatori("", 0, 0);
            //u.nume = tbNume.Text;
            //utilizatori.Add(u);
            //foreach (var line in lines)
            //{
            //    string[] entries = line.Split(',');
            //    Utilizatori newUtilizator = new Utilizatori();
            //    u.nume = tbNume.Text = entries[0];
            //    //newUtilizator.nume = entries[0];
            //}




            //de scris (In continuare) DE REZOLVATTT
            //using (StreamWriter writer = new StreamWriter(@"C:\Visual Studio Proiecte\Proiect\Proiect\DateUtilizatori.txt")){

            //    Utilizatori uz1 = new Utilizatori();
            //    uz1.nume = tbNume.Text;
            //    uz1.varsta = Convert.ToInt32(tbVarsta.Text);
            //    uz1.cnp = Convert.ToInt32(tbCnp.Text);

            //    writer.Write(uz1.ToString());

            //    //writer.Close();

            //}
            #endregion

            if (validare())
            {
                FileStream fs = new FileStream("..\\..\\DateUtilizatori.txt", FileMode.Open, FileAccess.ReadWrite);
                fs.Seek(0, SeekOrigin.End);
                StreamWriter sw = new StreamWriter(fs);
                Utilizatori uz1 = new Utilizatori();

                try //pt varsta/cnp+nume 
                {
                    if (tbNume.Text != "")
                    {
                        uz1.nume = tbNume.Text;
                    }

                    if ((uz1.nume == "Anonim") || (uz1.nume.Any(char.IsDigit) == true))
                    {
                        throw new DataException("Nume invalid");
                    }

                    uz1.varsta = Convert.ToInt32(tbVarsta.Text);
                    uz1.cnp = Convert.ToDouble(tbCnp.Text);
                    uz1.drept.nume = cbDrept.SelectedItem.ToString();
                    uz1.grup.nume = cbGrup.SelectedItem.ToString();

                    sw.Write(uz1.ToString());
                    sw.WriteLine();
                    sw.Close();
                    fs.Close();



                    using (StreamReader ReadFile = new StreamReader("..\\..\\DateUtilizatori.txt"))
                    {
                        listView1.Items.Clear();
                        Utilizatori u = new Utilizatori();
                        string rf = ReadFile.ReadLine();
                        while (rf != null)
                        {
                            string[] str = rf.Split(',');
                            listaUtilizatori.Add(u);
                            u.nume = str[0];
                            ListViewItem lvi = new ListViewItem(u.nume.ToString());
                            lvi.SubItems.Add(str[1]);
                            lvi.SubItems.Add(str[2]);
                            rf = ReadFile.ReadLine();
                            listView1.Items.Add(lvi);

                        }
                        ReadFile.Close();
                        ReadFile.Dispose();
                    }
                }
                catch (DataException d)
                {
                    MessageBox.Show(d.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception eroare)
                {
                    MessageBox.Show("Varsta/CNP nu este valid!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                tbNume.Text = "";
                tbVarsta.Text = "";
                tbCnp.Text = "";
                cbDrept.SelectedIndex = 0;
                cbGrup.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("Datele nu sunt valide.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void tbNume_TextChanged(object sender, EventArgs e)
        {

        }

        private void UCUtilizatori_Load(object sender, EventArgs e)
        {
            
            cbDrept.SelectedIndex = 0;
            cbGrup.SelectedIndex = 0;
            

        }
        
       

        private void cbDrept_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
            if ((cbDrept.SelectedItem.ToString() == "Moderator" || cbDrept.SelectedItem.ToString() == "Admin") && cbGrup.SelectedItem.ToString() == "Membri")
            {
                string mesaj = "Un utilizator Moderator/Admin nu poate sa apartina grupului de membri.\nDoriti sa aveti dreptul de 'Membru'?";
                var rezultat = MessageBox.Show(mesaj, "Eroare", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (rezultat == DialogResult.Yes)
                {
                    cbDrept.SelectedItem = "Membru";
                }
                else
                {
                    cbGrup.SelectedItem = "STAFF";
                }
                
            }
        }

        private void cbGrup_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            //eroare staff-membru
            if (cbDrept.SelectedItem.ToString() == "Membru" && cbGrup.SelectedItem.ToString() == "STAFF")
            {
                MessageBox.Show("Un membru nu poate sa apartina STAFF-ului\n Ati fost mutat in categoria 'Membru'", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbGrup.SelectedItem = "Membri";
            }
        }
        //acceleratori
        private void btAdaugaUtilizator_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true && e.KeyCode == Keys.A)
            {
                btAdaugaUtilizator.PerformClick();
            }
        }

        private void UCUtilizatori_KeyDown(object sender, KeyEventArgs e)
        {   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (StreamReader ReadFile = new StreamReader("..\\..\\DateUtilizatori.txt"))
            {
                listView1.Items.Clear();
                Utilizatori u = new Utilizatori();
                string rf = ReadFile.ReadLine();
                while (rf != null)
                {
                    string[] str = rf.Split(',');
                    listaUtilizatori.Add(u);
                    u.nume = str[0];
                    ListViewItem lvi = new ListViewItem(u.nume.ToString());
                    lvi.SubItems.Add(str[1]);
                    lvi.SubItems.Add(str[2]);
                    rf = ReadFile.ReadLine();
                    listView1.Items.Add(lvi);

                }
                ReadFile.Close();
                ReadFile.Dispose();
            }
        }

        //doc
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font fnt = new Font("Trebuchet", 20.0f, FontStyle.Bold);
            Graphics g = e.Graphics;
            int miscareY = 200;
            int miscareX = 50;
            g.DrawString("Nume", fnt, new SolidBrush(Color.DarkBlue), e.MarginBounds.X + miscareX, e.MarginBounds.Y + miscareY - 50);
            g.DrawString("Varsta", fnt, new SolidBrush(Color.DarkBlue), e.MarginBounds.X + miscareX + 150, e.MarginBounds.Y + miscareY - 50);
            g.DrawString("CNP", fnt, new SolidBrush(Color.DarkBlue), e.MarginBounds.X + miscareX + 300, e.MarginBounds.Y + miscareY - 50);
            Bitmap bmp = Properties.Resources.ReteaCalcPRINT;
            e.Graphics.DrawImage(bmp, 25, 25, 690, 198);
            fnt = new Font("Trebuchet", 20.0f, FontStyle.Regular);
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                //g.DrawString(listView1.Items[i].Text, Font, new SolidBrush(Color.Black), e.MarginBounds.X, e.MarginBounds.Y + miscareY);
                for (int j = 0; j < listView1.Items[i].SubItems.Count; j++)
                {
                    g.DrawString(listView1.Items[i].SubItems[j].Text, fnt, new SolidBrush(Color.Black), e.MarginBounds.X +miscareX, e.MarginBounds.Y +miscareY);
                    miscareX += 150;
                }
                miscareX = 50;
                miscareY += 50;
                
            }
        }

        private void btPrint_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void btPrintPreview_Click(object sender, EventArgs e)
        {
            
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cbGrup.Items.Add(textBox1.Text);
            textBox1.Text = "";
        }
    }


        
}

