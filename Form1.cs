using CeddysItemTracker.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ObjectiveC;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using Newtonsoft.Json;



namespace CeddysItemTracker
{
    public partial class Form1 : Form
    {
        public int tokens;
        public int tokensAvailable;
        public int time = 0;
        public Point CurrentCursorPos;
        public Point PreviousMousePos;
        public int PreviousItemState;
        public bool IsDragging = false;
        public bool WasCollected = false;
        public string Goalrequirement = "Vanilla";
        public string RequiredMeds = "6";
        public string RequiredStones = "0";
        public bool SphereTrackerActive;
        public bool WOTHEnabled;
        public bool MapTrackerEnabled;
        public int pathHintCount;
        public int sometimesCount;
        public Size wothSize;
        public Size sometimesSize;
        public Size appsize;
        public Point wothLocation;
        public Point alwaysLocation;
        public Point sometimesLocation;
        public Point items_equips_location;
        public int SphereRows;
        public int SphereColumns;
        public bool ScrubShuffle;
        public bool ShopShuffle;
        public bool helplines;
        public bool enableStats;
        public Point stats_location;
        public bool N64_Textures;
        readonly List<string> LonLonRanch = ["Lon-Lon-Ranch", "Talon Minigame", "Malon Song", "LLR HP"];
        readonly List<string> HyruleField = ["Hyrule Field", "Open Grotto", "Southeast Grotto", "Salesman", "North Grotto", "Tektite Grotto Freestanding PoH", "Song of Time"];
        readonly List<string> KokiriForest = ["Kokiri Forest", "Mido Top Left", "Mido Top Right", "Mido Bottom Left", "Mido Bottom Right", "Kokiri Sword Chest", "Storms Grotto"];
        readonly List<string> LostWoods = ["Lost Woods", "Ocarina Memory Game", "Target in the Woods", "Near Shortcuts Grotto Chest", "Skull Kid", "Deku Scrub Near Bridge", "Deku Scrub Grotto Front", "Skull Mask"];
        readonly List<string> SacredForestMeadow = ["Sacred Forest Meadow", "Wolfo Grotto", "Sarias Song", "Shiek in Forest"];
        readonly List<string> DekuTree = ["Deku Tree", "Map Chest", "Slingshot Room Side Chest", "Slingshot Chest", "Compass Chest", "Compass Room Side Chest", "Basement Chest", "Gohma Heart"];
        readonly List<string> ForestTemple = ["Forest Temple", "First Room Chest", "First Stalfos Chest", "Raised Island Courtyard Chest", "Map Chest", "Well Chest", "Eye Switch Chest", "Boss Key Chest", "Floormaster Chest", "Red Poe Chest", "Bow Chest", "Blue Poe Chest", "Falling Ceilling Room Chest", "Basement Chest", "Phantom Ganon Heart"];
        readonly List<string> LakeHylia = ["Lake Hylia", "Underwater Item", "Child Fishing", "Adult Fishing", "Lab Dive", "Freestanding PoH", "Shoot the Sun"];
        readonly List<string> GerudoValley = ["Gerudo Valley", "Crate Freestanding PoH", "Waterfall Freestanding PoH", "Hammer Chest"];
        readonly List<string> GerudoFortress = ["Gerudo Fortress", "Chest on Roof", "HBA 1000 Points", "HBA 1500 Points"];
        readonly List<string> GerudosTrainingGrounds = ["Gerudos Training Grounds", "Lobby Left Chest", "Lobby Right Chest", "Stalfos Chest", "Before Heavy Block Chest", "Heavy Block First Chest", "Heavy Block Second Chest", "Heavy Block Third Chest", "Heavy Block Fourth Chest", "Eye Statue Chest", "Near Scarecrow Chest", "Hammer Room Clear Chest", "Hammer Room Switch Chest", "Freestanding Key", "Maze Right Central Chest", "Maze Right Side Chest", "Underwater Silver Rupee Chest", "Beamos Chest", "Hidden Ceiling Chest", "Maze Path First Chest", "Maze Path Second Chest", "Maze Path Third Chest", "Maze Path Final Chest"];
        readonly List<string> HauntedWasteland = ["Haunted Wasteland", "Wasteland Chest"];
        readonly List<string> DesertColossus = ["Desert Colossus", "Great Fairy Reward", "Freestanding PoH", "Shiek at Colossus"];
        readonly List<string> SpiritTemple = ["Spirit Temple", "Child Bridge Chest", "Child Early Torches Chest", "Child Climb North Chest", "Child Climb East Chest", "Map Chest", "Sun Block Room Chest", "Silver Gauntlets Chest", "Compass Chest", "Early Adult Right Chest", "First Mirror Left Chest", "First Mirror Right Chest", "Statue Room Northeast Chest", "Statue Room Hand Chest", "Near Four Armos Chest", "Hallway Right Invisible Chest", "Hallway Left Invisible Chest", "Mirror Shield Chest", "Boss Key Chest", "Topmost Chest", "Twinrova Heart"];
        readonly List<string> ZoraRiver = ["Zora River", "Open Grotto Chest", "Frogs in the Rain", "Frogs Ocarina Game", "Near Open Grotto Freestanding Heart", "Near Domain Freestanding PoH"];
        readonly List<string> ZoraDomain = ["Zora Domain", "Diving Game", "Chest", "King Zora Thawed"];
        readonly List<string> ZoraFountain = ["Zora Fountain", "Great Fairy Reward", "Iceberg Freestanding PoH", "Bottom Freestanding PoH"];
        readonly List<string> JabuJabusBelly = ["Jabu-Jabus Belly", "Boomerang Chest", "Map Chest", "Compass Chest", "Barinade Heart"];
        readonly List<string> IceCavern = ["Ice Cavern", "Map Chest", "Compass Chest", "Iron Boots Chest", "Freestanding PoH", "Shiek at Ice Cavern"];
        readonly List<string> Kakariko = ["Kakariko", "Chickens", "Anju as Adult", "Impas House Freestanding PoH", "Windmill Freestanding PoH", "Man on Roof", "Open Grotto Chest", "Windmill Song", "Redead Grotto Chest", "Shooting Gallery", "Shiek at Kakariko", "10 Skulltulas", "20 Skulltulas", "30 Skulltulas", "40 Skulltulas", "50 Skulltulas"];
        readonly List<string> BottomOfTheWell = ["Bottom of the Well", "Front Left Fake Wall Chest", "Front Center Bombable Chest", "Back Left Bombable Chest", "Underwater Left Chest", "Freestanding Key", "Compass Chest", "Center Skull Chest", "Right Bottom Fake Wall Chest", "Fire Keese Chest", "Like Like Chest", "Map Chest", "Underwater Front Chest", "Invisible Chest", "Lens of Truth Chest"];
        readonly List<string> Graveyard = ["Graveyard", "Shield Grave Chest", "Heart Piece Grave Chest", "Royal Familys Tomb Chest", "Freestanding PoH", "Dampe Gravedigging Tour", "Dampe Race Hookshot Chest", "Dampe Race Freestanding PoH", "Composer Song"];
        readonly List<string> ShadowTemple = ["Shadow Temple", "Map Chest", "Hover Boots Chest", "Compass Chest", "Early Silver Rupee Chest", "Invisible Blades Left Chest", "Invisible Blades Right Chest", "Falling Spikes Lower Chest", "Falling Spikes Upper Chest", "Falling Spikes Switch Chest", "Invisible Spikes Chest", "Shadow Pot", "Wind Hint Chest", "After Wind Enemy Chest", "After Wind Hidden Chest", "Spike Walls Left Chest", "Boss Key Chest", "Invisible Floormaster Chest", "Bongo Bongo Heart"];
        readonly List<string> DeathMountainTrail = ["Death Mountain Trail", "Freestanding PoH", "Chest", "Storms Grotto Chest", "Great Fairy Reward", "Biggoron"];
        readonly List<string> DodongosCavern = ["Dodongos Cavern", "Map Chest", "Compass Chest", "Bomb Flower Platform Chest", "Bomb Bag Chest", "End of Bridge Chest", "Boss Room Chest", "King Dodongo Heart"];
        readonly List<string> GoronCity = ["Goron City", "Darunias Joy", "Pot Freestanding PoH", "Rolling Goron as Child", "Rolling Goron as Adult", "Maze Left Chest", "Maze Center Chest", "Maze Right Chest"];
        readonly List<string> DeathMountainCrater = ["Death Mountain Crater", "Volcano Freestanding PoH", "Wall Freestanding PoH", "Upper Grotto Chest", "Shiek at Crater", "Great Fairy Reward"];
        readonly List<string> FireTemple = ["Fire Temple", "Near Boss Door Chest", "Flare Dancer Chest", "Boss Key Chest", "Big Lava Room Lower Door Chest", "Big Lava Room Blocked Door Chest", "Boulder Maze Lower Chest", "Boulder Maze Side Room Chest", "Map Chest", "Boulder Maze Shortcut Chest", "Boulder Maze Upper Chest", "Scarecrow Chest", "Compass Chest", "Megaton Hammer Chest", "Highest Goron Chest", "Volvagia Heart"];
        readonly List<string> WaterTemple = ["Water Temple", "Compass Chest", "Map Chest", "Cracked Wall Chest", "Torches Chest", "Boss Key Chest", "Central Pillar Chest", "Central Bow Target Chest", "Longshot Chest", "River Chest", "Dragon Chest", "Morpha Heart"];
        readonly List<string> Market = ["Market", "Shooting Gallery Reward", "Bombchu Bowling First Prize", "Bombchu Bowling Second Prize", "Lost Dog", "Treasure Chest Game", "10 Big Poes"];
        readonly List<string> TempleOfTime = ["Temple of Time", "Shiek at Temple", "Light Arrow Cutscene"];
        readonly List<string> Castles = ["Castles", "HC Great Fairy Reward", "GC Great Fairy Reward"];
        readonly List<string> GanonsCastle = ["Ganons Castle", "Forest Trial Chest", "Water Trial Left Chest", "Water Trial Right Chest", "Shadow Trial Front Chest", "Shadow Trial Golden Gauntlets Chest", "Light Trial First Left Chest", "Light Trial Second Left Chest", "Light Trial Third Left Chest", "Light Trial First Right Chest", "Light Trial Second Right Chest", "Light Trial Third Right Chest", "Light Trial Invisible Enemies Chest", "Light Trial Lullaby Chest", "Spirit Trial Crystal Switch Chest", "Spirit Trial Invisible Chest", "Boss Key Chest"];

