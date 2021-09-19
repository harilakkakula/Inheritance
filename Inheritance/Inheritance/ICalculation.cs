using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
   public interface ICalculation<T>:ILogger<String>, IMath<int>
    {
        int Add(List<T> value);
    }
}
