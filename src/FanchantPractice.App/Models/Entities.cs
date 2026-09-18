using SQLite;

namespace FanchantPractice.App.Models;

public sealed class Artist
{
    [PrimaryKey, AutoIncrement] public int Id { get; set; }
    [NotNull] public string Name { get; set; } = string.Empty;
    public string? OfficialColor { get; set; }
}

public sealed class Member
{
    [PrimaryKey, AutoIncrement] public int Id { get; set; }
    [Indexed] public int ArtistId { get; set; }
    [NotNull] public string Name { get; set; } = string.Empty;
    [NotNull] public string SymbolColor { get; set; } = string.Empty;
    public string SymbolType { get; set; } = "Heart";
    public int SortOrder { get; set; }
    public bool IsActive { get; set; } = true;
}

public sealed class Song
{
    [PrimaryKey, AutoIncrement] public int Id { get; set; }
    [Indexed] public int ArtistId { get; set; }
    [NotNull] public string Title { get; set; } = string.Empty;
    public string? AlbumName { get; set; }
    public DateTime? ReleaseDate { get; set; }
    public long? DurationMs { get; set; }
    public string SearchText { get; set; } = string.Empty;
}

public sealed class Fanchant
{
    [PrimaryKey, AutoIncrement] public int Id { get; set; }
    [Unique, Indexed] public int SongId { get; set; }
    [NotNull] public string Title { get; set; } = string.Empty;
    public string? Description { get; set; }
    public int VerificationStatus { get; set; }
    public string? SourceName { get; set; }
    public string? SourceUrl { get; set; }
    public DateTime UpdatedAt { get; set; }
}

public sealed class FanchantSegment
{
    [PrimaryKey, AutoIncrement] public int Id { get; set; }
    [Indexed] public int FanchantId { get; set; }
    public int? MemberId { get; set; }
    [Indexed] public long StartTimeMs { get; set; }
    public long EndTimeMs { get; set; }
    [NotNull] public string Text { get; set; } = string.Empty;
    public int SegmentType { get; set; }
    public int SortOrder { get; set; }
}

public sealed class Concert
{
    [PrimaryKey, AutoIncrement] public int Id { get; set; }
    [Indexed] public int ArtistId { get; set; }
    [NotNull] public string Title { get; set; } = string.Empty;
    public string? Venue { get; set; }
    public DateTime? ConcertDate { get; set; }
    public int SetlistStatus { get; set; }
}

public sealed class SetlistItem
{
    [PrimaryKey, AutoIncrement] public int Id { get; set; }
    [Indexed] public int ConcertId { get; set; }
    [Indexed] public int SongId { get; set; }
    public int Sequence { get; set; }
    public string? Note { get; set; }
}

public sealed class Favorite
{
    [PrimaryKey, AutoIncrement] public int Id { get; set; }
    [Unique, Indexed] public int SongId { get; set; }
    public DateTime CreatedAt { get; set; }
}

public sealed class PracticeRecord
{
    [PrimaryKey, AutoIncrement] public int Id { get; set; }
    [Indexed] public int SongId { get; set; }
    public DateTime StartedAt { get; set; }
    public DateTime? EndedAt { get; set; }
    public int PracticeDurationSec { get; set; }
    public long LastPositionMs { get; set; }
    public int RepeatCount { get; set; }
    public bool Completed { get; set; }
}

public sealed class AudioConnection
{
    [PrimaryKey, AutoIncrement] public int Id { get; set; }
    [Unique, Indexed] public int SongId { get; set; }
    [NotNull] public string DisplayName { get; set; } = string.Empty;
    [NotNull] public string LocalReference { get; set; } = string.Empty;
    public long? DurationMs { get; set; }
    public DateTime UpdatedAt { get; set; }
}

public sealed class AppSetting
{
    [PrimaryKey] public string Key { get; set; } = string.Empty;
    [NotNull] public string Value { get; set; } = string.Empty;
    public DateTime UpdatedAt { get; set; }
}
