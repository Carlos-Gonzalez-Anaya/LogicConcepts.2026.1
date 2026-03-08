using Shared;

do
{
    var n1 = ConsoleExtension.GetInt("Ingrese el primer número: ");
    var n2 = ConsoleExtension.GetInt("Ingrese el segundo número: ");
    Console.WriteLine("");

    if (n1 < n2)
    {
        Console.WriteLine("Por favor que el primer número sea mayor que sel segundo");
        Console.WriteLine("");
        continue;
    }

    if (n1%n2==0)
    {
        Console.WriteLine($"El número: {n2}, es multiplo de: {n1}");
    }
    else
    {
        Console.WriteLine($"El número: {n2}, no es multiplo de: {n1}");
    }

} while (true);

