// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.WriteLine ("Считаем сумму цифр в предложенном числе.");
Console.WriteLine ("Введите число - ");
string input = Console.ReadLine();
int[] array = new int [input.Length];
int sum = 0;

for (int i = 0; i < array.Length; i++)
{
    array [i] = input [i] - 48; // Странно, но работает Оо. 
}

PrintArray (array);
Console.WriteLine ();

for (int i = 0; i < array.Length; i++)
{
    sum = sum + ((array [i]));
}

Console.WriteLine (sum);

void PrintArray(int[] colPA)
{
    int count = colPA.Length;
    int pos = 0;
    while (pos < count)
    {
        Console.Write(colPA[pos] + " "); pos++;
    }
}