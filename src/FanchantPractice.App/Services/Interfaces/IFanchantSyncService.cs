using FanchantPractice.App.Models;

namespace FanchantPractice.App.Services.Interfaces;

public interface IFanchantSyncService
{
    FanchantSegment? GetActiveSegment(IEnumerable<FanchantSegment> segments, long positionMs);
}
