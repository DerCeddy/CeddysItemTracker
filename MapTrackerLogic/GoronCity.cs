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
        public void ItemLogic_GoronCity()
        {
            Panel maptracker_Panel = maptracker;
            //Darunia Joy
            if (Has(ZeldasLullaby) && Has(SariasSong))
            {
                Pb("Goron City", "Darunias Joy", maptracker_Panel).ForeColor = Available;
            }
            else
            {
                Pb("Goron City", "Darunias Joy", maptracker_Panel).ForeColor = red;
            }
            //Pot PoH
            if (has_explosives && (Has(ZeldasLullaby) || Has(Dins) && Has(Magic)))
            {
                Pb("Goron City", "Pot Freestanding PoH", maptracker_Panel).ForeColor = Available;
            }
            else
            {
                Pb("Goron City", "Pot Freestanding PoH", maptracker_Panel).ForeColor = red;
            }
            //Rolling Goron Child
            if (has_explosives)
            {
                Pb("Goron City", "Rolling Goron as Child", maptracker_Panel).ForeColor = Available;
            }
            else
            {
                Pb("Goron City", "Rolling Goron as Child", maptracker_Panel).ForeColor = red;
            }
            //Rolling Goron Adult
            if (has_explosives || Has(Strength) || Has(Bow))
            {
                Pb("Goron City", "Rolling Goron as Adult", maptracker_Panel).ForeColor = Available;
            }
            else
            {
                Pb("Goron City", "Rolling Goron as Adult", maptracker_Panel).ForeColor = red;
            }
            //Maze Center and Right
            if (can_blast_or_smash || Strength.State > 1)
            {
                Pb("Goron City", "Maze Right Chest", maptracker_Panel).ForeColor = Available;
                Pb("Goron City", "Maze Center Chest", maptracker_Panel).ForeColor = Available;
            }
            else
            {
                Pb("Goron City", "Maze Right Chest", maptracker_Panel).ForeColor = red;
                Pb("Goron City", "Maze Center Chest", maptracker_Panel).ForeColor = red;
            }
            //Maze Left
            if (Has(Hammer) || Strength.State > 1)
            {
                Pb("Goron City", "Maze Left Chest", maptracker_Panel).ForeColor = Available;
            }
            else
            {
                Pb("Goron City", "Maze Left Chest", maptracker_Panel).ForeColor = red;
            }
            //Skulls
            if (has_explosives)
            {
                tokensAvailable += 1;
            }
        }
    }
}
