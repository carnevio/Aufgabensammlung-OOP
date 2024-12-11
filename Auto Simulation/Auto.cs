using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auto_Simulation
{
    internal class Auto
    {
        int aktuellegeschwindigkeit;
        int aktuellergang;
        bool motoran;
        string marke;
        int ps;
        int tank;

        public int AktuelleGeschwindigkeit
        {
            get { return aktuellegeschwindigkeit; }
            

        }

        public int AktuellerGang
        {
            get { return aktuellergang; }
        }

        public bool MotorAn
        {
            get { return motoran; }
        }

        public string Marke
        {
            get { return marke; }
        }

        public int PS
        {
            get { return ps; }
        }

        public int Tank
        {
            get { return tank; }
        }


        public Auto(string marke, int ps)
        {
            this.marke = marke;
            this.ps = ps;

        }

        public void Auftanken()
        {
            tank = 100;
        }

        public void Bremsen()
        {
            if (aktuellegeschwindigkeit > 0)
            {
                aktuellegeschwindigkeit -= 10;
            }
        }

        public void GibGas()
        {
            if (motoran == true)
            {
                if (aktuellegeschwindigkeit < ps)
                {
                    if (tank > 0)
                    {
                        aktuellegeschwindigkeit += (ps / 50);
                        tank -= (aktuellegeschwindigkeit/100) + (ps /100);

                        switch (aktuellegeschwindigkeit)
                        {
                            case int n when (n > 101):
                                aktuellergang = 6;
                                break;
                            case int n when (n > 70):
                                aktuellergang = 5;
                                break;
                            case int n when (n > 40):
                                aktuellergang = 4;
                                break;
                            case int n when (n > 20):
                                aktuellergang = 3;
                                break;
                            case int n when (n > 10):
                                aktuellergang = 2;
                                break;
                            case int n when (n > 0):
                                aktuellergang = 1;
                                break;
                            default:
                                MessageBox.Show("Ungültige Geschwindigkeit");
                                break;
                        }
                    }
                    else if (tank <= 0)
                    {
                        tank = 0;
                        aktuellegeschwindigkeit = 0;
                        aktuellergang = 0;
                        motoran = false;
                        MessageBox.Show("Tank ist leer");
                    }
                }
            }
        }

        public void Hupe()
        {
            MessageBox.Show("Hupen");
        }

        public void MotorAus()
        {
            motoran = false;
        }

        public void StarteMotor()
        {
            if (tank > 0)
            {
                motoran = true;
            }
        }

        

        public override string ToString()
        {
            return Marke + PS;

        
        }
    }
}
