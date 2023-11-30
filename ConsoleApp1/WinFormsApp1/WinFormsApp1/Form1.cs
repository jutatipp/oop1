using System.Diagnostics.Eventing.Reader;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        int number = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBoxInput.Text = textBoxInput.Text + "1";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBoxInput.Text = textBoxInput.Text + "2";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBoxInput.Text = textBoxInput.Text + "3";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBoxInput.Text = textBoxInput.Text + "4";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBoxInput.Text = textBoxInput.Text + "5";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBoxInput.Text = textBoxInput.Text + "6";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBoxInput.Text = textBoxInput.Text + "7";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBoxInput.Text = textBoxInput.Text + "8";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBoxInput.Text = textBoxInput.Text + "9";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBoxInput.Text = textBoxInput.Text + "0";
        }
        string operation;
        string number1 = string.Empty;
        private void button2_Click(object sender, EventArgs e)
        {
            textBoxInput.Text = string.Empty;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            number1 = textBoxInput.Text;
            textBoxInput.Text = string.Empty;
            operation = "+";
        }

        private void button13_Click(object sender, EventArgs e)
        {

            string number2 = textBoxInput.Text;
            //convert string to intger
            int num1 = int.Parse(number1);
            int num2 = int.Parse(number2);
            if (operation == "+")
            {
                int output = num1 + num2;
                textBoxInput.Text = output.ToString();
            }
            if (operation == "-")
            {
                int output = num1 - num2;
                textBoxInput.Text = output.ToString();

            }
            if (operation == "x")
            {
                int output = num1 * num2;
                textBoxInput.Text = output.ToString();

            }
            if (operation == "/")
            {
                int output = num1 / num2;
                textBoxInput.Text = output.ToString();

            }



        }
        private void button15_Click(object sender, EventArgs e)
        {
            number1 = textBoxInput.Text;
            textBoxInput.Text = string.Empty;
            operation = "-";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //datatype
            //string
            //int  -- จำนวนเต็ม
            //double -- ทศนิยม
            string userinput = textBoxInput.Text;
            textBoxInput.Text = userinput + "KKU";
            // String.Format("{0} {1} " , userinput , "KKU");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            number1 = textBoxInput.Text;
            textBoxInput.Text = string.Empty;
            operation = "x";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            number1 = textBoxInput.Text;
            textBoxInput.Text = string.Empty;
            operation = "/";
        }
    }
}
