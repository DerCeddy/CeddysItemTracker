using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CeddysItemTracker.Form1;

namespace CeddysItemTracker
{
    partial class Form1
    {
        public void ItemLogic_LostWoods()
        {
            Panel maptracker_Panel = maptracker;
            //Skull Kid
            if (Has(SariasSong))
            {
                Pb("Lost Woods", "Skull Kid", maptracker_Panel).ForeColor = Available;
            }
            else
            {
                Pb("Lost Woods", "Skull Kid", maptracker_Panel).ForeColor = red;
            }
            //Target in the Woods
            if (Has(Slingshot))
            {
                Pb("Lost Woods", "Target in the Woods", maptracker_Panel).ForeColor = Available;
            }
            else
            {
                Pb("Lost Woods", "Target in the Woods", maptracker_Panel).ForeColor = red;
            }
            //Near Goron City Shortcut
            if (Has(Bomb) || Has(Hammer))
            {
                Pb("Lost Woods", "Near Shortcuts Grotto Chest", maptracker_Panel).ForeColor = Available;
            }
            else
            {
                Pb("Lost Woods", "Near Shortcuts Grotto Chest", maptracker_Panel).ForeColor = red;
            }
            //Scrubs Near SFM Exit
            if (((Has(SariasSong) || Has(Minuet)) && Has(Hammer)) || Bomb.State == 1)
            {
                Pb("Lost Woods", "Deku Scrub Grotto Front", maptracker_Panel).ForeColor = Available;
            }
            else
            {
                Pb("Lost Woods", "Deku Scrub Grotto Front", maptracker_Panel).ForeColor = red;
            }
            //Skulltula
            if (Has(Beans) || can_get_beans)
            {
                tokensAvailable++;
            }
        }
    }
}
