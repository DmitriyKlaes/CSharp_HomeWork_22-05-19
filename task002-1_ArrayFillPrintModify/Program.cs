/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

void PrintArray(int[] array)
{
    Console.WriteLine($"Массив из {array.Length} случайных элементов получился таким:");
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}
int[] DinArray()
{
    int[] array = new int[1];
    Console.WriteLine($"Введите любое количество чисел (для завершения повторно нажмите Enter): \n[]");
    try
    {
        for (int i = 0; i < array.Length + 1; i++)
        {
            array[i] = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            string stringarray = string.Join(", ", array);
            Console.Write($"Введите любое количество чисел (для подтверждения повторно нажмите Enter): \n[{stringarray}] ");
            Array.Resize(ref array, array.Length + 1);
        }
    }
    catch
    {
        Array.Resize(ref array, array.Length - 1);
        Console.WriteLine($"У вас получился массив из {array.Length} элементов!");
    }
    return array;
}
void RandomArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 100);
    }
}
Console.Write("Желаете воспользоваться динамической системой наполнения массива? (Y / N): ");
var input = Console.ReadKey();
switch (input.Key)
{
    case ConsoleKey.Y:
    {
        Console.WriteLine();
        int[] array = DinArray();
        break;
    }
    case ConsoleKey.N:
    {
        Console.WriteLine();
        Console.WriteLine("Новый массив будет заполнен случайными числами от 1 до 99!");
        Console.WriteLine("Введите размер массива (значение 0 задаст случайный размер от 2 до 15 элементов):");
        int length = Convert.ToInt32(Console.ReadLine());
        if (length != 0)
        {
            int[] array = new int[length];
            RandomArray(array);
            PrintArray(array);
        }
        else
        {
            int randomLength = new Random().Next(2,16);
            int[] array = new int[randomLength];
            RandomArray(array);
            PrintArray(array);
        }
        break;
    }
    default:
    {
        Console.WriteLine();
        Console.WriteLine($"Неверный ввод, попробуйте еще раз!");
        break;
    }
}