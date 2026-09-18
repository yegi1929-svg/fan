using FanchantPractice.App.Models;
using SQLite;

namespace FanchantPractice.App.Data;

public sealed class AppDatabase
{
    private SQLiteAsyncConnection? _connection;

    public SQLiteAsyncConnection Connection => _connection ??= new SQLiteAsyncConnection(
        Path.Combine(FileSystem.AppDataDirectory, "fanchant-practice.db3"),
        SQLiteOpenFlags.ReadWrite | SQLiteOpenFlags.Create | SQLiteOpenFlags.SharedCache);

    public async Task InitializeAsync()
    {
        await Connection.CreateTablesAsync(CreateFlags.None,
            typeof(Artist), typeof(Member), typeof(Song), typeof(Fanchant),
            typeof(FanchantSegment), typeof(Concert), typeof(SetlistItem),
            typeof(Favorite), typeof(PracticeRecord), typeof(AudioConnection),
            typeof(AppSetting));
    }
}
