// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.WriteLine ("Считаем сумму цифр в предложенном числе.");
Console.WriteLine ("Введите число - ");
string input = Console.ReadLine();
int sum = 0;

for (int i = 0; i < input.Length; i++)
{
    sum = sum + ((input [i]) - 48);
    // Console.WriteLine (input [i] + "   " + sum);  !!! я не понимаю откуда берется 48 !!!
}

Console.WriteLine (sum);