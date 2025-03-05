using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cae.Utils.MappedExceptions.Specifics
{
    public class NotAuthenticatedMappedException : MappedException
    {
        public NotAuthenticatedMappedException(string briefPublicMessage) : base(briefPublicMessage)
        {
        }

        public NotAuthenticatedMappedException(string briefPublicMessage, string details) : base(briefPublicMessage, details)
        {
        }

        public NotAuthenticatedMappedException(string briefPublicMessage, Exception originalException) : base(briefPublicMessage, originalException)
        {
        }

        public NotAuthenticatedMappedException(string briefPublicMessage, string details, Exception originalException) : base(briefPublicMessage, details, originalException)
        {
        }
    }
}
