
namespace ConsoleApp10;

class Counter
{
    public int data;
    public int min;
    public int max;

    public Counter(int min, int max)
    {
        data = min;
        this.min = min;
        this.max = max;
    }

    public void Increment()
    {
        if (data == max)
        {
            data = min;
            return;
        }
        data++;
    }

    public void Decrement()
    {
        if (data == min)
        {
            data = max;
            return;
        }
        data--;
    }

    public int CurrentData() => data;
}

class Pointer
{
    public int x;
    public int y;

    public Pointer(int x,int y)
    {
        this.x = x;
        this.y = y;
    }

    public void ShowData()
    {
        Console.Write("X: ");
        Console.WriteLine(x);
        Console.Write("Y: ");
        Console.WriteLine(y);
    }
    
    public void ShowCordinate()
    {
        Console.WriteLine(x);
        Console.Write(";");
        Console.WriteLine(y);
    }


}



class Program
{
    static void Main()
    {
        Counter c = new Counter(50, 90);
        Pointer p = new Pointer(50, 90);

        c.Increment();
        c.Decrement();
        Console.WriteLine(c.CurrentData());
    }



}
