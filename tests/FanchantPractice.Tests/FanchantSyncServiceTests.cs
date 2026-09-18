using FanchantPractice.Core;

namespace FanchantPractice.Tests;

public sealed class FanchantSyncServiceTests
{
    private readonly FanchantSyncService _service = new();
    private readonly FanchantSegment[] _segments =
    [
        new(1000, 2000, "첫 구간", "General"),
        new(2500, 3000, "두 번째 구간", "MemberName", 1)
    ];

    [Fact]
    public void ReturnsSegmentAtInclusiveStart()
    {
        Assert.Equal("첫 구간", _service.GetActiveSegment(_segments, 1000)?.Text);
    }

    [Fact]
    public void ExcludesSegmentAtEnd()
    {
        Assert.Null(_service.GetActiveSegment(_segments, 2000));
    }

    [Fact]
    public void ReturnsNullBetweenSegments()
    {
        Assert.Null(_service.GetActiveSegment(_segments, 2250));
    }
}
