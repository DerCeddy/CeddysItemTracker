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
        public void ItemLogic_Jabu()
        {
            Panel maptracker_Panel = maptracker;
            //Boomerang Chest
            if (Has(RutoLetter) && (Has(Scales) || (Bomb.State == 1 && Has(ZeldasLullaby))))
            {
                Pb("Jabu-Jabus Belly", "Boomerang Chest", maptracker_Panel).ForeColor = Available;
                tokensAvailable += 1;
            }
            else
            {
                Pb("Jabu-Jabus Belly", "Boomerang Chest", maptracker_Panel).ForeColor = red;
            }
            //Rest
            if (Has(RutoLetter) && ((Has(ZeldasLullaby) && Bomb.State == 1) || Has(Scales)) && Has(Boomerang))
            {
                Pb("Jabu-Jabus Belly", "Barinade Heart", maptracker_Panel).ForeColor = Available;
                Pb("Jabu-Jabus Belly", "Compass Chest", maptracker_Panel).ForeColor = Available;
                Pb("Jabu-Jabus Belly", "Map Chest", maptracker_Panel).ForeColor = Available;
                tokensAvailable += 3;
            }
            else
            {
                Pb("Jabu-Jabus Belly", "Barinade Heart", maptracker_Panel).ForeColor = red;
                Pb("Jabu-Jabus Belly", "Compass Chest", maptracker_Panel).ForeColor = red;
                Pb("Jabu-Jabus Belly", "Map Chest", maptracker_Panel).ForeColor = red;
            }
        }
    }
}
