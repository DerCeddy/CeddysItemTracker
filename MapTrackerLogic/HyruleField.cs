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
        public void ItemLogic_HyruleField()
        {
            Panel maptracker_Panel = maptracker;
            //Checks under Rocks and Salesman
            if (Has(Bomb) || Has(Hammer))
            {
                Pb("Hyrule Field", "North Grotto", maptracker_Panel).ForeColor = Available;
                Pb("Hyrule Field", "Salesman", maptracker_Panel).ForeColor = Available;
                Pb("Hyrule Field", "Southeast Grotto", maptracker_Panel).ForeColor = Available;
            }
            else
            {
                Pb("Hyrule Field", "North Grotto", maptracker_Panel).ForeColor = red;
                Pb("Hyrule Field", "Salesman", maptracker_Panel).ForeColor = red;
                Pb("Hyrule Field", "Southeast Grotto", maptracker_Panel).ForeColor = red;
            }
            //Diving Grotto
            if ((Has(Bomb) || Has(Hammer)) && (Scales.State == 2 || Has(IronBoots)))
            {
                Pb("Hyrule Field", "Tektite Grotto Freestanding PoH", maptracker_Panel).ForeColor = Available;
            }
            else
            {
                Pb("Hyrule Field", "Tektite Grotto Freestanding PoH", maptracker_Panel).ForeColor = red;
            }
            //Song of Time
            if (Has(KokiriStone) && Has(GoronStone) && Has(ZoraStone))
            {
                Pb("Hyrule Field", "Song of Time", maptracker_Panel).ForeColor = Available;
            }
            else
            {
                Pb("Hyrule Field", "Song of Time", maptracker_Panel).ForeColor = red;
            }
            //Skulltula
            if ((Has(Boomerang) && Has(Bomb)) || (can_blast_or_smash && Has(Hookshot)))
            {
                tokensAvailable++;
            }
            if (has_firesource && Has(Bomb) && (Has(Hookshot) || Has(Boomerang)))
            {
                tokensAvailable++;
            }
        }
    }
}
