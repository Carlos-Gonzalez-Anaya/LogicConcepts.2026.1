using Shared;

var answer = string.Empty;
var options = new List<string> { "s", "n" };

do
{
    var n = ConsoleExtension.GetInt("Cauntos terminos deseas: ");
    var x = ConsoleExtension.GetDouble("digita el valor de x: ");
    var taylor = Taylor(x, n);
    Console.WriteLine($"f({x})={taylor:N5}");

    do
    {
        answer = ConsoleExtension.GetValidOptionts("¿Deseas continuar [S]i, [N]o?: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));


} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));

double Taylor(double x, int n)
{
    double sum = 0;
    for (int i = 0; i < n; i++)
    {
        sum += Math.Pow(-1,i)*(Math.Pow(x, i) / Mymath.factorial(i));
    }
    return sum;
}