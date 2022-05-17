// Показать четные числа от 1 до N
Console.WriteLine("Ввведите число верхней границы отрезка: N");
int N = Convert.ToInt32(Console.ReadLine());
int i=1;
while (i<N)
{
 if (i%2==0)
{
        Console.WriteLine(i);
}
i++;
}
