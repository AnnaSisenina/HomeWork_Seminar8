// В двумерном массиве целых чисел. Удалить строку и столбец, на пересечении которых расположен наименьший элемент.
int ReadInt(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}
void FillArray(int[,] array, int from, int to)
{
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(from, to);
        }
    }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    Console.WriteLine();
}
int [] MinimumLineColumnIndexArray(int[,] array)
{
    int minimum = array[0, 0];
    int [] minLineColumnIndex =new int [2];
    minLineColumnIndex [0]= 0;
    minLineColumnIndex [1]= 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < minimum)
            {
                minimum = array[i, j];
                minLineColumnIndex [0]= i;
                minLineColumnIndex [1] = j;
            }
        }
    }
    return minLineColumnIndex;
}

int[,] ArrayWithoutMinimum(int[,] array, int lineIndex, int columnIndex)
{
    int[,] newArray = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    {
        for (int i = 0; i < lineIndex; i++)
        {
            for (int j = 0; j < columnIndex; j++)
            {
                newArray[i, j] = array[i, j];
            }
            for (int j = columnIndex+1; j < array.GetLength(1); j++)
            {
                newArray[i, j - 1] = array[i, j];
            }
        }
        for (int i = lineIndex + 1; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < columnIndex; j++)
            {
                newArray[i - 1, j] = array[i, j];
            }
            for (int j = columnIndex+1; j < array.GetLength(1); j++)
            {
                newArray[i - 1, j - 1] = array[i, j];
            }
        }
    }
    return newArray;
}

int line = ReadInt("Введите колличество строк массива: ");
int column = ReadInt("Введите колличество столбцов массивв: ");
int[,] numbers = new int[line, column];
FillArray(numbers, 0, 10);
PrintArray(numbers);
int [] index = MinimumLineColumnIndexArray(numbers);
int[,] numbersOutMin=ArrayWithoutMinimum(numbers, index[0], index [1]);
PrintArray(numbersOutMin);

