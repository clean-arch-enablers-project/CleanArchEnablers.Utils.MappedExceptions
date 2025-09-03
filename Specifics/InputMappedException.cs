using CleanArchEnablers.Utils.MappedExceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchEnablers.Utils.MappedExceptions.Specifics
{
    public class InputMappedException : MappedException
    {
        public InputMappedException(string briefPublicMessage) : base(briefPublicMessage)
        {
        }

        public InputMappedException(string briefPublicMessage, string details) : base(briefPublicMessage, details)
        {
        }

        public InputMappedException(string briefPublicMessage, Exception originalException) : base(briefPublicMessage, originalException)
        {
        }

        public InputMappedException(string briefPublicMessage, string details, Exception originalException) : base(briefPublicMessage, details, originalException)
        {
        }
    }
}
