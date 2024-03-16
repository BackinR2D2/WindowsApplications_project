namespace Proiect
{
    partial class Meniu
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
            this.meniuContainer = new System.Windows.Forms.Panel();
            this.meniuTitlu = new System.Windows.Forms.Label();
            this.cuvantTradusLabel = new System.Windows.Forms.Label();
            this.traducereLabel = new System.Windows.Forms.Label();
            this.cuvantTradusTextbox = new System.Windows.Forms.TextBox();
            this.traducereTextbox = new System.Windows.Forms.TextBox();
            this.tipCuvantTradus = new System.Windows.Forms.Label();
            this.tipTraducere = new System.Windows.Forms.Label();
            this.cuvantTradusSelect = new System.Windows.Forms.ComboBox();
            this.traducereSelect = new System.Windows.Forms.ComboBox();
            this.explicatieCuvantTradusLabel = new System.Windows.Forms.Label();
            this.explicatieTraducereLabel = new System.Windows.Forms.Label();
            this.explicatieCuvantTradusTextbox = new System.Windows.Forms.TextBox();
            this.explicatieTraducereTextbox = new System.Windows.Forms.TextBox();
            this.adaugaButton = new System.Windows.Forms.Button();
            this.meniuContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // meniuContainer
            // 
            this.meniuContainer.Controls.Add(this.adaugaButton);
            this.meniuContainer.Controls.Add(this.explicatieTraducereTextbox);
            this.meniuContainer.Controls.Add(this.explicatieCuvantTradusTextbox);
            this.meniuContainer.Controls.Add(this.explicatieTraducereLabel);
            this.meniuContainer.Controls.Add(this.explicatieCuvantTradusLabel);
            this.meniuContainer.Controls.Add(this.traducereSelect);
            this.meniuContainer.Controls.Add(this.cuvantTradusSelect);
            this.meniuContainer.Controls.Add(this.tipTraducere);
            this.meniuContainer.Controls.Add(this.tipCuvantTradus);
            this.meniuContainer.Controls.Add(this.traducereTextbox);
            this.meniuContainer.Controls.Add(this.cuvantTradusTextbox);
            this.meniuContainer.Controls.Add(this.traducereLabel);
            this.meniuContainer.Controls.Add(this.cuvantTradusLabel);
            this.meniuContainer.Controls.Add(this.meniuTitlu);
            this.meniuContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.meniuContainer.Location = new System.Drawing.Point(0, 0);
            this.meniuContainer.Name = "meniuContainer";
            this.meniuContainer.Size = new System.Drawing.Size(800, 450);
            this.meniuContainer.TabIndex = 0;
            // 
            // meniuTitlu
            // 
            this.meniuTitlu.AutoSize = true;
            this.meniuTitlu.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meniuTitlu.Location = new System.Drawing.Point(276, 26);
            this.meniuTitlu.Name = "meniuTitlu";
            this.meniuTitlu.Size = new System.Drawing.Size(222, 23);
            this.meniuTitlu.TabIndex = 0;
            this.meniuTitlu.Text = "Adauga o traducere";
            // 
            // cuvantTradusLabel
            // 
            this.cuvantTradusLabel.AutoSize = true;
            this.cuvantTradusLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuvantTradusLabel.Location = new System.Drawing.Point(83, 86);
            this.cuvantTradusLabel.Name = "cuvantTradusLabel";
            this.cuvantTradusLabel.Size = new System.Drawing.Size(89, 16);
            this.cuvantTradusLabel.TabIndex = 1;
            this.cuvantTradusLabel.Text = "Cuvant Tradus";
            // 
            // traducereLabel
            // 
            this.traducereLabel.AutoSize = true;
            this.traducereLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.traducereLabel.Location = new System.Drawing.Point(523, 86);
            this.traducereLabel.Name = "traducereLabel";
            this.traducereLabel.Size = new System.Drawing.Size(64, 16);
            this.traducereLabel.TabIndex = 2;
            this.traducereLabel.Text = "Traducere";
            // 
            // cuvantTradusTextbox
            // 
            this.cuvantTradusTextbox.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuvantTradusTextbox.Location = new System.Drawing.Point(86, 117);
            this.cuvantTradusTextbox.Name = "cuvantTradusTextbox";
            this.cuvantTradusTextbox.Size = new System.Drawing.Size(183, 20);
            this.cuvantTradusTextbox.TabIndex = 3;
            // 
            // traducereTextbox
            // 
            this.traducereTextbox.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.traducereTextbox.Location = new System.Drawing.Point(526, 117);
            this.traducereTextbox.Name = "traducereTextbox";
            this.traducereTextbox.Size = new System.Drawing.Size(183, 20);
            this.traducereTextbox.TabIndex = 4;
            // 
            // tipCuvantTradus
            // 
            this.tipCuvantTradus.AutoSize = true;
            this.tipCuvantTradus.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipCuvantTradus.Location = new System.Drawing.Point(83, 165);
            this.tipCuvantTradus.Name = "tipCuvantTradus";
            this.tipCuvantTradus.Size = new System.Drawing.Size(24, 16);
            this.tipCuvantTradus.TabIndex = 5;
            this.tipCuvantTradus.Text = "Tip";
            // 
            // tipTraducere
            // 
            this.tipTraducere.AutoSize = true;
            this.tipTraducere.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipTraducere.Location = new System.Drawing.Point(523, 165);
            this.tipTraducere.Name = "tipTraducere";
            this.tipTraducere.Size = new System.Drawing.Size(24, 16);
            this.tipTraducere.TabIndex = 6;
            this.tipTraducere.Text = "Tip";
            // 
            // cuvantTradusSelect
            // 
            this.cuvantTradusSelect.FormattingEnabled = true;
            this.cuvantTradusSelect.Items.AddRange(new object[] {
            "Romana",
            "Engleza",
            "Germana"});
            this.cuvantTradusSelect.Location = new System.Drawing.Point(86, 195);
            this.cuvantTradusSelect.Name = "cuvantTradusSelect";
            this.cuvantTradusSelect.Size = new System.Drawing.Size(125, 21);
            this.cuvantTradusSelect.TabIndex = 7;
            // 
            // traducereSelect
            // 
            this.traducereSelect.FormattingEnabled = true;
            this.traducereSelect.Items.AddRange(new object[] {
            "Romana",
            "Engleza",
            "Germana"});
            this.traducereSelect.Location = new System.Drawing.Point(526, 195);
            this.traducereSelect.Name = "traducereSelect";
            this.traducereSelect.Size = new System.Drawing.Size(125, 21);
            this.traducereSelect.TabIndex = 8;
            // 
            // explicatieCuvantTradusLabel
            // 
            this.explicatieCuvantTradusLabel.AutoSize = true;
            this.explicatieCuvantTradusLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.explicatieCuvantTradusLabel.Location = new System.Drawing.Point(83, 247);
            this.explicatieCuvantTradusLabel.Name = "explicatieCuvantTradusLabel";
            this.explicatieCuvantTradusLabel.Size = new System.Drawing.Size(64, 16);
            this.explicatieCuvantTradusLabel.TabIndex = 9;
            this.explicatieCuvantTradusLabel.Text = "Explicatie";
            // 
            // explicatieTraducereLabel
            // 
            this.explicatieTraducereLabel.AutoSize = true;
            this.explicatieTraducereLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.explicatieTraducereLabel.Location = new System.Drawing.Point(523, 247);
            this.explicatieTraducereLabel.Name = "explicatieTraducereLabel";
            this.explicatieTraducereLabel.Size = new System.Drawing.Size(64, 16);
            this.explicatieTraducereLabel.TabIndex = 10;
            this.explicatieTraducereLabel.Text = "Explicatie";
            // 
            // explicatieCuvantTradusTextbox
            // 
            this.explicatieCuvantTradusTextbox.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.explicatieCuvantTradusTextbox.Location = new System.Drawing.Point(86, 277);
            this.explicatieCuvantTradusTextbox.Multiline = true;
            this.explicatieCuvantTradusTextbox.Name = "explicatieCuvantTradusTextbox";
            this.explicatieCuvantTradusTextbox.Size = new System.Drawing.Size(183, 61);
            this.explicatieCuvantTradusTextbox.TabIndex = 11;
            // 
            // explicatieTraducereTextbox
            // 
            this.explicatieTraducereTextbox.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.explicatieTraducereTextbox.Location = new System.Drawing.Point(526, 277);
            this.explicatieTraducereTextbox.Multiline = true;
            this.explicatieTraducereTextbox.Name = "explicatieTraducereTextbox";
            this.explicatieTraducereTextbox.Size = new System.Drawing.Size(183, 61);
            this.explicatieTraducereTextbox.TabIndex = 12;
            // 
            // adaugaButton
            // 
            this.adaugaButton.BackColor = System.Drawing.Color.Coral;
            this.adaugaButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adaugaButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.adaugaButton.Location = new System.Drawing.Point(329, 338);
            this.adaugaButton.Name = "adaugaButton";
            this.adaugaButton.Size = new System.Drawing.Size(135, 45);
            this.adaugaButton.TabIndex = 13;
            this.adaugaButton.Text = "Adauga";
            this.adaugaButton.UseVisualStyleBackColor = false;
            this.adaugaButton.Click += new System.EventHandler(this.adaugaButton_Click);
            // 
            // Meniu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.meniuContainer);
            this.Name = "Meniu";
            this.Text = "Meniu";
            this.meniuContainer.ResumeLayout(false);
            this.meniuContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel meniuContainer;
        private System.Windows.Forms.Label meniuTitlu;
        private System.Windows.Forms.Label traducereLabel;
        private System.Windows.Forms.Label cuvantTradusLabel;
        private System.Windows.Forms.TextBox traducereTextbox;
        private System.Windows.Forms.TextBox cuvantTradusTextbox;
        private System.Windows.Forms.Label tipCuvantTradus;
        private System.Windows.Forms.ComboBox traducereSelect;
        private System.Windows.Forms.ComboBox cuvantTradusSelect;
        private System.Windows.Forms.Label tipTraducere;
        private System.Windows.Forms.Label explicatieTraducereLabel;
        private System.Windows.Forms.Label explicatieCuvantTradusLabel;
        private System.Windows.Forms.TextBox explicatieTraducereTextbox;
        private System.Windows.Forms.TextBox explicatieCuvantTradusTextbox;
        private System.Windows.Forms.Button adaugaButton;
    }
}