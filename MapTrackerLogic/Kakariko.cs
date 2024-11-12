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
        public void ItemLogic_Kakariko()
        {
            Panel maptracker_Panel = maptracker;
            //Kak Shooting Gallery
            if (Has(Bow))
            {
                Pb("Kakariko", "Shooting Gallery", maptracker_Panel).ForeColor = Available;
            }
            else
            {
                Pb("Kakariko", "Shooting Gallery", maptracker_Panel).ForeColor = red;
            }
            //Kak Redead Grotto
            if (can_blast_or_smash)
            {
                Pb("Kakariko", "Redead Grotto Chest", maptracker_Panel).ForeColor = Available;
            }
            else
            {
                Pb("Kakariko", "Redead Grotto Chest", maptracker_Panel).ForeColor = red;
            }
            //Shiek at Kakariko
            if (Has(ForestMedallion) && Has(FireMedallion) && Has(WaterMedallion))
            {
                Pb("Kakariko", "Shiek at Kakariko", maptracker_Panel).ForeColor = Available;
            }
            else
            {
                Pb("Kakariko", "Shiek at Kakariko", maptracker_Panel).ForeColor = red;
            }

            //Skulltula
            if (Has(Slingshot) || Has(Bomb))
            {
                tokensAvailable++;
            }
            if (Has(Hookshot))
            {
                tokensAvailable++;
            }
        }
    }
}
