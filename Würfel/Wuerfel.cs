using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Würfel
{
    public class Wuerfel
    {
        Random r = new Random();
        int aktuellerWurf;
        int letzterWurf;
        List<int> allewuerfe = new List<int>();

        public int LetzterWurf
        {
            get { return letzterWurf; }
        }

        public List<int> AlleWuerfe
        {
            get { return allewuerfe; }
        }

        public int Werfen()
        {
            letzterWurf = aktuellerWurf;
            aktuellerWurf = r.Next(1, 7);
            allewuerfe.Add(aktuellerWurf);
            return aktuellerWurf;
        }

        public Wuerfel()
        {
            allewuerfe = new List<int>();
        }

    }
}
