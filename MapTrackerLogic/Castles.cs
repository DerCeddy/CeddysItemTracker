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
        public void ItemLogic_Castles()
        {
            Panel maptracker_Panel = maptracker;
            //HC
            if (has_explosives && Has(ZeldasLullaby))
            {
                Pb("Castles", "HC Great Fairy Reward", maptracker_Panel).ForeColor = Available;
            }
            else
            {
                Pb("Castles", "HC Great Fairy Reward", maptracker_Panel).ForeColor = red;
            }
            //OGC
            if (Strength.State == 3)
            {
                Pb("Castles", "GC Great Fairy Reward", maptracker_Panel).ForeColor = Available;
            }
            else
            {
                Pb("Castles", "GC Great Fairy Reward", maptracker_Panel).ForeColor = red;
            }
            //SKulltula
            if (Has(SongOfStorms) && Has(Bomb))
            {
                tokensAvailable++;
            }
        }
    }
}
