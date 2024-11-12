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
        public void ItemLogic_ShopShuffle()
        {
            Panel maptracker_Panel = maptracker;
            if (ShopShuffle)
            {
                //Goron Shop
                if (Has(Bomb) || Has(Bow) || Has(Strength) || (Has(Dins) && Has(Magic)))
                {
                    Pb("Goron City", "Shop Top Left", maptracker_Panel).ForeColor = Available;
                    Pb("Goron City", "Shop Top Right", maptracker_Panel).ForeColor = Available;
                    Pb("Goron City", "Shop Bottom Left", maptracker_Panel).ForeColor = Available;
                    Pb("Goron City", "Shop Bottom Right", maptracker_Panel).ForeColor = Available;
                }
                else
                {
                    Pb("Goron City", "Shop Top Left", maptracker_Panel).ForeColor = red;
                    Pb("Goron City", "Shop Top Right", maptracker_Panel).ForeColor = red;
                    Pb("Goron City", "Shop Bottom Left", maptracker_Panel).ForeColor = red;
                    Pb("Goron City", "Shop Bottom Right", maptracker_Panel).ForeColor = red;
                }
                //Zoras Domain
                if ((Has(ZeldasLullaby) && (has_bottle && Wallet.State == 2 || Has(Bomb))) || Has(Scales))
                {
                    Pb("Zora Domain", "Shop Top Left", maptracker_Panel).ForeColor = Available;
                    Pb("Zora Domain", "Shop Top Right", maptracker_Panel).ForeColor = Available;
                    Pb("Zora Domain", "Shop Bottom Left", maptracker_Panel).ForeColor = Available;
                    Pb("Zora Domain", "Shop Bottom Right", maptracker_Panel).ForeColor = Available;
                }
                else
                {
                    Pb("Zora Domain", "Shop Top Left", maptracker_Panel).ForeColor = red;
                    Pb("Zora Domain", "Shop Top Right", maptracker_Panel).ForeColor = red;
                    Pb("Zora Domain", "Shop Bottom Left", maptracker_Panel).ForeColor = red;
                    Pb("Zora Domain", "Shop Bottom Right", maptracker_Panel).ForeColor = red;
                }
            }
        }
    }
}
