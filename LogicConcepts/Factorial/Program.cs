using Shared;
using System.Net.Http.Headers;

var answer = string.Empty;
var options = new List<string> { "s", "n" };

do
{
    var n = ConsoleExtension.GetInt("ingrese numero: ");
    var factorial = Mymath.factorial(n);

    Console.WriteLine($"{n}!={factorial:N0}");
    Console.WriteLine("");

    do
    {
        answer = ConsoleExtension.GetValidOptionts("¿Deseas continuar [S]i, [N]o?: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));


} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));
