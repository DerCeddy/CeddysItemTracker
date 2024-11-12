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
        public void ItemLogic_ZoraFountain()
        {
            Panel maptracker_Panel = maptracker;
            //Zora Fountain Fairy
            if (Has(RutoLetter) && Bomb.State == 1 && Has(ZeldasLullaby))
            {
                Pb("Zora Fountain", "Great Fairy Reward", maptracker_Panel).ForeColor = Available;
            }
            else
            {
                Pb("Zora Fountain", "Great Fairy Reward", maptracker_Panel).ForeColor = red;
            }
            //Zora Fountain Freestanding PoH
            if (Has(RutoLetter) && Has(ZeldasLullaby) && (Bomb.State == 1 || Has(Scales)))
            {
                Pb("Zora Fountain", "Iceberg Freestanding PoH", maptracker_Panel).ForeColor = Available;
                tokensAvailable += 1;
            }
            else
            {
                Pb("Zora Fountain", "Iceberg Freestanding PoH", maptracker_Panel).ForeColor = red;
            }
            //Bottom PoH
            if (Has(RutoLetter) && Has(IronBoots) && Has(ZeldasLullaby) && (Bomb.State == 1 || Has(Scales)))
            {
                Pb("Zora Fountain", "Bottom Freestanding PoH", maptracker_Panel).ForeColor = Available;
            }
            else
            {
                Pb("Zora Fountain", "Bottom Freestanding PoH", maptracker_Panel).ForeColor = red;
            }
            //Skulls
            if (Has(RutoLetter) && Has(ZeldasLullaby) && Strength.State >= 2)
            {
                tokensAvailable += 1;
            }
            if (Has(RutoLetter) && Has(ZeldasLullaby) && (Bomb.State == 1 || Has(Scales)) && Has(Boomerang))
            {
                tokensAvailable += 1;
            }
        }
    }
}
