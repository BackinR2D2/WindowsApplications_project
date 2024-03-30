using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Cuvant cuvant1 = new Cuvant("Romana", "capitalism", "Sistem social-economic si politic-ideologic bazat pe proprietatea privata, piata libera si libertatea de actiune.");
            Cuvant cuvant2 = new Cuvant("Engleza", "capitalism", "An economic and political system in which property, business, and industry are controlled by private owners rather than by the state, with the purpose of making a profit");
            Cuvant cuvant9 = new Cuvant("Germana", "Kapitalismus", "Sozialökonomisches und politisch-ideologisches System, das auf Privateigentum, freiem Markt und Handlungsfreiheit basiert.");

            Cuvant cuvant3 = new Cuvant("Romana", "economie", "Ansamblul activitatilor umane desfasurate in sfera productiei, distributiei si consumului bunurilor materiale si serviciilor.");
            Cuvant cuvant4 = new Cuvant("Engleza", "economy", "The system of trade and industry by which the wealth of a country is made and used");
            Cuvant cuvant10 = new Cuvant("Germana", "Wirtschaft", "Die Gesamtheit der menschlichen Aktivitäten im Bereich der Produktion, Verteilung und des Konsums materieller Güter und Dienstleistungen.");

            Cuvant cuvant5 = new Cuvant("Romana", "amortizabil", "Folosit pentru a descrie un cost de afaceri sau un activ (= ceva de valoare cumparat pentru o afacere), atunci cand suma de bani cheltuita poate fi luata treptat din impozitul platit de companie intr-o perioada de timp");
            Cuvant cuvant6 = new Cuvant("Engleza", "amortizable", "Used to describe a business cost or an asset (= something of value bought for a business), when the amount of money spent can gradually be taken away from tax paid by the business over a period of time");
            Cuvant cuvant11 = new Cuvant("Germana", "Kissen", "Wird verwendet, um einen Geschäftsaufwand oder Vermögenswert (= etwas Wertvolles, das für ein Unternehmen gekauft wird) zu beschreiben, wenn der ausgegebene Geldbetrag über einen bestimmten Zeitraum hinweg schrittweise von der vom Unternehmen gezahlten Steuer abgezogen werden kann");

            Cuvant cuvant7 = new Cuvant("Romana", "uberizare", "Actiunea sau procesul de schimbare a pietei pentru un serviciu prin introducerea unui mod diferit de cumparare sau utilizare, in special folosind tehnologia mobila.");
            Cuvant cuvant8 = new Cuvant("Engleza", "uberization", "The act or process of changing the market for a service by introducing a different way of buying or using it, especially using mobile technology.");
            Cuvant cuvant12 = new Cuvant("Germana", "Uberisierung", "Der Akt oder Prozess der Veränderung des Marktes für eine Dienstleistung durch die Einführung einer anderen Art des Kaufs oder der Nutzung, insbesondere durch den Einsatz mobiler Technologie.");

            // Romana-Engleza
            Dictionary<Cuvant, Cuvant> cuvinteRE = new Dictionary<Cuvant, Cuvant>();

            cuvinteRE.Add(cuvant1, cuvant2);
            cuvinteRE.Add(cuvant3, cuvant4);
            cuvinteRE.Add(cuvant5, cuvant6);
            cuvinteRE.Add(cuvant7, cuvant8);

            Dictionar dictionarRE = new Dictionar(cuvinteRE);
            dictionarRE.scrieInFisier();

            // Engleza-Romana
            Dictionary<Cuvant, Cuvant> cuvinteER = new Dictionary<Cuvant, Cuvant>();

            cuvinteER.Add(cuvant2, cuvant1);
            cuvinteER.Add(cuvant4, cuvant3);
            cuvinteER.Add(cuvant6, cuvant5);
            cuvinteER.Add(cuvant8, cuvant7);

            Dictionar dictionarER = new Dictionar(cuvinteER);
            dictionarER.scrieInFisier();

            // Romana-Germana
            Dictionary<Cuvant, Cuvant> cuvinteRG = new Dictionary<Cuvant, Cuvant>();

            cuvinteRG.Add(cuvant1, cuvant9);
            cuvinteRG.Add(cuvant3, cuvant10);
            cuvinteRG.Add(cuvant5, cuvant11);
            cuvinteRG.Add(cuvant7, cuvant12);

            Dictionar dictionarRG = new Dictionar(cuvinteRG);
            dictionarRG.scrieInFisier();

            // Engleza-Germana
            Dictionary<Cuvant, Cuvant> cuvinteEG = new Dictionary<Cuvant, Cuvant>();

            cuvinteEG.Add(cuvant2, cuvant9);
            cuvinteEG.Add(cuvant4, cuvant10);
            cuvinteEG.Add(cuvant6, cuvant11);
            cuvinteEG.Add(cuvant8, cuvant12);

            Dictionar dictionarEG = new Dictionar(cuvinteEG);
            dictionarEG.scrieInFisier();

            // Germana-Romana
            Dictionary<Cuvant, Cuvant> cuvinteGR = new Dictionary<Cuvant, Cuvant>();

            cuvinteGR.Add(cuvant9, cuvant1);
            cuvinteGR.Add(cuvant10, cuvant3);
            cuvinteGR.Add(cuvant11, cuvant5);
            cuvinteGR.Add(cuvant12, cuvant7);

            Dictionar dictionarGR = new Dictionar(cuvinteGR);
            dictionarGR.scrieInFisier();

            // Germana-Engleza
            Dictionary<Cuvant, Cuvant> cuvinteGE = new Dictionary<Cuvant, Cuvant>();

            cuvinteGE.Add(cuvant9, cuvant2);
            cuvinteGE.Add(cuvant10, cuvant4);
            cuvinteGE.Add(cuvant11, cuvant6);
            cuvinteGE.Add(cuvant12, cuvant8);

            Dictionar dictionarGE = new Dictionar(cuvinteGE);
            dictionarGE.scrieInFisier();

            Application.Run(new Form1());
        }
    }
}
