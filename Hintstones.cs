using CeddysItemTracker.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeddysItemTracker
{
    public partial class Form1 : Form
    {
        private static void PathStone_Click(MouseEventArgs e, PictureBox PathStone)
        {
            if (e.Button == MouseButtons.Right)
            {
                PathStone.Image = Resources.gossip_stone_bw_32x32;
            }
            if (e.Button == MouseButtons.Left)
            {
                PathStone.Image = Resources.Soldout;
            }
        }
        public void PictureBox2_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
                e.Effect = DragDropEffects.Move;
        }

        static void PictureBox2_DragDrop(DragEventArgs e, PictureBox PathStone)
        {
            Bitmap bmp = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
            PathStone.Image = bmp;
        }
    }
}
