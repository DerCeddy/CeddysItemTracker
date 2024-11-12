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
        public void ItemLogic_Graveyard()
        {
            Panel maptracker_Panel = maptracker;
            //Sun Song Grave
            if (Has(SunSong))
            {
                Pb("Graveyard", "Heart Piece Grave Chest", maptracker_Panel).ForeColor = Available;
            }
            else
            {
                Pb("Graveyard", "Heart Piece Grave Chest", maptracker_Panel).ForeColor = red;
            }
            //Royal Tomb Chest
            if (Has(ZeldasLullaby) && Has(Magic) && (Has(Dins) || (Has(Bow) && Has(FireArrow))))
            {
                Pb("Graveyard", "Royal Familys Tomb Chest", maptracker_Panel).ForeColor = Available;
            }
            else
            {
                Pb("Graveyard", "Royal Familys Tomb Chest", maptracker_Panel).ForeColor = red;
            }
            //Freestanding PoH
            if (Has(Beans) || has_longshot)
            {
                Pb("Graveyard", "Freestanding PoH", maptracker_Panel).ForeColor = Available;
            }
            else if (Has(Bomb) || Has(Scales))
            {
                Pb("Graveyard", "Freestanding PoH", maptracker_Panel).ForeColor = coulddo;
            }
            else
            {
                Pb("Graveyard", "Freestanding PoH", maptracker_Panel).ForeColor = red;
            }
            //Composer Song
            if (Has(ZeldasLullaby))
            {
                Pb("Graveyard", "Composer Song", maptracker_Panel).ForeColor = Available;
            }
            else
            {
                Pb("Graveyard", "Composer Song", maptracker_Panel).ForeColor = red;
            }
            //Skulltula
            if (Has(Boomerang))
            {
                tokensAvailable++;
            }
        }
    }
}
