using System;
using System.Collections.Generic;
using System.Text;

namespace UserRegexExceptionHandlingUC_7
{
    public class ExceptionHandling : Exception
    {
        public enum ExceptionType
        {
            NULL_FIELD,
            INVALID_INPUT,
        }
        private readonly ExceptionType type;
        public ExceptionHandling(ExceptionType Type, string message) : base(message)
        {
            this.type = Type;
        }
    }

}
