namespace Sentry.Tests.Internals;

[UsesVerify]
public partial class MainExceptionProcessorTests
{
    [Fact]
    public Task CreateSentryException_Aggregate()
    {
        var sut = _fixture.GetSut();
        var aggregateException = BuildAggregateException();

        var sentryException = sut.CreateSentryExceptions(new ExceptionWrapper(aggregateException));

        return Verify(sentryException);
    }
}
