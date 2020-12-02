
namespace CourseBuilder
{
    partial class WorkingMemory
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
            this.memoryTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // memoryTextBox
            // 
            this.memoryTextBox.Location = new System.Drawing.Point(12, 23);
            this.memoryTextBox.Multiline = true;
            this.memoryTextBox.Name = "memoryTextBox";
            this.memoryTextBox.ReadOnly = true;
            this.memoryTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.memoryTextBox.Size = new System.Drawing.Size(336, 400);
            this.memoryTextBox.TabIndex = 1;
            this.memoryTextBox.TabStop = false;
            // 
            // WorkingMemory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 442);
            this.Controls.Add(this.memoryTextBox);
            this.Name = "WorkingMemory";
            this.Text = "Working Memory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox memoryTextBox;
    }
}