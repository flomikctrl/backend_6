using MemesApi.Models;
namespace MemesApi.Data;

public static class MemesStore {
    private static int _nextId = 4;
    public static List<Meme> Memes { get; } = new() {

        new Meme { Id = 1, Title = "Discipline",
        Category = "Mentality", Rating = 5,
        AddedAt = new DateTime(2026, 4, 11, 0, 0, 0, DateTimeKind.Utc) },
        new Meme { Id = 2, Title = "Добро пожаловать в русский ресейл",
        Category = "Авито", Rating = 5,
        AddedAt = new DateTime(2026, 4, 12, 0, 0, 0, DateTimeKind.Utc)},
        new Meme { Id = 3, Title = "ХамМмМам",
        Category = "Бурмалда", Rating = 5,
        AddedAt = new DateTime(2026, 4, 13, 0, 0, 0, DateTimeKind.Utc)},
    };
    public static int NextId() => _nextId++;
}