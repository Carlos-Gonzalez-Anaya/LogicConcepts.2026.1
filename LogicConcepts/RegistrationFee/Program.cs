using Shared;

var answer = string.Empty;
var options = new List<string> { "s", "n" };

do
{
    var credits = ConsoleExtension.GetInt("Ingrese el numero de Creditos a matricular: ");
    var valueCredits = ConsoleExtension.GetInt("Ingrese el valor del credito: ");
    var stratum = ConsoleExtension.GetInt("Ingrese el estrato del estudiante: ");
    Console.WriteLine("");
    var discount = 0.0;
    var subsidy = 0;
    var totalValueCredits = 0;
    var TuitionFee = 0;



    if (stratum==1)
    {
        discount = (1 - 0.8);
        subsidy = 200000;
    }
    else if(stratum==2)
    {
        discount = (1 - 0.5);
        subsidy = 100000;
    }
    else
    {
        discount = (1 - 0.3);
        subsidy = 0;
    }

    if (credits <= 20)
    {
        TuitionFee = (int)(valueCredits * credits * discount);
    }
    else
    {
        totalValueCredits = valueCredits * (credits - 20) * 2;
        TuitionFee = (int)((int)(20 * valueCredits + totalValueCredits) * discount);
    }



    Console.WriteLine($"Numero de creditos: {credits}");
    Console.WriteLine($"Valor credito: {valueCredits:C2}");
    Console.WriteLine($"Estrato del estudiante: {stratum}");
    Console.WriteLine($"Costo de matricula: {TuitionFee:C2}");
    Console.WriteLine($"Valor del subsidio: {subsidy:C2}");
    Console.WriteLine("");

    do
    {
        answer = ConsoleExtension.GetValidOptionts("¿Deseas continuar [S]i, [N]o?: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));


} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));
