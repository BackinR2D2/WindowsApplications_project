using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proiect
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        }

        public string getTitlu(object sender)
        {
            ToolStripMenuItem mi = (ToolStripMenuItem)sender;
            ToolStripMenuItem miOwnerItem = (ToolStripMenuItem)(mi.GetCurrentParent() as ToolStripDropDown).OwnerItem;
            string titlu = miOwnerItem.ToString() + "-" + mi.ToString();
            return titlu;
        }

        private void Homepage_Click(object sender, EventArgs e)
        {
            Homepage home = new Homepage();
            home.TopLevel = false;
            if(MainContainer.Controls.Count > 0)
            {
                MainContainer.Controls.Clear();
            }
            MainContainer.Controls.Add(home);
            home.BringToFront();
            home.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Homepage home = new Homepage();
            home.TopLevel = false;
            MainContainer.Controls.Add(home);
            home.BringToFront();
            home.Show();
        }

        private void romanaEnglezaMeniu_Click(object sender, EventArgs e)
        {
            Traducere re = new Traducere(getTitlu(sender));
            
            re.TopLevel = false;
            if (MainContainer.Controls.Count > 0)
            {
                MainContainer.Controls.Clear();
            }

            MainContainer.Controls.Add(re);
            re.BringToFront();
            re.Show();
        }

        private void romanaGermanaMeniu_Click(object sender, EventArgs e)
        {
            Traducere rg = new Traducere(getTitlu(sender));
            rg.TopLevel = false;
            if (MainContainer.Controls.Count > 0)
            {
                MainContainer.Controls.Clear();
            }
            MainContainer.Controls.Add(rg);
            rg.BringToFront();
            rg.Show();
        }

        private void englezaRomanaMeniu_Click(object sender, EventArgs e)
        {
            Traducere er = new Traducere(getTitlu(sender));
            er.TopLevel = false;
            if (MainContainer.Controls.Count > 0)
            {
                MainContainer.Controls.Clear();
            }
            MainContainer.Controls.Add(er);
            er.BringToFront();
            er.Show();
        }

        private void englezaGermanaMeniu_Click(object sender, EventArgs e)
        {
            Traducere eg = new Traducere(getTitlu(sender));
            eg.TopLevel = false;
            if (MainContainer.Controls.Count > 0)
            {
                MainContainer.Controls.Clear();
            }
            MainContainer.Controls.Add(eg);
            eg.BringToFront();
            eg.Show();
        }

        private void germanaRomanaMeniu_Click(object sender, EventArgs e)
        {
            Traducere gr = new Traducere(getTitlu(sender));
            gr.TopLevel = false;
            if (MainContainer.Controls.Count > 0)
            {
                MainContainer.Controls.Clear();
            }
            MainContainer.Controls.Add(gr);
            gr.BringToFront();
            gr.Show();
        }

        private void germanaEnglezaMeniu_Click(object sender, EventArgs e)
        {
            Traducere ge = new Traducere(getTitlu(sender));
            ge.TopLevel = false;
            if (MainContainer.Controls.Count > 0)
            {
                MainContainer.Controls.Clear();
            }
            MainContainer.Controls.Add(ge);
            ge.BringToFront();
            ge.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to exit?", "Close Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void adaugaTraducereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Meniu meniu = new Meniu();
            meniu.TopLevel = false;
            if(MainContainer.Controls.Count > 0)
            {
                MainContainer.Controls.Clear();
            }
            MainContainer.Controls.Add(meniu);
            meniu.BringToFront();
            meniu.Show();
        }

        private void listaTraduceriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaTraduceri listaTraduceri = new ListaTraduceri();
            listaTraduceri.TopLevel = false;
            if (MainContainer.Controls.Count > 0)
            {
                MainContainer.Controls.Clear();
            }
            MainContainer.Controls.Add(listaTraduceri);
            listaTraduceri.BringToFront();
            listaTraduceri.Show();
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.TopLevel = false;
            if (MainContainer.Controls.Count > 0)
            {
                MainContainer.Controls.Clear();
            }
            MainContainer.Controls.Add(dashboard);
            dashboard.BringToFront();
            dashboard.Show();
        }
    }
}
