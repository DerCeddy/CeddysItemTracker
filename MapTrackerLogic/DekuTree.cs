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
        public void ItemLogic_DekuTree()
        {
            Panel maptracker_Panel = maptracker;
            //Deku Tree Entry
            if (Has(KokiriSword))
            {
                Pb("Deku Tree", "Map Chest", maptracker_Panel).ForeColor = Available;
                Pb("Deku Tree", "Compass Chest", maptracker_Panel).ForeColor = Available;
                Pb("Deku Tree", "Basement Chest", maptracker_Panel).ForeColor = Available;
                Pb("Deku Tree", "Slingshot Room Side Chest", maptracker_Panel).ForeColor = Available;
                Pb("Deku Tree", "Slingshot Chest", maptracker_Panel).ForeColor = Available;
                Pb("Deku Tree", "Compass Room Side Chest", maptracker_Panel).ForeColor = Available;
                tokensAvailable += 2;
            }
            else
            {
                Pb("Deku Tree", "Basement Chest", maptracker_Panel).ForeColor = red;
                Pb("Deku Tree", "Compass Chest", maptracker_Panel).ForeColor = red;
                Pb("Deku Tree", "Map Chest", maptracker_Panel).ForeColor = red;
                Pb("Deku Tree", "Slingshot Room Side Chest", maptracker_Panel).ForeColor = red;
                Pb("Deku Tree", "Slingshot Chest", maptracker_Panel).ForeColor = red;
                Pb("Deku Tree", "Compass Room Side Chest", maptracker_Panel).ForeColor = red;
            }
            //Deku Tree Gohma
            if (Has(KokiriSword) && Has(Slingshot))
            {
                Pb("Deku Tree", "Gohma Heart", maptracker_Panel).ForeColor = Available;
            }
            else
            {
                Pb("Deku Tree", "Gohma Heart", maptracker_Panel).ForeColor = red;
            }
            //Skulltula
            if ((Has(Slingshot) || Has(Boomerang)) || (Has(Magic) && Has(Dins)))
            {
                tokensAvailable++;
            }
            if (Has(Bomb) && Has(Boomerang) && Has(KokiriSword))
            {
                tokensAvailable++;
            }
        }
    }  
}
