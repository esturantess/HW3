// Задача: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// System.Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// if (number > 0)
//     for (int i = 1; i <= number; i++)
//     {
//         System.Console.Write($"{Math.Pow(i, 3)} ");
//     }
// else
// {
//     System.Console.WriteLine("Введённое число меньше 1.");
// }

// Второй способ

System.Console.WriteLine("Введите число: ");

int size = Convert.ToInt32(Console.ReadLine());
if (size > 0)
{
    int[] array = new int[size];
    int index = 0;
    while (index < size)
    {
        array[index] = index + 1;
        System.Console.Write($"{Math.Pow(array[index], 3)} ");
        index++;
    }
}
else
{
    System.Console.WriteLine($"Введённое число меньше 1.");
}