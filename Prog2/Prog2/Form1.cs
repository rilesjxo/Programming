///////////////////////////////////////////////////////////
/// Lab #:       Program 2                              ///
/// Section:     CIS 199-01                             ///
/// Due Date:    3/10/2022                              ///
/// Grading ID:  K3222                                  ///
/// Description: A program that determines the cost of  ///
///              a single hotel room based on number    ///
///              of guests, duration of the stay, and   ///
///              stars of the hotel.                    ///
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

namespace Prog2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int guests; // Variable for number of guests
            int nights; // Variable for number of nights
            int stars; // Variable for stars of the hotel
            double guestflatrate = 0; // Variable for flat rate based on number of guests
            double costpernight = 0; // Variable for nightly cost based on number of nights
            double starfactor = 0; // Variable for star gactor based on stars of the hotel
            double totalcost; // Variable for total cost of the stay

            {
                int.TryParse(guestsTextBox.Text, out guests); // Conversion for user input in guestsTextBox from string to integer

                if (guests == 1) // If statement for 1 guest
                    guestflatrate = 100; // Flat rate declaration for 1 guest
                else if (guests == 2) // Else If statement for 2 guests
                    guestflatrate = 150; // Flat rate declaration for 2 guests
                else if (guests == 3) // Else If statement for 3 guests
                    guestflatrate = 250; // Flat rate declaration for 3 guests
                else if (guests >= 4 && guests <= 7) // Else If statement for 4- 7 guests
                    guestflatrate = 400; // Flat rate declaration for 4 - 7 guests
                else // Else statement for above if and if else statements for number of guests
                    MessageBox.Show("Number of guests must be an integer between 1 and 7."); // Shows message box if user input is not an integer between 1 and 7

                int.TryParse(nightsTextBox.Text, out nights); // Conversion for user input in nightsTextBox from string to integer

                if (nights >= 1 && nights <= 6) // If statement for 1 - 6 nights
                    costpernight = 100; // Cost per night declaration for 1 - 6 nights
                else if (nights >= 7 && nights <= 30) // Else If statement for 7 - 30 nights
                    costpernight = 75; // Cost per night declaration for 7 - 30 nights
                else if (nights >= 31) // Else If statement for 31+ nights
                    costpernight = 25; // Cost per night declaration for 31+ nights
                else // Else statement for above if and if else statements for number of nights
                    MessageBox.Show("Number of nights must be an integer greater than 0."); // Shows message box if user input is not an integer greater than 0

                int.TryParse(starsTextBox.Text, out stars); // Conversion for user input in starsTextBox from string to integer

                if (stars == 1) // If statement for 1 star
                    starfactor = 1; // Star factor declarion for 1 star
                else if (stars == 2) // Else If statement for 2 stars
                    starfactor = 1.5; // Star factor declarion for 2 stars
                else if (stars == 3) // Else If statement for 3 stars
                    starfactor = 2.5; // Star factor declarion for 3 stars
                else if (stars == 4) // Else If statement for 4 stars
                    starfactor = 3; // Star factor declarion for 4 stars
                else if (stars == 5) // Else If statement for 5 stars
                    starfactor = 4; // Star factor declarion for 5 stars
                else // Else statement for above if and if else statements for hotel stars
                    MessageBox.Show("Hotel stars must be an integer between 1 and 5."); // Shows message box if user input is not an integer between 1 and 5
            }

            totalcost = (guestflatrate + nights * costpernight) * starfactor; // Calculates total cost of stay based on the formula (Flat Guest Fee + Number of Nights * Cost Per Night) * Star Factor)
            outputLabel.Text = totalcost.ToString("C"); // Displays result of totalcost calculation in the outputLabel at the bottom of Form1

        }
    }
}
