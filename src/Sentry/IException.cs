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
    }
}
