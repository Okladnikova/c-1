//найти кубы чисел от 1 до N
Console.WriteLine("Введите N");
int N = Convert.ToInt32(Console.ReadLine());
int i=1;
while (i<=N)
{
    Double n3 = Math.Pow(i,3);
    Console.Write(i);
    Console.Write("|");
    Console.WriteLine(n3);
    i++;
    }
