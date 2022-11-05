// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


public class Singleton
{
    private static Singleton _instance; //must be private and static prop

    private Singleton() //must be private or protected constructor
    {
    }

    public static Singleton Instance 
    {
        get
        {
            if (_instance == null)
                _instance = new Singleton();

            return _instance;
        }
    }

    public void DoSingletonOperation()//At least have one non-static public method for a singleton operation.
    {
        Console.WriteLine("singleton operation");
    }
}