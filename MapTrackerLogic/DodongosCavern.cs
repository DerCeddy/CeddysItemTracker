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
        public void ItemLogic_DodongosCavern()
        {
            Panel maptracker_Panel = maptracker;
            //Map and Compass Chests
            if (Bomb.State == 1 || Has(Strength) || Has(Hammer))
            {
                Pb("Dodongos Cavern", "Compass Chest", maptracker_Panel).ForeColor = Available;
                Pb("Dodongos Cavern", "Map Chest", maptracker_Panel).ForeColor = Available;
                tokensAvailable++;
            }
            else
            {
                Pb("Dodongos Cavern", "Compass Chest", maptracker_Panel).ForeColor = red;
                Pb("Dodongos Cavern", "Map Chest", maptracker_Panel).ForeColor = red;
            }
            //Beyond Staircase
            if (Bomb.State == 1 || Has(Strength) || ((Has(Dins) && Has(Magic)) && Has(Hammer)))
            {
                Pb("Dodongos Cavern", "Bomb Flower Platform Chest", maptracker_Panel).ForeColor = Available;
                Pb("Dodongos Cavern", "Bomb Bag Chest", maptracker_Panel).ForeColor = Available;
                tokensAvailable++;
            }
            else
            {
                Pb("Dodongos Cavern", "Bomb Flower Platform Chest", maptracker_Panel).ForeColor = red;
                Pb("Dodongos Cavern", "Bomb Bag Chest", maptracker_Panel).ForeColor = red;
            }
            //End of Bridge
            if (Bomb.State == 1 || (Has(Strength) || (Has(Dins) && Has(Magic))) && Has(Hammer))
            {
                Pb("Dodongos Cavern", "End of Bridge Chest", maptracker_Panel).ForeColor = Available;
            }
            else
            {
                Pb("Dodongos Cavern", "End of Bridge Chest", maptracker_Panel).ForeColor = red;
            }
            //You need Bomb Bag for Boss Room
            if (Has(Bomb))
            {
                Pb("Dodongos Cavern", "Boss Room Chest", maptracker_Panel).ForeColor = Available;
                Pb("Dodongos Cavern", "King Dodongo Heart", maptracker_Panel).ForeColor = Available;
                tokensAvailable++;
            }
            else
            {
                Pb("Dodongos Cavern", "Boss Room Chest", maptracker_Panel).ForeColor = red;
                Pb("Dodongos Cavern", "King Dodongo Heart", maptracker_Panel).ForeColor = red;
            }
            //Skulltula
            if ((Bomb.State == 1 || Has(Strength)) && (Has(Hookshot) || Has(Boomerang)))
            {
                tokensAvailable++;
            }
            if ((Has(Bomb) || Has(Strength)) && Has(Hookshot))
            {
                tokensAvailable++;
            }
        }
    }
}
