namespace Assignment4._1._2
{
    public partial class Form1 : Form, ICalculator //callin Icalculator
    {

        double firstNumber = 0;
        string Operation = "";




        public Form1()
        {
            InitializeComponent();
        }

        public void Add()   //this is you putting in all the Icalulator interface
        {
            firstNumber = Convert.ToDouble(ResultTextBox.Text);
            ResultTextBox.Text = "0";
            Operation = "+";
        }
        public void Subtract()
        {
            firstNumber = Convert.ToDouble(ResultTextBox.Text);
            ResultTextBox.Text = "0";
            Operation = "-";
        }
        public void Multiply()
        {
            firstNumber = Convert.ToDouble(ResultTextBox.Text);
            ResultTextBox.Text = "0";
            Operation = "*";
        }
        public void Divide()
        {
            firstNumber = Convert.ToDouble(ResultTextBox.Text);
            ResultTextBox.Text = "0";
            Operation = "/";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ResultTextBox.Text == "0" && ResultTextBox.Text != null)
            {
                ResultTextBox.Text = "1";
            }
            else
            {
                ResultTextBox.Text = ResultTextBox.Text + "1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ResultTextBox.Text == "0" && ResultTextBox.Text != null)
            {
                ResultTextBox.Text = "2";
            }
            else
            {
                ResultTextBox.Text = ResultTextBox.Text + "2";
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (ResultTextBox.Text == "0" && ResultTextBox.Text != null)
            {
                ResultTextBox.Text = "3";
            }
            else
            {
                ResultTextBox.Text = ResultTextBox.Text + "3";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (ResultTextBox.Text == "0" && ResultTextBox.Text != null)
            {
                ResultTextBox.Text = "4";
            }
            else
            {
                ResultTextBox.Text = ResultTextBox.Text + "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (ResultTextBox.Text == "0" && ResultTextBox.Text != null)
            {
                ResultTextBox.Text = "5";
            }
            else
            {
                ResultTextBox.Text = ResultTextBox.Text + "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (ResultTextBox.Text == "0" && ResultTextBox.Text != null)
            {
                ResultTextBox.Text = "6";
            }
            else
            {
                ResultTextBox.Text = ResultTextBox.Text + "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (ResultTextBox.Text == "0" && ResultTextBox.Text != null)
            {
                ResultTextBox.Text = "7";
            }
            else
            {
                ResultTextBox.Text = ResultTextBox.Text + "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (ResultTextBox.Text == "0" && ResultTextBox.Text != null)
            {
                ResultTextBox.Text = "8";
            }
            else
            {
                ResultTextBox.Text = ResultTextBox.Text + "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (ResultTextBox.Text == "0" && ResultTextBox.Text != null)
            {
                ResultTextBox.Text = "9";
            }
            else
            {
                ResultTextBox.Text = ResultTextBox.Text + "9";
            }
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (ResultTextBox.Text == "0" && ResultTextBox.Text != null)
            {
                ResultTextBox.Text = "0";
            }
            else
            {
                ResultTextBox.Text = ResultTextBox.Text + "0";
            }
        }

        private void buttonPeriod_Click(object sender, EventArgs e)
        {
            if (ResultTextBox.Text == "0" && ResultTextBox.Text != null)
            {
                ResultTextBox.Text = ".";
            }
            else
            {
                ResultTextBox.Text = ResultTextBox.Text + ".";
            }
        }

        private void buttonbackSpace_Click(object sender, EventArgs e)
        {
            if (ResultTextBox.Text == "0" && ResultTextBox.Text != null)
            {
                ResultTextBox.Text = "0";
            }
            else
            {
                ResultTextBox.Text = "0";
            }
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            Subtract();
        }

        private void buttonmultiply_Click(object sender, EventArgs e)                                                                           
        {
            Multiply();
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            Divide();
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {

            double secondNumber = Convert.ToDouble(ResultTextBox.Text);
            double result;
            
            switch (Operation)
            {
                case "+":
                    result = (firstNumber + secondNumber);
                    ResultTextBox.Text = Convert.ToString(result);
                    break;
                case "-":
                    result = (firstNumber - secondNumber);
                    ResultTextBox.Text = Convert.ToString(result);
                    break;
                case "*":
                    result = (firstNumber * secondNumber);
                    ResultTextBox.Text = Convert.ToString(result);
                    break;
                case "/":
                    if (secondNumber > 0)
                    {
                        result = (firstNumber / secondNumber);
                        ResultTextBox.Text = Convert.ToString(result);
                    }
                    else
                    {
                        ResultTextBox.Text = "Cannot divide by 0";
                    }
                    break;

            }
        }
    }
}
