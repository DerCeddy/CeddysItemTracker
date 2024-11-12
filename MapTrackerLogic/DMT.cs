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
        public void ItemLogic_DMT()
        {
            Panel maptracker_Panel = maptracker;
            //DMT Chest
            if (can_blast_or_smash)
            {
                Pb("Death Mountain Trail", "Chest", maptracker_Panel).ForeColor = Available;
            }
            else
            {
                Pb("Death Mountain Trail", "Chest", maptracker_Panel).ForeColor = red;
            }
            //Storms Grotto
            if (Has(SongOfStorms))
            {
                Pb("Death Mountain Trail", "Storms Grotto Chest", maptracker_Panel).ForeColor = Available;
            }
            else
            {
                Pb("Death Mountain Trail", "Storms Grotto Chest", maptracker_Panel).ForeColor = red;
            }
            //Great Fairy
            if (can_blast_or_smash && Has(ZeldasLullaby))
            {
                Pb("Death Mountain Trail", "Great Fairy Reward", maptracker_Panel).ForeColor = Available;
            }
            else
            {
                Pb("Death Mountain Trail", "Great Fairy Reward", maptracker_Panel).ForeColor = red;
            }
            //Big Goron
            if (AdultTradeItems.State >= 3 && can_blast_or_smash)
            {
                Pb("Death Mountain Trail", "Biggoron", maptracker_Panel).ForeColor = Available;
            }
            else
            {
                Pb("Death Mountain Trail", "Biggoron", maptracker_Panel).ForeColor = red;
            }
            //Skulls
            if (has_explosives && has_bottle)
            {
                tokensAvailable += 1;
            }
            if (Has(Bomb))
            {
                tokensAvailable += 1;
            }
            if (Has(Hammer))
            {
                tokensAvailable += 2;
            }
        }
    }
}
