using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using static CeddysItemTracker.Form1;

namespace CeddysItemTracker
{
    partial class Form1
    {
        public void ItemLogic_Wasteland()
        {
            Panel maptracker_Panel = maptracker;
            if (has_or_can_get_gerudocard && Has(Magic) && (has_longshot || Has(HoverBoots)) && ((Has(Bow) && Has(FireArrow)) || Has(Dins)))
            {
                Pb("Haunted Wasteland", "Wasteland Chest", maptracker_Panel).ForeColor = Available;
            }
            else
            {
                Pb("Haunted Wasteland", "Wasteland Chest", maptracker_Panel).ForeColor = red;
            }
            //Skulltula
            if (has_or_can_get_gerudocard && Has(Hookshot) && (has_longshot || Has(HoverBoots)))
            {
                tokensAvailable++;
            }
        }
    }
}
