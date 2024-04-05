namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        double numberOne;
        double numberTwo;
        double endResult;
        int sign;
        int signNum;
        
        public Form1()
        {
            InitializeComponent();
        }


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
            numberOne = double.Parse(textBox1.Text);
            textBox1.Clear();
            signNum = 1;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            numberOne = double.Parse(textBox1.Text);
            textBox1.Clear();
            signNum = 2;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            numberOne = double.Parse(textBox1.Text);
            textBox1.Clear();
            signNum = 3;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            numberOne = double.Parse(textBox1.Text);
            textBox1.Clear();
            signNum = 4;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            solution();
        }
        
        private void solution()
        {
            numberTwo = double.Parse(textBox1.Text);

            if (signNum == 1 && textBox1.Text == "0")
            {
                textBox1.Text = "�����";
            }
            else if (signNum == 1)
            {
                endResult = numberOne / numberTwo;
                textBox1.Text = endResult.ToString();
            }
            else if (signNum == 2)
            {
                endResult = numberOne * numberTwo;
                textBox1.Text = endResult.ToString();
            }
            else if (signNum == 3)
            {
                endResult = numberOne - numberTwo;
                textBox1.Text = endResult.ToString();
            }
            else if (signNum == 4)
            {
                endResult = numberOne + numberTwo;
                textBox1.Text = endResult.ToString();
            }
        }
    }
}
