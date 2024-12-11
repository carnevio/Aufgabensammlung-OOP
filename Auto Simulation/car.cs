using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Auto_Simulation
{
    public partial class car : Form
    {
        public car()
        {
            InitializeComponent();
            Autoauswahl.Items.Add(new Auto("Porsche", 250));
            Autoauswahl.Items.Add(new Auto("Opel", 190));
            Autoauswahl.Items.Add(new Auto("Ferrari", 370));
        }

        Auto auto;
        private void Zapfhan_Click(object sender, EventArgs e)
        {
            auto.Auftanken();
            progressBar1.Value = auto.Tank;
        }

        private void Autoauswahl_SelectedIndexChanged(object sender, EventArgs e)
        {
            auto = (Auto)Autoauswahl.SelectedItem;
            kmH.Text = auto.AktuelleGeschwindigkeit.ToString();
            progressBar1.Value = auto.Tank;
        }

        private void Autoschlüssel_Click(object sender, EventArgs e)
        {
            if (auto.MotorAn == true)
            {
                auto.MotorAus();
                Autoschlüssel.Text = "Motor aus";
            }
            else
            {
                auto.StarteMotor();
                Autoschlüssel.Text = "Motor an";
            }
        }

        private void Bremse_Click(object sender, EventArgs e)
        {
            auto.Bremsen();
            kmH.Text = auto.AktuelleGeschwindigkeit.ToString();

        }

        private void Hupe_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hup, Hup!");
        }

        private void Gas_Click(object sender, EventArgs e)
        {
            auto.GibGas();
            kmH.Text = auto.AktuelleGeschwindigkeit.ToString();
            progressBar1.Value = auto.Tank;
            gear.Text = auto.AktuellerGang.ToString();
            Console.WriteLine($"Tank: {auto.Tank}, ProgressBar Value: {progressBar1.Value}");
        }
    }
}
