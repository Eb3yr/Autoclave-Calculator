using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.Threading;

namespace Autoclave_2._0
{
    public partial class Form1 : Form
    {
        public Dictionary<string, double> tools;
        public Form1()
        {
            InitializeComponent();
            tools = new Dictionary<string, double>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (string i in ToolListBox.Items)
            {
                tools.Add(i, 0);
                Controls[i + "Box"].Text = i;
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label16.Text = "Selecting " + (string)ToolListBox.SelectedItem + " as autoclaved tool";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Profit calc
            errLabel.Text = "";
            try
            {
                double noOfClaves = double.Parse(RateBoughtBox.Text) * double.Parse(WLsSpentBox.Text) / 20;
                NumOfToolsEnd.Text = "No. of each tool: " + noOfClaves;
                double grossProduct = 0;
                //ew:
                AnaestheticProfit.Text = (noOfClaves / double.Parse(AnaestheticBox.Text)).ToString();
                AntibioticsProfit.Text = (noOfClaves / double.Parse(AntibioticsBox.Text)).ToString();
                AntisepticProfit.Text = (noOfClaves / double.Parse(AntisepticBox.Text)).ToString();
                ClampProfit.Text = (noOfClaves / double.Parse(ClampBox.Text)).ToString();
                DefibrillatorProfit.Text = (noOfClaves / double.Parse(DefibrillatorBox.Text)).ToString();
                LabKitProfit.Text = (noOfClaves / double.Parse(LabKitBox.Text)).ToString();
                PinsProfit.Text = (noOfClaves / double.Parse(PinsBox.Text)).ToString();
                ScalpelProfit.Text = (noOfClaves / double.Parse(ScalpelBox.Text)).ToString();
                SplintProfit.Text = (noOfClaves / double.Parse(SplintBox.Text)).ToString();
                SpongeProfit.Text = (noOfClaves / double.Parse(SpongeBox.Text)).ToString();
                TransfusionProfit.Text = (noOfClaves / double.Parse(TransfusionBox.Text)).ToString();
                UltrasoundProfit.Text = (noOfClaves / double.Parse(UltrasoundBox.Text)).ToString();
                StitchesProfit.Text = (noOfClaves / double.Parse(StitchesBox.Text)).ToString();

                grossProduct += noOfClaves / double.Parse(AnaestheticBox.Text);
                grossProduct += noOfClaves / double.Parse(AntibioticsBox.Text);
                grossProduct += noOfClaves / double.Parse(AntisepticBox.Text);
                grossProduct += noOfClaves / double.Parse(ClampBox.Text);
                grossProduct += noOfClaves / double.Parse(DefibrillatorBox.Text);
                grossProduct += noOfClaves / double.Parse(LabKitBox.Text);
                grossProduct += noOfClaves / double.Parse(PinsBox.Text);
                grossProduct += noOfClaves / double.Parse(ScalpelBox.Text);
                grossProduct += noOfClaves / double.Parse(SplintBox.Text);
                grossProduct += noOfClaves / double.Parse(SpongeBox.Text);
                grossProduct += noOfClaves / double.Parse(TransfusionBox.Text);
                grossProduct += noOfClaves / double.Parse(UltrasoundBox.Text);
                grossProduct += noOfClaves / double.Parse(StitchesBox.Text);

                GrossLabel.Text = "Gross: " + grossProduct.ToString();
                ProfitLabel.Text = "Profit: " + (grossProduct - double.Parse(WLsSpentBox.Text)).ToString();

            }
            catch (Exception)
            {
                errLabel.Text = "You did something wrong so profit won't calc\n\ndont";
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
