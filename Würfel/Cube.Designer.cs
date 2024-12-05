namespace Würfel
{
    partial class Cube
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
            this.Würfeln = new System.Windows.Forms.Button();
            this.Zahl = new System.Windows.Forms.Label();
            this.LezterWurf = new System.Windows.Forms.Label();
            this.LetzerWurfZahl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Würfeln
            // 
            this.Würfeln.Location = new System.Drawing.Point(56, 120);
            this.Würfeln.Name = "Würfeln";
            this.Würfeln.Size = new System.Drawing.Size(246, 113);
            this.Würfeln.TabIndex = 0;
            this.Würfeln.Text = "Würfeln";
            this.Würfeln.UseVisualStyleBackColor = true;
            this.Würfeln.Click += new System.EventHandler(this.Würfeln_Click);
            // 
            // Zahl
            // 
            this.Zahl.AutoSize = true;
            this.Zahl.Location = new System.Drawing.Point(471, 166);
            this.Zahl.Name = "Zahl";
            this.Zahl.Size = new System.Drawing.Size(18, 20);
            this.Zahl.TabIndex = 1;
            this.Zahl.Text = "?";
            // 
            // LezterWurf
            // 
            this.LezterWurf.AutoSize = true;
            this.LezterWurf.Location = new System.Drawing.Point(73, 381);
            this.LezterWurf.Name = "LezterWurf";
            this.LezterWurf.Size = new System.Drawing.Size(100, 20);
            this.LezterWurf.TabIndex = 2;
            this.LezterWurf.Text = "Letzer Wurf: ";
            // 
            // LetzerWurfZahl
            // 
            this.LetzerWurfZahl.AutoSize = true;
            this.LetzerWurfZahl.Location = new System.Drawing.Point(250, 380);
            this.LetzerWurfZahl.Name = "LetzerWurfZahl";
            this.LetzerWurfZahl.Size = new System.Drawing.Size(18, 20);
            this.LetzerWurfZahl.TabIndex = 3;
            this.LetzerWurfZahl.Text = "?";
            // 
            // Cube
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LetzerWurfZahl);
            this.Controls.Add(this.LezterWurf);
            this.Controls.Add(this.Zahl);
            this.Controls.Add(this.Würfeln);
            this.Name = "Cube";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Würfeln;
        private System.Windows.Forms.Label Zahl;
        private System.Windows.Forms.Label LezterWurf;
        private System.Windows.Forms.Label LetzerWurfZahl;
    }
}

