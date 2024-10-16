using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CeddysItemTracker
{
    public partial class Form1 : Form
    {           
        private void RegionSelect(Control Region)
        {
            List<Panel> Regions = [];
            foreach (Control RegionPanel in maptracker.Controls)
            {
                if (RegionPanel is Panel Panel)
                {
                    Regions.Add(Panel);
                }
            }
            foreach (Panel RegionPanel in Regions)
            {
                if (RegionPanel == Region)
                {
                    Region.Visible = true;
                    Region.BringToFront();
                }
                else
                {
                    switch (RegionPanel.Name)
                    {                  
                        case "keysPanel":
                            break;                    
                        default:
                            RegionPanel.Visible = false;
                            break;
                    }
                }
            }
        }      
        private void RegionButton(MouseEventArgs e, Control RegionPanel, string RegionName)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    RegionSelect(RegionPanel);
                    break;
                case MouseButtons.Middle:
                    RegionCompletion(RegionPanel);
                    break;
                case MouseButtons.Right:
                    RightClickToTextboxes(RegionName, Controls.Find("wothPanel", true).First());
                    break;              
            }
        }                
        private void RegionCompletion(Control p)
        {
            int ChecksChecked = 0;
            int MaxChecks = 0;
            foreach (Control c in p.Controls)
            {
                if (c is CheckBox cb)
                {
                    MaxChecks++;
                    if (cb.Checked)
                    {
                        ChecksChecked++;
                    }
                }              
            }
            if (MaxChecks > ChecksChecked)
            {
                foreach (Control c in p.Controls)
                {
                    if (c is CheckBox cb)
                    {
                        cb.Checked = true;
                    }
                }
            }
            else
            {
                foreach (Control c in p.Controls)
                {
                    if (c is CheckBox cb)
                    {
                        cb.Checked = false;
                    }
                }
            }
            UpdateAllCountersOnClick();
        }
        private void LLR_Click(object sender, MouseEventArgs e)
        {
            RegionButton(e, maptracker.Controls.Find("Lon-Lon-Ranch", true).First(), "Lon-Lon-Ranch");           
        }
        private void HF_Click(object sender, MouseEventArgs e)
        {
            RegionButton(e, maptracker.Controls.Find("Hyrule Field", true).First(), "Hyrule Field");
        }
        private void Kf_Click(object sender, MouseEventArgs e)
        {
            RegionButton(e, maptracker.Controls.Find("Kokiri Forest", true).First(), "Kokiri Forest");
        }
        private void DekuTreeButton_Click(object sender, MouseEventArgs e)
        {
            RegionButton( e, maptracker.Controls.Find("Deku Tree", true).First(), "Deku Tree");
        }
        private void Kakariko_Click(object sender, MouseEventArgs e)
        {
            RegionButton(e, maptracker.Controls.Find("Kakariko", true).First(), "Kakariko");
        }
        private void Lake_Click(object sender, MouseEventArgs e)
        {
            RegionButton(e, maptracker.Controls.Find("Lake Hylia", true).First(), "Lake Hylia");
        }
        private void WaterTemple_Click(object sender, MouseEventArgs e)
        {
            RegionButton(e, maptracker.Controls.Find("Water Temple", true).First(), "Water Temple");
        }
        private void GerudoValley_Click(object sender, MouseEventArgs e)
        {
            RegionButton(e, maptracker.Controls.Find("Gerudo Valley", true).First(), "Gerudo Valley");
        }
        private void GerudoFortress_Click(object sender, MouseEventArgs e)
        {
            RegionButton(e, maptracker.Controls.Find("Gerudo Fortress", true).First(), "Gerudo Fortress");
        }
        private void Wasteland_Click(object sender, MouseEventArgs e)
        {
            RegionButton(e, maptracker.Controls.Find("Haunted Wasteland", true).First(), "Haunted Wasteland");
        }

        private void DesertCollossus_Click(object sender, MouseEventArgs e)
        {
            RegionButton(e, maptracker.Controls.Find("Desert Colossus", true).First(), "Desert Colossus");
        }

        private void SpiritTemple_Click(object sender, MouseEventArgs e)
        {
            RegionButton(e, maptracker.Controls.Find("Spirit Temple", true).First(), "Spirit Temple");
        }
        private void Market_Click(object sender, MouseEventArgs e)
        {
            RegionButton(e, maptracker.Controls.Find("Market", true).First(), "Market");
        }
        private void OutsideCastle_Click(object sender, MouseEventArgs e)
        {
            RegionButton(e, maptracker.Controls.Find("Castles", true).First(), "Castles");
        }
        private void Dmt_Click(object sender, MouseEventArgs e)
        {
            RegionButton(e, maptracker.Controls.Find("Death Mountain Trail", true).First(), "Death Mountain Trail");
        }
        private void GoronCity_Click(object sender, MouseEventArgs e)
        {
            RegionButton(e, maptracker.Controls.Find("Goron City", true).First(), "Goron City");
        }
        private void Dmc_Click(object sender, MouseEventArgs e)
        {
            RegionButton(e, maptracker.Controls.Find("Death Mountain Crater", true).First(), "Death Mountain Crater");
        }
        private void FireTemple_Click(object sender, MouseEventArgs e)
        {
            RegionButton(e, maptracker.Controls.Find("Fire Temple", true).First(), "Fire Temple");
        }
        private void ZoraRiver_Click(object sender, MouseEventArgs e)
        {
            RegionButton(e, maptracker.Controls.Find("Zora River", true).First(), "Zora River");
        }
        private void Graveyard_Click(object sender, MouseEventArgs e)
        {
            RegionButton(e, maptracker.Controls.Find("Graveyard", true).First(), "Graveyard");
        }
        private void ShadowTemple_Click(object sender, MouseEventArgs e)
        {
            RegionButton(e, maptracker.Controls.Find("Shadow Temple", true).First(), "Shadow Temple");
        }
        private void ZoraDomain_Click(object sender, MouseEventArgs e)
        {
            RegionButton(e, maptracker.Controls.Find("Zora Domain", true).First(), "Zoras Domain");
        }
        private void ZoraFountain_Click(object sender, MouseEventArgs e)
        {
            RegionButton(e, maptracker.Controls.Find("Zora Fountain", true).First(), "Zoras Fountain");
        }
        private void IceCavern_Click(object sender, MouseEventArgs e)
        {
            RegionButton(e, maptracker.Controls.Find("Ice Cavern", true).First(), "Ice Cavern");
        }
        private void LwButton_Click(object sender, MouseEventArgs e)
        {
            RegionButton(e, maptracker.Controls.Find("Lost Woods", true).First(), "Lost Woods");
        }
        private void SfwButton_Click(object sender, MouseEventArgs e)
        {
            RegionButton(e, maptracker.Controls.Find("Sacred Forest Meadow", true).First(), "Sacred Forest Meadow");
        }
        private void ForestButton_Click(object sender, MouseEventArgs e)
        {
            RegionButton(e, maptracker.Controls.Find("Forest Temple", true).First(), "Forest Temple");
        }
        private void DodongoCavernButton_Click(object sender, MouseEventArgs e)
        {
            RegionButton(e, maptracker.Controls.Find("Dodongos Cavern", true).First(), "Dodongos Cavern");
        }
        private void JjButton_Click(object sender, MouseEventArgs e)
        {
            RegionButton(e, maptracker.Controls.Find("Jabu-Jabus Belly", true).First(), "Jabu-Jabus Belly");
        }
        private void Gtg_button_Click(object sender, MouseEventArgs e)
        {
            RegionButton(e, maptracker.Controls.Find("Gerudos Training Grounds", true).First(), "Gerudo Training Grounds");
        }
        private void Botw_Button_Click(object sender, MouseEventArgs e)
        {
            RegionButton(e, maptracker.Controls.Find("Bottom of the Well", true).First(), "Bottom of the Well");
        }
        private void Tot_Button_Click(object sender, MouseEventArgs e)
        {
            RegionButton(e, maptracker.Controls.Find("Temple of Time", true).First(), "Temple of Time");
        }
        private void GanonCastle_Click(object sender, MouseEventArgs e)
        {
            RegionButton(e, maptracker.Controls.Find("Ganons Castle", true).First(), "Ganons Castle");
        }
        
    }
}
