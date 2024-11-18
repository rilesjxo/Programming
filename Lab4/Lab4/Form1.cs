///////////////////////////////////////////////////////////
/// Lab #:       Lab 4                                  ///
/// Section:     CIS 199-01                             ///
/// Due Date:    2/27/2022                              ///
/// Grading ID:  K3222                                  ///
/// Description: A program that determines admission    ///
///              status for a university based on high  ///
///              school GPA and admission test score.   ///
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Form1 : Form
    {
        int totalAccepted = 1, totalRejected = 1;   // Field Variable declarations for running totals
        public Form1()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            float gpa;  // Floating-Point Variable for GPA

            if (float.TryParse(gpaTextBox.Text, out gpa) == false || gpa < 0 || gpa > 4)    // GPA Validation using TryParse
            {
                MessageBox.Show("Invalid grade point average entered.");    // MessageBox for invalid GPA
            }

            int testScore;

            if (int.TryParse(scoreTextBox.Text, out testScore) == false || testScore < 0 || testScore > 100)    // Test Score Validation using TryParse
            {
                MessageBox.Show("Invalid test score entered."); // MessageBox for invalid Test Score
            }

            if ((gpa >= 3.0 && testScore >= 60) || (gpa < 3.0 && testScore >= 80))  // IF statement to determine acceptance from user input of GPA and Test Score
            {
                outputLabel.Text = ("Accepted");    // Outputs "Accepted" to outputLabel.Text
                acceptedCount.Text = Convert.ToString(totalAccepted++);     // Adds +1 to running total for Total Accepted
            }
            else    // ELSE statement to determine rejection when IF statement requirements are not met
            {
                outputLabel.Text = ("Rejected");    // Outputs "Rejected" to outputLabel.Text
                rejectedCount.Text = Convert.ToString(totalRejected++);     // Adds +1 to running total for Total Rejected
            }
        }
    }
}
