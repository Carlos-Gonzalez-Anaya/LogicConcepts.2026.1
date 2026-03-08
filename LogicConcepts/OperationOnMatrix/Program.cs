//30 OPERACIONES EN UNA MATRIZ
//Construir un programa que cree una matriz cuadrada de orden N. La matriz se debe llenar con la siguiente formula
//Celda[i][j] = (i + 1) - j . Luego debe mostrar la matriz como quedo llena y acto seguido, mostrar: la sumatoria de los
//elementos de la matriz, el mayor elemento de la matriz y el menor elemento de la matriz30 OPERACIONES EN UNA MATRIZ



using Shared;

var answer = string.Empty;
var options = new List<string> { "s", "n" };

do
{
    var n = ConsoleExtension.GetInt("Ingrese el orden de la matriz: ");
    int menor = 9999;
    int mayor = -9999;
    int suma = 0;

    int[,] matriz = new int[n,n];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matriz[i, j] = (i + 1) - j;
            Console.Write(matriz[i, j] + "\t");
            
            if (matriz[i,j]<menor)
            {
                menor = matriz[i,j];
            }
            if (matriz[i,j]>mayor)
            {
                mayor = matriz[i,j];
            }
            suma = matriz[i,j]+suma;
        }
        Console.WriteLine();
    }

    Console.WriteLine(matriz);
    Console.WriteLine($"La sumatoria es :{suma} ");
    Console.WriteLine($"el valor maximo es : {mayor}");
    Console.WriteLine($"el valor minimo es : {menor}" );

    do
    {
        answer = ConsoleExtension.GetValidOptionts("¿Deseas continuar [S]i, [N]o?: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));


} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));