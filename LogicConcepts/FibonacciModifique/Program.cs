using Shared;

var answer = string.Empty;
var options = new List<string> { "s", "n" };

do
{
    var n = ConsoleExtension.GetInt("Cuantos terminos quieres; ");
    double a = 0;
    double b = 1;
    double c = 2;
    double suma = 0;

    Console.Write($"{a}\t{b}\t{c}\t");
    for (int i = 3; i < n; i++)
    {

        double d = b + c+a;
        a = b;
        b = c;
        c = d;
        suma = suma+d;
        Console.Write($"{d}\t");

    }
    Console.WriteLine("");
    Console.Write($"la sumatoria es: {suma}");
    Console.WriteLine("");

    do
    {
        answer = ConsoleExtension.GetValidOptionts("¿Deseas continuar [S]i, [N]o?: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));


} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));