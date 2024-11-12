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
        public void ItemLogic_ShadowTemple()
        {
            Panel maptracker_Panel = maptracker;
            //Shadow Entrance      
            if (Has(Dins) && Has(Nocturne) && Has(Magic) && (Has(Hookshot) || Has(HoverBoots)))
            {
                Pb("Shadow Temple", "Map Chest", maptracker_Panel).ForeColor = Available;
                Pb("Shadow Temple", "Hover Boots Chest", maptracker_Panel).ForeColor = Available;
            }
            else
            {
                Pb("Shadow Temple", "Map Chest", maptracker_Panel).ForeColor = red;
                Pb("Shadow Temple", "Hover Boots Chest", maptracker_Panel).ForeColor = red;
            }
            //Shadow beyond statue
            if (Has(Dins) && Has(Nocturne) && Has(Magic) && Has(HoverBoots))
            {
                Pb("Shadow Temple", "Compass Chest", maptracker_Panel).ForeColor = Available;
                Pb("Shadow Temple", "Early Silver Rupee Chest", maptracker_Panel).ForeColor = Available;
            }
            else
            {
                Pb("Shadow Temple", "Compass Chest", maptracker_Panel).ForeColor = red;
                Pb("Shadow Temple", "Early Silver Rupee Chest", maptracker_Panel).ForeColor = red;
            }
            //Shadow beyond Beamos
            if (Has(Dins) && Has(Nocturne) && Has(Magic) && Has(HoverBoots) && Bomb.State == 1 && shadow_keys >= 1)
            {
                Pb("Shadow Temple", "Invisible Blades Left Chest", maptracker_Panel).ForeColor = Available;
                Pb("Shadow Temple", "Invisible Blades Right Chest", maptracker_Panel).ForeColor = Available;
                Pb("Shadow Temple", "Falling Spikes Lower Chest", maptracker_Panel).ForeColor = Available;
                tokensAvailable += 2;

            }
            else if (Has(Dins) && Has(Nocturne) && Has(Magic) && Has(HoverBoots) && Bomb.State == 1)
            {
                Pb("Shadow Temple", "Invisible Blades Left Chest", maptracker_Panel).ForeColor = coulddo;
                Pb("Shadow Temple", "Invisible Blades Right Chest", maptracker_Panel).ForeColor = coulddo;
                Pb("Shadow Temple", "Falling Spikes Lower Chest", maptracker_Panel).ForeColor = coulddo;
                tokensAvailable += 2;
            }
            else
            {
                Pb("Shadow Temple", "Invisible Blades Left Chest", maptracker_Panel).ForeColor = red;
                Pb("Shadow Temple", "Invisible Blades Right Chest", maptracker_Panel).ForeColor = red;
                Pb("Shadow Temple", "Falling Spikes Lower Chest", maptracker_Panel).ForeColor = red;
            }
            //Shadow Upper Falling Spike
            if (Has(Dins) && Has(Nocturne) && Has(Magic) && Has(HoverBoots) && Has(Bomb) && Has(Strength) && shadow_keys >= 1)
            {
                Pb("Shadow Temple", "Falling Spikes Upper Chest", maptracker_Panel).ForeColor = Available;
                Pb("Shadow Temple", "Falling Spikes Switch Chest", maptracker_Panel).ForeColor = Available;
            }
            else if (Has(Dins) && Has(Nocturne) && Has(Magic) && Has(HoverBoots) && Has(Bomb) && Has(Strength))
            {
                Pb("Shadow Temple", "Falling Spikes Upper Chest", maptracker_Panel).ForeColor = coulddo;
                Pb("Shadow Temple", "Falling Spikes Switch Chest", maptracker_Panel).ForeColor = coulddo;
            }
            else
            {
                Pb("Shadow Temple", "Falling Spikes Upper Chest", maptracker_Panel).ForeColor = red;
                Pb("Shadow Temple", "Falling Spikes Switch Chest", maptracker_Panel).ForeColor = red;
            }
            //Shadow Invisible Spikes
            if (Has(Dins) && Has(Nocturne) && Has(Magic) && Has(HoverBoots) && Has(Bomb) && shadow_keys >= 2)
            {
                Pb("Shadow Temple", "Invisible Spikes Chest", maptracker_Panel).ForeColor = Available;
                Pb("Shadow Temple", "Shadow Pot", maptracker_Panel).ForeColor = Available;
                tokensAvailable++;
            }
            else if (Has(Dins) && Has(Nocturne) && Has(Magic) && Has(HoverBoots) && Has(Bomb))
            {
                Pb("Shadow Temple", "Invisible Spikes Chest", maptracker_Panel).ForeColor = coulddo;
                Pb("Shadow Temple", "Shadow Pot", maptracker_Panel).ForeColor = coulddo;
                tokensAvailable++;
            }
            else
            {
                Pb("Shadow Temple", "Invisible Spikes Chest", maptracker_Panel).ForeColor = red;
                Pb("Shadow Temple", "Shadow Pot", maptracker_Panel).ForeColor = red;
            }
            //Shadow Beyond Spikes
            if (Has(Dins) && Has(Nocturne) && Has(Magic) && Has(HoverBoots) && Has(Bomb) && Has(Hookshot) && shadow_keys >= 3)
            {
                Pb("Shadow Temple", "Wind Hint Chest", maptracker_Panel).ForeColor = Available;
                Pb("Shadow Temple", "After Wind Enemy Chest", maptracker_Panel).ForeColor = Available;
                Pb("Shadow Temple", "After Wind Hidden Chest", maptracker_Panel).ForeColor = Available;
            }
            else if (Has(Dins) && Has(Nocturne) && Has(Magic) && Has(HoverBoots) && Has(Bomb) && Has(Hookshot))
            {

                Pb("Shadow Temple", "Wind Hint Chest", maptracker_Panel).ForeColor = coulddo;
                Pb("Shadow Temple", "After Wind Enemy Chest", maptracker_Panel).ForeColor = coulddo;
                Pb("Shadow Temple", "After Wind Hidden Chest", maptracker_Panel).ForeColor = coulddo;
            }
            else
            {
                Pb("Shadow Temple", "Wind Hint Chest", maptracker_Panel).ForeColor = red;
                Pb("Shadow Temple", "After Wind Enemy Chest", maptracker_Panel).ForeColor = red;
                Pb("Shadow Temple", "After Wind Hidden Chest", maptracker_Panel).ForeColor = red;

            }
            //Shadow Beyond Boat
            if (Has(ZeldasLullaby) && Has(Dins) && Has(Nocturne) && Has(Magic) && Has(HoverBoots) && Has(Bomb) && Has(Hookshot) && shadow_keys >= 4)
            {
                Pb("Shadow Temple", "Invisible Floormaster Chest", maptracker_Panel).ForeColor = Available;
                Pb("Shadow Temple", "Spike Walls Left Chest", maptracker_Panel).ForeColor = Available;
                Pb("Shadow Temple", "Boss Key Chest", maptracker_Panel).ForeColor = Available;
                tokensAvailable++;
            }
            else if (Has(ZeldasLullaby) && Has(Dins) && Has(Nocturne) && Has(Magic) && Has(HoverBoots) && Has(Bomb) && Has(Hookshot))
            {
                Pb("Shadow Temple", "Invisible Floormaster Chest", maptracker_Panel).ForeColor = coulddo;
                Pb("Shadow Temple", "Spike Walls Left Chest", maptracker_Panel).ForeColor = coulddo;
                Pb("Shadow Temple", "Boss Key Chest", maptracker_Panel).ForeColor = coulddo;
                tokensAvailable++;
            }
            else
            {
                Pb("Shadow Temple", "Invisible Floormaster Chest", maptracker_Panel).ForeColor = red;
                Pb("Shadow Temple", "Spike Walls Left Chest", maptracker_Panel).ForeColor = red;
                Pb("Shadow Temple", "Boss Key Chest", maptracker_Panel).ForeColor = red;
            }
            //Shadow Bongo 
            if (Has(ZeldasLullaby) && Has(Dins) && Has(Nocturne) && Has(Magic) && Has(HoverBoots) && Has(Bomb) && (has_longshot || Has(Bow)) && shadow_keys == 5 && Has(ShadowBossKey))
            {
                Pb("Shadow Temple", "Bongo Bongo Heart", maptracker_Panel).ForeColor = Available;
            }
            else if (Has(ZeldasLullaby) && Has(Dins) && Has(Nocturne) && Has(Magic) && Has(HoverBoots) && Has(Bomb) && (has_longshot || Has(Bow)))
            {
                Pb("Shadow Temple", "Bongo Bongo Heart", maptracker_Panel).ForeColor = coulddo;
            }
            else
            {
                Pb("Shadow Temple", "Bongo Bongo Heart", maptracker_Panel).ForeColor = red;
            }
            //Skulltula          
            if (Has(Dins) && Has(Nocturne) && Has(Magic) && Has(HoverBoots) && Has(Bomb) && has_longshot)
            {
                tokensAvailable++;
            }
        }
    }
}
