//Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.

using System;

void recit(int M, int N)
{
   if (M == N)
      Console.WriteLine(M);
   else
      if (M > N)
   {
      Console.Write($"{N}, ");
      recit(M, N + 1);
   }
   else
   {
      Console.Write($"{M}, ");
      recit(M + 1, N);
   }
}

int M = 10;
int N = 5;
recit(M, N);