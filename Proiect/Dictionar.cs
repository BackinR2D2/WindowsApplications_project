using Microsoft.SqlServer.Server;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

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

        public void adaugaTraducere(Cuvant cuvantTradus, Cuvant traducere)
        {
            cuvinte.Add(cuvantTradus, traducere);
            //string traducereString = cuvantTradus.Tip + "|" + cuvantTradus + "|" + traducere.Tip + "|" + traducere + "|" + cuvantTradus.Explicatie + "|" + traducere.Explicatie + Environment.NewLine;
            //File.AppendAllText("dictionar.txt", traducereString);
        }

        public void stergeDinFisier(string[] element) 
        {
            //cuvinte.Clear();
            //StreamReader reader = File.OpenText("dictionar.txt");
            //string linie;
            //string text = "";
            //int NR_COLOANE = 6;
            //while ((linie = reader.ReadLine()) != null)
            //{
            //    string[] items = linie.Split('|');
            //    Boolean suntEgale = true;
            //    for(int i = 0; i < NR_COLOANE; i++)
            //    {
            //        if (items[i] != element[i])
            //        {
            //            suntEgale = false;
            //            break;
            //        }
            //    }
            //    if(!suntEgale)
            //    {
            //        Cuvant tradus = new Cuvant(items[0], items[1], items[4]);
            //        Cuvant traducere = new Cuvant(items[2], items[3], items[5]);
            //        text += tradus.Tip + "|" + tradus + "|" + traducere.Tip + "|" + traducere + "|" + tradus.Explicatie + "|" + traducere.Explicatie + Environment.NewLine;
            //        File.AppendAllText("dictionarTMP.txt", text);
            //    }
            //}
            //File.Replace("dictionarTMP.txt", "dictionar.txt", "dictionarReplaced.txt");

            Cuvant cuvantDeSters = Cuvinte.Keys.First<Cuvant>(cuvant =>
            {   
               if(cuvant.Tip == element[0] && cuvant.Label == element[2] && cuvant.Explicatie.ToString() == element[4]) return true; 
                return false;
            });
            cuvinte.Remove(cuvantDeSters);
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
