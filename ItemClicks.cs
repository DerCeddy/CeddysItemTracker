using CeddysItemTracker.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CeddysItemTracker
{
    public partial class Form1 : Form
    {     
        public void ItemClick(object sender, MouseEventArgs e, Item Item)
        {
            if (e.Button == MouseButtons.Left)
            {
                Item.State = ValueUP(Item.State, Item.MaxCount);
            }
            if (e.Button == MouseButtons.Right)
            {
                Item.State = ValueDown(Item.State, Item.MinCount);
            }
            CheckItemState(Item);
            ItemLogic();
            UpdateAllCountersOnClick();
            Update_Rupee_Counter();
        }
        public void Drag_MouseDown(MouseEventArgs e, Item Item)
        {
            if (e.Button == MouseButtons.Left)
            {
                IsDragging = true;
                PreviousMousePos = e.Location;
                PreviousItemState = Item.State;
            }
        }
        public void Drag_MouseDown(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                IsDragging = true;
                PreviousMousePos = e.Location;
            }
        }
        public void ItemClickMouseUp(object sender, MouseEventArgs e)
        {
            if (IsDragging)
            {
                IsDragging = false;
            }
        }       
        public static void CheckItemState(Item Test)
        {
            switch (Test.State)
            {
                case 0:
                    Test.ItemPictureBox.Image = Test.ItemPicture_bw;
                    break;
                case 1:
                    Test.ItemPictureBox.Image = Test.ItemPicture;
                    break;
                case 2:
                    Test.ItemPictureBox.Image = Test.ItemPicture1;
                    break;
                case 3:
                    Test.ItemPictureBox.Image = Test.ItemPicture2;
                    break;
                case 4:
                    Test.ItemPictureBox.Image = Test.ItemPicture3;
                    break;
            }
        }      
        public static int ValueUP(int x, int MaxCount)
        {
            x++;
            if (x > MaxCount)
            { x = MaxCount; }
            return x;
        }
        public static int ValueDown(int x, int LowestCount)
        {
            x--;
            if (x < LowestCount)
            { x = LowestCount; }
            return x;
        }
        private void MouseMoveForDrag(object sender, MouseEventArgs e, Item Item)
        {
            if (IsDragging)
            {
                if ((System.Math.Abs(e.X - PreviousMousePos.X) > 10) || (System.Math.Abs(e.Y - PreviousMousePos.Y) > 10))
                {
                    if (Item.MaxCount > PreviousItemState)
                    {
                        Item.State--;
                        ItemLogic();
                        UpdateAllCountersOnClick();
                        switch (Item.State)
                        {
                            case 0:
                                Item.ItemPictureBox.Image = Item.ItemPicture_bw;
                                break;
                            case 1:
                                Item.ItemPictureBox.Image = Item.ItemPicture;
                                break;
                            case 2:
                                Item.ItemPictureBox.Image = Item.ItemPicture1;
                                break;
                            case 3:
                                Item.ItemPictureBox.Image = Item.ItemPicture2;
                                break;
                        }

                    }
                    DragAndDrop(Item);
                }
            }
        }
        private void MouseMoveForDrag(MouseEventArgs e, PictureBox p)
        {
            if (IsDragging)
            {
                if ((System.Math.Abs(e.X - PreviousMousePos.X) > 10) || (System.Math.Abs(e.Y - PreviousMousePos.Y) > 10))
                { 
                    
                    DragAndDrop(p);
                }
            }
        }
        private void DragAndDrop(Item Item)
        {
            IsDragging = false;
            var img = Item.ItemPicture;
            if (img == null) return;
            DoDragDrop(img, DragDropEffects.Move);
        }
        private void DragAndDrop(PictureBox pb)
        {
            IsDragging = false;
            var img = pb.Image;
            if (img == null) return;
            pb.Image = Resources.gossip_stone_bw_32x32;
            DoDragDrop(img, DragDropEffects.Move);
        }     
        private void TokenPictureBox_Click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                tokens = TokenUp(tokens);
            }
            else if (e.Button == MouseButtons.Right)
            {
                tokens = TokenDown(tokens);
            }
            tokenCounterDisplay.Text = tokens.ToString();
            ItemLogic();
        }
        private void TokenScroll(object sender, MouseEventArgs e)
        {
            if (e.Delta < 0)
            {
                tokens = TokenUp(tokens);
            }
            else
            {
                tokens = TokenDown(tokens);
            }
            tokenCounterDisplay.Text = tokens.ToString();
        }
        public static int TokenUp(int x)
        {
            x++;
            if (x > 100)
            { x = 100; }
            return x;
        }
        public static int TokenDown(int x)
        {
            x--;
            if (x < 0)
            { x = 0; }
            return x;
        }
    }
}
