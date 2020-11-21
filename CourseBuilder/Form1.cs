using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseBuilder
{
    public partial class Form1 : Form
    {
        private Controller controller;
        public Form1()
        {
            controller = new Controller();
            InitializeComponent();

            //tooltips to help the user
            courseNumberMaskedTextBox.MaskInputRejected += new MaskInputRejectedEventHandler(courseMaskBox_InputRejected);
            gradeMaskedTextBox.MaskInputRejected += new MaskInputRejectedEventHandler(gradeMaskBox_InputRejected);
            //hide tooltips
            courseNumberMaskedTextBox.KeyDown += new KeyEventHandler(courseMaskBox_KeyDown);
            gradeMaskedTextBox.KeyDown += new KeyEventHandler(gradeMaskBox_KeyDown);
        }

        //function to add courses when add button is clicked
        private void addButton_Click(object sender, EventArgs e)
        {
            //first check that the inputs are valid
            //Then add the course

            //Check and see if a subject is selected
            if (courseComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select the Subject");
            }

            //Since the maskedtextbox does allow for spaces and returns a string with spaces, remove spaces and check length
            String courseNumber = String.Concat(courseNumberMaskedTextBox.Text.Where(c => !Char.IsWhiteSpace(c)));
            if (courseNumber.Length != 4)
            {
                MessageBox.Show("Please enter a full course number");
            }

            //see if something is in the textbox
            if (gradeMaskedTextBox.Text.Length != 1)
            {
                MessageBox.Show("Please add a grade");
            }

            //check and see if it is a valid input
            if (!validGrade(gradeMaskedTextBox.Text[0]))
            {
                MessageBox.Show("Please insert a valid grade");
            }
        }

        //clear the course field when clear button is clicked
        private void clearButton_Click(object sender, EventArgs e)
        {
            courseComboBox.SelectedIndex = -1;
            courseNumberMaskedTextBox.Clear();
            gradeMaskedTextBox.Clear();
        }

        //check if the char for grade is valid and returns bool
        private bool validGrade(char grade)
        {
            return ('A' == grade || 'B' == grade || 'C' == grade || 'D' == grade || 'F' == grade);
        }

        //tooltips for the masked text boxes
        void courseMaskBox_InputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (courseNumberMaskedTextBox.MaskFull)
            {
                toolTip1.ToolTipTitle = "Input Rejected - Too Much Data";
                toolTip1.Show("You cannot enter any more data into the date field. Delete some characters in order to insert more data.", courseNumberMaskedTextBox, 0, 20, 5000);
            }
            else if (e.Position == courseNumberMaskedTextBox.Mask.Length)
            {
                toolTip1.ToolTipTitle = "Input Rejected - End of Field";
                toolTip1.Show("You cannot add extra characters to the end of this date field.", courseNumberMaskedTextBox, 0, 20, 5000);
            }
            else
            {
                toolTip1.ToolTipTitle = "Input Rejected";
                toolTip1.Show("You can only add numeric characters (0-9) into this date field.", courseNumberMaskedTextBox, 0, 20, 5000);
            }
        }

        void gradeMaskBox_InputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (gradeMaskedTextBox.MaskFull)
            {
                toolTip1.ToolTipTitle = "Input Rejected - Too Much Data";
                toolTip1.Show("You cannot enter any more data into the date field. Delete some characters in order to insert more data.", gradeMaskedTextBox, 0, 20, 5000);
            }
            else if (e.Position == gradeMaskedTextBox.Mask.Length)
            {
                toolTip1.ToolTipTitle = "Input Rejected - End of Field";
                toolTip1.Show("You cannot add extra characters to the end of this date field.", gradeMaskedTextBox, 0, 20, 5000);
            }
            else
            {
                toolTip1.ToolTipTitle = "Input Rejected";
                toolTip1.Show("You can only add Alphabetic characters (A-D & F) into this date field.", gradeMaskedTextBox, 0, 20, 5000);
            }
        }

        //hide tooltips once user has pressed a key
        void courseMaskBox_KeyDown(object sender, KeyEventArgs e)
        {
            // The balloon tip is visible for five seconds; if the user types any data before it disappears, collapse it ourselves.
            toolTip1.Hide(courseNumberMaskedTextBox);
        }

        void gradeMaskBox_KeyDown(object sender, KeyEventArgs e)
        {
            // The balloon tip is visible for five seconds; if the user types any data before it disappears, collapse it ourselves.
            toolTip1.Hide(gradeMaskedTextBox);
        }
    }
}
