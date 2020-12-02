using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CourseBuilder
{
    public partial class ForwardOutput : Form
    {
        List<Rule> ruleList;
        public ForwardOutput(List<Rule> rules)
        {
            ruleList = rules;
            InitializeComponent();
            fillForm();
        }

        private void fillForm()
        {
            foreach(Rule workingRule in ruleList)
            {
                availableTextBox.Text += workingRule.Course + Environment.NewLine;
                courseComboBox.Items.Add(workingRule.Course);
            }
        }

        private void explainButton_Click(object sender, EventArgs e)
        {
            //check to make sure something is selected
            if (courseComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a class that you would like to be explain");
                return;
            }

            //the rule used
            Rule rule = ruleList[courseComboBox.SelectedIndex];

            string output = "By using rule" + rule.RuleNumber + " and knowing that" + Environment.NewLine;

            List<string> requirements = rule.Requirements;

            foreach(string req in requirements)
            {
                output += req + " was passed" + Environment.NewLine;
            }

            explainTextBox.Text = output;
        }
    }
}
