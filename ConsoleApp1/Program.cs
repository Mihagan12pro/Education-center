class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(typeof(Foo).BaseType == typeof(Foo));
    }
}

class Foo
{

}