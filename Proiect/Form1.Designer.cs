namespace Proiect
{
    partial class Form1
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Homepage = new System.Windows.Forms.ToolStripMenuItem();
            this.romanaMeniu = new System.Windows.Forms.ToolStripMenuItem();
            this.romanaEnglezaMeniu = new System.Windows.Forms.ToolStripMenuItem();
            this.romanaGermanaMeniu = new System.Windows.Forms.ToolStripMenuItem();
            this.englezaMeniu = new System.Windows.Forms.ToolStripMenuItem();
            this.englezaRomanaMeniu = new System.Windows.Forms.ToolStripMenuItem();
            this.englezaGermanaMeniu = new System.Windows.Forms.ToolStripMenuItem();
            this.germanaMeniu = new System.Windows.Forms.ToolStripMenuItem();
            this.germanaRomanaMeniu = new System.Windows.Forms.ToolStripMenuItem();
            this.germanaEnglezaMeniu = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainContainer = new System.Windows.Forms.Panel();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 10);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(57, 6);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Homepage,
            this.romanaMeniu,
            this.englezaMeniu,
            this.germanaMeniu,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Homepage
            // 
            this.Homepage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Homepage.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14F);
            this.Homepage.Name = "Homepage";
            this.Homepage.Size = new System.Drawing.Size(101, 29);
            this.Homepage.Text = "Dictionar";
            this.Homepage.Click += new System.EventHandler(this.Homepage_Click);
            // 
            // romanaMeniu
            // 
            this.romanaMeniu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.romanaEnglezaMeniu,
            this.romanaGermanaMeniu});
            this.romanaMeniu.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.romanaMeniu.Name = "romanaMeniu";
            this.romanaMeniu.Size = new System.Drawing.Size(67, 29);
            this.romanaMeniu.Text = "Romana";
            // 
            // romanaEnglezaMeniu
            // 
            this.romanaEnglezaMeniu.Name = "romanaEnglezaMeniu";
            this.romanaEnglezaMeniu.Size = new System.Drawing.Size(122, 22);
            this.romanaEnglezaMeniu.Text = "Engleza";
            this.romanaEnglezaMeniu.Click += new System.EventHandler(this.romanaEnglezaMeniu_Click);
            // 
            // romanaGermanaMeniu
            // 
            this.romanaGermanaMeniu.Name = "romanaGermanaMeniu";
            this.romanaGermanaMeniu.Size = new System.Drawing.Size(122, 22);
            this.romanaGermanaMeniu.Text = "Germana";
            this.romanaGermanaMeniu.Click += new System.EventHandler(this.romanaGermanaMeniu_Click);
            // 
            // englezaMeniu
            // 
            this.englezaMeniu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.englezaRomanaMeniu,
            this.englezaGermanaMeniu});
            this.englezaMeniu.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.englezaMeniu.Name = "englezaMeniu";
            this.englezaMeniu.Size = new System.Drawing.Size(66, 29);
            this.englezaMeniu.Text = "Engleza";
            // 
            // englezaRomanaMeniu
            // 
            this.englezaRomanaMeniu.Name = "englezaRomanaMeniu";
            this.englezaRomanaMeniu.Size = new System.Drawing.Size(122, 22);
            this.englezaRomanaMeniu.Text = "Romana";
            this.englezaRomanaMeniu.Click += new System.EventHandler(this.englezaRomanaMeniu_Click);
            // 
            // englezaGermanaMeniu
            // 
            this.englezaGermanaMeniu.Name = "englezaGermanaMeniu";
            this.englezaGermanaMeniu.Size = new System.Drawing.Size(122, 22);
            this.englezaGermanaMeniu.Text = "Germana";
            this.englezaGermanaMeniu.Click += new System.EventHandler(this.englezaGermanaMeniu_Click);
            // 
            // germanaMeniu
            // 
            this.germanaMeniu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.germanaRomanaMeniu,
            this.germanaEnglezaMeniu});
            this.germanaMeniu.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.germanaMeniu.Name = "germanaMeniu";
            this.germanaMeniu.Size = new System.Drawing.Size(72, 29);
            this.germanaMeniu.Text = "Germana";
            // 
            // germanaRomanaMeniu
            // 
            this.germanaRomanaMeniu.Name = "germanaRomanaMeniu";
            this.germanaRomanaMeniu.Size = new System.Drawing.Size(118, 22);
            this.germanaRomanaMeniu.Text = "Romana";
            this.germanaRomanaMeniu.Click += new System.EventHandler(this.germanaRomanaMeniu_Click);
            // 
            // germanaEnglezaMeniu
            // 
            this.germanaEnglezaMeniu.Name = "germanaEnglezaMeniu";
            this.germanaEnglezaMeniu.Size = new System.Drawing.Size(118, 22);
            this.germanaEnglezaMeniu.Text = "Engleza";
            this.germanaEnglezaMeniu.Click += new System.EventHandler(this.germanaEnglezaMeniu_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(42, 29);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // MainContainer
            // 
            this.MainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainContainer.Location = new System.Drawing.Point(0, 33);
            this.MainContainer.Name = "MainContainer";
            this.MainContainer.Size = new System.Drawing.Size(800, 417);
            this.MainContainer.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainContainer);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Proiect";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Homepage;
        private System.Windows.Forms.ToolStripMenuItem romanaMeniu;
        private System.Windows.Forms.ToolStripMenuItem englezaMeniu;
        private System.Windows.Forms.ToolStripMenuItem romanaEnglezaMeniu;
        private System.Windows.Forms.ToolStripMenuItem romanaGermanaMeniu;
        private System.Windows.Forms.ToolStripMenuItem englezaRomanaMeniu;
        private System.Windows.Forms.ToolStripMenuItem englezaGermanaMeniu;
        private System.Windows.Forms.ToolStripMenuItem germanaMeniu;
        private System.Windows.Forms.ToolStripMenuItem germanaRomanaMeniu;
        private System.Windows.Forms.ToolStripMenuItem germanaEnglezaMeniu;
        private System.Windows.Forms.Panel MainContainer;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

