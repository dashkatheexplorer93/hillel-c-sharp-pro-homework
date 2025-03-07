namespace Hw4;

internal class CreditCard(string cardNumber, DateTime expiryDate, int cvc, decimal balance)
{
    public readonly string CardNumber = cardNumber;
    public readonly DateTime ExpiryDate = expiryDate; 
    private readonly int _cvc = cvc;
    private decimal _balance = balance;
    
    public static decimal operator +(CreditCard card, decimal amount) => card._balance +=amount;
    
    public static decimal operator -(CreditCard card, decimal amount) => card._balance -= amount;
    
    public static bool operator ==(CreditCard card1, CreditCard card2) => card1._cvc == card2._cvc;
    
    public static bool operator !=(CreditCard card1, CreditCard card2) => card1._cvc != card2._cvc;
    
    public static bool operator >(CreditCard card1, CreditCard card2) => card1._balance > card2._balance;
    
    public static bool operator <(CreditCard card1, CreditCard card2) => card1._balance < card2._balance;
    
    public override bool Equals(object obj)
    {
        if (obj is CreditCard card)
        {
            return _balance == card._balance;
        }
        return false;
    }
    
    public override int GetHashCode() => _balance.GetHashCode();
    
    public override string ToString() => $"Card number: {CardNumber}, expiry date: {ExpiryDate:MM/yyyy}, cvc: ***, balance: {_balance:C}";
}