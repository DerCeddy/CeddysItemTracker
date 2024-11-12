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
        public void ItemLogic_IceCavern()
        {
            Panel maptracker_Panel = maptracker;
            if (Has(RutoLetter) && Has(ZeldasLullaby) && (Has(Bomb) || Has(Scales)))
            {
                Pb("Ice Cavern", "Map Chest", maptracker_Panel).ForeColor = Available;
                Pb("Ice Cavern", "Compass Chest", maptracker_Panel).ForeColor = Available;
                Pb("Ice Cavern", "Iron Boots Chest", maptracker_Panel).ForeColor = Available;
                Pb("Ice Cavern", "Freestanding PoH", maptracker_Panel).ForeColor = Available;
                Pb("Ice Cavern", "Shiek at Ice Cavern", maptracker_Panel).ForeColor = Available;
            }
            else
            {
                Pb("Ice Cavern", "Map Chest", maptracker_Panel).ForeColor = red;
                Pb("Ice Cavern", "Compass Chest", maptracker_Panel).ForeColor = red;
                Pb("Ice Cavern", "Iron Boots Chest", maptracker_Panel).ForeColor = red;
                Pb("Ice Cavern", "Freestanding PoH", maptracker_Panel).ForeColor = red;
                Pb("Ice Cavern", "Shiek at Ice Cavern", maptracker_Panel).ForeColor = red;
            }
            if (Has(RutoLetter) && Has(ZeldasLullaby) && (Has(Bomb) || Has(Scales)) && Has(Hookshot))
            {
                tokensAvailable += 3;
            }
        }
    }
}
