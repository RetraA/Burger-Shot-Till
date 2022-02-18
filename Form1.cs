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
        int heartStopper = 400;
        int bleeder = 150;
        int fries = 50;
        int moneyShot = 200;
        int meatFree = 150;
        int donut = 50;
        int meteoriteIceCream = 150;
        int softDrink = 100;
        int otIceCream = 150;



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
            textBox1.AppendText("Heart Stopper - $400\n");
            textBox1.AppendText(Environment.NewLine);
            costLabel.Text = "Total: $"+totalCost.ToString();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            totalCost = bleeder + totalCost;
            textBox1.AppendText("Bleeder - $150\n");
            textBox1.AppendText(Environment.NewLine);
            costLabel.Text = "Total: $" + totalCost.ToString(); costLabel.Text = "Total: $" + totalCost.ToString();
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            totalCost = fries + totalCost;
            textBox1.AppendText("Fries - $50\n");
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
            textBox1.AppendText("Money Shot - $200\n");
            textBox1.AppendText(Environment.NewLine);
            costLabel.Text = "Total: $" + totalCost.ToString(); costLabel.Text = "Total: $" + totalCost.ToString();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            totalCost = meatFree + totalCost;
            textBox1.AppendText("Meat Free - $150\n");
            textBox1.AppendText(Environment.NewLine);
            costLabel.Text = "Total: $" + totalCost.ToString(); costLabel.Text = "Total: $" + totalCost.ToString();
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            totalCost = donut + totalCost;
            textBox1.AppendText("Donut - $50\n");
            textBox1.AppendText(Environment.NewLine);
            costLabel.Text = "Total: $" + totalCost.ToString(); costLabel.Text = "Total: $" + totalCost.ToString();
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            totalCost = otIceCream + totalCost;
            textBox1.AppendText("Orange Tango Ice Cream - $150\n");
            textBox1.AppendText(Environment.NewLine);
            costLabel.Text = "Total: $" + totalCost.ToString(); costLabel.Text = "Total: $" + totalCost.ToString();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            totalCost = softDrink + totalCost;
            textBox1.AppendText("Soft Drink - $100\n");
            textBox1.AppendText(Environment.NewLine);
            costLabel.Text = "Total: $" + totalCost.ToString(); costLabel.Text = "Total: $" + totalCost.ToString();
        }

        private void Button10_Click(object sender, EventArgs e)
        {

        }

        private void Button14_Click(object sender, EventArgs e)
        {
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            totalCost = meteoriteIceCream + totalCost;
            textBox1.AppendText("Meteorite Ice Cream - $150\n");
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
