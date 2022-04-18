using System;

/*int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return  result;
}*/
//             0    1   2   3   4   5   6   7   8
int[] array = {11, 21, 18, 31, 41, 15, 61, 17, 18, 19};
int n = array.Length;
int find = 18;
int index = 0;

while(index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }    

    index++;
}
//array[3] = 5;
  


//Console.WriteLine(array[3]);