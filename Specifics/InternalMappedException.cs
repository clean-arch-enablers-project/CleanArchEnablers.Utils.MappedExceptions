using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Cae.Utils.MappedExceptions.Specifics
{
    /// <summary>
    /// More specific type of MappedException thought to cover cases in
    /// which something went wrong internally during the execution of
    /// your application.Maybe some remote call received an unexpected
    /// status code and your application ain't prepared for handling it,
    /// maybe some implementation that is dispatching your use case
    /// called your primary port passing an object that doesn't meet your
    /// requirements, so you check it and throw an
    /// InternalMappedException, which would be similar to, in HTTP,
    /// returning a 5xx status code.
    /// </summary>
    public class InternalMappedException : MappedException
    {
        public InternalMappedException(string briefPublicMessage) : base(briefPublicMessage)
        {
        }

        public InternalMappedException(string briefPublicMessage, string details) : base(briefPublicMessage, details)
        {
        }

        public InternalMappedException(string briefPublicMessage, Exception originalException) : base(briefPublicMessage, originalException)
        {
        }

        public InternalMappedException(string briefPublicMessage, string details, Exception originalException) : base(briefPublicMessage, details, originalException)
        {
        }
    }
}
