namespace Hw2;

internal class Ukulele : MusicalInstrument
{
    public Ukulele() : base(
        nameof(Ukulele),
        "string",
        "wood",
        4)
    {
    }

    public override void Sound()
    {
        Console.WriteLine($"{nameof(Ukulele)} sounds soft and cheerful");
    }

    public override void History()
    {
        Console.WriteLine($"{nameof(Ukulele)} originates from Hawaii and was created in the 19th century");
    }
}