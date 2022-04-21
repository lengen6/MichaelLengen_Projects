using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FractionCalculator_MichaelLengen
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

            //Select addition as default operation

            operationDropDown.SelectedIndex = 0;

            //Disable relevant butttons until a calculation is performed

            mixedBtn.Enabled = false;
            doubleBtn.Enabled = false;
            clearBtn.Enabled = false;

        }

        //Declare global varialbes used across multiple click events

        int numerator1;
        int denominator1;
        int numerator2;
        int denominator2;
        Fraction result = new Fraction();

        private void calculateBtn_Click(object sender, EventArgs e)
        {

            //Declare local variables for click event

            bool success;
            bool success1;
            bool success2;
            bool success3;
            int selection = operationDropDown.SelectedIndex;

            //Validate User input

            success = int.TryParse(numerator1Txt.Text, out numerator1);
            if (numerator1 == 0)
            {
                success = false;
            }

            success1 = int.TryParse(numerator2Txt.Text, out numerator2);
            if (numerator2 == 0)
            {
                success1 = false;
            }

            success2 = int.TryParse(denominator1Txt.Text, out denominator1);
            if (denominator1 == 0)
            {
                success2 = false;
            }

            success3 = int.TryParse(denominator2Txt.Text, out denominator2);
            if (denominator2 == 0)
            {
                success3 = false;
            }


            if (success && success1 && success2 && success3)
            {
                //Create both fractions

                Fraction f1 = new Fraction(numerator1, denominator1);
                Fraction f2 = new Fraction(numerator2, denominator2);

                //Only used for testing the reduce method
                //MessageBox.Show(f1.ToString());
                //MessageBox.Show(f2.ToString());

                //Enable relevant buttons

                mixedBtn.Enabled = true;
                doubleBtn.Enabled = true;
                clearBtn.Enabled = true;

                //Switch statement to choose the selected operation

                switch (selection)
                {
                    case 0:
                        try
                        {
                            //Add both fractions and return result

                            result = f1.Add(f2);

                            //Display Results

                            DisplayResults(result);

                        }
                        catch (DivideByZeroException)
                        {
                            MessageBox.Show("You attempted to divide by zero. You cannot have a fraction with zero for a denominator");
                        }
                        break;

                    case 1:
                        try
                        {
                            //Subtract the second fraction from the first

                            result = f1.Subtract(f2);
                           
                            //Display Results

                            DisplayResults(result);

                        }
                        catch (DivideByZeroException)
                        {
                            MessageBox.Show("You attempted to divide by zero. You cannot have a fraction with zero for a denominator");
                        }
                        break;

                    case 2:
                        try
                        {
                            //Multiply the first fraction by the second

                            result = f1.Multiply(f2);

                            //Display Results

                            DisplayResults(result);

                        }
                        catch (DivideByZeroException)
                        {
                            MessageBox.Show("You attempted to divide by zero. You cannot have a fraction with zero for a denominator");
                        }
                        break;

                    case 3:
                        try
                        {
                            //Divide the first fraction by the second

                            result = f1.Divide(f2);
                         
                            //Display Results

                            DisplayResults(result);

                        }
                        catch (DivideByZeroException)
                        {
                            MessageBox.Show("You attempted to divide by zero. You cannot have a fraction with zero for a denominator");
                        }
                        break;
                }
            }
            else
            {
                MessageBox.Show("One or more of the values you entered were invalid or zero. Please enter only non-zero integers as values");
            }

        }

        //Methods

        //Method for displaying results

        private void DisplayResults(Fraction argFraction)
        {
            resultLbl.Text = argFraction.ToDecimalString(3);
            numResultLbl.Text = argFraction.Numerator.ToString();
            denomResultLbl.Text = argFraction.Denominator.ToString();
        }

        private void mixedBtn_Click(object sender, EventArgs e)
        {
            resultLbl.Text = result.ToMixedNumberString();
        }

        private void doubleBtn_Click(object sender, EventArgs e)
        {
            resultLbl.Text = result.ToDouble().ToString();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            //Reset relevant values

            numerator1 = 0;
            denominator1 = 0;
            numerator2 = 0;
            denominator2 = 0;

            result = new Fraction();

            //Clear text boxes and lables

            numerator1Txt.Text = "";
            denominator1Txt.Text = "";
            numerator2Txt.Text = "";
            denominator2Txt.Text = "";
            numResultLbl.Text = "";
            denomResultLbl.Text = "";
            resultLbl.Text = "";

            //Disable Results buttons

            mixedBtn.Enabled = false;
            doubleBtn.Enabled = false;

        }
    }
}
