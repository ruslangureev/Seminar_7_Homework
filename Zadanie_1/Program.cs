double[,] GetArray(int m, int n)
{
    double[,] result = new double[m, n];
    for (int i = 0; i < m; ++i)
    {
        for (int j = 0; j < n; ++j)
        {
            result[i, j] = new Random().Next(0, 20) + new Random().NextDouble();
        }
    }
    return result;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); ++i)
    {
        for (int j = 0; j < array.GetLength(1); ++j)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Zadaite razmer massiva: ");

Console.WriteLine("Vvedite kolichestvo strok");
int rows = int.Parse(Console.ReadLine());

Console.WriteLine("Vvedite kolichestvo stolbcov");
int columns = int.Parse(Console.ReadLine());

double[,] array = GetArray(rows, columns);
Console.WriteLine();

for (int i = 0; i < array.GetLength(0); ++i)
    {
        for (int j = 0; j < array.GetLength(1); ++j)
        {
            array[i,j] = Math.Round(array[i,j], 1);
        }
        
    }

PrintArray(array);
Console.WriteLine(); 