using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CourseBuilder
{
    public partial class WorkingMemory : Form
    {
        public WorkingMemory()
        {
            InitializeComponent();
        }

        public void addToOutput(List<string> output)
        {
            memoryTextBox.Text += "Snapshot" + Environment.NewLine;
            foreach(string course in output)
            {
                memoryTextBox.Text += course + Environment.NewLine;
            }
            memoryTextBox.Text += Environment.NewLine;
        }
    }
}
