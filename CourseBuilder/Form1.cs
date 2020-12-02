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
        List<string> Courses;
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
            string courseNumber = string.Concat(courseNumberMaskedTextBox.Text.Where(c => !char.IsWhiteSpace(c)));
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

            addToTranscript(courseComboBox.Text, courseNumber, (string)gradeComboBox.SelectedItem);

            //clear the fields
            courseComboBox.SelectedIndex = -1;
            courseNumberMaskedTextBox.Clear();
            gradeComboBox.SelectedIndex = -1;
        }

        //this will add course to transcript.
        //Moved this outside of the addButton so that the load file method can use it
        private void addToTranscript(string subject, string courseNumber, string grade)
        {
            //Add course to the transcript. Need to also send it to the controller
            //if the course has a grade of D or F, don't send to controller and add asterisk
            if (grade == "D" || grade == "F")
            {
                transcriptTextBox.Text += subject + " " + courseNumber + " " + grade + "*" + Environment.NewLine;
            }
            else
            {
                transcriptTextBox.Text += subject + " " + courseNumber + " " + grade + Environment.NewLine;
                //Since we are allowing the user to remove classes, lets not send courses to the controller till the user has started the search
                Courses.Add(subject + " " + courseNumber);
            }

            //add the course to the remove combo box
            removeComboBox.Items.Add(subject + " " + courseNumber);
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

            //clear the course field
            backMaskedTextBox.Clear();

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
            string[] workingstring = transcriptTextBox.Text.Split(Environment.NewLine);
            transcriptTextBox.Text = ""; //set to empty string
            for(int i = 0; i < workingstring.Length - 1; i++) //set to minus one to ignore the last line, which is blank
            {
                //skip the string to remove
                if(i == index)
                {
                    continue;
                }
                transcriptTextBox.Text += workingstring[i] + Environment.NewLine;
            }

        }

        //give the other classes access to modify the fall and spring textbox
        public void addJuniorCourses(string output, string Semester)
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

        //this will start the process for the deduction methods
        private void runButton_Click(object sender, EventArgs e)
        {
            if(forwardRadioButton.Checked)
            {
                controller.run();
            }
            else
            {
                //Since the maskedtextbox does allow for spaces and returns a string with spaces, remove spaces and check length
                string courseNumber = string.Concat(backMaskedTextBox.Text.Where(c => !Char.IsWhiteSpace(c)));
                if (courseNumber.Length != 4)
                {
                    MessageBox.Show("Please enter a full course number");
                    return;
                }
                string course = "CSCI " + courseNumber;
                controller.run(course);
            }
        }

        //This will fill out the junior schedule. This allows for the run button to be clicked several times
        private void fillScheduleButton_Click(object sender, EventArgs e)
        {
            controller.fillSchedule(Courses, memoryCheckBox.Checked);
        }

        //this will be used to load the courses from a text file.
        private void loadMenuItem_Click(object sender, EventArgs e)
        {
            //show the open dialog
            openFileDialog1.Filter = "Text Files|*.txt|All Files|*.*";
            openFileDialog1.Title = "Load Transcript";
            openFileDialog1.ShowDialog();

            //check if filename was given
            if (openFileDialog1.FileName != "")
            {
                //NEED TO LOAD THE TRANSCRIPT INTO THE PROGRAM!!

                //boolean to keep track of if there was and error
                bool error = false;

                //read file
                string fileText = System.IO.File.ReadAllText(openFileDialog1.FileName);

                //break into lines, which will be Subject, Course Number, and Grade
                string[] courses = fileText.Split(Environment.NewLine);

                //foreach line, break into subject, course number, and grade and then send to addToTranscrip
                foreach(string workingCourse in courses)
                {
                    string[] courseParts = workingCourse.Split(" ");

                    //check that the subject, course number, and grade all present.
                    //For time sake, won't check that input is valid. User can see the input on the screen and can remove if needed
                    if (courseParts.Length != 3)
                    {
                        error = true;
                        continue;
                    }

                    //send to addToTranscript
                    addToTranscript(courseParts[0], courseParts[1], courseParts[2]);
                }

                //if there was an error, inform the user
                if(error)
                {
                    MessageBox.Show("There was an error with 1 or more of your courses. Please review your file");
                }
            }
        }
    }
}
