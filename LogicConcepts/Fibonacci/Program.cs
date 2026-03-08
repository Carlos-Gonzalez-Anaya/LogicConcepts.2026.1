using Shared;
using System.Runtime.Serialization;

var answer = string.Empty;
var options = new List<string> { "s", "n" };

do
{
    var n = ConsoleExtension.GetInt("Cuantos terminos quieres; ");
    double a = 0;
    double b = 1;

    Console.Write($"{a}\t{b}\t");
    for (int i = 2; i < n; i++)
    {
        
        double c =a+b;
        Console.Write($"{c}\t");
        a =b;
        b=c;
        ;
    }
    Console.WriteLine("");


    do
    {
        answer = ConsoleExtension.GetValidOptionts("¿Deseas continuar [S]i, [N]o?: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));


} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));
