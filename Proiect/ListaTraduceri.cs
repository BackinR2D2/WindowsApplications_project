using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Proiect
{
    public partial class ListaTraduceri : Form
    {
        Dictionar dictionar;
        public ListaTraduceri()
        {
            InitializeComponent();

            this.listaTraduceriLV.DragDrop += new System.Windows.Forms.DragEventHandler(this.listaTraduceriLV_DragDrop);

            this.listaTraduceriLV.DragEnter += new System.Windows.Forms.DragEventHandler(this.listaTraduceriLV_DragEnter);


            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            dictionar = new Dictionar();
            dictionar.citesteDinFisier();

            foreach(var item in dictionar.Cuvinte)
            {
                ListViewItem traducere = new ListViewItem(item.Key.Tip);
                traducere.SubItems.Add(item.Value.Tip);
                traducere.SubItems.Add(item.Key.Label.ToString());
                traducere.SubItems.Add(item.Value.Label.ToString());
                traducere.SubItems.Add(item.Key.Explicatie.ToString());
                traducere.SubItems.Add(item.Value.Explicatie.ToString());
                string[] element = { item.Key.Tip, item.Value.Tip, item.Key.Label, item.Value.Label, item.Key.Explicatie.ToString(), item.Value.Explicatie.ToString() };
                traducere.Tag = element;
                listaTraduceriLV.Items.Add(traducere);
            }
        }

        private void listaTraduceriLV_DragEnter(object sender, DragEventArgs e)
        {
            if(e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.All;
            } else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void listaTraduceriLV_DragDrop(object sender, DragEventArgs e)
        {
            string[] fileList = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            StreamReader stream = File.OpenText(fileList[0]);
            string linie;
            while ((linie = stream.ReadLine()) != null)
            {
                string[] items = linie.Split(',');
                if (items.Length != 6)
                {
                    MessageBox.Show("Fisier gresit");
                    return;
                }
                Cuvant tradus = new Cuvant(items[0], items[1], items[4]);
                Cuvant traducere = new Cuvant(items[2], items[3], items[5]);
                dictionar.adaugaTraducere(tradus, traducere);

                ListViewItem traducerePereche = new ListViewItem(tradus.Tip);
                traducerePereche.SubItems.Add(traducere.Tip);
                traducerePereche.SubItems.Add(tradus.Label.ToString());
                traducerePereche.SubItems.Add(traducere.Label.ToString());
                traducerePereche.SubItems.Add(tradus.Explicatie.ToString());
                traducerePereche.SubItems.Add(traducere.Explicatie.ToString());
                string[] element = { tradus.Tip, traducere.Tip, tradus.Label, traducere.Label, tradus.Explicatie.ToString(), traducere.Explicatie.ToString() };
                traducerePereche.Tag = element;
                listaTraduceriLV.Items.Add(traducerePereche);
            }
            //dictionar.scrieInFisier();
            MessageBox.Show("Traduceri Salvate!");
        }

        private void printBtn_Click(object sender, EventArgs e)
        {
            PrintDialog printDlg = new PrintDialog();
            PrintDocument printDoc = new PrintDocument();
            printDoc.DocumentName = "dictionar";
            printDlg.Document = printDoc;
            printDlg.AllowSelection = true;
            printDlg.AllowSomePages = true;
            if (printDlg.ShowDialog() == DialogResult.OK)
            {
                printDoc.PrintPage += new PrintPageEventHandler(pd_PrintPage);
                printDoc.Print();
            }
        }

        private void pd_PrintPage(object sender, PrintPageEventArgs ev)
        {
            string content = "";
            foreach(var item in dictionar.Cuvinte)
            {
                content += item.Key.Tip + ", " + item.Key + ", " + item.Value.Tip + ", " + item.Value + Environment.NewLine;
            }
            Font font = new Font("Arial", 9.75F);
            ev.Graphics.DrawString(content, font, Brushes.Black,
                            0, 0, new StringFormat());
        }

        private void stergeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] element = listaTraduceriLV.SelectedItems[0].Tag as string[];
            dictionar.stergeDinFisier(element);
            listaTraduceriLV.Refresh();
            listaTraduceriLV.Items.RemoveAt(listaTraduceriLV.SelectedIndices[0]);
            MessageBox.Show("Traducere Stearsa cu succes!");
        }

        private void meniuTraducere_Opening(object sender, CancelEventArgs e)
        {
            if (listaTraduceriLV.SelectedItems.Count > 0)
            {
                this.stergeToolStripMenuItem.Enabled = true;
            }
            else
            {
                this.stergeToolStripMenuItem.Enabled = false;
            }
        }
    }
}
