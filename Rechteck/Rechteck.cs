using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rechteck
{
    public partial class Rechteck : Form
    {
        public Rechteck()
        {
            InitializeComponent();
        }


        public void button1_Click(object sender, EventArgs e)
        {
            Rechteck1 rechteck = new Rechteck1();
            double height = Convert.ToDouble(EingabeHöhe.Text);
            double width = Convert.ToDouble(EingabeBreite.Text);
            AusgabeFläche.Text = rechteck.GetArea(height, width).ToString();

        }

        private void Beenden_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