        public class Settings
        {
            [JsonProperty("General")]
            public required General general;
            [JsonProperty("ShuffleSettings")]
            public required ShuffleSettings shuffleSettings;
            [JsonProperty("WOTHPanel")]
            public required WOTHPanel wothpanel;
            [JsonProperty("AlwaysPanel")]
            public required WOTHPanel alwayspanel;
            [JsonProperty("SometimesPanel")]
            public required SometimesPanel sometimespanel;
            [JsonProperty("SphereTracker")]
            public required SphereTracker spheretracker;
            [JsonProperty("Stats")]
            public required SphereTracker stats;
            [JsonProperty("Items_Equips")]
            public required SphereTracker items_equips;
            [JsonProperty("MapTracker")]
            public required MapTracker maptracker;       
        }
        public class ShuffleSettings
        {
            public bool ScrubShuffle;
            public bool ShopShuffle;
        }
        public class WOTHPanel
        {
            public bool Enabled;
            public int HintCount;
            public Size Size;
            public Point Location;
        }
        public class AlwaysPanel
        {
            public bool Enabled;
            public Size Size;
            public Point Location;
        }
        public class SometimesPanel
        {
            public int HintCount;
            public Size Size;
            public Point Location;
        }
        public class Items_Equips
        {
            public Point Location;
        }
        public class SphereTracker
        {
            public bool Enabled;
            public Size Size;
            public Point Location;
            public int Rows;
            public int Columns;
        }
        public class Stats
        {
            public bool Enabled;
            public Point Location;
        }
        public class MapTracker
        {
            public bool Enabled;
        }
        public class General
        {

