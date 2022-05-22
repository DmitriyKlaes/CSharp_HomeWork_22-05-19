/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

void FillArray(int[] array, string arg)
{
    if (arg.ToLower() == "y")
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = new Random().Next(1, 100);
        }
    }
    else if (arg.ToLower() == "n")
    {
        Console.WriteLine("Введите 8 чисел через Enter: ");
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Convert.ToInt32(Console.ReadLine());
        }
    }
    else
    {
        Console.WriteLine("Неверный выбор, попробуйте ещё раз!");
    }
}
void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
        {
            Console.Write(",");
        }
    }
    Console.Write("]");
}
int[] array = new int[8];
Console.WriteLine("Выбрать случайные 8 чисел от 1 до 99 (ввелите Y или N)?: ");
string choice = Console.ReadLine()!;
FillArray(array, choice);
if (choice.ToLower() == "n" || choice.ToLower() == "y")
{
    PrintArray(array);
}
/*
else
{
    return;
}
*/

/*
while (choice.ToLower() == "y")
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 100);
    }
    break;
}
while (choice.ToLower() == "n")
{
    Console.WriteLine("Введите 9 случайных чисел через (Пробел):");
    string[] arrayNumber = (Console.ReadLine()!.Split(' '));
    for (int i = 0; i < arrayNumber.Length; i++)
    {
        array[i] = int.Parse(arrayNumber[i]);
    }
    break;
}
int max = Max(Max(array[0], array[1], array[2]),
              Max(array[3], array[4], array[5]),
              Max(array[6], array[7], array[8]));
string str = string.Join(", ", array);
Console.WriteLine($"Максимальным из чисел ({str}) является {max}");
*/