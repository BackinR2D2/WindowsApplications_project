using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect
{
    public partial class Meniu : Form
    {
        public Meniu()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }

        private void adaugaButton_Click(object sender, EventArgs e)
        {
            string cuvantTradusLabel = cuvantTradusTextbox.Text.Trim();
            string cuvantTradusTip = (cuvantTradusSelect.SelectedItem != null) ? cuvantTradusSelect.SelectedItem.ToString().Trim() : "";
            string cuvantTradusExplicatie = explicatieCuvantTradusTextbox.Text.Trim();

            Cuvant cuvantTradus = new Cuvant(cuvantTradusTip, cuvantTradusLabel, cuvantTradusExplicatie);

            string traducereLabel = traducereTextbox.Text.Trim();
            string traducereTip = (traducereSelect.SelectedItem != null) ? traducereSelect.SelectedItem.ToString().Trim() : "";
            string traducereExplicatie = explicatieTraducereTextbox.Text.Trim();

            Cuvant traducere = new Cuvant(traducereTip, traducereLabel, traducereExplicatie);

            if(cuvantTradusTip == traducereTip)
            {
                errCatch.SetError(cuvantTradusSelect, "Cuvintele nu pot avea acelasi tip.");
                errCatch.SetError(traducereSelect, "Cuvintele nu pot avea acelasi tip.");
            } else
            {
                errCatch.SetError(cuvantTradusSelect, "");
                errCatch.SetError(traducereSelect, "");
            }
            
            if(cuvantTradusTip.Length > 0 && cuvantTradusLabel.Length > 0 && cuvantTradusExplicatie.Length > 0 && traducereLabel.Length > 0 && traducereTip.Length > 0 && traducereExplicatie.Length > 0)
            {
                Dictionar dictionar = new Dictionar();
                dictionar.adaugaTraducere(cuvantTradus, traducere);
                errCatch.SetError(cuvantTradusSelect, "");
                errCatch.SetError(cuvantTradusTextbox, "");
                errCatch.SetError(explicatieCuvantTradusTextbox, "");
                errCatch.SetError(traducereTextbox, "");
                errCatch.SetError(traducereSelect, "");
                errCatch.SetError(explicatieTraducereTextbox, "");
                MessageBox.Show("Traducere adaugata cu succes.");
            } else
            {
                if(cuvantTradusTip.Length == 0)
                {
                    errCatch.SetError(cuvantTradusSelect, "Camp incomplet");
                } else
                {
                    errCatch.SetError(cuvantTradusSelect, "");
                }

                if(cuvantTradusLabel.Length == 0)
                {
                    errCatch.SetError(cuvantTradusTextbox, "Camp incomplet");
                } else
                {
                    errCatch.SetError(cuvantTradusTextbox, "");
                }

                if(cuvantTradusExplicatie.Length == 0)
                {
                    errCatch.SetError(explicatieCuvantTradusTextbox, "Camp incomplet");
                } else
                {
                    errCatch.SetError(explicatieCuvantTradusTextbox, "");
                }

                if(traducereLabel.Length == 0)
                {
                    errCatch.SetError(traducereTextbox, "Camp incomplet");
                } else
                {
                    errCatch.SetError(traducereTextbox, "");
                }

                if(traducereTip.Length == 0)
                {
                    errCatch.SetError(traducereSelect, "Camp incomplet");
                } else
                {
                    errCatch.SetError(traducereSelect, "");
                }

                if(traducereExplicatie.Length == 0)
                {
                    errCatch.SetError(explicatieTraducereTextbox, "Camp incomplet");
                } else
                {
                    errCatch.SetError(explicatieTraducereTextbox, "");
                }
            }
        }
    }
}
