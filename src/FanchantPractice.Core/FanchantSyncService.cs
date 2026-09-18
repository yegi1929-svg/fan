namespace FanchantPractice.Core;
public sealed class FanchantSyncService
{
    public FanchantSegment? GetActiveSegment(IEnumerable<FanchantSegment> segments, long positionMs) => segments.FirstOrDefault(segment => positionMs >= segment.StartMs && positionMs < segment.EndMs);
}
