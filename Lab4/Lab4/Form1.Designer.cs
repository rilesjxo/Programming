namespace Lab4
{
    partial class Form1
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
            this.gpaLabel = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.gpaTextBox = new System.Windows.Forms.TextBox();
            this.scoreTextBox = new System.Windows.Forms.TextBox();
            this.outputLabel = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.acceptedLabel = new System.Windows.Forms.Label();
            this.rejectedLabel = new System.Windows.Forms.Label();
            this.acceptedCount = new System.Windows.Forms.Label();
            this.rejectedCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gpaLabel
            // 
            this.gpaLabel.AutoSize = true;
            this.gpaLabel.Location = new System.Drawing.Point(84, 74);
            this.gpaLabel.Name = "gpaLabel";
            this.gpaLabel.Size = new System.Drawing.Size(93, 13);
            this.gpaLabel.TabIndex = 0;
            this.gpaLabel.Text = "High School GPA:";
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Location = new System.Drawing.Point(65, 101);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(112, 13);
            this.scoreLabel.TabIndex = 1;
            this.scoreLabel.Text = "Admission Test Score:";
            // 
            // gpaTextBox
            // 
            this.gpaTextBox.Location = new System.Drawing.Point(183, 71);
            this.gpaTextBox.Name = "gpaTextBox";
            this.gpaTextBox.Size = new System.Drawing.Size(100, 20);
            this.gpaTextBox.TabIndex = 2;
            // 
            // scoreTextBox
            // 
            this.scoreTextBox.Location = new System.Drawing.Point(183, 98);
            this.scoreTextBox.Name = "scoreTextBox";
            this.scoreTextBox.Size = new System.Drawing.Size(100, 20);
            this.scoreTextBox.TabIndex = 3;
            // 
            // outputLabel
            // 
            this.outputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.Location = new System.Drawing.Point(117, 207);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(117, 36);
            this.outputLabel.TabIndex = 4;
            this.outputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(138, 157);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 5;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // acceptedLabel
            // 
            this.acceptedLabel.AutoSize = true;
            this.acceptedLabel.Location = new System.Drawing.Point(65, 292);
            this.acceptedLabel.Name = "acceptedLabel";
            this.acceptedLabel.Size = new System.Drawing.Size(83, 13);
            this.acceptedLabel.TabIndex = 6;
            this.acceptedLabel.Text = "Total Accepted:";
            // 
            // rejectedLabel
            // 
            this.rejectedLabel.AutoSize = true;
            this.rejectedLabel.Location = new System.Drawing.Point(191, 292);
            this.rejectedLabel.Name = "rejectedLabel";
            this.rejectedLabel.Size = new System.Drawing.Size(80, 13);
            this.rejectedLabel.TabIndex = 7;
            this.rejectedLabel.Text = "Total Rejected:";
            // 
            // acceptedCount
            // 
            this.acceptedCount.AutoSize = true;
            this.acceptedCount.Location = new System.Drawing.Point(154, 292);
            this.acceptedCount.Name = "acceptedCount";
            this.acceptedCount.Size = new System.Drawing.Size(13, 13);
            this.acceptedCount.TabIndex = 8;
            this.acceptedCount.Text = "0";
            this.acceptedCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rejectedCount
            // 
            this.rejectedCount.AutoSize = true;
            this.rejectedCount.Location = new System.Drawing.Point(277, 292);
            this.rejectedCount.Name = "rejectedCount";
            this.rejectedCount.Size = new System.Drawing.Size(13, 13);
            this.rejectedCount.TabIndex = 9;
            this.rejectedCount.Text = "0";
            this.rejectedCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 323);
            this.Controls.Add(this.rejectedCount);
            this.Controls.Add(this.acceptedCount);
            this.Controls.Add(this.rejectedLabel);
            this.Controls.Add(this.acceptedLabel);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.scoreTextBox);
            this.Controls.Add(this.gpaTextBox);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.gpaLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label gpaLabel;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.TextBox gpaTextBox;
        private System.Windows.Forms.TextBox scoreTextBox;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label acceptedLabel;
        private System.Windows.Forms.Label rejectedLabel;
        private System.Windows.Forms.Label acceptedCount;
        private System.Windows.Forms.Label rejectedCount;
    }
}

