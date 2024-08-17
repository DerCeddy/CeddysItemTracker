using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CeddysItemTracker
{
    public partial class Form1 : Form
    {
        public int forest = 0;
        public int fire = 0;
        public int water = 0;
        public int shadow = 0;
        public int spirit = 0;
        public int kStone = 0;
        public int light = 0;
        public int gStone = 0;
        public int zStone = 0;
        private void ForestLabel_Scroll(object sender, MouseEventArgs e)
        {
            if (e.Delta < 0)
            {
                forest = LabelUP(forest);
            }
            else if (e.Delta > 0)
            {
                forest = LabelDOWN(forest);
            }
            CheckLabelState(forest, forestLabel);
        }
        private void FireLabel_Scroll(object sender, MouseEventArgs e)
        {
            if (e.Delta < 0)
            {
                fire = LabelUP(fire);
            }
            else if (e.Delta > 0)
            {
                fire = LabelDOWN(fire);
            }
            CheckLabelState(fire, fireLabel);
        }
        private void WaterLabel_Scroll(object sender, MouseEventArgs e)
        {
            if (e.Delta < 0)
            {
                water = LabelUP(water);
            }
            else if (e.Delta > 0)
            {
                water = LabelDOWN(water);
            }
            CheckLabelState(water, waterLabel);
        }
        private void ShadowLabel_Scroll(object sender, MouseEventArgs e)
        {
            if (e.Delta < 0)
            {
                shadow = LabelUP(shadow);
            }
            else if (e.Delta > 0)
            {
                shadow = LabelDOWN(shadow);
            }
            CheckLabelState(shadow, shadowLabel);
        }
        private void SpiritLabel_Scroll(object sender, MouseEventArgs e)
        {
            if (e.Delta < 0)
            {
                spirit = LabelUP(spirit);
            }
            else if (e.Delta > 0)
            {
                spirit = LabelDOWN(spirit);
            }
            CheckLabelState(spirit, spiritLabel);
        }
        private void LightLabel_Scroll(object sender, MouseEventArgs e)
        {
            if (e.Delta < 0)
            {
                light = LabelUP(light);
            }
            else if (e.Delta > 0)
            {
                light = LabelDOWN(light);
            }
            CheckLabelState(light, lightLabel);
        }
        private void KStoneLabel_Scroll(object sender, MouseEventArgs e)
        {
            if (e.Delta < 0)
            {
                kStone = LabelUP(kStone);
            }
            else if (e.Delta > 0)
            {
                kStone = LabelDOWN(kStone);
            }
            CheckLabelState(kStone, kStoneLabel);
        }
        private void GStoneLabel_Scroll(object sender, MouseEventArgs e)
        {
            if (e.Delta < 0)
            {
                gStone = LabelUP(gStone);
            }
            else if (e.Delta > 0)
            {
                gStone = LabelDOWN(gStone);
            }
            CheckLabelState(gStone, gStoneLabel);
        }
        private void ZStoneLabel_Scroll(object sender, MouseEventArgs e)
        {
            if (e.Delta < 0)
            {
                zStone = LabelUP(zStone);
            }
            else if (e.Delta > 0)
            {
                zStone = LabelDOWN(zStone);
            }
            CheckLabelState(zStone, zStoneLabel);
        }
        public int LabelUP(int x)
        {
            x++;
            if (x > 5)
            { x = 5; }
            return x;
        }
        public static int LabelDOWN(int x)
        {
            x--;
            if (x < -3)
            { x = -3; }
            return x;
        }
        private static void CheckLabelState(int x, System.Windows.Forms.Label dungeon)
        {
            switch (x)
            {
                case -3:
                    dungeon.Text = "JABU";
                    break;
                case -2:
                    dungeon.Text = "DC";
                    break;
                case -1:
                    dungeon.Text = "DEKU";
                    break;
                case 0:
                    dungeon.Text = "FREE";
                    break;
                case 1:
                    dungeon.Text = "FOREST";
                    break;
                case 2:
                    dungeon.Text = "FIRE";
                    break;
                case 3:
                    dungeon.Text = "WATER";
                    break;
                case 4:
                    dungeon.Text = "SHADOW";
                    break;
                case 5:
                    dungeon.Text = "SPIRIT";
                    break;
            }
        }
    }
}
