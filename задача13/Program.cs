// Показать таблицу квадратов чисел от 1 до N
Console.WriteLine("Введите N");
int N = Convert.ToInt32(Console.ReadLine());
int i=1;
while (i<=N)
{
    Double n2 = Math.Pow(i,2);
    Console.Write(i);
    Console.Write("|");
    Console.WriteLine(n2);
    i++;
}