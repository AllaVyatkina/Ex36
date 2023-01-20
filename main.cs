using System;

class Program {
  public static void Main (string[] args) {
    int[] CreateRandomArray(int N, int start, int end)
{
    int[] RandomArray = new int[N];
    for (int i = 0; i < N; i++)
    {
        RandomArray[i] = new Random().Next(start, end);
    }
    return RandomArray;
}
    void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
int[] tripleArray = CreateRandomArray(4,100, 1000);
int ruslt = 0;
    for(int i=0; i < tripleArray.Length; i++ )
    {
      if (i % 2 != 0) 
        {
        ruslt += tripleArray[i];
        }
    }
ShowArray(tripleArray);
Console.WriteLine(ruslt);
  }
}