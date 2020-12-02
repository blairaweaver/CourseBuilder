
namespace CourseBuilder
{
    partial class BackwardOutput
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.eligibleLabel = new System.Windows.Forms.Label();
            this.eligibleTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // eligibleLabel
            // 
            this.eligibleLabel.AutoSize = true;
            this.eligibleLabel.Location = new System.Drawing.Point(41, 41);
            this.eligibleLabel.Name = "eligibleLabel";
            this.eligibleLabel.Size = new System.Drawing.Size(50, 15);
            this.eligibleLabel.TabIndex = 0;
            this.eligibleLabel.Text = "Eligible?";
            // 
            // eligibleTextBox
            // 
            this.eligibleTextBox.Location = new System.Drawing.Point(41, 83);
            this.eligibleTextBox.Multiline = true;
            this.eligibleTextBox.Name = "eligibleTextBox";
            this.eligibleTextBox.ReadOnly = true;
            this.eligibleTextBox.Size = new System.Drawing.Size(359, 141);
            this.eligibleTextBox.TabIndex = 1;
            this.eligibleTextBox.TabStop = false;
            // 
            // BackwardOutput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 283);
            this.Controls.Add(this.eligibleTextBox);
            this.Controls.Add(this.eligibleLabel);
            this.Name = "BackwardOutput";
            this.Text = "Backward Output";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label eligibleLabel;
        private System.Windows.Forms.TextBox eligibleTextBox;
    }
}