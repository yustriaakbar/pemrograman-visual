namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int num1;
        int num2;
        string option;
        int res;
        string CalculatorRes;
        List<string> historyList = new List<string>();

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        // button C
        private void button1_Click(object sender, EventArgs e)
        {
            textDisplay.Clear();
        }

        // button ( )
        private void btn00_Click(object sender, EventArgs e)
        {

        }

        private void btn7_Click(object sender, EventArgs e)
        {
            textDisplay.Text = textDisplay.Text + btn7.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            textDisplay.Text = textDisplay.Text + btn8.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            textDisplay.Text = textDisplay.Text + btn9.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            textDisplay.Text = textDisplay.Text + btn6.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            textDisplay.Text = textDisplay.Text + btn5.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            textDisplay.Text = textDisplay.Text + btn4.Text;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            textDisplay.Text = textDisplay.Text + btn1.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            textDisplay.Text = textDisplay.Text + btn2.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            textDisplay.Text = textDisplay.Text + btn3.Text;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            textDisplay.Text = textDisplay.Text + btn0.Text;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            option = "+";
            num1 = int.Parse(textDisplay.Text);
            textDisplay.Clear();
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            option = "-";
            num1 = int.Parse(textDisplay.Text);
            textDisplay.Clear();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            option = "/";
            num1 = int.Parse(textDisplay.Text);
            textDisplay.Clear();
        }

        // button *
        private void button17_Click(object sender, EventArgs e)
        {
            option = "*";
            num1 = int.Parse(textDisplay.Text);
            textDisplay.Clear();
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            option = "%";
            num1 = int.Parse(textDisplay.Text);
            textDisplay.Clear();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            num2 = int.Parse(textDisplay.Text);
            if (option == ("+")) {
                res = num1 + num2;
                historyList.Add(num1.ToString() + "+" + num2.ToString() + "=" + res.ToString());
            } else if (option == ("-")) {
                res = num1 - num2;
                historyList.Add(num1.ToString() + "-" + num2.ToString() + "=" + res.ToString());
            } else if (option == ("*")) {
                res = num1 * num2;
                historyList.Add(num1.ToString() + "*" + num2.ToString() + "=" + res.ToString());
            } else if (option == ("/")) {
                res = num1 / num2;
                historyList.Add(num1.ToString() + "/" + num2.ToString() + "=" + res.ToString());
            } else if (option == ("%")) {
                res = num1 % num2;
                historyList.Add(num1.ToString() + "%" + num2.ToString() + "=" + res.ToString());
            }

            textDisplay.Text = (res + "");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < historyList.Count(); i++)
            {
                textDisplay.AppendText(historyList[i]);
                textDisplay.AppendText(Environment.NewLine);
            }
        }
    }
}