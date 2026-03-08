using Shared;

var answer = string.Empty;
var options = new List<string> { "s", "n" };

do
{
    var n = ConsoleExtension.GetInt("cuantos numeros deseas: ");
    int sum = 0;

    for (int i = 1; i<=n; i++)
    {
        Console.Write($"{i}\t");
        sum+=i;
    }
    Console.WriteLine();
    Console.WriteLine($"La suma es....{sum,20:N0}");
    Console.WriteLine($"El promedio es{sum/n,20:N2}");


    do
    {
        answer = ConsoleExtension.GetValidOptionts("¿Deseas continuar [S]i, [N]o?: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));


} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));
