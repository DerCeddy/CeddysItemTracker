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
        public void ItemLogic_DMC()
        {
            Panel maptracker_Panel = maptracker;
            //DMC Freestanding PoH
            if (has_explosives || Has(Strength) || Has(Bow) || (Has(Bolero) && (Has(Hookshot) || Has(HoverBoots))))
            {
                Pb("Death Mountain Crater", "Wall Freestanding PoH", maptracker_Panel).ForeColor = Available;
            }
            else
            {
                Pb("Death Mountain Crater", "Wall Freestanding PoH", maptracker_Panel).ForeColor = red;
            }
            //DMC Upper Grotto
            if (Has(Bomb) || (Has(Hammer) && (Has(Strength) || Has(Bow) || (Has(Bolero) && (Has(Hookshot) || Has(HoverBoots))))))
            {
                Pb("Death Mountain Crater", "Upper Grotto Chest", maptracker_Panel).ForeColor = Available;
            }
            else
            {
                Pb("Death Mountain Crater", "Upper Grotto Chest", maptracker_Panel).ForeColor = red;
            }
            //DMC Volcano PoH
            if (Has(HoverBoots) && (has_explosives || Has(Strength) || Has(Bow) || Has(Bolero)) || (Has(Beans) && Has(Bolero)))
            {
                Pb("Death Mountain Crater", "Volcano Freestanding PoH", maptracker_Panel).ForeColor = Available;
            }
            else
            {
                Pb("Death Mountain Crater", "Volcano Freestanding PoH", maptracker_Panel).ForeColor = red;
            }
            //DMC Greaty Fairy
            if (Has(Hammer) && Has(ZeldasLullaby) && (Bomb.State == 1 || Has(Strength) || Has(Bow) || (Has(Bolero) && (Has(Hookshot) || Has(HoverBoots)))))
            {
                Pb("Death Mountain Crater", "Great Fairy Reward", maptracker_Panel).ForeColor = Available;
            }
            else
            {
                Pb("Death Mountain Crater", "Great Fairy Reward", maptracker_Panel).ForeColor = red;
            }
            //Shiek at Crater
            if (craterplatformaccess == 1)
            {
                Pb("Death Mountain Crater", "Shiek at Crater", maptracker_Panel).ForeColor = Available;
            }
            else
            {
                Pb("Death Mountain Crater", "Shiek at Crater", maptracker_Panel).ForeColor = red;
            }
            //Skulltula
            if (Has(Bomb))
            {
                tokensAvailable++;
            }
            if (Has(Bolero) && has_bottle)
            {
                tokensAvailable++;
            }
        }
    }
}
