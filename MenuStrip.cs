using CeddysItemTracker.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            timer1.Stop();
            time = 0;
            cph_label.Text = "0 cph";
            for (int i = 0; i < goal123.Count; i++)
            {
                goal123[i] = 0;
            }
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
            foreach (Control c1 in alwayshintsPanel.Controls)
            {
                if(c1 is PictureBox pb)
                {
                    if (pb.Name.StartsWith("alwayshintStone"))
                    pb.Image = Resources.gossip_stone_bw_32x32;
                }
            }
            foreach (Control c1 in Controls.Find("sometimesPanel", true).First().Controls)
            {
                if (c1 is PictureBox pb)
                {
                    if(pb.Name.StartsWith("sometimesStone"))
                    {
                        pb.Image = Resources.gossip_stone_bw_32x32;
                    }
                }
                if (c1 is TextBox tb)
                {
                    if(tb.Name.StartsWith("sometimesHint"))
                    {
                        tb.Text = null;
                    }
                }
            }
            foreach (Control c1 in Controls.Find("wothPanel", true).First().Controls)
            {
                if (c1 is PictureBox pb)
                {
                    if(pb.Name.StartsWith("pathHintStone"))
                    {
                        pb.Image = Resources.gossip_stone_bw_32x32;
                    }
                    if (pb.Name.StartsWith("Goal"))
                    {
                        pb.Image = Resources.unknown_32x32;
                    }
                }
                if (c1 is TextBox tb)
                {
                    if(tb.Name.StartsWith("pathHint"))
                    {
                        tb.Text = null;
                    }
                }
            }
        }           
    }
}
