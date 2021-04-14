using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        

#region Butoane

        // exit
        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //adauga
       
       
        //utilizatori
        private void btUtilizatori_Click(object sender, EventArgs e)
        {
            ucDesen1.Visible = false;
            ucInceput.Visible = false;
            ucGrupuri.Visible = false;
            ucDrepturi1.Visible = false;
            ucUtilizatori.Visible = true;
            ucDataBase1.Visible = false;

        }

        private void btDrepturi_Click(object sender, EventArgs e)
        {
            ucDesen1.Visible = false;
            ucInceput.Visible = false;
            ucGrupuri.Visible = false;
            ucUtilizatori.Visible = false;
            ucDrepturi1.Visible = true;
            ucDataBase1.Visible = false;

        }

        private void btGrupuri_Click(object sender, EventArgs e)
        {
            ucDesen1.Visible = false;
            ucInceput.Visible = false;
            ucDrepturi1.Visible = false;
            ucUtilizatori.Visible = false;
            ucGrupuri.Visible = true;
            ucDataBase1.Visible = false;


        }
        //desen
        private void button1_Click(object sender, EventArgs e)
        {
            ucDesen1.Visible = true;
            ucDataBase1.Visible = false;
            ucInceput.Visible = false;
            ucGrupuri.Visible = false;
            ucDrepturi1.Visible = false;
            ucUtilizatori.Visible = true;


        }
        //DB
        private void button2_Click(object sender, EventArgs e)
        {
            ucDataBase1.Visible = true;
            ucDesen1.Visible = false;
            ucInceput.Visible = false;
            ucGrupuri.Visible = false;
            ucDrepturi1.Visible = false;
            ucUtilizatori.Visible = false;
        }
        #endregion


        private void ucUtilizatori_Load(object sender, EventArgs e)
        {

        }

        private void ucGrupuri_Load(object sender, EventArgs e)
        {

        }

        private void btUtilizatori_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        //acceleratori hotkeys CTRL +1/2/3
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control==true && e.KeyCode == Keys.D1)
            {
                btUtilizatori.PerformClick();
            }
            if (e.Control==true && e.KeyCode == Keys.D2)
            {
                btDrepturi.PerformClick();
            }
            if (e.Control==true && e.KeyCode == Keys.D3)
            {
                btGrupuri.PerformClick();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
// TODO: This line of code loads data into the 'databaseDataSet.Utilizatori' table. You can move, or remove it, as needed.
this.utilizatoriTableAdapter.Fill(this.databaseDataSet.Utilizatori);
            this.KeyPreview = true;
        }

       

        private void utilizatoriBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.utilizatoriBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);

        }

       
    }
}
