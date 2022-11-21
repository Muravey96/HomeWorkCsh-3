/* Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да */

Console.Write("Введите пятизначное число: ");
string userNum = Console.ReadLine() ?? "";

void CheckingNum(string userNum)
{
  if (userNum[0]==userNum[4] && userNum[1]==userNum[3])
  {
    Console.WriteLine($"{userNum} - да");
  }
  else Console.WriteLine($"{userNum} - нет");
}

if (userNum!.Length == 5)
{
  CheckingNum(userNum);
}
else Console.WriteLine($"Непятизначное число");