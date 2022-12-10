// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите число: ");
string? number = Console.ReadLine();

void CheckingNumber(string number)
{
  if (number[0]==number[4] || number[1]==number[3]){ //если 1-я цифра = 5-й цифре и 2-я цифра = 4-й цифре то
    Console.WriteLine("Число является палиндромом: " + number + " -> Да!"); // число Палиндром!
  }
  else Console.WriteLine("Число является палиндромом: " + number + " -> Нет!");
}

if (number!.Length == 5)
{
  CheckingNumber(number);
}
else Console.WriteLine("Число не является палиндромом");