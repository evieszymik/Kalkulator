using System.Windows.Forms;

namespace Kalkulator
{
    public partial class Kalkulator : Form
    {
        public Kalkulator()
        {
            InitializeComponent();
            textBox.Text = "0";
        }


        private string firstValue;
        private string currentValue;
        private string secondValue="";
        private string operation;
        private bool isLastOperation = false;
        double value;

        enum Operation
        {
            Add,
            Substract,
            Multiply,
            Divide,
            None,
        }
        private Operation currentOperation = Operation.None;

        private void number_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
                textBox.Text = string.Empty;

           // value = Convert.ToDouble((sender as Button).Text);
            currentValue = (sender as Button).Text;
            textBox.Text += value;

            if (currentOperation != Operation.None)
                secondValue += value;
            isLastOperation = false;
        }

        private void operation_Click(object sender, EventArgs e)
        {
            if (!isLastOperation)
            {
                operation = (sender as Button).Text;
                firstValue = textBox.Text;
                textBox.Text += $"{operation}";

                currentOperation = operation switch
                {
                    "+" => Operation.Add,
                    "-" => Operation.Substract,
                    "*" => Operation.Multiply,
                    "/" => Operation.Divide,
                    _ => Operation.None
                };
                isLastOperation = true;
            }

        }
        private void clear_Click(object sender, EventArgs e)
        {
            textBox.Text = "0";
            currentOperation = Operation.None;
            isLastOperation = false;

        }
        private double Calculate(double firstNumber, double secondNumber)
        {
            switch (currentOperation)
            {
                case Operation.Add:
                    return firstNumber + secondNumber;
                case Operation.Substract:
                    return firstNumber - secondNumber;
                case Operation.Multiply:
                    return firstNumber * secondNumber;
                case Operation.Divide:
                    if (secondNumber == 0)
                    {
                        MessageBox.Show("Nie mo¿na dzieliæ przez 0!");
                        return 0;
                    }
                    return firstNumber / secondNumber;
            }
            return 0;
        }
        private void result_Click(object sender, EventArgs e)
        {
            if(secondValue=="")
            {
                textBox.Text = value.ToString();
                isLastOperation = false;
                
            }
            else
            {
                double second = Double.Parse(secondValue);
                double first = Double.Parse(firstValue);
                double result = Calculate(first, second);

                textBox.Text = result.ToString();

                
                secondValue = string.Empty;
            }
            currentOperation = Operation.None;





        }
        private void kwadrat_Click(object sender, EventArgs e)
        {
            double val;
            if (!isLastOperation)
            {
                val = Double.Parse(textBox.Text);
                textBox.Text = (val * val).ToString();
            }
            else
            {
                val = Double.Parse(firstValue);
                textBox.Text = (val * val).ToString() + operation;
            }



        }
        private void mianownik_Click(object sender, EventArgs e)
        {
            double val;
            if (currentOperation == Operation.None)
            {
                val = Double.Parse(textBox.Text);
                textBox.Text = (1 / val).ToString();
            }
            else
            {
                secondValue = (1 / Double.Parse(secondValue)).ToString();
                textBox.Text = firstValue + $"{operation}" + secondValue.ToString();
            }



        }

        private void changeSign_Click(object sender, EventArgs e)
        {
            if (currentOperation == Operation.None)
            {
                double val = Double.Parse(textBox.Text);
                textBox.Text = (-val).ToString();
            }
            else
            {
                secondValue = (-Double.Parse(secondValue)).ToString();
                textBox.Text = firstValue + operation + secondValue.ToString();
            }

        }

        private void point_Click(object sender, EventArgs e)
        {
            if(!isLastOperation)
            {
                if (textBox.Text == "0")
                {
                    textBox.Text = "0,";
                }
                else
                {
                    textBox.Text += ",";
                }
                isLastOperation = true;
            }
            
        }
    }
}
