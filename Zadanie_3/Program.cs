int[,] FillArray(int rows, int columns, int min, int max)
{
    int[,] a = new int[rows, columns];
    for (int i = 0; i < a.GetLength(0); ++i)
    {
        for (int j = 0; j < a.GetLength(1); ++j)
        {
            a[i,j] = new Random().Next(min, max);
        
        }
    }
    return a;
}

void PrintArray(int[,] b)
{
    for (int i = 0; i < b.GetLength(0); ++i)
    {
        for (int j = 0; j < b.GetLength(1); ++j)
        {
            Console.Write(b[i,j] + " ");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine());

Console.Write("Введите минимальное значение диапазона генерации чисел: ");
int minDiap = int.Parse(Console.ReadLine());

Console.Write("Введите максимальное значение диапазона генерации чисел: ");
int maxDiap = int.Parse(Console.ReadLine());

while (minDiap > maxDiap)
{
    Console.Write("Вы ввели некорректный диапазон генерации чисел");
    Console.Write("Введите минимальное значение диапазона генерации чисел: ");
    minDiap = int.Parse(Console.ReadLine());
    Console.Write("Введите максимальное значение диапазона генерации чисел: ");
    maxDiap = int.Parse(Console.ReadLine());
}

int[,] array = FillArray(rows, columns, minDiap, maxDiap);
Console.WriteLine("Двумерный массив из случайных чисел: ");
PrintArray(array);
Console.Write("Среднее арифметическое каждого столбца:");

for (int j = 0; j < array.GetLength(1); ++j)
{
    double sum = 0;
    double arithmetic = 0;
    for (int i = 0; i < array.GetLength(0); ++i)
    {
        sum += array[i,j];
    }
    arithmetic = Math.Round(sum / array.GetLength(0), 2);
    Console.Write($"{arithmetic}" + " ");
}
