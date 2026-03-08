using Shared;


var answer = string.Empty;
var options = new List<string> { "s", "n" };

do
{
    var n = ConsoleExtension.GetInt("Ingresa numero: ");
    var isPrime = Mymath.IsPrime(n);
    Console.WriteLine($"El número: {n} {(isPrime ? "SI":"NO")} es primo");

    do
    {
        answer = ConsoleExtension.GetValidOptionts("¿Deseas continuar [S]i, [N]o?: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));


} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));

