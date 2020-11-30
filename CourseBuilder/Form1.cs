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
        List<String> Courses;
        public Form1()
        {
            controller = new Controller(this);
            Courses = new List<string>();
            InitializeComponent();

            //tooltips to help the user
            courseNumberMaskedTextBox.MaskInputRejected += new MaskInputRejectedEventHandler(courseMaskBox_InputRejected);
            //hide tooltips
            courseNumberMaskedTextBox.KeyDown += new KeyEventHandler(courseMaskBox_KeyDown);

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
                return;
            }

            //Since the maskedtextbox does allow for spaces and returns a string with spaces, remove spaces and check length
            String courseNumber = String.Concat(courseNumberMaskedTextBox.Text.Where(c => !Char.IsWhiteSpace(c)));
            if (courseNumber.Length != 4)
            {
                MessageBox.Show("Please enter a full course number");
                return;
            }

            //Check and see if a grade is selected
            if (gradeComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select the Grade");
                return;
            }

            //Add course to the transcript. Need to also send it to the controller
            //if the course has a grade of D or F, don't send to controller and add asterisk
            if ((String)gradeComboBox.SelectedItem == "D" || (String)gradeComboBox.SelectedItem == "F")
            {
                transcriptTextBox.Text += courseComboBox.Text + " " + courseNumber + " " + gradeComboBox.Text + "*" + Environment.NewLine;
            }
            else
            {
                transcriptTextBox.Text += courseComboBox.Text + " " + courseNumber + " " + gradeComboBox.Text + Environment.NewLine;
                //Since we are allowing the user to remove classes, lets not send courses to the controller till the user has started the search
                Courses.Add(courseComboBox.Text + " " + courseNumber);
            }

            //add the course to the remove combo box
            removeComboBox.Items.Add(courseComboBox.Text + " " + courseNumber);

            //clear the fields
            courseComboBox.SelectedIndex = -1;
            courseNumberMaskedTextBox.Clear();
            gradeComboBox.SelectedIndex = -1;
        }

        //clear the course field when clear button is clicked
        private void clearButton_Click(object sender, EventArgs e)
        {
            courseComboBox.SelectedIndex = -1;
            courseNumberMaskedTextBox.Clear();
            gradeComboBox.SelectedIndex = -1;
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

        //show tooltip explaining the asterisk when the user hovers over the textbox
        void transcriptTextBox_MouseHover(object sender, EventArgs e)
        {
            toolTip1.ToolTipTitle = "Information";
            toolTip1.Show("The * indicates classes that need to be retaken.", transcriptTextBox, 0, 108, 5000); //if change the height of the textbox, change the second number
        }

        //show tooltip explaining the removeComboBox
        void removeComboBox_MouseHover(object sender, EventArgs e)
        {
            toolTip1.ToolTipTitle = "Information";
            toolTip1.Show("The selected class can be removed before clicking run if there is a mistake", removeComboBox, 0, 20, 5000); //if change the height of the textbox, change the second number
        }

        //hide tooltips once user has pressed a key
        void courseMaskBox_KeyDown(object sender, KeyEventArgs e)
        {
            // The balloon tip is visible for five seconds; if the user types any data before it disappears, collapse it ourselves.
            toolTip1.Hide(courseNumberMaskedTextBox);
        }

        //this will reset the program
        private void endButton_Click(object sender, EventArgs e)
        {
            //clear the transcript box
            transcriptTextBox.Clear();

            //clear the junior semester boxes
            fallTextBox.Clear();
            springTextBox.Clear();

            //clear the remove combobox
            removeComboBox.Items.Clear();

            //Need to tell the controller that the session has ended
            controller.endSession();
        }

        //allows the user to remove a class from the transcript if there is an error
        private void removeButton_Click(object sender, EventArgs e)
        {
            //check to make sure something is selected
            if(removeComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a class that you would like to remove");
                return;
            }

            //just to make sure the index doesn't make an issue when changing the combo box
            //set to variable
            int index = removeComboBox.SelectedIndex;

            //remove the course from the list
            //should be the same index since added at the same time
            Courses.RemoveAt(index);

            //remove from the combo box and reset combobox
            removeComboBox.SelectedIndex = -1;
            removeComboBox.Items.RemoveAt(index);

            //remove the course from the textbox
            //will need to conver to array and then put back to the textbox while skipping the one to remove
            String[] workingString = transcriptTextBox.Text.Split(Environment.NewLine);
            transcriptTextBox.Text = ""; //set to empty string
            for(int i = 0; i < workingString.Length - 1; i++) //set to minus one to ignore the last line, which is blank
            {
                //skip the string to remove
                if(i == index)
                {
                    continue;
                }
                transcriptTextBox.Text += workingString[i] + Environment.NewLine;
            }

        }

        //give the other classes access to modify the fall and spring textbox
        public void addJuniorCourses(String output, String Semester)
        {
            if(Semester == "F")
            {
                fallTextBox.Text = output;
            }
            else
            {
                springTextBox.Text = output;
            }
        }

        //this will start the process.
        //There is still a lot to write and then add here
        //ex deduction methods, eplanation module
        private void runButton_Click(object sender, EventArgs e)
        {
            controller.run(Courses);
        }
    }
}
