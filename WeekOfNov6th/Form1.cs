using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeekOfNov6th
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTemp_Click(object sender, EventArgs e)
        {
            if (rdoTempConverter1.Checked)
            {
                double celsius = double.Parse(txtInput1.Text);
                double fahrenheit = (celsius * 9 / 5) + 32;
                rtbOutput.Text = fahrenheit.ToString();
                rtbOutput.Text += "°F";
            }
            else if (rdoTempConverter2.Checked)
            {
                double fahrenheit =  double.Parse(txtInput1.Text);
                double celsius = (fahrenheit - 32) * 5/9;
                rtbOutput.Text = celsius.ToString();
                rtbOutput.Text += "°C";
            }
        }

        private void btnDistance_Click(object sender, EventArgs e)
        {
            if (chkMileToKilo.Checked)
            {
                double miles = double.Parse(txtInput1.Text);
                double kilometers = miles * 1.609344;
                rtbOutput.Text = kilometers.ToString();
                rtbOutput.Text += "km \n(kilometers)";
            }
            else if (chkKiloToMiles.Checked)
            {
                double kilometers = double.Parse(txtInput1.Text);
                double miles = kilometers / 1.609344;
                rtbOutput.Text = miles.ToString();
                rtbOutput.Text += "m \n(miles)";
            }
        }

        private void btnMoney_Click(object sender, EventArgs e)
        {
            /* 
            currency
                USD - Yen
                Yen - USD
                USD - EUR
                EUR - USD
                USD - CNY
                CNY - USD
                USD - MXN
                MXN - USD
                USD - GTQ
                GTQ - USD
            */


            if (cmbMoneyConverter.SelectedItem.ToString() == "USD - Yen")
            {
                double USD = double.Parse(txtInput1.Text);
                double Yen = USD * 149.72;
                rtbOutput.Text = Yen.ToString();
                rtbOutput.Text += " yen";
                rtbOutput.Text += "\n(Japanese Yen)";
            }
            else if (cmbMoneyConverter.SelectedItem.ToString() == "Yen - USD")
            {
                double Yen = double.Parse(txtInput1.Text);
                double USD = Yen / 149.72;
                rtbOutput.Text = USD.ToString();
                rtbOutput.Text += " USD";
                rtbOutput.Text += "\n(US Dollars)";
            }
            else if (cmbMoneyConverter.SelectedItem.ToString() == "USD - EUR")
            {
                double USD = double.Parse(txtInput1.Text);
                double EUR = USD * 0.9364;
                rtbOutput.Text = EUR.ToString();
                rtbOutput.Text += " EUR";
                rtbOutput.Text += "\n(Europe Euro)";
            }
            else if (cmbMoneyConverter.SelectedItem.ToString() == "EUR - USD")
            {
                double EUR = double.Parse(txtInput1.Text);
                double USD = EUR / 0.9364;
                rtbOutput.Text = USD.ToString();
                rtbOutput.Text += " USD";
                rtbOutput.Text += "\n(US Dollars)";
            }
            else if (cmbMoneyConverter.SelectedItem.ToString() == "USD - CNY")
            {
                double USD = double.Parse(txtInput1.Text);
                double CNY = USD * 7.28;
                rtbOutput.Text = CNY.ToString();
                rtbOutput.Text += " CNY";
                rtbOutput.Text += "\n(Chinese Yuan)";
            }
            else if (cmbMoneyConverter.SelectedItem.ToString() == "CNY - USD")
            {
                double CNY = double.Parse(txtInput1.Text);
                double USD = CNY / 7.28;
                rtbOutput.Text = USD.ToString();
                rtbOutput.Text += " USD";
                rtbOutput.Text += "\n(US Dollars)";
            }
            else if (cmbMoneyConverter.SelectedItem.ToString() == "USD - MXN")
            {
                double USD = double.Parse(txtInput1.Text);
                double MXN = USD * 17.51;
                rtbOutput.Text = MXN.ToString();
                rtbOutput.Text += " MXN";
                rtbOutput.Text += "\n(Mexican Peso)";
            }
            else if (cmbMoneyConverter.SelectedItem.ToString() == "MXN - USD")
            {
                double MXN = double.Parse(txtInput1.Text);
                double USD = MXN / 17.51;
                rtbOutput.Text = USD.ToString();
                rtbOutput.Text += " USD";
                rtbOutput.Text += "\n(US Dollars)";
            }
            else if (cmbMoneyConverter.SelectedItem.ToString() == "USD - GTQ")
            {
                double USD = double.Parse(txtInput1.Text);
                double GTQ = USD * 7.82;
                rtbOutput.Text = GTQ.ToString();
                rtbOutput.Text += " GTQ";
                rtbOutput.Text += "\n(Guatemalan Quetzal)";
            }
            else if (cmbMoneyConverter.SelectedItem.ToString() == "GTQ - USD")
            {
                double GTQ = double.Parse(txtInput1.Text);
                double USD = GTQ / 7.82;
                rtbOutput.Text = USD.ToString();
                rtbOutput.Text += " USD";
                rtbOutput.Text += "\n(US dollars)";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (chkMeterToInch.Checked)
            {
                double meters = double.Parse(txtInput2.Text);
                double inches = meters * 39.3700787;
                rtbOutput.Text += "\n" + inches.ToString();
                rtbOutput.Text += "in \n(inches)";
            }
            else if (chkInchToMeter.Checked)
            {
                double inches = double.Parse(txtInput2.Text);
                double meters = inches / 39.3700787;
                rtbOutput.Text += "\n" + meters.ToString();
                rtbOutput.Text += "m \n(meters)";
            }
        }
    }
}
