﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Würfel
{
    public partial class Cube : Form
    {
        public Cube()
        {
            InitializeComponent();
        }

        Wuerfel w = new Wuerfel();

        private void Würfeln_Click(object sender, EventArgs e)
        {
            Zahl.Text = Convert.ToString(w.Werfen());
            LetzerWurfZahl.Text = Convert.ToString(w.LetzterWurf);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            alleZahlen.Text = string.Join(", ", w.AlleWuerfe);
        }
    }
}
