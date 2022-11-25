using NUnit.Framework;
using ConsoleCalc;

namespace ConsoleCalcTest
{
    [TestFixture]
    public class CalcOperatiosUnitTests
    {

        [Test]
        public void Add_Operation()
        {
            //ARRANGE
            var calc = new CalcPage();

            //ACT
            var result = calc.Add(15, 25);

            //ASSERT
            Assert.AreEqual(40, result);
        }
        [Test]
        public void Subtract_Operation()
        {
            //ARRANGE

            var calc = new CalcPage();
            //ACT
            var result = calc.Subtract(15, 25);
            //ASSERT
            Assert.AreEqual(-10, result, "The function is not working properly");
        }
        [Test]  
        public void Multiply_Operation()
        {
            //ARRANGE
            var calc = new CalcPage();
            //ACT
            var result= calc.Multiply(15, 3);
            //ASSERT
            Assert.AreEqual(45, result, "The function is not working properly");

        }
        [Test]  
        public void Divide_Operation()
        {
            //ARRANGE
            var calc = new CalcPage();
            //ACT
            var result=calc.Divide(15.9, 3.18);
            //ASSERT
            Assert.AreEqual(5, result, "The function is not working properly");
        }
        [Test]    
        public void RaisingPower_Operation()
        {
            //ARRANGE
            var calc = new CalcPage();
            //ACT
            var result = calc.RaisingPower(2, 6);
            //ASSERT
            Assert.AreEqual(64, result, "The function is not working properly");
        }
        [Test]  
        public void PercentOfNumber_Operation()
        {
            //ARANGE
            var calc = new CalcPage();
            //ACT
            var result = calc.PercentOfNumber(45.4, 15);
            //ASSERT
            Assert.AreEqual(6.81, result);

        }
    }
}