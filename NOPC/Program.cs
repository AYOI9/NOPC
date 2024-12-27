

class ParentClass
{
    public double x;
    public double y;
}

class ChildClass : ParentClass
{
    public double z;

    public double Calculate()
    {
        double maxXY = Math.Max(x, y);
        return Math.Pow(z, 3) + maxXY;
    }
}

class Program
{
    static void Main()
    {
        ChildClass obj = new ChildClass();
        obj.x = 3;
        obj.y = 4; 
        obj.z = 5; 

        double result = obj.Calculate();
        Console.WriteLine("Результат = " + result);
    }
}
