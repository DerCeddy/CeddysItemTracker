using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeddysItemTracker
{
    public partial class Form1 : Form
    {    
        public void DrawRegionPanel(Panel forminstance, List<string> Region)
        {
            Panel panel = new()
            {
                Size = new Size(230, 240),
                Location = new Point(92, 240),
                Name = Region[0],
                AutoScroll = true,

            };
            Label label = new()
            {
                Text = Region[0],
                Location = new Point(0,0),
                Size = new Size(210,20),
                Font = new Font("Segoe UI", 12, FontStyle.Bold)
            };
            forminstance.Controls.Add(panel);
            panel.Controls.Add(label);
            panel.BringToFront();
            for(int i = 1; i < Region.Count; i++)
            {
                CheckBox cb = new()
                {
                    Text = Region[i],
                    Location = new Point(0, i * 30),
                    Size = new Size(210, 20),
                    ForeColor = Color.White,
                    Name = $"{Region[i]}"

                };
                panel.Controls.Add(cb);
                cb.MouseDown += (sender, e) => CheckBoxClick(cb);
                cb.MouseClick += (sender, e) => UpdateAllCountersOnClick();
            }

        }              
    }
}
