
using Shared;

do
{
    Console.WriteLine("Ingrese 3 números diferentes...");
    var a = ConsoleExtension.GetInt("ingrese el primer número: ");
    var b = ConsoleExtension.GetInt("ingrese el segundo número: ");
    if (a == b)
    {
        Console.WriteLine("Deben ser diferentes, Vuelva a empezar...");
        Console.WriteLine("");
        continue;
    }

    var c = ConsoleExtension.GetInt("ingrese el tercer número: ");
    if (a == c || b==c)
    {
        Console.WriteLine("Deben ser diferentes, Vuelva a empezar...");
        Console.WriteLine("");
        continue;
    }
    
    Console.WriteLine("");

    if (a>b && a > c) 
    {
        if (b>c)
        {
            Console.WriteLine($"El mayor es {a}, el medio es {b}, el menor es {c}");
            Console.WriteLine("");
        }
        else
        {
            Console.WriteLine($"El mayor es {a}, el medio es {c}, el menor es {b}");
            Console.WriteLine("");
        }
    }
    else if (b>a && b>c)
    {
        if(a>c)
        {
            Console.WriteLine($"El mayor es {b}, el medio es {a}, el menor es {c}");
            Console.WriteLine("");
        }
        else
        {
            Console.WriteLine($"El mayor es {b}, el medio es {c}, el menor es {a}");
            Console.WriteLine("");
        }
    }
    else
    {
        if (a > b)
        {
            Console.WriteLine($"El mayor es {c}, el medio es {a}, el menor es {b}");
            Console.WriteLine("");
        }
        else
        {
            Console.WriteLine($"El mayor es {c}, el medio es {b}, el menor es {a}");
            Console.WriteLine("");
        }
    }

}while(true);