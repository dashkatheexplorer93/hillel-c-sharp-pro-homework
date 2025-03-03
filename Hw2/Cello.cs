namespace Hw2;

internal class Cello : MusicalInstrument
{
    public Cello() : base(
        nameof(Cello),
        "string",
        "wood",
        4)
    {
    }

    public override void Sound()
    {
        Console.WriteLine($"{nameof(Cello)} has a deep, rich sound");
    }

    public override void History()
    {
        Console.WriteLine($"{nameof(Cello)} appeared in the 16th century as part of the violin family");
    }
}