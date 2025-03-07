namespace Hw4;

internal class Employee(string name, string position, decimal salary)
{
    public readonly string Name = name;
    public string _position = position;
    private decimal _salary = salary;

    public static decimal operator +(Employee employee, decimal amount) => employee._salary += amount;

    public static decimal operator -(Employee employee, decimal amount) => employee._salary -= amount;

    public static bool operator ==(Employee employee1, Employee employee2) => employee1._salary == employee2._salary;

    public static bool operator !=(Employee employee1, Employee employee2) => employee1._salary != employee2._salary;
    
    public static bool operator >(Employee employee1, Employee employee2) => employee1._salary > employee2._salary;
    
    public static bool operator <(Employee employee1, Employee employee2) => employee1._salary < employee2._salary;
    
    public override bool Equals(object obj)
    {
        if (obj is Employee employee)
        {
            return _salary == employee._salary;
        }
        return false;
    }
    
    public override int GetHashCode() => _salary.GetHashCode();
    
    public override string ToString() => $"Employee's name: {Name}, position: {_position}, salary: {_salary:C}";
}