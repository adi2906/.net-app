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
    public partial class UCDataBase : UserControl
    {
        public UCDataBase()
        {
            InitializeComponent();
            bindingNavigatorAddNewItem.PerformClick();

        }

        private void utilizatoriBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.utilizatoriBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            
        }

        private bool validare()
        {
            if (numeTextBox.TextLength == 0 || varstaTextBox.TextLength == 0 || cNPTextBox.TextLength == 0)
            {
                if (numeTextBox.TextLength == 0)
                {
                    errorProvider1.SetError(numeTextBox, "Introdu date!");
                }
                if (varstaTextBox.TextLength == 0)
                {
                    errorProvider1.SetError(varstaTextBox, "Introdu date!");
                }
                if (cNPTextBox.TextLength == 0)
                {
                    errorProvider1.SetError(cNPTextBox, "Introdu date!");
                }
                return false;
            }
            return true;
        }

        private void btAdaugaUtilizator_Click(object sender, EventArgs e)
        {
            if (validare())
            {
                bindingNavigatorAddNewItem.PerformClick();
            }
            
        }

       

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            bindingNavigatorDeleteItem.PerformClick();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (StreamReader ReadFile = new StreamReader("..\\..\\DateUtilizatori.txt"))
            {
                Utilizatori u = new Utilizatori();
                string rf = ReadFile.ReadLine();
                while (rf != null)
                {

                    string[] str = rf.Split(',');
                    u.nume = str[0];
                    u.varsta = Convert.ToInt32(str[1]);
                    u.cnp = Convert.ToDouble(str[2]);
                    numeTextBox.Text = u.nume;
                    varstaTextBox.Text = Convert.ToString(u.varsta);
                    cNPTextBox.Text = Convert.ToString(u.cnp);
                    bindingNavigatorAddNewItem.PerformClick();
                    rf = ReadFile.ReadLine();
                }
                ReadFile.Close();
                ReadFile.Dispose();
            }
        }
    }
}
