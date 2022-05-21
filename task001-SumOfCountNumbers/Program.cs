/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

int SumNumbersOf(int number)
{
    int result = 0;
    for (int i = number; i > 0; i /= 10 )
    {
        result = i % 10 + result;
    }
    return result;
}
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = SumNumbersOf(number);
Console.WriteLine($"Сумма цифр в числе {number} равняется {result}");