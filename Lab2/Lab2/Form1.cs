/////////////////////
/// Lab 2         ///
/// CIS 199-01    ///
/// Due: 2/6/2021 ///
/// By: K3222     ///
/////////////////////
namespace Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void priceTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            string input;
            double input1;
            double output1;
            double output2;
            double output3;

            input = priceTextBox.Text;

            input1 = Double.Parse(input);

            output1 = 0.15 * input1;
            output2 = 0.18 * input1;
            output3 = 0.20 * input1;

            output15Label.Text = "$" + output1.ToString("n2");
            output18Label.Text = "$" + output2.ToString("n2");
            output20Label.Text = "$" + output3.ToString("n2");

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}