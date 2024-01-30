using System;
using System.Collections;

namespace Sentry
{
    /// <summary>
    /// TODO: write doc
    /// </summary>
    public interface IException
    {
        /// <summary>
        /// TODO: write doc
        /// </summary>
        public IDictionary Data { get; }

        /// <summary>
        /// TODO: write doc
        /// </summary>
        public string? StackTrace { get; }

        /// <summary>
        /// TODO: write doc
        /// </summary>
        public Exception? InnerException { get; }

        /// <summary>
        /// TODO: write doc
        /// </summary>
        public string Message { get; }

        /// <summary>
        /// TODO: write doc
        /// </summary>
        public string? HelpLink { get; }

        /// <summary>
        /// Return true if exception should be considered of given type
        /// </summary>
        public bool IsOfType(Type exceptionType);

        /// <summary>
        /// Return true if this is aggeregate exception. See FlattenedInnerExceptions property.
        /// </summary>
        public bool IsAggregate { get; }

        /// <summary>
        /// If this is aggeregate exception, return all inner exceptions flattened into one collection.
        /// </summary>
        public IReadOnlyCollection<Exception> FlattenedInnerExceptions { get; }

    }
}
