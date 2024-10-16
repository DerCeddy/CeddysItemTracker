using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeddysItemTracker
{
    public partial class Form1 : Form
    {
        public void AddScrubs()
        {
            LostWoods.AddRange(new string[] { "Deku Scrub Near Deku Theater Left", "Deku Scrub Near Deku Theater Right","Deku Scrub Grotto Rear" });
            SacredForestMeadow.AddRange(new string[] {"Deku Scrub Grotto Front","Deku Scrub Grotto Rear" });
            LonLonRanch.AddRange(new string[] {"Deku Scrub Grotto Left", "Deku Scrub Grotto Center", "Deku Scrub Grotto Right" });
            GoronCity.AddRange(new string[] { "Deku Scrub Grotto Left", "Deku Scrub Grotto Center", "Deku Scrub Grotto Right" });
            DeathMountainCrater.AddRange(new string[] { "Deku Scrub Grotto Left", "Deku Scrub Grotto Center", "Deku Scrub Grotto Right","Deku Scrub" });
            ZoraRiver.AddRange(new string[] { "Deku Scrub Grotto Front", "Deku Scrub Grotto Rear" });
            LakeHylia.AddRange(new string[] { "Deku Scrub Grotto Left", "Deku Scrub Grotto Center", "Deku Scrub Grotto Right" });
            GerudoValley.AddRange(new string[] { "Deku Scrub Grotto Front", "Deku Scrub Grotto Rear" });
            DesertColossus.AddRange(new string[] { "Deku Scrub Grotto Front", "Deku Scrub Grotto Rear" });
            DodongosCavern.AddRange(new string[] { "Deku Scrub Side Room Near Dodongos", "Deku Scrub Lobby", "Deku Scrub Near Bomb Bag Left", "Deku Scrub Near Bomb Bag Right" });
            JabuJabusBelly.AddRange(new string[] {"Deku Scrub" });
            GanonsCastle.AddRange(new string[] { "Deku Scrub Left", "Deku Scrub Center-Left", "Deku Scrub Center-Right", "Deku Scrub Right" });           
        }
        public void AddShops()
        {
            Market.AddRange(new string[] { "Bazaar Top Left", "Bazaar Top Right", "Bazaar Bottom Left", "Bazaar Bottom Right", "Potion Shop Top Left", "Potion Shop Top Right", "Potion Shop Bottom Left", "Potion Shop Bottom Right", "Bombchu Shop Top Left", "Bombchu Shop Top Right", "Bombchu Shop Bottom Left", "Bombchu Shop Bottom Right" });
            Kakariko.AddRange(new string[] { "Bazaar Top Left", "Bazaar Top Right", "Bazaar Bottom Left", "Bazaar Bottom Right", "Potion Shop Top Left", "Potion Shop Top Right", "Potion Shop Bottom Left", "Potion Shop Bottom Right" });
            GoronCity.AddRange(new string[] {"Shop Top Left", "Shop Top Right","Shop Bottom Left","Shop Bottom Right"});
            ZoraDomain.AddRange(new string[] {"Shop Top Left", "Shop Top Right", "Shop Bottom Left", "Shop Bottom Right"});         
        }
    }
}
