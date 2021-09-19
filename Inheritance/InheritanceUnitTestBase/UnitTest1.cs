using Inheritance;
using NUnit.Framework;
using System.Collections.Generic;

namespace InheritanceUnitTestBase
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void Test1()
        {
            ICalculation<int> CalcObj = Calculations.GetCalculationInstance;
           int value=CalcObj.Add(new List<int>{1,2,3});
            CalcObj.Log(new List<string>() { "Unit test Base"});
            int mathvalues = CalcObj.Add(new List<int> { 1, 2, 3 });
            Assert.AreEqual(6, value);
            
        }
    }
}