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
        public void ItemLogic_FireTemple()
        {
            Panel maptracker_Panel = maptracker;
            //Near Boss
            if (craterplatformaccess == 1)
            {
                Pb("Fire Temple", "Near Boss Door Chest", maptracker_Panel).ForeColor = Available;
            }
            else
            {
                Pb("Fire Temple", "Near Boss Door Chest", maptracker_Panel).ForeColor = red;
            }
            //Beginning Hammer locked checks
            if (Has(Hammer) && craterplatformaccess == 1)
            {
                Pb("Fire Temple", "Boss Key Chest", maptracker_Panel).ForeColor = Available;
                Pb("Fire Temple", "Flare Dancer Chest", maptracker_Panel).ForeColor = Available;
                tokensAvailable++;
            }
            else
            {
                Pb("Fire Temple", "Boss Key Chest", maptracker_Panel).ForeColor = red;
                Pb("Fire Temple", "Flare Dancer Chest", maptracker_Panel).ForeColor = red;
            }
            //Big Lava Lower
            if (fire_keys >= 1 && craterplatformaccess == 1)
            {
                Pb("Fire Temple", "Big Lava Room Lower Door Chest", maptracker_Panel).ForeColor = Available;
            }
            else if (craterplatformaccess == 1)
            {
                Pb("Fire Temple", "Big Lava Room Lower Door Chest", maptracker_Panel).ForeColor = coulddo;
            }
            else
            {
                Pb("Fire Temple", "Big Lava Room Lower Door Chest", maptracker_Panel).ForeColor = red;
            }
            //Blocked door
            if (Bomb.State == 1 && fire_keys >= 1 && craterplatformaccess == 1)
            {
                Pb("Fire Temple", "Big Lava Room Blocked Door Chest", maptracker_Panel).ForeColor = Available;
            }
            else if (Bomb.State == 1 && craterplatformaccess == 1)
            {
                Pb("Fire Temple", "Big Lava Room Blocked Door Chest", maptracker_Panel).ForeColor = coulddo;
            }
            else
            {
                Pb("Fire Temple", "Big Lava Room Blocked Door Chest", maptracker_Panel).ForeColor = red;
            }
            //Bouldermaze lower
            if (has_or_can_red_tunic == 1 && Has(Strength) && fire_keys >= 3 && craterplatformaccess == 1)
            {
                Pb("Fire Temple", "Boulder Maze Lower Chest", maptracker_Panel).ForeColor = Available;
                Pb("Fire Temple", "Boulder Maze Side Room Chest", maptracker_Panel).ForeColor = Available;
            }
            else if (has_or_can_red_tunic == 1 && Has(Strength) && craterplatformaccess == 1)
            {
                Pb("Fire Temple", "Boulder Maze Lower Chest", maptracker_Panel).ForeColor = coulddo;
                Pb("Fire Temple", "Boulder Maze Side Room Chest", maptracker_Panel).ForeColor = coulddo;
            }
            else
            {
                Pb("Fire Temple", "Boulder Maze Lower Chest", maptracker_Panel).ForeColor = red;
                Pb("Fire Temple", "Boulder Maze Side Room Chest", maptracker_Panel).ForeColor = red;
            }
            //Mapchest
            if (has_or_can_red_tunic == 1 && Has(Strength) && ((fire_keys >= 4 && Has(Bow)) || fire_keys >= 5) && craterplatformaccess == 1)
            {
                Pb("Fire Temple", "Map Chest", maptracker_Panel).ForeColor = Available;
            }
            else if (has_or_can_red_tunic == 1 && Has(Strength) && (Has(Bow)) && craterplatformaccess == 1)
            {
                Pb("Fire Temple", "Map Chest", maptracker_Panel).ForeColor = coulddo;
            }
            else
            {
                Pb("Fire Temple", "Map Chest", maptracker_Panel).ForeColor = red;
            }
            //Upper Maze
            if (craterplatformaccess == 1 && has_or_can_red_tunic == 1 && Has(Strength) && fire_keys >= 5)
            {
                Pb("Fire Temple", "Boulder Maze Upper Chest", maptracker_Panel).ForeColor = Available;
            }
            else if (craterplatformaccess == 1 && has_or_can_red_tunic == 1 && Has(Strength))
            {
                Pb("Fire Temple", "Boulder Maze Upper Chest", maptracker_Panel).ForeColor = coulddo;
            }
            else
            {
                Pb("Fire Temple", "Boulder Maze Upper Chest", maptracker_Panel).ForeColor = red;
            }
            //Scarecrow Chest
            if (craterplatformaccess == 1 && has_or_can_red_tunic == 1 && Has(Strength) && fire_keys >= 5 && Has(Hookshot))
            {
                Pb("Fire Temple", "Scarecrow Chest", maptracker_Panel).ForeColor = Available;
                tokensAvailable += 2;
            }
            else if (craterplatformaccess == 1 && has_or_can_red_tunic == 1 && Has(Strength) && Has(Hookshot))
            {
                Pb("Fire Temple", "Scarecrow Chest", maptracker_Panel).ForeColor = coulddo;
                tokensAvailable += 2;
            }
            else
            {
                Pb("Fire Temple", "Scarecrow Chest", maptracker_Panel).ForeColor = red;
            }
            //Shortcut chest
            if (Bomb.State == 1 && has_or_can_red_tunic == 1 && Has(Strength) && craterplatformaccess == 1 && fire_keys >= 5)
            {
                Pb("Fire Temple", "Boulder Maze Shortcut Chest", maptracker_Panel).ForeColor = Available;
            }
            else if (Bomb.State == 1 && has_or_can_red_tunic == 1 && Has(Strength) && craterplatformaccess == 1)
            {
                Pb("Fire Temple", "Boulder Maze Shortcut Chest", maptracker_Panel).ForeColor = coulddo;
            }
            else
            {
                Pb("Fire Temple", "Boulder Maze Shortcut Chest", maptracker_Panel).ForeColor = red;
            }
            //Compass Chest
            if (craterplatformaccess == 1 && fire_keys >= 6 && Has(Strength) && has_or_can_red_tunic == 1)
            {
                Pb("Fire Temple", "Compass Chest", maptracker_Panel).ForeColor = Available;
            }
            else if (craterplatformaccess == 1 && Has(Strength) && has_or_can_red_tunic == 1)
            {
                Pb("Fire Temple", "Compass Chest", maptracker_Panel).ForeColor = coulddo;
            }
            else
            {
                Pb("Fire Temple", "Compass Chest", maptracker_Panel).ForeColor = red;
            }
            //Highest Goron chest
            if ((fire_keys >= 7 || (Has(Hammer) && Has(HoverBoots) && fire_keys >= 6)) && Has(Hammer) && (Has(SongOfTime) || Has(HoverBoots) || Bomb.State == 1) && has_or_can_red_tunic == 1 && Has(Strength) && craterplatformaccess == 1)
            {
                Pb("Fire Temple", "Highest Goron Chest", maptracker_Panel).ForeColor = Available;
            }
            else if ((Has(Hammer) && Has(HoverBoots)) && Has(Hammer) && (Has(SongOfTime) || Has(HoverBoots) || Bomb.State == 1) && has_or_can_red_tunic == 1 && Has(Strength) && craterplatformaccess == 1)
            {
                Pb("Fire Temple", "Highest Goron Chest", maptracker_Panel).ForeColor = coulddo;
            }
            else
            {
                Pb("Fire Temple", "Highest Goron Chest", maptracker_Panel).ForeColor = red;
            }
            //Hammer Chest
            if ((fire_keys >= 7 || (Has(Hammer) && Has(HoverBoots) && fire_keys >= 6)) && Bomb.State == 1)
            {
                Pb("Fire Temple", "Megaton Hammer Chest", maptracker_Panel).ForeColor = Available;
            }
            else if (Has(Hammer) && Has(HoverBoots) && Bomb.State == 1)
            {
                Pb("Fire Temple", "Megaton Hammer Chest", maptracker_Panel).ForeColor = coulddo;
            }
            else
            {
                Pb("Fire Temple", "Megaton Hammer Chest", maptracker_Panel).ForeColor = red;
            }
            //Volvo defeat
            if (Has(Hammer) && has_or_can_red_tunic == 1 && craterplatformaccess == 1 && (Has(HoverBoots) || fire_keys >= 7) && Has(FireBossKey))
            {
                Pb("Fire Temple", "Volvagia Heart", maptracker_Panel).ForeColor = Available;
            }
            else if (Has(Hammer) && has_or_can_red_tunic == 1 && craterplatformaccess == 1 && Has(HoverBoots))
            {
                Pb("Fire Temple", "Volvagia Heart", maptracker_Panel).ForeColor = coulddo;
            }
            else
            {
                Pb("Fire Temple", "Volvagia Heart", maptracker_Panel).ForeColor = red;
            }
            //Skulltula
            if (craterplatformaccess == 1 && Has(SongOfTime))
            {
                tokensAvailable++;
            }
            if (has_or_can_red_tunic == 1 && Has(Strength) && craterplatformaccess == 1 && Has(Bomb))
            {
                tokensAvailable++;
            }
        }
    }
}