            public Size Appsize;
            public bool HelpLines;
            public bool N64_Textures;
        }
        public Form1()
        {
            InitializeComponent();           
            List <List<string>> Regions = [LonLonRanch, HyruleField, KokiriForest, LostWoods, SacredForestMeadow,DekuTree,ForestTemple,LakeHylia,GerudoValley,GerudoFortress,GerudosTrainingGrounds,HauntedWasteland, DesertColossus, SpiritTemple, ZoraRiver, ZoraDomain, ZoraFountain, JabuJabusBelly, IceCavern, Kakariko, BottomOfTheWell, Graveyard, ShadowTemple, DeathMountainTrail, DodongosCavern, GoronCity, DeathMountainCrater, FireTemple, WaterTemple, Market, TempleOfTime, Castles, GanonsCastle];         
            StreamReader r = new("config.json");
            string json = r.ReadToEnd();
            Settings Konfig = JsonConvert.DeserializeObject<Settings>(json);
            ScrubShuffle = Konfig.shuffleSettings.ScrubShuffle;
            ShopShuffle = Konfig.shuffleSettings.ShopShuffle;
            pathHintCount = Konfig.wothpanel.HintCount;
            sometimesCount = Konfig.sometimespanel.HintCount;
            wothSize = Konfig.wothpanel.Size;
            wothLocation = Konfig.wothpanel.Location;
            sometimesSize = Konfig.sometimespanel.Size;
            WOTHEnabled = Konfig.wothpanel.Enabled;
            appsize = Konfig.general.Appsize;
            MapTrackerEnabled = Konfig.maptracker.Enabled;
            SphereTrackerActive = Konfig.spheretracker.Enabled;
            sphere_panel.Location = Konfig.spheretracker.Location;
            sphere_panel.Size = Konfig.spheretracker.Size;
            //dungeon_item_count_panel.Location = new Point(755,621);
            SphereColumns = Konfig.spheretracker.Columns;
            SphereRows = Konfig.spheretracker.Rows;
            alwaysLocation = Konfig.alwayspanel.Location;
            sometimesLocation = Konfig.sometimespanel.Location;
            helplines = Konfig.general.HelpLines;
            items_equips_location = Konfig.items_equips.Location;
            Size = appsize;
            equip_panel.Location = items_equips_location;
            enableStats = Konfig.stats.Enabled;
            stats_location = Konfig.stats.Location;
            N64_Textures = Konfig.general.N64_Textures;          
            if (ScrubShuffle)
            {
                AddScrubs();
            }
            if (ShopShuffle)
            {
                AddShops();
            }
            foreach (List<string> list in Regions)
            {
                DrawRegionPanel(maptracker, list);
            }
            Sphere0Checks();
            ItemLogic();
            UpdateAllCountersOnClick();
            AddPictureBoxesToItems();
            stat_panel.Location = stats_location;
            if(!enableStats)
            {
                stat_panel.Dispose();
            }
            if (WOTHEnabled)
            {
                DrawWOTHPanel(this);
            }
            if (!MapTrackerEnabled)
            {
                maptracker.Dispose();
            }
            if (SphereTrackerActive)
            {
                DrawSphereTracker(sphere_panel, SphereRows,SphereColumns);
            }
            else
            {
                sphere_panel.Dispose();
            }
            if(helplines)
            {
                maptracker.BorderStyle = BorderStyle.FixedSingle;
                equip_panel.BorderStyle = BorderStyle.FixedSingle;
                alwayshintsPanel.BorderStyle = BorderStyle.FixedSingle;
                stat_panel.BorderStyle = BorderStyle.FixedSingle;
                sphere_panel.BorderStyle= BorderStyle.FixedSingle;
            }
            DrawSometimesPanel(this);
            alwayshintsPanel.Location = alwaysLocation;
            tokenCounterDisplay.BackColor = Color.Transparent;
            tokenCounterDisplay.Parent = pictureBox1;           
            timer.Tick += TimerUpdate;
            timer.Stop();        
            List<Item> Items =
            [
                Bomb,
                Bow,
                Lens,
                Nuts,
                Sticks,
                FireArrow,
                Dins,
                Slingshot,
                Ocarina,
                Bombchu,
                Hookshot,
                IceArrow,
                FaroresWind,
                Boomerang,
                Beans,
                Hammer,
                LightArrow,
                NayrusLove,
                RutoLetter,
                Bottle2,
                Bottle3,
                Bottle4,
                ChildTradeItems,
                AdultTradeItems,
                KokiriSword,
                MasterSword,
                BiggoronSword,
                GerudoCard,
                DekuShield,
                HylianShield,
                MirrorShield,
                Strength,
                Scales,
                Wallet,
                GoronTunic,
                ZoraTunic,
                Magic,
                IronBoots,
                HoverBoots,
                ZeldasLullaby,
                EponasSong,
                SariasSong,
                SunSong,
                SongOfTime,
                SongOfStorms,
                Minuet,
                Bolero,
                Serenade,
                Nocturne,
                Reqiuem,
                Prelude,
                ForestMedallion,
                FireMedallion,
                WaterMedallion,
                ShadowMedallion,
                SpiritMedallion,
                LightMedallion,
                KokiriStone,
                GoronStone,
                ZoraStone,
                DoubleDefense,
                Agony,
                GoMode,
                ForestBossKey,
                FireBossKey,
                WaterBossKey,
                ShadowBossKey,
                SpiritBossKey
            ];
            if (N64_Textures)
            {
                ChangeToN64();
                foreach (Item i in Items)
                {
                    CheckItemState(i);
                }
            }
            resetTracker.MouseDown += (sender, e) => ResetTracker(Items);
            //Mouse Interactions with Items
            foreach (Item i in Items)
            {            
                    i.ItemPictureBox.MouseDown += (sender, e) => Drag_MouseDown(e, i);
                    i.ItemPictureBox.MouseDown += (sender, e) => ItemClick(sender, e, i);
                    i.ItemPictureBox.MouseMove += (sender, e) => MouseMoveForDrag(sender, e, i);
                    i.ItemPictureBox.MouseUp += ItemClickMouseUp;             
            }
            List<PictureBox> boxes = [];
            foreach (Control c in equip_panel.Controls)
            {
                if (c is PictureBox box)
                {
                    boxes.Add(box);
                }
            }
            //Transparency for Items
            foreach (PictureBox pb in boxes)
            {
                pb.BackColor = Color.Transparent;
                switch (pb.Name)
                {
                    case "pictureBox1":
                        break;
                    case "hyrule_map":
                        break;
                    case "keyBag_Form1":
                        break;
                    case "equip_panel":
                        break;
                    default:
                        pb.Parent = pictureBox1;
                        break;
                }
            }
            List<Label> labels = [];
            foreach (Control c in equip_panel.Controls)
            {
                if (c is Label l)
                {
                    labels.Add(l);
                }
            }
            foreach (Label l in labels)
            {
                if (l.Name == "checks_Label" || l.Name == "tokenCounter")
                {

                }
                else
                {
                    l.BackColor = Color.Transparent;
                    l.Parent = pictureBox1;
                }
            }
            foreach (Control c in alwayshintsPanel.Controls)
            {
                if (c is PictureBox p && p.Name.StartsWith("alwayshintStone"))
                {
                    p.AllowDrop = true;
                    p.DragEnter += GossipStone_DragEnter;
                    p.DragDrop += (sender, e) => GossipStone_DragDrop(e, p);
                    p.MouseMove += (sender, e) => MouseMoveForDrag(e, p);
                    p.MouseClick += (sender, e) => GossipStone_Click(e, p);
                    p.MouseDown += (sender, e) => Drag_MouseDown(e);
                    p.MouseUp += ItemClickMouseUp;
                }
            }
            foreach (Control c in songPanel.Controls)
            {
                PictureBox? p = c as PictureBox;
                if (p != null && p.Name.Contains("songStone"))
                {
                    p.AllowDrop = true;
                    p.DragEnter += GossipStone_DragEnter;
                    p.DragDrop += (sender, e) => GossipStone_DragDrop(e, p);
                    p.MouseMove += (sender, e) => MouseMoveForDrag(e, p);
                    p.MouseClick += (sender, e) => GossipStone_Click(e, p);
                    p.MouseDown += (sender, e) => Drag_MouseDown(e);
                    p.MouseUp += ItemClickMouseUp;
                }
                if (p != null && !p.Name.Contains("songStone"))
                {
                    p.Parent = songPanel;
                    p.BackColor = Color.Transparent;
                    p.MouseUp += ItemClickMouseUp;
                }
            }              
        }
        private void Starttimer_button_Click(object sender, EventArgs e)
        {
            timer.Start();
        }
    }
}