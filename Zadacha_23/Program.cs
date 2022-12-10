// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Введите число N: ");
int finish = Convert.ToInt32(Console.ReadLine()); // Идем от 1 до N
for (int start = 1; start <= finish;  start++) // точка начала = 1; условие выхода из цикла; увеличение счетчика
{
    Console.Write(Math.Pow(start,3) + " "); // Math.Pow(число, степень)
}


