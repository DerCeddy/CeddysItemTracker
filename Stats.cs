using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeddysItemTracker
{
    public partial class Form1 : Form
    {       
        private void UpdateChecks()
        {
            remainingChecks = 0;
            availableChecks = 0;
            checkedchecks = 0;
            foreach (Control c in maptracker.Controls)
            {
                if (c is Panel pn)
                {
                    foreach (Control c1 in pn.Controls)
                    {
                        CheckBox cb = c1 as CheckBox;
                        if (cb != null && cb.Checked == false)
                        {
                            remainingChecks++;
                        }
                        if (cb != null && cb.Checked == true)
                        {
                            checkedchecks++;
                        }
                        if (cb != null && cb.Checked == false && (cb.ForeColor == Color.Lime || cb.ForeColor == coulddo))
                        {
                            availableChecks++;
                        }
                    }
                }
            }
            string remaining = remainingChecks.ToString();
            string checkedChecks = checkedchecks.ToString();
            string available = availableChecks.ToString();
            checksdone_label.Text = $"{checkedChecks}";
            checksremaining_label.Text = $"{remaining}";
            availablechecks_label.Text = $"{available}";
        }
        public void TimerUpdate(object sender, EventArgs e)
        {
            time++;
            cph_label.Text = $"{Math.Round((checkedchecks / time * 60 * 60))} cph";
        }
    }
}
