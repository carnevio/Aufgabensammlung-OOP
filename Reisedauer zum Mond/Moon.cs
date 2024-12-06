using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reisedauer_zum_Mond
{
    public partial class Moon : Form
    {
        public Moon()
        {
            InitializeComponent();
        }

        private void Reisedauerberechnen_Click(object sender, EventArgs e)
        {
            if (inTagen.Checked)
            {
                Mondreise reise = new Mondreise(Convert.ToDouble(Geschwindigkeit.Text));
                Reisedauer.Text = reise.ReisedauerInTagen().ToString();
            }
            else
            {
                Mondreise reise = new Mondreise(Convert.ToDouble(Geschwindigkeit.Text));
                Reisedauer.Text = reise.ReisedauerInStunden().ToString();
            }
        }
    }
   }
