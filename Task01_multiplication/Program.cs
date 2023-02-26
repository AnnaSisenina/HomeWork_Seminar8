// Найти произведение двух матриц
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
int [,] arraysMultiplication (int [,]firstArray, int [,]secondArray)
{
    int [,] arraysMultiplication=new int [firstArray.GetLength(0),secondArray.GetLength(1)];
    for (int i = 0; i < firstArray.GetLength(0); i++)
    {
        for (int j = 0; j<secondArray.GetLength(1); j++)
        {
            for (int k = 0; k < firstArray.GetLength(1); k++)
            {
                arraysMultiplication[i,j]+=firstArray[i,k]*secondArray[k,j];
            }
            
        }
    }
    return arraysMultiplication;
}

int line = ReadInt("Введите колличество строк массива: ");
int column = ReadInt("Введите колличество столбцов массивв: ");
int[,] numbers1 = new int[line, column];
int[,] numbers2 = new int[column, line];
FillArray(numbers1, 0, 3);
FillArray(numbers2, 0, 3);
PrintArray(numbers1);
PrintArray(numbers2);
int[,] numbersMultiplication = arraysMultiplication(numbers1, numbers2);
Console.WriteLine("Результат произведения двух матриц:");
PrintArray(numbersMultiplication);