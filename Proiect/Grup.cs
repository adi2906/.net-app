using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect
{
    public class Grup
    {
        public string nume;

        public Grup()
        {
            this.nume = "Membri";
        }
        public Grup(string nume)
        {
            this.nume = nume;
        }

        public override string ToString()
        {
            return nume;
        }
    }
}
