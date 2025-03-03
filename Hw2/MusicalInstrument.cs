namespace Hw2;

internal abstract class MusicalInstrument
{
    private readonly string _name;
    private readonly string _type;
    private readonly int _numberOfStrings;
    private readonly string _material;

    protected MusicalInstrument(string name, string type, string material, int numberOfStrings)
    {
        _name = name;
        _type = type;
        _numberOfStrings = numberOfStrings;
        _material = material;
    }

    public abstract void Sound();
    
    public void Show() => Console.WriteLine($"The name of this musical instrument is: {_name}");
    
    public void Desc() => Console.WriteLine($"{_name} is a {_type} musical instrument made of {_material} with {_numberOfStrings} strings");
    
    public abstract void History(); 
}