namespace Hw8;

public static class BarberShop
{
    private static readonly SemaphoreSlim BarberSleeping = new(0);
    private static readonly SemaphoreSlim SeatsAccess = new(1);
    private static readonly Queue<int> WaitingCustomers = new();
    private static bool _isBarberBusy;
    private const int WaitingChairs = 3;
    private static readonly Mutex ConsoleMutex = new();
    
    public static void BarberWork()
    {
        while (true)
        {
            ConsoleMutex.WaitOne();
            Console.WriteLine("Barber is sleeping...");
            ConsoleMutex.ReleaseMutex();
            
            BarberSleeping.Wait();

            SeatsAccess.Wait();
            var customerNumber = WaitingCustomers.Dequeue();
            _isBarberBusy = true;
            SeatsAccess.Release();
            
            ConsoleMutex.WaitOne();
            Console.WriteLine($"Barber was awaken and started cutting hair of Customer {customerNumber}...");
            ConsoleMutex.ReleaseMutex();

            Thread.Sleep(4000);
            
            SeatsAccess.Wait();
            _isBarberBusy = false;
            SeatsAccess.Release();

            ConsoleMutex.WaitOne();
            Console.WriteLine($"Barber finished cutting hair of Customer {customerNumber}...");
            ConsoleMutex.ReleaseMutex();
        }
    }
    
    public static void CustomerVisitBarberShop(int customerNumber)
    {
        Console.WriteLine($"Customer {customerNumber} entering the barber shop...");
        SeatsAccess.Wait();
        
        if (!_isBarberBusy && WaitingCustomers.Count == 0)
        {
            _isBarberBusy = true;
            SeatsAccess.Release();
            
            ConsoleMutex.WaitOne();
            Console.WriteLine($"Customer {customerNumber} getting a haircut without waiting...");
            ConsoleMutex.ReleaseMutex();
            
            WaitingCustomers.Enqueue(customerNumber);
            BarberSleeping.Release();
            return;
        }
        
        if (WaitingCustomers.Count < WaitingChairs)
        {
            WaitingCustomers.Enqueue(customerNumber);
            ConsoleMutex.WaitOne();
            Console.WriteLine($"Customer {customerNumber} waiting for a haircut...");
            ConsoleMutex.ReleaseMutex();
            SeatsAccess.Release();

            BarberSleeping.Release();
        }
        else
        {
            ConsoleMutex.WaitOne();
            Console.WriteLine($"Customer {customerNumber} leaving the barber shop due to no available waiting chairs...");
            ConsoleMutex.ReleaseMutex();
            SeatsAccess.Release();
        }
    }
}