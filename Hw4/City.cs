namespace Hw4;

internal class City(string name, int population)
{
    public readonly string Name = name;
    public int Population = population;
    
    public static long operator +(City city, int amount) => city.Population += amount;
    
    public static long operator -(City city, int amount) => city.Population -= amount;
    
    public static bool operator ==(City city1, City city2) => city1.Population == city2.Population;

    public static bool operator !=(City city1, City city2) => city1.Population != city2.Population;
    
    public static bool operator >(City city1, City city2) => city1.Population > city2.Population;

    public static bool operator <(City city1, City city2) => city1.Population < city2.Population;
    
    public override bool Equals(object obj)
    {
        if (obj is City city)
        {
            return Population == city.Population;
        }
        return false;
    }
    
    public override int GetHashCode() => Population.GetHashCode();
    
    public override string ToString() => $"City's name: {Name}, population: {Population:N0}";
}