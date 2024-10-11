namespace caculator
{
    public partial class Form1 : Form
    {
        double result = 0;
        string operation = "";
        bool isOperationPerformed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btsqrt_Click(object sender, EventArgs e)
        {
            result = Math.Sqrt(Double.Parse(textBox1.Text));
            textBox1.Text = result.ToString();
        }

        private void btMR_Click(object sender, EventArgs e)
        {
            textBox1.Text = result.ToString();
        }

        private void btm_Click(object sender, EventArgs e)
        {
            result = 0;
            textBox1.Text = "0";
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            result = 0;
            isOperationPerformed = false;
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0") || (isOperationPerformed))
                textBox1.Clear();

            isOperationPerformed = false;
            textBox1.Text = textBox1.Text + "1";
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0") || (isOperationPerformed))
                textBox1.Clear();

            isOperationPerformed = false;
            textBox1.Text = textBox1.Text + "2";
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0") || (isOperationPerformed))
                textBox1.Clear();

            isOperationPerformed = false;
            textBox1.Text = textBox1.Text + "3";
        }

        private void btcong_Click(object sender, EventArgs e)
        {
            operation = "+";
            result = Double.Parse(textBox1.Text);
            isOperationPerformed = true;
        }

        private void bt4_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0") || (isOperationPerformed))
                textBox1.Clear();

            isOperationPerformed = false;
            textBox1.Text = textBox1.Text + "4";
        }

        private void bt5_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0") || (isOperationPerformed))
                textBox1.Clear();

            isOperationPerformed = false;
            textBox1.Text = textBox1.Text + "5";
        }

        private void bt6_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0") || (isOperationPerformed))
                textBox1.Clear();

            isOperationPerformed = false;
            textBox1.Text = textBox1.Text + "6";
        }

        private void bttru_Click(object sender, EventArgs e)
        {
            operation = "-";
            result = Double.Parse(textBox1.Text);
            isOperationPerformed = true;
        }

        private void bt7_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0") || (isOperationPerformed))
                textBox1.Clear();

            isOperationPerformed = false;
            textBox1.Text = textBox1.Text + "7";
        }

        private void bt8_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0") || (isOperationPerformed))
                textBox1.Clear();

            isOperationPerformed = false;
            textBox1.Text = textBox1.Text + "8";
        }

        private void bt9_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0") || (isOperationPerformed))
                textBox1.Clear();

            isOperationPerformed = false;
            textBox1.Text = textBox1.Text + "9";
        }

        private void btnhan_Click(object sender, EventArgs e)
        {
            operation = "*";
            result = Double.Parse(textBox1.Text);
            isOperationPerformed = true;
        }

        private void bt0_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0")
                textBox1.Text = textBox1.Text + "0";
        }

        private void btbang_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                    textBox1.Text = (result + Double.Parse(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text = (result - Double.Parse(textBox1.Text)).ToString();
                    break;
                case "*":
                    textBox1.Text = (result * Double.Parse(textBox1.Text)).ToString();
                    break;
                case "/":
                    if (textBox1.Text != "0")
                        textBox1.Text = (result / Double.Parse(textBox1.Text)).ToString();
                    else
                        MessageBox.Show("Cannot divide by zero");
                    break;
            }
            isOperationPerformed = false;
        }

        private void btconghoactru_Click(object sender, EventArgs e)
        {
            double temp = Double.Parse(textBox1.Text);
            temp = -temp;
            textBox1.Text = temp.ToString();
        }

        private void btchia_Click(object sender, EventArgs e)
        {
            operation = "/";
            result = Double.Parse(textBox1.Text);
            isOperationPerformed = true;
        }
    }
}
