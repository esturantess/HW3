// Задача: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//
// A (3,6,8); B (2,1,-7), -> 15.84
//
// A (7,-5, 0); B (1,-1,9) -> 11.53

// System.Console.Write("Введите координату X первой точки: ");
// int firstNumX = Convert.ToInt32(Console.ReadLine());

// System.Console.Write("Введите координату Y первой точки: ");
// int firstNumY = Convert.ToInt32(Console.ReadLine());

// System.Console.Write("Введите координату Z первой точки: ");
// int firstNumZ = Convert.ToInt32(Console.ReadLine());

// System.Console.Write("Введите координату X второй точки: ");
// int secondNumX = Convert.ToInt32(Console.ReadLine());

// System.Console.Write("Введите координату Y второй точки: ");
// int secondNumY = Convert.ToInt32(Console.ReadLine());

// System.Console.Write("Введите координату Z второй точки: ");
// int secondNumZ = Convert.ToInt32(Console.ReadLine());

// double distance = Math.Sqrt(Math.Pow((secondNumX - firstNumX), 2) + Math.Pow((secondNumY - firstNumY), 2) + Math.Pow((secondNumZ - firstNumZ), 2));

// System.Console.WriteLine($"Расстояние между точками A({firstNumX},{firstNumY},{firstNumZ}) и B({secondNumX},{secondNumY},{secondNumZ}) в 3D пространстве: {distance}");

// Второй способ

double[] coordsA = new double[3];
double[] coordsB = new double[3];

System.Console.Write("Введите координату X первой точки: ");
coordsA[0] = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите координату Y первой точки: ");
coordsA[1] = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите координату Z первой точки: ");
coordsA[2] = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите координату X второй точки: ");
coordsB[0] = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите координату Y второй точки: ");
coordsB[1] = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите координату Z второй точки: ");
coordsB[2] = Convert.ToInt32(Console.ReadLine());

double distance = Math.Round((Math.Sqrt(Math.Pow((coordsB[0] - coordsA[0]), 2) + Math.Pow((coordsB[1] - coordsA[1]), 2) + Math.Pow((coordsB[2] - coordsA[2]), 2))), 2);

System.Console.WriteLine($"Расстояние между точками А({coordsA[0]}, {coordsA[1]}, {coordsA[2]}) и B({coordsB[0]}, {coordsB[1]}, {coordsB[2]}) в 3D пространстве: {distance}");