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
        int moneyShot = 600;
        int meatFree = 1000;
        int donut = 150;
        int meteoriteIceCream = 750;
        int water = 200;
        int softDrink = 400;
        int otIceCream = 750;



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

        }

        private void Button6_Click(object sender, EventArgs e)
        {
            totalCost = moneyShot + totalCost;
            textBox1.AppendText("Money Shot - $600\n");
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
            totalCost = otIceCream + totalCost;
            textBox1.AppendText("Orange Tango Ice Cream - $750\n");
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
            totalCost = meteoriteIceCream + totalCost;
            textBox1.AppendText("Meteorite Ice Cream - $750\n");
            textBox1.AppendText(Environment.NewLine);
            costLabel.Text = "Total: $" + totalCost.ToString(); costLabel.Text = "Total: $" + totalCost.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
                    //Ability to move program with mouse
            }

            base.WndProc(ref m);
        }

        private void panel1_Paint()
        {
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Button11_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Button10_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
