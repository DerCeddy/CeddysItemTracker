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
        public void ItemLogic_LakeHylia()
        {
            Panel maptracker_Panel = maptracker;
            //Underwater Item
            if (Has(Scales))
            {
                Pb("Lake Hylia", "Underwater Item", maptracker_Panel).ForeColor = Available;
            }
            else
            {
                Pb("Lake Hylia", "Underwater Item", maptracker_Panel).ForeColor = red;
            }
            //Labdive
            if (Scales.State == 2)
            {
                Pb("Lake Hylia", "Lab Dive", maptracker_Panel).ForeColor = Available;
            }
            else
            {
                Pb("Lake Hylia", "Lab Dive", maptracker_Panel).ForeColor = red;
            }
            //Adult fishing and PoH
            if (Has(Hookshot) || Has(Beans))
            {
                Pb("Lake Hylia", "Adult Fishing", maptracker_Panel).ForeColor = Available;
                Pb("Lake Hylia", "Freestanding PoH", maptracker_Panel).ForeColor = Available;
            }
            else if (Has(Hookshot) || can_get_beans)
            {
                Pb("Lake Hylia", "Adult Fishing", maptracker_Panel).ForeColor = coulddo;
                Pb("Lake Hylia", "Freestanding PoH", maptracker_Panel).ForeColor = coulddo;
            }
            else
            {
                Pb("Lake Hylia", "Adult Fishing", maptracker_Panel).ForeColor = red;
                Pb("Lake Hylia", "Freestanding PoH", maptracker_Panel).ForeColor = red;
            }
            //Shoot the sun
            if (has_longshot && Has(Bow))
            {
                Pb("Lake Hylia", "Shoot the Sun", maptracker_Panel).ForeColor = Available;
            }
            else
            {
                Pb("Lake Hylia", "Shoot the Sun", maptracker_Panel).ForeColor = red;
            }
            //Skulltulla
            if (Has(Boomerang))
            {
                tokensAvailable++;
            }
            if (has_longshot)
            {
                tokensAvailable++;
            }
            if (Has(IronBoots) && Has(Hookshot))
            {
                tokensAvailable++;
            }
        }
    }
}
