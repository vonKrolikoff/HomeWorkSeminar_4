// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. Вывод сделать отдельным методом.
int[] array = new int [8];
FillArray (array);
PrintArray (array);

void FillArray(int[] colFA)
{
    int length = colFA.Length;
    int index = 0;
    while (index < length)
    {
        colFA[index] = new Random().Next(0, 99); index++;
    }
}

void PrintArray(int[] colPA)
{
    int count = colPA.Length;
    int pos = 0;
    while (pos < count)
    {
        Console.Write(colPA[pos] + " "); pos++;
    }
}