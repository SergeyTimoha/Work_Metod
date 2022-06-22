Console.Clear();
Console.Write("Введите количество элементов массива: ");
int elementCount = Convert.ToInt32(Console.ReadLine());
int[] Array = new int[elementCount];
for (int i = 0; i < Array.Length; i++)
{
    Array[i] =  new Random().Next(1,100);
}
Console.WriteLine("Вывод массива");
Console.WriteLine(String.Join("  " , Array));
Console.WriteLine($"Максимальное число массива:  {Array.Max()}");
Console.WriteLine($"Максимальное число массива:  {Array.Min()}");
Привет
