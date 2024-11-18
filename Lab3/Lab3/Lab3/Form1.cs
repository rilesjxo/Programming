///////////////////////////////////////////////////////////
/// Lab #:       Lab 3                                  ///
/// Section:     CIS 199-01                             ///
/// Due Date:    2/13/2021                              ///
/// Grading ID:  K3222                                  ///
/// Description: A program that calculates diameter,    ///
///              surface area, and volume of a sphere   ///
///              based on user inputted radius.         ///
///////////////////////////////////////////////////////////
using System;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            string input;                                                   //String variable for input
            double input1;                                                  //Double variable for input
            double output1;                                                 //Double variable for diameter
            double output2;                                                 //Double variable for surface area
            double output3;                                                 //Double variable for volume

            input = radiusInput.Text;                                       //Saves user input radius from Text Box

            input1 = Double.Parse(input);                                   //Converts String to Double

            output1 = 2 * input1;                                           //Calculates Diameter
            output2 = 4 * Math.PI * Math.Pow(input1, 2);                    //Calculates Surface Area
            output3 = 4 * Math.PI * Math.Pow(input1, 3) / 3;                //Calculates Volume

            diameterOutput.Text = output1.ToString("n2");                   //Outputs Diameter as string to Text Box
            surfaceareaOutput.Text = output2.ToString("n2");                //Outputs Surface Area as string to Text Box
            volumeOutput.Text = output3.ToString("n2");                     //Outputs Volume as string to Text Box
        }
    }
}
