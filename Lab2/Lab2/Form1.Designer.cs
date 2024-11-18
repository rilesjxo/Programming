namespace Lab2
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
            this.priceLabel = new System.Windows.Forms.Label();
            this.fifteenLabel = new System.Windows.Forms.Label();
            this.eighteenLabel = new System.Windows.Forms.Label();
            this.twentyLabel = new System.Windows.Forms.Label();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.output15Label = new System.Windows.Forms.Label();
            this.output18Label = new System.Windows.Forms.Label();
            this.output20Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.priceLabel.Location = new System.Drawing.Point(52, 53);
            this.priceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(104, 14);
            this.priceLabel.TabIndex = 0;
            this.priceLabel.Text = "Enter price of meal:";
            // 
            // fifteenLabel
            // 
            this.fifteenLabel.AutoSize = true;
            this.fifteenLabel.Location = new System.Drawing.Point(128, 92);
            this.fifteenLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fifteenLabel.Name = "fifteenLabel";
            this.fifteenLabel.Size = new System.Drawing.Size(28, 14);
            this.fifteenLabel.TabIndex = 1;
            this.fifteenLabel.Text = "15%";
            // 
            // eighteenLabel
            // 
            this.eighteenLabel.AutoSize = true;
            this.eighteenLabel.Location = new System.Drawing.Point(128, 133);
            this.eighteenLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.eighteenLabel.Name = "eighteenLabel";
            this.eighteenLabel.Size = new System.Drawing.Size(28, 14);
            this.eighteenLabel.TabIndex = 2;
            this.eighteenLabel.Text = "18%";
            // 
            // twentyLabel
            // 
            this.twentyLabel.AutoSize = true;
            this.twentyLabel.Location = new System.Drawing.Point(128, 172);
            this.twentyLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.twentyLabel.Name = "twentyLabel";
            this.twentyLabel.Size = new System.Drawing.Size(28, 14);
            this.twentyLabel.TabIndex = 3;
            this.twentyLabel.Text = "20%";
            // 
            // priceTextBox
            // 
            this.priceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.priceTextBox.Location = new System.Drawing.Point(160, 51);
            this.priceTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(86, 22);
            this.priceTextBox.TabIndex = 4;
            this.priceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.priceTextBox.TextChanged += new System.EventHandler(this.priceTextBox_TextChanged);
            // 
            // calculateButton
            // 
            this.calculateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calculateButton.Location = new System.Drawing.Point(114, 248);
            this.calculateButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(93, 24);
            this.calculateButton.TabIndex = 5;
            this.calculateButton.Text = "Calculate Tip";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // output15Label
            // 
            this.output15Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.output15Label.Location = new System.Drawing.Point(160, 91);
            this.output15Label.Name = "output15Label";
            this.output15Label.Size = new System.Drawing.Size(86, 21);
            this.output15Label.TabIndex = 6;
            this.output15Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // output18Label
            // 
            this.output18Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.output18Label.Location = new System.Drawing.Point(160, 132);
            this.output18Label.Name = "output18Label";
            this.output18Label.Size = new System.Drawing.Size(85, 22);
            this.output18Label.TabIndex = 7;
            this.output18Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // output20Label
            // 
            this.output20Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.output20Label.Location = new System.Drawing.Point(160, 171);
            this.output20Label.Name = "output20Label";
            this.output20Label.Size = new System.Drawing.Size(86, 22);
            this.output20Label.TabIndex = 8;
            this.output20Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(332, 312);
            this.Controls.Add(this.output20Label);
            this.Controls.Add(this.output18Label);
            this.Controls.Add(this.output15Label);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.twentyLabel);
            this.Controls.Add(this.eighteenLabel);
            this.Controls.Add(this.fifteenLabel);
            this.Controls.Add(this.priceLabel);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form1";
            this.Text = "Lab 2";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label priceLabel;
        private Label fifteenLabel;
        private Label eighteenLabel;
        private Label twentyLabel;
        private TextBox priceTextBox;
        private Button calculateButton;
        private Label output15Label;
        private Label output18Label;
        private Label output20Label;
    }
}