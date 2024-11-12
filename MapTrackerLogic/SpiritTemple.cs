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
        public void ItemLogic_SpiritTemple()
        {
            Panel maptracker_Panel = maptracker;
            //Early Child Checks
            if (Has(Reqiuem) && (Has(Slingshot) || Has(Boomerang)))
            {
                Pb("Spirit Temple", "Child Bridge Chest", maptracker_Panel).ForeColor = Available;
                Pb("Spirit Temple", "Child Early Torches Chest", maptracker_Panel).ForeColor = Available;
                tokensAvailable++;
            }
            else
            {
                Pb("Spirit Temple", "Child Bridge Chest", maptracker_Panel).ForeColor = red;
                Pb("Spirit Temple", "Child Early Torches Chest", maptracker_Panel).ForeColor = red;

            }
            //Child Climb
            if ((Has(Reqiuem) && spirit_keys == 5 && (Has(Slingshot) || Has(Boomerang))) || (desertaccess == 1 && Strength.State >= 2 && spirit_keys >= 3 && (Has(Hookshot) || Has(Bow))) || (desertaccess == 1 && spirit_keys >= 1 && (((Has(Slingshot) || Has(Boomerang)) && (Has(Bow) || Has(Hookshot))) || Bomb.State == 1)))
            {
                Pb("Spirit Temple", "Child Climb North Chest", maptracker_Panel).ForeColor = Available;
                Pb("Spirit Temple", "Child Climb East Chest", maptracker_Panel).ForeColor = Available;
                tokensAvailable++;
            }
            else if ((Has(Reqiuem) && (Has(Slingshot) || Has(Boomerang))) || (desertaccess == 1 && Strength.State >= 2 && (Has(Hookshot) || Has(Bow))) || (desertaccess == 1 && (((Has(Slingshot) || Has(Boomerang)) && (Has(Bow) || Has(Hookshot))) || Bomb.State == 1)))
            {
                Pb("Spirit Temple", "Child Climb North Chest", maptracker_Panel).ForeColor = coulddo;
                Pb("Spirit Temple", "Child Climb East Chest", maptracker_Panel).ForeColor = coulddo;
                tokensAvailable++;
            }
            else
            {
                Pb("Spirit Temple", "Child Climb North Chest", maptracker_Panel).ForeColor = red;
                Pb("Spirit Temple", "Child Climb East Chest", maptracker_Panel).ForeColor = red;
            }
            //Map Chest
            if ((Has(Reqiuem) && (spirit_keys == 5 || (Has(Dins) && Has(Magic) && spirit_keys >= 1)) && Bomb.State == 1 && (Has(Slingshot) || Has(Boomerang))) || (desertaccess == 1 && Strength.State >= 2 && spirit_keys >= 3 && has_firesource && (Has(Hookshot) || Has(Bow))))
            {
                Pb("Spirit Temple", "Map Chest", maptracker_Panel).ForeColor = Available;
                Pb("Spirit Temple", "Sun Block Room Chest", maptracker_Panel).ForeColor = Available;
            }
            else if ((Has(Reqiuem) && ((Has(Dins) && Has(Magic))) && Bomb.State == 1 && (Has(Slingshot) || Has(Boomerang))) || (desertaccess == 1 && Strength.State >= 2 && has_firesource && (Has(Hookshot) || Has(Bow))))
            {
                Pb("Spirit Temple", "Map Chest", maptracker_Panel).ForeColor = coulddo;
                Pb("Spirit Temple", "Sun Block Room Chest", maptracker_Panel).ForeColor = coulddo;
            }
            else
            {
                Pb("Spirit Temple", "Map Chest", maptracker_Panel).ForeColor = red;
                Pb("Spirit Temple", "Sun Block Room Chest", maptracker_Panel).ForeColor = red;
            }
            //Silver Gauntlets
            if ((Has(Reqiuem) && (Has(Slingshot) || Has(Boomerang)) && Bomb.State == 1 && spirit_keys == 5) || (desertaccess == 1 && Strength.State >= 2 && has_longshot && Bomb.State == 1 && spirit_keys >= 3))
            {
                Pb("Spirit Temple", "Silver Gauntlets Chest", maptracker_Panel).ForeColor = Available;
            }
            else if ((Has(Reqiuem) && (Has(Slingshot) || Has(Boomerang)) && Bomb.State == 1) || (desertaccess == 1 && Strength.State >= 2 && has_longshot && Bomb.State == 1))
            {
                Pb("Spirit Temple", "Silver Gauntlets Chest", maptracker_Panel).ForeColor = coulddo;
            }
            else
            {
                Pb("Spirit Temple", "Silver Gauntlets Chest", maptracker_Panel).ForeColor = red;
            }
            //Adult Entry
            if (desertaccess == 1 && Strength.State >= 2 && (Has(Hookshot) || Has(Bow) || Has(Bomb)))
            {
                Pb("Spirit Temple", "Early Adult Right Chest", maptracker_Panel).ForeColor = Available;
            }
            else
            {
                Pb("Spirit Temple", "Early Adult Right Chest", maptracker_Panel).ForeColor = red;
            }
            //Adult Compass Chest
            if (desertaccess == 1 && Strength.State >= 2 && Has(Hookshot) && Has(ZeldasLullaby))
            {
                Pb("Spirit Temple", "Compass Chest", maptracker_Panel).ForeColor = Available;
            }
            else
            {
                Pb("Spirit Temple", "Compass Chest", maptracker_Panel).ForeColor = red;
            }
            //Adult Climb
            if (desertaccess == 1 && Strength.State >= 2 && spirit_keys >= 3 && (Has(Hookshot) || Has(Bow) || Has(Bomb)))
            {

                Pb("Spirit Temple", "First Mirror Left Chest", maptracker_Panel).ForeColor = Available;
                Pb("Spirit Temple", "First Mirror Right Chest", maptracker_Panel).ForeColor = Available;
            }
            else if (desertaccess == 1 && Strength.State >= 2 && (Has(Hookshot) || Has(Bow) || Has(Bomb)))
            {

                Pb("Spirit Temple", "First Mirror Left Chest", maptracker_Panel).ForeColor = coulddo;
                Pb("Spirit Temple", "First Mirror Right Chest", maptracker_Panel).ForeColor = coulddo;
            }
            else
            {
                Pb("Spirit Temple", "First Mirror Left Chest", maptracker_Panel).ForeColor = red;
                Pb("Spirit Temple", "First Mirror Right Chest", maptracker_Panel).ForeColor = red;
            }
            //Adult Centerroom
            if (desertaccess == 1 && Strength.State >= 2 && spirit_keys >= 3 && (Has(Hookshot) || Has(Bow) || Has(Bomb)) && Has(ZeldasLullaby))
            {
                Pb("Spirit Temple", "Statue Room Hand Chest", maptracker_Panel).ForeColor = Available;
            }
            else if (desertaccess == 1 && Strength.State >= 2 && (Has(Hookshot) || Has(Bow) || Has(Bomb)) && Has(ZeldasLullaby))
            {
                Pb("Spirit Temple", "Statue Room Hand Chest", maptracker_Panel).ForeColor = coulddo;
            }
            else
            {
                Pb("Spirit Temple", "Statue Room Hand Chest", maptracker_Panel).ForeColor = red;
            }
            //Adult Statue Northeast Chest
            if (desertaccess == 1 && Strength.State >= 2 && Has(Hookshot) && Has(ZeldasLullaby) && spirit_keys >= 3)
            {
                Pb("Spirit Temple", "Statue Room Northeast Chest", maptracker_Panel).ForeColor = Available;
            }
            else if (desertaccess == 1 && Strength.State >= 2 && Has(Hookshot) && Has(ZeldasLullaby))
            {
                Pb("Spirit Temple", "Statue Room Northeast Chest", maptracker_Panel).ForeColor = coulddo;
            }
            else
            {
                Pb("Spirit Temple", "Statue Room Northeast Chest", maptracker_Panel).ForeColor = red;
            }
            //Adult beyond Anubis Room
            if (desertaccess == 1 && Strength.State >= 2 && spirit_keys >= 4 && (Has(Hookshot) || Has(Bow) || Has(Bomb)) && Bomb.State == 1)
            {
                Pb("Spirit Temple", "Hallway Right Invisible Chest", maptracker_Panel).ForeColor = Available;
                Pb("Spirit Temple", "Hallway Left Invisible Chest", maptracker_Panel).ForeColor = Available;
                Pb("Spirit Temple", "Mirror Shield Chest", maptracker_Panel).ForeColor = Available;
            }
            else if (desertaccess == 1 && Strength.State >= 2 && (Has(Hookshot) || Has(Bow) || Has(Bomb)) && Bomb.State == 1)
            {
                Pb("Spirit Temple", "Hallway Right Invisible Chest", maptracker_Panel).ForeColor = coulddo;
                Pb("Spirit Temple", "Hallway Left Invisible Chest", maptracker_Panel).ForeColor = coulddo;
                Pb("Spirit Temple", "Mirror Shield Chest", maptracker_Panel).ForeColor = coulddo;
            }
            else
            {
                Pb("Spirit Temple", "Hallway Right Invisible Chest", maptracker_Panel).ForeColor = red;
                Pb("Spirit Temple", "Hallway Left Invisible Chest", maptracker_Panel).ForeColor = red;
                Pb("Spirit Temple", "Mirror Shield Chest", maptracker_Panel).ForeColor = red;
            }
            //Near Four Armors
            if (desertaccess == 1 && Strength.State >= 2 && (Has(Hookshot) || Has(Bow)) && Bomb.State == 1 && Has(MirrorShield) && spirit_keys >= 4)
            {
                Pb("Spirit Temple", "Near Four Armos Chest", maptracker_Panel).ForeColor = Available;
            }
            else if (desertaccess == 1 && Strength.State >= 2 && (Has(Hookshot) || Has(Bow)) && Bomb.State == 1 && Has(MirrorShield))
            {
                Pb("Spirit Temple", "Near Four Armos Chest", maptracker_Panel).ForeColor = coulddo;
            }
            else
            {
                Pb("Spirit Temple", "Near Four Armos Chest", maptracker_Panel).ForeColor = red;
            }
            //Boss Key Chest
            if (desertaccess == 1 && Strength.State >= 2 && Has(ZeldasLullaby) && spirit_keys == 5 && Has(Hookshot) && Has(Bow) && ((has_longshot || Bomb.State == 1) || ((Bomb.State == 1 || (Has(Dins) && Has(Magic)) || Has(Nuts)) && (Has(Bow) || Has(Hookshot) || Has(Hammer)))))
            {
                Pb("Spirit Temple", "Boss Key Chest", maptracker_Panel).ForeColor = Available;
            }
            else if (desertaccess == 1 && Strength.State >= 2 && Has(ZeldasLullaby) && Has(Hookshot) && Has(Bow) && ((has_longshot || Bomb.State == 1) || ((Bomb.State == 1 || (Has(Dins) && Has(Magic)) || Has(Nuts)) && (Has(Bow) || Has(Hookshot) || Has(Hammer)))))
            {
                Pb("Spirit Temple", "Boss Key Chest", maptracker_Panel).ForeColor = coulddo;
            }
            else
            {
                Pb("Spirit Temple", "Boss Key Chest", maptracker_Panel).ForeColor = red;
            }
            //Topmost Chest
            if (desertaccess == 1 && Strength.State >= 2 && spirit_keys == 5 && Has(MirrorShield) && (Has(Hookshot) || Has(Bow)) && ((has_longshot || Bomb.State == 1) || ((Bomb.State == 1 || (Has(Dins) && Has(Magic)) || Has(Nuts)) && (Has(Bow) || Has(Hookshot) || Has(Hammer)))))
            {
                Pb("Spirit Temple", "Topmost Chest", maptracker_Panel).ForeColor = Available;
            }
            else if (desertaccess == 1 && Strength.State >= 2 && Has(MirrorShield) && (Has(Hookshot) || Has(Bow)) && ((has_longshot || Bomb.State == 1) || ((Bomb.State == 1 || (Has(Dins) && Has(Magic)) || Has(Nuts)) && (Has(Bow) || Has(Hookshot) || Has(Hammer)))))
            {
                Pb("Spirit Temple", "Topmost Chest", maptracker_Panel).ForeColor = coulddo;

            }
            else
            {
                Pb("Spirit Temple", "Topmost Chest", maptracker_Panel).ForeColor = red;

            }
            //Twinrova Heart
            if (desertaccess == 1 && Strength.State >= 2 && Has(MirrorShield) && Has(SpiritBossKey) && spirit_keys == 5 && (Has(Hookshot) || Has(Bow)) && ((has_longshot || Bomb.State == 1) || ((Bomb.State == 1 || (Has(Dins) && Has(Magic)) || Has(Nuts)) && (Has(Bow) || Has(Hookshot) || Has(Hammer)))))
            {
                Pb("Spirit Temple", "Twinrova Heart", maptracker_Panel).ForeColor = Available;
            }
            else if (desertaccess == 1 && Strength.State >= 2 && Has(MirrorShield) && (Has(Hookshot) || Has(Bow)) && ((has_longshot || Bomb.State == 1) || ((Bomb.State == 1 || (Has(Dins) && Has(Magic)) || Has(Nuts)) && (Has(Bow) || Has(Hookshot) || Has(Hammer)))))
            {
                Pb("Spirit Temple", "Twinrova Heart", maptracker_Panel).ForeColor = coulddo;
            }
            else
            {
                Pb("Spirit Temple", "Twinrova Heart", maptracker_Panel).ForeColor = red;
            }
            //Skulltula
            if (desertaccess == 1 && Strength.State >= 2 && (Has(Hookshot) || Has(Bow)) && Has(SongOfTime))
            {
                tokensAvailable++;
            }
            if ((spirit_keys == 5 && Has(Boomerang)) || (spirit_keys >= 3 && (Has(Hookshot) || Has(HoverBoots))))
            {
                tokensAvailable++;
            }
            if ((spirit_keys == 5 && Has(Boomerang)) || (spirit_keys >= 3 && Has(Hookshot)))
            {
                tokensAvailable++;
            }
        }
    }
}
