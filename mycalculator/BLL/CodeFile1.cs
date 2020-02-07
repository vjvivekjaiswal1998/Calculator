using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mycalculator
{
    public partial class Form1 : Form
    {
        double FirstNumber;
        double SecondNumber;
        double Result;

        public int Equal_Click()
        {
            throw new NotImplementedException();
        }

        string Operation;
        public Form1()
        {
            InitializeComponent();
        }

        private void Number0_Click(object sender, EventArgs e)
        {
            Enternumber("0");
        }

        private void Number1_Click(object sender, EventArgs e)
        {
            Enternumber("1");
        }

        private void Number2_Click(object sender, EventArgs e)
        {
            Enternumber("2");
        }

        private void Number3_Click(object sender, EventArgs e)
        {
            Enternumber("3");
        }

        private void Number4_Click(object sender, EventArgs e)
        {
            Enternumber("4");
        }

        private void Number5_Click(object sender, EventArgs e)
        {
            Enternumber("5");
        }

        private void Number6_Click(object sender, EventArgs e)
        {
            Enternumber("6");
        }

        private void Number7_Click(object sender, EventArgs e)
        {
            Enternumber("7");
        }

        private void Number8_Click(object sender, EventArgs e)
        {
            Enternumber("8");
        }

        private void Number9_Click(object sender, EventArgs e)
        {
            //if (textBox1.Text == "0" && textBox1.Text != null)
            //{
            //    textBox1.Text = "9";
            //}
            //else
            //{
            //    textBox1.Text = textBox1.Text + "9";
            //}
            Enternumber("9");
        }

        private void Dot_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";
        }

        private void Addition_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Operation = "+";
        }

        private void Subtraction_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Operation = "-";
        }

        private void Multiplication_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Operation = "*";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Operation = "/";
        }

        private void Clear16_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

      //  public class Solution
      //  {
            
            public double GetAddition(double FirstNumber, double SecondNumber)
            {
                Result = FirstNumber + SecondNumber;
            textBox1.Text = Convert.ToString(Result);
            FirstNumber = Result;
            return Result;
          

        }
            public double GetSubtration(double FirstNumber, double SecondNumber)
            {
                Result = FirstNumber - SecondNumber;
                return Result;

            }


            //public double GetAdd(double FirstNumber, double SecondNumber)
            //{
            //    double result = FirstNumber + SecondNumber;
            //    return result;

            //}
            //public string GetName(string firstName, string lastName)
            //{
            //    return string.Concat(firstName, " ", lastName);
            //}



            public void Equal_Click(object sender, EventArgs e)
            {
                SecondNumber = Convert.ToDouble(textBox1.Text);
                double Result;
                switch (Operation)
                {
                    case "+":
                    //{
                    //  Result = (FirstNumber + SecondNumber);
                    GetAddition(FirstNumber, SecondNumber);
                        //textBox1.Text = Convert.ToString(Result);
                        //FirstNumber = Result;

                        // }
                        break;

                    case "-":
                        Result = (FirstNumber - SecondNumber);
                        textBox1.Text = Convert.ToString(Result);
                        FirstNumber = Result;
                        break;
                    case "*":
                        Result = (FirstNumber * SecondNumber);
                        textBox1.Text = Convert.ToString(Result);
                        FirstNumber = Result;
                        break;
                    case "/":
                        if (SecondNumber == 0)
                        {
                            textBox1.Text = "Cannot divide by zero";
                        }
                        else
                        {
                            Result = (FirstNumber / SecondNumber);
                            textBox1.Text = Convert.ToString(Result);
                            FirstNumber = Result;
                        }


                        //try
                        //{
                        //    Result = FirstNumber / SecondNumber;
                        //    textBox1.Text = Convert.ToString(Result);
                        //    FirstNumber = Result;
                        //}
                        //catch (Exception v)
                        //{
                        //    // Console.WriteLine("Exception caught: {0}", v);
                        //    textBox1.Text = "Cannot divide by zero";
                        //}
                        //finally
                        //{
                        //    Console.WriteLine("Result: {0}", Result);
                        //}

                        break;



                    case "%":
                        Result = (FirstNumber * SecondNumber) / 100;
                        textBox1.Text = Convert.ToString(Result);
                        FirstNumber = Result;
                        break;
                    default:
                        break;
                }
            }
      //  }
        private void NegativeOrPositive_Click(object sender, EventArgs e)
        {
            string Number = textBox1.Text;
            if (Number != "0" && Number != "")
            {
                if (Number.StartsWith("-"))
                {
                    textBox1.Text = Number.Substring(1);
                }

                else
                {
                    textBox1.Text = "-" + textBox1.Text;
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Percentage_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Operation = "%";
            //SecondNumber = Convert.ToDouble(textBox1.Text);
            //if (Operation.Equals("-"))
            //{
            //     double Sum = (FirstNumber*SecondNumber)/100;
            //   // double Sum = (FirstNumber / 100)*SecondNumber;
            //    double SumFinal=FirstNumber - Sum;
            //  //  double result = FirstNumber - SumFinal;
            //    textBox1.Text = Convert.ToString(SumFinal);               
            //}
            //else
            //{
            //     double Sum = (FirstNumber * SecondNumber) / 100;
            //    //double Sum = (FirstNumber / 100) * SecondNumber;
            //    double SumFinal = FirstNumber + Sum;
            //    textBox1.Text = Convert.ToString(SumFinal);
            //}           
        }
        private void Enternumber(String _numberByUser)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = _numberByUser;
            }
            else
            {
                textBox1.Text = textBox1.Text + _numberByUser;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
