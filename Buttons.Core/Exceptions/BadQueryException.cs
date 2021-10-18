using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buttons.Core.Exceptions
{
    public class BadQueryException : Exception
    {
        public BadQueryException() : base("bad query")
        {

        }
    }
}
