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
        public void ItemLogic_Skulltulas()
        {
            Panel maptracker_Panel = maptracker;
            if (Has(Boomerang))
            {
                tokensAvailable += 3;
            }
            if (has_bottle)
            {
                tokensAvailable += 6;
            }
            //Skullhouse
            if (tokensAvailable >= 10)
            {
                Pb("Kakariko", "10 Skulltulas", maptracker_Panel).ForeColor = Available;
            }
            else
            {
                Pb("Kakariko", "10 Skulltulas", maptracker_Panel).ForeColor = red;
            }
            if (tokensAvailable >= 20)
            {
                Pb("Kakariko", "20 Skulltulas", maptracker_Panel).ForeColor = Available;
            }
            else
            {
                Pb("Kakariko", "20 Skulltulas", maptracker_Panel).ForeColor = red;
            }
            if (tokensAvailable >= 30)
            {
                Pb("Kakariko", "30 Skulltulas", maptracker_Panel).ForeColor = Available;
            }
            else
            {
                Pb("Kakariko", "30 Skulltulas", maptracker_Panel).ForeColor = red;
            }
            if (tokensAvailable >= 40)
            {
                Pb("Kakariko", "40 Skulltulas", maptracker_Panel).ForeColor = Available;
            }
            else
            {
                Pb("Kakariko", "40 Skulltulas", maptracker_Panel).ForeColor = red;
            }
            if (tokensAvailable >= 50)
            {
                Pb("Kakariko", "50 Skulltulas", maptracker_Panel).ForeColor = Available;
            }
            else
            {
                Pb("Kakariko", "50 Skulltulas", maptracker_Panel).ForeColor = red;
            }
            string checks = tokensAvailable.ToString();
            token_available_label.Text = $"{checks}";
        }
    }
}
