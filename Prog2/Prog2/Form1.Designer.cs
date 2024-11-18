namespace Prog2
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
            this.guestsLabel = new System.Windows.Forms.Label();
            this.nightsLabel = new System.Windows.Forms.Label();
            this.starsLabel = new System.Windows.Forms.Label();
            this.costLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.guestsTextBox = new System.Windows.Forms.TextBox();
            this.nightsTextBox = new System.Windows.Forms.TextBox();
            this.starsTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // guestsLabel
            // 
            this.guestsLabel.AutoSize = true;
            this.guestsLabel.Location = new System.Drawing.Point(48, 32);
            this.guestsLabel.Name = "guestsLabel";
            this.guestsLabel.Size = new System.Drawing.Size(95, 13);
            this.guestsLabel.TabIndex = 0;
            this.guestsLabel.Text = "Number of Guests:";
            // 
            // nightsLabel
            // 
            this.nightsLabel.AutoSize = true;
            this.nightsLabel.Location = new System.Drawing.Point(48, 67);
            this.nightsLabel.Name = "nightsLabel";
            this.nightsLabel.Size = new System.Drawing.Size(92, 13);
            this.nightsLabel.TabIndex = 1;
            this.nightsLabel.Text = "Number of Nights:";
            // 
            // starsLabel
            // 
            this.starsLabel.AutoSize = true;
            this.starsLabel.Location = new System.Drawing.Point(48, 104);
            this.starsLabel.Name = "starsLabel";
            this.starsLabel.Size = new System.Drawing.Size(62, 13);
            this.starsLabel.TabIndex = 2;
            this.starsLabel.Text = "Hotel Stars:";
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.Location = new System.Drawing.Point(48, 228);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(59, 13);
            this.costLabel.TabIndex = 3;
            this.costLabel.Text = "Hotel Cost:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(103, 155);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.outputLabel.Location = new System.Drawing.Point(149, 224);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(100, 23);
            this.outputLabel.TabIndex = 5;
            // 
            // guestsTextBox
            // 
            this.guestsTextBox.Location = new System.Drawing.Point(149, 30);
            this.guestsTextBox.Name = "guestsTextBox";
            this.guestsTextBox.Size = new System.Drawing.Size(100, 20);
            this.guestsTextBox.TabIndex = 6;
            // 
            // nightsTextBox
            // 
            this.nightsTextBox.Location = new System.Drawing.Point(149, 64);
            this.nightsTextBox.Name = "nightsTextBox";
            this.nightsTextBox.Size = new System.Drawing.Size(100, 20);
            this.nightsTextBox.TabIndex = 7;
            // 
            // starsTextBox
            // 
            this.starsTextBox.Location = new System.Drawing.Point(149, 101);
            this.starsTextBox.Name = "starsTextBox";
            this.starsTextBox.Size = new System.Drawing.Size(100, 20);
            this.starsTextBox.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 283);
            this.Controls.Add(this.starsTextBox);
            this.Controls.Add(this.nightsTextBox);
            this.Controls.Add(this.guestsTextBox);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.costLabel);
            this.Controls.Add(this.starsLabel);
            this.Controls.Add(this.nightsLabel);
            this.Controls.Add(this.guestsLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Program 2 - Hotel Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label guestsLabel;
        private System.Windows.Forms.Label nightsLabel;
        private System.Windows.Forms.Label starsLabel;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.TextBox guestsTextBox;
        private System.Windows.Forms.TextBox nightsTextBox;
        private System.Windows.Forms.TextBox starsTextBox;
    }
}

