/*
COMP 1098 Assignment 2
App Name- Sharp Auto Form
Author's Name- Parth Joshi
Student ID (Lakehead): 1126914
Date- 18 February 2020
This is a Sharp Auto Form app which will determine the total amount due for the purchase of a
vehicle based on accessories and options selected and a trade in value (if any). The price of the
car will be set by the user. 
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SharpAutoForm
{
    public partial class SharpAutoForm : Form
    {
        public SharpAutoForm()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ExitMenuStrip_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// This method will reset all fields after Clear Button is Clicked
        /// </summary>

        private void Clear_All()
        {
            BasePriceTextBox.Text = "0";
            AdditionalOptionsTextBox.Text = "";
            SubTotalTextBox.Text = "";
            SalesTaxTextBox.Text = "";
            TotalTextBox.Text = "";
            TradeInAllowanceTextBox.Text = "0";
            AmountDueTextBox.Text = "";
            StandardRadioButton.Checked = true;
            PearlizedRadioButton.Checked = false;
            CustomizedRadioButton.Checked = false;
            StereoSystemCheckBox.Checked = false;
            LeatherInteriorCheckBox.Checked = false;
            ComputerNavigationCheckBox.Checked = false;
        }


        private void ClearButton_Click(object sender, EventArgs e)
        {
            Clear_All();
        }

        private void ClearMenuStrip_Click(object sender, EventArgs e)
        {
            Clear_All();
        }

        private void AboutMenuStrip_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Program Determines the Total Amount due for Purchase of a Vehicle Based on Accessories and Options Selected and a Trade-in value (if any).");
        }


        private void CalculateButton_Click(object sender, EventArgs e)
        {
            Calculate_Total();
        }

        const double Stereo_Sys = 425.76;
        const double Leather_Int = 987.41;
        const double Comp_Nav = 1741.23;
        const double Standard = 0;
        const double Pearlized = 345.72;
        const double Custom = 599.99;
        const double Tax = 0.13;

        /// <summary>
        /// This method will Calucate the total amount due
        /// </summary>

        private void Calculate_Total()
        {
            try
            {
                /*
                Adding the price of the selected accessories and exterior finish to the base
                price and displaying the result in the Subtotal Text Box
                 */

                double sub_total = Convert.ToDouble(AdditionalOptionsTextBox.Text);
                double base_price = Convert.ToDouble(BasePriceTextBox.Text);

                double price1 = sub_total + base_price;
                SubTotalTextBox.Text = price1.ToString();

                /*
                  Calculating Sales Tax (13%) on the SubTotal and displaying the result in the Total Text Field.
                 */

                double after_tax = Tax * price1;
                SalesTaxTextBox.Text = after_tax.ToString();

                double tax_amt = price1 + after_tax;
                TotalTextBox.Text = tax_amt.ToString();

                /*
                 Subtracting any Trade-in amount from the Total and Display the result of    
                 calculation in the Amount Due Text Field.
                 */

                double amt = Convert.ToDouble(TradeInAllowanceTextBox.Text);
                double amt_due = tax_amt - amt;
                AmountDueTextBox.Text = amt_due.ToString();

            }

            //If the user does not enter base price or trade-in allowance in numbers 
            //, a meesage box is displayed

            catch(Exception)
            {
                MessageBox.Show("Please Enter Numbers !");
            }
        }

        private void CalculateMenuStrip_Click(object sender, EventArgs e)
        {
            Calculate_Total();
        }


        private void AdditionalItemsGroupBox_Enter(object sender, EventArgs e)
        {
                   
        }

        /// <summary>
        /// When the Font or Color menu selection is clicked, applying the user’s font and color
        //changes to the Amount Due and Base Price Text Boxes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void FontMenuStrip_Click(object sender, EventArgs e)
        {
            FontDialog font_Dialog = new FontDialog();
            if(font_Dialog.ShowDialog()==DialogResult.OK)
            {
                AmountDueTextBox.Font = font_Dialog.Font;
                BasePriceTextBox.Font = font_Dialog.Font;
                   
            }
        }

        private void ColorMenuStrip_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            color.ShowDialog();
            AmountDueTextBox.ForeColor = color.Color;
            BasePriceTextBox.ForeColor = color.Color;
        }

        /// <summary>
        /// This method will ensure that when the user selects one or more checkboxes, the
        ///Additional Options Text Field is updated with the costs of these additional items
        /// </summary>

        private void Check_Uncheck()
        {
            if((StereoSystemCheckBox.Checked==false) && (LeatherInteriorCheckBox.Checked==false) && (ComputerNavigationCheckBox.Checked
                ==false))
            {
                AdditionalOptionsTextBox.Text = "0";
            }
            if ((StereoSystemCheckBox.Checked == true) && (LeatherInteriorCheckBox.Checked == false) && (ComputerNavigationCheckBox.Checked
                == false))
            {
                AdditionalOptionsTextBox.Text = "425.76";
            }
            if ((StereoSystemCheckBox.Checked == true) && (LeatherInteriorCheckBox.Checked == true))
            {
                AdditionalOptionsTextBox.Text = "1413.17";
            }
            if ((StereoSystemCheckBox.Checked == true) && (LeatherInteriorCheckBox.Checked == true) && (ComputerNavigationCheckBox.Checked == true))
            {
                AdditionalOptionsTextBox.Text = "3154.4";
            }
        }

        private void StereoSystemCheckBox_CheckedChanged(object sender, EventArgs e)
        {

            Check_Uncheck();
        }

        private void LeatherInteriorCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Check_Uncheck();
        }

        private void ComputerNavigationCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Check_Uncheck();
        }


        /* This will check for When the user selects one of the radio buttons, the
        Additional Option Text Field is updated with the costs of the exterior finish
        selected 
         */

        private void PearlizedRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if(PearlizedRadioButton.Checked==true)
            {
                double add_pearlize = Convert.ToDouble(AdditionalOptionsTextBox.Text);
                double total =Pearlized+add_pearlize;
                AdditionalOptionsTextBox.Text =total.ToString();
            } 
            else
            {
                double add_pearlized = Convert.ToDouble(AdditionalOptionsTextBox.Text);
                double total = add_pearlized-Pearlized;
                AdditionalOptionsTextBox.Text = total.ToString();
            }
        }

        private void CustomizedRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (CustomizedRadioButton.Checked==true)
            {
                double add_custom = Convert.ToDouble(AdditionalOptionsTextBox.Text);
                double total = Custom + add_custom;
                AdditionalOptionsTextBox.Text = total.ToString();
            }
            else
            {
                double add_customize = Convert.ToDouble(AdditionalOptionsTextBox.Text);
                double total = add_customize - Custom;
                AdditionalOptionsTextBox.Text = total.ToString();
            }
        }
    }
}
