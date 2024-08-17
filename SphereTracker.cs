using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CeddysItemTracker.Properties;

namespace CeddysItemTracker
{
    public partial class Form1 : Form
    {      
            public void DrawSphereTracker(Panel panel, int Rows, int Columns)
            {
                for (int i = 0; i < Rows; i++)
                {
                    for (int j = 0; j < Columns; j++)
                    {
                        PictureBox Test = new ();
                        GossipStone(new Point(i * 30, j * 30), Test);                     
                        panel.Controls.Add(Test);
                    }
                }
            }    
    }
}
