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
        public void DrawSometimesPanel(Form1 formInstance)
        {
            Panel panel = new()
            {
                Name = "sometimesPanel",
                Size = sometimesSize,
                Location = sometimesLocation               
            };
            Label label = new()
            {
                Size = new Size(130, 20),
                Location = new Point(0, 0),
                Text = "Sometimes Hints",
                ForeColor = Color.White
            };
            formInstance.Controls.Add(panel);
            if (helplines)
            {
                panel.BorderStyle = BorderStyle.FixedSingle;
            }
            panel.Controls.Add(label);
            for (int i = 0; i < sometimesCount; i++)
            {    
                
                TextBox textBox = new()
                {
                    Size = new Size(129, 23),
                    BackColor = Color.Gray,
                    Location = new Point(0, (i * 30) + 20)
                };
                textBox.MouseDown += (sender, e) => DeleteWOTHText(textBox);               
                textBox.Name = "sometimesHint" + i;                               
                panel.Controls.Add(textBox);
                for (int j = 0; j < 1; j++)
                {
                    PictureBox gossipstone = new();
                    GossipStone(new Point((j * 30) + 134, (i * 30) + 20), gossipstone);
                    panel.Controls.Add(gossipstone);
                }
            }
        }
        public void CheckBoxClick(CheckBox Check)
        {           
            if (MouseButtons == MouseButtons.Right)
            {
                RightClickToTextboxes(Check.Text, Controls.Find("sometimesPanel", true).First());
            }
        }
        
    }
}
