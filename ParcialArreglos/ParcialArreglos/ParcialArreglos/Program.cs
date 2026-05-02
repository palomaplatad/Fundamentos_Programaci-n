// See https://aka.ms/new-console-template for more information
int fil = 0;
int col = 0;
Console.WriteLine("Ingrese el número de filas");
fil = int.Parse (Console.ReadLine());
Console.WriteLine("Ingrese el número de colmunas");
col = int.Parse (Console.ReadLine());
if (fil >= 2 || fil >= 10 || col <= 10 || col >= 2)
{
    int[,] mat = new int[fil, col];
    for (int i = 0; i < mat.GetLength(0); i++)
    {
        for (int j = 0; j < mat.GetLength(1); j++)
        {
            Console.WriteLine($"Ingrese el numero de la poscion [{i},{j}]");
            mat[i,j]= int.Parse (Console.ReadLine());
        }
    }
    for (int i = 0; i < mat.GetLength(0); i++)
    {
        for (int j = 0;j < mat.GetLength(1); j++)
        {
            Console.Write(mat[i,j]+" | ");
        }

    }
    
    int sumapares = 0;
    int sumaimpares = 0;
    int cantnegativos = 0;
    int cantceros = 0;
    int suma;
    int promedio;

    for (int i = 0; i < mat.GetLength(0); i++)
    {
        for (int j = 0; j < mat.GetLength(1); j++)
        {
           suma =  mat[i, j] % 2 == 0 ? sumapares += mat[i, j] : sumaimpares += mat[i, j];
            if (mat[i, j] == 0)
            {
                cantceros++;
            }
            else if (mat[i, j] < 0)
            {
                cantnegativos++;
            }
        }
    }
    promedio = (sumapares + sumaimpares) / (fil * col);
    Console.WriteLine($"La suma de los números pares es {sumapares}");
    Console.WriteLine($"La suma de los números impares es {sumaimpares}");
    Console.WriteLine($"La cantidad de ceros es {cantceros}");
    Console.WriteLine($"La cantidad de números negativos es {cantnegativos}");
    Console.WriteLine($"El promedio general es {promedio}");



}
else
{
    Console.WriteLine("Numero fuera de rango vuelva a intentar");
}
