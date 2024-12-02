using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeddysItemTracker
{
    public partial class Form1 : Form
    {
        public int rupees_needed_value;
        private void UpdateChecks()
        {
            remainingChecks = 0;
            availableChecks = 0;
            checkedchecks = 0;
            foreach (Control c in maptracker.Controls)
            {
                if (c is Panel pn)
                {
                    foreach (Control c1 in pn.Controls)
                    {
                        CheckBox cb = c1 as CheckBox;
                        if (cb != null && cb.Checked == false)
                        {
                            remainingChecks++;
                        }
                        if (cb != null && cb.Checked == true)
                        {
                            checkedchecks++;
                        }
                        if (cb != null && cb.Checked == false && (cb.ForeColor == Color.Lime || cb.ForeColor == coulddo))
                        {
                            availableChecks++;
                        }
                    }
                }
            }
            string remaining = remainingChecks.ToString();
            string checkedChecks = checkedchecks.ToString();
            string available = availableChecks.ToString();
            checksdone_label.Text = $"{checkedChecks}";
            checksremaining_label.Text = $"{remaining}";
            availablechecks_label.Text = $"{available}";
        }
        public void TimerUpdate(object sender, EventArgs e)
        {
            time++;
            cph_label.Text = $"{Math.Round((checkedchecks / time * 60 * 60))} cph";
        } 
        public void Update_Rupee_Counter()
        {
            int rupees_needed = 0;
            Panel maptracker_Panel = maptracker;
            if(HylianShield.State == 0 && MirrorShield.State == 0)
            {
                rupees_needed += 80;
            }
            if(Pb("Lost Woods", "Deku Scrub Near Bridge", maptracker_Panel) is CheckBox cb)
            {
                if(!cb.Checked)
                {
                    rupees_needed += 40;
                }
            }
            if (Pb("Lost Woods", "Deku Scrub Grotto Front", maptracker_Panel) is CheckBox cb1)
            {
                if (!cb1.Checked)
                {
                    rupees_needed += 40;
                }
            }
            if (Pb("Market", "Bombchu Bowling First Prize", maptracker_Panel) is CheckBox cb2)
            {
                if (!cb2.Checked)
                {
                    rupees_needed += 30;
                }
            }
            if (Pb("Market", "Bombchu Bowling Second Prize", maptracker_Panel) is CheckBox cb3)
            {
                if (!cb3.Checked)
                {
                    rupees_needed += 30;
                }
            }
            if (Pb("Market", "Shooting Gallery Reward", maptracker_Panel) is CheckBox cb8)
            {
                if (!cb8.Checked)
                {
                    rupees_needed += 20;
                }
            }
            if (Pb("Market", "Treasure Chest Game", maptracker_Panel) is CheckBox cb9)
            {
                if (!cb9.Checked)
                {
                    rupees_needed += 10;
                }
            }
            if (Pb("Hyrule Field", "Salesman", maptracker_Panel) is CheckBox cb4)
            {
                if (!cb4.Checked)
                {
                    rupees_needed += 10;
                }
            }
            if (Pb("Lake Hylia", "Child Fishing", maptracker_Panel) is CheckBox cb5)
            {
                if (!cb5.Checked)
                {
                    rupees_needed += 20;
                }
            }
            if (Pb("Lake Hylia", "Adult Fishing", maptracker_Panel) is CheckBox cb6)
            {
                if (!cb6.Checked)
                {
                    rupees_needed += 20;
                }
            }
            if (Pb("Lon-Lon-Ranch", "Talon Minigame", maptracker_Panel) is CheckBox cb7)
            {
                if (!cb7.Checked)
                {
                    rupees_needed += 10;
                }
            }
            if (Pb("Zora Domain", "Diving Game", maptracker_Panel) is CheckBox cb10)
            {
                if (!cb10.Checked)
                {
                    rupees_needed += 20;
                }
            }
            if (Pb("Kakariko", "Shooting Gallery", maptracker_Panel) is CheckBox cb11)
            {
                if (!cb11.Checked)
                {
                    rupees_needed += 20;
                }
            }
            if (Pb("Graveyard", "Dampe Gravedigging Tour", maptracker_Panel) is CheckBox cb12)
            {
                if (!cb12.Checked)
                {
                    rupees_needed += 10;
                }
            }
            if (Pb("Gerudo Fortress", "HBA 1000 Points", maptracker_Panel) is CheckBox cb13 && Pb("Gerudo Fortress", "HBA 1500 Points", maptracker_Panel) is CheckBox cb14)
            {
                if (cb13.Checked && cb14.Checked)
                {
                    
                }
                else
                {
                    rupees_needed += 20;
                }
            }
            label7.Text = rupees_needed.ToString();
        }
    }
}
