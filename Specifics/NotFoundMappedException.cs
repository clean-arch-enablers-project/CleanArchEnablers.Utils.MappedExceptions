using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cae.Utils.MappedExceptions.Specifics
{
    public class NotFoundMappedException : MappedException
    {
        public NotFoundMappedException(string briefPublicMessage) : base(briefPublicMessage)
        {
        }

        public NotFoundMappedException(string briefPublicMessage, string details) : base(briefPublicMessage, details)
        {
        }

        public NotFoundMappedException(string briefPublicMessage, Exception originalException) : base(briefPublicMessage, originalException)
        {
        }

        public NotFoundMappedException(string briefPublicMessage, string details, Exception originalException) : base(briefPublicMessage, details, originalException)
        {
        }
    }
}
