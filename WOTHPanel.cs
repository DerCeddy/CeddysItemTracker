using CeddysItemTracker.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices.Marshalling;

namespace CeddysItemTracker
{
    public partial class Form1 : Form
    {
        public List<int> Goals = [];      
        public void DrawWOTHPanel(Form formInstance)
        {           
            Panel panel = new()
            {
                Name = "wothPanel",
                Size = wothSize,
                Location = wothLocation            
            };
            Label label = new()
            {
                Size = new Size(130, 20),
                Location = new Point(0, 0),
                Text = "Path Hints",
                ForeColor = Color.White
            };         
            formInstance.Controls.Add(panel);
            panel.Controls.Add(label); 
            if (helplines)
            {
                panel.BorderStyle = BorderStyle.FixedSingle;
            }          
            for (int i = 0; i < pathHintCount; i++)
            {
                Goals.Add(0);
                PictureBox goal = new()
                {
                    Image = Resources.unknown_32x32,
                    Location = new Point(0,(i * 30) + 20),
                    Size = new Size(24,24),
                    SizeMode = PictureBoxSizeMode.StretchImage
                };             
                TextBox textBox = new()
                {
                    Size = new Size(129, 23),
                    BackColor = Color.DeepSkyBlue,
                    Location = new Point(25, (i * 30) + 20)
                };
                var formId = i;
                panel.Controls.Add(goal);
                panel.Controls.Add(textBox);
                textBox.MouseDown += (sender,e) => DeleteWOTHText(textBox);
                goal.MouseDown += (sender,e) => GoalClick(e, goal, formId);
                goal.MouseWheel += (sender, e) => GoalScroll(e,goal,formId);             
                textBox.Name = "pathHint" + i;
                goal.Name = "Goal" + i;                             
                for (int j = 0; j < 4; j++)
                {
                    PictureBox gossipstone = new();
                    GossipStone(new Point((j * 30) + 154, (i * 30) + 20),gossipstone);
                    gossipstone.Name = "pathHintStone" + i;
                    panel.Controls.Add(gossipstone);                      
                }
            }   
            
        }
        public void GoalScroll(MouseEventArgs e,PictureBox BossImage, int i)
        {
            if (e.Delta < 0)
            {
                Goals[i] = LabelUP(Goals[i]);
               
            }
            if (e.Delta > 0)
            {
                Goals[i] = LabelDOWN(Goals[i]);

            }
            CheckGoalState(Goals[i], BossImage);        
        }
        public void GoalClick(MouseEventArgs e, PictureBox BossImage, int i)
        {
            if (e.Button == MouseButtons.Left)
            {
                Goals[i] = LabelUP(Goals[i]);

            }
            if (e.Button == MouseButtons.Right)
            {
                Goals[i] = LabelDOWN(Goals[i]);

            }
            CheckGoalState(Goals[i], BossImage);
        }      
        private static void CheckGoalState(int x, PictureBox Goal)
        {
            switch (x)
            {
                case -3:
                    Goal.Image = Resources.barinade_32x32;
                    break;
                case -2:
                    Goal.Image = Resources.dodongo_32x32;
                    break;
                case -1:
                    Goal.Image = Resources.gohma_32x32;
                    break;
                case 0:
                    Goal.Image = Resources.unknown_32x32;
                    break;
                case 1:
                    Goal.Image = Resources.pg_32x32;
                    break;
                case 2:
                    Goal.Image = Resources.volvagia_32x32;
                    break;
                case 3:
                    Goal.Image = Resources.morpha_32x32;
                    break;
                case 4:
                    Goal.Image = Resources.bongo_32x32;
                    break;
                case 5:
                    Goal.Image = Resources.twinrova_32x32;
                    break;
            }
        }      
        private void RightClickToTextboxes(string RegionName, Control control)
        {
            string LocationName = RegionName;

            foreach (Control c in control.Controls)
            {
                if (c is TextBox tb)
                {
                    if (tb.Text == string.Empty)
                    {
                        tb.Text = LocationName;
                        return;
                    }
                }               
            }
        }
        private static void DeleteWOTHText(TextBox Pathhint)
        {
            Pathhint.Text = string.Empty;
        }
    }
}
