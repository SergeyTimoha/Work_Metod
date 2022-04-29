Console.Clear();
int F1 = int.Parse(Console.ReadLine());
int F2 = int.Parse(Console.ReadLine());
int N = int.Parse(Console.ReadLine());

GetFibanacci(F1, F2, N);

void GetFibanacci(int F1, int F2, int N)
{
    if (N >= 1)
        Console.Write(F1 + " ");
    if (N >= 2)
        Console.Write(F2 + " ");
    for (int i = 0; i < N - 2; i++)
    {
        F2 += F1;
        F1 = F2 - F1;
        Console.Write(F2 + " ");
    }

}
Console.WriteLine();