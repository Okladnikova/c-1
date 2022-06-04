// Найти сумму чисел от 1 до N
Console.WriteLine("Введите N");
int N = Convert.ToInt32(Console.ReadLine());
int i=1;
int sum=0;
while (i<=N)
{
sum = sum+i;
i++;
}
Console.WriteLine(sum);