namespace Auto_Simulation
{
    partial class car
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(car));
            this.label1 = new System.Windows.Forms.Label();
            this.Autoauswahl = new System.Windows.Forms.ComboBox();
            this.Autoschlüssel = new System.Windows.Forms.Button();
            this.Hupe = new System.Windows.Forms.Button();
            this.Zapfhan = new System.Windows.Forms.Button();
            this.Bremse = new System.Windows.Forms.Button();
            this.Gas = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gear = new System.Windows.Forms.TextBox();
            this.kmH = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Auto wählen:";
            // 
            // Autoauswahl
            // 
            this.Autoauswahl.FormattingEnabled = true;
            this.Autoauswahl.Location = new System.Drawing.Point(214, 22);
            this.Autoauswahl.Name = "Autoauswahl";
            this.Autoauswahl.Size = new System.Drawing.Size(177, 28);
            this.Autoauswahl.TabIndex = 1;
            this.Autoauswahl.SelectedIndexChanged += new System.EventHandler(this.Autoauswahl_SelectedIndexChanged);
            // 
            // Autoschlüssel
            // 
            this.Autoschlüssel.Image = ((System.Drawing.Image)(resources.GetObject("Autoschlüssel.Image")));
            this.Autoschlüssel.Location = new System.Drawing.Point(30, 72);
            this.Autoschlüssel.Name = "Autoschlüssel";
            this.Autoschlüssel.Size = new System.Drawing.Size(77, 68);
            this.Autoschlüssel.TabIndex = 2;
            this.Autoschlüssel.UseVisualStyleBackColor = true;
            this.Autoschlüssel.Click += new System.EventHandler(this.Autoschlüssel_Click);
            // 
            // Hupe
            // 
            this.Hupe.Image = ((System.Drawing.Image)(resources.GetObject("Hupe.Image")));
            this.Hupe.Location = new System.Drawing.Point(30, 177);
            this.Hupe.Name = "Hupe";
            this.Hupe.Size = new System.Drawing.Size(77, 52);
            this.Hupe.TabIndex = 3;
            this.Hupe.UseVisualStyleBackColor = true;
            this.Hupe.Click += new System.EventHandler(this.Hupe_Click);
            // 
            // Zapfhan
            // 
            this.Zapfhan.Image = ((System.Drawing.Image)(resources.GetObject("Zapfhan.Image")));
            this.Zapfhan.Location = new System.Drawing.Point(30, 267);
            this.Zapfhan.Name = "Zapfhan";
            this.Zapfhan.Size = new System.Drawing.Size(77, 46);
            this.Zapfhan.TabIndex = 4;
            this.Zapfhan.UseVisualStyleBackColor = true;
            this.Zapfhan.Click += new System.EventHandler(this.Zapfhan_Click);
            // 
            // Bremse
            // 
            this.Bremse.Location = new System.Drawing.Point(281, 295);
            this.Bremse.Name = "Bremse";
            this.Bremse.Size = new System.Drawing.Size(319, 200);
            this.Bremse.TabIndex = 5;
            this.Bremse.Text = "Bremse";
            this.Bremse.UseVisualStyleBackColor = true;
            this.Bremse.Click += new System.EventHandler(this.Bremse_Click);
            // 
            // Gas
            // 
            this.Gas.Location = new System.Drawing.Point(643, 295);
            this.Gas.Name = "Gas";
            this.Gas.Size = new System.Drawing.Size(139, 199);
            this.Gas.TabIndex = 6;
            this.Gas.Text = "Gas";
            this.Gas.UseVisualStyleBackColor = true;
            this.Gas.Click += new System.EventHandler(this.Gas_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox1.Controls.Add(this.gear);
            this.groupBox1.Controls.Add(this.kmH);
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.Location = new System.Drawing.Point(281, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(544, 197);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // gear
            // 
            this.gear.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.gear.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gear.Location = new System.Drawing.Point(433, 41);
            this.gear.Name = "gear";
            this.gear.Size = new System.Drawing.Size(87, 66);
            this.gear.TabIndex = 2;
            this.gear.Text = "1";
            this.gear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // kmH
            // 
            this.kmH.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.kmH.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kmH.ForeColor = System.Drawing.Color.Lime;
            this.kmH.Location = new System.Drawing.Point(50, 41);
            this.kmH.Name = "kmH";
            this.kmH.Size = new System.Drawing.Size(339, 66);
            this.kmH.TabIndex = 1;
            this.kmH.Text = "0";
            this.kmH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(45, 141);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(475, 36);
            this.progressBar1.TabIndex = 0;
            // 
            // car
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 540);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Gas);
            this.Controls.Add(this.Bremse);
            this.Controls.Add(this.Zapfhan);
            this.Controls.Add(this.Hupe);
            this.Controls.Add(this.Autoschlüssel);
            this.Controls.Add(this.Autoauswahl);
            this.Controls.Add(this.label1);
            this.Name = "car";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Autoauswahl;
        private System.Windows.Forms.Button Autoschlüssel;
        private System.Windows.Forms.Button Hupe;
        private System.Windows.Forms.Button Zapfhan;
        private System.Windows.Forms.Button Bremse;
        private System.Windows.Forms.Button Gas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox kmH;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox gear;
    }
}

