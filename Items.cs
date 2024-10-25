using CeddysItemTracker.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CeddysItemTracker
{
    public class Item : PictureBox
    {
        public int State;
        public PictureBox? ItemPictureBox;
        public required int MaxCount;
        public required int MinCount;
        public required Bitmap ItemPicture;
        public Bitmap? ItemPicture1;
        public Bitmap? ItemPicture2;
        public Bitmap? ItemPicture3;
        public Bitmap? ItemPicture_bw;     
    }
    public partial class Form1 : Form
    {
        public Item Bomb = new() { ItemPicture = Resources.OoT3D_Bomb_Icon, State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = Resources.OoT3D_Bomb_Icon_bw };
        public Item ZeldasLullaby = new() { ItemPicture = Resources.zeldas_lullaby_32x40, State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = Resources.zeldas_lullaby_bw_32x40 };
        public Item EponasSong = new() { ItemPicture = Resources.epona_32x40, State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = Resources.epona_bw_32x40 };
        public Item SariasSong = new() { ItemPicture = Resources.saria_32x40, State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = Resources.saria_bw_32x40 };
        public Item SunSong = new() { ItemPicture = Resources.suns_song_32x40, State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = Resources.suns_song_bw_32x40 };
        public Item SongOfTime = new() { ItemPicture = Resources.song_of_time_32x40, State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = Resources.song_of_time_bw_32x40 };
        public Item SongOfStorms = new() { ItemPicture = Resources.song_of_storms_32x40, State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = Resources.song_of_storms_bw_32x40 };
        public Item Minuet = new() { ItemPicture = Resources.minuet_32x40, State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = Resources.minuet_bw_32x40 };
        public Item Bolero = new() { ItemPicture = Resources.bolero_32x40, State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = Resources.bolero_bw_32x40 };
        public Item Serenade = new() { ItemPicture = Resources.serenade_32x40, State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = Resources.serenade_bw_32x40 };
        public Item Nocturne = new() { ItemPicture = Resources.nocturne_32x40, State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = Resources.nocturne_bw_32x40 };
        public Item Reqiuem = new() { ItemPicture = Resources.requiem_32x40, State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = Resources.requiem_bw_32x40 };
        public Item Prelude = new() { ItemPicture = Resources.prelude_32x40, State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = Resources.prelude_bw_32x40 };
        public Item Hammer = new() { ItemPicture = Resources.OoT3D_Megaton_Hammer_Icon, State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = Resources.OoT3D_Megaton_Hammer_Icon_bw };
        public Item Strength = new() { ItemPicture = Resources.OoT3D_Goron_Bracelet_Icon, State = 0, MaxCount = 3, MinCount = 0, ItemPicture_bw = Resources.OoT3D_Goron_Bracelet_Icon_bw, ItemPicture1 = Resources.OoT3D_Silver_Gauntlets_Icon, ItemPicture2 = Resources.OoT3D_Golden_Gauntlets_Icon };
        public Item Bow = new() { ItemPicture = Resources.OoT3D_Fairy_Bow_Icon, MaxCount = 1, MinCount = 0, State = 0, ItemPicture_bw = Resources.OoT3D_Fairy_Bow_Icon_bw };
        public Item Wallet = new() { ItemPicture = Resources.OoT3D_Adult_s_Wallet_Icon, ItemPicture_bw = Resources.OoT3D_Adult_s_Wallet_Icon_bw, ItemPicture1 = Resources.OoT3D_Giant_s_Wallet_Icon, MaxCount = 2, MinCount = 0, State = 0 };
        public Item Bottle2 = new() { ItemPicture = Resources.OoT3D_Bottle_Icon, State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = Resources.OoT3D_Bottle_Icon_bw };
        public Item Bottle3 = new() { ItemPicture = Resources.OoT3D_Bottle_Icon, State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = Resources.OoT3D_Bottle_Icon_bw };
        public Item Bottle4 = new() { ItemPicture = Resources.OoT3D_Bottle_Icon, State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = Resources.OoT3D_Bottle_Icon_bw };
        public Item BiggoronSword = new() { ItemPicture = Resources.OoT3D_Biggoron_s_Sword_Icon, State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = Resources.OoT3D_Biggoron_s_Sword_Icon_bw };
        public Item MasterSword = new() { ItemPicture = Resources.OoT3D_Master_Sword_Icon, State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = Resources.OoT3D_Master_Sword_Icon_bw };
        public Item KokiriSword = new() { ItemPicture = Resources.OoT3D_Kokiri_Sword_Icon, State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = Resources.OoT3D_Kokiri_Sword_Icon_bw };
        public Item Slingshot = new() { ItemPicture = Resources.OoT3D_Fairy_Slingshot_Icon, State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = Resources.OoT3D_Fairy_Slingshot_Icon_bw };
        public Item Boomerang = new() { ItemPicture = Resources.OoT3D_Boomerang_Icon, State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = Resources.OoT3D_Boomerang_Icon_bw };
        public Item Nuts = new() { ItemPicture = Resources.OoT3D_Deku_Nut_Icon, State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = Resources.OoT3D_Deku_Nut_Icon_bw };
        public Item Sticks = new() { ItemPicture = Resources.OoT3D_Deku_Stick_Icon, ItemPicture_bw = Resources.OoT3D_Deku_Stick_Icon_bw, State = 0, MaxCount = 1, MinCount = 0 };
        public Item AdultTradeItems = new() { ItemPicture = Resources.OoT3D_Prescription_Icon, ItemPicture_bw = Resources.OoT3D_Prescription_Icon_bw, State = 0, MaxCount = 4, MinCount = 0, ItemPicture1 = Resources.OoT3D_Eyeball_Frog_Icon, ItemPicture2 = Resources.OoT3D_World_s_Finest_Eyedrops_Icon, ItemPicture3 = Resources.OoT3D_Claim_Check_Icon };
        public Item ChildTradeItems = new() { ItemPicture = Resources.OoT3D_Keaton_Mask_Icon, ItemPicture1 = Resources.OoT3D_Skull_Mask_Icon, State = 0, MaxCount = 2, MinCount = 0, ItemPicture_bw = Resources.OoT3D_Keaton_Mask_Icon_bw };
        public Item Ocarina = new() { ItemPicture = Resources.OoT3D_Fairy_Ocarina_Icon, State = 0, MaxCount = 2, MinCount = 0, ItemPicture1 = Resources.OoT3D_Ocarina_of_Time_Icon, ItemPicture_bw = Resources.OoT3D_Fairy_Ocarina_Icon_bw };
        public Item Dins = new() { ItemPicture = Resources.OoT3D_Din_s_Fire_Icon, State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = Resources.OoT3D_Din_s_Fire_Icon_bw };
        public Item FaroresWind = new() { ItemPicture = Resources.OoT3D_Farore_s_Wind_Icon, State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = Resources.OoT3D_Farore_s_Wind_Icon_bw };
        public Item NayrusLove = new() { ItemPicture = Resources.OoT3D_Nayru_s_Love_Icon, State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = Resources.OoT3D_Nayru_s_Love_Icon_bw };
        public Item FireArrow = new() { ItemPicture = Resources.OoT3D_Fire_Arrow_Icon, State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = Resources.OoT3D_Fire_Arrow_Icon_bw };
        public Item IceArrow = new() { ItemPicture = Resources.OoT3D_Ice_Arrow_Icon, State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = Resources.OoT3D_Ice_Arrow_Icon_bw };
        public Item LightArrow = new() { ItemPicture = Resources.OoT3D_Light_Arrow_Icon, State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = Resources.OoT3D_Light_Arrow_Icon_bw };
        public Item Hookshot = new() { ItemPicture = Resources.OoT3D_Hookshot_Icon, ItemPicture1 = Resources.OoT3D_Longshot_Icon, State = 0, MaxCount = 2, MinCount = 0, ItemPicture_bw = Resources.OoT3D_Hookshot_Icon_bw };
        public Item DekuShield = new() { ItemPicture = Resources.OoT3D_Deku_Shield_Icon, State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = Resources.OoT3D_Deku_Shield_Icon_bw };
        public Item HylianShield = new() { ItemPicture = Resources.OoT3D_Hylian_Shield_Icon, State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = Resources.OoT3D_Hylian_Shield_Icon_bw };
        public Item MirrorShield = new() { ItemPicture = Resources.OoT3D_Mirror_Shield_Icon, State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = Resources.OoT3D_Mirror_Shield_Icon_bw };
        public Item KokiriBoots = new() { ItemPicture = Resources.OoT3D_Kokiri_Boots_Icon, State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = Resources.OoT3D_Kokiri_Boots_Icon_bw };
        public Item IronBoots = new() { ItemPicture = Resources.OoT3D_Iron_Boots_Icon, State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = Resources.OoT3D_Iron_Boots_Icon_bw };
        public Item HoverBoots = new() { ItemPicture = Resources.OoT3D_Hover_Boots_Icon, State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = Resources.OoT3D_Hover_Boots_Icon_bw };
        public Item KokiriTunic = new() { ItemPicture = Resources.OoT3D_Kokiri_Tunic_Icon, State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = Resources.OoT3D_Kokiri_Tunic_Icon_bw };
        public Item GoronTunic = new() { ItemPicture = Resources.OoT3D_Goron_Tunic_Icon, State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = Resources.OoT3D_Goron_Tunic_Icon_bw };
        public Item ZoraTunic = new() { ItemPicture = Resources.OoT3D_Zora_Tunic_Icon, State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = Resources.OoT3D_Zora_Tunic_Icon_bw };
        public Item Lens = new() { ItemPicture = Resources.OoT3D_Lens_of_Truth_Icon, State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = Resources.OoT3D_Lens_of_Truth_Icon_bw };
        public Item Scales = new() { ItemPicture = Resources.OoT3D_Silver_Scale_Icon, State = 0, MaxCount = 2, MinCount = 0, ItemPicture_bw = Resources.OoT3D_Silver_Scale_Icon_bw, ItemPicture1 = Resources.OoT3D_Golden_Scale_Icon };
        public Item Beans = new() { ItemPicture = Resources.OoT3D_Magic_Bean_Icon, State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = Resources.OoT3D_Magic_Bean_Icon_bw };
        public Item RutoLetter = new() { ItemPicture = Resources.OoT3D_Ruto_s_Letter_Icon, State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = Resources.OoT3D_Ruto_s_Letter_Icon_bw };
        public Item Bombchu = new() { ItemPicture = Resources.OoT3D_Bombchu_Icon, State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = Resources.OoT3D_Bombchu_Icon_bw };
        public Item GerudoCard = new() { ItemPicture = Resources.OoT3D_Gerudo_Token_Icon, State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = Resources.OoT3D_Gerudo_Token_Icon_bw };
        public Item Magic = new() { ItemPicture = Resources.Magic, State = 0, MaxCount = 2, MinCount = 0, ItemPicture1 = Resources.Magic2, ItemPicture_bw = Resources.Magic_BW };
        public Item ForestMedallion = new() { ItemPicture = Resources.OoT3D_Forest_Medallion_Icon, State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = Resources.OoT3D_Forest_Medallion_Icon_bw };
        public Item FireMedallion = new() { ItemPicture = Resources.OoT3D_Fire_Medallion_Icon, State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = Resources.OoT3D_Fire_Medallion_Icon_bw };
        public Item WaterMedallion = new() { ItemPicture = Resources.OoT3D_Water_Medallion_Icon, State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = Resources.OoT3D_Water_Medallion_Icon_bw };
        public Item ShadowMedallion = new() { ItemPicture = Resources.OoT3D_Shadow_Medallion_Icon, State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = Resources.OoT3D_Shadow_Medallion_Icon_bw };
        public Item SpiritMedallion = new() { ItemPicture = Resources.OoT3D_Spirit_Medallion_Icon, State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = Resources.OoT3D_Spirit_Medallion_Icon_bw };
        public Item LightMedallion = new() { ItemPicture = Resources.OoT3D_Light_Medallion_Icon, State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = Resources.OoT3D_Light_Medallion_Icon_bw };
        public Item KokiriStone = new() { ItemPicture = Resources.OoT3D_Spiritual_Stone_of_the_Forest_Icon, State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = Resources.OoT3D_Spiritual_Stone_of_the_Forest_Icon_bw };
        public Item GoronStone = new() { ItemPicture = Resources.OoT3D_Spiritual_Stone_of_Fire_Icon, State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = Resources.OoT3D_Spiritual_Stone_of_Fire_Icon_bw };
        public Item ZoraStone = new() { ItemPicture = Resources.OoT3D_Spiritual_Stone_of_Water_Icon, State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = Resources.OoT3D_Spiritual_Stone_of_Water_Icon_bw };
        public Item Agony = new() { ItemPicture = Resources.OoT3D_Shard_of_Agony_Icon, State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = Resources.OoT3D_Shard_of_Agony_Icon_bw };
        public Item DoubleDefense = new() { ItemPicture = Resources.OoT3D_Heart_Container_Icon, State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = Resources.OoT3D_Heart_Container_Icon_bw };
        public Item GoMode = new() { ItemPicture = Resources.go_mode_32x32, State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = Resources.go_mode_bw_32x32 };
        public Item ForestBossKey = new() {ItemPicture = Resources.OoT3D_Boss_Key_Icon, State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = Resources.OoT3D_Boss_Key_Icon_bw, };
        public Item FireBossKey = new() { ItemPicture = Resources.OoT3D_Boss_Key_Icon, State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = Resources.OoT3D_Boss_Key_Icon_bw, };
        public Item WaterBossKey = new() { ItemPicture = Resources.OoT3D_Boss_Key_Icon, State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = Resources.OoT3D_Boss_Key_Icon_bw, };
        public Item ShadowBossKey = new() { ItemPicture = Resources.OoT3D_Boss_Key_Icon, State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = Resources.OoT3D_Boss_Key_Icon_bw, };
        public Item SpiritBossKey = new() { ItemPicture = Resources.OoT3D_Boss_Key_Icon, State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = Resources.OoT3D_Boss_Key_Icon_bw, };
    }
}
