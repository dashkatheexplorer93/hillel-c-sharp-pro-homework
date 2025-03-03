namespace Hw2;

internal class Violin : MusicalInstrument
{
    public Violin() : base(
        nameof(Violin),
        "string",
        "wood",
        4)
    {
    }

    public override void Sound()
    {
        Console.WriteLine($"{nameof(Violin)} produces a melodious, piercing sound");
    }

    public override void History()
    {
        Console.WriteLine($"{nameof(Violin)} was created in the 16th century in Italy");
    }
}