using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeddysItemTracker
{
    public partial class Form1 : Form
    {
        public int forest_keys = 0;
        public int fire_keys = 0;
        public int water_keys = 0;
        public int shadow_keys = 0;
        public int spirit_keys = 0;
        public int gtg_keys = 0;
        public int botw_keys = 0;
        public static void KeyClick(MouseEventArgs e, ref int Item, int MaxCount, int LowestCount, Label KeyLabel)
        {
            if (e.Button == MouseButtons.Left)
            {
                Item = ValueUP(Item, MaxCount);
            }
            if (e.Button == MouseButtons.Right)
            {
                Item = ValueDown(Item, LowestCount);
            }
            if (Item == MaxCount)
            {
                KeyLabel.Text = Item.ToString();
                KeyLabel.ForeColor = Color.Lime;
            }
            else
            {
                KeyLabel.Text = Item.ToString();
                KeyLabel.ForeColor = Color.White;
            }
            
        }            
        private void Forestkey_Picturebox_Click(object sender, MouseEventArgs e)
        {
            KeyClick(e, ref forest_keys, 5, 0, forest_keyLabel);
            ItemLogic();
            UpdateRegionCounter(forestCheckedItems, maptracker.Controls.Find("Forest Temple", true).First(), forestButton, 14);
            UpdateChecks();
        }
        private void Firekey_Picturebox_Click(object sender, MouseEventArgs e)
        {
            KeyClick(e, ref fire_keys, 8, 0, fire_keyLabel);
            ItemLogic();
            UpdateRegionCounter(fireCheckedItems, maptracker.Controls.Find("Fire Temple", true).First(), fireTemple, 15);
            UpdateChecks();
        }
        private void Waterkey_Picturebox_Click(object sender, MouseEventArgs e)
        {
            KeyClick(e, ref water_keys, 6, 0, water_keyLabel);
            ItemLogic();
            UpdateRegionCounter(waterCheckedItems, maptracker.Controls.Find("Water Temple", true).First(), waterTemple, 11);
            UpdateChecks();
        }
        private void Shadowkey_Picturebox_Click(object sender, MouseEventArgs e)
        {
            KeyClick(e, ref shadow_keys, 5, 0, shadow_keyLabel);
            ItemLogic();
            UpdateRegionCounter(shadowCheckedItems, maptracker.Controls.Find("Shadow Temple", true).First(), shadowTemple, 18);
            UpdateChecks();
        }
        private void Spiritkey_Picturebox_Click(object sender, MouseEventArgs e)
        {
            KeyClick(e, ref spirit_keys, 5, 0, spirit_keyLabel);
            ItemLogic();
            UpdateRegionCounter(spiritCheckedItems, maptracker.Controls.Find("Spirit Temple", true).First(), spiritTemple, 20);
            UpdateChecks();
        }
        private void Gtg_keyPictureBox_Click(object sender, MouseEventArgs e)
        {
            KeyClick(e, ref gtg_keys, 9, 0, gtg_keyLabel);
            ItemLogic();
            UpdateRegionCounter(gtgCheckedItems, maptracker.Controls.Find("Gerudos Training Grounds", true).First(), gtg_button, 22);
            UpdateChecks();
        }
        private void Botw_keyPicturebox_Click(object sender, MouseEventArgs e)
        {
            KeyClick(e, ref botw_keys, 3, 0, botw_keyLabel);
            ItemLogic();
            UpdateRegionCounter(botwCheckedItems, maptracker.Controls.Find("Bottom of the Well", true).First(), botw_Button, 14);
            UpdateChecks();
        }
    }
}
