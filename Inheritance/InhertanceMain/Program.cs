using Inheritance;
using System;

namespace InhertanceMain
{
    class Program
    {
        
        static void Main(string[] args)
        {
            ICalculation<int> claobje = Calculations.GetCalculationInstance;
            claobje.Add(new System.Collections.Generic.List<int> { 1,2,3});
            Console.Read();

        }
    }
}
