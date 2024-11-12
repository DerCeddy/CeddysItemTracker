using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CeddysItemTracker.Form1;

namespace CeddysItemTracker
{
    partial class Form1
    {
        public void ItemLogic_SFM()
        {
            Panel maptracker_Panel = maptracker;
            //Wolfo Grotto
            if (Has(Bomb) || ((Has(SariasSong) || Has(Minuet)) && Has(Hammer)))
            {
                Pb("Sacred Forest Meadow", "Wolfo Grotto", maptracker_Panel).ForeColor = Available;
            }
            else
            {
                Pb("Sacred Forest Meadow", "Wolfo Grotto", maptracker_Panel).ForeColor = red;
            }
            //Shiek in Forest
            if (Has(SariasSong) || Has(Minuet))
            {
                Pb("Sacred Forest Meadow", "Shiek in Forest", maptracker_Panel).ForeColor = Available;
            }
            else
            {
                Pb("Sacred Forest Meadow", "Shiek in Forest", maptracker_Panel).ForeColor = red;
            }
            //Skulltula
            if (Has(Hookshot))
            {
                tokensAvailable++;
            }
        }
    }
}
