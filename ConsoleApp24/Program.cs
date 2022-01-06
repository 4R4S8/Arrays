using System.Linq;

Console.Write("Enter The Length of the Array: ");
int x = int.Parse(Console.ReadLine());
int y = 0;
int[] number=new int[x];
Console.WriteLine();
for (int j = 0; j < number.Length; j++)
{
    Console.Write("Enter The Number: ");
    y = int.Parse(Console.ReadLine());
    number[j] = y;
}
//Console.WriteLine();
//foreach (int  g in number)
//{
//    Console.WriteLine(" {0} ",g);

//}

//Console.WriteLine();

//Console.WriteLine(number.Max());
//Console.WriteLine(number.Min());
//Console.WriteLine(number.Sum());
//Console.WriteLine(number.Count());
//Array.Sort(number);
