using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace Proiect
{
    public partial class Dashboard : Form
    {

        public Dashboard()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }

        void FillChart()
        {
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Andreea\\source\\repos\\Proiect\\Proiect\\Proiect.mdf;Integrated Security=True;Connect Timeout=30");
            DataTable dt = new DataTable();


            conn.Open();

            SqlDataAdapter adapter = new SqlDataAdapter("SELECT COUNT(*) AS Count, cuvantTradusTip FROM traducere GROUP BY cuvantTradusTip", conn);
            adapter.Fill(dt);
            grafic.DataSource = dt;

            conn.Close();

            grafic.Series["Traduceri"].XValueMember = "cuvantTradusTip";
            grafic.Series["Traduceri"].YValueMembers = "Count";

            grafic.Titles.Add("Count");


        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'proiectDataSet.Traducere' table. You can move, or remove it, as needed.
            this.traducereTableAdapter.Fill(this.proiectDataSet.Traducere);
            FillChart();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.traducereBindingSource.EndEdit();
                this.proiectDataSetBindingSource.EndEdit();
                dataGridView1.EndEdit();
                
                
                this.traducereTableAdapter.Update(this.proiectDataSet.Traducere);

                MessageBox.Show($"Changes saved successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving changes: {ex.Message}");
            }
        }

        private void dataGridView1_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            this.traducereTableAdapter.Update(this.proiectDataSet.Traducere);
        }
    }
}
