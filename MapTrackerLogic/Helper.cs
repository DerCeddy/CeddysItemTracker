using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeddysItemTracker
{
    partial class Form1
    {
        public void ItemLogic_Helper()
        {                           
            //Explosives
            if (Has(Bomb))
            {
                has_explosives = true;
            }
            else
            {
                has_explosives = false;
            }
            if (Has(Bomb) || Has(Hammer))
            {
                can_blast_or_smash = true;
            }
            else
            {
                can_blast_or_smash = false;
            }
            //Longshot
            if (Hookshot.State == 2)
            {
                has_longshot = true;
            }
            else
            {
                has_longshot = false;
            }
            //Has Fire Source
            if (Has(Magic) && (Has(Dins) || (Has(Bow) && Has(FireArrow))))
            {
                has_firesource = true;
            }
            else
            {
                has_firesource = false;
            }
            //Can buy Goron Tunic or has it
            if (Has(GoronTunic) || (Has(Wallet) && (Has(ZeldasLullaby) || (Has(Bomb) || Has(Strength) || Has(Bow)))))
            {
                has_or_can_red_tunic = 1;
            }
            else
            {
                has_or_can_red_tunic = 0;
            }
            if (Has(GerudoCard) || Has(EponasSong) || has_longshot)
            {
                has_or_can_get_gerudocard = true;
            }
            else
            {
                has_or_can_get_gerudocard = false;
            }
            //Has Bottle
            if ((Has(RutoLetter) && (Has(Scales) || (Has(Bomb) && Has(ZeldasLullaby)))) || Has(Bottle2) || Has(Bottle3) || Has(Bottle4))
            {
                has_bottle = true;
            }
            else
            {
                has_bottle = false;
            }
            //Can get Beans
            if (Has(Bomb) || Has(Scales))
            {
                can_get_beans = true;
            }
            else
            {
                can_get_beans = false;
            }
            if (has_or_can_get_gerudocard && Has(Lens) && Has(Magic) && (Has(HoverBoots) || has_longshot))
            {
                wastelandcrossing = 1;
            }
            else
            {
                wastelandcrossing = 0;
            }
            if (Has(Reqiuem) || wastelandcrossing == 1)
            {
                desertaccess = 1;
            }
            else
            {
                desertaccess = 0;
            }
            if (Has(Bolero) || ((Has(Hookshot) || Has(HoverBoots)) && (Has(Bomb) || Has(Bow) || Has(Strength))))
            {
                craterplatformaccess = 1;
            }
            else
            {
                craterplatformaccess = 0;
            }
            //Rainbowbridge
            switch (Goalrequirement)
            {
                case "Medallions":
                    {
                        if (Has(ForestMedallion) && Has(FireMedallion) && Has(WaterMedallion) && Has(SpiritMedallion) && Has(ShadowMedallion) && Has(LightMedallion))
                        {
                            rainbowbridge = true;
                        }
                        else
                        {
                            rainbowbridge = false;
                        }
                        break;
                    }
                case "AD":
                    {
                        if (Has(ForestMedallion) && Has(FireMedallion) && Has(WaterMedallion) && Has(SpiritMedallion) && Has(ShadowMedallion) && Has(LightMedallion) && Has(KokiriStone) && Has(GoronStone) && Has(ZoraStone))
                        {
                            rainbowbridge = true;
                        }
                        else
                        {
                            rainbowbridge = false;
                        }
                        break;
                    }
                case "SGL":
                    {
                        if (Has(KokiriStone) && Has(GoronStone) && Has(ZoraStone))
                        {
                            rainbowbridge = true;
                        }
                        else
                        {
                            rainbowbridge = false;
                        }
                        break;
                    }
                case "Vanilla":
                    {
                        if (Has(SpiritMedallion) && Has(ShadowMedallion) && Has(LightArrow))
                        {
                            rainbowbridge = true;
                        }
                        else
                        {
                            rainbowbridge = false;
                        }
                        break;
                    }
            }
        }
    }
}
