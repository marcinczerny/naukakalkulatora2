using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
   
    public partial class Calculator : Form
    {
        Double value = 0;
        String operational = "";
        bool operators = false;
        public Calculator()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            Button pressed = (Button)sender;
            if (result.Text == "0" || operators)
            {if (pressed.Text == ",")
                    result.Text = result.Text + pressed.Text;
                else
                    result.Text = pressed.Text;
               
            }
            else if (pressed.Text == ",")
            {
                if (!result.Text.Contains(","))
                    result.Text = result.Text + pressed.Text;
            }
            else
                result.Text = result.Text + pressed.Text;
            operators = false;
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            result.Clear();
            result.Text = "0";
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button operation = (Button)sender;
            value = Convert.ToDouble(result.Text);
            upperBox.Text +=result.Text+ " " + operation.Text;
            operators = true;
            operational = operation.Text;
        }

        private void operation_clicks(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            
            switch (operational)
            {
                case "+":
                    result.Text=Convert.ToString(value+Convert.ToDouble(result.Text));
                    break;
                case "-":
                    result.Text = Convert.ToString(value - Convert.ToDouble(result.Text));
                    break;
                case "*":
                    result.Text = Convert.ToString(value * Convert.ToDouble(result.Text));
                    break;
                case "/":
                    result.Text = Convert.ToString(value / Convert.ToDouble(result.Text));
                    break;
                default:
                    break;
           }
            operators = false;
            upperBox.Text = "";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            value = 0;
            result.Clear();
            upperBox.Text = "";
            result.Text = "0";
        }

        private void upperBox_Click(object sender, EventArgs e)
        {

        }

        private void keydown(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar.ToString())
            {

                case "1":
                    button7.PerformClick();

                    break;
                case "2":
                    button8.PerformClick();
                    break;
                case "3":
                    button9.PerformClick();
                    break;
                case "4":
                    button4.PerformClick();
                    break;
                case "5":
                    button5.PerformClick();
                    break;
                case "6":
                    button6.PerformClick();
                    break;
                case "7":
                    button1.PerformClick();
                    break;
                case "8":
                    button2.PerformClick();
                    break;
                case "9":
                    button3.PerformClick();
                    break;
                case "*":
                    button14.PerformClick();
                    break;
                case "/":
                    button15.PerformClick();
                    break;
                case "+":
                    button11.PerformClick();
                    break;
                case "-":
                    button13.PerformClick();
                    break;
                case ",":
                    button12.PerformClick();
                    break;
                case ".":
                    button12.PerformClick();
                    break;
                case "ENTER":
                    button16.PerformClick();
                    break;
                default:
                    break;

            }
        }
    }
}
