using FanchantPractice.App.Data;
using FanchantPractice.App.Models;
using FanchantPractice.App.Services.Interfaces;

namespace FanchantPractice.App.Services;

public sealed class DatabaseInitializer(AppDatabase database) : IDatabaseInitializer
{
    public async Task InitializeAsync()
    {
        await database.InitializeAsync();
        if (await database.Connection.Table<Artist>().CountAsync() > 0) return;

        var artist = new Artist { Name = "Sample Artist", OfficialColor = "#A9A9A9" };
        await database.Connection.InsertAsync(artist);
        await database.Connection.InsertAllAsync(new[]
        {
            new Member { ArtistId = artist.Id, Name = "윤두준", SymbolColor = "#5794FF", SortOrder = 1 },
            new Member { ArtistId = artist.Id, Name = "양요섭", SymbolColor = "#FFD75A", SortOrder = 2 },
            new Member { ArtistId = artist.Id, Name = "이기광", SymbolColor = "#57C785", SortOrder = 3 },
            new Member { ArtistId = artist.Id, Name = "손동운", SymbolColor = "#A87CFF", SortOrder = 4 }
        });
    }
}
