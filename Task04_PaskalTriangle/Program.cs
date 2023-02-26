// Показать треугольник Паскаля *Сделать вывод в виде равнобедренного треугольника
int ReadInt(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}
void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j <= i; j++)
        {
            if (j==0 || j==i)
            array[i, j] = 1;
            else array[i,j]=array[i-1,j-1]+array[i-1,j];
        }
    }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j <= i; j++)
        {
            Console.Write($"{array[i, j]}");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    Console.WriteLine();
}

int linesNumber=ReadInt("Введите колличество строк");
int[,] pascalNumbers=new int[linesNumber,linesNumber];
FillArray (pascalNumbers);
Console.WriteLine("Треугольник Паскаля для указанного колличества строк:");
Console.WriteLine();
PrintArray (pascalNumbers);
