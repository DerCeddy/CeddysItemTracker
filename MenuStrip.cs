using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeddysItemTracker
{
    public partial class Form1 : Form
    {
        //Goal
        private void ToolStripMenuItem2_SGL_Click(object sender, EventArgs e)
        {
            Goalrequirement = "SGL";
            ItemLogic();
            UpdateAllCountersOnClick();          
        }
        private void ToolStripMenuItem2_Vanilla_Click(object sender, EventArgs e)
        {
            Goalrequirement = "Vanilla";
            ItemLogic();
            UpdateAllCountersOnClick();
        }
        private void MedPreset(object sender, EventArgs e)
        {
            Goalrequirement = "Medallions";
            ItemLogic();
            UpdateAllCountersOnClick();
        }
        private void ToolStripMenuItem2_AD_Click(object sender, EventArgs e)
        {
            Goalrequirement = "AD";
            ItemLogic();
            UpdateAllCountersOnClick();
        }
        //Reset Tracker
        private void ResetTracker(List<Item> ListItems)
        {
            foreach(Item i in ListItems)
            {
                i.State = 0;
                CheckItemState(i);
                ItemLogic();               
            }
            foreach (Control c1 in maptracker.Controls)
            {
                if (c1 is Panel p)
                {
                    foreach (Control c2 in p.Controls)
                    {
                        if (c2 is CheckBox cb)
                        {
                            cb.Checked = false;
                            UpdateAllCountersOnClick();
                        }
                    }
                }
            }
        }           
    }
}
