namespace CourseBuilder
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.subjectLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addButton = new System.Windows.Forms.Button();
            this.courseComboBox = new System.Windows.Forms.ComboBox();
            this.courseNumberLabel = new System.Windows.Forms.Label();
            this.courseNumberMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.gradeLabel = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.gradeComboBox = new System.Windows.Forms.ComboBox();
            this.transcriptTextBox = new System.Windows.Forms.TextBox();
            this.endButton = new System.Windows.Forms.Button();
            this.transcriptLabel = new System.Windows.Forms.Label();
            this.removeComboBox = new System.Windows.Forms.ComboBox();
            this.removeButton = new System.Windows.Forms.Button();
            this.removeLabel = new System.Windows.Forms.Label();
            this.runButton = new System.Windows.Forms.Button();
            this.forwardRadioButton = new System.Windows.Forms.RadioButton();
            this.backwardRadioButton = new System.Windows.Forms.RadioButton();
            this.fallLabel = new System.Windows.Forms.Label();
            this.fallTextBox = new System.Windows.Forms.TextBox();
            this.springLabel = new System.Windows.Forms.Label();
            this.springTextBox = new System.Windows.Forms.TextBox();
            this.backMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.backCourseLabel = new System.Windows.Forms.Label();
            this.csciLable = new System.Windows.Forms.Label();
            this.loadMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // subjectLabel
            // 
            this.subjectLabel.AutoSize = true;
            this.subjectLabel.Location = new System.Drawing.Point(28, 29);
            this.subjectLabel.Name = "subjectLabel";
            this.subjectLabel.Size = new System.Drawing.Size(46, 15);
            this.subjectLabel.TabIndex = 0;
            this.subjectLabel.Text = "Subject";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(791, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(353, 62);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 7;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // courseComboBox
            // 
            this.courseComboBox.FormattingEnabled = true;
            this.courseComboBox.Items.AddRange(new object[] {
            "COMM",
            "CSCI",
            "MATH",
            "STAT"});
            this.courseComboBox.Location = new System.Drawing.Point(28, 62);
            this.courseComboBox.Name = "courseComboBox";
            this.courseComboBox.Size = new System.Drawing.Size(121, 23);
            this.courseComboBox.TabIndex = 3;
            // 
            // courseNumberLabel
            // 
            this.courseNumberLabel.AutoSize = true;
            this.courseNumberLabel.Location = new System.Drawing.Point(168, 29);
            this.courseNumberLabel.Name = "courseNumberLabel";
            this.courseNumberLabel.Size = new System.Drawing.Size(91, 15);
            this.courseNumberLabel.TabIndex = 4;
            this.courseNumberLabel.Text = "Course Number";
            // 
            // courseNumberMaskedTextBox
            // 
            this.courseNumberMaskedTextBox.Location = new System.Drawing.Point(168, 61);
            this.courseNumberMaskedTextBox.Mask = "0000";
            this.courseNumberMaskedTextBox.Name = "courseNumberMaskedTextBox";
            this.courseNumberMaskedTextBox.Size = new System.Drawing.Size(100, 23);
            this.courseNumberMaskedTextBox.TabIndex = 5;
            // 
            // gradeLabel
            // 
            this.gradeLabel.AutoSize = true;
            this.gradeLabel.Location = new System.Drawing.Point(288, 29);
            this.gradeLabel.Name = "gradeLabel";
            this.gradeLabel.Size = new System.Drawing.Size(38, 15);
            this.gradeLabel.TabIndex = 7;
            this.gradeLabel.Text = "Grade";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(434, 62);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 8;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // gradeComboBox
            // 
            this.gradeComboBox.FormattingEnabled = true;
            this.gradeComboBox.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "F"});
            this.gradeComboBox.Location = new System.Drawing.Point(288, 60);
            this.gradeComboBox.Name = "gradeComboBox";
            this.gradeComboBox.Size = new System.Drawing.Size(38, 23);
            this.gradeComboBox.TabIndex = 6;
            // 
            // transcriptTextBox
            // 
            this.transcriptTextBox.Location = new System.Drawing.Point(554, 50);
            this.transcriptTextBox.Multiline = true;
            this.transcriptTextBox.Name = "transcriptTextBox";
            this.transcriptTextBox.ReadOnly = true;
            this.transcriptTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.transcriptTextBox.Size = new System.Drawing.Size(192, 110);
            this.transcriptTextBox.TabIndex = 10;
            this.transcriptTextBox.TabStop = false;
            this.transcriptTextBox.MouseHover += new System.EventHandler(this.transcriptTextBox_MouseHover);
            // 
            // endButton
            // 
            this.endButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.endButton.Location = new System.Drawing.Point(288, 479);
            this.endButton.Name = "endButton";
            this.endButton.Size = new System.Drawing.Size(198, 45);
            this.endButton.TabIndex = 11;
            this.endButton.Text = "End Session";
            this.endButton.UseVisualStyleBackColor = true;
            this.endButton.Click += new System.EventHandler(this.endButton_Click);
            // 
            // transcriptLabel
            // 
            this.transcriptLabel.AutoSize = true;
            this.transcriptLabel.Location = new System.Drawing.Point(554, 28);
            this.transcriptLabel.Name = "transcriptLabel";
            this.transcriptLabel.Size = new System.Drawing.Size(58, 15);
            this.transcriptLabel.TabIndex = 12;
            this.transcriptLabel.Text = "Transcript";
            // 
            // removeComboBox
            // 
            this.removeComboBox.FormattingEnabled = true;
            this.removeComboBox.Location = new System.Drawing.Point(28, 137);
            this.removeComboBox.Name = "removeComboBox";
            this.removeComboBox.Size = new System.Drawing.Size(240, 23);
            this.removeComboBox.TabIndex = 13;
            this.removeComboBox.MouseHover += new System.EventHandler(this.removeComboBox_MouseHover);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(353, 137);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(75, 23);
            this.removeButton.TabIndex = 14;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // removeLabel
            // 
            this.removeLabel.AutoSize = true;
            this.removeLabel.Location = new System.Drawing.Point(28, 116);
            this.removeLabel.Name = "removeLabel";
            this.removeLabel.Size = new System.Drawing.Size(104, 15);
            this.removeLabel.TabIndex = 15;
            this.removeLabel.Text = "Course to Remove";
            // 
            // runButton
            // 
            this.runButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.runButton.Location = new System.Drawing.Point(52, 480);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(117, 44);
            this.runButton.TabIndex = 16;
            this.runButton.Text = "Run";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // forwardRadioButton
            // 
            this.forwardRadioButton.AutoSize = true;
            this.forwardRadioButton.Checked = true;
            this.forwardRadioButton.Location = new System.Drawing.Point(52, 406);
            this.forwardRadioButton.Name = "forwardRadioButton";
            this.forwardRadioButton.Size = new System.Drawing.Size(119, 19);
            this.forwardRadioButton.TabIndex = 17;
            this.forwardRadioButton.TabStop = true;
            this.forwardRadioButton.Text = "Forward Chaining";
            this.forwardRadioButton.UseVisualStyleBackColor = true;
            // 
            // backwardRadioButton
            // 
            this.backwardRadioButton.AutoSize = true;
            this.backwardRadioButton.Location = new System.Drawing.Point(288, 406);
            this.backwardRadioButton.Name = "backwardRadioButton";
            this.backwardRadioButton.Size = new System.Drawing.Size(127, 19);
            this.backwardRadioButton.TabIndex = 18;
            this.backwardRadioButton.Text = "Backward Chaining";
            this.backwardRadioButton.UseVisualStyleBackColor = true;
            // 
            // fallLabel
            // 
            this.fallLabel.AutoSize = true;
            this.fallLabel.Location = new System.Drawing.Point(44, 202);
            this.fallLabel.Name = "fallLabel";
            this.fallLabel.Size = new System.Drawing.Size(76, 15);
            this.fallLabel.TabIndex = 20;
            this.fallLabel.Text = "Fall Semester";
            // 
            // fallTextBox
            // 
            this.fallTextBox.Location = new System.Drawing.Point(44, 220);
            this.fallTextBox.Multiline = true;
            this.fallTextBox.Name = "fallTextBox";
            this.fallTextBox.ReadOnly = true;
            this.fallTextBox.Size = new System.Drawing.Size(192, 110);
            this.fallTextBox.TabIndex = 19;
            this.fallTextBox.TabStop = false;
            // 
            // springLabel
            // 
            this.springLabel.AutoSize = true;
            this.springLabel.Location = new System.Drawing.Point(333, 198);
            this.springLabel.Name = "springLabel";
            this.springLabel.Size = new System.Drawing.Size(92, 15);
            this.springLabel.TabIndex = 22;
            this.springLabel.Text = "Srping Semester";
            // 
            // springTextBox
            // 
            this.springTextBox.Location = new System.Drawing.Point(333, 220);
            this.springTextBox.Multiline = true;
            this.springTextBox.Name = "springTextBox";
            this.springTextBox.ReadOnly = true;
            this.springTextBox.Size = new System.Drawing.Size(192, 110);
            this.springTextBox.TabIndex = 21;
            this.springTextBox.TabStop = false;
            // 
            // backMaskedTextBox
            // 
            this.backMaskedTextBox.Location = new System.Drawing.Point(489, 405);
            this.backMaskedTextBox.Mask = "0000";
            this.backMaskedTextBox.Name = "backMaskedTextBox";
            this.backMaskedTextBox.Size = new System.Drawing.Size(100, 23);
            this.backMaskedTextBox.TabIndex = 24;
            // 
            // backCourseLabel
            // 
            this.backCourseLabel.AutoSize = true;
            this.backCourseLabel.Location = new System.Drawing.Point(489, 387);
            this.backCourseLabel.Name = "backCourseLabel";
            this.backCourseLabel.Size = new System.Drawing.Size(91, 15);
            this.backCourseLabel.TabIndex = 23;
            this.backCourseLabel.Text = "Course Number";
            // 
            // csciLable
            // 
            this.csciLable.AutoSize = true;
            this.csciLable.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.csciLable.Location = new System.Drawing.Point(437, 408);
            this.csciLable.Name = "csciLable";
            this.csciLable.Size = new System.Drawing.Size(43, 21);
            this.csciLable.TabIndex = 25;
            this.csciLable.Text = "CSCI";
            // 
            // loadMenuItem
            // 
            this.loadMenuItem.Name = "loadMenuItem";
            this.loadMenuItem.Size = new System.Drawing.Size(45, 20);
            this.loadMenuItem.Text = "&Load";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 567);
            this.Controls.Add(this.csciLable);
            this.Controls.Add(this.backMaskedTextBox);
            this.Controls.Add(this.backCourseLabel);
            this.Controls.Add(this.springLabel);
            this.Controls.Add(this.springTextBox);
            this.Controls.Add(this.fallLabel);
            this.Controls.Add(this.fallTextBox);
            this.Controls.Add(this.backwardRadioButton);
            this.Controls.Add(this.forwardRadioButton);
            this.Controls.Add(this.runButton);
            this.Controls.Add(this.removeLabel);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.removeComboBox);
            this.Controls.Add(this.transcriptLabel);
            this.Controls.Add(this.endButton);
            this.Controls.Add(this.transcriptTextBox);
            this.Controls.Add(this.gradeComboBox);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.gradeLabel);
            this.Controls.Add(this.courseNumberMaskedTextBox);
            this.Controls.Add(this.courseNumberLabel);
            this.Controls.Add(this.courseComboBox);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.subjectLabel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "AI Advisor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label subjectLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ComboBox courseComboBox;
        private System.Windows.Forms.Label courseNumberLabel;
        private System.Windows.Forms.MaskedTextBox courseNumberMaskedTextBox;
        private System.Windows.Forms.Label gradeLabel;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ComboBox gradeComboBox;
        private System.Windows.Forms.TextBox transcriptTextBox;
        private System.Windows.Forms.Button endButton;
        private System.Windows.Forms.Label transcriptLabel;
        private System.Windows.Forms.ComboBox removeComboBox;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Label removeLabel;
        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.RadioButton forwardRadioButton;
        private System.Windows.Forms.RadioButton backwardRadioButton;
        private System.Windows.Forms.Label fallLabel;
        private System.Windows.Forms.TextBox fallTextBox;
        private System.Windows.Forms.Label springLabel;
        private System.Windows.Forms.TextBox springTextBox;
        private System.Windows.Forms.MaskedTextBox backMaskedTextBox;
        private System.Windows.Forms.Label backCourseLabel;
        private System.Windows.Forms.Label csciLable;
        private System.Windows.Forms.ToolStripMenuItem loadMenuItem;
    }
}

