namespace Hw2;

internal class Trombone : MusicalInstrument
{
    public Trombone() : base(
        name: nameof(Trombone),
        type: "wind",
        material: "brass",
        numberOfStrings: 0)
    {
    }

    public override void Sound()
    {
        Console.WriteLine($"{nameof(Trombone)} has a loud, rich sound with characteristic glissando");
    }

    public override void History()
    {
        Console.WriteLine($"{nameof(Trombone)} appeared in the 15th century in Europe");
    }
}