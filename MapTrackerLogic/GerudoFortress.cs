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
        public void ItemLogic_GerudoFortress()
        {
            Panel maptracker_Panel = maptracker;
            /*
            if (Has(EponasSong) || has_longshot)
            {
                Pb("Gerudo Fortress", "Carpenter", maptracker_Panel).ForeColor = Available;
                tokensAvailable++;
            }
            else
            {
                Pb("Gerudo Fortress", "Carpenter", maptracker_Panel).ForeColor = red;
            }  
            */
            if (has_or_can_get_gerudocard && Has(EponasSong) && Has(Bow))
            {
                Pb("Gerudo Fortress", "HBA 1000 Points", maptracker_Panel).ForeColor = Available;
                Pb("Gerudo Fortress", "HBA 1500 Points", maptracker_Panel).ForeColor = Available;
            }
            else
            {
                Pb("Gerudo Fortress", "HBA 1000 Points", maptracker_Panel).ForeColor = red;
                Pb("Gerudo Fortress", "HBA 1500 Points", maptracker_Panel).ForeColor = red;
            }
            if ((Has(Hookshot) || Has(HoverBoots)) && has_or_can_get_gerudocard)
            {
                Pb("Gerudo Fortress", "Chest on Roof", maptracker_Panel).ForeColor = Available;
            }
            else
            {
                Pb("Gerudo Fortress", "Chest on Roof", maptracker_Panel).ForeColor = red;
            }
            //Skulltula
            if ((Has(EponasSong) || has_longshot) && Has(Hookshot))
            {
                tokensAvailable += 2;
            }
        }
    }
}
