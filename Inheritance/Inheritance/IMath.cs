using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
   public interface IMath<T>
    {
        public int Multiply(List<T> values);

    }
}
