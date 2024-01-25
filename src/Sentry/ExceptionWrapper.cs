using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sentry
{
    internal class ExceptionWrapper : IException
    {
        private readonly Exception _exception;

        internal Exception WrappedException => _exception;
        public ExceptionWrapper(Exception ex)
        {
            _exception = ex;
        }
        public IDictionary Data => _exception.Data;

        public string? StackTrace => _exception.StackTrace;

        public Exception? InnerException => _exception.InnerException;

        public string Message => _exception.Message;

        public string? HelpLink => _exception.HelpLink;
    }
}
