namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double number1;
        double number2;
        double number3solution;
        int sign = 0;
        int signnum = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
        }
        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ",";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            number1 = double.Parse(textBox1.Text);
            textBox1.Clear();
            signnum = 1;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            number1 = double.Parse(textBox1.Text);
            textBox1.Clear();
            signnum = 2;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            number1 = double.Parse(textBox1.Text);
            textBox1.Clear();
            signnum = 3;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            number1 = double.Parse(textBox1.Text);
            textBox1.Clear();
            signnum = 4;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            solution();
        }
        private void solution()
        {
            number2 = double.Parse(textBox1.Text);

            if (signnum == 1 && textBox1.Text == "0")
            {
                textBox1.Text = "юанаю";
            }
            else if (signnum == 1)
            {
                number3solution = number1 / number2;
                textBox1.Text = number3solution.ToString();
            }
            else if (signnum == 2)
            {
                number3solution = number1 * number2;
                textBox1.Text = number3solution.ToString();
            }
            else if (signnum == 3)
            {
                number3solution = number1 - number2;
                textBox1.Text = number3solution.ToString();
            }
            else if (signnum == 4)
            {
                number3solution = number1 + number2;
                textBox1.Text = number3solution.ToString();
            }
        }
    }
}
