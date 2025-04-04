using Hw8;

var barberThread = new Thread(BarberShop.BarberWork);
barberThread.Start();

var customerNumber = 1;

while (true)
{
    Thread.Sleep(new Random().Next(500, 5000));
    new Thread(() => BarberShop.CustomerVisitBarberShop(customerNumber++)).Start();
}