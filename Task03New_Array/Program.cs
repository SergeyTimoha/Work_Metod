using System;
// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
/*int[] myArray;
myArray = new int[10];
myArray[1] = 3;
myArray[0] = 7;
int a = myArray[0];
Console.WriteLine(myArray.Length);*/
Console.Clear();
Console.Write("Введите количество элементов массива:\t");
int elementsCount = Convert.ToInt32(Console.ReadLine()); 
int[] myArray = new int[elementsCount];
for (int i = 0; i < myArray.Length; i++)
{
    Console.Write($"\nВведите число под индексом {i} : " );
    myArray[i] = Convert.ToInt32(Console.ReadLine()); 
}

Console.WriteLine("\nВывод массива");

 
//int[] myArray = { 2, 3, 3, 3, };

 Console.WriteLine("\nВывод массива: ");
for (int i = myArray.Length - 1; i >= 0; i--)
{
    Console.WriteLine(myArray[i]);
}
