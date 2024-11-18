namespace Lab3
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
            this.radiusLabel = new System.Windows.Forms.Label();
            this.radiusInput = new System.Windows.Forms.TextBox();
            this.diameterLabel = new System.Windows.Forms.Label();
            this.surfaceareaLabel = new System.Windows.Forms.Label();
            this.volumeLabel = new System.Windows.Forms.Label();
            this.diameterOutput = new System.Windows.Forms.Label();
            this.surfaceareaOutput = new System.Windows.Forms.Label();
            this.volumeOutput = new System.Windows.Forms.Label();
            this.sphereBox1 = new System.Windows.Forms.PictureBox();
            this.sphereBox2 = new System.Windows.Forms.PictureBox();
            this.calculateButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sphereBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sphereBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // radiusLabel
            // 
            this.radiusLabel.AutoSize = true;
            this.radiusLabel.Location = new System.Drawing.Point(164, 62);
            this.radiusLabel.Name = "radiusLabel";
            this.radiusLabel.Size = new System.Drawing.Size(90, 13);
            this.radiusLabel.TabIndex = 0;
            this.radiusLabel.Text = "Radius of sphere:";
            // 
            // radiusInput
            // 
            this.radiusInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.radiusInput.Location = new System.Drawing.Point(260, 59);
            this.radiusInput.Name = "radiusInput";
            this.radiusInput.Size = new System.Drawing.Size(100, 20);
            this.radiusInput.TabIndex = 1;
            this.radiusInput.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // diameterLabel
            // 
            this.diameterLabel.AutoSize = true;
            this.diameterLabel.Location = new System.Drawing.Point(41, 192);
            this.diameterLabel.Name = "diameterLabel";
            this.diameterLabel.Size = new System.Drawing.Size(49, 13);
            this.diameterLabel.TabIndex = 2;
            this.diameterLabel.Text = "Diameter";
            // 
            // surfaceareaLabel
            // 
            this.surfaceareaLabel.AutoSize = true;
            this.surfaceareaLabel.Location = new System.Drawing.Point(21, 245);
            this.surfaceareaLabel.Name = "surfaceareaLabel";
            this.surfaceareaLabel.Size = new System.Drawing.Size(69, 13);
            this.surfaceareaLabel.TabIndex = 3;
            this.surfaceareaLabel.Text = "Surface Area";
            // 
            // volumeLabel
            // 
            this.volumeLabel.AutoSize = true;
            this.volumeLabel.Location = new System.Drawing.Point(48, 294);
            this.volumeLabel.Name = "volumeLabel";
            this.volumeLabel.Size = new System.Drawing.Size(42, 13);
            this.volumeLabel.TabIndex = 4;
            this.volumeLabel.Text = "Volume";
            // 
            // diameterOutput
            // 
            this.diameterOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.diameterOutput.Location = new System.Drawing.Point(96, 191);
            this.diameterOutput.Name = "diameterOutput";
            this.diameterOutput.Size = new System.Drawing.Size(92, 18);
            this.diameterOutput.TabIndex = 5;
            this.diameterOutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // surfaceareaOutput
            // 
            this.surfaceareaOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.surfaceareaOutput.Location = new System.Drawing.Point(96, 244);
            this.surfaceareaOutput.Name = "surfaceareaOutput";
            this.surfaceareaOutput.Size = new System.Drawing.Size(92, 18);
            this.surfaceareaOutput.TabIndex = 6;
            this.surfaceareaOutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // volumeOutput
            // 
            this.volumeOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.volumeOutput.Location = new System.Drawing.Point(96, 293);
            this.volumeOutput.Name = "volumeOutput";
            this.volumeOutput.Size = new System.Drawing.Size(92, 18);
            this.volumeOutput.TabIndex = 7;
            this.volumeOutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // sphereBox1
            // 
            this.sphereBox1.BackColor = System.Drawing.SystemColors.Control;
            this.sphereBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.sphereBox1.Image = global::Lab3.Properties.Resources.Sphere_and_Ball;
            this.sphereBox1.Location = new System.Drawing.Point(12, 12);
            this.sphereBox1.Name = "sphereBox1";
            this.sphereBox1.Size = new System.Drawing.Size(150, 150);
            this.sphereBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.sphereBox1.TabIndex = 8;
            this.sphereBox1.TabStop = false;
            // 
            // sphereBox2
            // 
            this.sphereBox2.BackColor = System.Drawing.SystemColors.Control;
            this.sphereBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.sphereBox2.Image = global::Lab3.Properties.Resources.Sphere_and_Ball;
            this.sphereBox2.Location = new System.Drawing.Point(210, 191);
            this.sphereBox2.Name = "sphereBox2";
            this.sphereBox2.Size = new System.Drawing.Size(150, 150);
            this.sphereBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.sphereBox2.TabIndex = 9;
            this.sphereBox2.TabStop = false;
            // 
            // calculateButton
            // 
            this.calculateButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.calculateButton.Location = new System.Drawing.Point(273, 98);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 10;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.sphereBox2);
            this.Controls.Add(this.sphereBox1);
            this.Controls.Add(this.volumeOutput);
            this.Controls.Add(this.surfaceareaOutput);
            this.Controls.Add(this.diameterOutput);
            this.Controls.Add(this.volumeLabel);
            this.Controls.Add(this.surfaceareaLabel);
            this.Controls.Add(this.diameterLabel);
            this.Controls.Add(this.radiusInput);
            this.Controls.Add(this.radiusLabel);
            this.Name = "Form1";
            this.Text = "Lab 3";
            ((System.ComponentModel.ISupportInitialize)(this.sphereBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sphereBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label radiusLabel;
        private System.Windows.Forms.TextBox radiusInput;
        private System.Windows.Forms.Label diameterLabel;
        private System.Windows.Forms.Label surfaceareaLabel;
        private System.Windows.Forms.Label volumeLabel;
        private System.Windows.Forms.Label diameterOutput;
        private System.Windows.Forms.Label surfaceareaOutput;
        private System.Windows.Forms.Label volumeOutput;
        private System.Windows.Forms.PictureBox sphereBox1;
        private System.Windows.Forms.PictureBox sphereBox2;
        private System.Windows.Forms.Button calculateButton;
    }
}

