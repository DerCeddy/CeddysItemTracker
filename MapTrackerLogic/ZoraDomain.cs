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
        public void ItemLogic_ZoraDomain()
        {
            Panel maptracker_Panel = maptracker;
            //Zora Domain Child Checks
            if (Has(Scales) || (Bomb.State == 1 && Has(ZeldasLullaby)))
            {
                Pb("Zora Domain", "Chest", maptracker_Panel).ForeColor = Available;
                Pb("Zora Domain", "Diving Game", maptracker_Panel).ForeColor = Available;
            }
            else
            {
                Pb("Zora Domain", "Chest", maptracker_Panel).ForeColor = red;
                Pb("Zora Domain", "Diving Game", maptracker_Panel).ForeColor = red;
            }
            //King Zora Thawed
            if (Has(ZeldasLullaby) && ((Has(RutoLetter) && (Has(Bomb) || Has(Scales))) || (Wallet.State == 2 && has_bottle)))
            {
                Pb("Zora Domain", "King Zora Thawed", maptracker_Panel).ForeColor = Available;
            }
            else
            {
                Pb("Zora Domain", "King Zora Thawed", maptracker_Panel).ForeColor = red;
            }
            //Skulltula
            if (Has(Hookshot) && Has(ZeldasLullaby))
            {
                tokensAvailable++;
            }
        }
    }
}
