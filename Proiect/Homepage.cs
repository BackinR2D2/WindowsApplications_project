using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect
{
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }

        private void re_Click(object sender, EventArgs e)
        {
            Traducere re = new Traducere("Romana-Engleza");
            re.TopLevel = false;
            if (homepageContainer.Controls.Count > 0)
            {
                homepageContainer.Controls.Clear();
            }
            homepageContainer.Controls.Add(re);
            re.BringToFront();
            re.Show();
        }

        private void rg_Click(object sender, EventArgs e)
        {
            Traducere rg = new Traducere("Romana-Germana");
            rg.TopLevel = false;
            if (homepageContainer.Controls.Count > 0)
            {
                homepageContainer.Controls.Clear();
            }
            homepageContainer.Controls.Add(rg);
            rg.BringToFront();
            rg.Show();
        }

        private void er_Click(object sender, EventArgs e)
        {
            Traducere er = new Traducere("Engleza-Romana");
            er.TopLevel = false;
            if (homepageContainer.Controls.Count > 0)
            {
                homepageContainer.Controls.Clear();
            }
            homepageContainer.Controls.Add(er);
            er.BringToFront();
            er.Show();
        }

        private void eg_Click(object sender, EventArgs e)
        {
            Traducere eg = new Traducere("Engleza-Germana");
            eg.TopLevel = false;
            if (homepageContainer.Controls.Count > 0)
            {
                homepageContainer.Controls.Clear();
            }
            homepageContainer.Controls.Add(eg);
            eg.BringToFront();
            eg.Show();
        }

        private void gr_Click(object sender, EventArgs e)
        {
            Traducere gr = new Traducere("Germana-Romana");
            gr.TopLevel = false;
            if (homepageContainer.Controls.Count > 0)
            {
                homepageContainer.Controls.Clear();
            }
            homepageContainer.Controls.Add(gr);
            gr.BringToFront();
            gr.Show();
        }

        private void ge_Click(object sender, EventArgs e)
        {
            Traducere ge = new Traducere("Germana-Engleza");
            ge.TopLevel = false;
            if (homepageContainer.Controls.Count > 0)
            {
                homepageContainer.Controls.Clear();
            }
            homepageContainer.Controls.Add(ge);
            ge.BringToFront();
            ge.Show();
        }
    }
}
