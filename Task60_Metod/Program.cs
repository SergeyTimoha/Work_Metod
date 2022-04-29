// Копировать массив
using System;
using System.Linq;
Console.Clear();
Console.WriteLine("Введите размер массив");
/*int i = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Convert.ToString(i,2));*/

int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size].Select(x => new Random().Next(20)).ToArray();
Console.WriteLine(String.Join(" , ",array));

int[] copyArray(int[] arr)
{
    int[] newArray = new int[arr.Length];
    for (int i = 0; i < newArray.Length; i++)
    {
        newArray[i] = arr[i];
    
    }
    return newArray;
}
Console.WriteLine(string.Join(" , ", copyArray(array) ));
