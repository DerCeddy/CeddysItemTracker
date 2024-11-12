using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using static CeddysItemTracker.Form1;

namespace CeddysItemTracker
{
    partial class Form1
    {
        public void ItemLogic_ScrubShuffle()
        {
            Panel maptracker_Panel = maptracker;
            if (ScrubShuffle)
            {
                //Lost Woods
                if (((Has(SariasSong) || Has(Minuet)) && Has(Hammer)) || Bomb.State == 1)
                {
                    Pb("Lost Woods", "Deku Scrub Grotto Rear", maptracker_Panel).ForeColor = Available;
                }
                else
                {
                    Pb("Lost Woods", "Deku Scrub Grotto Rear", maptracker_Panel).ForeColor = red;
                }
                //SFM
                if (Has(SongOfStorms))
                {
                    Pb("Sacred Forest Meadow", "Deku Scrub Grotto Front", maptracker_Panel).ForeColor = Available;
                    Pb("Sacred Forest Meadow", "Deku Scrub Grotto Rear", maptracker_Panel).ForeColor = Available;
                }
                else
                {
                    Pb("Sacred Forest Meadow", "Deku Scrub Grotto Front", maptracker_Panel).ForeColor = red;
                    Pb("Sacred Forest Meadow", "Deku Scrub Grotto Rear", maptracker_Panel).ForeColor = red;
                }
                //Goron City
                if (Has(SongOfTime) || (Has(Hookshot) && (Has(GoronTunic) || Has(NayrusLove))))
                {
                    Pb("Goron City", "Deku Scrub Grotto Left", maptracker_Panel).ForeColor = Available;
                    Pb("Goron City", "Deku Scrub Grotto Center", maptracker_Panel).ForeColor = Available;
                    Pb("Goron City", "Deku Scrub Grotto Right", maptracker_Panel).ForeColor = Available;
                }
                else
                {
                    Pb("Goron City", "Deku Scrub Grotto Left", maptracker_Panel).ForeColor = red;
                    Pb("Goron City", "Deku Scrub Grotto Center", maptracker_Panel).ForeColor = red;
                    Pb("Goron City", "Deku Scrub Grotto Right", maptracker_Panel).ForeColor = red;
                }
                //Dodongos Cavern
                if (Bomb.State == 1 || Has(Strength) || Has(Hammer))
                {
                    Pb("Dodongos Cavern", "Deku Scrub Lobby", maptracker_Panel).ForeColor = Available;
                    Pb("Dodongos Cavern", "Deku Scrub Side Room Near Dodongos", maptracker_Panel).ForeColor = Available;
                }
                else
                {
                    Pb("Dodongos Cavern", "Deku Scrub Lobby", maptracker_Panel).ForeColor = red;
                    Pb("Dodongos Cavern", "Deku Scrub Side Room Near Dodongos", maptracker_Panel).ForeColor = red;
                }
                if (Bomb.State == 1 || ((Has(Dins) && Has(Magic) || Has(Strength)) && Has(Hammer)))
                {
                    Pb("Dodongos Cavern", "Deku Scrub Near Bomb Bag Right", maptracker_Panel).ForeColor = Available;
                    Pb("Dodongos Cavern", "Deku Scrub Near Bomb Bag Left", maptracker_Panel).ForeColor = Available;
                }
                else
                {
                    Pb("Dodongos Cavern", "Deku Scrub Near Bomb Bag Right", maptracker_Panel).ForeColor = red;
                    Pb("Dodongos Cavern", "Deku Scrub Near Bomb Bag Left", maptracker_Panel).ForeColor = red;
                }
                //DMC
                if (Has(Hammer) && (has_explosives || Has(Strength) || Has(Bow) || (Has(Bolero) && (Has(Hookshot) || Has(HoverBoots)))))
                {
                    Pb("Death Mountain Crater", "Deku Scrub Grotto Left", maptracker_Panel).ForeColor = Available;
                    Pb("Death Mountain Crater", "Deku Scrub Grotto Center", maptracker_Panel).ForeColor = Available;
                    Pb("Death Mountain Crater", "Deku Scrub Grotto Right", maptracker_Panel).ForeColor = Available;
                }
                else
                {
                    Pb("Death Mountain Crater", "Deku Scrub Grotto Left", maptracker_Panel).ForeColor = red;
                    Pb("Death Mountain Crater", "Deku Scrub Grotto Center", maptracker_Panel).ForeColor = red;
                    Pb("Death Mountain Crater", "Deku Scrub Grotto Right", maptracker_Panel).ForeColor = red;
                }
                if (Has(Bomb))
                {
                    Pb("Death Mountain Crater", "Deku Scrub", maptracker_Panel).ForeColor = Available;
                }
                else
                {
                    Pb("Death Mountain Crater", "Deku Scrub", maptracker_Panel).ForeColor = red;
                }
                //Zora River
                if (Has(SongOfStorms))
                {
                    Pb("Zora River", "Deku Scrub Grotto Front", maptracker_Panel).ForeColor = Available;
                    Pb("Zora River", "Deku Scrub Grotto Rear", maptracker_Panel).ForeColor = Available;
                }
                else
                {
                    Pb("Zora River", "Deku Scrub Grotto Front", maptracker_Panel).ForeColor = red;
                    Pb("Zora River", "Deku Scrub Grotto Rear", maptracker_Panel).ForeColor = red;
                }
                //Jabu Jabu
                if (Has(RutoLetter) && (Has(Scales) || (Bomb.State == 1 && Has(ZeldasLullaby))))
                {
                    Pb("Jabu-Jabus Belly", "Deku Scrub", maptracker_Panel).ForeColor = Available;
                }
                else
                {
                    Pb("Jabu-Jabus Belly", "Deku Scrub", maptracker_Panel).ForeColor = red;
                }
                // Gerudo Valley
                if ((has_longshot || Has(EponasSong)) && Has(SongOfStorms))
                {
                    Pb("Gerudo Valley", "Deku Scrub Grotto Front", maptracker_Panel).ForeColor = Available;
                    Pb("Gerudo Valley", "Deku Scrub Grotto Rear", maptracker_Panel).ForeColor = Available;
                }
                else
                {
                    Pb("Gerudo Valley", "Deku Scrub Grotto Front", maptracker_Panel).ForeColor = red;
                    Pb("Gerudo Valley", "Deku Scrub Grotto Rear", maptracker_Panel).ForeColor = red;
                }
                //Desert Colossus
                if (desertaccess == 1 && Strength.State > 1)
                {
                    Pb("Desert Colossus", "Deku Scrub Grotto Front", maptracker_Panel).ForeColor = Available;
                    Pb("Desert Colossus", "Deku Scrub Grotto Rear", maptracker_Panel).ForeColor = Available;
                }
                else
                {
                    Pb("Desert Colossus", "Deku Scrub Grotto Front", maptracker_Panel).ForeColor = red;
                    Pb("Desert Colossus", "Deku Scrub Grotto Rear", maptracker_Panel).ForeColor = red;
                }
                //Ganons Castle
                if (rainbowbridge)
                {
                    Pb("Ganons Castle", "Deku Scrub Left", maptracker_Panel).ForeColor = Available;
                    Pb("Ganons Castle", "Deku Scrub Center-Left", maptracker_Panel).ForeColor = Available;
                    Pb("Ganons Castle", "Deku Scrub Center-Right", maptracker_Panel).ForeColor = Available;
                    Pb("Ganons Castle", "Deku Scrub Right", maptracker_Panel).ForeColor = Available;
                }
                else
                {
                    Pb("Ganons Castle", "Deku Scrub Left", maptracker_Panel).ForeColor = red;
                    Pb("Ganons Castle", "Deku Scrub Center-Left", maptracker_Panel).ForeColor = red;
                    Pb("Ganons Castle", "Deku Scrub Center-Right", maptracker_Panel).ForeColor = red;
                    Pb("Ganons Castle", "Deku Scrub Right", maptracker_Panel).ForeColor = red;
                }
            }
        }
    }
}
