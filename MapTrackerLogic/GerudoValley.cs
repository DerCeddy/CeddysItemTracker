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
        public void ItemLogic_GerudoValley()
        {
            Panel maptracker_Panel = maptracker;
            if (Has(Hammer) && (Has(EponasSong) || has_longshot))
            {
                Pb("Gerudo Valley", "Hammer Chest", maptracker_Panel).ForeColor = Available;
            }
            else
            {
                Pb("Gerudo Valley", "Hammer Chest", maptracker_Panel).ForeColor = red;
            }
            //Skulltula
            if (Has(Hookshot) && (Has(EponasSong) || has_longshot))
            {
                tokensAvailable += 2;
            }
        }
    }
}
