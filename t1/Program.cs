Console.Write("Количество рандомных чисел: ");
int val = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[val];
int max = 0;
int min = 0;
 
Console.WriteLine(); 
 
for (int i = 0; i < val; i++)
{
      Console.Write("Число {0}: ", i + 1);
      arr[i] = Convert.ToInt32(Console.ReadLine());
}
 
 
min = arr[0];
max = arr[0];
for (int i = 1; i < val; i++)
{
       if (arr[i] < min)
            min = arr[i];
       if (arr[i] > max)
            max = arr[i];
}
 
Console.WriteLine(); 
Console.WriteLine("Max: " + max);
Console.WriteLine("Min: " + min);
 
Console.ReadLine();