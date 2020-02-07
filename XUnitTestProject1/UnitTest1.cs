using mycalculator;
using System;
using Xunit;
using Moq;
using static mycalculator.Form1;

namespace XUnitTestProject1
{
    public class UnitTest1
    {

        [Fact]

        public void GetNameTestforaddition()
        {
            //Arrange  
            Form1  addition = new Form1 ();
            double number1 = 50;
            double number2 = 100;
            double result = addition.GetAddition(number1, number2);
            Assert.Equal(150, result);
        }
        [Fact]

        public void GetNameTestforsubtration()
        {
            //Arrange  
            Form1 addition = new Form1();
            double number1 = 100;
            double number2 = 100;
            double result = addition.GetSubtration(number1, number2);
            Assert.Equal(0, result);
        }

    }
}
