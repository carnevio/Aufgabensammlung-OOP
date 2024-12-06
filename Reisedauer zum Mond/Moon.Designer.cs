namespace Reisedauer_zum_Mond
{
    partial class Moon
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
            this.Titel = new System.Windows.Forms.Label();
            this.inTagen = new System.Windows.Forms.RadioButton();
            this.inStunden = new System.Windows.Forms.RadioButton();
            this.Text = new System.Windows.Forms.Label();
            this.Geschwindigkeit = new System.Windows.Forms.TextBox();
            this.Reisedauerberechnen = new System.Windows.Forms.Button();
            this.Text2 = new System.Windows.Forms.Label();
            this.Reisedauer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Titel
            // 
            this.Titel.AutoSize = true;
            this.Titel.Location = new System.Drawing.Point(35, 31);
            this.Titel.Name = "Titel";
            this.Titel.Size = new System.Drawing.Size(249, 20);
            this.Titel.TabIndex = 0;
            this.Titel.Text = "Reisedauer zum Mond berechnen";
            // 
            // inTagen
            // 
            this.inTagen.AutoSize = true;
            this.inTagen.Location = new System.Drawing.Point(74, 140);
            this.inTagen.Name = "inTagen";
            this.inTagen.Size = new System.Drawing.Size(95, 24);
            this.inTagen.TabIndex = 1;
            this.inTagen.TabStop = true;
            this.inTagen.Text = "in Tagen";
            this.inTagen.UseVisualStyleBackColor = true;
            // 
            // inStunden
            // 
            this.inStunden.AutoSize = true;
            this.inStunden.Location = new System.Drawing.Point(208, 140);
            this.inStunden.Name = "inStunden";
            this.inStunden.Size = new System.Drawing.Size(111, 24);
            this.inStunden.TabIndex = 2;
            this.inStunden.TabStop = true;
            this.inStunden.Text = "in Stunden";
            this.inStunden.UseVisualStyleBackColor = true;
            // 
            // Text
            // 
            this.Text.AutoSize = true;
            this.Text.Location = new System.Drawing.Point(74, 206);
            this.Text.Name = "Text";
            this.Text.Size = new System.Drawing.Size(163, 20);
            this.Text.TabIndex = 3;
            this.Text.Text = "Geschwindigkeit km/h";
            // 
            // Geschwindigkeit
            // 
            this.Geschwindigkeit.Location = new System.Drawing.Point(277, 206);
            this.Geschwindigkeit.Name = "Geschwindigkeit";
            this.Geschwindigkeit.Size = new System.Drawing.Size(100, 26);
            this.Geschwindigkeit.TabIndex = 4;
            // 
            // Reisedauerberechnen
            // 
            this.Reisedauerberechnen.Location = new System.Drawing.Point(74, 266);
            this.Reisedauerberechnen.Name = "Reisedauerberechnen";
            this.Reisedauerberechnen.Size = new System.Drawing.Size(329, 54);
            this.Reisedauerberechnen.TabIndex = 5;
            this.Reisedauerberechnen.Text = "Reisedauer berechnen";
            this.Reisedauerberechnen.UseVisualStyleBackColor = true;
            this.Reisedauerberechnen.Click += new System.EventHandler(this.Reisedauerberechnen_Click);
            // 
            // Text2
            // 
            this.Text2.AutoSize = true;
            this.Text2.Location = new System.Drawing.Point(74, 353);
            this.Text2.Name = "Text2";
            this.Text2.Size = new System.Drawing.Size(159, 20);
            this.Text2.TabIndex = 6;
            this.Text2.Text = "Ausgabe Reisedauer";
            // 
            // Reisedauer
            // 
            this.Reisedauer.Location = new System.Drawing.Point(259, 347);
            this.Reisedauer.Name = "Reisedauer";
            this.Reisedauer.Size = new System.Drawing.Size(100, 26);
            this.Reisedauer.TabIndex = 7;
            // 
            // Moon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 450);
            this.Controls.Add(this.Reisedauer);
            this.Controls.Add(this.Text2);
            this.Controls.Add(this.Reisedauerberechnen);
            this.Controls.Add(this.Geschwindigkeit);
            this.Controls.Add(this.Text);
            this.Controls.Add(this.inStunden);
            this.Controls.Add(this.inTagen);
            this.Controls.Add(this.Titel);
            this.Name = "Moon";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Titel;
        private System.Windows.Forms.RadioButton inTagen;
        private System.Windows.Forms.RadioButton inStunden;
        private System.Windows.Forms.Label Text;
        private System.Windows.Forms.TextBox Geschwindigkeit;
        private System.Windows.Forms.Button Reisedauerberechnen;
        private System.Windows.Forms.Label Text2;
        private System.Windows.Forms.TextBox Reisedauer;
    }
}

