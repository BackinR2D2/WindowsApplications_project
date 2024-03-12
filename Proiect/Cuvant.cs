using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect
{
    internal class Cuvant
    {
        string id = Guid.NewGuid().ToString("N"); // Generare string aleator
        string tip;
        string label;
        Explicatie explicatie;

        public string Id => id;

        public string Tip
        {
            get { return tip; }
            set
            {
                if (value.ToLower() == "romana" || value.ToLower() == "engleza" || value.ToLower() == "germana")
                {
                    tip = value;
                }
            }
        }

        public string Label
        {
            get { return label; }
            set
            {
                if (value.Length > 1)
                {
                    label = value;
                }
            }
        }

        public Explicatie Explicatie => explicatie;

        public Cuvant()
        {
            label = "Null";
            explicatie = new Explicatie();
        }

        public Cuvant(string tip, string label, string descriere)
        {
            Tip = tip;
            Label = label;
            explicatie = new Explicatie(descriere);
        }

        public override string ToString()
        {
            return (Label.ToLower());
        }
    }
}
