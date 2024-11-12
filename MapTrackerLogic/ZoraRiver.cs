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
        public void ItemLogic_ZoraRiver()
        {
            Panel maptracker_Panel = maptracker;
            //Both PoH
            if (Bomb.State == 1 || Has(Scales) || Has(HoverBoots))
            {
                Pb("Zora River", "Near Open Grotto Freestanding Heart", maptracker_Panel).ForeColor = Available;
                Pb("Zora River", "Near Domain Freestanding PoH", maptracker_Panel).ForeColor = Available;
            }
            else
            {
                Pb("Zora River", "Near Open Grotto Freestanding Heart", maptracker_Panel).ForeColor = red;
                Pb("Zora River", "Near Domain Freestanding PoH", maptracker_Panel).ForeColor = red;
            }
            //Frogs1
            if (Has(SongOfStorms) && (Bomb.State == 1 || Has(Scales)))
            {
                Pb("Zora River", "Frogs in the Rain", maptracker_Panel).ForeColor = Available;
            }
            else
            {
                Pb("Zora River", "Frogs in the Rain", maptracker_Panel).ForeColor = red;
            }
            //FrogGame
            if ((Has(ZeldasLullaby) && Has(EponasSong) && Has(SariasSong) && Has(SunSong) && Has(SongOfStorms) && Has(SongOfTime)) && (Has(Scales) || Bomb.State == 1))
            {
                Pb("Zora River", "Frogs Ocarina Game", maptracker_Panel).ForeColor = Available;
            }
            else
            {
                Pb("Zora River", "Frogs Ocarina Game", maptracker_Panel).ForeColor = red;
            }
            //Skulls
            if (Has(Scales) || Bomb.State == 1)
            {
                tokensAvailable += 1;
            }
            if (Has(Hookshot))
            {
                tokensAvailable += 2;
            }
        }
    }
}
