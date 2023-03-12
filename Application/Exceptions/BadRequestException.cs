using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Exceptions
{
    public class BadRequestException : Exception
    {
        public BadRequestException(string message) : base(message)
        {
        }
        public BadRequestException() : this("Not found")
        {
        }
        public BadRequestException(Exception ex) : this(ex.Message)
        {
        }
    }
}
