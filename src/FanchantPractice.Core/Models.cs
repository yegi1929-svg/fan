namespace FanchantPractice.Core;
public sealed record Member(int Id, string Name, string Color);
public sealed record Song(int Id, string Title, string Album, DateOnly ReleaseDate, string? SourceUrl);
public sealed record Concert(int Id, string Title, DateOnly? Date, string Venue, string Status);
public sealed record FanchantSegment(long StartMs, long EndMs, string Text, string Type, int? MemberId = null);
public static class PilotData
{
    public static readonly Song Body = new(1, "BODY", "Switch On", new DateOnly(2024, 3, 11), "https://www.aroundusent.com/staffNotice/detail/68?category_idx=&page=1");
    public static readonly IReadOnlyList<Member> Members = [new(1, "윤두준", "#5794FF"), new(2, "양요섭", "#FFD75A"), new(3, "이기광", "#57C785"), new(4, "손동운", "#A87CFF")];
}
