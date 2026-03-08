using Shared;
using System.ComponentModel.Design;


var answer = string.Empty;
var options = new List<string> { "s", "n" };

do
{
    var n = ConsoleExtension.GetInt("Ingrese el numero a descomponer: ");
    List<int> Lista = Mymath.listPrimes(n);
    int i = 0;

    Console.Write($"{n} = ");

    while (n > 1)
    {
        if (n % Lista[i] == 0)
        {
            Console.Write($"{Lista[i]}");
            n = n / Lista[i];

            if (n > 1)
            {
                Console.Write(" x ");
            }
        }
        else
        {
            i++;
        }
    }
    Console.WriteLine("");

    do
    {
        answer = ConsoleExtension.GetValidOptionts("¿Deseas continuar [S]i, [N]o?: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));


} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));