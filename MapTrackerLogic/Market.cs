using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using static CeddysItemTracker.Form1;

namespace CeddysItemTracker
{
    partial class Form1
    {
        public void ItemLogic_Market()
        {
            Panel maptracker_Panel = maptracker;
            //Bowling 
            if (Has(Bomb))
            {
                Pb("Market", "Bombchu Bowling First Prize", maptracker_Panel).ForeColor = Available;
                Pb("Market", "Bombchu Bowling Second Prize", maptracker_Panel).ForeColor = Available;
            }
            else
            {
                Pb("Market", "Bombchu Bowling First Prize", maptracker_Panel).ForeColor = red;
                Pb("Market", "Bombchu Bowling Second Prize", maptracker_Panel).ForeColor = red;
            }
            //Treasure Chest Game
            if (Has(Magic) && Has(Lens))
            {
                Pb("Market", "Treasure Chest Game", maptracker_Panel).ForeColor = Available;
            }
            else
            {
                Pb("Market", "Treasure Chest Game", maptracker_Panel).ForeColor = red;
            }
            //Big Poes
            if (has_bottle && Has(Bow) && Has(EponasSong))
            {
                Pb("Market", "10 Big Poes", maptracker_Panel).ForeColor = Available;
            }
            else
            {
                Pb("Market", "10 Big Poes", maptracker_Panel).ForeColor = red;
            }
        }
    }
}
