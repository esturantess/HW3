// Задача: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//
// A (3,6,8); B (2,1,-7), -> 15.84
//
// A (7,-5, 0); B (1,-1,9) -> 11.53

System.Console.Write("Введите координату X первой точки: ");
int firstNumX = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите координату Y первой точки: ");
int firstNumY = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите координату Z первой точки: ");
int firstNumZ = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите координату X второй точки: ");
int secondNumX = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите координату Y второй точки: ");
int secondNumY = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите координату Z второй точки: ");
int secondNumZ = Convert.ToInt32(Console.ReadLine());

double distance = Math.Sqrt(Math.Pow((secondNumX - firstNumX), 2) + Math.Pow((secondNumY - firstNumY), 2) + Math.Pow((secondNumZ - firstNumZ), 2));

System.Console.WriteLine($"Расстояние между точками A({firstNumX},{firstNumY},{firstNumZ}) и B({secondNumX},{secondNumY},{secondNumZ}) в 3D пространстве: {distance}");