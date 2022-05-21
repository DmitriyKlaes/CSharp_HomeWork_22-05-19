/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

int PowerOf(int number, int power)
{
    int result = 1;
    for (int i = 0; i < power; i++)
    {
        result = result * number;
    }
    return result;
}
System.Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите степень числа: ");
int power = Convert.ToInt32(Console.ReadLine());
int result = PowerOf(number, power);
System.Console.WriteLine($"{number}^{power} = {result}");