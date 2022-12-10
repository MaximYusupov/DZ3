// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// // A(x,y,z)

// AB = √(x2 - x1)^2 + (y2 - y1)^2 + (z2 - z1)^2

Console.Write("Введите координату х1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());
// Math.Sqrt(число) => Math.Sqrt(25) => 5
// Math.Pow (2, 3) => 8 = 2 * 2 * 2
double d = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2)); // Math.Pow(число, степень)
// Math.Round(число, количество знаков) 
Console.WriteLine($"Расстояние между 2 точками: {x1},{y1},{z1}  {x2},{y2},{z2} = {Math.Round(d,3)}"); // Интерполяция