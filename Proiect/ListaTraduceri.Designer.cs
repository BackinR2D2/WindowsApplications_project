namespace Proiect
{
    partial class ListaTraduceri
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
            this.listaTraduceriContainer = new System.Windows.Forms.Panel();
            this.listaTraduceriLV = new System.Windows.Forms.ListView();
            this.listaTraduceriTitlu = new System.Windows.Forms.Label();
            this.cuvantTip = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.traducereTip = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cuvantLabel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.traducereLabel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cuvantExplicatie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.traducereExplicatie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.printBtn = new System.Windows.Forms.Button();
            this.meniuTraducere = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.stergeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaTraduceriContainer.SuspendLayout();
            this.meniuTraducere.SuspendLayout();
            this.SuspendLayout();
            // 
            // listaTraduceriContainer
            // 
            this.listaTraduceriContainer.Controls.Add(this.printBtn);
            this.listaTraduceriContainer.Controls.Add(this.listaTraduceriLV);
            this.listaTraduceriContainer.Controls.Add(this.listaTraduceriTitlu);
            this.listaTraduceriContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listaTraduceriContainer.Location = new System.Drawing.Point(0, 0);
            this.listaTraduceriContainer.Name = "listaTraduceriContainer";
            this.listaTraduceriContainer.Size = new System.Drawing.Size(800, 450);
            this.listaTraduceriContainer.TabIndex = 0;
            // 
            // listaTraduceriLV
            // 
            this.listaTraduceriLV.AllowDrop = true;
            this.listaTraduceriLV.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listaTraduceriLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cuvantTip,
            this.traducereTip,
            this.cuvantLabel,
            this.traducereLabel,
            this.cuvantExplicatie,
            this.traducereExplicatie});
            this.listaTraduceriLV.ContextMenuStrip = this.meniuTraducere;
            this.listaTraduceriLV.HideSelection = false;
            this.listaTraduceriLV.Location = new System.Drawing.Point(12, 26);
            this.listaTraduceriLV.Name = "listaTraduceriLV";
            this.listaTraduceriLV.Size = new System.Drawing.Size(776, 335);
            this.listaTraduceriLV.TabIndex = 4;
            this.listaTraduceriLV.UseCompatibleStateImageBehavior = false;
            this.listaTraduceriLV.View = System.Windows.Forms.View.Details;
            // 
            // listaTraduceriTitlu
            // 
            this.listaTraduceriTitlu.AutoSize = true;
            this.listaTraduceriTitlu.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaTraduceriTitlu.Location = new System.Drawing.Point(298, 0);
            this.listaTraduceriTitlu.Name = "listaTraduceriTitlu";
            this.listaTraduceriTitlu.Size = new System.Drawing.Size(171, 23);
            this.listaTraduceriTitlu.TabIndex = 3;
            this.listaTraduceriTitlu.Text = "Lista Traduceri";
            // 
            // cuvantTip
            // 
            this.cuvantTip.Text = "Cuvant Tip";
            this.cuvantTip.Width = 78;
            // 
            // traducereTip
            // 
            this.traducereTip.Text = "Traducere Tip";
            this.traducereTip.Width = 87;
            // 
            // cuvantLabel
            // 
            this.cuvantLabel.Text = "Cuvant";
            this.cuvantLabel.Width = 64;
            // 
            // traducereLabel
            // 
            this.traducereLabel.Text = "Traducere";
            this.traducereLabel.Width = 80;
            // 
            // cuvantExplicatie
            // 
            this.cuvantExplicatie.Text = "Cuvant Explicatie";
            this.cuvantExplicatie.Width = 167;
            // 
            // traducereExplicatie
            // 
            this.traducereExplicatie.Text = "Traducere Explicatie";
            this.traducereExplicatie.Width = 203;
            // 
            // printBtn
            // 
            this.printBtn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printBtn.Location = new System.Drawing.Point(346, 367);
            this.printBtn.Name = "printBtn";
            this.printBtn.Size = new System.Drawing.Size(123, 45);
            this.printBtn.TabIndex = 5;
            this.printBtn.Text = "Print";
            this.printBtn.UseVisualStyleBackColor = true;
            this.printBtn.Click += new System.EventHandler(this.printBtn_Click);
            // 
            // meniuTraducere
            // 
            this.meniuTraducere.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stergeToolStripMenuItem});
            this.meniuTraducere.Name = "meniuTraducere";
            this.meniuTraducere.Size = new System.Drawing.Size(181, 48);
            this.meniuTraducere.Opening += new System.ComponentModel.CancelEventHandler(this.meniuTraducere_Opening);
            // 
            // stergeToolStripMenuItem
            // 
            this.stergeToolStripMenuItem.Name = "stergeToolStripMenuItem";
            this.stergeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.stergeToolStripMenuItem.Text = "Sterge";
            this.stergeToolStripMenuItem.Click += new System.EventHandler(this.stergeToolStripMenuItem_Click);
            // 
            // ListaTraduceri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listaTraduceriContainer);
            this.Name = "ListaTraduceri";
            this.Text = "ListaTraduceri";
            this.listaTraduceriContainer.ResumeLayout(false);
            this.listaTraduceriContainer.PerformLayout();
            this.meniuTraducere.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel listaTraduceriContainer;
        private System.Windows.Forms.ListView listaTraduceriLV;
        private System.Windows.Forms.Label listaTraduceriTitlu;
        private System.Windows.Forms.ColumnHeader cuvantTip;
        private System.Windows.Forms.ColumnHeader traducereTip;
        private System.Windows.Forms.ColumnHeader cuvantLabel;
        private System.Windows.Forms.ColumnHeader traducereLabel;
        private System.Windows.Forms.ColumnHeader cuvantExplicatie;
        private System.Windows.Forms.ColumnHeader traducereExplicatie;
        private System.Windows.Forms.Button printBtn;
        private System.Windows.Forms.ContextMenuStrip meniuTraducere;
        private System.Windows.Forms.ToolStripMenuItem stergeToolStripMenuItem;
    }
}