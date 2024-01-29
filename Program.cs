// See https://aka.ms/new-console-template for more information
class Program
{
    static void Main()
    {   

        Console.WriteLine("choose an option");
        Console.WriteLine("+");
        Console.WriteLine("-");
        Console.WriteLine("*");
        Console.WriteLine("/");
        string option = Console.ReadLine();
        Console.WriteLine("enter the value of x");
        //string s =
        int x = int.Parse(Console.ReadLine());
        Console.WriteLine("enter the value of x");
        int y =int.Parse(Console.ReadLine());
        if(option=="+")
        {
            Console.WriteLine(x+y);
        }
         if(option=="-")
        {
            Console.WriteLine(x-y);
        }
         if(option=="*")
        {
            Console.WriteLine(x*y);
        }
         if(option=="/")
        {
            Console.WriteLine(x/y);
        }
    }
}