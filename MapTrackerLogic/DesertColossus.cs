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
        public void ItemLogic_DesertColossus()
        {
            Panel maptracker_Panel = maptracker;
            //Shiek at Colossus
            if (desertaccess == 1)
            {
                Pb("Desert Colossus", "Shiek at Colossus", maptracker_Panel).ForeColor = Available;
            }
            else
            {
                Pb("Desert Colossus", "Shiek at Colossus", maptracker_Panel).ForeColor = red;
            }
            //Colossus Fairy
            if (desertaccess == 1 && Bomb.State == 1 && Has(ZeldasLullaby))
            {
                Pb("Desert Colossus", "Great Fairy Reward", maptracker_Panel).ForeColor = Available;
            }
            else
            {
                Pb("Desert Colossus", "Great Fairy Reward", maptracker_Panel).ForeColor = red;
            }
            //Arc
            if (desertaccess == 1 && Has(Beans))
            {
                Pb("Desert Colossus", "Freestanding PoH", maptracker_Panel).ForeColor = Available;
            }
            else if (desertaccess == 1 && (Has(Bomb) || Has(Scales)))
            {
                Pb("Desert Colossus", "Freestanding PoH", maptracker_Panel).ForeColor = coulddo;
            }
            else
            {
                Pb("Desert Colossus", "Freestanding PoH", maptracker_Panel).ForeColor = red;
            }
            //Skulltula
            if (desertaccess == 1 && Has(Hookshot))
            {
                tokensAvailable++;
            }
            if (desertaccess == 1 && (has_longshot || can_get_beans))
            {
                tokensAvailable++;
            }
            if (desertaccess == 1 && has_bottle)
            {
                tokensAvailable++;
            }
        }
    }
}
