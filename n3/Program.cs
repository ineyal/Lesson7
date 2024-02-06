//Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

using System;

void rev(int[] arr)
{
   if (arr.Length == 0)
      return;

   Console.Write(arr[arr.Length - 1] + " ");
   Array.Resize(ref arr, arr.Length - 1);
   rev(arr);
}

//Допустим, дан массив из 10 случайных чисел 
int[] array = new int[10];
Random rand = new Random();
for (int i = 0; i < array.Length; i++)
   array[i] = rand.Next(100);

//Console.WriteLine("{0}", string.Join(" ", array));

rev(array);
Console.WriteLine();