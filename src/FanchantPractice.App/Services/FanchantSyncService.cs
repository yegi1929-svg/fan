using FanchantPractice.App.Models;
using FanchantPractice.App.Services.Interfaces;

namespace FanchantPractice.App.Services;

public sealed class FanchantSyncService : IFanchantSyncService
{
    public FanchantSegment? GetActiveSegment(IEnumerable<FanchantSegment> segments, long positionMs) =>
        segments.FirstOrDefault(x => positionMs >= x.StartTimeMs && positionMs < x.EndTimeMs);
}
