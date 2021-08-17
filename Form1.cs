using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BurgerShot_example
{
    public partial class Form1 : Form
    {
        int totalCost = 0;
        int heartStopper = 800;
        int bleeder = 500;
        int fries = 200;
        int torpedo = 600;
        int moneyShot = 400;
        int meatFree = 1000;
        int donut = 150;
        int coffee = 750;
        int water = 200;
        int softDrink = 400;
        int milkShake = 750;

        public Form1()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            totalCost = heartStopper + totalCost;
            textBox1.AppendText("Heart Stopper - $800\n");
            textBox1.AppendText(Environment.NewLine);
            costLabel.Text = "Total: $"+totalCost.ToString();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            totalCost = bleeder + totalCost;
            textBox1.AppendText("Bleeder - $500\n");
            textBox1.AppendText(Environment.NewLine);
            costLabel.Text = "Total: $" + totalCost.ToString(); costLabel.Text = "Total: $" + totalCost.ToString();
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            totalCost = fries + totalCost;
            textBox1.AppendText("Fries - $200\n");
            textBox1.AppendText(Environment.NewLine);
            costLabel.Text = "Total: $" + totalCost.ToString(); costLabel.Text = "Total: $" + totalCost.ToString();
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            totalCost = 0;
            costLabel.Text = "Total: $"+totalCost.ToString();
            textBox1.Clear();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button7_Click(object sender, EventArgs e)
        {
            totalCost = torpedo + totalCost;
            textBox1.AppendText("Torpedo - $600\n");
            textBox1.AppendText(Environment.NewLine);
            costLabel.Text = "Total: $" + totalCost.ToString(); costLabel.Text = "Total: $" + totalCost.ToString();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            totalCost = moneyShot + totalCost;
            textBox1.AppendText("Money Shot - $400\n");
            textBox1.AppendText(Environment.NewLine);
            costLabel.Text = "Total: $" + totalCost.ToString(); costLabel.Text = "Total: $" + totalCost.ToString();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            totalCost = meatFree + totalCost;
            textBox1.AppendText("Meat Free - $1000\n");
            textBox1.AppendText(Environment.NewLine);
            costLabel.Text = "Total: $" + totalCost.ToString(); costLabel.Text = "Total: $" + totalCost.ToString();
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            totalCost = donut + totalCost;
            textBox1.AppendText("Donut - $150\n");
            textBox1.AppendText(Environment.NewLine);
            costLabel.Text = "Total: $" + totalCost.ToString(); costLabel.Text = "Total: $" + totalCost.ToString();
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            totalCost = milkShake + totalCost;
            textBox1.AppendText("Milkshake - $750\n");
            textBox1.AppendText(Environment.NewLine);
            costLabel.Text = "Total: $" + totalCost.ToString(); costLabel.Text = "Total: $" + totalCost.ToString();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            totalCost = softDrink + totalCost;
            textBox1.AppendText("Soft Drink - $400\n");
            textBox1.AppendText(Environment.NewLine);
            costLabel.Text = "Total: $" + totalCost.ToString(); costLabel.Text = "Total: $" + totalCost.ToString();
        }

        private void Button10_Click(object sender, EventArgs e)
        {

        }

        private void Button14_Click(object sender, EventArgs e)
        {
            totalCost = water + totalCost;
            textBox1.AppendText("Water - $200\n");
            textBox1.AppendText(Environment.NewLine);
            costLabel.Text = "Total: $" + totalCost.ToString(); costLabel.Text = "Total: $" + totalCost.ToString();
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            totalCost = coffee + totalCost;
            textBox1.AppendText("Coffee - $750\n");
            textBox1.AppendText(Environment.NewLine);
            costLabel.Text = "Total: $" + totalCost.ToString(); costLabel.Text = "Total: $" + totalCost.ToString();
        }
    }
}
