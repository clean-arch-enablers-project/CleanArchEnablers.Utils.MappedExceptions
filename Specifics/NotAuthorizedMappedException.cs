using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cae.Utils.MappedExceptions.Specifics
{
    public class NotAuthorizedMappedException : MappedException
    {
        public NotAuthorizedMappedException(string briefPublicMessage) : base(briefPublicMessage)
        {
        }

        public NotAuthorizedMappedException(string briefPublicMessage, string details) : base(briefPublicMessage, details)
        {
        }

        public NotAuthorizedMappedException(string briefPublicMessage, Exception originalException) : base(briefPublicMessage, originalException)
        {
        }

        public NotAuthorizedMappedException(string briefPublicMessage, string details, Exception originalException) : base(briefPublicMessage, details, originalException)
        {
        }
    }
}
