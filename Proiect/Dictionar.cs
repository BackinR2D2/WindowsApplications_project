using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect
{
    internal class Dictionar
    {
        Dictionary<Cuvant, Cuvant> cuvinte;

        public Dictionary<Cuvant, Cuvant> Cuvinte
        {
            get { return cuvinte; }
            set
            {
                if (value.Count() > 0)
                {
                    cuvinte = value;
                }
            }
        }

        public void adaugaTraducere(Cuvant cuvant, Cuvant cuvantTradus)
        {
            cuvinte.Add(cuvant, cuvantTradus);
        }

        public void scrieInFisier()
        {
            string text = "";
            foreach(var item in cuvinte)
            {
                text += item.Key.Tip + "|" + item.Key + "|" + item.Value.Tip + "|" + item.Value + "|" + item.Key.Explicatie + "|" + item.Value.Explicatie + Environment.NewLine;
            }

            File.AppendAllText("dictionar.txt", text);
        }

        public void citesteDinFisier()
        {
            cuvinte.Clear();
            StreamReader reader = File.OpenText("dictionar.txt");
            string linie;
            while((linie = reader.ReadLine()) != null)
            {
                string[] items = linie.Split('|');
                Cuvant tradus = new Cuvant(items[0], items[1], items[4]);
                Cuvant traducere = new Cuvant(items[2], items[3], items[5]);
                cuvinte.Add(tradus, traducere);
            }
        }

        public Dictionar()
        {
            cuvinte = new Dictionary<Cuvant, Cuvant>();
        }

        public Dictionar(Dictionary<Cuvant, Cuvant> cuvinte)
        {
            Cuvinte = cuvinte;
        }

        public override string ToString()
        {
            string rezultat = "";
            foreach (var item in cuvinte)
            {
                rezultat += item.Key + ": " + item.Value + " | " + item.Key.Explicatie + "\n";

            }
            return rezultat;
        }
    }
}
