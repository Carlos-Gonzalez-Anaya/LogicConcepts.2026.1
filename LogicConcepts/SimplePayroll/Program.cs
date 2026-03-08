using Shared;

var answer = string.Empty;
var options = new List<string> { "s", "n" };

do
{
    var name = ConsoleExtension.GetString("Ingrese nombre:........................: ");
    var WorkHours = ConsoleExtension.GetFloat("Ingrese número de horas trabajadas.....: ");
    var HourValue = ConsoleExtension.GetDecimal("Ingrese Valor hora.....................: ");
    var salaryMinimum = ConsoleExtension.GetDecimal("Ingrese valor de salario minimo mensual: ");
    Console.WriteLine("");

    var salary = (decimal)WorkHours * HourValue;
    if (salary < salaryMinimum)
    {
        Console.WriteLine($"Nombre.................................: {name}");
        Console.WriteLine($"Salario................................: {salaryMinimum:C2}");
    }
    else
    {
        Console.WriteLine($"Nombre.................................: {name}");
        Console.WriteLine($"Salario................................: {salary:C2}");
    }
    Console.WriteLine("");
    do
    {
        answer = ConsoleExtension.GetValidOptionts("¿Deseas continuar [S]i, [N]o?: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));


} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));


