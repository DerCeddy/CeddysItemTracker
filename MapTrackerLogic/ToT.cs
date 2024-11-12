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
        public void ItemLogic_ToT()
        {
            Panel maptracker_Panel = maptracker;
            //Light Arrow Cutscene
            if (Has(SpiritMedallion) && Has(ShadowMedallion))
            {
                Pb("Temple of Time", "Light Arrow Cutscene", maptracker_Panel).ForeColor = Available;
            }
            else
            {
                Pb("Temple of Time", "Light Arrow Cutscene", maptracker_Panel).ForeColor = red;
            }
            //Shiek at Temple
            if (Has(ForestMedallion))
            {
                Pb("Temple of Time", "Shiek at Temple", maptracker_Panel).ForeColor = Available;
            }
            else
            {
                Pb("Temple of Time", "Shiek at Temple", maptracker_Panel).ForeColor = red;
            }
        }
    }
}
