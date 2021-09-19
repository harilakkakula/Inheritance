using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
   public sealed class Calculations : ICalculation<int>
    {
        private  static Calculations calculationsinstance=null;
        int Counter = 0;
        public static Calculations GetCalculationInstance
        {
            get
            {
                if(calculationsinstance==null)
                {
                    calculationsinstance = new Calculations();
                }
                return calculationsinstance;
            }
          
        }
        private  Calculations()
        {
            Console.WriteLine($"No.Of Instance {Counter++}");
        }
        public int Add(List<int> value)
        {
            int sumvalue = value.Sum();               
            Console.WriteLine($"Sum of Value {sumvalue}");
            return sumvalue;
        }

        public void Log(List<string> message)
        {
            Console.WriteLine($"Read the Message :{message}");
        }

        public int Multiply(List<int> values)
        {
            return values.Sum();
        }
    }
}
