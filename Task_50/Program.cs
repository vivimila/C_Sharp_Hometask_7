// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и 
// возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1, 7 -> такого элемента в массиве нет

int[,] CreateMatrixRndInt(int row, int col, int min, int max)

{
    int[,] matrix = new int[row, col];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;

}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4},");
            else Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("]");
    }

    Console.Write("Введите № строки: ");
    int NumRow = Convert.ToInt32(Console.ReadLine()) - 1;
    Console.Write("Введите № столбца: ");
    int NumCol = Convert.ToInt32(Console.ReadLine()) - 1;
    if ((NumRow > matrix.GetLength(0)) && (NumCol > matrix.GetLength(1)))
        Console.Write("Такого значения не существует");

    else
    {
        Console.WriteLine($"Значение элемента массива: {matrix[NumRow, NumCol]}");
    }

}

int[,] Array2D = CreateMatrixRndInt(3, 4, -20, 20);
PrintMatrix(Array2D);





