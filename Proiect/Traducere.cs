using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Proiect
{
    public partial class Traducere : Form
    {
        private string titlu;

        public string Titlu
        {
            get { return titlu; }
            set
            {
                if (value.Length > 5)
                {
                    titlu = value;
                }
            }
        }
        public Traducere()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        }

        public Traducere(string titlu)
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Titlu = titlu;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Homepage home = new Homepage();
            home.TopLevel = false;
            if (TraducereContainer.Controls.Count > 0)
            {
                TraducereContainer.Controls.Clear();
            }
            TraducereContainer.Controls.Add(home);
            home.BringToFront();
            home.Show();
        }

        private void Traducere_Load(object sender, EventArgs e)
        {
            Label label = new Label()
            {
                Text = titlu,
                Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                AutoSize = false,
                TextAlign = ContentAlignment.TopLeft,
                Dock = DockStyle.None,
                Left = 10,
                Top = 10,
                Width = TraducereContainer.Width,
                TabIndex = 1,

            };
            TraducereContainer.Controls.Add(label);
        }

        private void traduceButton_Click(object sender, EventArgs e)
        {
            string traducereInputSearchQuery = CuvantInput.Text;
            Dictionar dictionar = new Dictionar();
            dictionar.citesteDinFisier();

            string[] titluSplit = titlu.Split('-');
            string tradus = titluSplit[0];
            string traducere = titluSplit[1];

            foreach(var item in dictionar.Cuvinte)
            {
                if(item.Key.Tip.ToLower() == tradus.ToLower() && item.Value.Tip.ToLower() == traducere.ToLower())
                {
                    if(item.Key.Label.ToLower() == traducereInputSearchQuery.ToLower())
                    {
                        //MessageBox.Show(item.Value.Label + " - " + item.Key.Explicatie, item.Key.Label);
                        
                        header.Text = item.Key.Label + ": " + item.Value.Label;
                        header.Cursor = Cursors.Hand;

                        explicatieLbl.Text = item.Key.Explicatie.ToString();

                        break;
                    }
                }
            }
        }

        private void header_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(header.Text);
            MessageBox.Show("Traducerea a fost copiata in clipboard.");
        }
    }
}
