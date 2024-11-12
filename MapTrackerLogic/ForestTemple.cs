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
        public void ItemLogic_ForestTemple()
        {
            Panel maptracker_Panel = maptracker;
            //ForestFirst2Checks
            if ((Has(SariasSong) || Has(Minuet)) && Has(Hookshot))
            {
                Pb("Forest Temple", "First Room Chest", maptracker_Panel).ForeColor = Available;
                Pb("Forest Temple", "First Stalfos Chest", maptracker_Panel).ForeColor = Available;
                tokensAvailable += 2;
            }
            else
            {
                Pb("Forest Temple", "First Room Chest", maptracker_Panel).ForeColor = red;
                Pb("Forest Temple", "First Stalfos Chest", maptracker_Panel).ForeColor = red;
            }
            //ForestBackyard
            if (((Has(SariasSong) || Has(Minuet)) && Has(Hookshot) && (Has(SongOfTime) || Has(Bow))))
            {
                Pb("Forest Temple", "Map Chest", maptracker_Panel).ForeColor = Available;
                Pb("Forest Temple", "Raised Island Courtyard Chest", maptracker_Panel).ForeColor = Available;
                Pb("Forest Temple", "Well Chest", maptracker_Panel).ForeColor = Available;
                tokensAvailable++;
            }
            else
            {
                Pb("Forest Temple", "Map Chest", maptracker_Panel).ForeColor = red;
                Pb("Forest Temple", "Raised Island Courtyard Chest", maptracker_Panel).ForeColor = red;
                Pb("Forest Temple", "Well Chest", maptracker_Panel).ForeColor = red;
            }
            //Forest Eye Switch Chest
            if ((Has(SariasSong) || Has(Minuet)) && Has(Hookshot) && forest_keys >= 1 && Has(Bow))
            {
                Pb("Forest Temple", "Eye Switch Chest", maptracker_Panel).ForeColor = Available;
            }
            else if ((Has(SariasSong) || Has(Minuet)) && Has(Hookshot) && Has(Bow))
            {
                Pb("Forest Temple", "Eye Switch Chest", maptracker_Panel).ForeColor = coulddo;
            }
            else
            {
                Pb("Forest Temple", "Eye Switch Chest", maptracker_Panel).ForeColor = red;
            }
            //Forest Floormaster
            if ((Has(SariasSong) || Has(Minuet)) && Has(Hookshot) && ((Has(Strength) && forest_keys >= 2 && Has(Bow)) || (Has(HoverBoots) && forest_keys >= 1)))
            {
                Pb("Forest Temple", "Floormaster Chest", maptracker_Panel).ForeColor = Available;
                tokensAvailable++;
            }
            else if ((Has(SariasSong) || Has(Minuet)) && Has(Hookshot) && ((Has(Strength) && Has(Bow)) || (Has(HoverBoots))))
            {
                Pb("Forest Temple", "Floormaster Chest", maptracker_Panel).ForeColor = coulddo;
                tokensAvailable++;
            }
            else
            {
                Pb("Forest Temple", "Floormaster Chest", maptracker_Panel).ForeColor = red;
            }
            //Forest Boss Key
            if ((Has(SariasSong) || Has(Minuet)) && Has(Hookshot) && Has(Strength) && forest_keys >= 2 && Has(Bow))
            {
                Pb("Forest Temple", "Boss Key Chest", maptracker_Panel).ForeColor = Available;
            }
            else if ((Has(SariasSong) || Has(Minuet)) && Has(Hookshot) && Has(Strength) && Has(Bow))
            {
                Pb("Forest Temple", "Boss Key Chest", maptracker_Panel).ForeColor = coulddo;
            }
            else
            {
                Pb("Forest Temple", "Boss Key Chest", maptracker_Panel).ForeColor = red;
            }
            //ForestWithStrength
            if ((Has(SariasSong) || Has(Minuet)) && Has(Hookshot) && forest_keys >= 3 && Has(Strength))
            {
                Pb("Forest Temple", "Bow Chest", maptracker_Panel).ForeColor = Available;
            }
            else if ((Has(SariasSong) || Has(Minuet)) && Has(Hookshot) && Has(Strength) && (Has(SongOfTime) || Has(Bow) || Has(HoverBoots)))
            {
                Pb("Forest Temple", "Bow Chest", maptracker_Panel).ForeColor = coulddo;
            }
            else
            {
                Pb("Forest Temple", "Bow Chest", maptracker_Panel).ForeColor = red;
            }
            //Red and Blue Poe
            if ((Has(SariasSong) || Has(Minuet)) && Has(Hookshot) && forest_keys >= 3 && Has(Strength) && Has(Bow))
            {
                Pb("Forest Temple", "Red Poe Chest", maptracker_Panel).ForeColor = Available;
                Pb("Forest Temple", "Blue Poe Chest", maptracker_Panel).ForeColor = Available;
            }
            else if ((Has(SariasSong) || Has(Minuet)) && Has(Hookshot) && Has(Strength) && Has(Bow))
            {
                Pb("Forest Temple", "Red Poe Chest", maptracker_Panel).ForeColor = coulddo;
                Pb("Forest Temple", "Blue Poe Chest", maptracker_Panel).ForeColor = coulddo;
            }
            else
            {
                Pb("Forest Temple", "Red Poe Chest", maptracker_Panel).ForeColor = red;
                Pb("Forest Temple", "Blue Poe Chest", maptracker_Panel).ForeColor = red;
            }
            //ForestRest
            if ((Has(SariasSong) || Has(Minuet)) && Has(Hookshot) && Has(Bow) && Has(Strength) && forest_keys == 5)
            {
                Pb("Forest Temple", "Falling Ceilling Room Chest", maptracker_Panel).ForeColor = Available;
                Pb("Forest Temple", "Basement Chest", maptracker_Panel).ForeColor = Available;
                tokensAvailable++;
            }
            else if ((Has(SariasSong) || Has(Minuet)) && Has(Hookshot) && Has(Bow) && Has(Strength))
            {
                Pb("Forest Temple", "Falling Ceilling Room Chest", maptracker_Panel).ForeColor = coulddo;
                Pb("Forest Temple", "Basement Chest", maptracker_Panel).ForeColor = coulddo;
                tokensAvailable++;
            }
            else
            {
                Pb("Forest Temple", "Falling Ceilling Room Chest", maptracker_Panel).ForeColor = red;
                Pb("Forest Temple", "Basement Chest", maptracker_Panel).ForeColor = red;
            }
            //Boss
            if ((Has(SariasSong) || Has(Minuet)) && Has(Hookshot) && Has(Bow) && Has(Strength) && forest_keys == 5 && Has(ForestBossKey))
            {
                Pb("Forest Temple", "Phantom Ganon Heart", maptracker_Panel).ForeColor = Available;

            }
            else if ((Has(SariasSong) || Has(Minuet)) && Has(Hookshot) && Has(Bow) && Has(Strength))
            {
                Pb("Forest Temple", "Phantom Ganon Heart", maptracker_Panel).ForeColor = coulddo;

            }
            else
            {
                Pb("Forest Temple", "Phantom Ganon Heart", maptracker_Panel).ForeColor = red;
            }
        }
    }
}
