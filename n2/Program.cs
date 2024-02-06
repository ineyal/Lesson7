//Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

using System;

int Akk(int n, int m)
{
   if (n == 0)
      return (m + 1);
   else
      if (m == 0)
      return (Akk(n - 1, 1));
   else
      return (Akk(n - 1, Akk(n, m - 1)));
}

//Не до конца понял формулировку задания. Допустим, числа вводятся с клавиатуры построчно
Console.Write("m = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("n = ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Akk(n, m));

