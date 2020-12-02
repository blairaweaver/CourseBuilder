using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CourseBuilder
{
    public partial class BackwardOutput : Form
    {
        public BackwardOutput()
        {
            InitializeComponent();
        }

        public void updateEligible(Rule? triggeredRule, string course)
        {
            string output = "";
            if(triggeredRule != null)
            {
                output += "Yes, " + triggeredRule.Course + " is eligible for the Spring because rule" + triggeredRule.RuleNumber + " and" + Environment.NewLine +
                    "Semester is " + triggeredRule.Semester + Environment.NewLine;
                foreach(string req in triggeredRule.Requirements)
                {
                    output += req + " was passed" + Environment.NewLine;
                }
            }
            else
            {
                output += "No, " + course + " is eligible for the Spring since not all requirements met";
            }

            eligibleTextBox.Text = output;
        }
    }
}
