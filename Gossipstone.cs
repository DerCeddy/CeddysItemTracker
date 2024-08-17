using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CeddysItemTracker.Properties;

namespace CeddysItemTracker
{
    public partial class Form1 : Form
    {
        public void GossipStone(Point point, PictureBox pictureBox)
        {
            pictureBox.Image = Resources.gossip_stone_bw_32x32;
            pictureBox.Size = new Size(24, 24);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Location = point;
            pictureBox.AllowDrop = true;
            pictureBox.MouseUp += ItemClickMouseUp;
            pictureBox.DragEnter += PictureBox2_DragEnter;
            pictureBox.DragDrop += (sender, e) => PictureBox2_DragDrop(e, pictureBox);
            pictureBox.MouseMove += (sender, e) => MouseMoveForDrag(e, pictureBox);
            pictureBox.MouseClick += (sender, e) => PathStone_Click(e, pictureBox);
            pictureBox.MouseDown += (sender, e) => Drag_MouseDown(e); 
            
        }             
    }
}
