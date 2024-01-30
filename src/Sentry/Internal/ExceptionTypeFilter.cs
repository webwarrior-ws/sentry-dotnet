using Sentry.Extensibility;

namespace Sentry.Internal;

internal class ExceptionTypeFilter<TException> : IExceptionFilter where TException : Exception
{
    private readonly Type _filteredType = typeof(TException);
    public bool Filter(IException ex) => ex.IsOfType(_filteredType);
}
