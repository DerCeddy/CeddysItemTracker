using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeddysItemTracker
{
    partial class Form1
    {
        public void ItemLogic_KokiriForest()
        {
            Panel maptracker_Panel = maptracker;
            //Storms Grotto
            if (Has(SongOfStorms))
            {
                Pb("Kokiri Forest", "Storms Grotto", maptracker_Panel).ForeColor = Available;
            }
            else
            {
                Pb("Kokiri Forest", "Storms Grotto", maptracker_Panel).ForeColor = red;
            }
            if (Has(Hookshot))
            {
                tokensAvailable++;
            }
        }
    }
}
