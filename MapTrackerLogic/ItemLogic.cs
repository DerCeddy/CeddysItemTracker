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
        public int gtg_available_checks;
        public Color Available = Color.Lime;
        public Color red = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
        public Color coulddo = Color.Yellow;      
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
            Pb("Lon-Lon-Ranch", "Talon Minigame", maptracker_Panel).ForeColor = Available;
            Pb("Lon-Lon-Ranch", "Malon Song", maptracker_Panel).ForeColor = Available;
            Pb("Lon-Lon-Ranch", "LLR HP", maptracker_Panel).ForeColor = Available;
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
                Pb("Kokiri Forest", "Shop Top Left",maptracker_Panel).ForeColor = Available;
                Pb("Kokiri Forest", "Shop Top Right", maptracker_Panel).ForeColor = Available;
                Pb("Kokiri Forest", "Shop Bottom Left", maptracker_Panel).ForeColor = Available;
                Pb("Kokiri Forest", "Shop Bottom Right", maptracker_Panel).ForeColor = Available;
                Pb("Market", "Bazaar Top Left", maptracker_Panel).ForeColor = Available;
                Pb("Market", "Bazaar Top Right", maptracker_Panel).ForeColor = Available;
                Pb("Market", "Bazaar Bottom Left", maptracker_Panel).ForeColor = Available;
                Pb("Market", "Bazaar Bottom Right", maptracker_Panel).ForeColor = Available;
                Pb("Market", "Potion Shop Top Left", maptracker_Panel).ForeColor = Available;
                Pb("Market", "Potion Shop Top Right", maptracker_Panel).ForeColor = Available;
                Pb("Market", "Potion Shop Bottom Left", maptracker_Panel).ForeColor = Available;
                Pb("Market", "Potion Shop Bottom Right", maptracker_Panel).ForeColor = Available;              
                Pb("Market", "Bombchu Shop Top Left", maptracker_Panel).ForeColor = Available;
                Pb("Market", "Bombchu Shop Top Right", maptracker_Panel).ForeColor = Available;
                Pb("Market", "Bombchu Shop Bottom Left", maptracker_Panel).ForeColor = Available;
                Pb("Market", "Bombchu Shop Bottom Right", maptracker_Panel).ForeColor = Available;
                Pb("Kakariko", "Bazaar Top Left", maptracker_Panel).ForeColor = Available;
                Pb("Kakariko", "Bazaar Top Right", maptracker_Panel).ForeColor = Available;
                Pb("Kakariko", "Bazaar Bottom Left", maptracker_Panel).ForeColor = Available;
                Pb("Kakariko", "Bazaar Bottom Right", maptracker_Panel).ForeColor = Available;
                Pb("Kakariko", "Potion Shop Top Left", maptracker_Panel).ForeColor = Available;
                Pb("Kakariko", "Potion Shop Top Right", maptracker_Panel).ForeColor = Available;
                Pb("Kakariko", "Potion Shop Bottom Left", maptracker_Panel).ForeColor = Available;
                Pb("Kakariko", "Potion Shop Bottom Right", maptracker_Panel).ForeColor = Available;
                Pb("Goron City", "Shop Top Left", maptracker_Panel).ForeColor = Available;
                Pb("Goron City", "Shop Top Right", maptracker_Panel).ForeColor = Available;
                Pb("Goron City", "Shop Bottom Left", maptracker_Panel).ForeColor = Available;
                Pb("Goron City", "Shop Bottom Right", maptracker_Panel).ForeColor = Available;
                Pb("Zora Domain", "Shop Top Left", maptracker_Panel).ForeColor = Available;
                Pb("Zora Domain", "Shop Top Right", maptracker_Panel).ForeColor = Available;
                Pb("Zora Domain", "Shop Bottom Left", maptracker_Panel).ForeColor = Available;
                Pb("Zora Domain", "Shop Bottom Right", maptracker_Panel).ForeColor = Available;
            }
        }
        public void ItemLogic()
        {          
            tokensAvailable = 13;
            gtg_available_checks = 0;
            ItemLogic_Helper();
            ItemLogic_BotW();
            ItemLogic_Castles();
            ItemLogic_DekuTree();
            ItemLogic_DesertColossus();
            ItemLogic_DMC();
            ItemLogic_DMT();
            ItemLogic_DodongosCavern();
            ItemLogic_FireTemple();
            ItemLogic_ForestTemple();           
            ItemLogic_GanonsCastle();
            ItemLogic_GerudoFortress();
            ItemLogic_GerudoValley();
            ItemLogic_GoronCity();
            ItemLogic_Graveyard();
            ItemLogic_GTG();
            ItemLogic_HyruleField();
            ItemLogic_IceCavern();
            ItemLogic_Jabu();
            ItemLogic_Kakariko();
            ItemLogic_KokiriForest();
            ItemLogic_LakeHylia();
            ItemLogic_LostWoods();
            ItemLogic_Market();
            ItemLogic_ScrubShuffle();
            ItemLogic_SFM();
            ItemLogic_ShadowTemple();
            ItemLogic_ShopShuffle();
            ItemLogic_SpiritTemple();
            ItemLogic_ToT();
            ItemLogic_Wasteland();
            ItemLogic_WaterTemple();
            ItemLogic_ZoraDomain();
            ItemLogic_ZoraFountain();
            ItemLogic_ZoraRiver();
            ItemLogic_Skulltulas();           
        }
        /*
        public void ItemLogic(Item i)
        {
            tokensAvailable = 13;
            switch (i.Item_Name)
            {
                case "Bomb":
                    ItemLogic_Helper();
                    ItemLogic_SpiritTemple();
                    ItemLogic_DesertColossus();
                    ItemLogic_GTG();
                    ItemLogic_WaterTemple();
                    ItemLogic_HyruleField();
                    ItemLogic_DodongosCavern();
                    ItemLogic_Market();
                    ItemLogic_Castles();
                    ItemLogic_GanonsCastle();
                    ItemLogic_Kakariko();
                    ItemLogic_BotW();
                    ItemLogic_ShadowTemple();
                    ItemLogic_DMC();
                    ItemLogic_DMT();
                    ItemLogic_GoronCity();
                    ItemLogic_ZoraFountain();
                    ItemLogic_IceCavern();
                    ItemLogic_ZoraDomain();
                    ItemLogic_Jabu();
                    ItemLogic_LostWoods();
                    ItemLogic_SFM();
                    break;
                case "Bow":
                    ItemLogic_Kakariko();
                    ItemLogic_SpiritTemple();
                    ItemLogic_GTG();
                    ItemLogic_GerudoFortress();
                    ItemLogic_LakeHylia();
                    ItemLogic_WaterTemple();
                    ItemLogic_Market();
                    ItemLogic_FireTemple();
                    ItemLogic_ForestTemple();
                    break;
                case "Hookshot":
                    ItemLogic_Helper();
                    ItemLogic_SpiritTemple();
                    ItemLogic_GTG();
                    ItemLogic_LakeHylia();
                    ItemLogic_WaterTemple();
                    ItemLogic_GanonsCastle();
                    ItemLogic_FireTemple();
                    ItemLogic_ForestTemple();
                    ItemLogic_ShadowTemple();
                    break;
                case "Slingshot":
                    ItemLogic_SpiritTemple();
                    ItemLogic_LostWoods();
                    ItemLogic_DekuTree();
                    break;
                case "Boomerang":
                    ItemLogic_SpiritTemple();
                    ItemLogic_Jabu();
                    break;
                case "Letter":
                    ItemLogic_Helper();
                    ItemLogic_Jabu();
                    ItemLogic_ZoraFountain();
                    ItemLogic_IceCavern();
                    break;
                case "Bottle":
                    ItemLogic_Helper();
                    ItemLogic_ZoraDomain();
                    ItemLogic_Market();
                    break;
                case "Beans":
                    ItemLogic_DesertColossus();
                    ItemLogic_LakeHylia();
                    ItemLogic_DMC();
                    break;
                case "Lens":
                    ItemLogic_Helper();
                    ItemLogic_Market();
                    ItemLogic_DesertColossus();
                    ItemLogic_SpiritTemple();
                    ItemLogic_Wasteland();
                    break;
                case "Hammer":
                    ItemLogic_GTG();
                    ItemLogic_GerudoValley();
                    ItemLogic_HyruleField();
                    ItemLogic_DMC();
                    ItemLogic_DMT();
                    ItemLogic_GoronCity();
                    ItemLogic_FireTemple();
                    ItemLogic_LostWoods();
                    ItemLogic_SFM();
                    ItemLogic_Kakariko();
                    break;
                case "Fire Arrows":
                    ItemLogic_SpiritTemple();
                    ItemLogic_Wasteland();
                    ItemLogic_Graveyard();
                    break;
                case "Dins":
                    ItemLogic_SpiritTemple();
                    ItemLogic_Wasteland();
                    ItemLogic_Graveyard();
                    ItemLogic_GoronCity();
                    ItemLogic_ShadowTemple();
                    break;
                case "Light Arrows":
                    ItemLogic_GanonsCastle();
                    break;
                case "Adult Trade":
                    ItemLogic_DMT();
                    break;
                case "Kokiri Sword":
                    ItemLogic_DekuTree();
                    break;
                case "Mirror Shield":
                    ItemLogic_SpiritTemple();
                    break;
                case "Strength":
                    ItemLogic_SpiritTemple();
                    ItemLogic_GTG();
                    ItemLogic_WaterTemple();
                    ItemLogic_WaterTemple();
                    ItemLogic_Castles();
                    ItemLogic_GanonsCastle();
                    ItemLogic_DodongosCavern();
                    ItemLogic_DMC();
                    ItemLogic_GoronCity();
                    ItemLogic_BotW();
                    ItemLogic_ForestTemple();
                    break;
                case "Scale":
                    ItemLogic_ZoraRiver();
                    ItemLogic_Jabu();
                    ItemLogic_ZoraFountain();
                    ItemLogic_IceCavern();
                    ItemLogic_LakeHylia();
                    ItemLogic_HyruleField();
                    break;
                case "Wallet":
                    ItemLogic_Helper();
                    ItemLogic_FireTemple();
                    ItemLogic_WaterTemple();
                    ItemLogic_ZoraDomain();
                    break;
                case "Goron Tunic":
                    ItemLogic_Helper();
                    ItemLogic_FireTemple();
                    break;
                case "Zora Tunic":
                    ItemLogic_Helper();
                    ItemLogic_WaterTemple();
                    break;
                case "Magic":
                    ItemLogic_Helper();
                    ItemLogic_SpiritTemple();
                    ItemLogic_DesertColossus();
                    ItemLogic_DodongosCavern();
                    ItemLogic_Wasteland();
                    ItemLogic_Market();
                    ItemLogic_GoronCity();
                    ItemLogic_Graveyard();
                    ItemLogic_BotW();
                    ItemLogic_ShadowTemple();
                    break;
                case "Iron Boots":
                    ItemLogic_GTG();
                    ItemLogic_WaterTemple();
                    ItemLogic_ZoraFountain();
                    ItemLogic_HyruleField();
                    break;
                case "HoverBoots":
                    ItemLogic_Helper();
                    ItemLogic_DMC();
                    ItemLogic_FireTemple();
                    ItemLogic_SpiritTemple();
                    ItemLogic_DesertColossus();
                    ItemLogic_Wasteland();
                    ItemLogic_WaterTemple();
                    ItemLogic_ForestTemple();
                    ItemLogic_ShadowTemple();
                    ItemLogic_GerudoFortress();
                    break;
                case "Kokiri Stone":
                    ItemLogic_Helper();
                    ItemLogic_HyruleField();
                    ItemLogic_GanonsCastle();
                    break;
                case "Goron Stone":
                    ItemLogic_Helper();
                    ItemLogic_HyruleField();
                    ItemLogic_GanonsCastle();
                    break;
                case "Zora Stone":
                    ItemLogic_Helper();
                    ItemLogic_HyruleField();
                    ItemLogic_GanonsCastle();
                    break;
                case "Forest Medallion":
                    ItemLogic_Helper();
                    ItemLogic_ToT();
                    ItemLogic_Kakariko();
                    ItemLogic_GanonsCastle();
                    break;
                case "Fire Medallion":
                    ItemLogic_Helper();
                    ItemLogic_ToT();
                    ItemLogic_Kakariko();
                    ItemLogic_GanonsCastle();
                    break;
                case "Water Medallion":
                    ItemLogic_Helper();
                    ItemLogic_ToT();
                    ItemLogic_Kakariko();
                    ItemLogic_GanonsCastle();
                    break;
                case "Shadow Medallion":
                    ItemLogic_Helper();
                    ItemLogic_ToT();
                    ItemLogic_GanonsCastle();
                    break;
                case "Spirit Medallion":
                    ItemLogic_Helper();
                    ItemLogic_ToT();
                    ItemLogic_GanonsCastle();
                    break;
                case "Light Medallion":
                    ItemLogic_Helper();                   
                    ItemLogic_GanonsCastle();
                    break;
                case "Zeldas Lullaby":
                    ItemLogic_SpiritTemple();
                    ItemLogic_DesertColossus();
                    ItemLogic_WaterTemple();
                    ItemLogic_Castles();
                    ItemLogic_GanonsCastle();
                    ItemLogic_GoronCity();
                    ItemLogic_DMC();
                    ItemLogic_DMT();
                    ItemLogic_BotW();
                    ItemLogic_Graveyard();
                    ItemLogic_ShadowTemple();
                    ItemLogic_ZoraRiver();
                    ItemLogic_ZoraDomain();
                    ItemLogic_ZoraFountain();
                    ItemLogic_IceCavern();
                    ItemLogic_Jabu();
                    break;
                case "Eponas Song":
                    ItemLogic_Helper();
                    ItemLogic_SpiritTemple();
                    ItemLogic_DesertColossus();
                    ItemLogic_GTG();
                    ItemLogic_Wasteland();
                    ItemLogic_GerudoFortress();
                    ItemLogic_GerudoValley();
                    ItemLogic_Market();
                    ItemLogic_ZoraRiver();
                    break;
                case "Sarias Song":
                    ItemLogic_GoronCity();
                    ItemLogic_ZoraRiver();
                    ItemLogic_LostWoods();
                    ItemLogic_SFM();
                    ItemLogic_ForestTemple();
                    break;
                case "Sun Song":
                    ItemLogic_Graveyard();
                    ItemLogic_ZoraRiver();
                    break;
                case "Song of Time":
                    ItemLogic_GTG();
                    ItemLogic_WaterTemple();
                    ItemLogic_ZoraRiver();
                    ItemLogic_FireTemple();
                    ItemLogic_SpiritTemple();
                    break;
                case "Song of Storms":
                    ItemLogic_DMT();
                    ItemLogic_BotW();
                    ItemLogic_ZoraRiver();
                    ItemLogic_KokiriForest();
                    break;
                case "Minuet":
                    ItemLogic_ForestTemple();
                    ItemLogic_SFM();
                    break;
                case "Bolero":
                    ItemLogic_Helper();
                    ItemLogic_DMC();
                    ItemLogic_FireTemple();
                    break;
                case "Nocturne":
                    ItemLogic_ShadowTemple();
                    break;
                case "Requiem":
                    ItemLogic_Helper();
                    ItemLogic_SpiritTemple();
                    ItemLogic_DesertColossus();
                    break;
                case "Forest Boss Key":
                    ItemLogic_ForestTemple();
                    break;
            }
        }
        */
    }

}
