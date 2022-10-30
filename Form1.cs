namespace Calculator_WindowForms
{
    public partial class Form1 : Form
    {
        double FirstNumber;
        String Operation;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void n1_Click(object sender, EventArgs e)
        {
            if (displaybox.Text == "0" && displaybox.Text != null)
                displaybox.Text = "1";
            else
                displaybox.Text += "1";
        }

        private void n2_Click(object sender, EventArgs e)
        {
            if (displaybox.Text == "0" && displaybox.Text != null)
                displaybox.Text = "2";
            else
                displaybox.Text += "2";
        }

        private void n3_Click(object sender, EventArgs e)
        {
            if (displaybox.Text == "0" && displaybox.Text != null)
                displaybox.Text = "3";
            else
                displaybox.Text += "3";
        }

        private void n4_Click(object sender, EventArgs e)
        {
            if (displaybox.Text == "0" && displaybox.Text != null)
                displaybox.Text = "4";
            else
                displaybox.Text += "4";
        }

        private void n5_Click(object sender, EventArgs e)
        {
            if (displaybox.Text == "0" && displaybox.Text != null)
                displaybox.Text = "5";
            else
                displaybox.Text += "5";
        }

        private void n6_Click(object sender, EventArgs e)
        {
            if (displaybox.Text == "0" && displaybox.Text != null)
                displaybox.Text = "6";
            else
                displaybox.Text += "6";
        }

        private void n7_Click(object sender, EventArgs e)
        {
            if (displaybox.Text == "0" && displaybox.Text != null)
                displaybox.Text = "7";
            else
                displaybox.Text += "7";
        }

        private void n8_Click(object sender, EventArgs e)
        {
            if (displaybox.Text == "0" && displaybox.Text != null)
                displaybox.Text = "8";
            else
                displaybox.Text += "8";
        }

        private void n9_Click(object sender, EventArgs e)
        {
            if (displaybox.Text == "0" && displaybox.Text != null)
                displaybox.Text = "9";
            else
                displaybox.Text += "9";
        }

        private void n0_Click(object sender, EventArgs e)
        {
            displaybox.Text += "0";
        }

        

        private void bSub_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(displaybox.Text);
            //displaybox.Text = "0";
            displaybox.Clear();
            Operation = "-";
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(displaybox.Text);
            //displaybox.Text = "0";
            displaybox.Clear();
            Operation = "+";
        }

        private void bMul_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(displaybox.Text);
            //displaybox.Text = "0";
            displaybox.Clear();
            Operation = "*";
        }

        private void bDiv_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(displaybox.Text);
            //displaybox.Text = "0";
            displaybox.Clear();
            Operation = "/";
        }

        private void bClr_Click(object sender, EventArgs e)
        {
            displaybox.Text = "0";
        }

        private void bDot_Click(object sender, EventArgs e)
        {
            displaybox.Text += ".";
        }

        private void bEql_Click(object sender, EventArgs e)
        {
            double SecondNumber;
            double Result;
            SecondNumber= Convert.ToDouble(displaybox.Text);

            if (Operation == "+")
            {
                Result = (FirstNumber + SecondNumber);
                displaybox.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "-")
            {
                Result = (FirstNumber - SecondNumber);
                displaybox.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if(Operation == "*")
            {
                Result = (FirstNumber * SecondNumber);
                displaybox.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if(Operation == "/")
            {
                if (SecondNumber != 0)
                {
                    Result = (FirstNumber / SecondNumber);
                    displaybox.Text = Convert.ToString(Result);
                    FirstNumber = Result;
                }
                else
                {
                    displaybox.Text = "Cannot divide by Zero";
                }
            }
        }
    }
}