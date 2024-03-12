using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect
{
    internal class Explicatie
    {
        string descriere;

        public string Descriere
        {
            get { return descriere; }
            set
            {
                if (value.Length > 10)
                {
                    descriere = value;
                }
            }
        }

        public Explicatie()
        {
            Descriere = "Explicatie inexistenta";
        }

        public Explicatie(string d)
        {
            Descriere = d;
        }

        public override string ToString()
        {
            return Descriere;
        }
    }
}
