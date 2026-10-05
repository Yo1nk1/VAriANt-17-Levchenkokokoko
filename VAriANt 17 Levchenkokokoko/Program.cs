using System;

class Program
{
    static void Main()
    {
        Car car = new Car();
        car.Marka = "Жигули";
        car.Nomer = "Т144ТО";
        car.Probeg = 10350;

        car.Show();

        double sr = car.SredProbeg(2);
        Console.WriteLine($"Среднегодовой пробег при возрасте 2 года = {sr} км.");

        Console.ReadKey();
    }
}

class Car
{
    // поля
    private string marka;
    private string nomer;
    private int probeg;

    // свойства – доступ к полям класса
    public string Marka
    {
        get { return marka; }
        set { marka = value; }
    }

    public string Nomer
    {
        get { return nomer; }
        set { nomer = value; }
    }

    public int Probeg
    {
        get { return probeg; }
        set { if (value > 0) probeg = value; }
    }

    // конструкторы
    public Car() // конструктор по умолчанию
    {
        Marka = "";
        Nomer = "";
        Probeg = 0;
    }

    public Car(string m, string n, int p)
    {
        Marka = m;
        Nomer = n;
        Probeg = p;
    }

    // вычислительные методы
    public double SredProbeg(int vozrast) // средний пробег за год
    {
        if (vozrast <= 0) return 0;
        return (double)probeg / vozrast;
    }

    public void Show() // показать данные об автомобиле
    {
        Console.WriteLine($"Автомобиль: марка = {Marka}, номер = {Nomer}, пробег = {Probeg} км");
    }
}