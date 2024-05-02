namespace Proiect
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grafic = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.traducereBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proiectDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proiectDataSet = new Proiect.ProiectDataSet();
            this.saveBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.traducereTableAdapter = new Proiect.ProiectDataSetTableAdapters.TraducereTableAdapter();
            this.cuvantTradusTipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuvantTradusLabelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.traducereTipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.traducereLabelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuvantTradusExplicatieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.traducereExplicatieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grafic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.traducereBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proiectDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proiectDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grafic);
            this.panel1.Controls.Add(this.saveBtn);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 1;
            // 
            // grafic
            // 
            chartArea3.Name = "ChartArea1";
            this.grafic.ChartAreas.Add(chartArea3);
            this.grafic.DataSource = this.traducereBindingSource;
            legend3.Name = "Legend1";
            this.grafic.Legends.Add(legend3);
            this.grafic.Location = new System.Drawing.Point(438, 12);
            this.grafic.Name = "grafic";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Traduceri";
            this.grafic.Series.Add(series3);
            this.grafic.Size = new System.Drawing.Size(350, 328);
            this.grafic.TabIndex = 3;
            this.grafic.Text = "Grafic";
            // 
            // traducereBindingSource
            // 
            this.traducereBindingSource.DataMember = "Traducere";
            this.traducereBindingSource.DataSource = this.proiectDataSetBindingSource;
            // 
            // proiectDataSetBindingSource
            // 
            this.proiectDataSetBindingSource.DataSource = this.proiectDataSet;
            this.proiectDataSetBindingSource.Position = 0;
            // 
            // proiectDataSet
            // 
            this.proiectDataSet.DataSetName = "ProiectDataSet";
            this.proiectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(206, 361);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(345, 53);
            this.saveBtn.TabIndex = 2;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cuvantTradusTipDataGridViewTextBoxColumn,
            this.cuvantTradusLabelDataGridViewTextBoxColumn,
            this.traducereTipDataGridViewTextBoxColumn,
            this.traducereLabelDataGridViewTextBoxColumn,
            this.cuvantTradusExplicatieDataGridViewTextBoxColumn,
            this.traducereExplicatieDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.traducereBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(420, 328);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowValidated);
            // 
            // traducereTableAdapter
            // 
            this.traducereTableAdapter.ClearBeforeFill = true;
            // 
            // cuvantTradusTipDataGridViewTextBoxColumn
            // 
            this.cuvantTradusTipDataGridViewTextBoxColumn.DataPropertyName = "cuvantTradusTip";
            this.cuvantTradusTipDataGridViewTextBoxColumn.HeaderText = "cuvantTradusTip";
            this.cuvantTradusTipDataGridViewTextBoxColumn.Name = "cuvantTradusTipDataGridViewTextBoxColumn";
            this.cuvantTradusTipDataGridViewTextBoxColumn.Width = 113;
            // 
            // cuvantTradusLabelDataGridViewTextBoxColumn
            // 
            this.cuvantTradusLabelDataGridViewTextBoxColumn.DataPropertyName = "cuvantTradusLabel";
            this.cuvantTradusLabelDataGridViewTextBoxColumn.HeaderText = "cuvantTradusLabel";
            this.cuvantTradusLabelDataGridViewTextBoxColumn.Name = "cuvantTradusLabelDataGridViewTextBoxColumn";
            this.cuvantTradusLabelDataGridViewTextBoxColumn.Width = 124;
            // 
            // traducereTipDataGridViewTextBoxColumn
            // 
            this.traducereTipDataGridViewTextBoxColumn.DataPropertyName = "traducereTip";
            this.traducereTipDataGridViewTextBoxColumn.HeaderText = "traducereTip";
            this.traducereTipDataGridViewTextBoxColumn.Name = "traducereTipDataGridViewTextBoxColumn";
            this.traducereTipDataGridViewTextBoxColumn.Width = 92;
            // 
            // traducereLabelDataGridViewTextBoxColumn
            // 
            this.traducereLabelDataGridViewTextBoxColumn.DataPropertyName = "traducereLabel";
            this.traducereLabelDataGridViewTextBoxColumn.HeaderText = "traducereLabel";
            this.traducereLabelDataGridViewTextBoxColumn.Name = "traducereLabelDataGridViewTextBoxColumn";
            this.traducereLabelDataGridViewTextBoxColumn.Width = 103;
            // 
            // cuvantTradusExplicatieDataGridViewTextBoxColumn
            // 
            this.cuvantTradusExplicatieDataGridViewTextBoxColumn.DataPropertyName = "cuvantTradusExplicatie";
            this.cuvantTradusExplicatieDataGridViewTextBoxColumn.HeaderText = "cuvantTradusExplicatie";
            this.cuvantTradusExplicatieDataGridViewTextBoxColumn.Name = "cuvantTradusExplicatieDataGridViewTextBoxColumn";
            this.cuvantTradusExplicatieDataGridViewTextBoxColumn.Width = 143;
            // 
            // traducereExplicatieDataGridViewTextBoxColumn
            // 
            this.traducereExplicatieDataGridViewTextBoxColumn.DataPropertyName = "traducereExplicatie";
            this.traducereExplicatieDataGridViewTextBoxColumn.HeaderText = "traducereExplicatie";
            this.traducereExplicatieDataGridViewTextBoxColumn.Name = "traducereExplicatieDataGridViewTextBoxColumn";
            this.traducereExplicatieDataGridViewTextBoxColumn.Width = 122;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grafic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.traducereBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proiectDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proiectDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private ProiectDataSet proiectDataSet;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource traducereBindingSource;
        private ProiectDataSetTableAdapters.TraducereTableAdapter traducereTableAdapter;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.DataVisualization.Charting.Chart grafic;
        private System.Windows.Forms.BindingSource proiectDataSetBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuvantTradusTipDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuvantTradusLabelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn traducereTipDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn traducereLabelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuvantTradusExplicatieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn traducereExplicatieDataGridViewTextBoxColumn;
    }
}