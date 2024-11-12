using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using static CeddysItemTracker.Form1;

namespace CeddysItemTracker
{
    partial class Form1
    {
        public void ItemLogic_GanonsCastle()
        {
            Panel maptracker_Panel = maptracker;
            if (rainbowbridge)
            {
                Pb("Ganons Castle", "Forest Trial Chest", maptracker_Panel).ForeColor = Available;
                Pb("Ganons Castle", "Water Trial Left Chest", maptracker_Panel).ForeColor = Available;
                Pb("Ganons Castle", "Water Trial Right Chest", maptracker_Panel).ForeColor = Available;
                Pb("Ganons Castle", "Boss Key Chest", maptracker_Panel).ForeColor = Available;
            }
            else
            {
                Pb("Ganons Castle", "Forest Trial Chest", maptracker_Panel).ForeColor = red;
                Pb("Ganons Castle", "Water Trial Left Chest", maptracker_Panel).ForeColor = red;
                Pb("Ganons Castle", "Water Trial Right Chest", maptracker_Panel).ForeColor = red;
                Pb("Ganons Castle", "Boss Key Chest", maptracker_Panel).ForeColor = red;
            }
            //Shadow Trial 1
            if (rainbowbridge && ((Has(Magic) && Has(Bow) && Has(FireArrow)) || Has(Hookshot) || Has(HoverBoots) || Has(SongOfTime)))
            {
                Pb("Ganons Castle", "Shadow Trial Front Chest", maptracker_Panel).ForeColor = Available;
            }
            else
            {
                Pb("Ganons Castle", "Shadow Trial Front Chest", maptracker_Panel).ForeColor = red;
            }
            //Shadow Trial 2
            if (rainbowbridge && (Has(HoverBoots) || has_firesource))
            {
                Pb("Ganons Castle", "Shadow Trial Golden Gauntlets Chest", maptracker_Panel).ForeColor = Available;
            }
            else
            {
                Pb("Ganons Castle", "Shadow Trial Golden Gauntlets Chest", maptracker_Panel).ForeColor = red;
            }
            //Light Trial
            if (rainbowbridge && Strength.State == 3)
            {
                Pb("Ganons Castle", "Light Trial First Left Chest", maptracker_Panel).ForeColor = Available;
                Pb("Ganons Castle", "Light Trial Second Left Chest", maptracker_Panel).ForeColor = Available;
                Pb("Ganons Castle", "Light Trial Third Left Chest", maptracker_Panel).ForeColor = Available;
                Pb("Ganons Castle", "Light Trial First Right Chest", maptracker_Panel).ForeColor = Available;
                Pb("Ganons Castle", "Light Trial Second Right Chest", maptracker_Panel).ForeColor = Available;
                Pb("Ganons Castle", "Light Trial Third Right Chest", maptracker_Panel).ForeColor = Available;
                Pb("Ganons Castle", "Light Trial Invisible Enemies Chest", maptracker_Panel).ForeColor = Available;
            }
            else
            {
                Pb("Ganons Castle", "Light Trial First Left Chest", maptracker_Panel).ForeColor = red;
                Pb("Ganons Castle", "Light Trial Second Left Chest", maptracker_Panel).ForeColor = red;
                Pb("Ganons Castle", "Light Trial Third Left Chest", maptracker_Panel).ForeColor = red;
                Pb("Ganons Castle", "Light Trial First Right Chest", maptracker_Panel).ForeColor = red;
                Pb("Ganons Castle", "Light Trial Second Right Chest", maptracker_Panel).ForeColor = red;
                Pb("Ganons Castle", "Light Trial Third Right Chest", maptracker_Panel).ForeColor = red;
                Pb("Ganons Castle", "Light Trial Invisible Enemies Chest", maptracker_Panel).ForeColor = red;
            }
            //Light Trial Last Chest
            if (rainbowbridge && Strength.State == 3 && Has(ZeldasLullaby))
            {
                Pb("Ganons Castle", "Light Trial Lullaby Chest", maptracker_Panel).ForeColor = Available;
            }
            else
            {
                Pb("Ganons Castle", "Light Trial Lullaby Chest", maptracker_Panel).ForeColor = red;
            }
            //Spirit Trial 1
            if (rainbowbridge && Has(Hookshot))
            {
                Pb("Ganons Castle", "Spirit Trial Crystal Switch Chest", maptracker_Panel).ForeColor = Available;
            }
            else
            {
                Pb("Ganons Castle", "Spirit Trial Crystal Switch Chest", maptracker_Panel).ForeColor = red;
            }
            //Spirit Trial 2
            if (rainbowbridge && Has(Hookshot) && Has(Bomb))
            {
                Pb("Ganons Castle", "Spirit Trial Invisible Chest", maptracker_Panel).ForeColor = Available;
            }
            else
            {
                Pb("Ganons Castle", "Spirit Trial Invisible Chest", maptracker_Panel).ForeColor = red;
            }
        }
    }
}
