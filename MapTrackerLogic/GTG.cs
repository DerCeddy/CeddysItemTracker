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
        public void ItemLogic_GTG()
        {
            gtg_available_checks = 0;
            Panel maptracker_Panel = maptracker;
            //LobbyChests
            if (has_or_can_get_gerudocard && Has(Bow))
            {
                Pb("Gerudos Training Grounds", "Lobby Left Chest", maptracker_Panel).ForeColor = Available;
                Pb("Gerudos Training Grounds", "Lobby Right Chest", maptracker_Panel).ForeColor = Available;
                gtg_available_checks += 2;
            }
            else
            {
                Pb("Gerudos Training Grounds", "Lobby Left Chest", maptracker_Panel).ForeColor = red;
                Pb("Gerudos Training Grounds", "Lobby Right Chest", maptracker_Panel).ForeColor = red;
            }
            //Stalfos
            if (has_or_can_get_gerudocard)
            {
                Pb("Gerudos Training Grounds", "Stalfos Chest", maptracker_Panel).ForeColor = Available;
                gtg_available_checks++;
            }
            else
            {
                Pb("Gerudos Training Grounds", "Stalfos Chest", maptracker_Panel).ForeColor = red;
            }
            //Beamos
            if (has_or_can_get_gerudocard && Bomb.State == 1)
            {
                Pb("Gerudos Training Grounds", "Beamos Chest", maptracker_Panel).ForeColor = Available;
                gtg_available_checks++;
            }
            else
            {
                Pb("Gerudos Training Grounds", "Beamos Chest", maptracker_Panel).ForeColor = red;
            }
            //Toilet
            if (has_or_can_get_gerudocard && Has(IronBoots) && Has(SongOfTime) && Bomb.State == 1)
            {
                Pb("Gerudos Training Grounds", "Underwater Silver Rupee Chest", maptracker_Panel).ForeColor = Available;
                gtg_available_checks++;
            }
            else
            {
                Pb("Gerudos Training Grounds", "Underwater Silver Rupee Chest", maptracker_Panel).ForeColor = red;
            }       
            //Freestanding Key
            if (has_or_can_get_gerudocard && ((Bomb.State == 1 || Has(Hookshot)) && Has(SongOfTime) || gtg_keys == 9))
            {
                Pb("Gerudos Training Grounds", "Freestanding Key", maptracker_Panel).ForeColor = Available;
                gtg_available_checks++;
            }
            else if (has_or_can_get_gerudocard && (Bomb.State == 1 || Has(Hookshot)) && Has(SongOfTime))
            {
                Pb("Gerudos Training Grounds", "Freestanding Key", maptracker_Panel).ForeColor = coulddo;
            }
            else
            {
                Pb("Gerudos Training Grounds", "Freestanding Key", maptracker_Panel).ForeColor = red;
            }
            //Before Heavy Block
            if (has_or_can_get_gerudocard && Has(Hookshot))
            {
                Pb("Gerudos Training Grounds", "Before Heavy Block Chest", maptracker_Panel).ForeColor = Available;
                gtg_available_checks++;
            }
            else
            {
                Pb("Gerudos Training Grounds", "Before Heavy Block Chest", maptracker_Panel).ForeColor = red;
            }
            //Heavy Block Chests
            if (has_or_can_get_gerudocard && Has(Hookshot) && Strength.State >= 2)
            {
                Pb("Gerudos Training Grounds", "Heavy Block First Chest", maptracker_Panel).ForeColor = Available;
                Pb("Gerudos Training Grounds", "Heavy Block Second Chest", maptracker_Panel).ForeColor = Available;
                Pb("Gerudos Training Grounds", "Heavy Block Third Chest", maptracker_Panel).ForeColor = Available;
                Pb("Gerudos Training Grounds", "Heavy Block Fourth Chest", maptracker_Panel).ForeColor = Available;
                gtg_available_checks += 4;
            }
            else
            {
                Pb("Gerudos Training Grounds", "Heavy Block First Chest", maptracker_Panel).ForeColor = red;
                Pb("Gerudos Training Grounds", "Heavy Block Second Chest", maptracker_Panel).ForeColor = red;
                Pb("Gerudos Training Grounds", "Heavy Block Third Chest", maptracker_Panel).ForeColor = red;
                Pb("Gerudos Training Grounds", "Heavy Block Fourth Chest", maptracker_Panel).ForeColor = red;
            }
            //Eye Statue Chests
            if (has_or_can_get_gerudocard && Has(Hookshot) && Has(Bow))
            {
                Pb("Gerudos Training Grounds", "Eye Statue Chest", maptracker_Panel).ForeColor = Available;
                Pb("Gerudos Training Grounds", "Near Scarecrow Chest", maptracker_Panel).ForeColor = Available;
                gtg_available_checks += 2;
            }
            else
            {
                Pb("Gerudos Training Grounds", "Eye Statue Chest", maptracker_Panel).ForeColor = red;
                Pb("Gerudos Training Grounds", "Near Scarecrow Chest", maptracker_Panel).ForeColor = red;
            }
            //Hammer room
            if (has_or_can_get_gerudocard && Has(Hookshot))
            {
                Pb("Gerudos Training Grounds", "Hammer Room Clear Chest", maptracker_Panel).ForeColor = Available;
                gtg_available_checks++;
            }
            else
            {
                Pb("Gerudos Training Grounds", "Hammer Room Clear Chest", maptracker_Panel).ForeColor = red;
            }
            if (has_or_can_get_gerudocard && Has(Hookshot) && Has(Hammer))
            {
                Pb("Gerudos Training Grounds", "Hammer Room Switch Chest", maptracker_Panel).ForeColor = Available;
                gtg_available_checks++;
            }
            else
            {
                Pb("Gerudos Training Grounds", "Hammer Room Switch Chest", maptracker_Panel).ForeColor = red;
            }
            //Hidden Ceiling
            if (has_or_can_get_gerudocard && gtg_keys >= 3)
            {
                Pb("Gerudos Training Grounds", "Hidden Ceiling Chest", maptracker_Panel).ForeColor = Available;
                gtg_available_checks++;
            }
            else if (has_or_can_get_gerudocard && gtg_available_checks >= 3)
            {
                Pb("Gerudos Training Grounds", "Hidden Ceiling Chest", maptracker_Panel).ForeColor = coulddo;               
            }
            else
            {
                Pb("Gerudos Training Grounds", "Hidden Ceiling Chest", maptracker_Panel).ForeColor = red;
            }
            //Maze 1
            if (has_or_can_get_gerudocard && gtg_keys >= 4)
            {
                Pb("Gerudos Training Grounds", "Maze Path First Chest", maptracker_Panel).ForeColor = Available;
                gtg_available_checks++;
            }
            else if (has_or_can_get_gerudocard && gtg_available_checks >= 4)
            {
                Pb("Gerudos Training Grounds", "Maze Path First Chest", maptracker_Panel).ForeColor = coulddo;               
            }
            else
            {
                Pb("Gerudos Training Grounds", "Maze Path First Chest", maptracker_Panel).ForeColor = red;
            }
            //Maze 2
            if (has_or_can_get_gerudocard && gtg_keys >= 6)
            {
                Pb("Gerudos Training Grounds", "Maze Path Second Chest", maptracker_Panel).ForeColor = Available;
            }
            else if (has_or_can_get_gerudocard && gtg_available_checks >= 6)
            {
                Pb("Gerudos Training Grounds", "Maze Path Second Chest", maptracker_Panel).ForeColor = coulddo;
            }
            else
            {
                Pb("Gerudos Training Grounds", "Maze Path Second Chest", maptracker_Panel).ForeColor = red;
            }
            //Maze 3
            if (has_or_can_get_gerudocard && gtg_keys >= 7)
            {
                Pb("Gerudos Training Grounds", "Maze Path Third Chest", maptracker_Panel).ForeColor = Available;
            }
            else if (has_or_can_get_gerudocard && gtg_available_checks >= 7)
            {
                Pb("Gerudos Training Grounds", "Maze Path Third Chest", maptracker_Panel).ForeColor = coulddo;
            }
            else
            {
                Pb("Gerudos Training Grounds", "Maze Path Third Chest", maptracker_Panel).ForeColor = red;
            }
            //Maze 4
            if (has_or_can_get_gerudocard && gtg_keys >= 9)
            {
                Pb("Gerudos Training Grounds", "Maze Path Final Chest", maptracker_Panel).ForeColor = Available;
            }
            else if (has_or_can_get_gerudocard && gtg_available_checks >= 9)
            {
                Pb("Gerudos Training Grounds", "Maze Path Final Chest", maptracker_Panel).ForeColor = coulddo;
            }
            else
            {
                Pb("Gerudos Training Grounds", "Maze Path Final Chest", maptracker_Panel).ForeColor = red;
            }
            //Maze Right Chests
            if (has_or_can_get_gerudocard && ((Bomb.State == 1 || Has(Hookshot)) && Has(SongOfTime) || gtg_keys == 9))
            {
                Pb("Gerudos Training Grounds", "Maze Right Central Chest", maptracker_Panel).ForeColor = Available;
                Pb("Gerudos Training Grounds", "Maze Right Side Chest", maptracker_Panel).ForeColor = Available;
                gtg_available_checks += 2;
            }
            else if (has_or_can_get_gerudocard && ((Bomb.State == 1 || Has(Hookshot)) && Has(SongOfTime) || gtg_available_checks >= 9))
            {
                Pb("Gerudos Training Grounds", "Maze Right Central Chest", maptracker_Panel).ForeColor = coulddo;
                Pb("Gerudos Training Grounds", "Maze Right Side Chest", maptracker_Panel).ForeColor = coulddo;
            }
            else
            {
                Pb("Gerudos Training Grounds", "Maze Right Central Chest", maptracker_Panel).ForeColor = red;
                Pb("Gerudos Training Grounds", "Maze Right Side Chest", maptracker_Panel).ForeColor = red;
            }
        }
    }
}
