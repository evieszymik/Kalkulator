using System.Text;
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
        private string auxValue="";
        private string secondValue="";
        private string operation;
        private bool isLastOperation = false;
        private bool newSecond = false;
        private bool isResult = false;
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
        private Operation previousOperation = Operation.None;
        private Operation auxOperation = Operation.None;

        private void number_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
                textBox.Text = string.Empty;

            value = Convert.ToDouble((sender as Button).Text);
            if(!isResult)
            {
                textBox.Text += value;
                if (newSecond)
                    secondValue = string.Empty;
                if (currentOperation != Operation.None)
                {
                    newSecond = false;
                    secondValue += value;
                }
               
            }
            else
            {
                textBox.Text = value.ToString();
                isResult = false;
                currentOperation = Operation.None;
                secondValue = string.Empty;
            }
            
            
            
            isLastOperation = false;
            add.Enabled = true;
            minus.Enabled = true;
            multiply.Enabled = true;
            divide.Enabled = true;
            kwadrat.Enabled = true;
            mianownik.Enabled = true;
            point.Enabled = true;
        }

       
        private void add_Click(object sender, EventArgs e)
        {
            if(isResult)
            {
                currentOperation = Operation.None;
                secondValue = string.Empty;
            }

                
                if (currentOperation == Operation.None)
                {
                    firstValue = textBox.Text;

                }
                else
                {
                    if (auxValue != string.Empty)
                    {
                        secondValue = Calculate(currentOperation).ToString(); ;
                        firstValue = auxValue;
                        firstValue = (Calculate(auxOperation)).ToString();
                        auxValue = string.Empty;

                    }
                    else
                    {
                        previousOperation = currentOperation;
                        firstValue = Calculate(previousOperation).ToString();
                    }

                }
                textBox.Text += "+";
            operation = "+";
                currentOperation = Operation.Add;
                newSecond = true;
            isLastOperation = true;
            add.Enabled = false;
            minus.Enabled = false;
            multiply.Enabled = false;
            divide.Enabled = false;
            kwadrat.Enabled = false;
            mianownik.Enabled = false;
            point.Enabled = false;
            isResult = false;
        }
        private void substract_Click(object sender, EventArgs e)
        {
            if (isResult)
            {
                currentOperation = Operation.None;
                secondValue = string.Empty;
            }
            if (currentOperation == Operation.None)
            {
                firstValue = textBox.Text;

            }
            else
            {
                if (auxValue != string.Empty)
                {
                    secondValue = Calculate(currentOperation).ToString(); ;
                    firstValue = auxValue;
                    firstValue = (Calculate(auxOperation)).ToString();
                    auxValue = string.Empty;

                }
                else
                {
                    previousOperation = currentOperation;
                    firstValue = Calculate(previousOperation).ToString();
                }
            }
            textBox.Text += "-";
            currentOperation = Operation.Substract;
            newSecond = true;
            
            add.Enabled = false;
            minus.Enabled = false;
            multiply.Enabled = false;
            divide.Enabled = false;
            isLastOperation = true;
            kwadrat.Enabled = false;
            mianownik.Enabled = false;
            operation = "-";
            isResult = false;
            point.Enabled = false;
        }
        private void multiply_Click(object sender, EventArgs e)
        {
            if (isResult)
            {
                currentOperation = Operation.None;
                secondValue = string.Empty;
            }
            if (currentOperation == Operation.None)
            {
                firstValue = textBox.Text;

            }
            else
            {
                previousOperation = currentOperation;
                if(previousOperation==Operation.Add || previousOperation==Operation.Substract)
                {
                    auxValue = firstValue;
                    auxOperation = previousOperation;
                    firstValue = secondValue;
                }
                else
                {
                    firstValue = Calculate(previousOperation).ToString();
                }
                
            }
            textBox.Text += "*";
            currentOperation = Operation.Multiply;
            newSecond = true;
           
            add.Enabled = false;
            minus.Enabled = false;
            multiply.Enabled = false;
            divide.Enabled = false;
            isLastOperation = true;
            operation = "*";
            kwadrat.Enabled = false;
            mianownik.Enabled = false;
            isResult = false;
            point.Enabled = false;
        }

        private void divide_Click(object sender, EventArgs e)
        {
            if (isResult)
            {
                currentOperation = Operation.None;
                secondValue = string.Empty;
            }
            if (currentOperation == Operation.None)
            {
                firstValue = textBox.Text;

            }
            else
            {
                previousOperation = currentOperation;
                if (previousOperation == Operation.Add || previousOperation == Operation.Substract)
                {
                    auxValue = firstValue;
                    auxOperation = previousOperation;
                    firstValue = secondValue;
                }
                else
                {
                    firstValue = Calculate(previousOperation).ToString();
                    
                }

            }
            textBox.Text += "/";
            currentOperation = Operation.Divide;
            newSecond = true;
            
            add.Enabled = false;
            minus.Enabled = false;
            multiply.Enabled = false;
            divide.Enabled = false;
            isLastOperation = true;
            operation = "/";
            kwadrat.Enabled = false;
            mianownik.Enabled = false;
            isResult = false;
            point.Enabled = false;
        }


        private double Calculate(Operation operation)
        {
            switch(operation)
            {
                case Operation.Add:
                    return Double.Parse(firstValue) + Double.Parse(secondValue);
                case Operation.Substract:
                    return Double.Parse(firstValue) - Double.Parse(secondValue);
                case Operation.Multiply:
                    return Double.Parse(firstValue) * Double.Parse(secondValue);
                case Operation.Divide:
                    if (secondValue == "0")
                    {
                        textBox.Text = "Nie mo¿na dzieliæ przez 0!";
                        return 0;
                    }
                    return Double.Parse(firstValue) / Double.Parse(secondValue);
            }
            return 0;
        }
        private void clear_Click(object sender, EventArgs e)
        {
            textBox.Text = "0";
            currentOperation = Operation.None;
            previousOperation = Operation.None;
            auxOperation = Operation.None;
            isLastOperation = false;
            firstValue = string.Empty;
            secondValue = string.Empty;
            auxValue = string.Empty;
            isLastOperation = false;
            add.Enabled = true;
            minus.Enabled = true;
            multiply.Enabled = true;
            divide.Enabled = true;
            kwadrat.Enabled = true;
            mianownik.Enabled = true;
            point.Enabled = true;
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
                if(secondValue=="0")
                {
                    textBox.Text = "Nie mo¿na dzieliæ przez 0!";
                }
                else
                {
                    double result = Calculate(currentOperation);
                    MessageBox.Show(secondValue);
                    if (auxValue != string.Empty)
                    {
                        firstValue = auxValue;
                        secondValue = result.ToString();
                        result = Calculate(auxOperation);
                    }

                    textBox.Text = result.ToString();
                    firstValue = textBox.Text;

                    
                }
                
            }
            
            add.Enabled = true;
            minus.Enabled = true;
            multiply.Enabled = true;
            divide.Enabled = true;
            kwadrat.Enabled = true;
            mianownik.Enabled = true;
            point.Enabled = true;
            isResult = true;
        }
        private void kwadrat_Click(object sender, EventArgs e)
        {
            if (isResult)
            {
                currentOperation = Operation.None;
                secondValue = string.Empty;
            }
            double val;
            
            if (secondValue=="")
            {
                val = Double.Parse(textBox.Text);
                textBox.Text = (val * val).ToString();
                add.Enabled = true;
                minus.Enabled = true;
                multiply.Enabled = true;
                divide.Enabled = true;
            }
            else
            {
                val = Double.Parse(secondValue);
                textBox.Text=textBox.Text.Replace(secondValue, (val * val).ToString());
                secondValue = (val * val).ToString();
                
            }



        }
        private void mianownik_Click(object sender, EventArgs e)
        {
            if (isResult)
            {
                currentOperation = Operation.None;
                secondValue = string.Empty;
            }
            double val;
            if (secondValue == "")
            {
                val = Double.Parse(textBox.Text);
                textBox.Text = (1/ val).ToString();
                add.Enabled = true;
                minus.Enabled = true;
                multiply.Enabled = true;
                divide.Enabled = true;
            }
            else
            {
                val = Double.Parse(secondValue);
                textBox.Text = textBox.Text.Replace(secondValue, (1/val).ToString());
                secondValue = (1/ val).ToString();

            }
        }

        private void changeSign_Click(object sender, EventArgs e)
        {
            if (isResult)
            {
                currentOperation = Operation.None;
                secondValue = string.Empty;
            }
            double val;
            if (secondValue == "" && currentOperation==Operation.None)
            {
                val = Double.Parse(textBox.Text);
                textBox.Text = (-val).ToString();
                
            }
            else if(secondValue == "" && currentOperation != Operation.None)
            {
                val = Double.Parse(firstValue);
                textBox.Text = textBox.Text.Replace(firstValue, (-val).ToString());
                firstValue = (-val).ToString();

            }
            else
            {
                val = Double.Parse(secondValue);
                textBox.Text = textBox.Text.Replace(secondValue, (-val).ToString());
                secondValue = (-val).ToString();
                
            }

        }

        private void point_Click(object sender, EventArgs e)
        {
            point.Enabled = false;
            add.Enabled = false;
            minus.Enabled = false;
            multiply.Enabled = false;
            divide.Enabled = false;

            if (!isLastOperation)
            {
                if (textBox.Text == "0")
                {
                    textBox.Text = "0.";
                }
                else
                {
                    if(secondValue!="")
                    {
                        secondValue += ".";
                    }
                    textBox.Text += ".";
                }
                isLastOperation = true;
            }
            
        }
    }
}
