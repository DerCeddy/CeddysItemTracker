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
        public void ItemLogic_WaterTemple()
        {
            Panel maptracker_Panel = maptracker;
            //Entrance Chests
            if (Has(Hookshot) && Has(IronBoots))
            {
                Pb("Water Temple", "Map Chest", maptracker_Panel).ForeColor = Available;
                Pb("Water Temple", "Compass Chest", maptracker_Panel).ForeColor = Available;
            }
            else
            {
                Pb("Water Temple", "Map Chest", maptracker_Panel).ForeColor = red;
                Pb("Water Temple", "Compass Chest", maptracker_Panel).ForeColor = red;
            }
            //Dragon Chest
            if (Has(Hookshot) && Has(IronBoots) && Has(ZeldasLullaby) && (Has(Strength) || (Has(Bow) && Has(IronBoots) && water_keys >= 5 && Has(SongOfTime))))
            {
                Pb("Water Temple", "Dragon Chest", maptracker_Panel).ForeColor = Available;
            }
            else if (Has(Hookshot) && Has(IronBoots) && Has(ZeldasLullaby) && (Has(Strength) || (Has(Bow) && Has(IronBoots) && Has(SongOfTime))))
            {
                Pb("Water Temple", "Dragon Chest", maptracker_Panel).ForeColor = coulddo;
            }
            else
            {
                Pb("Water Temple", "Dragon Chest", maptracker_Panel).ForeColor = red;
            }
            //Torches Chest
            if (Has(Hookshot) && Has(IronBoots) && Has(ZeldasLullaby) && (Has(Bow) || (Has(Dins) && Has(Magic))))
            {
                Pb("Water Temple", "Torches Chest", maptracker_Panel).ForeColor = Available;
            }
            else
            {
                Pb("Water Temple", "Torches Chest", maptracker_Panel).ForeColor = red;
            }
            //Cracked Wall
            if (Has(Hookshot) && Has(IronBoots) && Has(ZeldasLullaby) && Bomb.State == 1 && (Has(Bow) || (Has(Dins) && Has(Magic)) || water_keys >= 5))
            {
                Pb("Water Temple", "Cracked Wall Chest", maptracker_Panel).ForeColor = Available;
            }
            else if (Has(Hookshot) && Has(IronBoots) && Has(ZeldasLullaby) && Bomb.State == 1 && (Has(Bow) || (Has(Dins) && Has(Magic))))
            {
                Pb("Water Temple", "Cracked Wall Chest", maptracker_Panel).ForeColor = coulddo;
            }
            else
            {
                Pb("Water Temple", "Cracked Wall Chest", maptracker_Panel).ForeColor = red;
            }
            //Longshot Chest
            if (Has(Hookshot) && Has(IronBoots) && Has(ZeldasLullaby) && water_keys >= 5)
            {
                Pb("Water Temple", "Longshot Chest", maptracker_Panel).ForeColor = Available;
            }
            else if (Has(Hookshot) && Has(IronBoots) && Has(ZeldasLullaby))
            {
                Pb("Water Temple", "Longshot Chest", maptracker_Panel).ForeColor = coulddo;
            }
            else
            {
                Pb("Water Temple", "Longshot Chest", maptracker_Panel).ForeColor = red;
            }
            //Central Bow Target Chest
            if (Has(Hookshot) && Has(IronBoots) && Has(ZeldasLullaby) && Has(Bow) && (Has(HoverBoots) || has_longshot))
            {
                Pb("Water Temple", "Central Bow Target Chest", maptracker_Panel).ForeColor = Available;
            }
            else
            {
                Pb("Water Temple", "Central Bow Target Chest", maptracker_Panel).ForeColor = red;
            }
            //Central Pillar
            if (Has(Hookshot) && Has(IronBoots) && Has(ZeldasLullaby) && Has(ZoraTunic) && (water_keys >= 5 || (Has(Bow) || (Has(Dins) && Has(Magic)))))
            {
                Pb("Water Temple", "Central Pillar Chest", maptracker_Panel).ForeColor = Available;
            }
            else if (Has(Hookshot) && Has(IronBoots) && Has(ZeldasLullaby) && Has(ZoraTunic) && (Has(Bow) || (Has(Dins) && Has(Magic))))
            {
                Pb("Water Temple", "Central Pillar Chest", maptracker_Panel).ForeColor = coulddo;
            }
            else
            {
                Pb("Water Temple", "Central Pillar Chest", maptracker_Panel).ForeColor = red;
            }
            //Boss Key
            if (has_longshot && Has(IronBoots) && water_keys >= 5 && (Has(HoverBoots) || (Has(Bomb) && Has(Strength))))
            {
                Pb("Water Temple", "Boss Key Chest", maptracker_Panel).ForeColor = Available;
                tokensAvailable++;
            }
            else if (has_longshot && Has(IronBoots) && (Has(HoverBoots) || (Has(Bomb) && Has(Strength))))
            {
                Pb("Water Temple", "Boss Key Chest", maptracker_Panel).ForeColor = coulddo;
                tokensAvailable++;
            }
            else
            {
                Pb("Water Temple", "Boss Key Chest", maptracker_Panel).ForeColor = red;
            }
            //River Chest
            if (Has(Hookshot) && Has(IronBoots) && Has(ZeldasLullaby) && Has(Bow) && Has(SongOfTime) && water_keys >= 5)
            {
                Pb("Water Temple", "River Chest", maptracker_Panel).ForeColor = Available;
                tokensAvailable++;
            }
            else if (Has(Hookshot) && Has(IronBoots) && Has(ZeldasLullaby) && Has(Bow) && Has(SongOfTime))
            {
                Pb("Water Temple", "River Chest", maptracker_Panel).ForeColor = coulddo;
                tokensAvailable++;
            }
            else
            {
                Pb("Water Temple", "River Chest", maptracker_Panel).ForeColor = red;
            }
            //Morpha Heart
            if (has_longshot && Has(IronBoots) && Has(WaterBossKey))
            {
                Pb("Water Temple", "Morpha Heart", maptracker_Panel).ForeColor = Available;
            }
            else if (has_longshot && Has(IronBoots))
            {
                Pb("Water Temple", "Morpha Heart", maptracker_Panel).ForeColor = coulddo;
            }
            else
            {
                Pb("Water Temple", "Morpha Heart", maptracker_Panel).ForeColor = red;
            }
            //Skulltula
            if (has_longshot && Has(IronBoots) && water_keys >= 5)
            {
                tokensAvailable++;
            }
            if (has_longshot && Has(IronBoots) && Has(ZeldasLullaby) && Has(ZoraTunic) && (Has(Bow) || (Has(Dins) && Has(Magic))))
            {
                tokensAvailable++;
            }
            if (Has(Hookshot) && Has(IronBoots) && Has(ZeldasLullaby) && Has(Bomb))
            {
                tokensAvailable++;
            }
        }
    }
}
