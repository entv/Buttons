using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buttons.Core.Exceptions
{
    public class ElementDoesNotExistException : Exception
    {
        public ElementDoesNotExistException() : base("there is no element with such an index")
        {

        }
    }
}
