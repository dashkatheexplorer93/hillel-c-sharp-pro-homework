namespace Hw6;

internal class StagePlay(string title, string author, string genre, int year) : IDisposable
{
    public void DisplayInfo() =>
        Console.WriteLine($"Title: {title}\nAuthor: {author}\nGenre: {genre}\nYear: {year}\n");
    
    public void Dispose() =>
        Console.WriteLine($"Stage play {title} has been disposed\n");

    ~StagePlay() =>
        Console.WriteLine($"Stage play {title} has been destroyed\n");
}