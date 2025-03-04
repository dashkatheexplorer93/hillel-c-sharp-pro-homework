namespace Hw3;

internal class MyArray(int[] array) : IOutput, IMath, ISort
{
    public void Show() => Console.WriteLine(string.Join(", ", array));

    public void Show(string info)
    {
        Console.WriteLine(info);
        Show();
    }

    public int Max() => array.Max();

    public int Min() => array.Min();

    public float Avg() => (float)array.Average();

    public bool Search(int valueToSearch) => array.Contains(valueToSearch);

    public void SortAsc() => Array.Sort(array);
    
    public void SortDesc()
    {
        SortAsc();
        Array.Reverse(array);
    }

    public void SortByParam(bool isAsc)
    {
        if (isAsc)
            SortAsc();
        else
            SortDesc();
    }
}