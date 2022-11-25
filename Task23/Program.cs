/*  Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */ 
 

Console.Clear();
int N = GetNumFromUser ("Введите количество возводимых в куб чисел: ");
int cubeN = GetCubeN (N);

Console.WriteLine($"{N} ->{cubeN}");

//-------Функция вывода числа с консоли

int GetNumFromUser(string message)
{
    while(true)
    {
        Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out int userNumber));
           return userNumber;
    }
}

// -------- Функция возведения в куб

int GetCubeN (int num)
{
    int cube = 0;
    for(int i=1; i<=num; i++ )
    {
       cube = (int)(Math.Pow(i, 3));
    }
    return cube;
}