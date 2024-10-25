using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeddysItemTracker
{
    public partial class Form1 : Form
    {
        public int remainingChecks;
        public int availableChecks;
        public double checkedchecks;
        public int llrcheckeditems;
        public int dekuTreeCheckedItems;
        public int kfCheckedItems;
        public int hfCheckedItems;
        public int lwCheckedItems;
        public int sfmCheckItems;
        public int marketCheckedItems;
        public int kakCheckedItems;
        public int dmtCheckedItems;
        public int dmcCheckedItems;
        public int botwCheckedItems;
        public int goronCityCheckedItems;
        public int lhCheckedItems;
        public int gvCheckedItems;
        public int gfCheckedItems;
        public int gyCheckedItems;
        public int gtgCheckedItems;
        public int sfmCheckedItems;
        public int wastelandCheckedItems;
        public int desertColossusCheckedItems;
        public int zrCheckedItems;
        public int zdCheckedItems;
        public int zfCheckedItems;
        public int castlesCheckedItems;
        public int dtCheckedItems;
        public int dcCheckedItems;
        public int jjCheckedItems;
        public int spiritCheckedItems;
        public int shadowCheckedItems;
        public int fireCheckedItems;
        public int forestCheckedItems;
        public int icecavernCheckedItems;
        public int waterCheckedItems;
        public int tot_CheckedItems;
        public int ganonsCastle_CheckedItems;    
        private void UpdateRegionCounter(int region, Control region_panel, Button region_button, int maxChecks)
        {
            region = 0;
            foreach (Control c in region_panel.Controls)
            {
                if (c is CheckBox cb && cb.Checked == false && (cb.ForeColor == Color.Lime || cb.ForeColor == coulddo))
                {
                    region++;
                }
            }
            if(region >= 10 && region_button.Tag != "Dungeon")
            {
                region_button.Text = region.ToString();
                region_button.Font = new Font("Segoe UI",9,GraphicsUnit.Pixel);
            }  
            else
            {
                region_button.Text = region.ToString();
                region_button.Font = new Font("Segoe UI", 12, GraphicsUnit.Pixel);
            }
            BackgroundColorForButtons(region_panel, region_button, maxChecks);
        }      
        private void BackgroundColorForButtons(Control LocationPanel, Button LocationButton, int MaxCheckCount)
        {
            int availableItems = 0;
            int checkedItems = 0;
            foreach (Control c in LocationPanel.Controls)
            {
                CheckBox? cb = c as CheckBox;
                if (cb != null && (cb.ForeColor == Color.Lime || cb.ForeColor == coulddo) && !cb.Checked)
                {
                    availableItems++;
                }
                if (cb != null && cb.Checked)
                {
                    checkedItems++;
                }
            }
            if (checkedItems == MaxCheckCount)
            {
                LocationButton.BackColor = Color.Gray;
            }
            else if (availableItems == 0)
            {
                LocationButton.BackColor = Color.Red;
            }
            else if (availableItems + checkedItems == MaxCheckCount)
            {
                LocationButton.BackColor = Color.Lime;
            }
            else
            {
                LocationButton.BackColor = Color.Orange;
            }
        }
        public void UpdateAllCountersOnClick()
        {
            UpdateChecks();
            UpdateRegionCounter(kfCheckedItems, maptracker.Controls.Find("Kokiri Forest", true).First(), kf, KokiriForest.Count - 1);
            UpdateRegionCounter(llrcheckeditems, maptracker.Controls.Find("Lon-Lon-Ranch", true).First(), LLR, LonLonRanch.Count - 1);
            UpdateRegionCounter(dekuTreeCheckedItems, maptracker.Controls.Find("Deku Tree", true).First(), dekuTreeButton, DekuTree.Count - 1);
            UpdateRegionCounter(hfCheckedItems, maptracker.Controls.Find("Hyrule Field", true).First(), hf, HyruleField.Count - 1);
            UpdateRegionCounter(kakCheckedItems, maptracker.Controls.Find("Kakariko", true).First(), kakariko, Kakariko.Count - 1);
            UpdateRegionCounter(lhCheckedItems, maptracker.Controls.Find("Lake Hylia", true).First(), lake, LakeHylia.Count - 1);
            UpdateRegionCounter(zrCheckedItems, maptracker.Controls.Find("Zora River", true).First(), zoraRiver, ZoraRiver.Count - 1);
            UpdateRegionCounter(marketCheckedItems, maptracker.Controls.Find("Market", true).First(), market, Market.Count - 1);
            UpdateRegionCounter(gvCheckedItems, maptracker.Controls.Find("Gerudo Valley", true).First(), gerudoValley, GerudoValley.Count - 1);
            UpdateRegionCounter(gfCheckedItems, maptracker.Controls.Find("Gerudo Fortress", true).First(), gerudoFortress, GerudoFortress.Count - 1);
            UpdateRegionCounter(wastelandCheckedItems, maptracker.Controls.Find("Haunted Wasteland", true).First(), wasteland, HauntedWasteland.Count - 1);
            UpdateRegionCounter(desertColossusCheckedItems, maptracker.Controls.Find("Desert Colossus", true).First(), desertCollossus, DesertColossus.Count - 1);
            UpdateRegionCounter(lwCheckedItems, maptracker.Controls.Find("Lost Woods", true).First(), lwButton, LostWoods.Count - 1);
            UpdateRegionCounter(goronCityCheckedItems, maptracker.Controls.Find("Goron City", true).First(), goronCity, GoronCity.Count - 1);
            UpdateRegionCounter(gyCheckedItems, maptracker.Controls.Find("Graveyard", true).First(), graveyard, Graveyard.Count - 1);
            UpdateRegionCounter(dmtCheckedItems, maptracker.Controls.Find("Death Mountain Trail", true).First(), dmt, DeathMountainTrail.Count - 1);
            UpdateRegionCounter(dmcCheckedItems, maptracker.Controls.Find("Death Mountain Crater", true).First(), dmc, DeathMountainCrater.Count - 1);
            UpdateRegionCounter(sfmCheckedItems, maptracker.Controls.Find("Sacred Forest Meadow", true).First(), sfwButton, SacredForestMeadow.Count - 1);
            UpdateRegionCounter(zfCheckedItems, maptracker.Controls.Find("Zora Fountain", true).First(), zoraFountain, ZoraFountain.Count - 1);
            UpdateRegionCounter(zdCheckedItems, maptracker.Controls.Find("Zora Domain", true).First(), zoraDomain, ZoraDomain.Count - 1);
            UpdateRegionCounter(icecavernCheckedItems, maptracker.Controls.Find("Ice Cavern", true).First(), iceCavern, IceCavern.Count - 1);           
            UpdateRegionCounter(castlesCheckedItems, maptracker.Controls.Find("Castles", true).First(), outsideCastle, Castles.Count - 1);
            UpdateRegionCounter(dcCheckedItems, maptracker.Controls.Find("Dodongos Cavern", true).First(), dodongoCavernButton, DodongosCavern.Count - 1);
            UpdateRegionCounter(jjCheckedItems, maptracker.Controls.Find("Jabu-Jabus Belly", true).First(), jjButton, JabuJabusBelly.Count - 1);
            UpdateRegionCounter(forestCheckedItems, maptracker.Controls.Find("Forest Temple", true).First(), forestButton, ForestTemple.Count - 1);
            UpdateRegionCounter(fireCheckedItems, maptracker.Controls.Find("Fire Temple", true).First(), fireTemple, FireTemple.Count - 1);
            UpdateRegionCounter(waterCheckedItems, maptracker.Controls.Find("Water Temple", true).First(), waterTemple, WaterTemple.Count - 1);
            UpdateRegionCounter(shadowCheckedItems, maptracker.Controls.Find("Shadow Temple", true).First(), shadowTemple, ShadowTemple.Count - 1);
            UpdateRegionCounter(spiritCheckedItems, maptracker.Controls.Find("Spirit Temple", true).First(), spiritTemple, SpiritTemple.Count - 1);
            UpdateRegionCounter(gtgCheckedItems, maptracker.Controls.Find("Gerudos Training Grounds", true).First(), gtg_button, GerudosTrainingGrounds.Count - 1);
            UpdateRegionCounter(botwCheckedItems, maptracker.Controls.Find("Bottom of the Well", true).First(), botw_Button, BottomOfTheWell.Count - 1);
            UpdateRegionCounter(tot_CheckedItems, maptracker.Controls.Find("Temple of Time", true).First(), tot_Button, TempleOfTime.Count - 1);
            UpdateRegionCounter(ganonsCastle_CheckedItems, maptracker.Controls.Find("Ganons Castle", true).First(), ganonCastle, GanonsCastle.Count - 1);
        }
    }
}
