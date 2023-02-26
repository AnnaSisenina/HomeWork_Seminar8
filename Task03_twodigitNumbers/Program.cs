// Сформировать трехмерный массив не повторяющимися двузначными числами показать его построчно на экран выводя индексы соответствующего элемента

void FillArray(int[,,] array, int from, int to)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                    array[i, j, k] = from;
                    from++;
            }

        }
    }
}
void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]} ({i},{j},{k})  ");
            }
           Console.WriteLine();
        }
    }
    Console.WriteLine();
    Console.WriteLine();
}

int[,,] numbers = new int[10, 3, 3];
FillArray(numbers, 10, 99);
PrintArray(numbers);