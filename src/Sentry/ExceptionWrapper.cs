using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

        public bool IsOfType(Type exceptionType)
        {
            return exceptionType.IsInstanceOfType(_exception);
        }

        public bool IsAggregate => _exception is AggregateException;

        public IReadOnlyCollection<Exception> FlattenedInnerExceptions
        {
            get
            {
                if(_exception is AggregateException aggregate)
                    return aggregate.Flatten().InnerExceptions;
                else
                    return Array.Empty<Exception>();
            }
        }

        override public bool Equals(object? other)
        {
            if(other is ExceptionWrapper wrapper)
                return _exception.Equals(wrapper._exception);
            else
                return false;
        }

        override public int GetHashCode()
        {
            return _exception.GetHashCode();
        }
    }
}
