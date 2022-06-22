// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.WriteLine ("Возводим число А в степень В");

int a = Input ("Введите первое число -  ");
int b = Input ("Введите второе число (должно быть натуральным) -  ");
int c = a; int count = 1;

if (b>0)
{
    while (count < b)
    {
        a=a*c; count++;
    }
    Console.WriteLine("Ответ: " + a);
} 
else Console.WriteLine("Вы ввели неправильное число");

int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}