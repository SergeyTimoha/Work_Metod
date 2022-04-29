/* задача 37: Найдите произведение пар чисел в одномерном массиве,
Парой считается первый и последний элемент, второй и предпоследний и т.д. Результат 
запишите в новом массиве.*/
using System;
using System.Linq;
Console.Clear();
Console.WriteLine("Введите размер массив");

int[] array2 = new int[int.Parse(Console.ReadLine())].Select(x => x = new Random().Next(0,10)).ToArray();
Console.WriteLine(String.Join(" , ", array2));

Console.WriteLine($"Произведение пар равно {String.Join(" , ", GetMult(array2))}");
int[] GetMult(int[] array2)
{
    int[] mult = new int[array2.Length / 2];
    for (int i = 0; i < array2.Length / 2; i++)
    {
        mult[i] = array2[i]*array2[array2.Length - 1 - i];

    }
    return mult;
}
