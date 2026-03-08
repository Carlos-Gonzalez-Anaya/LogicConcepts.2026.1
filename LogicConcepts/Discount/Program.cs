using Shared;

var answer = string.Empty;
var options = new List<string> { "s", "n" };

do
{
    var NumberDesk = ConsoleExtension.GetInt("Ingrese el numero de escritorios a comprar: ");
    var ValueDesk = 650000;
    var ValueToPay = 0;

    if (NumberDesk < 4)
    {
        ValueToPay = (int)(ValueDesk * NumberDesk * 0.9f);
        Console.WriteLine($"Numero de escritorios: {NumberDesk}");
        Console.WriteLine($"El valor a pagar es: {ValueToPay:C2}");
    }
    else if (NumberDesk < 10)
    {
        ValueToPay = (int)(ValueDesk * NumberDesk *0.8f);
        Console.WriteLine($"Numero de escritorios: {NumberDesk}");
        Console.WriteLine($"El valor a pagar es: {ValueToPay:C2}");
    }
    else
    {
        ValueToPay = (int)(ValueDesk * NumberDesk * 0.6f);
        Console.WriteLine($"Numero de escritorios: {NumberDesk}");
        Console.WriteLine($"El valor a pagar es: {ValueToPay:C2}");
    }

    do
    {
        answer = ConsoleExtension.GetValidOptionts("¿Deseas continuar [S]i, [N]o?: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));


} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));
