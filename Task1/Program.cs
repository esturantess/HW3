// Задача: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//
// 14212 -> нет
//
// 12821 -> да
//
// 23432 -> да

System.Console.WriteLine("Введите пятизначное число: ");
string? number = Console.ReadLine();
if (number!.Length == 5)
{
    if (number[0] == number[4] && number[1] == number[3])
    {
        System.Console.WriteLine($"Число {number} является палиндромом.");
    }
    else
    {
        System.Console.WriteLine($"Число {number} не является палиндромом.");
    }
}
else
{
    System.Console.WriteLine($"Введенное число не является пятизначным.");
}

// Второй способ

// System.Console.WriteLine("Введите пятизначное число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number > 9999 && number < 100000)
// {   if (number / 10000 == number % 10 && ((number / 1000) % 10) == ((number % 100) / 10))
//     {
//         System.Console.WriteLine($"Число {number} является палиндромом.");
//     }
//     else
//     {
//         System.Console.WriteLine($"Число {number} не является палиндромом.");
//     }
// }
// else
// {
//     System.Console.WriteLine($"Введенное число не является пятизначным.");
// }
