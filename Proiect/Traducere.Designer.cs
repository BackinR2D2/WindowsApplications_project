namespace Proiect
{
    partial class Traducere
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
            this.TraducereContainer = new System.Windows.Forms.Panel();
            this.labelCuvant = new System.Windows.Forms.Label();
            this.traduceButton = new System.Windows.Forms.Button();
            this.CuvantInput = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.explicatieLbl = new System.Windows.Forms.Label();
            this.header = new System.Windows.Forms.Label();
            this.TraducereContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // TraducereContainer
            // 
            this.TraducereContainer.AutoSize = true;
            this.TraducereContainer.Controls.Add(this.explicatieLbl);
            this.TraducereContainer.Controls.Add(this.header);
            this.TraducereContainer.Controls.Add(this.labelCuvant);
            this.TraducereContainer.Controls.Add(this.traduceButton);
            this.TraducereContainer.Controls.Add(this.CuvantInput);
            this.TraducereContainer.Controls.Add(this.button1);
            this.TraducereContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TraducereContainer.Location = new System.Drawing.Point(0, 0);
            this.TraducereContainer.Name = "TraducereContainer";
            this.TraducereContainer.Size = new System.Drawing.Size(800, 450);
            this.TraducereContainer.TabIndex = 0;
            // 
            // labelCuvant
            // 
            this.labelCuvant.AutoSize = true;
            this.labelCuvant.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCuvant.Location = new System.Drawing.Point(271, 75);
            this.labelCuvant.Name = "labelCuvant";
            this.labelCuvant.Size = new System.Drawing.Size(85, 16);
            this.labelCuvant.TabIndex = 6;
            this.labelCuvant.Text = "Scrieti cuvant";
            // 
            // traduceButton
            // 
            this.traduceButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.traduceButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.traduceButton.FlatAppearance.BorderSize = 0;
            this.traduceButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.traduceButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.traduceButton.Location = new System.Drawing.Point(318, 147);
            this.traduceButton.Name = "traduceButton";
            this.traduceButton.Size = new System.Drawing.Size(142, 32);
            this.traduceButton.TabIndex = 5;
            this.traduceButton.Text = "Traduce";
            this.traduceButton.UseVisualStyleBackColor = false;
            this.traduceButton.Click += new System.EventHandler(this.traduceButton_Click);
            // 
            // CuvantInput
            // 
            this.CuvantInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CuvantInput.Location = new System.Drawing.Point(274, 94);
            this.CuvantInput.Name = "CuvantInput";
            this.CuvantInput.Size = new System.Drawing.Size(233, 20);
            this.CuvantInput.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Tan;
            this.button1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(319, 185);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 32);
            this.button1.TabIndex = 3;
            this.button1.Text = "Go to homepage";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // explicatieLbl
            // 
            this.explicatieLbl.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.explicatieLbl.Location = new System.Drawing.Point(12, 297);
            this.explicatieLbl.Name = "explicatieLbl";
            this.explicatieLbl.Size = new System.Drawing.Size(776, 144);
            this.explicatieLbl.TabIndex = 10;
            this.explicatieLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // header
            // 
            this.header.Cursor = System.Windows.Forms.Cursors.Default;
            this.header.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header.Location = new System.Drawing.Point(223, 256);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(337, 41);
            this.header.TabIndex = 9;
            this.header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.header.Click += new System.EventHandler(this.header_Click);
            // 
            // Traducere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TraducereContainer);
            this.Name = "Traducere";
            this.Text = "Traducere";
            this.Load += new System.EventHandler(this.Traducere_Load);
            this.TraducereContainer.ResumeLayout(false);
            this.TraducereContainer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TraducereContainer;
        private System.Windows.Forms.Button traduceButton;
        private System.Windows.Forms.TextBox CuvantInput;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelCuvant;
        private System.Windows.Forms.Label explicatieLbl;
        private System.Windows.Forms.Label header;
    }
}