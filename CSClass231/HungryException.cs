using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSClass231
{
    class HungryException : Exception
    {
        public HungryException(string message) : base(message)
        {
        }
    }
}
