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
        private string secondValue;
        private string currentOperation = "";

        private void number_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
                textBox.Text = string.Empty;
            string clickedValue = (sender as Button).Text;
            textBox.Text += clickedValue;

            if (currentOperation != "")
                secondValue += clickedValue;
        }

        private void operation_Click(object sender, EventArgs e)
        {
            var operation = (sender as Button).Text;
            firstValue = textBox.Text;
            textBox.Text += $"{operation}";

            currentOperation = operation switch
            {
                "+" => "+",
                "-" => "-",
                "/" => "/",
                "*" => "*",
                "x^2" =>"x^2",
                "1/x" => "1/x",
                ""=> "",
            };
        }
        private void clear_Click(object sender, EventArgs e)
        {
            
        }
        private double Calculate(double firstNumber, double secondNumber)
        {
            switch (currentOperation)
            {
                case "":
                    return firstNumber;
                case "+":
                    return firstNumber + secondNumber;
                case "-":
                    return firstNumber - secondNumber;
                case "*":
                    return firstNumber * secondNumber;
                case "/":
                    if (secondNumber == 0)
                    {
                        MessageBox.Show("Nie mo¿na dzieliæ przez 0");
                        return 0;
                    }
                    else
                    {
                        return firstNumber / secondNumber;
                    }
                
               }
            return 0;
         }
        private void result_Click(object sender, EventArgs e)
        {
            var firstNumber = double.Parse(firstValue);
            var secondNumber = double.Parse(secondValue);
            var result = Calculate(firstNumber, secondNumber);

            textBox.Text = result.ToString();

            secondValue = string.Empty;
            currentOperation = "";


        }



    }
}
