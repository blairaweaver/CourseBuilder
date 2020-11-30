
namespace CourseBuilder
{
    partial class ForwardOutput
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
            this.availableTextBox = new System.Windows.Forms.TextBox();
            this.avaliableLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // availableTextBox
            // 
            this.availableTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.availableTextBox.Location = new System.Drawing.Point(49, 60);
            this.availableTextBox.Multiline = true;
            this.availableTextBox.Name = "availableTextBox";
            this.availableTextBox.ReadOnly = true;
            this.availableTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.availableTextBox.Size = new System.Drawing.Size(226, 258);
            this.availableTextBox.TabIndex = 0;
            this.availableTextBox.TabStop = false;
            // 
            // avaliableLabel
            // 
            this.avaliableLabel.AutoSize = true;
            this.avaliableLabel.Location = new System.Drawing.Point(49, 22);
            this.avaliableLabel.Name = "avaliableLabel";
            this.avaliableLabel.Size = new System.Drawing.Size(100, 15);
            this.avaliableLabel.TabIndex = 1;
            this.avaliableLabel.Text = "Avaliable Courses";
            // 
            // ForwardOutput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 378);
            this.Controls.Add(this.avaliableLabel);
            this.Controls.Add(this.availableTextBox);
            this.Name = "ForwardOutput";
            this.Text = "Forward Output";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox availableTextBox;
        private System.Windows.Forms.Label avaliableLabel;
    }
}