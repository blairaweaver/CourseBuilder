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
            this.subjectLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addButton = new System.Windows.Forms.Button();
            this.courseComboBox = new System.Windows.Forms.ComboBox();
            this.courseNumberLabel = new System.Windows.Forms.Label();
            this.courseNumberMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.gradeMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.gradeLabel = new System.Windows.Forms.Label();
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
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(418, 62);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // courseComboBox
            // 
            this.courseComboBox.FormattingEnabled = true;
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
            this.courseNumberMaskedTextBox.Name = "courseNumberMaskedTextBox";
            this.courseNumberMaskedTextBox.Size = new System.Drawing.Size(100, 23);
            this.courseNumberMaskedTextBox.TabIndex = 5;
            // 
            // gradeMaskedTextBox
            // 
            this.gradeMaskedTextBox.Location = new System.Drawing.Point(288, 61);
            this.gradeMaskedTextBox.Name = "gradeMaskedTextBox";
            this.gradeMaskedTextBox.Size = new System.Drawing.Size(100, 23);
            this.gradeMaskedTextBox.TabIndex = 6;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gradeLabel);
            this.Controls.Add(this.gradeMaskedTextBox);
            this.Controls.Add(this.courseNumberMaskedTextBox);
            this.Controls.Add(this.courseNumberLabel);
            this.Controls.Add(this.courseComboBox);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.subjectLabel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
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
        private System.Windows.Forms.MaskedTextBox gradeMaskedTextBox;
        private System.Windows.Forms.Label gradeLabel;
    }
}

