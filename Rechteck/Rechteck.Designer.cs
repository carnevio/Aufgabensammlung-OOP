namespace Rechteck
{
    partial class Rechteck
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
            this.Breite = new System.Windows.Forms.Label();
            this.Höhe = new System.Windows.Forms.Label();
            this.Fläche = new System.Windows.Forms.Label();
            this.EingabeBreite = new System.Windows.Forms.TextBox();
            this.EingabeHöhe = new System.Windows.Forms.TextBox();
            this.AusgabeFläche = new System.Windows.Forms.TextBox();
            this.Berechnen = new System.Windows.Forms.Button();
            this.Beenden = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Breite
            // 
            this.Breite.AutoSize = true;
            this.Breite.Location = new System.Drawing.Point(50, 93);
            this.Breite.Name = "Breite";
            this.Breite.Size = new System.Drawing.Size(161, 20);
            this.Breite.TabIndex = 0;
            this.Breite.Text = "Breite des Rechtecks";
            // 
            // Höhe
            // 
            this.Höhe.AutoSize = true;
            this.Höhe.Location = new System.Drawing.Point(50, 141);
            this.Höhe.Name = "Höhe";
            this.Höhe.Size = new System.Drawing.Size(158, 20);
            this.Höhe.TabIndex = 1;
            this.Höhe.Text = "Höhe des Rechtecks";
            // 
            // Fläche
            // 
            this.Fläche.AutoSize = true;
            this.Fläche.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Fläche.Location = new System.Drawing.Point(54, 296);
            this.Fläche.Name = "Fläche";
            this.Fläche.Size = new System.Drawing.Size(135, 20);
            this.Fläche.TabIndex = 2;
            this.Fläche.Text = "Ausgabe (Fläche)";
            // 
            // EingabeBreite
            // 
            this.EingabeBreite.Location = new System.Drawing.Point(319, 90);
            this.EingabeBreite.Name = "EingabeBreite";
            this.EingabeBreite.Size = new System.Drawing.Size(177, 26);
            this.EingabeBreite.TabIndex = 3;
            // 
            // EingabeHöhe
            // 
            this.EingabeHöhe.Location = new System.Drawing.Point(319, 141);
            this.EingabeHöhe.Name = "EingabeHöhe";
            this.EingabeHöhe.Size = new System.Drawing.Size(177, 26);
            this.EingabeHöhe.TabIndex = 4;
            // 
            // AusgabeFläche
            // 
            this.AusgabeFläche.Location = new System.Drawing.Point(319, 296);
            this.AusgabeFläche.Name = "AusgabeFläche";
            this.AusgabeFläche.Size = new System.Drawing.Size(177, 26);
            this.AusgabeFläche.TabIndex = 5;
            // 
            // Berechnen
            // 
            this.Berechnen.Location = new System.Drawing.Point(579, 80);
            this.Berechnen.Name = "Berechnen";
            this.Berechnen.Size = new System.Drawing.Size(194, 46);
            this.Berechnen.TabIndex = 6;
            this.Berechnen.Text = "Berechnen";
            this.Berechnen.UseVisualStyleBackColor = true;
            this.Berechnen.Click += new System.EventHandler(this.button1_Click);
            // 
            // Beenden
            // 
            this.Beenden.Location = new System.Drawing.Point(569, 283);
            this.Beenden.Name = "Beenden";
            this.Beenden.Size = new System.Drawing.Size(194, 47);
            this.Beenden.TabIndex = 7;
            this.Beenden.Text = "Beenden";
            this.Beenden.UseVisualStyleBackColor = true;
            this.Beenden.Click += new System.EventHandler(this.Beenden_Click);
            // 
            // Rechteck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Beenden);
            this.Controls.Add(this.Berechnen);
            this.Controls.Add(this.AusgabeFläche);
            this.Controls.Add(this.EingabeHöhe);
            this.Controls.Add(this.EingabeBreite);
            this.Controls.Add(this.Fläche);
            this.Controls.Add(this.Höhe);
            this.Controls.Add(this.Breite);
            this.Name = "Rechteck";
            this.Text = "Fläche des Rechtecks berechnen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Breite;
        private System.Windows.Forms.Label Höhe;
        private System.Windows.Forms.Label Fläche;
        private System.Windows.Forms.TextBox EingabeBreite;
        private System.Windows.Forms.TextBox EingabeHöhe;
        private System.Windows.Forms.TextBox AusgabeFläche;
        private System.Windows.Forms.Button Berechnen;
        private System.Windows.Forms.Button Beenden;
    }
}

