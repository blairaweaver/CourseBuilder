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
        public ForwardOutput(string output)
        {
            InitializeComponent();
            availableTextBox.Text = output;
        }
    }
}
