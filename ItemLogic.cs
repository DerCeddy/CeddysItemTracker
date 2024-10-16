using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace CeddysItemTracker
{
    partial class Form1
    {
        public bool has_explosives = false;
        public bool can_blast_or_smash = false;
        public int wastelandcrossing = 0;
        public int desertaccess = 0;
        public bool has_firesource = false;
        public int craterplatformaccess = 0;
        public int has_or_can_red_tunic = 0;
        public bool has_or_can_get_gerudocard = false;
        public bool has_longshot = false;
        public bool has_gold_scale = false;
        public bool has_bottle = false;
        public bool can_get_beans = false;
        public bool rainbowbridge;
        public Color Available = Color.Lime;
        public Color red = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
        public Color coulddo = Color.Yellow;
        public Color OoLChus = Color.BlueViolet;
        static bool Has(Item ItemToCheck)
        {
            bool State;
            if (ItemToCheck.State == 0)
            {
                State = false;
            }
            else
            {
                State = true;
            }
            return State;
        }
        static Control Pb(string ControlPanelName,string Name, Panel panel)
        {           
            return panel.Controls.Find(ControlPanelName, true).First().Controls.Find(Name, true).First();
        }
        public void Sphere0Checks()
        {
            Panel maptracker_Panel = maptracker;
            Pb("Kakariko", "Chickens", maptracker_Panel).ForeColor = Available;
            Pb("Kakariko", "Anju as Adult", maptracker_Panel).ForeColor = Available;
            Pb("Kakariko", "Impas House Freestanding PoH", maptracker_Panel).ForeColor = Available;
            Pb("Kakariko", "Windmill Freestanding PoH", maptracker_Panel).ForeColor = Available;
            Pb("Kakariko", "Man on Roof", maptracker_Panel).ForeColor = Available;
            Pb("Kakariko", "Open Grotto Chest", maptracker_Panel).ForeColor = Available;
            Pb("Kakariko", "Windmill Song", maptracker_Panel).ForeColor = Available;
            Pb("Kokiri Forest", "Mido Top Left", maptracker_Panel).ForeColor = Available;
            Pb("Kokiri Forest", "Mido Top Right", maptracker_Panel).ForeColor = Available;
            Pb("Kokiri Forest", "Mido Bottom Left", maptracker_Panel).ForeColor = Available;
            Pb("Kokiri Forest", "Mido Bottom Right", maptracker_Panel).ForeColor = Available;
            Pb("Kokiri Forest", "Kokiri Sword Chest", maptracker_Panel).ForeColor = Available;
            Pb("Gerudo Valley", "Crate Freestanding PoH", maptracker_Panel).ForeColor = Available;
            Pb("Gerudo Valley", "Waterfall Freestanding PoH", maptracker_Panel).ForeColor = Available;
            Pb("Lake Hylia", "Child Fishing", maptracker_Panel).ForeColor = Available;
            Pb("Graveyard", "Shield Grave Chest", maptracker_Panel).ForeColor = Available;
            Pb("Graveyard", "Dampe Gravedigging Tour", maptracker_Panel).ForeColor = Available;
            Pb("Graveyard", "Dampe Race Hookshot Chest", maptracker_Panel).ForeColor = Available;
            Pb("Graveyard", "Dampe Race Freestanding PoH", maptracker_Panel).ForeColor = Available;
            Pb("Zora River", "Open Grotto Chest", maptracker_Panel).ForeColor = Available;
            Pb("Death Mountain Trail", "Freestanding PoH", maptracker_Panel).ForeColor = Available;
            Pb("Lost Woods", "Ocarina Memory Game", maptracker_Panel).ForeColor = Available;
            Pb("Lost Woods", "Deku Scrub Near Bridge", maptracker_Panel).ForeColor = Available;
            Pb("Lost Woods", "Skull Mask", maptracker_Panel).ForeColor = Available;
            Pb("Sacred Forest Meadow", "Sarias Song", maptracker_Panel).ForeColor = Available;
            Pb("Market", "Shooting Gallery Reward", maptracker_Panel).ForeColor = Available;
            Pb("Market", "Lost Dog", maptracker_Panel).ForeColor = Available;
            Pb("Hyrule Field", "Open Grotto", maptracker_Panel).ForeColor = Available;
            if (ScrubShuffle)
            {
                Pb("Lon-Lon-Ranch","Deku Scrub Grotto Left", maptracker_Panel).ForeColor = Available;
                Pb("Lon-Lon-Ranch", "Deku Scrub Grotto Center", maptracker_Panel).ForeColor = Available;
                Pb("Lon-Lon-Ranch", "Deku Scrub Grotto Right", maptracker_Panel).ForeColor = Available;
                Pb("Lake Hylia", "Deku Scrub Grotto Left", maptracker_Panel).ForeColor = Available;
                Pb("Lake Hylia", "Deku Scrub Grotto Center", maptracker_Panel).ForeColor = Available;
                Pb("Lake Hylia", "Deku Scrub Grotto Right", maptracker_Panel).ForeColor = Available;
                Pb("Lost Woods", "Deku Scrub Near Deku Theater Left", maptracker_Panel).ForeColor = Available;
                Pb("Lost Woods", "Deku Scrub Near Deku Theater Right", maptracker_Panel).ForeColor = Available;
            } 
            if(ShopShuffle)
            {

            }
        }
        public void ItemLogic()
        {
            Panel maptracker_Panel = maptracker;
            tokensAvailable = 13;                                          
            #region Has Anything
            //Explosives
            if (Has(Bomb))
            {
                has_explosives = true;
            }
            else
            {
                has_explosives = false;
            }
            if (Has(Bomb) || Has(Hammer))
            {
                can_blast_or_smash = true;
            }
            else
            {
                can_blast_or_smash = false;
            }
            //Longshot
            if (Hookshot.State == 2)
            {
                has_longshot = true;
            }
            else
            {
                has_longshot = false;
            }
            //Has Fire Source
            if (Has(Magic) && (Has(Dins) || (Has(Bow) && Has(FireArrow))))
            {
                has_firesource = true;
            }
            else
            {
                has_firesource = false;
            }
            //Can buy Goron Tunic or has it
            if (Has(GoronTunic) || (Has(Wallet) && (Has(ZeldasLullaby) || (Has(Bomb) || Has(Strength) || Has(Bow)))))
            {
                has_or_can_red_tunic = 1;
            }
            else
            {
                has_or_can_red_tunic = 0;
            }
            if (Has(GerudoCard) || Has(EponasSong) || has_longshot)
            {
                has_or_can_get_gerudocard = true;
            }
            else
            {
                has_or_can_get_gerudocard = false;
            }
            //Has Bottle
            if ((Has(RutoLetter) && (Has(Scales) || (Has(Bomb) && Has(ZeldasLullaby)))) || Has(Bottle2) || Has(Bottle3) || Has(Bottle4))
            {
                has_bottle = true;
            }
            else
            {
                has_bottle = false;
            }
            //Can get Beans
            if (Has(Bomb) || Has(Scales))
            {
                can_get_beans = true;
            }
            else
            {
                can_get_beans = false;
            }
            #endregion          
            #region Entrance Helper
            if (has_or_can_get_gerudocard && Has(Lens) && Has(Magic) && (Has(HoverBoots) || has_longshot))
            {
                wastelandcrossing = 1;
            }
            else
            {
                wastelandcrossing = 0;
            }
            if (Has(Reqiuem) || wastelandcrossing == 1)
            {
                desertaccess = 1;
            }
            else
            {
                desertaccess = 0;
            }
            if (Has(Bolero) || ((Has(Hookshot) || Has(HoverBoots)) && (Has(Bomb) || Has(Bow) || Has(Strength))))
            {
                craterplatformaccess = 1;
            }
            else
            {
                craterplatformaccess = 0;
            }
            //Rainbowbridge
            switch (Goalrequirement)
            {
                case "Medallions":
                    {
                        if (Has(ForestMedallion) && Has(FireMedallion) && Has(WaterMedallion) && Has(SpiritMedallion) && Has(ShadowMedallion) && Has(LightMedallion))
                        {
                            rainbowbridge = true;
                        }
                        else
                        {
                            rainbowbridge = false;
                        }
                        break;
                    }
                case "AD":
                    {
                        if (Has(ForestMedallion) && Has(FireMedallion) && Has(WaterMedallion) && Has(SpiritMedallion) && Has(ShadowMedallion) && Has(LightMedallion) && Has(KokiriStone) && Has(GoronStone) && Has(ZoraStone))
                        {
                            rainbowbridge = true;
                        }
                        else
                        {
                            rainbowbridge = false;
                        }
                        break;
                    }
                case "SGL":
                    {
                        if (Has(KokiriStone) && Has(GoronStone) && Has(ZoraStone))
                        {
                            rainbowbridge = true;
                        }
                        else
                        {
                            rainbowbridge = false;
                        }
                        break;
                    }
                case "Vanilla":
                    {
                        if (Has(SpiritMedallion) && Has(ShadowMedallion) && Has(LightArrow))
                        {
                            rainbowbridge = true;
                        }
                        else
                        {
                            rainbowbridge = false;
                        }
                        break;
                    }
            }
            #endregion
            #region Kokiri Forest
            //Storms Grotto
            if (Has(SongOfStorms))
            {
                Pb("Kokiri Forest","Storms Grotto",maptracker_Panel).ForeColor = Available;
            }
            else
            {
                Pb("Kokiri Forest", "Storms Grotto", maptracker_Panel).ForeColor = red;
            }
            if (Has(Hookshot))
            {
                tokensAvailable++;
            }
            #endregion
            #region Lon-Lon-Ranch
            Pb("Lon-Lon-Ranch", "Talon Minigame", maptracker_Panel).ForeColor = Available;
            Pb("Lon-Lon-Ranch", "Malon Song", maptracker_Panel).ForeColor = Available;
            Pb("Lon-Lon-Ranch", "LLR HP", maptracker_Panel).ForeColor = Available;
            #endregion
            #region SFM
            //Wolfo Grotto
            if (Has(Bomb) || ((Has(SariasSong) || Has(Minuet)) && Has(Hammer)))
            {
                Pb("Sacred Forest Meadow", "Wolfo Grotto", maptracker_Panel).ForeColor = Available;
            }
            else if (Has(Bombchu) || ((Has(SariasSong) || Has(Minuet)) && Has(Hammer)))
            {
                Pb("Sacred Forest Meadow", "Wolfo Grotto", maptracker_Panel).ForeColor = OoLChus;
            }
            else
            {
                Pb("Sacred Forest Meadow", "Wolfo Grotto", maptracker_Panel).ForeColor = red;
            }
            //Shiek in Forest
            if (Has(SariasSong) || Has(Minuet))
            {
                Pb("Sacred Forest Meadow", "Shiek in Forest", maptracker_Panel).ForeColor = Available;
            }
            else
            {
                Pb("Sacred Forest Meadow", "Shiek in Forest", maptracker_Panel).ForeColor = red;
            }       
            //Skulltula
            if (Has(Hookshot))
            {
                tokensAvailable++;
            }
            #endregion
            #region Lost Woods
            //Skull Kid
            if (Has(SariasSong))
            {
                Pb("Lost Woods", "Skull Kid", maptracker_Panel).ForeColor = Available;
            }
            else
            {
                Pb("Lost Woods", "Skull Kid", maptracker_Panel).ForeColor = red;
            }
            //Target in the Woods
            if (Has(Slingshot))
            {
                Pb("Lost Woods", "Target in the Woods", maptracker_Panel).ForeColor = Available;
            }
            else
            {
                Pb("Lost Woods", "Target in the Woods", maptracker_Panel).ForeColor = red;
            }
            //Near Goron City Shortcut
            if (Has(Bomb) || Has(Hammer))
            {
                Pb("Lost Woods", "Near Shortcuts Grotto Chest", maptracker_Panel).ForeColor = Available;
            }
            else if (Has(Bombchu))
            {
                Pb("Lost Woods", "Near Shortcuts Grotto Chest", maptracker_Panel).ForeColor = OoLChus;
            }
            else
            {
                Pb("Lost Woods", "Near Shortcuts Grotto Chest", maptracker_Panel).ForeColor = red;
            }
            //Scrubs Near SFM Exit
            if (((Has(SariasSong) || Has(Minuet)) && Has(Hammer)) || Bomb.State == 1)
            {
                Pb("Lost Woods", "Deku Scrub Grotto Front", maptracker_Panel).ForeColor = Available;
            }
            else if (Has(Bombchu))
            {
                Pb("Lost Woods", "Deku Scrub Grotto Front", maptracker_Panel).ForeColor = OoLChus;
            }
            else
            {
                Pb("Lost Woods", "Deku Scrub Grotto Front", maptracker_Panel).ForeColor = red;
            }
            //Skulltula
            if (Has(Beans) || can_get_beans)
            {
                tokensAvailable++;
            }
            #endregion
            #region Forest Temple
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
                tokensAvailable ++;
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
            #endregion
            #region Deku Tree
            //Deku Tree Entry
            if (Has(KokiriSword))
            {
                Pb("Deku Tree", "Map Chest", maptracker_Panel).ForeColor = Available;
                Pb("Deku Tree", "Compass Chest", maptracker_Panel).ForeColor = Available;
                Pb("Deku Tree", "Basement Chest", maptracker_Panel).ForeColor = Available;
                Pb("Deku Tree", "Slingshot Room Side Chest", maptracker_Panel).ForeColor = Available;
                Pb("Deku Tree", "Slingshot Chest", maptracker_Panel).ForeColor = Available;
                Pb("Deku Tree", "Compass Room Side Chest", maptracker_Panel).ForeColor = Available;
                tokensAvailable += 2;
            }
            else
            {
                Pb("Deku Tree", "Basement Chest", maptracker_Panel).ForeColor = red;
                Pb("Deku Tree", "Compass Chest", maptracker_Panel).ForeColor = red;
                Pb("Deku Tree", "Map Chest", maptracker_Panel).ForeColor = red;
                Pb("Deku Tree", "Slingshot Room Side Chest", maptracker_Panel).ForeColor = red;
                Pb("Deku Tree", "Slingshot Chest", maptracker_Panel).ForeColor = red;
                Pb("Deku Tree", "Compass Room Side Chest", maptracker_Panel).ForeColor = red;
            }
            //Deku Tree Gohma
            if (Has(KokiriSword) && Has(Slingshot))
            {
                Pb("Deku Tree", "Gohma Heart", maptracker_Panel).ForeColor = Available;
            }
            else
            {
                Pb("Deku Tree", "Gohma Heart", maptracker_Panel).ForeColor = red;
            }
            //Skulltula
            if ((Has(Slingshot) || Has(Boomerang)) || (Has(Magic) && Has(Dins)))
            {
                tokensAvailable++;
            }
            if (Has(Bomb) && Has(Boomerang) && Has(KokiriSword))
            {
                tokensAvailable++;
            }
            #endregion
            #region Hyrule Field         
            //Checks under Rocks and Salesman
            if (Has(Bomb) || Has(Hammer))
            {
                Pb("Hyrule Field", "North Grotto", maptracker_Panel).ForeColor = Available;
                Pb("Hyrule Field", "Salesman", maptracker_Panel).ForeColor = Available;
                Pb("Hyrule Field", "Southeast Grotto", maptracker_Panel).ForeColor = Available;
            }
            else if (Has(Bombchu))
            {
                Pb("Hyrule Field", "North Grotto", maptracker_Panel).ForeColor = OoLChus;
                Pb("Hyrule Field", "Salesman", maptracker_Panel).ForeColor = OoLChus;
                Pb("Hyrule Field", "Southeast Grotto", maptracker_Panel).ForeColor = OoLChus;
            }
            else
            {
                Pb("Hyrule Field", "North Grotto", maptracker_Panel).ForeColor = red;
                Pb("Hyrule Field", "Salesman", maptracker_Panel).ForeColor = red;
                Pb("Hyrule Field", "Southeast Grotto", maptracker_Panel).ForeColor = red;
            }
            //Diving Grotto
            if ((Has(Bomb) || Has(Hammer)) && (Scales.State == 2 || Has(IronBoots)))
            {
                Pb("Hyrule Field", "Tektite Grotto Freestanding PoH", maptracker_Panel).ForeColor = Available;
            }
            else if (Has(Bombchu) && (Scales.State == 2 || Has(IronBoots)))
            {
                Pb("Hyrule Field", "Tektite Grotto Freestanding PoH", maptracker_Panel).ForeColor = OoLChus;
            }
            else
            {
                Pb("Hyrule Field", "Tektite Grotto Freestanding PoH", maptracker_Panel).ForeColor = red;
            }
            //Song of Time
            if (Has(KokiriStone) && Has(GoronStone) && Has(ZoraStone))
            {
                Pb("Hyrule Field", "Song of Time", maptracker_Panel).ForeColor = Available;
            }
            else
            {
                Pb("Hyrule Field", "Song of Time", maptracker_Panel).ForeColor = red;
            }
            //Skulltula
            if((Has(Boomerang) && Has(Bomb)) || (can_blast_or_smash && Has(Hookshot)))
            {
                tokensAvailable++;
            }
            if(has_firesource && Has(Bomb) && (Has(Hookshot) || Has(Boomerang)))
            {
                tokensAvailable++;
            }
            #endregion           
            #region Market
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
            #endregion
            #region Castles
            //HC
            if (has_explosives && Has(ZeldasLullaby))
            {
                Pb("Castles", "HC Great Fairy Reward", maptracker_Panel).ForeColor = Available;
            }
            else if (Has(Bombchu) && Has(ZeldasLullaby))
            {
                Pb("Castles", "HC Great Fairy Reward", maptracker_Panel).ForeColor = OoLChus;
            }
            else
            {
                Pb("Castles", "HC Great Fairy Reward", maptracker_Panel).ForeColor = red;
            }
            //OGC
            if (Strength.State == 3)
            {
                Pb("Castles", "GC Great Fairy Reward", maptracker_Panel).ForeColor = Available;
            }
            else
            {
                Pb("Castles", "GC Great Fairy Reward", maptracker_Panel).ForeColor = red;
            }   
            //SKulltula
            if (Has(SongOfStorms) && Has(Bomb))
            {
                tokensAvailable++;
            }
            #endregion
            #region Kakariko
            //Kak Shooting Gallery
            if (Has(Bow))
            {
                Pb("Kakariko", "Shooting Gallery", maptracker_Panel).ForeColor = Available;
            }
            else
            {
                Pb("Kakariko", "Shooting Gallery", maptracker_Panel).ForeColor = red;
            }
            //Kak Redead Grotto
            if (can_blast_or_smash)
            {
                Pb("Kakariko", "Redead Grotto Chest", maptracker_Panel).ForeColor = Available;
            }
            else if (Has(Bombchu))
            {
                Pb("Kakariko", "Redead Grotto Chest", maptracker_Panel).ForeColor = OoLChus;
            }
            else
            {
                Pb("Kakariko", "Redead Grotto Chest", maptracker_Panel).ForeColor = red;
            }
            //Shiek at Kakariko
            if (Has(ForestMedallion) && Has(FireMedallion) && Has(WaterMedallion))
            {
                Pb("Kakariko", "Shiek at Kakariko", maptracker_Panel).ForeColor = Available;
            }
            else
            {
                Pb("Kakariko", "Shiek at Kakariko", maptracker_Panel).ForeColor = red;
            }
            
            //Skulltula
            if(Has(Slingshot) || Has(Bomb))
            {
                tokensAvailable++;
            }
            if(Has(Hookshot))
            {
                tokensAvailable++;
            }
            #endregion
            #region Graveyard
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
            if(Has(Boomerang))
            {
                tokensAvailable++;
            }
            #endregion
            #region Shadow Temple
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
            #endregion            
            #region DMT
            //DMT Chest
            if (can_blast_or_smash)
            {
                Pb("Death Mountain Trail", "Chest", maptracker_Panel).ForeColor = Available;
            }
            else if (Has(Bombchu))
            {
                Pb("Death Mountain Trail", "Chest", maptracker_Panel).ForeColor = OoLChus;
            }
            else
            {
                Pb("Death Mountain Trail", "Chest", maptracker_Panel).ForeColor = red;
            }
            //Storms Grotto
            if (Has(SongOfStorms))
            {
                Pb("Death Mountain Trail", "Storms Grotto Chest", maptracker_Panel).ForeColor = Available;
            }
            else
            {
                Pb("Death Mountain Trail", "Storms Grotto Chest", maptracker_Panel).ForeColor = red;
            }
            //Great Fairy
            if (can_blast_or_smash && Has(ZeldasLullaby))
            {
                Pb("Death Mountain Trail", "Great Fairy Reward", maptracker_Panel).ForeColor = Available;
            }
            else if (Has(Bombchu) && Has(ZeldasLullaby))
            {
                Pb("Death Mountain Trail", "Great Fairy Reward", maptracker_Panel).ForeColor = OoLChus;
            }
            else
            {
                Pb("Death Mountain Trail", "Great Fairy Reward", maptracker_Panel).ForeColor = red;
            }
            //Big Goron
            if (AdultTradeItems.State >= 3 && can_blast_or_smash)
            {
                Pb("Death Mountain Trail", "Biggoron", maptracker_Panel).ForeColor = Available;
            }
            else if (AdultTradeItems.State >= 3 && Has(Bombchu))
            {
                Pb("Death Mountain Trail", "Biggoron", maptracker_Panel).ForeColor = OoLChus;
            }
            else
            {
                Pb("Death Mountain Trail", "Biggoron", maptracker_Panel).ForeColor = red;
            }
            //Skulls
            if ((has_explosives || Has(Bombchu)) && has_bottle)
            {
                tokensAvailable += 1;
            }
            if (Has(Bomb) || Has(Bombchu))
            {
                tokensAvailable += 1;
            }
            if (Has(Hammer)) 
            { 
                tokensAvailable += 2; 
            }
            #endregion
            #region Goron City
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
            if (has_explosives && Has(ZeldasLullaby))
            {
                Pb("Goron City", "Pot Freestanding PoH", maptracker_Panel).ForeColor = Available;
            }
            else if (Has(Bombchu) && Has(ZeldasLullaby))
            {
                Pb("Goron City", "Pot Freestanding PoH", maptracker_Panel).ForeColor = OoLChus;
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
            else if (Has(Bombchu))
            {
                Pb("Goron City", "Rolling Goron as Child", maptracker_Panel).ForeColor = OoLChus;
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
            else if (Has(Bombchu))
            {
                Pb("Goron City", "Rolling Goron as Adult", maptracker_Panel).ForeColor = OoLChus;
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
            else if (Has(Bombchu))
            {
                Pb("Goron City", "Maze Right Chest", maptracker_Panel).ForeColor = OoLChus;
                Pb("Goron City", "Maze Center Chest", maptracker_Panel).ForeColor = OoLChus;
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
            if (has_explosives || Has(Bombchu))
            {
                tokensAvailable += 1;
            }
            #endregion
            #region DMC
            //DMC Freestanding PoH
            if (has_explosives || Has(Strength) || Has(Bow) || (Has(Bolero) && (Has(Hookshot) || Has(HoverBoots))))
            {
                Pb("Death Mountain Crater", "Wall Freestanding PoH", maptracker_Panel).ForeColor = Available;
            }
            else if (Has(Bombchu))
            {
                Pb("Death Mountain Crater", "Wall Freestanding PoH", maptracker_Panel).ForeColor = OoLChus;
            }
            else
            {
                Pb("Death Mountain Crater", "Wall Freestanding PoH", maptracker_Panel).ForeColor = red;
            }
            //DMC Upper Grotto
            if (Has(Bomb) || (Has(Hammer) && (Has(Strength) || Has(Bow) || (Has(Bolero) && (Has(Hookshot) || Has(HoverBoots))))))
            {
                Pb("Death Mountain Crater", "Upper Grotto Chest", maptracker_Panel).ForeColor = Available;
            }
            else if (Has(Bombchu))
            {
                Pb("Death Mountain Crater", "Upper Grotto Chest", maptracker_Panel).ForeColor = OoLChus;
            }
            else
            {
                Pb("Death Mountain Crater", "Upper Grotto Chest", maptracker_Panel).ForeColor = red;
            }
            //DMC Volcano PoH
            if (Has(HoverBoots) && (has_explosives || Has(Strength) || Has(Bow) || Has(Bolero)) || (Has(Beans) && Has(Bolero)))
            {
                Pb("Death Mountain Crater", "Volcano Freestanding PoH", maptracker_Panel).ForeColor = Available;
            }
            else if (Has(HoverBoots) && Has(Bombchu))
            {
                Pb("Death Mountain Crater", "Volcano Freestanding PoH", maptracker_Panel).ForeColor = OoLChus;
            }
            else
            {
                Pb("Death Mountain Crater", "Volcano Freestanding PoH", maptracker_Panel).ForeColor = red;
            }
            //DMC Greaty Fairy
            if (Has(Hammer) && Has(ZeldasLullaby) && (Bomb.State == 1 || Has(Strength) || Has(Bow) || (Has(Bolero) && (Has(Hookshot) || Has(HoverBoots)))))
            {
                Pb("Death Mountain Crater", "Great Fairy Reward", maptracker_Panel).ForeColor = Available;
            }
            else
            {
                Pb("Death Mountain Crater", "Great Fairy Reward", maptracker_Panel).ForeColor = red;
            }
            //Shiek at Crater
            if (craterplatformaccess == 1)
            {
                Pb("Death Mountain Crater", "Shiek at Crater", maptracker_Panel).ForeColor = Available;
            }
            else if (Has(Bombchu) && (Has(HoverBoots) || Has(Hookshot)))                 
            {
                Pb("Death Mountain Crater", "Shiek at Crater", maptracker_Panel).ForeColor = OoLChus;
            }
            else
            {
                Pb("Death Mountain Crater", "Shiek at Crater", maptracker_Panel).ForeColor = red;
            }
            //Skulltula
            if (Has(Bomb))
            {
                tokensAvailable++; 
            }
            if(Has(Bolero) && has_bottle)
            {
                tokensAvailable++;
            }
            #endregion
            #region Fire Temple
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
            #endregion
            #region Lake Hylia
            //Underwater Item
            if (Has(Scales))
            {
                Pb("Lake Hylia", "Underwater Item", maptracker_Panel).ForeColor = Available;
            }
            else
            {
                Pb("Lake Hylia", "Underwater Item", maptracker_Panel).ForeColor = red;
            }
            //Labdive
            if (Scales.State == 2)
            {
                Pb("Lake Hylia", "Lab Dive", maptracker_Panel).ForeColor = Available;
            }
            else
            {
                Pb("Lake Hylia", "Lab Dive", maptracker_Panel).ForeColor = red;
            }
            //Adult fishing and PoH
            if (Has(Hookshot) || Has(Beans))
            {
                Pb("Lake Hylia", "Adult Fishing", maptracker_Panel).ForeColor = Available;
                Pb("Lake Hylia", "Freestanding PoH", maptracker_Panel).ForeColor = Available;
            }
            else if(Has(Hookshot) || can_get_beans)
            {
                Pb("Lake Hylia", "Adult Fishing", maptracker_Panel).ForeColor = coulddo;
                Pb("Lake Hylia", "Freestanding PoH", maptracker_Panel).ForeColor = coulddo;
            }
            else
            {
                Pb("Lake Hylia", "Adult Fishing", maptracker_Panel).ForeColor = red;
                Pb("Lake Hylia", "Freestanding PoH", maptracker_Panel).ForeColor = red;
            }
            //Shoot the sun
            if (has_longshot && Has(Bow))
            {
                Pb("Lake Hylia", "Shoot the Sun", maptracker_Panel).ForeColor = Available;
            }
            else
            {
                Pb("Lake Hylia", "Shoot the Sun", maptracker_Panel).ForeColor = red;
            }
            //Skulltulla
            if (Has(Boomerang))
            {
                tokensAvailable++;
            }
            if (has_longshot)
            {
                tokensAvailable++;
            }
            if (Has(IronBoots) && Has(Hookshot))
            {
                tokensAvailable++;
            }
            #endregion
            #region Water Temple
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
            #endregion
            #region Gerudo Valley
            if (Has(Hammer) && (Has(EponasSong) || has_longshot))
            {
                Pb("Gerudo Valley", "Hammer Chest", maptracker_Panel).ForeColor = Available;
            }
            else
            {
                Pb("Gerudo Valley", "Hammer Chest", maptracker_Panel).ForeColor = red;
            }
            //Skulltula
            if (Has(Hookshot) && (Has(EponasSong) || has_longshot))
            {
                tokensAvailable += 2;
            }
            #endregion
            #region Gerudo Fortress   
            /*
            if (Has(EponasSong) || has_longshot)
            {
                Pb("Gerudo Fortress", "Carpenter", maptracker_Panel).ForeColor = Available;
                tokensAvailable++;
            }
            else
            {
                Pb("Gerudo Fortress", "Carpenter", maptracker_Panel).ForeColor = red;
            }  
            */
            if (has_or_can_get_gerudocard && Has(EponasSong) && Has(Bow))
            {
                Pb("Gerudo Fortress", "HBA 1000 Points", maptracker_Panel).ForeColor = Available;
                Pb("Gerudo Fortress", "HBA 1500 Points", maptracker_Panel).ForeColor = Available;
            }
            else
            {
                Pb("Gerudo Fortress", "HBA 1000 Points", maptracker_Panel).ForeColor = red;
                Pb("Gerudo Fortress", "HBA 1500 Points", maptracker_Panel).ForeColor = red;
            }
            if ((Has(Hookshot) || Has(HoverBoots)) && has_or_can_get_gerudocard)
            {
                Pb("Gerudo Fortress", "Chest on Roof", maptracker_Panel).ForeColor = Available;
            }
            else
            {
                Pb("Gerudo Fortress", "Chest on Roof", maptracker_Panel).ForeColor = red;
            }
            //Skulltula
            if ((Has(EponasSong) || has_longshot) && Has(Hookshot))
            {
                tokensAvailable += 2;
            }
            #endregion
            #region Wasteland
            if (has_or_can_get_gerudocard && Has(Magic) && (has_longshot || Has(HoverBoots)) && ((Has(Bow) && Has(FireArrow)) || Has(Dins)))
            {
                Pb("Haunted Wasteland", "Wasteland Chest", maptracker_Panel).ForeColor = Available;
            }
            else
            {
                Pb("Haunted Wasteland", "Wasteland Chest", maptracker_Panel).ForeColor = red;
            }
            //Skulltula
            if (has_or_can_get_gerudocard && Has(Hookshot) && (has_longshot || Has(HoverBoots)))
            {
                tokensAvailable++;
            }
            #endregion
            #region Desert Colossus
            //Shiek at Colossus
            if (desertaccess == 1)
            {
                Pb("Desert Colossus", "Shiek at Colossus", maptracker_Panel).ForeColor = Available;
            }
            else
            {
                Pb("Desert Colossus", "Shiek at Colossus", maptracker_Panel).ForeColor = red;
            }
            //Colossus Fairy
            if (desertaccess == 1 && Bomb.State == 1 && Has(ZeldasLullaby))
            {
                Pb("Desert Colossus", "Great Fairy Reward", maptracker_Panel).ForeColor = Available;
            }
            else if (desertaccess == 1 && Bomb.State == 1 && Has(ZeldasLullaby))
            {
                Pb("Desert Colossus", "Great Fairy Reward", maptracker_Panel).ForeColor = OoLChus;
            }
            else
            {
                Pb("Desert Colossus", "Great Fairy Reward", maptracker_Panel).ForeColor = red;
            }
            //Arc
            if (desertaccess == 1 && Has(Beans))
            {
                Pb("Desert Colossus", "Freestanding PoH", maptracker_Panel).ForeColor = Available;
            }
            else if (desertaccess == 1 && (Has(Bomb) || Has(Scales)))
            {
                Pb("Desert Colossus", "Freestanding PoH", maptracker_Panel).ForeColor = coulddo;
            }
            else
            {
                Pb("Desert Colossus", "Freestanding PoH", maptracker_Panel).ForeColor = red;
            }
            //Skulltula
            if (desertaccess == 1 && Has(Hookshot))
            {
                tokensAvailable++;
            }
            if (desertaccess == 1 && (has_longshot || can_get_beans))
            {
                tokensAvailable++;
            }
            if (desertaccess == 1 && has_bottle)
            {
                tokensAvailable++;
            }
            #endregion
            #region Spirit Temple
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
            else if ((Has(Reqiuem) && spirit_keys == 5 && (Has(Slingshot) || Has(Boomerang))) || (desertaccess == 1 && Strength.State >= 2 && spirit_keys >= 3 && (Has(Hookshot) || Has(Bow))) || (desertaccess == 1 && spirit_keys >= 1 && (((Has(Slingshot) || Has(Boomerang)) && (Has(Bow) || Has(Hookshot))) || Has(Bombchu))))
            {
                Pb("Spirit Temple", "Child Climb North Chest", maptracker_Panel).ForeColor = OoLChus;
                Pb("Spirit Temple", "Child Climb East Chest", maptracker_Panel).ForeColor = OoLChus;
                tokensAvailable++;
            }
            else if ((Has(Reqiuem) && (Has(Slingshot) || Has(Boomerang))) || (desertaccess == 1 && Strength.State >= 2  && (Has(Hookshot) || Has(Bow))) || (desertaccess == 1  && (((Has(Slingshot) || Has(Boomerang)) && (Has(Bow) || Has(Hookshot))) || Bomb.State == 1)))
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
            else if ((Has(Reqiuem) && (spirit_keys == 5 || (Has(Dins) && Has(Magic) && spirit_keys >= 1)) && Has(Bombchu) && (Has(Slingshot) || Has(Boomerang))) || (desertaccess == 1 && Strength.State >= 2 && spirit_keys >= 3 && has_firesource && (Has(Hookshot) || Has(Bow))))
            {
                Pb("Spirit Temple", "Map Chest", maptracker_Panel).ForeColor = OoLChus;
                Pb("Spirit Temple", "Sun Block Room Chest", maptracker_Panel).ForeColor = OoLChus;
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
            else if ((Has(Reqiuem) && (Has(Slingshot) || Has(Boomerang)) && Has(Bombchu) && spirit_keys == 5) || (desertaccess == 1 && Strength.State >= 2 && has_longshot && Bomb.State == 1 && spirit_keys >= 3))
            {
                Pb("Spirit Temple", "Silver Gauntlets Chest", maptracker_Panel).ForeColor = OoLChus;
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
            if (desertaccess == 1 && Strength.State >= 2 && (Has(Hookshot) || Has(Bow)))
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
            if (desertaccess == 1 && Strength.State >= 2 && spirit_keys >= 3 && (Has(Hookshot) || Has(Bow)))
            {

                Pb("Spirit Temple", "First Mirror Left Chest", maptracker_Panel).ForeColor = Available;
                Pb("Spirit Temple", "First Mirror Right Chest", maptracker_Panel).ForeColor = Available;
            }
            else if (desertaccess == 1 && Strength.State >= 2 && (Has(Hookshot) || Has(Bow)))
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
            if (desertaccess == 1 && Strength.State >= 2 && spirit_keys >= 3 && (Has(Hookshot) || Has(Bow)) && Has(ZeldasLullaby))
            {
                Pb("Spirit Temple", "Statue Room Hand Chest", maptracker_Panel).ForeColor = Available;
            }
            else if (desertaccess == 1 && Strength.State >= 2 && (Has(Hookshot) || Has(Bow)) && Has(ZeldasLullaby))
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
            if (desertaccess == 1 && Strength.State >= 2 && spirit_keys >= 4 && (Has(Hookshot) || Has(Bow)) && Bomb.State == 1)
            {
                Pb("Spirit Temple", "Hallway Right Invisible Chest", maptracker_Panel).ForeColor = Available;
                Pb("Spirit Temple", "Hallway Left Invisible Chest", maptracker_Panel).ForeColor = Available;
                Pb("Spirit Temple", "Mirror Shield Chest", maptracker_Panel).ForeColor = Available;
            }
            else if (desertaccess == 1 && Strength.State >= 2 && spirit_keys >= 4 && (Has(Hookshot) || Has(Bow)) && Has(Bombchu))
            {
                Pb("Spirit Temple", "Hallway Right Invisible Chest", maptracker_Panel).ForeColor = OoLChus;
                Pb("Spirit Temple", "Hallway Left Invisible Chest", maptracker_Panel).ForeColor = OoLChus;
                Pb("Spirit Temple", "Mirror Shield Chest", maptracker_Panel).ForeColor = OoLChus;
            }
            else if (desertaccess == 1 && Strength.State >= 2 && (Has(Hookshot) || Has(Bow)) && Bomb.State == 1)
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
            else if (desertaccess == 1 && Strength.State >= 2 && (Has(Hookshot) || Has(Bow)) && Has(Bombchu) && Has(MirrorShield) && spirit_keys >= 4)
            {
                Pb("Spirit Temple", "Near Four Armos Chest", maptracker_Panel).ForeColor = OoLChus;
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
            else if (desertaccess == 1 && Strength.State >= 2 && Has(ZeldasLullaby) && spirit_keys == 5 && Has(Hookshot) && Has(Bow) && ((has_longshot || Has(Bombchu)) || ((Has(Bombchu) || (Has(Dins) && Has(Magic)) || Has(Nuts)) && (Has(Bow) || Has(Hookshot) || Has(Hammer)))))
            {
                Pb("Spirit Temple", "Boss Key Chest", maptracker_Panel).ForeColor = OoLChus;
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
            else if (desertaccess == 1 && Strength.State >= 2 && spirit_keys == 5 && Has(MirrorShield) && (Has(Hookshot) || Has(Bow)) && ((has_longshot || Has(Bombchu)) || ((Has(Bombchu) || (Has(Dins) && Has(Magic)) || Has(Nuts)) && (Has(Bow) || Has(Hookshot) || Has(Hammer)))))
            {
                Pb("Spirit Temple", "Topmost Chest", maptracker_Panel).ForeColor = OoLChus;

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
            else if (desertaccess == 1 && Strength.State >= 2 && Has(MirrorShield) && Has(SpiritBossKey) && spirit_keys == 5 && (Has(Hookshot) || Has(Bow)) && ((has_longshot || Has(Bombchu)) || ((Has(Bombchu) || (Has(Dins) && Has(Magic)) || Has(Nuts)) && (Has(Bow) || Has(Hookshot) || Has(Hammer)))))
            {
                Pb("Spirit Temple", "Twinrova Heart", maptracker_Panel).ForeColor = OoLChus;
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
            if((spirit_keys == 5 && Has(Boomerang)) || (spirit_keys >= 3 && (Has(Hookshot) || Has(HoverBoots))))
            {
                tokensAvailable++;
            }
            if ((spirit_keys == 5 && Has(Boomerang)) || (spirit_keys >= 3 && Has(Hookshot)))
            {
                tokensAvailable++;
            }
            #endregion
            #region Zora River
            //Both PoH
            if (Bomb.State == 1 || Has(Scales) || Has(HoverBoots))
            {
                Pb("Zora River", "Near Open Grotto Freestanding Heart", maptracker_Panel).ForeColor = Available;
                Pb("Zora River", "Near Domain Freestanding PoH", maptracker_Panel).ForeColor = Available;
            }
            else
            {
                Pb("Zora River", "Near Open Grotto Freestanding Heart", maptracker_Panel).ForeColor = red;
                Pb("Zora River", "Near Domain Freestanding PoH", maptracker_Panel).ForeColor = red;
            }
            //Frogs1
            if (Has(SongOfStorms) && (Bomb.State == 1 || Has(Scales)))
            {
                Pb("Zora River", "Frogs in the Rain", maptracker_Panel).ForeColor = Available;
            }
            else
            {
                Pb("Zora River", "Frogs in the Rain", maptracker_Panel).ForeColor = red;
            }
            //FrogGame
            if ((Has(ZeldasLullaby) && Has(EponasSong) && Has(SariasSong) && Has(SunSong) && Has(SongOfStorms) && Has(SongOfTime)) && (Has(Scales) || Bomb.State == 1))
            {
                Pb("Zora River", "Frogs Ocarina Game", maptracker_Panel).ForeColor = Available;
            }
            else
            {
                Pb("Zora River", "Frogs Ocarina Game", maptracker_Panel).ForeColor = red;
            }
            //Skulls
            if (Has(Scales) || Bomb.State == 1)
            {
                tokensAvailable += 1;
            }
            if (Has(Hookshot))
            {
                tokensAvailable += 2;
            }
            #endregion
            #region Zora Fountain
            //Zora Fountain Fairy
            if (Has(RutoLetter) && Bomb.State == 1 && Has(ZeldasLullaby))
            {
                Pb("Zora Fountain", "Great Fairy Reward", maptracker_Panel).ForeColor = Available;
            }
            else if (Has(RutoLetter) && Has(Bombchu) && Has(ZeldasLullaby))
            {
                Pb("Zora Fountain", "Great Fairy Reward", maptracker_Panel).ForeColor = OoLChus;
            }
            else
            {
                Pb("Zora Fountain", "Great Fairy Reward", maptracker_Panel).ForeColor = red;
            }
            //Zora Fountain Freestanding PoH
            if (Has(RutoLetter) && Has(ZeldasLullaby) && (Bomb.State == 1 || Has(Scales)))
            {
                Pb("Zora Fountain", "Iceberg Freestanding PoH", maptracker_Panel).ForeColor = Available;
                tokensAvailable += 1;
            }
            else if (Has(RutoLetter) && Has(ZeldasLullaby) && Has(Bombchu))
            {
                Pb("Zora Fountain", "Iceberg Freestanding PoH", maptracker_Panel).ForeColor = OoLChus;              
            }
            else
            {
                Pb("Zora Fountain", "Iceberg Freestanding PoH", maptracker_Panel).ForeColor = red;
            }
            //Bottom PoH
            if (Has(RutoLetter) && Has(IronBoots) && Has(ZeldasLullaby) && (Bomb.State == 1 || Has(Scales)))
            {
                Pb("Zora Fountain", "Bottom Freestanding PoH", maptracker_Panel).ForeColor = Available;
            }
            else if (Has(RutoLetter) && Has(IronBoots) && Has(ZeldasLullaby) && Has(Bombchu))
            {
                Pb("Zora Fountain", "Bottom Freestanding PoH", maptracker_Panel).ForeColor = OoLChus;
            }
            else
            {
                Pb("Zora Fountain", "Bottom Freestanding PoH", maptracker_Panel).ForeColor = red;
            }
            //Skulls
            if (Has(RutoLetter) && Has(ZeldasLullaby) && Strength.State >= 2)
            {
                tokensAvailable += 1;
            }
            if (Has(RutoLetter) && Has(ZeldasLullaby) && (Bomb.State == 1 || Has(Scales)) && Has(Boomerang))
            {
                tokensAvailable += 1;
            }
            #endregion
            #region Ice Cavern
            if (Has(RutoLetter) && Has(ZeldasLullaby) && (Has(Bomb) || Has(Scales)))
            {
                Pb("Ice Cavern", "Map Chest", maptracker_Panel).ForeColor = Available;
                Pb("Ice Cavern", "Compass Chest", maptracker_Panel).ForeColor = Available;
                Pb("Ice Cavern", "Iron Boots Chest", maptracker_Panel).ForeColor = Available;
                Pb("Ice Cavern", "Freestanding PoH", maptracker_Panel).ForeColor = Available;
                Pb("Ice Cavern", "Shiek at Ice Cavern", maptracker_Panel).ForeColor = Available;
            }
            else
            {
                Pb("Ice Cavern", "Map Chest", maptracker_Panel).ForeColor = red;
                Pb("Ice Cavern", "Compass Chest", maptracker_Panel).ForeColor = red;
                Pb("Ice Cavern", "Iron Boots Chest", maptracker_Panel).ForeColor = red;
                Pb("Ice Cavern", "Freestanding PoH", maptracker_Panel).ForeColor = red;
                Pb("Ice Cavern", "Shiek at Ice Cavern", maptracker_Panel).ForeColor = red;
            }
            if (Has(RutoLetter) && Has(ZeldasLullaby) && (Has(Bomb) || Has(Scales)) && Has(Hookshot))
            {
                tokensAvailable += 3;
            }
            //Skulltula
            #endregion
            #region Jabu Jabu
            //Boomerang Chest
            if (Has(RutoLetter) && (Has(Scales) || (Bomb.State == 1 && Has(ZeldasLullaby))))
            {
                Pb("Jabu-Jabus Belly", "Boomerang Chest", maptracker_Panel).ForeColor = Available;
                tokensAvailable += 1;
            }
            else
            {
                Pb("Jabu-Jabus Belly", "Boomerang Chest", maptracker_Panel).ForeColor = red;
            }
            //Rest
            if (Has(RutoLetter) && ((Has(ZeldasLullaby) && Bomb.State == 1) || Has(Scales)) && Has(Boomerang))
            {
                Pb("Jabu-Jabus Belly", "Barinade Heart", maptracker_Panel).ForeColor = Available;
                Pb("Jabu-Jabus Belly", "Compass Chest", maptracker_Panel).ForeColor = Available;
                Pb("Jabu-Jabus Belly", "Map Chest", maptracker_Panel).ForeColor = Available;
                tokensAvailable += 3;
            }
            else
            {
                Pb("Jabu-Jabus Belly", "Barinade Heart", maptracker_Panel).ForeColor = red;
                Pb("Jabu-Jabus Belly", "Compass Chest", maptracker_Panel).ForeColor = red;
                Pb("Jabu-Jabus Belly", "Map Chest", maptracker_Panel).ForeColor = red;
            }
            #endregion
            #region Zora Domain
            //Zora Domain Child Checks
            if (Has(Scales) || (Bomb.State == 1 && Has(ZeldasLullaby)))
            {
                Pb("Zora Domain", "Chest", maptracker_Panel).ForeColor = Available;
                Pb("Zora Domain", "Diving Game", maptracker_Panel).ForeColor = Available;
            }
            else
            {
                Pb("Zora Domain", "Chest", maptracker_Panel).ForeColor = red;
                Pb("Zora Domain", "Diving Game", maptracker_Panel).ForeColor = red;
            }
            //King Zora Thawed
            if (Has(ZeldasLullaby) && ((Has(RutoLetter) && (Has(Bomb) || Has(Scales))) || (Wallet.State == 2 && has_bottle)))
            {
                Pb("Zora Domain", "King Zora Thawed", maptracker_Panel).ForeColor = Available;
            }
            else
            {
                Pb("Zora Domain", "King Zora Thawed", maptracker_Panel).ForeColor = red;
            }
            //Skulltula
            if(Has(Hookshot) && Has(ZeldasLullaby))
            {
                tokensAvailable++;
            }
            #endregion
            #region Dodongos Cavern
            //Map and Compass Chests
            if (Bomb.State == 1 || Has(Strength) || Has(Hammer))
            {
                Pb("Dodongos Cavern", "Compass Chest", maptracker_Panel).ForeColor = Available;
                Pb("Dodongos Cavern", "Map Chest", maptracker_Panel).ForeColor = Available;               
                tokensAvailable++;
            }
            else if (Has(Bombchu) || Has(Strength) || Has(Hammer))
            {
                Pb("Dodongos Cavern", "Compass Chest", maptracker_Panel).ForeColor = OoLChus;
                Pb("Dodongos Cavern", "Map Chest", maptracker_Panel).ForeColor = OoLChus;
                tokensAvailable++;
            }
            else
            {
                Pb("Dodongos Cavern", "Compass Chest", maptracker_Panel).ForeColor = red;
                Pb("Dodongos Cavern", "Map Chest", maptracker_Panel).ForeColor = red;              
            }
            //Beyond Staircase
            if (Bomb.State == 1 || Has(Strength) || ((Has(Dins) && Has(Magic)) && Has(Hammer)))
            {
                Pb("Dodongos Cavern", "Bomb Flower Platform Chest", maptracker_Panel).ForeColor = Available;
                Pb("Dodongos Cavern", "Bomb Bag Chest", maptracker_Panel).ForeColor = Available;
                tokensAvailable++;
            }
            else if (Has(Bombchu) || Has(Strength) || ((Has(Dins) && Has(Magic)) && Has(Hammer)))
            {
                Pb("Dodongos Cavern", "Bomb Flower Platform Chest", maptracker_Panel).ForeColor = OoLChus;
                Pb("Dodongos Cavern", "Bomb Bag Chest", maptracker_Panel).ForeColor = OoLChus;
                tokensAvailable++;
            }
            else
            {
                Pb("Dodongos Cavern", "Bomb Flower Platform Chest", maptracker_Panel).ForeColor = red;
                Pb("Dodongos Cavern", "Bomb Bag Chest", maptracker_Panel).ForeColor = red;
            }
            //End of Bridge
            if (Bomb.State == 1 || (Has(Strength) || (Has(Dins) && Has(Magic))) && Has(Hammer))
            {
                Pb("Dodongos Cavern", "End of Bridge Chest", maptracker_Panel).ForeColor = Available;
            }
            else if (Has(Bombchu) || (Has(Strength) || (Has(Dins) && Has(Magic))) && Has(Hammer))
            {
                Pb("Dodongos Cavern", "End of Bridge Chest", maptracker_Panel).ForeColor = OoLChus;
            }
            else
            {
                Pb("Dodongos Cavern", "End of Bridge Chest", maptracker_Panel).ForeColor = red;
            }
            //You need Bomb Bag for Boss Room
            if (Has(Bomb))
            {
                Pb("Dodongos Cavern", "Boss Room Chest", maptracker_Panel).ForeColor = Available;
                Pb("Dodongos Cavern", "King Dodongo Heart", maptracker_Panel).ForeColor = Available;
                tokensAvailable++;
            }
            else if (Has(Bombchu))
            {
                Pb("Dodongos Cavern", "Boss Room Chest", maptracker_Panel).ForeColor = OoLChus;
                Pb("Dodongos Cavern", "King Dodongo Heart", maptracker_Panel).ForeColor = OoLChus;
                tokensAvailable++;
            }
            else
            {
                Pb("Dodongos Cavern", "Boss Room Chest", maptracker_Panel).ForeColor = red;
                Pb("Dodongos Cavern", "King Dodongo Heart", maptracker_Panel).ForeColor = red;
            }
            //Skulltula
            if ((Bomb.State == 1 || Has(Bombchu) || Has(Strength)) && (Has(Hookshot) || Has(Boomerang)))
            {
                tokensAvailable++;
            }    
            if ((Has(Bomb) || Has(Bombchu) || Has(Strength)) && Has(Hookshot))
            {
                tokensAvailable++;
            }
            #endregion
            #region GTG            
            //LobbyChests
            if (has_or_can_get_gerudocard && Has(Bow))
            {
                Pb("Gerudos Training Grounds", "Lobby Left Chest", maptracker_Panel).ForeColor = Available;
                Pb("Gerudos Training Grounds", "Lobby Right Chest", maptracker_Panel).ForeColor = Available;
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
            }
            else
            {
                Pb("Gerudos Training Grounds", "Stalfos Chest", maptracker_Panel).ForeColor = red;
            }
            //Beamos
            if (has_or_can_get_gerudocard && Bomb.State == 1)
            {
                Pb("Gerudos Training Grounds", "Beamos Chest", maptracker_Panel).ForeColor = Available;
            }
            else
            {
                Pb("Gerudos Training Grounds", "Beamos Chest", maptracker_Panel).ForeColor = red;
            }
            //Hidden Ceiling
            if (has_or_can_get_gerudocard && gtg_keys >= 3)
            {
                Pb("Gerudos Training Grounds", "Hidden Ceiling Chest", maptracker_Panel).ForeColor = Available;
            }
            else if(has_or_can_get_gerudocard)
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
            }
            else if (has_or_can_get_gerudocard)
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
            else if (has_or_can_get_gerudocard)
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
            else if (has_or_can_get_gerudocard)
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
            else if (has_or_can_get_gerudocard)
            {
                Pb("Gerudos Training Grounds", "Maze Path Final Chest", maptracker_Panel).ForeColor = coulddo;
            }
            else
            {
                Pb("Gerudos Training Grounds", "Maze Path Final Chest", maptracker_Panel).ForeColor = red;
            }
            //Toilet
            if (has_or_can_get_gerudocard && Has(IronBoots) && Has(SongOfTime) && Bomb.State == 1)
            {
                Pb("Gerudos Training Grounds", "Underwater Silver Rupee Chest", maptracker_Panel).ForeColor = Available;
            }
            else
            {
                Pb("Gerudos Training Grounds", "Underwater Silver Rupee Chest", maptracker_Panel).ForeColor = red;
            }
            //Maze Right Chests
            if (has_or_can_get_gerudocard && ((Bomb.State == 1 || Has(Hookshot)) && Has(SongOfTime) || gtg_keys == 9))
            {
                Pb("Gerudos Training Grounds", "Maze Right Central Chest", maptracker_Panel).ForeColor = Available;
                Pb("Gerudos Training Grounds", "Maze Right Side Chest", maptracker_Panel).ForeColor = Available;
            }           
            else
            {
                Pb("Gerudos Training Grounds", "Maze Right Central Chest", maptracker_Panel).ForeColor = red;
                Pb("Gerudos Training Grounds", "Maze Right Side Chest", maptracker_Panel).ForeColor = red;
            }
            //Freestanding Key
            if (has_or_can_get_gerudocard && ((Bomb.State == 1 || Has(Hookshot)) && Has(SongOfTime) || gtg_keys == 9))
            {
                Pb("Gerudos Training Grounds", "Freestanding Key", maptracker_Panel).ForeColor = Available;
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
            }
            else
            {
                Pb("Gerudos Training Grounds", "Hammer Room Clear Chest", maptracker_Panel).ForeColor = red;
            }
            if (has_or_can_get_gerudocard && Has(Hookshot) && Has(Hammer))
            {
                Pb("Gerudos Training Grounds", "Hammer Room Switch Chest", maptracker_Panel).ForeColor = Available;
            }
            else
            {
                Pb("Gerudos Training Grounds", "Hammer Room Switch Chest", maptracker_Panel).ForeColor = red;
            }
            #endregion
            #region BotW
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
            else if (Has(SongOfStorms) && Has(Bombchu))
            {
                Pb("Bottom of the Well", "Front Center Bombable Chest", maptracker_Panel).ForeColor = OoLChus;
                Pb("Bottom of the Well", "Back Left Bombable Chest", maptracker_Panel).ForeColor = OoLChus;
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
            #endregion
            #region ToT
            //Light Arrow Cutscene
            if (Has(SpiritMedallion) && Has(ShadowMedallion))
            {
                Pb("Temple of Time", "Light Arrow Cutscene", maptracker_Panel).ForeColor = Available;
            }
            else
            {
                Pb("Temple of Time", "Light Arrow Cutscene", maptracker_Panel).ForeColor = red;
            }
            //Shiek at Temple
            if (Has(ForestMedallion))
            {
                Pb("Temple of Time", "Shiek at Temple", maptracker_Panel).ForeColor = Available;
            }
            else
            {
                Pb("Temple of Time", "Shiek at Temple", maptracker_Panel).ForeColor = red;
            }
            #endregion
            #region Ganons Castle
            if (rainbowbridge)
            {
                Pb("Ganons Castle", "Forest Trial Chest", maptracker_Panel).ForeColor = Available;
                Pb("Ganons Castle", "Water Trial Left Chest", maptracker_Panel).ForeColor = Available;
                Pb("Ganons Castle", "Water Trial Right Chest", maptracker_Panel).ForeColor = Available;
                Pb("Ganons Castle", "Boss Key Chest", maptracker_Panel).ForeColor = Available;
            }
            else
            {
                Pb("Ganons Castle", "Forest Trial Chest", maptracker_Panel).ForeColor = red;
                Pb("Ganons Castle", "Water Trial Left Chest", maptracker_Panel).ForeColor = red;
                Pb("Ganons Castle", "Water Trial Right Chest", maptracker_Panel).ForeColor = red;
                Pb("Ganons Castle", "Boss Key Chest", maptracker_Panel).ForeColor = red;
            }
            //Shadow Trial 1
            if (rainbowbridge && ((Has(Magic) && Has(Bow) && Has(FireArrow)) || Has(Hookshot) || Has(HoverBoots) || Has(SongOfTime)))
            {
                Pb("Ganons Castle", "Shadow Trial Front Chest", maptracker_Panel).ForeColor = Available;
            }
            else
            {
                Pb("Ganons Castle", "Shadow Trial Front Chest", maptracker_Panel).ForeColor = red;
            }
            //Shadow Trial 2
            if (rainbowbridge && (Has(HoverBoots) || has_firesource))
            {
                Pb("Ganons Castle", "Shadow Trial Golden Gauntlets Chest", maptracker_Panel).ForeColor = Available;
            }
            else
            {
                Pb("Ganons Castle", "Shadow Trial Golden Gauntlets Chest", maptracker_Panel).ForeColor = red;
            }
            //Light Trial
            if(rainbowbridge && Strength.State == 3)
            {
                Pb("Ganons Castle", "Light Trial First Left Chest", maptracker_Panel).ForeColor = Available;
                Pb("Ganons Castle", "Light Trial Second Left Chest", maptracker_Panel).ForeColor = Available;
                Pb("Ganons Castle", "Light Trial Third Left Chest", maptracker_Panel).ForeColor = Available;
                Pb("Ganons Castle", "Light Trial First Right Chest", maptracker_Panel).ForeColor = Available;
                Pb("Ganons Castle", "Light Trial Second Right Chest", maptracker_Panel).ForeColor = Available;
                Pb("Ganons Castle", "Light Trial Third Right Chest", maptracker_Panel).ForeColor = Available;
                Pb("Ganons Castle", "Light Trial Invisible Enemies Chest", maptracker_Panel).ForeColor = Available;
            }
            else
            {
                Pb("Ganons Castle", "Light Trial First Left Chest", maptracker_Panel).ForeColor = red;
                Pb("Ganons Castle", "Light Trial Second Left Chest", maptracker_Panel).ForeColor = red;
                Pb("Ganons Castle", "Light Trial Third Left Chest", maptracker_Panel).ForeColor = red;
                Pb("Ganons Castle", "Light Trial First Right Chest", maptracker_Panel).ForeColor = red;
                Pb("Ganons Castle", "Light Trial Second Right Chest", maptracker_Panel).ForeColor = red;
                Pb("Ganons Castle", "Light Trial Third Right Chest", maptracker_Panel).ForeColor = red;
                Pb("Ganons Castle", "Light Trial Invisible Enemies Chest", maptracker_Panel).ForeColor = red;
            }
            //Light Trial Last Chest
            if (rainbowbridge && Strength.State == 3 && Has(ZeldasLullaby))
            {
                Pb("Ganons Castle", "Light Trial Lullaby Chest", maptracker_Panel).ForeColor = Available;
            }
            else
            {
                Pb("Ganons Castle", "Light Trial Lullaby Chest", maptracker_Panel).ForeColor = red;
            }
            //Spirit Trial 1
            if (rainbowbridge && Has(Hookshot))
            {
                Pb("Ganons Castle", "Spirit Trial Crystal Switch Chest", maptracker_Panel).ForeColor = Available;
            }
            else
            {
                Pb("Ganons Castle", "Spirit Trial Crystal Switch Chest", maptracker_Panel).ForeColor = red;  
            }
            //Spirit Trial 2
            if(rainbowbridge && Has(Hookshot) && Has(Bomb))
            {
                Pb("Ganons Castle", "Spirit Trial Invisible Chest", maptracker_Panel).ForeColor = Available;
            }
            else
            {
                Pb("Ganons Castle", "Spirit Trial Invisible Chest", maptracker_Panel).ForeColor = red;
            }         
            #endregion
            #region Skulls    
            if (Has(Boomerang))
            {
                tokensAvailable += 3;
            }
            if (has_bottle)
            {
                tokensAvailable += 6;
            }         
            //Skullhouse
            if (tokensAvailable >= 10)
            {
                Pb("Kakariko", "10 Skulltulas", maptracker_Panel).ForeColor = Available;
            }
            else
            {
                Pb("Kakariko", "10 Skulltulas", maptracker_Panel).ForeColor = red;
            }
            if (tokensAvailable >= 20)
            {
                Pb("Kakariko", "20 Skulltulas", maptracker_Panel).ForeColor = Available;
            }
            else
            {
                Pb("Kakariko", "20 Skulltulas", maptracker_Panel).ForeColor = red;
            }
            if (tokensAvailable >= 30)
            {
                Pb("Kakariko", "30 Skulltulas", maptracker_Panel).ForeColor = Available;
            }
            else
            {
                Pb("Kakariko", "30 Skulltulas", maptracker_Panel).ForeColor = red;
            }
            if (tokensAvailable >= 40)
            {
                Pb("Kakariko", "40 Skulltulas", maptracker_Panel).ForeColor = Available;
            }
            else
            {
                Pb("Kakariko", "40 Skulltulas", maptracker_Panel).ForeColor = red;
            }
            if (tokensAvailable >= 50)
            {
                Pb("Kakariko", "50 Skulltulas", maptracker_Panel).ForeColor = Available;
            }
            else
            {
                Pb("Kakariko", "50 Skulltulas", maptracker_Panel).ForeColor = red;
            }

            string checks = tokensAvailable.ToString();
            tokenCounter.Text = $"Available Tokens: {checks}";
            #endregion
            #region ScrubShuffle
            if (ScrubShuffle)
            {
                //Lost Woods
                if(((Has(SariasSong) || Has(Minuet)) && Has(Hammer)) || Bomb.State == 1)
                {
                    Pb("Lost Woods", "Deku Scrub Grotto Rear", maptracker_Panel).ForeColor = Available;
                }
                else
                {
                    Pb("Lost Woods", "Deku Scrub Grotto Rear", maptracker_Panel).ForeColor = red;
                }
                //SFM
                if (Has(SongOfStorms))
                {
                    Pb("Sacred Forest Meadow", "Deku Scrub Grotto Front", maptracker_Panel).ForeColor = Available;
                    Pb("Sacred Forest Meadow", "Deku Scrub Grotto Rear", maptracker_Panel).ForeColor = Available;
                }
                else
                {
                    Pb("Sacred Forest Meadow", "Deku Scrub Grotto Front", maptracker_Panel).ForeColor = red;
                    Pb("Sacred Forest Meadow", "Deku Scrub Grotto Rear", maptracker_Panel).ForeColor = red;
                }
                //Goron City
                if (Has(SongOfTime) || (Has(Hookshot) && (Has(GoronTunic) || Has(NayrusLove))))
                {
                    Pb("Goron City", "Deku Scrub Grotto Left", maptracker_Panel).ForeColor = Available;
                    Pb("Goron City", "Deku Scrub Grotto Center", maptracker_Panel).ForeColor = Available;
                    Pb("Goron City", "Deku Scrub Grotto Right", maptracker_Panel).ForeColor = Available;
                }
                else
                {
                    Pb("Goron City", "Deku Scrub Grotto Left", maptracker_Panel).ForeColor = red;
                    Pb("Goron City", "Deku Scrub Grotto Center", maptracker_Panel).ForeColor = red;
                    Pb("Goron City", "Deku Scrub Grotto Right", maptracker_Panel).ForeColor = red;
                }
                //Dodongos Cavern
                if(Bomb.State == 1 || Has(Strength) || Has(Hammer))
                {
                    Pb("Dodongos Cavern", "Deku Scrub Lobby", maptracker_Panel).ForeColor = Available;
                    Pb("Dodongos Cavern", "Deku Scrub Side Room Near Dodongos", maptracker_Panel).ForeColor = Available;
                }
                else
                {
                    Pb("Dodongos Cavern", "Deku Scrub Lobby", maptracker_Panel).ForeColor = red;
                    Pb("Dodongos Cavern", "Deku Scrub Side Room Near Dodongos", maptracker_Panel).ForeColor = red;
                }
                if (Bomb.State == 1 || ((Has(Dins) && Has(Magic) || Has(Strength)) && Has(Hammer)))
                {
                    Pb("Dodongos Cavern", "Deku Scrub Near Bomb Bag Right", maptracker_Panel).ForeColor = Available;
                    Pb("Dodongos Cavern", "Deku Scrub Near Bomb Bag Left", maptracker_Panel).ForeColor = Available;                
                }
                else
                {
                    Pb("Dodongos Cavern", "Deku Scrub Near Bomb Bag Right", maptracker_Panel).ForeColor = red;
                    Pb("Dodongos Cavern", "Deku Scrub Near Bomb Bag Left", maptracker_Panel).ForeColor = red;
                }
                //DMC
                if (Has(Hammer) && (has_explosives || Has(Strength) || Has(Bow) || (Has(Bolero) && (Has(Hookshot) || Has(HoverBoots)))))
                {
                    Pb("Death Mountain Crater", "Deku Scrub Grotto Left", maptracker_Panel).ForeColor = Available;
                    Pb("Death Mountain Crater", "Deku Scrub Grotto Center", maptracker_Panel).ForeColor = Available;
                    Pb("Death Mountain Crater", "Deku Scrub Grotto Right", maptracker_Panel).ForeColor = Available;
                }
                else
                {
                    Pb("Death Mountain Crater", "Deku Scrub Grotto Left", maptracker_Panel).ForeColor = red;
                    Pb("Death Mountain Crater", "Deku Scrub Grotto Center", maptracker_Panel).ForeColor = red;
                    Pb("Death Mountain Crater", "Deku Scrub Grotto Right", maptracker_Panel).ForeColor = red;
                }
                if(Has(Bomb))
                {
                    Pb("Death Mountain Crater", "Deku Scrub", maptracker_Panel).ForeColor = Available;
                }
                else
                {
                    Pb("Death Mountain Crater", "Deku Scrub", maptracker_Panel).ForeColor = red;
                }
                //Zora River
                if(Has(SongOfStorms))
                {
                    Pb("Zora River", "Deku Scrub Grotto Front", maptracker_Panel).ForeColor = Available;
                    Pb("Zora River", "Deku Scrub Grotto Rear", maptracker_Panel).ForeColor = Available;
                }
                else
                {
                    Pb("Zora River", "Deku Scrub Grotto Front", maptracker_Panel).ForeColor = red;
                    Pb("Zora River", "Deku Scrub Grotto Rear", maptracker_Panel).ForeColor = red;
                }
                //Jabu Jabu
                if (Has(RutoLetter) && (Has(Scales) || (Bomb.State == 1 && Has(ZeldasLullaby))))
                {
                    Pb("Jabu-Jabus Belly", "Deku Scrub", maptracker_Panel).ForeColor = Available;                  
                }
                else
                {
                    Pb("Jabu-Jabus Belly", "Deku Scrub", maptracker_Panel).ForeColor = red;
                }
                // Gerudo Valley
                if ((has_longshot || Has(EponasSong)) && Has(SongOfStorms))
                {
                    Pb("Gerudo Valley", "Deku Scrub Grotto Front", maptracker_Panel).ForeColor = Available;
                    Pb("Gerudo Valley", "Deku Scrub Grotto Rear", maptracker_Panel).ForeColor = Available;
                }
                else
                {
                    Pb("Gerudo Valley", "Deku Scrub Grotto Front", maptracker_Panel).ForeColor = red;
                    Pb("Gerudo Valley", "Deku Scrub Grotto Rear", maptracker_Panel).ForeColor = red;
                }
                //Desert Colossus
                if(desertaccess == 1 && Strength.State > 1)
                {
                    Pb("Desert Colossus", "Deku Scrub Grotto Front", maptracker_Panel).ForeColor = Available;
                    Pb("Desert Colossus", "Deku Scrub Grotto Rear", maptracker_Panel).ForeColor = Available;
                }
                else
                {
                    Pb("Desert Colossus", "Deku Scrub Grotto Front", maptracker_Panel).ForeColor = red;
                    Pb("Desert Colossus", "Deku Scrub Grotto Rear", maptracker_Panel).ForeColor = red;
                }
                //Ganons Castle
                if(rainbowbridge)
                {
                    Pb("Ganons Castle", "Deku Scrub Left", maptracker_Panel).ForeColor = Available;
                    Pb("Ganons Castle", "Deku Scrub Center-Left", maptracker_Panel).ForeColor = Available;
                    Pb("Ganons Castle", "Deku Scrub Center-Right", maptracker_Panel).ForeColor = Available;
                    Pb("Ganons Castle", "Deku Scrub Right", maptracker_Panel).ForeColor = Available;
                }
                else
                {
                    Pb("Ganons Castle", "Deku Scrub Left", maptracker_Panel).ForeColor = red;
                    Pb("Ganons Castle", "Deku Scrub Center-Left", maptracker_Panel).ForeColor = red;
                    Pb("Ganons Castle", "Deku Scrub Center-Right", maptracker_Panel).ForeColor = red;
                    Pb("Ganons Castle", "Deku Scrub Right", maptracker_Panel).ForeColor = red;
                }
            }
            #endregion
        }      
    }

}
