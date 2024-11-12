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
        public void ItemLogic_BotW()
        {
            Panel maptracker_Panel = maptracker;
            //Access
            if (Has(SongOfStorms))
            {
                Pb("Bottom of the Well", "Freestanding Key", maptracker_Panel).ForeColor = Available;
                Pb("Bottom of the Well", "Front Left Fake Wall Chest", maptracker_Panel).ForeColor = Available;
                Pb("Bottom of the Well", "Compass Chest", maptracker_Panel).ForeColor = Available;
                Pb("Bottom of the Well", "Center Skull Chest", maptracker_Panel).ForeColor = Available;
                Pb("Bottom of the Well", "Right Bottom Fake Wall Chest", maptracker_Panel).ForeColor = Available;
            }
            else
            {
                Pb("Bottom of the Well", "Freestanding Key", maptracker_Panel).ForeColor = red;
                Pb("Bottom of the Well", "Front Left Fake Wall Chest", maptracker_Panel).ForeColor = red;
                Pb("Bottom of the Well", "Compass Chest", maptracker_Panel).ForeColor = red;
                Pb("Bottom of the Well", "Center Skull Chest", maptracker_Panel).ForeColor = red;
                Pb("Bottom of the Well", "Right Bottom Fake Wall Chest", maptracker_Panel).ForeColor = red;
            }
            //Bombable Things
            if (Has(SongOfStorms) && Bomb.State == 1)
            {
                Pb("Bottom of the Well", "Front Center Bombable Chest", maptracker_Panel).ForeColor = Available;
                Pb("Bottom of the Well", "Back Left Bombable Chest", maptracker_Panel).ForeColor = Available;
            }
            else
            {
                Pb("Bottom of the Well", "Front Center Bombable Chest", maptracker_Panel).ForeColor = red;
                Pb("Bottom of the Well", "Back Left Bombable Chest", maptracker_Panel).ForeColor = red;
            }
            //Behind ZL
            if (Has(SongOfStorms) && Has(ZeldasLullaby))
            {
                Pb("Bottom of the Well", "Underwater Left Chest", maptracker_Panel).ForeColor = Available;
                Pb("Bottom of the Well", "Underwater Front Chest", maptracker_Panel).ForeColor = Available;
                Pb("Bottom of the Well", "Invisible Chest", maptracker_Panel).ForeColor = Available;
                Pb("Bottom of the Well", "Lens of Truth Chest", maptracker_Panel).ForeColor = Available;
            }
            else
            {
                Pb("Bottom of the Well", "Underwater Left Chest", maptracker_Panel).ForeColor = red;
                Pb("Bottom of the Well", "Underwater Front Chest", maptracker_Panel).ForeColor = red;
                Pb("Bottom of the Well", "Invisible Chest", maptracker_Panel).ForeColor = red;
                Pb("Bottom of the Well", "Lens of Truth Chest", maptracker_Panel).ForeColor = red;
            }
            //Map Chest
            if (Has(SongOfStorms) && ((Bomb.State == 1) || (Has(Strength) && ((botw_keys == 3) || (Has(Dins) && Has(Magic))))))
            {
                Pb("Bottom of the Well", "Map Chest", maptracker_Panel).ForeColor = Available;
            }
            else if (Has(SongOfStorms) && ((Bomb.State == 1) || (Has(Strength) && Has(Dins) && Has(Magic))))
            {
                Pb("Bottom of the Well", "Map Chest", maptracker_Panel).ForeColor = coulddo;
            }
            else
            {
                Pb("Bottom of the Well", "Map Chest", maptracker_Panel).ForeColor = red;
            }
            //Behind Locked Doors
            if (Has(SongOfStorms) && botw_keys == 3)
            {
                Pb("Bottom of the Well", "Like Like Chest", maptracker_Panel).ForeColor = Available;
                Pb("Bottom of the Well", "Fire Keese Chest", maptracker_Panel).ForeColor = Available;
            }
            else if (Has(SongOfStorms))
            {
                Pb("Bottom of the Well", "Like Like Chest", maptracker_Panel).ForeColor = coulddo;
                Pb("Bottom of the Well", "Fire Keese Chest", maptracker_Panel).ForeColor = coulddo;
            }
            else
            {
                Pb("Bottom of the Well", "Like Like Chest", maptracker_Panel).ForeColor = red;
                Pb("Bottom of the Well", "Fire Keese Chest", maptracker_Panel).ForeColor = red;
            }
            //Skulltula
            if (Has(SongOfStorms) && botw_keys == 3 && Has(Boomerang))
            {
                tokensAvailable += 3;
            }
        }
    }
}
