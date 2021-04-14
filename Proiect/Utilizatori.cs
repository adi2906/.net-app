using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect
{
    public class Utilizatori
    {
        public string nume;
        public int varsta;
        public double cnp;
        public Drept drept;
        public Grup grup;

        public Utilizatori()
        {
            this.nume = "Anonim";
            this.varsta = 0;
            this.cnp = 0;
            this.drept = new Drept();
            this.grup = new Grup();
        }

        public Utilizatori(string nume, int varsta, double cnp, Drept drept, Grup grup)
        {
            this.nume = nume;
            this.varsta = varsta;
            this.cnp = cnp;
            this.drept = drept;
            this.grup = grup;
        }
        public override string ToString()
        {
            return nume + ',' + varsta + ',' + cnp + ',' + drept.nume + ',' + grup.nume;
        }

    }
}
