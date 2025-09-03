using System.Collections.Generic;

namespace CleanArchEnablers.Utils.MappedExceptions
{
    public class MappedException : Exception
    {
        protected string BriefPublicMessage { get; init; }

        protected string? Details { get; init; }

        protected Exception? OriginalException { get; init; }

        public MappedException(string briefPublicMessage, string details) : base(briefPublicMessage + " | " + details)
        {

            BriefPublicMessage = briefPublicMessage;
            Details = details;
            OriginalException = null;
        }

        public MappedException(string briefPublicMessage) : base(briefPublicMessage)
        {

            BriefPublicMessage = briefPublicMessage;
            Details = null;
            OriginalException = null;
        }

        public MappedException(string briefPublicMessage, string details, Exception originalException) : base(briefPublicMessage + " | " + details + " | Original: " + originalException)
        {

            BriefPublicMessage = briefPublicMessage;
            Details = details;
            OriginalException = originalException;
        }

        public MappedException(string briefPublicMessage, Exception originalException) : base(briefPublicMessage + " | Original: " + originalException)
        {

            BriefPublicMessage = briefPublicMessage;
            Details = null;
            OriginalException = originalException;
        }

        public IEnumerable<string> GetLinesFromStackTraceFromOriginalException(int numberOfLines)
        {
            if (OriginalException == null)
                return [];

            return GetLinesFromStackTraceAsString(this, numberOfLines);
        }

        public IEnumerable<string> GetLinesFromStackTrace(int numberOfLines)
        {
            return GetLinesFromStackTraceAsString(this, numberOfLines);
        }

        public static IEnumerable<string> GetLinesFromStackTraceAsString(Exception exception, int numberOfLines)
        {
            var allLines = new List<string> { exception.StackTrace ?? "" };
            var linesToReturn = new List<string>();
            var counter = 0;
            var maxCount = allLines.Count < numberOfLines ? allLines.Count : numberOfLines;
            while (counter < maxCount)
            {
                var line = allLines.ElementAt(counter);
                linesToReturn.Add(line.ToString());
                counter++;
            }
            if (allLines.Count > numberOfLines)
            {
                var lastLine = allLines.Count - numberOfLines + " hidden line(s)";
                linesToReturn.Add(lastLine);
            }
            return linesToReturn;
        }

        protected string GetFullStackTraceAsString()
        {
            if (OriginalException == null)
            {
                return string.Empty;
            }

            var stringWriter = new StringWriter();
            stringWriter.WriteLine(OriginalException.ToString());
            return stringWriter.ToString();
        }
    }
}
