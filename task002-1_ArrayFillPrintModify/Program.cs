/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

/*
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
*/
void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
}
void DinArray(int[] array)
{
    try
    {
        for (int i = 0; i < array.Length + 1; i++)
        {
            Console.Write(new string(' ', Console.BufferWidth));
            array[i] = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            string stringarray = string.Join(", ", array);
            Console.WriteLine(stringarray);
            Array.Resize(ref array, array.Length + 1);
        }
    }
    catch
    {
        Array.Resize(ref array, array.Length - 1);
    }
}
void RandomArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 100);
    }
}
//int[] array = new int[];
System.Console.WriteLine("Введите размер массива (значение 0 задаст случайную размерность массива от 1 до 15): ");
int length = Convert.ToInt32(Console.ReadLine());
if (length == 0)
{
    int[] array = new int[length];
}


//PrintArray(array);

/*
string arraystring = string.Join(", ", array);
System.Console.WriteLine(arraystring);*/
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